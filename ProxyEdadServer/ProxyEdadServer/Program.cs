using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProxyEdadServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 9999);

            while (true)
            {
                listener.Start();
                Console.WriteLine("Waiting .....");
                Socket s = listener.AcceptSocket();

                byte[] b = new byte[100];

                int count = s.Receive(b);

                string input = string.Empty;

                for (int i = 0; i < count; i++)
                {
                    input += Convert.ToChar(b[i]);
                }

                ProxyIEdad realSubject = new ProxyEdad();
                string returnValue = string.Empty;
                string message = string.Empty;

                switch (input)
                {
                    case "n":
                        message = "Nombre: ";
                        returnValue = realSubject.Nombre;
                        break;
                    case "a":
                        message = "Apellido: ";
                        returnValue = realSubject.Apellido;
                        break;
                    case "e":
                        message = "Edad: ";
                        returnValue = realSubject.Edad;
                        break;
                    case "m":
                        message = "Materia: ";
                        returnValue = realSubject.Materia;
                        break;
                }

                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes(returnValue));

                s.Close();
                listener.Stop();
                Console.WriteLine("Respuesta a ({0}) Enviada .....", message);
            }
        }
    }
}
