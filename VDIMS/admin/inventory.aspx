<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="inventory.aspx.cs" Inherits="VDIMS.admin.inventory" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Current Inventory</h1>
    <p><a class="left" href="add_vehicle.aspx">Add a vehicle</a></p>
   <table style="margin: 0 auto; width: 600px;">
            
            <%--vehicle inventory display--%>
            <tr>
                <td>
                    <asp:GridView ID="VehicleGridView" AllowSorting="True" AllowPaging ="True" 
                        runat="server" DataSourceID="SqlDataSource" DataKeyNames="IMN" 
                        AutoGenerateColumns="False" Width="700px" SelectedIndex="0" 
                        OnSelectedIndexChanged="VehicleGridView_SelectedIndexChanged" 
                        OnPageIndexChanged="VehicleGridView_PageIndexChanged" 
                        OnRowDeleted="VehicleGridView_RowDeleted" 
                        OnSorted ="VehicleGridView_Sorted" BackColor="White"
                        BorderColor="#000000" BorderStyle="Groove" BorderWidth="2px" CellPadding="5"
                        ForeColor="#000000" HeaderStyle-Font-Names="Calisto MT">
                        <Columns>
                            <asp:CommandField ShowSelectButton="true" ShowDeleteButton="true" />
                            <asp:BoundField DataField="IMN" HeaderText="IMN" ReadOnly="true" SortExpression="IMN"/>
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
                        <FooterStyle BackColor="#fff" />
                        <HeaderStyle BackColor="#fff" Font-Bold="true" ForeColor="#000" />
                        <PagerStyle BackColor="#fff" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#fff" />
                        <SelectedRowStyle BackColor="#fff" Font-Bold="True" ForeColor="#000" />
                        <SortedAscendingCellStyle BackColor="#fff" />
                        <SortedAscendingHeaderStyle BackColor="#fff" />
                        <SortedDescendingCellStyle BackColor="#fff" />
                        <SortedDescendingHeaderStyle BackColor="#fff" />
                    </asp:GridView>
                    
                </td>
            </tr>
        </table>
</asp:Content>
</asp:Content>