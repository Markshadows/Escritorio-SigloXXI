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
                menu.URL = Url;
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

        public bool CambiarEstado(int id)
        {
            MENU menu = conexion.Entidad.MENU
                    .First(p => p.ID == id);

            int eliminar = Decimal.ToInt32(menu.ID);
            if (String.IsNullOrEmpty(eliminar.ToString()))
            {
                //Significa que la cadena esta vacia.
                return false;
            }
            else
            {
                //Significa que la cadena cotiene un valor.
                if (menu.ESTADO == 1)
                {
                    //El estado es activo
                    int updateMenu = conexion.Entidad.Database.ExecuteSqlCommand
                        ("UPDATE menu SET estado = 2 WHERE id = " + menu.ID);
                    conexion.Entidad.SaveChanges();                  
                    return true;
                }
                if (menu.ESTADO == 2)
                {
                    //El estado esta inactivo
                    int updateMenu = conexion.Entidad.Database.ExecuteSqlCommand
                        ("UPDATE menu SET estado = 1 WHERE id = " + menu.ID);
                    conexion.Entidad.SaveChanges();
                    return true;
                }

                //Significa que no entro en ningun estado
                return false;
                
            }

            
        }

        public bool Modificar()
        {
            try
            {
                MENU menu = conexion.Entidad.MENU
                    .First(m => m.ID == Id);
                menu.ID = Id;
                menu.NOMBRE = Nombre;
                menu.PRECIO = Precio;
                menu.URL = Url;
                menu.ESTADO = Estado.Id;
                conexion.Entidad.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public MENU DevolverMenu(int id)
        {
            try
            {

                MENU menu = conexion.Entidad.MENU
                    .First(m => m.ID == Id);
                menu.ID = Id;
                menu.NOMBRE = Nombre;
                menu.PRECIO = Precio;
                menu.URL = Url;
                menu.ESTADO = Estado.Id;
                conexion.Entidad.SaveChanges();
                return menu;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }










        public string TraerImagen(int id) {
            //Creamos variable a retornar. Se inicializa vacia
            string url = "";
            //traemos el objeto menu segun su id
            MENU menu = conexion.Entidad.MENU
                    .First(p => p.ID == id);

            url = menu.URL;

            return url;
        }


    }
}

