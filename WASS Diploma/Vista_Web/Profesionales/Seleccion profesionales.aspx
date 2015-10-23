<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Seleccion profesionales.aspx.cs" Inherits="Vista_Web.Formulario_web17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            text-align: left;
        }
        .style3
        {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:Label ID="lb_profesionales_inscriptos" runat="server" 
            Text="Profesionales inscriptos al curso:"></asp:Label>
&nbsp;<asp:Label ID="lb_curso" runat="server" Text="Curso" Font-Size="Large" 
            ForeColor="#3366FF"></asp:Label>
        <asp:GridView ID="gv_profesionales" runat="server" 
            AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
            GridLines="None" onrowdatabound="gv_profesionales_RowDataBound" 
            Width="100%" onselectedindexchanged="gv_profesionales_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
    </p>
    <p class="style2">
        <asp:Label ID="lb_inscripcion" runat="server" Text="Inscripcion"></asp:Label>
    </p>
    <p class="style1">
        <asp:Button ID="btn_inscribir" runat="server" onclick="btn_inscribir_Click" 
            Text="Inscribir" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_desinscribir" runat="server" 
            onclick="btn_desinscribir_Click" Text="Desinscribir" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_asentar_asistencia" runat="server" 
            onclick="btn_asentar_asistencia_Click" Text="Asentar asistencia" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_volver" runat="server" Text="Volver" Width="77px" 
            onclick="btn_volver_Click" />
    </p>
    <p class="style3">
        <asp:Label ID="lb_mensaje" runat="server" ForeColor="#CC0000" Text="Mensaje"></asp:Label>
    </p>
    <p class="style1">
        <asp:Label ID="lb_mensaje2" runat="server" Text="Mensaje2"></asp:Label>
    </p>
</asp:Content>
