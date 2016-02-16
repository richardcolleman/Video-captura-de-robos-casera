using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using System.Net;
using AForge;
using AForge.Video;
using AForge.Imaging;
using AForge.Video.VFW;
using AForge.Vision.Motion;
using AForge.Video.DirectShow;
using NReco.VideoConverter;
using Nemiro.OAuth;
using Nemiro.OAuth.LoginForms;

namespace Video_Captura_Robos_ESPOL
{
    public partial class frm_principal : Form
    {
        private FilterInfoCollection Disp_Video=null;
        private bool Dispositivos_Disponibles = false;
        private VideoCaptureDevice FuenteDeVideo = null;
        private MotionDetector detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());
        private Single motionAlarmLevel = 0.015F;
        private Bitmap foto=null,video=null;
        private bool IsRecording = false;
        private AVIWriter writer = new AVIWriter();
        private MailMessage mail;
        private Attachment Data;
        private DateTime time_stop = DateTime.MinValue;
        int timeLeft;
        string PhotoFileName = string.Empty;
        string VideoFileName = string.Empty;
        string UploadFileName = string.Empty;
        public frm_principal()
        {
            InitializeComponent();
        }


        private void Carga_Dispositivos()
        {
            int i;
            for ( i = 0; i < Disp_Video.Count; i++)
            {
                cmb_dispositivos.Items.Add(Disp_Video[i].Name.ToString());
            }
            cmb_dispositivos.Text = cmb_dispositivos.Items[0].ToString();
            txtMensajes.Text += i.ToString() + " dispositivos encontrados!" + "\r\n";
        }

        private void Busca_Dispositivos()
        {
            Disp_Video = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (Disp_Video.Count == 0)
                Dispositivos_Disponibles = false;
            else
            {
                Dispositivos_Disponibles = true;
                Carga_Dispositivos();
                btn_iniciar.Enabled = true;
            }
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            Busca_Dispositivos();
            cmb_dispositivos.SelectedIndex = 1;
            timer1.Start();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_registroCtasUsuario frmCtasUsuario = new frm_registroCtasUsuario();
            frmCtasUsuario.Show();
        }

        private void correosNotificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_registroCorreosNotif frmRegCorreos = new frm_registroCorreosNotif();
            frmRegCorreos.Show();
        }

        private void envíoDeCorreosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_EnvioCorreos frmEnvioCorreos = new frm_EnvioCorreos();
            frmEnvioCorreos.Show();
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {

            //entra aqui mientras no se haya detectado movimiento

            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            video = (Bitmap)eventArgs.Frame.Clone();
            if(detector != null)
            {
                Single motionLevel = detector.ProcessFrame(Imagen);

                if(motionLevel > motionAlarmLevel)
                {
                    //"Si hay Movimiento";
                    if (!IsRecording && timeLeft<=0)
                    {
                        //txtMensajes.Text += "Inicio de grabación...! " + "\r\n";
                        time_stop = DateTime.Now.AddSeconds(10);
                        IsRecording = true;
                        VideoFileName = "C:/Users/Alex/Desktop/DEMO/video_" + DateTime.Now.ToShortDateString().Replace("/", "-") + DateTime.Now.ToShortTimeString().Replace(":", "_") + ".avi";
                        writer.Open(VideoFileName, video.Width, video.Height);
                        //FileWriter.Open("D:/video.avi", 320, 240, 25, VideoCodec.MPEG4, 5000000);
                    }
                    
                }
                else{
                    //"No hay Movimiento";
                    foto = (Bitmap)eventArgs.Frame.Clone();
                }

                pcb_video.Image = Imagen;
                
            
           }
        }

        private void GetAccesToken()
        {
            var login = new DropboxLogin("967so10b2m8tutu", "knm65ro9x474cdq");
            login.Owner = this;
            login.ShowDialog();

            if (login.IsSuccessfully)
            {
                Properties.Settings.Default.AccessToken = login.AccessToken.Value;
                Properties.Settings.Default.Save();
                txtMensajes.Text += "Inicio de sesión exitoso en Dropbox! " + "\r\n";
            }
            else
            {
                txtMensajes.Text += "Inicio de sesión fallido en Dropbox..." + "\r\n";
                MessageBox.Show("No se obtuvo acceso a su cuenta Dropbox, favor verificar antes de iniciar el servicio");
                return;
            }
        }
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                txtMensajes.Text += "Solicitando inicio de sesión en servidores de almacenamiento externo..." + "\r\n";
                this.GetAccesToken();
            }
                

            // Start the timer.
            txtMensajes.Text += "Cuenta regresiva para inicio del servicio!" + "\r\n";
            timeLeft = 30;
            lblServicio.Visible = true;
            lblServicio.Text = "El servicio iniciará en ... 30 segundos";
            timer2.Start();

             if(Dispositivos_Disponibles)
             {
                FuenteDeVideo = new VideoCaptureDevice(Disp_Video[cmb_dispositivos.SelectedIndex].MonikerString);
                FuenteDeVideo.NewFrame += new NewFrameEventHandler( video_NuevoFrame);
                FuenteDeVideo.Start();
                cmb_dispositivos.Enabled = false;
                btn_detener.Enabled = true;
                btn_iniciar.Enabled = false;
            }
        
        }

        private void Termina_FuenteDeVideo()
        {
            if (FuenteDeVideo != null)
            {
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;

                }
            }

        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            if (FuenteDeVideo.IsRunning)
            {
                Termina_FuenteDeVideo();
                writer.Close();
                pcb_video.Image=Properties.Resources.offline;
                //timer1.Stop();
                timer2.Stop();
                lblServicio.Text = "";
                lblGrabar.Text = "";
                cmb_dispositivos.Enabled = true;
                btn_detener.Enabled = false;
                btn_iniciar.Enabled = true;
            }
        }

        private void enviar_Correo(string To,string Subject,string Body)
        {
            string[] Mails;
                /*To = txt_destinatarios.Text.TrimEnd(';');
                
                Subject = txt_asunto.Text;
                Body = rtxt_mensaje.Text;*/
                Mails = To.Split(';');//varios correos
                mail = new MailMessage();
                //varios correos
                foreach (string lista in Mails)
                {
                    mail.To.Add(new MailAddress(lista));
                }
                //mail.To.Add(new MailAddress(this.To));
                mail.From = new MailAddress("sist_segu_2015@hotmail.com");
                mail.Subject = Subject;
                mail.Body = Body;
                mail.IsBodyHtml = true;


                Data = new Attachment(PhotoFileName, MediaTypeNames.Application.Octet);
                    mail.Attachments.Add(Data);
                

                SmtpClient client = new SmtpClient("smtp.live.com", 587);
                try
                {
                    using (client)
                    {
                        client.Credentials = new System.Net.NetworkCredential("sist_segu_2015@hotmail.com", "Espol2015");
                        client.EnableSsl = true;
                        client.Send(mail);
                    }
                    txtMensajes.Text += "Envío exitoso de e-mail...!" + "\r\n";
                    mail.Dispose();
                    Data.Dispose();
                    client.Dispose();
                    client = null;
                    Data = null;
                    mail = null;
                }catch(SmtpException exc)
                {
                    //MessageBox.Show(exc.Message + "\n" + exc.StackTrace);
                    txtMensajes.Text += exc.Message + "\r\n" + exc.StackTrace;
                    mail.Dispose();
                    Data.Dispose();
                    client.Dispose();
                    client = null;
                    Data = null;
                    mail = null;
                }
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Upload_Result(RequestResult result)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<RequestResult>(Upload_Result), result);
                return;
            }

            if (result.StatusCode == 200)
            {
                this.txtMensajes.Text+="Carga de archivo exitosa!" + "\r\n";
            }
            else
            {
                if (result["error"].HasValue)
                {
                    this.txtMensajes.Text+= result["error"].ToString() + "\r\n";
                }
                else
                {
                    this.txtMensajes.Text+= result.ToString() + "\r\n";
                }
            }
        }
        private void subirArchivo( string ruta)
        {
            Stream archivo = (Stream)File.OpenRead(ruta);
            UploadFileName="/Public/video_" + DateTime.Now.ToShortDateString().Replace("/", "-") + DateTime.Now.ToShortTimeString().Replace(":", "_") + ".mp4";
            OAuthUtility.PutAsync
              (
                "https://api-content.dropbox.com/1/files_put/auto/",
                new HttpParameterCollection
                {
                  {"access_token", Properties.Settings.Default.AccessToken},
                  {"path", UploadFileName},
                  {"overwrite", "true"},
                  {"autorename","true"},
                  {archivo}
                },
                callback: Upload_Result
              );
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string Body = string.Empty;
            var ffMpeg = new FFMpegConverter();
            txt_time.Text = time.ToLongTimeString();
            if(IsRecording)
            {
                if(time<time_stop)
                {
                    lblGrabar.Visible = true;
                    lblGrabar.Text = "Grabando hasta " + time_stop.ToLongTimeString();
                    //Bitmap Imagen = (Bitmap)pcb_video.Image;
                    
                    writer.AddFrame(video);
                    //FileWriter.WriteVideoFrame(video);
                    if(time<time_stop.AddSeconds(-8))
                    {
                        //txtMensajes.Text += "Capturando la foto con imagen de movimiento" + "\r\n";
                        PhotoFileName = "C:/Users/Alex/Desktop/DEMO/photo_" + DateTime.Now.ToShortDateString().Replace("/", "-") + DateTime.Now.ToShortTimeString().Replace(":", "_") + ".png";
                        foto.Save(PhotoFileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
                else
                {
                    txtMensajes.Text += "Fin de la grabación...!" + "\r\n";
                    writer.Close();

                    pcb_video.Image = Properties.Resources.offline;
                    //FileWriter.Close();
                    txtMensajes.Text += "Compresión de video...!" + "\r\n";
                    ffMpeg.ConvertMedia(VideoFileName, VideoFileName.Replace(".avi",".mp4"), Format.mp4);
                    txtMensajes.Text += "Intentando subir video a servidor de almacenamiento externo...!" + "\r\n";
                    subirArchivo(VideoFileName.Replace(".avi", ".mp4"));
                    txtMensajes.Text += "Video " + this.UploadFileName.Substring(8,UploadFileName.Length-8) +" cargado a servidor de almacenamiento externo...!" + "\r\n";
                    txtMensajes.Text += "Envío de e-mail...!" + "\r\n";
                    Body = "<a href='https://dl.dropboxusercontent.com/u/72924944/" + this.UploadFileName.Substring(8, UploadFileName.Length - 8) + "'>VIDEO</a>" +
                            "<p>" +
                            "<a href='mailto:sist_segu_2015@hotmail.com?cc=aledcerv@espol.edu.ec&amp;subject=Ignorar%20Evento&amp;body=Se%20ha%20detectado%20movimiento%20en%20el%20sistema%20de%20seguridad%2C%20pero%20Ud.%20ha%20decidido%20ignorar%20este%20evento.%20El%20sistema%20detendr%C3%A1%20el%20servicio%20por%2030%20Minutos.'>IGNORAR</a>";
                    enviar_Correo("alexcerv17@gmail.com", "ALERTA - Sistema de Seguridad ha detectado movimiento", Body);
                    IsRecording = false;
                    lblGrabar.Visible = false;
                    time_stop = DateTime.MinValue;
                }
            }
                
        }

        private void subirAOneDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm frmOnedrive = new MainForm();
            frmOnedrive.Show();
        }

        private void capturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisorPrincipal frmVisorPrincipal = new VisorPrincipal();
            frmVisorPrincipal.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lblServicio.Text = "El servicio iniciará en ..." + timeLeft.ToString() + " segundos";
            }
            else
            {
                timer2.Stop();
                lblServicio.Text = "";
                
            }
        }

        private void excepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos trabajando en el Manual de Usuario, Gracias por su comprensión", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un sistema creado por Alex Cervantes y Ricardo Coloma, Estudiantes de la Facultad de Ingeniería Eléctrica y Computación - Escuela Superior Politécnica del Litoral", "Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cámaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_config frmconfig = new frm_config();
            frmconfig.Show();
        }
    }
}
