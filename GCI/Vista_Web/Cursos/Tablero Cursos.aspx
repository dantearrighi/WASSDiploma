<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tablero Cursos.aspx.cs" Inherits="Vista_Web.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        CURSOS del Colegio</h1>
    &nbsp;<br />
    Cursos de la comisión:
    <asp:Label ID="lb_comision" runat="server" Text="Comsion" Font-Size="Large" 
        ForeColor="#3366FF"></asp:Label>
&nbsp;<asp:GridView ID="gv_cursos" runat="server" Width="100%" 
        style="margin-top: 19px" AutoGenerateSelectButton="True" 
        onselectedindexchanged="gv_cursos_SelectedIndexChanged" CellPadding="4" 
        CssClass="clear" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" 
            HorizontalAlign="Left" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <p class="style1">
        <asp:Button ID="btn_alta" runat="server" onclick="btn_alta_Click" 
            Text="Dar de alta" style="height: 26px" />
        <span class="bold">&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="btn_baja" runat="server" onclick="btn_baja_Click" 
            Text="Dar de baja" />
        <span class="bold">&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="btn_modificar" runat="server" Text="Modificar" 
            onclick="btn_modificar_Click" />
        <span class="bold">&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="btn_consulta" runat="server" onclick="btn_consulta_Click" 
            Text="Consultar" />
        <span class="bold">&nbsp;&nbsp;&nbsp;
        </span>
    </p>
    <p class="style1">
        <asp:Button ID="btn_asistencias" runat="server" onclick="btn_asistencias_Click" 
            Text="Asentar asistencias" />
        <span class="bold">&nbsp;&nbsp;&nbsp; </span>
        <asp:Button ID="btn_inscribir_profesional" runat="server" CssClass="clear" 
            onclick="btn_inscribir_profesional_Click" Text="Inscribir profesional" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_desinscribir_profesional" runat="server" CssClass="clear" 
            onclick="btn_desinscribir_profesional_Click" 
            Text="Desinscribir profesional" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_clase" runat="server" onclick="btn_clase_Click" 
            Text="Ver clases" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_inscriptos" runat="server" onclick="btn_inscriptos_Click" 
            Text="Ver inscriptos" style="height: 26px" />
    </p>
    <p class="style2">
        <asp:Label ID="lb_mensaje" runat="server" ForeColor="#CC0000" Text="Mensaje"></asp:Label>
    </p>
    <p class="style1">
        Aquí puede visualizar si los cursos cuentan con más del 75% de los inscriptos 
        con respecto al objetivo (color verde), entre un 50 y un 75% (color amarillo) y menos 
        del 50 % (color rojo).</p>
</asp:Content>
