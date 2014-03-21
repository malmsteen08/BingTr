<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DilDeneme._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1 {
            width: 100%;
        }

        .style2 {
            width: 201px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="style1">

                <tr>
                    <td class="style2">Kelime Gir:</td>
                    <td>
                        <asp:TextBox ID="txttext" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">Dil Seçimi:</td>
                    <td>
                        <asp:DropDownList ID="ddltolang" runat="server">
                            <asp:ListItem Value="en">English</asp:ListItem>
                            <asp:ListItem Value="fr">French</asp:ListItem>
                            <asp:ListItem Value="es">Spanish</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td>&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Translate" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
