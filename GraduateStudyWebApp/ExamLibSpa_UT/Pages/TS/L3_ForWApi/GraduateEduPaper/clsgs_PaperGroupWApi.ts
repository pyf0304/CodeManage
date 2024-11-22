
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperGroupWApi
 表名:gs_PaperGroup(01120749)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 18:28:55
 生成者:pyf2
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
 框架-层名:WA_访问层(WA_Access)
 编程语言:TypeScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */

 /// <summary>
 /// 论文分组(gs_PaperGroup)
 /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
 /// </summary>
/**
* Created by pyf2 on 2020年09月28日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { clsCommonFunc4Web } from "../../PubFun/clsCommonFunc4Web.js";
import { clsgs_PaperGroupEN,  clsgs_PaperGroupEN_Sim } from "../../L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { clsStackTrace } from "../../PubFun/clsStackTrace.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { myShowErrorMsg, GetStrLen } from "../../PubFun/tzPubFun.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { clsString } from "../../PubFun/clsString.js";
var ResponseData: tzResponseData;
export class clsgs_PaperGroupWApi 
{
 public static mstrController: string = "gs_PaperGroupApi";
public static CacheModeId = ""; //
public objgs_PaperGroupEN: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
constructor( pobjgs_PaperGroupEN: clsgs_PaperGroupEN)
{
this.objgs_PaperGroupEN = pobjgs_PaperGroupEN;
};

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 /// </summary>
 /// <param name = "strPaperGroupId">关键字</param>
 /// <returns>对象</returns>
public static GetObjByPaperGroupIdAsync(strPaperGroupId: string): Promise<clsgs_PaperGroupEN>  
{
var strAction = "GetObjByPaperGroupId";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("PaperGroupId", strPaperGroupId);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObj = JSON.parse(data.ReturnObj);
//console.log(returnObj);
resolve(returnObj);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存中获取.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
 /// </summary>
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <returns>对象</returns>
public static async GetObjByPaperGroupId_Cache(strPaperGroupId: string) {
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = await clsgs_PaperGroupWApi.GetObjLst_Cache();
var obj: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
var arrgs_PaperGroup_Sel: Array <clsgs_PaperGroupEN> = arrgs_PaperGroupObjLst_Cache.filter(x => x.PaperGroupId == strPaperGroupId);
var objgs_PaperGroup: clsgs_PaperGroupEN;
if (arrgs_PaperGroup_Sel.length > 0)
{
objgs_PaperGroup = arrgs_PaperGroup_Sel[0];
return objgs_PaperGroup;
}
else
{
return obj;
}
}
catch (e)
{
var strMsg: string = `错误:[${e}]. \n根据关键字:[${ strPaperGroupId }]获取相应的对象不成功!`;
alert(strMsg);
}
return obj;
};

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存中获取.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 /// </summary>
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <returns>对象</returns>
public static async GetObjByPaperGroupId_localStorage(strPaperGroupId: string) {
if (clsString.IsNullOrEmpty(strPaperGroupId) == true) return null;
var strKey: string = clsString.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strPaperGroupId);
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (localStorage.hasOwnProperty(strKey))
{
//缓存存在，直接返回
var strTempObj: string = localStorage.getItem(strKey) as string;
var objgs_PaperGroup_Cache: clsgs_PaperGroupEN = JSON.parse(strTempObj);
return objgs_PaperGroup_Cache;
}
try
{
var objgs_PaperGroup: clsgs_PaperGroupEN = await clsgs_PaperGroupWApi.GetObjByPaperGroupIdAsync(strPaperGroupId);
if (objgs_PaperGroup != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_PaperGroup));
var strInfo: string = `Key:[${ strKey}]的缓存已经建立!`;
console.log(strInfo);
return objgs_PaperGroup;
}
return objgs_PaperGroup;
}
catch (e)
{
var strMsg: string = `错误:[${e}]. \n根据关键字:[${ strPaperGroupId }]获取相应的对象不成功!`;
alert(strMsg);
return;
}
};

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存中获取.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 /// </summary>
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <returns>对象</returns>
public static async UpdateObjInLst_Cache(objgs_PaperGroup: clsgs_PaperGroupEN) {
try
{
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = await clsgs_PaperGroupWApi.GetObjLst_Cache();
var obj = arrgs_PaperGroupObjLst_Cache.find(x => x.PaperGroupName == objgs_PaperGroup.PaperGroupName && x.UpdUser == objgs_PaperGroup.UpdUser);
if (obj != null)
{
objgs_PaperGroup.PaperGroupId = obj.PaperGroupId;
clsgs_PaperGroupBL.CopyObjTo(objgs_PaperGroup, obj);
}
else
{
arrgs_PaperGroupObjLst_Cache.push(objgs_PaperGroup);
}
}
catch (e) {
var strMsg: string = `错误:[${e}]. \n在列表中修改对象不成功!`;
alert(strMsg);
};
};

 /// <summary>
 /// 根据关键字获取相关对象的名称属性, 从缓存中获取.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 /// </summary>
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <returns>对象</returns>
public static async GetNameByPaperGroupId_Cache(strPaperGroupId: string) {
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = await clsgs_PaperGroupWApi.GetObjLst_Cache();
var obj: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
var arrgs_PaperGroup_Sel: Array <clsgs_PaperGroupEN> = arrgs_PaperGroupObjLst_Cache.filter(x => x.PaperGroupId == strPaperGroupId);
var objgs_PaperGroup: clsgs_PaperGroupEN;
if (arrgs_PaperGroup_Sel.length > 0)
{
objgs_PaperGroup = arrgs_PaperGroup_Sel[0];
return objgs_PaperGroup.PaperGroupName;
}
else
{
return "";
}
}
catch (e)
{
var strMsg: string = `错误:[${e}]. \n根据关键字:[${ strPaperGroupId }]获取相应的对象名称属性不成功!`;
alert(strMsg);
}
return obj;
};

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf2
 /// 日期:20200928182855
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static async func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
if (strInFldName != clsgs_PaperGroupEN.con_PaperGroupId)
{
var strMsg: string = clsString.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Error(strMsg);
}
if (clsgs_PaperGroupEN.AttributeName.indexOf(strOutFldName) == -1)
{
var strMsg : string= clsString.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsgs_PaperGroupEN.AttributeName.join(','));
throw new Error(strMsg);
}
var objgs_PaperGroup = await clsgs_PaperGroupWApi.GetObjByPaperGroupId_Cache(strInValue );
if (objgs_PaperGroup == null) return "";
return objgs_PaperGroup[strOutFldName].toString();
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存中获取.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SetCache)
 /// </summary>
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <returns>对象</returns>
public static SetCache() {
};

 /// <summary>
 /// 根据关键字获取相应的对象
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_WA_CacheAsync)
 /// </summary>
 /// <param name = "strPaperGroupId">关键字</param>
 /// <returns>对象</returns>
public static GetObjByPaperGroupId_WA_CacheAsync(strPaperGroupId: string): Promise<clsgs_PaperGroupEN>  
{
var strAction = "GetObjByPaperGroupId_Cache";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("PaperGroupId", strPaperGroupId);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObj = JSON.parse(data.ReturnObj);
//console.log(returnObj);
resolve(returnObj);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
var strAction = "GetFirstID";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnStr);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
}

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取的相应对象</returns>
public static GetFirstObjAsync(strWhereCond: string): Promise<clsgs_PaperGroupEN>  
{
var strAction = "GetFirstObj";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObj = JSON.parse(data.ReturnObj);
//console.log(returnObj);
resolve(returnObj);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
public static async GetObjLst_ClientCache() 
{
//初始化列表缓存
var strWhereCond: string = "1=1";
clsgs_PaperGroupWApi.InitListCache(); 
var strKey: string = clsgs_PaperGroupEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = CacheHelper.Get(strKey);
return arrgs_PaperGroupObjLst_Cache;
}
try
{
const responseText = await clsgs_PaperGroupWApi.GetObjLstAsync(strWhereCond);
var arrgs_PaperGroupObjLst: Array <clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>> responseText;
CacheHelper.Add(strKey, arrgs_PaperGroupObjLst);
var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrgs_PaperGroupObjLst.length}!`;
console.log(strInfo);
return arrgs_PaperGroupObjLst;
}
catch (e)
{
console.log("GetObjLst_Cache:e");
console.error(e);
var strMsg: string = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
throw (strMsg);
}
}

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
public static async GetObjLst_localStorage() 
{
//初始化列表缓存
var strWhereCond: string = "1=1";
clsgs_PaperGroupWApi.InitListCache(); 
var strKey: string = clsgs_PaperGroupEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (localStorage.hasOwnProperty(strKey))
{
//缓存存在，直接返回
var strTempObjLst:string = localStorage.getItem(strKey) as string;
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = JSON.parse(strTempObjLst);
return arrgs_PaperGroupObjLst_Cache;
}
try
{
const responseText = await clsgs_PaperGroupWApi.GetObjLstAsync(strWhereCond);
var arrgs_PaperGroupObjLst: Array <clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>> responseText;
localStorage.setItem(strKey, JSON.stringify(arrgs_PaperGroupObjLst));
var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrgs_PaperGroupObjLst.length}!`;
console.log(strInfo);
return arrgs_PaperGroupObjLst;
}
catch (e)
{
console.log("GetObjLst_Cache:e");
console.error(e);
var strMsg: string = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
throw (strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取的相应对象列表</returns>
public static GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PaperGroupEN>>  
{
var strAction = "GetObjLst";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
public static async GetObjLst_sessionStorage() 
{
//初始化列表缓存
var strWhereCond: string = "1=1";
clsgs_PaperGroupWApi.InitListCache(); 
var strKey: string = clsgs_PaperGroupEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (sessionStorage.hasOwnProperty(strKey))
{
//缓存存在，直接返回
var strTempObjLst:string = sessionStorage.getItem(strKey) as string;
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = JSON.parse(strTempObjLst);
return arrgs_PaperGroupObjLst_Cache;
}
try
{
const responseText = await clsgs_PaperGroupWApi.GetObjLstAsync(strWhereCond);
var arrgs_PaperGroupObjLst: Array <clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>> responseText;
sessionStorage.setItem(strKey, JSON.stringify(arrgs_PaperGroupObjLst));
var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrgs_PaperGroupObjLst.length}!`;
console.log(strInfo);
return arrgs_PaperGroupObjLst;
}
catch (e)
{
console.log("GetObjLst_Cache:e");
console.error(e);
var strMsg: string = `从缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
throw (strMsg);
}
}

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
public static async GetObjLst_Cache() 
{
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN>;
switch (clsgs_PaperGroupWApi.CacheModeId)
{
case "04"://sessionStorage
arrgs_PaperGroupObjLst_Cache = await clsgs_PaperGroupWApi.GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_PaperGroupObjLst_Cache = await clsgs_PaperGroupWApi.GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_PaperGroupObjLst_Cache = await clsgs_PaperGroupWApi.GetObjLst_ClientCache();
break;
default:
arrgs_PaperGroupObjLst_Cache = await clsgs_PaperGroupWApi.GetObjLst_ClientCache();
break;
}
return arrgs_PaperGroupObjLst_Cache;
}

 /// <summary>
 /// 获取服务器缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_WA_CacheAsync)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取的相应对象列表</returns>
public static GetObjLst_WA_CacheAsync(): Promise<Array<clsgs_PaperGroupEN>>  
{
var strAction = "GetObjLst_Cache";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件对象, 从缓存的对象列表中获取子集.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objstrPaperGroupId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static async GetSubObjLst_Cache(objgs_PaperGroup_Cond: clsgs_PaperGroupEN) {
var objgs_PaperGroup_Sim : clsgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = await clsgs_PaperGroupWApi.GetObjLst_Cache();
var arrgs_PaperGroup_Sel: Array < clsgs_PaperGroupEN > = arrgs_PaperGroupObjLst_Cache.filter(x => true);
if (objgs_PaperGroup_Sim.sf_FldComparisonOp == null || objgs_PaperGroup_Sim.sf_FldComparisonOp == "") return arrgs_PaperGroup_Sel;
var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperGroup_Sim.sf_FldComparisonOp);
console.log("clsgs_PaperGroupWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_PaperGroup_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] != null);
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objgs_PaperGroup_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] == strValue);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrgs_PaperGroup_Sel;
}
catch (e) {
var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify( objgs_PaperGroup_Sim)}]缓存对象列表中获取子集对象不成功!`;
throw new Error(strMsg);
}
return new Array<clsgs_PaperGroupEN>();
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_WA_CacheAsync)
 /// </summary>
 /// <param name = "objgs_PaperGroup_Cond">条件对象</param>
 /// <returns>获取的相应记录对象列表</returns>
public static GetSubObjLst_WA_CacheAsync(objgs_PaperGroup_Cond: clsgs_PaperGroupEN): Promise<Array<clsgs_PaperGroupEN>>  
{
var strAction = "GetSubObjLst_Cache";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objgs_PaperGroupEN_Sim,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据关键字列表获取相关对象列表
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 /// </summary>
 /// <param name = "arrPaperGroupId">关键字列表</param>
 /// <returns>对象列表</returns>
public static GetObjLstByPaperGroupIdLstAsync(arrPaperGroupId: Array<string>): Promise<Array<clsgs_PaperGroupEN>>  
{
var strAction = "GetObjLstByPaperGroupIdLst";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrPaperGroupId },
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 从缓存中获取.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrstrPaperGroupIdLst">关键字列表</param>
 /// <returns>对象列表</returns>
public static async GetObjLstByPaperGroupIdLst_Cache(arrPaperGroupIdLst: Array<string>) {
try
{
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = await clsgs_PaperGroupWApi.GetObjLst_Cache();
var arrgs_PaperGroup_Sel: Array <clsgs_PaperGroupEN> = arrgs_PaperGroupObjLst_Cache.filter(x => arrPaperGroupIdLst.indexOf(x.PaperGroupId)>-1);
return arrgs_PaperGroup_Sel;
}
catch (e)
{
var strMsg: string = `错误:[${e}]. \n根据关键字:[${ arrPaperGroupIdLst.join(",") }]获取对象列表不成功!`;
throw new Error(strMsg);
}
return new Array<clsgs_PaperGroupEN>();
};

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 从WebApi缓存中获取
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_WA_CacheAsync)
 /// </summary>
 /// <param name = "arrPaperGroupId">关键字列表</param>
 /// <returns>对象列表</returns>
public static GetObjLstByPaperGroupIdLst_WA_CacheAsync(arrPaperGroupId: Array<string>): Promise<Array<clsgs_PaperGroupEN>>  
{
var strAction = "GetObjLstByPaperGroupIdLst_Cache";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrPaperGroupId },
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>获取的相应对象列表</returns>
public static GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_PaperGroupEN>>  
{
var strAction = "GetTopObjLst";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary =  stuTopPara.GetMapParam(objTopPara);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objTopPara,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取对象列表的参数对象</param>
 /// <returns>获取的相应记录对象列表</returns>
public static GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_PaperGroupEN>>  
{
var strAction = "GetObjLstByRange";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = stuRangePara.GetMapParam(objRangePara);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objRangePara,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
}

 /// <summary>
 /// 从缓存中获取分页对象列表.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页参数结构</param>
 /// <returns>对象列表</returns>
public static async GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = await clsgs_PaperGroupWApi.GetObjLst_Cache();
if (arrgs_PaperGroupObjLst_Cache.length == 0) return arrgs_PaperGroupObjLst_Cache;
var arrgs_PaperGroup_Sel: Array < clsgs_PaperGroupEN > = arrgs_PaperGroupObjLst_Cache.filter(x => true);
var obj_Cond: clsgs_PaperGroupEN_Sim = JSON.parse(objPagerPara.WhereCond);
var dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
console.log("clsgs_PaperGroupWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web.GetObjKeys(obj_Cond);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] != null);
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = obj_Cond[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] == strValue);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
if (arrgs_PaperGroup_Sel.length == 0) return arrgs_PaperGroup_Sel;
var intStart: number = objPagerPara.PageSize* (objPagerPara.PageIndex - 1);
if (intStart <= 0) intStart = 0;
var intEnd = intStart + objPagerPara.PageSize;
if (objPagerPara.OrderBy != null && objPagerPara.OrderBy.length>0) {
var sstrSplit: string[] = objPagerPara.OrderBy.split(" ");
var strSortType: string = "asc";
var strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
//                console.log(arrgs_PaperGroup_Sel);
let objFirst = arrgs_PaperGroup_Sel[0];//第一个对象
let strSortValue = objFirst[strSortFld];  //第一个对象排序字段值            
let strSortFldType = typeof(strSortValue);//排序字段值的数据类型
//console.log("排序字段的数据类型: " + strSortFldType);
switch (strSortFldType)
{
case "string":
if (strSortType.toLowerCase() == "asc") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
}
else {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
}
break;
case "number":
case "boolean":
if (strSortType.toLowerCase() == "asc") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.sort((x, y) => x[strSortFld] - y[strSortFld]);
}
else {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.sort((x, y) => y[strSortFld] - x[strSortFld]);
}
break;
}
}
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.slice(intStart, intEnd);     
return arrgs_PaperGroup_Sel;
}
catch (e) {
var strMsg: string = `错误:[${e}]. \n根据条件:[${objPagerPara.WhereCond}]获取分页对象列表不成功!(In clsgs_PaperGroupWApi.GetObjLstByPager_Cache)`;
throw new Error(strMsg);
}
return new Array<clsgs_PaperGroupEN>();
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_WA_CacheAsync)
 /// </summary>
 /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
 /// <returns>获取的相应记录对象列表</returns>
public static GetObjLstByPager_WA_CacheAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperGroupEN>>  
{
var strAction = "GetObjLstByPager_Cache";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = stuPagerPara.GetMapParam(objPagerPara);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objPagerPara,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 /// </summary>
 /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
 /// <returns>获取的相应记录对象列表</returns>
public static GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperGroupEN>>  
{
var strAction = "GetObjLstByPager";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = stuPagerPara.GetMapParam(objPagerPara);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objPagerPara,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 调用WebApi来删除记录
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
 /// </summary>
 /// <param name = "strPaperGroupId">关键字</param>
 /// <returns>获取删除的结果</returns>
public static DelRecordAsync(strPaperGroupId: string): Promise<number>  
{
var strAction = "DelRecord";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
strUrl = `${strUrl}/${ strPaperGroupId }`;
var mapParam: Dictionary = new Dictionary();
mapParam.add("strPaperGroupId", strPaperGroupId);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "DELETE",
dataType: "json",
data: { "": strPaperGroupId },
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnInt);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
 /// </summary>
 /// <param name = "arrPaperGroupId">关键字列表</param>
 /// <returns>实际删除记录的个数</returns>
public static Delgs_PaperGroupsAsync(arrPaperGroupId: Array<string>): Promise<number> 
{
var strAction = "Delgs_PaperGroups";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrPaperGroupId },
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnInt);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static Delgs_PaperGroupsByCondAsync(strWhereCond: string): Promise<number> 
{
var strAction = "Delgs_PaperGroupsByCond";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"":strWhereCond},
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnInt);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
}

 /// <summary>
 /// 调用WebApi来添加记录，数据传递使用JSON串
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
public static AddNewRecordAsync(objgs_PaperGroupEN: clsgs_PaperGroupEN): Promise<boolean> 
{
var strMsg = "";
var strAction = "AddNewRecord";
var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroupEN);
 //var strJSON = JSON.stringify(objgs_PaperGroupEN_Sim);
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objgs_PaperGroupEN_Sim,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 调用WebApi来添加记录，数据传递使用JSON串
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
public static AddNewRecordWithMaxIdAsync(objgs_PaperGroupEN: clsgs_PaperGroupEN): Promise<string> 
{
var strMsg = "";
var strAction = "AddNewRecordWithMaxId";
var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroupEN);
 //var strJSON = JSON.stringify(objgs_PaperGroupEN_Sim);
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objgs_PaperGroupEN_Sim,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnStr);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static AddNewRecordWithReturnKeyAsync(objgs_PaperGroupEN: clsgs_PaperGroupEN): Promise<string> 
{
var strAction = "AddNewRecordWithReturnKey";
var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroupEN);
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objgs_PaperGroupEN_Sim,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnStr);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
}

 /// <summary>
 /// 调用WebApi来修改记录，数据传递使用JSON串
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要添加的对象</param>
 /// <returns>获取修改是否成功？</returns>
public static UpdateRecordAsync(objgs_PaperGroupEN: clsgs_PaperGroupEN): Promise<boolean>  
{
var strMsg = "";
var strAction = "UpdateRecord";
 if (objgs_PaperGroupEN.sf_UpdFldSetStr === null || objgs_PaperGroupEN.sf_UpdFldSetStr === "")
{
strMsg = `对象(关键字: ${objgs_PaperGroupEN.PaperGroupId })的【修改字段集】为空，不能修改!`;
 throw strMsg;
 }
var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroupEN);
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objgs_PaperGroupEN_Sim,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件来修改记录
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static UpdateWithConditionAsync(objgs_PaperGroupEN: clsgs_PaperGroupEN, strWhereCond: string ): Promise<boolean> 
{
var strAction = "UpdateWithCondition";
 if (objgs_PaperGroupEN.sf_UpdFldSetStr === null || objgs_PaperGroupEN.sf_UpdFldSetStr === "")
{
var strMsg = `对象(关键字: ${objgs_PaperGroupEN.PaperGroupId })的【修改字段集】为空，不能修改!`;
 throw new Error(strMsg);
 }
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
}

 /// <summary>
 /// 根据条件对象, 从缓存的对象列表中获取子集.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
 /// </summary>
 /// <param name = "objstrPaperGroupId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static async IsExistRecord_Cache(objgs_PaperGroup_Cond: clsgs_PaperGroupEN) {
var objgs_PaperGroup_Sim : clsgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = await clsgs_PaperGroupWApi.GetObjLst_Cache();
var arrgs_PaperGroup_Sel: Array < clsgs_PaperGroupEN > = arrgs_PaperGroupObjLst_Cache.filter(x => true);
if (objgs_PaperGroup_Sim.sf_FldComparisonOp == null || objgs_PaperGroup_Sim.sf_FldComparisonOp == "") return arrgs_PaperGroup_Sel.length>0?true:false;
var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperGroup_Sim.sf_FldComparisonOp);
console.log("clsgs_PaperGroupWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_PaperGroup_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objgs_PaperGroup_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] == strValue);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
if (arrgs_PaperGroup_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
var strMsg: string = `根据条件:[${JSON.stringify( objgs_PaperGroup_Sim)}]判断是否存在不成功!`;
throw new Error(strMsg);
}
return false;
};

 /// <summary>
 /// 根据条件获取是否存在相应的记录？
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>是否存在记录？</returns>
public static IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
var strAction = "IsExistRecord";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据关键字判断是否存在记录, 从本地缓存中判断.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
 /// </summary>
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <returns>对象</returns>
public static async IsExist_Cache(strPaperGroupId: string) {
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = await clsgs_PaperGroupWApi.GetObjLst_Cache();
var obj: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
var arrgs_PaperGroup_Sel: Array <clsgs_PaperGroupEN> = arrgs_PaperGroupObjLst_Cache.filter(x => x.PaperGroupId == strPaperGroupId);
var objgs_PaperGroup: clsgs_PaperGroupEN;
if (arrgs_PaperGroup_Sel.length > 0)
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
var strMsg: string = `根据关键字:[${ strPaperGroupId }]判断是否存在不成功!`;
alert(strMsg);
}
return false;
};

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 /// </summary>
 /// <param name = "strPaperGroupId">关键字</param>
 /// <returns>是否存在?存在返回True</returns>
public static IsExistAsync(strPaperGroupId: string): Promise<boolean> 
{
//检测记录是否存在
var strAction = "IsExist";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("PaperGroupId", strPaperGroupId);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
}

 /// <summary>
 /// 获取某一条件的记录数
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取某一条件的记录数</returns>
public static GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
var strAction = "GetRecCountByCond";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
console.log('GetRecCountByCondAsync:strData:');
console.log(strData);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnInt);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件对象, 从缓存的对象列表中获取记录数.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
 /// </summary>
 /// <param name = "objgs_PaperGroup_Cond">条件对象</param>
 /// <returns>对象列表记录数</returns>
public static async GetRecCountByCond_Cache(objgs_PaperGroup_Cond: clsgs_PaperGroupEN) {
var objgs_PaperGroup_Sim : clsgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
var arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = await clsgs_PaperGroupWApi.GetObjLst_Cache();
var arrgs_PaperGroup_Sel: Array < clsgs_PaperGroupEN > = arrgs_PaperGroupObjLst_Cache.filter(x => true);
if (objgs_PaperGroup_Sim.sf_FldComparisonOp == null || objgs_PaperGroup_Sim.sf_FldComparisonOp == "") return arrgs_PaperGroup_Sel.length;
var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperGroup_Sim.sf_FldComparisonOp);
console.log("clsgs_PaperGroupWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_PaperGroup_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] != null);
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objgs_PaperGroup_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] == strValue);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrgs_PaperGroup_Sel.length;
}
catch (e) {
var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify( objgs_PaperGroup_Sim)}]从缓存对象列表中获取记录数不成功!`;
throw new Error(strMsg);
}
return 0;
};

 /// <summary>
 /// 获取表的最大关键字
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
 /// </summary>
 /// <returns>获取表的最大关键字</returns>
public static GetMaxStrIdAsync(): Promise<string>  
{
var strAction = "GetMaxStrId";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnStr);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefixAsync)
 /// </summary>
 /// <param name = "mapParam">参数列表</param>
 /// <returns>获取当前表关键字值的最大值</returns>
public static GetMaxStrIdByPrefixAsync(strPrefix: string): Promise<string>  
{
var strAction = "GetMaxStrIdByPrefix";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("strPrefix", strPrefix);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnStr);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问地址:${ strUrl}不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 获取WebApi的地址
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
 /// </summary>
 /// <returns>返回当前文件中Web服务的地址</returns>
public static GetWebApiUrl(strController: string, strAction: string): string {
var strServiceUrl:string;
if (clsSysPara4WebApi.bolIsLocalHost == false) {
strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
}
else {
strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
}
return strServiceUrl;
}

/// <summary>
/// 为下拉框获取数据,从表:[gs_PaperGroup]中获取
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DdlBind_Cache)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public async BindDdl_PaperGroupId_Cache2(strDdlName: string, objgs_PaperGroup_Cond: clsgs_PaperGroupEN) {
//var strWhereCond = " 1 =1 ";
var objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
var strMsg = `下拉框：${ strDdlName } 不存在！`;
alert(strMsg);
throw (strMsg);
}
try
{
var arrObjLst_Sel: Array<clsgs_PaperGroupEN> = await clsgs_PaperGroupWApi.GetSubObjLst_Cache(objgs_PaperGroup_Cond);
clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsgs_PaperGroupEN.con_PaperGroupId, clsgs_PaperGroupEN.con_PaperGroupName, "论文分组");
console.log("完成BindDdl_PaperGroupId!");
}
catch (e)
{
var strMsg: string = `使用缓存对象列表绑定下拉框出错,${e}.`;
alert(strMsg);
}
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_InitListCache)
 /// </summary>
public static  InitListCache():void
{
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
 /// </summary>
public static  ReFreshCache():void
{
 var strMsg:string = `刷新缓存成功！(${clsStackTrace.GetCurrClassFunctionByLevel(3)}->${clsStackTrace.GetCurrClassFunctionByLevel(2)}->${clsStackTrace.GetCurrClassFunction()})`;
console.log(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strKey:string = clsgs_PaperGroupEN._CurrTabName;
switch (clsgs_PaperGroupWApi.CacheModeId)
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

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 /// </summary>
public static  ReFreshThisCache():void
{
var strMsg:string = "";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
var strKey:string = clsgs_PaperGroupEN._CurrTabName;
switch (clsgs_PaperGroupWApi.CacheModeId)
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
strMsg = `刷新缓存成功！(${clsStackTrace.GetCurrClassFunctionByLevel(3)}->${clsStackTrace.GetCurrClassFunctionByLevel(2)}->${clsStackTrace.GetCurrClassFunction()})`,
console.log(strMsg);
}
else
{
strMsg = `刷新缓存已经关闭。(clsSysPara4WebApi.spSetRefreshCacheOn == false)(${clsStackTrace.GetCurrClassFunctionByLevel(3)}->${clsStackTrace.GetCurrClassFunctionByLevel(2)}->${clsStackTrace.GetCurrClassFunction()})`;
console.log(strMsg);
}
}
};
export class clsgs_PaperGroupBL
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
 /// </summary>
private arrgs_PaperGroupObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
 /// </summary>
private intFindFailCount = 0;

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 public CheckPropertyNew(pobjgs_PaperGroupEN: clsgs_PaperGroupEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjgs_PaperGroupEN.UpdUser 
 || null !== pobjgs_PaperGroupEN.UpdUser && pobjgs_PaperGroupEN.UpdUser.toString()  ===  "")
{
 throw new Error("(errid:Watl000058)字段[论文分组|修改人]不能为空(NULL)!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjgs_PaperGroupEN.PaperGroupId && GetStrLen(pobjgs_PaperGroupEN.PaperGroupId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文分组(gs_PaperGroup)|组Id(PaperGroupId)]的长度不能超过8!值:$(pobjgs_PaperGroupEN.PaperGroupId)(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperGroupEN.PaperGroupName && GetStrLen(pobjgs_PaperGroupEN.PaperGroupName) > 50)
{
 throw new Error("(errid:Watl000059)字段[论文分组(gs_PaperGroup)|组名(PaperGroupName)]的长度不能超过50!值:$(pobjgs_PaperGroupEN.PaperGroupName)(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperGroupEN.UpdUser && GetStrLen(pobjgs_PaperGroupEN.UpdUser) > 50)
{
 throw new Error("(errid:Watl000059)字段[论文分组(gs_PaperGroup)|修改人(UpdUser)]的长度不能超过50!值:$(pobjgs_PaperGroupEN.UpdUser)(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperGroupEN.UpdDate && GetStrLen(pobjgs_PaperGroupEN.UpdDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[论文分组(gs_PaperGroup)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjgs_PaperGroupEN.UpdDate)(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperGroupEN.Meno && GetStrLen(pobjgs_PaperGroupEN.Meno) > 2000)
{
 throw new Error("(errid:Watl000059)字段[论文分组(gs_PaperGroup)|备注(Meno)]的长度不能超过2000!值:$(pobjgs_PaperGroupEN.Meno)(clsgs_PaperGroupBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjgs_PaperGroupEN.PaperGroupId && undefined !== pobjgs_PaperGroupEN.PaperGroupId && tzDataType.isString(pobjgs_PaperGroupEN.PaperGroupId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文分组(gs_PaperGroup)|组Id(PaperGroupId)]的值:[$(pobjgs_PaperGroupEN.PaperGroupId)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperGroupEN.PaperGroupName && undefined !== pobjgs_PaperGroupEN.PaperGroupName && tzDataType.isString(pobjgs_PaperGroupEN.PaperGroupName) === false)
{
 throw new Error("(errid:Watl000060)字段[论文分组(gs_PaperGroup)|组名(PaperGroupName)]的值:[$(pobjgs_PaperGroupEN.PaperGroupName)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperGroupEN.UpdUser && undefined !== pobjgs_PaperGroupEN.UpdUser && tzDataType.isString(pobjgs_PaperGroupEN.UpdUser) === false)
{
 throw new Error("(errid:Watl000060)字段[论文分组(gs_PaperGroup)|修改人(UpdUser)]的值:[$(pobjgs_PaperGroupEN.UpdUser)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperGroupEN.UpdDate && undefined !== pobjgs_PaperGroupEN.UpdDate && tzDataType.isString(pobjgs_PaperGroupEN.UpdDate) === false)
{
 throw new Error("(errid:Watl000060)字段[论文分组(gs_PaperGroup)|修改日期(UpdDate)]的值:[$(pobjgs_PaperGroupEN.UpdDate)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperGroupEN.Meno && undefined !== pobjgs_PaperGroupEN.Meno && tzDataType.isString(pobjgs_PaperGroupEN.Meno) === false)
{
 throw new Error("(errid:Watl000060)字段[论文分组(gs_PaperGroup)|备注(Meno)]的值:[$(pobjgs_PaperGroupEN.Meno)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_PaperGroupEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 public CheckProperty4Update (pobjgs_PaperGroupEN: clsgs_PaperGroupEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjgs_PaperGroupEN.PaperGroupId && GetStrLen(pobjgs_PaperGroupEN.PaperGroupId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文分组(gs_PaperGroup)|组Id(PaperGroupId)]的长度不能超过8!值:$(pobjgs_PaperGroupEN.PaperGroupId)(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperGroupEN.PaperGroupName && GetStrLen(pobjgs_PaperGroupEN.PaperGroupName) > 50)
{
 throw new Error("(errid:Watl000062)字段[论文分组(gs_PaperGroup)|组名(PaperGroupName)]的长度不能超过50!值:$(pobjgs_PaperGroupEN.PaperGroupName)(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperGroupEN.UpdUser && GetStrLen(pobjgs_PaperGroupEN.UpdUser) > 50)
{
 throw new Error("(errid:Watl000062)字段[论文分组(gs_PaperGroup)|修改人(UpdUser)]的长度不能超过50!值:$(pobjgs_PaperGroupEN.UpdUser)(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperGroupEN.UpdDate && GetStrLen(pobjgs_PaperGroupEN.UpdDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[论文分组(gs_PaperGroup)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjgs_PaperGroupEN.UpdDate)(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperGroupEN.Meno && GetStrLen(pobjgs_PaperGroupEN.Meno) > 2000)
{
 throw new Error("(errid:Watl000062)字段[论文分组(gs_PaperGroup)|备注(Meno)]的长度不能超过2000!值:$(pobjgs_PaperGroupEN.Meno)(clsgs_PaperGroupBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjgs_PaperGroupEN.PaperGroupId && undefined !== pobjgs_PaperGroupEN.PaperGroupId && tzDataType.isString(pobjgs_PaperGroupEN.PaperGroupId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文分组(gs_PaperGroup)|组Id(PaperGroupId)]的值:[$(pobjgs_PaperGroupEN.PaperGroupId)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperGroupEN.PaperGroupName && undefined !== pobjgs_PaperGroupEN.PaperGroupName && tzDataType.isString(pobjgs_PaperGroupEN.PaperGroupName) === false)
{
 throw new Error("(errid:Watl000063)字段[论文分组(gs_PaperGroup)|组名(PaperGroupName)]的值:[$(pobjgs_PaperGroupEN.PaperGroupName)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperGroupEN.UpdUser && undefined !== pobjgs_PaperGroupEN.UpdUser && tzDataType.isString(pobjgs_PaperGroupEN.UpdUser) === false)
{
 throw new Error("(errid:Watl000063)字段[论文分组(gs_PaperGroup)|修改人(UpdUser)]的值:[$(pobjgs_PaperGroupEN.UpdUser)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperGroupEN.UpdDate && undefined !== pobjgs_PaperGroupEN.UpdDate && tzDataType.isString(pobjgs_PaperGroupEN.UpdDate) === false)
{
 throw new Error("(errid:Watl000063)字段[论文分组(gs_PaperGroup)|修改日期(UpdDate)]的值:[$(pobjgs_PaperGroupEN.UpdDate)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperGroupEN.Meno && undefined !== pobjgs_PaperGroupEN.Meno && tzDataType.isString(pobjgs_PaperGroupEN.Meno) === false)
{
 throw new Error("(errid:Watl000063)字段[论文分组(gs_PaperGroup)|备注(Meno)]的值:[$(pobjgs_PaperGroupEN.Meno)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_PaperGroupEN.PaperGroupId 
 || null !== pobjgs_PaperGroupEN.PaperGroupId && pobjgs_PaperGroupEN.PaperGroupId.toString()  ===  ""
 || null !== pobjgs_PaperGroupEN.PaperGroupId && pobjgs_PaperGroupEN.PaperGroupId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[论文分组|组Id]不能为空(NULL)!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_PaperGroupEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:pyf2
 /// 日期:20200928182855
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
public static GetJSONStrByObj (pobjgs_PaperGroupEN: clsgs_PaperGroupEN): string
{
pobjgs_PaperGroupEN.sf_UpdFldSetStr = pobjgs_PaperGroupEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjgs_PaperGroupEN);
}
catch(objException)
{
myShowErrorMsg(objException.message);
}
return strJson;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象列表
 /// 作者:pyf2
 /// 日期:20200928182855
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
public static GetObjLstByJSONStr (strJSON: string): Array<clsgs_PaperGroupEN>
{
var arrgs_PaperGroupObjLst = new Array();
if (strJSON === "")
{
return arrgs_PaperGroupObjLst;
}
try
{
arrgs_PaperGroupObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_PaperGroupObjLst;
}
return arrgs_PaperGroupObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:pyf2
 /// 日期:20200928182855
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
public static GetObjByJSONStr (strJSON: string): clsgs_PaperGroupEN
{
var pobjgs_PaperGroupEN = new clsgs_PaperGroupEN();
if (strJSON === "")
{
return pobjgs_PaperGroupEN;
}
try
{
pobjgs_PaperGroupEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_PaperGroupEN;
}
return pobjgs_PaperGroupEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objgs_PaperGroupENS">源简化对象</param>
 /// <param name = "objgs_PaperGroupENT">目标对象</param>
public static CopyObjFromSimObj(objgs_PaperGroupENS: clsgs_PaperGroupEN_Sim, objgs_PaperGroupENT: clsgs_PaperGroupEN): void 
{
objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static GetCombineCondition(objgs_PaperGroup_Cond: clsgs_PaperGroupEN ):string
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond: string = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_PaperGroup_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperGroupEN.con_PaperGroupId) == true)
{
var strComparisonOp_PaperGroupId:string = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN.con_PaperGroupId];
strWhereCond += clsString.Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN.con_PaperGroupId, objgs_PaperGroup_Cond.PaperGroupId, strComparisonOp_PaperGroupId);
}
if (objgs_PaperGroup_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperGroupEN.con_PaperGroupName) == true)
{
var strComparisonOp_PaperGroupName:string = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN.con_PaperGroupName];
strWhereCond += clsString.Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN.con_PaperGroupName, objgs_PaperGroup_Cond.PaperGroupName, strComparisonOp_PaperGroupName);
}
if (objgs_PaperGroup_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperGroupEN.con_UpdUser) == true)
{
var strComparisonOp_UpdUser:string = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN.con_UpdUser];
strWhereCond += clsString.Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN.con_UpdUser, objgs_PaperGroup_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objgs_PaperGroup_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperGroupEN.con_UpdDate) == true)
{
var strComparisonOp_UpdDate:string = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN.con_UpdDate];
strWhereCond += clsString.Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN.con_UpdDate, objgs_PaperGroup_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objgs_PaperGroup_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperGroupEN.con_Meno) == true)
{
var strComparisonOp_Meno:string = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN.con_Meno];
strWhereCond += clsString.Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN.con_Meno, objgs_PaperGroup_Cond.Meno, strComparisonOp_Meno);
}
 return strWhereCond;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objgs_PaperGroupENS">源对象</param>
 /// <param name = "objgs_PaperGroupENT">目标对象</param>
public static CopyObjTo(objgs_PaperGroupENS: clsgs_PaperGroupEN , objgs_PaperGroupENT: clsgs_PaperGroupEN ): void 
{
objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
objgs_PaperGroupENT.sf_UpdFldSetStr = objgs_PaperGroupENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objgs_PaperGroupENS">源对象</param>
 /// <param name = "objgs_PaperGroupENT">目标对象</param>
public static CopyObjToSimObj(objgs_PaperGroupENS: clsgs_PaperGroupEN , objgs_PaperGroupENT: clsgs_PaperGroupEN_Sim ): void 
{
objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
objgs_PaperGroupENT.sf_UpdFldSetStr = objgs_PaperGroupENS.UpdFldString; //专门用于记录某字段属性是否修改
objgs_PaperGroupENT.sf_FldComparisonOp = objgs_PaperGroupENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objgs_PaperGroupENS">源简化对象</param>
 /// <param name = "objgs_PaperGroupENT">目标对象</param>
public static CopyObjFromSimObj4Upd(objgs_PaperGroupENS: clsgs_PaperGroupEN_Sim, objgs_PaperGroupENT: clsgs_PaperGroupEN ): void
 {
   var strsf_UpdFldSetStr: string = objgs_PaperGroupENS.sf_UpdFldSetStr;
    var sstrFldSet: string[] = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsgs_PaperGroupEN.con_PaperGroupId)  >= 0)
{
objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
}
if (sstrFldSet.indexOf(clsgs_PaperGroupEN.con_PaperGroupName)  >= 0)
{
objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
}
if (sstrFldSet.indexOf(clsgs_PaperGroupEN.con_UpdUser)  >= 0)
{
objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
}
if (sstrFldSet.indexOf(clsgs_PaperGroupEN.con_UpdDate)  >= 0)
{
objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsgs_PaperGroupEN.con_Meno)  >= 0)
{
objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objgs_PaperGroupENS">源对象</param>
 /// <param name = "objgs_PaperGroupENT">目标对象</param>
public static GetSimObjFromObj(objgs_PaperGroupENS: clsgs_PaperGroupEN): clsgs_PaperGroupEN_Sim 
{
var objgs_PaperGroupENT: clsgs_PaperGroupEN_Sim = new clsgs_PaperGroupEN_Sim();
objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
objgs_PaperGroupENT.sf_UpdFldSetStr = objgs_PaperGroupENS.UpdFldString; //专门用于记录某字段属性是否修改
objgs_PaperGroupENT.sf_FldComparisonOp = objgs_PaperGroupENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objgs_PaperGroupENT;
}
};