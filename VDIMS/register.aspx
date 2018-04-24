<%@ Page Language="C#" MasterPageFile="~/master_page.master" CodeFile="register.aspx.cs" Inherits="VDIMS.register" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <form id="registerform" class="form-signin" runat="server">
       <h1 class="h3 mb-3 font-weight-normal">Create an account</h1>
        <asp:TextBox id="name" class="form-control" runat="server">Name</asp:TextBox>
        <asp:TextBox id="email" class="form-control" runat="server">Email Address</asp:TextBox>
        <asp:TextBox id="password" class="form-control" runat="server">Password</asp:TextBox>
        <asp:TextBox id="phone" class="form-control" runat="server">Phone Number</asp:TextBox>
        <br/>
        <asp:Button id="loginButton" runat="server" Text="Sign me up"  class="btn btn-lg btn-primary btn-block"/>
        <br/>
        <p><a href="/sign_in.aspx">Already have an account?</a></p>
        
    </form>
    </asp:Content>