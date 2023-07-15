using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusManagement
{
    public partial class AddDriver : Form
    {
        BusServices _busService = new BusServices();
        DriverRepository _driverrepository = new DriverRepository();
        public AddDriver()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            load_cbDriverGender();
            load_cbBusID();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var driver = getValidInput();

            if (driver != null)
            {
                new DriverRepository().Create(driver);
                MessageBox.Show("Thêm tài xế thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_cbDriverGender()
        {
            cbDriverGender.Items.AddRange(new String[] { "Nam", "Nu", "Khac" });
            cbDriverGender.SelectedIndex = 0;
        }

        private void load_cbBusID()
        {
            var listCombo = _busService.GetAll().Select(p => new { p.BusId, p.NumberPlate }).ToList();
            cbBusID.DisplayMember = "NumberPlate";
            cbBusID.ValueMember = "BusId";
            cbBusID.DataSource = listCombo;
        }

        private void reset()
        {
            txtDriverID.Text = "";
            txtDriverName.Text = "";
            txtDriverAddress.Text = "";
            txtDriverSalary.Text = "";
            dtpDriverDoB.Value = DateTime.Now;
            dtpDriverStartDate.Value = DateTime.Now;
            cbDriverGender.SelectedIndex = 0;
            load_cbBusID();
        }

        private TblDriver getValidInput()
        {
            // New driver
            TblDriver driver = new TblDriver();

            // Check if textbox is null or empty?
            if (String.IsNullOrEmpty(txtDriverID.Text.Trim())
                || String.IsNullOrEmpty(txtDriverName.Text.Trim())
                || String.IsNullOrEmpty(txtDriverAddress.Text.Trim())
                || String.IsNullOrEmpty(txtDriverSalary.Text.Trim())
                )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Check if "ID" match regex or not?
            String idPattern = @"^[d,D]{1}[0-9]{4}$";
            if (!Regex.IsMatch(txtDriverID.Text.Trim(), idPattern))
            {
                MessageBox.Show("Vui lòng điền ID theo cú pháp sau: D****. " +
                    "Trong đó * là số. Ví Dụ: D1234 ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Check if "ID" is existed or not?
            var existedDriverID = _driverrepository.GetAll()
                .Where(p => p.DriverId.Equals(txtDriverID.Text.Trim().ToUpper())).FirstOrDefault();
            if (existedDriverID != null)
            {
                MessageBox.Show("ID đã tồn tại!!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Add "ID" to new Driver
            driver.DriverId = txtDriverID.Text.Trim().ToUpper();

            //Check if "Name" contains special characters or numbers or not?
            if (!txtDriverName.Text.Trim().All(c => Char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Tên không chứa ký tự đặc biệt và số!!!", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Add "Name" to new Driver
            driver.DriverName = txtDriverName.Text.Trim();

            //Check if "Address" contains special characters or not?
            if (!txtDriverAddress.Text.Trim().All(c => Char.IsLetterOrDigit(c) || c == ' '))
            {
                MessageBox.Show("Địa chỉ không chứa ký tự đặc biệt!!!", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Add "Address" to new Driver
            driver.Address = txtDriverAddress.Text.Trim();

            //Check if "StartDate" right or not?
            if (dtpDriverStartDate.Value <= DateTime.Today)
            {
                MessageBox.Show("Ngày bắt đầu phải lớn hơn hoặc bằng ngày hôm nay!!!", "Thông báo",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Add "StartDate" to new Driver
            driver.StartDate = dtpDriverStartDate.Value;

            //Check if "DoB" right or not?
            if (dtpDriverDoB.Value >= DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không thể nào lớn hơn ngày hôm nay!!!", "Thông báo",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Add "DoB" to new Driver
            driver.Dob = dtpDriverDoB.Value;

            //Check if "Salary" contains special characters or alphabet or not?
            if (!txtDriverSalary.Text.Trim().All(c => Char.IsDigit(c)))
            {
                MessageBox.Show("Lương không chứa ký tự đặc biệt và chữ cái!!!", "Thông báo",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Add "Salary" to new Driver
            driver.Salary = Decimal.Parse(txtDriverSalary.Text.Trim());

            //Add "Gender" to new Driver
            driver.Gender = cbDriverGender.SelectedItem.ToString();

            //Add "BusID" to new Driver
            driver.BusId = cbBusID.SelectedValue.ToString();

            //Add "isActive" to new Driver
            driver.IsActive = true;

            return driver;
        }

    }
}
