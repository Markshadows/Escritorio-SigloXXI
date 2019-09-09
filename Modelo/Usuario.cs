using DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Appaterno { get; set; }
        public string Apmaterno { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public int Telefono { get; set; }
        public int Tipo { get; set; }
        public int Estado { get; set; }
        public string Direccion { get; set; }

        private Contexto conexion;

        public Usuario()
        {
            conexion = new Contexto();
        }
        /*public Usuario(int idProf)
        {
            IdProfesor = idProf;
        }*/

        public bool IniciarSesion()
        {
            try
            {
                USUARIO usuario = conexion.Entidad.USUARIO
                    .First(u => u.CORREO.Equals(Correo)
                    && u.CONTRASENA.Equals(Contrasena));
                this.Tipo = (int)usuario.TIPO;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Agregar()
        {
            try
            {
                USUARIO usuario = new USUARIO();
                usuario.ID_USUARIO = Id;
                usuario.RUT = Rut;
                usuario.NOMBRE = Nombre;
                usuario.APPATERNO = Appaterno;
                usuario.APMATERNO = Apmaterno;
                usuario.CORREO = Correo;
                usuario.CONTRASENA = Contrasena;
                usuario.TELEFONO = Telefono;
                usuario.DIRECCION = Direccion;
                usuario.TIPO = Tipo;
                usuario.ESTADO = Estado;
                conexion.Entidad.USUARIO.Add(usuario);
                conexion.Entidad.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public bool Buscar()
        {
            try
            {
                USUARIO usuario = conexion.Entidad.USUARIO
                    .First(p => p.RUT == Rut);
                this.Rut = usuario.RUT;
                this.Nombre = usuario.NOMBRE;
                this.Appaterno = usuario.APPATERNO;
                this.Apmaterno = usuario.APMATERNO;
                this.Correo = usuario.CORREO;
                this.Contrasena = usuario.CONTRASENA;
                this.Telefono = (int)usuario.TELEFONO;
                this.Direccion = usuario.DIRECCION;
                this.Tipo = (int)usuario.TIPO;
                this.Estado = (int)usuario.ESTADO;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public bool Modificar()
        {
            try
            {
                USUARIO usuario = conexion.Entidad.USUARIO
                    .First(p => p.RUT == Rut);
                usuario.RUT = Rut;
                usuario.NOMBRE = Nombre;
                usuario.APPATERNO = Appaterno;
                usuario.APMATERNO = Apmaterno;
                usuario.CORREO = Correo;
                usuario.CONTRASENA = Contrasena;
                usuario.TELEFONO = Telefono;
                usuario.DIRECCION = Direccion;
                usuario.TIPO = Tipo;
                usuario.ESTADO = Estado;
                conexion.Entidad.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
