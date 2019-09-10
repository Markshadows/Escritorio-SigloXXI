using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALC;

namespace Vista.Administrador
{
    public partial class MenuAdministrador : MetroFramework.Forms.MetroForm
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetSigloXXI.USUARIO' Puede moverla o quitarla según sea necesario.
            this.uSUARIOTableAdapter.Fill(this.dataSetSigloXXI.USUARIO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetSigloXXI.TIPO_USUARIO' Puede moverla o quitarla según sea necesario.
            this.tIPO_USUARIOTableAdapter.Fill(this.dataSetSigloXXI.TIPO_USUARIO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetSigloXXI.USUARIO_ESTADO' Puede moverla o quitarla según sea necesario.
            this.uSUARIO_ESTADOTableAdapter.Fill(this.dataSetSigloXXI.USUARIO_ESTADO);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                Modelo.Usuario usuario = new Modelo.Usuario();
                usuario.Id = random.Next(1, 100);
                usuario.Nombre = txtNombre.Text;
                usuario.Appaterno = txtAppaterno.Text;
                usuario.Apmaterno = txtApmaterno.Text;
                usuario.Correo = txtCorreo.Text;
                usuario.Contrasena = txtContrasena.Text;
                usuario.Rut = txtRut.Text;
                usuario.Telefono = int.Parse(txtTelefono.Text);
                usuario.Direccion = txtDireccion.Text;
                usuario.Tipo = int.Parse(cboTipo.SelectedValue.ToString());
                usuario.Estado = int.Parse(cboEstado.SelectedValue.ToString());
                if (usuario.Agregar())
                {
                    MenuAdministrador_Load(sender, e);
                    MetroFramework.MetroMessageBox.Show(this, "Usuario Agregado", "Agregar Usuario");
                }
                limpiarFormulario();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error al agregar" + ex, "Agregar Usuario");
                limpiarFormulario();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Usuario usuario = new Modelo.Usuario();
                usuario.Rut = txtBuscarRut.Text;
                if (usuario.Buscar())
                {
                    txtNombre.Text = usuario.Nombre;
                    txtRut.Text = usuario.Rut;
                    txtContrasena.Text = usuario.Contrasena;
                    txtCorreo.Text = usuario.Correo;
                    txtAppaterno.Text = usuario.Appaterno;
                    txtApmaterno.Text = usuario.Apmaterno;
                    txtTelefono.Text = usuario.Telefono.ToString();
                    txtDireccion.Text = usuario.Direccion;
                    cboTipo.SelectedValue = usuario.Tipo;
                    cboEstado.SelectedValue = usuario.Estado;
                    btnAgregar.Enabled = false;

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "No existe el usuario", "Buscar Usuario");
                    limpiarFormulario();
                }
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Buscar Usuario");
                limpiarFormulario();
            }

        }

        private void limpiarFormulario()
        {
            txtNombre.Text = "";
            txtRut.Text = "";
            txtContrasena.Text = "";
            txtCorreo.Text = "";
            txtAppaterno.Text = "";
            txtApmaterno.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cboTipo.SelectedItem = 1;
            cboEstado.SelectedItem = 1;
            btnAgregar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Usuario usuario = new Modelo.Usuario();
                usuario.Rut = txtBuscarRut.Text;
                usuario.Nombre = txtNombre.Text;
                usuario.Contrasena = txtContrasena.Text;
                usuario.Correo = txtCorreo.Text;
                usuario.Appaterno = txtAppaterno.Text;
                usuario.Apmaterno = txtApmaterno.Text;
                usuario.Telefono = int.Parse(txtTelefono.Text);
                usuario.Direccion = txtDireccion.Text;
                usuario.Tipo = int.Parse(cboTipo.SelectedValue.ToString());
                usuario.Estado = int.Parse(cboEstado.SelectedValue.ToString());
                if (usuario.Modificar())
                {
                    btnAgregar.Enabled = false;
                    MenuAdministrador_Load(sender, e);
                    MetroFramework.MetroMessageBox.Show(this, "Usuario Modificado", "Modificar Usuario");

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "No se pudo modificar", "Modificar Usuario");
                }
                limpiarFormulario();
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Modificar Usuario");
                limpiarFormulario();
            }
        }
    }
}
