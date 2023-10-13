using OfficeOpenXml;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Quan_Ly
{
    public partial class formLogin : Form
    {

        List<account> dsAccountsMember = new List<account>();
        List<account> dsAccountsAdmin = new List<account>();
        formMain formMain = new formMain();
        private formDoiMatKhau formDoiMatKhau = null; // Khai báo biến để theo dõi formQuenMatKhau
        formMainAdmin formMainAdmin = new formMainAdmin();

        public formLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•';
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //Mở file excel
                using (var package = new ExcelPackage(new FileInfo("data/Accounts.xlsx")))
                {
                    //lấy sheet đầu tiên
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    //cho duyệt từ dòng 3 đến hết
                    for (int i = 3; i <= worksheet.Dimension.End.Row; i++)
                    {
                        //khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng dòng
                        string user = worksheet.Cells[i, 1].Value.ToString();
                        string password = worksheet.Cells[i, 2].Value.ToString();
                        string permission = worksheet.Cells[i, 3].Value.ToString();
                        string nameOfUser = worksheet.Cells[i, 4].Value.ToString();
                        //tạo biến account để thêm vào dsAccountsMember
                        account account = new account(user, password, permission, nameOfUser);
                        //thêm biến vừa tạo vào dsAccount
                        dsAccountsMember.Add(account);
                    }
                }
            }
            catch (Exception ex)
            {
                //Thông báo lỗi
                MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                //Mở file excel
                using (var package = new ExcelPackage(new FileInfo("data/Accounts.xlsx")))
                {
                    //lấy sheet đầu tiên
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[2];
                    //cho duyệt từ dòng 3 đến hết
                    for (int i = 3; i <= worksheet.Dimension.End.Row; i++)
                    {
                        //khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng dòng
                        string user = worksheet.Cells[i, 1].Value.ToString();
                        string password = worksheet.Cells[i, 2].Value.ToString();
                        string permission = worksheet.Cells[i, 3].Value.ToString();
                        string nameOfUser = worksheet.Cells[i, 4].Value.ToString();
                        //tạo biến account để thêm vào dsAccountsMember
                        account account = new account(user, password, permission, nameOfUser);
                        //thêm biến vừa tạo vào dsAccount
                        dsAccountsAdmin.Add(account);
                    }
                }
            }
            catch (Exception ex)
            {
                //Thông báo lỗi
                MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttDangNhap_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (var account in dsAccountsMember)
            {
                if (txtUser.Text.ToLower() == account.user.ToLower() && txtPassword.Text == account.password)
                {

                    check = 1;
                    formMain.Show();
                    this.Hide();
                    formMain.FormClosed += (s, args) => { this.Close(); }; // Thêm sự kiện FormClosed cho formMain
                    break;
                }
            }
            foreach (var account in dsAccountsAdmin)
            {
                if (txtUser.Text.ToLower() == account.user.ToLower() && txtPassword.Text == account.password)
                {
                    check = 1;
                    formMainAdmin.Show();
                    this.Hide();
                    formMainAdmin.FormClosed += (s, args) => { this.Close(); }; // Thêm sự kiện FormClosed cho formMain
                    break;
                }
            }
            if (check == 0)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkNotHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNotHidePassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; //Sử dụng '\0' để hiển thị văn bản thường.
                checkNotHidePassword.BackgroundImage = Image.FromFile("img/icon/eye.png");
            }
            else
            {
                txtPassword.PasswordChar = '•';
                checkNotHidePassword.BackgroundImage = Image.FromFile("img/icon/eye-off.png");
            }
        }

        private void linkLabelQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (formDoiMatKhau == null || formDoiMatKhau.IsDisposed)
            {
                // Nếu formQuenMatKhau chưa được tạo hoặc đã bị giải phóng, tạo một mới
                formDoiMatKhau = new formDoiMatKhau();
                formDoiMatKhau.FormClosed += (s, args) => { this.Show(); formLogin_Load(sender ,e); }; // Thêm sự kiện FormClosed cho formQuenMatKhau
            }

            this.Hide();
            formDoiMatKhau.Show();

        }
    }
}
