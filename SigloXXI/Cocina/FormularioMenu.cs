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
        public FormularioMenu(Comandas comanda)
        {
            InitializeComponent();
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
                menu.Url = "Imagen del javier";
                menu.Estado = new Estado { Id = int.Parse(cboEstadoMenu.SelectedValue.ToString()) };

                if (menu.Agregar())                 
                {
                    txtNombreMenu.Clear();
                    txtPrecioMenu.Clear();
                    MetroFramework.MetroMessageBox.Show(this, "Se agrego el menu correctamente");
                }

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error al agregar el menu");
                throw;
            }
        }

       
    }
}
