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

namespace Vista.Usuario
{
    public partial class IniciarSesion : MetroFramework.Forms.MetroForm
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string tipoUsuario = txtUsuario.Text;
            switch (tipoUsuario)
            {
                case "Administrador":
                    MenuAdministrador menuAdministrador = new MenuAdministrador();
                    menuAdministrador.Show();
                    this.Hide();
                    break;
                case "Bodega":
                    Inventario inventario = new Inventario();
                    inventario.Show();
                    this.Hide();
                    break;
                case "Caja":
                    MenuCaja menuCaja = new MenuCaja();
                    menuCaja.Show();
                    this.Hide();
                    break;
                case "ClienteMesa":
                    ClienteMesa clienteMesa = new ClienteMesa();
                    clienteMesa.Show();
                    this.Hide();
                    break;
                case "Cocina":
                    Comandas comandas = new Comandas();
                    comandas.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
