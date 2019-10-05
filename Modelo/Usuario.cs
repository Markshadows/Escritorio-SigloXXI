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
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public int Telefono { get; set; }
        public Rol Rol { get; set; }
        public Direccion Direccion { get; set; }

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
                    && u.PASSWORD.Equals(Contrasena));
                this.Rut = usuario.RUN;
                this.Nombre = usuario.NOMBRE;
                this.Apellidos = usuario.APELLIDOS;
                this.Correo = usuario.CORREO;
                this.Contrasena = usuario.PASSWORD;
                this.Telefono = (int)usuario.TELEFONO;
                this.Direccion = new Direccion { Id = (int)usuario.DIRECCION_ID };
                this.Rol = new Rol { Id = (int)usuario.ROL_ID };
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
                usuario.ID = 0;
                usuario.RUN = Rut;
                usuario.NOMBRE = Nombre;
                usuario.APELLIDOS = Apellidos;
                usuario.CORREO = Correo;
                usuario.PASSWORD = Contrasena;
                usuario.TELEFONO = Telefono;
                usuario.DIRECCION_ID = Direccion.Id;
                usuario.ROL_ID = Rol.Id;
                usuario.CREATED_AT = DateTime.Now;
                usuario.UPDATE_AT = DateTime.Now;
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
                    .First(p => p.RUN == Rut);
                this.Rut = usuario.RUN;
                this.Nombre = usuario.NOMBRE;
                this.Apellidos = usuario.APELLIDOS;
                this.Correo = usuario.CORREO;
                this.Contrasena = usuario.PASSWORD;
                this.Telefono = (int)usuario.TELEFONO;
                this.Direccion = new Direccion { Id = (int)usuario.DIRECCION_ID };
                this.Rol = new Rol { Id = (int)usuario.ROL_ID };
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
                    .First(p => p.RUN == Rut);
                usuario.RUN = Rut;
                usuario.NOMBRE = Nombre;
                usuario.APELLIDOS = Apellidos;
                usuario.CORREO = Correo;
                usuario.PASSWORD = Contrasena;
                usuario.TELEFONO = Telefono;
                usuario.DIRECCION_ID = Direccion.Id;
                usuario.ROL_ID = Rol.Id;
                usuario.CREATED_AT = DateTime.Now;
                usuario.UPDATE_AT = DateTime.Now;

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
