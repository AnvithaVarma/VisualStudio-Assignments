<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calendarControl.aspx.cs" Inherits="October27th.calendarControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="151px"></asp:TextBox>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="16px" ImageUrl="~/calendar.png" OnClick="ImageButton1_Click" Width="20px" />
        <br />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#660066" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#CC0099" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged" Width="220px">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
    </form>
</body>
</html>
