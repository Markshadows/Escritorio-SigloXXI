using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DALC;
using Modelo;
using Vista.Administrador.Estadisticas;

namespace Vista.Administrador
{
    public partial class MenuAdministrador : Form
    {
        private int idMetrica;
        public MenuAdministrador()
        {
            InitializeComponent();
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
        }

        public void MenuAdministrador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.DTProveedor' Puede moverla o quitarla según sea necesario.
            this.dTProveedorTableAdapter.Fill(this.dS_Siglo21.DTProveedor);
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.DTUsuario' Puede moverla o quitarla según sea necesario.
            this.dTUsuarioTableAdapter.Fill(this.dS_Siglo21.DTUsuario);
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.DTMesa' Puede moverla o quitarla según sea necesario.
            this.dTMesaTableAdapter.Fill(this.dS_Siglo21.DTMesa);
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.DTProducto' Puede moverla o quitarla según sea necesario.
            this.dTProductoTableAdapter.Fill(this.dS_Siglo21.DTProducto);
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.PROVEEDOR' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORTableAdapter.Fill(this.dS_Siglo21.PROVEEDOR);
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.SOLICITUD' Puede moverla o quitarla según sea necesario.
            this.sOLICITUDTableAdapter.Fill(this.dS_Siglo21.SOLICITUD);
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.ESTADO_SOLICITUD' Puede moverla o quitarla según sea necesario.
            this.eSTADO_SOLICITUDTableAdapter.Fill(this.dS_Siglo21.ESTADO_SOLICITUD);
            cboMetrica.DataSource = Metrica.metricas();
            cboMetrica.DisplayMember = "Medida";
            cboMetrica.ValueMember = "Medida";


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

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            Utilidades.cerrarSesion(this);
        }

        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            new CRUDUsuario(this) { }.Show();
        }

        private void gridMesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Mesa m = new Mesa();
                m.Numero = int.Parse(gridMesas.Rows[e.RowIndex].Cells[0].Value.ToString()); ;
                m.Buscar();
                txtNroMesa.Text = m.Numero.ToString();
                txtCantSillasMesa.Text = m.CantSillas.ToString();
                tglEstadoMesa.Text = m.Estado.Nombre;
                return;
            }
            MetroFramework.MetroMessageBox.Show(this, "Seleccione una fila correcta", "Seleccionar Mesa");
        }

        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Producto p = new Producto();
                p.Codigo = gridProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                p.Buscar();
                txtCodigoProducto.Text = p.Codigo;
                txtNombreProducto.Text = p.Nombre;
                cboProveedor.SelectedValue = p.Proveedor.Id;
                cboMetrica.SelectedValue = p.Metrica.Medida;
                idMetrica = p.Metrica.Id;
                return;
            }
            MetroFramework.MetroMessageBox.Show(this, "Seleccione una fila correcta", "Seleccionar Producto");
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Metrica m = new Metrica();
                m.Medida = cboMetrica.SelectedValue.ToString();

                Producto p = new Producto();
                p.Codigo = txtCodigoProducto.Text;
                p.Nombre = txtNombreProducto.Text;
                p.Proveedor = new Proveedor { Id = int.Parse(cboProveedor.SelectedValue.ToString()) };
                p.Metrica = m;
                if (p.Agregar())
                {
                    MenuAdministrador_Load(sender, e);
                    MetroFramework.MetroMessageBox.Show(this, "Producto Agregado", "Agregar Producto");
                    return;
                }
                MetroFramework.MetroMessageBox.Show(this, "El producto número " + txtCodigoProducto.Text + " ya existe", "Agregar Producto");

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex.Message, "Agregar Mesa");
            }
        }

        private void ModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Metrica m = new Metrica();
                m.Id = idMetrica;
                m.Medida = cboMetrica.SelectedValue.ToString();

                Producto p = new Producto();
                p.Codigo = txtCodigoProducto.Text;
                p.Nombre = txtNombreProducto.Text;
                p.Proveedor = new Proveedor { Id = int.Parse(cboProveedor.SelectedValue.ToString()) };
                p.Metrica = m;
                if (p.Modificar())
                {
                    MenuAdministrador_Load(sender, e);
                    MetroFramework.MetroMessageBox.Show(this, "Producto Modificado", "Modificar Producto");
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex.Message, "Modificar Producto");
            }
        }

        private void AgregarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                Mesa m = new Mesa();
                m.Numero = int.Parse(txtNroMesa.Text);
                m.CantSillas = int.Parse(txtCantSillasMesa.Text);
                m.Estado = new Estado { Id = int.Parse(tglEstadoMesa.Text.Equals("Off") ? "2" : "1") };
                if (m.Agregar())
                {
                    MenuAdministrador_Load(sender, e);
                    MetroFramework.MetroMessageBox.Show(this, "Mesa Agregada", "Agregar Mesa");
                    return;
                }
                MetroFramework.MetroMessageBox.Show(this, "La mesa número " + txtNroMesa.Text + " ya existe", "Agregar Mesa");

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex.Message, "Agregar Mesa");
            }
        }

        private void ModificarMesa_Click(object sender, EventArgs e)
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

        private void gridSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Solicitud p = new Solicitud();
                p.Id = int.Parse(gridSolicitudes.Rows[e.RowIndex].Cells[0].Value.ToString());
                p.Buscar();
                cboEstadoSolicitud.SelectedValue = p.EstadoSolicitud.Id;
                txtIdSolicitud.Text = p.Id.ToString();
                return;
            }
            MetroFramework.MetroMessageBox.Show(this, "Seleccione una fila correcta", "Seleccionar Producto");
        }

        private void ModificarSolicitud_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud m = new Solicitud();
                m.Id = int.Parse(txtIdSolicitud.Text);
                m.EstadoSolicitud = new EstadoSolicitud { Id = int.Parse(cboEstadoSolicitud.SelectedValue.ToString()) };
                if (m.Modificar())
                {
                    MenuAdministrador_Load(sender, e);
                    MetroFramework.MetroMessageBox.Show(this, "Solicitud Modificada", "Modificar Solicitud");
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex.Message, "Modificar Mesa");
            }
        }

        private void gridProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Run = gridProveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
                proveedor.Buscar();
                new CRUDProveedor(this, proveedor) { }.Show();
                return;
            }
            MetroFramework.MetroMessageBox.Show(this, "Seleccione una fila correcta", "Seleccionar Proveedor");
        }

        private void AgregarProveedor_Click(object sender, EventArgs e)
        {
            new CRUDProveedor(this) { }.Show();
        }

        private void btnEstdsUsuarios_Click(object sender, EventArgs e)
        {
            new EstatsUsuario().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilidades.cerrar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Utilidades.minimizar(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MenuAdministrador_Load(sender, e);
        }
    }
}
