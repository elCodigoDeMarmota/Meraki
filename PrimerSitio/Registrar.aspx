<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="PrimerSitio.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMensaje" runat="server" ></asp:Label>
    <br />
    <asp:Label ID="lblNombre" runat="server" Text="Nombre:"
    Style="display:inline-block; width:150px; text-align:right; margin-right:10px;"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator 
    ID="Req_Nombre" 
    runat="server" 
    ErrorMessage="*" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"
        Style="display:inline-block; width:150px; text-align:right; margin-right:10px;"></asp:Label>
    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator 
    ID="Req_Usuario"
    runat="server" 
    ErrorMessage="*" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
    <br />  
    <asp:Label ID="lblContraseña" runat="server" Text="Contraseña:"
        Style="display:inline-block; width:150px; text-align:right; margin-right:10px;"></asp:Label>
    <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator 
     ID="Req_Contraseña" 
     runat="server" 
     ErrorMessage="*" ControlToValidate="txtContraseña"></asp:RequiredFieldValidator>
    <br />  
    <asp:Label ID="lblEmail" runat="server" Text="Email:"
        Style="display:inline-block; width:150px; text-align:right; margin-right:10px;"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator 
    ID="Req_Email" 
    runat="server" 
    ErrorMessage="*" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblRol" runat="server" Text="Rol:"
        Style="display:inline-block; width:150px; text-align:right; margin-right:10px;"></asp:Label>
        <asp:DropDownList ID="ddlRol" runat="server" Height="16px" Width="131px"></asp:DropDownList>
    <asp:RequiredFieldValidator 
        ID="Req_Rol" 
        runat="server" 
        ErrorMessage="*" ControlToValidate="ddlRol" ForeColor="Red" InitialValue="-1"></asp:RequiredFieldValidator>
    <br />
    
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    
    <br /><br />
</asp:Content>
