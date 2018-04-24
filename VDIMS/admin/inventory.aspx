<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="inventory.aspx.cs" Inherits="VDIMS.admin.inventory" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Current Inventory</h1>
    <p><a class="left" href="add_vehicle.aspx">Add a vehicle</a></p>
    <% 
    
    do_table();

    %>
</asp:Content>