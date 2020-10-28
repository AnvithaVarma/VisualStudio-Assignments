<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dataTableAssignment.aspx.cs" Inherits="October27th.dataTableAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>These are the details of Employees in DXC Company!</h2>

            <asp:DataList ID="DataList1" runat="server" Height="1033px">
                <ItemTemplate>
                    <asp:Table ID="Table1" runat="server" CellPadding="2"
                        CellSpacing="0" BorderWidth="2px" style="width:270px; height:100px; background-color:darkorchid" />
                    <tr>
                        <td>
                            <b>ID</b> <span class="f"><%# Eval("ID") %></span><br />
                            <b>First Name</b> <span class="a"><%# Eval("First Name") %> </span><br />
                            <b>Last Name</b> <span class="b"><%# Eval("Last Name") %> </span><br />
                            <b>Designation</b> <span class="c"><%# Eval("Designation") %> </span><br />
                            <b>Location</b> <span class="d"><%# Eval("Location") %> </span><br />
                            <b>Country</b> <span class="e"><%# Eval("Country") %> </span><br />

                        </td>
                    </tr>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
