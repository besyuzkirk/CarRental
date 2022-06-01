<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListCars.aspx.cs" Inherits="CarRental.ListCars" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />

    <div class="row">
        <asp:ListView ID="ListView12" runat="server">
            <ItemTemplate>
                <div class="col-md-4">
                    <div class="card" style="width: 400px; padding: 10px; margin-bottom: 20px;">
                        <img class="card-img-top p-2" src="<%#Eval("ImgUrl") %>" alt="Card image" style="width: 100%; height: 250px; border-radius: 20px">
                        <div class="card-body">
                            <h4 id="carName" runat="server" class="card-title text-center"><%#Eval("CarName") %></h4>
                            <h4 id="carId" runat="server" class="card-title text-center"><%#Eval("Id") %></h4>
                            <p class="card-text">Seats: <%#Eval("Seats") %></p>
                            <p class="card-text">Luggage: <%#Eval("Luggage") %></p>
                            <p class="card-text">Transmission: <%#Eval("ShiftType") %></p>
                            <p class="card-text">Air conditioning: <%#Eval("AirConditioning") %></p>
                            <p class="card-text">Price: $<%#Eval("Price") %></p>
                            <a href="UpdateCar.aspx?Id=<%#Eval("Id") %>" class="btn btn-primary stretched-link">Update Car</a>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
