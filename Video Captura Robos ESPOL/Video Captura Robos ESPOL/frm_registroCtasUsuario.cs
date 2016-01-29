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
        
        public frm_registroCtasUsuario()
        {
            InitializeComponent();
        }

        private void frm_registroCtasUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su configuración de cuentas se ha realizado con éxito");
            this.Close();
        }

        private void pct_oneDrive_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su cuenta Onedrive ha sido configurada exitosamente");
        }

        private void pct_dropBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su cuenta Dropbox ha sido configurada exitosamente");
        }
    }
}
