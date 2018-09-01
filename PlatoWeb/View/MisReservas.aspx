<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/MisReservas.aspx.cs" Inherits="View_MisReservas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 20%;
            height: 99px;
        }
        .auto-style2 {
            color: #000000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

             <table class="nav-justified">
                 <tr>
                     <td style="width: 20%">&nbsp;</td>
                     <td rowspan="2" class="text-center">
                         <h1>Mis Reservas</h1>
                     </td>
                     <td style="width: 20%">&nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style1"></td>
                     <td class="auto-style1"></td>
                 </tr>
                 <tr>
                     <td style="width: 20%">&nbsp;</td>
                     <td>&nbsp;</td>
                     <td style="width: 20%">&nbsp;</td>
                 </tr>
                 <tr>
                     <td style="width: 20%">&nbsp;</td>
                     <td>
                         <asp:GridView ID="GV_misreservas" runat="server" AutoGenerateColumns="False" Width="100%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                             <Columns>
                                 <asp:BoundField DataField="id_mesa" HeaderText="Mesa" />
                                 <asp:BoundField DataField="puntos" HeaderText="Puntos" Visible="False" />
                                 <asp:BoundField DataField="dia" HeaderText="Dia" />
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
                     </td>
                     <td style="width: 20%">&nbsp;</td>
                 </tr>
                 <tr>
                     <td style="width: 20%">&nbsp;</td>
                     <td>&nbsp;</td>
                     <td style="width: 20%">&nbsp;</td>
                 </tr>
                 <tr>
                     <td style="width: 20%">&nbsp;</td>
                     <td class="text-center">
                         <asp:Button ID="BT_Regresar" runat="server" OnClick="BT_Regresar_Click" Text="Regresar" class="btn btn-primary"/>
                     </td>
                     <td style="width: 20%">&nbsp;</td>
                 </tr>
             </table>

</asp:Content>

