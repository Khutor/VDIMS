<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="sold_inventory.aspx.cs" Inherits="VDIMS.admin.sold_inventory" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Sold Vehicle Inventory</h1>
    <p><a class="left" href="sell_vehicle.aspx">Mark a vehicle as sold</a></p>
    <div style="min-width: 2000px; max-width: 2000px;">
        <asp:GridView style="margin-right:700px;" CssClass="table table-striped table-bordered table-condensed" ID="VehicleGridView" AllowSorting="True" AllowPaging ="True" 
            runat="server" DataKeyNames="IMN"
            AutoGenerateColumns="False" Width="670px" SelectedIndex="0" 
            horizontalalign="Right">
            <Columns>
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
