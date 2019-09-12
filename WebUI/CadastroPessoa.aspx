<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroPessoa.aspx.cs" Inherits="WebUI.CadastroPessoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Página Cadastro Pessoa</h2>
    <table>
        <tr>
            <td>
        <asp:Label ID="Label1" runat="server" Text="Código:"></asp:Label>
            </td>
            <td><asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
    
            
    
            &nbsp;
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
    
            
    
            </td>
        </tr>
         <tr>
            <td>
    
        <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
             </td>
            <td><asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    
             &nbsp;</td>
        </tr>
         <tr>
            <td>
    
         <asp:Label ID="Label3" runat="server" Text="Data Nascimento:"></asp:Label>
             </td>
            <td><asp:TextBox ID="txtDataNasc" runat="server"></asp:TextBox>

             </td>
        </tr>
         <tr>
            <td>

        <asp:Label ID="Label4" runat="server" Text="E-mail:"></asp:Label>
             </td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

             &nbsp;<asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Digite um e-mail válido." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>

             </td>
        </tr>
         <tr>
            <td>

        <asp:Label ID="Label5" runat="server" Text="Sexo:"></asp:Label>
             </td>
             <td>

                 <asp:RadioButton ID="rbtnMasc" runat="server" Text="Masculino" />
                 <asp:RadioButton ID="rbtnFem" runat="server" Text="Feminino" />

             </td>
         </tr>
         <tr>
            <td>

        <asp:Label ID="Label6" runat="server" Text="Estado Civíl:"></asp:Label>
             </td>
            <td>
                <asp:DropDownList ID="ddlEstadoCivil" runat="server">
                    <asp:ListItem>Solteiro (a)</asp:ListItem>
                    <asp:ListItem>Casado (a)</asp:ListItem>
                    <asp:ListItem>Divorciado (a)</asp:ListItem>
                    <asp:ListItem>Viuvo (a)</asp:ListItem>
                    <asp:ListItem>Outros</asp:ListItem>
                </asp:DropDownList>
    
             </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Tipo de Contato:"></asp:Label>
             </td>
            <td>
                <asp:CheckBox ID="cboxRecebeEmail" runat="server" Text="Recebe E-mail" />
                <br />
                <asp:CheckBox ID="cboxRecebeSMS" runat="server" Text="Recebe SMS" />
             </td>
        </tr>
    </table>
    &nbsp;<asp:Label ID="lblMensagem" runat="server" Enabled="False"></asp:Label>
    <br />
    <asp:Button ID="btnAdicionar" runat="server" Text="Adicionar" OnClick="btnAdicionar_Click" />
&nbsp;<asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" Enabled="False" OnClick="btnAtualizar_Click" />
&nbsp;<asp:Button ID="btnExcluir" runat="server" Text="Excluir" Enabled="False" OnClick="btnExcluir_Click" />
&nbsp;<asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
    <br />
    <br />
    <asp:GridView ID="grvPessoas" runat="server">
    </asp:GridView>
    
</asp:Content>
