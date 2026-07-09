namespace SistemaVentasCarros.Login
{
    partial class Frm_Login
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
            btn_register = new Button();
            btn_login = new Button();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_register
            // 
            btn_register.Location = new Point(89, 127);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(75, 23);
            btn_register.TabIndex = 13;
            btn_register.Text = "Sign-up";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(8, 127);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 12;
            btn_login.Text = "Sign-in";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(74, 54);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(156, 23);
            txt_username.TabIndex = 11;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(74, 83);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(156, 23);
            txt_password.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 57);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 87);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 7;
            label1.Text = "LOGIN";
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 167);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(txt_username);
            Controls.Add(txt_password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_register;
        private Button btn_login;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}