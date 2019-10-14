using DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Mesa
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int CantSillas { get; set; }
        public Estado Estado { get; set; }

        private Contexto conexion;

        public Mesa()
        {
            conexion = new Contexto();
        }

        public bool Agregar()
        {
            try
            {
                if (Buscar()==false)
                {
                    MESA mesa = new MESA();
                    mesa.ID = conexion.Entidad.Database.SqlQuery<int>("SELECT SEQ_MESA_IDMESA.NEXTVAL FROM dual").First();
                    mesa.NUMERO = Numero;
                    mesa.SILLAS = CantSillas;
                    mesa.ESTADO = Estado.Id;
                    conexion.Entidad.MESA.Add(mesa);
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
                MESA mesa = conexion.Entidad.MESA
                    .First(p => p.NUMERO == Numero);
                Numero = (int)mesa.NUMERO;
                CantSillas = (int)mesa.SILLAS;
                Estado = new Estado { Id = (int)mesa.ESTADO };
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
                MESA mesa = conexion.Entidad.MESA
                    .First(p => p.NUMERO == Numero);
                mesa.NUMERO = Numero;
                mesa.SILLAS = CantSillas;
                mesa.ESTADO = Estado.Id;
                conexion.Entidad.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
