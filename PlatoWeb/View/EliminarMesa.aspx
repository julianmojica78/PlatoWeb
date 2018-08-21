<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/EliminarMesa.aspx.cs" Inherits="View_EliminarMesa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="text-center" colspan="4">
                <h1>Eliminar Mesas</h1>
            </td>
        </tr>
        <tr>
            <td style="height: 22px"></td>
            <td class="text-right" style="height: 22px">ID:</td>
            <td style="height: 22px">
                <asp:TextBox ID="TB_id_mesa" runat="server" Enabled="False" Width="168px"></asp:TextBox>
            </td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="height: 22px"></td>
            <td class="text-right" style="height: 22px">Cantidad de Personas</td>
            <td style="height: 22px">
                <asp:TextBox ID="TB_Cantidad" runat="server" Width="168px" Enabled="False"></asp:TextBox>
            </td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-center" colspan="2">
                <asp:Button ID="BT_Eliminar" runat="server" OnClick="BT_Modificar_Click" Text="Eliminar" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>

