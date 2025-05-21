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
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.lbl_TenKhachHang = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.lbl_CCCD = new System.Windows.Forms.Label();
            this.txt_Timkiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.dgv_DanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.pn_QuanLyKhachHang = new System.Windows.Forms.Panel();
            this.lbl_QuanLyKhachHang = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.grb_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhachHang)).BeginInit();
            this.pn_QuanLyKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(564, 307);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(154, 48);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(994, 308);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(154, 48);
            this.btn_Xoa.TabIndex = 4;
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
            this.btn_Sua.Location = new System.Drawing.Point(779, 307);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(154, 48);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Controls.Add(this.txt_TenKhachHang);
            this.grb_ThongTin.Controls.Add(this.lbl_TenKhachHang);
            this.grb_ThongTin.Controls.Add(this.txt_Email);
            this.grb_ThongTin.Controls.Add(this.txt_SoDienThoai);
            this.grb_ThongTin.Controls.Add(this.txt_CCCD);
            this.grb_ThongTin.Controls.Add(this.lbl_Email);
            this.grb_ThongTin.Controls.Add(this.lbl_SoDienThoai);
            this.grb_ThongTin.Controls.Add(this.lbl_CCCD);
            this.grb_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ThongTin.Location = new System.Drawing.Point(41, 117);
            this.grb_ThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.grb_ThongTin.Size = new System.Drawing.Size(1153, 166);
            this.grb_ThongTin.TabIndex = 0;
            this.grb_ThongTin.TabStop = false;
            this.grb_ThongTin.Text = "Thông tin";
            this.grb_ThongTin.Enter += new System.EventHandler(this.grb_ThongTin_Enter);
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenKhachHang.Location = new System.Drawing.Point(222, 28);
            this.txt_TenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(289, 29);
            this.txt_TenKhachHang.TabIndex = 1;
            // 
            // lbl_TenKhachHang
            // 
            this.lbl_TenKhachHang.AutoSize = true;
            this.lbl_TenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenKhachHang.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_TenKhachHang.Location = new System.Drawing.Point(56, 32);
            this.lbl_TenKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenKhachHang.Name = "lbl_TenKhachHang";
            this.lbl_TenKhachHang.Size = new System.Drawing.Size(153, 24);
            this.lbl_TenKhachHang.TabIndex = 58;
            this.lbl_TenKhachHang.Text = "Tên khách hàng:";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Email.Location = new System.Drawing.Point(809, 98);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(289, 29);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(809, 31);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(289, 29);
            this.txt_SoDienThoai.TabIndex = 3;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_CCCD.Location = new System.Drawing.Point(222, 98);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(289, 29);
            this.txt_CCCD.TabIndex = 2;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Email.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_Email.Location = new System.Drawing.Point(650, 101);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(62, 24);
            this.lbl_Email.TabIndex = 37;
            this.lbl_Email.Text = "Email:";
            this.lbl_Email.Click += new System.EventHandler(this.lbl_SoDienThoai_Click);
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_SoDienThoai.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(650, 35);
            this.lbl_SoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(126, 24);
            this.lbl_SoDienThoai.TabIndex = 36;
            this.lbl_SoDienThoai.Text = "Số điện thoại:";
            // 
            // lbl_CCCD
            // 
            this.lbl_CCCD.AutoSize = true;
            this.lbl_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_CCCD.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_CCCD.Location = new System.Drawing.Point(57, 98);
            this.lbl_CCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CCCD.Name = "lbl_CCCD";
            this.lbl_CCCD.Size = new System.Drawing.Size(144, 24);
            this.lbl_CCCD.TabIndex = 35;
            this.lbl_CCCD.Text = "CCCD/Passport:";
            // 
            // txt_Timkiem
            // 
            this.txt_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Timkiem.Location = new System.Drawing.Point(180, 316);
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
            this.lbl_TimKiem.Location = new System.Drawing.Point(67, 316);
            this.lbl_TimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(92, 24);
            this.lbl_TimKiem.TabIndex = 72;
            this.lbl_TimKiem.Text = "Tìm kiếm:";
            // 
            // dgv_DanhSachKhachHang
            // 
            this.dgv_DanhSachKhachHang.AllowUserToAddRows = false;
            this.dgv_DanhSachKhachHang.AllowUserToDeleteRows = false;
            this.dgv_DanhSachKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKhachHang.Location = new System.Drawing.Point(41, 381);
            this.dgv_DanhSachKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DanhSachKhachHang.MultiSelect = false;
            this.dgv_DanhSachKhachHang.Name = "dgv_DanhSachKhachHang";
            this.dgv_DanhSachKhachHang.ReadOnly = true;
            this.dgv_DanhSachKhachHang.RowHeadersWidth = 51;
            this.dgv_DanhSachKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachKhachHang.Size = new System.Drawing.Size(1153, 266);
            this.dgv_DanhSachKhachHang.TabIndex = 70;
            this.dgv_DanhSachKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachKhachHang_CellClick);
            // 
            // pn_QuanLyKhachHang
            // 
<<<<<<< HEAD
            this.pn_QuanLyKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pn_QuanLyKhachHang.Controls.Add(this.lbl_QuanLyKhachHang);
            this.pn_QuanLyKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_QuanLyKhachHang.Location = new System.Drawing.Point(0, 0);
            this.pn_QuanLyKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.pn_QuanLyKhachHang.Name = "pn_QuanLyKhachHang";
            this.pn_QuanLyKhachHang.Size = new System.Drawing.Size(1312, 74);
            this.pn_QuanLyKhachHang.TabIndex = 73;
=======
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.lbl_QuanLyKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 74);
            this.panel1.TabIndex = 73;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
>>>>>>> branch-minh-01
            // 
            // lbl_QuanLyKhachHang
            // 
            this.lbl_QuanLyKhachHang.AutoSize = true;
            this.lbl_QuanLyKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuanLyKhachHang.ForeColor = System.Drawing.Color.White;
            this.lbl_QuanLyKhachHang.Location = new System.Drawing.Point(16, 22);
            this.lbl_QuanLyKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QuanLyKhachHang.Name = "lbl_QuanLyKhachHang";
            this.lbl_QuanLyKhachHang.Size = new System.Drawing.Size(340, 31);
            this.lbl_QuanLyKhachHang.TabIndex = 0;
            this.lbl_QuanLyKhachHang.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Tim.ForeColor = System.Drawing.Color.White;
            this.btn_Tim.Location = new System.Drawing.Point(448, 316);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(76, 29);
            this.btn_Tim.TabIndex = 74;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.pn_QuanLyKhachHang);
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
            this.pn_QuanLyKhachHang.ResumeLayout(false);
            this.pn_QuanLyKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.GroupBox grb_ThongTin;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.Label lbl_TenKhachHang;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label lbl_CCCD;
        private System.Windows.Forms.TextBox txt_Timkiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.DataGridView dgv_DanhSachKhachHang;
        private System.Windows.Forms.Panel pn_QuanLyKhachHang;
        private System.Windows.Forms.Label lbl_QuanLyKhachHang;
        private System.Windows.Forms.Button btn_Tim;
    }
}