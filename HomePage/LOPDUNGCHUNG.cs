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
        private readonly string chuoiKn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\OnTap\DANHOM\QuanLyKhachSan\HomePage\QuanLyKhachSan.mdf;Integrated Security=True";
        SqlConnection conn;

        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(chuoiKn);
        }

        public string GetConnectionString()
        {
            return chuoiKn;
        }

        public int ThemSuaXoa(string sql)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand comm = new SqlCommand(sql, conn);
            int kq = comm.ExecuteNonQuery();
            conn.Close(); 
            return kq;
        }

        public object LayGiaTri(string sql)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand comm = new SqlCommand(sql, conn);
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