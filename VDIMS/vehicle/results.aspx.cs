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
        public void do_params()
        {
            Response.Write("<p>this is where the search params will be listed (csv style)</p>");
        }
        public void do_table()
        {
            String make = Request.QueryString["make"];
            String model = Request.QueryString["model"];
            String year = Request.QueryString["year"];
            String color = Request.QueryString["color"];
            String minPrice = Request.QueryString["minPrice"];
            String maxPrice = Request.QueryString["maxPrice"];
            String condition = Request.QueryString["condition"];
            String location = Request.QueryString["location"];

            MySqlConnection conn = new MySqlConnection("ADD ME");
            conn.Open();
            DataTable dt2 = new DataTable();
            var sql = "";
            if (Request.Url.AbsoluteUri.Contains("all"))
                sql = "SELECT IMN, MAKE, MODEL, VEHICLE_YEAR, EXTERIOR_COLOR, VEHICLE_CONDITION, PRICE, DEALERSHIP_ID FROM VEHICLE";
            else
                sql = "SELECT IMN, MAKE, MODEL, YEAR, EXTERIOR_COLOR, CONDITION, PRICE, DEALERSHIP_ID FROM VEHICLE WHERE MAKE LIKE '" + make + "' AND MODEL LIKE '" + model + "' AND YEAR = " + year + " AND EXTERIOR_COLOR LIKE '" + color + "' AND PRICE > " + minPrice + " AND PRICE < " + maxPrice + " AND CONDITION = '" + condition + "' AND DEALERSHIP_ID = " + location;

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            adapter.Fill(dt2);
            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (dt2.Rows.Count > 0)
            {
                reader = cmd.ExecuteReader();

            }
            else
            {

            }


        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                this.BindRepeater();
            }
       }
        private void BindRepeater()
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
                sql = "SELECT IMN, MAKE, MODEL FROM VEHICLE";
            else
                sql = "SELECT IMN, MAKE, MODEL WHERE MAKE LIKE '" + make + "' AND MODEL LIKE '" + model + "' AND YEAR = " + year + " AND EXTERIOR_COLOR LIKE '" + color + "' AND PRICE > " + minPrice + " AND PRICE < " + maxPrice + " AND CONDITION = '" + condition + "' AND DEALERSHIP_ID = " + location;

            string constr = "ADD ME";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        Repeater1.DataSource = dt;
                        Repeater1.DataBind();
                    }
                }
            }
        }
    }
}