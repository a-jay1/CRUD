<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="b4toss.aspx.cs" Inherits="YourNamespace.B4toss" %>

<!DOCTYPE html>
<html>
<head>
    <title>Hand  ric</title>
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
            <h1>Welcome to HandCricket</h1>
            <asp:Button ID="btnWelcome" runat="server" Text="start" OnClick="btnstart_Click" />
        </div>
    </form>
</body>
</html>
