using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;
using Vista.Cocina;

namespace SigloXXI.Cocina
{
    public partial class Comandas : Form
    {

        public Comandas()
        {
            InitializeComponent();
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        public void Comandas_Load(object sender, EventArgs e)
        {
            cargarTablas();
        }

        private void cargarTablas()
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.MENU' Puede moverla o quitarla según sea necesario.
            this.mENUTableAdapter.Fill(this.dS_Siglo21.MENU);
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.DTProducto' Puede moverla o quitarla según sea necesario.
            this.dTProductoTableAdapter.Fill(this.dS_Siglo21.DTProducto);
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.DTIngrediente' Puede moverla o quitarla según sea necesario.
            this.dTIngredienteTableAdapter.Fill(this.dS_Siglo21.DTIngrediente);
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.MENU' Puede moverla o quitarla según sea necesario.
            this.mENUTableAdapter.Fill(this.dS_Siglo21.MENU);
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.MENU' Puede moverla o quitarla según sea necesario.
            this.mENUTableAdapter.Fill(this.dS_Siglo21.MENU);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Utilidades.cerrarSesion(this);
        }

        private void btnCrearMenu_Click(object sender, EventArgs e)
        {
            //Redireccionamos a la vista para crear el menu
            new FormularioMenu(this) { }.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Redireccionamos a la vista para crear el ingrediente
            new FormularioIngrediente(this) { }.Show();
        }

     

        private void menuConEstadoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.mENUTableAdapter.MenuConEstado(this.dataSetCocina.MENU);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnVerPedidosMenu_Click(object sender, EventArgs e)
        {
            //Mostrar la ventana de pedidos
            new VerPedidos(this) { }.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            //cargarTablas();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnVerImagenMenu_Click(object sender, EventArgs e)
        {   
            //Seleccionamos el id de la posicion del gridView
            int url = int.Parse(metroGrid2.Rows[metroGrid2.CurrentRow.Index].Cells[0].Value.ToString());
            //Creamos una instancia de la clase menu para llamar el metodo que nos traera la ubicacion de la imagen
            Modelo.Menu menu = new Modelo.Menu();
            string nuestraimagen = menu.TraerImagen(url);
            //Verificamos que la grilla tenga valores
            if (metroGrid2.Rows.Count > 0)
            {
                lblVerID.Text = url.ToString();
                pictureMenuPrincipal.ImageLocation = Utilidades.nombreDnsHttp()+@nuestraimagen;
                pictureMenuPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void btnEliminarMenu_Click(object sender, EventArgs e)
        {
            const string mensaje = "Estas segura(o) que quieres modificar el estado de este menu?";
            const string caption = "------ Confirmacion de cambiar estado de menu ------";
            var result = MessageBox.Show(mensaje, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                //Seleccionamos el id de la posicion del gridView
                int remove = int.Parse(metroGrid2.Rows[metroGrid2.CurrentRow.Index].Cells[0].Value.ToString());
                //Creamos una instancia de la clase menu para llamar el metodo que nos traera la ubicacion de la imagen
                Modelo.Menu menu = new Modelo.Menu();
                if (menu.CambiarEstado(remove))
                {
                   
                    MetroFramework.MetroMessageBox.Show(this, "El estado del menu fue cambiado exitosamente!");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "No se pudo cambiar el estado del menu");
                }

                
            }

            
            
        }

        public void ChangeTextBoxText(string text)
        {
            lblVerID.Text = text;
        }

        private void btnModificarMenu_Click(object sender, EventArgs e)
        {
            //Seleccionamos el id de la posicion del gridView
            int id = int.Parse(metroGrid2.Rows[metroGrid2.CurrentRow.Index].Cells[0].Value.ToString());
            string nombre = metroGrid2.Rows[metroGrid2.CurrentRow.Index].Cells[1].Value.ToString();
            int precio = int.Parse(metroGrid2.Rows[metroGrid2.CurrentRow.Index].Cells[2].Value.ToString());
            int estado = int.Parse(metroGrid2.Rows[metroGrid2.CurrentRow.Index].Cells[3].Value.ToString());
            string url = new Modelo.Menu().TraerImagen(id);

            Modelo.Menu menu = new Modelo.Menu();
            menu.Id = id;
            menu.Nombre = nombre;
            menu.Precio = precio;
            menu.Estado = new Modelo.Estado { Id = estado};
            menu.Url = url;

            //Redireccionamos a la vista para crear el menu
            new ActualizarMenu(this, menu) { }.Show();
            


        }

        private void metroButtonIngre_Click(object sender, EventArgs e)
        {
            //Redireccionamos a la vista para crear el ingrediente
            new FormularioIngrediente(this) { }.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilidades.minimizar(this);
        }

        private void btnCerrarMenuCocina_Click(object sender, EventArgs e)
        {
            Utilidades.cerrarVentana(this);
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seleccionamos el id de la posicion del gridView
            int url = int.Parse(metroGrid2.Rows[metroGrid2.CurrentRow.Index].Cells[0].Value.ToString());
            //Creamos una instancia de la clase menu para llamar el metodo que nos traera la ubicacion de la imagen
            Modelo.Menu menu = new Modelo.Menu();
            string nuestraimagen = menu.TraerImagen(url);
            //Verificamos que la grilla tenga valores
            if (metroGrid2.Rows.Count > 0)
            {
                lblVerID.Text = url.ToString();
                pictureMenuPrincipal.ImageLocation = Utilidades.nombreDnsHttp() + @nuestraimagen;
                pictureMenuPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
    }
}
