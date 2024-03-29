﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALC;
using Modelo;
using SigloXXI.Cocina;

namespace Vista.Cocina
{
    public partial class ActualizarMenu : Form
    {
        Comandas comandita;
        private Modelo.Menu menu;

        public ActualizarMenu(Comandas comanda)
        {
            InitializeComponent();            
        }

        public ActualizarMenu(Comandas comanda, Modelo.Menu menu)
        {
            InitializeComponent();
            comandita = comanda;
            this.menu = menu;
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
                lblImagenSubida.Text = subirImagen.FileName;
                //Aca entra si la imagen fue JPG y la monta en el picture box                          
                pictureMenu.ImageLocation = subirImagen.FileName;
                pictureMenu.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void btnGuardarMenu_Click(object sender, EventArgs e)
        {   //Boton para actualizar menu
            try
            {

                Modelo.Menu menu = new Modelo.Menu();
                menu.Id = this.menu.Id;
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

                if (menu.Modificar())
                {
                    txtNombreMenu.Clear();
                    txtPrecioMenu.Clear();
                    //Cargamos el formulario de menu para ver los cambios 
                    comandita.Comandas_Load(sender, e);
                    Close();
                    MetroFramework.MetroMessageBox.Show(this, "Se actualizo el menu correctamente");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "No se pudo actualizar el menu correctamente");
                }

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error al actualizar el menu");

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

        private void ActualizarMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Siglo21.ESTADO' Puede moverla o quitarla según sea necesario.
            this.eSTADOTableAdapter.Fill(this.dS_Siglo21.ESTADO);
            txtNombreMenu.Text = this.menu.Nombre;
            txtPrecioMenu.Text = this.menu.Precio.ToString();
            cboEstadoMenu.SelectedValue = this.menu.Estado.Id;
            lblImagenSubida.Text = this.menu.Url;
            pictureMenu.ImageLocation = Utilidades.nombreDnsHttp() + this.menu.Url;

        }
    }
}

    

