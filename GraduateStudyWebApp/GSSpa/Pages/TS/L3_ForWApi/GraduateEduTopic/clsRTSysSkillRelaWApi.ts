
 /**
 * 类名:clsRTSysSkillRelaWApi
 * 表名:RTSysSkillRela(01120658)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:55
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * RTSysSkillRela(RTSysSkillRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsRTSysSkillRelaEN } from "../../L0_Entity/GraduateEduTopic/clsRTSysSkillRelaEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const rTSysSkillRela_Controller = "RTSysSkillRelaApi";
 export const rTSysSkillRela_ConstructorName = "rTSysSkillRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function RTSysSkillRela_GetObjBymIdAsync(lngmId: number): Promise<clsRTSysSkillRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngmId": lngmId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objRTSysSkillRela = RTSysSkillRela_GetObjFromJsonObj(returnObj);
return objRTSysSkillRela;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function RTSysSkillRela_SortFun_Defa(a:clsRTSysSkillRelaEN , b:clsRTSysSkillRelaEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
}
/**
 * 排序函数。根据表对象中随机两个字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param  a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function RTSysSkillRela_SortFun_Defa_2Fld(a:clsRTSysSkillRelaEN , b:clsRTSysSkillRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.skillId.localeCompare(b.skillId);
else return a.topicId.localeCompare(b.topicId);
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function RTSysSkillRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsRTSysSkillRelaEN.con_mId:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return a.mId-b.mId;
}
case clsRTSysSkillRelaEN.con_TopicId:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsRTSysSkillRelaEN.con_SkillId:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return a.skillId.localeCompare(b.skillId);
}
case clsRTSysSkillRelaEN.con_UpdDate:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsRTSysSkillRelaEN.con_UpdUser:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsRTSysSkillRelaEN.con_Memo:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return a.memo.localeCompare(b.memo);
}
case clsRTSysSkillRelaEN.con_ClassificationId:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return a.classificationId.localeCompare(b.classificationId);
}
case clsRTSysSkillRelaEN.con_id_CurrEduCls:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTSysSkillRela]中不存在！(in ${ rTSysSkillRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsRTSysSkillRelaEN.con_mId:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return b.mId-a.mId;
}
case clsRTSysSkillRelaEN.con_TopicId:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsRTSysSkillRelaEN.con_SkillId:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return b.skillId.localeCompare(a.skillId);
}
case clsRTSysSkillRelaEN.con_UpdDate:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsRTSysSkillRelaEN.con_UpdUser:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsRTSysSkillRelaEN.con_Memo:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return b.memo.localeCompare(a.memo);
}
case clsRTSysSkillRelaEN.con_ClassificationId:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return b.classificationId.localeCompare(a.classificationId);
}
case clsRTSysSkillRelaEN.con_id_CurrEduCls:
return (a: clsRTSysSkillRelaEN, b: clsRTSysSkillRelaEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTSysSkillRela]中不存在！(in ${ rTSysSkillRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function RTSysSkillRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsRTSysSkillRelaEN.con_mId:
return (obj: clsRTSysSkillRelaEN) => {
return obj.mId === value;
}
case clsRTSysSkillRelaEN.con_TopicId:
return (obj: clsRTSysSkillRelaEN) => {
return obj.topicId === value;
}
case clsRTSysSkillRelaEN.con_SkillId:
return (obj: clsRTSysSkillRelaEN) => {
return obj.skillId === value;
}
case clsRTSysSkillRelaEN.con_UpdDate:
return (obj: clsRTSysSkillRelaEN) => {
return obj.updDate === value;
}
case clsRTSysSkillRelaEN.con_UpdUser:
return (obj: clsRTSysSkillRelaEN) => {
return obj.updUser === value;
}
case clsRTSysSkillRelaEN.con_Memo:
return (obj: clsRTSysSkillRelaEN) => {
return obj.memo === value;
}
case clsRTSysSkillRelaEN.con_ClassificationId:
return (obj: clsRTSysSkillRelaEN) => {
return obj.classificationId === value;
}
case clsRTSysSkillRelaEN.con_id_CurrEduCls:
return (obj: clsRTSysSkillRelaEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTSysSkillRela]中不存在！(in ${ rTSysSkillRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function RTSysSkillRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
if (data.errorId == 0)
{
return data.returnStr;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
 * @param strWhereCond:条件
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回的第一条记录的关键字值
*/
export async function RTSysSkillRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
cb(data);
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 根据条件获取满足条件的第一条记录对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
 * @param strWhereCond:条件
 * @returns 第一条记录对象
 **/
export async function RTSysSkillRela_GetFirstObjAsync(strWhereCond: string): Promise<clsRTSysSkillRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objRTSysSkillRela = RTSysSkillRela_GetObjFromJsonObj(returnObj);
return objRTSysSkillRela;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function RTSysSkillRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsRTSysSkillRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTSysSkillRela_GetObjLstByJSONObjLst(returnObjLst);
return (arrObjLst);
}
else
{
console.error(data.errorMsg);
throw (data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function RTSysSkillRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsRTSysSkillRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTSysSkillRela_GetObjLstByJSONObjLst(returnObjLst);
return arrObjLst;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function RTSysSkillRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsRTSysSkillRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTSysSkillRela_GetObjLstByJSONObjLst(returnObjLst);
return (arrObjLst);
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 根据范围条件获取相应的记录对象列表，获取某范围的记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
 * @param objRangePara:根据范围获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function RTSysSkillRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsRTSysSkillRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTSysSkillRela_GetObjLstByJSONObjLst(returnObjLst);
return arrObjLst;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRange)
 * @param intMinNum:最小记录号
 * @param intMaxNum:最大记录号
 * @param strWhereCond:给定条件
 * @param strOrderBy:排序方式
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取的相应记录对象列表
*/
export async function RTSysSkillRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"intMinNum": intMinNum,
"intMaxNum": intMaxNum,
"strWhereCond": strWhereCond,
"strOrderBy": strOrderBy,
}
});
const data = response.data;
cb(data);
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function RTSysSkillRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsRTSysSkillRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTSysSkillRela_GetObjLstByJSONObjLst(returnObjLst);
return arrObjLst;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 调用WebApi来删除记录，根据关键字来删除记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
 * @param lngmId:关键字
 * @returns 获取删除的结果
 **/
export async function RTSysSkillRela_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngmId, }
});
const data = response.data;
if (data.errorId == 0)
{
return data.returnInt;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 根据关键字列表删除记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
 * @param arrmId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function RTSysSkillRela_DelRTSysSkillRelasAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelRTSysSkillRelasAsync";
const strAction = "DelRTSysSkillRelas";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
return data.returnInt;
}
else
{
console.error(data.errorMsg);
throw data.errorMsg;
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 根据条件删除记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
 * @returns 实际删除记录的个数
 **/
export async function RTSysSkillRela_DelRTSysSkillRelasByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelRTSysSkillRelasByCondAsync";
const strAction = "DelRTSysSkillRelasByCond";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
if (data.errorId == 0)
{
return data.returnInt;
}
else
{
console.error(data.errorMsg);
throw (data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 调用WebApi来添加记录，数据传递使用JSON串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
 * @param objRTSysSkillRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function RTSysSkillRela_AddNewRecordAsync(objRTSysSkillRelaEN: clsRTSysSkillRelaEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objRTSysSkillRelaEN);
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTSysSkillRelaEN);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
/* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/

 /**
 * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
 * @param objRTSysSkillRelaEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function RTSysSkillRela_AddNewRecordWithReturnKeyAsync(objRTSysSkillRelaEN: clsRTSysSkillRelaEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTSysSkillRelaEN);
const data = response.data;
if (data.errorId == 0)
{
return data.returnStr;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
 * @param objRTSysSkillRelaEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function RTSysSkillRela_AddNewRecordWithReturnKey(objRTSysSkillRelaEN: clsRTSysSkillRelaEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objRTSysSkillRelaEN.mId === null || objRTSysSkillRelaEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTSysSkillRelaEN);
const data = response.data;
cb(data);
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 调用WebApi来修改记录，数据传递使用JSON串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
 * @param objRTSysSkillRelaEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function RTSysSkillRela_UpdateRecordAsync(objRTSysSkillRelaEN: clsRTSysSkillRelaEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objRTSysSkillRelaEN.sf_UpdFldSetStr === undefined || objRTSysSkillRelaEN.sf_UpdFldSetStr === null || objRTSysSkillRelaEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTSysSkillRelaEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTSysSkillRelaEN);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 根据条件来修改记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
 * @param objRTSysSkillRelaEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function RTSysSkillRela_UpdateWithConditionAsync(objRTSysSkillRelaEN: clsRTSysSkillRelaEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objRTSysSkillRelaEN.sf_UpdFldSetStr === undefined || objRTSysSkillRelaEN.sf_UpdFldSetStr === null || objRTSysSkillRelaEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTSysSkillRelaEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
objRTSysSkillRelaEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objRTSysSkillRelaEN);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据条件获取是否存在相应的记录？
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
 * @param strWhereCond:条件
 * @returns 是否存在记录？
 **/
export async function RTSysSkillRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
 * @param lngmId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function RTSysSkillRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"mId": lngmId,
}
});
const data = response.data;
cb(data);
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngmId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function RTSysSkillRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngmId": lngmId }
});
const data = response.data;
if (data.errorId == 0)
{
return (data.returnBool);
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 获取某一条件的记录数
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
 * @param strWhereCond:条件
 * @returns 获取某一条件的记录数
 **/
export async function RTSysSkillRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
if (data.errorId == 0)
{
return data.returnInt;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;
/*该表的关键字类型不是字符型自增，不需要生成获取最大关键字函数！*/
/*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/

/**
 * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
 * @param mapParam:参数列表
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取当前表关键字值的最大值
*/
export async function RTSysSkillRela_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(rTSysSkillRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strPrefix": strPrefix}
});
const data = response.data;
cb(data);
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTSysSkillRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 获取WebApi的地址
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
*/
export function RTSysSkillRela_GetWebApiUrl(strController: string, strAction: string): string {
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
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function RTSysSkillRela_CheckPropertyNew(pobjRTSysSkillRelaEN: clsRTSysSkillRelaEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.skillId) === true )
{
 throw new Error("(errid:Watl000058)字段[技能Id]不能为空(In RTSysSkillRela)!(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.topicId) == false && GetStrLen(pobjRTSysSkillRelaEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.topicId)(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.skillId) == false && GetStrLen(pobjRTSysSkillRelaEN.skillId) > 10)
{
 throw new Error("(errid:Watl000059)字段[技能Id(skillId)]的长度不能超过10(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.skillId)(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.updDate) == false && GetStrLen(pobjRTSysSkillRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.updDate)(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.updUser) == false && GetStrLen(pobjRTSysSkillRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.updUser)(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.memo) == false && GetStrLen(pobjRTSysSkillRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.memo)(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.classificationId) == false && GetStrLen(pobjRTSysSkillRelaEN.classificationId) > 10)
{
 throw new Error("(errid:Watl000059)字段[分类Id(classificationId)]的长度不能超过10(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.classificationId)(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.id_CurrEduCls) == false && GetStrLen(pobjRTSysSkillRelaEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.id_CurrEduCls)(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjRTSysSkillRelaEN.mId && undefined !== pobjRTSysSkillRelaEN.mId && tzDataType.isNumber(pobjRTSysSkillRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjRTSysSkillRelaEN.mId)], 非法，应该为数值型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.topicId) == false && undefined !== pobjRTSysSkillRelaEN.topicId && tzDataType.isString(pobjRTSysSkillRelaEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjRTSysSkillRelaEN.topicId)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.skillId) == false && undefined !== pobjRTSysSkillRelaEN.skillId && tzDataType.isString(pobjRTSysSkillRelaEN.skillId) === false)
{
 throw new Error("(errid:Watl000060)字段[技能Id(skillId)]的值:[$(pobjRTSysSkillRelaEN.skillId)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.updDate) == false && undefined !== pobjRTSysSkillRelaEN.updDate && tzDataType.isString(pobjRTSysSkillRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjRTSysSkillRelaEN.updDate)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.updUser) == false && undefined !== pobjRTSysSkillRelaEN.updUser && tzDataType.isString(pobjRTSysSkillRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjRTSysSkillRelaEN.updUser)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.memo) == false && undefined !== pobjRTSysSkillRelaEN.memo && tzDataType.isString(pobjRTSysSkillRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRTSysSkillRelaEN.memo)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.classificationId) == false && undefined !== pobjRTSysSkillRelaEN.classificationId && tzDataType.isString(pobjRTSysSkillRelaEN.classificationId) === false)
{
 throw new Error("(errid:Watl000060)字段[分类Id(classificationId)]的值:[$(pobjRTSysSkillRelaEN.classificationId)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.id_CurrEduCls) == false && undefined !== pobjRTSysSkillRelaEN.id_CurrEduCls && tzDataType.isString(pobjRTSysSkillRelaEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTSysSkillRelaEN.id_CurrEduCls)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjRTSysSkillRelaEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function RTSysSkillRela_CheckProperty4Update (pobjRTSysSkillRelaEN: clsRTSysSkillRelaEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.topicId) == false && GetStrLen(pobjRTSysSkillRelaEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.topicId)(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.skillId) == false && GetStrLen(pobjRTSysSkillRelaEN.skillId) > 10)
{
 throw new Error("(errid:Watl000062)字段[技能Id(skillId)]的长度不能超过10(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.skillId)(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.updDate) == false && GetStrLen(pobjRTSysSkillRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.updDate)(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.updUser) == false && GetStrLen(pobjRTSysSkillRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.updUser)(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.memo) == false && GetStrLen(pobjRTSysSkillRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.memo)(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.classificationId) == false && GetStrLen(pobjRTSysSkillRelaEN.classificationId) > 10)
{
 throw new Error("(errid:Watl000062)字段[分类Id(classificationId)]的长度不能超过10(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.classificationId)(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.id_CurrEduCls) == false && GetStrLen(pobjRTSysSkillRelaEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In RTSysSkillRela(RTSysSkillRela))!值:$(pobjRTSysSkillRelaEN.id_CurrEduCls)(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjRTSysSkillRelaEN.mId && undefined !== pobjRTSysSkillRelaEN.mId && tzDataType.isNumber(pobjRTSysSkillRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjRTSysSkillRelaEN.mId)], 非法，应该为数值型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.topicId) == false && undefined !== pobjRTSysSkillRelaEN.topicId && tzDataType.isString(pobjRTSysSkillRelaEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjRTSysSkillRelaEN.topicId)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.skillId) == false && undefined !== pobjRTSysSkillRelaEN.skillId && tzDataType.isString(pobjRTSysSkillRelaEN.skillId) === false)
{
 throw new Error("(errid:Watl000063)字段[技能Id(skillId)]的值:[$(pobjRTSysSkillRelaEN.skillId)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.updDate) == false && undefined !== pobjRTSysSkillRelaEN.updDate && tzDataType.isString(pobjRTSysSkillRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjRTSysSkillRelaEN.updDate)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.updUser) == false && undefined !== pobjRTSysSkillRelaEN.updUser && tzDataType.isString(pobjRTSysSkillRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjRTSysSkillRelaEN.updUser)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.memo) == false && undefined !== pobjRTSysSkillRelaEN.memo && tzDataType.isString(pobjRTSysSkillRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRTSysSkillRelaEN.memo)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.classificationId) == false && undefined !== pobjRTSysSkillRelaEN.classificationId && tzDataType.isString(pobjRTSysSkillRelaEN.classificationId) === false)
{
 throw new Error("(errid:Watl000063)字段[分类Id(classificationId)]的值:[$(pobjRTSysSkillRelaEN.classificationId)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTSysSkillRelaEN.id_CurrEduCls) == false && undefined !== pobjRTSysSkillRelaEN.id_CurrEduCls && tzDataType.isString(pobjRTSysSkillRelaEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTSysSkillRelaEN.id_CurrEduCls)], 非法，应该为字符型(In RTSysSkillRela(RTSysSkillRela))!(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjRTSysSkillRelaEN.mId 
 || pobjRTSysSkillRelaEN.mId != null && pobjRTSysSkillRelaEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In RTSysSkillRela)!(clsRTSysSkillRelaBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjRTSysSkillRelaEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function RTSysSkillRela_GetJSONStrByObj (pobjRTSysSkillRelaEN: clsRTSysSkillRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjRTSysSkillRelaEN.sf_UpdFldSetStr = pobjRTSysSkillRelaEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjRTSysSkillRelaEN);
}
catch(objException)
{
const strEx = GetExceptionStr(objException);
myShowErrorMsg(strEx);
}
if (strJson == undefined) return "";
else return strJson;
}

/**
 * 把一个JSON串转化为一个对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象列表
*/
export function RTSysSkillRela_GetObjLstByJSONStr (strJSON: string): Array<clsRTSysSkillRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrRTSysSkillRelaObjLst = new Array<clsRTSysSkillRelaEN>();
if (strJSON === "")
{
return arrRTSysSkillRelaObjLst;
}
try
{
arrRTSysSkillRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrRTSysSkillRelaObjLst;
}
return arrRTSysSkillRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrRTSysSkillRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function RTSysSkillRela_GetObjLstByJSONObjLst (arrRTSysSkillRelaObjLstS: Array<clsRTSysSkillRelaEN>): Array<clsRTSysSkillRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrRTSysSkillRelaObjLst = new Array<clsRTSysSkillRelaEN>();
for (const objInFor of arrRTSysSkillRelaObjLstS) {
const obj1 = RTSysSkillRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrRTSysSkillRelaObjLst.push(obj1);
}
return arrRTSysSkillRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function RTSysSkillRela_GetObjByJSONStr (strJSON: string): clsRTSysSkillRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjRTSysSkillRelaEN = new clsRTSysSkillRelaEN();
if (strJSON === "")
{
return pobjRTSysSkillRelaEN;
}
try
{
pobjRTSysSkillRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjRTSysSkillRelaEN;
}
return pobjRTSysSkillRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function RTSysSkillRela_GetCombineCondition(objRTSysSkillRela_Cond: clsRTSysSkillRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objRTSysSkillRela_Cond.dicFldComparisonOp, clsRTSysSkillRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objRTSysSkillRela_Cond.dicFldComparisonOp[clsRTSysSkillRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsRTSysSkillRelaEN.con_mId, objRTSysSkillRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objRTSysSkillRela_Cond.dicFldComparisonOp, clsRTSysSkillRelaEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objRTSysSkillRela_Cond.dicFldComparisonOp[clsRTSysSkillRelaEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTSysSkillRelaEN.con_TopicId, objRTSysSkillRela_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objRTSysSkillRela_Cond.dicFldComparisonOp, clsRTSysSkillRelaEN.con_SkillId) == true)
{
const strComparisonOp_SkillId:string = objRTSysSkillRela_Cond.dicFldComparisonOp[clsRTSysSkillRelaEN.con_SkillId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTSysSkillRelaEN.con_SkillId, objRTSysSkillRela_Cond.skillId, strComparisonOp_SkillId);
}
if (Object.prototype.hasOwnProperty.call(objRTSysSkillRela_Cond.dicFldComparisonOp, clsRTSysSkillRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objRTSysSkillRela_Cond.dicFldComparisonOp[clsRTSysSkillRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTSysSkillRelaEN.con_UpdDate, objRTSysSkillRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objRTSysSkillRela_Cond.dicFldComparisonOp, clsRTSysSkillRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objRTSysSkillRela_Cond.dicFldComparisonOp[clsRTSysSkillRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTSysSkillRelaEN.con_UpdUser, objRTSysSkillRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objRTSysSkillRela_Cond.dicFldComparisonOp, clsRTSysSkillRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objRTSysSkillRela_Cond.dicFldComparisonOp[clsRTSysSkillRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTSysSkillRelaEN.con_Memo, objRTSysSkillRela_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objRTSysSkillRela_Cond.dicFldComparisonOp, clsRTSysSkillRelaEN.con_ClassificationId) == true)
{
const strComparisonOp_ClassificationId:string = objRTSysSkillRela_Cond.dicFldComparisonOp[clsRTSysSkillRelaEN.con_ClassificationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTSysSkillRelaEN.con_ClassificationId, objRTSysSkillRela_Cond.classificationId, strComparisonOp_ClassificationId);
}
if (Object.prototype.hasOwnProperty.call(objRTSysSkillRela_Cond.dicFldComparisonOp, clsRTSysSkillRelaEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objRTSysSkillRela_Cond.dicFldComparisonOp[clsRTSysSkillRelaEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTSysSkillRelaEN.con_id_CurrEduCls, objRTSysSkillRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--RTSysSkillRela(RTSysSkillRela),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function RTSysSkillRela_GetUniCondStr_mId(objRTSysSkillRelaEN: clsRTSysSkillRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objRTSysSkillRelaEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--RTSysSkillRela(RTSysSkillRela),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function RTSysSkillRela_GetUniCondStr4Update_mId(objRTSysSkillRelaEN: clsRTSysSkillRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objRTSysSkillRelaEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objRTSysSkillRelaEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objRTSysSkillRelaENS:源对象
 * @param objRTSysSkillRelaENT:目标对象
*/
export function RTSysSkillRela_CopyObjTo(objRTSysSkillRelaENS: clsRTSysSkillRelaEN , objRTSysSkillRelaENT: clsRTSysSkillRelaEN ): void 
{
objRTSysSkillRelaENT.mId = objRTSysSkillRelaENS.mId; //mId
objRTSysSkillRelaENT.topicId = objRTSysSkillRelaENS.topicId; //主题Id
objRTSysSkillRelaENT.skillId = objRTSysSkillRelaENS.skillId; //技能Id
objRTSysSkillRelaENT.updDate = objRTSysSkillRelaENS.updDate; //修改日期
objRTSysSkillRelaENT.updUser = objRTSysSkillRelaENS.updUser; //修改人
objRTSysSkillRelaENT.memo = objRTSysSkillRelaENS.memo; //备注
objRTSysSkillRelaENT.classificationId = objRTSysSkillRelaENS.classificationId; //分类Id
objRTSysSkillRelaENT.id_CurrEduCls = objRTSysSkillRelaENS.id_CurrEduCls; //教学班流水号
objRTSysSkillRelaENT.sf_UpdFldSetStr = objRTSysSkillRelaENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objRTSysSkillRelaENS:源对象
 * @param objRTSysSkillRelaENT:目标对象
*/
export function RTSysSkillRela_GetObjFromJsonObj(objRTSysSkillRelaENS: clsRTSysSkillRelaEN): clsRTSysSkillRelaEN 
{
 const objRTSysSkillRelaENT: clsRTSysSkillRelaEN = new clsRTSysSkillRelaEN();
ObjectAssign(objRTSysSkillRelaENT, objRTSysSkillRelaENS);
 return objRTSysSkillRelaENT;
}