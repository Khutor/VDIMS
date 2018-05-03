<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="account.aspx.cs" Inherits="VDIMS.user.account" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>My Account</h1>
    <asp:Label ID="msgTxt" runat="server" Text=""></asp:Label><br />
    <asp:Image ID="profile" ImageUrl="~/images/profile.png" Width="250" Height="250" runat="server" /><br />
    <asp:Label ID="nameTxt" runat="server"  Text="Name" Font-Size="Larger"></asp:Label><br />
    <asp:Label ID="emailTxt" runat="server" Font-Size="Larger" Text="Email"></asp:Label><br />
    <h2>Favorite Vehicles</h2>
    <asp:GridView ID="favorites" ShowHeaderWhenEmpty="true" DataKeyNames="IMN" autogeneratecolumns="false" OnRowCommand="favorites_RowCommand" CssClass= "table table-striped table-bordered table-condensed" runat="server"> 
        <Columns>
           <%--  <asp:CommandField HeaderText="Remove Favorite" DeleteText="Remove" ShowDeleteButton="true"/> --%>
            <asp:HyperLinkField DataTextField="IMN" DataNavigateUrlFields="IMN" DataNavigateUrlFormatString="/vehicle/view.aspx?IMN={0}&frmAcnt=true" HeaderText="Inventory #" Text="IMN" />
        </Columns> 
    </asp:GridView>
</asp:Content>
