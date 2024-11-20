<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGIN.aspx.cs" Inherits="PrimerSitio.LOGIN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .texto
        {
            background-color:blanchedalmond;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" class="texto">
            <tr>
                <td> Autenfiticación</td>
                <td></td>
            </tr>
            <tr>
                <td>Usuario:</td>
                <td> 
                    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator
                    ID="Req_Usuario" 
                    runat="server" CssClass="val"
                   ErrorMessage="*" ControlToValidate="txtUser">
                   </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>    
                    Clave:
                </td>
                <td>
                    <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator
                    ID="Req_Clave"
                    runat="server"  CssClass="val"
                    ErrorMessage="*" ControlToValidate="txtClave">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>    
                    <asp:Label ID="lblMensaje" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>    
                    <asp:ImageButton ID="btnProbar" runat="server" ImageUrl="~/conectar.jpg" Width="100" Height="100" OnClick="btnProbar_Click" CausesValidation="true" />
                </td>
            </tr>

        </table>
    </form>
</body>
</html>
