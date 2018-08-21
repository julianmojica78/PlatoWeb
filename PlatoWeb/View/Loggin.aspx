<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Loggin.aspx.cs" Inherits="View_Loggin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style27 {
            width: 100%;
        }

        .auto-style29 {
            height: 26px;
        }

        .auto-style30 {
            text-align: right;
            height: 26px;
        }

        .auto-style28 {
            text-align: right;
            height: 27px;
        }

        .auto-style31 {
            text-align: center;
        }

        .auto-style32 {
            height: 27px;
        }
        .auto-style33 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 100%;
            left: 2px;
            top: 23px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style34 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 100%;
            left: 1px;
            top: 22px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style35 {
            height: 27px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="auto-style27">
        <tr>
            <td class="auto-style13" colspan="4">
                <h1 class="auto-style31">Iniciar Sesion</h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style29"></td>
            <td id="L_User" class="auto-style30" style="width: 30%"><strong>Nombre de Usuario:</strong></td>

            <td class="auto-style29">
                <div class="row form-group">
                    <div class="auto-style33">
                        <asp:TextBox ID="UserName" runat="server" Font-Size="0.8em" class="form-control" Width="520px" placeholder="Usuario"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_User" runat="server" ControlToValidate="UserName" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="Uno"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </td>
            <td class="auto-style29"></td>
        </tr>
        <tr>
            <td class="auto-style32"></td>
            <td id="L_Clave" class="auto-style28" style="width: 30%"><strong>Contraseña</strong>:</td>
            <td class="auto-style32">
                            <div class="row form-group">
               <div class="auto-style34">
                <asp:TextBox ID="Password" runat="server" Font-Size="0.8em" TextMode="Password" class="form-control" Width="520px" placeholder="Contraseña"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Clave" runat="server" ControlToValidate="Password" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="Uno"></asp:RequiredFieldValidator>
            </div>
                                </div>
                   </td>
            <td class="auto-style32"></td>
        </tr>
        <tr>
            <td class="auto-style32"></td>
            <td class="auto-style35" colspan="2">&nbsp;</td>
            <td class="auto-style32"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style31" colspan="2">
                <asp:LinkButton ID="LB_Recuperar" runat="server" OnClick="LB_Recuperar_Click">Recuperar Contraseña</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style31" colspan="2">
                 <div class="form-group">
                <asp:Button ID="B_Registrarse" runat="server" OnClick="B_Registrarse_Click" Text="Registrarse" class="btn btn-primary" ValidationGroup="dos" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="B_Login" runat="server" OnClick="Button8_Click" Text="Inicio de Sesión" ValidationGroup="Uno" class="btn btn-primary" />
            </div>
                     </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

