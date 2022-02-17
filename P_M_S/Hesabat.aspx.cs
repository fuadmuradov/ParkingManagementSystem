using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P_M_S
{
    public partial class Hesabat : System.Web.UI.Page
    {
        Connection DataBase = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            string dlt = "Delete from HESABAT";

            DataBase.SQLEXEC(dlt);

            Response.Redirect("Hesabat.aspx");
        }
        public void LoadData()
        {
            string HTML="";

            DataTable StudentTable = new DataTable();
            StudentTable = DataBase.SQLEXEC("SELECT * FROM HESABAT");

            foreach (DataRow row in StudentTable.Rows )
            {
                HTML += @"<tr>
                               
                                <td>
                                      " + row["adi"] + @"
                                </td>
                                <td>
                                    " + row["model"] + @"
                                </td>
                                <td>
                                      " + row["marka"] + @"
                                </td>
                                 <td>
                                      " + row["nomre"] + @"
                                </td>
                                <td>
                                      " + row["g_saat"] + @"
                                </td>
                                    <td>
                                      " + row["g_cixis"] + @"
                                </td>
                                <td>
                                      " + row["qiymet"] +" AZN"+ @"
                                </td>
                                </tr>";
            }
            
            lbl_data3.InnerHtml = HTML;
        }

    }
}