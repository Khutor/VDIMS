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

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Logged"].Equals("Yes"))
            {
                
                String IMN = Request.QueryString["IMN"];
                carImage.ImageUrl = "~/images/" + IMN + ".jpg";
                carImage.Width = 500;
                carImage.Height = 250;

                String sql = "SELECT IMN, VIN, MAKE, MODEL, VEHICLE_YEAR, MILEAGE, EXTERIOR_COLOR, INTERIOR_COLOR FROM VEHICLE WHERE IMN = " + IMN;
                String sql2 = "SELECT TRANSMISSION, VEHICLE_CONDITION, DEALERSHIP_ID, HIGHWAY_MPG, CITY_MPG, PRICE, VEHICLE_ENGINE FROM VEHICLE WHERE IMN = " + IMN;
                String cString = "ADD ME";
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
                Response.Redirect("~/sign_in.aspx");
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
            String IMN = Request.QueryString["IMN"];
            String ID = Session["USER_ID"].ToString();
            MySqlConnection conn = new MySqlConnection("ADD ME");
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            var sql = "INSERT INTO FAVORITES VALUES(@ID, @IMN)";
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@ID", ID);
            comm.Parameters.AddWithValue("@IMN", IMN);
            comm.ExecuteNonQuery();
            conn.Close();
            msgTxt.Text = "Added to favorites successfully";
        }
    }
}
