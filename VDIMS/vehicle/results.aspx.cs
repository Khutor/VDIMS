using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace VDIMS.vehicle
{

    public partial class results : System.Web.UI.Page
    {
        private String cString = "ADD ME";

        //public void do_params()
        //{
        //    Response.Write("<p>this is where the search params will be listed (csv style)</p>");
        //}
        //public void do_table()
        //{
        //    String make = Request.QueryString["make"];
        //    String model = Request.QueryString["model"];
        //    String year = Request.QueryString["year"];
        //    String color = Request.QueryString["color"];
        //    String minPrice = Request.QueryString["minPrice"];
        //    String maxPrice = Request.QueryString["maxPrice"];
        //    String condition = Request.QueryString["condition"];
        //    String location = Request.QueryString["location"];

        //    MySqlConnection conn = new MySqlConnection(cString);
        //    conn.Open();
        //    DataTable dt2 = new DataTable();
        //    var sql = "";
        //    if (Request.Url.AbsoluteUri.Contains("all"))
        //        sql = "SELECT IMN, MAKE, MODEL, VEHICLE_YEAR, EXTERIOR_COLOR, VEHICLE_CONDITION, PRICE, DEALERSHIP_ID FROM VEHICLE";
        //    else
        //        sql = "SELECT IMN, MAKE, MODEL, YEAR, EXTERIOR_COLOR, CONDITION, PRICE, DEALERSHIP_ID FROM VEHICLE WHERE MAKE LIKE '" + make + "' AND MODEL LIKE '" + model + "' AND YEAR = " + year + " AND EXTERIOR_COLOR LIKE '" + color + "' AND PRICE > " + minPrice + " AND PRICE < " + maxPrice + " AND CONDITION = '" + condition + "' AND DEALERSHIP_ID = " + location;

        //    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
        //    adapter.Fill(dt2);
        //    MySqlDataReader reader;
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    if (dt2.Rows.Count > 0)
        //    {
        //        reader = cmd.ExecuteReader();

        //    }
        //    else
        //    {

        //    }


        //}

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                this.BindRepeater();
            }
       }

        private void BindRepeater()
        {
            try
            {
                String make = Request.QueryString["make"];
                String model = Request.QueryString["model"];
                String year = Request.QueryString["year"];
                String color = Request.QueryString["color"];
                String minPrice = Request.QueryString["minPrice"];
                String maxPrice = Request.QueryString["maxPrice"];
                String condition = Request.QueryString["condition"];
                String location = Request.QueryString["location"];
                var sql = "";
                if (Request.Url.AbsoluteUri.Contains("all"))
                    sql = "SELECT IMN, MAKE, MODEL, PRICE FROM VEHICLE";
                else
                    sql = "SELECT IMN, MAKE, MODEL WHERE MAKE LIKE '" + make + "' AND MODEL LIKE '" + model + "' AND VEHICLE_YEAR = " + year + " AND EXTERIOR_COLOR LIKE '" + color + "' AND PRICE > " + minPrice + " AND PRICE < " + maxPrice + " AND VEHICLE_CONDITION = '" + condition + "' AND DEALERSHIP_ID = " + location;

                using (MySqlConnection con = new MySqlConnection(cString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            gvSearch.DataSource = dt;
                            gvSearch.DataBind();
                        }
                    }
                }
            } catch(MySqlException ex)
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

        protected void backToSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("/vehicle/search.aspx");
        }
    }
}