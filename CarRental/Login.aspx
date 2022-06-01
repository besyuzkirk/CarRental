<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CarRental.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MIS Rental Car | Login</title>
    <script src="https://kit.fontawesome.com/66560d2e46.js" crossorigin="anonymous"></script>
    <style>
        body {
            background: linear-gradient(90deg, rgba(2,0,36,1) 0%, rgba(9,121,20,1) 65%, rgba(0,212,255,1) 100%);
            color: white;
        }

        .container {
            width: 400px;
            padding: 20px;
            margin: auto;
            text-align: center;
            position: absolute;
            left: 50%;
            top: 50%;
            -webkit-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
        }

        .loginstatus {
            background-color: black;
            width: 80%;
            margin: auto;
            padding: 15px;
            font-size: 20px;
            margin-bottom: 15px;
            color: white;
            border-radius: 25px;
        }

        .form-text {
            padding-left: 20px;
            font-size: 20px;
        }

        .textBox {
            padding: 10px;
            border: 1px solid black;
            border-radius: 20px;
        }

        .title {
            font-size: 40px;
            font-weight: 900;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        .login-button {
            font-size: 20px;
            padding: 10px;
            background-color: white;
            border: 1px solid grey;
            margin-top: 20px;
            display: inline-block;
            border-radius: 25px;
            width: 150px;
            border: none;
            
        }

        .login-button:focus {
            opacity: 0.5;
        }
    </style>
</head>
<body style="font-family: Arial, Helvetica, sans-serif;">
    <form id="form1" runat="server">
        <div class="container">
            <i style="font-size: 200px; margin-bottom:10px" class="fas fa-car"></i>
            <p class="title">Log In</p>
            <asp:PlaceHolder runat="server" ID="LoginStatus" Visible="false">
                <p class="loginstatus">
                    <asp:Literal runat="server" ID="StatusText" />
                </p>
            </asp:PlaceHolder>
            <asp:PlaceHolder runat="server" ID="LoginForm" Visible="true">
                <div style="margin-bottom: 10px">
                    <p class="form-text" style="text-align: left;">User Name</p>
                    <div>
                        <asp:TextBox Font-Size="Large" Width="80%" CssClass="textBox" runat="server" ID="UserName" />
                    </div>
                </div>
                <div style="margin-bottom: 10px">
                    <p class="form-text" style="text-align: left;">Password</p>
                    <div>
                        <asp:TextBox Font-Size="Large" Width="80%" CssClass="textBox" runat="server" ID="Password" TextMode="Password" />
                    </div>
                </div>
                <div style="margin-bottom: 10px">
                    <div>
                        <asp:Button  BackColor="#cccccc" CssClass="login-button" runat="server" OnClick="SignIn" Text="Log in" />
                    </div>
                </div>
                 <div style="margin-bottom: 10px">
                    <div>
                        <asp:Button BackColor="#cccccc" CssClass="login-button" runat="server" OnClick="SignUp" Text="Sign Up" />
                    </div>
                </div>
            </asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
