using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace QLVT
{
    static class Program
    {

        public static SqlConnection conn = new SqlConnection();
        public static string connstr = "Data Source=.;Initial Catalog=QLVT;User ID=sa;Password=123456";
        public static String control = "";

        //public static SqlDataReader myreader;

        public static bool KetNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            try
            {
                conn.ConnectionString = connstr;
                conn.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\n " + e.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
