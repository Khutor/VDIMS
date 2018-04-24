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
            MySqlConnection conn = new MySqlConnection("server=SERVER;user id=ID;password=PWORD;persistsecurityinfo=True;database=DB");
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            String name = nameTxt.Text;
            int phone = int.Parse(phoneTxt.Text);
            String email = emailTxt.Text;
            String pword = passwordTxt.Text;
            Boolean admin = false;
            int cars = 0;
            var sql = "INSERT INTO USERS(USER_PHONE_NUMBER, USER_EMAIL, USER_NAME, USER_PASSWORD, IS_ADMIN, WATCHED_VEHICLES) VALUES(@phone, @email, @name, @pword, @admin, @cars)";
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@phone", phone);
            comm.Parameters.AddWithValue("@email", email);
            comm.Parameters.AddWithValue("@name", name);
            comm.Parameters.AddWithValue("@pword", pword);
            comm.Parameters.AddWithValue("@admin", admin);
            comm.Parameters.AddWithValue("@cars", cars);
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}
