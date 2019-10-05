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

            Direccion direccion = new Direccion();
            direccion.Id = 31;
            direccion.Calle = "Test Call";
            direccion.Numero = "Test Nr";
            direccion.Piso = "Test Pis";
            direccion.Departamento = "Dpto";
            direccion.Otro = "Otro";
            direccion.Pais = new Pais { Id = 1 };
            direccion.Comuna = new Comuna { Id = 1 };
            direccion.Ciudad = new Ciudad { Id = 3 };
            direccion.Modificar();

            Usuario usuario = new Usuario();
            usuario.Rut = "19.277.806-9";
            usuario.Nombre = "Iván";
            usuario.Apellidos = "Torres Maldonado";
            usuario.Correo = "ivan@gmail.com";
            usuario.Contrasena = "ivan";
            usuario.Telefono = 54637456;
            usuario.Rol = new Rol { Id = 3 };
            usuario.Direccion = new Direccion { Id = 31 };
            string msj = usuario.Modificar() ? "Modificó" : "No Modificó";
            Console.WriteLine(usuario.Nombre);
            return msj;
        }

        static void Agregar() {

            Direccion direccion = new Direccion();
            direccion.Calle = "Test Calle";
            direccion.Numero = "Test Nro";
            direccion.Piso = "Test Piso";
            direccion.Departamento = "Test Dpto";
            direccion.Otro = "Test Otro";
            direccion.Pais = new Pais { Id = 1 };
            direccion.Comuna = new Comuna { Id = 1 };
            direccion.Ciudad = new Ciudad { Id = 2 };
            int idDireccion = direccion.Agregar();

            Usuario usuario = new Usuario();
            usuario.Id = 1;
            usuario.Nombre = "Iván";
            usuario.Apellidos = "Torres Mercado";
            usuario.Correo = "ivan@gmail.com";
            usuario.Contrasena = "ivan";
            usuario.Rut = "19.277.806-9";
            usuario.Telefono = 54637456;
            usuario.Rol = new Rol { Id = 1 };
            usuario.Direccion = new Direccion { Id = idDireccion};
            if (usuario.Agregar())
            {
                Console.WriteLine("Agregó");
            }
        }
    }
}
