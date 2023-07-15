namespace BusManagement
{
    partial class UpdateBus
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
            cbPeriodic = new ComboBox();
            cbBustype = new ComboBox();
            txtNumePlate = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            cbRoute = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtManufacturing = new DateTimePicker();
            dtRegistration = new DateTimePicker();
            txtEngine = new TextBox();
            txtSeat = new TextBox();
            txtBusID = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            label13 = new Label();
            cbStatus = new ComboBox();
            SuspendLayout();
            // 
            // cbPeriodic
            // 
            cbPeriodic.FormattingEnabled = true;
            cbPeriodic.Location = new Point(380, 412);
            cbPeriodic.Name = "cbPeriodic";
            cbPeriodic.Size = new Size(151, 28);
            cbPeriodic.TabIndex = 52;
            // 
            // cbBustype
            // 
            cbBustype.FormattingEnabled = true;
            cbBustype.Location = new Point(381, 168);
            cbBustype.Name = "cbBustype";
            cbBustype.Size = new Size(151, 28);
            cbBustype.TabIndex = 51;
            // 
            // txtNumePlate
            // 
            txtNumePlate.Location = new Point(380, 72);
            txtNumePlate.Name = "txtNumePlate";
            txtNumePlate.Size = new Size(137, 27);
            txtNumePlate.TabIndex = 50;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(227, 74);
            label12.Name = "label12";
            label12.Size = new Size(104, 25);
            label12.TabIndex = 49;
            label12.Text = "Biển số xe:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(555, 225);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 48;
            label11.Text = "Ghế";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(539, 420);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 47;
            label10.Text = "Tháng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(555, 277);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 46;
            label9.Text = "W";
            // 
            // cbRoute
            // 
            cbRoute.FormattingEnabled = true;
            cbRoute.Location = new Point(380, 119);
            cbRoute.Name = "cbRoute";
            cbRoute.Size = new Size(151, 28);
            cbRoute.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(152, 415);
            label8.Name = "label8";
            label8.Size = new Size(179, 25);
            label8.TabIndex = 41;
            label8.Text = "Bảo dưỡng định kỳ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(194, 318);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 40;
            label7.Text = "Ngày sản suất:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(185, 369);
            label6.Name = "label6";
            label6.Size = new Size(146, 25);
            label6.TabIndex = 39;
            label6.Text = "Hạn đăng kiểm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(229, 269);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 38;
            label5.Text = "Công suất:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(256, 220);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 37;
            label4.Text = "Số ghế:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(254, 171);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 36;
            label3.Text = "Loại xe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(201, 122);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 35;
            label2.Text = "Tuyến đường:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(262, 29);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 34;
            label1.Text = "Mã xe:";
            // 
            // dtManufacturing
            // 
            dtManufacturing.Location = new Point(380, 316);
            dtManufacturing.Name = "dtManufacturing";
            dtManufacturing.Size = new Size(250, 27);
            dtManufacturing.TabIndex = 33;
            // 
            // dtRegistration
            // 
            dtRegistration.Location = new Point(380, 367);
            dtRegistration.Name = "dtRegistration";
            dtRegistration.Size = new Size(250, 27);
            dtRegistration.TabIndex = 32;
            // 
            // txtEngine
            // 
            txtEngine.Location = new Point(380, 267);
            txtEngine.Name = "txtEngine";
            txtEngine.Size = new Size(137, 27);
            txtEngine.TabIndex = 31;
            // 
            // txtSeat
            // 
            txtSeat.Location = new Point(380, 218);
            txtSeat.Name = "txtSeat";
            txtSeat.Size = new Size(137, 27);
            txtSeat.TabIndex = 30;
            // 
            // txtBusID
            // 
            txtBusID.Location = new Point(380, 27);
            txtBusID.Name = "txtBusID";
            txtBusID.ReadOnly = true;
            txtBusID.Size = new Size(137, 27);
            txtBusID.TabIndex = 29;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(293, 509);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 29);
            btnUpdate.TabIndex = 53;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(473, 509);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 29);
            btnCancel.TabIndex = 54;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(227, 463);
            label13.Name = "label13";
            label13.Size = new Size(104, 25);
            label13.TabIndex = 55;
            label13.Text = "Trạng thái:";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(381, 460);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(151, 28);
            cbStatus.TabIndex = 56;
            // 
            // UpdateBus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(cbStatus);
            Controls.Add(label13);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(cbPeriodic);
            Controls.Add(cbBustype);
            Controls.Add(txtNumePlate);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cbRoute);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtManufacturing);
            Controls.Add(dtRegistration);
            Controls.Add(txtEngine);
            Controls.Add(txtSeat);
            Controls.Add(txtBusID);
            Name = "UpdateBus";
            Text = "UpdateBus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbPeriodic;
        private ComboBox cbBustype;
        private TextBox txtNumePlate;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox cbRoute;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtManufacturing;
        private DateTimePicker dtRegistration;
        private TextBox txtEngine;
        private TextBox txtSeat;
        private TextBox txtBusID;
        private Button btnUpdate;
        private Button btnCancel;
        private Label label13;
        private ComboBox cbStatus;
    }
}