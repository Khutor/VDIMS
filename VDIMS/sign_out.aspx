<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sign_out.aspx.cs" MasterPageFile="~/master_page.master" Inherits="VDIMS.sign_out" %>

<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <form id="signoutform" class="" runat="server">
        <h2>You have been signed out</h2>
        <asp:Button ID="continueBtn" class="btn btn-lg btn-primary btn-block" runat="server" Text="Continue" OnClick="continueBtn_Click" />
    </form>
</asp:Content>