R<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CarRental.Register" %>

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
<body style="font-family: Arial, Helvetica, sans-serif; font-size: small">
    <form id="form1" runat="server">

        <div class="container">
            <h1>Welcome to MIS Rental Car</h1>
            <hr />
            <p style="font-size=30px;background-color=red;">
                <asp:Literal  runat="server" ID="StatusMessage" />
            </p>
            <div style="margin-bottom: 10px">
                <p class="form-text" style="text-align: left;">E-mail</p>
                <div>
                    <asp:TextBox Font-Size="Large" Width="80%" CssClass="textBox" runat="server" ID="Email" TextMode="Email" />
                    <asp:RequiredFieldValidator Width="80%" ID="RequiredFieldValidator1" BackColor="Red" runat="server" ErrorMessage="Required Field" ControlToValidate="Email"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div style="margin-bottom: 10px">
                <p class="form-text" style="text-align: left;">Phone Number</p>
                <div>
                    <asp:TextBox Font-Size="Large" Width="80%" CssClass="textBox" runat="server" ID="PhoneNUmber" TextMode="Phone" />
                    <asp:RequiredFieldValidator Width="80%" ID="RequiredFieldValidator2" BackColor="Red" runat="server" ErrorMessage="Required Field" ControlToValidate="PhoneNUmber"></asp:RequiredFieldValidator>

                </div>
            </div>
            <div style="margin-bottom: 10px">
                <p class="form-text" style="text-align: left;">User Name</p>
                <div>
                    <asp:TextBox Font-Size="Large" Width="80%" CssClass="textBox" runat="server" ID="UserName" />
                    <asp:RequiredFieldValidator Width="80%" ID="RequiredFieldValidator3" BackColor="Red" runat="server" ErrorMessage="Required Field" ControlToValidate="UserName"></asp:RequiredFieldValidator>

                </div>
            </div>
            <div style="margin-bottom: 10px">
                <p class="form-text" style="text-align: left;">Password</p>
                <div>
                    <asp:TextBox Font-Size="Large" Width="80%" CssClass="textBox" runat="server" ID="Password" TextMode="Password" />
                    <asp:RequiredFieldValidator Width="80%" ID="RequiredFieldValidator4" BackColor="Red" runat="server" ErrorMessage="Required Field" ControlToValidate="Password"></asp:RequiredFieldValidator>

                </div>
            </div>
            <div style="margin-bottom: 10px">
                <p class="form-text" style="text-align: left;">Confirm Password</p>
                <div>
                    <asp:TextBox Font-Size="Large" Width="80%" CssClass="textBox" runat="server" ID="ConfirmPassword" TextMode="Password" />
                    <asp:RequiredFieldValidator Width="80%" ID="RequiredFieldValidator5" BackColor="Red" runat="server" ErrorMessage="Required Field" ControlToValidate="ConfirmPassword"></asp:RequiredFieldValidator>

                </div>
            </div>
            <br />
            <div>
                <div>
                    <asp:Button BackColor="#cccccc" Font-Size="Large" Width="70%" CssClass="textBox" runat="server" OnClick="CreateUser_Click" Text="Register" />

                </div>
            </div>
            <br />
            <br />
             <div>
                <div>
                    <a style="color=white;"  href="Login.aspx" >Already a user?</a> 
                </div>
            </div>
        </div>
    </form>
</body>
</html>
