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
using DALC;

namespace Vista.Cocina
{
    public partial class FormularioIngrediente : MetroFramework.Forms.MetroForm
    {
        public FormularioIngrediente(Comandas comanda)
        {
            InitializeComponent();
        }

        public FormularioIngrediente()
        {
            InitializeComponent();
        }

        private void bntGuardarIngrediente_Click(object sender, EventArgs e)
        {
            //Guardaremos primero una clase metrica para nuestra entidad ingrediente
            Metrica metrica     = new Metrica();
            metrica.Medida      = cboMedidaIngrediente.SelectedItem.ToString();
            metrica.Peso        = int.Parse(txtPesoIngrediente.Text);
            //Rescatamos el id de la metrica para guardarlo en la entidad ingrediente
            int idMetrica       = metrica.Agregar();
            if (idMetrica == 0)
            {
                //Aca caera si no se puede agregar la metrica. Mandamos el mensaje
                txtPesoIngrediente.Clear();
                MetroFramework.MetroMessageBox.Show(this, "No se pudo agregar el ingrediente.");
            }
            //Crearemos un ingrediente con la metrica correspondiente agregada
            Ingrediente ing     = new Ingrediente();
            ing.Cantidad        = int.Parse(txtCantidadIngrediente.Text);
            ing.Nombre          = txtNombreIngrediente.Text;
            ing.Menu            = new Menu {Id = int.Parse(cboMenuIngrediente.SelectedValue.ToString()) };
           










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
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "No se pudo agregar el menu correctamente");
            }
        }

        private void FormularioIngrediente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCocina.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.dataSetCocina.PRODUCTO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetCocina.MENU' Puede moverla o quitarla según sea necesario.
            this.mENUTableAdapter.Fill(this.dataSetCocina.MENU);

        }
    }
}
