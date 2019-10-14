using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALC;

namespace Modelo
{
    public class Metrica
    {
        public int Id { get; set; }
        public int Peso { get; set; }
        public string Medida { get; set; }


        private Contexto conexion;

        public Metrica()
        {
            conexion = new Contexto();
        }

        public int Agregar()
        {
            try
            {
                METRICA metrica = new METRICA();
                metrica.ID = conexion.Entidad.Database.SqlQuery<int>("SELECT SEQ_METRICA_IDMETRICA.NEXTVAL FROM dual").First();
                metrica.PESO = Peso;
                metrica.MEDIDA = Medida;
                conexion.Entidad.METRICA.Add(metrica);
                conexion.Entidad.SaveChanges();
                return (int)metrica.ID;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }











    }
}

