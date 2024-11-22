
 /**
 * 类名:clsRTTopicObjectiveRelaWApi
 * 表名:RTTopicObjectiveRela(01120615)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:49:23
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
 * 主题客观关系表(RTTopicObjectiveRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsRTTopicObjectiveRelaEN } from "../../L0_Entity/GraduateEduTopic/clsRTTopicObjectiveRelaEN.js";
import { vRTTopicObjectiveRela_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTopic/clsvRTTopicObjectiveRelaWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const rTTopicObjectiveRela_Controller = "RTTopicObjectiveRelaApi";
 export const rTTopicObjectiveRela_ConstructorName = "rTTopicObjectiveRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function RTTopicObjectiveRela_GetObjBymIdAsync(lngmId: number): Promise<clsRTTopicObjectiveRelaEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsRTTopicObjectiveRelaWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objRTTopicObjectiveRela = RTTopicObjectiveRela_GetObjFromJsonObj(returnObj);
return objRTTopicObjectiveRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_GetObjBymId_Cache(lngmId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsRTTopicObjectiveRelaWApi.GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_Cache();
try
{
const arrRTTopicObjectiveRela_Sel: Array <clsRTTopicObjectiveRelaEN> = arrRTTopicObjectiveRelaObjLst_Cache.filter(x => 
 x.mId == lngmId );
let objRTTopicObjectiveRela: clsRTTopicObjectiveRelaEN;
if (arrRTTopicObjectiveRela_Sel.length > 0)
{
objRTTopicObjectiveRela = arrRTTopicObjectiveRela_Sel[0];
return objRTTopicObjectiveRela;
}
else
{
if (bolTryAsyncOnce == true)
{
const objRTTopicObjectiveRela_Const = await RTTopicObjectiveRela_GetObjBymIdAsync(lngmId);
if (objRTTopicObjectiveRela_Const != null)
{
RTTopicObjectiveRela_ReFreshThisCache();
return objRTTopicObjectiveRela_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsRTTopicObjectiveRelaWApi.GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsRTTopicObjectiveRelaEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objRTTopicObjectiveRela_Cache: clsRTTopicObjectiveRelaEN = JSON.parse(strTempObj);
return objRTTopicObjectiveRela_Cache;
}
try
{
const objRTTopicObjectiveRela = await RTTopicObjectiveRela_GetObjBymIdAsync(lngmId);
if (objRTTopicObjectiveRela != null)
{
localStorage.setItem(strKey, JSON.stringify(objRTTopicObjectiveRela));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objRTTopicObjectiveRela;
}
return objRTTopicObjectiveRela;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objRTTopicObjectiveRela:所给的对象
 * @returns 对象
*/
export async function RTTopicObjectiveRela_UpdateObjInLst_Cache(objRTTopicObjectiveRela: clsRTTopicObjectiveRelaEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_Cache();
const obj = arrRTTopicObjectiveRelaObjLst_Cache.find(x => x.mId == objRTTopicObjectiveRela.mId && x.topicId == objRTTopicObjectiveRela.topicId && x.topicObjectiveId == objRTTopicObjectiveRela.topicObjectiveId);
if (obj != null)
{
objRTTopicObjectiveRela.mId = obj.mId;
ObjectAssign( obj, objRTTopicObjectiveRela);
}
else
{
arrRTTopicObjectiveRelaObjLst_Cache.push(objRTTopicObjectiveRela);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}
/*该表没有名称字段，不能生成此函数！*/

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 * @returns 返回一个输出字段值
*/
export async function RTTopicObjectiveRela_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsRTTopicObjectiveRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsRTTopicObjectiveRelaEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsRTTopicObjectiveRelaEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objRTTopicObjectiveRela = await RTTopicObjectiveRela_GetObjBymId_Cache(lngmId );
if (objRTTopicObjectiveRela == null) return "";
if (objRTTopicObjectiveRela.GetFldValue(strOutFldName) == null) return "";
return objRTTopicObjectiveRela.GetFldValue(strOutFldName).toString();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function RTTopicObjectiveRela_SortFun_Defa(a:clsRTTopicObjectiveRelaEN , b:clsRTTopicObjectiveRelaEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
}
/**
 * 排序函数。根据表对象中随机两个字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param  a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function RTTopicObjectiveRela_SortFun_Defa_2Fld(a:clsRTTopicObjectiveRelaEN , b:clsRTTopicObjectiveRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
else return a.topicId.localeCompare(b.topicId);
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function RTTopicObjectiveRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsRTTopicObjectiveRelaEN.con_mId:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
return a.mId-b.mId;
}
case clsRTTopicObjectiveRelaEN.con_TopicId:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
if (a.topicId == null) return -1;
if (b.topicId == null) return 1;
return a.topicId.localeCompare(b.topicId);
}
case clsRTTopicObjectiveRelaEN.con_TopicObjectiveId:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
}
case clsRTTopicObjectiveRelaEN.con_UpdDate:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsRTTopicObjectiveRelaEN.con_UpdUser:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsRTTopicObjectiveRelaEN.con_Memo:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsRTTopicObjectiveRelaEN.con_ClassificationId:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
if (a.classificationId == null) return -1;
if (b.classificationId == null) return 1;
return a.classificationId.localeCompare(b.classificationId);
}
case clsRTTopicObjectiveRelaEN.con_id_CurrEduCls:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTTopicObjectiveRela]中不存在！(in ${ rTTopicObjectiveRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsRTTopicObjectiveRelaEN.con_mId:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
return b.mId-a.mId;
}
case clsRTTopicObjectiveRelaEN.con_TopicId:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
if (b.topicId == null) return -1;
if (a.topicId == null) return 1;
return b.topicId.localeCompare(a.topicId);
}
case clsRTTopicObjectiveRelaEN.con_TopicObjectiveId:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
}
case clsRTTopicObjectiveRelaEN.con_UpdDate:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsRTTopicObjectiveRelaEN.con_UpdUser:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsRTTopicObjectiveRelaEN.con_Memo:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsRTTopicObjectiveRelaEN.con_ClassificationId:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
if (b.classificationId == null) return -1;
if (a.classificationId == null) return 1;
return b.classificationId.localeCompare(a.classificationId);
}
case clsRTTopicObjectiveRelaEN.con_id_CurrEduCls:
return (a: clsRTTopicObjectiveRelaEN, b: clsRTTopicObjectiveRelaEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTTopicObjectiveRela]中不存在！(in ${ rTTopicObjectiveRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function RTTopicObjectiveRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsRTTopicObjectiveRelaEN.con_mId:
return (obj: clsRTTopicObjectiveRelaEN) => {
return obj.mId === value;
}
case clsRTTopicObjectiveRelaEN.con_TopicId:
return (obj: clsRTTopicObjectiveRelaEN) => {
return obj.topicId === value;
}
case clsRTTopicObjectiveRelaEN.con_TopicObjectiveId:
return (obj: clsRTTopicObjectiveRelaEN) => {
return obj.topicObjectiveId === value;
}
case clsRTTopicObjectiveRelaEN.con_UpdDate:
return (obj: clsRTTopicObjectiveRelaEN) => {
return obj.updDate === value;
}
case clsRTTopicObjectiveRelaEN.con_UpdUser:
return (obj: clsRTTopicObjectiveRelaEN) => {
return obj.updUser === value;
}
case clsRTTopicObjectiveRelaEN.con_Memo:
return (obj: clsRTTopicObjectiveRelaEN) => {
return obj.memo === value;
}
case clsRTTopicObjectiveRelaEN.con_ClassificationId:
return (obj: clsRTTopicObjectiveRelaEN) => {
return obj.classificationId === value;
}
case clsRTTopicObjectiveRelaEN.con_id_CurrEduCls:
return (obj: clsRTTopicObjectiveRelaEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTTopicObjectiveRela]中不存在！(in ${ rTTopicObjectiveRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
 * @param strInFldName:输入字段名
 * @param strInValue:输入字段值
 * @param strComparisonOp:比较操作符
 * @returns 返回一个关键字值列表
*/
export async function RTTopicObjectiveRela_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<number>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsRTTopicObjectiveRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrRTTopicObjectiveRela = await RTTopicObjectiveRela_GetObjLst_Cache();
if (arrRTTopicObjectiveRela == null) return [];
let arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrRTTopicObjectiveRela_Sel.length == 0) return [];
return arrRTTopicObjectiveRela_Sel.map(x=>x.mId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function RTTopicObjectiveRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_GetFirstObjAsync(strWhereCond: string): Promise<clsRTTopicObjectiveRelaEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objRTTopicObjectiveRela = RTTopicObjectiveRela_GetObjFromJsonObj(returnObj);
return objRTTopicObjectiveRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsRTTopicObjectiveRelaEN._CurrTabName;
if (IsNullOrEmpty(clsRTTopicObjectiveRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsRTTopicObjectiveRelaEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrRTTopicObjectiveRelaExObjLst_Cache: Array<clsRTTopicObjectiveRelaEN> = CacheHelper.Get(strKey);
const arrRTTopicObjectiveRelaObjLst_T = RTTopicObjectiveRela_GetObjLstByJSONObjLst(arrRTTopicObjectiveRelaExObjLst_Cache);
return arrRTTopicObjectiveRelaObjLst_T;
}
try
{
const arrRTTopicObjectiveRelaExObjLst = await RTTopicObjectiveRela_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrRTTopicObjectiveRelaExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTTopicObjectiveRelaExObjLst.length);
console.log(strInfo);
return arrRTTopicObjectiveRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTTopicObjectiveRela_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsRTTopicObjectiveRelaEN._CurrTabName;
if (IsNullOrEmpty(clsRTTopicObjectiveRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsRTTopicObjectiveRelaEN.CacheAddiCondition);
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
const arrRTTopicObjectiveRelaExObjLst_Cache: Array<clsRTTopicObjectiveRelaEN> = JSON.parse(strTempObjLst);
const arrRTTopicObjectiveRelaObjLst_T = RTTopicObjectiveRela_GetObjLstByJSONObjLst(arrRTTopicObjectiveRelaExObjLst_Cache);
return arrRTTopicObjectiveRelaObjLst_T;
}
try
{
const arrRTTopicObjectiveRelaExObjLst = await RTTopicObjectiveRela_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrRTTopicObjectiveRelaExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTTopicObjectiveRelaExObjLst.length);
console.log(strInfo);
return arrRTTopicObjectiveRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTTopicObjectiveRela_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsRTTopicObjectiveRelaEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrRTTopicObjectiveRelaObjLst_Cache: Array<clsRTTopicObjectiveRelaEN> = JSON.parse(strTempObjLst);
return arrRTTopicObjectiveRelaObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function RTTopicObjectiveRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsRTTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsRTTopicObjectiveRelaEN._CurrTabName;
if (IsNullOrEmpty(clsRTTopicObjectiveRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsRTTopicObjectiveRelaEN.CacheAddiCondition);
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
const arrRTTopicObjectiveRelaExObjLst_Cache: Array<clsRTTopicObjectiveRelaEN> = JSON.parse(strTempObjLst);
const arrRTTopicObjectiveRelaObjLst_T = RTTopicObjectiveRela_GetObjLstByJSONObjLst(arrRTTopicObjectiveRelaExObjLst_Cache);
return arrRTTopicObjectiveRelaObjLst_T;
}
try
{
const arrRTTopicObjectiveRelaExObjLst = await RTTopicObjectiveRela_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrRTTopicObjectiveRelaExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTTopicObjectiveRelaExObjLst.length);
console.log(strInfo);
return arrRTTopicObjectiveRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTTopicObjectiveRela_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsRTTopicObjectiveRelaEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrRTTopicObjectiveRelaObjLst_Cache: Array<clsRTTopicObjectiveRelaEN> = JSON.parse(strTempObjLst);
return arrRTTopicObjectiveRelaObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTTopicObjectiveRela_GetObjLst_Cache(): Promise<Array<clsRTTopicObjectiveRelaEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrRTTopicObjectiveRelaObjLst_Cache;
switch (clsRTTopicObjectiveRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_ClientCache();
break;
default:
arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_ClientCache();
break;
}
const arrRTTopicObjectiveRelaObjLst = RTTopicObjectiveRela_GetObjLstByJSONObjLst(arrRTTopicObjectiveRelaObjLst_Cache);
return arrRTTopicObjectiveRelaObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTTopicObjectiveRela_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrRTTopicObjectiveRelaObjLst_Cache;
switch (clsRTTopicObjectiveRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrRTTopicObjectiveRelaObjLst_Cache = null;
break;
default:
arrRTTopicObjectiveRelaObjLst_Cache = null;
break;
}
return arrRTTopicObjectiveRelaObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function RTTopicObjectiveRela_GetSubObjLst_Cache(objRTTopicObjectiveRela_Cond: clsRTTopicObjectiveRelaEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_Cache();
let arrRTTopicObjectiveRela_Sel: Array < clsRTTopicObjectiveRelaEN > = arrRTTopicObjectiveRelaObjLst_Cache;
if (objRTTopicObjectiveRela_Cond.sf_FldComparisonOp == null || objRTTopicObjectiveRela_Cond.sf_FldComparisonOp == "") return arrRTTopicObjectiveRela_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objRTTopicObjectiveRela_Cond.sf_FldComparisonOp);
//console.log("clsRTTopicObjectiveRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objRTTopicObjectiveRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRTTopicObjectiveRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrRTTopicObjectiveRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objRTTopicObjectiveRela_Cond), rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsRTTopicObjectiveRelaEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function RTTopicObjectiveRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsRTTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_Cache();
const arrRTTopicObjectiveRela_Sel: Array <clsRTTopicObjectiveRelaEN> = arrRTTopicObjectiveRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrRTTopicObjectiveRela_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function RTTopicObjectiveRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsRTTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsRTTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsRTTopicObjectiveRelaEN>();
const arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_Cache();
if (arrRTTopicObjectiveRelaObjLst_Cache.length == 0) return arrRTTopicObjectiveRelaObjLst_Cache;
let arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRelaObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objRTTopicObjectiveRela_Cond = new clsRTTopicObjectiveRelaEN();
ObjectAssign(objRTTopicObjectiveRela_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsRTTopicObjectiveRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRTTopicObjectiveRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrRTTopicObjectiveRela_Sel.length == 0) return arrRTTopicObjectiveRela_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.sort(RTTopicObjectiveRela_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.sort(objPagerPara.sortFun);
}
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.slice(intStart, intEnd);     
return arrRTTopicObjectiveRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsRTTopicObjectiveRelaEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function RTTopicObjectiveRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsRTTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsRTTopicObjectiveRelaEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
try
{
const response = await axios.delete(strUrl);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_DelRTTopicObjectiveRelasAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelRTTopicObjectiveRelasAsync";
const strAction = "DelRTTopicObjectiveRelas";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_DelRTTopicObjectiveRelasByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelRTTopicObjectiveRelasByCondAsync";
const strAction = "DelRTTopicObjectiveRelasByCond";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @param objRTTopicObjectiveRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function RTTopicObjectiveRela_AddNewRecordAsync(objRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objRTTopicObjectiveRelaEN);
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTTopicObjectiveRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @param objRTTopicObjectiveRelaEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function RTTopicObjectiveRela_AddNewRecordWithReturnKeyAsync(objRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTTopicObjectiveRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @param objRTTopicObjectiveRelaEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function RTTopicObjectiveRela_AddNewRecordWithReturnKey(objRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objRTTopicObjectiveRelaEN.mId === null || objRTTopicObjectiveRelaEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTTopicObjectiveRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @param objRTTopicObjectiveRelaEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function RTTopicObjectiveRela_UpdateRecordAsync(objRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objRTTopicObjectiveRelaEN.sfUpdFldSetStr === undefined || objRTTopicObjectiveRelaEN.sfUpdFldSetStr === null || objRTTopicObjectiveRelaEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTTopicObjectiveRelaEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTTopicObjectiveRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @param objRTTopicObjectiveRelaEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function RTTopicObjectiveRela_UpdateWithConditionAsync(objRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objRTTopicObjectiveRelaEN.sfUpdFldSetStr === undefined || objRTTopicObjectiveRelaEN.sfUpdFldSetStr === null || objRTTopicObjectiveRelaEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTTopicObjectiveRelaEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
objRTTopicObjectiveRelaEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objRTTopicObjectiveRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_IsExistRecord_Cache(objRTTopicObjectiveRela_Cond: clsRTTopicObjectiveRelaEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_Cache();
if (arrRTTopicObjectiveRelaObjLst_Cache == null) return false;
let arrRTTopicObjectiveRela_Sel: Array < clsRTTopicObjectiveRelaEN > = arrRTTopicObjectiveRelaObjLst_Cache;
if (objRTTopicObjectiveRela_Cond.sf_FldComparisonOp == null || objRTTopicObjectiveRela_Cond.sf_FldComparisonOp == "") return arrRTTopicObjectiveRela_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objRTTopicObjectiveRela_Cond.sf_FldComparisonOp);
//console.log("clsRTTopicObjectiveRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objRTTopicObjectiveRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRTTopicObjectiveRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrRTTopicObjectiveRela_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objRTTopicObjectiveRela_Cond), rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_IsExist_Cache(lngmId:number) {
const strThisFuncName = "IsExist_Cache";
const arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_Cache();
if (arrRTTopicObjectiveRelaObjLst_Cache == null) return false;
try
{
const arrRTTopicObjectiveRela_Sel: Array <clsRTTopicObjectiveRelaEN> = arrRTTopicObjectiveRelaObjLst_Cache.filter(x => x.mId == lngmId);
if (arrRTTopicObjectiveRela_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @param objRTTopicObjectiveRela_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function RTTopicObjectiveRela_GetRecCountByCond_Cache(objRTTopicObjectiveRela_Cond: clsRTTopicObjectiveRelaEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrRTTopicObjectiveRelaObjLst_Cache = await RTTopicObjectiveRela_GetObjLst_Cache();
if (arrRTTopicObjectiveRelaObjLst_Cache == null) return 0;
let arrRTTopicObjectiveRela_Sel: Array < clsRTTopicObjectiveRelaEN > = arrRTTopicObjectiveRelaObjLst_Cache;
if (objRTTopicObjectiveRela_Cond.sf_FldComparisonOp == null || objRTTopicObjectiveRela_Cond.sf_FldComparisonOp == "") return arrRTTopicObjectiveRela_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objRTTopicObjectiveRela_Cond.sf_FldComparisonOp);
//console.log("clsRTTopicObjectiveRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objRTTopicObjectiveRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRTTopicObjectiveRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRTTopicObjectiveRela_Sel = arrRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrRTTopicObjectiveRela_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objRTTopicObjectiveRela_Cond), rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function RTTopicObjectiveRela_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(rTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export function RTTopicObjectiveRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function RTTopicObjectiveRela_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsRTTopicObjectiveRelaEN._CurrTabName;
switch (clsRTTopicObjectiveRelaEN.CacheModeId)
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
vRTTopicObjectiveRela_ReFreshThisCache();
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function RTTopicObjectiveRela_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsRTTopicObjectiveRelaEN._CurrTabName;
switch (clsRTTopicObjectiveRelaEN.CacheModeId)
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
export function RTTopicObjectiveRela_CheckPropertyNew(pobjRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.topicObjectiveId) === true )
{
 throw new Error("(errid:Watl000058)字段[客观Id]不能为空(In 主题客观关系表)!(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.updUser) === true )
{
 throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 主题客观关系表)!(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.topicId) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.topicId)(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.topicObjectiveId) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.topicObjectiveId) > 8)
{
 throw new Error("(errid:Watl000059)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.topicObjectiveId)(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.updDate) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.updDate)(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.updUser) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.updUser)(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.memo) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.memo)(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.classificationId) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.classificationId) > 10)
{
 throw new Error("(errid:Watl000059)字段[分类Id(classificationId)]的长度不能超过10(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.classificationId)(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.id_CurrEduCls) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.id_CurrEduCls)(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjRTTopicObjectiveRelaEN.mId && undefined !== pobjRTTopicObjectiveRelaEN.mId && tzDataType.isNumber(pobjRTTopicObjectiveRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjRTTopicObjectiveRelaEN.mId)], 非法，应该为数值型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.topicId) == false && undefined !== pobjRTTopicObjectiveRelaEN.topicId && tzDataType.isString(pobjRTTopicObjectiveRelaEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjRTTopicObjectiveRelaEN.topicId)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.topicObjectiveId) == false && undefined !== pobjRTTopicObjectiveRelaEN.topicObjectiveId && tzDataType.isString(pobjRTTopicObjectiveRelaEN.topicObjectiveId) === false)
{
 throw new Error("(errid:Watl000060)字段[客观Id(topicObjectiveId)]的值:[$(pobjRTTopicObjectiveRelaEN.topicObjectiveId)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.updDate) == false && undefined !== pobjRTTopicObjectiveRelaEN.updDate && tzDataType.isString(pobjRTTopicObjectiveRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjRTTopicObjectiveRelaEN.updDate)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.updUser) == false && undefined !== pobjRTTopicObjectiveRelaEN.updUser && tzDataType.isString(pobjRTTopicObjectiveRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjRTTopicObjectiveRelaEN.updUser)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.memo) == false && undefined !== pobjRTTopicObjectiveRelaEN.memo && tzDataType.isString(pobjRTTopicObjectiveRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRTTopicObjectiveRelaEN.memo)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.classificationId) == false && undefined !== pobjRTTopicObjectiveRelaEN.classificationId && tzDataType.isString(pobjRTTopicObjectiveRelaEN.classificationId) === false)
{
 throw new Error("(errid:Watl000060)字段[分类Id(classificationId)]的值:[$(pobjRTTopicObjectiveRelaEN.classificationId)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.id_CurrEduCls) == false && undefined !== pobjRTTopicObjectiveRelaEN.id_CurrEduCls && tzDataType.isString(pobjRTTopicObjectiveRelaEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTTopicObjectiveRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjRTTopicObjectiveRelaEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function RTTopicObjectiveRela_CheckProperty4Update (pobjRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.topicId) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.topicId)(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.topicObjectiveId) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.topicObjectiveId) > 8)
{
 throw new Error("(errid:Watl000062)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.topicObjectiveId)(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.updDate) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.updDate)(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.updUser) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.updUser)(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.memo) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.memo)(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.classificationId) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.classificationId) > 10)
{
 throw new Error("(errid:Watl000062)字段[分类Id(classificationId)]的长度不能超过10(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.classificationId)(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.id_CurrEduCls) == false && GetStrLen(pobjRTTopicObjectiveRelaEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题客观关系表(RTTopicObjectiveRela))!值:$(pobjRTTopicObjectiveRelaEN.id_CurrEduCls)(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjRTTopicObjectiveRelaEN.mId && undefined !== pobjRTTopicObjectiveRelaEN.mId && tzDataType.isNumber(pobjRTTopicObjectiveRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjRTTopicObjectiveRelaEN.mId)], 非法，应该为数值型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.topicId) == false && undefined !== pobjRTTopicObjectiveRelaEN.topicId && tzDataType.isString(pobjRTTopicObjectiveRelaEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjRTTopicObjectiveRelaEN.topicId)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.topicObjectiveId) == false && undefined !== pobjRTTopicObjectiveRelaEN.topicObjectiveId && tzDataType.isString(pobjRTTopicObjectiveRelaEN.topicObjectiveId) === false)
{
 throw new Error("(errid:Watl000063)字段[客观Id(topicObjectiveId)]的值:[$(pobjRTTopicObjectiveRelaEN.topicObjectiveId)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.updDate) == false && undefined !== pobjRTTopicObjectiveRelaEN.updDate && tzDataType.isString(pobjRTTopicObjectiveRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjRTTopicObjectiveRelaEN.updDate)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.updUser) == false && undefined !== pobjRTTopicObjectiveRelaEN.updUser && tzDataType.isString(pobjRTTopicObjectiveRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjRTTopicObjectiveRelaEN.updUser)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.memo) == false && undefined !== pobjRTTopicObjectiveRelaEN.memo && tzDataType.isString(pobjRTTopicObjectiveRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRTTopicObjectiveRelaEN.memo)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.classificationId) == false && undefined !== pobjRTTopicObjectiveRelaEN.classificationId && tzDataType.isString(pobjRTTopicObjectiveRelaEN.classificationId) === false)
{
 throw new Error("(errid:Watl000063)字段[分类Id(classificationId)]的值:[$(pobjRTTopicObjectiveRelaEN.classificationId)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTTopicObjectiveRelaEN.id_CurrEduCls) == false && undefined !== pobjRTTopicObjectiveRelaEN.id_CurrEduCls && tzDataType.isString(pobjRTTopicObjectiveRelaEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTTopicObjectiveRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 主题客观关系表(RTTopicObjectiveRela))!(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjRTTopicObjectiveRelaEN.mId 
 || pobjRTTopicObjectiveRelaEN.mId != null && pobjRTTopicObjectiveRelaEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 主题客观关系表)!(clsRTTopicObjectiveRelaBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjRTTopicObjectiveRelaEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function RTTopicObjectiveRela_GetJSONStrByObj (pobjRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjRTTopicObjectiveRelaEN.sfUpdFldSetStr = pobjRTTopicObjectiveRelaEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjRTTopicObjectiveRelaEN);
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
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象列表
*/
export function RTTopicObjectiveRela_GetObjLstByJSONStr (strJSON: string): Array<clsRTTopicObjectiveRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrRTTopicObjectiveRelaObjLst = new Array<clsRTTopicObjectiveRelaEN>();
if (strJSON === "")
{
return arrRTTopicObjectiveRelaObjLst;
}
try
{
arrRTTopicObjectiveRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrRTTopicObjectiveRelaObjLst;
}
return arrRTTopicObjectiveRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrRTTopicObjectiveRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function RTTopicObjectiveRela_GetObjLstByJSONObjLst (arrRTTopicObjectiveRelaObjLstS: Array<clsRTTopicObjectiveRelaEN>): Array<clsRTTopicObjectiveRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrRTTopicObjectiveRelaObjLst = new Array<clsRTTopicObjectiveRelaEN>();
for (const objInFor of arrRTTopicObjectiveRelaObjLstS) {
const obj1 = RTTopicObjectiveRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrRTTopicObjectiveRelaObjLst.push(obj1);
}
return arrRTTopicObjectiveRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function RTTopicObjectiveRela_GetObjByJSONStr (strJSON: string): clsRTTopicObjectiveRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjRTTopicObjectiveRelaEN = new clsRTTopicObjectiveRelaEN();
if (strJSON === "")
{
return pobjRTTopicObjectiveRelaEN;
}
try
{
pobjRTTopicObjectiveRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjRTTopicObjectiveRelaEN;
}
return pobjRTTopicObjectiveRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function RTTopicObjectiveRela_GetCombineCondition(objRTTopicObjectiveRela_Cond: clsRTTopicObjectiveRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsRTTopicObjectiveRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsRTTopicObjectiveRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsRTTopicObjectiveRelaEN.con_mId, objRTTopicObjectiveRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsRTTopicObjectiveRelaEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsRTTopicObjectiveRelaEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTTopicObjectiveRelaEN.con_TopicId, objRTTopicObjectiveRela_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsRTTopicObjectiveRelaEN.con_TopicObjectiveId) == true)
{
const strComparisonOp_TopicObjectiveId:string = objRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsRTTopicObjectiveRelaEN.con_TopicObjectiveId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTTopicObjectiveRelaEN.con_TopicObjectiveId, objRTTopicObjectiveRela_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
}
if (Object.prototype.hasOwnProperty.call(objRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsRTTopicObjectiveRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsRTTopicObjectiveRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTTopicObjectiveRelaEN.con_UpdDate, objRTTopicObjectiveRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsRTTopicObjectiveRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsRTTopicObjectiveRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTTopicObjectiveRelaEN.con_UpdUser, objRTTopicObjectiveRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsRTTopicObjectiveRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsRTTopicObjectiveRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTTopicObjectiveRelaEN.con_Memo, objRTTopicObjectiveRela_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsRTTopicObjectiveRelaEN.con_ClassificationId) == true)
{
const strComparisonOp_ClassificationId:string = objRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsRTTopicObjectiveRelaEN.con_ClassificationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTTopicObjectiveRelaEN.con_ClassificationId, objRTTopicObjectiveRela_Cond.classificationId, strComparisonOp_ClassificationId);
}
if (Object.prototype.hasOwnProperty.call(objRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsRTTopicObjectiveRelaEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsRTTopicObjectiveRelaEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTTopicObjectiveRelaEN.con_id_CurrEduCls, objRTTopicObjectiveRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--RTTopicObjectiveRela(主题客观关系表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @param strTopicObjectiveId: 客观Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function RTTopicObjectiveRela_GetUniCondStr_mId_TopicId_TopicObjectiveId(objRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objRTTopicObjectiveRelaEN.mId);
 strWhereCond +=  Format(" and TopicId = '{0}'", objRTTopicObjectiveRelaEN.topicId);
 strWhereCond +=  Format(" and TopicObjectiveId = '{0}'", objRTTopicObjectiveRelaEN.topicObjectiveId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--RTTopicObjectiveRela(主题客观关系表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @param strTopicObjectiveId: 客观Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function RTTopicObjectiveRela_GetUniCondStr4Update_mId_TopicId_TopicObjectiveId(objRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objRTTopicObjectiveRelaEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objRTTopicObjectiveRelaEN.mId);
 strWhereCond +=  Format(" and TopicId = '{0}'", objRTTopicObjectiveRelaEN.topicId);
 strWhereCond +=  Format(" and TopicObjectiveId = '{0}'", objRTTopicObjectiveRelaEN.topicObjectiveId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objRTTopicObjectiveRelaENS:源对象
 * @param objRTTopicObjectiveRelaENT:目标对象
*/
export function RTTopicObjectiveRela_CopyObjTo(objRTTopicObjectiveRelaENS: clsRTTopicObjectiveRelaEN , objRTTopicObjectiveRelaENT: clsRTTopicObjectiveRelaEN ): void 
{
objRTTopicObjectiveRelaENT.mId = objRTTopicObjectiveRelaENS.mId; //mId
objRTTopicObjectiveRelaENT.topicId = objRTTopicObjectiveRelaENS.topicId; //主题Id
objRTTopicObjectiveRelaENT.topicObjectiveId = objRTTopicObjectiveRelaENS.topicObjectiveId; //客观Id
objRTTopicObjectiveRelaENT.updDate = objRTTopicObjectiveRelaENS.updDate; //修改日期
objRTTopicObjectiveRelaENT.updUser = objRTTopicObjectiveRelaENS.updUser; //修改人
objRTTopicObjectiveRelaENT.memo = objRTTopicObjectiveRelaENS.memo; //备注
objRTTopicObjectiveRelaENT.classificationId = objRTTopicObjectiveRelaENS.classificationId; //分类Id
objRTTopicObjectiveRelaENT.id_CurrEduCls = objRTTopicObjectiveRelaENS.id_CurrEduCls; //教学班流水号
objRTTopicObjectiveRelaENT.sfUpdFldSetStr = objRTTopicObjectiveRelaENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objRTTopicObjectiveRelaENS:源对象
 * @param objRTTopicObjectiveRelaENT:目标对象
*/
export function RTTopicObjectiveRela_GetObjFromJsonObj(objRTTopicObjectiveRelaENS: clsRTTopicObjectiveRelaEN): clsRTTopicObjectiveRelaEN 
{
 const objRTTopicObjectiveRelaENT: clsRTTopicObjectiveRelaEN = new clsRTTopicObjectiveRelaEN();
ObjectAssign(objRTTopicObjectiveRelaENT, objRTTopicObjectiveRelaENS);
 return objRTTopicObjectiveRelaENT;
}