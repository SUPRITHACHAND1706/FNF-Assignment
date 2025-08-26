<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test01Words.aspx.cs" Inherits="SampleWbFormsApp.Hackathon2.Test01Words" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>My words</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>My words</h2>
        <asp:GridView ID="gvWords" runat="server" AutoGenerateColumns="True">
            <Columns>
                <asp:BoundField DataField="Word" HeaderText="Word" />
                <asp:BoundField DataField="Translation" HeaderText="Translation" />
            </Columns>
        </asp:GridView>
        <br />
        <a href="Test01Search.aspx">Search another word</a>
    </form>
</body>
</html>
