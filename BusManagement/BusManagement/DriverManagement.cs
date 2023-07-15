using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusManagement
{

    public partial class DriverManagement : Form
    {
        DriverRepository _driverRepository;
        TblAccount account;
        public DriverManagement(TblAccount account)
        {
            this.account = account;
            InitializeComponent();
            formSettings();
            dgvDriver.ReadOnly = true;

            loadDgv();
            if (account.Role.Equals("Quản Lí"))
            {
                btnAccountManage.Enabled = true;
            }
            else
            {
                btnAccountManage.Enabled = false;
            }
            settingDataGridView();
        }

        private void loadDgv()
        {
            _driverRepository = new DriverRepository();

            var listDriver = _driverRepository.GetAll().Select(p => new
            {
                p.DriverId,
                p.DriverName,
                p.Address,
                p.Gender,
                p.Dob,
                p.Salary,
                p.StartDate,
                p.BusId,
                IsActive = (bool)p.IsActive ? "Hoat dong" : "Khong hoat dong"
            }).ToList();
            dgvDriver.DataSource = listDriver;

        }

        private void settingDataGridView()
        {
            dgvDriver.Columns[0].HeaderText = "Mã Tài Xế";
            dgvDriver.Columns[1].HeaderText = "Tên Tài Xế";
            dgvDriver.Columns[2].HeaderText = "Địa Chỉ";
            dgvDriver.Columns[3].HeaderText = "Giới Tính";
            dgvDriver.Columns[4].HeaderText = "Ngày Tháng Năm Sinh";
            dgvDriver.Columns[5].HeaderText = "Tiền Lương";
            dgvDriver.Columns[6].HeaderText = "Ngày Bắt Đầu Làm";
            dgvDriver.Columns[7].HeaderText = "Mã Xe";
            dgvDriver.Columns[8].HeaderText = "Tình Trạng Hoạt Động";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form = new AddDriver();
            form.ShowDialog();
            loadDgv();
        }

        private void dgvDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra hàng hợp lệ
            {
                dgvDriver.Rows[e.RowIndex].Selected = true; // Chọn toàn bộ hàng được click
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDriver.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDriver.SelectedRows[0];
                TblDriver selectedDriver = new TblDriver
                {
                    DriverId = selectedRow.Cells["DriverID"].Value.ToString(),
                    DriverName = selectedRow.Cells["DriverName"].Value.ToString(),
                    Address = selectedRow.Cells["Address"].Value.ToString(),
                    StartDate = DateTime.Parse(selectedRow.Cells["StartDate"].Value.ToString()),
                    Dob = DateTime.Parse(selectedRow.Cells["Dob"].Value.ToString()),
                    Salary = Decimal.Parse(selectedRow.Cells["Salary"].Value.ToString()),
                    Gender = selectedRow.Cells["Gender"].Value.ToString(),
                    BusId = selectedRow.Cells["BusId"].Value.ToString(),
                };
                //truyen du lieu
                Form updateDriver = new UpdateDriver(selectedDriver);
                updateDriver.ShowDialog();
                loadDgv();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            loadDgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDriver.SelectedRows.Count > 0)
            {
                int location = dgvDriver.CurrentCell.RowIndex;
                string driverId = dgvDriver.Rows[location].Cells["DriverID"].Value.ToString();
                TblDriver selectedDriver = _driverRepository.GetAll().FirstOrDefault(p => p.DriverId.Equals(driverId));

                DialogResult result = MessageBox.Show("Bạn muốn hủy hoạt động tài xế này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    selectedDriver.IsActive = false;
                    _driverRepository.Update(selectedDriver);
                    MessageBox.Show("Hủy thành công!!!", "Thông báo", MessageBoxButtons.OK);
                    loadDgv();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để hủy", "Thông báo", MessageBoxButtons.OK);
            }
            loadDgv();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = _driverRepository.GetAll()
                .Where(p => p.DriverName.Contains(txtSearch.Text)).Select(p => new
                {
                    p.DriverId,
                    p.DriverName,
                    p.Address,
                    p.Gender,
                    p.Dob,
                    p.Salary,
                    p.StartDate,
                    p.BusId,
                    IsActive = (bool)p.IsActive ? "Hoat dong" : "Khong hoat dong",
                }).ToList();
            dgvDriver.DataSource = new BindingSource() { DataSource = search };
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

            btnDriverManage.Enabled = false;
            btnDriverManage.BackColor = Color.LightYellow;

            btnAccountManage.Enabled = true;
            btnAccountManage.BackColor = Color.White;
        }

        private void btnRoutesManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new RoutesManagement(account);
            form.ShowDialog();
        }

        private void btnUnitManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new TransportUnitManagement(account);
            form.ShowDialog();
        }

        private void btnBusManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new BusManage(account);
            form.ShowDialog();
        }

        private void btnAccountManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new AccountManagement(account);
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Login();
            form.ShowDialog();
        }

        private void dgvDriver_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDriver.Rows[e.RowIndex];
                TblDriver selectedDriver = new TblDriver
                {
                    DriverId = row.Cells["DriverID"].Value.ToString(),
                    DriverName = row.Cells["DriverName"].Value.ToString(),
                    Address = row.Cells["Address"].Value.ToString(),
                    StartDate = DateTime.Parse(row.Cells["StartDate"].Value.ToString()),
                    Dob = DateTime.Parse(row.Cells["Dob"].Value.ToString()),
                    Salary = Decimal.Parse(row.Cells["Salary"].Value.ToString()),
                    Gender = row.Cells["Gender"].Value.ToString(),
                    BusId = row.Cells["BusId"].Value.ToString(),
                };
                //truyen du lieu
                Form updateDriver = new UpdateDriver(selectedDriver);
                updateDriver.ShowDialog();
            }
            loadDgv();
        }
    }


}
