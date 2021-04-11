<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="Metric_Conversion.Pages.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>History of length conversion</h2>
    <p>
        <asp:GridView ID="grid1" runat="server" ShowHeader="False" GridLines="None" Width="400px">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <h2>History of liquid conversion</h2>
    <h3>Gallon and Liter</h3>
    <p>
        <asp:GridView ID="grid2" runat="server" GridLines="None" ShowHeader="False" Width="400px">
        </asp:GridView>
    </p>
    <h3>Gallon and Pint</h3>
    <p>
        <asp:GridView ID="grid3" runat="server" GridLines="None" ShowHeader="False" Width="400px">
        </asp:GridView>
    </p>
    <h3>Gallon and Quart</h3>
    <p>
        <asp:GridView ID="grid4" runat="server" GridLines="None" ShowHeader="False" Width="400px">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <h2>History of temperature conversion</h2>
    <p>
        <asp:GridView ID="grid5" runat="server" GridLines="None" ShowHeader="False" Width="400px">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <h2>History of mass conversion</h2>
    <p>
        <asp:GridView ID="grid6" runat="server" GridLines="None" ShowHeader="False" Width="400px">
        </asp:GridView>
    </p>
<p>
        &nbsp;</p>
</asp:Content>
