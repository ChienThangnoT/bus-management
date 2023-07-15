using Services.Models;
using Services.Repository;

namespace BusManagement
{

    public partial class Login : Form
    {
        public static TblAccount accountLG;
        Util u;
        public Login()
        {
            InitializeComponent();
            u = new Util();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            accountLG = new AccountRepository().GetAll().Where(p => p.IsActive == true && p.Username.Equals(txtAccount.Text) && p.Password.Equals(txtPassword.Text)).FirstOrDefault();
            if (accountLG == null || accountLG.Role.Length == 0)
            {
                u.ShowNoiceBox("Tài Khoản hoặc mật khẩu không đúng!");
            }
            else
            {
                Form f = new RoutesManagement(accountLG);
                this.Hide();
                f.ShowDialog();
            }
        }


    }
}