<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/ListadePlatos.aspx.cs" Inherits="View_ListadePlatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
    <tr>
        <td class="text-center" colspan="2">
            <h3>LISTA DE PLATOS </h3>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="height: 36px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="BT_Nuevo" runat="server" Text="Nuevo" class="btn btn-primary" OnClick="BT_Nuevo_Click" />
              &nbsp;&nbsp;&nbsp;<asp:Button ID="B_modificar" runat="server" OnClick="B_modificar_Click" Text="Modificar" class="btn btn-primary" />
             &nbsp;&nbsp;&nbsp; <asp:Button ID="BT_Eliminar" runat="server" Text="Eliminar" class="btn btn-primary" OnClick="BT_Eliminar_Click"/>
        </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Buscar:"></asp:Label>
                <asp:TextBox ID="TB_Filtro" runat="server" Width="218px" OnTextChanged="TB_Filtro_TextChanged" MaxLength="20" ValidationGroup="Uno" placeholder="Ingrese Nombre"></asp:TextBox>
                &nbsp;
                <asp:Button ID="BT_Buscar" runat="server" OnClick="BT_Buscar_Click" Text="Buscar" ValidationGroup="Uno" class="btn btn-primary"/>
                <asp:RegularExpressionValidator ID="validator_username" runat="server" ControlToValidate="TB_Filtro" ErrorMessage="*Ingrese solo letras" ForeColor="Red" ValidationExpression="^[A-Za-zñÑ]*$" ValidationGroup="1"></asp:RegularExpressionValidator>
           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_Filtro" ErrorMessage="No ha Ingresado Nada a Buscar" ForeColor="Red" ValidationGroup="Uno"></asp:RequiredFieldValidator>
            </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="GV_Platos" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ButtonType="Button" HeaderText="Seleccionar" ShowSelectButton="True"/>
                    <asp:BoundField DataField="id_plato" HeaderText="Codigo del plato" Visible="False" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                    <asp:BoundField DataField="precio" HeaderText="Precio" />
                    <asp:ImageField DataImageUrlField="imagen" HeaderText="Imagen">
                        <ControlStyle Height="15%" Width="15%" />
                    </asp:ImageField>
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
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 20px">
        &nbsp;&nbsp;&nbsp;
        </td>
        <td style="height: 20px"></td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
</table>
</asp:Content>

