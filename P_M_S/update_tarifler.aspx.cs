using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P_M_S
{
    public partial class update_tarifler : System.Web.UI.Page
    {
        Connection DataBase = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Entire_Click(object sender, EventArgs e)
        {
            DataTable StudentTable = new DataTable();
            StudentTable = DataBase.SQLEXEC("SELECT * FROM TARİFLER");




            string sql = "update TARİFLER SET SAAT=" + Convert.ToInt32(saat_id.Text.ToString()) +
                                         "; update TARİFLER set GUN=" + Convert.ToInt32(gun_id.Text.ToString()) +
                                         "; update TARİFLER set  HEFTE=" + Convert.ToInt32(hefte_id.Text.ToString()) +
                                         "; update TARİFLER set  AY=" + Convert.ToInt32(ay_id.Text.ToString()) + ";";




            DataBase.SQLEXEC(sql);

           
        }
    }
}