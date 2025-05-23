namespace HomePage
{
    partial class frm_BookingService
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_KhachHang = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Phong = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.lbl_Tong = new System.Windows.Forms.Label();
            this.lbl_MaDatPhong = new System.Windows.Forms.Label();
            this.cb_DichVu = new System.Windows.Forms.ComboBox();
            this.num_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.btn_ThemDichVu = new System.Windows.Forms.Button();
            this.btn_XoaDichVu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            this.btn_HuyDatDichVu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dịch vụ phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đặt phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khách hàng: ";
            // 
            // lbl_KhachHang
            // 
            this.lbl_KhachHang.AutoSize = true;
            this.lbl_KhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_KhachHang.Location = new System.Drawing.Point(147, 127);
            this.lbl_KhachHang.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_KhachHang.Name = "lbl_KhachHang";
            this.lbl_KhachHang.Size = new System.Drawing.Size(55, 23);
            this.lbl_KhachHang.TabIndex = 4;
            this.lbl_KhachHang.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(353, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phòng:";
            // 
            // lbl_Phong
            // 
            this.lbl_Phong.AutoSize = true;
            this.lbl_Phong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Phong.Location = new System.Drawing.Point(442, 127);
            this.lbl_Phong.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Phong.Name = "lbl_Phong";
            this.lbl_Phong.Size = new System.Drawing.Size(55, 23);
            this.lbl_Phong.TabIndex = 6;
            this.lbl_Phong.Text = "label7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(25, 270);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Dịch vụ: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(25, 310);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Đơn giá:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(356, 270);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Số lượng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(356, 310);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tổng:";
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_DonGia.Location = new System.Drawing.Point(121, 310);
            this.lbl_DonGia.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(64, 23);
            this.lbl_DonGia.TabIndex = 13;
            this.lbl_DonGia.Text = "label13";
            // 
            // lbl_Tong
            // 
            this.lbl_Tong.AutoSize = true;
            this.lbl_Tong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Tong.Location = new System.Drawing.Point(464, 310);
            this.lbl_Tong.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Tong.Name = "lbl_Tong";
            this.lbl_Tong.Size = new System.Drawing.Size(64, 23);
            this.lbl_Tong.TabIndex = 17;
            this.lbl_Tong.Text = "label17";
            // 
            // lbl_MaDatPhong
            // 
            this.lbl_MaDatPhong.AutoSize = true;
            this.lbl_MaDatPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_MaDatPhong.Location = new System.Drawing.Point(147, 84);
            this.lbl_MaDatPhong.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_MaDatPhong.Name = "lbl_MaDatPhong";
            this.lbl_MaDatPhong.Size = new System.Drawing.Size(55, 23);
            this.lbl_MaDatPhong.TabIndex = 2;
            this.lbl_MaDatPhong.Text = "label3";
            // 
            // cb_DichVu
            // 
            this.cb_DichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_DichVu.FormattingEnabled = true;
            this.cb_DichVu.Location = new System.Drawing.Point(122, 270);
            this.cb_DichVu.Name = "cb_DichVu";
            this.cb_DichVu.Size = new System.Drawing.Size(121, 28);
            this.cb_DichVu.TabIndex = 18;
            this.cb_DichVu.SelectedIndexChanged += new System.EventHandler(this.cb_DichVu_SelectedIndexChanged);
            // 
            // num_SoLuong
            // 
            this.num_SoLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num_SoLuong.Location = new System.Drawing.Point(468, 267);
            this.num_SoLuong.Name = "num_SoLuong";
            this.num_SoLuong.Size = new System.Drawing.Size(60, 27);
            this.num_SoLuong.TabIndex = 19;
            this.num_SoLuong.ValueChanged += new System.EventHandler(this.num_SoLuong_ValueChanged);
            // 
            // btn_ThemDichVu
            // 
            this.btn_ThemDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_ThemDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemDichVu.ForeColor = System.Drawing.Color.White;
            this.btn_ThemDichVu.Location = new System.Drawing.Point(28, 355);
            this.btn_ThemDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemDichVu.Name = "btn_ThemDichVu";
            this.btn_ThemDichVu.Size = new System.Drawing.Size(152, 33);
            this.btn_ThemDichVu.TabIndex = 20;
            this.btn_ThemDichVu.Text = "Thêm dịch vụ";
            this.btn_ThemDichVu.UseVisualStyleBackColor = false;
            this.btn_ThemDichVu.Click += new System.EventHandler(this.btn_ThemDichVu_Click);
            // 
            // btn_XoaDichVu
            // 
            this.btn_XoaDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_XoaDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XoaDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaDichVu.ForeColor = System.Drawing.Color.White;
            this.btn_XoaDichVu.Location = new System.Drawing.Point(376, 355);
            this.btn_XoaDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaDichVu.Name = "btn_XoaDichVu";
            this.btn_XoaDichVu.Size = new System.Drawing.Size(152, 33);
            this.btn_XoaDichVu.TabIndex = 22;
            this.btn_XoaDichVu.Text = "Xóa dịch vụ";
            this.btn_XoaDichVu.UseVisualStyleBackColor = false;
            this.btn_XoaDichVu.Click += new System.EventHandler(this.btn_XoaDichVu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(237, 355);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(89, 33);
            this.btn_Sua.TabIndex = 21;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ThemDichVu);
            this.groupBox2.Controls.Add(this.lbl_TongTien);
            this.groupBox2.Controls.Add(this.btn_XoaDichVu);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.num_SoLuong);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.cb_DichVu);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl_Tong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbl_DonGia);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.Location = new System.Drawing.Point(17, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 426);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách dịch vụ đã chọn";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_TongTien.Location = new System.Drawing.Point(464, 225);
            this.lbl_TongTien.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(64, 23);
            this.lbl_TongTien.TabIndex = 15;
            this.lbl_TongTien.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(25, 225);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 23);
            this.label16.TabIndex = 8;
            this.label16.Text = "Tổng tiền dịch vụ:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(499, 165);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HoanTat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_HoanTat.Location = new System.Drawing.Point(439, 626);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(121, 35);
            this.btn_HoanTat.TabIndex = 8;
            this.btn_HoanTat.Text = "Hoàn tất";
            this.btn_HoanTat.UseVisualStyleBackColor = true;
            // 
            // btn_HuyDatDichVu
            // 
            this.btn_HuyDatDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HuyDatDichVu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_HuyDatDichVu.Location = new System.Drawing.Point(254, 626);
            this.btn_HuyDatDichVu.Name = "btn_HuyDatDichVu";
            this.btn_HuyDatDichVu.Size = new System.Drawing.Size(165, 35);
            this.btn_HuyDatDichVu.TabIndex = 9;
            this.btn_HuyDatDichVu.Text = "Hủy đặt dịch vụ";
            this.btn_HuyDatDichVu.UseVisualStyleBackColor = true;
            // 
            // frm_BookingService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 682);
            this.Controls.Add(this.btn_HuyDatDichVu);
            this.Controls.Add(this.btn_HoanTat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_Phong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_KhachHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_MaDatPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_BookingService";
            this.Text = "frm_BookingService";
            this.Load += new System.EventHandler(this.frm_BookingService_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_KhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Phong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.Label lbl_Tong;
        private System.Windows.Forms.Label lbl_MaDatPhong;
        private System.Windows.Forms.ComboBox cb_DichVu;
        private System.Windows.Forms.NumericUpDown num_SoLuong;
        private System.Windows.Forms.Button btn_ThemDichVu;
        private System.Windows.Forms.Button btn_XoaDichVu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_HoanTat;
        private System.Windows.Forms.Button btn_HuyDatDichVu;
    }
}