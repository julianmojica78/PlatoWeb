<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/CanjePuntos.aspx.cs" Inherits="View_CanjePuntos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #000000;
            font-size: large;
        }
        .auto-style2 {
            height: 27px;
        }
        .auto-style3 {
            text-align: right;
            color: #000000;
        }
    .auto-style4 {
        text-align: center;
        color: #000000;
        width: 981px;
    }
    .auto-style5 {
        width: 981px;
    }
        .auto-style6 {
            width: 981px;
            height: 11px;
        }
        .auto-style7 {
            height: 23px;
        }
        .auto-style8 {
            height: 16px;
        }
        .auto-style9 {
            height: 11px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="auto-style1" colspan="4"><strong>PUNTOS RECOLECTADOS</strong></td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="2">
                Cantidad de puntos seleccionados<br />
                <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="Puntos insuficientes para canjear"></asp:Label>
            </td>
            <td class="text-left" colspan="2">
                <asp:Label ID="LB_puntos" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="4">
                <h4>Historial</h4>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 5%">
                &nbsp;</td>
            <td class="text-center" colspan="2"style="width:90%">
            
                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                             <Columns>
                                 <asp:BoundField DataField="id_mesa" HeaderText="Mesa" />
                                 <asp:BoundField DataField="puntos" HeaderText="Puntos" Visible="False" />
                                 <asp:BoundField DataField="dia" HeaderText="Dia" />
                             </Columns>
                             <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                             <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                             <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                             <SortedAscendingCellStyle BackColor="#F7F7F7" />
                             <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                             <SortedDescendingCellStyle BackColor="#E5E5E5" />
                             <SortedDescendingHeaderStyle BackColor="#242121" />
                         </asp:GridView>
            
            </td>
            <td class="text-center" >
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="2">
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
                                    <br />
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11"></td>
                                <td class="auto-style2">
                                    &nbsp;</td>
                                <td rowspan="2" class="auto-style3">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1" colspan="2">
                                    <asp:Button ID="BT_Canje" runat="server" Text="Canjear" class="btn btn-primary" OnClick="BT_Canje_Click" ValidationGroup="dos" />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
                </td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="2">
                </td>
            <td class="auto-style9" colspan="2"></td>
        </tr>
        <tr>
            <td class="text-center" colspan="2">
                <asp:Button ID="BT_MReservas" runat="server" OnClick="BT_MReservas_Click" Text="Regresar" class="btn btn-primary" ValidationGroup="dos" />
            
                </td>
            <td colspan="2">&nbsp;</td>
        </tr>
    </table>
    <br />
                <asp:ObjectDataSource ID="ODS_Plato" runat="server" SelectMethod="obtenerPlato" TypeName="DAOUsuario"></asp:ObjectDataSource>
            </asp:Content>

