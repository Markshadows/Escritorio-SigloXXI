using DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Proveedor Proveedor { get; set; }
        public Metrica Metrica { get; set; }

        private Contexto conexion;

        public Producto()
        {
            conexion = new Contexto();
        }

        //    public bool Agregar()
        //    {
        //        try
        //        {
        //            if (Buscar() == false)
        //            {
        //                PRODUCTO producto = new PRODUCTO();
        //                producto.ID = conexion.Entidad.Database.SqlQuery<byte>("SELECT SEQ_PRODUCTO_IDPRODUCTO.NEXTVAL FROM dual").First();
        //                producto.CODIGO = Codigo;
        //                producto.NOMBRE = Nombre;
        //                producto.PROVEEDOR_ID = Proveedor.Id;
        //                producto.METRICA_ID = Metrica.Id;
        //                conexion.Entidad.PRODUCTO.Add(producto);
        //                conexion.Entidad.SaveChanges();
        //                return true;
        //            }
        //            return false;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex);
        //            return false;
        //        }
        //    }
        ////    public bool Buscar()
        ////    {
        ////        try
        ////        {
        ////            //PRODUCTO producto = conexion.Entidad.PRODUCTO
        ////            //    .First(p => p.CODIGO.Equals(Codigo));
        ////            //Codigo = (int)producto.CODIGO;
        ////            //CantSillas = (int)mesa.SILLAS;
        ////            //Estado = new Estado { Id = (int)mesa.ESTADO };
        ////            //return true;
        ////        }
        ////        catch (Exception ex)
        ////        {
        ////            Console.WriteLine(ex);
        ////            return false;
        ////        }
        ////    }
        ////    public bool Modificar()
        ////    {
        ////        try
        ////        {
        ////            //MESA mesa = conexion.Entidad.MESA
        ////            //    .First(p => p.NUMERO == Numero);
        ////            //mesa.NUMERO = Numero;
        ////            //mesa.SILLAS = CantSillas;
        ////            //mesa.ESTADO = Estado.Id;
        ////            //conexion.Entidad.SaveChanges();
        ////            //return true;
        ////        }
        ////        catch (Exception ex)
        ////        {
        ////            return false;
        ////        }
        ////    }
        ////}
    }
}
