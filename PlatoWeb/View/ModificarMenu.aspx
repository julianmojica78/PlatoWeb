<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/ModificarMenu.aspx.cs" Inherits="View_ModificarMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
    <tr>
        <td class="text-center" colspan="2">MODIFICAR MENÚ</td>
    </tr>
    <tr>
        <td colspan="2" style="height: 18px"></td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="LB_nompla" runat="server" Text="Ingrese el nombre del plato"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TB_nompla" runat="server" MaxLength="10" class="form-control"></asp:TextBox>
            &nbsp;<asp:RegularExpressionValidator ID="REV_nombre" runat="server" ControlToValidate="TB_nompla" ErrorMessage="Ingrese solo letras" ForeColor="Red" ValidationExpression="^[A-Za-z_-]*$"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="text-right">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="LB_desc" runat="server" Text="Descripcion del plato: "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TB_desc" runat="server" MaxLength="15" class="form-control"></asp:TextBox>
        &nbsp;<asp:RegularExpressionValidator ID="REV_desc" runat="server" ControlToValidate="TB_desc" ErrorMessage="Ingrese solo letras y numeros" ForeColor="Red" ValidationExpression="^[A-Za-z0-9_-]*$"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="text-right">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="Label1" runat="server" Text="Precio del plato: "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TB_precio" runat="server" MaxLength="8" class="form-control"></asp:TextBox>
        &nbsp;<asp:RegularExpressionValidator ID="validator_username" runat="server" ControlToValidate="TB_precio" ErrorMessage="*Ingrese solo Numeros" ForeColor="Red" ValidationExpression="^[A-Za-z0-9_-]*$" ValidationGroup="1"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="text-right">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="LB_imagen" runat="server" Text="Seleccione imagen del plato: "></asp:Label>
        </td>
        <td>
            <asp:FileUpload ID="FU_imagen" runat="server" class="form-control"/>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="height: 22px"> </td>
        <td style="height: 22px">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="text-right">
            &nbsp;</td>
        <td class="text-left">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="text-center" colspan="2">
            <asp:Button ID="B_Modificar" runat="server" OnClick="B_Modificar_Click" Text="MODIFICAR" class="btn btn-primary" />
        </td>
    </tr>
</table>
</asp:Content>

