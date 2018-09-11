<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/ReporteReserva.aspx.cs" Inherits="View_ReporteReserva" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td>
                <CR:CrystalReportViewer ID="CRV_Reserva" runat="server" AutoDataBind="true" ReportSourceID="CRS_Reserva" />
            </td>
        </tr>
        <tr>
            <td>
                <CR:CrystalReportSource ID="CRS_Reserva" runat="server">
                    <Report FileName="~\Reportes\ReporteReserva.rpt">
                    </Report>
                </CR:CrystalReportSource>
            </td>
        </tr>
    </table>
</asp:Content>

