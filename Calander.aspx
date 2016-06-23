<asp:radiobuttonlist runat="server"></asp:radiobuttonlist>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calander.aspx.cs" Inherits="ToolBox.Calander" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 183px">
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Page_Load"></asp:Calendar>
        <br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        
    </div>
    </form>
</body>
</html>
