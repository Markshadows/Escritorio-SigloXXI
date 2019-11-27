using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Metrica
    {
        public int Id { get; set; }
        public int Peso { get; set; }
        public string Medida { get; set; }

        public static List<Metrica> metricas()
        {
            try
            {
                return new List<Metrica>
                {
                    new Metrica
                    {
                        Id = 1,
                        Peso = 0,
                        Medida = "Kilogramos"
                    },
                    new Metrica
                    {
                        Id = 2,
                        Peso = 0,
                        Medida = "Gramos"
                    },
                    new Metrica
                    {
                        Id = 3,
                        Peso = 0,
                        Medida = "Litros"
                    },
                     new Metrica
                    {
                        Id = 3,
                        Peso = 0,
                        Medida = "Botellas"
                    },
                     new Metrica
                    {
                        Id = 3,
                        Peso = 0,
                        Medida = "Unidades"
                    },
                     new Metrica
                    {
                        Id = 3,
                        Peso = 0,
                        Medida = "Paquetes"
                    }
                };

            }
            catch (Exception)
            {

                return null;
            }
        }

        public int Agregar()
        {
            throw new NotImplementedException();
        }
    }
}
