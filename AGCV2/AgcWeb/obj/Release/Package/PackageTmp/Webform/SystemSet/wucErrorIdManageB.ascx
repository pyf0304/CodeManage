<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucErrorIdManageB.ascx.cs" Inherits="AGC.Webform.wucErrorIdManageB" %>

<table id="tabwucErrorIdManage" cellspacing="1" cellpadding="1" border="0" style="width: 679px">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodeTypeId" runat="server" CssClass="col-form-label text-right">����ֲ�����</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCodeTypeId" runat="server" class="form-control-sm" OnSelectedIndexChanged="ddlCodeTypeId_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
        </td>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblErrID" runat="server" CssClass="col-form-label text-right">����Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtErrID" runat="server" class="form-control-sm" ReadOnly="True" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
  
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFunctionName" runat="server" CssClass="col-form-label text-right">��������</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFunctionName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblExplanation" runat="server" CssClass="col-form-label text-right">��ϸ˵��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtExplanation" runat="server" class="form-control-sm" Height="102px" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
   
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">��ע</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Height="91px" TextMode="MultiLine" Width="400px"></asp:TextBox>
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
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
