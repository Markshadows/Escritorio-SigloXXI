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

        public static void minimizar(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public static void cerrar()
        {
            Application.Exit();
        }

        public static void cerrarVentana(Control control)
        {
            control.Hide();
        }

        public static string nombreDnsHttp()
        {
            return "https://ef39c903.ngrok.io/";
        }

        public static string nombreUsuario()
        {
            return "crow";
        }

        public static string contrasena()
        {
            return "crow2680";
        }

        public static int puertoSSH()
        {
            return 13923;
        }

        public static string carpetaIMG()
        {
            return "/opt/glassfish5/glassfish/domains/domain1/applications/web_siglo_xxi/img";
        }
    }
}
