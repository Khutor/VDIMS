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

            var cond = condition.SelectedValue;
            if (cond.Equals("Any"))
                cond = "Both";

            String minT = minprice.Text;
            String maxT = maxprice.Text;
            if (make.Text == "" && model.Text == "" && year.Text == "" && color.Text == "" && cond.Equals("Both") && location.SelectedIndex == 0 && maxT.Equals("") && minT.Equals(""))
                Response.Redirect("~/vehicle/results.aspx?all");
            else
                Response.Redirect("~/vehicle/results.aspx?make=" + make.Text + "&model=" + model.Text + "&year=" + year.Text + "&color=" + color.Text + "&minPrice=" + min + "&maxprice=" + max + "&condition=" + cond + "&location=" + location.SelectedIndex);
        }
    }
}
