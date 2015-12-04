﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge;
using AForge.Video;
using AForge.Imaging;
using AForge.Video.VFW;
using AForge.Vision.Motion;
using AForge.Video.DirectShow;
//using AForge.Video.FFMPEG;

namespace Video_Captura_Robos_ESPOL
{
    public partial class frm_principal : Form
    {
        private FilterInfoCollection Disp_Video=null;
        private bool Dispositivos_Disponibles = false;
        private VideoCaptureDevice FuenteDeVideo = null;
        private MotionDetector detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());
        private Single motionAlarmLevel = 0.015F;
        private Bitmap foto=null;
        private bool IsRecording = false;
        private AVIWriter writer = null;
        private Timer timer_frames=null;
        private DateTime time_stop = DateTime.MinValue;
        //private VideoFileWriter writer = new VideoFileWriter();
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_foto_MouseEnter(object sender, EventArgs e)
        {
            btn_foto.BackColor = Color.LightBlue;
        }

        private void Carga_Dispositivos()
        {
            for (int i = 0; i < Disp_Video.Count; i++)
            {
                cmb_dispositivos.Items.Add(Disp_Video[i].Name.ToString());
            }
            cmb_dispositivos.Text = cmb_dispositivos.Items[0].ToString();
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
            cmb_contenido.SelectedIndex = 0;
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

            if(detector != null)
            {
                Single motionLevel = detector.ProcessFrame(Imagen);

                if(motionLevel > motionAlarmLevel)
                {
                    //"Si hay Movimiento";
                    this.btn_foto.ForeColor = Color.White;
                    this.btn_foto.BackColor = Color.Red;
                    if (!IsRecording)
                    {
                        //Cambie Ruta a C:\Users\Alex\Documents
                        foto.Save("C:/Users/Alex/Documents/CapturasSistema/photo.png", System.Drawing.Imaging.ImageFormat.Png);
                        time_stop = DateTime.Now.AddSeconds(10);
                        IsRecording = true;
                        writer = new AVIWriter();
                        writer.Open("C:/Users/Alex/Documents/CapturasSistema/video.avi", (int)Math.Ceiling((double)pcb_video.Image.Width), (int)Math.Ceiling((double)pcb_video.Image.Height));
                    }
                    
                }
                else{
                    //"No hay Movimiento";
                    this.btn_foto.ForeColor = Color.Black;
                    this.btn_foto.BackColor = Color.Yellow;
                    foto = (Bitmap)eventArgs.Frame.Clone();
                }

                pcb_video.Image = Imagen;
                
            
           }
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
          
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
                cmb_dispositivos.Enabled = true;
                btn_detener.Enabled = false;
                //pcb_video.Image=null;
                btn_iniciar.Enabled = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            txt_time.Text = time.ToLongTimeString();
            if(IsRecording)
            {
                if(time<time_stop)
                {
                    lblGrabar.Visible = true;
                    lblGrabar.Text = "Grabando hasta " + time_stop.ToLongTimeString();
                    Bitmap Imagen = (Bitmap)pcb_video.Image;
                    this.writer.AddFrame(Imagen);
                }
                else
                {
                    writer.Close();
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

        private void btn_envCorreo_Click(object sender, EventArgs e)
        {
            
        }

    }
}
