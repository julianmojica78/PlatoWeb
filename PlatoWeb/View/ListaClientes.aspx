<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/ListaClientes.aspx.cs" Inherits="View_ListaClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td colspan="3">
                <h3 class="text-center"><strong>Lista de Clientes</strong></h3>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;Buscar:<asp:TextBox ID="TB_Filtro" runat="server" OnTextChanged="TB_Filtro_TextChanged" Width="201px" ValidationGroup="Uno" placeholder="Ingrese Nombre"></asp:TextBox>
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
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td rowspan="5">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" Width="100%" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="usuario" HeaderText="Usuario" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                        <asp:BoundField DataField="correo" HeaderText="Email" />
                        <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                        <asp:BoundField DataField="puntos" HeaderText="Puntos" />
                    </Columns>
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
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

