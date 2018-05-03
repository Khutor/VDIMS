using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VDIMS.admin
{

    public partial class update_user : System.Web.UI.Page
    {
        private String cString = "ADD ME";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Logged"].Equals("Yes") && Session["IS_ADMIN"].Equals("true"))
            {
                if (!IsPostBack)
                {
                    try
                    {
                        String UID = Session["USER_ID"].ToString();
                        MySqlConnection conn = new MySqlConnection(cString);
                        DataSet ds = new DataSet();
                        var sql = "SELECT USER_ID FROM USERS WHERE NOT USER_ID = " + UID + " ORDER BY USER_ID";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                            da.Fill(ds, "USERS");
                        UIDdrop.DataSource = ds.Tables["USERS"];
                        UIDdrop.DataValueField = "USER_ID";
                        UIDdrop.DataTextField = "USER_ID";
                        UIDdrop.DataBind();
                        conn.Close();
                        UIDdrop.Items.Insert(0, new ListItem("Select User ID", "0"));
                    }
                    catch (MySqlException ex)
                    {
                        msgTxt.ForeColor = System.Drawing.Color.Red;
                        msgTxt.Text = "An error has occurred:" + "<br />" + ex.ToString();
                    }
                }
            }
            else
            {
                Response.Redirect("~/sign_in.aspx");
            }
        }

        protected void UIDdrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM USERS WHERE USER_ID = " + UIDdrop.SelectedItem.ToString();
                MySqlConnection conn = new MySqlConnection(cString);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = null;
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    name.Text = reader["USER_NAME"].ToString();
                    email.Text = reader["USER_EMAIL"].ToString();
                    phone.Text = reader["USER_PHONE_NUMBER"].ToString();
                    pass.Text = reader["USER_PASSWORD"].ToString();
                    admin.Text = reader["IS_ADMIN"].ToString();
                }
                reader.Close();
                reader.Dispose();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
            catch (MySqlException)
            {
                Response.Redirect("update_vehicle.aspx");
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cString);
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                String UID = UIDdrop.SelectedValue;
                String name1 = name.Text;
                String email1 = email.Text;
                String pass1 = pass.Text;
                String phone1 = phone.Text;
                String admin1 = admin.Text;
                var sql = "UPDATE USERS SET USER_NAME = @name1, USER_EMAIL = @email1, USER_PASSWORD = @pass1, USER_PHONE_NUMBER = @phone1, IS_ADMIN = @admin1 WHERE USER_ID = " + UID;
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@name1", name1);
                comm.Parameters.AddWithValue("@email1", email1);
                comm.Parameters.AddWithValue("@pass1", pass1);
                comm.Parameters.AddWithValue("@phone1", phone1);
                comm.Parameters.AddWithValue("@admin1", admin1);
                comm.ExecuteNonQuery();
                conn.Close();
                msgTxt.ForeColor = System.Drawing.Color.Empty;
                msgTxt.Text = "User successfully updated in the database";
            }
            catch (MySqlException ex)
            {
                msgTxt.ForeColor = System.Drawing.Color.Red;
                msgTxt.Text = "User could not be updated; refer to the below error message:" + "<br />" + ex.ToString();
            }

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/user_list.aspx");
        }
    }
}

