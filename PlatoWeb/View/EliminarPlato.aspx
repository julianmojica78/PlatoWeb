<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/EliminarPlato.aspx.cs" Inherits="View_EliminarPlato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="text-center" style="height: 20px">ELIMINAR PLATO DEL REGISTRO</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GV_eliminarPato" runat="server" DataSourceID="ODS_obtenerPlato" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ButtonType="Button" HeaderText="Seleccionar" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_obtenerPlato" runat="server" SelectMethod="listarmenu" TypeName="Logica.Luser"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:Button ID="B_eliminar" runat="server" OnClick="B_eliminar_Click" Text="ELIMINAR" />
            </td>
        </tr>
    </table>
</asp:Content>

