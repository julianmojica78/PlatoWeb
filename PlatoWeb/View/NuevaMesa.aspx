<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/NuevaMesa.aspx.cs" Inherits="View_NuevaMesa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <table class="nav-justified">
        <tr>
            <td colspan="4">
                <h1 class="text-center">Ingresar Mesas</h1>
            </td>
        </tr>
        <tr>
            <td style="height: 20px"></td>
            <td class="text-right" style="height: 20px">Cantidad de Personas:</td>
            <td style="height: 20px">
                <asp:TextBox ID="TB_Cantidad" runat="server"  class="form-control" MaxLength="5"></asp:TextBox>
                <asp:RegularExpressionValidator ID="validator_username" runat="server" ControlToValidate="TB_Cantidad" ErrorMessage="*Ingrese solo Numeros" ForeColor="Red" ValidationExpression="^[0-9_-]*$" ValidationGroup="1"></asp:RegularExpressionValidator>
            </td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td style="height: 20px">&nbsp;</td>
            <td class="text-right" style="height: 20px">&nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-right">Ubiación:</td>
            <td>
                <asp:TextBox ID="TB_Ubicacion" runat="server" class="form-control" MaxLength="20"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TB_Ubicacion" ErrorMessage="*Ingrese solo letras Y Numeros" ForeColor="Red" ValidationExpression="^[A-Za-z0-9_-]*$" ValidationGroup="1"></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="4">
                <asp:Button ID="BT_Nuevo" runat="server" OnClick="BT_Nuevo_Click" Text="Nuevo" class="btn btn-primary"/>
            </td>
        </tr>
    </table>


</asp:Content>

