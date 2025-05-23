using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_BookingService());
            //Application.Run(new frm_Login());
            //Application.Run(new frm_DanhSachPhong());
            //Application.Run(new frm_DichVu());
            //Application.Run(new frm_Login());

            //Application.Run(new frm_Main());
            //Application.Run(new frm_DanhSachPhong());

            //Application.Run(new frm_DatPhong());
            //Application.Run(new frm_Main());

            Application.Run(new frm_Login());
            //Application.Run(new frm_Main());
        }
    }
}
