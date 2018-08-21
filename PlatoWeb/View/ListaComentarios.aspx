<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/ListaComentarios.aspx.cs" Inherits="View_ListaComentarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <table class="nav-justified">
        <tr>
            <td class="text-center" style="width: 5%; height: 20px;">
                <h1></h1>
            </td>
            <td class="text-center" style="90%; height: 20px;">
                <h1>Listado de Comentarios</h1>
            </td>
            <td style="width: 5%; height: 20px;">
                <h1></h1>
            </td>
        </tr>
        <tr>
            <td style="width: 5%; height: 20px;"></td>
            <td style="90%; height: 20px;">Buscar:<asp:TextBox ID="TB_Filtrar" runat="server" OnTextChanged="TB_Filtrar_TextChanged" Width="206px" placeholder="Ingrese Detalle" MaxLength="20"></asp:TextBox>
                <asp:Button ID="BT_Buscar" runat="server" OnClick="BT_Buscar_Click" Text="Buscar" />
                <asp:RegularExpressionValidator ID="validator_username" runat="server" ControlToValidate="TB_Filtrar" ErrorMessage="*Ingrese solo letras" ForeColor="Red" ValidationExpression="^[A-Za-zñÑ]*$" ValidationGroup="1"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 5%; height: 20px;"></td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="90%">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_Filtrar" ErrorMessage="No ha Ingresado Nada a Buscar" ForeColor="Red" ValidationGroup="Uno"></asp:RequiredFieldValidator>

            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="90%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%; height: 20px;"></td>
            <td style="90%; height: 20px;">
                <asp:GridView ID="GV_Listar" runat="server" AllowPaging="True" Width="100%" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="id_comentarios" HeaderText="ID" />
                        <asp:BoundField DataField="detalle" HeaderText="Detalle" />
                        <asp:BoundField DataField="user_name" HeaderText="Usuario" />
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
            <td style="width: 5%; height: 20px;"></td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="90%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="90%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
    </table>


</asp:Content>

