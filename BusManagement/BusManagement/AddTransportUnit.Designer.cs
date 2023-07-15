namespace BusManagement
{
    partial class AddTransportUnit
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
            label3 = new Label();
            label4 = new Label();
            txtTenDonVi = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtDienThoai = new MaskedTextBox();
            btnLuu = new Button();
            btnLamMoi = new Button();
            btnHuy = new Button();
            label5 = new Label();
            txtID = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 112);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Đơn Vị:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 158);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 1;
            label2.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 209);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 2;
            label3.Text = "Số Điện Thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(70, 257);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // txtTenDonVi
            // 
            txtTenDonVi.Location = new Point(267, 110);
            txtTenDonVi.Name = "txtTenDonVi";
            txtTenDonVi.Size = new Size(229, 27);
            txtTenDonVi.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(267, 162);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(229, 27);
            txtDiaChi.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(267, 261);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(267, 209);
            txtDienThoai.Mask = "0000000000";
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(229, 27);
            txtDienThoai.TabIndex = 7;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.Location = new Point(88, 363);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(114, 45);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLamMoi.Location = new Point(267, 363);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(111, 45);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.Location = new Point(429, 363);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(105, 45);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(70, 57);
            label5.Name = "label5";
            label5.Size = new Size(75, 28);
            label5.TabIndex = 11;
            label5.Text = "Tên ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(267, 57);
            txtID.Name = "txtID";
            txtID.Size = new Size(229, 27);
            txtID.TabIndex = 12;
            // 
            // AddTransportUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(btnHuy);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuu);
            Controls.Add(txtDienThoai);
            Controls.Add(txtEmail);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenDonVi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddTransportUnit";
            Text = "AddTransportUnit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTenDonVi;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private MaskedTextBox txtDienThoai;
        private Button btnLuu;
        private Button btnLamMoi;
        private Button btnHuy;
        private Label label5;
        private TextBox txtID;
    }
}