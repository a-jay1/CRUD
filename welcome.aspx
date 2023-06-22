<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="YourNamespace.Welcome" %>

<!DOCTYPE html>
<html>
<head>
    <title>Welcome</title>
</head>
<body>   
    <form id="form1" runat="server">
        <div>
            <center>
            <h1>Welcome to WebForm1</h1>
            <asp:Button ID="btnWelcome" runat="server" Text="Welcome" OnClick="btnWelcome_Click" />
            </center>
        </div>
    </form>
</body>
</html>
