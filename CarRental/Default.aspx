<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CarRental._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 style="font-weight: 700">Find the Best Car</h1>
        <p style="font-size: 20px" class="lead">From as low as $10 per day with limited time offer discounts.</p>
        <!-- <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p> -->
    </div>

    <div class="row">
        <asp:ListView ID="ListView1" runat="server">
            <ItemTemplate>
                <div class="col-md-4">
                    <div class="card" style="width: 400px; padding: 10px; margin-bottom: 20px;">
                        <img class="card-img-top p-2" src="<%#Eval("ImgUrl") %>" alt="Card image" style="width: 100%; height: 250px; border-radius: 20px">
                        <div class="card-body">
                            <h4 id="carName" runat="server" class="card-title text-center"><%#Eval("CarName") %></h4>
                            <p class="card-text">Seats: <%#Eval("Seats") %></p>
                            <p class="card-text">Luggage: <%#Eval("Luggage") %></p>
                            <p class="card-text">Transmission: <%#Eval("ShiftType") %></p>
                            <p class="card-text">Air conditioning: <%#Eval("AirConditioning") %></p>
                            <p class="card-text">Price: $<%#Eval("Price") %></p>
                            <a href="RentCar.aspx?Id=<%#Eval("Id") %>" class="btn btn-primary stretched-link">Rent Car</a>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>

</asp:Content>
