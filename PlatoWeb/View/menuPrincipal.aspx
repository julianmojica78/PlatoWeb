<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/menuPrincipal.aspx.cs" Inherits="View_menuPrincipal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style27 {
            width: 100%;
        }

        .auto-style28 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="auto-style27">
        <tr>
            <td>
                <h1 class="auto-style28"><strong>MENU</strong></h1>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_plato">
                    <Columns>
                        <asp:TemplateField HeaderText="Nombre">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Descripcion">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("descripcion") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Precio">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("precio") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Foto">
                            <ItemTemplate>
                                <asp:Image ID="Image2" runat="server" Height="50px" ImageUrl='<%# Bind("imagen") %>' Width="50px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EmptyDataTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("imagen") %>' />
                    </EmptyDataTemplate>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_plato" runat="server" SelectMethod="listarmenu" TypeName="Logica.Luser"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

