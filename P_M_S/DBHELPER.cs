using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace P_M_S
{
    public class DBHELPER
    {
        public DataTable dbexec(string P_sql)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1LJC4H1E\SQLEXPRESS;Initial Catalog=STUDENTS;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand(P_sql, con);
            SqlDataReader reader = com.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            con.Close();
            return dt;
        }
    }
}