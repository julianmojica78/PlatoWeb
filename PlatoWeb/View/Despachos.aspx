<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageCocinero.master" AutoEventWireup="true" CodeFile="~/Controller/Despachos.aspx.cs" Inherits="View_Despachos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            width: 50%;
            height: 204px;
        }
        .auto-style2 {
            text-align: center;
            width: 50%;
            height: 27px;
        }
        .auto-style3 {
            text-align: center;
            width: 0.1%;
            height: 27px;
        }
        .auto-style4 {
            text-align: left;
            height: 27px;
        }
        .auto-style5 {
            text-align: left;
            height: 16px;
        }
        </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table class="nav-justified">
        <tr>
            <td class="auto-style2">
            </td>
            <td class="auto-style3">
                </td>
            <td class="auto-style2">
            </td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="3">
                <h3>Pedidos</h3>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:GridView ID="GV_Pedidos" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Despachos" Width="100%" DataKeyNames="id_pedido" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                    <Columns>
                        <asp:CommandField ButtonType="Button" EditText="Pedido" HeaderText="Ordenes" ShowSelectButton="True" />
                        <asp:BoundField DataField="id_pedido" HeaderText="Pedido" />
                        <asp:BoundField HeaderText="Mesa" DataField="id_mesa" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Despachos" runat="server" SelectMethod="obtenerdatos" TypeName="DAOUsuario"></asp:ObjectDataSource>
            </td>
            <td style="width: 0.1%" class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Plato" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="100%" DataKeyNames="id_pedido" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                    <Columns>
                        <asp:BoundField DataField="id_pedido" HeaderText="Pedido" />
                        <asp:BoundField DataField="nombre" HeaderText="Plato" />
                        <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                        <asp:CommandField ButtonType="Button" HeaderText="Despachar" ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Plato" runat="server" SelectMethod="informacionPlato" TypeName="DAOUsuario" UpdateMethod="despacho">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="GV_Pedidos" Name="id_pedido" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="id_pedido" Type="Int32" />
                        <asp:Parameter Name="fecha_despacho" Type="DateTime" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                </td>
            <td class="auto-style3">
                </td>
            <td class="auto-style2">
                </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <h3>Reservas</h3>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Despacho1" Width="100%" DataKeyNames="id_pedido" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                        <asp:BoundField DataField="id_pedido" HeaderText="Pedido" />
                        <asp:BoundField DataField="id_mesa" HeaderText="Mesa" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Despacho1" runat="server" SelectMethod="obtenerdatos1" TypeName="DAOUsuario"></asp:ObjectDataSource>
            </td>
            <td style="width: 0.1%" class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Plato1" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" Width="100%" DataKeyNames="id_pedido" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                    <Columns>
                        <asp:BoundField DataField="id_pedido" HeaderText="Pedido" />
                        <asp:BoundField DataField="Nombre" HeaderText="Plato" />
                        <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Plato1" runat="server" SelectMethod="informacionPlato1" TypeName="DAOUsuario">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="GridView2" Name="id_pedido" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
    
</asp:Content>

