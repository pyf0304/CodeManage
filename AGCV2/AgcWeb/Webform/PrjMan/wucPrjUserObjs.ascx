<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucPrjUserObjs.ascx.cs"
    Inherits="AGC.Webform.wucPrjUserObjs" %>
<table id="tabwucPrjUserObjs" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblPrjUserObjId" runat="server">�����û�����ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrjUserObjId" runat="server"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPrjId" runat="server">���̺�</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server" Width="152px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPrjUserObjName" runat="server">�����û�������</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrjUserObjName" runat="server"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
