
<%@ Page language = "c#" AutoEventWireup = "true" CodeBehind = "WApigs_PaperAttention_UT.aspx.cs" Inherits = "ExamLib.WApiForm.WApigs_PaperAttention_UT" %>
<!DOCTYPE html>
<html xmlns = "http://www.w3.org/1999/xhtml">
<head runat = "server">
<meta http-equiv = "Content-Type" content = "text/html; charset = utf-8" />
<title>论文关注的WApi单元测试</title>
<script type = "text/javascript" src = "../../Scripts/jquery-3.4.1.min.js" ></script>
<link href = "../../Content/bootstrap.min.css" rel = "stylesheet" />
<script type = "text/javascript" src = "../../Scripts/bootstrap.min.js" ></script>
<script type = "text/javascript" src = "../../JS/tzPubFun.js"></script>
     <script>    
         function ExpandDiv(divName) {
            OnlyShowDiv(divName, "function", "content");
        }
window.onload = function() {
var hidDivName = document.getElementById("hidDivName");
var divName = hidDivName.value;
ExpandDiv(divName);
}
    </script>
</head>
<body>
<form id = "form1" runat = "server">
<asp:HiddenField  id="hidDivName" runat = "server"  />
<div id = "tabLayout" class = "tab_layout" 
runat = "server">

<div id="divIsExistRecord" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle1" name="lblTitle1" CssClass="h6" Width="700px" Text="测试：1、存在条件记录?(IsExistRecord)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandIsExistRecord" name="btnExpandIsExistRecord" onclick="ExpandDiv('divIsExistRecord');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup1" style="width: 100%; float: left">
<div id="divParastrWhereCond1" style="width: 100%; float: left">
<asp:Label id="lblParastrWhereCond1" name="lblParastrWhereCond1" Width="200px" Text="strWhereCond" runat="server" />
<asp:TextBox id="txtstrWhereCond1" name="txtstrWhereCond1" Width="80px" Text="1=1" runat="server" />
</div>
</div>
<div id="divList1" style="width: 100%; float: left">
<asp:Button id="btnIsExistRecord" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnIsExistRecord_Click" Text="1、存在条件记录?" runat="server" />
<asp:Label id="lblResult1" name="lblResult1" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetRecCountByCond" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle2" name="lblTitle2" CssClass="h6" Width="700px" Text="测试：2、获取条件记录数(GetRecCountByCond)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetRecCountByCond" name="btnExpandGetRecCountByCond" onclick="ExpandDiv('divGetRecCountByCond');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup2" style="width: 100%; float: left">
<div id="divParastrWhereCond2" style="width: 100%; float: left">
<asp:Label id="lblParastrWhereCond2" name="lblParastrWhereCond2" Width="200px" Text="strWhereCond" runat="server" />
<asp:TextBox id="txtstrWhereCond2" name="txtstrWhereCond2" Width="80px" Text="1=1" runat="server" />
</div>
</div>
<div id="divList2" style="width: 100%; float: left">
<asp:Button id="btnGetRecCountByCond" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetRecCountByCond_Click" Text="2、获取条件记录数" runat="server" />
<asp:Label id="lblResult2" name="lblResult2" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetFldValue" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle3" name="lblTitle3" CssClass="h6" Width="700px" Text="测试：3、获取条件字段值列表(GetFldValue)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetFldValue" name="btnExpandGetFldValue" onclick="ExpandDiv('divGetFldValue');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup3" style="width: 100%; float: left">
<div id="divParastrWhereCond3" style="width: 100%; float: left">
<asp:Label id="lblParastrWhereCond3" name="lblParastrWhereCond3" Width="200px" Text="strWhereCond" runat="server" />
<asp:TextBox id="txtstrWhereCond3" name="txtstrWhereCond3" Width="80px" Text="1=1" runat="server" />
</div>
<div id="divParastrFldName3" style="width: 100%; float: left">
<asp:Label id="lblParastrFldName3" name="lblParastrFldName3" Width="200px" Text="strFldName" runat="server" />
<asp:TextBox id="txtstrFldName3" name="txtstrFldName3" Width="80px" runat="server" />
</div>
<div id="divParastrTabName3" style="width: 100%; float: left">
<asp:Label id="lblParastrTabName3" name="lblParastrTabName3" Width="200px" Text="strTabName" runat="server" />
<asp:TextBox id="txtstrTabName3" name="txtstrTabName3" Width="80px" runat="server" />
</div>
</div>
<div id="divList3" style="width: 100%; float: left">
<asp:Button id="btnGetFldValue" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetFldValue_Click" Text="3、获取条件字段值列表" runat="server" />
<asp:Label id="lblResult3" name="lblResult3" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divAddNewRecord" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle4" name="lblTitle4" CssClass="h6" Width="700px" Text="测试：4、添加记录(AddNewRecord)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandAddNewRecord" name="btnExpandAddNewRecord" onclick="ExpandDiv('divAddNewRecord');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup4" style="width: 100%; float: left">
<div id="divParastrFunction4CodeJSONObj4" style="width: 100%; float: left">
<asp:Label id="lblParastrFunction4CodeJSONObj4" name="lblParastrFunction4CodeJSONObj4" Width="200px" Text="strFunction4CodeJSONObj" runat="server" />
<asp:TextBox id="txtstrFunction4CodeJSONObj4" name="txtstrFunction4CodeJSONObj4" Width="80px" runat="server" />
</div>
</div>
<div id="divList4" style="width: 100%; float: left">
<asp:Button id="btnAddNewRecord" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnAddNewRecord_Click" Text="4、添加记录" runat="server" />
<asp:Label id="lblResult4" name="lblResult4" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divUpdateRecord" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle8" name="lblTitle8" CssClass="h6" Width="700px" Text="测试：8、修改记录(UpdateRecord)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandUpdateRecord" name="btnExpandUpdateRecord" onclick="ExpandDiv('divUpdateRecord');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup8" style="width: 100%; float: left">
</div>
<div id="divList8" style="width: 100%; float: left">
<asp:Button id="btnUpdateRecord" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnUpdateRecord_Click" Text="8、修改记录" runat="server" />
<asp:Label id="lblResult8" name="lblResult8" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divDelRecord" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle9" name="lblTitle9" CssClass="h6" Width="700px" Text="测试：9、删除记录(DelRecord)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandDelRecord" name="btnExpandDelRecord" onclick="ExpandDiv('divDelRecord');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup9" style="width: 100%; float: left">
<div id="divParastrKeyId9" style="width: 100%; float: left">
<asp:Label id="lblParastrKeyId9" name="lblParastrKeyId9" Width="200px" Text="strKeyId" runat="server" />
<asp:TextBox id="txtstrKeyId9" name="txtstrKeyId9" Width="80px" runat="server" />
</div>
</div>
<div id="divList9" style="width: 100%; float: left">
<asp:Button id="btnDelRecord" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnDelRecord_Click" Text="9、删除记录" runat="server" />
<asp:Label id="lblResult9" name="lblResult9" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divDelRecords" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle10" name="lblTitle10" CssClass="h6" Width="700px" Text="测试：10、根据关键字串来删除多条记录(DelRecords)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandDelRecords" name="btnExpandDelRecords" onclick="ExpandDiv('divDelRecords');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup10" style="width: 100%; float: left">
<div id="divParastrKeyIdLst10" style="width: 100%; float: left">
<asp:Label id="lblParastrKeyIdLst10" name="lblParastrKeyIdLst10" Width="200px" Text="strKeyIdLst" runat="server" />
<asp:TextBox id="txtstrKeyIdLst10" name="txtstrKeyIdLst10" Width="80px" runat="server" />
</div>
</div>
<div id="divList10" style="width: 100%; float: left">
<asp:Button id="btnDelRecords" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnDelRecords_Click" Text="10、根据关键字串来删除多条记录" runat="server" />
<asp:Label id="lblResult10" name="lblResult10" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetFirstObj" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle11" name="lblTitle11" CssClass="h6" Width="700px" Text="测试：11、获取第一条满足条件的对象(GetFirstObj)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetFirstObj" name="btnExpandGetFirstObj" onclick="ExpandDiv('divGetFirstObj');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup11" style="width: 100%; float: left">
<div id="divParastrWhereCond11" style="width: 100%; float: left">
<asp:Label id="lblParastrWhereCond11" name="lblParastrWhereCond11" Width="200px" Text="strWhereCond" runat="server" />
<asp:TextBox id="txtstrWhereCond11" name="txtstrWhereCond11" Width="80px" Text="1=1" runat="server" />
</div>
</div>
<div id="divList11" style="width: 100%; float: left">
<asp:Button id="btnGetFirstObj" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetFirstObj_Click" Text="11、获取第一条满足条件的对象" runat="server" />
<asp:Label id="lblResult11" name="lblResult11" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetObjByPaperAttentionId" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle12" name="lblTitle12" CssClass="h6" Width="700px" Text="测试：12、根据关键字获取对象(GetObjBy[Key])" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetObjByPaperAttentionId" name="btnExpandGetObjByPaperAttentionId" onclick="ExpandDiv('divGetObjByPaperAttentionId');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup12" style="width: 100%; float: left">
<div id="divParavarKeyId12" style="width: 100%; float: left">
<asp:Label id="lblParavarKeyId12" name="lblParavarKeyId12" Width="200px" Text="varKeyId" runat="server" />
<asp:TextBox id="txtvarKeyId12" name="txtvarKeyId12" Width="80px" runat="server" />
</div>
</div>
<div id="divList12" style="width: 100%; float: left">
<asp:Button id="btnGetObjByPaperAttentionId" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetObjByPaperAttentionId_Click" Text="12、根据关键字获取对象" runat="server" />
<asp:Label id="lblResult12" name="lblResult12" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetObjByPaperAttentionId_WA_Cache" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle13" name="lblTitle13" CssClass="h6" Width="700px" Text="测试：13、根据关键字获取对象, 使用WebApi缓存(GetObjBy[Key]_WA_Cache)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetObjByPaperAttentionId_WA_Cache" name="btnExpandGetObjByPaperAttentionId_WA_Cache" onclick="ExpandDiv('divGetObjByPaperAttentionId_WA_Cache');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup13" style="width: 100%; float: left">
<div id="divParavarKeyId13" style="width: 100%; float: left">
<asp:Label id="lblParavarKeyId13" name="lblParavarKeyId13" Width="200px" Text="varKeyId" runat="server" />
<asp:TextBox id="txtvarKeyId13" name="txtvarKeyId13" Width="80px" runat="server" />
</div>
</div>
<div id="divList13" style="width: 100%; float: left">
<asp:Button id="btnGetObjByPaperAttentionId_WA_Cache" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetObjByPaperAttentionId_WA_Cache_Click" Text="13、根据关键字获取对象, 使用WebApi缓存" runat="server" />
<asp:Label id="lblResult13" name="lblResult13" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetObjLst" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle14" name="lblTitle14" CssClass="h6" Width="700px" Text="测试：14、获取对象列表(GetObjLst)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetObjLst" name="btnExpandGetObjLst" onclick="ExpandDiv('divGetObjLst');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup14" style="width: 100%; float: left">
<div id="divParastrWhereCond14" style="width: 100%; float: left">
<asp:Label id="lblParastrWhereCond14" name="lblParastrWhereCond14" Width="200px" Text="strWhereCond" runat="server" />
<asp:TextBox id="txtstrWhereCond14" name="txtstrWhereCond14" Width="80px" Text="1=1" runat="server" />
</div>
</div>
<div id="divList14" style="width: 100%; float: left">
<asp:Button id="btnGetObjLst" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetObjLst_Click" Text="14、获取对象列表" runat="server" />
<asp:Label id="lblResult14" name="lblResult14" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetObjLstByKeyLst" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle15" name="lblTitle15" CssClass="h6" Width="700px" Text="测试：15、根据关键字列表获取对象列表(GetObjLstByKeyLst)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetObjLstByKeyLst" name="btnExpandGetObjLstByKeyLst" onclick="ExpandDiv('divGetObjLstByKeyLst');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup15" style="width: 100%; float: left">
<div id="divParaarrKeyId15" style="width: 100%; float: left">
<asp:Label id="lblParaarrKeyId15" name="lblParaarrKeyId15" Width="200px" Text="arrKeyId" runat="server" />
<asp:TextBox id="txtarrKeyId15" name="txtarrKeyId15" Width="80px" runat="server" />
</div>
</div>
<div id="divList15" style="width: 100%; float: left">
<asp:Button id="btnGetObjLstByKeyLst" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetObjLstByKeyLst_Click" Text="15、根据关键字列表获取对象列表" runat="server" />
<asp:Label id="lblResult15" name="lblResult15" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetObjLstByKeyLst_Cache" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle16" name="lblTitle16" CssClass="h6" Width="700px" Text="测试：16、根据关键字列表获取对象列表, 使用缓存(GetObjLstByKeyLst_Cache)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetObjLstByKeyLst_Cache" name="btnExpandGetObjLstByKeyLst_Cache" onclick="ExpandDiv('divGetObjLstByKeyLst_Cache');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup16" style="width: 100%; float: left">
<div id="divParaarrKeyId16" style="width: 100%; float: left">
<asp:Label id="lblParaarrKeyId16" name="lblParaarrKeyId16" Width="200px" Text="arrKeyId" runat="server" />
<asp:TextBox id="txtarrKeyId16" name="txtarrKeyId16" Width="80px" runat="server" />
</div>
</div>
<div id="divList16" style="width: 100%; float: left">
<asp:Button id="btnGetObjLstByKeyLst_Cache" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetObjLstByKeyLst_Cache_Click" Text="16、根据关键字列表获取对象列表, 使用缓存" runat="server" />
<asp:Label id="lblResult16" name="lblResult16" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetObjLstByKeyLst_WA_Cache" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle17" name="lblTitle17" CssClass="h6" Width="700px" Text="测试：17、根据关键字列表获取对象列表, 使用WebApi缓存(GetObjLstByKeyLst_WA_Cache)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetObjLstByKeyLst_WA_Cache" name="btnExpandGetObjLstByKeyLst_WA_Cache" onclick="ExpandDiv('divGetObjLstByKeyLst_WA_Cache');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup17" style="width: 100%; float: left">
<div id="divParaarrKeyId17" style="width: 100%; float: left">
<asp:Label id="lblParaarrKeyId17" name="lblParaarrKeyId17" Width="200px" Text="arrKeyId" runat="server" />
<asp:TextBox id="txtarrKeyId17" name="txtarrKeyId17" Width="80px" runat="server" />
</div>
</div>
<div id="divList17" style="width: 100%; float: left">
<asp:Button id="btnGetObjLstByKeyLst_WA_Cache" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetObjLstByKeyLst_WA_Cache_Click" Text="17、根据关键字列表获取对象列表, 使用WebApi缓存" runat="server" />
<asp:Label id="lblResult17" name="lblResult17" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetTopObjLst" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle18" name="lblTitle18" CssClass="h6" Width="700px" Text="测试：18、获取顶部对象列表(GetTopObjLst)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetTopObjLst" name="btnExpandGetTopObjLst" onclick="ExpandDiv('divGetTopObjLst');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup18" style="width: 100%; float: left">
<div id="divParaintTopSize18" style="width: 100%; float: left">
<asp:Label id="lblParaintTopSize18" name="lblParaintTopSize18" Width="200px" Text="intTopSize" runat="server" />
<asp:TextBox id="txtintTopSize18" name="txtintTopSize18" Width="80px" Text="3" runat="server" />
</div>
<div id="divParastrOrderBy18" style="width: 100%; float: left">
<asp:Label id="lblParastrOrderBy18" name="lblParastrOrderBy18" Width="200px" Text="strOrderBy" runat="server" />
<asp:TextBox id="txtstrOrderBy18" name="txtstrOrderBy18" Width="80px" Text="PaperAttentionId Asc" runat="server" />
</div>
<div id="divParastrWhereCond18" style="width: 100%; float: left">
<asp:Label id="lblParastrWhereCond18" name="lblParastrWhereCond18" Width="200px" Text="strWhereCond" runat="server" />
<asp:TextBox id="txtstrWhereCond18" name="txtstrWhereCond18" Width="80px" Text="1=1" runat="server" />
</div>
</div>
<div id="divList18" style="width: 100%; float: left">
<asp:Button id="btnGetTopObjLst" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetTopObjLst_Click" Text="18、获取顶部对象列表" runat="server" />
<asp:Label id="lblResult18" name="lblResult18" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetObjLstByPager" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle19" name="lblTitle19" CssClass="h6" Width="700px" Text="测试：19、获取分页对象列表(GetObjLstByPager)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetObjLstByPager" name="btnExpandGetObjLstByPager" onclick="ExpandDiv('divGetObjLstByPager');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup19" style="width: 100%; float: left">
<div id="divParaintPageIndex19" style="width: 100%; float: left">
<asp:Label id="lblParaintPageIndex19" name="lblParaintPageIndex19" Width="200px" Text="intPageIndex" runat="server" />
<asp:TextBox id="txtintPageIndex19" name="txtintPageIndex19" Width="80px" Text="1" runat="server" />
</div>
<div id="divParaintPageSize19" style="width: 100%; float: left">
<asp:Label id="lblParaintPageSize19" name="lblParaintPageSize19" Width="200px" Text="intPageSize" runat="server" />
<asp:TextBox id="txtintPageSize19" name="txtintPageSize19" Width="80px" Text="5" runat="server" />
</div>
<div id="divParastrOrderBy19" style="width: 100%; float: left">
<asp:Label id="lblParastrOrderBy19" name="lblParastrOrderBy19" Width="200px" Text="strOrderBy" runat="server" />
<asp:TextBox id="txtstrOrderBy19" name="txtstrOrderBy19" Width="80px" Text="PaperAttentionId Asc" runat="server" />
</div>
<div id="divParastrWhereCond19" style="width: 100%; float: left">
<asp:Label id="lblParastrWhereCond19" name="lblParastrWhereCond19" Width="200px" Text="strWhereCond" runat="server" />
<asp:TextBox id="txtstrWhereCond19" name="txtstrWhereCond19" Width="80px" Text="1=1" runat="server" />
</div>
</div>
<div id="divList19" style="width: 100%; float: left">
<asp:Button id="btnGetObjLstByPager" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetObjLstByPager_Click" Text="19、获取分页对象列表" runat="server" />
<asp:Label id="lblResult19" name="lblResult19" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetObjLstByPager_Cache" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle20" name="lblTitle20" CssClass="h6" Width="700px" Text="测试：20、获取分页对象列表, 使用缓存(GetObjLstByPager_Cache)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetObjLstByPager_Cache" name="btnExpandGetObjLstByPager_Cache" onclick="ExpandDiv('divGetObjLstByPager_Cache');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup20" style="width: 100%; float: left">
<div id="divParaintPageIndex20" style="width: 100%; float: left">
<asp:Label id="lblParaintPageIndex20" name="lblParaintPageIndex20" Width="200px" Text="intPageIndex" runat="server" />
<asp:TextBox id="txtintPageIndex20" name="txtintPageIndex20" Width="80px" Text="1" runat="server" />
</div>
<div id="divParaintPageSize20" style="width: 100%; float: left">
<asp:Label id="lblParaintPageSize20" name="lblParaintPageSize20" Width="200px" Text="intPageSize" runat="server" />
<asp:TextBox id="txtintPageSize20" name="txtintPageSize20" Width="80px" Text="5" runat="server" />
</div>
<div id="divParastrOrderBy20" style="width: 100%; float: left">
<asp:Label id="lblParastrOrderBy20" name="lblParastrOrderBy20" Width="200px" Text="strOrderBy" runat="server" />
<asp:TextBox id="txtstrOrderBy20" name="txtstrOrderBy20" Width="80px" Text="PaperAttentionId Asc" runat="server" />
</div>
<div id="divParastrWhereCond20" style="width: 100%; float: left">
<asp:Label id="lblParastrWhereCond20" name="lblParastrWhereCond20" Width="200px" Text="strWhereCond" runat="server" />
<asp:TextBox id="txtstrWhereCond20" name="txtstrWhereCond20" Width="80px" Text="1=1" runat="server" />
</div>
</div>
<div id="divList20" style="width: 100%; float: left">
<asp:Button id="btnGetObjLstByPager_Cache" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetObjLstByPager_Cache_Click" Text="20、获取分页对象列表, 使用缓存" runat="server" />
<asp:Label id="lblResult20" name="lblResult20" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>

<div id="divGetObjLstByRange" style="width: 100%; float: left; margin-bottom:5px;" class="function">
<hr />
<div style="width:100%; height:25px;" class="title">
<div style="float:left; width:80%;">
<asp:Label id="lblTitle21" name="lblTitle21" CssClass="h6" Width="700px" Text="测试：21、获取范围内的对象列表(GetObjLstByRange)" runat="server" />
</div>
<div style="float:right; width:20%;">
<input type='button'  id="btnExpandGetObjLstByRange" name="btnExpandGetObjLstByRange" onclick="ExpandDiv('divGetObjLstByRange');" value="展开"  />
</div>
</div>
<div style="width: 100%" class="content">
<div id="divParaGroup21" style="width: 100%; float: left">
<div id="divParastrOrderBy21" style="width: 100%; float: left">
<asp:Label id="lblParastrOrderBy21" name="lblParastrOrderBy21" Width="200px" Text="strOrderBy" runat="server" />
<asp:TextBox id="txtstrOrderBy21" name="txtstrOrderBy21" Width="80px" Text="PaperAttentionId Asc" runat="server" />
</div>
<div id="divParaintMaxNum21" style="width: 100%; float: left">
<asp:Label id="lblParaintMaxNum21" name="lblParaintMaxNum21" Width="200px" Text="intMaxNum" runat="server" />
<asp:TextBox id="txtintMaxNum21" name="txtintMaxNum21" Width="80px" Text="5" runat="server" />
</div>
<div id="divParaintMinNum21" style="width: 100%; float: left">
<asp:Label id="lblParaintMinNum21" name="lblParaintMinNum21" Width="200px" Text="intMinNum" runat="server" />
<asp:TextBox id="txtintMinNum21" name="txtintMinNum21" Width="80px" Text="2" runat="server" />
</div>
<div id="divParastrWhereCond21" style="width: 100%; float: left">
<asp:Label id="lblParastrWhereCond21" name="lblParastrWhereCond21" Width="200px" Text="strWhereCond" runat="server" />
<asp:TextBox id="txtstrWhereCond21" name="txtstrWhereCond21" Width="80px" Text="1=1" runat="server" />
</div>
</div>
<div id="divList21" style="width: 100%; float: left">
<asp:Button id="btnGetObjLstByRange" CssClass="btn btn-outline-info btn-sm" Width="350px" OnClick="btnGetObjLstByRange_Click" Text="21、获取范围内的对象列表" runat="server" />
<asp:Label id="lblResult21" name="lblResult21" CssClass="Content" Width="600px" Text="结果" runat="server" />
<div>
</div>
</div>
</div>
</div>
</div>
</form>
</body>
</html>