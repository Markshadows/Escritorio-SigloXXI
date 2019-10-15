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
using SigloXXI.Cocina;

namespace Vista.Cocina
{
    public partial class FormularioMenu : MetroFramework.Forms.MetroForm
    {
        Comandas comandita;

        public FormularioMenu(Comandas comanda)
        {
            InitializeComponent();
            comandita = comanda;
        }

        public FormularioMenu()
        {
            InitializeComponent();
        }

        private void FormularioMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCocina.ESTADO' Puede moverla o quitarla según sea necesario.
            this.eSTADOTableAdapter.Fill(this.dataSetCocina.ESTADO);

        }

        private void btnGuardarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Menu menu = new Modelo.Menu();
                menu.Nombre = txtNombreMenu.Text;
                menu.Precio = int.Parse(txtPrecioMenu.Text);
                //Cargar aca la imagen rescatada por la ventana de usuario
                menu.Url = "Imagen del javier";                
                menu.Estado = new Estado { Id = int.Parse(cboEstadoMenu.SelectedValue.ToString()) };

                if (menu.Agregar())
                {
                    txtNombreMenu.Clear();
                    txtPrecioMenu.Clear();
                    //Cargamos el formulario de menu para ver los cambios 
                    comandita.Comandas_Load(sender,e);
                    MetroFramework.MetroMessageBox.Show(this, "Se agrego el menu correctamente");
                }
                else {
                    MetroFramework.MetroMessageBox.Show(this, "No se pudo agregar el menu correctamente");
                }

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error al agregar el menu");
                
            }
        }

        private void btnLimpiarMenu_Click(object sender, EventArgs e)
        {
            txtNombreMenu.Clear();
            txtPrecioMenu.Clear();
        }
    }
}
