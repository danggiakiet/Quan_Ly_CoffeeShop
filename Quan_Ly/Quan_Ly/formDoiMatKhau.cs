using OfficeOpenXml;
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
    public partial class formDoiMatKhau : Form
    {
        List<account> dsTaiKhoanMember = new List<account>();
        List<account> dsTaiKhoanAdmin = new List<account>();
        public formDoiMatKhau()
        {
            InitializeComponent();
            txtCauHoi.ReadOnly = true;
            txtCauHoi.Cursor = Cursors.Default;
        }
        private void formQuenMatKhau_Load(object sender, EventArgs e)
        {
            try
            {
                //Mở file excel  lấy ds account member
                using (var package = new ExcelPackage(new FileInfo("data/Accounts.xlsx")))
                {
                    //lấy sheet đầu tiên
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    //cho duyệt từ dòng 3 đến hết
                    for (int i = 3; i <= worksheet.Dimension.End.Row; i++)
                    {
                        //khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng dòng
                        string user = worksheet.Cells[i, 1].Value.ToString();
                        string cauHoi = worksheet.Cells[i, 5].Value.ToString();
                        string dapAn = worksheet.Cells[i, 6].Value.ToString();
                        //tạo biến account để thêm vào dsAccountsMember
                        account account = new account(user, cauHoi, dapAn);
                        //thêm biến vừa tạo vào dsAccount
                        dsTaiKhoanMember.Add(account);
                    }
                }
                //Mở file excel lấy ds account admin
                using (var package = new ExcelPackage(new FileInfo("data/Accounts.xlsx")))
                {
                    //lấy sheet đầu tiên
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[2];
                    //cho duyệt từ dòng 3 đến hết
                    for (int i = 3; i <= worksheet.Dimension.End.Row; i++)
                    {
                        //khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng dòng
                        string user = worksheet.Cells[i, 1].Value.ToString();
                        string cauHoi = worksheet.Cells[i, 5].Value.ToString();
                        string dapAn = worksheet.Cells[i, 6].Value.ToString();
                        //tạo biến account để thêm vào dsAccountsMember
                        account account = new account(user, cauHoi, dapAn);
                        //thêm biến vừa tạo vào dsAccount
                        dsTaiKhoanAdmin.Add(account);
                    }
                }
            }
            catch (Exception ex)
            {
                //Thông báo lỗi
                MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string user = "";
        private int sheet = 0;
        private string cauHoi = "";
        private string dapAn = "";
        private void buttonCheckTaiKhoan_Click(object sender, EventArgs e)
        {
            int check = 0;
            if(txtCheckTaiKhoan.Text == "")
            {
                MessageBox.Show("Yêu cầu điền tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {       
                foreach (account accountAdmin in dsTaiKhoanAdmin)
                {
                    if(accountAdmin.user.ToLower() == txtCheckTaiKhoan.Text.ToLower())
                    {
                        user = accountAdmin.user;
                        sheet = 2;
                        cauHoi = accountAdmin.cauHoi;
                        dapAn = accountAdmin.DapAn;
                        check = 1;
                        break;
                    }    
                }
                foreach (account accountMember in dsTaiKhoanMember)
                {
                    if (accountMember.user.ToLower() == txtCheckTaiKhoan.Text.ToLower())
                    {
                        user = accountMember.user;
                        sheet = 1;
                        cauHoi = accountMember.cauHoi;
                        dapAn = accountMember.DapAn;
                        check = 1;
                        break;
                    }
                }
                if (check == 1)
                {
                    txtCheckTaiKhoan.Visible = false;
                    buttonCheckTaiKhoan.Visible = false;
                    labelTaiKhoan.Visible = false;
                    labelCauHoi.Visible = true;
                    labelDapAn.Visible = true;
                    bttCheckDapAn.Visible = true;
                    txtCauHoi.Visible = true;
                    txtCauHoi.Text = cauHoi;
                    txtDapAn.Visible = true;
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại trên hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }
        private void bttCheckDapAn_Click(object sender, EventArgs e)
        {
            if(txtDapAn.Text == dapAn)
            {
                labelCauHoi.Visible = false;
                labelDapAn.Visible = false;
                bttCheckDapAn.Visible = false;
                txtCauHoi.Visible = false;
                txtDapAn.Visible = false;
                labelMatKhau.Visible = true;
                labelNhapLaiMK.Visible = true;
                txtMatKhauMoi.Visible = true;
                txtNhapLaiMatKhau.Visible=true;
                bttCapNhapMatKhau.Visible = true;
            } 
            else
            {
                MessageBox.Show("Đáp án sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void bttCapNhapMatKhau_Click(object sender, EventArgs e)
        {
            if(txtMatKhauMoi.Text == "" || txtNhapLaiMatKhau.Text == "")
            {
                MessageBox.Show("Yêu cầu điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không trùng nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn đã chắc chắn?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        //Mở file excel
                        using (var package = new ExcelPackage(new FileInfo("data/Accounts.xlsx")))
                        {
                            //lấy sheet đầu tiên
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[sheet];
                            //cho duyệt từ dòng 3 đến hết
                            for (int i = 3; i <= worksheet.Dimension.End.Row; i++)
                            {
                                if (worksheet.Cells[i, 1].Value.ToString().ToLower() == user.ToLower())
                                {
                                    worksheet.Cells[i, 2].Value = txtMatKhauMoi.Text;
                                    MessageBox.Show("Bạn đã cập nhật mật khẩu mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    package.Save();
                                    this.Close();
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //Thông báo lỗi
                        MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
