using System;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.Web.SessionState;

namespace VDIMS
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
        }

        protected void Session_Start(Object sender, EventArgs e)
        {
            //Define new 3 Sessions
            //The first Session "Logged" which is an indicator to the status of the user
            Session["Logged"] = "No";
            //The second Session "User" stores the name of the current user
            Session["USER_NAME"] = "";
            Session["USER_ID"] = "";
            Session["IS_ADMIN"] = "false";
            //The third Session "URL" stores the URL of the requested WebForm before Logging In
            Session["URL"] = "Default.aspx";
        }
    }
}
