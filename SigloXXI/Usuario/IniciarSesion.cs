using SigloXXI.Cocina;
using SigloXXI.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SigloXXI;
using Vista.Administrador;
using Vista.Finanzas;
using MetroFramework.Components;

namespace Vista.Usuario
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Modelo.Usuario usuario = new Modelo.Usuario();
            usuario.Correo = txtCorreo.Text;
            usuario.Contrasena = txtContrasena.Text;

            if (usuario.IniciarSesion())
            {
                switch (usuario.Rol.Id)
                {
                    case 1:
                        MenuAdministrador menuAdministrador = new MenuAdministrador();
                        menuAdministrador.Show();
                        this.Hide();
                        break;
                    case 2:
                        Comandas comandas = new Comandas();
                        comandas.Show();
                        this.Hide();
                        break;
                    case 3:
                        Inventario inventario = new Inventario();
                        inventario.Show();
                        this.Hide();
                        break;
                    case 4:
                        MenuCaja menuCaja = new MenuCaja();
                        menuCaja.Show();
                        this.Hide();
                        break;
                    case 5:
                        FormularioFinanzas formularioFinanzas = new FormularioFinanzas();
                        formularioFinanzas.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "El usuario no existe", "Iniciar Sesión", 100);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilidades.cerrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilidades.minimizar(this);
        }
    }
}
