namespace SistemaVentasCarros.Menu
{
    partial class Frm_menu
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
            components = new System.ComponentModel.Container();
            contextMenuStrip3 = new ContextMenuStrip(components);
            carrosToolStripMenuItem1 = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            carrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            ventasToolStripMenuItem1 = new ToolStripMenuItem();
            reportesToolStripMenuItem1 = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { carrosToolStripMenuItem1 });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.ShowImageMargin = false;
            contextMenuStrip3.Size = new Size(84, 26);
            // 
            // carrosToolStripMenuItem1
            // 
            carrosToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem });
            carrosToolStripMenuItem1.Name = "carrosToolStripMenuItem1";
            carrosToolStripMenuItem1.Size = new Size(83, 22);
            carrosToolStripMenuItem1.Text = "Carros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventasToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(116, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportesToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(108, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(120, 22);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(142, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { carrosToolStripMenuItem, clientesToolStripMenuItem1, ventasToolStripMenuItem1, reportesToolStripMenuItem1, cerrarSesionToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(941, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // carrosToolStripMenuItem
            // 
            carrosToolStripMenuItem.Name = "carrosToolStripMenuItem";
            carrosToolStripMenuItem.Size = new Size(53, 20);
            carrosToolStripMenuItem.Text = "Carros";
            carrosToolStripMenuItem.Click += carrosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(61, 20);
            clientesToolStripMenuItem1.Text = "Clientes";
            clientesToolStripMenuItem1.Click += clientesToolStripMenuItem1_Click;
            // 
            // ventasToolStripMenuItem1
            // 
            ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            ventasToolStripMenuItem1.Size = new Size(53, 20);
            ventasToolStripMenuItem1.Text = "Ventas";
            ventasToolStripMenuItem1.Click += ventasToolStripMenuItem1_Click;
            // 
            // reportesToolStripMenuItem1
            // 
            reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            reportesToolStripMenuItem1.Size = new Size(65, 20);
            reportesToolStripMenuItem1.Text = "Reportes";
            reportesToolStripMenuItem1.Click += reportesToolStripMenuItem1_Click;
            // 
            // cerrarSesionToolStripMenuItem1
            // 
            cerrarSesionToolStripMenuItem1.Name = "cerrarSesionToolStripMenuItem1";
            cerrarSesionToolStripMenuItem1.Size = new Size(87, 20);
            cerrarSesionToolStripMenuItem1.Text = "Cerrar sesion";
            cerrarSesionToolStripMenuItem1.Click += cerrarSesionToolStripMenuItem1_Click;
            // 
            // Frm_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Frm_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_menu";
            contextMenuStrip3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem carrosToolStripMenuItem1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem carrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem ventasToolStripMenuItem1;
        private ToolStripMenuItem reportesToolStripMenuItem1;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem1;
    }
}