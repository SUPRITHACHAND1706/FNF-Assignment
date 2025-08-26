<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test01Search.aspx.cs" Inherits="SampleWbFormsApp.Hackathon2.Test01Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Search word</h2>
        <p>
            English word:<asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" BackColor="LightBlue" BorderStyle="Inset"  Text="Search" OnClick="btnSearch_Click" />
            <br />
            <asp:Label ID ="lblMsg" runat="server" ForeColor="Red" />
            <asp:Panel ID ="pnlAdd" runat="server" Visible="false" />
            <p>
                <table>
                    <tr>
                        <td>Word   </td>
                        <td>Translation</td>
                        <td>Action</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblWord" runat="server" /></td>
                        <td>
                            <asp:TextBox ID="txtTranslation" runat="server" /></td>
                        <td>
                            <asp:Button ID="btnAdd" Text="Add to My Words" runat="server" OnClick="btnAdd_Click" />
                        </td>
                    </tr>
                </table>
                </asp:Panel>
                    <br />
                    <a href="Test01Words.aspx">My Words</a>
    </form>
</body>
</html>

