using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Usuario;

namespace Vista
{
    public class Utilidades
    {
        public static void cerrarSesion(Control control)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.Show();
            control.Hide();
        }
    }
}
