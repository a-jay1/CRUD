<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="toss.aspx.cs" Inherits="YourNamespace.Toss" %>

<!DOCTYPE html>
<html>
<head>
    <title>Hand  cric</title>
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
            <h1>Welcome to Toss !</h1>
            <asp:Button ID="Button1" runat="server" Text="head" OnClick="btnhead_Click" />
            <asp:Button ID="Button2" runat="server" Text="tail" OnClick="btntail_Click" />
        </div>
    </form>
</body>
</html>
