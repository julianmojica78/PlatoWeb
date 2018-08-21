<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/ListaVentas.aspx.cs" Inherits="View_ListaVentas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="text-center" colspan="3" style="font-size: x-large">
                <h3>LISTADO DE VENTAS</h3>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;Buscar:<asp:TextBox ID="TB_Filtro" runat="server" OnTextChanged="TB_Filtro_TextChanged" Width="201px" ValidationGroup="Uno" placeholder="Ingrese Nombre" MaxLength="20"></asp:TextBox>
                &nbsp;
                <asp:Button ID="BT_Buscar" runat="server" OnClick="BT_Buscar_Click" Text="Buscar" ValidationGroup="Uno" class="btn btn-primary"/>
                <asp:RegularExpressionValidator ID="validator_username" runat="server" ControlToValidate="TB_Filtro" ErrorMessage="*Ingrese solo letras" ForeColor="Red" ValidationExpression="^[A-Za-zñÑ]*$" ValidationGroup="1"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_Filtro" ErrorMessage="No ha Ingresado Nada a Buscar" ForeColor="Red" ValidationGroup="Uno"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <div class="text-center">
                    <asp:GridView ID="GridView1" runat="server" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 20px"></td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
        </tr>
        </table>
</asp:Content>

