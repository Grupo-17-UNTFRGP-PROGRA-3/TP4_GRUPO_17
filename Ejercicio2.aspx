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
        .auto-style6 {
            width: 18px;
        }
        .auto-style7 {
            width: 16px;
        }
        .auto-style8 {
            width: 103px;
        }
        .auto-style9 {
        }
        .auto-style10 {
            width: 190px;
        }
        .auto-style11 {
            width: 36px;
            height: 37px;
        }
        .auto-style12 {
            width: 18px;
            height: 37px;
        }
        .auto-style14 {
            width: 16px;
            height: 37px;
        }
        .auto-style15 {
            width: 190px;
            height: 37px;
        }
        .auto-style16 {
            height: 37px;
        }
        .auto-style17 {
            width: 103px;
            height: 37px;
        }
        .auto-style18 {
            width: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="margin-left: 40px">Trabajo Práctico N°4 - Grupo 17</h1>
        <nav>
            <p style="margin-left: 40px">
            <a href="Ejercicio1.aspx">Ejercicio 1</a> |
            <a href="Ejercicio2.aspx">Ejercicio 2</a> |
            <a href="Ejercicio3.aspx">Ejercicio 3</a>
           </p>
        </nav>
        <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ejercicio 2</h2>

        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">
                        Id Producto:</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:DropDownList ID="ddlProducto" runat="server" AutoPostBack="True">
                            <asp:ListItem Value="=">Igual a:</asp:ListItem>
                            <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                            <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="txtProducto" runat="server" Width="170px" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">
                        Id Categoria:</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:DropDownList ID="ddlCategoria" runat="server">
                            <asp:ListItem Value="=">Igual a:</asp:ListItem>
                            <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                            <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCategoria" runat="server" Width="170px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style17"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style15">
                        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    <td class="auto-style16">
                        <asp:Button ID="btnQuitarFiltro" runat="server" Text="Quitar filtro" />
                    </td>
                    <td class="auto-style16"></td>
                </tr>
                <tr>
                    <td class="auto-style9" colspan="7">
                        <asp:GridView ID="gvProductos" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style18">&nbsp;</td>
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
