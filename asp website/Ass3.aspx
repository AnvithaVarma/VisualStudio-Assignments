<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ass3.aspx.cs" Inherits="Ass3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="true" BackColor="#CCFFFF" BorderColor="Black" BorderWidth="2px" Font-Bold="True" ForeColor="Red" Height="48px" OnCheckedChanged="RadioButton1_CheckedChanged" Text="          RED" Width="125px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="redbox" runat="server" BackColor="White" ForeColor="Red" Height="40px" OnTextChanged="TextBox1_TextChanged"
            Width="232px" Visible="false">     This is ASP.net webform!!</asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="true" BackColor="#CCFFFF" BorderColor="Black" BorderWidth="2px" ForeColor="#00CC00" Height="48px" OnCheckedChanged="RadioButton2_CheckedChanged" Text="      GREEN" Width="125px"  />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="greenbox" runat="server" BackColor="White" ForeColor="#009933" Height="42px" OnTextChanged="TextBox3_TextChanged" Width="232px" Visible="false">   This is ASP.net waveform!!</asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="true" BackColor="#CCFFFF" BorderColor="Black" BorderWidth="2px" ForeColor="#0000CC" Height="48px" OnCheckedChanged="RadioButton3_CheckedChanged" Text="         BLUE" Width="125px"  />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="bluebox" runat="server" BackColor="White" ForeColor="#0000CC" Height="39px" OnTextChanged="TextBox2_TextChanged" Width="231px" Visible="false">  This is ASP.net waveform!!</asp:TextBox>
    </form>
</body>
</html>
