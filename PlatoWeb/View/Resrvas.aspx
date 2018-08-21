<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Resrvas.aspx.cs" Inherits="View_Resrvas" %>

<%@ Register Assembly="RJS.Web.WebControl.PopCalendar.Net.2008" Namespace="RJS.Web.WebControl" TagPrefix="rjs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
        }

        .auto-style2 {
            font-size: x-large;
        }

        .auto-style3 {
            height: 32px;
            width: 440px;
            margin-left: 0px;
        }

        .auto-style4 {
            width: 10%;
            height: 47px;
        }

        .auto-style5 {
            width: 10%;
            height: 47px;
            text-align: right;
        }

        .auto-style6 {
            width: 30%;
            height: 47px;
        }

        .auto-style7 {
            font-size: large;
        }
        .auto-style8 {
            width: 10%;
            height: 15px;
            text-align: right;
        }
        .auto-style9 {
            width: 10%;
            height: 15px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <table class="nav-justified">
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td class="auto-style1" colspan="6">
                <h1><strong>RESERVAS</strong></h1>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" style="width: 5%" rowspan="2"></td>
            <td class="auto-style5" colspan="3" style="width: 10%">
                <asp:Label ID="Label1" runat="server" Text="Fecha:" CssClass="auto-style7"></asp:Label>
            </td>
            <td class="auto-style6" colspan="2" rowspan="2">
                <div class="row form-group" style="height: 100%; width: 100%; margin-left: 0px;">
                    <div class="auto-style3" style="height: 100%; width: 100%; margin-left: 0px;">
                        <label class="sr-only" for="fecha">Fecha:</label>
                        <asp:TextBox ID="TB_Fecha" runat="server" Width="100%" class="form-control" placeholder="DD/MM/AAAA"></asp:TextBox>

                    </div>
                </div>
            </td>
            <td class="auto-style4">
                <rjs:PopCalendar ID="PopCalendar1" runat="server" Control="TB_Fecha" From-Date="" From-Today="True" ValidationGroup="uno" IncrementY="5" MessageAlignment="RightCalendarControl" ScriptsValidators="Server Only" StartAt="Sunday" />
                <asp:RequiredFieldValidator ID="RFV_Dia" runat="server" ControlToValidate="TB_Fecha" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="Uno"></asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator ID="REV_Fecha" runat="server" ControlToValidate="TB_Fecha" ErrorMessage="Fecha No Valida" ForeColor="Red" ValidationExpression="^[dd-mm-yyyy]*$"></asp:RegularExpressionValidator>

            </td>
            <td class="auto-style4" style="width: 5%" rowspan="2"></td>
        </tr>
        <tr>
            <td class="auto-style8" colspan="3">
                </td>
            <td class="auto-style9">
                </td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 3%" class="text-right">
                &nbsp;</td>
            <td style="width: 20%">
                <div class="row form-group" style="height: 100%; width: 100%; margin-left: 0px;">
                    <div class="auto-style3" style="height: 100%; width: 100%; margin-left: 0px;">
                    </div>
                </div>
            </td>
            <td style="width: 10%" class="text-right">
                <asp:Label ID="Label2" runat="server" Text="Hora:" CssClass="auto-style7"></asp:Label>
            </td>
            <td colspan="2">

                        <asp:DropDownList ID="DDL_Hora" runat="server" Width="100%" DataTextField="hora" DataValueField="id_hora" class="form-control">
                            <asp:ListItem Value="0">---Seleccione Opcion---</asp:ListItem>
                            <asp:ListItem Value="1">12</asp:ListItem>
                            <asp:ListItem Value="2">13</asp:ListItem>
                            <asp:ListItem Value="3">14</asp:ListItem>
                            <asp:ListItem Value="4">15</asp:ListItem>
                            <asp:ListItem Value="5">16</asp:ListItem>
                            <asp:ListItem Value="6">17</asp:ListItem>
                            <asp:ListItem Value="7">18</asp:ListItem>
                            <asp:ListItem Value="8">19</asp:ListItem>
                            <asp:ListItem Value="9">20</asp:ListItem>
                            <asp:ListItem Value="10">21</asp:ListItem>
                        </asp:DropDownList>

            </td>
            <td style="width: 10%">
                <asp:RangeValidator ID="RV_Hora" runat="server" ControlToValidate="DDL_Hora" ErrorMessage="Seleccione una Opcion" ForeColor="Red" MaximumValue="90" MinimumValue="1" SetFocusOnError="True" ValidationGroup="Uno"></asp:RangeValidator>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 40%" colspan="3" class="text-right">
                <asp:Label ID="Label4" runat="server" CssClass="auto-style7" Text="Cantidad de Personas:"></asp:Label>
            </td>
            <td style="width: 30%">
                <div class="row form-group" style="height: 100%; width: 100%; margin-left: 0px;">
                    <div class="auto-style3" style="height: 100%; width: 100%; margin-left: 0px;">
                        <label class="sr-only" for="fecha">Fecha:</label>
                        <asp:DropDownList ID="DDL_Cantp" runat="server" Width="300px" DataSourceID="ODS_Mesa" DataTextField="cantidad" DataValueField="id_mesa" OnSelectedIndexChanged="DDL_Cantp_SelectedIndexChanged" class="form-control">
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="ODS_Mesa" runat="server" SelectMethod="obtenerMesa" TypeName="DAOUsuario"></asp:ObjectDataSource>
                    
                    </div>
                </div>
            </td>
            <td style="width: 10%" colspan="2">
                        <asp:RangeValidator ID="RV_Cantidad" runat="server" ControlToValidate="DDL_Cantp" ErrorMessage="Seleccione una Opcion" ForeColor="Red" MaximumValue="5" MinimumValue="1" SetFocusOnError="True" ValidationGroup="Uno"></asp:RangeValidator>
                    </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 40%" colspan="3" class="text-center">
                &nbsp;</td>
            <td style="width40%" colspan="3">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td colspan="6" class="text-center">
                <asp:Button ID="B_Reservar" runat="server"  OnClick="Button8_Click" class="btn btn-primary"  Text="Reservar" ValidationGroup="Uno" />
                <asp:Button ID="BT_MReservas" runat="server" OnClick="BT_MReservas_Click" Text="Mis Reservas" class="btn btn-primary" ValidationGroup="dos" />
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        </table>
                         </asp:Content>

