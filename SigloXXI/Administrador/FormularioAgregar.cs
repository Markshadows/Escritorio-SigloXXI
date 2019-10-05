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
            cargarDatosUsuario();
        }

        private void FormularioAgregar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetSigloXXI.ROL' Puede moverla o quitarla según sea necesario.
            this.rOLTableAdapter.Fill(this.dataSetSigloXXI.ROL);
            // TODO: esta línea de código carga datos en la tabla 'dataSetSigloXXI.COMUNA' Puede moverla o quitarla según sea necesario.
            this.cOMUNATableAdapter.Fill(this.dataSetSigloXXI.COMUNA);
            // TODO: esta línea de código carga datos en la tabla 'dataSetSigloXXI.CIUDAD' Puede moverla o quitarla según sea necesario.
            this.cIUDADTableAdapter.Fill(this.dataSetSigloXXI.CIUDAD);
            // TODO: esta línea de código carga datos en la tabla 'dataSetSigloXXI.PAIS' Puede moverla o quitarla según sea necesario.
            this.pAISTableAdapter.Fill(this.dataSetSigloXXI.PAIS);

        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {

                Direccion direccion = new Direccion();
                direccion.Calle = txtCalle.Text;
                direccion.Numero = txtNro.Text;
                direccion.Piso = txtPiso.Text;
                direccion.Departamento = txtDpto.Text;
                direccion.Otro = txtOtro.Text;
                direccion.Pais = new Pais { Id = int.Parse(cboPais.SelectedValue.ToString()) };
                direccion.Comuna = new Comuna { Id = int.Parse(cboComuna.SelectedValue.ToString()) };
                direccion.Ciudad = new Ciudad { Id = int.Parse(cboCiudad.SelectedValue.ToString()) };
                int idDireccion = direccion.Agregar();

                Modelo.Usuario usuario = new Modelo.Usuario();
                usuario.Nombre = txtNombre.Text;
                usuario.Apellidos = txtApellidos.Text;
                usuario.Correo = txtCorreo.Text;
                usuario.Contrasena = txtContrasena.Text;
                usuario.Rut = txtRut.Text;
                usuario.Telefono = int.Parse(txtTelefono.Text);
                usuario.Rol = new Rol { Id = int.Parse(cboTipo.SelectedValue.ToString()) };
                usuario.Direccion = new Direccion { Id = idDireccion };
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

                    Direccion direccion = new Direccion();
                    direccion.Id = usu.Direccion.Id;
                    direccion.Buscar();

                    txtCalle.Text = direccion.Calle;
                    txtNro.Text = direccion.Numero;
                    txtPiso.Text = direccion.Piso;
                    txtDpto.Text = direccion.Departamento;
                    txtOtro.Text = direccion.Otro;
                    cboPais.SelectedValue = 5;
                    cboCiudad.SelectedValue = 5;
                    cboComuna.SelectedValue = 5;

                    btnGuardarUsuario.Enabled = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
