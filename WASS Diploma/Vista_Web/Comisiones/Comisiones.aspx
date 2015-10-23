<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="Vista_Web.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            text-align: right;
        }
        .style2
        {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p class="style1">
        &nbsp;<asp:Label ID="lb_comision" runat="server" Font-Size="X-Large" 
            ForeColor="#3366FF" Text="Comision"></asp:Label>
    </p>
    <p class="clear">
        <asp:Label ID="lb_nombre" runat="server" Text="Nombre de la comision:"></asp:Label>
&nbsp;<asp:TextBox ID="txt_nombre" runat="server" Font-Size="Smaller"></asp:TextBox>
    </p>
    <p class="clear">
        <asp:Label ID="lb_dinero_asignado" runat="server" Text="Dinero asignado:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_dinero_asignado" runat="server" Font-Size="Smaller"></asp:TextBox>
    </p>
    <p class="clear">
        <asp:Label ID="lb_dinero_gastado" runat="server" Text="Dinero gastado:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_dinero_gastado" runat="server" Font-Size="Smaller"></asp:TextBox>
    </p>
    <p class="style2">
        <asp:Button ID="btn_guardar" runat="server" onclick="btn_guardar_Click" 
            Text="Guardar" />
        <span class="main">&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="btn_volver" runat="server" 
            PostBackUrl="~/Comisiones/Tablero Comisiones.aspx" Text="Volver" Width="77px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
</asp:Content>
