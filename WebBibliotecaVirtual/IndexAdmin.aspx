<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="IndexAdmin.aspx.cs" Inherits="WebClaroClima.IndexAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container-fluid">
		<div class="row">
			<div class="col-md-12">
				<h5 class="text-info">Usuarios&nbsp
					<i class="fa fa-plus" aria-hidden="true" title="Crear nuevo usuario"></i>
				</h5>
			</div>
		</div>
		<div class="row">
			<div class="col-md-3">
				<input type="text" id="filtroUsuario" placeholder="Buscar" class="form-control"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-2">

				<asp:GridView ID="gvUsuarios"  ClientIDMode="Static" runat="server" CssClass="table table-bordered table-condensed table-striped" AutoGenerateColumns="false">
					<Columns>
						<asp:TemplateField>
							<ItemTemplate>
								<asp:LinkButton runat="server" ID="btnEditarUs"><i class="fa fa-eye" aria-hidden="true"></i></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateField>
						<asp:BoundField DataField="id_us" HeaderText="Id"/>
						<asp:BoundField DataField="nombre_us" HeaderText="Nombre"/>
						<asp:BoundField DataField="apellido_us" HeaderText="Apellido"/>
						<asp:BoundField DataField="rut_us" HeaderText="Rut"/>
						<asp:BoundField DataField="fec_nac_us" HeaderText="Fecha de Nacimiento"/>
						<asp:BoundField DataField="correo_us" HeaderText="Correo"/>
						<asp:BoundField Datafield="fk_id_cargo" HeaderText="Cargo"/>
						<asp:BoundField Datafield="fk_id_cargo" HeaderText="Fabrica"/>
						<asp:BoundField Datafield="fk_id_cargo" HeaderText="Tipo de Usuario"/>
					</Columns>
				</asp:GridView>
			</div>
		</div>
	</div>

</asp:Content>
