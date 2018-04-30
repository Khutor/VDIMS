using System;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

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
            DataTable dt = new DataTable();
            var sql = "";
            if (Request.Url.AbsoluteUri.Contains("all"))
                sql = "SELECT IMN, MAKE, MODEL, VEHICLE_YEAR, EXTERIOR_COLOR, VEHICLE_CONDITION, PRICE, DEALERSHIP_ID FROM VEHICLE";
            else
                sql = "SELECT IMN, MAKE, MODEL, YEAR, EXTERIOR_COLOR, CONDITION, PRICE, DEALERSHIP_ID FROM VEHICLE WHERE MAKE LIKE '" + make + "' AND MODEL LIKE '" + model + "' AND YEAR = " + year + " AND EXTERIOR_COLOR LIKE '" + color + "' AND PRICE > " + minPrice + " AND PRICE < " + maxPrice + " AND CONDITION = '" + condition + "' AND DEALERSHIP_ID = " + location;

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (dt.Rows.Count > 0)
            {
                reader = cmd.ExecuteReader();
                Response.Write(@"<p>Below this is where a table will go to show results IF and only if => 1 result is found</p>
                <table class='table'><thead><tr>
                                            <th scope='col'>IMN</th>
                                            <th scope='col'>Condition</th>
                                            <th scope='col'>Make</th>
                                            <th scope='col'>Model</th>
                                            <th scope='col'>Year</th>
                                            <th scope='col'>Color</th>
                                            <th scope='col'>Price</th>
                                            <th scope='col'>Location</th>
                                            <th scope='col'></th>
                                        </tr></thead><tbody>"
                    while(reader.Read() {
                    Response.Write(@"<tr>"+ whtaeverthemaketextisthatyougotfromthedb.text "</tr>"
                                        +"<tr></tr>");
                    }
                   //run a for loop generating
                   //table body andtable rows for
                   //each vehicle returned by the search
                   //with the rightmost column being a view
                   //link to vehicle info page

                   + "</tbody></table>");
            }
            else
            {
                Response.Write("<p>SHIT DOESN'T WORK FAM</p>");
            }


        }

        /*protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("server=undcsmysql.mysql.database.azure.com;user id=tyler.w.clark@undcsmysql;password=Tyler5566;persistsecurityinfo=True;database=tyler_w_clark");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT USER_ID, USER_EMAIL FROM USERS", conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            Repeater1.Visible = true;
            conn.Close();
        }
        */
    }
}