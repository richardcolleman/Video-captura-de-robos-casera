using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnviarCorreo
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void lbl_envioEmail_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void lbl_registroEmail_Click(object sender, EventArgs e)
        {
            FormRegistro frmR = new FormRegistro();
            this.Hide();
            frmR.Show();
        }
    }
}
