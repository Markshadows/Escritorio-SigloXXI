using DALC;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pedido
    {

        private Contexto conexion;

        public Pedido()
        {
            conexion = new Contexto();
        }

        public object[] listaPedidos()
        {
            try
            {
                DateTime fecha_filtro = new DateTime(2019, 11, 30);
                DateTime fecha_final = DateTime.Parse(fecha_filtro.ToString("dd/MM/yyyy"));
                var x = from pe in conexion.Entidad.PEDIDO
                        join me in conexion.Entidad.MENU on pe.MENU_ID equals me.ID
                        join es in conexion.Entidad.ESTADO on pe.ESTADO_ID equals es.ID
                        join res in conexion.Entidad.RESERVA on pe.RESERVA_ID equals res.ID
                        join mes in conexion.Entidad.MESA on res.MESA_ID equals mes.ID
                        join usu in conexion.Entidad.USUARIO on res.USUARIO_ID equals usu.ID
                        where DbFunctions.TruncateTime(pe.CREATED_AT) == fecha_final
                        && pe.ESTADO_ID == 3
                        select new
                        {
                            nro = pe.ID,
                            menu = me.NOMBRE,
                            mesa = mes.NUMERO,
                            mesero = usu.NOMBRE,
                            hora = pe.CREATED_AT,
                            estado = es.NOMBRE
                        };

                return x.ToArray();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public bool PedidoListo(int id)
        {
            try
            {
                PEDIDO pe = conexion.Entidad.PEDIDO
                    .First(p => p.ID == id);
                pe.ESTADO_ID = 4;
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
