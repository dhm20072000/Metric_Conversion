<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="kmandmiles.aspx.cs" Inherits="Metric_Conversion.Submenus.kmandmiles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Pick a unit to convert:<br />
<asp:DropDownList ID="ddlkmandmile" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlkmandmile_SelectedIndexChanged">
    <asp:ListItem>--Choose a value--</asp:ListItem>
    <asp:ListItem>km</asp:ListItem>
    <asp:ListItem>mile</asp:ListItem>
    <asp:ListItem>yard</asp:ListItem>
    <asp:ListItem>ft</asp:ListItem>
    <asp:ListItem>inch</asp:ListItem>
    <asp:ListItem>cm</asp:ListItem>
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlkmandmile" Display="Dynamic" ErrorMessage="Please pick a value" ForeColor="Red" InitialValue="--Choose a value--"></asp:RequiredFieldValidator>
<br />
<br />
Enter a value:<br />
<asp:TextBox ID="txtkmandmileinput" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtkmandmileinput" Display="Dynamic" ErrorMessage="Please enter number only" ForeColor="Red" ValidationExpression="\d+(.\d+)?"></asp:RegularExpressionValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtkmandmileinput" Display="Dynamic" ErrorMessage="Please enter a number" ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
Result:<br />
<asp:TextBox ID="txtkmandmileresult" runat="server"></asp:TextBox>
<asp:Label ID="lblkmandmile" runat="server"></asp:Label>
<br />
<br />
<asp:Button ID="btnkmandmile" runat="server" OnClick="btnkmandmile_Click" Text="Convert" />
<br />
<br />
<asp:Label ID="commentkmandmile" runat="server"></asp:Label>
<br />
<br />
</asp:Content>
