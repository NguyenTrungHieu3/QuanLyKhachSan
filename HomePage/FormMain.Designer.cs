﻿namespace HomePage
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.mc_NgayThang = new System.Windows.Forms.MonthCalendar();
            this.gb_ThongKe = new System.Windows.Forms.GroupBox();
            this.lbl_SoLuongPhongDaDat = new System.Windows.Forms.Label();
            this.lbl_SoLuongPhongTrong = new System.Windows.Forms.Label();
            this.lbl_SoPhongDaDat = new System.Windows.Forms.Label();
            this.lbl_SoPhongTrong = new System.Windows.Forms.Label();
            this.gb_MoTa = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_PhongDaDat = new System.Windows.Forms.Label();
            this.lbl_PhongTrong = new System.Windows.Forms.Label();
            this.ms_ChucNang = new System.Windows.Forms.MenuStrip();
            this.quảnLýPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_DanhSachPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_DichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.flp_SoDoPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_ThongKe.SuspendLayout();
            this.gb_MoTa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ms_ChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // mc_NgayThang
            // 
            this.mc_NgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mc_NgayThang.Location = new System.Drawing.Point(59, 79);
            this.mc_NgayThang.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.mc_NgayThang.MaximumSize = new System.Drawing.Size(500, 500);
            this.mc_NgayThang.Name = "mc_NgayThang";
            this.mc_NgayThang.TabIndex = 2;
            this.mc_NgayThang.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mc_NgayThang_DateChanged);
            // 
            // gb_ThongKe
            // 
            this.gb_ThongKe.Controls.Add(this.lbl_SoLuongPhongDaDat);
            this.gb_ThongKe.Controls.Add(this.lbl_SoLuongPhongTrong);
            this.gb_ThongKe.Controls.Add(this.lbl_SoPhongDaDat);
            this.gb_ThongKe.Controls.Add(this.lbl_SoPhongTrong);
            this.gb_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_ThongKe.Location = new System.Drawing.Point(23, 334);
            this.gb_ThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.gb_ThongKe.Name = "gb_ThongKe";
            this.gb_ThongKe.Padding = new System.Windows.Forms.Padding(4);
            this.gb_ThongKe.Size = new System.Drawing.Size(327, 190);
            this.gb_ThongKe.TabIndex = 3;
            this.gb_ThongKe.TabStop = false;
            this.gb_ThongKe.Text = " Thống kê ";
            // 
            // lbl_SoLuongPhongDaDat
            // 
            this.lbl_SoLuongPhongDaDat.AutoSize = true;
            this.lbl_SoLuongPhongDaDat.Location = new System.Drawing.Point(190, 123);
            this.lbl_SoLuongPhongDaDat.Name = "lbl_SoLuongPhongDaDat";
            this.lbl_SoLuongPhongDaDat.Size = new System.Drawing.Size(59, 20);
            this.lbl_SoLuongPhongDaDat.TabIndex = 3;
            this.lbl_SoLuongPhongDaDat.Text = "label1";
            // 
            // lbl_SoLuongPhongTrong
            // 
            this.lbl_SoLuongPhongTrong.AutoSize = true;
            this.lbl_SoLuongPhongTrong.Location = new System.Drawing.Point(190, 60);
            this.lbl_SoLuongPhongTrong.Name = "lbl_SoLuongPhongTrong";
            this.lbl_SoLuongPhongTrong.Size = new System.Drawing.Size(59, 20);
            this.lbl_SoLuongPhongTrong.TabIndex = 2;
            this.lbl_SoLuongPhongTrong.Text = "label1";
            // 
            // lbl_SoPhongDaDat
            // 
            this.lbl_SoPhongDaDat.AutoSize = true;
            this.lbl_SoPhongDaDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_SoPhongDaDat.Location = new System.Drawing.Point(34, 122);
            this.lbl_SoPhongDaDat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoPhongDaDat.Name = "lbl_SoPhongDaDat";
            this.lbl_SoPhongDaDat.Size = new System.Drawing.Size(151, 20);
            this.lbl_SoPhongDaDat.TabIndex = 1;
            this.lbl_SoPhongDaDat.Text = "Số phòng đã đặt:";
            // 
            // lbl_SoPhongTrong
            // 
            this.lbl_SoPhongTrong.AutoSize = true;
            this.lbl_SoPhongTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_SoPhongTrong.Location = new System.Drawing.Point(34, 59);
            this.lbl_SoPhongTrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoPhongTrong.Name = "lbl_SoPhongTrong";
            this.lbl_SoPhongTrong.Size = new System.Drawing.Size(142, 20);
            this.lbl_SoPhongTrong.TabIndex = 0;
            this.lbl_SoPhongTrong.Text = "Số phòng trống:";
            // 
            // gb_MoTa
            // 
            this.gb_MoTa.Controls.Add(this.pictureBox2);
            this.gb_MoTa.Controls.Add(this.pictureBox1);
            this.gb_MoTa.Controls.Add(this.lbl_PhongDaDat);
            this.gb_MoTa.Controls.Add(this.lbl_PhongTrong);
            this.gb_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_MoTa.Location = new System.Drawing.Point(23, 573);
            this.gb_MoTa.Margin = new System.Windows.Forms.Padding(4);
            this.gb_MoTa.Name = "gb_MoTa";
            this.gb_MoTa.Padding = new System.Windows.Forms.Padding(4);
            this.gb_MoTa.Size = new System.Drawing.Size(327, 164);
            this.gb_MoTa.TabIndex = 4;
            this.gb_MoTa.TabStop = false;
            this.gb_MoTa.Text = " Mô tả ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 43);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 43);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // lbl_PhongDaDat
            // 
            this.lbl_PhongDaDat.AutoSize = true;
            this.lbl_PhongDaDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_PhongDaDat.Location = new System.Drawing.Point(101, 116);
            this.lbl_PhongDaDat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PhongDaDat.Name = "lbl_PhongDaDat";
            this.lbl_PhongDaDat.Size = new System.Drawing.Size(119, 20);
            this.lbl_PhongDaDat.TabIndex = 11;
            this.lbl_PhongDaDat.Text = "Phòng đã đặt";
            // 
            // lbl_PhongTrong
            // 
            this.lbl_PhongTrong.AutoSize = true;
            this.lbl_PhongTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_PhongTrong.Location = new System.Drawing.Point(101, 49);
            this.lbl_PhongTrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PhongTrong.Name = "lbl_PhongTrong";
            this.lbl_PhongTrong.Size = new System.Drawing.Size(110, 20);
            this.lbl_PhongTrong.TabIndex = 0;
            this.lbl_PhongTrong.Text = "Phòng trống";
            // 
            // ms_ChucNang
            // 
            this.ms_ChucNang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ms_ChucNang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_ChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhòngToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.quảnLýDịchVụToolStripMenuItem});
            this.ms_ChucNang.Location = new System.Drawing.Point(0, 0);
            this.ms_ChucNang.Name = "ms_ChucNang";
            this.ms_ChucNang.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.ms_ChucNang.Size = new System.Drawing.Size(1345, 35);
            this.ms_ChucNang.TabIndex = 5;
            this.ms_ChucNang.Text = "menuStrip1";
            // 
            // quảnLýPhòngToolStripMenuItem
            // 
            this.quảnLýPhòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_DanhSachPhong,
            this.đặtToolStripMenuItem});
            this.quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
            this.quảnLýPhòngToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.quảnLýPhòngToolStripMenuItem.Text = "Quản lý phòng";
            // 
            // mi_DanhSachPhong
            // 
            this.mi_DanhSachPhong.Name = "mi_DanhSachPhong";
            this.mi_DanhSachPhong.Size = new System.Drawing.Size(240, 30);
            this.mi_DanhSachPhong.Text = "Danh sách phòng";
            this.mi_DanhSachPhong.Click += new System.EventHandler(this.mi_DanhSachPhong_Click);
            // 
            // đặtToolStripMenuItem
            // 
            this.đặtToolStripMenuItem.Name = "đặtToolStripMenuItem";
            this.đặtToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.đặtToolStripMenuItem.Text = "Đặt phòng";
            this.đặtToolStripMenuItem.Click += new System.EventHandler(this.đặtToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_KhachHang});
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(187, 29);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // mi_KhachHang
            // 
            this.mi_KhachHang.Name = "mi_KhachHang";
            this.mi_KhachHang.Size = new System.Drawing.Size(224, 30);
            this.mi_KhachHang.Text = "Khách hàng";
            this.mi_KhachHang.Click += new System.EventHandler(this.mi_KhachHang_Click);
            // 
            // quảnLýDịchVụToolStripMenuItem
            // 
            this.quảnLýDịchVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_DichVu});
            this.quảnLýDịchVụToolStripMenuItem.Name = "quảnLýDịchVụToolStripMenuItem";
            this.quảnLýDịchVụToolStripMenuItem.Size = new System.Drawing.Size(154, 29);
            this.quảnLýDịchVụToolStripMenuItem.Text = "Quản lý dịch vụ";
            this.quảnLýDịchVụToolStripMenuItem.Click += new System.EventHandler(this.quảnLýDịchVụToolStripMenuItem_Click);
            // 
            // mi_DichVu
            // 
            this.mi_DichVu.Name = "mi_DichVu";
            this.mi_DichVu.Size = new System.Drawing.Size(247, 30);
            this.mi_DichVu.Text = "Danh Sách dịch vụ";
            this.mi_DichVu.Click += new System.EventHandler(this.mi_DichVu_Click);
            // 
            // flp_SoDoPhong
            // 
            this.flp_SoDoPhong.AutoScroll = true;
            this.flp_SoDoPhong.Location = new System.Drawing.Point(382, 79);
            this.flp_SoDoPhong.Name = "flp_SoDoPhong";
            this.flp_SoDoPhong.Size = new System.Drawing.Size(931, 640);
            this.flp_SoDoPhong.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(385, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "SƠ ĐỒ PHÒNG";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(163, 29);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 876);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flp_SoDoPhong);
            this.Controls.Add(this.gb_MoTa);
            this.Controls.Add(this.gb_ThongKe);
            this.Controls.Add(this.mc_NgayThang);
            this.Controls.Add(this.ms_ChucNang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.ms_ChucNang;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.Load += new System.EventHandler(this.frm_QuanLyKhachSan_Load);
            this.gb_ThongKe.ResumeLayout(false);
            this.gb_ThongKe.PerformLayout();
            this.gb_MoTa.ResumeLayout(false);
            this.gb_MoTa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ms_ChucNang.ResumeLayout(false);
            this.ms_ChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar mc_NgayThang;
        private System.Windows.Forms.GroupBox gb_ThongKe;
        private System.Windows.Forms.Label lbl_SoPhongDaDat;
        private System.Windows.Forms.Label lbl_SoPhongTrong;
        private System.Windows.Forms.GroupBox gb_MoTa;
        private System.Windows.Forms.Label lbl_PhongTrong;
        private System.Windows.Forms.Label lbl_PhongDaDat;
        private System.Windows.Forms.MenuStrip ms_ChucNang;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_DanhSachPhong;
        private System.Windows.Forms.ToolStripMenuItem đặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_KhachHang;
        private System.Windows.Forms.Label lbl_SoLuongPhongDaDat;
        private System.Windows.Forms.Label lbl_SoLuongPhongTrong;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_DichVu;
        private System.Windows.Forms.FlowLayoutPanel flp_SoDoPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}

