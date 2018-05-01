using System;
using System.Web;
using System.Web.UI;
namespace VDIMS
{
    public partial class master_page : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Logged"].Equals("Yes") && Session["IS_ADMIN"].Equals("false"))
            {
                signout.Visible = true;
                signin.Visible = false;
                userpage.Visible = true;
            } else if(Session["Logged"].Equals("Yes") && Session["IS_ADMIN"].Equals("true")) {
                signout.Visible = true;
                signin.Visible = false;
                userpage.Visible = false;
            }
            else
            {
                userpage.Visible = false;
                signout.Visible = false;
                signin.Visible = true;
            }
        }
    }
}
