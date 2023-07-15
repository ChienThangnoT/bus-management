namespace BusManagement
{
    partial class UpdateDriver
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
            label9 = new Label();
            btnUpdate = new Button();
            btnCancel = new Button();
            cbBusID = new ComboBox();
            label8 = new Label();
            txtDriverAddress = new TextBox();
            label7 = new Label();
            txtDriverSalary = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dtpDriverStartDate = new DateTimePicker();
            cbDriverGender = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            dtpDriverDoB = new DateTimePicker();
            txtDriverName = new TextBox();
            label2 = new Label();
            txtDriverID = new TextBox();
            label1 = new Label();
            cbIsActive = new ComboBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(373, 31);
            label9.Name = "label9";
            label9.Size = new Size(281, 38);
            label9.TabIndex = 49;
            label9.Text = "Sửa Thông Tin Tài Xế";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(520, 468);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(173, 55);
            btnUpdate.TabIndex = 47;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(329, 468);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 55);
            btnCancel.TabIndex = 46;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbBusID
            // 
            cbBusID.FormattingEnabled = true;
            cbBusID.Location = new Point(652, 314);
            cbBusID.Name = "cbBusID";
            cbBusID.Size = new Size(151, 28);
            cbBusID.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(520, 314);
            label8.Name = "label8";
            label8.Size = new Size(100, 28);
            label8.TabIndex = 44;
            label8.Text = "ID Xe Bus";
            // 
            // txtDriverAddress
            // 
            txtDriverAddress.Location = new Point(185, 265);
            txtDriverAddress.Name = "txtDriverAddress";
            txtDriverAddress.Size = new Size(265, 27);
            txtDriverAddress.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(45, 265);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 42;
            label7.Text = "Địa Chỉ";
            // 
            // txtDriverSalary
            // 
            txtDriverSalary.Location = new Point(652, 211);
            txtDriverSalary.Name = "txtDriverSalary";
            txtDriverSalary.Size = new Size(125, 27);
            txtDriverSalary.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(520, 210);
            label6.Name = "label6";
            label6.Size = new Size(115, 28);
            label6.TabIndex = 40;
            label6.Text = "Tiền Lương";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(45, 314);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 39;
            label5.Text = "Ngày Bắt Đầu";
            // 
            // dtpDriverStartDate
            // 
            dtpDriverStartDate.Location = new Point(185, 315);
            dtpDriverStartDate.Name = "dtpDriverStartDate";
            dtpDriverStartDate.Size = new Size(250, 27);
            dtpDriverStartDate.TabIndex = 38;
            // 
            // cbDriverGender
            // 
            cbDriverGender.FormattingEnabled = true;
            cbDriverGender.Location = new Point(652, 262);
            cbDriverGender.Name = "cbDriverGender";
            cbDriverGender.Size = new Size(151, 28);
            cbDriverGender.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(520, 262);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 36;
            label4.Text = "Giới Tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(520, 160);
            label3.Name = "label3";
            label3.Size = new Size(217, 28);
            label3.TabIndex = 35;
            label3.Text = "Ngày Tháng Năm Sinh";
            // 
            // dtpDriverDoB
            // 
            dtpDriverDoB.Location = new Point(743, 162);
            dtpDriverDoB.Name = "dtpDriverDoB";
            dtpDriverDoB.Size = new Size(250, 27);
            dtpDriverDoB.TabIndex = 34;
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(185, 214);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(265, 27);
            txtDriverName.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 214);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 32;
            label2.Text = "Tên Tài Xế";
            // 
            // txtDriverID
            // 
            txtDriverID.Location = new Point(185, 161);
            txtDriverID.Name = "txtDriverID";
            txtDriverID.Size = new Size(125, 27);
            txtDriverID.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 160);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 30;
            label1.Text = "ID Tài Xế";
            // 
            // cbIsActive
            // 
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Location = new Point(532, 368);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(151, 28);
            cbIsActive.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(329, 368);
            label10.Name = "label10";
            label10.Size = new Size(186, 28);
            label10.TabIndex = 50;
            label10.Text = "Tình trạng làm việc";
            // 
            // UpdateDriver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 545);
            Controls.Add(cbIsActive);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(cbBusID);
            Controls.Add(label8);
            Controls.Add(txtDriverAddress);
            Controls.Add(label7);
            Controls.Add(txtDriverSalary);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpDriverStartDate);
            Controls.Add(cbDriverGender);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpDriverDoB);
            Controls.Add(txtDriverName);
            Controls.Add(label2);
            Controls.Add(txtDriverID);
            Controls.Add(label1);
            Name = "UpdateDriver";
            Text = "UpdateDriver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Button btnUpdate;
        private Button btnCancel;
        private ComboBox cbBusID;
        private Label label8;
        private TextBox txtDriverAddress;
        private Label label7;
        private TextBox txtDriverSalary;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpDriverStartDate;
        private ComboBox cbDriverGender;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpDriverDoB;
        private TextBox txtDriverName;
        private Label label2;
        private TextBox txtDriverID;
        private Label label1;
        private ComboBox cbIsActive;
        private Label label10;
    }
}