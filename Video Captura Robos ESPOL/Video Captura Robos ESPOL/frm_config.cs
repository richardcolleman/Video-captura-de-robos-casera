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
    public partial class frm_config : Form
    {
        public frm_config()
        {
            InitializeComponent();
        }

        private void frm_config_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_guardarConfig_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.AccessToken = login.AccessToken.Value;
            Properties.Settings.Default.tiempoEsperaInicial = cmb_tiempoInicial.Text;
            Properties.Settings.Default.calidadCaptura = cmb_calidad.Text;
            Properties.Settings.Default.tamanoVideo = cmb_calidad.Text;
            Properties.Settings.Default.tiempoCaptura = cmb_tiempo.Text;
            MessageBox.Show("Configuración de la Cámara guardada exitosamente");
        }
    }
}
