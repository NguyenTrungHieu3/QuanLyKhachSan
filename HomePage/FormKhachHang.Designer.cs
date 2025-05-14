namespace HomePage
{
    partial class frm_KhachHang
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
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.lbl_TenKhachHang = new System.Windows.Forms.Label();
            this.lbl_MaKhachHang = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.lbl_CCCD = new System.Windows.Forms.Label();
            this.txt_Timkiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.dgv_DanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.grb_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Them.Location = new System.Drawing.Point(504, 210);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(120, 37);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Xoa.Location = new System.Drawing.Point(792, 210);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(120, 37);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sua.Location = new System.Drawing.Point(650, 210);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 37);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Controls.Add(this.txt_MaKhachHang);
            this.grb_ThongTin.Controls.Add(this.txt_TenKhachHang);
            this.grb_ThongTin.Controls.Add(this.lbl_TenKhachHang);
            this.grb_ThongTin.Controls.Add(this.lbl_MaKhachHang);
            this.grb_ThongTin.Controls.Add(this.txt_Email);
            this.grb_ThongTin.Controls.Add(this.txt_SoDienThoai);
            this.grb_ThongTin.Controls.Add(this.txt_CCCD);
            this.grb_ThongTin.Controls.Add(this.lbl_Email);
            this.grb_ThongTin.Controls.Add(this.lbl_SoDienThoai);
            this.grb_ThongTin.Controls.Add(this.lbl_CCCD);
            this.grb_ThongTin.Location = new System.Drawing.Point(23, 26);
            this.grb_ThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.grb_ThongTin.Size = new System.Drawing.Size(912, 166);
            this.grb_ThongTin.TabIndex = 0;
            this.grb_ThongTin.TabStop = false;
            this.grb_ThongTin.Text = "Thông tin";
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaKhachHang.Location = new System.Drawing.Point(173, 25);
            this.txt_MaKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Size = new System.Drawing.Size(247, 29);
            this.txt_MaKhachHang.TabIndex = 0;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenKhachHang.Location = new System.Drawing.Point(173, 64);
            this.txt_TenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(247, 29);
            this.txt_TenKhachHang.TabIndex = 1;
            // 
            // lbl_TenKhachHang
            // 
            this.lbl_TenKhachHang.AutoSize = true;
            this.lbl_TenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenKhachHang.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_TenKhachHang.Location = new System.Drawing.Point(7, 68);
            this.lbl_TenKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenKhachHang.Name = "lbl_TenKhachHang";
            this.lbl_TenKhachHang.Size = new System.Drawing.Size(153, 24);
            this.lbl_TenKhachHang.TabIndex = 58;
            this.lbl_TenKhachHang.Text = "Tên khách hàng:";
            // 
            // lbl_MaKhachHang
            // 
            this.lbl_MaKhachHang.AutoSize = true;
            this.lbl_MaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaKhachHang.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_MaKhachHang.Location = new System.Drawing.Point(7, 28);
            this.lbl_MaKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaKhachHang.Name = "lbl_MaKhachHang";
            this.lbl_MaKhachHang.Size = new System.Drawing.Size(145, 24);
            this.lbl_MaKhachHang.TabIndex = 2;
            this.lbl_MaKhachHang.Text = "Mã khách hàng:";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Email.Location = new System.Drawing.Point(636, 67);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(247, 29);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(636, 28);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(247, 29);
            this.txt_SoDienThoai.TabIndex = 3;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_CCCD.Location = new System.Drawing.Point(173, 106);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(247, 29);
            this.txt_CCCD.TabIndex = 2;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Email.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_Email.Location = new System.Drawing.Point(477, 70);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(57, 24);
            this.lbl_Email.TabIndex = 37;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.Click += new System.EventHandler(this.lbl_SoDienThoai_Click);
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_SoDienThoai.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(477, 32);
            this.lbl_SoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(121, 24);
            this.lbl_SoDienThoai.TabIndex = 36;
            this.lbl_SoDienThoai.Text = "Số điện thoại";
            // 
            // lbl_CCCD
            // 
            this.lbl_CCCD.AutoSize = true;
            this.lbl_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_CCCD.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_CCCD.Location = new System.Drawing.Point(8, 106);
            this.lbl_CCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CCCD.Name = "lbl_CCCD";
            this.lbl_CCCD.Size = new System.Drawing.Size(144, 24);
            this.lbl_CCCD.TabIndex = 35;
            this.lbl_CCCD.Text = "CCCD/Passport:";
            // 
            // txt_Timkiem
            // 
            this.txt_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Timkiem.Location = new System.Drawing.Point(202, 215);
            this.txt_Timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Timkiem.Name = "txt_Timkiem";
            this.txt_Timkiem.Size = new System.Drawing.Size(247, 29);
            this.txt_Timkiem.TabIndex = 1;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TimKiem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_TimKiem.Location = new System.Drawing.Point(36, 219);
            this.lbl_TimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(87, 24);
            this.lbl_TimKiem.TabIndex = 72;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // dgv_DanhSachKhachHang
            // 
            this.dgv_DanhSachKhachHang.AllowUserToAddRows = false;
            this.dgv_DanhSachKhachHang.AllowUserToDeleteRows = false;
            this.dgv_DanhSachKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKhachHang.Location = new System.Drawing.Point(23, 273);
            this.dgv_DanhSachKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DanhSachKhachHang.MultiSelect = false;
            this.dgv_DanhSachKhachHang.Name = "dgv_DanhSachKhachHang";
            this.dgv_DanhSachKhachHang.ReadOnly = true;
            this.dgv_DanhSachKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachKhachHang.Size = new System.Drawing.Size(912, 245);
            this.dgv_DanhSachKhachHang.TabIndex = 70;
            this.dgv_DanhSachKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachKhachHang_CellClick);
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 561);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.grb_ThongTin);
            this.Controls.Add(this.txt_Timkiem);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.dgv_DanhSachKhachHang);
            this.Name = "frm_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.frm_KhachHang_Load);
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
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.Label lbl_TenKhachHang;
        private System.Windows.Forms.Label lbl_MaKhachHang;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label lbl_CCCD;
        private System.Windows.Forms.TextBox txt_Timkiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.DataGridView dgv_DanhSachKhachHang;
    }
}