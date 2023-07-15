namespace BusManagement
{
    partial class DriverManagement
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
            btnLogout = new Button();
            btnAccountManage = new Button();
            btnDriverManage = new Button();
            btnBusManage = new Button();
            btnUnitManage = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvDriver = new DataGridView();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            label1 = new Label();
            btnRoutesManage = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDriver).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ButtonHighlight;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(37, 651);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(191, 60);
            btnLogout.TabIndex = 23;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAccountManage
            // 
            btnAccountManage.BackColor = SystemColors.ButtonHighlight;
            btnAccountManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccountManage.Location = new Point(37, 560);
            btnAccountManage.Name = "btnAccountManage";
            btnAccountManage.Size = new Size(191, 60);
            btnAccountManage.TabIndex = 22;
            btnAccountManage.Text = "Quản Lý Nhân Viên";
            btnAccountManage.UseVisualStyleBackColor = false;
            btnAccountManage.Click += btnAccountManage_Click;
            // 
            // btnDriverManage
            // 
            btnDriverManage.BackColor = SystemColors.ButtonHighlight;
            btnDriverManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDriverManage.Location = new Point(37, 476);
            btnDriverManage.Name = "btnDriverManage";
            btnDriverManage.Size = new Size(191, 60);
            btnDriverManage.TabIndex = 21;
            btnDriverManage.Text = "Quản Lý Tài Xế";
            btnDriverManage.UseVisualStyleBackColor = false;
            // 
            // btnBusManage
            // 
            btnBusManage.BackColor = SystemColors.ButtonHighlight;
            btnBusManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBusManage.Location = new Point(37, 394);
            btnBusManage.Name = "btnBusManage";
            btnBusManage.Size = new Size(191, 60);
            btnBusManage.TabIndex = 20;
            btnBusManage.Text = "Quản Lý Xe";
            btnBusManage.UseVisualStyleBackColor = false;
            btnBusManage.Click += btnBusManage_Click;
            // 
            // btnUnitManage
            // 
            btnUnitManage.BackColor = SystemColors.ButtonHighlight;
            btnUnitManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnitManage.Location = new Point(37, 313);
            btnUnitManage.Name = "btnUnitManage";
            btnUnitManage.Size = new Size(191, 60);
            btnUnitManage.TabIndex = 19;
            btnUnitManage.Text = "Quản Lý Đơn Vị";
            btnUnitManage.UseVisualStyleBackColor = false;
            btnUnitManage.Click += btnUnitManage_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Control;
            btnDelete.Location = new Point(1006, 651);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 60);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Control;
            btnUpdate.Location = new Point(753, 651);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 60);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Location = new Point(489, 651);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 60);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvDriver
            // 
            dgvDriver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDriver.Location = new Point(269, 230);
            dgvDriver.Name = "dgvDriver";
            dgvDriver.RowHeadersWidth = 51;
            dgvDriver.RowTemplate.Height = 29;
            dgvDriver.Size = new Size(1076, 390);
            dgvDriver.TabIndex = 15;
            dgvDriver.CellClick += dgvDriver_CellClick;
            dgvDriver.CellDoubleClick += dgvDriver_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(269, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 62);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm Thông Tin Tài Xế";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(322, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(644, 9);
            label1.Name = "label1";
            label1.Size = new Size(358, 38);
            label1.TabIndex = 13;
            label1.Text = "Phần Mềm Quản Lý Xe Bus";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRoutesManage
            // 
            btnRoutesManage.BackColor = SystemColors.ButtonHighlight;
            btnRoutesManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoutesManage.Location = new Point(37, 230);
            btnRoutesManage.Name = "btnRoutesManage";
            btnRoutesManage.Size = new Size(191, 60);
            btnRoutesManage.TabIndex = 12;
            btnRoutesManage.Text = "Quản Lý Tuyến Xe";
            btnRoutesManage.UseVisualStyleBackColor = false;
            btnRoutesManage.Click += btnRoutesManage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(744, 68);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 24;
            label2.Text = "Quản Lý Tài Xế";
            // 
            // DriverManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 723);
            Controls.Add(label2);
            Controls.Add(btnLogout);
            Controls.Add(btnAccountManage);
            Controls.Add(btnDriverManage);
            Controls.Add(btnBusManage);
            Controls.Add(btnUnitManage);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvDriver);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnRoutesManage);
            Name = "DriverManagement";
            Text = "DriverManagement";
            ((System.ComponentModel.ISupportInitialize)dgvDriver).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Button btnAccountManage;
        private Button btnDriverManage;
        private Button btnBusManage;
        private Button btnUnitManage;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvDriver;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private Label label1;
        private Button btnRoutesManage;
        private Label label2;
    }
}