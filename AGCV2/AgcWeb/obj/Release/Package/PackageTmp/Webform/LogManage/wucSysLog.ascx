<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucSysLog.ascx.cs" Inherits="AGC.wucSysLog"
    %>
<table id="tabwucSysLog" cellspacing="1" cellpadding="1" width="304" border="0" style="width: 304px;
    height: 242px">
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblUserId" runat="server" >�û����</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtUserId" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblUserName" runat="server" >�û�����</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtUserName" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblUserIp" runat="server" >�û�IP</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtUserIp" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblOpDate" runat="server" >��������</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtOpDate" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblOpTime" runat="server" >����ʱ��</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtOpTime" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblOpType" runat="server" >��������</asp:Label></p>
        </td>
        <td>
            <asp:DropDownList ID="ddlOpTypeId" runat="server" 
                Width="158px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblTableName" runat="server" >���ݱ���</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtTableName" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblTableKey" runat="server" >���ݱ�ؼ��ֶ���</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtTableKey" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblOpContent" runat="server" >��������</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtOpContent" runat="server" ></asp:TextBox>
        </td>
    </tr>
</table>
