<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReturnCar.aspx.cs" Inherits="CarRental.ReturnCar" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Car Return</h1>
    <p>Order ID</p>
    <asp:TextBox ForeColor="Black" ID="CarReturn" runat="server"></asp:TextBox>


    <br />
    <br />

    <div>
        <div>
            <asp:Button BorderColor="White" ForeColor="Black" runat="server" Text="Retrieve Car" OnClick="Unnamed1_Click"  />
        </div>
    </div>
</asp:Content>
