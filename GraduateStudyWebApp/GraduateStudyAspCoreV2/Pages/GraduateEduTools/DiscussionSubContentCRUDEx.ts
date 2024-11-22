
 /**
 * 类名:DiscussionSubContentCRUDEx(界面:DiscussionSubContentCRUD)
 * 表名:DiscussionSubContent(01120587)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/06 00:00:21
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:WA_界面后台Ex_TS(TS)(WA_ViewScriptCSEx_TS)
 * 编程语言:TypeScript
 **/
import { DiscussionSubContentCRUD } from "../PagesBase/GraduateEduTools/DiscussionSubContentCRUD.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv }   from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
//import $ from "jquery";
 /** DiscussionSubContentCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
 **/
export class DiscussionSubContentCRUDEx extends DiscussionSubContentCRUD implements IShowList
{
//public static mstrListDiv = "divDataLst";
//public static mstrSortvDiscussionSubContentBy = "SubContentId";
 /**
 * 每页记录数，在扩展类可以修改
 **/
public get pageSize():number {
return 10;
}

BindGv(strType: string, strPara: string) {
this.BindGv_vDiscussionSubContent();
}
BindGv_Cache(strType: string, strPara: string) {
console.log("strPara", strPara);
let strMsg = "";
switch(strType)
{
case "vDiscussionSubContent":
alert('该类没有绑定该函数：[this.BindGv_vDiscussionSubContent_Cache]！');
//this.BindGv_vDiscussionSubContent_Cache();
break;
default:
strMsg = Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
console.error(strMsg);
alert(strMsg);
break;
}
}

 /**
 * 按钮单击,用于调用Js函数中btn_Click
 * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
 **/
public static btn_Click(strCommandName: string, strKeyId: string) {
let objPage: DiscussionSubContentCRUDEx;
if (DiscussionSubContentCRUD.objPage_CRUD == null)
{
DiscussionSubContentCRUD.objPage_CRUD = new DiscussionSubContentCRUDEx();
objPage = <DiscussionSubContentCRUDEx> DiscussionSubContentCRUD.objPage_CRUD;
}
else
{
objPage = <DiscussionSubContentCRUDEx> DiscussionSubContentCRUD.objPage_CRUD;
}
const arrKeyIds = GetCheckedKeyIdsInDiv(objPage.divName4DataList);
let strMsg = '';
switch (strCommandName)
{
case "Query":    //查询记录
objPage.btnQuery_Click();
break;
case "CopyRecord":            //复制记录
case "Clone":            //复制记录
if (arrKeyIds.length == 0)
{
alert("请选择需要复制的记录！");
return;
}
//objPage.btnCopyRecord_Click();
break;
case "ExportExcel":            //导出Excel
//objPage.btnExportExcel_Click();
//alert("导出Excel功能还没有开通！");
break;
case "DelRecord":            //删除记录
case "Delete":            //删除记录
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return;
}
objPage.btnDelRecord_Click();
break;
case "DelRecordInTab":   //删除记录InTab 
objPage.btnDelRecordInTab_Click(strKeyId);
break;
case "DelRecordBySign":            //按标志删除记录
case "DeleteBySign":            //按标志删除记录
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return;
}
//objPage.btnDelRecordBySign_Click();
break;
case "UnDelRecordBySign":            //按标志恢复删除记录
case "UnDeleteBySign":            //按标志恢复删除记录
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return;
}
//objPage.btnUnDelRecordBySign_Click();
break;
case "GoTop":            //置顶记录
if (arrKeyIds.length == 0)
{
alert("请选择需要置顶的记录！");
return;
}
//objPage.btnGoTop_Click();
break;
case "GoBottum":            //移底记录
if (arrKeyIds.length == 0)
{
alert("请选择需要移底的记录！");
return;
}
//objPage.btnGoBottum_Click();
break;
case "UpMove":            //上移记录
if (arrKeyIds.length == 0)
{
alert("请选择需要上移的记录！");
return;
}
//objPage.btnUpMove_Click();
break;
case "DownMove":            //下移记录
if (arrKeyIds.length == 0)
{
alert("请选择需要下移的记录！");
return;
}
//objPage.btnDownMove_Click();
break;
case "ReOrder":            //重序记录
//objPage.btnReOrder_Click();
break;
default:
strMsg = '命令:' + strCommandName + "在函数(DiscussionSubContentCRUDExEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}



}