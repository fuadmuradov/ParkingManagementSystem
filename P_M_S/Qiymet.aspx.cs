using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P_M_S
{
    public partial class Qiymet : System.Web.UI.Page
    {
        Connection DataBase = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        protected void Delete_Click(object sender, EventArgs e)
        { 
            DataTable StudentTable2 = new DataTable();
            StudentTable2 = DataBase.SQLEXEC("SELECT * FROM TRANSPORT");


            string sql = "DELETE FROM TRANSPORT WHERE SHOBE_ID=" + Session["user_id"].ToString();
            DataBase.SQLEXEC(sql);

            Response.Redirect("Main_Page_For_Customer.aspx");


        }

        public void LoadData()
        {
            DataTable StudentTable = new DataTable();
            StudentTable = DataBase.SQLEXEC("SELECT * FROM TRANSPORT");
            DataTable StudentTable2 = new DataTable();
            StudentTable2 = DataBase.SQLEXEC("SELECT * FROM CUSTOMER");
            string HTML = "";
            foreach (DataRow row in StudentTable.Rows)
            {
                if (Convert.ToInt32(Session["user_id"].ToString()) == Convert.ToInt32(row["SHOBE_ID"].ToString()))
                {
                    HTML += @"<tr>
                               
                                <tr><b>
                                      " + "Ödəniləcək Məbləğ: " + row["QIYMET"] + " AZN" + @"
                                                
                                </b></br></br></tr>
                               

                                </tr>";

                }
                lbl_data1.InnerHtml = HTML;
            }

            





            string sql2 = "";
            string sql3 = "";

            foreach (DataRow row in StudentTable.Rows)
            {
                if (Convert.ToInt32(Session["user_id"].ToString()) == Convert.ToInt32(row["SHOBE_ID"].ToString()))
                {


                    sql2 = "INSERT INTO HESABAT(model, marka, nomre, g_saat, g_cixis, qiymet, shobe_id) VALUES('" +
                         row["MODEL"] +"','"+ row["MARKA"] +"','"+ row["NOMRE"] +"','" +  row["TARIX"] +"','"+ row["CIXIS_TARIX"]+"',"+
                         row["QIYMET"]+","+row["SHOBE_ID"]+")";
                       
                }

            }

            DataBase.SQLEXEC(sql2);

            foreach (DataRow row in StudentTable2.Rows)
            {
                if (Convert.ToInt32(Session["user_id"].ToString()) == Convert.ToInt32(row["USERNAME_ID"].ToString()))
                {


                    sql3 = "Update HESABAT SET adi='" +row["USERNAME"] +  "' where shobe_id="+ Convert.ToInt32(Session["user_id"].ToString());
                         

                }

            }

            DataBase.SQLEXEC(sql3);




        }


    }
}