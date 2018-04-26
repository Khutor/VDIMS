using System;
using System.Web;
using System.Web.UI;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace VDIMS
{

    public partial class sign_in : System.Web.UI.Page
    {
        protected void loginButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=SERVER;user id=ID;password=PWORD;persistsecurityinfo=True;database=DB");
            DataTable dt = new DataTable();
            String email = emailTxt.Text;
            String pword = passwordTxt.Text;
            var sql = "SELECT * FROM USERS WHERE USER_EMAIL = '" + email + "' AND USER_PASSWORD = '" + pword + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Label1.Text = "Valid login";
            }
            else
            {
                Label1.Text = "Invalid login";
            }
        }
    }
}

