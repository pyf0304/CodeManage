﻿
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucvFeatureAppTypeRela4Gv.ascx.cs" Inherits = "AGC.Webform.wucvFeatureAppTypeRela4Gv" %>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<%-- 列表层 --%>

<div id = "divList" class = "div_List" 
runat = "server">
<asp:GridView id = "gvFeatureAppTypeRela" style = "z-index: 102;" runat = "server" 
Width = "100%" AutoGenerateColumns = "False" 
PageSize = "10" AllowPaging = "true" 
AllowSorting = "true" 
OnSorting = "gvFeatureAppTypeRela_Sorting" 
OnPageIndexChanging = "gvFeatureAppTypeRela_PageIndexChanging" 
OnRowCreated = "gvFeatureAppTypeRela_RowCreated"
OnRowCommand = "gvFeatureAppTypeRela_RowCommand"
OnRowDeleting = "gvFeatureAppTypeRela_RowDeleting" 
OnRowUpdating = "gvFeatureAppTypeRela_RowUpdating" 
BackColor = "White" 
BorderColor = "#E7E7FF" 
BorderStyle = "None" 
BorderWidth = "1px"
cellpadding = "3" 
GridLines = "Horizontal" 
Height = "1px" 
DataKeyNames = "mId" 
CssClass = "table table-bordered table-hover table-striped">
<Columns>
<asp:TemplateField HeaderText = "">
<HeaderStyle Width = "10px" />
<HeaderTemplate>
<asp:CheckBox id = "chkSelAll" CommandName = "SelAll" runat = "server" CssClass = "btn btn-link btn-sm text-nowrap" AutoPostBack = "true" OnCheckedChanged = "chkSelAll_CheckedChanged"  Text = ""></asp:CheckBox>
</HeaderTemplate>
<ItemTemplate>
<a name = "A_FeatureAppTypeRela<%# Eval("mId").ToString().Trim() %>"></a>
<asp:CheckBox id = "chkCheckRec" runat = "server"></asp:CheckBox>
</ItemTemplate>
</asp:TemplateField>
<asp:BoundField DataField = "ApplicationTypeName" SortExpression = "ApplicationTypeName" HeaderText = "应用程序类型名称"></asp:BoundField>
<asp:BoundField DataField = "ApplicationTypeENName" SortExpression = "ApplicationTypeENName" HeaderText = "应用类型英文名"></asp:BoundField>
<asp:BoundField DataField = "FeatureName" SortExpression = "FeatureName" HeaderText = "功能名称"></asp:BoundField>
<asp:BoundField DataField = "FeatureTypeName" SortExpression = "FeatureTypeName" HeaderText = "功能类型名称"></asp:BoundField>
<asp:BoundField DataField = "OrderNum" SortExpression = "OrderNum" HeaderText = "序号"></asp:BoundField>
<asp:BoundField DataField = "InUse" SortExpression = "InUse" HeaderText = "是否在用"></asp:BoundField>
<asp:BoundField DataField = "UpdDate" SortExpression = "UpdDate" HeaderText = "修改日期"></asp:BoundField>
<asp:BoundField DataField = "UpdUser" SortExpression = "UpdUser" HeaderText = "修改者"></asp:BoundField>
<asp:BoundField DataField = "Memo" SortExpression = "Memo" HeaderText = "说明"></asp:BoundField>
<asp:TemplateField HeaderText = "修改">
<ItemTemplate>
<asp:LinkButton id = "lbUpdate" runat = "Server" CommandName = "Update" Text = "修改" CssClass = "LinkButton_DefaInGv" ></asp:LinkButton>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText = "删除">
<ItemTemplate>
<asp:LinkButton id = "lbDelete" runat = "Server" CommandName = "Delete" Text = "删除" CssClass = "LinkButton_DefaInGv"></asp:LinkButton>
</ItemTemplate>
</asp:TemplateField>
</Columns>
<PagerTemplate>
<span class="text-info col-form-label-sm">共有记录:</span>
<asp:Label ID = "lblRecCount" runat = "server" CssClass = "text-info col-form-label-sm" ForeColor = "#000066" Width = "36px">0</asp:Label>
<span class="text-info col-form-label-sm">
<div style = "display: inline; width: 16px; height: 13px">
</div>
</span><span class="text-info col-form-label-sm">总页数:</span>
<asp:Label ID = "lblAllPages" runat = "server" CssClass = "text-info col-form-label-sm" ForeColor = "#000066">0</asp:Label>
<div style = "display: inline; width: 16px; height: 13px">
</div>
<span class="text-info col-form-label-sm">当前页:</span>
<asp:Label ID = "lblCurrentPage" runat = "server" CssClass = "text-info col-form-label-sm" ForeColor = "#000066">0</asp:Label>
<div style = "display: inline; width: 16px; height: 13px">
</div>
<asp:Button ID = "btnPrevPage" runat = "server" CssClass = "btn btn-info btn-sm" Text = "上一页"
 CommandArgument = "Prev" CommandName = "PrevPage" /><span style = "font-family: Verdana">
</span>
<asp:Button ID = "btnNextPage" runat = "server" CssClass = "btn btn-info btn-sm" Text = "下一页"
 CommandArgument = "Next" CommandName = "NextPage" />
<span class="text-info col-form-label-sm">到第</span>
<asp:TextBox ID = "txtJump2Page" runat = "server" CssClass = "form-control-sm" Width = "35px"></asp:TextBox>
<span class="text-info col-form-label-sm">页</span>
<asp:Button ID = "btnJumpPage" runat = "server" CssClass = "btn btn-info btn-sm" OnClick = "btnJumpPage_Click"
Text = "确定" CommandName = "Page" />
<span class="text-info col-form-label-sm">页记录数:</span>
<asp:DropDownList ID = "ddlPagerRecCount" runat = "server" CssClass = "btn btn-outline-info btn-sm"
Width = "70px" AutoPostBack = "True" OnSelectedIndexChanged = "ddlPagerRecCount_SelectedIndexChanged">
<asp:ListItem>5</asp:ListItem>
<asp:ListItem>10</asp:ListItem>
<asp:ListItem>15</asp:ListItem>
<asp:ListItem>20</asp:ListItem>
<asp:ListItem>30</asp:ListItem>
<asp:ListItem>50</asp:ListItem>
<asp:ListItem>100</asp:ListItem>
<asp:ListItem>1000</asp:ListItem>
</asp:DropDownList>
<asp:CompareValidator ID = "CompareValidator" runat = "server" ControlToValidate = "txtJump2Page"
ErrorMessage = "错误!" ForeColor = "DarkOrange" Operator = "DataTypeCheck" Type = "Integer"></asp:CompareValidator>
</PagerTemplate>
<FooterStyle CssClass = "FooterStyle" />
<RowStyle CssClass = "RowStyle" />
<EmptyDataRowStyle CssClass = "EmptyDataRowStyle" />
<SelectedRowStyle CssClass = "SelectedRowStyle" />
<PagerStyle CssClass = "PagerStyle" />
<HeaderStyle CssClass = "HeaderStyle" />
<EditRowStyle CssClass = "EditRowStyle" />
<AlternatingRowStyle CssClass = "AlternatingRowStyle" />
</asp:GridView>
</div>