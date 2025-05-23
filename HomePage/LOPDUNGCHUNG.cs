using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HomePage
{
    class LOPDUNGCHUNG
    {
        string chuoiKn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CS-464-FIS\CSHARP\Lesson03-Winforms\QuanLyKhachSan\HomePage\QuanLyKhachSan.mdf;Integrated Security=True";
        SqlConnection conn;

        public LOPDUNGCHUNG()
        {
            string chuoiKn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Lap_Trinh_Ung_Dung_NET\BaiGROUP\QuanLyKhachSan\HomePage\QuanLyKhachSan.mdf;Integrated Security=True";

            conn = new SqlConnection(chuoiKn);
        }

        

        public int ThemSuaXoa(string sql)
        {

            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close(); 
            return kq;
        }

        public object LayGiaTri(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
			conn.Open();
			object kq = comm.ExecuteScalar();
            conn.Close(); 
            return kq;
        }

        public DataTable LayDuLieuTuBang(string sql)
        {
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
    }
}