<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Demowebform.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" action="delete.aspx" method="post" runat="server">
        <div>
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:GridView ID="GridView1" EnableViewState="false" runat="server"></asp:GridView>
            <asp:HyperLink ID="HyperLink1" Target="_blank" NavigateUrl="abc" runat="server">Add new student</asp:HyperLink>
        </div>
    </form>
</body>
</html>
