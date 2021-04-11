<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Length.aspx.cs" Inherits="Metric_Conversion.Pages.Length" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    This is length conversion page.</p>
    <p>
        Click on the submenus of Length tab to get the conversion you want.</p>
    <p>
        We have the following conversion as shown in the table:</p>
    <p>
        <asp:Image ID="Image2" runat="server" Height="151px" ImageUrl="~/Images/lengthtable.PNG" Width="634px" />
    </p>
</asp:Content>
