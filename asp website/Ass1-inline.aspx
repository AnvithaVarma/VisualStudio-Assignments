<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

    protected void button_Click(object sender, EventArgs e)
    {
        Response.Write("This is the button created with inline code");
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="button" runat="server" Text="Click Here!" ForeColor="White" BackColor="OrangeRed" OnClick="button_Click" Height="61px" style="margin-left: 470px" Width="281px" />
        </div>
    </form>
</body>
</html>
