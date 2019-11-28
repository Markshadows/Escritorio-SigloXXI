using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace Test
{
    class Program
    {
        private static string host = "0.tcp.ngrok.io";
        // Enter your sftp username here
        private static string username = "crow";
        // Enter your sftp password here
        private static string password = "crow2680";
        static void Main(string[] args)
        {
            //Agregar();
            //Console.WriteLine(Buscar());
            //Console.WriteLine(Modificar());
            //cantidadMes();
            //menusVendidos();
            Send("myFile.txt");
            Console.ReadKey();
        }


            public static int Send(string fileName)
            {
                var connectionInfo = new ConnectionInfo(host, 14937, "crow", new PasswordAuthenticationMethod(username, password));
                // Upload File
                using (var sftp = new SftpClient(connectionInfo))
                {

                    sftp.Connect();
                    //sftp.ChangeDirectory("/MyFolder");
                    using (var uplfileStream = System.IO.File.OpenRead(fileName))
                    {
                        sftp.UploadFile(uplfileStream, fileName, true);
                    }
                    sftp.Disconnect();
                }
                return 0;
            }
     

        private static string Buscar()
        {
            Usuario usuario = new Usuario();
            usuario.Rut = "19.277.806-9";
            string msj = usuario.Buscar() ? "Existe" : "No Existe";
            return msj;
        }

        private static string Modificar() {

            Usuario usuario = new Usuario();
            usuario.Rut = "19.277.806-9";
            usuario.Nombre = "Iván";
            usuario.Apellidos = "Torres Maldonado";
            usuario.Correo = "ivan@gmail.com";
            usuario.Contrasena = "ivan";
            usuario.Telefono = 54637456;
            usuario.Rol = new Rol { Id = 3 };
            usuario.Direccion = "";
            string msj = usuario.Modificar() ? "Modificó" : "No Modificó";
            Console.WriteLine(usuario.Nombre);
            return msj;
        }

        static void Agregar() {

            Usuario usuario = new Usuario();
            usuario.Id = 1;
            usuario.Nombre = "Iván";
            usuario.Apellidos = "Torres Mercado";
            usuario.Correo = "ivan@gmail.com";
            usuario.Contrasena = "ivan";
            usuario.Rut = "19.277.806-9";
            usuario.Telefono = 54637456;
            usuario.Rol = new Rol { Id = 1 };
            usuario.Direccion = "";
            if (usuario.Agregar())
            {
                Console.WriteLine("Agregó");
            }
        }

        static int cantidadPorRol()
        {
            Usuario usuario = new Usuario();
            return usuario.cantidadPorRol("MESERO");
        }

        static void cantidadMes()
        {
            Informe inf = new Informe();
            Console.WriteLine(inf.cantidadMensual(10));
        }

        static void menusVendidos()
        {
            string nombreMenu = "";
            Informe inf = new Informe();
            int contador = 0;
            List<string> menus = new List<string>();
            IEnumerable<object> menusVendidos = inf.menusVendidos(10).Distinct();

            foreach (var item in inf.menusVendidos(10))
            {
                Console.WriteLine(item);
            }

            //foreach (var item in menus)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("contador: "+contador);
        }
    }
}
