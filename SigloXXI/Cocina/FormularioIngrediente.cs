﻿using System;
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
        Comandas ingredientito;

        public FormularioIngrediente(Comandas comanda)
        {
            InitializeComponent();
            ingredientito = comanda;
        }

        public FormularioIngrediente()
        {
            InitializeComponent();
        }

        private void bntGuardarIngrediente_Click(object sender, EventArgs e)
        {
            try
            {

                //Guardaremos primero una clase metrica para nuestra entidad ingrediente
                Metrica metrica          = new Metrica();
                metrica.Medida           = cboMedidaIngrediente.SelectedItem.ToString();
                metrica.Peso             = int.Parse(txtPesoIngrediente.Text);
                //Rescatamos el id de la metrica para guardarlo en la entidad ingrediente
                int idMetrica            = metrica.Agregar();
                if (idMetrica == 0)
                {
                    //Aca caera si no se puede agregar la metrica. Mandamos el mensaje
                    txtPesoIngrediente.Clear();
                    MetroFramework.MetroMessageBox.Show(this, "No se pudo agregar el ingrediente.");
                }
                //Crearemos un ingrediente con la metrica correspondiente agregada
                Ingrediente ing = new Ingrediente();
                ing.Cantidad = int.Parse(txtCantidadIngrediente.Text);
                ing.Nombre = txtNombreIngrediente.Text;
                ing.Menu = new Modelo.Menu { Id = int.Parse(cboMenuIngrediente.SelectedValue.ToString()) };
                ing.Producto = new Producto { Id = int.Parse(cboProductoIngrediente.SelectedValue.ToString()) };
                ing.Metrica = new Metrica { Id = idMetrica };
                //Preguntamos si el producto a sido agregado correctamente
                if (ing.Agregar())
                {
                    txtCantidadIngrediente.Clear();
                    txtNombreIngrediente.Clear();
                    txtPesoIngrediente.Clear();
                    //Cargamos el menu de ingrediente denuevo para ver el cambio que se agrego
                    ingredientito.Comandas_Load(sender, e);
                    //El ingrediente se guardo correctamente
                    MetroFramework.MetroMessageBox.Show(this, "Se agrego el ingrediente correctamente");
                }
                else
                {
                    //El ingrediente no se guardo correctamente
                    MetroFramework.MetroMessageBox.Show(this, "No se agrego el ingrediente correctamente");

                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "No se agrego el ingrediente correctamente");
                throw;
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