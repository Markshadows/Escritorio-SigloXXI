using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Agregar();
            Console.WriteLine(Modificar());
            Console.ReadKey();
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
            usuario.Appaterno = "Torres";
            usuario.Apmaterno = "Alvarado";
            usuario.Correo = "ivan@gmail.com";
            usuario.Contrasena = "ivan";
            usuario.Rut = "19.277.806-9";
            usuario.Telefono = 54637456;
            usuario.Tipo = 1;
            usuario.Estado = 2;
            string msj = usuario.Modificar() ? "Modificó" : "No Modificó";
            Console.WriteLine(usuario.Nombre);
            return msj;
        }

        static void Agregar() {
            Usuario usuario = new Usuario();
            usuario.Id = 1;
            usuario.Nombre = "Iván";
            usuario.Appaterno = "Torres";
            usuario.Apmaterno = "Alvarado";
            usuario.Correo = "ivan@gmail.com";
            usuario.Contrasena = "ivan";
            usuario.Rut = "19.277.806-9";
            usuario.Telefono = 54637456;
            usuario.Tipo = 1;
            if (usuario.Agregar())
            {
                Console.WriteLine("Agregó");
            }
        }
    }
}
