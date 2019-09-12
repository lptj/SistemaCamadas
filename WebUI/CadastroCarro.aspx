<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCarro.aspx.cs" Inherits="WebUI.CadastroCarro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Página Cadastro Carro</h2>
    <table>
        <tr>
            <td class="auto-style1">Código:</td>
            <td>
        <asp:TextBox ID="txtCodigo" runat="server" Width="56px"></asp:TextBox>
&nbsp;<asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" ValidationGroup="grupoBuscaCarro" />
    &nbsp; 
                <asp:CompareValidator ID="cvCodigo" runat="server" ControlToValidate="txtCodigo" ErrorMessage="Digite código válido." ForeColor="Red" Operator="DataTypeCheck" Type="Integer" ValidationGroup="grupoBuscaCarro">*</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Marca:</td>
            <td> <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="rfvMarca" runat="server" ControlToValidate="txtMarca" ErrorMessage="Digite uma marca." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Modelo:</td>
            <td> <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="rfvModelo" runat="server" ControlToValidate="txtModelo" ErrorMessage="Digite um modelo." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Cor:</td>
            <td>
        <asp:TextBox ID="txtCor" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="rfvCor" runat="server" ControlToValidate="txtCor" ErrorMessage="Digite uma cor." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Ano:</td>
            <td>
        <asp:TextBox ID="txtAno" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="rfvAno" runat="server" ControlToValidate="txtAno" ErrorMessage="Digite um ano." ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvAno" runat="server" ControlToValidate="txtAno" ErrorMessage="Digite um número inteiro." ForeColor="Red" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
            </td>
        </tr>
    </table>
    <p>&nbsp;<asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
    &nbsp;<asp:Button ID="btnAtualizar" runat="server" OnClick="btnAtualizar_Click" Text="Atualizar" />
    &nbsp;<asp:Button ID="btnExcluir" runat="server" Enabled="False" OnClick="btnExcluir_Click" Text="Excluir" />
    &nbsp;<asp:Button ID="btnCancelar" runat="server" Enabled="False" OnClick="btnCancelar_Click" Text="Cancelar" />
    </p>
    <p>
    </p>
    <p>&nbsp;<asp:Label ID="lblMensagem" runat="server"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="grvCarros" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="CdCarro" HeaderText="Código" />
                <asp:BoundField DataField="DsMarca" HeaderText="Marca" />
                <asp:BoundField DataField="DsModelo" HeaderText="Modelo" />
                <asp:BoundField DataField="Ano" HeaderText="Ano" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </p>
</asp:Content>
