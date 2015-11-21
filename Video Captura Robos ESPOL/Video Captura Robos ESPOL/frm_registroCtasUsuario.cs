using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Captura_Robos_ESPOL
{
    public partial class frm_registroCtasUsuario : Form
    {
        string lines;
        public frm_registroCtasUsuario()
        {
            InitializeComponent();
        }
        private void txt_passOnedrive_Enter(object sender, EventArgs e)
        {

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

        private void txt_correoOnedrive_Leave(object sender, EventArgs e)
        {
            Boolean imgVrf = verificar_correo(txt_correoOnedrive.Text);
            pct_okOnedrive.Visible = imgVrf;
            pct_errorOnedrive.Visible = !imgVrf;
        }

        private void txt_correoDropbox_Leave(object sender, EventArgs e)
        {
            Boolean imgVrf = verificar_correo(txt_correoDropbox.Text);
            pct_okDropbox.Visible = imgVrf;
            pct_errorDropbox.Visible = !imgVrf;
        }

        private void txt_passOnedrive_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_mostrarOnedrive.Visible = true;
        }

        private void txt_passDropbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_mostrarDropbox.Visible = true;
        }

        private void lbl_mostrarOnedrive_Click(object sender, EventArgs e)
        {
            txt_passOnedrive.PasswordChar = '\0';
        }

        private void lbl_mostrarDropbox_Click(object sender, EventArgs e)
        {
            txt_passDropbox.PasswordChar = '\0';
        }

        private void frm_registroCtasUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txt_passOnedrive_TextChanged(object sender, EventArgs e)
        {
            /*if ((txt_correoOnedrive.Text != "") && (txt_passOnedrive.Text != ""))
            {
                btn_guardar.Enabled = true;
            }
            else 
            {
                btn_guardar.Enabled = false;
            }*/
        }

        private void txt_correoOnedrive_TextChanged(object sender, EventArgs e)
        {
            /*if ((txt_correoOnedrive.Text != "") && (txt_passOnedrive.Text != ""))
            {
                btn_guardar.Enabled = true;
            }
            else
            {
                btn_guardar.Enabled = false;
            }*/
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Boolean od = false;
            Boolean db = false;

            if ((txt_correoOnedrive.Text != "") & (txt_passOnedrive.Text != ""))
            {
                od = true;
            }

            if ((txt_correoDropbox.Text != "") & (txt_passDropbox.Text != ""))
            {
                db = true;
            }

            if (od == true & db == false)
            {
                MessageBox.Show("Su cuenta OneDrive se guardo exitosamente.");
                lines = txt_correoOnedrive.Text + ';' + txt_passOnedrive.Text + ';' + ';' + ';';
            }
            else if (od == false & db == true)
            {
                MessageBox.Show("Su cuenta Dropbox se guardo exitosamente.");
                lines = ";" + ";" + txt_correoDropbox.Text + ';' + txt_passDropbox.Text + ';';
            }
            else if (od == true & db == true)
            {
                MessageBox.Show("Sus cuentas OneDrive y Dropbox se guardaron exitosamente.");
                lines = txt_correoOnedrive.Text + ';' + txt_passOnedrive.Text + ';' + txt_correoDropbox.Text + ';' + txt_passDropbox.Text + ';';
            }
            else if (od == false && db == false)
            {
                MessageBox.Show("Por favor registre la información de sus cuentas.");
            }
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\Alex\\Documents\\cuentasUsuario.txt");
            file.WriteLine(lines);
            file.Close();
        }
    }
}
