
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WApigs_PaperAttention_UT_TS
 表名:gs_PaperAttention(01120748)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/29 00:00:13
 生成者:pyf2
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
 框架-层名:WA_界面UT后台_TS(WA_ViewUTScriptCS_TS)
 编程语言:TypeScript
 == == == == == == == == == == == == 
 */
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
import { clsgs_PaperAttentionEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js";
import { clsgs_PaperAttentionWApi, clsgs_PaperAttentionBL } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web.js";
import { stuTopPara } from "../TS/PubFun/stuTopPara.js";
import { stuRangePara } from "../TS/PubFun/stuRangePara.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { CacheHelper } from "../TS/PubFun/CacheHelper.js";
import { clsFldComparisonObj } from "../TS/PubFun/clsFldComparisonObj.js";
declare var $;
 /// <summary>
 /// WApigs_PaperAttention_UT_TS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:GeneCode)
 /// </summary>
export class WApigs_PaperAttention_UT_TS 
{


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
public static async btnIsExist_Click() {
$('#hidDivName').val("divIsExist");
var strKeyId: string = $('#txtstrKeyId1').val();
var lngPaperAttentionId: number = Number(strKeyId);
try
{
const responseText = await clsgs_PaperAttentionWApi.IsExistAsync(lngPaperAttentionId);
var returnBool: boolean = responseText;
if (returnBool == false)
{
var strInfo: string = `关键字:[${strKeyId}] 的记录不存在!`;
$('#lblResult1').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `关键字:[${strKeyId}]的相关记录存在!`;
$('#lblResult1').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg: string = `检查相应关键字的记录存在不成功, ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickIsExist_Cache)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
public static async btnIsExist_Cache_Click() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId: string = $('#txtstrKeyId2').val();
var lngPaperAttentionId: number = Number(strKeyId);
try
{
const responseText = await clsgs_PaperAttentionWApi.IsExist_Cache(lngPaperAttentionId);
var returnBool: boolean = responseText;
if (returnBool == false)
{
var strInfo: string = `关键字:[${strKeyId}] 的记录不存在!`;
$('#lblResult2').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `关键字:[${strKeyId}]的相关记录存在!`;
$('#lblResult2').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg: string = `检查相应关键字的记录存在不成功, ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickIsExistRecord)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
public static async btnIsExistRecord_Click() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond: string = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsgs_PaperAttentionWApi.IsExistRecordAsync(strWhereCond);
var returnBool: boolean = responseText;
if (returnBool == false)
{
strWhereCond = $('#txtstrWhereCond3').val();
var strInfo: string = `根据条件:[${strWhereCond}] 的记录不存在!`;
$('#lblResult3').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
strWhereCond = $('#txtstrWhereCond3').val();
var strInfo: string = `根据条件:[${strWhereCond}]的相关记录存在!`;
$('#lblResult3').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg: string = `检查条件的记录存在不成功, ${(e)}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickIsExistRecord_Cache)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
public static async btnIsExistRecord_Cache_Click() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond:Object = $('#txtobjTabName_Cond4').val();
var objgs_PaperAttention_Cond: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
var arrFldComparisonObj = WApigs_PaperAttention_UT_TS.GetLocalObjLst();
console.log(`字段比较对象记录数(本地获取)：${ arrFldComparisonObj.length}`);
arrFldComparisonObj.forEach(x => { objgs_PaperAttention_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttention_Cond);
console.log(objgs_PaperAttentionEN_Sim);
try
{
const responseText = await clsgs_PaperAttentionWApi.IsExistRecord_Cache(objgs_PaperAttention_Cond);
var returnBool: boolean = responseText;
if (returnBool == false)
{
var strInfo: string = `根据条件:[${JSON.stringify(objgs_PaperAttention_Cond)}]的记录不存在!`;
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `根据条件:[${JSON.stringify(objgs_PaperAttention_Cond)}]的相关记录存在!`;
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg: string = `检查条件的记录存在不成功, ${(e)}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 获取某一条件的记录数
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetRecCountByCond)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
public static async btnGetRecCountByCond_Click() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond: string = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsgs_PaperAttentionWApi.GetRecCountByCondAsync(strWhereCond);
var returnInt: number = Number(responseText);
strWhereCond = $('#txtstrWhereCond5').val();
var strInfo: string = `根据条件:${strWhereCond}的记录数:${returnInt}!`;
$('#lblResult5').val(strInfo);
//显示信息框
alert(strInfo);
}
catch(e)
{
var strMsg: string = `获取某一条件的记录数不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 获取某一条件的记录数
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetRecCountByCond_Cache)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
public static async btnGetRecCountByCond_Cache_Click() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond:Object = $('#txtobjTabName_Cond6').val();
var objgs_PaperAttention_Cond: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
var arrFldComparisonObj = WApigs_PaperAttention_UT_TS.GetLocalObjLst();
console.log(`字段比较对象记录数(本地获取)：${ arrFldComparisonObj.length}`);
arrFldComparisonObj.forEach(x => { objgs_PaperAttention_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttention_Cond);
console.log(objgs_PaperAttentionEN_Sim);
try
{
const responseText = await clsgs_PaperAttentionWApi.GetRecCountByCond_Cache(objgs_PaperAttention_Cond);
var returnInt: number = Number(responseText);
var strInfo: string = `根据条件:[${JSON.stringify(objgs_PaperAttention_Cond)}]的记录数:${returnInt}!`;
$('#lblResult6').val(strInfo);
//显示信息框
alert(strInfo);
}
catch(e)
{
var strMsg: string = `获取某一条件的记录数不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickAddNewRecord)
 /// </summary>
 /// <returns></returns>
public static async btnAddNewRecord_Click() {
$('#hidDivName').val("divAddNewRecord");
var objgs_PaperAttentionEN: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
objgs_PaperAttentionEN.PaperId = "11111111";
objgs_PaperAttentionEN.UserId = "11111111111111111111";
objgs_PaperAttentionEN.PaperGroupId = "11111111";
objgs_PaperAttentionEN.UpdUser = "11111111111111111111111111111111111111111111111111";
objgs_PaperAttentionEN.UpdDate = "11111111111111111111";
objgs_PaperAttentionEN.Meno = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
const responseText = await clsgs_PaperAttentionWApi.IsExistAsync(objgs_PaperAttentionEN.PaperAttentionId);
var bolIsExist: boolean = responseText;
if (bolIsExist == true)
{
var strMsg: string = `添加记录时，关键字：${objgs_PaperAttentionEN.PaperAttentionId }已经存在！`;
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const responseText2 = await clsgs_PaperAttentionWApi.AddNewRecordAsync(objgs_PaperAttentionEN);
var returnBool: boolean = !!responseText2;
if (returnBool == true)
{
var strInfo: string = `添加记录成功!`;
$('#lblResult7').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `添加记录不成功!`;
$('#lblResult7').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg: string = `添加记录不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickAddNewRecord4GetMaxStrId)
 /// </summary>
 /// <returns></returns>
public static async btnAddNewRecord4GetMaxStrId_Click() {
$('#hidDivName').val("divAddNewRecord4GetMaxStrId");
const responseText = await clsgs_PaperAttentionWApi.GetMaxStrIdAsync();
var returnString: string = responseText.toString();
var objgs_PaperAttentionEN: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
objgs_PaperAttentionEN.PaperId = "11111111";
objgs_PaperAttentionEN.UserId = "11111111111111111111";
objgs_PaperAttentionEN.PaperGroupId = "11111111";
objgs_PaperAttentionEN.UpdUser = "11111111111111111111111111111111111111111111111111";
objgs_PaperAttentionEN.UpdDate = "11111111111111111111";
objgs_PaperAttentionEN.Meno = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
const responseText = await clsgs_PaperAttentionWApi.AddNewRecordAsync(objgs_PaperAttentionEN);
var returnBool: boolean = responseText;
if (returnBool == true)
{
var strInfo: string = `添加记录成功!`;
$('#lblResult8').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `添加记录不成功!`;
$('#lblResult8').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg: string = `添加记录不成功, ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetMaxStrId)
 /// </summary>
 /// <returns></returns>
public static async btnGetMaxStrId_Click() {
$('#hidDivName').val("divGetMaxStrId");
try
{
const responseText = await clsgs_PaperAttentionWApi.GetMaxStrIdAsync();
var returnString: string = responseText.toString();
if (returnString == "")
{
var strInfo: string = `获取表gs_PaperAttention的最大关键字为空，不成功，请检查!`;
$('#lblResult9').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `获取表gs_PaperAttention的最大关键字为：${returnString}!`;
$('#lblResult9').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns></returns>
public static async btnGetMaxStrIdByPrefix_Click() {
$('#hidDivName').val("divGetMaxStrIdByPrefix");
var strPrefix: string = $('#txtstrPrefix10').val();
try
{
const responseText = await clsgs_PaperAttentionWApi.GetMaxStrIdByPrefixAsync(strPrefix);
var returnString: string = responseText.toString();
if (returnString == "")
{
var strInfo: string = `获取表gs_PaperAttention的最大关键字为空，不成功，请检查!`;
$('#lblResult10').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `获取表gs_PaperAttention的最大关键字为：${returnString}!`;
$('#lblResult10').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickUpdateRecord)
 /// </summary>
 /// <returns></returns>
public static async btnUpdateRecord_Click() {
$('#hidDivName').val("divUpdateRecord");
var objgs_PaperAttentionEN: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
objgs_PaperAttentionEN.PaperId = "11111111";
objgs_PaperAttentionEN.UserId = "11111111111111111111";
objgs_PaperAttentionEN.PaperGroupId = "11111111";
objgs_PaperAttentionEN.UpdUser = "11111111111111111111111111111111111111111111111111";
objgs_PaperAttentionEN.UpdDate = "11111111111111111111";
objgs_PaperAttentionEN.Meno = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objgs_PaperAttentionEN.sf_UpdFldSetStr = objgs_PaperAttentionEN.UpdFldString;//设置哪些字段被修改(脏字段)
try
{
const responseText = await clsgs_PaperAttentionWApi.UpdateRecordAsync(objgs_PaperAttentionEN);
var returnBool: boolean = responseText;
if (returnBool == true)
{
var strInfo: string = `修改记录成功!`;
$('#lblResult11').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `修改记录不成功!`;
$('#lblResult11').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg: string = `修改记录不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 删除记录
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickDelRecord)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnDelRecord_Click() {
$('#hidDivName').val("divDelRecord");
var strKeyId: string = $('#txtstrKeyId12').val();
var lngPaperAttentionId: number = Number(strKeyId);
try
{
const responseText = await clsgs_PaperAttentionWApi.DelRecordAsync(lngPaperAttentionId);
var returnInt: number = responseText;
if (returnInt > 0)
{
var strInfo: string = `删除记录成功, 共删除了${returnInt}条记录!`;
$('#lblResult12').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `删除记录不成功!`;
$('#lblResult12').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg: string = `删除记录不成功. ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickDelMultiRecord)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnDelgs_PaperAttentions_Click() {
$('#hidDivName').val("divDel[TabName]s");
var strKeyIdLst:string = $('#txtarrKeyId13').val();
var arrPaperAttentionId:Array<string> = strKeyIdLst.split(',');
try
{
const responseText = await clsgs_PaperAttentionWApi.Delgs_PaperAttentionsAsync(arrPaperAttentionId);
var returnInt: number = responseText;
if (returnInt > 0)
{
var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
$('#lblResult13').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `删除记录不成功!`;
$('#lblResult13').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg: string = `删除记录不成功. ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件删除多条记录
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickDelMultiRecordByCond)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnDelMultiRecordByCond_Click() {
$('#hidDivName').val("divDelMultiRecordByCond");
var strWhereCond: string = $('#txtstrWhereCond14').val();
try
{
const responseText = await clsgs_PaperAttentionWApi.Delgs_PaperAttentionsByCondAsync(strWhereCond);
var returnInt: number = responseText;
if (returnInt > 0)
{
var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
$('#lblResult14').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `删除记录不成功!`;
$('#lblResult14').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg: string = `删除记录不成功. ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的第一条记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetFirstObj)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnGetFirstObj_Click() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond: string = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsgs_PaperAttentionWApi.GetFirstObjAsync(strWhereCond);
var objgs_PaperAttentionEN: clsgs_PaperAttentionEN = <clsgs_PaperAttentionEN>responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo: string = `根据条件:[${strWhereCond}] 获取第一个记录对象：${objgs_PaperAttentionEN.PaperAttentionId }!`;
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.Showgs_PaperAttentionObj("divList15", objgs_PaperAttentionEN);
}
catch(e)
{
var strMsg: string = `根据条件获取相应的第一条记录的对象不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjByKey)
 /// </summary>
 /// <param name = "sender">参数列表</param>
 /// <returns></returns>
public static async btnGetObjByPaperAttentionId_Click() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId: string = $('#txtvarKeyId16').val();
var lngPaperAttentionId: number = Number(strKeyId);
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjByPaperAttentionIdAsync(lngPaperAttentionId);
var objgs_PaperAttentionEN: clsgs_PaperAttentionEN = <clsgs_PaperAttentionEN>responseText;
var strInfo: string = `根据关键字:[${strKeyId}]获取对象：${objgs_PaperAttentionEN.PaperAttentionId }!`;
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.Showgs_PaperAttentionObj("divList16", objgs_PaperAttentionEN);
}
catch(e)
{
var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjByKey_Cache)
 /// </summary>
 /// <param name = "sender">参数列表</param>
 /// <returns></returns>
public static async btnGetObjByPaperAttentionId_Cache_Click() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId: string = $('#txtvarKeyId17').val();
var lngPaperAttentionId: number = Number(strKeyId);
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjByPaperAttentionId_Cache(lngPaperAttentionId);
var objgs_PaperAttentionEN: clsgs_PaperAttentionEN = <clsgs_PaperAttentionEN>responseText;
var strInfo: string = `根据关键字:[${strKeyId}]获取对象：${objgs_PaperAttentionEN.PaperAttentionId }!`;
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.Showgs_PaperAttentionObj("divList17", objgs_PaperAttentionEN);
}
catch(e)
{
var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjByKey_WA_Cache)
 /// </summary>
 /// <param name = "sender">参数列表</param>
 /// <returns></returns>
public static async btnGetObjByPaperAttentionId_WA_Cache_Click() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId: string = $('#txtvarKeyId18').val();
var lngPaperAttentionId: number = Number(strKeyId);
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjByPaperAttentionId_WA_CacheAsync(lngPaperAttentionId);
var objgs_PaperAttentionEN: clsgs_PaperAttentionEN = <clsgs_PaperAttentionEN>responseText;
var strInfo: string = `根据关键字:[${strKeyId}]获取对象：${objgs_PaperAttentionEN.PaperAttentionId }!`;
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.Showgs_PaperAttentionObj("divList18", objgs_PaperAttentionEN);
}
catch(e)
{
var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLst)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnGetObjLst_Click() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond: string = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjLstAsync(strWhereCond);
var arrgs_PaperAttentionObjLst : Array<clsgs_PaperAttentionEN> = < Array<clsgs_PaperAttentionEN>>responseText;
var strInfo: string = `根据条件:[${strWhereCond}]共获取对象列表数：${arrgs_PaperAttentionObjLst.length}!`;
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_gs_PaperAttention("divList19", arrgs_PaperAttentionObjLst);
}
catch(e)
{
var strMsg: string = `根据条件获取相应的对象列表不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByKeyLst)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnGetObjLstByKeyLst_Click() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst:string = $('#txtarrKeyId20').val();
var arrPaperAttentionId:Array<string> = strKeyIdLst.split(',');
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjLstByPaperAttentionIdLstAsync(arrPaperAttentionId);
var arrgs_PaperAttentionObjLst : Array<clsgs_PaperAttentionEN> = < Array<clsgs_PaperAttentionEN>>responseText;
var strInfo: string = `根据关键字列表:[${strKeyIdLst}]共获取对象列表数：${arrgs_PaperAttentionObjLst.length}!`;
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_gs_PaperAttention("divList20", arrgs_PaperAttentionObjLst);
}
catch(e)
{
var strMsg: string = `根据关键字列表获取相应对象列表不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnGetObjLstByKeyLst_Cache_Click() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst:string = $('#txtarrKeyId21').val();
var arrPaperAttentionId2:Array<string> = strKeyIdLst.split(',');
var arrPaperAttentionId:Array<number> = arrPaperAttentionId2.map(x=>Number(x));
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjLstByPaperAttentionIdLst_Cache(arrPaperAttentionId);
var arrgs_PaperAttentionObjLst : Array<clsgs_PaperAttentionEN> = < Array<clsgs_PaperAttentionEN>>responseText;
var strInfo: string = `根据关键字列表:[${strKeyIdLst}]共获取对象列表数：${arrgs_PaperAttentionObjLst.length}!`;
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_gs_PaperAttention("divList21", arrgs_PaperAttentionObjLst);
}
catch(e)
{
var strMsg: string = `根据关键字列表获取相应对象列表不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnGetObjLstByKeyLst_WA_Cache_Click() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst:string = $('#txtarrKeyId22').val();
var arrPaperAttentionId:Array<string> = strKeyIdLst.split(',');
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjLstByPaperAttentionIdLst_WA_CacheAsync(arrPaperAttentionId);
var arrgs_PaperAttentionObjLst : Array<clsgs_PaperAttentionEN> = < Array<clsgs_PaperAttentionEN>>responseText;
var strInfo: string = `根据关键字列表:[${strKeyIdLst}]共获取对象列表数：${arrgs_PaperAttentionObjLst.length}!`;
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_gs_PaperAttention("divList22", arrgs_PaperAttentionObjLst);
}
catch(e)
{
var strMsg: string = `根据关键字列表获取相应对象列表不成功,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetSubObjLst_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnGetSubObjLst_Cache_Click() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond:Object = $('#txtobjTabName_Cond23').val();
var objgs_PaperAttention_Cond: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
var arrFldComparisonObj = WApigs_PaperAttention_UT_TS.GetLocalObjLst();
console.log(`字段比较对象记录数(本地获取)：${ arrFldComparisonObj.length}`);
arrFldComparisonObj.forEach(x => { objgs_PaperAttention_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttention_Cond);
console.log(objgs_PaperAttentionEN_Sim);
try
{
const responseText = await clsgs_PaperAttentionWApi.GetSubObjLst_Cache(objgs_PaperAttention_Cond);
var arrgs_PaperAttentionObjLst: Array<clsgs_PaperAttentionEN> = <Array<clsgs_PaperAttentionEN>>responseText;
var strInfo: string = `根据条件:[${JSON.stringify(objgs_PaperAttention_Cond)}],共获取对象列表子集数：${arrgs_PaperAttentionObjLst.length}!`;
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_gs_PaperAttention("divList23", arrgs_PaperAttentionObjLst);
}
catch(e)
{
var strMsg: string = `根据条件对象获取相应的对象列表子集不成功, ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetSubObjLst_WA_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnGetSubObjLst_WA_Cache_Click() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond:Object = $('#txtobjTabName_Cond24').val();
var objgs_PaperAttention_Cond: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
var arrFldComparisonObj = WApigs_PaperAttention_UT_TS.GetLocalObjLst();
console.log(`字段比较对象记录数(本地获取)：${ arrFldComparisonObj.length}`);
arrFldComparisonObj.forEach(x => { objgs_PaperAttention_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttention_Cond);
console.log(objgs_PaperAttentionEN_Sim);
try
{
const responseText = await clsgs_PaperAttentionWApi.GetSubObjLst_WA_CacheAsync(objgs_PaperAttention_Cond);
var arrgs_PaperAttentionObjLst: Array<clsgs_PaperAttentionEN> = <Array<clsgs_PaperAttentionEN>>responseText;
var strInfo: string = `根据条件:[${JSON.stringify(objgs_PaperAttention_Cond)}],共获取对象列表子集数：${arrgs_PaperAttentionObjLst.length}!`;
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_gs_PaperAttention("divList24", arrgs_PaperAttentionObjLst);
}
catch(e)
{
var strMsg: string = `根据条件对象获取相应的对象列表子集不成功, ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的顶部对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetTopObjLst)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnGetTopObjLst_Click() 
{
$('#hidDivName').val("divGetTopObjLst");
var intTopSize:number = Number($('#txtintTopSize25').val());
var strOrderBy: string = $('#txtstrOrderBy25').val();
var strWhereCond: string = $('#txtstrWhereCond25').val();
var objTopPara: stuTopPara =
{
WhereCond: strWhereCond,
TopSize: intTopSize,
OrderBy: "",
IsCheckSQLAttack: "false",
Exclude:""
}
try
{
const responseText = await clsgs_PaperAttentionWApi.GetTopObjLstAsync(objTopPara);
var arrgs_PaperAttentionObjLst : Array<clsgs_PaperAttentionEN> = <Array<clsgs_PaperAttentionEN>>responseText;
var strInfo: string = `根据条件:[${strWhereCond}],顶部数:[${intTopSize}]共获取顶部对象列表数：${arrgs_PaperAttentionObjLst.length}!`;
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_gs_PaperAttention("divList25", arrgs_PaperAttentionObjLst);
}
catch(e)
{
var strMsg: string = `根据条件获取相应的顶部对象列表不成功, ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByPager)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnGetObjLstByPager_Click() 
{
$('#hidDivName').val("divGetObjLstByPager");
var intPageIndex:number = Number($('#txtintPageIndex26').val());
var intPageSize:number = Number($('#txtintPageSize26').val());
var strOrderBy: string = $('#txtstrOrderBy26').val();
var strWhereCond: string = $('#txtstrWhereCond26').val();
var objPagerPara: stuPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjLstByPagerAsync(objPagerPara);
var arrgs_PaperAttentionObjLst: Array<clsgs_PaperAttentionEN> = <Array<clsgs_PaperAttentionEN>>responseText;
var strInfo: string = `根据条件:[${strWhereCond}],每页记录数:[${intPageSize}],第[${intPageIndex}]页,共获取分页对象列表数：${arrgs_PaperAttentionObjLst.length}!`;
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_gs_PaperAttention("divList26", arrgs_PaperAttentionObjLst);
}
catch(e)
{
var strMsg: string = `根据条件获取相应的分页对象列表不成功, ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnGetObjLstByPager_Cache_Click() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex:number = Number($('#txtintPageIndex27').val());
var intPageSize:number = Number($('#txtintPageSize27').val());
var strOrderBy: string = $('#txtstrOrderBy27').val();
var strWhereCond: string = $('#txtstrWhereCond27').val();
var objgs_PaperAttention_Cond: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
var arrFldComparisonObj = WApigs_PaperAttention_UT_TS.GetLocalObjLst();
console.log(`字段比较对象记录数(本地获取)：${ arrFldComparisonObj.length}`);
arrFldComparisonObj.forEach(x => { objgs_PaperAttention_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttention_Cond);
console.log(objgs_PaperAttentionEN_Sim);
strWhereCond = JSON.stringify(objgs_PaperAttentionEN_Sim);
var objPagerPara: stuPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjLstByPager_Cache(objPagerPara);
var arrgs_PaperAttentionObjLst: Array<clsgs_PaperAttentionEN> = <Array<clsgs_PaperAttentionEN>>responseText;
var strInfo: string = `根据条件:[${strWhereCond}],每页记录数:[${intPageSize}],第[${intPageIndex}]页,共获取分页对象列表数：${arrgs_PaperAttentionObjLst.length}!`;
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_gs_PaperAttention("divList27", arrgs_PaperAttentionObjLst);
}
catch(e)
{
var strMsg: string = `根据条件获取相应的分页对象列表不成功, ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByPager_WA_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnGetObjLstByPager_WA_Cache_Click() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex:number = Number($('#txtintPageIndex28').val());
var intPageSize:number = Number($('#txtintPageSize28').val());
var strOrderBy: string = $('#txtstrOrderBy28').val();
var strWhereCond: string = $('#txtstrWhereCond28').val();
var objgs_PaperAttention_Cond: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
var arrFldComparisonObj = WApigs_PaperAttention_UT_TS.GetLocalObjLst();
console.log(`字段比较对象记录数(本地获取)：${ arrFldComparisonObj.length}`);
arrFldComparisonObj.forEach(x => { objgs_PaperAttention_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttention_Cond);
console.log(objgs_PaperAttentionEN_Sim);
strWhereCond = JSON.stringify(objgs_PaperAttentionEN_Sim);
var objPagerPara: stuPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjLstByPager_WA_CacheAsync(objPagerPara);
var arrgs_PaperAttentionObjLst: Array<clsgs_PaperAttentionEN> = <Array<clsgs_PaperAttentionEN>>responseText;
var strInfo: string = `根据条件:[${strWhereCond}],每页记录数:[${intPageSize}],第[${intPageIndex}]页,共获取分页对象列表数：${arrgs_PaperAttentionObjLst.length}!`;
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_gs_PaperAttention("divList28", arrgs_PaperAttentionObjLst);
}
catch(e)
{
var strMsg: string = `根据条件获取相应的分页对象列表不成功, ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByRange)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
public static async btnGetObjLstByRange_Click() 
{
$('#hidDivName').val("divGetObjLstByRange");
var strOrderBy: string = $('#txtstrOrderBy29').val();
var intMaxNum:number = Number($('#txtintMaxNum29').val());
var intMinNum:number = Number($('#txtintMinNum29').val());
var strWhereCond: string = $('#txtstrWhereCond29').val();
var objRangePara: stuRangePara = {
  MaxNum: intMaxNum,
MinNum: intMinNum,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjLstByRangeAsync(objRangePara);
var arrgs_PaperAttentionObjLst : Array<clsgs_PaperAttentionEN> = <Array<clsgs_PaperAttentionEN>>responseText;
var strInfo: string = `根据条件:[${strWhereCond}],最小记录号:[${intMinNum}],最大记录号:[${intMaxNum}],共获取分页对象列表数：${arrgs_PaperAttentionObjLst.length}!`;
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_gs_PaperAttention("divList29", arrgs_PaperAttentionObjLst);
}
catch(e)
{
var strMsg: string = `根据条件获取范围内相应的对象列表不成功, ${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 显示gs_PaperAttention对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrgs_PaperAttentionObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
public static BindTab_gs_PaperAttention(divContainer: string, arrgs_PaperAttentionObjLst: Array<clsgs_PaperAttentionEN>) 
{
var o:HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
if (o == null)
{
alert(`${divContainer}不存在！`);
return;
}
var sstrFldName: Array < string > = new Array<string>();
var sstrColHeader: Array < string > = new Array<string>();
sstrFldName.push("PaperAttentionId"); sstrColHeader.push("论文收藏Id");
sstrFldName.push("PaperId"); sstrColHeader.push("论文Id");
sstrFldName.push("UserId"); sstrColHeader.push("用户ID");
sstrFldName.push("PaperGroupId"); sstrColHeader.push("组Id");
sstrFldName.push("UpdUser"); sstrColHeader.push("修改人");
sstrFldName.push("UpdDate"); sstrColHeader.push("修改日期");
sstrFldName.push("Meno"); sstrColHeader.push("备注");
clsCommonFunc4Web.BindTab(o, arrgs_PaperAttentionObjLst, sstrFldName, sstrColHeader, "PaperAttentionId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objgs_PaperAttention">需要显示的对象</param>
 /// <returns></returns>
public static Showgs_PaperAttentionObj(divContainer: string, objgs_PaperAttention: clsgs_PaperAttentionEN) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(`${divContainer}不存在！`);
return;
}
var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_PaperAttention);
var ul: HTMLUListElement = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objgs_PaperAttention[strKey];
var li: HTMLLIElement = document.createElement("li");
li.innerHTML = `${ strKey}:${ strValue}`;
ul.appendChild(li);
}
o.appendChild(ul);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_FldComparison)
 /// </summary>
 /// <returns></returns>
public static AddDPV_FldComparison(divName4Edit: string) {
var objLst = document.getElementsByTagName("div");
var strStartName: string = "divEditFldComparison";
let arrElement: Array < HTMLElement > = WApigs_PaperAttention_UT_TS.GetArray(objLst) as Array<HTMLElement>;
let arrDiv: Array < HTMLDivElement > = arrElement as Array<HTMLDivElement>;
let arrFind: Array < HTMLDivElement > = arrDiv.filter(x => x.id.indexOf(strStartName) > -1);
arrFind.forEach(x => x.innerHTML = "");
//var o: HTMLDivElement = document.getElementById("div") as HTMLDivElement;
var strUrl: string = "../Test/_FldComparison/";
console.log("divName4Edit:(In AddDPV_FldComparison)" + divName4Edit);
$.ajax({
url: strUrl,
method: "GET",
dataType: "html",
data: { },
success: function(data) {
console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
$('#' + divName4Edit).html(data);
//setTimeout(() => { clsFldComparisonObj.BindTab(); }, 100);
clsFldComparisonObj.BindTab();
},
error: (e) => {
console.error(e);
}
});
};

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFldNameLst)
 /// </summary>
 /// <returns></returns>
public static GetFldNameLst(func: (strKey: string) => any) {
var arrFldName: Array<string> = clsgs_PaperAttentionEN.AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   public static GetLocalObjLst(): Array < clsFldComparisonObj > {
var strFldComparisonObjLst = $("#hidFldComparisonObjLst").val();
if (strFldComparisonObjLst == null || strFldComparisonObjLst == "")
{
return new Array<clsFldComparisonObj>();
}
var arrFldComparisonObj: Array < clsFldComparisonObj > = JSON.parse(strFldComparisonObjLst);
return arrFldComparisonObj;
};

 /// <summary>
 /// 建立缓存
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_CreateCache)
 /// </summary>
 /// <returns></returns>
public static async CreateCache() 
{
var strKey:string = "";
try
{
console.log("开始获取缓存：gs_PaperAttention");
strKey = clsgs_PaperAttentionEN._CurrTabName;
const responseText = await clsgs_PaperAttentionWApi.GetObjLst_Cache();
console.log("获取缓存完成！gs_PaperAttention");
var arrgs_PaperAttentionObjLst: Array < clsgs_PaperAttentionEN > = CacheHelper.Get(strKey);
if (arrgs_PaperAttentionObjLst != null)
{
var strInfo: string = `建立缓存Key=[${strKey}]完成: 共获取对象列表数：${ arrgs_PaperAttentionObjLst.length }!`;
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo: string = `建立缓存Key=[${strKey}]不成功!`;
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WApigs_PaperAttention_UT_TS: CreateCache()不成功！");
console.error(e);
var strInfo: string = `建立缓存Key=[${strKey}]失败:${e}!`;
console.log(strInfo);
$('#lblPageStatusContent').html(strInfo);
}  
}

 /// <summary>
 /// 把Html控件集合转换成Array列表
 /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_GetArray)
 /// </summary>
 /// <returns></returns>
public static GetArray(arr): Array < HTMLElement > {
let arrLst: Array < HTMLElement > = new Array<HTMLElement>();
for (var i = 0; i < arr.length; i++)
{
var chk: HTMLElement = arr[i];// as HTMLElement;
arrLst.push(chk);
}
return arrLst;
};
}