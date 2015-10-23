<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clases.aspx.cs" Inherits="Vista_Web.Formulario_web19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Seleccionar la fecha de la clase</p>
    <p>
        <asp:Label ID="lb_fecha" runat="server" Text="Fecha:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_fecha" runat="server"></asp:TextBox>
&nbsp;(formato: dia/mes/año)</p>
    <p>
        <asp:GridView ID="gv_profesionales" runat="server" AutoGenerateSelectButton="True" 
            CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
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
        <asp:Button ID="btn_guardar" runat="server" onclick="btn_guardar_Click" 
            Text="Guardar" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_volver" runat="server" Text="Volver" Width="77px" 
            onclick="btn_volver_Click" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
