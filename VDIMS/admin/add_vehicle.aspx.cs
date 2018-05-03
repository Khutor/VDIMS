using System;
using System.Web;
using System.Web.UI;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Collections.Generic;

namespace VDIMS.admin
{

    public partial class add_vehicle : System.Web.UI.Page
    {
        private String cString = "ADD ME";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Logged"].Equals("Yes") && Session["IS_ADMIN"].Equals("true"))
            {

            }
            else
            {
                Response.Redirect("~/sign_in.aspx");
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                MySqlConnection conn = new MySqlConnection(cString);
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                String make = Make.Text;
                String model = Model.Text;
                String year = Year.Text;
                String extColor = ExtColor.Text;
                String intColor = IntColor.Text;
                String condition = Condition.SelectedValue;
                int mileage = Math.Abs(int.Parse(Mileage.Text));
                int cMpg = Math.Abs(int.Parse(CityMpg.Text));
                int hMpg = Math.Abs(int.Parse(HighwayMpg.Text));
                String engine = Engine.Text;
                String transmission = Transmission.Text;
                int location = int.Parse(Location.SelectedValue);
                int price = Math.Abs(int.Parse(Price.Text));
                string vin = Vin.Text;
                String fileName;
                if (uploader.HasFile)
                {
                    fileName = Path.GetFileName(uploader.PostedFile.FileName);
                    uploader.PostedFile.SaveAs(Server.MapPath("~/images/") + fileName);
                    var sql = "INSERT INTO VEHICLE VALUES(@IMN, @vin, @make, @model, @year, @mileage, @extColor,  @intColor, @transmission, @condition, @location, @hMpg, @cMpg, @price, @engine, @image)";
                    comm.CommandText = sql;
                    comm.Parameters.AddWithValue("@IMN", DBNull.Value);
                    comm.Parameters.AddWithValue("@vin", vin);
                    comm.Parameters.AddWithValue("@make", make);
                    comm.Parameters.AddWithValue("@model", model);
                    comm.Parameters.AddWithValue("@year", year);
                    comm.Parameters.AddWithValue("@mileage", mileage);
                    comm.Parameters.AddWithValue("@extColor", extColor);
                    comm.Parameters.AddWithValue("@intColor", intColor);
                    comm.Parameters.AddWithValue("@transmission", transmission);
                    comm.Parameters.AddWithValue("@condition", condition);
                    comm.Parameters.AddWithValue("@location", location);
                    comm.Parameters.AddWithValue("@hMpg", hMpg);
                    comm.Parameters.AddWithValue("@cMpg", cMpg);
                    comm.Parameters.AddWithValue("@price", price);
                    comm.Parameters.AddWithValue("@engine", engine);
                    comm.Parameters.AddWithValue("@image", fileName);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    fileName = "missing.png";
                    var sql = "INSERT INTO VEHICLE VALUES(@IMN, @vin, @make, @model, @year, @mileage, @extColor, @intColor, @transmission, @condition, @location, @hMpg, @cMpg, @price, @engine, @image)";
                    comm.CommandText = sql;
                    comm.Parameters.AddWithValue("@IMN", DBNull.Value);
                    comm.Parameters.AddWithValue("@vin", vin);
                    comm.Parameters.AddWithValue("@make", make);
                    comm.Parameters.AddWithValue("@model", model);
                    comm.Parameters.AddWithValue("@year", year);
                    comm.Parameters.AddWithValue("@mileage", mileage);
                    comm.Parameters.AddWithValue("@extColor", extColor);
                    comm.Parameters.AddWithValue("@intColor", intColor);
                    comm.Parameters.AddWithValue("@transmission", transmission);
                    comm.Parameters.AddWithValue("@condition", condition);
                    comm.Parameters.AddWithValue("@location", location);
                    comm.Parameters.AddWithValue("@hMpg", hMpg);
                    comm.Parameters.AddWithValue("@cMpg", cMpg);
                    comm.Parameters.AddWithValue("@price", price);
                    comm.Parameters.AddWithValue("@engine", engine);
                    comm.Parameters.AddWithValue("@image", fileName);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
                msgTxt.ForeColor = System.Drawing.Color.Empty;
                msgTxt.Text = "Vehicle successfully added to the database";
            } catch(MySqlException ex)
            {
                msgTxt.ForeColor = System.Drawing.Color.Red;
                msgTxt.Text = "Vehicle could not be added; refer to the below error message:" + "<br />" + ex.ToString();
            }

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/inventory.aspx");
        }
    }
}
