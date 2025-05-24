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
    public partial class frm_BookingService: Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        
        private BookingInfo booking;
        private CustomerInfo customer;
        private RoomInfo room;
        private bool isFromDP = false;

        int ID = 2;
        public frm_BookingService()
        {
            InitializeComponent();
        }

        public frm_BookingService(BookingInfo bookingInfo , RoomInfo roomInfo , CustomerInfo customerInfo , bool fromDP = false)
        {
            InitializeComponent();
            booking = bookingInfo;
            room = roomInfo;
            customer = customerInfo;
            isFromDP = fromDP;
        }
        public void LoadForm()
        {

            string query = "Select bs.BookingServiceID, s.ServiceName, bs.Quantity, bs.TotalAmount from BookingServices bs Join Services s ON bs.ServiceID = s.ServiceID";
            try
            {
                
                lbl_MaDatPhong.Text = booking.BookingId.ToString();    
                lbl_KhachHang.Text = customer.FullName;
                lbl_Phong.Text = room.RoomNumber;
             

                dataGridView2.DataSource = lopchung.LayDuLieuTuBang(query);
                dataGridView2.Columns["BookingServiceID"].HeaderText = "STT";
                dataGridView2.Columns["ServiceName"].HeaderText = "Tên dịch vụ";
                dataGridView2.Columns["Quantity"].HeaderText = "Số lượng";
                dataGridView2.Columns["TotalAmount"].HeaderText = "Thành tiền";

                dataGridView2.Columns["BookingServiceID"].Width = 50;
                dataGridView2.Columns["ServiceName"].Width = 200;
                dataGridView2.Columns["Quantity"].Width = 100;
                dataGridView2.Columns["TotalAmount"].Width = 95;

                string queryBS = "Select SUM(TotalAmount) from BookingServices";
                object result = lopchung.LayGiaTri(queryBS);
                decimal TongTien = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                lbl_TongTien.Text = TongTien.ToString("N0");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void frm_BookingService_Load(object sender, EventArgs e)
        {
            LoadForm();
            string queryS = "Select * from Services";
            try
            {
                cb_DichVu.DataSource = lopchung.LayDuLieuTuBang(queryS);
                cb_DichVu.DisplayMember = "ServiceName";
                cb_DichVu.ValueMember = "ServiceID";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void num_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            int selectedID = (int)cb_DichVu.SelectedValue;
            string query = $"Select Price from Services Where ServiceID = {selectedID}";
            try
            {
                object number = lopchung.LayGiaTri(query);
                decimal price = number != null && number != DBNull.Value ? Convert.ToDecimal(number) : 0;
                if (price == 0 || num_SoLuong.Value == 0)
                {
                    lbl_Tong.Text = "0";
                }
                else
                {
                    lbl_Tong.Text = (num_SoLuong.Value * price).ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_DichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drv = cb_DichVu.SelectedItem as DataRowView;
            if (drv == null) return;

            int selectedID = Convert.ToInt32(drv["ServiceID"]);
            string query = $"Select Price from Services Where ServiceID = {selectedID}";
            try
            {
                object number = lopchung.LayGiaTri(query);
                decimal price = number != null && number != DBNull.Value ? Convert.ToDecimal(number) : 0;
                lbl_DonGia.Text = price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ThemDichVu_Click(object sender, EventArgs e)
        {
            string query = "Insert Into BookingServices (BookingID, ServiceID, Quantity, TotalAmount) Values('"+booking.BookingId.ToString()+"', '"+cb_DichVu.SelectedValue+"', '"+num_SoLuong.Value+"', '"+decimal.Parse(lbl_Tong.Text)+"')";
            string checkquery = "Select Count(*) from BookingServices Where ServiceID = '"+cb_DichVu.SelectedValue+"'";
            try
            {
                int count = (int)lopchung.LayGiaTri(checkquery);
                if (count > 0) {
                    MessageBox.Show("Dịch vụ này đã được thêm rồi!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                try
                {
                    int kq = lopchung.ThemSuaXoa(query);
                    if (kq > 0) MessageBox.Show("Thêm dịch vụ thành công!");
                    else MessageBox.Show("Không thể thêm dịch vụ này");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            LoadForm();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string query = "Update BookingServices Set ServiceID = '" + cb_DichVu.SelectedValue + "', Quantity = '" + num_SoLuong.Value + "', TotalAmount = '" + lbl_Tong.Text + "' Where ServiceID = '" + cb_DichVu.SelectedValue + "'";
            try
            {
                int kq = lopchung.ThemSuaXoa(query);
                if (kq > 0) MessageBox.Show("Dịch vụ đã được thay đổi!");
                else MessageBox.Show("Không thể thay đổi dịch vụ này");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadForm();
        }

        private void btn_XoaDichVu_Click(object sender, EventArgs e)
        {
            string query = "Delete BookingServices Where ServiceID = '" + cb_DichVu.SelectedValue + "'";
            try
            {
                int kq = lopchung.ThemSuaXoa(query);
                if (kq > 0) MessageBox.Show("Dịch vụ đã bị xóa!");
                else MessageBox.Show("Không thể xóa dịch vụ này");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadForm();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cb_DichVu.SelectedValue = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                num_SoLuong.Value = Convert.ToDecimal(dataGridView2.CurrentRow.Cells[2].Value);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
