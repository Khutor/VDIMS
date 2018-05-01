using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VDIMS.vehicle
{

    public partial class view : System.Web.UI.Page
    {
        private String cString = "ADD ME";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Logged"].Equals("Yes"))
                {
                    String IMN = Request.QueryString["IMN"];
                    String sql3 = "SELECT IMAGE FROM VEHICLE WHERE IMN = " + IMN;
                    String img = "";
                    using (MySqlConnection conn2 = new MySqlConnection(cString))
                    {
                        using (MySqlCommand cmd3 = new MySqlCommand(sql3, conn2))
                        {
                            conn2.Open();
                            MySqlDataReader dr = cmd3.ExecuteReader(CommandBehavior.CloseConnection);
                            while (dr.Read())
                                img = dr["IMAGE"].ToString();
                            conn2.Close();
                        }
                    }

                    carImage.ImageUrl = "~/images/" + img;
                    carImage.Width = 500;
                    carImage.Height = 250;

                    String sql = "SELECT IMN, VIN, MAKE, MODEL, VEHICLE_YEAR, MILEAGE, EXTERIOR_COLOR, INTERIOR_COLOR FROM VEHICLE WHERE IMN = " + IMN;
                    String sql2 = "SELECT TRANSMISSION, VEHICLE_CONDITION, DEALERSHIP_ID, HIGHWAY_MPG, CITY_MPG, PRICE, VEHICLE_ENGINE FROM VEHICLE WHERE IMN = " + IMN;

                    using (MySqlConnection conn = new MySqlConnection(cString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            conn.Open();
                            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            carDetails.DataSource = dt;
                            carDetails.DataBind();
                            conn.Close();
                        }

                        using (MySqlCommand cmd = new MySqlCommand(sql2, conn))
                        {
                            conn.Open();
                            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            carDetails2.DataSource = dt;
                            carDetails2.DataBind();
                            conn.Close();
                        }
                    }
                }
                else
                {
                    favorite.Visible = false;
                    String IMN = Request.QueryString["IMN"];
                    String sql3 = "SELECT IMAGE FROM VEHICLE WHERE IMN = " + IMN;
                    String img = "";
                    using (MySqlConnection conn2 = new MySqlConnection(cString))
                    {
                        using (MySqlCommand cmd3 = new MySqlCommand(sql3, conn2))
                        {
                            conn2.Open();
                            MySqlDataReader dr = cmd3.ExecuteReader(CommandBehavior.CloseConnection);
                            while (dr.Read())
                                img = dr["IMAGE"].ToString();
                            conn2.Close();
                        }
                    }

                    carImage.ImageUrl = "~/images/" + img;
                    carImage.Width = 500;
                    carImage.Height = 250;

                    String sql = "SELECT IMN, VIN, MAKE, MODEL, VEHICLE_YEAR, MILEAGE, EXTERIOR_COLOR, INTERIOR_COLOR FROM VEHICLE WHERE IMN = " + IMN;
                    String sql2 = "SELECT TRANSMISSION, VEHICLE_CONDITION, DEALERSHIP_ID, HIGHWAY_MPG, CITY_MPG, PRICE, VEHICLE_ENGINE FROM VEHICLE WHERE IMN = " + IMN;

                    using (MySqlConnection conn = new MySqlConnection(cString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            conn.Open();
                            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            carDetails.DataSource = dt;
                            carDetails.DataBind();
                            conn.Close();
                        }

                        using (MySqlCommand cmd = new MySqlCommand(sql2, conn))
                        {
                            conn.Open();
                            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            carDetails2.DataSource = dt;
                            carDetails2.DataBind();
                            conn.Close();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                msgTxt.ForeColor = System.Drawing.Color.Red;
                msgTxt.Text = "An error has occurred; refer to the following error message: " + "<br />" + ex.ToString(); 
            }
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
               server control at run time. */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/vehicle/results.aspx?all");
        }

        protected void favorite_Click(object sender, EventArgs e)
        {
            try
            {
                String IMN = Request.QueryString["IMN"];
                String ID = Session["USER_ID"].ToString();
                MySqlConnection conn = new MySqlConnection(cString);
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                var sql = "INSERT INTO FAVORITES VALUES(@ID, @IMN)";
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@ID", ID);
                comm.Parameters.AddWithValue("@IMN", IMN);
                comm.ExecuteNonQuery();
                conn.Close();
                msgTxt.ForeColor = System.Drawing.Color.Empty;
                msgTxt.Text = "Added to favorites successfully";
            }
            catch (MySqlException ex)
            {
                msgTxt.ForeColor = System.Drawing.Color.Red;
                msgTxt.Text = "Error has occurred adding to favorites; refer to error below: " + "<br />" + ex.ToString(); ;
            }

        }
    }
}
