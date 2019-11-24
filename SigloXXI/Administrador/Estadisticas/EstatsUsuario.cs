using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Modelo;

namespace Vista.Administrador.Estadisticas
{
    public partial class EstatsUsuario : MetroFramework.Forms.MetroForm
    {
        public EstatsUsuario()
        {
            InitializeComponent();
            CargarGrafico();
            graficoClientesMes();
        }

        private void CargarGrafico ()
        {
            chart1.Series.Clear();
            //chart1.DataSource = dS_Siglo21.DTUsuario.Where(p => p.TIPO.Equals("Mesero")).Count();
            Series series = new Series("Mesero");
            Series series2 = new Series("Administrador");
            Series series3 = new Series("Cocina");
            Series series4 = new Series("Finanzas");
            Series series5 = new Series("Bodega");
            chart1.Series.Add(series);
            chart1.Series["Mesero"].Points.AddXY("Mesero", new Modelo.Usuario().cantidadPorRol("MESERO"));
            chart1.Series.Add(series2);
            chart1.Series["Administrador"].Points.AddXY("Administrador", new Modelo.Usuario().cantidadPorRol("ADM"));
            chart1.Series.Add(series3);
            chart1.Series["Cocina"].Points.AddXY("Cocina", new Modelo.Usuario().cantidadPorRol("COCINA"));
            chart1.Series.Add(series4);
            chart1.Series["Finanzas"].Points.AddXY("Finanzas", new Modelo.Usuario().cantidadPorRol("FINANZAS"));
            chart1.Series.Add(series5);
            chart1.Series["Bodega"].Points.AddXY("Bodega", new Modelo.Usuario().cantidadPorRol("BODEGA"));
        }

        private void graficoClientesMes()
        {
            chart2.Series.Clear();
            //chart1.DataSource = dS_Siglo21.DTUsuario.Where(p => p.TIPO.Equals("Mesero")).Count();
            Series series = new Series("Septiembre");
            Series series2 = new Series("Octubre");
            Series series3 = new Series("Noviembre");
            chart2.Series.Add(series);
            chart2.Series["Septiembre"].Points.AddXY("Septiembre", new Informe().cantidadMensual(9));
            chart2.Series.Add(series2);
            chart2.Series["Octubre"].Points.AddXY("Octubre", new Informe().cantidadMensual(10));
            chart2.Series.Add(series3);
            chart2.Series["Noviembre"].Points.AddXY("Noviembre", new Informe().cantidadMensual(11));
        }

        private void btnVolverEstsUsuario_Click(object sender, EventArgs e)
        {
            new MenuAdministrador().Show();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CargarGrafico();
        }
    }
}
