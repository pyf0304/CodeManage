<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFuncModule.ascx.cs" Inherits="AGC.Webform.wucFuncModule" %>

<table id="tabwucFuncModule" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td class="NameTD" style="width: 118px">
            <asp:Label ID="lblFuncModuleId" runat="server" CssClass="col-form-label text-right">����ģ��Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncModuleId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblFuncModuleName" runat="server" CssClass="col-form-label text-right" Width="84px">����ģ������</asp:Label></td>
        <td>
            <asp:TextBox ID="txtFuncModuleName" runat="server" class="form-control-sm"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 118px">&nbsp;<asp:Label ID="lblFuncModuleEnName" runat="server" CssClass="col-form-label text-right">����ģ��Ӣ������</asp:Label></td>
        <td class="ValueTD" colspan="3">&nbsp;<asp:TextBox ID="txtFuncModuleEnName" runat="server" class="form-control-sm" Width="447px"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 118px">&nbsp;<asp:Label ID="lblPrjId" runat="server" CssClass="col-form-label text-right">����ID</asp:Label></td>
        <td class="ValueTD">&nbsp;<asp:DropDownList ID="ddlPrjId" runat="server" class="form-control-sm" Width="164px" Enabled="False"></asp:DropDownList></td>
        <td>
            <asp:Label ID="lblUserId" runat="server" CssClass="col-form-label text-right">�û�ID</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlUserId" runat="server" class="form-control-sm" Width="158px"></asp:DropDownList></td>
    </tr>
    <tr>
        <td class="style1" valign="top">
            <asp:Label ID="lblUseStateId" runat="server" CssClass="col-form-label text-right">ʹ��״̬</asp:Label>
        </td>
        <td class="ValueTD" valign="top">
            <asp:DropDownList ID="ddlUseStateId" runat="server" class="form-control-sm" Width="160px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 118px">&nbsp;<asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">˵��</asp:Label></td>
        <td class="ValueTD" colspan="3">&nbsp;<asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Height="178px" Width="447px"></asp:TextBox></td>
    </tr>
</table>
