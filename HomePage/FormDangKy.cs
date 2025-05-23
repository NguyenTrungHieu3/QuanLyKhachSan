using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace HomePage
{
    public partial class FormDangKy : Form
    {
        LOPDUNGCHUNG lopDungChung = new LOPDUNGCHUNG();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txt_TenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txt_MatKhau.Text != txt_XacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                string checkUserSql = $"SELECT COUNT(*) FROM ACCOUNTS WHERE USERNAME = N'{txt_TenDangNhap.Text}'";
                int userCount = Convert.ToInt32(lopDungChung.LayGiaTri(checkUserSql));

                if (userCount > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertSql = $"INSERT INTO ACCOUNTS (USERNAME, PASSWORD) VALUES (N'{txt_TenDangNhap.Text}', N'{txt_MatKhau.Text}')";
                int kq = lopDungChung.ThemSuaXoa(insertSql);

                if (kq >= 1)
                {
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_QuayLai_Click(object sender, EventArgs e)
        {
            frm_Login loginForm = new frm_Login();
            this.Hide();
            loginForm.Show();
            this.Close();
            
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
