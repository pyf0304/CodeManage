<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucPrjCases.ascx.cs"
    Inherits="AGC.Webform.wucPrjCases" %>
<table id="tabwucPrjCases" style="width: 352px; height: 399px" cellspacing="1" cellpadding="1"
    width="352" border="0">
    <tr>
        <td>
            <asp:Label ID="lblCaseId" runat="server">�������</asp:Label></td>
        <td>
            <asp:TextBox ID="txtCaseId" runat="server" Width="250px"></asp:TextBox></td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCaseName" runat="server">��������</asp:Label></td>
        <td>
            <asp:TextBox ID="txtCaseName" runat="server" Width="250px"></asp:TextBox></td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCaseTypeId" runat="server">��������</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlCaseTypeId" runat="server" Width="250px">
            </asp:DropDownList></td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCaseContent" runat="server">������ϸ����</asp:Label></td>
        <td>
            <asp:TextBox ID="txtCaseContent" runat="server" Width="250px" Height="150px" TextMode="MultiLine"></asp:TextBox></td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server">˵��</asp:Label></td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" Width="250px" Height="150px" TextMode="MultiLine"></asp:TextBox></td>
        <td>
        </td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPrjId" runat="server">���̺�</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server" Width="250px">
            </asp:DropDownList></td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblUserId" runat="server"
                Visible="False">�û���</asp:Label></td>
        <td>
            <asp:TextBox ID="txtUserId" runat="server" Width="72px" Visible="False"></asp:TextBox></td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblUpdDate" runat="server"
                Visible="False">�޸�����</asp:Label></td>
        <td>
            <asp:TextBox ID="txtUpdDate" runat="server" Width="72px" Visible="False"></asp:TextBox></td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
