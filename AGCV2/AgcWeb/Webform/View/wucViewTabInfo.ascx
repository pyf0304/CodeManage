<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewTabInfo.ascx.cs" Inherits="AGC.Webform.wucViewTabInfo"%>
<table id="tabwucViewTabInfo" cellSpacing="1" cellPadding="1" width="600" border="0">
	<tr>
		<td>
			<asp:Label id="lblViewId" runat="server">����ID</asp:Label>
		</td>
		<td>
			<asp:DropDownList id="ddlViewId" runat="server" Width="152px"></asp:DropDownList>
		</td>
		<td>
		</td>
		<td></td>
	</tr>
	<tr>
		<td>
			<asp:Label id="lblDataBaseName" runat="server">���ݿ���</asp:Label>
		</td>
		<td>
			<asp:TextBox id="txtDataBaseName" runat="server"></asp:TextBox>
		</td>
		<td>
		</td>
		<td></td>
	</tr>
	<tr>
		<td>
			<asp:Label id="lblTabName" runat="server">����</asp:Label>
		</td>
		<td>
			<asp:TextBox id="txtTabName" runat="server"></asp:TextBox>
		</td>
		<td>
		</td>
		<td></td>
	</tr>
</table>
