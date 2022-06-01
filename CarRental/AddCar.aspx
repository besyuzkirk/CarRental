<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCar.aspx.cs" Inherits="CarRental.AddCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Add New Car</h1>
    <p>Car Name</p>
    <asp:TextBox ForeColor="Black" ID="CarName" runat="server"></asp:TextBox>
    <p>Car Image</p>
    <asp:TextBox ForeColor="Black" ID="CarImage" runat="server"></asp:TextBox>
    <p>Car Capacity</p>
    <asp:TextBox ForeColor="Black" ID="CarCapacity" runat="server"></asp:TextBox>
     <p>Luggage</p>
    <asp:TextBox ForeColor="Black" ID="Luggage" runat="server"></asp:TextBox>
    <p>Transamission</p>
    <asp:TextBox ForeColor="Black" ID="Transamission" runat="server"></asp:TextBox>
    <p>Air Conditioning</p>
    <asp:TextBox ForeColor="Black" ID="TextBox1" runat="server"></asp:TextBox>
    <p>Daily Price</p>
    <asp:TextBox ForeColor="Black" ID="DailyPrice" runat="server"></asp:TextBox>

    <br />
    <br />
    <br />

    <div>
        <div>
            <asp:Button  BorderColor="White" ForeColor="Black" runat="server" Text="Add a New Car" OnClick="AddNewCar" />
        </div>
    </div>

</asp:Content>
