namespace SigloXXI.Cocina
{
    partial class Comandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comandas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrarSesion = new MetroFramework.Controls.MetroButton();
            this.tabControlCocina = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnCrearMenu = new MetroFramework.Controls.MetroButton();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCocina = new Vista.DataSetCocina();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nOMBREDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETRICAIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNGREDIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVEEDORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETRICAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pRODUCTOTableAdapter = new Vista.DataSetCocinaTableAdapters.PRODUCTOTableAdapter();
            this.mENUTableAdapter = new Vista.DataSetCocinaTableAdapters.MENUTableAdapter();
            this.iNGREDIENTETableAdapter = new Vista.DataSetCocinaTableAdapters.INGREDIENTETableAdapter();
            this.tabControlCocina.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCocina)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGREDIENTEBindingSource)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarSesion.Location = new System.Drawing.Point(700, 11);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(57, 46);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.UseSelectable = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // tabControlCocina
            // 
            this.tabControlCocina.Controls.Add(this.metroTabPage2);
            this.tabControlCocina.Controls.Add(this.metroTabPage1);
            this.tabControlCocina.Controls.Add(this.metroTabPage3);
            this.tabControlCocina.Controls.Add(this.metroTabPage4);
            this.tabControlCocina.Location = new System.Drawing.Point(23, 82);
            this.tabControlCocina.Name = "tabControlCocina";
            this.tabControlCocina.SelectedIndex = 2;
            this.tabControlCocina.Size = new System.Drawing.Size(734, 441);
            this.tabControlCocina.TabIndex = 6;
            this.tabControlCocina.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(726, 399);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Pedidos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnCrearMenu);
            this.metroTabPage2.Controls.Add(this.metroGrid2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(726, 399);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Menu";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnCrearMenu
            // 
            this.btnCrearMenu.Location = new System.Drawing.Point(553, 3);
            this.btnCrearMenu.Name = "btnCrearMenu";
            this.btnCrearMenu.Size = new System.Drawing.Size(170, 47);
            this.btnCrearMenu.TabIndex = 3;
            this.btnCrearMenu.Text = "Agregar Menu";
            this.btnCrearMenu.UseSelectable = true;
            this.btnCrearMenu.Click += new System.EventHandler(this.btnCrearMenu_Click);
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.AutoGenerateColumns = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nOMBREDataGridViewTextBoxColumn1,
            this.pRECIODataGridViewTextBoxColumn,
            this.uRLDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn});
            this.metroGrid2.DataSource = this.mENUBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(3, 3);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(544, 400);
            this.metroGrid2.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // nOMBREDataGridViewTextBoxColumn1
            // 
            this.nOMBREDataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn1.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn1.Name = "nOMBREDataGridViewTextBoxColumn1";
            // 
            // pRECIODataGridViewTextBoxColumn
            // 
            this.pRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.Name = "pRECIODataGridViewTextBoxColumn";
            // 
            // uRLDataGridViewTextBoxColumn
            // 
            this.uRLDataGridViewTextBoxColumn.DataPropertyName = "URL";
            this.uRLDataGridViewTextBoxColumn.HeaderText = "URL";
            this.uRLDataGridViewTextBoxColumn.Name = "uRLDataGridViewTextBoxColumn";
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            // 
            // mENUBindingSource
            // 
            this.mENUBindingSource.DataMember = "MENU";
            this.mENUBindingSource.DataSource = this.dataSetCocina;
            // 
            // dataSetCocina
            // 
            this.dataSetCocina.DataSetName = "DataSetCocina";
            this.dataSetCocina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroButton1);
            this.metroTabPage3.Controls.Add(this.dataGridView1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(726, 399);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Ingrediente";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(555, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(168, 49);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Agregar Ingrediente";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBREDataGridViewTextBoxColumn2,
            this.cANTIDADDataGridViewTextBoxColumn,
            this.mENUIDDataGridViewTextBoxColumn,
            this.pRODUCTOIDDataGridViewTextBoxColumn,
            this.mETRICAIDDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.iNGREDIENTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 326);
            this.dataGridView1.TabIndex = 2;
            // 
            // nOMBREDataGridViewTextBoxColumn2
            // 
            this.nOMBREDataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn2.Name = "nOMBREDataGridViewTextBoxColumn2";
            // 
            // cANTIDADDataGridViewTextBoxColumn
            // 
            this.cANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.Name = "cANTIDADDataGridViewTextBoxColumn";
            // 
            // mENUIDDataGridViewTextBoxColumn
            // 
            this.mENUIDDataGridViewTextBoxColumn.DataPropertyName = "MENU_ID";
            this.mENUIDDataGridViewTextBoxColumn.HeaderText = "MENU_ID";
            this.mENUIDDataGridViewTextBoxColumn.Name = "mENUIDDataGridViewTextBoxColumn";
            // 
            // pRODUCTOIDDataGridViewTextBoxColumn
            // 
            this.pRODUCTOIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTO_ID";
            this.pRODUCTOIDDataGridViewTextBoxColumn.HeaderText = "PRODUCTO_ID";
            this.pRODUCTOIDDataGridViewTextBoxColumn.Name = "pRODUCTOIDDataGridViewTextBoxColumn";
            // 
            // mETRICAIDDataGridViewTextBoxColumn1
            // 
            this.mETRICAIDDataGridViewTextBoxColumn1.DataPropertyName = "METRICA_ID";
            this.mETRICAIDDataGridViewTextBoxColumn1.HeaderText = "METRICA_ID";
            this.mETRICAIDDataGridViewTextBoxColumn1.Name = "mETRICAIDDataGridViewTextBoxColumn1";
            // 
            // iNGREDIENTEBindingSource
            // 
            this.iNGREDIENTEBindingSource.DataMember = "INGREDIENTE";
            this.iNGREDIENTEBindingSource.DataSource = this.dataSetCocina;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.metroGrid1);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(726, 399);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Productos";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cODIGODataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.pROVEEDORIDDataGridViewTextBoxColumn,
            this.mETRICAIDDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.pRODUCTOBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 3);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(543, 393);
            this.metroGrid1.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // pROVEEDORIDDataGridViewTextBoxColumn
            // 
            this.pROVEEDORIDDataGridViewTextBoxColumn.DataPropertyName = "PROVEEDOR_ID";
            this.pROVEEDORIDDataGridViewTextBoxColumn.HeaderText = "PROVEEDOR_ID";
            this.pROVEEDORIDDataGridViewTextBoxColumn.Name = "pROVEEDORIDDataGridViewTextBoxColumn";
            // 
            // mETRICAIDDataGridViewTextBoxColumn
            // 
            this.mETRICAIDDataGridViewTextBoxColumn.DataPropertyName = "METRICA_ID";
            this.mETRICAIDDataGridViewTextBoxColumn.HeaderText = "METRICA_ID";
            this.mETRICAIDDataGridViewTextBoxColumn.Name = "mETRICAIDDataGridViewTextBoxColumn";
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource.DataSource = this.dataSetCocina;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(247, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Bienvenida(o): ";
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // mENUTableAdapter
            // 
            this.mENUTableAdapter.ClearBeforeFill = true;
            // 
            // iNGREDIENTETableAdapter
            // 
            this.iNGREDIENTETableAdapter.ClearBeforeFill = true;
            // 
            // Comandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 496);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tabControlCocina);
            this.Controls.Add(this.btnCerrarSesion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Comandas";
            this.Text = "Menu de cocina";
            this.Load += new System.EventHandler(this.Comandas_Load);
            this.tabControlCocina.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCocina)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGREDIENTEBindingSource)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCerrarSesion;
        private MetroFramework.Controls.MetroTabControl tabControlCocina;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Vista.DataSetCocina dataSetCocina;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource;
        private Vista.DataSetCocinaTableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROVEEDORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETRICAIDDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.BindingSource mENUBindingSource;
        private Vista.DataSetCocinaTableAdapters.MENUTableAdapter mENUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnCrearMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource iNGREDIENTEBindingSource;
        private Vista.DataSetCocinaTableAdapters.INGREDIENTETableAdapter iNGREDIENTETableAdapter;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mENUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETRICAIDDataGridViewTextBoxColumn1;
    }
}