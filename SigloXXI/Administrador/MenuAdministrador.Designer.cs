namespace Vista.Administrador
{
    partial class MenuAdministrador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrador));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabAdmin = new MetroFramework.Controls.MetroTabControl();
            this.tabUsuarios = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid3 = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSigloXXI = new Vista.DataSetSigloXXI();
            this.btnAgregarUsuario = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarRut = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.tabMesas = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnAgregarMesa = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtCantSillasMesa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNroMesa = new MetroFramework.Controls.MetroTextBox();
            this.lblNroMesa = new MetroFramework.Controls.MetroLabel();
            this.tglEstadoMesa = new MetroFramework.Controls.MetroToggle();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.s = new MetroFramework.Controls.MetroTabPage();
            this.btnCerrarSesion = new MetroFramework.Controls.MetroButton();
            this.dTUsuarioTableAdapter = new Vista.DataSetSigloXXITableAdapters.DTUsuarioTableAdapter();
            this.TabAdmin.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSigloXXI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.tabMesas.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabAdmin
            // 
            this.TabAdmin.Controls.Add(this.tabUsuarios);
            this.TabAdmin.Controls.Add(this.tabMesas);
            this.TabAdmin.Controls.Add(this.s);
            this.TabAdmin.Location = new System.Drawing.Point(23, 63);
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.SelectedIndex = 1;
            this.TabAdmin.Size = new System.Drawing.Size(1059, 562);
            this.TabAdmin.TabIndex = 0;
            this.TabAdmin.UseSelectable = true;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.metroGrid3);
            this.tabUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.tabUsuarios.Controls.Add(this.pictureBox1);
            this.tabUsuarios.Controls.Add(this.txtBuscarRut);
            this.tabUsuarios.Controls.Add(this.metroGrid2);
            this.tabUsuarios.Controls.Add(this.metroGrid1);
            this.tabUsuarios.HorizontalScrollbarBarColor = true;
            this.tabUsuarios.HorizontalScrollbarHighlightOnWheel = false;
            this.tabUsuarios.HorizontalScrollbarSize = 10;
            this.tabUsuarios.Location = new System.Drawing.Point(4, 38);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(1051, 520);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.VerticalScrollbarBarColor = true;
            this.tabUsuarios.VerticalScrollbarHighlightOnWheel = false;
            this.tabUsuarios.VerticalScrollbarSize = 10;
            // 
            // metroGrid3
            // 
            this.metroGrid3.AllowUserToResizeRows = false;
            this.metroGrid3.AutoGenerateColumns = false;
            this.metroGrid3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.eSTADODataGridViewTextBoxColumn});
            this.metroGrid3.DataSource = this.dTUsuarioBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid3.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid3.EnableHeadersVisualStyles = false;
            this.metroGrid3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.Location = new System.Drawing.Point(3, 110);
            this.metroGrid3.Name = "metroGrid3";
            this.metroGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid3.Size = new System.Drawing.Size(839, 373);
            this.metroGrid3.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RUN";
            this.dataGridViewTextBoxColumn1.HeaderText = "RUN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "APELLIDOS";
            this.dataGridViewTextBoxColumn3.HeaderText = "APELLIDOS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CORREO";
            this.dataGridViewTextBoxColumn4.HeaderText = "CORREO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TELEFONO";
            this.dataGridViewTextBoxColumn5.HeaderText = "TELEFONO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DIRECCION";
            this.dataGridViewTextBoxColumn6.HeaderText = "DIRECCION";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TIPO";
            this.dataGridViewTextBoxColumn7.HeaderText = "TIPO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            // 
            // dTUsuarioBindingSource
            // 
            this.dTUsuarioBindingSource.DataMember = "DTUsuario";
            this.dTUsuarioBindingSource.DataSource = this.dataSetSigloXXI;
            // 
            // dataSetSigloXXI
            // 
            this.dataSetSigloXXI.DataSetName = "DataSetSigloXXI";
            this.dataSetSigloXXI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(255, 50);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUsuario.TabIndex = 9;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseSelectable = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBuscarRut
            // 
            // 
            // 
            // 
            this.txtBuscarRut.CustomButton.Image = null;
            this.txtBuscarRut.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtBuscarRut.CustomButton.Name = "";
            this.txtBuscarRut.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscarRut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscarRut.CustomButton.TabIndex = 1;
            this.txtBuscarRut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscarRut.CustomButton.UseSelectable = true;
            this.txtBuscarRut.CustomButton.Visible = false;
            this.txtBuscarRut.Lines = new string[0];
            this.txtBuscarRut.Location = new System.Drawing.Point(3, 50);
            this.txtBuscarRut.MaxLength = 32767;
            this.txtBuscarRut.Name = "txtBuscarRut";
            this.txtBuscarRut.PasswordChar = '\0';
            this.txtBuscarRut.PromptText = "11.111.111-1";
            this.txtBuscarRut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarRut.SelectedText = "";
            this.txtBuscarRut.SelectionLength = 0;
            this.txtBuscarRut.SelectionStart = 0;
            this.txtBuscarRut.ShortcutsEnabled = true;
            this.txtBuscarRut.Size = new System.Drawing.Size(128, 23);
            this.txtBuscarRut.TabIndex = 6;
            this.txtBuscarRut.UseSelectable = true;
            this.txtBuscarRut.WaterMark = "11.111.111-1";
            this.txtBuscarRut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscarRut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(0, 28);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(341, 321);
            this.metroGrid2.TabIndex = 3;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(36, 28);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(240, 150);
            this.metroGrid1.TabIndex = 2;
            // 
            // tabMesas
            // 
            this.tabMesas.Controls.Add(this.metroLabel1);
            this.tabMesas.Controls.Add(this.metroPanel1);
            this.tabMesas.Controls.Add(this.metroDateTime1);
            this.tabMesas.Controls.Add(this.metroProgressBar1);
            this.tabMesas.HorizontalScrollbarBarColor = true;
            this.tabMesas.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMesas.HorizontalScrollbarSize = 10;
            this.tabMesas.Location = new System.Drawing.Point(4, 38);
            this.tabMesas.Name = "tabMesas";
            this.tabMesas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabMesas.Size = new System.Drawing.Size(1051, 520);
            this.tabMesas.TabIndex = 1;
            this.tabMesas.Text = "Mesas";
            this.tabMesas.VerticalScrollbarBarColor = true;
            this.tabMesas.VerticalScrollbarHighlightOnWheel = false;
            this.tabMesas.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(142, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Agregar Mesas";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnAgregarMesa);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtCantSillasMesa);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtNroMesa);
            this.metroPanel1.Controls.Add(this.lblNroMesa);
            this.metroPanel1.Controls.Add(this.tglEstadoMesa);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(29, 57);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(334, 318);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnAgregarMesa
            // 
            this.btnAgregarMesa.Location = new System.Drawing.Point(84, 208);
            this.btnAgregarMesa.Name = "btnAgregarMesa";
            this.btnAgregarMesa.Size = new System.Drawing.Size(126, 19);
            this.btnAgregarMesa.TabIndex = 7;
            this.btnAgregarMesa.Text = "Agregar";
            this.btnAgregarMesa.UseSelectable = true;
            this.btnAgregarMesa.Click += new System.EventHandler(this.btnAgregarMesa_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 130);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Estado";
            // 
            // txtCantSillasMesa
            // 
            // 
            // 
            // 
            this.txtCantSillasMesa.CustomButton.Image = null;
            this.txtCantSillasMesa.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCantSillasMesa.CustomButton.Name = "";
            this.txtCantSillasMesa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantSillasMesa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantSillasMesa.CustomButton.TabIndex = 1;
            this.txtCantSillasMesa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantSillasMesa.CustomButton.UseSelectable = true;
            this.txtCantSillasMesa.CustomButton.Visible = false;
            this.txtCantSillasMesa.Lines = new string[0];
            this.txtCantSillasMesa.Location = new System.Drawing.Point(112, 82);
            this.txtCantSillasMesa.MaxLength = 32767;
            this.txtCantSillasMesa.Name = "txtCantSillasMesa";
            this.txtCantSillasMesa.PasswordChar = '\0';
            this.txtCantSillasMesa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantSillasMesa.SelectedText = "";
            this.txtCantSillasMesa.SelectionLength = 0;
            this.txtCantSillasMesa.SelectionStart = 0;
            this.txtCantSillasMesa.ShortcutsEnabled = true;
            this.txtCantSillasMesa.Size = new System.Drawing.Size(75, 23);
            this.txtCantSillasMesa.TabIndex = 5;
            this.txtCantSillasMesa.UseSelectable = true;
            this.txtCantSillasMesa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantSillasMesa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Cant. Sillas";
            // 
            // txtNroMesa
            // 
            // 
            // 
            // 
            this.txtNroMesa.CustomButton.Image = null;
            this.txtNroMesa.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtNroMesa.CustomButton.Name = "";
            this.txtNroMesa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNroMesa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNroMesa.CustomButton.TabIndex = 1;
            this.txtNroMesa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNroMesa.CustomButton.UseSelectable = true;
            this.txtNroMesa.CustomButton.Visible = false;
            this.txtNroMesa.Lines = new string[0];
            this.txtNroMesa.Location = new System.Drawing.Point(112, 38);
            this.txtNroMesa.MaxLength = 32767;
            this.txtNroMesa.Name = "txtNroMesa";
            this.txtNroMesa.PasswordChar = '\0';
            this.txtNroMesa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNroMesa.SelectedText = "";
            this.txtNroMesa.SelectionLength = 0;
            this.txtNroMesa.SelectionStart = 0;
            this.txtNroMesa.ShortcutsEnabled = true;
            this.txtNroMesa.Size = new System.Drawing.Size(75, 23);
            this.txtNroMesa.TabIndex = 3;
            this.txtNroMesa.UseSelectable = true;
            this.txtNroMesa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNroMesa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNroMesa
            // 
            this.lblNroMesa.AutoSize = true;
            this.lblNroMesa.Location = new System.Drawing.Point(17, 38);
            this.lblNroMesa.Name = "lblNroMesa";
            this.lblNroMesa.Size = new System.Drawing.Size(58, 19);
            this.lblNroMesa.TabIndex = 2;
            this.lblNroMesa.Text = "Número";
            // 
            // tglEstadoMesa
            // 
            this.tglEstadoMesa.AutoSize = true;
            this.tglEstadoMesa.Location = new System.Drawing.Point(112, 132);
            this.tglEstadoMesa.Name = "tglEstadoMesa";
            this.tglEstadoMesa.Size = new System.Drawing.Size(80, 17);
            this.tglEstadoMesa.TabIndex = 3;
            this.tglEstadoMesa.Text = "Off";
            this.tglEstadoMesa.UseSelectable = true;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(418, 190);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 4;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(408, 136);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(100, 23);
            this.metroProgressBar1.TabIndex = 2;
            // 
            // s
            // 
            this.s.HorizontalScrollbarBarColor = true;
            this.s.HorizontalScrollbarHighlightOnWheel = false;
            this.s.HorizontalScrollbarSize = 10;
            this.s.Location = new System.Drawing.Point(4, 38);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(1051, 520);
            this.s.TabIndex = 2;
            this.s.Text = "metroTabPage1";
            this.s.VerticalScrollbarBarColor = true;
            this.s.VerticalScrollbarHighlightOnWheel = false;
            this.s.VerticalScrollbarSize = 10;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.Location = new System.Drawing.Point(960, 31);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(57, 46);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.UseSelectable = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // dTUsuarioTableAdapter
            // 
            this.dTUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 633);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.TabAdmin);
            this.Name = "MenuAdministrador";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuAdministrador_Load);
            this.TabAdmin.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSigloXXI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.tabMesas.ResumeLayout(false);
            this.tabMesas.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabAdmin;
        private MetroFramework.Controls.MetroTabPage tabUsuarios;
        private MetroFramework.Controls.MetroTabPage tabMesas;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroToggle tglEstadoMesa;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MetroFramework.Controls.MetroTextBox txtBuscarRut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnCerrarSesion;
        private MetroFramework.Controls.MetroButton btnAgregarUsuario;
        private System.Windows.Forms.BindingSource dTUsuariosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid metroGrid3;
        private DataSetSigloXXI dataSetSigloXXI;
        private System.Windows.Forms.BindingSource dTUsuarioBindingSource;
        private DataSetSigloXXITableAdapters.DTUsuarioTableAdapter dTUsuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTabPage s;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNroMesa;
        private MetroFramework.Controls.MetroLabel lblNroMesa;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtCantSillasMesa;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnAgregarMesa;
    }
}