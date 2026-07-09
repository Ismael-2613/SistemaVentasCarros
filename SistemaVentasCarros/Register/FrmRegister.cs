using BusinessLogicLayer;
using Models.Users;
using SistemaVentasCarros.Login;

namespace SistemaVentasCarros
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
            this.Hide();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text) && string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Por favor llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
                ClsRequest clsUsers = new ClsRequest
                {
                    Tbl_Username = txt_username.Text,
                    Tbl_Password = txt_password.Text,
                };

                ClsRegisterUsers clsRegisterUsers = new ClsRegisterUsers();
                var register = clsRegisterUsers.Register(clsUsers);

            if (register.Status == 1)
            {
                MessageBox.Show(register.message, "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(register.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
