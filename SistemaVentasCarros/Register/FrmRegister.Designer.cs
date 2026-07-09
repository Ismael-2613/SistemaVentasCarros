namespace SistemaVentasCarros
{
    partial class FrmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_password = new TextBox();
            txt_username = new TextBox();
            btn_login = new Button();
            btn_register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 30);
            label1.TabIndex = 0;
            label1.Text = "REGISTER ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(78, 83);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(156, 23);
            txt_password.TabIndex = 3;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(78, 54);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(156, 23);
            txt_username.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(12, 127);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 5;
            btn_login.Text = "Sign-in";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += this.btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(93, 127);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(75, 23);
            btn_register.TabIndex = 6;
            btn_register.Text = "Sign-up";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += this.btn_register_Click;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 162);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(txt_username);
            Controls.Add(txt_password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_password;
        private TextBox txt_username;
        private Button btn_login;
        private Button btn_register;
    }
}
