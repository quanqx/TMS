using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSapp
{
    class funcHangDi
    {
        public static SqlConnection con;

        public static bool Connect()
        {
            con = new SqlConnection("Server = localhost;Database = TMS; Integrated Security = true;");
            try
            {
                con.Open();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable getDataToTable(String sql)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adater = new SqlDataAdapter(sql, con);
                adater.Fill(dataTable);
                adater.Dispose();
                adater = null;
                return dataTable;
            }
            catch(Exception e)
            {
                MessageBox.Show("Không thể lấy dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataTable;
            }
        }
    }
}
