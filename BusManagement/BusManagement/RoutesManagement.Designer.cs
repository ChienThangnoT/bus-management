namespace BusManagement
{
    partial class RoutesManagement
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
            btnRoutesManage = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            dgv = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnUnitManage = new Button();
            btnBusManage = new Button();
            btnDriverManage = new Button();
            btnAccountManage = new Button();
            btnLogout = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnRoutesManage
            // 
            btnRoutesManage.BackColor = SystemColors.ButtonHighlight;
            btnRoutesManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoutesManage.Location = new Point(37, 230);
            btnRoutesManage.Name = "btnRoutesManage";
            btnRoutesManage.Size = new Size(191, 60);
            btnRoutesManage.TabIndex = 0;
            btnRoutesManage.Text = "Quản Lý Tuyến Xe";
            btnRoutesManage.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(644, 9);
            label1.Name = "label1";
            label1.Size = new Size(358, 38);
            label1.TabIndex = 1;
            label1.Text = "Phần Mềm Quản Lý Xe Bus";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(269, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 62);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm Thông Tin Tuyến Xe";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(322, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(269, 230);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(1076, 390);
            dgv.TabIndex = 3;
            dgv.CellClick += dgv_CellClick;
            dgv.CellContentDoubleClick += dgv_CellContentDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Location = new Point(489, 651);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 60);
            btnAdd.TabIndex = 4;
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
            btnUpdate.TabIndex = 5;
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
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Xóa";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUnitManage
            // 
            btnUnitManage.BackColor = SystemColors.ButtonHighlight;
            btnUnitManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnitManage.Location = new Point(37, 313);
            btnUnitManage.Name = "btnUnitManage";
            btnUnitManage.Size = new Size(191, 60);
            btnUnitManage.TabIndex = 7;
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
            btnBusManage.TabIndex = 8;
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
            btnDriverManage.TabIndex = 9;
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
            btnAccountManage.TabIndex = 10;
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
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(731, 68);
            label2.Name = "label2";
            label2.Size = new Size(175, 28);
            label2.TabIndex = 25;
            label2.Text = "Quản Lý Tuyến Xe";
            // 
            // RoutesManagement
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
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgv);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnRoutesManage);
            Name = "RoutesManagement";
            Text = "RoutesManagement";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRoutesManage;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private DataGridView dgv;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnUnitManage;
        private Button btnBusManage;
        private Button btnDriverManage;
        private Button btnAccountManage;
        private Button btnLogout;
        private Label label2;
    }
}