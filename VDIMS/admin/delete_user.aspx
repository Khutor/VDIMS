<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="delete_user.aspx.cs" Inherits="VDIMS.admin.delete_user" %>


<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Delete Users</h1>
            <div class="container">
                <form id="deleteform" runat="server">
                    <div>
                     <div class="row">
                        <div class="form-group col">
                            <asp:DropDownList autopostback="true" class="form-control" ID="UIDdrop" runat="server" OnSelectedIndexChanged="UIDdrop_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="name" class="form-control" readonly="true" required="true" placeholder="Name" runat="server" ></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="email" class="form-control" readonly="true" runat="server" required="true" placeholder="Email"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="phone" class="form-control" readonly="true" runat="server" required="true" placeholder="Phone"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col">
                            <asp:TextBox id="pass" class="form-control" readonly="true" runat="server" required="true" placeholder="Password"></asp:TextBox>
                        </div>
                        <div class="form-group col">
                            <asp:TextBox id="admin" class="form-control" readonly="true" runat="server" required="true" placeholder="Is admin?"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                            <asp:Button id="deleteButton" OnClientClick="return confirm('Delete this user?');" runat="server" readonly="true" Text="Delete User" onClick="deleteButton_Click" class="btn btn-lg btn-primary btn-block"/>
                        <br />
                        </div>
                    </div>
                    <asp:Label ID="msgTxt" runat="server" Text=""></asp:Label><br />
                    <asp:Button id="backBtn" runat="server" Text="Back to Users" UseSubmitBehavior="false" class="btn btn-lg btn-primary btn-block" CausesValidation="false" OnClick="backBtn_Click"/>


                </form>
            </div>
    </asp:Content>

