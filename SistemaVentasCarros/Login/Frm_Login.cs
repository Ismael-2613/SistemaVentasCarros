using BusinessLogicLayer;
using Models.Users;
using SistemaVentasCarros.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaVentasCarros.Login
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            ClsRequest obj_Users = new ClsRequest
            {
                Tbl_Username = txt_username.Text,
                Tbl_Password = txt_password.Text,
            };

            if (string.IsNullOrEmpty(txt_username.Text) && string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Porfavor llena todos los campos antes de continuar"); 
            }
            
                ClsLoginUsers clsLoginUsers = new ClsLoginUsers();
                var login = clsLoginUsers.Login(obj_Users);
                
            if (login.Status == 3)
            {
                MessageBox.Show(login.message, "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_menu frm_Menu = new Frm_menu();
                frm_Menu.Show();
                this.Hide();
            }
            else if (login.Status == 4) 
            {
                MessageBox.Show(login.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(login.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
     
                
            
        }
    }
}
