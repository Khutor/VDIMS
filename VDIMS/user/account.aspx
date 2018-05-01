<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="account.aspx.cs" Inherits="VDIMS.user.account" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>My Account</h1>

    <asp:Label ID="nameTxt" runat="server" Text="Name"></asp:Label><br />
    <asp:Label ID="emailTxt" runat="server" Text="Email"></asp:Label><br />
    <h2>Favorite Vehicles</h2>
    <asp:GridView ID="favorites" CssClass= "table table-striped table-bordered table-condensed" runat="server"></asp:GridView>
</asp:Content>
