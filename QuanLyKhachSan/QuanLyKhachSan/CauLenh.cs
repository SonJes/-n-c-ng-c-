using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class CauLenh
    {
        SqlConnection con = new SqlConnection(@"Data Source = JOHAN\SQLEXPRESS; Initial Catalog = Qlks; Integrated Security = True");
        DataTable dt = new DataTable();
    }
}
