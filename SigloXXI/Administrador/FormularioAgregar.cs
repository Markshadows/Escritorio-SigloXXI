using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Administrador
{
    public partial class FormularioAgregar : MetroFramework.Forms.MetroForm
    {
        MenuAdministrador menuAdm;
        Modelo.Usuario usu;
        public FormularioAgregar()
        {
            InitializeComponent();
        }

        public FormularioAgregar(MenuAdministrador menuAdministrador)
        {
            InitializeComponent();
            menuAdm = menuAdministrador;
        }

        public FormularioAgregar(MenuAdministrador menuAdministrador, Modelo.Usuario usuario)
        {
            InitializeComponent();
            menuAdm = menuAdministrador;
            usu = usuario;
        }

        private void FormularioAgregar_Activated(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetSigloXXI.ROL' Puede moverla o quitarla según sea necesario.
            this.rOLTableAdapter.Fill(this.dataSetSigloXXI.ROL);

            cargarDatosUsuario();

        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {

                Modelo.Usuario usuario = new Modelo.Usuario();
                usuario.Nombre = txtNombre.Text;
                usuario.Apellidos = txtApellidos.Text;
                usuario.Correo = txtCorreo.Text;
                usuario.Contrasena = txtContrasena.Text;
                usuario.Rut = txtRut.Text;
                usuario.Telefono = int.Parse(txtTelefono.Text);
                usuario.Rol = new Rol { Id = int.Parse(cboTipo.SelectedValue.ToString()) };
                usuario.Direccion = txtDireccion.Text;
                if (usuario.Agregar())
                {
                    menuAdm.MenuAdministrador_Load(sender, e);
                    MetroFramework.MetroMessageBox.Show(this, "Usuario Agregado", "Agregar Usuario");
                }
                //limpiarFormulario();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error al agregar" + ex, "Agregar Usuario");
                //limpiarFormulario();
            }
        }

        public void cargarDatosUsuario()
        {
            try
            {
                if (usu != null)
                {
                    txtNombre.Text = usu.Nombre;
                    txtRut.Text = usu.Rut;
                    txtContrasena.Text = usu.Contrasena;
                    txtCorreo.Text = usu.Correo;
                    txtApellidos.Text = usu.Apellidos;
                    txtTelefono.Text = usu.Telefono.ToString();
                    cboTipo.SelectedValue = usu.Rol.Id;
                    txtDireccion.Text = usu.Direccion;

                    btnGuardarUsuario.Enabled = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {

                Modelo.Usuario usuario = new Modelo.Usuario();
                usuario.Nombre = txtNombre.Text;
                usuario.Apellidos = txtApellidos.Text;
                usuario.Correo = txtCorreo.Text;
                usuario.Contrasena = txtContrasena.Text;
                usuario.Rut = txtRut.Text;
                usuario.Telefono = int.Parse(txtTelefono.Text);
                usuario.Rol = new Rol { Id = int.Parse(cboTipo.SelectedValue.ToString()) };
                usuario.Direccion = txtDireccion.Text;
                string msj = usuario.Modificar() ? "Modificó" : "No Modificó";
                Console.WriteLine(usuario.Nombre);
                
                if (usuario.Modificar())
                {
                    menuAdm.MenuAdministrador_Load(sender, e);
                    MetroFramework.MetroMessageBox.Show(this, "Usuario Modificado", "Modificar Usuario");

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "No se pudo modificar", "Modificar Usuario");
                }
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Modificar Usuario");
            }
        }
    }
}
