using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Captura_Robos_ESPOL
{
    public partial class frm_registroCorreosNotif : Form
    {
        private string[] Mails;
        string lines;
        public frm_registroCorreosNotif()
        {
            InitializeComponent();
        }

        private void chk_email1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_email1.Checked == true)
            {
                txt_email1.Enabled = true;
            }
            else
            {
                txt_email1.Clear();
                txt_email1.Enabled = false;
                pct_error1.Visible = false;
                pct_ok1.Visible = false;
            }
        }

        private void chk_email2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_email2.Checked == true)
            {
                txt_email2.Enabled = true;
            }
            else
            {
                txt_email2.Clear();
                txt_email2.Enabled = false;
                pct_error2.Visible = false;
                pct_ok2.Visible = false;
            }
        }

        private void chk_email3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_email3.Checked == true)
            {
                txt_email3.Enabled = true;
            }
            else
            {
                txt_email3.Clear();
                txt_email3.Enabled = false;
                pct_error3.Visible = false;
                pct_ok3.Visible = false;
            }
        }

        private void chk_email4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_email4.Checked == true)
            {
                txt_email4.Enabled = true;
            }
            else
            {
                txt_email4.Clear();
                txt_email4.Enabled = false;
                pct_error4.Visible = false;
                pct_ok4.Visible = false;
            }
        }

        private void chk_email5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_email5.Checked == true)
            {
                txt_email5.Enabled = true;
            }
            else
            {
                txt_email5.Clear();
                txt_email5.Enabled = false;
                pct_error5.Visible = false;
                pct_ok5.Visible = false;
            }
        }

        private void txt_email1_Leave(object sender, EventArgs e)
        {
            Boolean imgVrf = verificar_correo(txt_email1.Text);
            pct_ok1.Visible = imgVrf;
            pct_error1.Visible = !imgVrf;
        }

        private Boolean verificar_correo(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txt_email2_Leave(object sender, EventArgs e)
        {
            Boolean imgVrf = verificar_correo(txt_email2.Text);
            pct_ok2.Visible = imgVrf;
            pct_error2.Visible = !imgVrf;
        }

        private void txt_email3_Leave(object sender, EventArgs e)
        {
            Boolean imgVrf = verificar_correo(txt_email3.Text);
            pct_ok3.Visible = imgVrf;
            pct_error3.Visible = !imgVrf;
        }

        private void txt_email4_Leave(object sender, EventArgs e)
        {
            Boolean imgVrf = verificar_correo(txt_email4.Text);
            pct_ok4.Visible = imgVrf;
            pct_error4.Visible = !imgVrf;
        }

        private void txt_email5_Leave(object sender, EventArgs e)
        {
            Boolean imgVrf = verificar_correo(txt_email5.Text);
            pct_ok5.Visible = imgVrf;
            pct_error5.Visible = !imgVrf;
        }

        private void frm_registroCorreosNotif_Load(object sender, EventArgs e)
        {
            int c = 0;
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"C:\\Users\\Alex\\Documents\\RegCorreos.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String correos = sr.ReadToEnd();
                    Mails = correos.Split(';');
                    if (Mails[0] != null) { txt_email1.Text = Mails[0]; c++; }
                    if (Mails[1] != null) { txt_email2.Text = Mails[1]; c++; }
                    if (Mails[2] != null) { txt_email3.Text = Mails[2]; c++; }
                    if (Mails[3] != null) { txt_email4.Text = Mails[3]; c++; }
                    if (Mails[4] != null) { txt_email5.Text = Mails[4]; c++; }
                }
                if (c != 0)
                {
                    MessageBox.Show("Tiene registrados correos");
                }
            }
            catch (Exception ex)
            {
                //Exception
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_email1.TextLength != 0 || txt_email2.TextLength != 0 || txt_email3.TextLength != 0 || txt_email4.TextLength != 0 || txt_email5.TextLength != 0)
            {
                MessageBox.Show("Se han guardado exitosamente sus correos");
                if (txt_email1.TextLength != 0) { lines = txt_email1.Text + ";"; }
                if (txt_email2.TextLength != 0)
                {
                    string email2;
                    email2 = txt_email2.Text + ";";
                    lines = string.Concat(lines, email2);
                    //MessageBox.Show(lines);
                }
                if (txt_email3.TextLength != 0)
                {
                    string email3;
                    email3 = txt_email3.Text + ";";
                    lines = string.Concat(lines, email3);
                    //MessageBox.Show(lines);
                }
                if (txt_email4.TextLength != 0)
                {
                    string email4;
                    email4 = txt_email4.Text + ";";
                    lines = string.Concat(lines, email4);
                    //MessageBox.Show(lines);
                }
                if (txt_email5.TextLength != 0)
                {
                    string email5;
                    email5 = txt_email5.Text + ";";
                    lines = string.Concat(lines, email5);
                    //MessageBox.Show(lines);
                }
                System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\Alex\\Desktop\\DEMO\\RegCorreos.txt");
                Properties.Settings.Default.emailsNotificacion = lines;
                file.Write(lines);
                file.Close();
                MessageBox.Show("Verifique el archivo de correos en C:\\Users\\Alex\\Desktop\\DEMO\\RegCorreos.txt" + " - Sus correos registrados son: " + lines);
            }
            else
            {
                MessageBox.Show("Ingrese al menos un correo");
            }
        }

    }
}
