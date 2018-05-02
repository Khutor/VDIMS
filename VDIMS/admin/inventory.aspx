<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="inventory.aspx.cs" Inherits="VDIMS.admin.inventory" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Current Inventory</h1>
    <p><a class="left" href="add_vehicle.aspx">Add a vehicle</a></p>
    <div style="min-width: 2000px; max-width: 2000px;">
        <asp:GridView style="margin-right:615px;" CssClass="table table-striped table-bordered table-condensed" ID="VehicleGridView" AllowSorting="True" AllowPaging ="True" 
            runat="server" DataKeyNames="IMN"
            AutoGenerateColumns="False" Width="670px" SelectedIndex="0"
            horizontalalign="Right">
            <Columns>
                <asp:hyperlinkfield headertext="Sell" Text="Sell" NavigateUrl="~/admin/sell_vehicle.aspx" />
                <asp:hyperlinkfield headertext="Update" Text="Update" NavigateUrl="~/admin/update_vehicle.aspx" />
                <asp:hyperlinkfield headertext="Delete" Text="Delete" NavigateUrl="~/admin/delete_vehicle.aspx" />
                <asp:BoundField DataField="IMN" HeaderText="IMN" ReadOnly="true"/>
                <asp:BoundField DataField="VIN" HeaderText="VIN" ReadOnly="true" />
                <asp:BoundField DataField="MAKE" HeaderText="Make" ReadOnly="true"/>
                <asp:BoundField DataField="MODEL" HeaderText="Model" ReadOnly="true"/>
                <asp:BoundField DataField="VEHICLE_YEAR" HeaderText="Year" ReadOnly="true"/>
                <asp:BoundField DataField="MILEAGE" HeaderText="Miles" ReadOnly="true"/>
                <asp:BoundField DataField="EXTERIOR_COLOR" HeaderText="Color(Exterior)" ReadOnly="true"/>
                <asp:BoundField DataField="INTERIOR_COLOR" HeaderText="Color(Interior)" ReadOnly="true"/>
                <asp:BoundField DataField="TRANSMISSION" HeaderText="Transmission" ReadOnly="true"/>
                <asp:BoundField DataField="VEHICLE_CONDITION" HeaderText="Condition" ReadOnly="true"/>
                <asp:BoundField DataField="DEALERSHIP_ID" HeaderText="Location" ReadOnly="true"/>
                <asp:BoundField DataField="HIGHWAY_MPG" HeaderText="MPG(Highway)" ReadOnly="true"/>
                <asp:BoundField DataField="CITY_MPG" HeaderText="MPG(City)" ReadOnly="true"/>
                <asp:BoundField DataField="PRICE" HeaderText="Price" ReadOnly="true"/>
                <asp:BoundField DataField="VEHICLE_ENGINE" HeaderText="Engine" ReadOnly="true"/>
            </Columns>
        </asp:GridView>
    </div>
    <br />
    <asp:Label ID="msgTxt" runat="server" Text=""></asp:Label><br />
    <a class="btn btn-primary" href="/admin/backend.aspx" role="button">Back to Backend Home</a>
</asp:Content>
