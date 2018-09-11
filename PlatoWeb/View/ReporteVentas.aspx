<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/ReporteVentas.aspx.cs" Inherits="View_ReporteVentas" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td>
                <CR:CrystalReportViewer ID="CRV_Reportev" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="50px"  ReportSourceID="CRS_ReporteVentas" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="350px" />
                <CR:CrystalReportSource ID="CRS_ReporteVentas" runat="server">
                    <Report FileName="~\Reportes\ReporteVentas.rpt">
                    </Report>
                </CR:CrystalReportSource>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

