
 /**
 * 类名:PaperCRUDEx(界面:PaperCRUD)
 * 表名:Paper(01120535)
 * 版本:2023.01.08.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/09 01:17:56
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_界面后台Ex_TS(TS)(WA_ViewScriptCSEx_TS)
 * 编程语言:TypeScript
 **/
import { PaperCRUD } from "../PagesBase/GraduateEduPaper/PaperCRUD.js";
import { Paper_EditEx } from "./Paper_EditEx.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv }   from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
//import $ from "jquery";
 /** PaperCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
 **/
export class PaperCRUDEx extends PaperCRUD implements IShowList
{
//public static mstrListDiv = "divDataLst";
//public static mstrSortvPaperBy = "PaperId";
 /**
 * 每页记录数，在扩展类可以修改
 **/
public get pageSize():number {
return 10;
}

BindGv(strType: string, strPara: string) {
this.BindGv_Paper();
}
BindGv_Cache(strType: string, strPara: string) {
console.log("strPara", strPara);
let strMsg = "";
switch(strType)
{
case "vPaper":
alert('该类没有绑定该函数：[this.BindGv_vPaper_Cache]！');
//this.BindGv_vPaper_Cache();
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
let objPage: PaperCRUDEx;
if (PaperCRUD.objPage_CRUD == null)
{
PaperCRUD.objPage_CRUD = new PaperCRUDEx();
objPage = <PaperCRUDEx> PaperCRUD.objPage_CRUD;
}
else
{
objPage = <PaperCRUDEx> PaperCRUD.objPage_CRUD;
}
const objPage_Edit:Paper_EditEx = new Paper_EditEx(objPage);
let strMsg = '';
const arrKeyIds = GetCheckedKeyIdsInDiv(objPage.divName4DataList);
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
case "UpdateRecordInTab":            //修改记录InTab
strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);
if (IsNullOrEmpty( strKeyId )== true)
{
const strMsg = "请选择需要修改的记录！";
console.error(strMsg);
alert(strMsg);
return;
}
if (strCommandName == "UpdateRecordInTab")
{
objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
}
else
{
objPage_Edit.btnUpdateRecord_Click(strKeyId);
}
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
strMsg = '命令:' + strCommandName + "在函数(PaperCRUDExEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}



}