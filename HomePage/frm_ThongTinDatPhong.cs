using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HomePage
{
    public partial class frm_ThongTinDatPhong : Form
    {
        private RoomInfo room;
        private CustomerInfo customer;
        private BookingInfo booking;
        private bool isFromMain = false;
        public frm_ThongTinDatPhong()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        LOPDUNGCHUNG chung = new LOPDUNGCHUNG();
        public frm_ThongTinDatPhong(BookingInfo bookingInfo, RoomInfo roomInfo, CustomerInfo customerInfo,bool fromMain = false)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            booking = bookingInfo;
            room = roomInfo;
            customer = customerInfo;
            isFromMain = fromMain;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void combo_loaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_loaiPhong.SelectedValue != null && int.TryParse(combo_loaiPhong.SelectedValue.ToString(), out int roomTypeId))
            {
                LoadTenPhongTheoLoai(roomTypeId);
            }
        }

        public void combo_tenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_tenPhong.SelectedValue != null)
            {
                txt_maPhong.Text = combo_tenPhong.SelectedValue.ToString();
            }
        }

        public void LoadDV()
        {
            string query = "Select bs.BookingServiceID, s.ServiceName, bs.Quantity, bs.TotalAmount from BookingServices bs Join Services s ON bs.ServiceID = s.ServiceID";
            dgv_dichVuDat.DataSource = chung.LayDuLieuTuBang(query);
            dgv_dichVuDat.Columns["BookingServiceID"].HeaderText = "STT";
            dgv_dichVuDat.Columns["ServiceName"].HeaderText = "Tên dịch vụ";
            dgv_dichVuDat.Columns["Quantity"].HeaderText = "Số lượng";
            dgv_dichVuDat.Columns["TotalAmount"].HeaderText = "Thành tiền";
        }
        private void frm_ThongTinDatPhong_Load(object sender, EventArgs e)
        {
            if(isFromMain)
            {
                // Gán loại phòng và tên phòng theo lựa chọn từ MainForm
                txt_maKH.Text = customer.CustomerID.ToString();
                txt_TenKhachHang.Text = customer.FullName;
                txt_CCCD.Text = customer.CCCD_Passport;
                txt_SoDienThoai.Text = customer.Phone;  

                txt_maDatPhong.Text = booking.BookingId.ToString();
                txt_maPhong.Text = room.RoomID.ToString();
                
                combo_loaiPhong.SelectedValue = room.RoomTypeID;
                combo_loaiPhong.Enabled = false;

                LoadTenPhongTheoLoai(room.RoomTypeID);
                combo_tenPhong.SelectedValue = room.RoomID;
                combo_tenPhong.Enabled = false;

                txt_tienCoc.Text = booking.Deposit.ToString();

                lb_hienThiPhong.Text = room.RoomNumber;
                LoadDV();
            }
        }

        private void btn_dichVu_Click(object sender, EventArgs e)
        {
            frm_BookingService bookingService = new frm_BookingService(booking,room,customer,true);   
            bookingService.ShowDialog();
        }
    }
}
