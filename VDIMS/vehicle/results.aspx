<%@ Page Language="C#" CodeFile="results.aspx.cs" MasterPageFile="/master_page.master" Inherits="VDIMS.vehicle.results" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Search Results</h1>
    <asp:GridView ID="gvSearch" runat="server" AllowPaging="True" CssClass= "table table-striped table-bordered table-condensed" AutoGenerateColumns="False">
        <Columns>
            <asp:HyperLinkField DataTextField="IMN" DataNavigateUrlFields="IMN" DataNavigateUrlFormatString="/vehicle/view.aspx?IMN={0}" HeaderText="IMN" Text="IMN" />
            <asp:BoundField DataField="Make" HeaderText="Make" />
            <asp:BoundField DataField="Model" HeaderText="Model" />
            <asp:BoundField DataField="Price" HeaderText="Price" />
        </Columns>
    </asp:GridView>
    <form id="backForm" runat="server">
        <asp:Button ID="backToSearch" Text="Back to Search" class="btn btn-lg btn-primary btn-block" CausesValidation="false" runat="server" OnClick="backToSearch_Click" /> <br />
        <asp:Label ID="msgTxt" runat="server" Text=""></asp:Label>
    </form>

</asp:Content>
