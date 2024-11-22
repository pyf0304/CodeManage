﻿
 /**
 * 类名:clsViewpointLikeLogExWApi
 * 表名:ViewpointLikeLog(01120601)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:48
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:WA_访问扩展层(TS)(WA_AccessEx)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

 /**
 * 观点点赞表(ViewpointLikeLog)
 * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
//import $ from "jquery";
import { ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsViewpointLikeLogENEx } from "../../L0_Entity/GraduateEduTopic/clsViewpointLikeLogENEx.js";
import { ViewpointLikeLog_FilterFunByKey, ViewpointLikeLog_GetObjLstAsync } from "../../L3_ForWApi/GraduateEduTopic/clsViewpointLikeLogWApi.js";
import { GetSortExpressInfo } from "../../PubFun/clsCommFunc4Web.js";
import { IsNullOrEmpty } from "../../PubFun/clsString.js";
import { ViewpointLikeLog_SortFunByKey } from "../../L3_ForWApi/GraduateEduTopic/clsViewpointLikeLogWApi.js";
import { clsViewpointLikeLogEN } from "../../L0_Entity/GraduateEduTopic/clsViewpointLikeLogEN.js";
import { Format } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
export const viewpointLikeLogEx_Controller = "ViewpointLikeLogExApi";
export const viewpointLikeLogEx_ConstructorName = "viewpointLikeLogEx";

 /**
 * 获取WebApi的地址
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
 **/
export function ViewpointLikeLogEx_GetWebApiUrl(strController: string, strAction: string): string {
const strThisFuncName = "GetWebApiUrl";
let strServiceUrl:string;
let strCurrIPAddressAndPort = "";
if (clsSysPara4WebApi.bolIsLocalHost == false)
{
strCurrIPAddressAndPort = clsSysPara4WebApi.CurrIPAddressAndPort;
}
else
{
strCurrIPAddressAndPort = clsSysPara4WebApi.CurrIPAddressAndPort_Local;
}
if (IsNullOrEmpty(clsSysPara4WebApi.CurrPrx) == true)
{
strServiceUrl = Format("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
}
else
{
strServiceUrl = Format("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi.CurrPrx, strController, strAction);
}
return strServiceUrl;
}

 /**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
 * @param objViewpointLikeLogENS:源对象
 * @returns 目标对象=>clsViewpointLikeLogEN:objViewpointLikeLogENT
 **/
export function ViewpointLikeLogEx_CopyToEx(objViewpointLikeLogENS:clsViewpointLikeLogEN ): clsViewpointLikeLogENEx
{
const strThisFuncName  = ViewpointLikeLogEx_CopyToEx.name;
 const objViewpointLikeLogENT = new clsViewpointLikeLogENEx();
try
{
ObjectAssign(objViewpointLikeLogENT, objViewpointLikeLogENS);
 return objViewpointLikeLogENT;
}
catch (e)
{
const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, viewpointLikeLogEx_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
 return objViewpointLikeLogENT;
}
}
//该表在前台TypeScript中，不需要使用Cache;

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function ViewpointLikeLogEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara):Promise<Array<clsViewpointLikeLogENEx>> {
const strThisFuncName = "GetObjExLstByPagerAsync";
const arrViewpointLikeLogExObjLst = await ViewpointLikeLog_GetObjLstAsync(objPagerPara.whereCond);
 const objSortInfo = GetSortExpressInfo(objPagerPara);
 if (IsNullOrEmpty(objSortInfo.SortFld) == false)
 {
 for (const objInFor of arrViewpointLikeLogExObjLst) {
 const conFuncMap = await ViewpointLikeLogEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
 }
 }
if (arrViewpointLikeLogExObjLst.length == 0) return arrViewpointLikeLogExObjLst;
let arrViewpointLikeLog_Sel: Array < clsViewpointLikeLogENEx > = arrViewpointLikeLogExObjLst;
try {
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrViewpointLikeLog_Sel = arrViewpointLikeLog_Sel.sort(ViewpointLikeLogEx_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrViewpointLikeLog_Sel = arrViewpointLikeLog_Sel.sort(objPagerPara.sortFun);
}
arrViewpointLikeLog_Sel = arrViewpointLikeLog_Sel.slice(intStart, intEnd);     
return arrViewpointLikeLog_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, viewpointLikeLogEx_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsViewpointLikeLogENEx>();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function ViewpointLikeLogEx_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
        default:
return ViewpointLikeLog_SortFunByKey(strKey, AscOrDesc);
 }
 }
  else
 {
switch (strKey)
{
        default:
return ViewpointLikeLog_SortFunByKey(strKey, AscOrDesc);
 }
 }
}

/**
 * 根据扩展字段名去调用相应的映射函数
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
 * @param strFldName:扩展字段名
 * @param  obj{0}Ex:需要转换的对象
 * @returns 针对扩展字段名对转换对象进行函数映射
*/
export function ViewpointLikeLogEx_FuncMapByFldName(strFldName: string, objViewpointLikeLogEx: clsViewpointLikeLogENEx)
{
const strThisFuncName = ViewpointLikeLogEx_FuncMapByFldName.name;
let strMsg = "";
//如果是本表中字段，不需要映射
const arrFldName = clsViewpointLikeLogEN.AttributeName;
if (arrFldName.indexOf(strFldName) > -1) return;
//针对扩展字段进行映射
switch (strFldName)
{
        default:
    strMsg = Format("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
console.error(strMsg);
 }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function ViewpointLikeLogEx_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
        default:
return ViewpointLikeLog_FilterFunByKey(strKey, value);
 }
}
