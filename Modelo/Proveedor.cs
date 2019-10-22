using DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Run { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string  Descripcion { get; set; }
        public string Direccion { get; set; }
        public Giro Giro { get; set; }
        public Estado Estado { get; set; }

        private Contexto conexion;

        public Proveedor()
        {
            conexion = new Contexto();
        }

        public bool Agregar()
        {
            try
            {
                if (Buscar() == false)
                {
                    PROVEEDOR proveedor = new PROVEEDOR();
                    proveedor.ID = conexion.Entidad.Database.SqlQuery<int>("SELECT SEQ_PROVEEDOR_IDPROVEEDOR.NEXTVAL FROM dual").First();
                    proveedor.RUN = Run;
                    proveedor.NOMBRE = Nombre;
                    proveedor.CORREO = Correo;
                    proveedor.TELEFONO = Telefono;
                    proveedor.DIRECCION = Direccion;
                    proveedor.DESCRIPCION = Descripcion;
                    proveedor.GIRO_ID = Giro.Id;
                    proveedor.ESTADO = Estado.Id;
                    conexion.Entidad.PROVEEDOR.Add(proveedor);
                    conexion.Entidad.SaveChanges();
                    return true;
                }
                return false;
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
                PROVEEDOR proveedor = conexion.Entidad.PROVEEDOR
                    .First(p => p.RUN == Run);
                Run = proveedor.RUN;
                Nombre = proveedor.NOMBRE;
                Telefono = proveedor.TELEFONO;
                Correo = proveedor.CORREO;
                Giro = new Giro { Id = (int)proveedor.GIRO_ID };
                Estado = new Estado { Id = (int)proveedor.ESTADO };
                Direccion = proveedor.DIRECCION;
                Descripcion = proveedor.DESCRIPCION;
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
                PROVEEDOR proveedor = conexion.Entidad.PROVEEDOR
                    .First(p => p.RUN == Run);
                proveedor.RUN = Run;
                proveedor.NOMBRE = Nombre;
                proveedor.CORREO = Correo;
                proveedor.TELEFONO = Telefono;
                proveedor.DIRECCION = Direccion;
                proveedor.DESCRIPCION = Descripcion;
                proveedor.GIRO_ID = Giro.Id;
                proveedor.ESTADO = Estado.Id;
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
