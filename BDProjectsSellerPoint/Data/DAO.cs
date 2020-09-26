using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProjectsSellerPoint.Data
{
    public static class DAO
    {
        public static void DbExecute(string sql, SqlConnection sqlConnection)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }


    }
}
