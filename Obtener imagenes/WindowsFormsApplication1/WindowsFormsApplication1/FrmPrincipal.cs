using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;
namespace WindowsFormsApplication1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private FilterInfoCollection Dispositivos; //LISTA DE DISPOSITIVOS
        private VideoCaptureDevice FuenteDeVideo; //DISPOSITIVO QUE USAREMOS COMO FUENTE
        private void Form1_Load(object sender, EventArgs e)
        {
            //LISTAR DISPOSITIVOS DE ENTRADAS DE VIDEO
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //Dispositivos tiene el array, con todos los dispositivos disponibles
            foreach (FilterInfo x in Dispositivos)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ESTABLECER EL DISPOSITIVO SELECCIONADO COMO FUENTE DE VIDEO
            FuenteDeVideo = new VideoCaptureDevice(Dispositivos[comboBox1.SelectedIndex].MonikerString);
            //INICIALIZAR EL CONTROL 
            videoSourcePlayer1.VideoSource = FuenteDeVideo;
            //INICIAR LA RECEPCIÓN DE IMAGENES
            videoSourcePlayer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DETENER LA RECEPCIÓN DE IMAGENES
            videoSourcePlayer1.SignalToStop();
        }

        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {

        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            
        }
    }
}
