using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenPopExamples;
using OpenPop.Pop3;
using OpenPop.Mime;
using System.Net.NetworkInformation;

namespace pruebaLecturaCorreos
{
    class Program
    {
        static bool networkIsAvailable = false;
        static void Main(string[] args)
        {
            bool cnx = false;
            String logMail = "sist_segu_2015@hotmail.com", logPass = "Espol2015";
            int num = 0, band = 0;
            Message message;
            String subject;
            String notif;

            Console.WriteLine("Verificando conexión a internet...");

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface nic in nics)
            {
                if (
                    (nic.NetworkInterfaceType != NetworkInterfaceType.Loopback && nic.NetworkInterfaceType != NetworkInterfaceType.Tunnel) &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    networkIsAvailable = true;
                }
            }
            Console.Write("Conexión a Internet: ");
            Console.WriteLine(networkIsAvailable);
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);

            if (networkIsAvailable)
            {

                Console.WriteLine("Subrutina -- Lectura de Eventos Ignorar");
                Console.WriteLine("Solicitando acceso a la cuenta de correo sist_segu_2015");

                Pop3Client pop3Client = new Pop3Client();
                pop3Client.Connect("pop3.live.com", 995, true);
                pop3Client.Authenticate(logMail, logPass);
                cnx = pop3Client.Connected;

                Console.WriteLine("Solicitud de conexión a las " + DateTime.Now);
                Console.WriteLine("Conectando...");

                if (cnx == true)
                {
                    Console.WriteLine("--- Conexión exitosa ---");
                    Console.WriteLine("Se realizó conexión exitosa a las " + DateTime.Now);
                }
                else
                {
                    Console.WriteLine("--- Conexión fallida ---");
                    Console.WriteLine("Fallo de conexión a las " + DateTime.Now);
                    Console.WriteLine("Presione una tecla para salir...");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }

                num = pop3Client.GetMessageCount();
                Console.WriteLine("Usted tiene {0} correos en su bandeja", num);
                Console.WriteLine("Leyendo correos, buscando notificación IGNORAR...");
                for (int i = 1; i <= num; i++)
                {
                    message = pop3Client.GetMessage(i);
                    subject = message.ToMailMessage().Subject;
                    if (subject == "IGNORAR")
                    {
                        notif = message.ToMailMessage().Body;
                        Console.WriteLine("Contenido del correo: " + notif);
                        pop3Client.DeleteMessage(i);
                        Console.WriteLine("Se ha notificado al programa la captura del evento IGNORAR enviada por el usuario");
                        band = 1;
                    }
                    else
                    {
                        Console.WriteLine("Leyendo {0} correos...", i);
                    }
                }
                if (band == 0)
                {
                    Console.WriteLine("No se han encontrado notificaciones...");
                }

                pop3Client.Disconnect();
                Console.WriteLine("La subrutina fue desconectada a las  " + DateTime.Now);
                Console.WriteLine("Presione una tecla para salir...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hay conexión a Internet, por favor verificar el inconveniente");
                Console.ReadKey();
            }
        }
        static void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            networkIsAvailable = e.IsAvailable;
            Console.Write("Conexión a Internet: ");
            Console.WriteLine(networkIsAvailable);
        }
    }
}
