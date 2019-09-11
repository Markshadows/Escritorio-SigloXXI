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

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Utilidades.cerrarSesion(this);
        }
    }
}
