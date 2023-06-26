<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateprofile.aspx.cs" Inherits="YourNamespace.updateprofile" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>updateProfile</title>
    <style>
        body {
            min-height: 100vh;
            display: grid;
            place-items: center;
        }
    </style>
</head>
<body>
    <form id="updateprofile" runat="server">
       
        <div>
            <label for="txtName">Name:</label>
            <input type="text" id="txtName" runat="server" />
        </div>
        
        <div>
            <input type="submit" value="update" runat="server" onserverclick="update_name" />
        </div>

    </form>
</body>
</html>
