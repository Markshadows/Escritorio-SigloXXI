using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALC;

namespace Modelo
{
    public class Menu
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Url { get; set; }
        public Estado Estado { get; set; }

        private Contexto conexion;

        public Menu()
        {
            conexion = new Contexto();
        }

        public bool Agregar()
        {
            try
            {
                MENU menu = new MENU();
                menu.ID = conexion.Entidad.Database.SqlQuery<int>("SELECT SEQ_MENU_IDMENU.NEXTVAL FROM dual").First();
                menu.NOMBRE = Nombre;
                menu.PRECIO = Precio;
                menu.ESTADO = Estado.Id;
                conexion.Entidad.MENU.Add(menu);
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

