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
using Modelo;

namespace Vista.Administrador
{
    public partial class MenuAdministrador : MetroFramework.Forms.MetroForm
    {
        public MenuAdministrador()
        {
            InitializeComponent();
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
        }

        public void MenuAdministrador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetSigloXXI.DTMesa' Puede moverla o quitarla según sea necesario.
            this.dTMesaTableAdapter.Fill(this.dataSetSigloXXI.DTMesa);
            // TODO: esta línea de código carga datos en la tabla 'dataSetSigloXXI.DTUsuario' Puede moverla o quitarla según sea necesario.
            this.dTUsuarioTableAdapter.Fill(this.dataSetSigloXXI.DTUsuario);
            // TODO: esta línea de código carga datos en la tabla 'dataSetSigloXXI.DTUsuario' Puede moverla o quitarla según sea necesario.
            this.dTUsuarioTableAdapter.Fill(this.dataSetSigloXXI.DTUsuario);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Modelo.Usuario usuario = new Modelo.Usuario();
            //    usuario.Nombre = txtNombre.Text;
            //    usuario.Appaterno = txtAppaterno.Text;
            //    usuario.Apmaterno = txtApmaterno.Text;
            //    usuario.Correo = txtCorreo.Text;
            //    usuario.Contrasena = txtContrasena.Text;
            //    usuario.Rut = txtRut.Text;
            //    usuario.Telefono = int.Parse(txtTelefono.Text);
            //    usuario.Direccion = txtDireccion.Text;
            //    usuario.Tipo = int.Parse(cboTipo.SelectedValue.ToString());
            //    usuario.Estado = int.Parse(cboEstado.SelectedValue.ToString());
            //    if (usuario.Agregar())
            //    {
            //        MenuAdministrador_Load(sender, e);
            //        MetroFramework.MetroMessageBox.Show(this, "Usuario Agregado", "Agregar Usuario");
            //    }
            //    limpiarFormulario();

            //}
            //catch (Exception ex)
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Error al agregar" + ex, "Agregar Usuario");
            //    limpiarFormulario();
            //}
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Usuario usuario = new Modelo.Usuario();
                usuario.Rut = txtBuscarRut.Text;
                if (usuario.Buscar())
                {
                    //txtNombre.Text = usuario.Nombre;
                    //txtRut.Text = usuario.Rut;
                    //txtContrasena.Text = usuario.Contrasena;
                    //txtCorreo.Text = usuario.Correo;
                    //txtAppaterno.Text = usuario.Appaterno;
                    //txtApmaterno.Text = usuario.Apmaterno;
                    //txtTelefono.Text = usuario.Telefono.ToString();
                    //txtDireccion.Text = usuario.Direccion;
                    //cboTipo.SelectedValue = usuario.Tipo;
                    //cboEstado.SelectedValue = usuario.Estado;
                    //btnAgregar.Enabled = false;
                    new CRUDUsuario(this, usuario) { }.Show();


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
            //txtNombre.Text = "";
            //txtRut.Text = "";
            //txtContrasena.Text = "";
            //txtCorreo.Text = "";
            //txtAppaterno.Text = "";
            //txtApmaterno.Text = "";
            //txtTelefono.Text = "";
            //txtDireccion.Text = "";
            //cboTipo.SelectedItem = 1;
            //cboEstado.SelectedItem = 1;
            //btnAgregar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Modelo.Usuario usuario = new Modelo.Usuario();
            //    usuario.Rut = txtBuscarRut.Text;
            //    usuario.Nombre = txtNombre.Text;
            //    usuario.Contrasena = txtContrasena.Text;
            //    usuario.Correo = txtCorreo.Text;
            //    usuario.Appaterno = txtAppaterno.Text;
            //    usuario.Apmaterno = txtApmaterno.Text;
            //    usuario.Telefono = int.Parse(txtTelefono.Text);
            //    usuario.Direccion = txtDireccion.Text;
            //    usuario.Tipo = int.Parse(cboTipo.SelectedValue.ToString());
            //    usuario.Estado = int.Parse(cboEstado.SelectedValue.ToString());
            //    if (usuario.Modificar())
            //    {
            //        btnAgregar.Enabled = false;
            //        MenuAdministrador_Load(sender, e);
            //        MetroFramework.MetroMessageBox.Show(this, "Usuario Modificado", "Modificar Usuario");

            //    }
            //    else
            //    {
            //        MetroFramework.MetroMessageBox.Show(this, "No se pudo modificar", "Modificar Usuario");
            //    }
            //    limpiarFormulario();
            //}
            //catch (Exception ex)
            //{

            //    MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Modificar Usuario");
            //    limpiarFormulario();
            //}
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Utilidades.cerrarSesion(this);
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            new CRUDUsuario(this) { }.Show();
            //this.Close();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                Mesa m = new Mesa();
                m.Numero =  int.Parse(txtNroMesa.Text);
                m.CantSillas = int.Parse(txtCantSillasMesa.Text);
                m.Estado = new Estado { Id = int.Parse(tglEstadoMesa.Text.Equals("Off") ? "2" : "1") };
                if (m.Agregar())
                {
                    MenuAdministrador_Load(sender, e);
                    MetroFramework.MetroMessageBox.Show(this, "Mesa Agregada", "Agregar Mesa");
                    return;
                }
                MetroFramework.MetroMessageBox.Show(this, "La mesa número "+txtNroMesa.Text+" ya existe", "Agregar Mesa");

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex.Message, "Agregar Mesa");
            }
        }

        private void btnModificarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                Mesa m = new Mesa();
                m.Numero = int.Parse(txtNroMesa.Text);
                m.CantSillas = int.Parse(txtCantSillasMesa.Text);
                m.Estado = new Estado { Id = int.Parse(tglEstadoMesa.Text.Equals("Off") ? "2" : "1") };
                if (m.Modificar())
                {
                    MenuAdministrador_Load(sender, e);
                    MetroFramework.MetroMessageBox.Show(this, "Mesa Modificada", "Modificar Mesa");
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex.Message, "Modificar Mesa");
            }
        }

        private void metroGrid5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Mesa m = new Mesa();
                m.Numero = int.Parse(metroGrid5.Rows[e.RowIndex].Cells[0].Value.ToString()); ;
                m.Buscar();
                txtNroMesa.Text = m.Numero.ToString();
                txtCantSillasMesa.Text = m.CantSillas.ToString();
                tglEstadoMesa.Text = m.Estado.Nombre;
                return;
            }
            MetroFramework.MetroMessageBox.Show(this, "Seleccione una fila correcta", "Seleccionar Mesa");
        }
    }
}
