
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:SectionCRUDEx
 表名:Section(01120558)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/26 20:48:51
 生成者:
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
 框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
 编程语言:TypeScript
 == == == == == == == == == == == == 
 */
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { SectionCRUD } from "./SectionCRUD.js";
import { Section_EditEx } from "./Section_EditEx.js";
import { clsCommonFunc4Web }   from "../TS/PubFun/clsCommonFunc4Web2.js";
declare function ShowDialog_Section(strOpType): void;
declare function HideDialog_vSection(): void;
declare var $;
 /* SectionCRUDEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class SectionCRUDEx extends SectionCRUD implements IShowList
{
//public static mstrListDiv: string = "divDataLst";
//public static mstrSortvSectionBy: string = "sectionId";
 /*
 * 每页记录数，在扩展类可以修改
*/
public get pageSize():number {
return 10;
}

BindGv(strType: string, strPara: string) {
this.BindGv_vSection();
}
BindGv_Cache(strType: string, strPara: string) {
switch(strType)
{
case "vSection":
alert('该类没有绑定该函数：[this.BindGv_vSection_Cache]！');
//this.BindGv_vSection_Cache();
break;
}
}

 /*
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
 */
public static btn_Click(strCommandName: string, strKeyId: string) {
var objPage:SectionCRUDEx = new SectionCRUDEx();
var objPage_Edit:Section_EditEx = new Section_EditEx(objPage);
switch (strCommandName)
{
case "Query":    //查询记录
objPage.btnQuery_Click();
break;
case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
//objPage_Edit.btnAddNewRecordWithMaxId_Click();
break;
case "CreateWithMaxId":    //添加记录使用最大关键字
//objPage_Edit.btnAddNewRecordWithMaxId_Click();
break;
case "AddNewRecord":            //添加记录
case "Create":            //添加记录
objPage_Edit.btnAddNewRecord_Click();
break;
case "UpdateRecord":            //修改记录
case "Update":            //修改记录
objPage_Edit.btnUpdateRecord_Click("");
break;
case "UpdateRecordInTab":            //修改记录InTab
objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
break;
case "CopyRecord":            //复制记录
case "Clone":            //复制记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要复制的记录！");
return;
}
//objPage.btnCopyRecord_Click();
break;
case "DelRecord":            //删除记录
case "Delete":            //删除记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
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
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return;
}
//objPage.btnDelRecordBySign_Click();
break;
case "UnDelRecordBySign":            //按标志恢复删除记录
case "UnDeleteBySign":            //按标志恢复删除记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return;
}
//objPage.btnUnDelRecordBySign_Click();
break;
case "GoTop":            //置顶记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要置顶的记录！");
return;
}
//objPage.btnGoTop_Click();
break;
case "GoBottum":            //移底记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要移底的记录！");
return;
}
//objPage.btnGoBottum_Click();
break;
case "UpMove":            //上移记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要上移的记录！");
return;
}
//objPage.btnUpMove_Click();
break;
case "DownMove":            //下移记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
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
var strMsg = '命令:' + strCommandName + "在函数(SectionCRUDExEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
case "ExportExcel":            //导出Excel
alert("导出Excel功能还没有开通！");
break;
}
}
}