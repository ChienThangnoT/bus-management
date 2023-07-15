namespace BusManagement
{
    partial class TransportUnitManagement
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
            dgvListTransportUnit = new DataGridView();
            btnRoutesManage = new Button();
            btnUnitManage = new Button();
            btnBusManage = new Button();
            btnDriverManage = new Button();
            btnAccountManage = new Button();
            btnLogout = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListTransportUnit).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListTransportUnit
            // 
            dgvListTransportUnit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListTransportUnit.Location = new Point(269, 230);
            dgvListTransportUnit.Name = "dgvListTransportUnit";
            dgvListTransportUnit.RowHeadersWidth = 51;
            dgvListTransportUnit.RowTemplate.Height = 29;
            dgvListTransportUnit.Size = new Size(1076, 390);
            dgvListTransportUnit.TabIndex = 0;
            dgvListTransportUnit.CellClick += dgvListTransportUnit_CellClick;
            dgvListTransportUnit.CellDoubleClick += dgvListTransportUnit_CellDoubleClick;
            // 
            // btnRoutesManage
            // 
            btnRoutesManage.BackColor = SystemColors.ButtonHighlight;
            btnRoutesManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoutesManage.Location = new Point(37, 230);
            btnRoutesManage.Name = "btnRoutesManage";
            btnRoutesManage.Size = new Size(191, 60);
            btnRoutesManage.TabIndex = 1;
            btnRoutesManage.Text = "Quản Lý Tuyến Xe";
            btnRoutesManage.UseVisualStyleBackColor = false;
            btnRoutesManage.Click += btnRoutesManage_Click;
            // 
            // btnUnitManage
            // 
            btnUnitManage.BackColor = SystemColors.ButtonHighlight;
            btnUnitManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnitManage.Location = new Point(37, 313);
            btnUnitManage.Name = "btnUnitManage";
            btnUnitManage.Size = new Size(191, 60);
            btnUnitManage.TabIndex = 2;
            btnUnitManage.Text = "Quản Lý Đơn Vị";
            btnUnitManage.UseVisualStyleBackColor = false;
            // 
            // btnBusManage
            // 
            btnBusManage.BackColor = SystemColors.ButtonHighlight;
            btnBusManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBusManage.Location = new Point(37, 394);
            btnBusManage.Name = "btnBusManage";
            btnBusManage.Size = new Size(191, 60);
            btnBusManage.TabIndex = 3;
            btnBusManage.Text = "Quản Lý Xe";
            btnBusManage.UseVisualStyleBackColor = false;
            btnBusManage.Click += btnBusManage_Click;
            // 
            // btnDriverManage
            // 
            btnDriverManage.BackColor = SystemColors.ButtonHighlight;
            btnDriverManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDriverManage.Location = new Point(37, 476);
            btnDriverManage.Name = "btnDriverManage";
            btnDriverManage.Size = new Size(191, 60);
            btnDriverManage.TabIndex = 4;
            btnDriverManage.Text = "Quản Lý Tài Xế";
            btnDriverManage.UseVisualStyleBackColor = false;
            btnDriverManage.Click += btnDriverManage_Click;
            // 
            // btnAccountManage
            // 
            btnAccountManage.BackColor = SystemColors.ButtonHighlight;
            btnAccountManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccountManage.Location = new Point(37, 560);
            btnAccountManage.Name = "btnAccountManage";
            btnAccountManage.Size = new Size(191, 60);
            btnAccountManage.TabIndex = 5;
            btnAccountManage.Text = "Quản Lý Nhân Viên";
            btnAccountManage.UseVisualStyleBackColor = false;
            btnAccountManage.Click += btnAccountManage_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ButtonHighlight;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(37, 651);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(191, 60);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(489, 651);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(137, 60);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(753, 651);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(137, 60);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1006, 651);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(137, 60);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(644, 9);
            label1.Name = "label1";
            label1.Size = new Size(358, 38);
            label1.TabIndex = 10;
            label1.Text = "Phần Mềm Quản Lý Xe Bus";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(269, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 62);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm Thông Tin Đơn Vị Vận Chuyển";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(322, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(744, 68);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 25;
            label2.Text = "Quản Lý Đơn Vị";
            // 
            // TransportUnitManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 723);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnLogout);
            Controls.Add(btnAccountManage);
            Controls.Add(btnDriverManage);
            Controls.Add(btnBusManage);
            Controls.Add(btnUnitManage);
            Controls.Add(btnRoutesManage);
            Controls.Add(dgvListTransportUnit);
            Name = "TransportUnitManagement";
            Text = "TransportUnitManagement";
            ((System.ComponentModel.ISupportInitialize)dgvListTransportUnit).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListTransportUnit;
        private Button btnRoutesManage;
        private Button btnUnitManage;
        private Button btnBusManage;
        private Button btnDriverManage;
        private Button btnAccountManage;
        private Button btnLogout;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private Label label2;
    }
}