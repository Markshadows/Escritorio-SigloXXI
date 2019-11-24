using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Informe
    {
        private Contexto conexion;
        public Informe()
        {
            conexion = new Contexto();
        }

        public int cantidadMensual(int mes)
        {
            try
            {
                var x = from cliente in conexion.Entidad.CLIENTE
                        join reserva in conexion.Entidad.RESERVA on cliente.ID equals reserva.CLIENTE_ID
                        where reserva.CREATED_AT.Month == mes
                        select new
                        {
                            res = cliente.NOMBRE
                        };
                return x.Count();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public object[] menusVendidos(int mes)
        {
            try
            {
                var x = from m in conexion.Entidad.MENU
                        join p in conexion.Entidad.PEDIDO on m.ID equals p.MENU_ID
                        where p.CREATED_AT.Month == mes
                        group m by p.MENU.NOMBRE into g
                        select new
                        {
                            menu = g.Key,
                            abc = g.Count()
                        };
                return x.ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
