<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkLichHocTheoTuan.aspx.cs" Inherits="Demowebform.checkLichHocTheoTuan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="lich" runat="server"></asp:Calendar>
            <asp:DropDownList ID="listStudent" runat="server"></asp:DropDownList>
            <asp:GridView ID="View" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
