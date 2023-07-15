using Services.Models;
using Services.Repository;
using System.Data;
using System.Windows.Forms;

namespace BusManagement
{
    public partial class AccountManagement : Form
    {
        AccountRepository accountRepository;
        TblAccount account;
        TblAccount acc;
        public AccountManagement(TblAccount acc)
        {
            this.acc = acc;
            InitializeComponent();
            formSettings();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnAccountManage.Enabled = false;
            accountRepository = new AccountRepository();
            loadData();
            dgv_Account.Columns[0].HeaderText = "Mã Nhân Viên";
            dgv_Account.Columns[1].HeaderText = "Tài Khoản";
            //dgv_Account.Columns[2].HeaderText = "Mật Khẩu";
            dgv_Account.Columns[2].HeaderText = "Họ và Tên";
            dgv_Account.Columns[3].HeaderText = "Ngày Tháng Năm Sinh";
            dgv_Account.Columns[4].HeaderText = "Email";
            dgv_Account.Columns[5].HeaderText = "Số Điện Thoại";
            dgv_Account.Columns[6].HeaderText = "Chức Vụ";
            dgv_Account.Columns[7].HeaderText = "Trạng Thái Hoạt Động";
            if (acc.Role.ToString().Equals("Quản Lí"))
            {
                btnAccountManage.Enabled = true;
            }
            else
            {
                btnAccountManage.Enabled = false;
            }

        }

        private void loadData()
        {
            btnRemove.Enabled = false;
            btnUpdate.Enabled = false;

            var listAccount = new AccountRepository().GetAll().Select(p => new
            {
                p.AccountId,
                p.Username,
                //p.Password,
                p.FullName,
                p.Dob,
                p.Email,
                p.PhoneNumber,
                p.Role,
                IsActive = (bool)p.IsActive ? "Hoat dong" : "Khong hoat dong"
            });
            dgv_Account.DataSource = new BindingSource() { DataSource = listAccount };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form = new AddAccount();
            form.ShowDialog();
            loadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn hủy hoạt động tài khoản ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                account.IsActive = false;
                accountRepository.Update(account);
                MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK);
                
            }
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form form = new UpdateAccount(account);
            form.ShowDialog();
            loadData();
        }


        private void dgv_Account_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form = new UpdateAccount(account);
            form.ShowDialog();
            loadData();

        }

        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemove.Enabled = true;
            btnUpdate.Enabled = true;
            if (e.RowIndex >= 0) // Kiểm tra hàng hợp lệ
            {
                dgv_Account.Rows[e.RowIndex].Selected = true; // Chọn toàn bộ hàng được click
            }
            account = new AccountRepository().GetAll().Where(p => p.AccountId.Equals(dgv_Account.Rows[e.RowIndex].Cells[0].Value)).FirstOrDefault();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = new AccountRepository().GetAll().Where(p => p.FullName.Contains(txtSearch.Text)).
            Select(p => new
            {
                p.AccountId,
                p.Username,
                //p.Password,
                p.FullName,
                p.Dob,
                p.Email,
                p.PhoneNumber,
                p.Role,
                IsActive = (bool)p.IsActive ? "Hoat dong" : "Khong hoat dong",
            });
            dgv_Account.DataSource = new BindingSource() { DataSource = search };
        }
        private void formSettings()
        {

            this.StartPosition = FormStartPosition.CenterScreen;

            btnRoutesManage.Enabled = true;
            btnRoutesManage.BackColor = Color.White;

            btnUnitManage.Enabled = true;
            btnUnitManage.BackColor = Color.White;

            btnBusManage.Enabled = true;
            btnBusManage.BackColor = Color.White;

            btnDriverManage.Enabled = true;
            btnDriverManage.BackColor = Color.White;

            btnAccountManage.Enabled = false;
            btnAccountManage.BackColor = Color.LightYellow;
        }

        private void btnRoutesManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new RoutesManagement(acc);
            form.ShowDialog();
        }

        private void btnUnitManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new TransportUnitManagement(acc);
            form.ShowDialog();
        }

        private void btnBusManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new BusManage(acc);
            form.ShowDialog();
        }

        private void btnDriverManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new DriverManagement(acc);
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Login();
            form.ShowDialog();
        }

        
    }
}

