using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Google.Apis.Auth.OAuth2;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Drive.v2;
using Google.Apis.Services;

namespace googleDriveConexion
{
    public partial class Form1 : Form
    {
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
        static string ApplicationName = "Drive API .NET Quickstart";
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_verificar_Click(object sender, EventArgs e)
        {
            String email = txt_correo.Text;
            if(txt_correo.Text != "")
            {
                verificar_correo(email);
            }else
            {
                MessageBox.Show("Por favor ingrese su correo");
            }    
        }
        private Boolean verificar_correo(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    MessageBox.Show("Correo válido");
                    btn_registrar.Enabled = true;
                    return true;
                }
                else
                {
                    MessageBox.Show("Correo incorrecto");
                    btn_registrar.Enabled = false;
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Correo incorrecto");
                btn_registrar.Enabled = false;
                return false;
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txt_contrasena.Text);
            if (txt_correo.TextLength != 0 & txt_contrasena.TextLength != 0) 
            {
                MessageBox.Show("Cuenta registrada");                

                // Compose a string that consists of three lines.
                //string lines = "First line.\r\nSecond line.\r\nThird line.";
                string lines = txt_correo.Text + ' ' + txt_contrasena.Text + '\n';
                // Write the string to a file.
                System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\Alex\\Documents\\cuentas.txt");
                
                file.WriteLine(lines);
                file.Close();

                txt_correo.Enabled = false;
                txt_contrasena.Enabled = false;
                btn_comprobar.Enabled = true;
                //txt_correo.Clear();
                //txt_contrasena.Clear();
            }
        }

        private void lbl_mostrarcontrasena_Click(object sender, EventArgs e)
        {
            String pass = txt_contrasena.Text;
            //txt_contrasena.Clear();
            txt_contrasena.PasswordChar = '\0';
            txt_contrasena.Text = Convert.ToString(pass);
        }

        private void txt_contrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_mostrarcontrasena.Visible = true;
        }

        static void registrar_cuenta(string cuenta)
        {//PARA SOBREESCRBIBR EL REPORTE Y TENER HISTORIAL DE LO QUE HACEMOS
            StreamWriter WriteReportFile = File.AppendText(@"C:\Users\Alex\Documents\cuentas.txt");
            WriteReportFile.WriteLine(cuenta);
            WriteReportFile.Close();
        }
        

        private void btn_comprobar_Click(object sender, EventArgs e)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.MaxResults = 10;

            // List files.
            IList<Google.Apis.Drive.v2.Data.File> files = listRequest.Execute()
                .Items;
            Console.WriteLine("Files:");
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    Console.WriteLine("{0} ({1})", file.Title, file.Id);
                }
            }
            else
            {
                Console.WriteLine("No files found.");
            }
            Console.Read();
        }
    }
}
