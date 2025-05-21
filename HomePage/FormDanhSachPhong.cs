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
using System.Data;

namespace HomePage
{
    public partial class frm_DanhSachPhong : Form
    {
        LOPDUNGCHUNG lopDungChung = new LOPDUNGCHUNG();

        public event EventHandler PhongMoiDuocThem;

        public frm_DanhSachPhong()
        {
            InitializeComponent();
        }

        private void DanhSachPhong_Load(object sender, EventArgs e)
        {
            string sql = "SELECT ROOMTYPE FROM ROOMS";
            //DataTable dt = new DataTable();
            cb_LoaiPhong.DataSource = lopDungChung.LayDuLieuTuBang(sql);
        }

        public void LoadDanhSachPhong()
        {

        }
    }
}
