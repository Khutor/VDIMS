<%@ Page Language="C#" CodeFile="sign_in.aspx.cs"  MasterPageFile="~/master_page.master" Inherits="VDIMS.sign_in" %>

<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <form id="signinform" class="form-signin" runat="server">
       <h1 class="h3 mb-3 font-weight-normal">Please sign in</h1>
        <label for="email" class="sr-only"></label>
        <asp:TextBox id="emailTxt" class="form-control" runat="server" placeholder="Email"></asp:TextBox>
        <label for="password" class="sr-only"></label>
        <asp:TextBox id="passwordTxt" class="form-control" runat="server" placeholder="Password"></asp:TextBox>
        <br/>
        <asp:Button id="loginButton" runat="server" Text="Sign in"  class="btn btn-lg btn-primary btn-block" OnClick="loginButton_Click"/>
        <br/>
        <p><a href="/register.aspx">Not Yet Registered?</a></p>
        
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        
        <br />
<%--        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString1 %>" ProviderName="<%$ ConnectionStrings:ConnectionString1.ProviderName %>"></asp:SqlDataSource>--%>
    
    </form>
</asp:Content>