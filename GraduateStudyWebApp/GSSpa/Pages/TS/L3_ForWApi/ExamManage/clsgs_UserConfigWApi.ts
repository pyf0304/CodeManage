
 /**
 * 类名:clsgs_UserConfigWApi
 * 表名:gs_UserConfig(01120693)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:19
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:考试管理(ExamManage)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 用户配置(gs_UserConfig)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsgs_UserConfigEN } from "../../L0_Entity/ExamManage/clsgs_UserConfigEN.js";
import { vgs_UserConfig_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTools/clsvgs_UserConfigWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_UserConfig_Controller = "gs_UserConfigApi";
 export const gs_UserConfig_ConstructorName = "gs_UserConfig";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngConfigId:关键字
 * @returns 对象
 **/
export async function gs_UserConfig_GetObjByConfigIdAsync(lngConfigId: number): Promise<clsgs_UserConfigEN>  
{
const strThisFuncName = "GetObjByConfigIdAsync";

if (lngConfigId == 0)
{
  const strMsg = Format("参数:[lngConfigId]不能为空！(In GetObjByConfigIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByConfigId";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngConfigId": lngConfigId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_UserConfig = gs_UserConfig_GetObjFromJsonObj(returnObj);
return objgs_UserConfig;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param lngConfigId:所给的关键字
 * @returns 对象
*/
export async function gs_UserConfig_GetObjByConfigId_Cache(lngConfigId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByConfigId_Cache";

if (lngConfigId == 0)
{
  const strMsg = Format("参数:[lngConfigId]不能为空！(In GetObjByConfigId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_Cache();
try
{
const arrgs_UserConfig_Sel: Array <clsgs_UserConfigEN> = arrgs_UserConfigObjLst_Cache.filter(x => x.configId == lngConfigId);
let objgs_UserConfig: clsgs_UserConfigEN;
if (arrgs_UserConfig_Sel.length > 0)
{
objgs_UserConfig = arrgs_UserConfig_Sel[0];
return objgs_UserConfig;
}
else
{
if (bolTryAsyncOnce == true)
{
objgs_UserConfig = await gs_UserConfig_GetObjByConfigIdAsync(lngConfigId);
if (objgs_UserConfig != null)
{
gs_UserConfig_ReFreshThisCache();
return objgs_UserConfig;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngConfigId, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngConfigId:所给的关键字
 * @returns 对象
*/
export async function gs_UserConfig_GetObjByConfigId_localStorage(lngConfigId: number) {
const strThisFuncName = "GetObjByConfigId_localStorage";

if (lngConfigId == 0)
{
  const strMsg = Format("参数:[lngConfigId]不能为空！(In GetObjByConfigId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_UserConfigEN._CurrTabName, lngConfigId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_UserConfig_Cache: clsgs_UserConfigEN = JSON.parse(strTempObj);
return objgs_UserConfig_Cache;
}
try
{
const objgs_UserConfig = await gs_UserConfig_GetObjByConfigIdAsync(lngConfigId);
if (objgs_UserConfig != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_UserConfig));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_UserConfig;
}
return objgs_UserConfig;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngConfigId, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_UserConfig:所给的对象
 * @returns 对象
*/
export async function gs_UserConfig_UpdateObjInLst_Cache(objgs_UserConfig: clsgs_UserConfigEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_Cache();
const obj = arrgs_UserConfigObjLst_Cache.find(x => x.configId == objgs_UserConfig.configId);
if (obj != null)
{
objgs_UserConfig.configId = obj.configId;
ObjectAssign( obj, objgs_UserConfig);
}
else
{
arrgs_UserConfigObjLst_Cache.push(objgs_UserConfig);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_UserConfig_ConstructorName, strThisFuncName);
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
export async function gs_UserConfig_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_UserConfigEN.con_ConfigId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_UserConfigEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsgs_UserConfigEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngConfigId = Number(strInValue);
if (lngConfigId == 0)
{
return "";
}
const objgs_UserConfig = await gs_UserConfig_GetObjByConfigId_Cache(lngConfigId );
if (objgs_UserConfig == null) return "";
return objgs_UserConfig.GetFldValue(strOutFldName).toString();
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
export function gs_UserConfig_SortFun_Defa(a:clsgs_UserConfigEN , b:clsgs_UserConfigEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.configId-b.configId;
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
export function gs_UserConfig_SortFun_Defa_2Fld(a:clsgs_UserConfigEN , b:clsgs_UserConfigEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.configTypeId == b.configTypeId) return a.shareId.localeCompare(b.shareId);
else return a.configTypeId.localeCompare(b.configTypeId);
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
export function gs_UserConfig_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_UserConfigEN.con_ConfigId:
return (a: clsgs_UserConfigEN, b: clsgs_UserConfigEN) => {
return a.configId-b.configId;
}
case clsgs_UserConfigEN.con_ConfigTypeId:
return (a: clsgs_UserConfigEN, b: clsgs_UserConfigEN) => {
return a.configTypeId.localeCompare(b.configTypeId);
}
case clsgs_UserConfigEN.con_ShareId:
return (a: clsgs_UserConfigEN, b: clsgs_UserConfigEN) => {
return a.shareId.localeCompare(b.shareId);
}
case clsgs_UserConfigEN.con_UpdUser:
return (a: clsgs_UserConfigEN, b: clsgs_UserConfigEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_UserConfigEN.con_UpdDate:
return (a: clsgs_UserConfigEN, b: clsgs_UserConfigEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_UserConfigEN.con_Memo:
return (a: clsgs_UserConfigEN, b: clsgs_UserConfigEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_UserConfig]中不存在！(in ${ gs_UserConfig_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_UserConfigEN.con_ConfigId:
return (a: clsgs_UserConfigEN, b: clsgs_UserConfigEN) => {
return b.configId-a.configId;
}
case clsgs_UserConfigEN.con_ConfigTypeId:
return (a: clsgs_UserConfigEN, b: clsgs_UserConfigEN) => {
return b.configTypeId.localeCompare(a.configTypeId);
}
case clsgs_UserConfigEN.con_ShareId:
return (a: clsgs_UserConfigEN, b: clsgs_UserConfigEN) => {
return b.shareId.localeCompare(a.shareId);
}
case clsgs_UserConfigEN.con_UpdUser:
return (a: clsgs_UserConfigEN, b: clsgs_UserConfigEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_UserConfigEN.con_UpdDate:
return (a: clsgs_UserConfigEN, b: clsgs_UserConfigEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_UserConfigEN.con_Memo:
return (a: clsgs_UserConfigEN, b: clsgs_UserConfigEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_UserConfig]中不存在！(in ${ gs_UserConfig_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_UserConfig_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_UserConfigEN.con_ConfigId:
return (obj: clsgs_UserConfigEN) => {
return obj.configId === value;
}
case clsgs_UserConfigEN.con_ConfigTypeId:
return (obj: clsgs_UserConfigEN) => {
return obj.configTypeId === value;
}
case clsgs_UserConfigEN.con_ShareId:
return (obj: clsgs_UserConfigEN) => {
return obj.shareId === value;
}
case clsgs_UserConfigEN.con_UpdUser:
return (obj: clsgs_UserConfigEN) => {
return obj.updUser === value;
}
case clsgs_UserConfigEN.con_UpdDate:
return (obj: clsgs_UserConfigEN) => {
return obj.updDate === value;
}
case clsgs_UserConfigEN.con_Memo:
return (obj: clsgs_UserConfigEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_UserConfig]中不存在！(in ${ gs_UserConfig_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_UserConfig_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
export async function gs_UserConfig_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
export async function gs_UserConfig_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_UserConfigEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_UserConfig = gs_UserConfig_GetObjFromJsonObj(returnObj);
return objgs_UserConfig;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
export async function gs_UserConfig_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_UserConfigEN._CurrTabName;
clsgs_UserConfigEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_UserConfigEN._CurrTabName);
if (IsNullOrEmpty(clsgs_UserConfigEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_UserConfigEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_UserConfigExObjLst_Cache: Array<clsgs_UserConfigEN> = CacheHelper.Get(strKey);
const arrgs_UserConfigObjLst_T = gs_UserConfig_GetObjLstByJSONObjLst(arrgs_UserConfigExObjLst_Cache);
return arrgs_UserConfigObjLst_T;
}
try
{
const arrgs_UserConfigExObjLst = await gs_UserConfig_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_UserConfigExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_UserConfigExObjLst.length);
console.log(strInfo);
return arrgs_UserConfigExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_UserConfig_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_UserConfigEN._CurrTabName;
clsgs_UserConfigEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_UserConfigEN._CurrTabName);
if (IsNullOrEmpty(clsgs_UserConfigEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_UserConfigEN.CacheAddiCondition);
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
const arrgs_UserConfigExObjLst_Cache: Array<clsgs_UserConfigEN> = JSON.parse(strTempObjLst);
const arrgs_UserConfigObjLst_T = gs_UserConfig_GetObjLstByJSONObjLst(arrgs_UserConfigExObjLst_Cache);
return arrgs_UserConfigObjLst_T;
}
try
{
const arrgs_UserConfigExObjLst = await gs_UserConfig_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_UserConfigExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_UserConfigExObjLst.length);
console.log(strInfo);
return arrgs_UserConfigExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_UserConfig_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_UserConfigEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_UserConfigObjLst_Cache: Array<clsgs_UserConfigEN> = JSON.parse(strTempObjLst);
return arrgs_UserConfigObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_UserConfig_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_UserConfigEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_UserConfig_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
export async function gs_UserConfig_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_UserConfigEN._CurrTabName;
clsgs_UserConfigEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_UserConfigEN._CurrTabName);
if (IsNullOrEmpty(clsgs_UserConfigEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_UserConfigEN.CacheAddiCondition);
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
const arrgs_UserConfigExObjLst_Cache: Array<clsgs_UserConfigEN> = JSON.parse(strTempObjLst);
const arrgs_UserConfigObjLst_T = gs_UserConfig_GetObjLstByJSONObjLst(arrgs_UserConfigExObjLst_Cache);
return arrgs_UserConfigObjLst_T;
}
try
{
const arrgs_UserConfigExObjLst = await gs_UserConfig_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_UserConfigExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_UserConfigExObjLst.length);
console.log(strInfo);
return arrgs_UserConfigExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_UserConfig_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_UserConfigEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_UserConfigObjLst_Cache: Array<clsgs_UserConfigEN> = JSON.parse(strTempObjLst);
return arrgs_UserConfigObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_UserConfig_GetObjLst_Cache(): Promise<Array<clsgs_UserConfigEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_UserConfigObjLst_Cache;
switch (clsgs_UserConfigEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_ClientCache();
break;
default:
arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_ClientCache();
break;
}
const arrgs_UserConfigObjLst = gs_UserConfig_GetObjLstByJSONObjLst(arrgs_UserConfigObjLst_Cache);
return arrgs_UserConfigObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_UserConfig_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_UserConfigObjLst_Cache;
switch (clsgs_UserConfigEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_UserConfigObjLst_Cache = null;
break;
default:
arrgs_UserConfigObjLst_Cache = null;
break;
}
return arrgs_UserConfigObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngConfigId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_UserConfig_GetSubObjLst_Cache(objgs_UserConfig_Cond: clsgs_UserConfigEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_Cache();
let arrgs_UserConfig_Sel: Array < clsgs_UserConfigEN > = arrgs_UserConfigObjLst_Cache;
if (objgs_UserConfig_Cond.sf_FldComparisonOp == null || objgs_UserConfig_Cond.sf_FldComparisonOp == "") return arrgs_UserConfig_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_UserConfig_Cond.sf_FldComparisonOp);
//console.log("clsgs_UserConfigWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_UserConfig_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_UserConfig_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_UserConfig_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_UserConfig_Cond), gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_UserConfigEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrConfigId:关键字列表
 * @returns 对象列表
 **/
export async function gs_UserConfig_GetObjLstByConfigIdLstAsync(arrConfigId: Array<string>): Promise<Array<clsgs_UserConfigEN>>  
{
const strThisFuncName = "GetObjLstByConfigIdLstAsync";
const strAction = "GetObjLstByConfigIdLst";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrConfigId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_UserConfig_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param arrlngConfigIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_UserConfig_GetObjLstByConfigIdLst_Cache(arrConfigIdLst: Array<number>) {
const strThisFuncName = "GetObjLstByConfigIdLst_Cache";
try
{
const arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_Cache();
const arrgs_UserConfig_Sel: Array <clsgs_UserConfigEN> = arrgs_UserConfigObjLst_Cache.filter(x => arrConfigIdLst.indexOf(x.configId)>-1);
return arrgs_UserConfig_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrConfigIdLst.join(","), gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_UserConfigEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_UserConfig_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_UserConfigEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_UserConfig_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
export async function gs_UserConfig_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_UserConfigEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_UserConfig_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
export async function gs_UserConfig_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
export async function gs_UserConfig_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_Cache();
if (arrgs_UserConfigObjLst_Cache.length == 0) return arrgs_UserConfigObjLst_Cache;
let arrgs_UserConfig_Sel = arrgs_UserConfigObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_UserConfig_Cond = new clsgs_UserConfigEN();
ObjectAssign(objgs_UserConfig_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_UserConfigWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_UserConfig_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_UserConfig_Sel.length == 0) return arrgs_UserConfig_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.sort(gs_UserConfig_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.sort(objPagerPara.sortFun);
}
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.slice(intStart, intEnd);     
return arrgs_UserConfig_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_UserConfigEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_UserConfig_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_UserConfigEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_UserConfig_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param lngConfigId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_UserConfig_DelRecordAsync(lngConfigId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngConfigId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngConfigId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param arrConfigId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_UserConfig_Delgs_UserConfigsAsync(arrConfigId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_UserConfigsAsync";
const strAction = "Delgs_UserConfigs";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrConfigId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
export async function gs_UserConfig_Delgs_UserConfigsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_UserConfigsByCondAsync";
const strAction = "Delgs_UserConfigsByCond";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param objgs_UserConfigEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_UserConfig_AddNewRecordAsync(objgs_UserConfigEN: clsgs_UserConfigEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_UserConfigEN);
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_UserConfigEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param objgs_UserConfigEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_UserConfig_AddNewRecordWithReturnKeyAsync(objgs_UserConfigEN: clsgs_UserConfigEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_UserConfigEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param objgs_UserConfigEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_UserConfig_AddNewRecordWithReturnKey(objgs_UserConfigEN: clsgs_UserConfigEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_UserConfigEN.configId === null || objgs_UserConfigEN.configId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_UserConfigEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param objgs_UserConfigEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_UserConfig_UpdateRecordAsync(objgs_UserConfigEN: clsgs_UserConfigEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_UserConfigEN.sf_UpdFldSetStr === undefined || objgs_UserConfigEN.sf_UpdFldSetStr === null || objgs_UserConfigEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_UserConfigEN.configId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_UserConfigEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param objgs_UserConfigEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_UserConfig_UpdateWithConditionAsync(objgs_UserConfigEN: clsgs_UserConfigEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_UserConfigEN.sf_UpdFldSetStr === undefined || objgs_UserConfigEN.sf_UpdFldSetStr === null || objgs_UserConfigEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_UserConfigEN.configId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
objgs_UserConfigEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_UserConfigEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param objlngConfigId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_UserConfig_IsExistRecord_Cache(objgs_UserConfig_Cond: clsgs_UserConfigEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_Cache();
if (arrgs_UserConfigObjLst_Cache == null) return false;
let arrgs_UserConfig_Sel: Array < clsgs_UserConfigEN > = arrgs_UserConfigObjLst_Cache;
if (objgs_UserConfig_Cond.sf_FldComparisonOp == null || objgs_UserConfig_Cond.sf_FldComparisonOp == "") return arrgs_UserConfig_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_UserConfig_Cond.sf_FldComparisonOp);
//console.log("clsgs_UserConfigWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_UserConfig_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_UserConfig_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_UserConfig_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_UserConfig_Cond), gs_UserConfig_ConstructorName, strThisFuncName);
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
export async function gs_UserConfig_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param lngConfigId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_UserConfig_IsExist(lngConfigId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ConfigId": lngConfigId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param lngConfigId:所给的关键字
 * @returns 对象
*/
export async function gs_UserConfig_IsExist_Cache(lngConfigId:number) {
const strThisFuncName = "IsExist_Cache";
const arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_Cache();
if (arrgs_UserConfigObjLst_Cache == null) return false;
try
{
const arrgs_UserConfig_Sel: Array <clsgs_UserConfigEN> = arrgs_UserConfigObjLst_Cache.filter(x => x.configId == lngConfigId);
if (arrgs_UserConfig_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngConfigId, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngConfigId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_UserConfig_IsExistAsync(lngConfigId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngConfigId": lngConfigId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
export async function gs_UserConfig_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
 * @param objgs_UserConfig_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_UserConfig_GetRecCountByCond_Cache(objgs_UserConfig_Cond: clsgs_UserConfigEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_UserConfigObjLst_Cache = await gs_UserConfig_GetObjLst_Cache();
if (arrgs_UserConfigObjLst_Cache == null) return 0;
let arrgs_UserConfig_Sel: Array < clsgs_UserConfigEN > = arrgs_UserConfigObjLst_Cache;
if (objgs_UserConfig_Cond.sf_FldComparisonOp == null || objgs_UserConfig_Cond.sf_FldComparisonOp == "") return arrgs_UserConfig_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_UserConfig_Cond.sf_FldComparisonOp);
//console.log("clsgs_UserConfigWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_UserConfig_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_UserConfig_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_UserConfig_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_UserConfig_Cond), gs_UserConfig_ConstructorName, strThisFuncName);
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
export async function gs_UserConfig_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_UserConfig_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_UserConfig_ConstructorName, strThisFuncName);
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
export function gs_UserConfig_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_UserConfig_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_UserConfigEN._CurrTabName;
switch (clsgs_UserConfigEN.CacheModeId)
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
vgs_UserConfig_ReFreshThisCache();
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function gs_UserConfig_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_UserConfigEN._CurrTabName;
switch (clsgs_UserConfigEN.CacheModeId)
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
export function gs_UserConfig_CheckPropertyNew(pobjgs_UserConfigEN: clsgs_UserConfigEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_UserConfigEN.configTypeId) === true )
{
 throw new Error("(errid:Watl000058)字段[配置类型Id]不能为空(In 用户配置)!(clsgs_UserConfigBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.shareId) === true )
{
 throw new Error("(errid:Watl000058)字段[分享Id]不能为空(In 用户配置)!(clsgs_UserConfigBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_UserConfigEN.configTypeId) == false && GetStrLen(pobjgs_UserConfigEN.configTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[配置类型Id(configTypeId)]的长度不能超过2(In 用户配置(gs_UserConfig))!值:$(pobjgs_UserConfigEN.configTypeId)(clsgs_UserConfigBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.shareId) == false && GetStrLen(pobjgs_UserConfigEN.shareId) > 2)
{
 throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 用户配置(gs_UserConfig))!值:$(pobjgs_UserConfigEN.shareId)(clsgs_UserConfigBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.updUser) == false && GetStrLen(pobjgs_UserConfigEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 用户配置(gs_UserConfig))!值:$(pobjgs_UserConfigEN.updUser)(clsgs_UserConfigBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.updDate) == false && GetStrLen(pobjgs_UserConfigEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 用户配置(gs_UserConfig))!值:$(pobjgs_UserConfigEN.updDate)(clsgs_UserConfigBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.memo) == false && GetStrLen(pobjgs_UserConfigEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 用户配置(gs_UserConfig))!值:$(pobjgs_UserConfigEN.memo)(clsgs_UserConfigBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_UserConfigEN.configId && undefined !== pobjgs_UserConfigEN.configId && tzDataType.isNumber(pobjgs_UserConfigEN.configId) === false)
{
 throw new Error("(errid:Watl000060)字段[配置Id(configId)]的值:[$(pobjgs_UserConfigEN.configId)], 非法，应该为数值型(In 用户配置(gs_UserConfig))!(clsgs_UserConfigBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.configTypeId) == false && undefined !== pobjgs_UserConfigEN.configTypeId && tzDataType.isString(pobjgs_UserConfigEN.configTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[配置类型Id(configTypeId)]的值:[$(pobjgs_UserConfigEN.configTypeId)], 非法，应该为字符型(In 用户配置(gs_UserConfig))!(clsgs_UserConfigBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.shareId) == false && undefined !== pobjgs_UserConfigEN.shareId && tzDataType.isString(pobjgs_UserConfigEN.shareId) === false)
{
 throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjgs_UserConfigEN.shareId)], 非法，应该为字符型(In 用户配置(gs_UserConfig))!(clsgs_UserConfigBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.updUser) == false && undefined !== pobjgs_UserConfigEN.updUser && tzDataType.isString(pobjgs_UserConfigEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_UserConfigEN.updUser)], 非法，应该为字符型(In 用户配置(gs_UserConfig))!(clsgs_UserConfigBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.updDate) == false && undefined !== pobjgs_UserConfigEN.updDate && tzDataType.isString(pobjgs_UserConfigEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_UserConfigEN.updDate)], 非法，应该为字符型(In 用户配置(gs_UserConfig))!(clsgs_UserConfigBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.memo) == false && undefined !== pobjgs_UserConfigEN.memo && tzDataType.isString(pobjgs_UserConfigEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_UserConfigEN.memo)], 非法，应该为字符型(In 用户配置(gs_UserConfig))!(clsgs_UserConfigBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_UserConfigEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_UserConfig_CheckProperty4Update (pobjgs_UserConfigEN: clsgs_UserConfigEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_UserConfigEN.configTypeId) == false && GetStrLen(pobjgs_UserConfigEN.configTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[配置类型Id(configTypeId)]的长度不能超过2(In 用户配置(gs_UserConfig))!值:$(pobjgs_UserConfigEN.configTypeId)(clsgs_UserConfigBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.shareId) == false && GetStrLen(pobjgs_UserConfigEN.shareId) > 2)
{
 throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 用户配置(gs_UserConfig))!值:$(pobjgs_UserConfigEN.shareId)(clsgs_UserConfigBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.updUser) == false && GetStrLen(pobjgs_UserConfigEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 用户配置(gs_UserConfig))!值:$(pobjgs_UserConfigEN.updUser)(clsgs_UserConfigBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.updDate) == false && GetStrLen(pobjgs_UserConfigEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 用户配置(gs_UserConfig))!值:$(pobjgs_UserConfigEN.updDate)(clsgs_UserConfigBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.memo) == false && GetStrLen(pobjgs_UserConfigEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 用户配置(gs_UserConfig))!值:$(pobjgs_UserConfigEN.memo)(clsgs_UserConfigBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_UserConfigEN.configId && undefined !== pobjgs_UserConfigEN.configId && tzDataType.isNumber(pobjgs_UserConfigEN.configId) === false)
{
 throw new Error("(errid:Watl000063)字段[配置Id(configId)]的值:[$(pobjgs_UserConfigEN.configId)], 非法，应该为数值型(In 用户配置(gs_UserConfig))!(clsgs_UserConfigBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.configTypeId) == false && undefined !== pobjgs_UserConfigEN.configTypeId && tzDataType.isString(pobjgs_UserConfigEN.configTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[配置类型Id(configTypeId)]的值:[$(pobjgs_UserConfigEN.configTypeId)], 非法，应该为字符型(In 用户配置(gs_UserConfig))!(clsgs_UserConfigBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.shareId) == false && undefined !== pobjgs_UserConfigEN.shareId && tzDataType.isString(pobjgs_UserConfigEN.shareId) === false)
{
 throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjgs_UserConfigEN.shareId)], 非法，应该为字符型(In 用户配置(gs_UserConfig))!(clsgs_UserConfigBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.updUser) == false && undefined !== pobjgs_UserConfigEN.updUser && tzDataType.isString(pobjgs_UserConfigEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_UserConfigEN.updUser)], 非法，应该为字符型(In 用户配置(gs_UserConfig))!(clsgs_UserConfigBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.updDate) == false && undefined !== pobjgs_UserConfigEN.updDate && tzDataType.isString(pobjgs_UserConfigEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_UserConfigEN.updDate)], 非法，应该为字符型(In 用户配置(gs_UserConfig))!(clsgs_UserConfigBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_UserConfigEN.memo) == false && undefined !== pobjgs_UserConfigEN.memo && tzDataType.isString(pobjgs_UserConfigEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_UserConfigEN.memo)], 非法，应该为字符型(In 用户配置(gs_UserConfig))!(clsgs_UserConfigBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_UserConfigEN.configId 
 || pobjgs_UserConfigEN.configId != null && pobjgs_UserConfigEN.configId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[配置Id]不能为空(In 用户配置)!(clsgs_UserConfigBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_UserConfigEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_UserConfig_GetJSONStrByObj (pobjgs_UserConfigEN: clsgs_UserConfigEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_UserConfigEN.sf_UpdFldSetStr = pobjgs_UserConfigEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_UserConfigEN);
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
export function gs_UserConfig_GetObjLstByJSONStr (strJSON: string): Array<clsgs_UserConfigEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_UserConfigObjLst = new Array<clsgs_UserConfigEN>();
if (strJSON === "")
{
return arrgs_UserConfigObjLst;
}
try
{
arrgs_UserConfigObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_UserConfigObjLst;
}
return arrgs_UserConfigObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_UserConfigObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_UserConfig_GetObjLstByJSONObjLst (arrgs_UserConfigObjLstS: Array<clsgs_UserConfigEN>): Array<clsgs_UserConfigEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_UserConfigObjLst = new Array<clsgs_UserConfigEN>();
for (const objInFor of arrgs_UserConfigObjLstS) {
const obj1 = gs_UserConfig_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_UserConfigObjLst.push(obj1);
}
return arrgs_UserConfigObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_UserConfig_GetObjByJSONStr (strJSON: string): clsgs_UserConfigEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_UserConfigEN = new clsgs_UserConfigEN();
if (strJSON === "")
{
return pobjgs_UserConfigEN;
}
try
{
pobjgs_UserConfigEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_UserConfigEN;
}
return pobjgs_UserConfigEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_UserConfig_GetCombineCondition(objgs_UserConfig_Cond: clsgs_UserConfigEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_UserConfig_Cond.dicFldComparisonOp, clsgs_UserConfigEN.con_ConfigId) == true)
{
const strComparisonOp_ConfigId:string = objgs_UserConfig_Cond.dicFldComparisonOp[clsgs_UserConfigEN.con_ConfigId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_UserConfigEN.con_ConfigId, objgs_UserConfig_Cond.configId, strComparisonOp_ConfigId);
}
if (Object.prototype.hasOwnProperty.call(objgs_UserConfig_Cond.dicFldComparisonOp, clsgs_UserConfigEN.con_ConfigTypeId) == true)
{
const strComparisonOp_ConfigTypeId:string = objgs_UserConfig_Cond.dicFldComparisonOp[clsgs_UserConfigEN.con_ConfigTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_UserConfigEN.con_ConfigTypeId, objgs_UserConfig_Cond.configTypeId, strComparisonOp_ConfigTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_UserConfig_Cond.dicFldComparisonOp, clsgs_UserConfigEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objgs_UserConfig_Cond.dicFldComparisonOp[clsgs_UserConfigEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_UserConfigEN.con_ShareId, objgs_UserConfig_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objgs_UserConfig_Cond.dicFldComparisonOp, clsgs_UserConfigEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_UserConfig_Cond.dicFldComparisonOp[clsgs_UserConfigEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_UserConfigEN.con_UpdUser, objgs_UserConfig_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_UserConfig_Cond.dicFldComparisonOp, clsgs_UserConfigEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_UserConfig_Cond.dicFldComparisonOp[clsgs_UserConfigEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_UserConfigEN.con_UpdDate, objgs_UserConfig_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_UserConfig_Cond.dicFldComparisonOp, clsgs_UserConfigEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_UserConfig_Cond.dicFldComparisonOp[clsgs_UserConfigEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_UserConfigEN.con_Memo, objgs_UserConfig_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_UserConfig(用户配置),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngConfigId: 配置Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_UserConfig_GetUniCondStr_ConfigId(objgs_UserConfigEN: clsgs_UserConfigEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ConfigId = '{0}'", objgs_UserConfigEN.configId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_UserConfig(用户配置),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngConfigId: 配置Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_UserConfig_GetUniCondStr4Update_ConfigId(objgs_UserConfigEN: clsgs_UserConfigEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ConfigId <> '{0}'", objgs_UserConfigEN.configId);
 strWhereCond +=  Format(" and ConfigId = '{0}'", objgs_UserConfigEN.configId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_UserConfigENS:源对象
 * @param objgs_UserConfigENT:目标对象
*/
export function gs_UserConfig_CopyObjTo(objgs_UserConfigENS: clsgs_UserConfigEN , objgs_UserConfigENT: clsgs_UserConfigEN ): void 
{
objgs_UserConfigENT.configId = objgs_UserConfigENS.configId; //配置Id
objgs_UserConfigENT.configTypeId = objgs_UserConfigENS.configTypeId; //配置类型Id
objgs_UserConfigENT.shareId = objgs_UserConfigENS.shareId; //分享Id
objgs_UserConfigENT.updUser = objgs_UserConfigENS.updUser; //修改人
objgs_UserConfigENT.updDate = objgs_UserConfigENS.updDate; //修改日期
objgs_UserConfigENT.memo = objgs_UserConfigENS.memo; //备注
objgs_UserConfigENT.sf_UpdFldSetStr = objgs_UserConfigENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_UserConfigENS:源对象
 * @param objgs_UserConfigENT:目标对象
*/
export function gs_UserConfig_GetObjFromJsonObj(objgs_UserConfigENS: clsgs_UserConfigEN): clsgs_UserConfigEN 
{
 const objgs_UserConfigENT: clsgs_UserConfigEN = new clsgs_UserConfigEN();
ObjectAssign(objgs_UserConfigENT, objgs_UserConfigENS);
 return objgs_UserConfigENT;
}