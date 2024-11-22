<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Testfunction.aspx.cs" Inherits="TestApi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Button ID="btn1" Text ="测试核算" runat="server" OnClick="btn1_Click" />

             <asp:Button ID="btn2" Text ="测试评论" runat="server" OnClick="btn2_Click" />


             <asp:Button ID="btn3" Text ="测试链接" runat="server" OnClick="btn3_Click"/>

             <asp:Button ID="btn4" Text ="测试各个数据统计" runat="server" OnClick="btn4_Click" />
        </div>

        <div>
         
            <asp:Button ID="btn5" Text ="测试返回周" runat="server" OnClick="btn5_Click"/>
            <br/>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
            <asp:Button ID="Button1" Text ="根据一个日期添加天数返回新日期" runat="server" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
