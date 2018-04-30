using System;
using System.Web;
using System.Web.UI;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace VDIMS
{

    public partial class register : System.Web.UI.Page
    {

        protected void loginButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("ADD ME");
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            String name = nameTxt.Text;
            String phone = phoneTxt.Text;
            String email = emailTxt.Text;
            String pword = passwordTxt.Text;
            Boolean admin = false;
            var sql = "INSERT INTO USERS(USER_PHONE_NUMBER, USER_EMAIL, USER_NAME, USER_PASSWORD, IS_ADMIN) VALUES(@phone, @email, @name, @pword, @admin)";
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@phone", phone);
            comm.Parameters.AddWithValue("@email", email);
            comm.Parameters.AddWithValue("@name", name);
            comm.Parameters.AddWithValue("@pword", pword);
            comm.Parameters.AddWithValue("@admin", admin);
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}
