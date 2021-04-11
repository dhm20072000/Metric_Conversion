<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="liquidsubmenu.aspx.cs" Inherits="Metric_Conversion.Submenus.liquidsubmenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Pick a unit to convert:<br />
<asp:DropDownList ID="ddllg" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlkmandmile_SelectedIndexChanged">
    <asp:ListItem>--Choose a value--</asp:ListItem>
    <asp:ListItem>liter</asp:ListItem>
    <asp:ListItem>gallon</asp:ListItem>
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddllg" Display="Dynamic" ErrorMessage="Please pick a value" ForeColor="Red" InitialValue="--Choose a value--"></asp:RequiredFieldValidator>
<br />
<br />
Enter a value:<br />
<asp:TextBox ID="txtlg" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtlg" Display="Dynamic" ErrorMessage="Please enter number only" ForeColor="Red" ValidationExpression="\d+(.\d+)?"></asp:RegularExpressionValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlg" Display="Dynamic" ErrorMessage="Please enter a number" ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
Result:<br />
<asp:TextBox ID="txtlgresult" runat="server"></asp:TextBox>
<asp:Label ID="lbllg" runat="server"></asp:Label>
<br />
<br />
<asp:Button ID="btnlg" runat="server" OnClick="btnkmandmile_Click" Text="Convert" />
<br />
<br />
<asp:Label ID="commentlg" runat="server"></asp:Label>
<br />
<br />
</asp:Content>
