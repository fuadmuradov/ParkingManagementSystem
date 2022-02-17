using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P_M_S
{
    public partial class Admin_neqliyyat : System.Web.UI.Page
    {

        Connection DataBase = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {

            // string code= MD5Hash(Session["password"].ToString());



            DataTable StudentTable = new DataTable();
            
            StudentTable = DataBase.SQLEXEC("SELECT * FROM CUS_TRA_VIEW");

            string HTML = "";

            foreach (DataRow row in StudentTable.Rows)
            {
                HTML += @"<tr>
                               
                                <td>
                                      " + row["USERNAME"] + @"
                                </td>
                                <td>
                                    " + row["MARKA"] + @"
                                </td>
                                <td>
                                      " + row["MODEL"] + @"
                                </td>
                                <td>
                                      " + row["NOMRE"] + @"
                                </td>
                                    <td>
                                      " + row["RENG"] + @"
                                </td>

                                </tr>";

            }
            lbl_data3.InnerHtml = HTML;


        }
    }
}