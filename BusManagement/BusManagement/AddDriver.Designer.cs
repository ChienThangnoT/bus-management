namespace BusManagement
{
    partial class AddDriver
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
            txtDriverID = new TextBox();
            txtDriverName = new TextBox();
            label2 = new Label();
            dtpDriverDoB = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            cbDriverGender = new ComboBox();
            label5 = new Label();
            dtpDriverStartDate = new DateTimePicker();
            txtDriverSalary = new TextBox();
            label6 = new Label();
            txtDriverAddress = new TextBox();
            label7 = new Label();
            cbBusID = new ComboBox();
            label8 = new Label();
            btnRefresh = new Button();
            btnAdd = new Button();
            btnCancel = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 166);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 1;
            label1.Text = "ID Tài Xế";
            // 
            // txtDriverID
            // 
            txtDriverID.Location = new Point(152, 167);
            txtDriverID.Name = "txtDriverID";
            txtDriverID.Size = new Size(112, 27);
            txtDriverID.TabIndex = 11;
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(152, 220);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(265, 27);
            txtDriverName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 220);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 12;
            label2.Text = "Tên Tài Xế";
            // 
            // dtpDriverDoB
            // 
            dtpDriverDoB.Location = new Point(710, 168);
            dtpDriverDoB.Name = "dtpDriverDoB";
            dtpDriverDoB.Size = new Size(229, 27);
            dtpDriverDoB.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(487, 166);
            label3.Name = "label3";
            label3.Size = new Size(217, 28);
            label3.TabIndex = 15;
            label3.Text = "Ngày Tháng Năm Sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(487, 268);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 16;
            label4.Text = "Giới Tính";
            // 
            // cbDriverGender
            // 
            cbDriverGender.FormattingEnabled = true;
            cbDriverGender.Location = new Point(619, 268);
            cbDriverGender.Name = "cbDriverGender";
            cbDriverGender.Size = new Size(151, 28);
            cbDriverGender.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 320);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 19;
            label5.Text = "Ngày Bắt Đầu";
            // 
            // dtpDriverStartDate
            // 
            dtpDriverStartDate.Location = new Point(152, 321);
            dtpDriverStartDate.Name = "dtpDriverStartDate";
            dtpDriverStartDate.Size = new Size(250, 27);
            dtpDriverStartDate.TabIndex = 18;
            // 
            // txtDriverSalary
            // 
            txtDriverSalary.Location = new Point(619, 217);
            txtDriverSalary.Name = "txtDriverSalary";
            txtDriverSalary.Size = new Size(151, 27);
            txtDriverSalary.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(487, 216);
            label6.Name = "label6";
            label6.Size = new Size(115, 28);
            label6.TabIndex = 20;
            label6.Text = "Tiền Lương";
            // 
            // txtDriverAddress
            // 
            txtDriverAddress.Location = new Point(152, 271);
            txtDriverAddress.Name = "txtDriverAddress";
            txtDriverAddress.Size = new Size(265, 27);
            txtDriverAddress.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 271);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 22;
            label7.Text = "Địa Chỉ";
            // 
            // cbBusID
            // 
            cbBusID.FormattingEnabled = true;
            cbBusID.Location = new Point(619, 320);
            cbBusID.Name = "cbBusID";
            cbBusID.Size = new Size(151, 28);
            cbBusID.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(487, 320);
            label8.Name = "label8";
            label8.Size = new Size(74, 28);
            label8.TabIndex = 24;
            label8.Text = "Xe Bus";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(637, 464);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(173, 55);
            btnRefresh.TabIndex = 28;
            btnRefresh.Text = "Tải Lại";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(393, 464);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(173, 55);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(152, 464);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 55);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(354, 37);
            label9.Name = "label9";
            label9.Size = new Size(228, 38);
            label9.TabIndex = 29;
            label9.Text = "Thêm Mới Tài Xế";
            // 
            // AddDriver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 570);
            Controls.Add(label9);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
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
            Name = "AddDriver";
            Text = "AddDriver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtDriverID;
        private TextBox txtDriverName;
        private Label label2;
        private DateTimePicker dtpDriverDoB;
        private Label label3;
        private Label label4;
        private ComboBox cbDriverGender;
        private Label label5;
        private DateTimePicker dtpDriverStartDate;
        private TextBox txtDriverSalary;
        private Label label6;
        private TextBox txtDriverAddress;
        private Label label7;
        private ComboBox cbBusID;
        private Label label8;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnCancel;
        private Label label9;
    }
}