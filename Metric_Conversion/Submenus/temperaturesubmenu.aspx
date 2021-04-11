<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="temperaturesubmenu.aspx.cs" Inherits="Metric_Conversion.Submenus.temperaturesubmenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Pick a unit to convert:<br />
<asp:DropDownList ID="ddlfc" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlkmandmile_SelectedIndexChanged">
    <asp:ListItem>--Choose a value--</asp:ListItem>
    <asp:ListItem>Fahrenheit</asp:ListItem>
    <asp:ListItem>Celsius</asp:ListItem>
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlfc" Display="Dynamic" ErrorMessage="Please pick a value" ForeColor="Red" InitialValue="--Choose a value--"></asp:RequiredFieldValidator>
<br />
<br />
Enter a value:<br />
<asp:TextBox ID="txtfc" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtfc" Display="Dynamic" ErrorMessage="Please enter number only" ForeColor="Red" ValidationExpression="\d+(.\d+)?"></asp:RegularExpressionValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtfc" Display="Dynamic" ErrorMessage="Please enter a number" ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
Result:<br />
<asp:TextBox ID="txtfcresult" runat="server"></asp:TextBox>
<asp:Label ID="lblfc" runat="server"></asp:Label>
<br />
<br />
<asp:Button ID="btnfc" runat="server" OnClick="btnkmandmile_Click" Text="Convert" />
<br />
<br />
<asp:Label ID="commentfc" runat="server"></asp:Label>
<br />
<br />
</asp:Content>
