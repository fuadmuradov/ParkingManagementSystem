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
    public partial class Sign_Up : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            }


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
        protected void Save_Click(object sender, EventArgs e)
        {
            DataTable StudentTable = new DataTable();
            StudentTable = DataBase.SQLEXEC("SELECT * FROM CUSTOMER");


          string code = MD5Hash(pswrd_id.Text.ToString());

            string sql = "INSERT INTO CUSTOMER(USERNAME, ADRESS, EMAIL, GENDER, PASWORD) VALUES(N'" + user_id.Text.ToString() + "' , '" + 
                                                                                                    address_id.Text.ToString() + "' , '" + 
                                                                                                    mail_id.Text.ToString() + "' , '" + 
                                                                                                    mf_id.Text.ToString() + "' , '" +
                                                                                                    code + "' " + ")";




            DataBase.SQLEXEC(sql);

            Response.Redirect("Login.aspx");
        }

    }
}