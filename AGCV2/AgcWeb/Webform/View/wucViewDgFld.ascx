<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewDgFld.ascx.cs"
    Inherits="AGC.Webform.wucViewDgFld" %>
<table id="tabwucViewFldInfo" cellspacing="1" cellpadding="1" width="344" border="0"
    style="width: 344px; height: 279px">
    <tr>
        <td>
            <asp:Label ID="lblFldID" runat="server">�ֶ�ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlFldID" runat="server" Width="160px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTabId" runat="server">��</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlTabId" runat="server" Width="160px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeId" runat="server">�ؼ����ͺ�</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCtlTypeId" runat="server" Width="160px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDDLItemsOption" runat="server">�������б�����Դѡ��</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDDLItemsOption" runat="server" Width="160px" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblItemsString" runat="server">�б��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtItemsString" runat="server"></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsTabName" runat="server">����Դ����</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDsTabName" runat="server" Width="160px" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsDataValueField" runat="server">����ԴValue�ֶ���</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDsDataValueField" runat="server" Width="160px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsDataTextField" runat="server">����ԴText�ֶ���</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDsDataTextField" runat="server" Width="160px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsCondStr" runat="server">����Դ������</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDsCondStr" runat="server"></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsSqlStr" runat="server">����ԴSQL��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDsSqlStr" runat="server"></asp:TextBox>
        </td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsCtlField" runat="server" Text="�Ƿ���Ϊ�ؼ��ֶ�"></asp:CheckBox>
        </td>
        <td>
            <asp:CheckBox ID="chkIsDataGrid" runat="server" Text="�Ƿ���ΪDataGrid�ֶ�"></asp:CheckBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsNeedSort" runat="server" Text="�Ƿ���Ҫ����"></asp:CheckBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsQuery" runat="server" Text="�Ƿ���Ϊ��ѯ�ֶ�"></asp:CheckBox>
        </td>
        <td>
            <asp:Label ID="lblQueryOption" runat="server">��ѯ��ʽ</asp:Label>
            <asp:DropDownList ID="ddlQueryOption" runat="server" Width="112px">
            </asp:DropDownList></td>
        <td>
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
            <asp:Label ID="lblUpdTime" runat="server">��������</asp:Label></td>
        <td>
            <asp:TextBox ID="txtUpdTime" runat="server"></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblUserId" runat="server">�û���</asp:Label></td>
        <td>
            <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblViewId" runat="server">����ID</asp:Label></td>
        <td>
            
                <asp:DropDownList ID="ddlViewId" runat="server">
                </asp:DropDownList></font></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
<p>
</p>
<p>
    &nbsp;</p>
