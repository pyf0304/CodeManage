
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucTabCheckResultB.ascx.cs" Inherits="AGC.Webform.wucTabCheckResultB" %>

<table id="tabwucTabCheckResult" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblPrjId" runat="server" CssClass="col-form-label text-right">����ID</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlPrjId" runat="server" class="form-control-sm"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblTabId" runat="server" CssClass="col-form-label text-right">��ID</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlTabId" runat="server" class="form-control-sm"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblFldID" runat="server" CssClass="col-form-label text-right">�ֶ�ID</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtFldID" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblErrorLevelId" runat="server" CssClass="col-form-label text-right">����ȼ�Id</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtErrorLevelId" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblErrorMsg" runat="server" CssClass="col-form-label text-right">������Ϣ</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtErrorMsg" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblCheckDate" runat="server" CssClass="col-form-label text-right">�������</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtCheckDate" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblCheckUser" runat="server" CssClass="col-form-label text-right">�����</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtCheckUser" runat="server" class="form-control-sm"></asp:TextBox>
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