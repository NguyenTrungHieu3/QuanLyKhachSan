using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class frm_DatPhong : Form 
    {
        //private int selectedRoomID;
        //private int selectedRoomTypeID;
        //private string selectedRoomNumber;
        private RoomInfo room;
        private bool isFromMain = false;
        public frm_DatPhong()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frm_DatPhong(RoomInfo roomInfo, bool fromMain = false)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            room = roomInfo;
            isFromMain = fromMain;
        }

        LOPDUNGCHUNG chung = new LOPDUNGCHUNG();
        

        private static string[] ChuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        private static string[] DonVi = { "", "nghìn", "triệu", "tỷ" };

        private string DocSo(long so)
        {
            if (so == 0) return "Không đồng";

            string ketQua = "";
            int donViIndex = 0;

            while (so > 0)
            {
                int baSo = (int)(so % 1000);
                if (baSo != 0)
                {
                    string chu = DocBaSo(baSo);
                    ketQua = chu + " " + DonVi[donViIndex] + " " + ketQua;
                }
                so /= 1000;
                donViIndex++;
            }

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ketQua.Trim()) + " đồng";
        }

        private string DocBaSo(int baSo)
        {
            int tram = baSo / 100;
            int chuc = (baSo % 100) / 10;
            int donvi = baSo % 10;
            string kq = "";

            if (tram > 0)
            {
                kq += ChuSo[tram] + " trăm";
                if (chuc == 0 && donvi > 0) kq += " lẻ";
            }

            if (chuc > 1)
            {
                kq += " " + ChuSo[chuc] + " mươi";
                if (donvi == 1) kq += " mốt";
                else if (donvi == 5) kq += " lăm";
                else if (donvi > 0) kq += " " + ChuSo[donvi];
            }
            else if (chuc == 1)
            {
                kq += " mười";
                if (donvi == 5) kq += " lăm";
                else if (donvi > 0) kq += " " + ChuSo[donvi];
            }
            else if (donvi > 0)
            {
                kq += " " + ChuSo[donvi];
            }

            return kq.Trim();
        }

        private void frm_DatPhong_Load(object sender, EventArgs e)
        {
            LoadLoaiPhong();
            txt_tienCoc.TextChanged += txt_tienCoc_TextChanged;
            DateTime now = DateTime.Now;
            
            date_checkIn.MinDate = DateTime.Today;

            // Gán ngày check-in = hôm nay, check-out = ngày mai
            date_checkIn.Value = DateTime.Today;
            date_checkOut.Value = DateTime.Today.AddDays(1);

            // Không cho chọn ngày check-out trước ngày mai
            date_checkOut.MinDate = DateTime.Today.AddDays(1);

            date_ngayDP.MinDate = now;
            date_ngayDP.Value = now;

            if (isFromMain)
            {
                // Gán loại phòng và tên phòng theo lựa chọn từ MainForm
                combo_loaiPhong.SelectedValue = room.RoomTypeID;
                combo_loaiPhong.Enabled = false;

                LoadTenPhongTheoLoai(room.RoomTypeID);
                combo_tenPhong.SelectedValue = room.RoomID;
                combo_tenPhong.Enabled = false;

                lb_hienThiPhong.Text = room.RoomNumber;
            }
        }

        public void LoadTenPhongTheoLoai(int roomTypeId)
        {
            string query = $"SELECT * FROM Rooms WHERE ROOMTYPEID = {roomTypeId} AND STATUSID = 1";
            combo_tenPhong.DataSource = chung.LayDuLieuTuBang(query);
            combo_tenPhong.DisplayMember = "RoomNumber";
            combo_tenPhong.ValueMember = "RoomID";

            if (combo_tenPhong.SelectedValue != null)
            {
                txt_maPhong.Text = combo_tenPhong.SelectedValue.ToString();
            }

            combo_tenPhong.SelectedIndexChanged += combo_tenPhong_SelectedIndexChanged;
        }
        public void combo_tenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_tenPhong.SelectedValue != null)
            {
                txt_maPhong.Text = combo_tenPhong.SelectedValue.ToString();
            }
        }

        private void combo_loaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_loaiPhong.SelectedValue != null && int.TryParse(combo_loaiPhong.SelectedValue.ToString(), out int roomTypeId))
            {
                LoadTenPhongTheoLoai(roomTypeId);
            }
        }

        public void LoadLoaiPhong()
        {
            string queryLoad_LoaiPhong = "SELECT * FROM ROOMTYPE";
            combo_loaiPhong.DataSource = chung.LayDuLieuTuBang(queryLoad_LoaiPhong);
            combo_loaiPhong.DisplayMember = "ROOMTYPE";
            combo_loaiPhong.ValueMember = "ROOMTYPEID";

            // Gắn sự kiện chọn
            combo_loaiPhong.SelectedIndexChanged += combo_loaiPhong_SelectedIndexChanged;

            // Gọi lần đầu để load mặc định
            if (combo_loaiPhong.SelectedValue != null)
                LoadTenPhongTheoLoai((int)combo_loaiPhong.SelectedValue);
        }



        public List<string> GetNullOrEmptyFieldNames(params (string value, string name)[] fieldsToCheck)
        {
            List<string> nullOrEmptyFields = new List<string>();
            foreach (var field in fieldsToCheck)
            {
                if (string.IsNullOrEmpty(field.value))
                {
                    nullOrEmptyFields.Add(field.name);
                }
            }
            return nullOrEmptyFields;
        }

        private void txt_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép phím số và phím điều khiển như Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void txt_tienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép phím số và phím điều khiển như Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void txt_tienCoc_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txt.Text)) return;

            int selectionStart = txt.SelectionStart;
            int length = txt.Text.Length;

            // Xoá tất cả dấu chấm cũ
            string textWithoutDots = txt.Text.Replace(".", "");

            // Nếu là số thì định dạng lại
            if (long.TryParse(textWithoutDots, out long value))
            {
                txt.Text = string.Format("{0:N0}", value).Replace(",", ".");
                // Cập nhật lại vị trí con trỏ để không nhảy lung tung
                txt.SelectionStart = txt.Text.Length - (length - selectionStart);

                lb_hienThiChu.Text = DocSo(value);
            }
            else
            {
                lb_hienThiChu.Text = "";
            }
        }

        private void txt_CCCD_TextChanged(object sender, EventArgs e)
        {
            string cccd = txt_CCCD.Text.Trim();
            if (string.IsNullOrEmpty(cccd))
            {
                return;
            }
            string chuoiKn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Data\Git_Source\QuanLyKhachSan\HomePage\QuanLyKhachSan.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(chuoiKn))
            {
                conn.Open();

                // 1. Kiểm tra khách hàng có tồn tại không
                string queryCheck = "SELECT TOP 1 CustomerID, FullName, Phone FROM Customers WHERE CCCD_Passport = @cccd";
                SqlCommand cmd = new SqlCommand(queryCheck, conn);
                cmd.Parameters.AddWithValue("@cccd", cccd);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Nếu tìm thấy
                    txt_maKH.Text = reader["CustomerID"].ToString();
                    txt_TenKhachHang.Text = reader["FullName"].ToString();
                    txt_SoDienThoai.Text = reader["Phone"].ToString();
                }
                else
                {
                    reader.Close();

                    // 2. Nếu không tìm thấy thì lấy CustomerID mới + 1
                    string idQuery = "SELECT ISNULL(MAX(CustomerID), 0) + 1 FROM Customers";
                    SqlCommand idCmd = new SqlCommand(idQuery, conn);
                    int nextId = (int)idCmd.ExecuteScalar();

                    txt_maKH.Text = nextId.ToString();
                    // Có thể để trống Name, Phone để nhập mới
                    txt_TenKhachHang.Text = "";
                    txt_SoDienThoai.Text = "";
                }

                conn.Close();
            }
        }

        public void ClearFields(params Control[] controls)
        {

            DateTime today = DateTime.Today;

            DateTimePicker checkInControl = null;
            DateTimePicker checkOutControl = null;

            foreach (var control in controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is DateTimePicker)
                {
                    // Tạm lưu lại để xử lý sau
                    if (control.Name == "date_checkIn")
                        checkInControl = (DateTimePicker)control;
                    else if (control.Name == "date_checkOut")
                        checkOutControl = (DateTimePicker)control;
                }
                else if (control is Label)
                {
                    ((Label)control).Text = "";
                }

                // Xử lý sau khi duyệt xong
                if (checkInControl != null)
                {
                    checkInControl.Value = DateTime.Today;
                   
                }

                if (checkOutControl != null)
                {
                    checkOutControl.MinDate = DateTime.Today.AddDays(1);
                    checkOutControl.Value = DateTime.Today.AddDays(1);
                }                
            }
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            string maKH = txt_maKH.Text;
            string maDPhong = txt_maDatPhong.Text;  
            string maPhong = txt_maPhong.Text;
            
            string tenKH = txt_TenKhachHang.Text;
            string cccd = txt_CCCD.Text;
            string sdt = txt_SoDienThoai.Text;

            string ngayCheckIn = date_checkIn.Text;
            string ngayCheckOut = date_checkOut.Text;
            string tenPhong = combo_tenPhong.Text;
            string loaiPhong = combo_loaiPhong.Text.Trim();
            string tienCoc = txt_tienCoc.Text;

            List<string> missingFields = GetNullOrEmptyFieldNames(
                (tenKH, "Tên Khách Hàng"),
                (cccd, "CCCD"),
                (sdt, "Số Điện Thoại"),
                (ngayCheckIn, "Ngày Nhận Phòng"),
                (ngayCheckOut, "Ngày Trả Phòng"),
                (tenPhong, "Tên Phòng"),
                (loaiPhong, "Loại Phòng"),
                (tienCoc, "Tiền Cọc")
            );

            if (missingFields.Any())
            {
                MessageBox.Show($"Vui lòng điền đầy đủ các trường sau: {string.Join(", ", missingFields)}", "Thông tin còn thiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int customerId;
                if (!int.TryParse(maKH, out customerId))
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal tienCoc1;
                if (!decimal.TryParse(tienCoc.Replace(".", ""), out tienCoc1))
                {
                    MessageBox.Show("Tiền cọc không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string queryKiemTraKH = "SELECT COUNT(*) FROM Customers WHERE CCCD_Passport = '" + cccd + "'";
                int checkKH = (int)chung.LayGiaTri(queryKiemTraKH);

                int re1 = 0;
                if (checkKH == 0)
                {
                    string queryThemKH = "INSERT INTO Customers (FullName, CCCD_Passport, Phone , Email) VALUES (N'" + tenKH + "' , '" + cccd + "' , '" + sdt + "' , NULL )";
                    re1 = chung.ThemSuaXoa(queryThemKH);
                }

                string queryThemBooking = "INSERT INTO Bookings (CustomerID , RoomID , CheckInDate , CheckOutDate , Deposit) VALUES ('" + int.Parse(maKH) + "' , '" + int.Parse(maPhong) + "' , Convert(datetime,'" + ngayCheckIn + "',103) , Convert(datetime,'" + ngayCheckOut + "',103) , '" + tienCoc1 + "' )";
                int re = chung.ThemSuaXoa(queryThemBooking);

                string querySetUpStatus = "UPDATE Rooms SET STATUSID = 2 WHERE RoomID = '"+ maPhong +"'";
                int re2 = chung.ThemSuaXoa(querySetUpStatus);


                if (re > 0 && re2 > 0)
                {
                    MessageBox.Show("Đặt phòng thành công", "Thông báo", MessageBoxButtons.OK);
                    ClearFields(txt_maKH, txt_CCCD, txt_TenKhachHang, txt_SoDienThoai, date_checkIn, date_checkOut, txt_maDatPhong,txt_maPhong, combo_tenPhong,combo_loaiPhong, txt_tienCoc);
                    lb_hienThiChu.Text = "";
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Đặt phòng không thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void grb_ThongTinDP_Enter(object sender, EventArgs e)
        {

        }

        private void data_ngayDP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grb_ThongTinKH_Enter(object sender, EventArgs e)
        {

        }
    }
}
