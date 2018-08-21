<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageMesero.master" AutoEventWireup="true" CodeFile="~/Controller/Reservas.aspx.cs" Inherits="View_Reservas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td style="width: 5%"></td>
            <td colspan="2" style="height: 20px">
                <h2 class="text-center">Reservas</h2>
            </td>
            <td style="width: 5%"></td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>
                <asp:Button ID="BT_Platos" runat="server" Text="Platos" class="btn btn-primary" OnClick="BT_Platos_Click" />
            </td>
            <td>&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td colspan="2">
                <div class="text-center">
                    <asp:GridView ID="GV_Reserva" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ODS_Re" ForeColor="Black" GridLines="Horizontal" Width="100%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                            <asp:BoundField DataField="user_name" HeaderText="Usuario" />
                            <asp:BoundField DataField="ubicacion" HeaderText="Mesa" />
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
                </div>
                <asp:ObjectDataSource ID="ODS_Re" runat="server" SelectMethod="obtenerRe" TypeName="DAOUsuario"></asp:ObjectDataSource>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

