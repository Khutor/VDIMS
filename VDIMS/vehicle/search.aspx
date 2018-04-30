<%@ Page Language="C#" MasterPageFile="/master_page.master" CodeFile="search.aspx.cs" Inherits="VDIMS.vehicle.search" %>

<asp:Content runat="server" ContentPlaceHolderID="contentMain">
        <h1>Search for a vehicle in our inventory.</h1>
        <div class="container">
            <form id="searchform" runat="server">
            <div class="row">
                <div class="form-group col">
                    <asp:TextBox id="make" class="form-control" placeholder="Make" runat="server"></asp:TextBox>
                </div>
                <div class="form-group col">
                    <asp:TextBox id="model" class="form-control" placeholder="Model" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group col">
                    <asp:TextBox id="color" class="form-control" placeholder="Color" runat="server"></asp:TextBox>
                </div>
                <div class="form-group col">
                    <asp:TextBox id="year" class="form-control" placeholder="Year" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group col">
                    <asp:TextBox id="minprice" class="form-control" type=number placeholder="Min Price" runat="server"></asp:TextBox>
                </div>
                <div class="form-group col">
                    <asp:TextBox id="maxprice" class="form-control" type=number placeholder="Max Price" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group col">
                    <asp:DropDownList id="condition" class="form-control" runat="server">
                        <asp:ListItem Value="Any" Text="Any Condition"></asp:ListItem>
                        <asp:ListItem Value="New" Text="New"></asp:ListItem>
                        <asp:ListItem Value="Used" Text="Used"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group col">
                    <asp:DropDownList id="location" class="form-control" runat="server">
                        <asp:ListItem Value="0" Text="Any Location"></asp:ListItem>
                        <asp:ListItem Value="1" Text="Grand Forks"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Fargo"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Minot"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            
            <div class="row">

        <asp:Button id="searchButton" runat="server" Text="Search"  class="btn btn-lg btn-primary btn-block" OnClick="searchButton_Click"/>
                 </div>


            </form>
    </div>
</asp:Content>