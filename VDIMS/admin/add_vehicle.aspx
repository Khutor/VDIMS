<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="add_vehicle.aspx.cs" Inherits="VDIMS.admin.add_vehicle" %>


<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Add Vehicle</h1>
    <p>All fields are required</p>
            <div class="container">
                <form id="searchform" runat="server">
                    <div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="Make" class="form-control" required="true" placeholder="Make" runat="server" ></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="Model" class="form-control" required="true" runat="server" placeholder="Model"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="Year" class="form-control" required="true" type="number" runat="server" placeholder="Year"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="ExtColor" class="form-control" require="true" runat="server" placeholder="Exterior Color"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="IntColor" class="form-control" required="true" runat="server" placeholder="Interior Color"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:DropDownList id="Condition" class="form-control" runat="server" placeholder="Condition">
                                <asp:ListItem runat="server" Text="New" Value="New" />
                                <asp:ListItem runat="server" Text="Used" Value="Used" />
                            </asp:DropDownList>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="Mileage" class="form-control" required="true" type="number" runat="server" placeholder="Mileage"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="CityMpg" class="form-control" required="true" type="number" runat="server" placeholder="City MPG"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="HighwayMpg" class="form-control" required="true" type="number" runat="server" placeholder="Highway MPG"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="Engine" class="form-control" required="true" runat="server" placeholder="Engine"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="Transmission" class="form-control" required="true" runat="server" placeholder="Transmission"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:DropDownList id="Location" class="form-control" runat="server" placeholder="Location">
                                <asp:ListItem runat="server" Text="Fargo" Value="1" />
                                <asp:ListItem runat="server" Text="Grand Forks" Value="2" />
                                <asp:ListItem runat="server" Text="Minot" Value="3" />
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="Price" class="form-control" required="true" type="number" runat="server" placeholder="Price"></asp:TextBox>

                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="Vin" class="form-control" required="true" type="number" runat="server" placeholder="VIN Number"></asp:TextBox>
                        </div>

                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <h3>File Image Upload</h3>
                            <br /><br />
                            <asp:FileUpload id="uploader" accept=".png,.jpg,.jpeg,.gif"  runat="server"/>
                            <br /><br />
                        </div>
                    </div>
                    <div class="row">
                            <asp:Button id="addButton" OnClientClick="return confirm('Add this vehicle?');" runat="server" Text="Add Vehicle"  class="btn btn-lg btn-primary btn-block" OnClick="addButton_Click"/>
                            
                        </div>
                    </div>
                    <asp:Label ID="msgTxt" runat="server" Text=""></asp:Label><br />
                    <asp:Button id="backBtn" runat="server" Text="Back to Inventory" UseSubmitBehavior="false" class="btn btn-lg btn-primary btn-block" CausesValidation="false" OnClick="backBtn_Click"/>

                </form>
            </div>
</asp:Content>