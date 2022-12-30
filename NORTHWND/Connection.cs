using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NORTHWND
{
    internal class Connection
    {
        public static SqlConnection con = new SqlConnection("Server=DESKTOP-A10URF2\\SQLEXPRESS;Database=NORTHWND;Trusted_Connection=True;");
    }
}
