<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Age.aspx.cs" Inherits="DemoTest.Age" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>DOB</td>
                    <td>
                        <asp:TextBox ID="txtDob" runat="server" TextMode="Date"></asp:TextBox></td>
                </tr>

                 <tr>
                    <td>Age</td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox></td>
                </tr>

                 <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                    
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
