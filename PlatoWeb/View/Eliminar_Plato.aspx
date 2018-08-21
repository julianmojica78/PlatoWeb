<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/Eliminar_Plato.aspx.cs" Inherits="View_Eliminar_Plato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
    <tr>
        <td class="text-center" colspan="2">REGISTRO SELECCIONADO PARA ELIMINAR</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="text-right">Nombre del plato: </td>
        <td>
            <asp:TextBox ID="TB_nompla" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right">Descripcion del plato: </td>
        <td>
            <asp:TextBox ID="TB_desc" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right">Precio del plato: </td>
        <td>
            <asp:TextBox ID="TB_precio" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right">Imagen del plato: </td>
        <td>
            <asp:TextBox ID="TB_imagen" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right">Codigo del plato: </td>
        <td>
            <asp:TextBox ID="TB_codigo" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="text-center" colspan="2">
            <asp:Button ID="B_eliminar" runat="server" OnClick="B_eliminar_Click" Text="ELIMINAR" />
        </td>
    </tr>
</table>
</asp:Content>

