using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Finanzas
{
    public partial class FormularioFinanzas : MetroFramework.Forms.MetroForm
    {
        public FormularioFinanzas()
        {
            InitializeComponent();
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Utilidades.cerrarSesion(this);
        }
    }
}
