<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllRentedCars.aspx.cs" Inherits="CarRental.AllRentedCars" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h1 class="m-auto">All Orders</h1>
    <br />
    <div class="row">
        <asp:ListView ID="ListViewRentedCarAll" runat="server">
            <ItemTemplate>
                <div class="col-md-4">
                    <div class="card" style="width: 400px; padding: 10px; margin-bottom: 20px;">
                        <div class="card-body">
                            <h4 id="carId" runat="server" class="card-title text-center">Car Id: <%#Eval("CarId") %></h4>
                            <h4 id="Id" runat="server" class="card-title text-center">Order Id: <%#Eval("Id") %></h4>
                            <p class="card-text">User Id: $<%#Eval("UserId") %></p>
                            <p class="card-text">End Date: <%#Eval("EndDate") %></p>
                            <p class="card-text">Start Date: <%#Eval("StartDate") %></p>
                            <p class="card-text">Total Day: <%#Eval("TotalDay") %></p>
                            <p class="card-text">Total Revenue: $<%#Eval("TotalRevenue") %></p>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
