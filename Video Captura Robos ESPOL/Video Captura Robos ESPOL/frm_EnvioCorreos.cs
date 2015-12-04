using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Captura_Robos_ESPOL
{
    public partial class frm_EnvioCorreos : Form
    {
        private string To;
        private string Subject;
        private string Body;
        private string[] Mails;//varios correos
        private MailMessage mail;
        private Attachment Data;
        public frm_EnvioCorreos()
        {
            InitializeComponent();
        }

        private void frm_EnvioCorreos_Load(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"C:\\Users\\Alex\\Documents\\RegCorreos.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String correos = sr.ReadToEnd();
                    //MessageBox.Show(correos);
                    txt_destinatarios.Text = correos;
                    
                    //Para uso de respuesta
                    //rtxt_mensaje.Text = "Hora Inicio: " + DateTime.Now.Hour.ToString() + ':' + DateTime.Now.Minute.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo de correos no puede ser leído: " + ex.Message);
            }
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txt_adjunto.Text = openFileDialog1.FileName;
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (!(txt_destinatarios.Text.Trim() == ""))
            {
                To = txt_destinatarios.Text.TrimEnd(';');
                Mails = To.Split(';');//varios correos
                Subject = txt_asunto.Text;
                Body = rtxt_mensaje.Text;

                mail = new MailMessage();
                //varios correos
                foreach (String lista in Mails)
                {
                    mail.To.Add(new MailAddress(lista));
                }
                //mail.To.Add(new MailAddress(this.To));
                mail.From = new MailAddress("sist_segu_2015@hotmail.com");
                mail.Subject = Subject;
                mail.Body = Body;
                mail.IsBodyHtml = true;

                if (!(txt_adjunto.Text.Trim() == ""))
                {
                    Data = new Attachment(txt_adjunto.Text, MediaTypeNames.Application.Octet);
                    mail.Attachments.Add(Data);
                }

                SmtpClient client = new SmtpClient("smtp.live.com", 587);
                using (client)
                {
                    client.Credentials = new System.Net.NetworkCredential("sist_segu_2015@hotmail.com", "Espol2015");
                    client.EnableSsl = true;
                    client.Send(mail);
                }
                MessageBox.Show("Mensaje enviado");
                this.Close();
            }
        }

        //FUNCIÓN PARA ENVIAR CORREOS
        private void enviarCorreos ()
        {
            //INICIO LECTURA DE DESTINATARIOS DE CORREO
            try
            {   
                using (StreamReader sr = new StreamReader(@"C:\\Users\\Alex\\Documents\\RegCorreos.txt"))
                {
                    String correos = sr.ReadToEnd();
                    //MessageBox.Show(correos);
                    txt_destinatarios.Text = correos;
                    //Para uso de respuesta
                    //rtxt_mensaje.Text = "Hora Inicio: " + DateTime.Now.Hour.ToString() + ':' + DateTime.Now.Minute.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo de correos no puede ser leído: " + ex.Message);
            }
            // FIN LECTURA DESTINARIOS DE CORREO

            //ARCHIVOS ADJUNTOS
            txt_adjunto.Text = "ARCHIVO DE PRUEBA";

            //INICIO DE ENVÍO DE CORREO

            if (!(txt_destinatarios.Text.Trim() == ""))
            {
                To = txt_destinatarios.Text.TrimEnd(';');
                Mails = To.Split(';');//varios correos
                Subject = txt_asunto.Text;
                Body = rtxt_mensaje.Text;

                mail = new MailMessage();
                //varios correos
                foreach (String lista in Mails)
                {
                    mail.To.Add(new MailAddress(lista));
                }
                //mail.To.Add(new MailAddress(this.To));
                mail.From = new MailAddress("sist_segu_2015@hotmail.com");
                mail.Subject = Subject;
                mail.Body = Body;
                mail.IsBodyHtml = false;

                /*
                if (!(txt_adjunto.Text.Trim() == ""))
                {
                    Data = new Attachment(txt_adjunto.Text, MediaTypeNames.Application.Octet);
                    mail.Attachments.Add(Data);
                }
                */

                SmtpClient client = new SmtpClient("smtp.live.com", 587);
                using (client)
                {
                    client.Credentials = new System.Net.NetworkCredential("sist_segu_2015@hotmail.com", "Espol2015");
                    client.EnableSsl = true;
                    client.Send(mail);
                }
                MessageBox.Show("Mensaje enviado");
                this.Close();
            }

            //FIN DE ENVÍO DE CORREO
        }
    }
}
