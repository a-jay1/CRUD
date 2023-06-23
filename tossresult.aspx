<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tossresult.aspx.cs" Inherits="YourNamespace.Tossresult" %>

<!DOCTYPE html>
<html>
<head>
    <title>Toss Result</title>
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
            <h1>Toss Result</h1>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnWelcome" runat="server" Text="start" OnClick="btnstart_Click" />
        </div>
    </form>
</body>
</html>