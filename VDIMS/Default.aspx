<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="~/Default.aspx.cs" Inherits="VDIMS.Default" %>

<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Welcome to our <br/>vehicle dealership webpage.</h1>
    <asp:Panel visible="true" ID="Panel1" runat="server">
        <p class="lead"><a href="/vehicle/search.aspx">Search</a> for vehicles or <a href="sign_in.aspx">sign in.</a></p>
    </asp:Panel>

    <asp:Panel visible="false" ID="Panel2" runat="server">
        <p class="lead">
            <asp:Label ID="welcTxt" runat="server" Text=""></asp:Label>
        </p>
        <p class="lead"><a href="/vehicle/search.aspx">Search</a> for vehicles</p>
    </asp:Panel>
</asp:Content>
