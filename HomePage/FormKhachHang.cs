using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class frm_KhachHang : Form
    {
        LOPDUNGCHUNG lopDungChung = new LOPDUNGCHUNG();
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void txt_Ghichu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.");
                return;
            }
            try
            {
                string sql = $"INSERT INTO CUSTOMERS(FULLNAME, CCCD_PASSPORT, PHONE, EMAIL) VALUES(N'{txt_TenKhachHang.Text}', '{txt_CCCD.Text}', '{txt_SoDienThoai.Text}', '{txt_Email.Text}')";
                int kq = lopDungChung.ThemSuaXoa(sql);
                if (kq >= 1)
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi thêm khách hàng");
                }
                LoadKhachHang();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void lbl_SoDienThoai_Click(object sender, EventArgs e)
        {

        }

        public void LoadKhachHang()
        {
            string sql = "SELECT * FROM CUSTOMERS";
            dgv_DanhSachKhachHang.DataSource = lopDungChung.LayDuLieuTuBang(sql);
            dgv_DanhSachKhachHang.Columns["CustomerID"].Visible = false;
            dgv_DanhSachKhachHang.Columns["FullName"].HeaderText = "Tên khách hàng";
            dgv_DanhSachKhachHang.Columns["CCCD_Passport"].HeaderText = "CCCD/Passport";
            dgv_DanhSachKhachHang.Columns["Phone"].HeaderText = "Số điện thoại";
            dgv_DanhSachKhachHang.Columns["Email"].HeaderText = "Email";
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.");
                return;
            }
            try
            {
                string maKhachHang = dgv_DanhSachKhachHang.CurrentRow.Cells["CUSTOMERID"].Value.ToString();
                string sql = $"UPDATE CUSTOMERS SET FULLNAME = N'{txt_TenKhachHang.Text}', CCCD_PASSPORT = '{txt_CCCD.Text}', PHONE = '{txt_SoDienThoai.Text}', EMAIL = '{txt_Email.Text}' WHERE CUSTOMERID = '{maKhachHang}'";
                int kq = lopDungChung.ThemSuaXoa(sql);
                if (kq >= 1)
                {
                    MessageBox.Show("Sửa khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi sửa khách hàng");
                }
                LoadKhachHang();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }

        }

        private void dgv_DanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenKhachHang.Text = dgv_DanhSachKhachHang.CurrentRow.Cells["FULLNAME"].Value.ToString();
            txt_CCCD.Text = dgv_DanhSachKhachHang.CurrentRow.Cells["CCCD_Passport"].Value.ToString();
            txt_SoDienThoai.Text = dgv_DanhSachKhachHang.CurrentRow.Cells["Phone"].Value.ToString();
            txt_Email.Text = dgv_DanhSachKhachHang.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhachHang = dgv_DanhSachKhachHang.CurrentRow.Cells["CUSTOMERID"].Value.ToString();
                string sql = $"DELETE FROM CUSTOMERS WHERE CUSTOMERID = '{maKhachHang}'";
                int kq = lopDungChung.ThemSuaXoa(sql);
                if (kq >= 1)
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi xóa khách hàng");
                }
                LoadKhachHang();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }

        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Timkiem.Text)) {
                LoadKhachHang();
                return;
            }
            
            string sql = $"SELECT * FROM CUSTOMERS WHERE FULLNAME LIKE N'%{txt_Timkiem.Text.Trim()}%'";
            dgv_DanhSachKhachHang.DataSource = lopDungChung.LayDuLieuTuBang(sql);
        }

        private void grb_ThongTin_Enter(object sender, EventArgs e)
        {

        }

        void ClearForm()
        {
            txt_TenKhachHang.Clear();
            txt_CCCD.Clear();
            txt_SoDienThoai.Clear();
            txt_Email.Clear();
            txt_Timkiem.Clear();
        }

    }
}
