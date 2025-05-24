namespace HomePage
{
    partial class frm_ThongTinDatPhong
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
            this.btn_checkOut = new System.Windows.Forms.Button();
            this.btn_quayVe = new System.Windows.Forms.Button();
            this.lb_hienThiChu = new System.Windows.Forms.Label();
            this.grb_ThongTinDP = new System.Windows.Forms.GroupBox();
            this.combo_tenPhong = new System.Windows.Forms.ComboBox();
            this.txt_tienCoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combo_loaiPhong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_maPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_checkOut = new System.Windows.Forms.DateTimePicker();
            this.date_checkIn = new System.Windows.Forms.DateTimePicker();
            this.txt_maDatPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.lbl_CCCD = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_hienThiPhong = new System.Windows.Forms.Label();
            this.lbl_QuanLyKhachHang = new System.Windows.Forms.Label();
            this.lbl_TenKhachHang = new System.Windows.Forms.Label();
            this.grb_ThongTinKH = new System.Windows.Forms.GroupBox();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.btn_dichVu = new System.Windows.Forms.Button();
            this.dgv_dichVuDat = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_tienPhong = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_tienDV = new System.Windows.Forms.Label();
            this.lb_tienTT = new System.Windows.Forms.Label();
            this.lb_tienCoc = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grb_ThongTinDP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grb_ThongTinKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichVuDat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_checkOut
            // 
            this.btn_checkOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_checkOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkOut.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkOut.ForeColor = System.Drawing.Color.White;
            this.btn_checkOut.Location = new System.Drawing.Point(1090, 651);
            this.btn_checkOut.Margin = new System.Windows.Forms.Padding(4);
            this.btn_checkOut.Name = "btn_checkOut";
            this.btn_checkOut.Size = new System.Drawing.Size(154, 51);
            this.btn_checkOut.TabIndex = 82;
            this.btn_checkOut.Text = "CHECK OUT";
            this.btn_checkOut.UseVisualStyleBackColor = false;
            // 
            // btn_quayVe
            // 
            this.btn_quayVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_quayVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quayVe.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quayVe.ForeColor = System.Drawing.Color.White;
            this.btn_quayVe.Location = new System.Drawing.Point(879, 651);
            this.btn_quayVe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quayVe.Name = "btn_quayVe";
            this.btn_quayVe.Size = new System.Drawing.Size(154, 51);
            this.btn_quayVe.TabIndex = 83;
            this.btn_quayVe.Text = "QUAY VỀ";
            this.btn_quayVe.UseVisualStyleBackColor = false;
            this.btn_quayVe.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // lb_hienThiChu
            // 
            this.lb_hienThiChu.AutoSize = true;
            this.lb_hienThiChu.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hienThiChu.ForeColor = System.Drawing.Color.Red;
            this.lb_hienThiChu.Location = new System.Drawing.Point(539, 230);
            this.lb_hienThiChu.Name = "lb_hienThiChu";
            this.lb_hienThiChu.Size = new System.Drawing.Size(0, 21);
            this.lb_hienThiChu.TabIndex = 75;
            // 
            // grb_ThongTinDP
            // 
            this.grb_ThongTinDP.Controls.Add(this.lb_hienThiChu);
            this.grb_ThongTinDP.Controls.Add(this.combo_tenPhong);
            this.grb_ThongTinDP.Controls.Add(this.txt_tienCoc);
            this.grb_ThongTinDP.Controls.Add(this.label9);
            this.grb_ThongTinDP.Controls.Add(this.combo_loaiPhong);
            this.grb_ThongTinDP.Controls.Add(this.label7);
            this.grb_ThongTinDP.Controls.Add(this.txt_maPhong);
            this.grb_ThongTinDP.Controls.Add(this.label6);
            this.grb_ThongTinDP.Controls.Add(this.label4);
            this.grb_ThongTinDP.Controls.Add(this.date_checkOut);
            this.grb_ThongTinDP.Controls.Add(this.date_checkIn);
            this.grb_ThongTinDP.Controls.Add(this.txt_maDatPhong);
            this.grb_ThongTinDP.Controls.Add(this.label2);
            this.grb_ThongTinDP.Controls.Add(this.label3);
            this.grb_ThongTinDP.Controls.Add(this.label5);
            this.grb_ThongTinDP.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ThongTinDP.Location = new System.Drawing.Point(22, 312);
            this.grb_ThongTinDP.Margin = new System.Windows.Forms.Padding(4);
            this.grb_ThongTinDP.Name = "grb_ThongTinDP";
            this.grb_ThongTinDP.Padding = new System.Windows.Forms.Padding(4);
            this.grb_ThongTinDP.Size = new System.Drawing.Size(507, 301);
            this.grb_ThongTinDP.TabIndex = 81;
            this.grb_ThongTinDP.TabStop = false;
            this.grb_ThongTinDP.Text = "Thông tin đặt phòng";
            // 
            // combo_tenPhong
            // 
            this.combo_tenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_tenPhong.FormattingEnabled = true;
            this.combo_tenPhong.Location = new System.Drawing.Point(193, 109);
            this.combo_tenPhong.Name = "combo_tenPhong";
            this.combo_tenPhong.Size = new System.Drawing.Size(289, 30);
            this.combo_tenPhong.TabIndex = 74;
            // 
            // txt_tienCoc
            // 
            this.txt_tienCoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tienCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tienCoc.Location = new System.Drawing.Point(193, 182);
            this.txt_tienCoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tienCoc.Name = "txt_tienCoc";
            this.txt_tienCoc.ReadOnly = true;
            this.txt_tienCoc.Size = new System.Drawing.Size(289, 29);
            this.txt_tienCoc.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(28, 186);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 73;
            this.label9.Text = "Tiền cọc:";
            // 
            // combo_loaiPhong
            // 
            this.combo_loaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_loaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_loaiPhong.FormattingEnabled = true;
            this.combo_loaiPhong.Location = new System.Drawing.Point(193, 145);
            this.combo_loaiPhong.Name = "combo_loaiPhong";
            this.combo_loaiPhong.Size = new System.Drawing.Size(289, 30);
            this.combo_loaiPhong.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(28, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 68;
            this.label7.Text = "Loại phòng:";
            // 
            // txt_maPhong
            // 
            this.txt_maPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_maPhong.Location = new System.Drawing.Point(193, 73);
            this.txt_maPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maPhong.Name = "txt_maPhong";
            this.txt_maPhong.ReadOnly = true;
            this.txt_maPhong.Size = new System.Drawing.Size(289, 29);
            this.txt_maPhong.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(28, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 66;
            this.label6.Text = "Mã phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(28, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "Tên phòng:";
            // 
            // date_checkOut
            // 
            this.date_checkOut.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.date_checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_checkOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_checkOut.Location = new System.Drawing.Point(192, 256);
            this.date_checkOut.Name = "date_checkOut";
            this.date_checkOut.Size = new System.Drawing.Size(290, 28);
            this.date_checkOut.TabIndex = 62;
            this.date_checkOut.Value = new System.DateTime(2025, 5, 21, 14, 0, 0, 0);
            // 
            // date_checkIn
            // 
            this.date_checkIn.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.date_checkIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_checkIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_checkIn.Location = new System.Drawing.Point(192, 220);
            this.date_checkIn.Name = "date_checkIn";
            this.date_checkIn.Size = new System.Drawing.Size(290, 28);
            this.date_checkIn.TabIndex = 61;
            this.date_checkIn.Value = new System.DateTime(2025, 5, 21, 2, 0, 0, 0);
            // 
            // txt_maDatPhong
            // 
            this.txt_maDatPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_maDatPhong.Location = new System.Drawing.Point(193, 36);
            this.txt_maDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maDatPhong.Name = "txt_maDatPhong";
            this.txt_maDatPhong.ReadOnly = true;
            this.txt_maDatPhong.Size = new System.Drawing.Size(289, 29);
            this.txt_maDatPhong.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Mã đặt phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(28, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "Ngày Check-In:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(28, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ngày Check-Out:";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(193, 146);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.ReadOnly = true;
            this.txt_SoDienThoai.Size = new System.Drawing.Size(289, 29);
            this.txt_SoDienThoai.TabIndex = 3;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_CCCD.Location = new System.Drawing.Point(193, 109);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.ReadOnly = true;
            this.txt_CCCD.Size = new System.Drawing.Size(289, 29);
            this.txt_CCCD.TabIndex = 2;
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_SoDienThoai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(31, 150);
            this.lbl_SoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(120, 21);
            this.lbl_SoDienThoai.TabIndex = 36;
            this.lbl_SoDienThoai.Text = "Số điện thoại:";
            // 
            // lbl_CCCD
            // 
            this.lbl_CCCD.AutoSize = true;
            this.lbl_CCCD.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_CCCD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_CCCD.Location = new System.Drawing.Point(31, 113);
            this.lbl_CCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CCCD.Name = "lbl_CCCD";
            this.lbl_CCCD.Size = new System.Drawing.Size(143, 21);
            this.lbl_CCCD.TabIndex = 35;
            this.lbl_CCCD.Text = "CCCD/Passport:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.lb_hienThiPhong);
            this.panel1.Controls.Add(this.lbl_QuanLyKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 79);
            this.panel1.TabIndex = 79;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_hienThiPhong
            // 
            this.lb_hienThiPhong.AutoSize = true;
            this.lb_hienThiPhong.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hienThiPhong.ForeColor = System.Drawing.Color.Lime;
            this.lb_hienThiPhong.Location = new System.Drawing.Point(164, 23);
            this.lb_hienThiPhong.Name = "lb_hienThiPhong";
            this.lb_hienThiPhong.Size = new System.Drawing.Size(0, 33);
            this.lb_hienThiPhong.TabIndex = 1;
            // 
            // lbl_QuanLyKhachHang
            // 
            this.lbl_QuanLyKhachHang.AutoSize = true;
            this.lbl_QuanLyKhachHang.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuanLyKhachHang.ForeColor = System.Drawing.Color.White;
            this.lbl_QuanLyKhachHang.Location = new System.Drawing.Point(16, 23);
            this.lbl_QuanLyKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QuanLyKhachHang.Name = "lbl_QuanLyKhachHang";
            this.lbl_QuanLyKhachHang.Size = new System.Drawing.Size(117, 33);
            this.lbl_QuanLyKhachHang.TabIndex = 0;
            this.lbl_QuanLyKhachHang.Text = "PHÒNG";
            // 
            // lbl_TenKhachHang
            // 
            this.lbl_TenKhachHang.AutoSize = true;
            this.lbl_TenKhachHang.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenKhachHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TenKhachHang.Location = new System.Drawing.Point(31, 76);
            this.lbl_TenKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenKhachHang.Name = "lbl_TenKhachHang";
            this.lbl_TenKhachHang.Size = new System.Drawing.Size(145, 21);
            this.lbl_TenKhachHang.TabIndex = 58;
            this.lbl_TenKhachHang.Text = "Tên khách hàng:";
            // 
            // grb_ThongTinKH
            // 
            this.grb_ThongTinKH.Controls.Add(this.txt_maKH);
            this.grb_ThongTinKH.Controls.Add(this.label1);
            this.grb_ThongTinKH.Controls.Add(this.txt_TenKhachHang);
            this.grb_ThongTinKH.Controls.Add(this.lbl_TenKhachHang);
            this.grb_ThongTinKH.Controls.Add(this.txt_SoDienThoai);
            this.grb_ThongTinKH.Controls.Add(this.txt_CCCD);
            this.grb_ThongTinKH.Controls.Add(this.lbl_SoDienThoai);
            this.grb_ThongTinKH.Controls.Add(this.lbl_CCCD);
            this.grb_ThongTinKH.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ThongTinKH.Location = new System.Drawing.Point(22, 107);
            this.grb_ThongTinKH.Margin = new System.Windows.Forms.Padding(4);
            this.grb_ThongTinKH.Name = "grb_ThongTinKH";
            this.grb_ThongTinKH.Padding = new System.Windows.Forms.Padding(4);
            this.grb_ThongTinKH.Size = new System.Drawing.Size(507, 197);
            this.grb_ThongTinKH.TabIndex = 80;
            this.grb_ThongTinKH.TabStop = false;
            this.grb_ThongTinKH.Text = "Thông tin khách hàng";
            // 
            // txt_maKH
            // 
            this.txt_maKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_maKH.Location = new System.Drawing.Point(193, 35);
            this.txt_maKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.ReadOnly = true;
            this.txt_maKH.Size = new System.Drawing.Size(289, 29);
            this.txt_maKH.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Mã khách hàng:";
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenKhachHang.Location = new System.Drawing.Point(193, 72);
            this.txt_TenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.ReadOnly = true;
            this.txt_TenKhachHang.Size = new System.Drawing.Size(289, 29);
            this.txt_TenKhachHang.TabIndex = 1;
            // 
            // btn_dichVu
            // 
            this.btn_dichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_dichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dichVu.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dichVu.ForeColor = System.Drawing.Color.White;
            this.btn_dichVu.Location = new System.Drawing.Point(616, 107);
            this.btn_dichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dichVu.Name = "btn_dichVu";
            this.btn_dichVu.Size = new System.Drawing.Size(154, 51);
            this.btn_dichVu.TabIndex = 84;
            this.btn_dichVu.Text = "DỊCH VỤ";
            this.btn_dichVu.UseVisualStyleBackColor = false;
            this.btn_dichVu.Click += new System.EventHandler(this.btn_dichVu_Click);
            // 
            // dgv_dichVuDat
            // 
            this.dgv_dichVuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dichVuDat.Location = new System.Drawing.Point(616, 183);
            this.dgv_dichVuDat.Name = "dgv_dichVuDat";
            this.dgv_dichVuDat.RowHeadersWidth = 51;
            this.dgv_dichVuDat.RowTemplate.Height = 24;
            this.dgv_dichVuDat.Size = new System.Drawing.Size(628, 243);
            this.dgv_dichVuDat.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(613, 457);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 21);
            this.label8.TabIndex = 77;
            this.label8.Text = "Tiền phòng: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(613, 497);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 21);
            this.label10.TabIndex = 87;
            this.label10.Text = "Tổng tiền dịch vụ:";
            // 
            // lb_tienPhong
            // 
            this.lb_tienPhong.AutoSize = true;
            this.lb_tienPhong.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tienPhong.Location = new System.Drawing.Point(1154, 457);
            this.lb_tienPhong.Name = "lb_tienPhong";
            this.lb_tienPhong.Size = new System.Drawing.Size(80, 21);
            this.lb_tienPhong.TabIndex = 88;
            this.lb_tienPhong.Text = "1500000";
            this.lb_tienPhong.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(613, 535);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 21);
            this.label11.TabIndex = 89;
            this.label11.Text = "Tiền cọc: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(613, 575);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 21);
            this.label12.TabIndex = 90;
            this.label12.Text = "Tổng tiền cần thanh toán:";
            // 
            // lb_tienDV
            // 
            this.lb_tienDV.AutoSize = true;
            this.lb_tienDV.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tienDV.Location = new System.Drawing.Point(1164, 495);
            this.lb_tienDV.Name = "lb_tienDV";
            this.lb_tienDV.Size = new System.Drawing.Size(70, 21);
            this.lb_tienDV.TabIndex = 91;
            this.lb_tienDV.Text = "250000";
            this.lb_tienDV.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_tienTT
            // 
            this.lb_tienTT.AutoSize = true;
            this.lb_tienTT.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tienTT.ForeColor = System.Drawing.Color.Red;
            this.lb_tienTT.Location = new System.Drawing.Point(1154, 568);
            this.lb_tienTT.Name = "lb_tienTT";
            this.lb_tienTT.Size = new System.Drawing.Size(80, 21);
            this.lb_tienTT.TabIndex = 93;
            this.lb_tienTT.Text = "1250000";
            this.lb_tienTT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_tienCoc
            // 
            this.lb_tienCoc.AutoSize = true;
            this.lb_tienCoc.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tienCoc.Location = new System.Drawing.Point(1164, 536);
            this.lb_tienCoc.Name = "lb_tienCoc";
            this.lb_tienCoc.Size = new System.Drawing.Size(0, 21);
            this.lb_tienCoc.TabIndex = 92;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1164, 532);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 21);
            this.label13.TabIndex = 94;
            this.label13.Text = "500000";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frm_ThongTinDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 733);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lb_tienTT);
            this.Controls.Add(this.lb_tienCoc);
            this.Controls.Add(this.lb_tienDV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_tienPhong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_dichVuDat);
            this.Controls.Add(this.btn_dichVu);
            this.Controls.Add(this.btn_checkOut);
            this.Controls.Add(this.btn_quayVe);
            this.Controls.Add(this.grb_ThongTinDP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grb_ThongTinKH);
            this.Name = "frm_ThongTinDatPhong";
            this.Text = "DỊCH VỤ";
            this.Load += new System.EventHandler(this.frm_ThongTinDatPhong_Load);
            this.grb_ThongTinDP.ResumeLayout(false);
            this.grb_ThongTinDP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grb_ThongTinKH.ResumeLayout(false);
            this.grb_ThongTinKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichVuDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_checkOut;
        private System.Windows.Forms.Button btn_quayVe;
        private System.Windows.Forms.Label lb_hienThiChu;
        private System.Windows.Forms.GroupBox grb_ThongTinDP;
        private System.Windows.Forms.ComboBox combo_tenPhong;
        private System.Windows.Forms.TextBox txt_tienCoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combo_loaiPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_maPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_checkOut;
        private System.Windows.Forms.DateTimePicker date_checkIn;
        private System.Windows.Forms.TextBox txt_maDatPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label lbl_CCCD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_hienThiPhong;
        private System.Windows.Forms.Label lbl_QuanLyKhachHang;
        private System.Windows.Forms.Label lbl_TenKhachHang;
        private System.Windows.Forms.GroupBox grb_ThongTinKH;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.Button btn_dichVu;
        private System.Windows.Forms.DataGridView dgv_dichVuDat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_tienPhong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_tienDV;
        private System.Windows.Forms.Label lb_tienTT;
        private System.Windows.Forms.Label lb_tienCoc;
        private System.Windows.Forms.Label label13;
    }
}