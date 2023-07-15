using Services.Models;
using Services.Repository;
using System.Data;
using System.Text.RegularExpressions;

namespace BusManagement
{
    public partial class AddAccount : Form
    {
        AccountRepository accountRepository;

        public AddAccount()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            accountRepository = new AccountRepository();
            loadComboBox();
        }

        private void loadComboBox()
        {
            cbbRole.Items.AddRange(new string[] { "Nhân Viên", "Quản Lí" });
            cbbRole.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtAccountID.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dtpDob.Value = DateTime.Now;
            txtPhoneNumber.Text = string.Empty;
            cbbRole.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var account = checkInput();

            if (account != null)
            {
                accountRepository.Create(account);
                MessageBox.Show("Thêm thông tin thành công!", "Thông Báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private TblAccount checkInput()
        {
            TblAccount account = new TblAccount();

            //check textbox is null or empty
            if (String.IsNullOrEmpty(txtAccountID.Text.Trim())
                || String.IsNullOrEmpty(txtUserName.Text.Trim())
                || String.IsNullOrEmpty(txtFullName.Text.Trim())
                || String.IsNullOrEmpty(txtPassword.Text.Trim())
                || String.IsNullOrEmpty(txtEmail.Text.Trim())
                || String.IsNullOrEmpty(txtPhoneNumber.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //check id match regex or not
            String idPattern = @"^[A, a]{1}[0-9]{4}$";
            if (!Regex.IsMatch(txtAccountID.Text.Trim(), idPattern))
            {
                MessageBox.Show("Hãy nhập ID theo cú pháp sau: [A****]. Trong đó * là số. Ví Dụ: [A1234] ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //check id is duplicate or not
            var accountID = accountRepository.GetAll().
                Where(p => p.AccountId.Equals(txtAccountID.Text.Trim().ToUpper())).FirstOrDefault();
            if (accountID != null)
            {
                MessageBox.Show("Đã có ID này rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }


            //check username is duplicate or not
            var username = accountRepository.GetAll().
                Where(p => p.Username.Equals(txtUserName.Text.Trim().ToUpper())).FirstOrDefault();
            if (username != null)
            {
                MessageBox.Show("Tài khoản này đã có rồi!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }


            //check if full name has special characters or numbers or not
            if (!txtFullName.Text.Trim().All(c => Char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Họ và Tên không được nhập ký tự đặc biệt và số!!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            // check email is match regex or not
            String emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (!Regex.IsMatch(txtEmail.Text.Trim(), emailPattern))
            {
                MessageBox.Show("Email phải được nhập theo định dạng sau: 'abc@abc.com' ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            // check phoneNumber only input 9-11 number
            string phoneNumberPattern = @"^[0-9]{9,11}$";
            if (!Regex.IsMatch(txtPhoneNumber.Text.Trim(), phoneNumberPattern))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập từ 9 - 11 số và không thể nhập chữ!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            // add data
            account.AccountId = txtAccountID.Text.Trim().ToUpper();
            account.Username = txtUserName.Text.Trim();
            account.Password = txtPassword.Text.Trim();
            account.FullName = txtFullName.Text.Trim();
            account.Dob = dtpDob.Value;
            account.Email = txtEmail.Text.Trim();
            account.PhoneNumber = txtPhoneNumber.Text.Trim();
            account.Role = cbbRole.SelectedItem.ToString();
            account.IsActive = true;

            return account;
        }


    }
}