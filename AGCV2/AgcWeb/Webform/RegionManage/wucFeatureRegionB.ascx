
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFeatureRegionB.ascx.cs" Inherits="AGC.Webform.wucFeatureRegionB" %>

<table id="tabwucFeatureRegion" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblRegionId" runat="server" CssClass="col-form-label text-right">����Id</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtRegionId" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
<asp:CompareValidator id="ComValid_RegionId" runat="server" CssClass="text-warning" ErrorMessage="������������ֵ!" ControlToValidate="txtRegionId" 
Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
</asp:CompareValidator>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblButtonStyleId" runat="server" CssClass="col-form-label text-right">��ť��ʽId</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlButtonStyleId" runat="server" class="form-control-sm"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" runat="server" CssClass="col-form-label text-right">˵��</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
</table>