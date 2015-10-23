<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="Vista_Web.Formulario_web15" %>
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
        &nbsp;<asp:Label ID="lb_Curso" runat="server" Font-Size="X-Large" 
            ForeColor="#3366FF" Text="Comision"></asp:Label>
    </p>
    <p class="clear">
        <asp:Label ID="lb_nombre" runat="server" Text="Nombre del curso:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_nombre" runat="server" Font-Size="Smaller" Width="280px"></asp:TextBox>
    </p>
    <p class="clear">
        <asp:Label ID="lb_dinero_asignado" runat="server" Text="Objetivo:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_objetivo" runat="server" Font-Size="Smaller" Width="280px"></asp:TextBox>
    </p>
    <p class="clear">
        <asp:CheckBox ID="chk_arancelado" runat="server" Text="¿Es arancelado?" 
            CssClass="bold" />
    </p>
    <p class="clear">
        <asp:Label ID="lb_costo" runat="server" Text="Costo:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox 
            ID="txt_costo" runat="server" Font-Size="Smaller" Width="280px"></asp:TextBox>
    </p>
    <p class="clear">
        <asp:Label ID="lb_doncente" runat="server" Text="Doncete:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddl_doncentes" runat="server" Height="25px" Width="280px">
        </asp:DropDownList>
    </p>
    <p class="clear">
        <asp:Label ID="lb_comision_organizadora" runat="server" 
            Text="Comisión organizadora:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddl_comision" runat="server" Height="23px" Width="280px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p class="style2">
        <asp:Button ID="btn_guardar" runat="server" onclick="btn_guardar_Click" 
            Text="Guardar" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_volver" runat="server" Text="Volver" Width="77px" 
            onclick="btn_volver_Click" />
    </p>
</asp:Content>
