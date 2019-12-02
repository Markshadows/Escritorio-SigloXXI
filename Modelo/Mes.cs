using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Mes
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public static List<Mes> meses()
        {
            try
            {
                return new List<Mes>
                {
                    new Mes
                    {
                        id = 1,
                        nombre = "Enero"
                    },
                    new Mes
                    {
                        id = 2,
                        nombre = "Febrero"
                    },
                    new Mes
                    {
                        id = 3,
                        nombre = "Marzo"
                    },
                    new Mes
                    {
                        id = 4,
                        nombre = "Abril"
                    },
                    new Mes
                    {
                        id = 5,
                        nombre = "Mayo"
                    },
                    new Mes
                    {
                        id = 6,
                        nombre = "Junio"
                    },
                    new Mes
                    {
                        id = 7,
                        nombre = "Julio"
                    },
                    new Mes
                    {
                        id = 8,
                        nombre = "Agosto"
                    },
                    new Mes
                    {
                        id = 9,
                        nombre = "Septiembre"
                    },
                    new Mes
                    {
                        id = 10,
                        nombre = "Octubre"
                    },
                    new Mes
                    {
                        id = 11,
                        nombre = "Noviembre"
                    },
                    new Mes
                    {
                        id = 12,
                        nombre = "Diciembre"
                    },
                };

            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
