<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="contact.aspx.cs" Inherits="VDIMS.contact" %>

<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Dealership Contacts</h1>
        <div class="container">
            <form id="contactform" runat="server">
                <div class="row">
                    <div class="form-group col">
                        <asp:DropDownList autopostback="true" class="form-control" ID="DIDdrop" runat="server" OnSelectedIndexChanged="DIDdrop_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group col">
                        <asp:TextBox id="dName" class="form-control" readonly="true" required="true" placeholder="Name" runat="server" ></asp:TextBox>
                    </div>
                    <div class="form-group col">
                        <asp:TextBox id="dCars" class="form-control" readonly="true" runat="server" required="true" placeholder="Cars on Lot"></asp:TextBox>
                    </div>
                    <div class="form-group col">
                        <asp:TextBox id="dAdd" class="form-control" readonly="true" runat="server" required="true" placeholder="Address"></asp:TextBox>
                    </div>
                    <div class="form-group col">
                        <asp:TextBox id="dPhone" class="form-control" readonly="true" runat="server" required="true" placeholder="Phone Number"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group col">
                        <asp:TextBox id="dCity" class="form-control" readonly="true" runat="server" required="true" placeholder="City"></asp:TextBox>
                    </div>
                    <div class="form-group col">
                        <asp:TextBox id="dState" class="form-control" readonly="true" runat="server" required="true" placeholder="State"></asp:TextBox>
                    </div>
                    <div class="form-group col">
                        <asp:TextBox id="dZip" class="form-control" readonly="true" runat="server" required="true" placeholder="Zip"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group col">
                        <asp:TextBox id="dmName" class="form-control" readonly="true" runat="server" required="true" placeholder="Manager"></asp:TextBox>
                    </div>
                    <div class="form-group col">
                        <asp:TextBox id="dmEmail" class="form-control" readonly="true" runat="server" required="true" placeholder="Manager Email"></asp:TextBox>
                    </div>
                    <div class="form-group col">
                        <asp:TextBox id="dmPhone" class="form-control" readonly="true" runat="server" required="true" placeholder="Manager Phone"></asp:TextBox>
                    </div>
                </div>
                <asp:Label ID="msgTxt" runat="server" Text=""></asp:Label><br />
                <asp:Button id="backBtn" runat="server" Text="Back to Home" UseSubmitBehavior="false" class="btn btn-lg btn-primary btn-block" CausesValidation="false" OnClick="backBtn_Click"/>
            </form>
        </div>
</asp:Content>
