namespace Vista.Cocina
{
    partial class ActualizarMenu
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
            this.lblImagenSubida = new MetroFramework.Controls.MetroLabel();
            this.btnActualizarMenu = new MetroFramework.Controls.MetroButton();
            this.cboEstadoMenu = new MetroFramework.Controls.MetroComboBox();
            this.txtPrecioMenu = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreMenu = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureMenu = new System.Windows.Forms.PictureBox();
            this.btnSubirImagen = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarFormMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dS_Siglo21 = new Vista.DS_Siglo21();
            this.eSTADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTADOTableAdapter = new Vista.DS_Siglo21TableAdapters.ESTADOTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Siglo21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImagenSubida
            // 
            this.lblImagenSubida.AutoSize = true;
            this.lblImagenSubida.Location = new System.Drawing.Point(50, 360);
            this.lblImagenSubida.Name = "lblImagenSubida";
            this.lblImagenSubida.Size = new System.Drawing.Size(91, 19);
            this.lblImagenSubida.TabIndex = 22;
            this.lblImagenSubida.Text = "Imagensubida";
            this.lblImagenSubida.Visible = false;
            // 
            // btnActualizarMenu
            // 
            this.btnActualizarMenu.Location = new System.Drawing.Point(244, 340);
            this.btnActualizarMenu.Name = "btnActualizarMenu";
            this.btnActualizarMenu.Size = new System.Drawing.Size(136, 40);
            this.btnActualizarMenu.TabIndex = 19;
            this.btnActualizarMenu.Text = "Actualizar menu";
            this.btnActualizarMenu.UseSelectable = true;
            this.btnActualizarMenu.Click += new System.EventHandler(this.btnGuardarMenu_Click);
            // 
            // cboEstadoMenu
            // 
            this.cboEstadoMenu.DataSource = this.eSTADOBindingSource;
            this.cboEstadoMenu.DisplayMember = "NOMBRE";
            this.cboEstadoMenu.FormattingEnabled = true;
            this.cboEstadoMenu.ItemHeight = 23;
            this.cboEstadoMenu.Location = new System.Drawing.Point(244, 196);
            this.cboEstadoMenu.Name = "cboEstadoMenu";
            this.cboEstadoMenu.Size = new System.Drawing.Size(280, 29);
            this.cboEstadoMenu.TabIndex = 18;
            this.cboEstadoMenu.UseSelectable = true;
            this.cboEstadoMenu.ValueMember = "ID";
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
            this.txtPrecioMenu.Location = new System.Drawing.Point(244, 147);
            this.txtPrecioMenu.MaxLength = 32767;
            this.txtPrecioMenu.Name = "txtPrecioMenu";
            this.txtPrecioMenu.PasswordChar = '\0';
            this.txtPrecioMenu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioMenu.SelectedText = "";
            this.txtPrecioMenu.SelectionLength = 0;
            this.txtPrecioMenu.SelectionStart = 0;
            this.txtPrecioMenu.ShortcutsEnabled = true;
            this.txtPrecioMenu.Size = new System.Drawing.Size(280, 23);
            this.txtPrecioMenu.TabIndex = 17;
            this.txtPrecioMenu.UseSelectable = true;
            this.txtPrecioMenu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioMenu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtNombreMenu.Location = new System.Drawing.Point(244, 105);
            this.txtNombreMenu.MaxLength = 32767;
            this.txtNombreMenu.Name = "txtNombreMenu";
            this.txtNombreMenu.PasswordChar = '\0';
            this.txtNombreMenu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreMenu.SelectedText = "";
            this.txtNombreMenu.SelectionLength = 0;
            this.txtNombreMenu.SelectionStart = 0;
            this.txtNombreMenu.ShortcutsEnabled = true;
            this.txtNombreMenu.Size = new System.Drawing.Size(280, 23);
            this.txtNombreMenu.TabIndex = 16;
            this.txtNombreMenu.UseSelectable = true;
            this.txtNombreMenu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreMenu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(50, 254);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Imagen ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(50, 199);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Estado del menu";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(50, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Precio";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureMenu);
            this.groupBox1.Controls.Add(this.btnSubirImagen);
            this.groupBox1.Location = new System.Drawing.Point(40, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 250);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu de administracion de cocina";
            // 
            // pictureMenu
            // 
            this.pictureMenu.Location = new System.Drawing.Point(491, 19);
            this.pictureMenu.Name = "pictureMenu";
            this.pictureMenu.Size = new System.Drawing.Size(224, 225);
            this.pictureMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 23;
            // 
            // btnCerrarFormMenu
            // 
            this.btnCerrarFormMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCerrarFormMenu.FlatAppearance.BorderSize = 0;
            this.btnCerrarFormMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFormMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarFormMenu.Location = new System.Drawing.Point(777, 0);
            this.btnCerrarFormMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarFormMenu.Name = "btnCerrarFormMenu";
            this.btnCerrarFormMenu.Size = new System.Drawing.Size(23, 20);
            this.btnCerrarFormMenu.TabIndex = 10;
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
            this.button2.Location = new System.Drawing.Point(750, 0);
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
            // dS_Siglo21
            // 
            this.dS_Siglo21.DataSetName = "DS_Siglo21";
            this.dS_Siglo21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSTADOBindingSource
            // 
            this.eSTADOBindingSource.DataMember = "ESTADO";
            this.eSTADOBindingSource.DataSource = this.dS_Siglo21;
            // 
            // eSTADOTableAdapter
            // 
            this.eSTADOTableAdapter.ClearBeforeFill = true;
            // 
            // ActualizarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblImagenSubida);
            this.Controls.Add(this.btnActualizarMenu);
            this.Controls.Add(this.cboEstadoMenu);
            this.Controls.Add(this.txtPrecioMenu);
            this.Controls.Add(this.txtNombreMenu);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizarMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarMenu";
            this.Load += new System.EventHandler(this.ActualizarMenu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Siglo21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblImagenSubida;
        private MetroFramework.Controls.MetroButton btnActualizarMenu;
        private MetroFramework.Controls.MetroComboBox cboEstadoMenu;
        private MetroFramework.Controls.MetroTextBox txtPrecioMenu;
        private MetroFramework.Controls.MetroTextBox txtNombreMenu;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureMenu;
        private MetroFramework.Controls.MetroButton btnSubirImagen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrarFormMenu;
        private DS_Siglo21 dS_Siglo21;
        private System.Windows.Forms.BindingSource eSTADOBindingSource;
        private DS_Siglo21TableAdapters.ESTADOTableAdapter eSTADOTableAdapter;
    }
}