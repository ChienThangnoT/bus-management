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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BusManagement
{
    public partial class UpdateTransportUnit : Form
    {
        TblTransportUnit transportUnitPara;
        TransportUnitRepository _transportUnitRepository;
        public UpdateTransportUnit(TblTransportUnit transportUnit)
        {
            transportUnitPara = transportUnit;
            InitializeComponent();
            _transportUnitRepository = new TransportUnitRepository();
            loadData();
            loadIsActive();
            var isActive = _transportUnitRepository.GetUnitStatus(transportUnitPara.TransportUnitId);// get status form db
            if (isActive)
            {
                cbStatus.SelectedIndex = 0; //Hoat dong
            }
            else
            {
                cbStatus.SelectedIndex = 1; // Khong hoat dong
            }
        }

        private void loadData()
        {
            var listTransportUnit = _transportUnitRepository.GetAll();
            txtID.Text = transportUnitPara.TransportUnitId;
            txtID.Enabled = false;
            txtTenDonVi.Text = transportUnitPara.TransportUnitName;
            txtDiaChi.Text = transportUnitPara.Address;
            txtSoDienThoai.Text = transportUnitPara.PhoneNumber;
            txtEmail.Text = transportUnitPara.Email;
        }

        private void loadIsActive()
        {
            cbStatus.Items.AddRange(new string[] { "Hoat dong", "Khong hoat dong" });
            cbStatus.SelectedIndex = 0;

        }
        //private bool isIdExists(String id)
        //{
        //    var listTransportUnitCount = _transportUnitRepository.GetAll();
        //    for (int i = 0; i < listTransportUnitCount.Count; i++)
        //    {
        //        if (listTransportUnitCount[i].TransportUnitId.Equals(id))
        //        {
        //            return true; // Id đã tồn tại trong danh sách
        //        }
        //    }
        //    return false; // Id không tồn tại trong danh sách
        //}

        private TblTransportUnit takeInput()
        {
            TblTransportUnit transportUnit = new TblTransportUnit();
            txtID.Text = txtID.Text.Trim();
            txtTenDonVi.Text = txtTenDonVi.Text.Trim();
            txtDiaChi.Text = txtDiaChi.Text.Trim();
            txtSoDienThoai.Text = txtSoDienThoai.Text.Trim();
            txtEmail.Text = txtEmail.Text.Trim();
            if (txtID.Text.Length == 0 || txtTenDonVi.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtSoDienThoai.Text.Length == 0 || txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK);
                return null;
            }
            else
            {
                if (11 < txtSoDienThoai.Text.Length || txtSoDienThoai.Text.Length < 10)
                {
                    MessageBox.Show("Vui lòng điền đủ số điện thoại !!!", "Thông báo", MessageBoxButtons.OK);
                    return null;
                }
                else
                {
                    transportUnit.TransportUnitId = txtID.Text;
                    string emailPattern = "^[A-Za-z0-9]+[A-Za-z0-9]*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)$";
                    if (!Regex.IsMatch(txtEmail.Text, emailPattern))
                    {
                        MessageBox.Show("Email không hợp lệ !!! (ví dụ: abc@edf.com)", "Thông báo", MessageBoxButtons.OK);
                        return null;
                    }
                    else
                    {
                        if (cbStatus.SelectedItem.ToString() == "Hoat dong")
                        {
                            transportUnit.IsActive = true;
                        }
                        else
                        {
                            transportUnit.IsActive &= false;
                        }
                    }
                }
            }



            //string idPattern = @"^TU[0-9]{5}$";
            //if (!Regex.IsMatch(txtID.Text, idPattern))
            //{
            //    MessageBox.Show("Please input a valid ID format (TUXXXXX)!", "Warning", MessageBoxButtons.OK);
            //    return null;
            //}

            //if (isIdExists(txtID.Text))
            //{
            //    MessageBox.Show("The ID already exists!", "Warning", MessageBoxButtons.OK);
            //    return null;
            //}


            //[A-Za-z0-9]*@ tùy chọn theo “[A-Za-z0-9]”, và kết thúc bằng một ký hiệu “@”
            //\\.[A-Za-z0-9] Sau domain là phần mở rộng của domain sau dấu chấm, ví dụ: (.com, .net, .org)





            transportUnit.Email = txtEmail.Text;
            transportUnit.TransportUnitName = txtTenDonVi.Text;
            transportUnit.Address = txtDiaChi.Text;
            transportUnit.PhoneNumber = txtSoDienThoai.Text;
            return transportUnit;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var transportUnitInput = takeInput();

            if (transportUnitInput != null)
            {
                var transportUnitDB = _transportUnitRepository.GetAll().Where(p => p.TransportUnitId.Equals(transportUnitPara.TransportUnitId)).FirstOrDefault();
                if (transportUnitDB != null)
                {
                    transportUnitDB.TransportUnitName = transportUnitInput.TransportUnitName;
                    transportUnitDB.Address = transportUnitInput.Address;
                    transportUnitDB.PhoneNumber = transportUnitInput.PhoneNumber;
                    transportUnitDB.Email = transportUnitInput.Email;
                    transportUnitDB.IsActive = transportUnitInput.IsActive;
                    _transportUnitRepository.Update(transportUnitDB);
                }
                MessageBox.Show("Cập nhật thành công!!!", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }

        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
