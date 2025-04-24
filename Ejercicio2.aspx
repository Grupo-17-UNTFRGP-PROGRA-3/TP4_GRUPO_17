<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP4_GRUPO_17.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>TP N°4 - Grupo 17 - Ej. 2</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 24px;
        }
        .auto-style6 {
            width: 18px;
        }
        .auto-style7 {
            width: 16px;
        }
        .auto-style8 {
            width: 83px;
        }
        .auto-style9 {
            width: 94px;
        }
        .auto-style10 {
            width: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Trabajo Práctico N°4 - Grupo 17</h1>
        <nav>
            <a href="Ejercicio1.aspx">Ejercicio 1</a> |
            <a href="Ejercicio2.aspx">Ejercicio 2</a> |
            <a href="Ejercicio3.aspx">Ejercicio 3</a>
        </nav>
        <h2>Ejercicio 2</h2>

        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">Id Producto:</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="ddlProducto" runat="server">
                            <asp:ListItem Value="==">Igual a:</asp:ListItem>
                            <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                            <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="txtProducto" runat="server" Width="170px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">Id Categoria:</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="ddlCategoria" runat="server">
                            <asp:ListItem Value="==">Igual a:</asp:ListItem>
                            <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                            <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="txtCategoria" runat="server" Width="170px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnQuitarFiltro" runat="server" Text="Quitar filtro" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
