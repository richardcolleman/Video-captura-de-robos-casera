using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Captura_Robos_ESPOL
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_foto_MouseEnter(object sender, EventArgs e)
        {
            btn_foto.BackColor = Color.LightBlue;
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            cmb_contenido.SelectedIndex = 0;
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
    }
}
