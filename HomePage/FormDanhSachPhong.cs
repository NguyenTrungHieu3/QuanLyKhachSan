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
	public partial class frm_DanhSachPhong : Form
	{
		LOPDUNGCHUNG lopDungChung = new LOPDUNGCHUNG();

		//public event EventHandler PhongMoiDuocThem;

		public frm_DanhSachPhong()
		{
			InitializeComponent();
		}

		public void LoadDanhSachPhong()
		{
			string sql = "SELECT  R.ROOMID, R.ROOMNUMBER, RT.ROOMTYPE AS LOAIPHONG, R.PRICE, S.STATUS AS TRANGTHAI FROM ROOMS R JOIN ROOMTYPE RT ON R.ROOMTYPEID = RT.ROOMTYPEID JOIN STATUS S ON R.STATUSID = S.STATUSID";
			dgv_DanhSachPhong.DataSource = lopDungChung.LayDuLieuTuBang(sql);
			dgv_DanhSachPhong.Columns["ROOMID"].HeaderText = "Mã phòng";
			dgv_DanhSachPhong.Columns["ROOMNUMBER"].HeaderText = "Số phòng";
			dgv_DanhSachPhong.Columns["LOAIPHONG"].HeaderText = "Loại phòng";
			dgv_DanhSachPhong.Columns["PRICE"].HeaderText = "Giá phòng";
			dgv_DanhSachPhong.Columns["TRANGTHAI"].HeaderText = "Trạng thái";
		}

		public void LoadLoaiPhong()
		{
			string sql = $"SELECT * FROM ROOMTYPE";
			cb_LoaiPhong.DataSource = lopDungChung.LayDuLieuTuBang(sql);
			cb_LoaiPhong.DisplayMember = "ROOMTYPE";
			cb_LoaiPhong.ValueMember = "ROOMTYPEID";
		}

		public void LoadTrangThaiPhong()
		{
			string sql = $"SELECT * FROM STATUS";
			cb_TrangThai.DataSource = lopDungChung.LayDuLieuTuBang(sql);
			cb_TrangThai.DisplayMember = "STATUS";
			cb_TrangThai.ValueMember = "STATUSID";
		}

		public void LoadLoaiPhongTimKiem()
		{
			string sql = $"SELECT * FROM ROOMTYPE";
			cb_LoaiPhongTim.DataSource = lopDungChung.LayDuLieuTuBang(sql);
			cb_LoaiPhongTim.DisplayMember = "ROOMTYPE";
			cb_LoaiPhongTim.ValueMember = "ROOMTYPEID";
		}

		public void LoadTrangThaiPhongTimKiem()
		{
			string sql = $"SELECT * FROM STATUS";
			cb_TrangThaiTim.DataSource = lopDungChung.LayDuLieuTuBang(sql);
			cb_TrangThaiTim.DisplayMember = "STATUS";
			cb_TrangThaiTim.ValueMember = "STATUSID";
		}

		private void DanhSachPhong_Load(object sender, EventArgs e)
		{
			LoadLoaiPhong();
			LoadTrangThaiPhong();
			LoadDanhSachPhong();
			LoadLoaiPhongTimKiem();
			LoadTrangThaiPhongTimKiem();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			if (!double.TryParse(txt_GiaTien.Text, out double giaTien))
			{
				MessageBox.Show("Giá tiền không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				string sql = $"UPDATE ROOMS SET ROOMNUMBER = '{txt_SoPhong.Text}', ROOMTYPEID = '{cb_LoaiPhong.SelectedValue}', PRICE = '{Double.Parse(txt_GiaTien.Text)}', STATUSID = '{cb_TrangThai.SelectedValue}' WHERE ROOMID = '{txt_MaPhong.Text}'";
				int kq = lopDungChung.ThemSuaXoa(sql);
				if (kq > 0)
				{
					MessageBox.Show("Sửa phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Lỗi sửa phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				LoadDanhSachPhong();
				ResetForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txt_SoPhong.Text) || string.IsNullOrWhiteSpace(txt_GiaTien.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!double.TryParse(txt_GiaTien.Text, out double giaTien))
			{
				MessageBox.Show("Giá tiền không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				string sql = $"INSERT INTO ROOMS(ROOMNUMBER, ROOMTYPEID, PRICE, STATUSID) VALUES('{txt_SoPhong.Text}', '{cb_LoaiPhong.SelectedValue}','{Double.Parse(txt_GiaTien.Text)}', '{cb_TrangThai.SelectedValue}')";
				int kq = lopDungChung.ThemSuaXoa(sql);
				if (kq > 0)
				{
					MessageBox.Show("Thêm phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Lỗi thêm phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				LoadDanhSachPhong();
				ResetForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			try
			{
				string sql = $"DELETE FROM ROOMS WHERE ROOMID = '{txt_MaPhong.Text}'";
				int kq = lopDungChung.ThemSuaXoa(sql);
				if (kq > 0)
				{
					MessageBox.Show("Xóa phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Lỗi xóa phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				LoadDanhSachPhong();
				ResetForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgv_DanhSachPhong_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txt_MaPhong.Text = dgv_DanhSachPhong.CurrentRow.Cells["ROOMID"].Value.ToString();
			txt_SoPhong.Text = dgv_DanhSachPhong.CurrentRow.Cells["ROOMNUMBER"].Value.ToString();
			cb_LoaiPhong.Text = dgv_DanhSachPhong.CurrentRow.Cells["LOAIPHONG"].Value.ToString();
			txt_GiaTien.Text = dgv_DanhSachPhong.CurrentRow.Cells["PRICE"].Value.ToString();
			cb_TrangThai.Text = dgv_DanhSachPhong.CurrentRow.Cells["TRANGTHAI"].Value.ToString();
		}

		private void btn_Tim_Click(object sender, EventArgs e)
		{
			string soPhong = txt_SoPhongTim.Text.Trim();
			string loaiPhongID = cb_LoaiPhongTim.SelectedValue?.ToString();
			string trangThaiID = cb_TrangThaiTim.SelectedValue?.ToString();

			string sql = @"SELECT R.ROOMID, R.ROOMNUMBER, RT.ROOMTYPE AS LOAIPHONG, 
                            R.PRICE, S.STATUS AS TRANGTHAI 
                       FROM ROOMS R 
                       JOIN ROOMTYPE RT ON R.ROOMTYPEID = RT.ROOMTYPEID 
                       JOIN STATUS S ON R.STATUSID = S.STATUSID 
                       WHERE 1=1";

			if (!string.IsNullOrEmpty(soPhong))
			{
				sql += $" AND R.ROOMNUMBER LIKE '%{soPhong}%'";
			}

			if (!string.IsNullOrEmpty(loaiPhongID))
			{
				sql += $" AND R.ROOMTYPEID = '{loaiPhongID}'";
			}

			if (!string.IsNullOrEmpty(trangThaiID))
			{
				sql += $" AND R.STATUSID = '{trangThaiID}'";
			}

			dgv_DanhSachPhong.DataSource = lopDungChung.LayDuLieuTuBang(sql);
		}

		void ResetForm()
		{
			txt_MaPhong.Clear();
			txt_SoPhong.Clear();
			txt_GiaTien.Clear();
			cb_LoaiPhong.SelectedIndex = 0;
			cb_TrangThai.SelectedIndex = 0;
		}

	}
}