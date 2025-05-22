namespace HomePage
{
    partial class FormDangKy
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
			this.btn_DangKy = new System.Windows.Forms.Button();
			this.btn_Huy = new System.Windows.Forms.Button();
			this.txt_XacNhanMatKhau = new System.Windows.Forms.TextBox();
			this.txt_MatKhau = new System.Windows.Forms.TextBox();
			this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
			this.lbl_XacNhanMatKhau = new System.Windows.Forms.Label();
			this.lbl_MatKhau = new System.Windows.Forms.Label();
			this.lbl_TenDangNhap = new System.Windows.Forms.Label();
			this.lbl_DangKy = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_DangKy
			// 
			this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_DangKy.ForeColor = System.Drawing.Color.Black;
			this.btn_DangKy.Location = new System.Drawing.Point(417, 334);
			this.btn_DangKy.Name = "btn_DangKy";
			this.btn_DangKy.Size = new System.Drawing.Size(150, 47);
			this.btn_DangKy.TabIndex = 11;
			this.btn_DangKy.Text = "Đăng ký";
			this.btn_DangKy.UseVisualStyleBackColor = true;
			this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
			// 
			// btn_Huy
			// 
			this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Huy.ForeColor = System.Drawing.Color.Black;
			this.btn_Huy.Location = new System.Drawing.Point(207, 334);
			this.btn_Huy.Name = "btn_Huy";
			this.btn_Huy.Size = new System.Drawing.Size(150, 47);
			this.btn_Huy.TabIndex = 13;
			this.btn_Huy.Text = "Hủy";
			this.btn_Huy.UseVisualStyleBackColor = true;
			this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
			// 
			// txt_XacNhanMatKhau
			// 
			this.txt_XacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_XacNhanMatKhau.Location = new System.Drawing.Point(315, 254);
			this.txt_XacNhanMatKhau.Multiline = true;
			this.txt_XacNhanMatKhau.Name = "txt_XacNhanMatKhau";
			this.txt_XacNhanMatKhau.PasswordChar = '*';
			this.txt_XacNhanMatKhau.Size = new System.Drawing.Size(324, 33);
			this.txt_XacNhanMatKhau.TabIndex = 9;
			// 
			// txt_MatKhau
			// 
			this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_MatKhau.Location = new System.Drawing.Point(315, 194);
			this.txt_MatKhau.Multiline = true;
			this.txt_MatKhau.Name = "txt_MatKhau";
			this.txt_MatKhau.PasswordChar = '*';
			this.txt_MatKhau.Size = new System.Drawing.Size(324, 33);
			this.txt_MatKhau.TabIndex = 7;
			// 
			// txt_TenDangNhap
			// 
			this.txt_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_TenDangNhap.Location = new System.Drawing.Point(315, 132);
			this.txt_TenDangNhap.Multiline = true;
			this.txt_TenDangNhap.Name = "txt_TenDangNhap";
			this.txt_TenDangNhap.Size = new System.Drawing.Size(324, 33);
			this.txt_TenDangNhap.TabIndex = 5;
			// 
			// lbl_XacNhanMatKhau
			// 
			this.lbl_XacNhanMatKhau.AutoSize = true;
			this.lbl_XacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbl_XacNhanMatKhau.ForeColor = System.Drawing.Color.Black;
			this.lbl_XacNhanMatKhau.Location = new System.Drawing.Point(121, 254);
			this.lbl_XacNhanMatKhau.Name = "lbl_XacNhanMatKhau";
			this.lbl_XacNhanMatKhau.Size = new System.Drawing.Size(181, 25);
			this.lbl_XacNhanMatKhau.TabIndex = 12;
			this.lbl_XacNhanMatKhau.Text = "Xác nhận mật khẩu";
			// 
			// lbl_MatKhau
			// 
			this.lbl_MatKhau.AutoSize = true;
			this.lbl_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbl_MatKhau.ForeColor = System.Drawing.Color.Black;
			this.lbl_MatKhau.Location = new System.Drawing.Point(121, 194);
			this.lbl_MatKhau.Name = "lbl_MatKhau";
			this.lbl_MatKhau.Size = new System.Drawing.Size(93, 25);
			this.lbl_MatKhau.TabIndex = 10;
			this.lbl_MatKhau.Text = "Mật khẩu";
			// 
			// lbl_TenDangNhap
			// 
			this.lbl_TenDangNhap.AutoSize = true;
			this.lbl_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbl_TenDangNhap.ForeColor = System.Drawing.Color.Black;
			this.lbl_TenDangNhap.Location = new System.Drawing.Point(121, 132);
			this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
			this.lbl_TenDangNhap.Size = new System.Drawing.Size(145, 25);
			this.lbl_TenDangNhap.TabIndex = 8;
			this.lbl_TenDangNhap.Text = "Tên đăng nhập";
			// 
			// lbl_DangKy
			// 
			this.lbl_DangKy.AutoSize = true;
			this.lbl_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbl_DangKy.ForeColor = System.Drawing.Color.Blue;
			this.lbl_DangKy.Location = new System.Drawing.Point(310, 39);
			this.lbl_DangKy.Name = "lbl_DangKy";
			this.lbl_DangKy.Size = new System.Drawing.Size(145, 38);
			this.lbl_DangKy.TabIndex = 6;
			this.lbl_DangKy.Text = "Đăng ký";
			// 
			// FormDangKy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_DangKy);
			this.Controls.Add(this.btn_Huy);
			this.Controls.Add(this.txt_XacNhanMatKhau);
			this.Controls.Add(this.txt_MatKhau);
			this.Controls.Add(this.txt_TenDangNhap);
			this.Controls.Add(this.lbl_XacNhanMatKhau);
			this.Controls.Add(this.lbl_MatKhau);
			this.Controls.Add(this.lbl_TenDangNhap);
			this.Controls.Add(this.lbl_DangKy);
			this.Name = "FormDangKy";
			this.Text = "Đăng Ký";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.TextBox txt_XacNhanMatKhau;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label lbl_XacNhanMatKhau;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label lbl_TenDangNhap;
        private System.Windows.Forms.Label lbl_DangKy;
    }
}