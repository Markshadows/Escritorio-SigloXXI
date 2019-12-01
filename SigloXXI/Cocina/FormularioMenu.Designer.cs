namespace Vista.Cocina
{
    partial class FormularioMenu
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNombreMenu = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecioMenu = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardarMenu = new MetroFramework.Controls.MetroButton();
            this.btnLimpiarMenu = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureMenu = new System.Windows.Forms.PictureBox();
            this.btnSubirImagen = new MetroFramework.Controls.MetroButton();
            this.cboEstadoMenu = new MetroFramework.Controls.MetroComboBox();
            this.eSTADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Siglo21 = new Vista.DS_Siglo21();
            this.lblImagenSubida = new MetroFramework.Controls.MetroLabel();
            this.eSTADOTableAdapter = new Vista.DS_Siglo21TableAdapters.ESTADOTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarFormMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Siglo21)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Precio";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 192);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Estado del menu";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 247);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Imagen ";
            // 
            // txtNombreMenu
            // 
            // 
            // 
            // 
            this.txtNombreMenu.CustomButton.Image = null;
            this.txtNombreMenu.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.txtNombreMenu.CustomButton.Name = "";
            this.txtNombreMenu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreMenu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreMenu.CustomButton.TabIndex = 1;
            this.txtNombreMenu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreMenu.CustomButton.UseSelectable = true;
            this.txtNombreMenu.CustomButton.Visible = false;
            this.txtNombreMenu.Lines = new string[0];
            this.txtNombreMenu.Location = new System.Drawing.Point(218, 98);
            this.txtNombreMenu.MaxLength = 32767;
            this.txtNombreMenu.Name = "txtNombreMenu";
            this.txtNombreMenu.PasswordChar = '\0';
            this.txtNombreMenu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreMenu.SelectedText = "";
            this.txtNombreMenu.SelectionLength = 0;
            this.txtNombreMenu.SelectionStart = 0;
            this.txtNombreMenu.ShortcutsEnabled = true;
            this.txtNombreMenu.Size = new System.Drawing.Size(280, 23);
            this.txtNombreMenu.TabIndex = 4;
            this.txtNombreMenu.UseSelectable = true;
            this.txtNombreMenu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreMenu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrecioMenu
            // 
            // 
            // 
            // 
            this.txtPrecioMenu.CustomButton.Image = null;
            this.txtPrecioMenu.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.txtPrecioMenu.CustomButton.Name = "";
            this.txtPrecioMenu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecioMenu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioMenu.CustomButton.TabIndex = 1;
            this.txtPrecioMenu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioMenu.CustomButton.UseSelectable = true;
            this.txtPrecioMenu.CustomButton.Visible = false;
            this.txtPrecioMenu.Lines = new string[0];
            this.txtPrecioMenu.Location = new System.Drawing.Point(218, 140);
            this.txtPrecioMenu.MaxLength = 32767;
            this.txtPrecioMenu.Name = "txtPrecioMenu";
            this.txtPrecioMenu.PasswordChar = '\0';
            this.txtPrecioMenu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioMenu.SelectedText = "";
            this.txtPrecioMenu.SelectionLength = 0;
            this.txtPrecioMenu.SelectionStart = 0;
            this.txtPrecioMenu.ShortcutsEnabled = true;
            this.txtPrecioMenu.Size = new System.Drawing.Size(280, 23);
            this.txtPrecioMenu.TabIndex = 5;
            this.txtPrecioMenu.UseSelectable = true;
            this.txtPrecioMenu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioMenu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardarMenu
            // 
            this.btnGuardarMenu.Location = new System.Drawing.Point(218, 333);
            this.btnGuardarMenu.Name = "btnGuardarMenu";
            this.btnGuardarMenu.Size = new System.Drawing.Size(136, 40);
            this.btnGuardarMenu.TabIndex = 7;
            this.btnGuardarMenu.Text = "Guardar";
            this.btnGuardarMenu.UseSelectable = true;
            this.btnGuardarMenu.Click += new System.EventHandler(this.btnGuardarMenu_Click);
            // 
            // btnLimpiarMenu
            // 
            this.btnLimpiarMenu.Location = new System.Drawing.Point(371, 333);
            this.btnLimpiarMenu.Name = "btnLimpiarMenu";
            this.btnLimpiarMenu.Size = new System.Drawing.Size(136, 40);
            this.btnLimpiarMenu.TabIndex = 8;
            this.btnLimpiarMenu.Text = "Limpiar";
            this.btnLimpiarMenu.UseSelectable = true;
            this.btnLimpiarMenu.Click += new System.EventHandler(this.btnLimpiarMenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureMenu);
            this.groupBox1.Controls.Add(this.btnSubirImagen);
            this.groupBox1.Location = new System.Drawing.Point(14, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 250);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu de administración de cocina";
            // 
            // pictureMenu
            // 
            this.pictureMenu.Location = new System.Drawing.Point(491, 19);
            this.pictureMenu.Name = "pictureMenu";
            this.pictureMenu.Size = new System.Drawing.Size(224, 225);
            this.pictureMenu.TabIndex = 1;
            this.pictureMenu.TabStop = false;
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.Location = new System.Drawing.Point(204, 179);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(280, 23);
            this.btnSubirImagen.TabIndex = 0;
            this.btnSubirImagen.Text = "Subir Imagen";
            this.btnSubirImagen.UseSelectable = true;
            this.btnSubirImagen.Click += new System.EventHandler(this.btnSubirImagen_Click);
            // 
            // cboEstadoMenu
            // 
            this.cboEstadoMenu.DataSource = this.eSTADOBindingSource;
            this.cboEstadoMenu.DisplayMember = "NOMBRE";
            this.cboEstadoMenu.FormattingEnabled = true;
            this.cboEstadoMenu.ItemHeight = 23;
            this.cboEstadoMenu.Location = new System.Drawing.Point(218, 189);
            this.cboEstadoMenu.Name = "cboEstadoMenu";
            this.cboEstadoMenu.Size = new System.Drawing.Size(280, 29);
            this.cboEstadoMenu.TabIndex = 6;
            this.cboEstadoMenu.UseSelectable = true;
            this.cboEstadoMenu.ValueMember = "ID";
            // 
            // eSTADOBindingSource
            // 
            this.eSTADOBindingSource.DataMember = "ESTADO";
            this.eSTADOBindingSource.DataSource = this.dS_Siglo21;
            // 
            // dS_Siglo21
            // 
            this.dS_Siglo21.DataSetName = "DS_Siglo21";
            this.dS_Siglo21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblImagenSubida
            // 
            this.lblImagenSubida.AutoSize = true;
            this.lblImagenSubida.Location = new System.Drawing.Point(24, 353);
            this.lblImagenSubida.Name = "lblImagenSubida";
            this.lblImagenSubida.Size = new System.Drawing.Size(91, 19);
            this.lblImagenSubida.TabIndex = 11;
            this.lblImagenSubida.Text = "Imagensubida";
            this.lblImagenSubida.Visible = false;
            // 
            // eSTADOTableAdapter
            // 
            this.eSTADOTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.btnCerrarFormMenu);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 32);
            this.panel1.TabIndex = 12;
            // 
            // btnCerrarFormMenu
            // 
            this.btnCerrarFormMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCerrarFormMenu.FlatAppearance.BorderSize = 0;
            this.btnCerrarFormMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFormMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarFormMenu.Location = new System.Drawing.Point(735, 0);
            this.btnCerrarFormMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarFormMenu.Name = "btnCerrarFormMenu";
            this.btnCerrarFormMenu.Size = new System.Drawing.Size(23, 20);
            this.btnCerrarFormMenu.TabIndex = 9;
            this.btnCerrarFormMenu.Text = "X";
            this.btnCerrarFormMenu.UseVisualStyleBackColor = false;
            this.btnCerrarFormMenu.Click += new System.EventHandler(this.btnCerrarFormMenu_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(708, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // FormularioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblImagenSubida);
            this.Controls.Add(this.btnLimpiarMenu);
            this.Controls.Add(this.btnGuardarMenu);
            this.Controls.Add(this.cboEstadoMenu);
            this.Controls.Add(this.txtPrecioMenu);
            this.Controls.Add(this.txtNombreMenu);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Menu";
            this.Load += new System.EventHandler(this.FormularioMenu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Siglo21)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtNombreMenu;
        private MetroFramework.Controls.MetroTextBox txtPrecioMenu;
        private MetroFramework.Controls.MetroButton btnGuardarMenu;
        private MetroFramework.Controls.MetroButton btnLimpiarMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cboEstadoMenu;
        private MetroFramework.Controls.MetroButton btnSubirImagen;
        private System.Windows.Forms.PictureBox pictureMenu;
        private MetroFramework.Controls.MetroLabel lblImagenSubida;
        private DS_Siglo21 dS_Siglo21;
        private System.Windows.Forms.BindingSource eSTADOBindingSource;
        private DS_Siglo21TableAdapters.ESTADOTableAdapter eSTADOTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCerrarFormMenu;
    }
}