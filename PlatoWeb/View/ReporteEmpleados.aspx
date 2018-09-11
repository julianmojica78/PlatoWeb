<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/ReporteEmpleados.aspx.cs" Inherits="View_ReporteEmpleados" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="nav-justified">
        <tr>
            <td>
                <CR:CrystalReportViewer ID="CRV_Empleados" runat="server" AutoDataBind="true" ReportSourceID="CRS_Empleados" />
            </td>
        </tr>
        <tr>
            <td>
                <CR:CrystalReportSource ID="CRS_Empleados" runat="server">
                    <Report FileName="~\Reportes\ReporteEmpleados.rpt">
                    </Report>
                </CR:CrystalReportSource>
            </td>
        </tr>
    </table>

</asp:Content>

