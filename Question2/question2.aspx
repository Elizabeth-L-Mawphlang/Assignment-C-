<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="question2.aspx.cs" Inherits="question2.question2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="54px" Width="83px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="Tomatoes">Tomatoes</asp:ListItem>
                <asp:ListItem Value="Potatoes">Potatoes</asp:ListItem>
                <asp:ListItem Value="Chili">Chili</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="img" runat="server" Height="137px" Width="242px" />
            <br />
            <br />
        </div>
        <asp:Button ID="save" runat="server" Text="Button" Width="85px" OnClick="btn_click" />
        <br />
        <br />
        <asp:Label ID="price" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
