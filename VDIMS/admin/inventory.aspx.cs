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
        protected void page_load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string constr = "ADD ME";
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Vehicle"))
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
        }


        protected void VehicleGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehicleGridView.DataBind();
        }
        protected void VehicleGridView_PageIndexChanged(object sender, EventArgs e)
        {
            VehicleGridView.DataBind();
        }
        protected void VehicleGridView_RowDeleted(object sender, EventArgs e) 
        {
            VehicleGridView.DataBind();
        }
        protected void VehicleGridView_Sorted(object sender, EventArgs e)
        {
            VehicleGridView.DataBind();
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
