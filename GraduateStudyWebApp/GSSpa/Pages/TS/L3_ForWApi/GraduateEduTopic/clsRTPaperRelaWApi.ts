
 /**
 * 类名:clsRTPaperRelaWApi
 * 表名:RTPaperRela(01120581)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:01
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
 * RTPaperRela(RTPaperRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsRTPaperRelaEN } from "../../L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const rTPaperRela_Controller = "RTPaperRelaApi";
 export const rTPaperRela_ConstructorName = "rTPaperRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function RTPaperRela_GetObjBymIdAsync(lngmId: number): Promise<clsRTPaperRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objRTPaperRela = RTPaperRela_GetObjFromJsonObj(returnObj);
return objRTPaperRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_GetObjBymId_Cache(lngmId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
try
{
const arrRTPaperRela_Sel: Array <clsRTPaperRelaEN> = arrRTPaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
let objRTPaperRela: clsRTPaperRelaEN;
if (arrRTPaperRela_Sel.length > 0)
{
objRTPaperRela = arrRTPaperRela_Sel[0];
return objRTPaperRela;
}
else
{
if (bolTryAsyncOnce == true)
{
objRTPaperRela = await RTPaperRela_GetObjBymIdAsync(lngmId);
if (objRTPaperRela != null)
{
RTPaperRela_ReFreshThisCache();
return objRTPaperRela;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsRTPaperRelaEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objRTPaperRela_Cache: clsRTPaperRelaEN = JSON.parse(strTempObj);
return objRTPaperRela_Cache;
}
try
{
const objRTPaperRela = await RTPaperRela_GetObjBymIdAsync(lngmId);
if (objRTPaperRela != null)
{
localStorage.setItem(strKey, JSON.stringify(objRTPaperRela));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objRTPaperRela;
}
return objRTPaperRela;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objRTPaperRela:所给的对象
 * @returns 对象
*/
export async function RTPaperRela_UpdateObjInLst_Cache(objRTPaperRela: clsRTPaperRelaEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
const obj = arrRTPaperRelaObjLst_Cache.find(x => x.mId == objRTPaperRela.mId);
if (obj != null)
{
objRTPaperRela.mId = obj.mId;
ObjectAssign( obj, objRTPaperRela);
}
else
{
arrRTPaperRelaObjLst_Cache.push(objRTPaperRela);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsRTPaperRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsRTPaperRelaEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsRTPaperRelaEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objRTPaperRela = await RTPaperRela_GetObjBymId_Cache(lngmId );
if (objRTPaperRela == null) return "";
return objRTPaperRela.GetFldValue(strOutFldName).toString();
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
export function RTPaperRela_SortFun_Defa(a:clsRTPaperRelaEN , b:clsRTPaperRelaEN): number 
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
export function RTPaperRela_SortFun_Defa_2Fld(a:clsRTPaperRelaEN , b:clsRTPaperRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.paperId.localeCompare(b.paperId);
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
export function RTPaperRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsRTPaperRelaEN.con_mId:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return a.mId-b.mId;
}
case clsRTPaperRelaEN.con_TopicId:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsRTPaperRelaEN.con_PaperId:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsRTPaperRelaEN.con_UpdDate:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsRTPaperRelaEN.con_UpdUser:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsRTPaperRelaEN.con_Memo:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return a.memo.localeCompare(b.memo);
}
case clsRTPaperRelaEN.con_id_CurrEduCls:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTPaperRela]中不存在！(in ${ rTPaperRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsRTPaperRelaEN.con_mId:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return b.mId-a.mId;
}
case clsRTPaperRelaEN.con_TopicId:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsRTPaperRelaEN.con_PaperId:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsRTPaperRelaEN.con_UpdDate:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsRTPaperRelaEN.con_UpdUser:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsRTPaperRelaEN.con_Memo:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return b.memo.localeCompare(a.memo);
}
case clsRTPaperRelaEN.con_id_CurrEduCls:
return (a: clsRTPaperRelaEN, b: clsRTPaperRelaEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTPaperRela]中不存在！(in ${ rTPaperRela_ConstructorName}.${ strThisFuncName})`;
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
export async function RTPaperRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsRTPaperRelaEN.con_mId:
return (obj: clsRTPaperRelaEN) => {
return obj.mId === value;
}
case clsRTPaperRelaEN.con_TopicId:
return (obj: clsRTPaperRelaEN) => {
return obj.topicId === value;
}
case clsRTPaperRelaEN.con_PaperId:
return (obj: clsRTPaperRelaEN) => {
return obj.paperId === value;
}
case clsRTPaperRelaEN.con_UpdDate:
return (obj: clsRTPaperRelaEN) => {
return obj.updDate === value;
}
case clsRTPaperRelaEN.con_UpdUser:
return (obj: clsRTPaperRelaEN) => {
return obj.updUser === value;
}
case clsRTPaperRelaEN.con_Memo:
return (obj: clsRTPaperRelaEN) => {
return obj.memo === value;
}
case clsRTPaperRelaEN.con_id_CurrEduCls:
return (obj: clsRTPaperRelaEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTPaperRela]中不存在！(in ${ rTPaperRela_ConstructorName}.${ strThisFuncName})`;
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
export async function RTPaperRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_GetFirstObjAsync(strWhereCond: string): Promise<clsRTPaperRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objRTPaperRela = RTPaperRela_GetObjFromJsonObj(returnObj);
return objRTPaperRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsRTPaperRelaEN._CurrTabName;
clsRTPaperRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsRTPaperRelaEN._CurrTabName);
if (IsNullOrEmpty(clsRTPaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsRTPaperRelaEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrRTPaperRelaExObjLst_Cache: Array<clsRTPaperRelaEN> = CacheHelper.Get(strKey);
const arrRTPaperRelaObjLst_T = RTPaperRela_GetObjLstByJSONObjLst(arrRTPaperRelaExObjLst_Cache);
return arrRTPaperRelaObjLst_T;
}
try
{
const arrRTPaperRelaExObjLst = await RTPaperRela_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrRTPaperRelaExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTPaperRelaExObjLst.length);
console.log(strInfo);
return arrRTPaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTPaperRela_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsRTPaperRelaEN._CurrTabName;
clsRTPaperRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsRTPaperRelaEN._CurrTabName);
if (IsNullOrEmpty(clsRTPaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsRTPaperRelaEN.CacheAddiCondition);
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
const arrRTPaperRelaExObjLst_Cache: Array<clsRTPaperRelaEN> = JSON.parse(strTempObjLst);
const arrRTPaperRelaObjLst_T = RTPaperRela_GetObjLstByJSONObjLst(arrRTPaperRelaExObjLst_Cache);
return arrRTPaperRelaObjLst_T;
}
try
{
const arrRTPaperRelaExObjLst = await RTPaperRela_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrRTPaperRelaExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTPaperRelaExObjLst.length);
console.log(strInfo);
return arrRTPaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTPaperRela_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsRTPaperRelaEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrRTPaperRelaObjLst_Cache: Array<clsRTPaperRelaEN> = JSON.parse(strTempObjLst);
return arrRTPaperRelaObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function RTPaperRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsRTPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsRTPaperRelaEN._CurrTabName;
clsRTPaperRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsRTPaperRelaEN._CurrTabName);
if (IsNullOrEmpty(clsRTPaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsRTPaperRelaEN.CacheAddiCondition);
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
const arrRTPaperRelaExObjLst_Cache: Array<clsRTPaperRelaEN> = JSON.parse(strTempObjLst);
const arrRTPaperRelaObjLst_T = RTPaperRela_GetObjLstByJSONObjLst(arrRTPaperRelaExObjLst_Cache);
return arrRTPaperRelaObjLst_T;
}
try
{
const arrRTPaperRelaExObjLst = await RTPaperRela_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrRTPaperRelaExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTPaperRelaExObjLst.length);
console.log(strInfo);
return arrRTPaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTPaperRela_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsRTPaperRelaEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrRTPaperRelaObjLst_Cache: Array<clsRTPaperRelaEN> = JSON.parse(strTempObjLst);
return arrRTPaperRelaObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTPaperRela_GetObjLst_Cache(): Promise<Array<clsRTPaperRelaEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrRTPaperRelaObjLst_Cache;
switch (clsRTPaperRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_ClientCache();
break;
default:
arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_ClientCache();
break;
}
const arrRTPaperRelaObjLst = RTPaperRela_GetObjLstByJSONObjLst(arrRTPaperRelaObjLst_Cache);
return arrRTPaperRelaObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTPaperRela_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrRTPaperRelaObjLst_Cache;
switch (clsRTPaperRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrRTPaperRelaObjLst_Cache = null;
break;
default:
arrRTPaperRelaObjLst_Cache = null;
break;
}
return arrRTPaperRelaObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function RTPaperRela_GetSubObjLst_Cache(objRTPaperRela_Cond: clsRTPaperRelaEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
let arrRTPaperRela_Sel: Array < clsRTPaperRelaEN > = arrRTPaperRelaObjLst_Cache;
if (objRTPaperRela_Cond.sf_FldComparisonOp == null || objRTPaperRela_Cond.sf_FldComparisonOp == "") return arrRTPaperRela_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objRTPaperRela_Cond.sf_FldComparisonOp);
//console.log("clsRTPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objRTPaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRTPaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrRTPaperRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objRTPaperRela_Cond), rTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsRTPaperRelaEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function RTPaperRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsRTPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
const arrRTPaperRela_Sel: Array <clsRTPaperRelaEN> = arrRTPaperRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrRTPaperRela_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), rTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsRTPaperRelaEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function RTPaperRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsRTPaperRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsRTPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
if (arrRTPaperRelaObjLst_Cache.length == 0) return arrRTPaperRelaObjLst_Cache;
let arrRTPaperRela_Sel = arrRTPaperRelaObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objRTPaperRela_Cond = new clsRTPaperRelaEN();
ObjectAssign(objRTPaperRela_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsRTPaperRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRTPaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrRTPaperRela_Sel.length == 0) return arrRTPaperRela_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrRTPaperRela_Sel = arrRTPaperRela_Sel.sort(RTPaperRela_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrRTPaperRela_Sel = arrRTPaperRela_Sel.sort(objPagerPara.sortFun);
}
arrRTPaperRela_Sel = arrRTPaperRela_Sel.slice(intStart, intEnd);     
return arrRTPaperRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsRTPaperRelaEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function RTPaperRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsRTPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_DelRTPaperRelasAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelRTPaperRelasAsync";
const strAction = "DelRTPaperRelas";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_DelRTPaperRelasByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelRTPaperRelasByCondAsync";
const strAction = "DelRTPaperRelasByCond";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
 * @param objRTPaperRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function RTPaperRela_AddNewRecordAsync(objRTPaperRelaEN: clsRTPaperRelaEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objRTPaperRelaEN);
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTPaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
 * @param objRTPaperRelaEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function RTPaperRela_AddNewRecordWithReturnKeyAsync(objRTPaperRelaEN: clsRTPaperRelaEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTPaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
 * @param objRTPaperRelaEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function RTPaperRela_AddNewRecordWithReturnKey(objRTPaperRelaEN: clsRTPaperRelaEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objRTPaperRelaEN.mId === null || objRTPaperRelaEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTPaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
 * @param objRTPaperRelaEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function RTPaperRela_UpdateRecordAsync(objRTPaperRelaEN: clsRTPaperRelaEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objRTPaperRelaEN.sf_UpdFldSetStr === undefined || objRTPaperRelaEN.sf_UpdFldSetStr === null || objRTPaperRelaEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTPaperRelaEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTPaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
 * @param objRTPaperRelaEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function RTPaperRela_UpdateWithConditionAsync(objRTPaperRelaEN: clsRTPaperRelaEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objRTPaperRelaEN.sf_UpdFldSetStr === undefined || objRTPaperRelaEN.sf_UpdFldSetStr === null || objRTPaperRelaEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTPaperRelaEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
objRTPaperRelaEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objRTPaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_IsExistRecord_Cache(objRTPaperRela_Cond: clsRTPaperRelaEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
if (arrRTPaperRelaObjLst_Cache == null) return false;
let arrRTPaperRela_Sel: Array < clsRTPaperRelaEN > = arrRTPaperRelaObjLst_Cache;
if (objRTPaperRela_Cond.sf_FldComparisonOp == null || objRTPaperRela_Cond.sf_FldComparisonOp == "") return arrRTPaperRela_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objRTPaperRela_Cond.sf_FldComparisonOp);
//console.log("clsRTPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objRTPaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRTPaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrRTPaperRela_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objRTPaperRela_Cond), rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_IsExist_Cache(lngmId:number) {
const strThisFuncName = "IsExist_Cache";
const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
if (arrRTPaperRelaObjLst_Cache == null) return false;
try
{
const arrRTPaperRela_Sel: Array <clsRTPaperRelaEN> = arrRTPaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
if (arrRTPaperRela_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
 * @param objRTPaperRela_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function RTPaperRela_GetRecCountByCond_Cache(objRTPaperRela_Cond: clsRTPaperRelaEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
if (arrRTPaperRelaObjLst_Cache == null) return 0;
let arrRTPaperRela_Sel: Array < clsRTPaperRelaEN > = arrRTPaperRelaObjLst_Cache;
if (objRTPaperRela_Cond.sf_FldComparisonOp == null || objRTPaperRela_Cond.sf_FldComparisonOp == "") return arrRTPaperRela_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objRTPaperRela_Cond.sf_FldComparisonOp);
//console.log("clsRTPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objRTPaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRTPaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrRTPaperRela_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objRTPaperRela_Cond), rTPaperRela_ConstructorName, strThisFuncName);
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
export async function RTPaperRela_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(rTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTPaperRela_ConstructorName, strThisFuncName);
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
export function RTPaperRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function RTPaperRela_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsRTPaperRelaEN._CurrTabName;
switch (clsRTPaperRelaEN.CacheModeId)
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
export function RTPaperRela_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsRTPaperRelaEN._CurrTabName;
switch (clsRTPaperRelaEN.CacheModeId)
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
export function RTPaperRela_CheckPropertyNew(pobjRTPaperRelaEN: clsRTPaperRelaEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjRTPaperRelaEN.topicId) == false && GetStrLen(pobjRTPaperRelaEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.topicId)(clsRTPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.paperId) == false && GetStrLen(pobjRTPaperRelaEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.paperId)(clsRTPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.updDate) == false && GetStrLen(pobjRTPaperRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.updDate)(clsRTPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.updUser) == false && GetStrLen(pobjRTPaperRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.updUser)(clsRTPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.memo) == false && GetStrLen(pobjRTPaperRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.memo)(clsRTPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.id_CurrEduCls) == false && GetStrLen(pobjRTPaperRelaEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.id_CurrEduCls)(clsRTPaperRelaBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjRTPaperRelaEN.mId && undefined !== pobjRTPaperRelaEN.mId && tzDataType.isNumber(pobjRTPaperRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjRTPaperRelaEN.mId)], 非法，应该为数值型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.topicId) == false && undefined !== pobjRTPaperRelaEN.topicId && tzDataType.isString(pobjRTPaperRelaEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjRTPaperRelaEN.topicId)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.paperId) == false && undefined !== pobjRTPaperRelaEN.paperId && tzDataType.isString(pobjRTPaperRelaEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjRTPaperRelaEN.paperId)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.updDate) == false && undefined !== pobjRTPaperRelaEN.updDate && tzDataType.isString(pobjRTPaperRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjRTPaperRelaEN.updDate)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.updUser) == false && undefined !== pobjRTPaperRelaEN.updUser && tzDataType.isString(pobjRTPaperRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjRTPaperRelaEN.updUser)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.memo) == false && undefined !== pobjRTPaperRelaEN.memo && tzDataType.isString(pobjRTPaperRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRTPaperRelaEN.memo)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.id_CurrEduCls) == false && undefined !== pobjRTPaperRelaEN.id_CurrEduCls && tzDataType.isString(pobjRTPaperRelaEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTPaperRelaEN.id_CurrEduCls)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjRTPaperRelaEN.topicId) == false && GetStrLen(pobjRTPaperRelaEN.topicId) !=  8)
{
 throw ("(errid:Watl000061)字段[主题Id]作为外键字段,长度应该为8(In RTPaperRela)!(clsRTPaperRelaBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjRTPaperRelaEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function RTPaperRela_CheckProperty4Update (pobjRTPaperRelaEN: clsRTPaperRelaEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjRTPaperRelaEN.topicId) == false && GetStrLen(pobjRTPaperRelaEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.topicId)(clsRTPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.paperId) == false && GetStrLen(pobjRTPaperRelaEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.paperId)(clsRTPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.updDate) == false && GetStrLen(pobjRTPaperRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.updDate)(clsRTPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.updUser) == false && GetStrLen(pobjRTPaperRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.updUser)(clsRTPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.memo) == false && GetStrLen(pobjRTPaperRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.memo)(clsRTPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.id_CurrEduCls) == false && GetStrLen(pobjRTPaperRelaEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.id_CurrEduCls)(clsRTPaperRelaBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjRTPaperRelaEN.mId && undefined !== pobjRTPaperRelaEN.mId && tzDataType.isNumber(pobjRTPaperRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjRTPaperRelaEN.mId)], 非法，应该为数值型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.topicId) == false && undefined !== pobjRTPaperRelaEN.topicId && tzDataType.isString(pobjRTPaperRelaEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjRTPaperRelaEN.topicId)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.paperId) == false && undefined !== pobjRTPaperRelaEN.paperId && tzDataType.isString(pobjRTPaperRelaEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjRTPaperRelaEN.paperId)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.updDate) == false && undefined !== pobjRTPaperRelaEN.updDate && tzDataType.isString(pobjRTPaperRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjRTPaperRelaEN.updDate)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.updUser) == false && undefined !== pobjRTPaperRelaEN.updUser && tzDataType.isString(pobjRTPaperRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjRTPaperRelaEN.updUser)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.memo) == false && undefined !== pobjRTPaperRelaEN.memo && tzDataType.isString(pobjRTPaperRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRTPaperRelaEN.memo)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTPaperRelaEN.id_CurrEduCls) == false && undefined !== pobjRTPaperRelaEN.id_CurrEduCls && tzDataType.isString(pobjRTPaperRelaEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTPaperRelaEN.id_CurrEduCls)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjRTPaperRelaEN.mId 
 || pobjRTPaperRelaEN.mId != null && pobjRTPaperRelaEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In RTPaperRela)!(clsRTPaperRelaBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjRTPaperRelaEN.topicId) == false && GetStrLen(pobjRTPaperRelaEN.topicId) !=  8)
{
 throw ("(errid:Watl000065)字段[主题Id]作为外键字段,长度应该为8(In RTPaperRela)!(clsRTPaperRelaBL:CheckPropertyNew)");
}

 pobjRTPaperRelaEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function RTPaperRela_GetJSONStrByObj (pobjRTPaperRelaEN: clsRTPaperRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjRTPaperRelaEN.sf_UpdFldSetStr = pobjRTPaperRelaEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjRTPaperRelaEN);
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
export function RTPaperRela_GetObjLstByJSONStr (strJSON: string): Array<clsRTPaperRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrRTPaperRelaObjLst = new Array<clsRTPaperRelaEN>();
if (strJSON === "")
{
return arrRTPaperRelaObjLst;
}
try
{
arrRTPaperRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrRTPaperRelaObjLst;
}
return arrRTPaperRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrRTPaperRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function RTPaperRela_GetObjLstByJSONObjLst (arrRTPaperRelaObjLstS: Array<clsRTPaperRelaEN>): Array<clsRTPaperRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrRTPaperRelaObjLst = new Array<clsRTPaperRelaEN>();
for (const objInFor of arrRTPaperRelaObjLstS) {
const obj1 = RTPaperRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrRTPaperRelaObjLst.push(obj1);
}
return arrRTPaperRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function RTPaperRela_GetObjByJSONStr (strJSON: string): clsRTPaperRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjRTPaperRelaEN = new clsRTPaperRelaEN();
if (strJSON === "")
{
return pobjRTPaperRelaEN;
}
try
{
pobjRTPaperRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjRTPaperRelaEN;
}
return pobjRTPaperRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function RTPaperRela_GetCombineCondition(objRTPaperRela_Cond: clsRTPaperRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsRTPaperRelaEN.con_mId, objRTPaperRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTPaperRelaEN.con_TopicId, objRTPaperRela_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTPaperRelaEN.con_PaperId, objRTPaperRela_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTPaperRelaEN.con_UpdDate, objRTPaperRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTPaperRelaEN.con_UpdUser, objRTPaperRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTPaperRelaEN.con_Memo, objRTPaperRela_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTPaperRelaEN.con_id_CurrEduCls, objRTPaperRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--RTPaperRela(RTPaperRela),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function RTPaperRela_GetUniCondStr_mId(objRTPaperRelaEN: clsRTPaperRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objRTPaperRelaEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--RTPaperRela(RTPaperRela),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function RTPaperRela_GetUniCondStr4Update_mId(objRTPaperRelaEN: clsRTPaperRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objRTPaperRelaEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objRTPaperRelaEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objRTPaperRelaENS:源对象
 * @param objRTPaperRelaENT:目标对象
*/
export function RTPaperRela_CopyObjTo(objRTPaperRelaENS: clsRTPaperRelaEN , objRTPaperRelaENT: clsRTPaperRelaEN ): void 
{
objRTPaperRelaENT.mId = objRTPaperRelaENS.mId; //mId
objRTPaperRelaENT.topicId = objRTPaperRelaENS.topicId; //主题Id
objRTPaperRelaENT.paperId = objRTPaperRelaENS.paperId; //论文Id
objRTPaperRelaENT.updDate = objRTPaperRelaENS.updDate; //修改日期
objRTPaperRelaENT.updUser = objRTPaperRelaENS.updUser; //修改人
objRTPaperRelaENT.memo = objRTPaperRelaENS.memo; //备注
objRTPaperRelaENT.id_CurrEduCls = objRTPaperRelaENS.id_CurrEduCls; //教学班流水号
objRTPaperRelaENT.sf_UpdFldSetStr = objRTPaperRelaENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objRTPaperRelaENS:源对象
 * @param objRTPaperRelaENT:目标对象
*/
export function RTPaperRela_GetObjFromJsonObj(objRTPaperRelaENS: clsRTPaperRelaEN): clsRTPaperRelaEN 
{
 const objRTPaperRelaENT: clsRTPaperRelaEN = new clsRTPaperRelaEN();
ObjectAssign(objRTPaperRelaENT, objRTPaperRelaENS);
 return objRTPaperRelaENT;
}