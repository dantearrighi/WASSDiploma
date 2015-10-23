<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tablero Comisiones.aspx.cs" Inherits="Vista_Web.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            text-align: center;
            margin-left: 40px;
        }
        .style2
        {
            text-align: right;
        }
        .style3
        {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
    Comsiones del Colegio</h1>
<h2>
    Presupuesto total asignado a las comisiones:
    <asp:Label ID="lb_total" runat="server" Font-Size="Large" ForeColor="#0066FF" 
        Text="total"></asp:Label>
</h2>
    &nbsp;&nbsp;&nbsp;
    <asp:GridView ID="gv_comisiones" runat="server" Width="100%" 
        style="margin-top: 19px" AutoGenerateSelectButton="True" 
        onselectedindexchanged="gv_comisiones_SelectedIndexChanged1" 
        CellPadding="4" ForeColor="#333333" GridLines="None" 
        onrowdatabound="gv_comisiones_RowDataBound">
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
            Text="Dar de alta" />
        <span class="main">&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="btn_baja" runat="server" onclick="btn_baja_Click" 
            Text="Dar de baja" />
        <span class="main">&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="btn_modificar" runat="server" Text="Modificar" 
            onclick="btn_modificar_Click" />
        <span class="main">&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="btn_consulta" runat="server" onclick="btn_consulta_Click" 
            Text="Consultar" />
        <span class="main">&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="btn_cursos" runat="server" onclick="btn_cursos_Click" 
            Text="Ver cursos" />
</p>
<p class="style2">
    <asp:Label ID="lb_mensaje" runat="server" ForeColor="Red" Text="Mensaje"></asp:Label>
    </p>
    <p class="style3">
        Aquí puede visualizar a las comisiones y si estas han gastado más del 75% de su 
        dinero asignado (color rojo), entre un 50 y un 75% (color amarillo) y menos del 
        50 % (color verde).</p>
</asp:Content>
