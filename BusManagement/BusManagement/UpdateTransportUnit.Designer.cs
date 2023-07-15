namespace BusManagement
{
    partial class UpdateTransportUnit
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
            label5 = new Label();
            txtID = new TextBox();
            txtTenDonVi = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtSoDienThoai = new MaskedTextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            label6 = new Label();
            cbStatus = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(132, 49);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã Đơn Vị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(132, 110);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên Đơn Vị:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(132, 168);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 2;
            label3.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(132, 226);
            label4.Name = "label4";
            label4.Size = new Size(144, 28);
            label4.TabIndex = 3;
            label4.Text = "Số Điện Thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(132, 285);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // txtID
            // 
            txtID.Location = new Point(312, 50);
            txtID.Name = "txtID";
            txtID.Size = new Size(229, 27);
            txtID.TabIndex = 5;
            // 
            // txtTenDonVi
            // 
            txtTenDonVi.Location = new Point(312, 111);
            txtTenDonVi.Name = "txtTenDonVi";
            txtTenDonVi.Size = new Size(229, 27);
            txtTenDonVi.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(312, 168);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(229, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(312, 285);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(312, 226);
            txtSoDienThoai.Mask = "0000000000";
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(229, 27);
            txtSoDienThoai.TabIndex = 9;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(167, 400);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(113, 49);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(401, 400);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(115, 49);
            btnHuy.TabIndex = 12;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(132, 337);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 13;
            label6.Text = "Trạng Thái";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(312, 337);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(151, 28);
            cbStatus.TabIndex = 14;
            // 
            // UpdateTransportUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(cbStatus);
            Controls.Add(label6);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtEmail);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenDonVi);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateTransportUnit";
            Text = "UpdateTransportUnit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtTenDonVi;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private MaskedTextBox txtSoDienThoai;
        private Button btnLuu;
        private Button btnHuy;
        private Label label6;
        private ComboBox cbStatus;
    }
}