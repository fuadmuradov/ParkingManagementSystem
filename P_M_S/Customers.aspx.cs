using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P_M_S
{
    public partial class Customers : System.Web.UI.Page
    {
        Connection DataBase = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        protected void Paying_Click(object sender, EventArgs e)
        {
            int n = 0, k = 0, sum = 0;
            DataTable StudentTable = new DataTable();
            StudentTable = DataBase.SQLEXEC("SELECT * FROM TRANSPORT");
            DataTable StudentTable2 = new DataTable();
            StudentTable2 = DataBase.SQLEXEC("SELECT * FROM TARİFLER");




            foreach (DataRow row in StudentTable.Rows)
            {
                if (Convert.ToInt32(Session["user_id"].ToString()) == Convert.ToInt32(row["SHOBE_ID"].ToString()))
                {
                    n = Convert.ToInt32(row["SUM_SAAT"].ToString());
                    k = Convert.ToInt32(row["SUM_DEQ"].ToString());

                }
            }

            if (k % 60 != 0) n = n + 1 + k / 60;
            else n = k / 60;

            foreach (DataRow row in StudentTable2.Rows)
            {
                sum = sum + n / 720 * (Convert.ToInt32(row["AY"].ToString()));
                n = n % 720;

                sum = sum + (n / 240) * (Convert.ToInt32(row["HEFTE"].ToString()));
                n = n % 240;

                sum = sum + n / 24 * (Convert.ToInt32(row["GUN"].ToString()));
                n = n % 24;

                sum = sum + n * (Convert.ToInt32(row["SAAT"].ToString()));

                break;
            }


            string sql4 = "UPDATE TRANSPORT SET QIYMET=" + sum + " WHERE SHOBE_ID = " + Convert.ToInt32(Session["user_id"].ToString()) + ";";

            DataBase.SQLEXEC(sql4);




            Response.Redirect("Qiymet.aspx");


        }

        public void LoadData()
        { 
        DataTable StudentTable = new DataTable();
            StudentTable = DataBase.SQLEXEC("SELECT * FROM TRANSPORT");
            string HTML = "";

           



            string sql2 = "";


            foreach (DataRow row in StudentTable.Rows)
            {
                if (Convert.ToInt32(Session["user_id"].ToString()) == Convert.ToInt32(row["SHOBE_ID"].ToString()))
                {


                    sql2 = "UPDATE TRANSPORT SET SUM_SAAT= DATEDIFF(HOUR, '" + row["TARIX"] + "', '" +
                                                        row["CIXIS_TARIX"] +
                                                    "') WHERE SHOBE_ID=" + Convert.ToInt32(Session["user_id"].ToString()) + ";" +

                                                    "" +
                                                    " UPDATE TRANSPORT SET SUM_DEQ = DATEDIFF(MINUTE, '" + row["SAAT"].ToString() + "', '" + row["CIXIS_SAAT"].ToString() + "') WHERE SHOBE_ID= " +
                                                    Convert.ToInt32(Session["user_id"].ToString()) + ";";
                }

            }

            DataBase.SQLEXEC(sql2);



            foreach (DataRow row in StudentTable.Rows)
            {
                if (Convert.ToInt32(Session["user_id"].ToString()) == Convert.ToInt32(row["SHOBE_ID"].ToString()))
                {
                    HTML += @"<tr>
                               
                                <tr><b>
                                      "+ "Tip:" + row["TIP"] + @"
                                                
                                </b></br></br></tr>
                                <tr><b>
                                    "+ "Model: " + row["MARKA"] + @"
                                </b></br></br></tr>
                                <tr><b>
                                      " + "Marka: " + row["MODEL"] + @"
                                </b></br></br></tr>
                                    <tr><b>
                                      " + "Nömrə: " + row["NOMRE"] + @"
                                </b></br></br></tr>
                                <tr><b>
                                      " + "Rəng: " + row["RENG"] + @"
                                </b></br></br></tr>
                                    <tr><b>
                                      " +"Tarix: "+ row["TARIX"] + @"
                                </b></br></br></tr>
                                    <tr><b>
                                      "+ "Saat: " + row["SAAT"] + @"
                                </b></br></br></tr>
                                        <tr><b>
                                      " + "Çıxış Tarixi: " + row["CIXIS_TARIX"] + @"
                                </b></br></br></tr>                                        
                                        <tr><b>
                                      " + "Çıxış Saatı: " + row["CIXIS_SAAT"] + @"
                                </b></br></br></tr>

                                </tr>";

                }
                lbl_data1.InnerHtml = HTML;
            }

        }



        }
}