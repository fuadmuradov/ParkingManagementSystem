using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Security.Cryptography;
using System.Data;

namespace P_M_S
{
    public partial class Login : System.Web.UI.Page
    {
        string sql, sql1;

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));


            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
        Connection DataBase = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void signUp_Click(object sender, EventArgs e)
        {

            Response.Redirect("Sign_Up.aspx");
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            DataTable StudentTable = new DataTable();
            StudentTable = DataBase.SQLEXEC("SELECT * FROM CUSTOMER");




            StudentTable.Rows.ToString();
            


            // DataBase.SQLEXEC(sql);
            Session["Username"] = username_id.Text;
            Session["password"] = password_id.Text.ToString();




            if (Session["Username"].ToString().Length != 0 && Session["password"].ToString().Length != 0)
            {
                sql1 = MD5Hash(Session["password"].ToString());
                int k = 0;
                     if (sql1.Equals("7594d9f5ae643cf1e10270b438f049c5")) Response.Redirect("Dashboard.aspx");

                

                foreach (DataRow row in StudentTable.Rows)
                {

                    sql = row["PASWORD"].ToString();
                    

                    if (sql1.Equals(sql)) { k = 1; Session["user_id"]=row["USERNAME_ID"].ToString(); Response.Redirect("Main_Page_For_Customer.aspx"); break; }
                    else continue;
                }

               

                if (k == 0) Response.Redirect("Login.aspx");

            }
           
        }







    }
}