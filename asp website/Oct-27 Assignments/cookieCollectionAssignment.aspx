<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookieCollectionAssignment.aspx.cs" Inherits="October27th.cookieCollectionAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Choose your favorite Color" Font-Bold="True" />

            <br />

            <asp:CheckBox ID="CheckBox1" runat="server" Text="White" BackColor="White" BorderColor="#333300" ForeColor="Black" />

            <br />

            <br />

        
        <asp:CheckBox ID="CheckBox2" runat="server" BackColor="#660066" Text="Violet" />
            <br />
        <br />
        
        <asp:CheckBox ID="CheckBox3" runat="server" BackColor="#333333" BorderColor="#333333" Text="Black" />
            <br />
        <br />
        
        <asp:CheckBox ID="CheckBox4" runat="server" BackColor="#0033CC" Text="Blue" />
            <br />
        <br />
        
        <asp:CheckBox ID="CheckBox5" runat="server" BackColor="Red" Text="Red" />
            <br />
        <br />
        
        <asp:CheckBox ID="CheckBox6" runat="server" BackColor="#00CC00" Text="Green" />
            <br />
        <br />
        
        <asp:CheckBox ID="CheckBox7" runat="server" BackColor="#FF0066" Text="Pink" />
            <br />
        <br />
        
                
        <asp:CheckBox ID="CheckBox8" runat="server" BackColor="Red" Text="Orange" />
            <br />
        <br />
        
        <asp:CheckBox ID="CheckBox9" runat="server" BackColor="#9900FF" Text="Lavender" />
            <br />
        <br />
        
        <asp:CheckBox ID="CheckBox10" runat="server" BackColor="Yellow" Text="Yellow" />

            <br />

            <br />
            <br />

        <asp:Button ID="button" runat="server" Text="Submit" Font-Bold="True" Height="27px" Width="98px" OnClick="button_Click" />
            </div>
        <p>
            <asp:Label ID="Label2" runat="server" />
        </p>

    </form>
</body>
</html>
