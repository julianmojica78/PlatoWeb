<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/ListaUsuarios.aspx.cs" Inherits="View_ListaUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="text-center" colspan="3">
                <h2>LISTADO DE CLIENTES</h2>
            </td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" DataSourceID="ODS_obtenerCliente" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_obtenerCliente" runat="server" SelectMethod="obtenercliente" TypeName="DAOUsuario"></asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

