<%@ Page Language="C#" CodeFile="results.aspx.cs" MasterPageFile="/master_page.master" Inherits="VDIMS.vehicle.results" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Search Results</h1>
    <asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
        <table cellspacing="0" rules="all" border="1">
            <tr>
                <th scope="col" style="width: 80px">
                    IMN
                </th>
                <th scope="col" style="width: 120px">
                    Make
                </th>
                <th scope="col" style="width: 100px">
                    Model
                </th>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td>
                <asp:HyperLink ID="lblIMN" runat=server NavigateUrl='<%# DataBinder.Eval(Container.DataItem, "IMN", "view.aspx?IMN={0}") %>'> <%# DataBinder.Eval(Container.DataItem, "IMN") %>' </asp:HyperLink>
            </td>
            <td>
                <asp:Label ID="lblMake" runat="server" Text='<%# Eval("MAKE") %>' />
            </td>
            <td>
                <asp:Label ID="lblModel" runat="server" Text='<%# Eval("MODEL") %>' />
            </td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>
</asp:Content>
