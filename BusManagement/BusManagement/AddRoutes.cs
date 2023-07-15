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
    public partial class AddRoutes : Form
    {
        BusRouteRepository routeRepo;
        TransportUnitRepository transportUnitRepo;
        Util u;
        public AddRoutes()
        {
            InitializeComponent();
            routeRepo = new BusRouteRepository();
            transportUnitRepo = new TransportUnitRepository();
            LoadCombobox();
            u = new Util();

        }
        private void LoadCombobox()
        {
            var list = transportUnitRepo.GetAll().Select(p => new { p.TransportUnitId, p.TransportUnitName }).ToList();
            cbb.DisplayMember = "TransportUnitName";
            cbb.ValueMember = "TransportUnitId";
            cbb.DataSource = list;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var route = TakeInputValid();

            if (route != null)
            {
                var route2 = routeRepo.GetAll().Where(p => p.RoutesId.Equals(route.RoutesId)).FirstOrDefault();
                if(route2 ==null)
                {
                    routeRepo.Create(route);
                    this.Close();
                    u.ShowNoiceBox("Tạo thành công!");
                }
                else
                {
                    u.ShowNoiceBox("Mã Tuyến đã tồn tại!");
                }
                
            }
        }

        private TblBusRoute TakeInputValid()
        {
            txtFrom.Text = txtFrom.Text.Trim();
            txtTo.Text = txtTo.Text.Trim();
            txtRoutesId.Text = txtRoutesId.Text.Trim();
            txtName.Text = txtName.Text.Trim();
            mTxtEndTime.Text = mTxtEndTime.Text.Trim();
            mTxtBreakTime.Text = mTxtBreakTime.Text.Trim();
            mTxtStartTime.Text = mTxtStartTime.Text.Trim();

            TblBusRoute routes = new TblBusRoute();
            if (txtName.Text.Length == 0 || txtRoutesId.Text.Length == 0 || txtFrom.Text.Length == 0 || txtTo.Text.Length == 0)
            {
                u.ShowNoiceBox("Vui lòng điền đầy đủ thông tin!");
                return null;
            }
            var sTime = u.GetTime(mTxtStartTime.Text);
            if (sTime == null)
            {
                return null;
            }
            routes.StartTime = sTime;

            var eTime = u.GetTime(mTxtEndTime.Text);
            if (eTime == null)
            {
                return null;
            }
            routes.EndTime = eTime;
            if (txtName.Text.Length > 50)
            {
                u.ShowNoiceBox("Tên Tuyến vui lòng Không quá 50 ký tự!");
                return null;
            }
            routes.RoutesName = txtName.Text;
            if (txtRoutesId.Text.Length > 10)
            {
                u.ShowNoiceBox("Mã Tuyến vui lòng không quá 10 ký tự");
                return null;
            }
            routes.RoutesId = txtRoutesId.Text;
            if (txtFrom.Text.Length > 100)
            {
                u.ShowNoiceBox("Lộ trình lượt đi vui lòng không quá 100 ký tự!");
                return null;
            }
            routes.StartPoint = txtFrom.Text;
            if (txtTo.Text.Length > 100)
            {
                u.ShowNoiceBox("Lộ trình lượt về vui lòng không quá 100 ký tự!");
                return null;
            }
            routes.EndPoint = txtTo.Text;
            routes.EstimatedTime = int.Parse(mTxtBreakTime.Text);
            routes.TransportUnitId = cbb.SelectedValue.ToString();
            routes.IsActive = true;
            return routes;
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetInputBox();
        }
        private void ResetInputBox()
        {
            txtFrom.Text = string.Empty;
            txtName.Text = string.Empty;
            txtRoutesId.Text = string.Empty;
            txtTo.Text = string.Empty;
            mTxtEndTime.Text = string.Empty;
            mTxtBreakTime.Text = string.Empty;
            mTxtStartTime.Text = string.Empty;
        }
    }
}
