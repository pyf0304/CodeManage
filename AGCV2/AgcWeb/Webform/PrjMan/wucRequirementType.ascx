<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucRequirementType.ascx.cs"
    Inherits="AGC.Webform.wucRequirementType" %>
<table id="tabwucRequirementType" cellspacing="1" cellpadding="1" width="328" border="0"
    style="width: 328px; height: 208px">
    <tr>
        <td>
            <asp:Label ID="lblRequirementTypeId" runat="server">�����������ͱ��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtRequirementTypeId" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblRequirementType" runat="server">������������</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtRequirementType" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblMemo" runat="server">��ע</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server"
                Height="144px" Width="207px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
