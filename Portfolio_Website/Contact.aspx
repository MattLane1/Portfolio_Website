﻿<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Portfolio_Website.Contact" EnableViewState="True" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container text-center">
        <!-- Title !-->
        <h1>Contact Me</h1>
        <!-- Contact me form !-->
        <div class="form-group">
            <label class="control-label" for="FirstNameTextBox">First Name</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="FirstName" placeholder="First Name" required="true"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="control-label" for="LastNameTextBox">Last Name</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="LastName" placeholder="Last Name" required="true"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="control-label" for="ContactNumber">Contact Number</label>
            <asp:TextBox runat="server" TextMode="Phone" CssClass="form-control" ID="ContactNumber" placeholder="Contact Number" required="true"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="control-label" for="Email">Email</label>
            <asp:TextBox runat="server" TextMode="Email" CssClass="form-control" ID="Email" placeholder="Email" required="true"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="control-label" for="Message">Message</label>
            <asp:TextBox runat="server" TextMode="MultiLine" Columns="5" Rows="5" CssClass="form-control" ID="Message" placeholder="Your Message" required="true"></asp:TextBox>
        </div>
        <a class="btn btn-danger btn-lg" id="CancelButton" href="Default.aspx">Cancel</a>
        <asp:Button runat="server" CssClass="btn btn-success btn-lg" ID="SendButton" Text="Submit" OnClick="SendButton_Click" CausesValidation="true" />
    </div>

</asp:Content>
