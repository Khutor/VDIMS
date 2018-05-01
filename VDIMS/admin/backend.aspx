﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/master_page.master" CodeBehind="backend.aspx.cs" Inherits="VDIMS.admin.backend" %>

<asp:Content runat="server" ContentPlaceHolderID="contentMain">
    <h2>Welcome to administrator backend</h2>
    <asp:Panel ID="panel" runat="server">
        <p class="lead">
            <asp:Label ID="welcome" runat="server" Text="Welcome Administrator"></asp:Label>
        </p>
        <p class="lead">Click <a href="/admin/add_vehicle.aspx">here</a> to add vehicles</p>
        <p class="lead">Click <a href="/admin/update_vehicle.aspx">here</a> to update vehicles</p>
        <p class="lead">Click <a href="/admin/delete_vehicle.aspx">here</a> to delete vehicles</p>
        <p class="lead">Click <a href="/admin/inventory.aspx">here</a> to view vehicle inventory</p>
    </asp:Panel>

</asp:Content>