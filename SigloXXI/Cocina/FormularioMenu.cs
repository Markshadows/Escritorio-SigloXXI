using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Modelo;
using SigloXXI.Cocina;
using Renci.SshNet;

namespace Vista.Cocina
{
    public partial class FormularioMenu : Form
    {
        Comandas comandita;
        private string rutaImagen = "";
        private string nombreImagen = "";

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
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.ESTADO' Puede moverla o quitarla según sea necesario.
            this.eSTADOTableAdapter.Fill(this.dS_Siglo21.ESTADO);


        }

        private void btnGuardarMenu_Click(object sender, EventArgs e)
        {
            try
            {
               
                Modelo.Menu menu = new Modelo.Menu();
                menu.Nombre = txtNombreMenu.Text;
                menu.Precio = int.Parse(txtPrecioMenu.Text);
                menu.Url = lblImagenSubida.Text;              
                menu.Estado = new Estado { Id = int.Parse(cboEstadoMenu.SelectedValue.ToString()) };
                //Validamos que los campos no se encuentren vacios
                if (txtNombreMenu.Text.Trim().Equals("") || txtPrecioMenu.Text.Trim().Equals(""))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los campos nombre y precio son obligatorios");
                }
                //Validamos que la imagen venga cargada
                if (lblImagenSubida.Text.Trim().Equals(""))
                {
                    MetroFramework.MetroMessageBox.Show(this, "El campo de imagen es obligatorio");
                }
                
                if (menu.Agregar())
                {
                    Send(rutaImagen, nombreImagen);
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
            rutaImagen = "";
            nombreImagen = "";
        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            //Subiremos la imagen con la clase OpenFileDialog
            OpenFileDialog subirImagen = new OpenFileDialog();
            //Indicamos el formato de la imagen que tiene que subirse
            subirImagen.Filter = "Archivos de imagen (JPG)|*.jpg";
            //Directorio donde se abrira el explorer
            subirImagen.InitialDirectory = "C:\\";
            //Preguntamos si la imagen se selecciono correctamente

        if (subirImagen.ShowDialog() == DialogResult.OK)
        {
            lblImagenSubida.Text = subirImagen.SafeFileName;
                rutaImagen = subirImagen.FileName;
                nombreImagen = subirImagen.SafeFileName;
                //Aca entra si la imagen fue JPG y la monta en el picture box                          
                //pictureMenu.ImageLocation = subirImagen.FileName;
                pictureMenu.ImageLocation = subirImagen.FileName;
                pictureMenu.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        }
        public void Send(string fileName, string nombre)
        {
            var connectionInfo = new ConnectionInfo("0.tcp.ngrok.io", 18041, "crow", new PasswordAuthenticationMethod("crow", "crow2680"));
            // Upload File
            using (var sftp = new SftpClient(connectionInfo))
            {

                sftp.Connect();
                sftp.ChangeDirectory("/opt/glassfish5/glassfish/domains/domain1/applications/web_siglo_xxi/img");
                using (var uplfileStream = System.IO.File.OpenRead(fileName))
                {
                    sftp.UploadFile(uplfileStream, nombre, true);
                }
                sftp.Disconnect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilidades.minimizar(this);
        }

        private void btnCerrarFormMenu_Click(object sender, EventArgs e)
        {
            Utilidades.cerrarVentana(this);
        }
    }
}
