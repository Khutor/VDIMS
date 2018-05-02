using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VDIMS.user
{

    public partial class account : System.Web.UI.Page
    {
        private String cString = "ADD ME";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Logged"].Equals("Yes") && Session["IS_ADMIN"].Equals("false"))
                {

                    nameTxt.Text = Session["USER_NAME"].ToString();
                    emailTxt.Text = Session["USER_EMAIL"].ToString();
                    String sql = "SELECT IMN FROM FAVORITES WHERE USER_ID = " + Session["USER_ID"].ToString() + " ORDER BY IMN";
                    using (MySqlConnection conn = new MySqlConnection(cString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            conn.Open();
                            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            favorites.DataSource = dt;
                            if(!IsPostBack)
                                favorites.DataBind();
                            conn.Close();
                        }
                    }
                }
                else
                {
                    Response.Redirect("~/sign_in.aspx");
                }
            } catch(MySqlException ex)
            {
                msgTxt.ForeColor = System.Drawing.Color.Red;
                msgTxt.Text = "An error has occurred loading favorites; refer to the following error message: " + "<br />" + ex.ToString();
            }

        }

        //protected void favorites_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    string pid = favorites.DataKeys[e.RowIndex].Values["IMN"].ToString();
        //    Label lbl0 = (Label)favorites.Rows[e.RowIndex].FindControl("IMN");
        //    msgTxt.Text = lbl0.Text.ToString();
        //    msgTxt.Text = "Yes";
        //    //MySqlCommand cmd = new MySqlCommand("DELETE FROM FAVORITES WHERE IMN");
        //    //favorites.DataBind();
        //}

        protected void favorites_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                // Retrieve the row index stored in the 
                // CommandArgument property.
                int index = Convert.ToInt32(e.CommandArgument);

                // Retrieve the row that contains the button 
                // from the Rows collection.
                msgTxt.Text = favorites.Rows[index].Cells[0].Text.ToString();

                // Add your code here
            }
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
               server control at run time. */
        }
    }
}
