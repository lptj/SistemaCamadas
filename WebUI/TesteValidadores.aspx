<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteValidadores.aspx.cs" Inherits="WebUI.TesteValidadores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Nome:
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome" ErrorMessage="O nome é obrigatório." ForeColor="Red">*</asp:RequiredFieldValidator>
</p>
<p>
    E-mail:
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="O E-mail é obrigatório." ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Digite um e-mail válido." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Digite um valor menor que 12:"></asp:Label>
&nbsp;<asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="cvNumero" runat="server" ControlToValidate="txtNumero" ErrorMessage="O número deve ser menor que 12." ForeColor="Red" Operator="LessThan" Type="Integer" ValueToCompare="12">*</asp:CompareValidator>
</p>
    <p>
        Digite uma faixa de data - Início:
        <asp:TextBox ID="txtDtInicial" runat="server"></asp:TextBox>
&nbsp;Fim:&nbsp;
        <asp:TextBox ID="txtDtFinal" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="cvDatas" runat="server" ControlToCompare="txtDtInicial" ControlToValidate="txtDtFinal" ErrorMessage="A data final deve ser maior que a data inicial." ForeColor="Red" Operator="GreaterThanEqual" Type="Date">*</asp:CompareValidator>
</p>
    <p>
        Digite um valor inteiro:
        <asp:TextBox ID="txtInteiro" runat="server"></asp:TextBox>
&nbsp;<asp:CompareValidator ID="cvInteiro" runat="server" ControlToValidate="txtInteiro" ErrorMessage="O valor precisa ser inteiro." ForeColor="Red" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
</p>
    <p>
        Digite um valor entre 1 - 100
        <asp:TextBox ID="txtFaixa" runat="server"></asp:TextBox>
&nbsp;<asp:RangeValidator ID="rvFaixa" runat="server" ControlToValidate="txtFaixa" ErrorMessage="O valor precisar ser entre 1 e 100." MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
</p>
    <p>
        Validação apenas no grupo: Código:
        <asp:TextBox ID="txtCodigo" runat="server" ValidationGroup="grupoBusca"></asp:TextBox>
&nbsp;<asp:Button ID="btnBuscar" runat="server" Text="Buscar" ValidationGroup="grupoBusca" />
&nbsp;<asp:CompareValidator ID="cvCodigo" runat="server" ControlToValidate="txtCodigo" ErrorMessage="O código precisar ser numérico." ForeColor="Red" Operator="DataTypeCheck" Type="Integer" ValidationGroup="grupoBusca">*</asp:CompareValidator>
</p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="grupoBusca" />
<p>
    <asp:Button ID="btnConfirmar" runat="server" OnClick="btnConfirmar_Click" Text="Confirmar" OnClientClick="return confirm('Tem certeza que quer confirmar?');" />
&nbsp;<asp:Button ID="btnLimpar" runat="server" CausesValidation="False" OnClick="btnLimpar_Click" Text="Limpar" />
</p>
<p>
    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
</p>
</asp:Content>
