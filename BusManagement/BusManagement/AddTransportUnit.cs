using Accessibility;
using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BusManagement
{
    public partial class AddTransportUnit : Form
    {
        TransportUnitRepository _transportUnitService = new TransportUnitRepository();

        public AddTransportUnit()
        {
            InitializeComponent();
        }

        private bool isIdExists(String id)
        {
            var listTransportUnitCount = _transportUnitService.GetAll();
            for (int i = 0; i < listTransportUnitCount.Count; i++)
            {
                if (listTransportUnitCount[i].TransportUnitId.Equals(id))
                {
                    return true; // Id đã tồn tại trong danh sách
                }
            }
            return false; // Id không tồn tại trong danh sách
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            var transportUnit = new TblTransportUnit();
            string ID = txtID.Text.Trim();
            string tenDonVi = txtTenDonVi.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string soDienThoai = txtDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            bool is_Active = true;

            if (string.IsNullOrEmpty(tenDonVi) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Các thông tin không được bỏ trống !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string idPattern = @"^TU[0-9]{5}$";
            if (!Regex.IsMatch(ID, idPattern))
            {
                MessageBox.Show("Mã đơn vị cần nhập theo format (TUXXXXX)!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (isIdExists(ID))
            {
                MessageBox.Show("Id đã tồn tại trong hệ thống!!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            transportUnit.TransportUnitId = ID;

            string emailPattern = "^[A-Za-z0-9]+[A-Za-z0-9]*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)$";
            //[A-Za-z0-9]*@ tùy chọn theo “[A-Za-z0-9]”, và kết thúc bằng một ký hiệu “@”
            //\\.[A-Za-z0-9] sau domain là phần mở rộng của domain sau dấu chấm(.com, .net,...)
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ !!! (ví dụ: abc@edf.com)", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (11 < txtDienThoai.Text.Length || txtDienThoai.Text.Length < 10)
            {
                MessageBox.Show("Vui lòng điền đủ số điện thoại !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            transportUnit.Email = email;

            transportUnit.TransportUnitName = tenDonVi;
            transportUnit.Address = diaChi;

            transportUnit.PhoneNumber = soDienThoai;
            transportUnit.IsActive = is_Active;
            _transportUnitService.Create(transportUnit);



            MessageBox.Show("Tạo thành công!!!", "Thông báo", MessageBoxButtons.OK);
            this.Close();


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTenDonVi.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
        }
    }
}
