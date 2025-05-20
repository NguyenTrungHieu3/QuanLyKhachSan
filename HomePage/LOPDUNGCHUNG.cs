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
            try
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                int kq = comm.ExecuteNonQuery();
                return kq;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public object LayGiaTri(string sql)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                object kq = comm.ExecuteScalar();
                return kq;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public DataTable LayDuLieuTuBang(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                // SqlDataAdapter tự động mở và đóng kết nối khi Fill
                da.Fill(dt);
                return dt;
            }
            finally
            {
                // Đảm bảo kết nối đã đóng trong mọi trường hợp
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
