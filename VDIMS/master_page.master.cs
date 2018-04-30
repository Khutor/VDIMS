using System;
using System.Web;
using System.Web.UI;
namespace VDIMS
{
    public partial class master_page : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Logged"].Equals("Yes"))
            {
                signout.Visible = true;
                signin.Visible = false;
                userpage.Visible = true;
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
