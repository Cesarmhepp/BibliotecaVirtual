<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebClaroClima.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="/Scripts/css/bootstrap.css"/>
    <link rel="stylesheet" type="text/css" href="/Scripts/fontawesome/css/all.min.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-4" style="margin-top: 20px;">
                    <img src="Scripts/img/logo.png" style="margin: 0% 10%; float: left; width: 80%; height: auto;" />
                </div>
                <div class="col-md-8" style="margin-top: 20px;">
                    <h2 style="width: 100%">MÓDULO DE GESTIÓN BIBLIOTECA VIRTUAL</h2>
                    <h5 style="width: 100%">INICIAR SESIÓN</h5>
                    <asp:PlaceHolder runat="server" ID="DescContrasena">
                        <p class="text-danger">
                            La contraseña debe ser de 8 caracteres como mínimo y debe incluir <u>números</u>, <u>mayúsculas</u> y <u>minúsculas</u>
                        </p>
                    </asp:PlaceHolder>
                    <asp:Panel runat="server" ID="PanelRecupera" class="form-group col-md-4" style="margin-top: 20px;">
                        <asp:HyperLink runat="server" ID="RecuperaContrasena" Text="He olvidado la contraseña" Target="_self" NavigateUrl="~/RecuperarContrasena.aspx"></asp:HyperLink>
                    </asp:Panel>
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <asp:Panel ID="PanelFormulario" runat="server">
                        <div class="form-group col-md-4" style="margin-top: 20px;">
                            <asp:Label runat="server"  CssClass="control-label">Nombre de usuario</asp:Label>
                            <asp:TextBox runat="server"  ID="txtNombreUs" CssClass="form-control" />
                        </div>
                        <div class="form-group col-md-4" style="margin-top: 20px;">
                            <asp:Label runat="server"  CssClass="control-label">Contraseña</asp:Label>
                            <asp:TextBox runat="server"  ID="txtPasswordUs" TextMode="Password" CssClass="form-control" />
                        </div>
                        <div class="form-group col-md-4" style="margin-top: 20px;">
                            <asp:CheckBox ID="RecordarmeAqui" runat="server" CssClass="custom-checkbox" Checked="false" Text="Recordarme" />
                        </div>

                        <div class="form-group col-md-4" style="margin-top: 20px;">
                            <asp:Button runat="server"  Text="Iniciar sesión" CssClass="btn btn-primary" Style="float: right;" OnClick="BtnLogin_Click" />
                        </div>
                    </asp:Panel>
                </div>
            </div>
        </div>
    </form>

</body>
    <script src="Scripts/js/jquery-3.2.1.slim.min.js"></script>
    <script src="Scripts/js/popper.min.js"></script>
    <script src="Scripts/js/bootstrap.min.js"></script>
</html>
