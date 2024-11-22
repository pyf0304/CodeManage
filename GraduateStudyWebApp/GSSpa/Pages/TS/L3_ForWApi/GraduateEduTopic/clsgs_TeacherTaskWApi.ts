
 /**
 * 类名:clsgs_TeacherTaskWApi
 * 表名:gs_TeacherTask(01120686)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:02
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
 * 教师任务(gs_TeacherTask)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsgs_TeacherTaskEN } from "../../L0_Entity/GraduateEduTopic/clsgs_TeacherTaskEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_TeacherTask_Controller = "gs_TeacherTaskApi";
 export const gs_TeacherTask_ConstructorName = "gs_TeacherTask";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function gs_TeacherTask_GetObjBymIdAsync(lngmId: number): Promise<clsgs_TeacherTaskEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TeacherTask = gs_TeacherTask_GetObjFromJsonObj(returnObj);
return objgs_TeacherTask;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * 根据关键字获取相关对象, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function gs_TeacherTask_GetObjBymId_Cache(lngmId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
try
{
const arrgs_TeacherTask_Sel: Array <clsgs_TeacherTaskEN> = arrgs_TeacherTaskObjLst_Cache.filter(x => x.mId == lngmId);
let objgs_TeacherTask: clsgs_TeacherTaskEN;
if (arrgs_TeacherTask_Sel.length > 0)
{
objgs_TeacherTask = arrgs_TeacherTask_Sel[0];
return objgs_TeacherTask;
}
else
{
if (bolTryAsyncOnce == true)
{
objgs_TeacherTask = await gs_TeacherTask_GetObjBymIdAsync(lngmId);
if (objgs_TeacherTask != null)
{
gs_TeacherTask_ReFreshThisCache();
return objgs_TeacherTask;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function gs_TeacherTask_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_TeacherTaskEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_TeacherTask_Cache: clsgs_TeacherTaskEN = JSON.parse(strTempObj);
return objgs_TeacherTask_Cache;
}
try
{
const objgs_TeacherTask = await gs_TeacherTask_GetObjBymIdAsync(lngmId);
if (objgs_TeacherTask != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_TeacherTask));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_TeacherTask;
}
return objgs_TeacherTask;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_TeacherTask:所给的对象
 * @returns 对象
*/
export async function gs_TeacherTask_UpdateObjInLst_Cache(objgs_TeacherTask: clsgs_TeacherTaskEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
const obj = arrgs_TeacherTaskObjLst_Cache.find(x => x.mId == objgs_TeacherTask.mId);
if (obj != null)
{
objgs_TeacherTask.mId = obj.mId;
ObjectAssign( obj, objgs_TeacherTask);
}
else
{
arrgs_TeacherTaskObjLst_Cache.push(objgs_TeacherTask);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}
/*该表没有名称字段，不能生成此函数！*/

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 * @returns 返回一个输出字段值
*/
export async function gs_TeacherTask_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_TeacherTaskEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_TeacherTaskEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsgs_TeacherTaskEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objgs_TeacherTask = await gs_TeacherTask_GetObjBymId_Cache(lngmId );
if (objgs_TeacherTask == null) return "";
return objgs_TeacherTask.GetFldValue(strOutFldName).toString();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function gs_TeacherTask_SortFun_Defa(a:clsgs_TeacherTaskEN , b:clsgs_TeacherTaskEN): number 
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
export function gs_TeacherTask_SortFun_Defa_2Fld(a:clsgs_TeacherTaskEN , b:clsgs_TeacherTaskEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
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
export function gs_TeacherTask_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_TeacherTaskEN.con_mId:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return a.mId-b.mId;
}
case clsgs_TeacherTaskEN.con_TopicId:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsgs_TeacherTaskEN.con_id_CurrEduCls:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsgs_TeacherTaskEN.con_MissionStatement:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return a.missionStatement.localeCompare(b.missionStatement);
}
case clsgs_TeacherTaskEN.con_MissionRequirement:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return a.missionRequirement.localeCompare(b.missionRequirement);
}
case clsgs_TeacherTaskEN.con_UpdDate:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_TeacherTaskEN.con_UpdUser:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_TeacherTaskEN.con_Memo:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TeacherTask]中不存在！(in ${ gs_TeacherTask_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_TeacherTaskEN.con_mId:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return b.mId-a.mId;
}
case clsgs_TeacherTaskEN.con_TopicId:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsgs_TeacherTaskEN.con_id_CurrEduCls:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsgs_TeacherTaskEN.con_MissionStatement:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return b.missionStatement.localeCompare(a.missionStatement);
}
case clsgs_TeacherTaskEN.con_MissionRequirement:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return b.missionRequirement.localeCompare(a.missionRequirement);
}
case clsgs_TeacherTaskEN.con_UpdDate:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_TeacherTaskEN.con_UpdUser:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_TeacherTaskEN.con_Memo:
return (a: clsgs_TeacherTaskEN, b: clsgs_TeacherTaskEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TeacherTask]中不存在！(in ${ gs_TeacherTask_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TeacherTask_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_TeacherTaskEN.con_mId:
return (obj: clsgs_TeacherTaskEN) => {
return obj.mId === value;
}
case clsgs_TeacherTaskEN.con_TopicId:
return (obj: clsgs_TeacherTaskEN) => {
return obj.topicId === value;
}
case clsgs_TeacherTaskEN.con_id_CurrEduCls:
return (obj: clsgs_TeacherTaskEN) => {
return obj.id_CurrEduCls === value;
}
case clsgs_TeacherTaskEN.con_MissionStatement:
return (obj: clsgs_TeacherTaskEN) => {
return obj.missionStatement === value;
}
case clsgs_TeacherTaskEN.con_MissionRequirement:
return (obj: clsgs_TeacherTaskEN) => {
return obj.missionRequirement === value;
}
case clsgs_TeacherTaskEN.con_UpdDate:
return (obj: clsgs_TeacherTaskEN) => {
return obj.updDate === value;
}
case clsgs_TeacherTaskEN.con_UpdUser:
return (obj: clsgs_TeacherTaskEN) => {
return obj.updUser === value;
}
case clsgs_TeacherTaskEN.con_Memo:
return (obj: clsgs_TeacherTaskEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TeacherTask]中不存在！(in ${ gs_TeacherTask_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TeacherTask_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
export async function gs_TeacherTask_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
export async function gs_TeacherTask_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_TeacherTaskEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TeacherTask = gs_TeacherTask_GetObjFromJsonObj(returnObj);
return objgs_TeacherTask;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TeacherTask_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TeacherTaskEN._CurrTabName;
clsgs_TeacherTaskEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TeacherTaskEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TeacherTaskEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TeacherTaskEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_TeacherTaskExObjLst_Cache: Array<clsgs_TeacherTaskEN> = CacheHelper.Get(strKey);
const arrgs_TeacherTaskObjLst_T = gs_TeacherTask_GetObjLstByJSONObjLst(arrgs_TeacherTaskExObjLst_Cache);
return arrgs_TeacherTaskObjLst_T;
}
try
{
const arrgs_TeacherTaskExObjLst = await gs_TeacherTask_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_TeacherTaskExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TeacherTaskExObjLst.length);
console.log(strInfo);
return arrgs_TeacherTaskExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TeacherTask_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TeacherTaskEN._CurrTabName;
clsgs_TeacherTaskEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TeacherTaskEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TeacherTaskEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TeacherTaskEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_TeacherTaskExObjLst_Cache: Array<clsgs_TeacherTaskEN> = JSON.parse(strTempObjLst);
const arrgs_TeacherTaskObjLst_T = gs_TeacherTask_GetObjLstByJSONObjLst(arrgs_TeacherTaskExObjLst_Cache);
return arrgs_TeacherTaskObjLst_T;
}
try
{
const arrgs_TeacherTaskExObjLst = await gs_TeacherTask_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_TeacherTaskExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TeacherTaskExObjLst.length);
console.log(strInfo);
return arrgs_TeacherTaskExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TeacherTask_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_TeacherTaskEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_TeacherTaskObjLst_Cache: Array<clsgs_TeacherTaskEN> = JSON.parse(strTempObjLst);
return arrgs_TeacherTaskObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_TeacherTask_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_TeacherTaskEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TeacherTask_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TeacherTask_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TeacherTaskEN._CurrTabName;
clsgs_TeacherTaskEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TeacherTaskEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TeacherTaskEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TeacherTaskEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_TeacherTaskExObjLst_Cache: Array<clsgs_TeacherTaskEN> = JSON.parse(strTempObjLst);
const arrgs_TeacherTaskObjLst_T = gs_TeacherTask_GetObjLstByJSONObjLst(arrgs_TeacherTaskExObjLst_Cache);
return arrgs_TeacherTaskObjLst_T;
}
try
{
const arrgs_TeacherTaskExObjLst = await gs_TeacherTask_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_TeacherTaskExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TeacherTaskExObjLst.length);
console.log(strInfo);
return arrgs_TeacherTaskExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TeacherTask_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_TeacherTaskEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_TeacherTaskObjLst_Cache: Array<clsgs_TeacherTaskEN> = JSON.parse(strTempObjLst);
return arrgs_TeacherTaskObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TeacherTask_GetObjLst_Cache(): Promise<Array<clsgs_TeacherTaskEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_TeacherTaskObjLst_Cache;
switch (clsgs_TeacherTaskEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_ClientCache();
break;
default:
arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_ClientCache();
break;
}
const arrgs_TeacherTaskObjLst = gs_TeacherTask_GetObjLstByJSONObjLst(arrgs_TeacherTaskObjLst_Cache);
return arrgs_TeacherTaskObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TeacherTask_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_TeacherTaskObjLst_Cache;
switch (clsgs_TeacherTaskEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_TeacherTaskObjLst_Cache = null;
break;
default:
arrgs_TeacherTaskObjLst_Cache = null;
break;
}
return arrgs_TeacherTaskObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_TeacherTask_GetSubObjLst_Cache(objgs_TeacherTask_Cond: clsgs_TeacherTaskEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
let arrgs_TeacherTask_Sel: Array < clsgs_TeacherTaskEN > = arrgs_TeacherTaskObjLst_Cache;
if (objgs_TeacherTask_Cond.sf_FldComparisonOp == null || objgs_TeacherTask_Cond.sf_FldComparisonOp == "") return arrgs_TeacherTask_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TeacherTask_Cond.sf_FldComparisonOp);
//console.log("clsgs_TeacherTaskWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TeacherTask_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TeacherTask_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TeacherTask_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_TeacherTask_Cond), gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TeacherTaskEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function gs_TeacherTask_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsgs_TeacherTaskEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TeacherTask_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * 根据关键字列表获取相关对象列表, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
 * @param arrlngmIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_TeacherTask_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
const arrgs_TeacherTask_Sel: Array <clsgs_TeacherTaskEN> = arrgs_TeacherTaskObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrgs_TeacherTask_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TeacherTaskEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_TeacherTask_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_TeacherTaskEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TeacherTask_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
export async function gs_TeacherTask_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_TeacherTaskEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TeacherTask_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
export async function gs_TeacherTask_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function gs_TeacherTask_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
if (arrgs_TeacherTaskObjLst_Cache.length == 0) return arrgs_TeacherTaskObjLst_Cache;
let arrgs_TeacherTask_Sel = arrgs_TeacherTaskObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_TeacherTask_Cond = new clsgs_TeacherTaskEN();
ObjectAssign(objgs_TeacherTask_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_TeacherTaskWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TeacherTask_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TeacherTask_Sel.length == 0) return arrgs_TeacherTask_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.sort(gs_TeacherTask_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.sort(objPagerPara.sortFun);
}
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.slice(intStart, intEnd);     
return arrgs_TeacherTask_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TeacherTaskEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_TeacherTask_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_TeacherTaskEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TeacherTask_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
export async function gs_TeacherTask_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
export async function gs_TeacherTask_Delgs_TeacherTasksAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_TeacherTasksAsync";
const strAction = "Delgs_TeacherTasks";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
export async function gs_TeacherTask_Delgs_TeacherTasksByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_TeacherTasksByCondAsync";
const strAction = "Delgs_TeacherTasksByCond";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * @param objgs_TeacherTaskEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TeacherTask_AddNewRecordAsync(objgs_TeacherTaskEN: clsgs_TeacherTaskEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_TeacherTaskEN);
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TeacherTaskEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * @param objgs_TeacherTaskEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_TeacherTask_AddNewRecordWithReturnKeyAsync(objgs_TeacherTaskEN: clsgs_TeacherTaskEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TeacherTaskEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * @param objgs_TeacherTaskEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_TeacherTask_AddNewRecordWithReturnKey(objgs_TeacherTaskEN: clsgs_TeacherTaskEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_TeacherTaskEN.mId === null || objgs_TeacherTaskEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TeacherTaskEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * @param objgs_TeacherTaskEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_TeacherTask_UpdateRecordAsync(objgs_TeacherTaskEN: clsgs_TeacherTaskEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_TeacherTaskEN.sf_UpdFldSetStr === undefined || objgs_TeacherTaskEN.sf_UpdFldSetStr === null || objgs_TeacherTaskEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TeacherTaskEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TeacherTaskEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * @param objgs_TeacherTaskEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_TeacherTask_UpdateWithConditionAsync(objgs_TeacherTaskEN: clsgs_TeacherTaskEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_TeacherTaskEN.sf_UpdFldSetStr === undefined || objgs_TeacherTaskEN.sf_UpdFldSetStr === null || objgs_TeacherTaskEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TeacherTaskEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
objgs_TeacherTaskEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_TeacherTaskEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_TeacherTask_IsExistRecord_Cache(objgs_TeacherTask_Cond: clsgs_TeacherTaskEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
if (arrgs_TeacherTaskObjLst_Cache == null) return false;
let arrgs_TeacherTask_Sel: Array < clsgs_TeacherTaskEN > = arrgs_TeacherTaskObjLst_Cache;
if (objgs_TeacherTask_Cond.sf_FldComparisonOp == null || objgs_TeacherTask_Cond.sf_FldComparisonOp == "") return arrgs_TeacherTask_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TeacherTask_Cond.sf_FldComparisonOp);
//console.log("clsgs_TeacherTaskWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TeacherTask_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TeacherTask_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TeacherTask_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_TeacherTask_Cond), gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return false;
}

 /**
 * 根据条件获取是否存在相应的记录？
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
 * @param strWhereCond:条件
 * @returns 是否存在记录？
 **/
export async function gs_TeacherTask_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
export async function gs_TeacherTask_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * 根据关键字判断是否存在记录, 从本地缓存中判断.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function gs_TeacherTask_IsExist_Cache(lngmId:number) {
const strThisFuncName = "IsExist_Cache";
const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
if (arrgs_TeacherTaskObjLst_Cache == null) return false;
try
{
const arrgs_TeacherTask_Sel: Array <clsgs_TeacherTaskEN> = arrgs_TeacherTaskObjLst_Cache.filter(x => x.mId == lngmId);
if (arrgs_TeacherTask_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e)
{
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngmId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_TeacherTask_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
export async function gs_TeacherTask_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
 * 根据条件对象, 从缓存的对象列表中获取记录数.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
 * @param objgs_TeacherTask_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_TeacherTask_GetRecCountByCond_Cache(objgs_TeacherTask_Cond: clsgs_TeacherTaskEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
if (arrgs_TeacherTaskObjLst_Cache == null) return 0;
let arrgs_TeacherTask_Sel: Array < clsgs_TeacherTaskEN > = arrgs_TeacherTaskObjLst_Cache;
if (objgs_TeacherTask_Cond.sf_FldComparisonOp == null || objgs_TeacherTask_Cond.sf_FldComparisonOp == "") return arrgs_TeacherTask_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TeacherTask_Cond.sf_FldComparisonOp);
//console.log("clsgs_TeacherTaskWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TeacherTask_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TeacherTask_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TeacherTask_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_TeacherTask_Cond), gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}
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
export async function gs_TeacherTask_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_TeacherTask_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeacherTask_ConstructorName, strThisFuncName);
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
export function gs_TeacherTask_GetWebApiUrl(strController: string, strAction: string): string {
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
 * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
 **/
export function gs_TeacherTask_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_TeacherTaskEN._CurrTabName;
switch (clsgs_TeacherTaskEN.CacheModeId)
{
case "04"://sessionStorage
sessionStorage.removeItem(strKey);
break;
case "03"://localStorage
localStorage.removeItem(strKey);
break;
case "02"://ClientCache
CacheHelper.Remove(strKey);
break;
default:
CacheHelper.Remove(strKey);
break;
}
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function gs_TeacherTask_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_TeacherTaskEN._CurrTabName;
switch (clsgs_TeacherTaskEN.CacheModeId)
{
case "04"://sessionStorage
sessionStorage.removeItem(strKey);
break;
case "03"://localStorage
localStorage.removeItem(strKey);
break;
case "02"://ClientCache
CacheHelper.Remove(strKey);
break;
default:
CacheHelper.Remove(strKey);
break;
}
const strMsg = Format("刷新缓存成功！");
console.trace(strMsg);
}
else
{
const strMsg = Format("刷新缓存已经关闭。");
console.trace(strMsg);
}
}
/* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_TeacherTask_CheckPropertyNew(pobjgs_TeacherTaskEN: clsgs_TeacherTaskEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.id_CurrEduCls) === true 
 || pobjgs_TeacherTaskEN.id_CurrEduCls.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[教学班流水号]不能为空(In 教师任务)!(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.topicId) == false && GetStrLen(pobjgs_TeacherTaskEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.topicId)(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.id_CurrEduCls) == false && GetStrLen(pobjgs_TeacherTaskEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.id_CurrEduCls)(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.missionStatement) == false && GetStrLen(pobjgs_TeacherTaskEN.missionStatement) > 2000)
{
 throw new Error("(errid:Watl000059)字段[任务说明(missionStatement)]的长度不能超过2000(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.missionStatement)(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.missionRequirement) == false && GetStrLen(pobjgs_TeacherTaskEN.missionRequirement) > 2000)
{
 throw new Error("(errid:Watl000059)字段[任务要求(missionRequirement)]的长度不能超过2000(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.missionRequirement)(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.updDate) == false && GetStrLen(pobjgs_TeacherTaskEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.updDate)(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.updUser) == false && GetStrLen(pobjgs_TeacherTaskEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.updUser)(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.memo) == false && GetStrLen(pobjgs_TeacherTaskEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.memo)(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_TeacherTaskEN.mId && undefined !== pobjgs_TeacherTaskEN.mId && tzDataType.isNumber(pobjgs_TeacherTaskEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_TeacherTaskEN.mId)], 非法，应该为数值型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.topicId) == false && undefined !== pobjgs_TeacherTaskEN.topicId && tzDataType.isString(pobjgs_TeacherTaskEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_TeacherTaskEN.topicId)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.id_CurrEduCls) == false && undefined !== pobjgs_TeacherTaskEN.id_CurrEduCls && tzDataType.isString(pobjgs_TeacherTaskEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TeacherTaskEN.id_CurrEduCls)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.missionStatement) == false && undefined !== pobjgs_TeacherTaskEN.missionStatement && tzDataType.isString(pobjgs_TeacherTaskEN.missionStatement) === false)
{
 throw new Error("(errid:Watl000060)字段[任务说明(missionStatement)]的值:[$(pobjgs_TeacherTaskEN.missionStatement)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.missionRequirement) == false && undefined !== pobjgs_TeacherTaskEN.missionRequirement && tzDataType.isString(pobjgs_TeacherTaskEN.missionRequirement) === false)
{
 throw new Error("(errid:Watl000060)字段[任务要求(missionRequirement)]的值:[$(pobjgs_TeacherTaskEN.missionRequirement)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.updDate) == false && undefined !== pobjgs_TeacherTaskEN.updDate && tzDataType.isString(pobjgs_TeacherTaskEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TeacherTaskEN.updDate)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.updUser) == false && undefined !== pobjgs_TeacherTaskEN.updUser && tzDataType.isString(pobjgs_TeacherTaskEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TeacherTaskEN.updUser)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.memo) == false && undefined !== pobjgs_TeacherTaskEN.memo && tzDataType.isString(pobjgs_TeacherTaskEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TeacherTaskEN.memo)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_TeacherTaskEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_TeacherTask_CheckProperty4Update (pobjgs_TeacherTaskEN: clsgs_TeacherTaskEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.topicId) == false && GetStrLen(pobjgs_TeacherTaskEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.topicId)(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.id_CurrEduCls) == false && GetStrLen(pobjgs_TeacherTaskEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.id_CurrEduCls)(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.missionStatement) == false && GetStrLen(pobjgs_TeacherTaskEN.missionStatement) > 2000)
{
 throw new Error("(errid:Watl000062)字段[任务说明(missionStatement)]的长度不能超过2000(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.missionStatement)(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.missionRequirement) == false && GetStrLen(pobjgs_TeacherTaskEN.missionRequirement) > 2000)
{
 throw new Error("(errid:Watl000062)字段[任务要求(missionRequirement)]的长度不能超过2000(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.missionRequirement)(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.updDate) == false && GetStrLen(pobjgs_TeacherTaskEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.updDate)(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.updUser) == false && GetStrLen(pobjgs_TeacherTaskEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.updUser)(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.memo) == false && GetStrLen(pobjgs_TeacherTaskEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.memo)(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_TeacherTaskEN.mId && undefined !== pobjgs_TeacherTaskEN.mId && tzDataType.isNumber(pobjgs_TeacherTaskEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_TeacherTaskEN.mId)], 非法，应该为数值型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.topicId) == false && undefined !== pobjgs_TeacherTaskEN.topicId && tzDataType.isString(pobjgs_TeacherTaskEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_TeacherTaskEN.topicId)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.id_CurrEduCls) == false && undefined !== pobjgs_TeacherTaskEN.id_CurrEduCls && tzDataType.isString(pobjgs_TeacherTaskEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TeacherTaskEN.id_CurrEduCls)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.missionStatement) == false && undefined !== pobjgs_TeacherTaskEN.missionStatement && tzDataType.isString(pobjgs_TeacherTaskEN.missionStatement) === false)
{
 throw new Error("(errid:Watl000063)字段[任务说明(missionStatement)]的值:[$(pobjgs_TeacherTaskEN.missionStatement)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.missionRequirement) == false && undefined !== pobjgs_TeacherTaskEN.missionRequirement && tzDataType.isString(pobjgs_TeacherTaskEN.missionRequirement) === false)
{
 throw new Error("(errid:Watl000063)字段[任务要求(missionRequirement)]的值:[$(pobjgs_TeacherTaskEN.missionRequirement)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.updDate) == false && undefined !== pobjgs_TeacherTaskEN.updDate && tzDataType.isString(pobjgs_TeacherTaskEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TeacherTaskEN.updDate)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.updUser) == false && undefined !== pobjgs_TeacherTaskEN.updUser && tzDataType.isString(pobjgs_TeacherTaskEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TeacherTaskEN.updUser)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeacherTaskEN.memo) == false && undefined !== pobjgs_TeacherTaskEN.memo && tzDataType.isString(pobjgs_TeacherTaskEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TeacherTaskEN.memo)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_TeacherTaskEN.mId 
 || pobjgs_TeacherTaskEN.mId != null && pobjgs_TeacherTaskEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 教师任务)!(clsgs_TeacherTaskBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_TeacherTaskEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TeacherTask_GetJSONStrByObj (pobjgs_TeacherTaskEN: clsgs_TeacherTaskEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_TeacherTaskEN.sf_UpdFldSetStr = pobjgs_TeacherTaskEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_TeacherTaskEN);
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
export function gs_TeacherTask_GetObjLstByJSONStr (strJSON: string): Array<clsgs_TeacherTaskEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_TeacherTaskObjLst = new Array<clsgs_TeacherTaskEN>();
if (strJSON === "")
{
return arrgs_TeacherTaskObjLst;
}
try
{
arrgs_TeacherTaskObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_TeacherTaskObjLst;
}
return arrgs_TeacherTaskObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_TeacherTaskObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_TeacherTask_GetObjLstByJSONObjLst (arrgs_TeacherTaskObjLstS: Array<clsgs_TeacherTaskEN>): Array<clsgs_TeacherTaskEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_TeacherTaskObjLst = new Array<clsgs_TeacherTaskEN>();
for (const objInFor of arrgs_TeacherTaskObjLstS) {
const obj1 = gs_TeacherTask_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_TeacherTaskObjLst.push(obj1);
}
return arrgs_TeacherTaskObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TeacherTask_GetObjByJSONStr (strJSON: string): clsgs_TeacherTaskEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_TeacherTaskEN = new clsgs_TeacherTaskEN();
if (strJSON === "")
{
return pobjgs_TeacherTaskEN;
}
try
{
pobjgs_TeacherTaskEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_TeacherTaskEN;
}
return pobjgs_TeacherTaskEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_TeacherTask_GetCombineCondition(objgs_TeacherTask_Cond: clsgs_TeacherTaskEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN.con_mId) == true)
{
const strComparisonOp_mId:string = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TeacherTaskEN.con_mId, objgs_TeacherTask_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeacherTaskEN.con_TopicId, objgs_TeacherTask_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeacherTaskEN.con_id_CurrEduCls, objgs_TeacherTask_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN.con_MissionStatement) == true)
{
const strComparisonOp_MissionStatement:string = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN.con_MissionStatement];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeacherTaskEN.con_MissionStatement, objgs_TeacherTask_Cond.missionStatement, strComparisonOp_MissionStatement);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN.con_MissionRequirement) == true)
{
const strComparisonOp_MissionRequirement:string = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN.con_MissionRequirement];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeacherTaskEN.con_MissionRequirement, objgs_TeacherTask_Cond.missionRequirement, strComparisonOp_MissionRequirement);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeacherTaskEN.con_UpdDate, objgs_TeacherTask_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeacherTaskEN.con_UpdUser, objgs_TeacherTask_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeacherTaskEN.con_Memo, objgs_TeacherTask_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TeacherTask(教师任务),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TeacherTask_GetUniCondStr_mId(objgs_TeacherTaskEN: clsgs_TeacherTaskEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objgs_TeacherTaskEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TeacherTask(教师任务),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TeacherTask_GetUniCondStr4Update_mId(objgs_TeacherTaskEN: clsgs_TeacherTaskEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objgs_TeacherTaskEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objgs_TeacherTaskEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_TeacherTaskENS:源对象
 * @param objgs_TeacherTaskENT:目标对象
*/
export function gs_TeacherTask_CopyObjTo(objgs_TeacherTaskENS: clsgs_TeacherTaskEN , objgs_TeacherTaskENT: clsgs_TeacherTaskEN ): void 
{
objgs_TeacherTaskENT.mId = objgs_TeacherTaskENS.mId; //mId
objgs_TeacherTaskENT.topicId = objgs_TeacherTaskENS.topicId; //主题Id
objgs_TeacherTaskENT.id_CurrEduCls = objgs_TeacherTaskENS.id_CurrEduCls; //教学班流水号
objgs_TeacherTaskENT.missionStatement = objgs_TeacherTaskENS.missionStatement; //任务说明
objgs_TeacherTaskENT.missionRequirement = objgs_TeacherTaskENS.missionRequirement; //任务要求
objgs_TeacherTaskENT.updDate = objgs_TeacherTaskENS.updDate; //修改日期
objgs_TeacherTaskENT.updUser = objgs_TeacherTaskENS.updUser; //修改人
objgs_TeacherTaskENT.memo = objgs_TeacherTaskENS.memo; //备注
objgs_TeacherTaskENT.sf_UpdFldSetStr = objgs_TeacherTaskENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_TeacherTaskENS:源对象
 * @param objgs_TeacherTaskENT:目标对象
*/
export function gs_TeacherTask_GetObjFromJsonObj(objgs_TeacherTaskENS: clsgs_TeacherTaskEN): clsgs_TeacherTaskEN 
{
 const objgs_TeacherTaskENT: clsgs_TeacherTaskEN = new clsgs_TeacherTaskEN();
ObjectAssign(objgs_TeacherTaskENT, objgs_TeacherTaskENS);
 return objgs_TeacherTaskENT;
}