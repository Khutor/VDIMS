using System;
using System.Web;
using System.Web.UI;

namespace VDIMS.admin
{

    public partial class add_vehicle : System.Web.UI.Page
    {
    protected void addButton_Click(object sender, EventArgs e)
        {
                StringBuilder sb = new StringBuilder();


           
                MySqlConnection conn = new MySqlConnection("server=SERVER;user id=ID;password=PWORD;persistsecurityinfo=True;database=DB");
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                String make = Make.Text;
                String model = Model.Text;
                String year = Year.Text;
                String extColor = ExtColor.Text;
                String intColor = IntColor.Text;
                String condition = Condition.SelectedValue;
                int mileage = int.Parse(Mileage.Text);
                int cMpg = int.Parse(CityMpg.Text);
                int hMpg = int.Parse(HighwayMpg.Text);
                String engine = Engine.Text;
                String transmission = Transmission.Text;
                int location = int.Parse(Location.SelectedValue);
                int price = int.Parse(Price.Text);
                string vin = Vin.Text;

                var sql = "INSERT INTO VEHICLE(IMN, VIN, MAKE, MODEL, VEHICLE_YEAR, MILEAGE, EXTERIOR_COLOR, INTERIOR_COLOR, TRANSMISSION, VEHICLE_CONDITION, DEALERSHIP_ID, HIGHWAY_MPG, CITY_MPG, PRICE, VEHICLE_ENGINE) VALUES(@IMN, @vin, @make, @model, @year, @mileage, @extColor, @intColor, @transmission, @condition, @location, @hMpg, @cMpg, @price, @engine)";
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
                comm.ExecuteNonQuery();
                conn.Close();    
        }
    }
}
