<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/ListaEmpleados.aspx.cs" Inherits="View_ListaEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified" id="tbl_rol">

        <tr>
            <td colspan="3" style="height: 56px">
                <h3 class="text-center">Lista de Empleados</h3>
            </td>
        </tr>
        <tr>
            <td style="height: 20px"></td>
            <td style="height: 20px">
                <asp:Button ID="BT_Nuevo" runat="server" OnClick="BT_Nuevo_Click" Text="Nuevo" class="btn btn-primary"/>
            &nbsp;&nbsp;&nbsp;
                <asp:Button ID="BT_Modificar" runat="server" OnClick="Button1_Click" Text="Modificar" class="btn btn-primary"/>
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BT_Eliminar" runat="server" Text="Eliminar" OnClick="BT_Eliminar_Click1" class="btn btn-primary" />
            </td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Buscar:"></asp:Label>
            &nbsp;
                <asp:TextBox ID="TB_Filtro" runat="server" Width="218px" OnTextChanged="TB_Filtro_TextChanged" MaxLength="20" ValidationGroup="Uno" placeholder="Ingrese Nombre" ></asp:TextBox>
                &nbsp;
                <asp:Button ID="BT_Buscar" runat="server" OnClick="BT_Buscar_Click" Text="Buscar" ValidationGroup="Uno" class="btn btn-primary"/>
                <asp:RegularExpressionValidator ID="validator_username" runat="server" ControlToValidate="TB_Filtro" ErrorMessage="*Ingrese solo letras" ForeColor="Red" ValidationExpression="^[A-Za-zñÑ]*$" ValidationGroup="1"></asp:RegularExpressionValidator>
           
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%; height: 20px;"></td>
            <td style="height: 20px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_Filtro" ErrorMessage="No ha Ingresado Nada a Buscar" ForeColor="Red" ValidationGroup="Uno"></asp:RequiredFieldValidator>
            </td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>
                <asp:GridView ID="GV_Empleados" runat="server" Width="100%" AutoGenerateColumns="False" OnSelectedIndexChanged="GV_Empleados_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                        <asp:BoundField DataField="codigo" HeaderText="ID" Visible="False" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                        <asp:BoundField DataField="correo" HeaderText="Email" />
                        <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                        <asp:BoundField DataField="cedula" HeaderText="Cedula" />
                        <asp:BoundField DataField="usuario" HeaderText="Usuario" />
                        <asp:BoundField DataField="rol" HeaderText="Rol" />
                        <asp:BoundField DataField="clave" HeaderText="Contraseña" />
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
            <td>&nbsp;</td>
        <tr>
            <td style="width: 5%" class="text-center"></td>
            <td colspan="2" rowspan="3" style="width: 90%" class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%" class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="height: 50px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

