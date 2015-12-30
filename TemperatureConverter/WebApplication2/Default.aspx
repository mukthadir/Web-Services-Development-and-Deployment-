<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2> .NET Test Client </h2>
    <p> Please enter the temperature in Celcius: <asp:TextBox ID ="txtInput" runat ="server" Width ="200px"></asp:TextBox>
        &nbsp;<asp:Button ID ="btnSubmit" runat = "server" OnClick ="btnSubmit_Click" Text ="Submit"/></p>
    <p> Corresponding value in Farenheit is <asp:TextBox ID ="txtInput2" runat ="server" Width ="200px"></asp:TextBox> 

    <p> Please enter the temperature in Farheinheit: <asp:TextBox ID ="TextBox1" runat ="server" Width ="200px"></asp:TextBox>
        &nbsp;<asp:Button ID ="Button1" runat = "server" OnClick ="btn2Submit_Click" Text ="Submit"/></p>
    <p> Corresponding value in Celcius is <asp:TextBox ID ="TextBox2" runat ="server" Width ="200px"></asp:TextBox>

</asp:Content>
