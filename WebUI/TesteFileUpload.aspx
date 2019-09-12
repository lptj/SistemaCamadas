<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteFileUpload.aspx.cs" Inherits="WebUI.TesteFileUpload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Teste de FileUpload</h2>
    <p>Código:
        <asp:TextBox ID="txtCódigo" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>Imagem:
        <asp:FileUpload ID="fupImagem" runat="server" />
    </p>
    <p>
        <asp:Image ID="imgFoto" runat="server" Height="100px" />
    </p>
    <p>Titulo:
        <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
    </p>
    <p>
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="grvFotos" runat="server" AutoGenerateColumns="False" OnRowCommand="grvFotos_RowCommand">
            <Columns>
                <asp:BoundField DataField="CdFoto" HeaderText="Código" />
                <asp:BoundField DataField="DsTitulo" HeaderText="Titulo" />
                <asp:BoundField DataField="NmArquivo" HeaderText="Nome Arquivo" />
                <asp:TemplateField HeaderText="Foto">
                    <ItemTemplate>
                        <img height="50" src="Imagens/<%# Eval("NmArquivo") %>" /> <%--Permite que crie um código C# dentro do aspx--%>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Editar">
                    <ItemTemplate>
                        <asp:ImageButton ID="ibtnEditar" ImageUrl="~/Imagens/Editar.png" Width="20" runat="server" CommandName="Editar" CommandArgument='<%# Eval("CdFoto") %>' />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>
