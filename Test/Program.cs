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
            //Agregar();
            //Console.WriteLine(Buscar());
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
    }
}
