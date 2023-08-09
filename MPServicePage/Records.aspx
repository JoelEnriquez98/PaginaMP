<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Records.aspx.cs" Inherits="MPServicePage.Records" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12 mt-3">
        <asp:GridView ID="GVRecords" CssClass="table table-bordered table-condensed table-responsive table-hover" AutoGenerateColumns="true" runat="server">
            <AlternatingRowStyle BackColor="Black" />
            <HeaderStyle BackColor="DarkGray" Font-Bold="true" Font-Size="Medium" ForeColor="White" />
            <RowStyle BackColor="#f5f5f5" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="true" ForeColor="White" />
        </asp:GridView>
    </div>
</asp:Content>
