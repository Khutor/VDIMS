<%@ Page Language="C#" MasterPageFile="/master_page.master" CodeFile="search.aspx.cs" Inherits="VDIMS.vehicle.search" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
        <h1>Search for a vehicle in our inventory.</h1>
        <div class="container">
            <form id="searchform" runat="server">
            <div class="row">
                <div class="form-group col">
                    <asp:TextBox id="make" class="form-control" runat="server">Make</asp:TextBox>
                </div>
                <div class="form-group col">
                    <asp:TextBox id="model" class="form-control" runat="server">Model</asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group col">
                    <asp:TextBox id="color" class="form-control" runat="server">Color</asp:TextBox>
                </div>
                <div class="form-group col">
                    <asp:TextBox id="year" class="form-control" runat="server">Year</asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group col">
                    <asp:TextBox id="minprice" class="form-control" runat="server">Min. Price</asp:TextBox>
                </div>
                <div class="form-group col">
                    <asp:TextBox id="maxprice" class="form-control" runat="server">Max. Price</asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group col">
                    <asp:DropDownList id="condition" class="form-control" runat="server">
                        <asp:ListItem Value="New" Text="New"></asp:ListItem>
                        <asp:ListItem Value="Used" Text="Used"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group col">
                    <asp:DropDownList id="location" class="form-control" runat="server">
                        <asp:ListItem Value="1" Text="Grand Forks"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Fargo"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Minot"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            
            <div class="row">

        <asp:Button id="searchButton" runat="server" Text="Search"  class="btn btn-lg btn-primary btn-block"/>
                 </div>


            </form>
    </div>
</asp:Content>