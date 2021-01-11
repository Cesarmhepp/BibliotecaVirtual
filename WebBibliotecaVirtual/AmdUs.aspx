<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="AmdUs.aspx.cs" Inherits="WebClaroClima.AmdUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
        <h1 class="form-control">MANTENEDOR USUARIO</h1>
        <div class="table-responsive">
            <form runat="server">
                <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center">
               <Columns>
                   <asp:BoundField DataField="id_user" HeaderText="ID USUARIO" />
                   <asp:BoundField DataField="nombre" HeaderText="NOMBRE" />
                   <asp:BoundField DataField="surName" HeaderText="APELLIDO" />
                   <asp:BoundField DataField="email" HeaderText="CORREO" />
                   <asp:BoundField DataField="fk_t_user" HeaderText="TIPO USUARIO" />
               </Columns>
           </asp:GridView>
            </form>     
            </div>
        </div>
    </div>
       
</asp:Content>
