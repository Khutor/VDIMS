using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VDIMS.vehicle
{

    public partial class search : System.Web.UI.Page
    {

        protected void searchButton_Click(object sender, EventArgs e)
        {
            String max = maxprice.Text;
            String min = minprice.Text;
            if (max == "")
                max = "1000000";
            if (min == "")
                min = "0";
            

            if (make.Text == "" && model.Text == "" && year.Text == "" && color.Text == "" && condition.SelectedValue == "Any" && location.SelectedIndex == 0)
                Response.Redirect("~/vehicle/results.aspx?all");
            else
                Response.Redirect("~/vehicle/results.aspx?make=" + make.Text + "&model=" + model.Text + "&year=" + year.Text + "&color=" + color.Text + "&minPrice=" + min + "&maxprice=" + max + "&condition=" + condition.SelectedIndex + "&location=" + location.SelectedIndex);
        }
    }
}
