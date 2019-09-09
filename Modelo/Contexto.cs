using DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto
    {
        private static Entidades conexion;

        public Entidades Entidad
        {
            get
            {
                if (conexion == null)
                    conexion = new Entidades();
                return conexion;
            }
        }
    }
}
