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

namespace SigloXXI
{
    public partial class Inventario : MetroFramework.Forms.MetroForm
    {
        public Inventario()
        {
            InitializeComponent();
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Utilidades.cerrarSesion(this);
        }
    }
}
