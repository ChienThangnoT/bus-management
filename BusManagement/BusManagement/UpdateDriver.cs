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

namespace BusManagement
{
    public partial class UpdateDriver : Form
    {
        TblDriver driverData;
        BusServices _busrepository = new BusServices();
        DriverRepository _driverrepository = new DriverRepository();

        public UpdateDriver(TblDriver driver)
        {
            driverData = driver;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            //Load ComboBox Data
            load_cbBusID();
            load_cbDriverGender();
            loadIsActive();

            //Load Driver Data For Update
            var isActive = _driverrepository.GetDriverStatus(driverData.DriverId);// get status form db
            if (isActive)
            {
                cbIsActive.SelectedIndex = 0; //Hoat dong
            }
            else
            {
                cbIsActive.SelectedIndex = 1; // Khong hoat dong
            }
            txtDriverID.Text = driverData.DriverId;
            txtDriverID.ReadOnly = true;
            txtDriverName.Text = driverData.DriverName;
            txtDriverAddress.Text = driverData.Address;
            dtpDriverStartDate.Value = driverData.StartDate.Value;
            dtpDriverStartDate.Enabled = false;
            dtpDriverDoB.Value = driverData.Dob.Value;
            txtDriverSalary.Text = String.Format("{0:0.##}", Decimal.Parse(driverData.Salary.ToString()));
            cbDriverGender.SelectedItem = driverData.Gender.ToString();
            cbBusID.SelectedValue = driverData.BusId.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var driver = getValidInput();
            var _driverUpdate = _driverrepository.GetAll().Where(p => p.DriverId == driver.DriverId).FirstOrDefault();
            
            if (_driverUpdate != null)
            {
                _driverUpdate.DriverName = driver.DriverName;
                _driverUpdate.Address = driver.Address;
                _driverUpdate.Gender = driver.Gender;
                _driverUpdate.StartDate = driver.StartDate;
                _driverUpdate.Dob = driver.Dob;
                _driverUpdate.Salary = driver.Salary;
                _driverUpdate.IsActive = driver.IsActive;
                _driverUpdate.BusId = driver.BusId;

                _driverrepository.Update(_driverUpdate);

                MessageBox.Show("Sửa thông tin tài xế thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void load_cbDriverGender()
        {
            cbDriverGender.Items.AddRange(new String[] { "Nam", "Nu", "Khac" });
            cbDriverGender.SelectedIndex = 0;
        }

        private void load_cbBusID()
        {
            var listCombo = _busrepository.GetAll().Select(p => new { p.BusId, p.NumberPlate }).ToList();
            cbBusID.DisplayMember = "NumberPlate";
            cbBusID.ValueMember = "BusId";
            cbBusID.DataSource = listCombo;
        }

        private void loadIsActive()
        {
            //var item = new[]
            //{
            //    new { Text = "Hoạt Động", Value = "True" },
            //    new { Text = "Không Hoạt Động", Value = "False" },
            //};
            //cbIsActive.DisplayMember = "Text";
            //cbIsActive.ValueMember = "Value";
            //cbIsActive.DataSource = item;
            cbIsActive.Items.AddRange(new string[] { "Hoat dong", "Khong hoat dong" });
            cbIsActive.SelectedIndex = 0;

        }

        private TblDriver getValidInput()
        {
            // New driver
            //var _busUpdate = _services.GetAll().Where(p => p.BusId == txtBusID.Text).FirstOrDefault();
            TblDriver driver = new TblDriver();

            // Add "ID"
            driver.DriverId = txtDriverID.Text;

            // Add "StartDate"
            driver.StartDate = dtpDriverStartDate.Value;

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
            if (cbIsActive.SelectedItem.ToString() == "Hoat dong")
            {
                driver.IsActive = true;
            }
            else
            {
                driver.IsActive &= false;
            }

            return driver;
        }
    }
}
