using System;
using System.Web;
using System.Web.UI;

namespace VDIMS
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Logged"].Equals("Yes") && Session["IS_ADMIN"].Equals("false"))
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                Panel3.Visible = false;
                String name = Session["USER_NAME"].ToString();
                welcTxt.Text = "Welcome, " + name;
                
            } else if(Session["Logged"].Equals("Yes") && Session["IS_ADMIN"].Equals("true"))
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = true;
            }
            else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
                Panel3.Visible = false;
            }
        }
    }
}
