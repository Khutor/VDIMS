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
                String condSql = "";
                String locSql = "";
                String priceSql = "(PRICE BETWEEN " + minPrice + " AND " + maxPrice + ")";
                String yearSql = "";
                if(!Request.Url.AbsoluteUri.Contains("all"))
                {
                    if (make.Equals(""))
                        make = "%";
                    if (model.Equals(""))
                        model = "%";
                    if (color.Equals(""))
                        color = "%";

                    if (year.Equals(""))
                        yearSql = "VEHICLE_YEAR LIKE '%'";
                    else
                        yearSql = "VEHICLE_YEAR = " + year;

                    if (condition.ToLower().Equals("both"))
                        condSql = "VEHICLE_CONDITION LIKE '%'";
                    else if (condition.ToLower().Equals("used"))
                        condSql = "VEHICLE_CONDITION = 'New'";
                    else
                        condSql = "VEHICLE_CONDITION = 'Used'";

                    if (location.Equals("0"))
                        locSql = "DEALERSHIP_ID LIKE '%'";
                    else if (location.Equals("1"))
                        locSql = "DEALERSHIP_ID = 1";
                    else if (location.Equals("2"))
                        locSql = "DEALERSHIP_ID = 2";
                    else
                        locSql = "DEALERSHIP_ID = 3";

                    sql = "SELECT IMN, MAKE, MODEL, PRICE FROM VEHICLE WHERE MAKE LIKE '" + make + "' AND MODEL LIKE '" + model + "' AND " + yearSql +  " AND EXTERIOR_COLOR LIKE '" + color + "%' AND " + priceSql + " AND " + condSql + " AND " + locSql;
                }
                else
                {
                    sql = "SELECT IMN, MAKE, MODEL, PRICE FROM VEHICLE";
                }
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