<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/CrearMenu.aspx.cs" Inherits="View_CrearMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified" style="width: 102%">
    <tr>
        <td class="text-center" colspan="2" style="font-size: medium"><strong>INSERTAR NUEVO MENÚ</strong></td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="LB_nompla" runat="server" Text="Nombre del plato: "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TB_nompla" runat="server" MaxLength="10" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RFV_nompla" runat="server" ControlToValidate="TB_nompla" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="REV_nombre" runat="server" ControlToValidate="TB_nompla" ErrorMessage="Ingrese solo letras" ForeColor="Red" ValidationExpression="^[A-Za-z_-]*$"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="LB_desc" runat="server" Text="Descripcion: "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TB_desc" runat="server" Height="118px" Width="215px" MaxLength="40" class="form-control" TextMode="MultiLine" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RFV_desc" runat="server" ControlToValidate="TB_desc" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revTexbox3" runat="server"
                        ErrorMessage="Debe ingresar hasta un maximo de 50 caracteres"
                        ValidationExpression="^([\s\S]{1,50})$"
                        ControlToValidate="TB_desc"
                        Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
        &nbsp;</td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="LB_precio" runat="server" Text="Precio del plato: "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TB_precio" runat="server" MaxLength="8" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RFV_precio" runat="server" ControlToValidate="TB_precio" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="REV_precio" runat="server" ErrorMessage="Ingrese solo numeros" ForeColor="Red" ValidationExpression="^[0-9_-]*$" ControlToValidate="TB_precio"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
    <tr>
        <td class="text-right" style="height: 19px">
            <asp:Label ID="Label1" runat="server" Text="Seleccione la imagen del plato"></asp:Label>
        </td>
        <td style="height: 19px">
            <asp:FileUpload ID="FU_imagen" runat="server" class="form-control" />
        </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
    <tr>
        <td class="text-center" colspan="2">
            <asp:Button ID="B_guardar" runat="server" OnClick="B_guardar_Click" Text="GUARDAR" />
        </td>
    </tr>
</table>
</asp:Content>

