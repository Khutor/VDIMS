using System;
using System.Web;
using System.Web.UI;

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
                                    </tr></thead>"
                           //run a for loop generating
                           //table body andtable rows for
                           //each vehicle returned by the search
                           //with the rightmost column being a view
                           //link to vehicle info page

                           + "</table>");
        }

    }
}
