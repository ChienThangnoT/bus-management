namespace BusManagement
{
    partial class AccountManagement
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
            dgv_Account = new DataGridView();
            btnRoutesManage = new Button();
            btnUnitManage = new Button();
            btnBusManage = new Button();
            btnDriverManage = new Button();
            btnAccountManage = new Button();
            btnLogout = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Account).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(644, 9);
            label1.Name = "label1";
            label1.Size = new Size(358, 38);
            label1.TabIndex = 2;
            label1.Text = "Phần Mềm Quản Lý Xe Bus";
            // 
            // dgv_Account
            // 
            dgv_Account.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Account.Location = new Point(269, 230);
            dgv_Account.Name = "dgv_Account";
            dgv_Account.RowHeadersWidth = 51;
            dgv_Account.RowTemplate.Height = 29;
            dgv_Account.Size = new Size(1076, 390);
            dgv_Account.TabIndex = 4;
            dgv_Account.CellClick += dgv_Account_CellClick;
            dgv_Account.CellDoubleClick += dgv_Account_CellDoubleClick;
            // 
            // btnRoutesManage
            // 
            btnRoutesManage.BackColor = SystemColors.ButtonHighlight;
            btnRoutesManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoutesManage.Location = new Point(37, 230);
            btnRoutesManage.Name = "btnRoutesManage";
            btnRoutesManage.Size = new Size(191, 60);
            btnRoutesManage.TabIndex = 5;
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
            btnUnitManage.TabIndex = 8;
            btnUnitManage.Text = "Quản Lý Đơn Vị";
            btnUnitManage.UseVisualStyleBackColor = false;
            btnUnitManage.Click += btnUnitManage_Click;
            // 
            // btnBusManage
            // 
            btnBusManage.BackColor = SystemColors.ButtonHighlight;
            btnBusManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBusManage.Location = new Point(37, 394);
            btnBusManage.Name = "btnBusManage";
            btnBusManage.Size = new Size(191, 60);
            btnBusManage.TabIndex = 9;
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
            btnDriverManage.TabIndex = 10;
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
            btnAccountManage.TabIndex = 11;
            btnAccountManage.Text = "Quản Lý Nhân Viên";
            btnAccountManage.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ButtonHighlight;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(37, 651);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(191, 60);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Location = new Point(489, 651);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 60);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Control;
            btnUpdate.Location = new Point(753, 651);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 60);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.Control;
            btnRemove.Location = new Point(1006, 651);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(137, 60);
            btnRemove.TabIndex = 15;
            btnRemove.Text = "Xóa";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(269, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 62);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm Thông Tin Nhân Viên";
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
            label2.Location = new Point(738, 68);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 25;
            label2.Text = "Quản Lý Nhân Viên ";
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 723);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnLogout);
            Controls.Add(btnAccountManage);
            Controls.Add(btnDriverManage);
            Controls.Add(btnBusManage);
            Controls.Add(btnUnitManage);
            Controls.Add(btnRoutesManage);
            Controls.Add(dgv_Account);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountManagement";
            Text = "AccountManagement";
            ((System.ComponentModel.ISupportInitialize)dgv_Account).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_Account;
        private Button btnRoutesManage;
        private Button btnUnitManage;
        private Button btnBusManage;
        private Button btnDriverManage;
        private Button btnAccountManage;
        private Button btnLogout;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private Label label2;
    }
}