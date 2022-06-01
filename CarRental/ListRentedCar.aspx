<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListRentedCar.aspx.cs" Inherits="CarRental.ListRentedCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br />
    <br />
    <br />

    <div class="row">
        <asp:ListView ID="ListViewRentedCar" runat="server">
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
