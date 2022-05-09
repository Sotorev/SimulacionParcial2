<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="SimulacionParcial.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>sEditar Albumes</h2>
<br />
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<br />
Titulo
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
Artista
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
Fecha
<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
<br />
<asp:Button ID="Button1" runat="server" Text="Guardar" />
</asp:Content>
