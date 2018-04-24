using System;
using System.Web;
using System.Web.UI;

namespace VDIMS.user
{

    public partial class account : System.Web.UI.Page
    {
        public void admin_controls()
        {
            //create link to admin controls if admin but for now
            Response.Write("<p><a href='#'>Admin Controls</a></p>");
        }
        public void do_fav_table()
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
