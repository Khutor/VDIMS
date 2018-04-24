<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="account.aspx.cs" Inherits="VDIMS.user.account" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Welcome!</h1>
        <p class="lead"><a href="/vehicle/search.aspx">Search</a> for vehicles.</p>
    <% 
        admin_controls();
    %>
    <p><a href="/admin/inventory.aspx">Admin Controls</a></p>
    <h3>Favorites</h3>
    <%
        do_fav_table();
    %>
</asp:Content>
