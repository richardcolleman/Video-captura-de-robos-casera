using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;

namespace EnviarCorreo
{
    public partial class Form1 : Form
    {

        private string To;
        private string Subject;
        private string Body;
        private string[] Mails;//varios correos

        private MailMessage mail;
        private Attachment Data;

        public Form1()
        {
            InitializeComponent();
        }

        private void examinarBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            archivoAdjTxt.Text = openFileDialog1.FileName;
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            if (!(toTxt.Text.Trim() == ""))
            {
                To = toTxt.Text.TrimEnd(';');
                Mails = To.Split(';');//varios correos
                Subject = asuntoTxt.Text;
                Body = mensajeTxt.Text;
                
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

                if (!(archivoAdjTxt.Text.Trim() == ""))
                {
                    Data = new Attachment(archivoAdjTxt.Text, MediaTypeNames.Application.Octet);
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
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"C:\\Users\\Alex\\Documents\\correos.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String correos = sr.ReadToEnd();
                    //MessageBox.Show(correos);
                    toTxt.Text = correos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo de correos no puede ser leído: " + ex.Message);
            }
        }

        private void pct_atras_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu frmM = new FormMenu();
            frmM.Show();
        }    
    }
}
