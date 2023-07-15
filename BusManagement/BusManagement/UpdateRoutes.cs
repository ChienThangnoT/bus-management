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
    public partial class UpdateRoutes : Form
    {
        TblBusRoute routePara;
        TransportUnitRepository transportUnitRepo;
        BusRouteRepository routeRepo;
        Util u;
        public UpdateRoutes(TblBusRoute route)
        {
            routePara = route;
            InitializeComponent();
            transportUnitRepo = new TransportUnitRepository();
            routeRepo = new BusRouteRepository();
            LoadData();
            u = new Util();
            var isActive = routeRepo.GetBusRouteStatus(routePara.RoutesId);// get status form db
            if (isActive)
            {
                cbStatus.SelectedIndex = 0; //Hoat dong
            }
            else
            {
                cbStatus.SelectedIndex = 1; // Khong hoat dong
            }
        }
        private void LoadData()
        {
            LoadCombobox();
            txtFrom.Text = routePara.StartPoint;
            txtTo.Text = routePara.EndPoint;
            txtName.Text = routePara.RoutesName;
            txtRoutesId.Text = routePara.RoutesId;
            txtRoutesId.Enabled = false;
            mTxtStartTime.Text = routePara.StartTime.ToString();
            mTxtEndTime.Text = routePara.EndTime.ToString();
            mTxtBreakTime.Text = routePara.EstimatedTime.ToString();
        }
        private void LoadCombobox()
        {
            var list = transportUnitRepo.GetAll().Select(p => new { p.TransportUnitId, p.TransportUnitName }).ToList();
            cbb.DisplayMember = "TransportUnitName";
            cbb.ValueMember = "TransportUnitId";
            cbb.DataSource = list;
            cbb.SelectedValue = routePara.TransportUnitId;
            cbStatus.Items.AddRange(new string[] { "Hoat dong", "Khong hoat dong" });
            cbStatus.SelectedIndex = 0;
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
            if (cbStatus.SelectedItem.ToString() == "Hoat dong")
            {
                routes.IsActive = true;
            }
            else
            {
                routes.IsActive &= false;
            }

            routes.EndPoint = txtTo.Text;
            routes.EstimatedTime = int.Parse(mTxtBreakTime.Text);
            routes.TransportUnitId = cbb.SelectedValue.ToString();
            return routes;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var routeInput = TakeInputValid();
            
            if (routeInput != null)
            {
                var routeDb = routeRepo.GetAll().Where(p => p.RoutesId.Equals(routePara.RoutesId)).FirstOrDefault();
                routeDb.TransportUnitId = cbb.SelectedValue.ToString();
                routeDb.StartPoint = routeInput.StartPoint;
                routeDb.EndPoint = routeInput.EndPoint;
                routeDb.RoutesName = routeInput.RoutesName;
                routeDb.StartTime = routeInput.StartTime;
                routeDb.EndTime = routeInput.EndTime;
                routeDb.EstimatedTime = routeInput.EstimatedTime;
                routeDb.IsActive = routeInput.IsActive;
                routeRepo.Update(routeDb);
                u.ShowNoiceBox("Cập nhật thành công!");
                this.Close();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
