<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/master_page.master" CodeBehind="backend.aspx.cs" Inherits="VDIMS.admin.backend" %>

<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h2>Welcome to administrator backend</h2>
    <asp:Panel ID="panel" runat="server">
        <p class="lead">
            <asp:Label ID="welcome" runat="server" Text="Welcome Administrator"></asp:Label>
        </p>
        <p class="lead">Click <a href="/admin/user_list.aspx">here</a> to view users</p>
        <p class="lead">Click <a href="/admin/inventory.aspx">here</a> to view vehicle inventory</p>
        <p class="lead">Click <a href="/admin/sold_inventory.aspx">here</a> to view sold vehicle inventory</p>
    </asp:Panel>

</asp:Content>
