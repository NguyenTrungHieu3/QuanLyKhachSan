namespace HomePage
{
    partial class frm_DanhSachPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.grb_ThongTin = new System.Windows.Forms.GroupBox();
            this.cb_TrangThai = new System.Windows.Forms.ComboBox();
            this.txt_SoPhong = new System.Windows.Forms.TextBox();
            this.lbl_SoPhong = new System.Windows.Forms.Label();
            this.txt_GiaTien = new System.Windows.Forms.TextBox();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.lbl_GiaTien = new System.Windows.Forms.Label();
            this.lbl_LoaiPhong = new System.Windows.Forms.Label();
            this.txt_Timkiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.dgv_DanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.cb_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.grb_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Them.Location = new System.Drawing.Point(506, 197);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(120, 37);
            this.btn_Them.TabIndex = 75;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Xoa.Location = new System.Drawing.Point(794, 197);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(120, 37);
            this.btn_Xoa.TabIndex = 77;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sua.Location = new System.Drawing.Point(652, 197);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 37);
            this.btn_Sua.TabIndex = 76;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Controls.Add(this.cb_TrangThai);
            this.grb_ThongTin.Controls.Add(this.cb_LoaiPhong);
            this.grb_ThongTin.Controls.Add(this.txt_SoPhong);
            this.grb_ThongTin.Controls.Add(this.lbl_SoPhong);
            this.grb_ThongTin.Controls.Add(this.txt_GiaTien);
            this.grb_ThongTin.Controls.Add(this.lbl_TrangThai);
            this.grb_ThongTin.Controls.Add(this.lbl_GiaTien);
            this.grb_ThongTin.Controls.Add(this.lbl_LoaiPhong);
            this.grb_ThongTin.Location = new System.Drawing.Point(25, 37);
            this.grb_ThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.grb_ThongTin.Size = new System.Drawing.Size(912, 152);
            this.grb_ThongTin.TabIndex = 73;
            this.grb_ThongTin.TabStop = false;
            this.grb_ThongTin.Text = "Thông tin";
            // 
            // cb_TrangThai
            // 
            this.cb_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_TrangThai.FormattingEnabled = true;
            this.cb_TrangThai.Location = new System.Drawing.Point(628, 86);
            this.cb_TrangThai.Name = "cb_TrangThai";
            this.cb_TrangThai.Size = new System.Drawing.Size(247, 30);
            this.cb_TrangThai.TabIndex = 60;
            // 
            // txt_SoPhong
            // 
            this.txt_SoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoPhong.Location = new System.Drawing.Point(179, 28);
            this.txt_SoPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoPhong.Name = "txt_SoPhong";
            this.txt_SoPhong.Size = new System.Drawing.Size(247, 29);
            this.txt_SoPhong.TabIndex = 1;
            // 
            // lbl_SoPhong
            // 
            this.lbl_SoPhong.AutoSize = true;
            this.lbl_SoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_SoPhong.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_SoPhong.Location = new System.Drawing.Point(27, 32);
            this.lbl_SoPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoPhong.Name = "lbl_SoPhong";
            this.lbl_SoPhong.Size = new System.Drawing.Size(98, 24);
            this.lbl_SoPhong.TabIndex = 58;
            this.lbl_SoPhong.Text = "Số phòng:";
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_GiaTien.Location = new System.Drawing.Point(628, 28);
            this.txt_GiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.Size = new System.Drawing.Size(247, 29);
            this.txt_GiaTien.TabIndex = 3;
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TrangThai.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_TrangThai.Location = new System.Drawing.Point(476, 88);
            this.lbl_TrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(99, 24);
            this.lbl_TrangThai.TabIndex = 37;
            this.lbl_TrangThai.Text = "Trạng thái:";
            // 
            // lbl_GiaTien
            // 
            this.lbl_GiaTien.AutoSize = true;
            this.lbl_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_GiaTien.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_GiaTien.Location = new System.Drawing.Point(477, 32);
            this.lbl_GiaTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GiaTien.Name = "lbl_GiaTien";
            this.lbl_GiaTien.Size = new System.Drawing.Size(78, 24);
            this.lbl_GiaTien.TabIndex = 36;
            this.lbl_GiaTien.Text = "Giá tiền:";
            // 
            // lbl_LoaiPhong
            // 
            this.lbl_LoaiPhong.AutoSize = true;
            this.lbl_LoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_LoaiPhong.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_LoaiPhong.Location = new System.Drawing.Point(27, 88);
            this.lbl_LoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoaiPhong.Name = "lbl_LoaiPhong";
            this.lbl_LoaiPhong.Size = new System.Drawing.Size(110, 24);
            this.lbl_LoaiPhong.TabIndex = 35;
            this.lbl_LoaiPhong.Text = "Loại phòng:";
            // 
            // txt_Timkiem
            // 
            this.txt_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Timkiem.Location = new System.Drawing.Point(204, 202);
            this.txt_Timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Timkiem.Name = "txt_Timkiem";
            this.txt_Timkiem.Size = new System.Drawing.Size(247, 29);
            this.txt_Timkiem.TabIndex = 74;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TimKiem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_TimKiem.Location = new System.Drawing.Point(38, 206);
            this.lbl_TimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(87, 24);
            this.lbl_TimKiem.TabIndex = 79;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // dgv_DanhSachKhachHang
            // 
            this.dgv_DanhSachKhachHang.AllowUserToAddRows = false;
            this.dgv_DanhSachKhachHang.AllowUserToDeleteRows = false;
            this.dgv_DanhSachKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKhachHang.Location = new System.Drawing.Point(25, 260);
            this.dgv_DanhSachKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DanhSachKhachHang.MultiSelect = false;
            this.dgv_DanhSachKhachHang.Name = "dgv_DanhSachKhachHang";
            this.dgv_DanhSachKhachHang.ReadOnly = true;
            this.dgv_DanhSachKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachKhachHang.Size = new System.Drawing.Size(912, 294);
            this.dgv_DanhSachKhachHang.TabIndex = 78;
            // 
            // cb_LoaiPhong
            // 
            this.cb_LoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_LoaiPhong.FormattingEnabled = true;
            this.cb_LoaiPhong.Items.AddRange(new object[] {
            "Phòng đơn",
            "Phòng đôi"});
            this.cb_LoaiPhong.Location = new System.Drawing.Point(178, 88);
            this.cb_LoaiPhong.Name = "cb_LoaiPhong";
            this.cb_LoaiPhong.Size = new System.Drawing.Size(247, 30);
            this.cb_LoaiPhong.TabIndex = 59;
            // 
            // frm_DanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 567);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.grb_ThongTin);
            this.Controls.Add(this.txt_Timkiem);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.dgv_DanhSachKhachHang);
            this.Name = "frm_DanhSachPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phòng";
            this.Load += new System.EventHandler(this.DanhSachPhong_Load);
            this.grb_ThongTin.ResumeLayout(false);
            this.grb_ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.GroupBox grb_ThongTin;
        private System.Windows.Forms.TextBox txt_SoPhong;
        private System.Windows.Forms.Label lbl_SoPhong;
        private System.Windows.Forms.TextBox txt_GiaTien;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.Label lbl_GiaTien;
        private System.Windows.Forms.Label lbl_LoaiPhong;
        private System.Windows.Forms.TextBox txt_Timkiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.DataGridView dgv_DanhSachKhachHang;
        private System.Windows.Forms.ComboBox cb_TrangThai;
        private System.Windows.Forms.ComboBox cb_LoaiPhong;
    }
}