<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validator.aspx.cs" Inherits="validator.validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 463px">
    <form id="form1" runat="server">
        <div style="height: 16px">
            Insert your details :<br />
            <br />
        </div>
        <p>
            Name :&nbsp;
            <asp:TextBox ID="txtname" runat="server" BackColor="#EDDF82"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtname" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </p>
        <p>
            Family Address :
            <asp:TextBox ID="txtfam" runat="server" BackColor="#EDDF82"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtfam" Display="Dynamic" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtname" ControlToValidate="txtfam" Display="Dynamic" ErrorMessage="differs from name"></asp:CompareValidator>
&nbsp;&nbsp;
        </p>
        <p>
            Address :
            <asp:TextBox ID="txtadd" runat="server" BackColor="#EDDF82" OnTextChanged="txtadd_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtadd" Display="Dynamic" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtadd" Display="Dynamic" ErrorMessage="at least 2chars" ValidationExpression="^[\s\S]{2,5}$"></asp:RegularExpressionValidator>
        </p>
        <p>
            City :
            <asp:TextBox ID="txtcity" runat="server" BackColor="#EDDF82"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtcity" Display="Dynamic" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtcity" Display="Dynamic" ErrorMessage="at least 2chars" ValidationExpression="^[\s\S]{2,5}$"></asp:RegularExpressionValidator>
        </p>
        <p>
            Zip Code : <asp:TextBox ID="tctzip" runat="server" BackColor="#EDDF82" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="tctzip" Display="Dynamic" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tctzip" Display="Dynamic" ErrorMessage="(xxxxx)" ValidationExpression="\d{5}(-\d{4})?"></asp:RegularExpressionValidator>
        </p>
        <p>
            Phone : <asp:TextBox ID="txtphone" runat="server" BackColor="#EDDF82" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtphone" Display="Dynamic" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtphone" Display="Dynamic" ErrorMessage="(xx-xxxxxxx / xxx-xxxxxxx)" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
&nbsp;
        </p>
        <p>
            E-Mail&nbsp; :<asp:TextBox ID="txtmail" runat="server" BackColor="#EDDF82"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtmail" Display="Dynamic" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtmail" Display="Dynamic" ErrorMessage="example@example.com" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btncheck" runat="server" Text="Check" />
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableTheming="True" ForeColor="#CC0000" HeaderText="ValidationSum" ShowMessageBox="True" />
    </form>
</body>
</html>
