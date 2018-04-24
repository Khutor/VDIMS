<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="update_vehicle.aspx.cs" Inherits="VDIMS.admin.update_vehicle" %>


<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Update vehicle</h1>
    <p>All fields are required</p>
            <div class="container">
                <form id="searchform" runat="server">
                    <div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="make" class="form-control" placeholder="Make" runat="server" ></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="model" class="form-control" runat="server" placeholder="Model"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="year" class="form-control" runat="server" placeholder="Year"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="extColor" class="form-control" runat="server" placeholder="Exterior Color"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="intColor" class="form-control" runat="server" placeholder="Interior Color"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:DropDownList id="condition" class="form-control" runat="server" placeholder="Condition">
                                <asp:ListItem runat="server" Text="New" Value="New" />
                                <asp:ListItem runat="server" Text="Used" Value="Used" />
                            </asp:DropDownList>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="Mileage" class="form-control" runat="server" placeholder="Mileage"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="cMpg" class="form-control" runat="server" placeholder="City MPG"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="hMpg" class="form-control" runat="server" placeholder="Highway MPG"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="engine" class="form-control" runat="server" placeholder="Engine"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="transmission" class="form-control" runat="server" placeholder="Transmission"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:DropDownList id="location" class="form-control" runat="server" placeholder="Location">
                                <asp:ListItem runat="server" Text="Fargo" Value="1" />
                                <asp:ListItem runat="server" Text="Grand Forks" Value="2" />
                                <asp:ListItem runat="server" Text="Minot" Value="3" />
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="price" class="form-control" runat="server" placeholder="Price"></asp:TextBox>

                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="vin" class="form-control" runat="server" placeholder="VIN Number"></asp:TextBox>
                        </div>

                    </div>
                    <div class="row">
                            <asp:Button id="updateButton" runat="server" Text="Update Vehicle"  class="btn btn-lg btn-primary btn-block"/>
                        </div>
                    </div>
                </form>
            </div>
    </asp:Content>
