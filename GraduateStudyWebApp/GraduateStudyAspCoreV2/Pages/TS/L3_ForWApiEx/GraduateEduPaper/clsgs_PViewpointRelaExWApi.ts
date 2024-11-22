﻿
 /**
 * 类名:clsgs_PViewpointRelaExWApi
 * 表名:gs_PViewpointRela(01120674)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/05 01:04:03
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_访问扩展层(TS)(WA_AccessEx)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

 /**
 * 论文观点关系表(gs_PViewpointRela)
 * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
* Created by pyf on 2022年11月05日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
//import $ from "jquery";
import { ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsgs_PViewpointRelaENEx } from "../../L0_Entity/GraduateEduPaper/clsgs_PViewpointRelaENEx.js";
import { gs_PViewpointRela_GetObjLstAsync } from "../../L3_ForWApi/GraduateEduPaper/clsgs_PViewpointRelaWApi.js";
import { GetSortExpressInfo } from "../../PubFun/clsCommFunc4Web.js";
import { IsNullOrEmpty } from "../../PubFun/clsString.js";
import { gs_PViewpointRela_SortFunByKey } from "../../L3_ForWApi/GraduateEduPaper/clsgs_PViewpointRelaWApi.js";
import { clsgs_PViewpointRelaEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PViewpointRelaEN.js";
import { Format } from "../../PubFun/clsString.js";
import { gs_PViewpointRela_FilterFunByKey } from "../../L3_ForWApi/GraduateEduPaper/clsgs_PViewpointRelaWApi.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
export const gs_PViewpointRelaEx_Controller = "gs_PViewpointRelaExApi";
export const gs_PViewpointRelaEx_ConstructorName = "gs_PViewpointRelaEx";

 /**
 * 获取WebApi的地址
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
 **/
export function gs_PViewpointRelaEx_GetWebApiUrl(strController: string, strAction: string): string {
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
 * @param objgs_PViewpointRelaENS:源对象
 * @returns 目标对象=>clsgs_PViewpointRelaEN:objgs_PViewpointRelaENT
 **/
export function gs_PViewpointRelaEx_CopyToEx(objgs_PViewpointRelaENS:clsgs_PViewpointRelaEN ): clsgs_PViewpointRelaENEx
{
const strThisFuncName  = gs_PViewpointRelaEx_CopyToEx.name;
 const objgs_PViewpointRelaENT = new clsgs_PViewpointRelaENEx();
try
{
ObjectAssign(objgs_PViewpointRelaENT, objgs_PViewpointRelaENS);
 return objgs_PViewpointRelaENT;
}
catch (e)
{
const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, gs_PViewpointRelaEx_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
 return objgs_PViewpointRelaENT;
}
}
//该表在前台TypeScript中，不需要使用Cache;

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function gs_PViewpointRelaEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara):Promise<Array<clsgs_PViewpointRelaENEx>> {
const strThisFuncName = "GetObjExLstByPagerAsync";
const arrgs_PViewpointRelaObjLst = await gs_PViewpointRela_GetObjLstAsync(objPagerPara.whereCond);
const arrgs_PViewpointRelaExObjLst = arrgs_PViewpointRelaObjLst.map(gs_PViewpointRelaEx_CopyToEx);
 const objSortInfo = GetSortExpressInfo(objPagerPara);
 if (IsNullOrEmpty(objSortInfo.SortFld) == false)
 {
 for (const objInFor of arrgs_PViewpointRelaExObjLst) {
 const conFuncMap = await gs_PViewpointRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
 }
 }
if (arrgs_PViewpointRelaExObjLst.length == 0) return arrgs_PViewpointRelaExObjLst;
let arrgs_PViewpointRela_Sel: Array < clsgs_PViewpointRelaENEx > = arrgs_PViewpointRelaExObjLst;
try {
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_PViewpointRela_Sel = arrgs_PViewpointRela_Sel.sort(gs_PViewpointRelaEx_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_PViewpointRela_Sel = arrgs_PViewpointRela_Sel.sort(objPagerPara.sortFun);
}
arrgs_PViewpointRela_Sel = arrgs_PViewpointRela_Sel.slice(intStart, intEnd);     
return arrgs_PViewpointRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_PViewpointRelaEx_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_PViewpointRelaENEx>();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-05
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function gs_PViewpointRelaEx_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
        default:
return gs_PViewpointRela_SortFunByKey(strKey, AscOrDesc);
 }
 }
  else
 {
switch (strKey)
{
        default:
return gs_PViewpointRela_SortFunByKey(strKey, AscOrDesc);
 }
 }
}

/**
 * 根据扩展字段名去调用相应的映射函数
 * 作者:pyf
 * 日期:2022-11-05
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
 * @param strFldName:扩展字段名
 * @param  obj{0}Ex:需要转换的对象
 * @returns 针对扩展字段名对转换对象进行函数映射
*/
export function gs_PViewpointRelaEx_FuncMapByFldName(strFldName: string, objgs_PViewpointRelaEx: clsgs_PViewpointRelaENEx)
{
const strThisFuncName = gs_PViewpointRelaEx_FuncMapByFldName.name;
let strMsg = "";
//如果是本表中字段，不需要映射
const arrFldName = clsgs_PViewpointRelaEN.AttributeName;
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
 * 日期:2022-11-05
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function gs_PViewpointRelaEx_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
        default:
return gs_PViewpointRela_FilterFunByKey(strKey, value);
 }
}