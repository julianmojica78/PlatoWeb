<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageMesero.master" AutoEventWireup="true" CodeFile="~/Controller/Pedido.aspx.cs" Inherits="View_Pedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td colspan="2">
                <h3 class="text-center">PEDIDO</h3>
            </td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td class="text-right" style="width: 45%">Seleccione la Mesa:</td>
            <td style="width: 45%">
                <asp:DropDownList ID="DDL_Ubicacion" runat="server" DataSourceID="ODS_Ubicacion" DataTextField="ubicacion" DataValueField="id_mesa" Height="20px" Width="246px">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ODS_Ubicacion" runat="server" SelectMethod="obtenerubi" TypeName="Logica.LUser"></asp:ObjectDataSource>
            </td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="BT_Mesa" runat="server" OnClick="BT_Mesa_Click" Text="Ingresar Mesa" />
            </td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td colspan="2">
                <h3 class="text-center">Menú</h3>
            </td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td colspan="2">
                <asp:DataList ID="DataList1" runat="server" DataSourceID="ODS_Plato" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td colspan="3" class="auto-style7"><strong>
                                    <asp:Label ID="Label1" runat="server" CssClass="auto-style8" Text='<%# Bind("id_plato") %>'></asp:Label>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                                    </strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style1" colspan="3">
                                    <asp:Image ID="Image1" runat="server" Height="53px" ImageUrl='<%# Bind("imagen") %>' Width="114px" />
                                    <br />
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("descripcion") %>'></asp:Label>
                                    <br />
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("precio") %>'></asp:Label>
                                    <br />
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">Ingrese la cantidad del pedido</td>
                                <td class="auto-style5">
                                    <asp:TextBox ID="TB_insertarPedido" runat="server" MaxLength="2" ValidationGroup="1"></asp:TextBox>
                                </td>
                                <td rowspan="3" class="auto-style3">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11">&nbsp;</td>
                                <td class="auto-style2">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1" colspan="2">
                                    <asp:Button ID="B_guardar" runat="server" OnClick="B_guardar_Click" Text="ENVIAR" />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
                <asp:ObjectDataSource ID="ODS_Plato" runat="server" SelectMethod="platopedi" TypeName="Logica.LUser"></asp:ObjectDataSource>
            </td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td class="text-center" colspan="2">&nbsp;</td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
    </table>
&nbsp;
</asp:Content>


