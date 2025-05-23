using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            string sqlLaySoPhongTrong = $"SELECT COUNT(*) FROM ROOMS WHERE STATUSID = 1";
            string sqlLaySoPhongDaDat = $"SELECT COUNT(*) FROM ROOMS WHERE STATUSID = 2";

            int soLuongPhongTrong = (int)lopDungChung.LayGiaTri(sqlLaySoPhongTrong);
            int soLuongPhongDaDat = (int)lopDungChung.LayGiaTri(sqlLaySoPhongDaDat);
            lbl_SoLuongPhongTrong.Text = soLuongPhongTrong.ToString();
            lbl_SoLuongPhongDaDat.Text = soLuongPhongDaDat.ToString();
            LoadSDPhong();
        }
        public void LoadSDPhong()
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CS-464-FIS\CSHARP\Lesson03-Winforms\QuanLyKhachSan\HomePage\QuanLyKhachSan.mdf;Integrated Security=True"; ;
            string query = "SELECT RoomID ,  RoomNumber,ROOMTYPEID , STATUSID FROM Rooms";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string roomNumber = reader["RoomNumber"].ToString();
                    string status = reader["STATUSID"].ToString();
                    int roomID = Convert.ToInt32(reader["RoomID"]);
                    int roomTypeID = Convert.ToInt32(reader["RoomTypeID"]);

                    Button roomButton = new Button();
                    roomButton.Text = roomNumber;
                    roomButton.Width = 150;
                    roomButton.Height = 60;
                    roomButton.Margin = new Padding(10);

                    roomButton.Font = new Font("Segoe UI", 14, FontStyle.Bold);

                    // Đổi màu theo trạng thái
                    if (status == "1")
                        roomButton.BackColor = Color.LightGreen;
                    else if (status == "2")
                        roomButton.BackColor = Color.Yellow;
                    else
                        roomButton.BackColor = Color.LightCoral;

                    roomButton.Click += (s, e) =>
                    {
                        if(status == "1")
                        {
                            frm_DatPhong datPhong = new frm_DatPhong(roomID, roomTypeID, roomNumber, true);
                            datPhong.ShowDialog();
                        }
                        else if (status == "2")
                        {
                            frm_ThongTinDatPhong chiTietDatPhong = new frm_ThongTinDatPhong();
                            chiTietDatPhong.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Phòng đang được dọn dẹp");
                        }   
                        
                    };
                    flp_SoDoPhong.Controls.Add(roomButton);
                }
            }
        }
        private void đặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DatPhong formDatPhong = new frm_DatPhong();
            formDatPhong.ShowDialog();
            this.Close();
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

        private void mi_DanhSachPhong_Click(object sender, EventArgs e)
        {
            frm_DanhSachPhong formDanhSachPhong = new frm_DanhSachPhong();
            this.Hide();
            formDanhSachPhong.ShowDialog();
            this.Close();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mi_DichVu_Click(object sender, EventArgs e)
        {
            frm_DichVu fromServices = new frm_DichVu();
            this.Hide();
            fromServices.ShowDialog();
            this.Close();
        }


        private void gb_SoDoPhong_Enter(object sender, EventArgs e) { }

        private void panel1_Paint_1(object sender, PaintEventArgs e)

        {

        }
    }
}
