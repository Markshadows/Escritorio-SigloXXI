using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALC;

namespace Modelo
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
        public Menu Menu { get; set; }
        public Producto Producto { get; set; }
        public Metrica Metrica { get; set; }


        private Contexto conexion;

        public Ingrediente()
        {
            conexion = new Contexto();
        }

        public bool Agregar()
        {
            try
            {
                INGREDIENTE ingrediente = new INGREDIENTE();
                ingrediente.ID = 0;
                ingrediente.CANTIDAD = Cantidad;
                ingrediente.NOMBRE = Nombre;
                ingrediente.MENU_ID = Menu.Id;
                ingrediente.PRODUCTO_ID = (byte)Producto.Id;
                ingrediente.METRICA_ID = Metrica.Id;
                conexion.Entidad.INGREDIENTE.Add(ingrediente);
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