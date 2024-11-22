
 /**
 * 类名:clsvSysCountWApi
 * 表名:vSysCount(01120626)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/15 23:44:04
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 数据统计视图(vSysCount)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月15日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsvSysCountEN } from "../../L0_Entity/GraduateEduTools/clsvSysCountEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vSysCount_Controller = "vSysCountApi";
 export const vSysCount_ConstructorName = "vSysCount";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strCountId:关键字
 * @returns 对象
 **/
export async function vSysCount_GetObjByCountIdAsync(strCountId: string): Promise<clsvSysCountEN|null>  
{
const strThisFuncName = "GetObjByCountIdAsync";

if (IsNullOrEmpty(strCountId) == true)
{
  const strMsg = Format("参数:[strCountId]不能为空！(In clsvSysCountWApi.GetObjByCountIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strCountId.length != 10)
{
const strMsg = Format("缓存分类变量:[strCountId]的长度:[{0}]不正确！(clsvSysCountWApi.GetObjByCountIdAsync)", strCountId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByCountId";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strCountId": strCountId,
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
const objvSysCount = vSysCount_GetObjFromJsonObj(returnObj);
return objvSysCount;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vSysCount_SortFun_Defa(a:clsvSysCountEN , b:clsvSysCountEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.countId.localeCompare(b.countId);
}
/**
 * 排序函数。根据表对象中随机两个字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param  a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vSysCount_SortFun_Defa_2Fld(a:clsvSysCountEN , b:clsvSysCountEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.countTypeId == b.countTypeId) return a.commentTypeName.localeCompare(b.commentTypeName);
else return a.countTypeId.localeCompare(b.countTypeId);
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vSysCount_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvSysCountEN.con_CountId:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return a.countId.localeCompare(b.countId);
}
case clsvSysCountEN.con_CountTypeId:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (a.countTypeId == null) return -1;
if (b.countTypeId == null) return 1;
return a.countTypeId.localeCompare(b.countTypeId);
}
case clsvSysCountEN.con_CommentTypeName:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (a.commentTypeName == null) return -1;
if (b.commentTypeName == null) return 1;
return a.commentTypeName.localeCompare(b.commentTypeName);
}
case clsvSysCountEN.con_CommentTable:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (a.commentTable == null) return -1;
if (b.commentTable == null) return 1;
return a.commentTable.localeCompare(b.commentTable);
}
case clsvSysCountEN.con_OkCount:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return a.okCount-b.okCount;
}
case clsvSysCountEN.con_CommentTableId:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (a.commentTableId == null) return -1;
if (b.commentTableId == null) return 1;
return a.commentTableId.localeCompare(b.commentTableId);
}
case clsvSysCountEN.con_CollectionCount:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return a.collectionCount-b.collectionCount;
}
case clsvSysCountEN.con_DownloadCount:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return a.downloadCount-b.downloadCount;
}
case clsvSysCountEN.con_AttachmentCount:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return a.attachmentCount-b.attachmentCount;
}
case clsvSysCountEN.con_CommentCount:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return a.commentCount-b.commentCount;
}
case clsvSysCountEN.con_Score:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return a.score-b.score;
}
case clsvSysCountEN.con_StuScore:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return a.stuScore-b.stuScore;
}
case clsvSysCountEN.con_TeaScore:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return a.teaScore-b.teaScore;
}
case clsvSysCountEN.con_TableKey:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (a.tableKey == null) return -1;
if (b.tableKey == null) return 1;
return a.tableKey.localeCompare(b.tableKey);
}
case clsvSysCountEN.con_ParentId:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (a.parentId == null) return -1;
if (b.parentId == null) return 1;
return a.parentId.localeCompare(b.parentId);
}
case clsvSysCountEN.con_UpdUser:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvSysCountEN.con_UpdDate:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvSysCountEN.con_Memo:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvSysCountEN.con_PaperRWCount:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return a.paperRWCount-b.paperRWCount;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysCount]中不存在！(in ${ vSysCount_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvSysCountEN.con_CountId:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return b.countId.localeCompare(a.countId);
}
case clsvSysCountEN.con_CountTypeId:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (b.countTypeId == null) return -1;
if (a.countTypeId == null) return 1;
return b.countTypeId.localeCompare(a.countTypeId);
}
case clsvSysCountEN.con_CommentTypeName:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (b.commentTypeName == null) return -1;
if (a.commentTypeName == null) return 1;
return b.commentTypeName.localeCompare(a.commentTypeName);
}
case clsvSysCountEN.con_CommentTable:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (b.commentTable == null) return -1;
if (a.commentTable == null) return 1;
return b.commentTable.localeCompare(a.commentTable);
}
case clsvSysCountEN.con_OkCount:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return b.okCount-a.okCount;
}
case clsvSysCountEN.con_CommentTableId:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (b.commentTableId == null) return -1;
if (a.commentTableId == null) return 1;
return b.commentTableId.localeCompare(a.commentTableId);
}
case clsvSysCountEN.con_CollectionCount:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return b.collectionCount-a.collectionCount;
}
case clsvSysCountEN.con_DownloadCount:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return b.downloadCount-a.downloadCount;
}
case clsvSysCountEN.con_AttachmentCount:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return b.attachmentCount-a.attachmentCount;
}
case clsvSysCountEN.con_CommentCount:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return b.commentCount-a.commentCount;
}
case clsvSysCountEN.con_Score:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return b.score-a.score;
}
case clsvSysCountEN.con_StuScore:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return b.stuScore-a.stuScore;
}
case clsvSysCountEN.con_TeaScore:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return b.teaScore-a.teaScore;
}
case clsvSysCountEN.con_TableKey:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (b.tableKey == null) return -1;
if (a.tableKey == null) return 1;
return b.tableKey.localeCompare(a.tableKey);
}
case clsvSysCountEN.con_ParentId:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (b.parentId == null) return -1;
if (a.parentId == null) return 1;
return b.parentId.localeCompare(a.parentId);
}
case clsvSysCountEN.con_UpdUser:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvSysCountEN.con_UpdDate:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvSysCountEN.con_Memo:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvSysCountEN.con_PaperRWCount:
return (a: clsvSysCountEN, b: clsvSysCountEN) => {
return b.paperRWCount-a.paperRWCount;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysCount]中不存在！(in ${ vSysCount_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function vSysCount_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvSysCountEN.con_CountId:
return (obj: clsvSysCountEN) => {
return obj.countId === value;
}
case clsvSysCountEN.con_CountTypeId:
return (obj: clsvSysCountEN) => {
return obj.countTypeId === value;
}
case clsvSysCountEN.con_CommentTypeName:
return (obj: clsvSysCountEN) => {
return obj.commentTypeName === value;
}
case clsvSysCountEN.con_CommentTable:
return (obj: clsvSysCountEN) => {
return obj.commentTable === value;
}
case clsvSysCountEN.con_OkCount:
return (obj: clsvSysCountEN) => {
return obj.okCount === value;
}
case clsvSysCountEN.con_CommentTableId:
return (obj: clsvSysCountEN) => {
return obj.commentTableId === value;
}
case clsvSysCountEN.con_CollectionCount:
return (obj: clsvSysCountEN) => {
return obj.collectionCount === value;
}
case clsvSysCountEN.con_DownloadCount:
return (obj: clsvSysCountEN) => {
return obj.downloadCount === value;
}
case clsvSysCountEN.con_AttachmentCount:
return (obj: clsvSysCountEN) => {
return obj.attachmentCount === value;
}
case clsvSysCountEN.con_CommentCount:
return (obj: clsvSysCountEN) => {
return obj.commentCount === value;
}
case clsvSysCountEN.con_Score:
return (obj: clsvSysCountEN) => {
return obj.score === value;
}
case clsvSysCountEN.con_StuScore:
return (obj: clsvSysCountEN) => {
return obj.stuScore === value;
}
case clsvSysCountEN.con_TeaScore:
return (obj: clsvSysCountEN) => {
return obj.teaScore === value;
}
case clsvSysCountEN.con_TableKey:
return (obj: clsvSysCountEN) => {
return obj.tableKey === value;
}
case clsvSysCountEN.con_ParentId:
return (obj: clsvSysCountEN) => {
return obj.parentId === value;
}
case clsvSysCountEN.con_UpdUser:
return (obj: clsvSysCountEN) => {
return obj.updUser === value;
}
case clsvSysCountEN.con_UpdDate:
return (obj: clsvSysCountEN) => {
return obj.updDate === value;
}
case clsvSysCountEN.con_Memo:
return (obj: clsvSysCountEN) => {
return obj.memo === value;
}
case clsvSysCountEN.con_PaperRWCount:
return (obj: clsvSysCountEN) => {
return obj.paperRWCount === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysCount]中不存在！(in ${ vSysCount_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vSysCount_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
export async function vSysCount_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
export async function vSysCount_GetFirstObjAsync(strWhereCond: string): Promise<clsvSysCountEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
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
const objvSysCount = vSysCount_GetObjFromJsonObj(returnObj);
return objvSysCount;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
export async function vSysCount_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvSysCountEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysCount_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysCount_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
 * @param arrCountId:关键字列表
 * @returns 对象列表
 **/
export async function vSysCount_GetObjLstByCountIdLstAsync(arrCountId: Array<string>): Promise<Array<clsvSysCountEN>>  
{
const strThisFuncName = "GetObjLstByCountIdLstAsync";
const strAction = "GetObjLstByCountIdLst";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCountId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysCount_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysCount_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
export async function vSysCount_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvSysCountEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysCount_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysCount_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
export async function vSysCount_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvSysCountEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysCount_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysCount_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
export async function vSysCount_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
export async function vSysCount_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvSysCountEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvSysCountEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysCount_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysCount_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
export async function vSysCount_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
 * @param strCountId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vSysCount_IsExist(strCountId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"CountId": strCountId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
 * @param strCountId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vSysCount_IsExistAsync(strCountId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strCountId": strCountId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
export async function vSysCount_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vSysCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysCount_ConstructorName, strThisFuncName);
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
 * 获取WebApi的地址
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
*/
export function vSysCount_GetWebApiUrl(strController: string, strAction: string): string {
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

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vSysCount_GetJSONStrByObj (pobjvSysCountEN: clsvSysCountEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvSysCountEN);
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
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象列表
*/
export function vSysCount_GetObjLstByJSONStr (strJSON: string): Array<clsvSysCountEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvSysCountObjLst = new Array<clsvSysCountEN>();
if (strJSON === "")
{
return arrvSysCountObjLst;
}
try
{
arrvSysCountObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvSysCountObjLst;
}
return arrvSysCountObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvSysCountObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vSysCount_GetObjLstByJSONObjLst (arrvSysCountObjLstS: Array<clsvSysCountEN>): Array<clsvSysCountEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvSysCountObjLst = new Array<clsvSysCountEN>();
for (const objInFor of arrvSysCountObjLstS) {
const obj1 = vSysCount_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvSysCountObjLst.push(obj1);
}
return arrvSysCountObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vSysCount_GetObjByJSONStr (strJSON: string): clsvSysCountEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvSysCountEN = new clsvSysCountEN();
if (strJSON === "")
{
return pobjvSysCountEN;
}
try
{
pobjvSysCountEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvSysCountEN;
}
return pobjvSysCountEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vSysCount_GetCombineCondition(objvSysCount_Cond: clsvSysCountEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_CountId) == true)
{
const strComparisonOp_CountId:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_CountId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCountEN.con_CountId, objvSysCount_Cond.countId, strComparisonOp_CountId);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_CountTypeId) == true)
{
const strComparisonOp_CountTypeId:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_CountTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCountEN.con_CountTypeId, objvSysCount_Cond.countTypeId, strComparisonOp_CountTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_CommentTypeName) == true)
{
const strComparisonOp_CommentTypeName:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_CommentTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCountEN.con_CommentTypeName, objvSysCount_Cond.commentTypeName, strComparisonOp_CommentTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_CommentTable) == true)
{
const strComparisonOp_CommentTable:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_CommentTable];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCountEN.con_CommentTable, objvSysCount_Cond.commentTable, strComparisonOp_CommentTable);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvSysCountEN.con_OkCount, objvSysCount_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_CommentTableId) == true)
{
const strComparisonOp_CommentTableId:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_CommentTableId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCountEN.con_CommentTableId, objvSysCount_Cond.commentTableId, strComparisonOp_CommentTableId);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_CollectionCount) == true)
{
const strComparisonOp_CollectionCount:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_CollectionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvSysCountEN.con_CollectionCount, objvSysCount_Cond.collectionCount, strComparisonOp_CollectionCount);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_DownloadCount) == true)
{
const strComparisonOp_DownloadCount:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_DownloadCount];
strWhereCond += Format(" And {0} {2} {1}", clsvSysCountEN.con_DownloadCount, objvSysCount_Cond.downloadCount, strComparisonOp_DownloadCount);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_AttachmentCount) == true)
{
const strComparisonOp_AttachmentCount:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_AttachmentCount];
strWhereCond += Format(" And {0} {2} {1}", clsvSysCountEN.con_AttachmentCount, objvSysCount_Cond.attachmentCount, strComparisonOp_AttachmentCount);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_CommentCount) == true)
{
const strComparisonOp_CommentCount:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_CommentCount];
strWhereCond += Format(" And {0} {2} {1}", clsvSysCountEN.con_CommentCount, objvSysCount_Cond.commentCount, strComparisonOp_CommentCount);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_Score) == true)
{
const strComparisonOp_Score:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsvSysCountEN.con_Score, objvSysCount_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvSysCountEN.con_StuScore, objvSysCount_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvSysCountEN.con_TeaScore, objvSysCount_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_TableKey) == true)
{
const strComparisonOp_TableKey:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_TableKey];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCountEN.con_TableKey, objvSysCount_Cond.tableKey, strComparisonOp_TableKey);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_ParentId) == true)
{
const strComparisonOp_ParentId:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_ParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCountEN.con_ParentId, objvSysCount_Cond.parentId, strComparisonOp_ParentId);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCountEN.con_UpdUser, objvSysCount_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCountEN.con_UpdDate, objvSysCount_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCountEN.con_Memo, objvSysCount_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN.con_PaperRWCount) == true)
{
const strComparisonOp_PaperRWCount:string = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN.con_PaperRWCount];
strWhereCond += Format(" And {0} {2} {1}", clsvSysCountEN.con_PaperRWCount, objvSysCount_Cond.paperRWCount, strComparisonOp_PaperRWCount);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvSysCountENS:源对象
 * @param objvSysCountENT:目标对象
*/
export function vSysCount_CopyObjTo(objvSysCountENS: clsvSysCountEN , objvSysCountENT: clsvSysCountEN ): void 
{
objvSysCountENT.countId = objvSysCountENS.countId; //CountId
objvSysCountENT.countTypeId = objvSysCountENS.countTypeId; //CountTypeId
objvSysCountENT.commentTypeName = objvSysCountENS.commentTypeName; //评论类型名
objvSysCountENT.commentTable = objvSysCountENS.commentTable; //评论表
objvSysCountENT.okCount = objvSysCountENS.okCount; //点赞统计
objvSysCountENT.commentTableId = objvSysCountENS.commentTableId; //评论表Id
objvSysCountENT.collectionCount = objvSysCountENS.collectionCount; //收藏数量
objvSysCountENT.downloadCount = objvSysCountENS.downloadCount; //下载数
objvSysCountENT.attachmentCount = objvSysCountENS.attachmentCount; //附件计数
objvSysCountENT.commentCount = objvSysCountENS.commentCount; //评论数
objvSysCountENT.score = objvSysCountENS.score; //评分
objvSysCountENT.stuScore = objvSysCountENS.stuScore; //学生平均分
objvSysCountENT.teaScore = objvSysCountENS.teaScore; //教师评分
objvSysCountENT.tableKey = objvSysCountENS.tableKey; //表主键
objvSysCountENT.parentId = objvSysCountENS.parentId; //父Id
objvSysCountENT.updUser = objvSysCountENS.updUser; //修改人
objvSysCountENT.updDate = objvSysCountENS.updDate; //修改日期
objvSysCountENT.memo = objvSysCountENS.memo; //备注
objvSysCountENT.paperRWCount = objvSysCountENS.paperRWCount; //PaperRWCount
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvSysCountENS:源对象
 * @param objvSysCountENT:目标对象
*/
export function vSysCount_GetObjFromJsonObj(objvSysCountENS: clsvSysCountEN): clsvSysCountEN 
{
 const objvSysCountENT: clsvSysCountEN = new clsvSysCountEN();
ObjectAssign(objvSysCountENT, objvSysCountENS);
 return objvSysCountENT;
}