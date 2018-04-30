<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="view.aspx.cs" Inherits="VDIMS.vehicle.view" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <%-- 
    do_titlecard(); 
    do_vehiclecard();
    --%>

    <asp:Image ID="carImage" runat="server" />
    <br /><br />
    <asp:GridView ID="carDetails" CssClass= "table table-striped table-bordered table-condensed" runat="server"></asp:GridView>
    <br />
    <asp:GridView ID="carDetails2" CssClass= "table table-striped table-bordered table-condensed" runat="server"></asp:GridView>
    <br /><br />
    <asp:Button ID="Button1" class="btn btn-lg btn-primary btn-block" runat="server" Text="Back to Results" OnClick="Button1_Click" />
        
</asp:Content>
