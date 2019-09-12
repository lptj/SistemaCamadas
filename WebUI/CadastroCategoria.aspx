<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCategoria.aspx.cs" Inherits="WebUI.CadastroCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Código:
    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
</p>
<p>
    Categoria:
    <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
</p>
<p>
    <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
</p>
    <p>
        <asp:GridView ID="grvCategorias" runat="server">
        </asp:GridView>
</p>
</asp:Content>
