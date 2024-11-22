<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestExcelExportByOdbc.aspx.cs" Inherits="TestExcel4O2007.TestExcelExportByOdbc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnExcelExportByOdbc" runat="server" 
            onclick="btnExcelExportByOdbc_Click" Text="导出Excel－ByOdbc" />
        <br />
          <asp:Button ID="btnExcelExportByOdbc2007" runat="server" 
            onclick="btnExcelExportByOdbc2007_Click" Text="导出Excel2007－ByOdbc" />
      
        <br />
          <asp:Button ID="btnTestOpenExcel2007ByOdbc" runat="server" 
            onclick="btnTestOpenExcel2007ByOdbc_Click" Text="测试打开Excel2007－ByOdbc" />
      
        <br />
          <asp:Button ID="btnTestOpenExcel2003ByOdbc0" runat="server" 
            onclick="btnTestOpenExcel2003ByOdbc0_Click" Text="测试打开Excel2003－ByOdbc" />
      
        <br />
        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
