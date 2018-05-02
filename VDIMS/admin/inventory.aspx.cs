using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace VDIMS.admin
{

    public partial class inventory : System.Web.UI.Page
    {
        private String cString = "ADD ME";
        protected void page_load(object sender, EventArgs e)
        {
            if (Session["Logged"].Equals("Yes") && Session["IS_ADMIN"].Equals("true"))
            {
                if (!this.IsPostBack)
                {
                    try
                    {
                        using (MySqlConnection con = new MySqlConnection(cString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM VEHICLE"))
                            {
                                using (MySqlDataAdapter da = new MySqlDataAdapter())
                                {
                                    cmd.Connection = con;
                                    da.SelectCommand = cmd;
                                    using (DataTable dt = new DataTable())
                                    {
                                        da.Fill(dt);
                                        VehicleGridView.DataSource = dt;
                                        VehicleGridView.DataBind();
                                    }
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        msgTxt.ForeColor = System.Drawing.Color.Red;
                        msgTxt.Text = "Inventory could not be displayed; refer to below error message:" + "<br />" + ex.ToString();
                    }
                }
            }
            else
            {
                Response.Redirect("~/sign_in.aspx");
            }
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
               server control at run time. */
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/admin/backend.aspx");
        }
    }
}
