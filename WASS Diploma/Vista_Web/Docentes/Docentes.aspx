<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Docentes.aspx.cs" Inherits="Vista_Web.Formulario_web13" %>
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
    <p>
    Gestión de docentes</p>
<p>
    <asp:GridView ID="gv_docentes" runat="server" 
        onselectedindexchanged="gv_docentes_SelectedIndexChanged" Width="100%" 
        AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
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
            onclick="btn_modificar_Click" style="height: 26px" />
        <span class="main">&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="btn_consulta" runat="server" onclick="btn_consulta_Click" 
            Text="Consultar" />
        <span class="main">&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="btn_cursos" runat="server" onclick="btn_cursos_Click" 
            Text="Ver cursos" />
</p>
<p class="style2">
    <asp:Label ID="lb_mensaje" runat="server" Text="Mensaje" ForeColor="#CC0000"></asp:Label>
    </p>
</asp:Content>
