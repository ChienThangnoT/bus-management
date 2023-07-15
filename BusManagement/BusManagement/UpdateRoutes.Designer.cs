namespace BusManagement
{
    partial class UpdateRoutes
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
            mTxtBreakTime = new MaskedTextBox();
            txtRoutesId = new TextBox();
            label8 = new Label();
            btnUpdate = new Button();
            btnCancel = new Button();
            mTxtEndTime = new MaskedTextBox();
            mTxtStartTime = new MaskedTextBox();
            txtName = new TextBox();
            txtTo = new RichTextBox();
            txtFrom = new RichTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbb = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            cbStatus = new ComboBox();
            SuspendLayout();
            // 
            // mTxtBreakTime
            // 
            mTxtBreakTime.Location = new Point(696, 170);
            mTxtBreakTime.Mask = "00000";
            mTxtBreakTime.Name = "mTxtBreakTime";
            mTxtBreakTime.Size = new Size(42, 27);
            mTxtBreakTime.TabIndex = 40;
            mTxtBreakTime.ValidatingType = typeof(int);
            // 
            // txtRoutesId
            // 
            txtRoutesId.Location = new Point(605, 87);
            txtRoutesId.Name = "txtRoutesId";
            txtRoutesId.Size = new Size(125, 27);
            txtRoutesId.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(490, 83);
            label8.Name = "label8";
            label8.Size = new Size(105, 28);
            label8.TabIndex = 37;
            label8.Text = "Mã Tuyến:";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(490, 510);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(173, 55);
            btnUpdate.TabIndex = 35;
            btnUpdate.Text = "Lưu";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(220, 510);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 55);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // mTxtEndTime
            // 
            mTxtEndTime.Location = new Point(240, 170);
            mTxtEndTime.Mask = "00:00";
            mTxtEndTime.Name = "mTxtEndTime";
            mTxtEndTime.Size = new Size(83, 27);
            mTxtEndTime.TabIndex = 33;
            mTxtEndTime.ValidatingType = typeof(DateTime);
            // 
            // mTxtStartTime
            // 
            mTxtStartTime.Location = new Point(226, 87);
            mTxtStartTime.Mask = "00:00";
            mTxtStartTime.Name = "mTxtStartTime";
            mTxtStartTime.Size = new Size(83, 27);
            mTxtStartTime.TabIndex = 32;
            mTxtStartTime.ValidatingType = typeof(DateTime);
            // 
            // txtName
            // 
            txtName.Location = new Point(605, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 31;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(490, 273);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(361, 148);
            txtTo.TabIndex = 30;
            txtTo.Text = "";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(39, 273);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(361, 148);
            txtFrom.TabIndex = 29;
            txtFrom.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(490, 232);
            label7.Name = "label7";
            label7.Size = new Size(167, 28);
            label7.TabIndex = 28;
            label7.Text = "Lộ Trình Lượt Về:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(39, 232);
            label6.Name = "label6";
            label6.Size = new Size(162, 28);
            label6.TabIndex = 27;
            label6.Text = "Lộ Trình Lượt Đi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(490, 166);
            label5.Name = "label5";
            label5.Size = new Size(200, 28);
            label5.TabIndex = 26;
            label5.Text = "Thời Gian Giãn Cách:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 166);
            label4.Name = "label4";
            label4.Size = new Size(190, 28);
            label4.TabIndex = 25;
            label4.Text = "Thời Gian Kết Thúc:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 86);
            label3.Name = "label3";
            label3.Size = new Size(181, 28);
            label3.TabIndex = 24;
            label3.Text = "Thời Gian Bắt Đầu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(490, 15);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 23;
            label2.Text = "Tên Tuyến:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 15);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 22;
            label1.Text = "Đơn Vị Vận Chuyển:";
            // 
            // cbb
            // 
            cbb.FormattingEnabled = true;
            cbb.Location = new Point(240, 18);
            cbb.Name = "cbb";
            cbb.Size = new Size(151, 28);
            cbb.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(744, 177);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 41;
            label9.Text = "Phút";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(313, 441);
            label10.Name = "label10";
            label10.Size = new Size(106, 28);
            label10.TabIndex = 42;
            label10.Text = "Trạng Thái";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(458, 441);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(151, 28);
            cbStatus.TabIndex = 43;
            // 
            // UpdateRoutes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 587);
            Controls.Add(cbStatus);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(mTxtBreakTime);
            Controls.Add(txtRoutesId);
            Controls.Add(label8);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(mTxtEndTime);
            Controls.Add(mTxtStartTime);
            Controls.Add(txtName);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbb);
            Name = "UpdateRoutes";
            Text = "UpdateRoutes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mTxtBreakTime;
        private TextBox txtRoutesId;
        private Label label8;
        private Button btnUpdate;
        private Button btnCancel;
        private MaskedTextBox mTxtEndTime;
        private MaskedTextBox mTxtStartTime;
        private TextBox txtName;
        private RichTextBox txtTo;
        private RichTextBox txtFrom;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbb;
        private Label label9;
        private Label label10;
        private ComboBox cbStatus;
    }
}