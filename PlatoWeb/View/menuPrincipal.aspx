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
                <asp:DataList ID="DataList1" runat="server" DataSourceID="ODS_Plato" RepeatDirection="Horizontal" RepeatColumns="4">
                    <ItemTemplate>
                        <table class="auto-style27">
                            <tr>
                                <td colspan="3">
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                              <div class="row">
                                <div class="col-lg-4 col-md-4 col-sm-6">
                                    <td>
                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("imagen") %>' width="20%" />
                                    </td>
                                </div>
                            </div>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("descripcion") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("precio") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
                <asp:ObjectDataSource ID="ODS_Plato" runat="server" SelectMethod="obtenerPlato" TypeName="DAOUsuario"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

