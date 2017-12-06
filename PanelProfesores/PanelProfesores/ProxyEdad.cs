using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    class ProxyEdad : ProxyIEdad
    {
        public string Nombre
        {
            get
            {
                return GetResponseFromServer("n");
            }
        }
        public string Apellido
        {
            get
            {
                return GetResponseFromServer("a");
            }
        }

        public string Edad
        {
            get
            {
                return GetResponseFromServer("e");
            }
        }

        public string Materia
        {
            get
            {
                return GetResponseFromServer("m");
            }
        }

        private string GetResponseFromServer(string input)
        {
            string result = string.Empty;
            using (TcpClient client = new TcpClient())
            {
                client.Connect("127.0.0.1", 9999);

                Stream stream = client.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(input.ToCharArray());

                stream.Write(ba, 0, ba.Length);

                byte[] br = new byte[100];
                int k = stream.Read(br, 0, 100);

                for (int i = 0; i < k; i++)
                {
                    result += Convert.ToChar(br[i]);
                }

                client.Close();
            }
            return result;
        }
    }
}
