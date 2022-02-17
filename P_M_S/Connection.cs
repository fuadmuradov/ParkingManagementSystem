using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace P_M_S
{
    public class Connection
    {
        public DataTable SQLEXEC(string P_SQl)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-1LJC4H1E\\SQLEXPRESS;Initial Catalog=STUDENTS;Integrated Security=True"))
            {
                con.Open();
                var cmd = new SqlCommand(P_SQl, con);
                var Sqlreader = cmd.ExecuteReader();
                dt.Load(Sqlreader);
                con.Close();
            }

            return dt;
        }
    }
}