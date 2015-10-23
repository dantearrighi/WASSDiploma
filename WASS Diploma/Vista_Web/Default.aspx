<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Vista_Web._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Bienvenido a la gestión de cursos del cie</h2>
    <p>
        Esta aplicación le permitirá gestionar los cursos del colegio de ingenieros 
        especialistas.
    </p>
    <p>
        Para comenzar haga click en tableros y seleccione la opción &quot;Comisiones&quot;. A 
        partir de ese momento puede consultar y editar los datos del curso.
    </p>
    <p>
        NOTA: Para poder ingresar DEBE ESTAR LOGUEADO.
    </p>
</asp:Content>
