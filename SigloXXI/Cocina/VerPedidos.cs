using Modelo;
using SigloXXI.Cocina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Cocina
{
    public partial class VerPedidos : Form
    {


        public VerPedidos(Comandas comanda)
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        public VerPedidos()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            VerPedidos_Load(sender,e);
        }

        public void crearPicture()
        {
            /*Modelo.Menu m = new Modelo.Menu();

            var panel = new FlowLayoutPanel();
            panel.SuspendLayout(); // don't calculate the layout before all picture boxes are added
            panel.Size = new Size(491, 152);
            panel.Location = new Point(12, 12);
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.AutoScroll = true; // automatically add scrollbars if needed
            panel.WrapContents = false; // all picture boxes in a single row
            this.Controls.Add(panel);

            foreach (var item in m.listaMenus())
            {
                var pictureBox = new PictureBox();
                // the location is calculated by the FlowLayoutPanel
                pictureBox.Size = new Size(75, 75);
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.ImageLocation = "https://5d26518b.ngrok.io/" + item.Url;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                panel.Controls.Add(pictureBox);

                var lbl
            }

            panel.ResumeLayout();

            
            //int contador = 50;
            //foreach (var item in m.listaMenus())
            //{
            //    var picture = new PictureBox
            //    {
            //        Name = "pictureBox"+item.Id.ToString(),
            //        Size = new Size(200, 200),
            //        Location = new Point(100+contador++, 100+contador++),

            //    };
            //    this.Controls.Add(picture);
            //    //picture.Image = new System.Drawing.Bitmap("https://ee017ace.ngrok.io/1.jpg");
            //    picture.ImageLocation = "https://5d26518b.ngrok.io/1.jpg";
            //    picture.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
            */
        }

        private void btnMinPedido_Click(object sender, EventArgs e)
        {
            Utilidades.minimizar(this);
        }

        private void btnCerrarPedido_Click(object sender, EventArgs e)
        {
            Utilidades.cerrarVentana(this);
        }

        private void VerPedidos_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = new Pedido().listaPedidos();

        }

        private void metroGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            const string mensaje = "¿El pedido está listo?";
            const string caption = "------ Confirmar estado del pedido ------";
            var result = MessageBox.Show(mensaje, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                           object[] pedido = new object[3];
            pedido[0] = int.Parse(metroGrid1.Rows[metroGrid1.CurrentRow.Index].Cells[0].Value.ToString());
            pedido[1] = metroGrid1.Rows[metroGrid1.CurrentRow.Index].Cells[1].Value.ToString();
            pedido[2] = int.Parse(metroGrid1.Rows[metroGrid1.CurrentRow.Index].Cells[2].Value.ToString());
                if (new Pedido().PedidoListo(int.Parse(pedido[0].ToString())))
                {

                    MetroFramework.MetroMessageBox.Show(this, "Pedido Listo");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "No se pudo cambiarestado del pedido");
                }


            }
        }
    }
}
