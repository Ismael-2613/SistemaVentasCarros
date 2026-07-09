using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaVentasCarros.Menu
{
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cars frm_Cars = new Frm_Cars();
            frm_Cars.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Customer frm_Customer = new Frm_Customer();
            frm_Customer.Show();
            this.Hide();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Sells frm_Sells = new Frm_Sells();
            frm_Sells.Show();
            this.Hide();
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Reports frm_Reports = new Frm_Reports();
            frm_Reports.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegister frm_Register = new FrmRegister();   
            frm_Register.Show();
            this.Hide();
        }
    }
}
