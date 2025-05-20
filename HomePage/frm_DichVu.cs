using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HomePage
{
    public partial class frm_DichVu : Form
    {
        LOPDUNGCHUNG dc = new LOPDUNGCHUNG();
        private void frm_DichVu_Load(object sender, EventArgs e)
        {
            // Tạo panel mới để chứa DataGridView
            Panel panelGrid = new Panel();
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.BackColor = Color.White;

            // Đảm bảo DataGridView hiển thị
            dgvServices.Dock = DockStyle.Fill;
            dgvServices.Visible = true;

            // Thêm DataGridView vào panel
            panelGrid.Controls.Add(dgvServices);

            // Thêm panel vào form
            this.Controls.Add(panelGrid);

            // Đưa panel lên trên cùng
            panelGrid.BringToFront();

            LoadDataServices();
            ResetForm();
        }

        public frm_DichVu()
        {
            InitializeComponent();
        }


        private void LoadDataServices()
        {
            try
            {
                // Load dữ liệu từ cơ sở dữ liệu
                string sql = "SELECT * FROM Services";
                DataTable dt = dc.LayDuLieuTuBang(sql);

                // Kiểm tra xem có dữ liệu hay không
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvServices.DataSource = dt;

                    // Định dạng cột
                    dgvServices.Columns["ServiceID"].HeaderText = "Mã dịch vụ";
                    dgvServices.Columns["ServiceName"].HeaderText = "Tên dịch vụ";
                    dgvServices.Columns["Description"].HeaderText = "Mô tả";
                    dgvServices.Columns["Price"].HeaderText = "Giá";
                    dgvServices.Columns["Price"].DefaultCellStyle.Format = "N0";
                }
                else
                {
                    // Nếu không có dữ liệu, tạo dữ liệu mẫu để kiểm tra hiển thị
                    DataTable dtTest = new DataTable();
                    dtTest.Columns.Add("ServiceID", typeof(int));
                    dtTest.Columns.Add("ServiceName", typeof(string));
                    dtTest.Columns.Add("Description", typeof(string));
                    dtTest.Columns.Add("Price", typeof(decimal));

                    dtTest.Rows.Add(1, "Dịch vụ 1", "Mô tả 1", 100000);
                    dtTest.Rows.Add(2, "Dịch vụ 2", "Mô tả 2", 200000);

                    dgvServices.DataSource = dtTest;

                    // Định dạng cột
                    dgvServices.Columns["ServiceID"].HeaderText = "Mã dịch vụ";
                    dgvServices.Columns["ServiceName"].HeaderText = "Tên dịch vụ";
                    dgvServices.Columns["Description"].HeaderText = "Mô tả";
                    dgvServices.Columns["Price"].HeaderText = "Giá";
                    dgvServices.Columns["Price"].DefaultCellStyle.Format = "N0";

                    MessageBox.Show("Không có dữ liệu trong bảng Services. Đã tạo dữ liệu mẫu để kiểm tra hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtServiceID.Text = "";
            txtServiceName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtServiceName.Focus();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtServiceName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServiceName.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            // Kiểm tra giới hạn giá trị của decimal(10,2)
            if (price > 99999999.99m)
            {
                MessageBox.Show("Giá trị quá lớn. Giá tối đa cho phép là 99,999,999.99", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            return true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                // Chuyển đổi giá trị Price sang decimal để đảm bảo định dạng đúng
                if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
                {
                    MessageBox.Show("Giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrice.Focus();
                    return;
                }

                // Sử dụng cấu trúc SQL cũ
                string sql = $"INSERT INTO Services (ServiceName, Description, Price) VALUES (N'{txtServiceName.Text.Trim().Replace("'", "''")}', N'{txtDescription.Text.Trim().Replace("'", "''")}', {price.ToString().Replace(",", ".")})";

                int result = dc.ThemSuaXoa(sql);

                if (result > 0)
                {
                    MessageBox.Show("Thêm dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataServices();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Message.Contains("Arithmetic overflow"))
                {
                    MessageBox.Show("Giá trị quá lớn cho cột Price. Giá tối đa cho phép là 99,999,999.99", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                }
                else
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServiceID.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateForm()) return;

            try
            {
                // Chuyển đổi giá trị Price sang decimal để đảm bảo định dạng đúng
                if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
                {
                    MessageBox.Show("Giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrice.Focus();
                    return;
                }

                // Sử dụng cấu trúc SQL cũ
                string sql = $"UPDATE Services SET ServiceName = N'{txtServiceName.Text.Trim().Replace("'", "''")}', Description = N'{txtDescription.Text.Trim().Replace("'", "''")}', Price = {price.ToString().Replace(",", ".")} WHERE ServiceID = {txtServiceID.Text}";

                int result = dc.ThemSuaXoa(sql);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataServices();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật dịch vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Message.Contains("Arithmetic overflow"))
                {
                    MessageBox.Show("Giá trị quá lớn cho cột Price. Giá tối đa cho phép là 99,999,999.99", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                }
                else
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServiceID.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kiểm tra xem dịch vụ có đang được sử dụng không
                string checkSql = $"SELECT COUNT(*) FROM BookingServices WHERE ServiceID = {txtServiceID.Text}";
                int count = Convert.ToInt32(dc.LayGiaTri(checkSql));

                if (count > 0)
                {
                    MessageBox.Show("Không thể xóa dịch vụ này vì đang được sử dụng trong đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = $"DELETE FROM Services WHERE ServiceID = {txtServiceID.Text}";

                    int deleteResult = dc.ThemSuaXoa(sql);

                    if (deleteResult > 0)
                    {
                        MessageBox.Show("Xóa dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataServices();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa dịch vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvServices.Rows[e.RowIndex];
                txtServiceID.Text = row.Cells["ServiceID"].Value.ToString();
                txtServiceName.Text = row.Cells["ServiceName"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value != null ? row.Cells["Description"].Value.ToString() : "";
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
                {
                    LoadDataServices();
                    return;
                }

                string sql = $"SELECT * FROM Services WHERE ServiceName LIKE N'%{txtTimKiem.Text.Trim().Replace("'", "''")}%'";
                dgvServices.DataSource = dc.LayDuLieuTuBang(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                decimal giaMin = 0;
                decimal giaMax = decimal.MaxValue;

                if (!string.IsNullOrWhiteSpace(txtGiaMin.Text))
                {
                    if (!decimal.TryParse(txtGiaMin.Text, out giaMin))
                    {
                        MessageBox.Show("Giá tối thiểu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtGiaMin.Focus();
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtGiaMax.Text))
                {
                    if (!decimal.TryParse(txtGiaMax.Text, out giaMax))
                    {
                        MessageBox.Show("Giá tối đa không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtGiaMax.Focus();
                        return;
                    }
                }

                // Kiểm tra giới hạn giá trị
                if (giaMin > 99999999.99m || giaMax > 99999999.99m)
                {
                    MessageBox.Show("Giá trị quá lớn. Giá tối đa cho phép là 99,999,999.99", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = $"SELECT * FROM Services WHERE Price >= {giaMin.ToString().Replace(",", ".")} AND Price <= {giaMax.ToString().Replace(",", ".")}";
                dgvServices.DataSource = dc.LayDuLieuTuBang(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
