namespace BusManagement
{
    partial class AddRoutes
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
            cbb = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtFrom = new RichTextBox();
            txtTo = new RichTextBox();
            txtName = new TextBox();
            mTxtStartTime = new MaskedTextBox();
            mTxtEndTime = new MaskedTextBox();
            btnCancel = new Button();
            btnAdd = new Button();
            btnRefresh = new Button();
            txtRoutesId = new TextBox();
            label8 = new Label();
            mTxtBreakTime = new MaskedTextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // cbb
            // 
            cbb.FormattingEnabled = true;
            cbb.Location = new Point(241, 31);
            cbb.Name = "cbb";
            cbb.Size = new Size(151, 28);
            cbb.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 28);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 1;
            label1.Text = "Đơn Vị Vận Chuyển:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(491, 28);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên Tuyến:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 113);
            label3.Name = "label3";
            label3.Size = new Size(181, 28);
            label3.TabIndex = 3;
            label3.Text = "Thời Gian Bắt Đầu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 193);
            label4.Name = "label4";
            label4.Size = new Size(190, 28);
            label4.TabIndex = 4;
            label4.Text = "Thời Gian Kết Thúc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(491, 193);
            label5.Name = "label5";
            label5.Size = new Size(200, 28);
            label5.TabIndex = 5;
            label5.Text = "Thời Gian Giãn Cách:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(40, 263);
            label6.Name = "label6";
            label6.Size = new Size(162, 28);
            label6.TabIndex = 6;
            label6.Text = "Lộ Trình Lượt Đi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(491, 263);
            label7.Name = "label7";
            label7.Size = new Size(167, 28);
            label7.TabIndex = 7;
            label7.Text = "Lộ Trình Lượt Về:";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(40, 304);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(361, 148);
            txtFrom.TabIndex = 8;
            txtFrom.Text = "";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(491, 304);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(361, 148);
            txtTo.TabIndex = 9;
            txtTo.Text = "";
            // 
            // txtName
            // 
            txtName.Location = new Point(606, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 10;
            // 
            // mTxtStartTime
            // 
            mTxtStartTime.Location = new Point(227, 114);
            mTxtStartTime.Mask = "00:00";
            mTxtStartTime.Name = "mTxtStartTime";
            mTxtStartTime.Size = new Size(83, 27);
            mTxtStartTime.TabIndex = 11;
            mTxtStartTime.ValidatingType = typeof(DateTime);
            // 
            // mTxtEndTime
            // 
            mTxtEndTime.Location = new Point(241, 197);
            mTxtEndTime.Mask = "00:00";
            mTxtEndTime.Name = "mTxtEndTime";
            mTxtEndTime.Size = new Size(83, 27);
            mTxtEndTime.TabIndex = 12;
            mTxtEndTime.ValidatingType = typeof(DateTime);
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(40, 508);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 55);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(276, 508);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(173, 55);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(508, 508);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(173, 55);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Làm Mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtRoutesId
            // 
            txtRoutesId.Location = new Point(606, 114);
            txtRoutesId.Name = "txtRoutesId";
            txtRoutesId.Size = new Size(125, 27);
            txtRoutesId.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(491, 110);
            label8.Name = "label8";
            label8.Size = new Size(105, 28);
            label8.TabIndex = 17;
            label8.Text = "Mã Tuyến:";
            // 
            // mTxtBreakTime
            // 
            mTxtBreakTime.Location = new Point(697, 197);
            mTxtBreakTime.Mask = "00000";
            mTxtBreakTime.Name = "mTxtBreakTime";
            mTxtBreakTime.Size = new Size(42, 27);
            mTxtBreakTime.TabIndex = 20;
            mTxtBreakTime.ValidatingType = typeof(int);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(745, 204);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 21;
            label9.Text = "Phút";
            // 
            // AddRoutes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 600);
            Controls.Add(label9);
            Controls.Add(mTxtBreakTime);
            Controls.Add(txtRoutesId);
            Controls.Add(label8);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
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
            Name = "AddRoutes";
            Text = "AddRoutes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox txtFrom;
        private RichTextBox txtTo;
        private TextBox txtName;
        private MaskedTextBox mTxtStartTime;
        private MaskedTextBox mTxtEndTime;
        private Button btnCancel;
        private Button btnAdd;
        private Button btnRefresh;
        private TextBox txtRoutesId;
        private Label label8;
        private MaskedTextBox mTxtBreakTime;
        private Label label9;
    }
}