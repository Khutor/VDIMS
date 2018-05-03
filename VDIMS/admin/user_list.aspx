<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeBehind="user_list.aspx.cs" Inherits="VDIMS.admin.user_list" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Current Users</h1>
    <asp:GridView CssClass="table table-striped table-bordered table-condensed" ID="UserGridView" AllowPaging ="True" 
        runat="server" DataKeyNames="USER_ID" SelectedIndex="0"
        horizontalalign="Right">
        <Columns>
            <asp:hyperlinkfield headertext="Update" Text="Update" NavigateUrl="~/admin/update_user.aspx" />
            <asp:hyperlinkfield headertext="Delete" Text="Delete" NavigateUrl="~/admin/delete_user.aspx" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="msgTxt" runat="server" Text=""></asp:Label><br />
    <a class="btn btn-primary" href="/admin/backend.aspx" role="button">Back to Backend Home</a>
</asp:Content>
