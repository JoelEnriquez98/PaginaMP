<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="MPServicePage.Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row margin-row">
        <div class="col-12">
            <h5 class="display-8">Seleccione estado:</h5>
        </div>
        <div class="col-12">
            <asp:DropDownList ID="DropDownEstado" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="row margin-row mt-5">
        <div class="col-12">
            <h5 class="display-8">Datos personales:</h5>
        </div>
        <div class="col-md-4 col-sm-12">
            <asp:Label ID="Label2" CssClass="form-control-plaintext" AssociatedControlID="TextBoxDPI" runat="server" Text="DPI"></asp:Label>
            <asp:TextBox ID="TextBoxDPI" Required="true" TextMode="Number" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-4 col-sm-12">
            <asp:Label ID="LabelBirth" CssClass="form-control-plaintext" AssociatedControlID="TextBoxBirth" runat="server" Text="Fecha de Nacimiento"></asp:Label>
            <asp:TextBox ID="TextBoxBirth" Required="true" TextMode="Date" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-4 col-sm-12">
            <asp:Label ID="LabelYearBirth" CssClass="form-control-plaintext" AssociatedControlID="TextBoxYearBirth" runat="server" Text="Año de Nacimiento"></asp:Label>
            <asp:TextBox ID="TextBoxYearBirth" Required="true" TextMode="Number" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-4 col-sm-12">
            <asp:Label ID="LabelEmail" CssClass="form-control-plaintext" AssociatedControlID="TextBoxEmail" runat="server" Text="Correo Electronico"></asp:Label>
            <asp:TextBox ID="TextBoxEmail" Required="true" TextMode="Email" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row margin-row">
        <div class="col-md-4 col-sm-12">
            <asp:Label ID="LabelFirstName" CssClass="form-control-plaintext" AssociatedControlID="TextBoxFirstName" runat="server" Text="Primer Nombre"></asp:Label>
            <asp:TextBox ID="TextBoxFirstName" Required="true" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-4 col-sm-12">
            <asp:Label ID="LabelSecondName" CssClass="form-control-plaintext" AssociatedControlID="TextBoxSecondName" runat="server" Text="Segundo Nombre"></asp:Label>
            <asp:TextBox ID="TextBoxSecondName" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-4 col-sm-12">
            <asp:Label ID="LabelThirdName" CssClass="form-control-plaintext" AssociatedControlID="TextBoxThirdName" runat="server" Text="Tercer Nombre"></asp:Label>
            <asp:TextBox ID="TextBoxThirdName" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row margin-row">
        <div class="col-md-4 col-sm-12">
            <asp:Label ID="LabelFirstLastName" CssClass="form-control-plaintext" AssociatedControlID="TextBoxFirstLastName" runat="server" Text="Primer Apellido"></asp:Label>
            <asp:TextBox ID="TextBoxFirstLastName" Required="true" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-4 col-sm-12">
            <asp:Label ID="LabelSecondLastName" CssClass="form-control-plaintext" AssociatedControlID="TextBoxSecondLastName" runat="server" Text="Segundo Apellido"></asp:Label>
            <asp:TextBox ID="TextBoxSecondLastName" Required="true" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-4 col-sm-12">
            <asp:Label ID="LabelMarryLastName" CssClass="form-control-plaintext" AssociatedControlID="TextBoxMarryLastName" runat="server" Text="Apellido de Casada"></asp:Label>
            <asp:TextBox ID="TextBoxMarryLastName" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row margin-row">
        <div class="col-12">
            <asp:Label ID="LabelPhone" CssClass="form-control-plaintext" AssociatedControlID="TextBoxPhone" runat="server" Text="Telefono Celular"></asp:Label>
            <asp:TextBox ID="TextBoxPhone" Required="true" TextMode="Number" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row margin-row mt-5">
        <div class="col-12">
            <h5 class="display-8">Carga de documentos DPI/Pasaporte:</h5>
        </div>
        <div class="col-12">
            <div class="row">
                <div class="col">
                    <asp:FileUpload CssClass="btn btn-outline" ID="FileUploadSelect" runat="server" />
                </div>
                <div class="col">
                    <asp:Button ID="ButtonUpload" Enabled="false" CssClass="btn btn-primary" runat="server" Text="Subir" />
                </div>
            </div>
        </div>
    </div>
    <div class="row text-center">
        <div class="col">
            <asp:Button CssClass="btn btn-success mt-3 mb-3" ID="ButtonSubmit" runat="server" Text="Solicitar Certificado" OnClick="ButtonSubmit_Click" />
        </div>
    </div>
</asp:Content>
