namespace Vista.Cocina
{
    partial class VerPedidos
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
            this.panelListaPedidos = new MetroFramework.Controls.MetroPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // panelListaPedidos
            // 
            this.panelListaPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListaPedidos.HorizontalScrollbarBarColor = true;
            this.panelListaPedidos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelListaPedidos.HorizontalScrollbarSize = 10;
            this.panelListaPedidos.Location = new System.Drawing.Point(20, 60);
            this.panelListaPedidos.Name = "panelListaPedidos";
            this.panelListaPedidos.Size = new System.Drawing.Size(760, 493);
            this.panelListaPedidos.TabIndex = 0;
            this.panelListaPedidos.VerticalScrollbarBarColor = true;
            this.panelListaPedidos.VerticalScrollbarHighlightOnWheel = false;
            this.panelListaPedidos.VerticalScrollbarSize = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(585, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Hora: ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(625, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(123, 19);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Tiempo del sistema";
            // 
            // VerPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panelListaPedidos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerPedidos";
            this.Text = "Lista de pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelListaPedidos;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblTime;
    }
}