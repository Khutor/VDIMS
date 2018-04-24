<%@ Page Language="C#" CodeFile="sign_in.aspx.cs"  MasterPageFile="~/master_page.master" Inherits="VDIMS.sign_in" %>

<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <form id="signinform" class="form-signin" runat="server">
       <h1 class="h3 mb-3 font-weight-normal">Please sign in</h1>
        <label for="email" class="sr-only"></label>
        <asp:TextBox id="email" class="form-control" runat="server">Email address</asp:TextBox>
        <label for="password" class="sr-only"></label>
        <asp:TextBox id="password" class="form-control" runat="server">Password</asp:TextBox>
        <br/>
        <asp:Button id="loginButton" runat="server" Text="Sign in"  class="btn btn-lg btn-primary btn-block"/>
        <br/>
        <p><a href="/register.aspx">Not Yet Registered?</a></p>
        
    </form>
    </asp:Content>