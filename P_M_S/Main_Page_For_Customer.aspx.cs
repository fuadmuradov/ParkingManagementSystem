using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Security.Cryptography;
using System.Data;

namespace P_M_S
{
    public partial class Main_Page_For_Customer : System.Web.UI.Page
    {

        protected void neqliyyat_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cus_Dashboard.aspx");
        }

        protected void Out_Click(object sender, EventArgs e)
        {
            
         
                 string sql = "UPDATE TRANSPORT SET CIXIS_TARIX=GETDATE() WHERE SHOBE_ID = " + Convert.ToInt32(Session["user_id"].ToString()) +
                                     "; UPDATE TRANSPORT SET CIXIS_SAAT=CONVERT(nvarchar(5), GETDATE(), 108) WHERE SHOBE_ID = " + Convert.ToInt32(Session["user_id"].ToString()) +";";
                

            DataBase.SQLEXEC(sql);

            Response.Redirect("Customers.aspx");
        }

        Connection DataBase = new Connection();
      

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





        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        public void LoadData()
        {
            
         // string code= MD5Hash(Session["password"].ToString());



            DataTable StudentTable = new DataTable();
            DataTable StudentTable2 = new DataTable();

            DataTable StudentTable3 = new DataTable();
            // StudentTable = DataBase.SQLEXEC("SELECT * FROM CUSTOMERS WHERE PASWORD='" + code + "'");
            StudentTable = DataBase.SQLEXEC("SELECT * FROM CUSTOMER");
            StudentTable2 = DataBase.SQLEXEC("SELECT * FROM TARİFLER");
            StudentTable3 = DataBase.SQLEXEC("SELECT * FROM TRANSPORT");
            string HTML = "";
            string HTML2 = "";
            string HTML3 = "";

            foreach (DataRow row in StudentTable.Rows)
            {
                if (Convert.ToInt32(Session["user_id"].ToString()) == Convert.ToInt32(row["USERNAME_ID"].ToString()))
                {
                    HTML += @"<tr>
                               
                                <td>
                                      " + row["USERNAME"] + @"
                                </td>
                                <td>
                                    " + row["ADRESS"] + @"
                                </td>
                                <td>
                                      " + row["EMAIL"] + @"
                                </td>
                                <td>
                                      " + row["GENDER"] + @"
                                </td>
                                </tr>";

                }
                lbl_data.InnerHtml = HTML;
            }
          //  lbl_data1.InnerHtml = HTML3;
            foreach (DataRow row in StudentTable2.Rows)
            {
                HTML2 += @"<tr>
                               
                                <td><b>
                                      " + row["SAAT"] + " AZN" + @"
                                </b></td>
                                <td><b>
                                    " + row["GUN"] + " AZN" + @"
                                </b></td>
                                <td><b>
                                      " + row["HEFTE"] + " AZN" + @"
                                </b></td>
                                <td><b>
                                      " + row["AY"] + " AZN" + @"
                                </br></td>
                                </tr>";
                
            }
            Lbl_1.InnerHtml = HTML2;

            foreach (DataRow row in StudentTable3.Rows)
            {
                if (Convert.ToInt32(Session["user_id"].ToString()) == Convert.ToInt32(row["SHOBE_ID"].ToString()))
                {
                    HTML3 += @"<tr>
                               
                                <td><b>
                                      " + row["TIP"] + @"
                                </b></td>
                                <td><b>
                                    " + row["MARKA"] + @"
                                </b></td>
                                <td><b>
                                      " + row["MODEL"] + @"
                                </b></td>
                                <td><b>
                                      " + row["NOMRE"] + @"
                                </b></td>
                                <td><b>
                                      " + row["RENG"] + @"
                                </br></td>
                                    <td><b>
                                      " + row["TARIX"] + @"
                                </br></td>
                                    <td><b>
                                      " + row["SAAT"] + @"
                                </br></td>
                                </tr>";

                }
                Label1.InnerHtml = HTML3;
            }
        }
    }
}