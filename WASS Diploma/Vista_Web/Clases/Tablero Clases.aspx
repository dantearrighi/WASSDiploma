<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tablero Clases.aspx.cs" Inherits="Vista_Web.Formulario_web18" %>
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
        Clases del curso:
    <asp:Label ID="lb_curso" runat="server" Text="Curso" Font-Size="Large" 
            ForeColor="#3366FF"></asp:Label>
&nbsp;&nbsp;<p>
    <asp:GridView ID="gv_clases" runat="server" Width="100%" 
        style="margin-top: 19px" AutoGenerateSelectButton="True" CellPadding="4" 
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
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_volver" runat="server" onclick="btn_volver_Click" 
            Text="Volver" />
    </p>
    <p class="style1">
        <asp:Button ID="btn_dar_presente" runat="server" 
            onclick="btn_dar_presente_Click" Text="Dar presente" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_dar_ausente" runat="server" onclick="btn_dar_ausente_Click" 
            Text="Dar ausente" />
    </p>
    <p class="style2">
        <asp:Label ID="lb_mensaje" runat="server" Text="Mensaje" ForeColor="#CC0000"></asp:Label>
    </p>
    <p class="style1">
        Aquí puede visualizar si a las clases han asistido más del 75% de los inscriptos 
        (color verde), entre un 50 y un 75% (color amarillo) y menos del 50 % (color 
        rojo).</p>
</asp:Content>
