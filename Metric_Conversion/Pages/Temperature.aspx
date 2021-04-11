<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Temperature.aspx.cs" Inherits="Metric_Conversion.Pages.Temperature" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        This is temperature conversion page.</p>
    <p>
        Click on the submenus of Temperature tab to get the conversion you want.</p>
    <p>
        We have the following conversion as shown in the table:</p>
    <p>
        <asp:Image ID="Image2" runat="server" Height="60px" ImageUrl="~/Images/temperaturetable.PNG" Width="634px" />
    </p>
</asp:Content>
