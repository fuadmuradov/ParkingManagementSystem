using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P_M_S
{
    public partial class Dashboard : System.Web.UI.Page
    {
        Connection DataBase = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void Neqliyyatt_Click(object sender, EventArgs e)
        {
           Response.Redirect("Admin_neqliyyat.aspx");
           // Response.Redirect("Hesabat.aspx");
        }

        protected void Hesabat_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hesabat.aspx");
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        protected void Tarifler_Click(object sender, EventArgs e)
        {
            Response.Redirect("update_tarifler.aspx");
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
            string HTML = "";
            string HTML2 = "";

            
            foreach (DataRow row in StudentTable.Rows)
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
            lbl_data2.InnerHtml = HTML;

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




        }
    }
}