<%@ Page Title="RECUPERAR CONTRASEÑA" Language="C#" MasterPageFile="~/View/MasterPago.master" AutoEventWireup="true" CodeFile="~/Controller/Recuperar_contraseña.aspx.cs" Inherits="View_Recuperar_contraseña" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style27 {
            width: 100%;
        }
        .auto-style28 {
            text-align: right;
        }
        .auto-style29 {
            text-align: center;
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style27">
        <tr>
            <td class="auto-style29" colspan="2">RECUPERAR CONTRASEÑA</td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28" style="width: 50%">Digite su nueva contraseña:</td>
            <td>
                <asp:TextBox ID="TB_newPass" runat="server" class="form-control" MaxLength="10" TextMode="Password" ValidationGroup="uno"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28">Repita la contraseña:</td>
            <td>
                <asp:TextBox ID="TB_repnewPass" runat="server" class="form-control" MaxLength="10" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="2">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TB_newPass" ControlToValidate="TB_repnewPass" ErrorMessage="No son iguales" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="2">
                <asp:Button ID="Guardar_new_pass" runat="server" Text="Aplicar cambios" OnClick="Guardar_new_pass_Click" class="btn btn-primary" />
            </td>
        </tr>
    </table>
</asp:Content>

