namespace Vista.Administrador
{
    partial class CRUDProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDProveedor));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNombreProveedor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtRutProveedor = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefonoProveedor = new MetroFramework.Controls.MetroTextBox();
            this.txtCorreoProveedor = new MetroFramework.Controls.MetroTextBox();
            this.txtDescripcionProveedor = new MetroFramework.Controls.MetroTextBox();
            this.txtDireccionProveedor = new MetroFramework.Controls.MetroTextBox();
            this.cboGiroProveedor = new MetroFramework.Controls.MetroComboBox();
            this.cboEstadoProveedor = new MetroFramework.Controls.MetroComboBox();
            this.dS_Siglo21 = new Vista.DS_Siglo21();
            this.gIROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIROTableAdapter = new Vista.DS_Siglo21TableAdapters.GIROTableAdapter();
            this.eSTADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTADOTableAdapter = new Vista.DS_Siglo21TableAdapters.ESTADOTableAdapter();
            this.AgregarProveedor = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Siglo21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.AgregarProveedor);
            this.metroPanel1.Controls.Add(this.cboEstadoProveedor);
            this.metroPanel1.Controls.Add(this.cboGiroProveedor);
            this.metroPanel1.Controls.Add(this.txtDireccionProveedor);
            this.metroPanel1.Controls.Add(this.txtDescripcionProveedor);
            this.metroPanel1.Controls.Add(this.txtCorreoProveedor);
            this.metroPanel1.Controls.Add(this.txtTelefonoProveedor);
            this.metroPanel1.Controls.Add(this.txtRutProveedor);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtNombreProveedor);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(38, 84);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(645, 343);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nombre:";
            // 
            // txtNombreProveedor
            // 
            // 
            // 
            // 
            this.txtNombreProveedor.CustomButton.Image = null;
            this.txtNombreProveedor.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtNombreProveedor.CustomButton.Name = "";
            this.txtNombreProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreProveedor.CustomButton.TabIndex = 1;
            this.txtNombreProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreProveedor.CustomButton.UseSelectable = true;
            this.txtNombreProveedor.CustomButton.Visible = false;
            this.txtNombreProveedor.Lines = new string[0];
            this.txtNombreProveedor.Location = new System.Drawing.Point(125, 39);
            this.txtNombreProveedor.MaxLength = 32767;
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.PasswordChar = '\0';
            this.txtNombreProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreProveedor.SelectedText = "";
            this.txtNombreProveedor.SelectionLength = 0;
            this.txtNombreProveedor.SelectionStart = 0;
            this.txtNombreProveedor.ShortcutsEnabled = true;
            this.txtNombreProveedor.Size = new System.Drawing.Size(154, 23);
            this.txtNombreProveedor.TabIndex = 3;
            this.txtNombreProveedor.UseSelectable = true;
            this.txtNombreProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "RUT:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 110);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Telefono:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 143);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Correo:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(25, 198);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Giro:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(360, 78);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(79, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Descripción:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(360, 210);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "Dirección:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(25, 242);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Estado:";
            // 
            // txtRutProveedor
            // 
            // 
            // 
            // 
            this.txtRutProveedor.CustomButton.Image = null;
            this.txtRutProveedor.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtRutProveedor.CustomButton.Name = "";
            this.txtRutProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRutProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRutProveedor.CustomButton.TabIndex = 1;
            this.txtRutProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRutProveedor.CustomButton.UseSelectable = true;
            this.txtRutProveedor.CustomButton.Visible = false;
            this.txtRutProveedor.Lines = new string[0];
            this.txtRutProveedor.Location = new System.Drawing.Point(125, 74);
            this.txtRutProveedor.MaxLength = 32767;
            this.txtRutProveedor.Name = "txtRutProveedor";
            this.txtRutProveedor.PasswordChar = '\0';
            this.txtRutProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRutProveedor.SelectedText = "";
            this.txtRutProveedor.SelectionLength = 0;
            this.txtRutProveedor.SelectionStart = 0;
            this.txtRutProveedor.ShortcutsEnabled = true;
            this.txtRutProveedor.Size = new System.Drawing.Size(154, 23);
            this.txtRutProveedor.TabIndex = 11;
            this.txtRutProveedor.UseSelectable = true;
            this.txtRutProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRutProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTelefonoProveedor
            // 
            // 
            // 
            // 
            this.txtTelefonoProveedor.CustomButton.Image = null;
            this.txtTelefonoProveedor.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtTelefonoProveedor.CustomButton.Name = "";
            this.txtTelefonoProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefonoProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefonoProveedor.CustomButton.TabIndex = 1;
            this.txtTelefonoProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefonoProveedor.CustomButton.UseSelectable = true;
            this.txtTelefonoProveedor.CustomButton.Visible = false;
            this.txtTelefonoProveedor.Lines = new string[0];
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(125, 110);
            this.txtTelefonoProveedor.MaxLength = 32767;
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.PasswordChar = '\0';
            this.txtTelefonoProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefonoProveedor.SelectedText = "";
            this.txtTelefonoProveedor.SelectionLength = 0;
            this.txtTelefonoProveedor.SelectionStart = 0;
            this.txtTelefonoProveedor.ShortcutsEnabled = true;
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(154, 23);
            this.txtTelefonoProveedor.TabIndex = 12;
            this.txtTelefonoProveedor.UseSelectable = true;
            this.txtTelefonoProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefonoProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCorreoProveedor
            // 
            // 
            // 
            // 
            this.txtCorreoProveedor.CustomButton.Image = null;
            this.txtCorreoProveedor.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtCorreoProveedor.CustomButton.Name = "";
            this.txtCorreoProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCorreoProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCorreoProveedor.CustomButton.TabIndex = 1;
            this.txtCorreoProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCorreoProveedor.CustomButton.UseSelectable = true;
            this.txtCorreoProveedor.CustomButton.Visible = false;
            this.txtCorreoProveedor.Lines = new string[0];
            this.txtCorreoProveedor.Location = new System.Drawing.Point(125, 143);
            this.txtCorreoProveedor.MaxLength = 32767;
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.PasswordChar = '\0';
            this.txtCorreoProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCorreoProveedor.SelectedText = "";
            this.txtCorreoProveedor.SelectionLength = 0;
            this.txtCorreoProveedor.SelectionStart = 0;
            this.txtCorreoProveedor.ShortcutsEnabled = true;
            this.txtCorreoProveedor.Size = new System.Drawing.Size(154, 23);
            this.txtCorreoProveedor.TabIndex = 13;
            this.txtCorreoProveedor.UseSelectable = true;
            this.txtCorreoProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCorreoProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescripcionProveedor
            // 
            // 
            // 
            // 
            this.txtDescripcionProveedor.CustomButton.Image = null;
            this.txtDescripcionProveedor.CustomButton.Location = new System.Drawing.Point(43, 2);
            this.txtDescripcionProveedor.CustomButton.Name = "";
            this.txtDescripcionProveedor.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtDescripcionProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcionProveedor.CustomButton.TabIndex = 1;
            this.txtDescripcionProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcionProveedor.CustomButton.UseSelectable = true;
            this.txtDescripcionProveedor.CustomButton.Visible = false;
            this.txtDescripcionProveedor.Lines = new string[0];
            this.txtDescripcionProveedor.Location = new System.Drawing.Point(461, 43);
            this.txtDescripcionProveedor.MaxLength = 32767;
            this.txtDescripcionProveedor.Name = "txtDescripcionProveedor";
            this.txtDescripcionProveedor.PasswordChar = '\0';
            this.txtDescripcionProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcionProveedor.SelectedText = "";
            this.txtDescripcionProveedor.SelectionLength = 0;
            this.txtDescripcionProveedor.SelectionStart = 0;
            this.txtDescripcionProveedor.ShortcutsEnabled = true;
            this.txtDescripcionProveedor.Size = new System.Drawing.Size(141, 100);
            this.txtDescripcionProveedor.TabIndex = 14;
            this.txtDescripcionProveedor.UseSelectable = true;
            this.txtDescripcionProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcionProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDireccionProveedor
            // 
            // 
            // 
            // 
            this.txtDireccionProveedor.CustomButton.Image = null;
            this.txtDireccionProveedor.CustomButton.Location = new System.Drawing.Point(43, 2);
            this.txtDireccionProveedor.CustomButton.Name = "";
            this.txtDireccionProveedor.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtDireccionProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccionProveedor.CustomButton.TabIndex = 1;
            this.txtDireccionProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccionProveedor.CustomButton.UseSelectable = true;
            this.txtDireccionProveedor.CustomButton.Visible = false;
            this.txtDireccionProveedor.Lines = new string[0];
            this.txtDireccionProveedor.Location = new System.Drawing.Point(461, 176);
            this.txtDireccionProveedor.MaxLength = 32767;
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.PasswordChar = '\0';
            this.txtDireccionProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccionProveedor.SelectedText = "";
            this.txtDireccionProveedor.SelectionLength = 0;
            this.txtDireccionProveedor.SelectionStart = 0;
            this.txtDireccionProveedor.ShortcutsEnabled = true;
            this.txtDireccionProveedor.Size = new System.Drawing.Size(141, 100);
            this.txtDireccionProveedor.TabIndex = 15;
            this.txtDireccionProveedor.UseSelectable = true;
            this.txtDireccionProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccionProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboGiroProveedor
            // 
            this.cboGiroProveedor.DataSource = this.gIROBindingSource;
            this.cboGiroProveedor.DisplayMember = "NOMBRE";
            this.cboGiroProveedor.FormattingEnabled = true;
            this.cboGiroProveedor.ItemHeight = 23;
            this.cboGiroProveedor.Location = new System.Drawing.Point(125, 188);
            this.cboGiroProveedor.Name = "cboGiroProveedor";
            this.cboGiroProveedor.Size = new System.Drawing.Size(154, 29);
            this.cboGiroProveedor.TabIndex = 16;
            this.cboGiroProveedor.UseSelectable = true;
            this.cboGiroProveedor.ValueMember = "ID";
            // 
            // cboEstadoProveedor
            // 
            this.cboEstadoProveedor.DataSource = this.eSTADOBindingSource;
            this.cboEstadoProveedor.DisplayMember = "NOMBRE";
            this.cboEstadoProveedor.FormattingEnabled = true;
            this.cboEstadoProveedor.ItemHeight = 23;
            this.cboEstadoProveedor.Location = new System.Drawing.Point(125, 242);
            this.cboEstadoProveedor.Name = "cboEstadoProveedor";
            this.cboEstadoProveedor.Size = new System.Drawing.Size(154, 29);
            this.cboEstadoProveedor.TabIndex = 17;
            this.cboEstadoProveedor.UseSelectable = true;
            this.cboEstadoProveedor.ValueMember = "ID";
            // 
            // dS_Siglo21
            // 
            this.dS_Siglo21.DataSetName = "DS_Siglo21";
            this.dS_Siglo21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIROBindingSource
            // 
            this.gIROBindingSource.DataMember = "GIRO";
            this.gIROBindingSource.DataSource = this.dS_Siglo21;
            // 
            // gIROTableAdapter
            // 
            this.gIROTableAdapter.ClearBeforeFill = true;
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
            // AgregarProveedor
            // 
            this.AgregarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AgregarProveedor.BackgroundImage")));
            this.AgregarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AgregarProveedor.Location = new System.Drawing.Point(259, 292);
            this.AgregarProveedor.Name = "AgregarProveedor";
            this.AgregarProveedor.Size = new System.Drawing.Size(41, 36);
            this.AgregarProveedor.TabIndex = 18;
            this.AgregarProveedor.UseSelectable = true;
            this.AgregarProveedor.Click += new System.EventHandler(this.AgregarProveedor_Click);
            // 
            // CRUDProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CRUDProveedor";
            this.Text = "CRUDProveedor";
            this.Load += new System.EventHandler(this.CRUDProveedor_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Siglo21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox cboEstadoProveedor;
        private MetroFramework.Controls.MetroComboBox cboGiroProveedor;
        private MetroFramework.Controls.MetroTextBox txtDireccionProveedor;
        private MetroFramework.Controls.MetroTextBox txtDescripcionProveedor;
        private MetroFramework.Controls.MetroTextBox txtCorreoProveedor;
        private MetroFramework.Controls.MetroTextBox txtTelefonoProveedor;
        private MetroFramework.Controls.MetroTextBox txtRutProveedor;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNombreProveedor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DS_Siglo21 dS_Siglo21;
        private System.Windows.Forms.BindingSource gIROBindingSource;
        private DS_Siglo21TableAdapters.GIROTableAdapter gIROTableAdapter;
        private System.Windows.Forms.BindingSource eSTADOBindingSource;
        private DS_Siglo21TableAdapters.ESTADOTableAdapter eSTADOTableAdapter;
        private MetroFramework.Controls.MetroButton AgregarProveedor;
    }
}