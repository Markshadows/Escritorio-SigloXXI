namespace Vista.Administrador
{
    partial class FormularioAgregar
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cboEstadoUsuario = new MetroFramework.Controls.MetroComboBox();
            this.rOLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSigloXXI = new Vista.DataSetSigloXXI();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.btnModificarUsuario = new MetroFramework.Controls.MetroButton();
            this.btnGuardarUsuario = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.cboEstado = new MetroFramework.Controls.MetroComboBox();
            this.txtContrasena = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cboTipo = new MetroFramework.Controls.MetroComboBox();
            this.txtTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.txtApellidos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtRut = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rOLTableAdapter = new Vista.DataSetSigloXXITableAdapters.ROLTableAdapter();
            this.eSTADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTADOTableAdapter = new Vista.DataSetSigloXXITableAdapters.ESTADOTableAdapter();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSigloXXI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.cboEstadoUsuario);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtDireccion);
            this.metroPanel1.Controls.Add(this.btnModificarUsuario);
            this.metroPanel1.Controls.Add(this.btnGuardarUsuario);
            this.metroPanel1.Controls.Add(this.btnModificar);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.cboEstado);
            this.metroPanel1.Controls.Add(this.txtContrasena);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.txtCorreo);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.cboTipo);
            this.metroPanel1.Controls.Add(this.txtTelefono);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.btnAgregar);
            this.metroPanel1.Controls.Add(this.txtApellidos);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtRut);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtNombre);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(32, 53);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(659, 374);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cboEstadoUsuario
            // 
            this.cboEstadoUsuario.DataSource = this.eSTADOBindingSource;
            this.cboEstadoUsuario.DisplayMember = "NOMBRE";
            this.cboEstadoUsuario.FormattingEnabled = true;
            this.cboEstadoUsuario.ItemHeight = 23;
            this.cboEstadoUsuario.Location = new System.Drawing.Point(407, 209);
            this.cboEstadoUsuario.Name = "cboEstadoUsuario";
            this.cboEstadoUsuario.Size = new System.Drawing.Size(165, 29);
            this.cboEstadoUsuario.TabIndex = 45;
            this.cboEstadoUsuario.UseSelectable = true;
            this.cboEstadoUsuario.ValueMember = "ID";
            // 
            // rOLBindingSource
            // 
            this.rOLBindingSource.DataMember = "ROL";
            this.rOLBindingSource.DataSource = this.dataSetSigloXXI;
            // 
            // dataSetSigloXXI
            // 
            this.dataSetSigloXXI.DataSetName = "DataSetSigloXXI";
            this.dataSetSigloXXI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(350, 209);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 44;
            this.metroLabel6.Text = "Estado:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(335, 117);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 43;
            this.metroLabel4.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            // 
            // 
            // 
            this.txtDireccion.CustomButton.Image = null;
            this.txtDireccion.CustomButton.Location = new System.Drawing.Point(67, 2);
            this.txtDireccion.CustomButton.Name = "";
            this.txtDireccion.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion.CustomButton.TabIndex = 1;
            this.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion.CustomButton.UseSelectable = true;
            this.txtDireccion.CustomButton.Visible = false;
            this.txtDireccion.Lines = new string[0];
            this.txtDireccion.Location = new System.Drawing.Point(407, 98);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.ShortcutsEnabled = true;
            this.txtDireccion.Size = new System.Drawing.Size(165, 100);
            this.txtDireccion.TabIndex = 42;
            this.txtDireccion.UseSelectable = true;
            this.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(295, 321);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnModificarUsuario.TabIndex = 41;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseSelectable = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(201, 321);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarUsuario.TabIndex = 40;
            this.btnGuardarUsuario.Text = "Agregar";
            this.btnGuardarUsuario.UseSelectable = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(110, 457);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(73, 417);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(51, 19);
            this.metroLabel10.TabIndex = 22;
            this.metroLabel10.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.DisplayMember = "DESCRIPCION";
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 23;
            this.cboEstado.Location = new System.Drawing.Point(130, 411);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(165, 29);
            this.cboEstado.TabIndex = 21;
            this.cboEstado.UseSelectable = true;
            this.cboEstado.ValueMember = "ID_ESTADO";
            // 
            // txtContrasena
            // 
            // 
            // 
            // 
            this.txtContrasena.CustomButton.Image = null;
            this.txtContrasena.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtContrasena.CustomButton.Name = "";
            this.txtContrasena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContrasena.CustomButton.TabIndex = 1;
            this.txtContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContrasena.CustomButton.UseSelectable = true;
            this.txtContrasena.CustomButton.Visible = false;
            this.txtContrasena.Lines = new string[0];
            this.txtContrasena.Location = new System.Drawing.Point(407, 63);
            this.txtContrasena.MaxLength = 32767;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '\0';
            this.txtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.SelectionLength = 0;
            this.txtContrasena.SelectionStart = 0;
            this.txtContrasena.ShortcutsEnabled = true;
            this.txtContrasena.Size = new System.Drawing.Size(165, 23);
            this.txtContrasena.TabIndex = 20;
            this.txtContrasena.UseSelectable = true;
            this.txtContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContrasena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(323, 67);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(78, 19);
            this.metroLabel9.TabIndex = 19;
            this.metroLabel9.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            // 
            // 
            // 
            this.txtCorreo.CustomButton.Image = null;
            this.txtCorreo.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtCorreo.CustomButton.Name = "";
            this.txtCorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCorreo.CustomButton.TabIndex = 1;
            this.txtCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCorreo.CustomButton.UseSelectable = true;
            this.txtCorreo.CustomButton.Visible = false;
            this.txtCorreo.Lines = new string[0];
            this.txtCorreo.Location = new System.Drawing.Point(407, 25);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.Size = new System.Drawing.Size(165, 23);
            this.txtCorreo.TabIndex = 18;
            this.txtCorreo.UseSelectable = true;
            this.txtCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(347, 25);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(54, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Correo:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(86, 179);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(38, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.DataSource = this.rOLBindingSource;
            this.cboTipo.DisplayMember = "TIPO";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 23;
            this.cboTipo.Location = new System.Drawing.Point(130, 179);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(165, 29);
            this.cboTipo.TabIndex = 15;
            this.cboTipo.UseSelectable = true;
            this.cboTipo.ValueMember = "ID";
            // 
            // txtTelefono
            // 
            // 
            // 
            // 
            this.txtTelefono.CustomButton.Image = null;
            this.txtTelefono.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtTelefono.CustomButton.Name = "";
            this.txtTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefono.CustomButton.TabIndex = 1;
            this.txtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefono.CustomButton.UseSelectable = true;
            this.txtTelefono.CustomButton.Visible = false;
            this.txtTelefono.Lines = new string[0];
            this.txtTelefono.Location = new System.Drawing.Point(130, 141);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(165, 23);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.UseSelectable = true;
            this.txtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(63, 141);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Teléfono:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(14, 457);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            // 
            // txtApellidos
            // 
            // 
            // 
            // 
            this.txtApellidos.CustomButton.Image = null;
            this.txtApellidos.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtApellidos.CustomButton.Name = "";
            this.txtApellidos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellidos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellidos.CustomButton.TabIndex = 1;
            this.txtApellidos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellidos.CustomButton.UseSelectable = true;
            this.txtApellidos.CustomButton.Visible = false;
            this.txtApellidos.Lines = new string[0];
            this.txtApellidos.Location = new System.Drawing.Point(130, 102);
            this.txtApellidos.MaxLength = 32767;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.ShortcutsEnabled = true;
            this.txtApellidos.Size = new System.Drawing.Size(165, 23);
            this.txtApellidos.TabIndex = 7;
            this.txtApellidos.UseSelectable = true;
            this.txtApellidos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellidos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(58, 102);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Apellidos:";
            // 
            // txtRut
            // 
            // 
            // 
            // 
            this.txtRut.CustomButton.Image = null;
            this.txtRut.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtRut.CustomButton.Name = "";
            this.txtRut.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRut.CustomButton.TabIndex = 1;
            this.txtRut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRut.CustomButton.UseSelectable = true;
            this.txtRut.CustomButton.Visible = false;
            this.txtRut.Lines = new string[0];
            this.txtRut.Location = new System.Drawing.Point(130, 63);
            this.txtRut.MaxLength = 32767;
            this.txtRut.Name = "txtRut";
            this.txtRut.PasswordChar = '\0';
            this.txtRut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRut.SelectedText = "";
            this.txtRut.SelectionLength = 0;
            this.txtRut.SelectionStart = 0;
            this.txtRut.ShortcutsEnabled = true;
            this.txtRut.Size = new System.Drawing.Size(165, 23);
            this.txtRut.TabIndex = 5;
            this.txtRut.UseSelectable = true;
            this.txtRut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(93, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Rut:";
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(130, 25);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(165, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nombre:";
            // 
            // rOLTableAdapter
            // 
            this.rOLTableAdapter.ClearBeforeFill = true;
            // 
            // eSTADOBindingSource
            // 
            this.eSTADOBindingSource.DataMember = "ESTADO";
            this.eSTADOBindingSource.DataSource = this.dataSetSigloXXI;
            // 
            // eSTADOTableAdapter
            // 
            this.eSTADOTableAdapter.ClearBeforeFill = true;
            // 
            // FormularioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FormularioAgregar";
            this.Text = "FormularioAgregar";
            this.Load += new System.EventHandler(this.FormularioAgregar_Activated);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSigloXXI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox cboEstado;
        private MetroFramework.Controls.MetroTextBox txtContrasena;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtCorreo;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cboTipo;
        private MetroFramework.Controls.MetroTextBox txtTelefono;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroTextBox txtApellidos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtRut;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DataSetSigloXXI dataSetSigloXXI;
        private MetroFramework.Controls.MetroButton btnGuardarUsuario;
        private System.Windows.Forms.BindingSource rOLBindingSource;
        private DataSetSigloXXITableAdapters.ROLTableAdapter rOLTableAdapter;
        private MetroFramework.Controls.MetroButton btnModificarUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtDireccion;
        private MetroFramework.Controls.MetroComboBox cboEstadoUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.BindingSource eSTADOBindingSource;
        private DataSetSigloXXITableAdapters.ESTADOTableAdapter eSTADOTableAdapter;
    }
}