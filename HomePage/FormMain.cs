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
//Đã complete
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
            flp_SoDoPhong.Controls.Clear();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Data\Git_Source\QuanLyKhachSan\HomePage\QuanLyKhachSan.mdf;Integrated Security=True"; ;
            string query = @"
            SELECT r.RoomID, r.RoomNumber, r.ROOMTYPEID, r.STATUSID,
                   c.CustomerID, c.FullName, c.CCCD_Passport, c.Phone,
                   b.BookingID, b.CheckInDate, b.CheckOutDate, b.Deposit
            FROM Rooms r
            LEFT JOIN Bookings b ON r.RoomID = b.RoomID
            LEFT JOIN Customers c ON b.CustomerID = c.CustomerID";


            
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    

                    BookingInfo booking = new BookingInfo 
                    {
                        BookingId = reader["BookingID"] != DBNull.Value ? Convert.ToInt32(reader["BookingID"]) : 0,
                        CheckInDate = reader["CheckInDate"] != DBNull.Value ? Convert.ToDateTime(reader["CheckInDate"]) : DateTime.MinValue,
                        CheckOutDate = reader["CheckOutDate"] != DBNull.Value ? Convert.ToDateTime(reader["CheckOutDate"]) : DateTime.MinValue,
                        Deposit = reader["Deposit"] != DBNull.Value ? Convert.ToDecimal(reader["Deposit"]) : 0
                    };

                    RoomInfo room = new RoomInfo
                    {
                        RoomID = Convert.ToInt32(reader["RoomID"]),
                        RoomNumber = reader["RoomNumber"].ToString(),
                        RoomTypeID = Convert.ToInt32(reader["RoomTypeID"]),
                        Status = reader["StatusID"].ToString()
                    };


                    CustomerInfo customer = new CustomerInfo
                    {
                        CustomerID = reader["CustomerID"] != DBNull.Value ? Convert.ToInt32(reader["CustomerID"]) : 0,
                        FullName = reader["FullName"] != DBNull.Value ? reader["FullName"].ToString() : string.Empty,
                        CCCD_Passport = reader["CCCD_Passport"] != DBNull.Value ? reader["CCCD_Passport"].ToString() : string.Empty,
                        Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : string.Empty
                    };

                    Button roomButton = new Button();
                    roomButton.Text = room.RoomNumber;
                    roomButton.Width = 150;
                    roomButton.Height = 60;
                    roomButton.Margin = new Padding(10);

                    roomButton.Font = new Font("Segoe UI", 14, FontStyle.Bold);

                    // Đổi màu theo trạng thái
                    if (room.Status == "1")
                        roomButton.BackColor = Color.LightGreen;
                    else
                        roomButton.BackColor = Color.LightCoral;
                    
                    roomButton.Click += (s, e) =>
                    {
                        if(room.Status == "1")
                        {
                            frm_DatPhong formDatPhong = new frm_DatPhong(room, true);
                            formDatPhong.ShowDialog();
                            LoadSDPhong();

                        }
                        else
                        {
                            frm_ThongTinDatPhong chiTietDatPhong = new frm_ThongTinDatPhong(booking ,room , customer , true);
                            chiTietDatPhong.ShowDialog();
                        }   
                        
                    };
                    flp_SoDoPhong.Controls.Add(roomButton);
                }
            }
        }
        private void đặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DatPhong formDatPhong = new frm_DatPhong();
            formDatPhong.FormClosed += (s, args) =>
            {
                LoadSDPhong(); // Gọi hàm reload sau khi form đóng
            };
            formDatPhong.ShowDialog();
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

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
 
        }
    }
}
