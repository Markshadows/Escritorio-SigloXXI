using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Vista.Administrador
{
    public partial class CRUDProveedor : MetroFramework.Forms.MetroForm
    {
        private MenuAdministrador menuAdministrador;
        private Proveedor proveedor;

        public CRUDProveedor()
        {
            InitializeComponent();
        }

        public CRUDProveedor(MenuAdministrador menuAdministrador, Proveedor proveedor)
        {
            InitializeComponent();
            this.menuAdministrador = menuAdministrador;
            this.proveedor = proveedor;
        }

        public CRUDProveedor(MenuAdministrador menuAdministrador)
        {
            InitializeComponent();
            this.menuAdministrador = menuAdministrador;
        }

        private void CRUDProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.ESTADO' Puede moverla o quitarla según sea necesario.
            this.eSTADOTableAdapter.Fill(this.dS_Siglo21.ESTADO);
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.GIRO' Puede moverla o quitarla según sea necesario.
            this.gIROTableAdapter.Fill(this.dS_Siglo21.GIRO);

            cargarProveedor();

        }

        private void AgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Nombre = txtNombreProveedor.Text;
                proveedor.Run = txtRutProveedor.Text;
                proveedor.Telefono = txtTelefonoProveedor.Text;
                proveedor.Correo = txtCorreoProveedor.Text;
                proveedor.Giro = new Giro { Id = int.Parse(cboGiroProveedor.SelectedValue.ToString()) };
                proveedor.Estado = new Estado { Id = int.Parse(cboEstadoProveedor.SelectedValue.ToString()) };
                proveedor.Descripcion = txtDescripcionProveedor.Text;
                proveedor.Direccion = txtDireccionProveedor.Text;
                if (proveedor.Agregar())
                {
                    menuAdministrador.MenuAdministrador_Load(sender, e);
                    MetroFramework.MetroMessageBox.Show(this, "Proveedor Agregado", "Agregar Proveedor");
                    return;
                }
                MetroFramework.MetroMessageBox.Show(this, "El proveedor ya existe", "Agregar Proveedor");
            }
            catch (Exception)
            {

            }
        }

        public void cargarProveedor()
        {
            try
            {
                if (proveedor != null)
                {
                    txtNombreProveedor.Text = proveedor.Nombre;
                    txtRutProveedor.Text = proveedor.Run;
                    txtTelefonoProveedor.Text = proveedor.Telefono;
                    txtCorreoProveedor.Text = proveedor.Correo;
                    cboGiroProveedor.SelectedValue = proveedor.Giro.Id;
                    cboEstadoProveedor.SelectedValue = proveedor.Estado.Id;
                    txtDescripcionProveedor.Text = proveedor.Descripcion;
                    txtDireccionProveedor.Text = proveedor.Direccion;

                    //btnGuardarUsuario.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
