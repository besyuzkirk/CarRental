<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RentCar.aspx.cs" Inherits="CarRental.RentCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <br />
        <br />
        <br />
        <br />
        <br />

        <asp:Label Font-Size="40px" ID="Label1" runat="server" Text="Label"></asp:Label>

        <h3>Start Date</h3>
        <asp:TextBox Font-Size="15px" ForeColor="Black" ID="StartDate" TextMode="Date" runat="server"></asp:TextBox>
        <h3>End Date</h3>
        <asp:TextBox ForeColor="Black" ID="EndDate" TextMode="Date" runat="server"></asp:TextBox>

        

        <asp:Button ID="Button1" BorderColor="White" ForeColor="Black" runat="server" Text="Calculate Price" OnClick="Button1_Click" />
        <br />
        <br />
        <br />

        <hr />
        <h1>Card Information</h1>
        <asp:Label ID="deneme" Font-Size="30px" runat="server" Text="Price: "></asp:Label>
        <div ></div>
        <br />
            <asp:TextBox MaxLength="12" ForeColor="Black" ID="TextBox1" Text="Card Number" runat="server"></asp:TextBox>
            <asp:TextBox MaxLength="3" ForeColor="Black" ID="TextBox2" Text="CVV" runat="server"></asp:TextBox>
            <asp:TextBox MaxLength="4" ForeColor="Black" ID="TextBox3" Text="Expiration Date" runat="server"></asp:TextBox>
            <asp:Button BorderColor="White" ForeColor="Black" ID="Button3" runat="server" Text="Checkout" OnClick="Checkout" />
        

        <asp:PlaceHolder runat="server" ID="LoginStatus" Visible="true">
            <p>
                <asp:Literal runat="server" ID="StatusText" />
                Status Text
            </p>
        </asp:PlaceHolder>
    </div>
</asp:Content>
