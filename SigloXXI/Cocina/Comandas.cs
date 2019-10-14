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
        }

        private void Comandas_Load(object sender, EventArgs e)
        {
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
    }
}
