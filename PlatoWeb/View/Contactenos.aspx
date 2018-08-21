<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Contactenos.aspx.cs" Inherits="View_Contactenos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style3 {
            width: 4%;
        }

        .auto-style4 {
            text-align: right;
            width: 4%;
        }

        .auto-style5 {
            width: 88%;
        }

        .auto-style6 {
            text-align: right;
            width: 4%;
            height: 27px;
        }

        .auto-style7 {
            width: 88%;
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>Contactenos</title>

        <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700" rel="stylesheet" />
        <link href="https://fonts.googleapis.com/css?family=Kaushan+Script" rel="stylesheet" />


        <link rel="stylesheet" href="../Styles/css/animate.css" />
        <link rel="stylesheet" href="../Styles/css/icomoon.css" />
        <link rel="stylesheet" href="../Styles/css/themify-icons.css" />
        <link rel="stylesheet" href="../Styles/css/bootstrap.css" />
        <link rel="stylesheet" href="../Styles/css/magnific-popup.css" />
        <link rel="stylesheet" href="../Styles/css/bootstrap-datetimepicker.min.css" />
        <link rel="stylesheet" href="../Styles/css/owl.carousel.min.css" />
        <link rel="stylesheet" href="../Styles/css/owl.theme.default.min.css" />
        <link rel="stylesheet" href="../Styles/css/style.css" />
        <script src="../Styles/js/modernizr-2.6.2.min.js"></script>


    </head>
    <body>
        <table class="nav-justified">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <h3>Contactenos</h3>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TB_Nombre" runat="server" class="form-control" MaxLength="20" placeholder="Nombre"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="validator_username" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="*Ingrese solo letras" ForeColor="Red" ValidationExpression="^[A-Za-z_-]*$" ValidationGroup="1"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Email:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TB_Email" runat="server" class="form-control" MaxLength="30" TextMode="Email" placeholder="Email"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_Email" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label3" runat="server" Text="Telefono:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TB_Telefono" runat="server" class="form-control" MaxLength="10" placeholder="Telefono"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_Telefono" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TB_Telefono" ErrorMessage="*Ingrese solo Numeros" ForeColor="Red" ValidationExpression="^[0-9]*$" ValidationGroup="1"></asp:RegularExpressionValidator>

                </td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label4" runat="server" Text="Detalle:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TB_Detalle" runat="server" Height="131px" Width="297px" class="form-control" TextMode="MultiLine" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TB_Detalle" ErrorMessage="*" ForeColor="Red" placeholder="Detalle"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revTexbox3" runat="server"
                        ErrorMessage="Debe ingresar hasta un maximo de 50 caracteres"
                        ValidationExpression="^([\s\S]{1,50})$"
                        ControlToValidate="TB_Detalle"
                        Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>

                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" colspan="2">
                    <asp:Button ID="BT_Enviar" runat="server" OnClick="BT_Enviar_Click1" Text="Enviar" class="btn btn-primary" />
                </td>
            </tr>
        </table>
        <script src="../Styles/js/jquery.min.js"></script>
        <script src="../Styles/js/jquery.easing.1.3.js"></script>
        <script src="../Styles/js/bootstrap.min.js"></script>
        <script src="../Styles/js/jquery.waypoints.min.js"></script>
        <script src="../Styles/js/owl.carousel.min.js"></script>
        <script src="../Styles/js/jquery.countTo.js"></script>
        <script src="../Styles/js/jquery.stellar.min.js"></script>
        <script src="../Styles/js/jquery.magnific-popup.min.js"></script>
        <script src="../Styles/js/magnific-popup-options.js"></script>

        <script src="../Styles/js/moment.min.js"></script>
        <script src="../Styles/js/bootstrap-datetimepicker.min.js"></script>
        <script src="../Styles/js/main.js"></script>

    </body>
</asp:Content>

