<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageMesero.master" AutoEventWireup="true" CodeFile="~/Controller/MenuReserva.aspx.cs" Inherits="View_MenuReserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

     </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    

    <table class="nav-justified">
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>
                <asp:Label ID="L_Usuario" runat="server"></asp:Label>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>
                <asp:DataList ID="DataList1" runat="server" DataSourceID="ODS_Plato" RepeatDirection="Horizontal" OnSelectedIndexChanged="DataList1_SelectedIndexChanged1">
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
                <br />
                <asp:ObjectDataSource ID="ODS_Plato" runat="server" SelectMethod="menuReser" TypeName="Logica.LUser"></asp:ObjectDataSource>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
        </tr>
    </table>


</asp:Content>

