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
    public partial class Comandas : MetroFramework.Forms.MetroForm
    {

        public Comandas()
        {
            InitializeComponent();
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        public void Comandas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetVistas.VISTA_PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.vISTA_PRODUCTOTableAdapter.VISTA_PRODUCTO(this.dataSetVistas.VISTA_PRODUCTO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetVistas.VISTA_INGREDIENTE' Puede moverla o quitarla según sea necesario.
            this.vISTA_INGREDIENTETableAdapter.VISTA_INGREDIENTE(this.dataSetVistas.VISTA_INGREDIENTE);
            // TODO: esta línea de código carga datos en la tabla 'dataSetVistas.VISTA_MENU' Puede moverla o quitarla según sea necesario.
            this.vISTA_MENUTableAdapter.Fill(this.dataSetVistas.VISTA_MENU);
            // TODO: esta línea de código carga datos en la tabla 'dataSetCocina.INGREDIENTE' Puede moverla o quitarla según sea necesario.
            this.iNGREDIENTETableAdapter.Fill(this.dataSetCocina.INGREDIENTE);
            // TODO: esta línea de código carga datos en la tabla 'dataSetCocina.MENU' Puede moverla o quitarla según sea necesario.
            this.mENUTableAdapter.Fill(this.dataSetCocina.MENU);
            // TODO: esta línea de código carga datos en la tabla 'dataSetCocina.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.dataSetCocina.PRODUCTO);

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
                this.mENUTableAdapter.MenuConEstado(this.dataSetCocina.MENU);
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
                pictureMenuPrincipal.ImageLocation = @nuestraimagen;
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
            lblVerID.Text = id.ToString();
            string menu = lblVerID.Text;
            //Redireccionamos a la vista para crear el menu
            new ActualizarMenu(this) { }.Show();


        }
    }
}
