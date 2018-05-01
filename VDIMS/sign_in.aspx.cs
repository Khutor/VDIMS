using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Web;
using System.Web.UI;
using System.Data;


namespace VDIMS
{

    public partial class sign_in : System.Web.UI.Page
    {
        protected void loginButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("ADD ME");
            DataTable dt = new DataTable();
            String email = emailTxt.Text;
            String pword = passwordTxt.Text;
            var sql = "SELECT * FROM USERS WHERE USER_EMAIL = '" + email + "' AND USER_PASSWORD = '" + pword + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                String name = "";
                int ID = 0;
                String isAdmin = "false";
                String admin = "";
                foreach (DataRow row in dt.Rows)
                {
                    ID = Int32.Parse(row["USER_ID"].ToString());
                    name = row["USER_NAME"].ToString();
                    admin = row["IS_ADMIN"].ToString();
                    if (admin.Equals("True"))
                        isAdmin = "true";
                    else
                        isAdmin = "false";
                }

                Session["Logged"] = "Yes";
                Session["USER_NAME"] = name;
                Session["USER_EMAIL"] = email;
                Session["USER_ID"] = ID;
                Session["IS_ADMIN"] = isAdmin;
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Label1.Text = "Invalid login";
            }
            conn.Close();
        }
    }
}

