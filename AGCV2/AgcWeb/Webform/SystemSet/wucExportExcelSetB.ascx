
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucExportExcelSetB.ascx.cs" Inherits="AGC.Webform.wucExportExcelSetB" %>
<link rel="stylesheet" type="text/css" href="../../css/taishweb2.css"/>
<table id="tabwucExportExcelSet" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblIdExportExcel4Users" runat="server" CssClass="col-form-label text-right">��ˮ��</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtIdExportExcel4Users" runat="server" class="form-control-sm" 
        Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblViewName" runat="server" CssClass="col-form-label text-right">��������</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtViewName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblTabName" runat="server" CssClass="col-form-label text-right">����</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtTabName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblUserID" runat="server" CssClass="col-form-label text-right">�û�ID</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtUserID" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td colspan="2">
<asp:CheckBox id="chkIsDefaultUser" runat="server" Text="�Ƿ�ȱʡ�û�" CssClass="Check_Defa"></asp:CheckBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblExportFileName" runat="server" CssClass="col-form-label text-right">�����ļ���</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtExportFileName" runat="server" class="form-control-sm" 
        Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" runat="server" CssClass="col-form-label text-right">��ע</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" runat="server" class="form-control-sm" Height="63px" 
        TextMode="MultiLine" Width="400px"></asp:TextBox>
</td>
</tr>
</table>