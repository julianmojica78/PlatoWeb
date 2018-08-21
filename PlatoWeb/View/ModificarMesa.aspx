<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/ModificarMesa.aspx.cs" Inherits="View_ModificarMesa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="nav-justified">
        <tr>
            <td class="text-center" colspan="4">
                <h1>Modificar Mesas</h1>
            </td>
        </tr>
        <tr>
            <td style="height: 22px"></td>
            <td class="text-right" style="height: 22px">ID:</td>
            <td>
                <asp:TextBox ID="TB_id_mesa" runat="server" class="form-control" Enabled="False" Height="32px" Width="186px"></asp:TextBox>
            </td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="height: 22px">&nbsp;</td>
            <td class="text-right" style="height: 22px">&nbsp;</td>
            <td style="height: 22px">
                &nbsp;</td>
            <td style="height: 22px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 22px"></td>
            <td class="text-right" style="height: 22px">Cantidad de Personas</td>
            <td style="height: 22px">
                <asp:TextBox ID="TB_Cantidad" runat="server" Width="168px" class="form-control"></asp:TextBox>
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
            <td class="text-right">Ubicación:</td>
            <td>
                <asp:TextBox ID="TB_Ubicacion" runat="server" Width="168px" class="form-control"></asp:TextBox>
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
            <td>&nbsp;</td>
            <td class="text-center" colspan="2">
                <asp:Button ID="BT_Modificar" runat="server" OnClick="BT_Modificar_Click" Text="Modificar" class="btn btn-primary" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>

