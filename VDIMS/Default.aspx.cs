using System;
using System.Web;
using System.Web.UI;

namespace VDIMS
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Logged"].Equals("Yes"))
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                String name = Session["USER_NAME"].ToString();
                welcTxt.Text = "Welcome, " + name;
                
            }
            else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
        }
    }
}
