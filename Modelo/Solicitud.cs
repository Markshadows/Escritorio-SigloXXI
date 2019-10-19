using DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Solicitud
    {
        public int Id { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
        public EstadoSolicitud EstadoSolicitud { get; set; }

        private Contexto conexion;

        public Solicitud()
        {
            conexion = new Contexto();
        }

        public bool Modificar()
        {
            try
            {
                SOLICITUD solicitud = conexion.Entidad.SOLICITUD
                    .First(p => p.ID_SOLICITUD == Id);
                solicitud.ESTADO_SOLICITUD = (byte)EstadoSolicitud.Id;
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
                SOLICITUD solicitud = conexion.Entidad.SOLICITUD
                    .First(p => p.ID_SOLICITUD == Id);
                Id = solicitud.ID_SOLICITUD;
                Asunto = solicitud.ASUNTO;
                Mensaje = solicitud.MENSAJE;
                EstadoSolicitud = new EstadoSolicitud { Id = solicitud.ESTADO_SOLICITUD };
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
