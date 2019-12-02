namespace Vista.Cocina
{
    partial class FormularioIngrediente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMedidaIngrediente = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiarIngrediente = new MetroFramework.Controls.MetroButton();
            this.bntGuardarIngrediente = new MetroFramework.Controls.MetroButton();
            this.txtPesoIngrediente = new MetroFramework.Controls.MetroTextBox();
            this.cboProductoIngrediente = new MetroFramework.Controls.MetroComboBox();
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Siglo21 = new Vista.DS_Siglo21();
            this.cboMenuIngrediente = new MetroFramework.Controls.MetroComboBox();
            this.mENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCantidadIngrediente = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreIngrediente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mENUTableAdapter = new Vista.DS_Siglo21TableAdapters.MENUTableAdapter();
            this.pRODUCTOTableAdapter = new Vista.DS_Siglo21TableAdapters.PRODUCTOTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Siglo21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMedidaIngrediente);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnLimpiarIngrediente);
            this.groupBox1.Controls.Add(this.bntGuardarIngrediente);
            this.groupBox1.Controls.Add(this.txtPesoIngrediente);
            this.groupBox1.Controls.Add(this.cboProductoIngrediente);
            this.groupBox1.Controls.Add(this.cboMenuIngrediente);
            this.groupBox1.Controls.Add(this.txtCantidadIngrediente);
            this.groupBox1.Controls.Add(this.txtNombreIngrediente);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(24, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu de administracion cocina ";
            // 
            // cboMedidaIngrediente
            // 
            this.cboMedidaIngrediente.FormattingEnabled = true;
            this.cboMedidaIngrediente.ItemHeight = 23;
            this.cboMedidaIngrediente.Items.AddRange(new object[] {
            "Kilogramos",
            "Gramos",
            "Litros",
            "Unidades",
            "Cajas",
            "Botella"});
            this.cboMedidaIngrediente.Location = new System.Drawing.Point(146, 273);
            this.cboMedidaIngrediente.Name = "cboMedidaIngrediente";
            this.cboMedidaIngrediente.Size = new System.Drawing.Size(120, 29);
            this.cboMedidaIngrediente.TabIndex = 16;
            this.cboMedidaIngrediente.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(310, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 194);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiarIngrediente
            // 
            this.btnLimpiarIngrediente.Location = new System.Drawing.Point(376, 276);
            this.btnLimpiarIngrediente.Name = "btnLimpiarIngrediente";
            this.btnLimpiarIngrediente.Size = new System.Drawing.Size(134, 23);
            this.btnLimpiarIngrediente.TabIndex = 14;
            this.btnLimpiarIngrediente.Text = "Limpiar";
            this.btnLimpiarIngrediente.UseSelectable = true;
            // 
            // bntGuardarIngrediente
            // 
            this.bntGuardarIngrediente.Location = new System.Drawing.Point(376, 239);
            this.bntGuardarIngrediente.Name = "bntGuardarIngrediente";
            this.bntGuardarIngrediente.Size = new System.Drawing.Size(134, 23);
            this.bntGuardarIngrediente.TabIndex = 13;
            this.bntGuardarIngrediente.Text = "Guardar";
            this.bntGuardarIngrediente.UseSelectable = true;
            this.bntGuardarIngrediente.Click += new System.EventHandler(this.bntGuardarIngrediente_Click);
            // 
            // txtPesoIngrediente
            // 
            // 
            // 
            // 
            this.txtPesoIngrediente.CustomButton.Image = null;
            this.txtPesoIngrediente.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtPesoIngrediente.CustomButton.Name = "";
            this.txtPesoIngrediente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPesoIngrediente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesoIngrediente.CustomButton.TabIndex = 1;
            this.txtPesoIngrediente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesoIngrediente.CustomButton.UseSelectable = true;
            this.txtPesoIngrediente.CustomButton.Visible = false;
            this.txtPesoIngrediente.Lines = new string[0];
            this.txtPesoIngrediente.Location = new System.Drawing.Point(146, 235);
            this.txtPesoIngrediente.MaxLength = 32767;
            this.txtPesoIngrediente.Name = "txtPesoIngrediente";
            this.txtPesoIngrediente.PasswordChar = '\0';
            this.txtPesoIngrediente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesoIngrediente.SelectedText = "";
            this.txtPesoIngrediente.SelectionLength = 0;
            this.txtPesoIngrediente.SelectionStart = 0;
            this.txtPesoIngrediente.ShortcutsEnabled = true;
            this.txtPesoIngrediente.Size = new System.Drawing.Size(120, 23);
            this.txtPesoIngrediente.TabIndex = 11;
            this.txtPesoIngrediente.UseSelectable = true;
            this.txtPesoIngrediente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesoIngrediente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboProductoIngrediente
            // 
            this.cboProductoIngrediente.DataSource = this.pRODUCTOBindingSource;
            this.cboProductoIngrediente.DisplayMember = "NOMBRE";
            this.cboProductoIngrediente.FormattingEnabled = true;
            this.cboProductoIngrediente.ItemHeight = 23;
            this.cboProductoIngrediente.Location = new System.Drawing.Point(146, 157);
            this.cboProductoIngrediente.Name = "cboProductoIngrediente";
            this.cboProductoIngrediente.Size = new System.Drawing.Size(158, 29);
            this.cboProductoIngrediente.TabIndex = 10;
            this.cboProductoIngrediente.UseSelectable = true;
            this.cboProductoIngrediente.ValueMember = "ID";
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource.DataSource = this.dS_Siglo21;
            // 
            // dS_Siglo21
            // 
            this.dS_Siglo21.DataSetName = "DS_Siglo21";
            this.dS_Siglo21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboMenuIngrediente
            // 
            this.cboMenuIngrediente.DataSource = this.mENUBindingSource;
            this.cboMenuIngrediente.DisplayMember = "NOMBRE";
            this.cboMenuIngrediente.FormattingEnabled = true;
            this.cboMenuIngrediente.ItemHeight = 23;
            this.cboMenuIngrediente.Location = new System.Drawing.Point(146, 118);
            this.cboMenuIngrediente.Name = "cboMenuIngrediente";
            this.cboMenuIngrediente.Size = new System.Drawing.Size(158, 29);
            this.cboMenuIngrediente.TabIndex = 9;
            this.cboMenuIngrediente.UseSelectable = true;
            this.cboMenuIngrediente.ValueMember = "ID";
            // 
            // mENUBindingSource
            // 
            this.mENUBindingSource.DataMember = "MENU";
            this.mENUBindingSource.DataSource = this.dS_Siglo21;
            // 
            // txtCantidadIngrediente
            // 
            // 
            // 
            // 
            this.txtCantidadIngrediente.CustomButton.Image = null;
            this.txtCantidadIngrediente.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtCantidadIngrediente.CustomButton.Name = "";
            this.txtCantidadIngrediente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantidadIngrediente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidadIngrediente.CustomButton.TabIndex = 1;
            this.txtCantidadIngrediente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidadIngrediente.CustomButton.UseSelectable = true;
            this.txtCantidadIngrediente.CustomButton.Visible = false;
            this.txtCantidadIngrediente.Lines = new string[0];
            this.txtCantidadIngrediente.Location = new System.Drawing.Point(146, 76);
            this.txtCantidadIngrediente.MaxLength = 32767;
            this.txtCantidadIngrediente.Name = "txtCantidadIngrediente";
            this.txtCantidadIngrediente.PasswordChar = '\0';
            this.txtCantidadIngrediente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidadIngrediente.SelectedText = "";
            this.txtCantidadIngrediente.SelectionLength = 0;
            this.txtCantidadIngrediente.SelectionStart = 0;
            this.txtCantidadIngrediente.ShortcutsEnabled = true;
            this.txtCantidadIngrediente.Size = new System.Drawing.Size(158, 23);
            this.txtCantidadIngrediente.TabIndex = 8;
            this.txtCantidadIngrediente.UseSelectable = true;
            this.txtCantidadIngrediente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidadIngrediente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombreIngrediente
            // 
            // 
            // 
            // 
            this.txtNombreIngrediente.CustomButton.Image = null;
            this.txtNombreIngrediente.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtNombreIngrediente.CustomButton.Name = "";
            this.txtNombreIngrediente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreIngrediente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreIngrediente.CustomButton.TabIndex = 1;
            this.txtNombreIngrediente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreIngrediente.CustomButton.UseSelectable = true;
            this.txtNombreIngrediente.CustomButton.Visible = false;
            this.txtNombreIngrediente.Lines = new string[0];
            this.txtNombreIngrediente.Location = new System.Drawing.Point(146, 33);
            this.txtNombreIngrediente.MaxLength = 32767;
            this.txtNombreIngrediente.Name = "txtNombreIngrediente";
            this.txtNombreIngrediente.PasswordChar = '\0';
            this.txtNombreIngrediente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreIngrediente.SelectedText = "";
            this.txtNombreIngrediente.SelectionLength = 0;
            this.txtNombreIngrediente.SelectionStart = 0;
            this.txtNombreIngrediente.ShortcutsEnabled = true;
            this.txtNombreIngrediente.Size = new System.Drawing.Size(158, 23);
            this.txtNombreIngrediente.TabIndex = 7;
            this.txtNombreIngrediente.UseSelectable = true;
            this.txtNombreIngrediente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreIngrediente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(86, 276);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(54, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Medida";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(104, 239);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Peso";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 208);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Metrica";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 160);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Producto";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Menu";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Cantidad";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 32);
            this.panel1.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(612, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 20);
            this.button5.TabIndex = 11;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(583, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 20);
            this.button4.TabIndex = 10;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(926, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 20);
            this.button3.TabIndex = 9;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(899, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(980, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mENUTableAdapter
            // 
            this.mENUTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // FormularioIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Ingrediente";
            this.Load += new System.EventHandler(this.FormularioIngrediente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Siglo21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNombreIngrediente;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPesoIngrediente;
        private MetroFramework.Controls.MetroComboBox cboProductoIngrediente;
        private MetroFramework.Controls.MetroComboBox cboMenuIngrediente;
        private MetroFramework.Controls.MetroTextBox txtCantidadIngrediente;
        private MetroFramework.Controls.MetroButton btnLimpiarIngrediente;
        private MetroFramework.Controls.MetroButton bntGuardarIngrediente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox cboMedidaIngrediente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private DS_Siglo21 dS_Siglo21;
        private System.Windows.Forms.BindingSource mENUBindingSource;
        private DS_Siglo21TableAdapters.MENUTableAdapter mENUTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource;
        private DS_Siglo21TableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter;
    }
}