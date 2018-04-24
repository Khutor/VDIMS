<%@ Page Language="C#" CodeFile="results.aspx.cs" MasterPageFile="/master_page.master" Inherits="VDIMS.vehicle.results" %>
<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h1>Search Results </h1>
    <p>Showing results for <% do_params(); %></p>
    <% 
    
    do_table();

    %>
</asp:Content>
