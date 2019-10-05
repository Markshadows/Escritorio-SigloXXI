using DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string Otro { get; set; }
        public Pais Pais { get; set; }
        public Comuna Comuna { get; set; }
        public Ciudad Ciudad { get; set; }

        private Contexto conexion;
        public Direccion()
        {
           conexion = new Contexto();
        }

        public int Agregar()
        {
            try
            {
                DIRECCION dir = new DIRECCION();
                dir.ID = conexion.Entidad.Database.SqlQuery<int>("SELECT SEQ_DIRECCION_IDDIRECCION.NEXTVAL FROM dual").First();
                dir.CALLE = Calle;
                dir.NUMERO = Numero;
                dir.PISO = Piso;
                dir.DEPARTAMENTO = Departamento;
                dir.OTRO = Otro;
                dir.PAIS_ID = Pais.Id;
                dir.COMUNA_ID = Comuna.Id;
                dir.CIUDAD_ID = Ciudad.Id;
                conexion.Entidad.DIRECCION.Add(dir);
                conexion.Entidad.SaveChanges();

                return (int)dir.ID;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }

        public bool Modificar()
        {
            try
            {
                DIRECCION dir = conexion.Entidad.DIRECCION
                    .First(p => p.ID == Id);
                dir.CALLE = Calle;
                dir.NUMERO = Numero;
                dir.PISO = Piso;
                dir.DEPARTAMENTO = Departamento;
                dir.OTRO = Otro;
                dir.PAIS_ID = Pais.Id;
                dir.COMUNA_ID = Comuna.Id;
                dir.CIUDAD_ID = Ciudad.Id;
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
                DIRECCION dir = conexion.Entidad.DIRECCION
                    .First(p => p.ID == Id);
                Calle = dir.CALLE;
                Numero = dir.NUMERO;
                Piso = dir.PISO;
                Departamento = dir.DEPARTAMENTO;
                Otro = dir.OTRO;
                Pais = new Pais { Id = (int)dir.PAIS_ID };
                Ciudad = new Ciudad { Id = (int)dir.CIUDAD_ID };
                Comuna = new Comuna { Id = (int)dir.COMUNA_ID };
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
