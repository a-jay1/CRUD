<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="YourNamespace.Login" %>

<!DOCTYPE html>
<html>
<head>
    <title>Login</title>
    <style>
        body {
            min-height: 100vh;
            display: grid;
            place-items: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login</h2>
            <asp:Label ID="lblErrorMessage" runat="server" Text="" Visible="false" CssClass="error-message" />
            <div>
                <asp:Label ID="lblEmail" runat="server" Text="Email:" />
                <asp:TextBox ID="txtEmail" runat="server" />
            </div>
            <div>
                <asp:Label ID="lblPassword" runat="server" Text="Password:" />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            </div>
            <div>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
