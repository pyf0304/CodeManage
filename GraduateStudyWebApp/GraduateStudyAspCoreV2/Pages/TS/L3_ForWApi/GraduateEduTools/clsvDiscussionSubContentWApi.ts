﻿
 /**
 * 类名:clsvDiscussionSubContentWApi
 * 表名:vDiscussionSubContent(01120585)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:43:50
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
 * v讨论子内容视图(vDiscussionSubContent)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsvDiscussionSubContentEN } from "../../L0_Entity/GraduateEduTools/clsvDiscussionSubContentEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vDiscussionSubContent_Controller = "vDiscussionSubContentApi";
 export const vDiscussionSubContent_ConstructorName = "vDiscussionSubContent";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strSubContentId:关键字
 * @returns 对象
 **/
export async function vDiscussionSubContent_GetObjBySubContentIdAsync(strSubContentId: string): Promise<clsvDiscussionSubContentEN|null>  
{
const strThisFuncName = "GetObjBySubContentIdAsync";

if (IsNullOrEmpty(strSubContentId) == true)
{
  const strMsg = Format("参数:[strSubContentId]不能为空！(In clsvDiscussionSubContentWApi.GetObjBySubContentIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strSubContentId.length != 10)
{
const strMsg = Format("缓存分类变量:[strSubContentId]的长度:[{0}]不正确！(clsvDiscussionSubContentWApi.GetObjBySubContentIdAsync)", strSubContentId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjBySubContentId";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strSubContentId": strSubContentId,
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
const objvDiscussionSubContent = vDiscussionSubContent_GetObjFromJsonObj(returnObj);
return objvDiscussionSubContent;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vDiscussionSubContent_SortFun_Defa(a:clsvDiscussionSubContentEN , b:clsvDiscussionSubContentEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.subContentId.localeCompare(b.subContentId);
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
export function vDiscussionSubContent_SortFun_Defa_2Fld(a:clsvDiscussionSubContentEN , b:clsvDiscussionSubContentEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.subContent == b.subContent) return a.topicsId.localeCompare(b.topicsId);
else return a.subContent.localeCompare(b.subContent);
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
export function vDiscussionSubContent_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvDiscussionSubContentEN.con_SubContent:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.subContent == null) return -1;
if (b.subContent == null) return 1;
return a.subContent.localeCompare(b.subContent);
}
case clsvDiscussionSubContentEN.con_TopicsId:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.topicsId == null) return -1;
if (b.topicsId == null) return 1;
return a.topicsId.localeCompare(b.topicsId);
}
case clsvDiscussionSubContentEN.con_TopicsTitle:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.topicsTitle == null) return -1;
if (b.topicsTitle == null) return 1;
return a.topicsTitle.localeCompare(b.topicsTitle);
}
case clsvDiscussionSubContentEN.con_IsTop:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.isTop == true) return 1;
else return -1
}
case clsvDiscussionSubContentEN.con_UpdDate:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvDiscussionSubContentEN.con_UpdUser:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvDiscussionSubContentEN.con_Memo:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvDiscussionSubContentEN.con_CollegeName:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.collegeName == null) return -1;
if (b.collegeName == null) return 1;
return a.collegeName.localeCompare(b.collegeName);
}
case clsvDiscussionSubContentEN.con_id_XzCollege:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.id_XzCollege == null) return -1;
if (b.id_XzCollege == null) return 1;
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvDiscussionSubContentEN.con_id_XzMajor:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.id_XzMajor == null) return -1;
if (b.id_XzMajor == null) return 1;
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvDiscussionSubContentEN.con_MajorName:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.majorName == null) return -1;
if (b.majorName == null) return 1;
return a.majorName.localeCompare(b.majorName);
}
case clsvDiscussionSubContentEN.con_UserName:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.userName == null) return -1;
if (b.userName == null) return 1;
return a.userName.localeCompare(b.userName);
}
case clsvDiscussionSubContentEN.con_BrowseNumber:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
return a.browseNumber-b.browseNumber;
}
case clsvDiscussionSubContentEN.con_id_CurrEduCls:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvDiscussionSubContentEN.con_ParentId:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.parentId == null) return -1;
if (b.parentId == null) return 1;
return a.parentId.localeCompare(b.parentId);
}
case clsvDiscussionSubContentEN.con_TopicsContent:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.topicsContent == null) return -1;
if (b.topicsContent == null) return 1;
return a.topicsContent.localeCompare(b.topicsContent);
}
case clsvDiscussionSubContentEN.con_UserId:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.userId == null) return -1;
if (b.userId == null) return 1;
return a.userId.localeCompare(b.userId);
}
case clsvDiscussionSubContentEN.con_vUpdDate:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.vUpdDate == null) return -1;
if (b.vUpdDate == null) return 1;
return a.vUpdDate.localeCompare(b.vUpdDate);
}
case clsvDiscussionSubContentEN.con_vUpdUser:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (a.vUpdUser == null) return -1;
if (b.vUpdUser == null) return 1;
return a.vUpdUser.localeCompare(b.vUpdUser);
}
case clsvDiscussionSubContentEN.con_SubContentId:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
return a.subContentId.localeCompare(b.subContentId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vDiscussionSubContent]中不存在！(in ${ vDiscussionSubContent_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvDiscussionSubContentEN.con_SubContent:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.subContent == null) return -1;
if (a.subContent == null) return 1;
return b.subContent.localeCompare(a.subContent);
}
case clsvDiscussionSubContentEN.con_TopicsId:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.topicsId == null) return -1;
if (a.topicsId == null) return 1;
return b.topicsId.localeCompare(a.topicsId);
}
case clsvDiscussionSubContentEN.con_TopicsTitle:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.topicsTitle == null) return -1;
if (a.topicsTitle == null) return 1;
return b.topicsTitle.localeCompare(a.topicsTitle);
}
case clsvDiscussionSubContentEN.con_IsTop:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.isTop == true) return 1;
else return -1
}
case clsvDiscussionSubContentEN.con_UpdDate:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvDiscussionSubContentEN.con_UpdUser:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvDiscussionSubContentEN.con_Memo:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvDiscussionSubContentEN.con_CollegeName:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.collegeName == null) return -1;
if (a.collegeName == null) return 1;
return b.collegeName.localeCompare(a.collegeName);
}
case clsvDiscussionSubContentEN.con_id_XzCollege:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.id_XzCollege == null) return -1;
if (a.id_XzCollege == null) return 1;
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvDiscussionSubContentEN.con_id_XzMajor:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.id_XzMajor == null) return -1;
if (a.id_XzMajor == null) return 1;
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvDiscussionSubContentEN.con_MajorName:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.majorName == null) return -1;
if (a.majorName == null) return 1;
return b.majorName.localeCompare(a.majorName);
}
case clsvDiscussionSubContentEN.con_UserName:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.userName == null) return -1;
if (a.userName == null) return 1;
return b.userName.localeCompare(a.userName);
}
case clsvDiscussionSubContentEN.con_BrowseNumber:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
return b.browseNumber-a.browseNumber;
}
case clsvDiscussionSubContentEN.con_id_CurrEduCls:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvDiscussionSubContentEN.con_ParentId:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.parentId == null) return -1;
if (a.parentId == null) return 1;
return b.parentId.localeCompare(a.parentId);
}
case clsvDiscussionSubContentEN.con_TopicsContent:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.topicsContent == null) return -1;
if (a.topicsContent == null) return 1;
return b.topicsContent.localeCompare(a.topicsContent);
}
case clsvDiscussionSubContentEN.con_UserId:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.userId == null) return -1;
if (a.userId == null) return 1;
return b.userId.localeCompare(a.userId);
}
case clsvDiscussionSubContentEN.con_vUpdDate:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.vUpdDate == null) return -1;
if (a.vUpdDate == null) return 1;
return b.vUpdDate.localeCompare(a.vUpdDate);
}
case clsvDiscussionSubContentEN.con_vUpdUser:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
if (b.vUpdUser == null) return -1;
if (a.vUpdUser == null) return 1;
return b.vUpdUser.localeCompare(a.vUpdUser);
}
case clsvDiscussionSubContentEN.con_SubContentId:
return (a: clsvDiscussionSubContentEN, b: clsvDiscussionSubContentEN) => {
return b.subContentId.localeCompare(a.subContentId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vDiscussionSubContent]中不存在！(in ${ vDiscussionSubContent_ConstructorName}.${ strThisFuncName})`;
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
export async function vDiscussionSubContent_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvDiscussionSubContentEN.con_SubContent:
return (obj: clsvDiscussionSubContentEN) => {
return obj.subContent === value;
}
case clsvDiscussionSubContentEN.con_TopicsId:
return (obj: clsvDiscussionSubContentEN) => {
return obj.topicsId === value;
}
case clsvDiscussionSubContentEN.con_TopicsTitle:
return (obj: clsvDiscussionSubContentEN) => {
return obj.topicsTitle === value;
}
case clsvDiscussionSubContentEN.con_IsTop:
return (obj: clsvDiscussionSubContentEN) => {
return obj.isTop === value;
}
case clsvDiscussionSubContentEN.con_UpdDate:
return (obj: clsvDiscussionSubContentEN) => {
return obj.updDate === value;
}
case clsvDiscussionSubContentEN.con_UpdUser:
return (obj: clsvDiscussionSubContentEN) => {
return obj.updUser === value;
}
case clsvDiscussionSubContentEN.con_Memo:
return (obj: clsvDiscussionSubContentEN) => {
return obj.memo === value;
}
case clsvDiscussionSubContentEN.con_CollegeName:
return (obj: clsvDiscussionSubContentEN) => {
return obj.collegeName === value;
}
case clsvDiscussionSubContentEN.con_id_XzCollege:
return (obj: clsvDiscussionSubContentEN) => {
return obj.id_XzCollege === value;
}
case clsvDiscussionSubContentEN.con_id_XzMajor:
return (obj: clsvDiscussionSubContentEN) => {
return obj.id_XzMajor === value;
}
case clsvDiscussionSubContentEN.con_MajorName:
return (obj: clsvDiscussionSubContentEN) => {
return obj.majorName === value;
}
case clsvDiscussionSubContentEN.con_UserName:
return (obj: clsvDiscussionSubContentEN) => {
return obj.userName === value;
}
case clsvDiscussionSubContentEN.con_BrowseNumber:
return (obj: clsvDiscussionSubContentEN) => {
return obj.browseNumber === value;
}
case clsvDiscussionSubContentEN.con_id_CurrEduCls:
return (obj: clsvDiscussionSubContentEN) => {
return obj.id_CurrEduCls === value;
}
case clsvDiscussionSubContentEN.con_ParentId:
return (obj: clsvDiscussionSubContentEN) => {
return obj.parentId === value;
}
case clsvDiscussionSubContentEN.con_TopicsContent:
return (obj: clsvDiscussionSubContentEN) => {
return obj.topicsContent === value;
}
case clsvDiscussionSubContentEN.con_UserId:
return (obj: clsvDiscussionSubContentEN) => {
return obj.userId === value;
}
case clsvDiscussionSubContentEN.con_vUpdDate:
return (obj: clsvDiscussionSubContentEN) => {
return obj.vUpdDate === value;
}
case clsvDiscussionSubContentEN.con_vUpdUser:
return (obj: clsvDiscussionSubContentEN) => {
return obj.vUpdUser === value;
}
case clsvDiscussionSubContentEN.con_SubContentId:
return (obj: clsvDiscussionSubContentEN) => {
return obj.subContentId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vDiscussionSubContent]中不存在！(in ${ vDiscussionSubContent_ConstructorName}.${ strThisFuncName})`;
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
export async function vDiscussionSubContent_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
export async function vDiscussionSubContent_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
export async function vDiscussionSubContent_GetFirstObjAsync(strWhereCond: string): Promise<clsvDiscussionSubContentEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
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
const objvDiscussionSubContent = vDiscussionSubContent_GetObjFromJsonObj(returnObj);
return objvDiscussionSubContent;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
export async function vDiscussionSubContent_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvDiscussionSubContentEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vDiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
 * @param arrSubContentId:关键字列表
 * @returns 对象列表
 **/
export async function vDiscussionSubContent_GetObjLstBySubContentIdLstAsync(arrSubContentId: Array<string>): Promise<Array<clsvDiscussionSubContentEN>>  
{
const strThisFuncName = "GetObjLstBySubContentIdLstAsync";
const strAction = "GetObjLstBySubContentIdLst";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSubContentId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vDiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
export async function vDiscussionSubContent_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvDiscussionSubContentEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vDiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
export async function vDiscussionSubContent_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvDiscussionSubContentEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vDiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
export async function vDiscussionSubContent_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
export async function vDiscussionSubContent_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvDiscussionSubContentEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvDiscussionSubContentEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vDiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
export async function vDiscussionSubContent_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
 * @param strSubContentId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vDiscussionSubContent_IsExist(strSubContentId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"SubContentId": strSubContentId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
 * @param strSubContentId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vDiscussionSubContent_IsExistAsync(strSubContentId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strSubContentId": strSubContentId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
export async function vDiscussionSubContent_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vDiscussionSubContent_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionSubContent_ConstructorName, strThisFuncName);
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
export function vDiscussionSubContent_GetWebApiUrl(strController: string, strAction: string): string {
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
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vDiscussionSubContent_GetJSONStrByObj (pobjvDiscussionSubContentEN: clsvDiscussionSubContentEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvDiscussionSubContentEN);
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
export function vDiscussionSubContent_GetObjLstByJSONStr (strJSON: string): Array<clsvDiscussionSubContentEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvDiscussionSubContentObjLst = new Array<clsvDiscussionSubContentEN>();
if (strJSON === "")
{
return arrvDiscussionSubContentObjLst;
}
try
{
arrvDiscussionSubContentObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvDiscussionSubContentObjLst;
}
return arrvDiscussionSubContentObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvDiscussionSubContentObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vDiscussionSubContent_GetObjLstByJSONObjLst (arrvDiscussionSubContentObjLstS: Array<clsvDiscussionSubContentEN>): Array<clsvDiscussionSubContentEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvDiscussionSubContentObjLst = new Array<clsvDiscussionSubContentEN>();
for (const objInFor of arrvDiscussionSubContentObjLstS) {
const obj1 = vDiscussionSubContent_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvDiscussionSubContentObjLst.push(obj1);
}
return arrvDiscussionSubContentObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vDiscussionSubContent_GetObjByJSONStr (strJSON: string): clsvDiscussionSubContentEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
if (strJSON === "")
{
return pobjvDiscussionSubContentEN;
}
try
{
pobjvDiscussionSubContentEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvDiscussionSubContentEN;
}
return pobjvDiscussionSubContentEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vDiscussionSubContent_GetCombineCondition(objvDiscussionSubContent_Cond: clsvDiscussionSubContentEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_TopicsId) == true)
{
const strComparisonOp_TopicsId:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_TopicsId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_TopicsId, objvDiscussionSubContent_Cond.topicsId, strComparisonOp_TopicsId);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_TopicsTitle) == true)
{
const strComparisonOp_TopicsTitle:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_TopicsTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_TopicsTitle, objvDiscussionSubContent_Cond.topicsTitle, strComparisonOp_TopicsTitle);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_IsTop) == true)
{
if (objvDiscussionSubContent_Cond.isTop == true)
{
strWhereCond += Format(" And {0} = '1'", clsvDiscussionSubContentEN.con_IsTop);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvDiscussionSubContentEN.con_IsTop);
}
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_UpdDate, objvDiscussionSubContent_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_UpdUser, objvDiscussionSubContent_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_Memo, objvDiscussionSubContent_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_CollegeName, objvDiscussionSubContent_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_id_XzCollege, objvDiscussionSubContent_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_id_XzMajor, objvDiscussionSubContent_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_MajorName, objvDiscussionSubContent_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_UserName, objvDiscussionSubContent_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_BrowseNumber) == true)
{
const strComparisonOp_BrowseNumber:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_BrowseNumber];
strWhereCond += Format(" And {0} {2} {1}", clsvDiscussionSubContentEN.con_BrowseNumber, objvDiscussionSubContent_Cond.browseNumber, strComparisonOp_BrowseNumber);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_id_CurrEduCls, objvDiscussionSubContent_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_ParentId) == true)
{
const strComparisonOp_ParentId:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_ParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_ParentId, objvDiscussionSubContent_Cond.parentId, strComparisonOp_ParentId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_UserId, objvDiscussionSubContent_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_vUpdDate) == true)
{
const strComparisonOp_vUpdDate:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_vUpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_vUpdDate, objvDiscussionSubContent_Cond.vUpdDate, strComparisonOp_vUpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_vUpdUser) == true)
{
const strComparisonOp_vUpdUser:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_vUpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_vUpdUser, objvDiscussionSubContent_Cond.vUpdUser, strComparisonOp_vUpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN.con_SubContentId) == true)
{
const strComparisonOp_SubContentId:string = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN.con_SubContentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionSubContentEN.con_SubContentId, objvDiscussionSubContent_Cond.subContentId, strComparisonOp_SubContentId);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vDiscussionSubContent(v讨论子内容视图),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strSubContentId: 子内容Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vDiscussionSubContent_GetUniCondStr_SubContentId(objvDiscussionSubContentEN: clsvDiscussionSubContentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and SubContentId = '{0}'", objvDiscussionSubContentEN.subContentId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vDiscussionSubContent(v讨论子内容视图),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strSubContentId: 子内容Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vDiscussionSubContent_GetUniCondStr4Update_SubContentId(objvDiscussionSubContentEN: clsvDiscussionSubContentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and SubContentId <> '{0}'", objvDiscussionSubContentEN.subContentId);
 strWhereCond +=  Format(" and SubContentId = '{0}'", objvDiscussionSubContentEN.subContentId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvDiscussionSubContentENS:源对象
 * @param objvDiscussionSubContentENT:目标对象
*/
export function vDiscussionSubContent_CopyObjTo(objvDiscussionSubContentENS: clsvDiscussionSubContentEN , objvDiscussionSubContentENT: clsvDiscussionSubContentEN ): void 
{
objvDiscussionSubContentENT.subContent = objvDiscussionSubContentENS.subContent; //子内容
objvDiscussionSubContentENT.topicsId = objvDiscussionSubContentENS.topicsId; //主题Id
objvDiscussionSubContentENT.topicsTitle = objvDiscussionSubContentENS.topicsTitle; //主题标题
objvDiscussionSubContentENT.isTop = objvDiscussionSubContentENS.isTop; //是否置顶
objvDiscussionSubContentENT.updDate = objvDiscussionSubContentENS.updDate; //修改日期
objvDiscussionSubContentENT.updUser = objvDiscussionSubContentENS.updUser; //修改人
objvDiscussionSubContentENT.memo = objvDiscussionSubContentENS.memo; //备注
objvDiscussionSubContentENT.collegeName = objvDiscussionSubContentENS.collegeName; //学院名称
objvDiscussionSubContentENT.id_XzCollege = objvDiscussionSubContentENS.id_XzCollege; //学院流水号
objvDiscussionSubContentENT.id_XzMajor = objvDiscussionSubContentENS.id_XzMajor; //专业流水号
objvDiscussionSubContentENT.majorName = objvDiscussionSubContentENS.majorName; //专业名称
objvDiscussionSubContentENT.userName = objvDiscussionSubContentENS.userName; //用户名
objvDiscussionSubContentENT.browseNumber = objvDiscussionSubContentENS.browseNumber; //浏览量
objvDiscussionSubContentENT.id_CurrEduCls = objvDiscussionSubContentENS.id_CurrEduCls; //教学班流水号
objvDiscussionSubContentENT.parentId = objvDiscussionSubContentENS.parentId; //父节点Id
objvDiscussionSubContentENT.topicsContent = objvDiscussionSubContentENS.topicsContent; //主题内容
objvDiscussionSubContentENT.userId = objvDiscussionSubContentENS.userId; //用户ID
objvDiscussionSubContentENT.vUpdDate = objvDiscussionSubContentENS.vUpdDate; //vUpdDate
objvDiscussionSubContentENT.vUpdUser = objvDiscussionSubContentENS.vUpdUser; //vUpdUser
objvDiscussionSubContentENT.subContentId = objvDiscussionSubContentENS.subContentId; //子内容Id
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvDiscussionSubContentENS:源对象
 * @param objvDiscussionSubContentENT:目标对象
*/
export function vDiscussionSubContent_GetObjFromJsonObj(objvDiscussionSubContentENS: clsvDiscussionSubContentEN): clsvDiscussionSubContentEN 
{
 const objvDiscussionSubContentENT: clsvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
ObjectAssign(objvDiscussionSubContentENT, objvDiscussionSubContentENS);
 return objvDiscussionSubContentENT;
}