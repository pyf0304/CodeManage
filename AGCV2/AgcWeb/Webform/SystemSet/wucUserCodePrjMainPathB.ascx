<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucUserCodePrjMainPathB.ascx.cs" Inherits="AGC.Webform.wucUserCodePrjMainPathB" %>


<table id="tabwucUserCodePrjMainPath" style="width: 738px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserId" runat="server" CssClass="col-form-label text-right">�û�ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUserId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server" CssClass="col-form-label text-right">����ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
     <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsUsePrjMainPath" runat="server" Text="	�Ƿ�ʹ����Ŀ��·��" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProgLangTypeId" runat="server" CssClass="col-form-label text-right">�����������Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlProgLangTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodePath" runat="server" CssClass="col-form-label text-right">����·��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodePath" runat="server" class="form-control-sm" Height="65px" TextMode="MultiLine" Width="498px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodePathBackup" runat="server" CssClass="col-form-label text-right">���ݴ���·��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodePathBackup" runat="server" class="form-control-sm" Height="56px" TextMode="MultiLine" Width="500px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsTemplate" runat="server" Text="�Ƿ�ģ��" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
    </tr>
 
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">˵��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Height="59px" TextMode="MultiLine" Width="496px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
