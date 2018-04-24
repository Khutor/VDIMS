using System;
using System.Web;
using System.Web.UI;

namespace VDIMS.vehicle
{

    public partial class view : System.Web.UI.Page
    {
        public void do_titlecard()
        {

            Response.Write("<h1>Make Model</h1><h3>Price | Condition</h3>");
        }

        public void do_vehiclecard()
        {

            Response.Write("<p>This is where everything else goes</p>");
        }
    }
}
