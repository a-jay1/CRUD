<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="YourNamespace.profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile</title>
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
            <h2>Profile Information</h2>
            <hr />
            <asp:Label ID="emailLabel" runat="server"></asp:Label><br />
             <asp:Label ID="Label1" runat="server"></asp:Label><br />
            <asp:Button ID="updateProfileButton" runat="server" Text="Update Profile" OnClick="updateProfileButton_Click" Visible="false" />
             <asp:Button ID="deleteAccount" runat="server" Text="Delete" OnClick="delete_Click" Visible="true" />
        </div>
    </form>
</body>
</html>

