namespace BusManagement
{
    partial class Login
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
            btnLogin = new Button();
            txtAccount = new TextBox();
            tk = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(310, 318);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(191, 60);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(310, 138);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(226, 27);
            txtAccount.TabIndex = 1;
            // 
            // tk
            // 
            tk.AutoSize = true;
            tk.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tk.Location = new Point(189, 140);
            tk.Name = "tk";
            tk.Size = new Size(95, 25);
            tk.TabIndex = 2;
            tk.Text = "Tài Khoản:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(189, 222);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 4;
            label1.Text = "Mật Khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(310, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(226, 27);
            txtPassword.TabIndex = 3;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 511);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(tk);
            Controls.Add(txtAccount);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtAccount;
        private Label tk;
        private Label label1;
        private TextBox txtPassword;
    }
}