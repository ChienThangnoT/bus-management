namespace BusManagement
{
    partial class AddBus
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
            txtBusID = new TextBox();
            txtSeat = new TextBox();
            txtEngine = new TextBox();
            dtRegistration = new DateTimePicker();
            dtManufacturing = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtAdbus = new Button();
            txtRefresh = new Button();
            txtHuyButton = new Button();
            cbRoute = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtNumePlate = new TextBox();
            cbBustype1 = new ComboBox();
            cbPeriodic = new ComboBox();
            SuspendLayout();
            // 
            // txtBusID
            // 
            txtBusID.Location = new Point(367, 46);
            txtBusID.Name = "txtBusID";
            txtBusID.Size = new Size(137, 27);
            txtBusID.TabIndex = 0;
            // 
            // txtSeat
            // 
            txtSeat.Location = new Point(367, 237);
            txtSeat.Name = "txtSeat";
            txtSeat.Size = new Size(137, 27);
            txtSeat.TabIndex = 3;
            // 
            // txtEngine
            // 
            txtEngine.Location = new Point(367, 289);
            txtEngine.Name = "txtEngine";
            txtEngine.Size = new Size(137, 27);
            txtEngine.TabIndex = 4;
            // 
            // dtRegistration
            // 
            dtRegistration.Location = new Point(367, 388);
            dtRegistration.Name = "dtRegistration";
            dtRegistration.Size = new Size(250, 27);
            dtRegistration.TabIndex = 7;
            // 
            // dtManufacturing
            // 
            dtManufacturing.Location = new Point(367, 339);
            dtManufacturing.Name = "dtManufacturing";
            dtManufacturing.Size = new Size(250, 27);
            dtManufacturing.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(249, 48);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 9;
            label1.Text = "Mã xe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(188, 141);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 10;
            label2.Text = "Tuyến đường:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(241, 190);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 11;
            label3.Text = "Loại xe:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(243, 239);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 12;
            label4.Text = "Số ghế:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(216, 291);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 13;
            label5.Text = "Công suất:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(172, 390);
            label6.Name = "label6";
            label6.Size = new Size(146, 25);
            label6.TabIndex = 14;
            label6.Text = "Hạn đăng kiểm:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(181, 341);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 15;
            label7.Text = "Ngày sản suất:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(139, 437);
            label8.Name = "label8";
            label8.Size = new Size(179, 25);
            label8.TabIndex = 16;
            label8.Text = "Bảo dưỡng định kỳ:";
            // 
            // txtAdbus
            // 
            txtAdbus.BackColor = SystemColors.Control;
            txtAdbus.Location = new Point(198, 491);
            txtAdbus.Name = "txtAdbus";
            txtAdbus.Size = new Size(94, 29);
            txtAdbus.TabIndex = 17;
            txtAdbus.Text = "Thêm";
            txtAdbus.UseVisualStyleBackColor = true;
            txtAdbus.Click += txtAdbus_Click;
            // 
            // txtRefresh
            // 
            txtRefresh.Location = new Point(368, 491);
            txtRefresh.Name = "txtRefresh";
            txtRefresh.Size = new Size(94, 29);
            txtRefresh.TabIndex = 18;
            txtRefresh.Text = "Làm mới";
            txtRefresh.UseVisualStyleBackColor = true;
            txtRefresh.Click += txtRefresh_Click;
            // 
            // txtHuyButton
            // 
            txtHuyButton.Location = new Point(542, 491);
            txtHuyButton.Name = "txtHuyButton";
            txtHuyButton.Size = new Size(94, 29);
            txtHuyButton.TabIndex = 19;
            txtHuyButton.Text = "Hủy";
            txtHuyButton.UseVisualStyleBackColor = true;
            txtHuyButton.Click += txtHuyButton_Click;
            // 
            // cbRoute
            // 
            cbRoute.FormattingEnabled = true;
            cbRoute.Location = new Point(367, 138);
            cbRoute.Name = "cbRoute";
            cbRoute.Size = new Size(151, 28);
            cbRoute.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(542, 296);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 21;
            label9.Text = "W";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(526, 442);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 22;
            label10.Text = "Tháng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(542, 244);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 23;
            label11.Text = "Ghế";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(214, 93);
            label12.Name = "label12";
            label12.Size = new Size(104, 25);
            label12.TabIndex = 24;
            label12.Text = "Biển số xe:";
            // 
            // txtNumePlate
            // 
            txtNumePlate.Location = new Point(367, 91);
            txtNumePlate.Name = "txtNumePlate";
            txtNumePlate.Size = new Size(137, 27);
            txtNumePlate.TabIndex = 25;
            // 
            // cbBustype1
            // 
            cbBustype1.FormattingEnabled = true;
            cbBustype1.Location = new Point(368, 187);
            cbBustype1.Name = "cbBustype1";
            cbBustype1.Size = new Size(151, 28);
            cbBustype1.TabIndex = 27;
            // 
            // cbPeriodic
            // 
            cbPeriodic.FormattingEnabled = true;
            cbPeriodic.Location = new Point(367, 434);
            cbPeriodic.Name = "cbPeriodic";
            cbPeriodic.Size = new Size(151, 28);
            cbPeriodic.TabIndex = 28;
            // 
            // AddBus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(cbPeriodic);
            Controls.Add(cbBustype1);
            Controls.Add(txtNumePlate);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cbRoute);
            Controls.Add(txtHuyButton);
            Controls.Add(txtRefresh);
            Controls.Add(txtAdbus);
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
            Name = "AddBus";
            Text = "AddBus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusID;
        private TextBox txtSeat;
        private TextBox txtEngine;
        private DateTimePicker dtRegistration;
        private DateTimePicker dtManufacturing;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button txtAdbus;
        private Button txtRefresh;
        private Button txtHuyButton;
        private ComboBox cbRoute;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtNumePlate;
        private TextBox textBox1;
        private ComboBox cbBustype1;
        private ComboBox cbPeriodic;
    }
}