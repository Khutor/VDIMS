using System;
using System.Web;
using System.Web.UI;

namespace VDIMS.admin
{

    public partial class inventory : System.Web.UI.Page
    {
        public void do_table()
        {
            Response.Write("<p>This is going to a select all statement for the inventory similar to the general search results</p>");
        }
    }
}
