<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="YourNamespace.Signup" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Sign Up</title>
    <style>
        body {
            min-height: 100vh;
            display: grid;
            place-items: center;
        }
    </style>
</head>
<body>
    <form id="formSignUp" runat="server">
        <div>
            <asp:Label ID="lblErrorMessage" runat="server" CssClass="error-message" Visible="false"></asp:Label>
        </div>
        <div>
            <label for="txtEmail">Email:</label>
            <input type="email" id="txtEmail" runat="server" />
        </div>
        <div>
            <label for="txtName">Name:</label>
            <input type="text" id="txtName" runat="server" />
        </div>
        <div>
            <label for="txtPassword">Password:</label>
            <input type="password" id="txtPassword" runat="server" />
        </div>
        <div>
            <label for="txtConfirmPassword">Confirm Password:</label>
            <input type="password" id="txtConfirmPassword" runat="server" />
        </div>
        <div>
            <input type="submit" value="Sign Up" runat="server" onserverclick="SignUp_Click" />
        </div>

    </form>
</body>
</html>
