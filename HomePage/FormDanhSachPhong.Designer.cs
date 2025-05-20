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
            this.btn_Tim = new System.Windows.Forms.Button();
            this.pn_QuanLyPhong = new System.Windows.Forms.Panel();
            this.lbl_QuanLyKhachHang = new System.Windows.Forms.Label();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.dgv_DanhSachPhong = new System.Windows.Forms.DataGridView();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.lbl_MaPhong = new System.Windows.Forms.Label();
            this.txt_GiaTien = new System.Windows.Forms.TextBox();
            this.txt_Timkiem = new System.Windows.Forms.TextBox();
            this.txt_SoPhong = new System.Windows.Forms.TextBox();
            this.lbl_LoaiPhong = new System.Windows.Forms.Label();
            this.lbl_SoPhong = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.grb_ThongTin = new System.Windows.Forms.GroupBox();
            this.cb_TrangThai = new System.Windows.Forms.ComboBox();
            this.cb_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.lbl_GiaTien = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.pn_QuanLyPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhong)).BeginInit();
            this.grb_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Tim.ForeColor = System.Drawing.Color.White;
            this.btn_Tim.Location = new System.Drawing.Point(482, 363);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(76, 29);
            this.btn_Tim.TabIndex = 83;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // pn_QuanLyPhong
            // 
            this.pn_QuanLyPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pn_QuanLyPhong.Controls.Add(this.lbl_QuanLyKhachHang);
            this.pn_QuanLyPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_QuanLyPhong.Location = new System.Drawing.Point(0, 0);
            this.pn_QuanLyPhong.Margin = new System.Windows.Forms.Padding(4);
            this.pn_QuanLyPhong.Name = "pn_QuanLyPhong";
            this.pn_QuanLyPhong.Size = new System.Drawing.Size(1312, 74);
            this.pn_QuanLyPhong.TabIndex = 82;
            // 
            // lbl_QuanLyKhachHang
            // 
            this.lbl_QuanLyKhachHang.AutoSize = true;
            this.lbl_QuanLyKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuanLyKhachHang.ForeColor = System.Drawing.Color.White;
            this.lbl_QuanLyKhachHang.Location = new System.Drawing.Point(16, 22);
            this.lbl_QuanLyKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QuanLyKhachHang.Name = "lbl_QuanLyKhachHang";
            this.lbl_QuanLyKhachHang.Size = new System.Drawing.Size(253, 31);
            this.lbl_QuanLyKhachHang.TabIndex = 0;
            this.lbl_QuanLyKhachHang.Text = "QUẢN LÝ PHÒNG";
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TimKiem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_TimKiem.Location = new System.Drawing.Point(101, 363);
            this.lbl_TimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(92, 24);
            this.lbl_TimKiem.TabIndex = 81;
            this.lbl_TimKiem.Text = "Tìm kiếm:";
            // 
            // dgv_DanhSachPhong
            // 
            this.dgv_DanhSachPhong.AllowUserToAddRows = false;
            this.dgv_DanhSachPhong.AllowUserToDeleteRows = false;
            this.dgv_DanhSachPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachPhong.Location = new System.Drawing.Point(75, 428);
            this.dgv_DanhSachPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DanhSachPhong.MultiSelect = false;
            this.dgv_DanhSachPhong.Name = "dgv_DanhSachPhong";
            this.dgv_DanhSachPhong.ReadOnly = true;
            this.dgv_DanhSachPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachPhong.Size = new System.Drawing.Size(1153, 295);
            this.dgv_DanhSachPhong.TabIndex = 80;
            this.dgv_DanhSachPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachPhong_CellClick);
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaPhong.Location = new System.Drawing.Point(222, 28);
            this.txt_MaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.ReadOnly = true;
            this.txt_MaPhong.Size = new System.Drawing.Size(289, 29);
            this.txt_MaPhong.TabIndex = 1;
            // 
            // lbl_MaPhong
            // 
            this.lbl_MaPhong.AutoSize = true;
            this.lbl_MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaPhong.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_MaPhong.Location = new System.Drawing.Point(56, 32);
            this.lbl_MaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaPhong.Name = "lbl_MaPhong";
            this.lbl_MaPhong.Size = new System.Drawing.Size(101, 24);
            this.lbl_MaPhong.TabIndex = 58;
            this.lbl_MaPhong.Text = "Mã phòng:";
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_GiaTien.Location = new System.Drawing.Point(818, 32);
            this.txt_GiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.Size = new System.Drawing.Size(289, 29);
            this.txt_GiaTien.TabIndex = 4;
            // 
            // txt_Timkiem
            // 
            this.txt_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Timkiem.Location = new System.Drawing.Point(214, 363);
            this.txt_Timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Timkiem.Name = "txt_Timkiem";
            this.txt_Timkiem.Size = new System.Drawing.Size(247, 29);
            this.txt_Timkiem.TabIndex = 76;
            // 
            // txt_SoPhong
            // 
            this.txt_SoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoPhong.Location = new System.Drawing.Point(222, 98);
            this.txt_SoPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoPhong.Name = "txt_SoPhong";
            this.txt_SoPhong.Size = new System.Drawing.Size(289, 29);
            this.txt_SoPhong.TabIndex = 2;
            // 
            // lbl_LoaiPhong
            // 
            this.lbl_LoaiPhong.AutoSize = true;
            this.lbl_LoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_LoaiPhong.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_LoaiPhong.Location = new System.Drawing.Point(57, 173);
            this.lbl_LoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoaiPhong.Name = "lbl_LoaiPhong";
            this.lbl_LoaiPhong.Size = new System.Drawing.Size(110, 24);
            this.lbl_LoaiPhong.TabIndex = 36;
            this.lbl_LoaiPhong.Text = "Loại phòng:";
            // 
            // lbl_SoPhong
            // 
            this.lbl_SoPhong.AutoSize = true;
            this.lbl_SoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_SoPhong.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_SoPhong.Location = new System.Drawing.Point(57, 98);
            this.lbl_SoPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoPhong.Name = "lbl_SoPhong";
            this.lbl_SoPhong.Size = new System.Drawing.Size(98, 24);
            this.lbl_SoPhong.TabIndex = 35;
            this.lbl_SoPhong.Text = "Số phòng:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(1028, 355);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(154, 48);
            this.btn_Xoa.TabIndex = 79;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(813, 354);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(154, 48);
            this.btn_Sua.TabIndex = 78;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Controls.Add(this.cb_TrangThai);
            this.grb_ThongTin.Controls.Add(this.cb_LoaiPhong);
            this.grb_ThongTin.Controls.Add(this.lbl_TrangThai);
            this.grb_ThongTin.Controls.Add(this.txt_MaPhong);
            this.grb_ThongTin.Controls.Add(this.lbl_MaPhong);
            this.grb_ThongTin.Controls.Add(this.txt_GiaTien);
            this.grb_ThongTin.Controls.Add(this.txt_SoPhong);
            this.grb_ThongTin.Controls.Add(this.lbl_GiaTien);
            this.grb_ThongTin.Controls.Add(this.lbl_LoaiPhong);
            this.grb_ThongTin.Controls.Add(this.lbl_SoPhong);
            this.grb_ThongTin.Location = new System.Drawing.Point(75, 106);
            this.grb_ThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.grb_ThongTin.Size = new System.Drawing.Size(1153, 223);
            this.grb_ThongTin.TabIndex = 75;
            this.grb_ThongTin.TabStop = false;
            this.grb_ThongTin.Text = "Thông tin";
            // 
            // cb_TrangThai
            // 
            this.cb_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_TrangThai.FormattingEnabled = true;
            this.cb_TrangThai.Items.AddRange(new object[] {
            "Còn trống",
            "Đã đặt"});
            this.cb_TrangThai.Location = new System.Drawing.Point(818, 99);
            this.cb_TrangThai.Name = "cb_TrangThai";
            this.cb_TrangThai.Size = new System.Drawing.Size(289, 30);
            this.cb_TrangThai.TabIndex = 62;
            // 
            // cb_LoaiPhong
            // 
            this.cb_LoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_LoaiPhong.FormattingEnabled = true;
            this.cb_LoaiPhong.Items.AddRange(new object[] {
            "Phòng đơn",
            "Phòng đôi",
            "Phòng gia đình"});
            this.cb_LoaiPhong.Location = new System.Drawing.Point(222, 173);
            this.cb_LoaiPhong.Name = "cb_LoaiPhong";
            this.cb_LoaiPhong.Size = new System.Drawing.Size(289, 30);
            this.cb_LoaiPhong.TabIndex = 61;
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TrangThai.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_TrangThai.Location = new System.Drawing.Point(659, 105);
            this.lbl_TrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(99, 24);
            this.lbl_TrangThai.TabIndex = 60;
            this.lbl_TrangThai.Text = "Trạng thái:";
            this.lbl_TrangThai.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_GiaTien
            // 
            this.lbl_GiaTien.AutoSize = true;
            this.lbl_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_GiaTien.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_GiaTien.Location = new System.Drawing.Point(659, 35);
            this.lbl_GiaTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GiaTien.Name = "lbl_GiaTien";
            this.lbl_GiaTien.Size = new System.Drawing.Size(78, 24);
            this.lbl_GiaTien.TabIndex = 37;
            this.lbl_GiaTien.Text = "Giá tiền:";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(598, 354);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(154, 48);
            this.btn_Them.TabIndex = 77;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frm_DanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.pn_QuanLyPhong);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.dgv_DanhSachPhong);
            this.Controls.Add(this.txt_Timkiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.grb_ThongTin);
            this.Controls.Add(this.btn_Them);
            this.Name = "frm_DanhSachPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phòng";
            this.Load += new System.EventHandler(this.DanhSachPhong_Load);
            this.pn_QuanLyPhong.ResumeLayout(false);
            this.pn_QuanLyPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhong)).EndInit();
            this.grb_ThongTin.ResumeLayout(false);
            this.grb_ThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Panel pn_QuanLyPhong;
        private System.Windows.Forms.Label lbl_QuanLyKhachHang;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.DataGridView dgv_DanhSachPhong;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.Label lbl_MaPhong;
        private System.Windows.Forms.TextBox txt_GiaTien;
        private System.Windows.Forms.TextBox txt_Timkiem;
        private System.Windows.Forms.TextBox txt_SoPhong;
        private System.Windows.Forms.Label lbl_LoaiPhong;
        private System.Windows.Forms.Label lbl_SoPhong;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.GroupBox grb_ThongTin;
        private System.Windows.Forms.Label lbl_GiaTien;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.ComboBox cb_TrangThai;
        private System.Windows.Forms.ComboBox cb_LoaiPhong;
    }
}