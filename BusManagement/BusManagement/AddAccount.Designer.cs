namespace BusManagement
{
    partial class AddAccount
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
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAccountID = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            dtpDob = new DateTimePicker();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            label8 = new Label();
            txtPhoneNumber = new TextBox();
            btnCancel = new Button();
            btnAdd = new Button();
            btnRefresh = new Button();
            cbbRole = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 113);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 2;
            label1.Text = "ID Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 180);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 13;
            label2.Text = "Tên Tài Khoản";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 239);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 23;
            label7.Text = "Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 300);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 24;
            label3.Text = "Họ và Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(453, 113);
            label4.Name = "label4";
            label4.Size = new Size(217, 28);
            label4.TabIndex = 25;
            label4.Text = "Ngày Tháng Năm Sinh";
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(155, 116);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(265, 27);
            txtAccountID.TabIndex = 26;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(155, 180);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(265, 27);
            txtUserName.TabIndex = 27;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(155, 241);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(265, 27);
            txtPassword.TabIndex = 28;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(155, 297);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(265, 27);
            txtFullName.TabIndex = 29;
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(654, 112);
            dtpDob.Margin = new Padding(3, 4, 3, 4);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(228, 27);
            dtpDob.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(453, 177);
            label5.Name = "label5";
            label5.Size = new Size(130, 28);
            label5.TabIndex = 31;
            label5.Text = "Địa Chỉ Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(617, 177);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 27);
            txtEmail.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(453, 239);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 33;
            label6.Text = "Số Điện Thoại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(453, 300);
            label8.Name = "label8";
            label8.Size = new Size(88, 28);
            label8.TabIndex = 34;
            label8.Text = "Chức Vụ";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(617, 241);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(265, 27);
            txtPhoneNumber.TabIndex = 36;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(58, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 55);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Trở Lại";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(347, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(173, 55);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(654, 409);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(173, 55);
            btnRefresh.TabIndex = 41;
            btnRefresh.Text = "Làm Mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cbbRole
            // 
            cbbRole.FormattingEnabled = true;
            cbbRole.Location = new Point(617, 303);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(265, 28);
            cbbRole.TabIndex = 43;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cbbRole);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(dtpDob);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtAccountID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAccount";
            Text = "AddAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label7;
        private Label label3;
        private Label label4;
        private TextBox txtAccountID;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private DateTimePicker dtpDob;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private Label label8;
        private TextBox txtPhoneNumber;
        private Button btnCancel;
        private Button btnAdd;
        private Button btnRefresh;
        private ComboBox cbbRole;
    }
}