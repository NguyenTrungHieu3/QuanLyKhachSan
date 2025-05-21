using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomePage
{
    public partial class frm_Login : Form
    {
        LOPDUNGCHUNG lopDungChung = new LOPDUNGCHUNG();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        public Boolean checkUserName()
        {
            if (txt_TenDangNhap.Text == "")
            {
                MessageBox.Show("Tên đang nhập không được để trống");
                return false;
            }
            return true;
        }

        public Boolean checkPassword()
        {
            if (txt_MatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return false;
            }
            return true;
        }


        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (checkUserName() && checkPassword())
            {
                string sql = $"SELECT * FROM ACCOUNTS WHERE USERNAME = N'{txt_TenDangNhap.Text}' AND PASSWORD = N'{txt_MatKhau.Text}'";
                DataTable dt = lopDungChung.LayDuLieuTuBang(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frm_Main mainForm = new frm_Main();
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnk_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             FormDangKy  formDangKy = new FormDangKy();
            formDangKy.ShowDialog();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
