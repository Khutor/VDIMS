<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="register.aspx.cs" Inherits="VDIMS.register" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <form id="registerform" class="form-signin" runat="server">
       <h1 class="h3 mb-3 font-weight-normal">Create an account</h1>
        <asp:TextBox id="nameTxt" class="form-control" runat="server" required="true" placeholder="Name"></asp:TextBox>
        <asp:TextBox id="emailTxt" class="form-control" runat="server" required="true" placeholder="Email Address"></asp:TextBox>
        <asp:TextBox id="passwordTxt" class="form-control" runat="server" required="true" type="password" placeholder="Password"></asp:TextBox>
        <asp:TextBox id="phoneTxt" class="form-control" runat="server" required="true" placeholder="Phone Number"></asp:TextBox>
        <br/>
        <asp:Button id="loginButton" runat="server" Text="Sign me up"  class="btn btn-lg btn-primary btn-block" OnClick="loginButton_Click"/>
        <br/>
        <p><a href="/sign_in.aspx">Already have an account?</a></p>
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </form>
    </asp:Content>