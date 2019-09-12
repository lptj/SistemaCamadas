<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroProduto.aspx.cs" Inherits="WebUI.CadastroProduto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            text-align: right;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <h2>Página de Cadastro de Produto</h2>
    <table>
        <tr>
            <td class="auto-style1">Código:</td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Descrição:</td>
            <td>
                <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Vl. Unitário:</td>
            <td>
                <asp:TextBox ID="txtVlUnitario" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Categoria:</td>
            <td class="auto-style3">
                <asp:DropDownList ID="ddlCategorias" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvCategoria" runat="server" ControlToValidate="ddlCategorias" ErrorMessage="A Categoria é obrigatória" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        </table>
        <br />
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
</asp:Content>
