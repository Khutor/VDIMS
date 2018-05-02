<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="update_vehicle.aspx.cs" Inherits="VDIMS.admin.update_vehicle" %>


<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Update Vehicle</h1>
    <p>All fields are required</p>
            <div class="container">
                <form id="searchform" runat="server">
                    <div>
                     <div class="row">
                        <div class="form-group col">
                            <asp:DropDownList autopostback="true" class="form-control" ID="IMNdrop" runat="server" OnSelectedIndexChanged="IMNdrop_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="make" class="form-control" required="true" placeholder="Make" runat="server" ></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="model" class="form-control" runat="server" required="true" placeholder="Model"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="year" class="form-control" runat="server" type="number" required="true" placeholder="Year"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="extColor" class="form-control" runat="server" required="true" placeholder="Exterior Color"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="intColor" class="form-control" runat="server" required="true" placeholder="Interior Color"></asp:TextBox>
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
                            <asp:TextBox id="Mileage" class="form-control" runat="server" type="number" required="true" placeholder="Mileage"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="cMpg" class="form-control" runat="server" type="number" required="true" placeholder="City MPG"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="hMpg" class="form-control" runat="server" type="number" required="true" placeholder="Highway MPG"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="engine" class="form-control" runat="server" required="true" placeholder="Engine"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="transmission" class="form-control" runat="server" required="true" placeholder="Transmission"></asp:TextBox>
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
                            <asp:TextBox id="price" class="form-control" runat="server" type="number" placeholder="Price"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="vin" class="form-control" runat="server" type="number" placeholder="VIN Number"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="img" class="form-control" runat="server" required="true" placeholder="Image.jpg"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                            <asp:Button id="updateButton" OnClientClick="return confirm('Update this vehicle?');" runat="server" Text="Update Vehicle"  class="btn btn-lg btn-primary btn-block" OnClick="updateButton_Click"/>
                        <br />
                        </div>
                    </div>
                    <asp:Label ID="msgTxt" runat="server" Text=""></asp:Label><br />
                    <asp:Button id="backBtn" runat="server" Text="Back to Inventory" UseSubmitBehavior="false" class="btn btn-lg btn-primary btn-block" CausesValidation="false" OnClick="backBtn_Click"/>
                </form>
            </div>
    </asp:Content>
