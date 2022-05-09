<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimulacionParcial._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1 style="font-size: xx-large">
        Biblioteca de musica</h1>
    <div>

        <h2>Datos de cancion</h2>
        <br />
        Nombre
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Artista
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Duracion
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Ingresar cancion" OnClick="Button1_Click" />
        <br />

    </div>
    <div>

        <h2>Datos del album</h2>
        <br />
        Titulo
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        Artista
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>

        <br />
        Fecha de publicacion<br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ingresar album" />

    </div>

</asp:Content>
