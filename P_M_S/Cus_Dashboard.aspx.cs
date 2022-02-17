using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace P_M_S
{
    public partial class Cus_Dashboard : System.Web.UI.Page
    {
        Connection DataBase = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Main_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main_Page_For_Customer.aspx");
        }

        protected void Entire_Click(object sender, EventArgs e)
        {
            DataTable StudentTable = new DataTable();
            StudentTable = DataBase.SQLEXEC("SELECT * FROM TRANSPORT");




            string sql = "INSERT INTO TRANSPORT(TIP, MARKA, MODEL, NOMRE, RENG, TARIX, SAAT, SHOBE_ID) VALUES(N'" + tip_id.Text.ToString() + "' , '" +
                                                            marka_id.Text.ToString() + "' , '" +
                                                            model_id.Text.ToString() + "' , '" +
                                                            nomre_id.Text.ToString() + "' , '" +
                                                            color_id.Text.ToString() + "', " +
                                                            "GETDATE(), CONVERT(nvarchar(5), GETDATE(), 108), " +
                                                            Convert.ToInt32(Session["user_id"].ToString())+
                                                            ")";




            DataBase.SQLEXEC(sql);

            Response.Redirect("Main_Page_For_Customer.aspx");
        }
    }
}