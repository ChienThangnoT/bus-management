using Services.Models;
using Services.Repository;
using System.Data;
using System.Text.RegularExpressions;

namespace BusManagement
{
    public partial class UpdateAccount : Form
    {
        AccountRepository accountRepository;
        TblAccount accountupdate;
        public UpdateAccount(TblAccount account)
        {
            accountupdate = account;
            InitializeComponent();
            loadComboBox();
            this.StartPosition = FormStartPosition.CenterScreen;
            accountRepository = new AccountRepository();
            txtAccountID.Text = account.AccountId;
            txtAccountID.Enabled = false;
            txtUserName.Text = account.Username;
            txtPassword.Text = account.Password;
            txtFullName.Text = account.FullName;
            dtpDob.Value = (DateTime)account.Dob;
            txtEmail.Text = account.Email;
            txtPhoneNumber.Text = account.PhoneNumber;
            cbbRole.SelectedItem = account.Role;

        }

        private void loadComboBox()
        {
            cbbRole.Items.AddRange(new string[] { "Nhân Viên", "Quản Lí" });
            cbbRole.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var check = checkInput();
            if (check != null)
            {
                var listAccount = accountRepository.GetAll().
                    Where(p => p.AccountId == txtAccountID.Text).FirstOrDefault();
                listAccount.Username = check.Username;
                listAccount.Password = check.Password;
                listAccount.FullName = check.FullName;
                listAccount.Dob = check.Dob;
                listAccount.Email = check.Email;
                listAccount.PhoneNumber = check.PhoneNumber;
                listAccount.Role = check.Role;

                accountRepository.Update(listAccount);
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông Báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private TblAccount checkInput()
        {
            TblAccount account = new TblAccount();

            //check textbox is null or empty
            if (String.IsNullOrEmpty(txtUserName.Text.Trim())
                || String.IsNullOrEmpty(txtFullName.Text.Trim())
                || String.IsNullOrEmpty(txtPassword.Text.Trim())
                || String.IsNullOrEmpty(txtEmail.Text.Trim())
                || String.IsNullOrEmpty(txtPhoneNumber.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (11 < txtPhoneNumber.Text.Length || txtPhoneNumber.Text.Length < 10)
            {
                MessageBox.Show("Vui lòng điền đủ số điện thoại !!!", "Thông báo", MessageBoxButtons.OK);
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

            // update data
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
