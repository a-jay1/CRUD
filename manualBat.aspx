<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manualBat.aspx.cs" Inherits="YourNamespace.Scorecard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Scorecard</title>
    <style>
        body {
            min-height: 100vh;
            display: grid;
            place-items: center;
        }
        .scorecard {
            display: flex;
            flex-direction: column-reverse;
        }
        
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        scorecard
        <div class="scorecard"><br />

            <span>Player: </span>
            <asp:Label ID="scoreLabel1" runat="server" Text="0">
            </asp:Label><br />
            <span>Computer: </span>
            <asp:Label ID="scoreLabel2" runat="server" Text="0">
            </asp:Label>
            <asp:Label ID="myLabel" runat="server" Visible="false" Text="out !"></asp:Label>

            <asp:Label ID="Label1" runat="server" Visible="false" Text="player win"></asp:Label>

            <asp:Label ID="Label2" runat="server" Visible="false" Text="player loss"></asp:Label>

            <asp:Label ID="Label3" runat="server" Visible="false" Text="player draw"></asp:Label>

        </div>
        <div>
            <asp:Button ID="btn1" runat="server" Text="1" OnClick="btn_Click" />
            <asp:Button ID="btn2" runat="server" Text="2" OnClick="btn_Click" />
            <asp:Button ID="btn3" runat="server" Text="3" OnClick="btn_Click" />
            <asp:Button ID="btn4" runat="server" Text="4" OnClick="btn_Click" />
            <asp:Button ID="btn5" runat="server" Text="5" OnClick="btn_Click" />
            <asp:Button ID="btn6" runat="server" Text="6" OnClick="btn_Click" />
        </div>
    </form>
</body>
</html>
