<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Docente.aspx.cs" Inherits="Vista_Web.Formulario_web14" %>
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
        <asp:Label ID="lb_docente" runat="server" Font-Size="X-Large" 
            ForeColor="#3366FF" Text="Docente"></asp:Label>
        <br />
    </p>
    <p>
        <asp:Label ID="lb_nombre" runat="server" Text="Nombre del docente:"></asp:Label>
        <span class="clear">&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="txt_nombre" runat="server" Font-Size="Smaller"></asp:TextBox>
    </p>
    <p class="style2">
        <asp:Button ID="btn_guardar" runat="server" onclick="btn_guardar_Click" 
            Text="Guardar" />
        <span class="main">&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="btn_volver" runat="server" 
            PostBackUrl="~/Docentes/Docentes.aspx" Text="Volver" Width="77px" />
    </p>
    <p>
    </p>
</asp:Content>
