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
    public partial class frm_Main : Form
    {
        LOPDUNGCHUNG lopDungChung = new LOPDUNGCHUNG();
        public frm_Main()
        {
            InitializeComponent();

        }

        private void frm_QuanLyKhachSan_Load(object sender, EventArgs e)
        {
            mc_NgayThang.Size = new System.Drawing.Size(200, 150);
            string sqlLaySoPhongTrong = $"SELECT COUNT(*) FROM ROOMS WHERE STATUS = 'available'";
            string sqlLaySoPhongDaDat = $"SELECT COUNT(*) FROM ROOMS WHERE STATUS = 'booked'";
            int soLuongPhongTrong = (int)lopDungChung.LayGiaTri(sqlLaySoPhongTrong);
            int soLuongPhongDaDat = (int)lopDungChung.LayGiaTri(sqlLaySoPhongDaDat);
            lbl_SoLuongPhongTrong.Text = soLuongPhongTrong.ToString();
            lbl_SoLuongPhongDaDat.Text = soLuongPhongDaDat.ToString();
        }

        private void đặtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mc_NgayThang_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mi_KhachHang_Click(object sender, EventArgs e)
        {
            frm_KhachHang formKhachHang = new frm_KhachHang();
            this.Hide();
            formKhachHang.ShowDialog();
            this.Close();
        }

        // Thêm phương thức để mở form quản lý dịch vụ
        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Services formServices = new frm_Services();
            this.Hide();
            formServices.ShowDialog();
            this.Close();
        }
    }
}
