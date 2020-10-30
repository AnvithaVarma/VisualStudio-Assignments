<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regForm.aspx.cs" Inherits="October_29th.regForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 314px;
        }
        .auto-style5 {
            width: 100%;
            height: 244px;
        }
        .auto-style6 {
            width: 193px;
            height: 46px;
        }
        .auto-style7 {
            height: 46px;
        }
    </style>
</head>
<body style="height: 298px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <table class="auto-style5">
                <tr>
                    <td class="auto-style6" style="font-family: 'Bahnschrift SemiBold'">Username</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox1" runat="server" BackColor="#FF99FF" BorderColor="#333333" BorderWidth="1px" Width="259px"></asp:TextBox>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style6" style="font-family: 'Bahnschrift SemiBold'">Email</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox2" runat="server" BackColor="#FF99FF" BorderColor="#333333" BorderWidth="1px" TextMode="Email" Width="259px"></asp:TextBox>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style6" style="font-family: 'Bahnschrift SemiBold'">Password</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox3" runat="server" BackColor="#FF99FF" BorderColor="#333333" BorderWidth="1px" TextMode="Password" Width="259px"></asp:TextBox>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style6" style="font-family: 'Bahnschrift SemiBold'">Confirm&nbsp; Password</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox4" runat="server" BackColor="#FF99FF" BorderColor="#333333" BorderWidth="1px" TextMode="Password" Width="259px"></asp:TextBox>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style6" style="font-family: 'Bahnschrift SemiBold'">Gender</td>
                    <td class="auto-style7">
                        <asp:RadioButton ID="RadioButton1" runat="server" BackColor="#FF99FF" BorderColor="#333333" BorderWidth="1px" Font-Bold="True" GroupName="gender" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" BackColor="#FF99FF" BorderColor="#333333" BorderWidth="1px" Font-Bold="True" GroupName="gender" Text="Female" />
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style6" style="font-family: 'Bahnschrift SemiBold'">Country</td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#FF99FF" Height="16px" Width="147px">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>India</asp:ListItem>
                            <asp:ListItem>South Korea</asp:ListItem>
                            <asp:ListItem>Germany</asp:ListItem>
                            <asp:ListItem>London</asp:ListItem>
                            <asp:ListItem>Denmark</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" BackColor="#FF99FF" BorderColor="#333333" BorderWidth="1px" Font-Bold="True" Height="36px" OnClick="Button1_Click" Text="Register" Width="165px" />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [RegistrationForm]"></asp:SqlDataSource>
    </form>
</body>
</html>
