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

        public bool Agregar()
        {
            try
            {
                if (Buscar() == false)
                {
                    METRICA m = new METRICA();
                    m.ID = conexion.Entidad.Database.SqlQuery<byte>("SELECT SEQ_METRICA_IDMETRICA.NEXTVAL FROM dual").First();
                    m.PESO = 0;
                    m.MEDIDA = Metrica.Medida;
                    conexion.Entidad.METRICA.Add(m);

                    PRODUCTO producto = new PRODUCTO();
                    producto.ID = conexion.Entidad.Database.SqlQuery<byte>("SELECT SEQ_PRODUCTO_IDPRODUCTO.NEXTVAL FROM dual").First();
                    producto.CODIGO = Codigo;
                    producto.NOMBRE = Nombre;
                    producto.PROVEEDOR_ID = Proveedor.Id;
                    producto.METRICA_ID = m.ID;
                    conexion.Entidad.PRODUCTO.Add(producto);

                    conexion.Entidad.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Buscar()
        {
            try
            {
                PRODUCTO producto = conexion.Entidad.PRODUCTO
                    .First(p => p.CODIGO.Equals(Codigo) || p.NOMBRE.Equals(Nombre));
                Codigo = producto.CODIGO;
                Nombre = producto.NOMBRE;
                Proveedor = new Proveedor { Id = (int)producto.PROVEEDOR_ID };
                Metrica = new Metrica { Id = (int)producto.METRICA_ID, Medida = producto.METRICA.MEDIDA};
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Modificar()
        {
            try
            {
                METRICA metrica = conexion.Entidad.METRICA
    .First(p => p.ID == Metrica.Id);
                metrica.MEDIDA = Metrica.Medida;

                PRODUCTO producto = conexion.Entidad.PRODUCTO
                    .First(p => p.CODIGO.Equals(Codigo));
                producto.CODIGO = Codigo;
                producto.NOMBRE = Nombre;
                producto.PROVEEDOR_ID = Proveedor.Id;
                producto.METRICA.ID = Metrica.Id;

                conexion.Entidad.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
