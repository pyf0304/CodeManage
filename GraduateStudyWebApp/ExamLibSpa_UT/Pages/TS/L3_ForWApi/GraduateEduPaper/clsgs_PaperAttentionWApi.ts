
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperAttentionWApi
 表名:gs_PaperAttention(01120748)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/29 00:00:12
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
 /// 论文关注(gs_PaperAttention)
 /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
 /// </summary>
/**
* Created by pyf2 on 2020年09月29日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { clsCommonFunc4Web } from "../../PubFun/clsCommonFunc4Web.js";
import { clsgs_PaperAttentionEN,  clsgs_PaperAttentionEN_Sim } from "../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js";
//import { clsvgs_PaperAttentionWApi } from "../../L3_ForWApi/GraduateEduPaper/clsvgs_PaperAttentionWApi.js";
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
export class clsgs_PaperAttentionWApi 
{
 public static mstrController: string = "gs_PaperAttentionApi";
public static CacheModeId = ""; //
public objgs_PaperAttentionEN: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
constructor( pobjgs_PaperAttentionEN: clsgs_PaperAttentionEN)
{
this.objgs_PaperAttentionEN = pobjgs_PaperAttentionEN;
};

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 /// </summary>
 /// <param name = "lngPaperAttentionId">关键字</param>
 /// <returns>对象</returns>
public static GetObjByPaperAttentionIdAsync(lngPaperAttentionId: number): Promise<clsgs_PaperAttentionEN>  
{
var strAction = "GetObjByPaperAttentionId";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("PaperAttentionId", lngPaperAttentionId);
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
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <returns>对象</returns>
public static async GetObjByPaperAttentionId_Cache(lngPaperAttentionId: number) {
var arrgs_PaperAttentionObjLst_Cache: Array<clsgs_PaperAttentionEN> = await clsgs_PaperAttentionWApi.GetObjLst_Cache();
var obj: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
try
{
var arrgs_PaperAttention_Sel: Array <clsgs_PaperAttentionEN> = arrgs_PaperAttentionObjLst_Cache.filter(x => x.PaperAttentionId == lngPaperAttentionId);
var objgs_PaperAttention: clsgs_PaperAttentionEN;
if (arrgs_PaperAttention_Sel.length > 0)
{
objgs_PaperAttention = arrgs_PaperAttention_Sel[0];
return objgs_PaperAttention;
}
else
{
return obj;
}
}
catch (e)
{
var strMsg: string = `错误:[${e}]. \n根据关键字:[${ lngPaperAttentionId }]获取相应的对象不成功!`;
alert(strMsg);
}
return obj;
};

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存中获取.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 /// </summary>
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <returns>对象</returns>
public static async GetObjByPaperAttentionId_localStorage(lngPaperAttentionId: number) {
if (lngPaperAttentionId == 0) return null;
var strKey: string = clsString.Format("{0}_{1}", clsgs_PaperAttentionEN._CurrTabName, lngPaperAttentionId);
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (localStorage.hasOwnProperty(strKey))
{
//缓存存在，直接返回
var strTempObj: string = localStorage.getItem(strKey) as string;
var objgs_PaperAttention_Cache: clsgs_PaperAttentionEN = JSON.parse(strTempObj);
return objgs_PaperAttention_Cache;
}
try
{
var objgs_PaperAttention: clsgs_PaperAttentionEN = await clsgs_PaperAttentionWApi.GetObjByPaperAttentionIdAsync(lngPaperAttentionId);
if (objgs_PaperAttention != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_PaperAttention));
var strInfo: string = `Key:[${ strKey}]的缓存已经建立!`;
console.log(strInfo);
return objgs_PaperAttention;
}
return objgs_PaperAttention;
}
catch (e)
{
var strMsg: string = `错误:[${e}]. \n根据关键字:[${ lngPaperAttentionId }]获取相应的对象不成功!`;
alert(strMsg);
return;
}
};

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存中获取.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 /// </summary>
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <returns>对象</returns>
public static async UpdateObjInLst_Cache(objgs_PaperAttention: clsgs_PaperAttentionEN) {
try
{
var arrgs_PaperAttentionObjLst_Cache: Array<clsgs_PaperAttentionEN> = await clsgs_PaperAttentionWApi.GetObjLst_Cache();
var obj = arrgs_PaperAttentionObjLst_Cache.find(x => x.PaperId == objgs_PaperAttention.PaperId && x.UserId == objgs_PaperAttention.UserId);
if (obj != null)
{
objgs_PaperAttention.PaperAttentionId = obj.PaperAttentionId;
clsgs_PaperAttentionBL.CopyObjTo(objgs_PaperAttention, obj);
}
else
{
arrgs_PaperAttentionObjLst_Cache.push(objgs_PaperAttention);
}
}
catch (e) {
var strMsg: string = `错误:[${e}]. \n在列表中修改对象不成功!`;
alert(strMsg);
};
};

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf2
 /// 日期:20200929000012
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static async func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
if (strInFldName != clsgs_PaperAttentionEN.con_PaperAttentionId)
{
var strMsg: string = clsString.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Error(strMsg);
}
if (clsgs_PaperAttentionEN.AttributeName.indexOf(strOutFldName) == -1)
{
var strMsg : string= clsString.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsgs_PaperAttentionEN.AttributeName.join(','));
throw new Error(strMsg);
}
var lngPaperAttentionId = Number(strInValue);
var objgs_PaperAttention = await clsgs_PaperAttentionWApi.GetObjByPaperAttentionId_Cache(lngPaperAttentionId );
if (objgs_PaperAttention == null) return "";
return objgs_PaperAttention[strOutFldName].toString();
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存中获取.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SetCache)
 /// </summary>
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <returns>对象</returns>
public static SetCache() {
};

 /// <summary>
 /// 根据关键字获取相应的对象
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_WA_CacheAsync)
 /// </summary>
 /// <param name = "lngPaperAttentionId">关键字</param>
 /// <returns>对象</returns>
public static GetObjByPaperAttentionId_WA_CacheAsync(lngPaperAttentionId: number): Promise<clsgs_PaperAttentionEN>  
{
var strAction = "GetObjByPaperAttentionId_Cache";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("PaperAttentionId", lngPaperAttentionId);
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
public static GetFirstObjAsync(strWhereCond: string): Promise<clsgs_PaperAttentionEN>  
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
clsgs_PaperAttentionWApi.InitListCache(); 
var strKey: string = clsgs_PaperAttentionEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
var arrgs_PaperAttentionObjLst_Cache: Array<clsgs_PaperAttentionEN> = CacheHelper.Get(strKey);
return arrgs_PaperAttentionObjLst_Cache;
}
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjLstAsync(strWhereCond);
var arrgs_PaperAttentionObjLst: Array <clsgs_PaperAttentionEN> = <Array<clsgs_PaperAttentionEN>> responseText;
CacheHelper.Add(strKey, arrgs_PaperAttentionObjLst);
var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrgs_PaperAttentionObjLst.length}!`;
console.log(strInfo);
return arrgs_PaperAttentionObjLst;
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
clsgs_PaperAttentionWApi.InitListCache(); 
var strKey: string = clsgs_PaperAttentionEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (localStorage.hasOwnProperty(strKey))
{
//缓存存在，直接返回
var strTempObjLst:string = localStorage.getItem(strKey) as string;
var arrgs_PaperAttentionObjLst_Cache: Array<clsgs_PaperAttentionEN> = JSON.parse(strTempObjLst);
return arrgs_PaperAttentionObjLst_Cache;
}
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjLstAsync(strWhereCond);
var arrgs_PaperAttentionObjLst: Array <clsgs_PaperAttentionEN> = <Array<clsgs_PaperAttentionEN>> responseText;
localStorage.setItem(strKey, JSON.stringify(arrgs_PaperAttentionObjLst));
var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrgs_PaperAttentionObjLst.length}!`;
console.log(strInfo);
return arrgs_PaperAttentionObjLst;
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
public static GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PaperAttentionEN>>  
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
clsgs_PaperAttentionWApi.InitListCache(); 
var strKey: string = clsgs_PaperAttentionEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (sessionStorage.hasOwnProperty(strKey))
{
//缓存存在，直接返回
var strTempObjLst:string = sessionStorage.getItem(strKey) as string;
var arrgs_PaperAttentionObjLst_Cache: Array<clsgs_PaperAttentionEN> = JSON.parse(strTempObjLst);
return arrgs_PaperAttentionObjLst_Cache;
}
try
{
const responseText = await clsgs_PaperAttentionWApi.GetObjLstAsync(strWhereCond);
var arrgs_PaperAttentionObjLst: Array <clsgs_PaperAttentionEN> = <Array<clsgs_PaperAttentionEN>> responseText;
sessionStorage.setItem(strKey, JSON.stringify(arrgs_PaperAttentionObjLst));
var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrgs_PaperAttentionObjLst.length}!`;
console.log(strInfo);
return arrgs_PaperAttentionObjLst;
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
var arrgs_PaperAttentionObjLst_Cache: Array<clsgs_PaperAttentionEN>;
switch (clsgs_PaperAttentionWApi.CacheModeId)
{
case "04"://sessionStorage
arrgs_PaperAttentionObjLst_Cache = await clsgs_PaperAttentionWApi.GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_PaperAttentionObjLst_Cache = await clsgs_PaperAttentionWApi.GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_PaperAttentionObjLst_Cache = await clsgs_PaperAttentionWApi.GetObjLst_ClientCache();
break;
default:
arrgs_PaperAttentionObjLst_Cache = await clsgs_PaperAttentionWApi.GetObjLst_ClientCache();
break;
}
return arrgs_PaperAttentionObjLst_Cache;
}

 /// <summary>
 /// 获取服务器缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_WA_CacheAsync)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取的相应对象列表</returns>
public static GetObjLst_WA_CacheAsync(): Promise<Array<clsgs_PaperAttentionEN>>  
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
 /// <param name = "objlngPaperAttentionId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static async GetSubObjLst_Cache(objgs_PaperAttention_Cond: clsgs_PaperAttentionEN) {
var objgs_PaperAttention_Sim : clsgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttention_Cond);
var arrgs_PaperAttentionObjLst_Cache: Array<clsgs_PaperAttentionEN> = await clsgs_PaperAttentionWApi.GetObjLst_Cache();
var arrgs_PaperAttention_Sel: Array < clsgs_PaperAttentionEN > = arrgs_PaperAttentionObjLst_Cache.filter(x => true);
if (objgs_PaperAttention_Sim.sf_FldComparisonOp == null || objgs_PaperAttention_Sim.sf_FldComparisonOp == "") return arrgs_PaperAttention_Sel;
var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperAttention_Sim.sf_FldComparisonOp);
console.log("clsgs_PaperAttentionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_PaperAttention_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] != null);
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objgs_PaperAttention_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] == strValue);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrgs_PaperAttention_Sel;
}
catch (e) {
var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify( objgs_PaperAttention_Sim)}]缓存对象列表中获取子集对象不成功!`;
throw new Error(strMsg);
}
return new Array<clsgs_PaperAttentionEN>();
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_WA_CacheAsync)
 /// </summary>
 /// <param name = "objgs_PaperAttention_Cond">条件对象</param>
 /// <returns>获取的相应记录对象列表</returns>
public static GetSubObjLst_WA_CacheAsync(objgs_PaperAttention_Cond: clsgs_PaperAttentionEN): Promise<Array<clsgs_PaperAttentionEN>>  
{
var strAction = "GetSubObjLst_Cache";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var objgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttention_Cond);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objgs_PaperAttentionEN_Sim,
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
 /// <param name = "arrPaperAttentionId">关键字列表</param>
 /// <returns>对象列表</returns>
public static GetObjLstByPaperAttentionIdLstAsync(arrPaperAttentionId: Array<string>): Promise<Array<clsgs_PaperAttentionEN>>  
{
var strAction = "GetObjLstByPaperAttentionIdLst";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrPaperAttentionId },
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
 /// <param name = "arrlngPaperAttentionIdLst">关键字列表</param>
 /// <returns>对象列表</returns>
public static async GetObjLstByPaperAttentionIdLst_Cache(arrPaperAttentionIdLst: Array<number>) {
try
{
var arrgs_PaperAttentionObjLst_Cache: Array<clsgs_PaperAttentionEN> = await clsgs_PaperAttentionWApi.GetObjLst_Cache();
var arrgs_PaperAttention_Sel: Array <clsgs_PaperAttentionEN> = arrgs_PaperAttentionObjLst_Cache.filter(x => arrPaperAttentionIdLst.indexOf(x.PaperAttentionId)>-1);
return arrgs_PaperAttention_Sel;
}
catch (e)
{
var strMsg: string = `错误:[${e}]. \n根据关键字:[${ arrPaperAttentionIdLst.join(",") }]获取对象列表不成功!`;
throw new Error(strMsg);
}
return new Array<clsgs_PaperAttentionEN>();
};

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 从WebApi缓存中获取
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_WA_CacheAsync)
 /// </summary>
 /// <param name = "arrPaperAttentionId">关键字列表</param>
 /// <returns>对象列表</returns>
public static GetObjLstByPaperAttentionIdLst_WA_CacheAsync(arrPaperAttentionId: Array<string>): Promise<Array<clsgs_PaperAttentionEN>>  
{
var strAction = "GetObjLstByPaperAttentionIdLst_Cache";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrPaperAttentionId },
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
public static GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_PaperAttentionEN>>  
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
public static GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_PaperAttentionEN>>  
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
var arrgs_PaperAttentionObjLst_Cache: Array<clsgs_PaperAttentionEN> = await clsgs_PaperAttentionWApi.GetObjLst_Cache();
if (arrgs_PaperAttentionObjLst_Cache.length == 0) return arrgs_PaperAttentionObjLst_Cache;
var arrgs_PaperAttention_Sel: Array < clsgs_PaperAttentionEN > = arrgs_PaperAttentionObjLst_Cache.filter(x => true);
var obj_Cond: clsgs_PaperAttentionEN_Sim = JSON.parse(objPagerPara.WhereCond);
var dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
console.log("clsgs_PaperAttentionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web.GetObjKeys(obj_Cond);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] != null);
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = obj_Cond[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] == strValue);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
if (arrgs_PaperAttention_Sel.length == 0) return arrgs_PaperAttention_Sel;
var intStart: number = objPagerPara.PageSize* (objPagerPara.PageIndex - 1);
if (intStart <= 0) intStart = 0;
var intEnd = intStart + objPagerPara.PageSize;
if (objPagerPara.OrderBy != null && objPagerPara.OrderBy.length>0) {
var sstrSplit: string[] = objPagerPara.OrderBy.split(" ");
var strSortType: string = "asc";
var strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
//                console.log(arrgs_PaperAttention_Sel);
let objFirst = arrgs_PaperAttention_Sel[0];//第一个对象
let strSortValue = objFirst[strSortFld];  //第一个对象排序字段值            
let strSortFldType = typeof(strSortValue);//排序字段值的数据类型
//console.log("排序字段的数据类型: " + strSortFldType);
switch (strSortFldType)
{
case "string":
if (strSortType.toLowerCase() == "asc") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
}
else {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
}
break;
case "number":
case "boolean":
if (strSortType.toLowerCase() == "asc") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.sort((x, y) => x[strSortFld] - y[strSortFld]);
}
else {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.sort((x, y) => y[strSortFld] - x[strSortFld]);
}
break;
}
}
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.slice(intStart, intEnd);     
return arrgs_PaperAttention_Sel;
}
catch (e) {
var strMsg: string = `错误:[${e}]. \n根据条件:[${objPagerPara.WhereCond}]获取分页对象列表不成功!(In clsgs_PaperAttentionWApi.GetObjLstByPager_Cache)`;
throw new Error(strMsg);
}
return new Array<clsgs_PaperAttentionEN>();
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_WA_CacheAsync)
 /// </summary>
 /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
 /// <returns>获取的相应记录对象列表</returns>
public static GetObjLstByPager_WA_CacheAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperAttentionEN>>  
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
public static GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperAttentionEN>>  
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
 /// <param name = "lngPaperAttentionId">关键字</param>
 /// <returns>获取删除的结果</returns>
public static DelRecordAsync(lngPaperAttentionId: number): Promise<number>  
{
var strAction = "DelRecord";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
strUrl = `${strUrl}/${ lngPaperAttentionId }`;
var mapParam: Dictionary = new Dictionary();
mapParam.add("lngPaperAttentionId", lngPaperAttentionId);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "DELETE",
dataType: "json",
data: { "": lngPaperAttentionId },
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
 /// <param name = "arrPaperAttentionId">关键字列表</param>
 /// <returns>实际删除记录的个数</returns>
public static Delgs_PaperAttentionsAsync(arrPaperAttentionId: Array<string>): Promise<number> 
{
var strAction = "Delgs_PaperAttentions";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrPaperAttentionId },
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
public static Delgs_PaperAttentionsByCondAsync(strWhereCond: string): Promise<number> 
{
var strAction = "Delgs_PaperAttentionsByCond";
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
 /// <param name = "objgs_PaperAttentionEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
public static AddNewRecordAsync(objgs_PaperAttentionEN: clsgs_PaperAttentionEN): Promise<boolean> 
{
var strMsg = "";
var strAction = "AddNewRecord";
var objgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttentionEN);
 //var strJSON = JSON.stringify(objgs_PaperAttentionEN_Sim);
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objgs_PaperAttentionEN_Sim,
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static AddNewRecordWithReturnKeyAsync(objgs_PaperAttentionEN: clsgs_PaperAttentionEN): Promise<string> 
{
var strAction = "AddNewRecordWithReturnKey";
var objgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttentionEN);
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objgs_PaperAttentionEN_Sim,
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
 /// <param name = "objgs_PaperAttentionEN">需要添加的对象</param>
 /// <returns>获取修改是否成功？</returns>
public static UpdateRecordAsync(objgs_PaperAttentionEN: clsgs_PaperAttentionEN): Promise<boolean>  
{
var strMsg = "";
var strAction = "UpdateRecord";
 if (objgs_PaperAttentionEN.sf_UpdFldSetStr === null || objgs_PaperAttentionEN.sf_UpdFldSetStr === "")
{
strMsg = `对象(关键字: ${objgs_PaperAttentionEN.PaperAttentionId })的【修改字段集】为空，不能修改!`;
 throw strMsg;
 }
var objgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttentionEN);
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objgs_PaperAttentionEN_Sim,
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
 /// <param name = "objgs_PaperAttentionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static UpdateWithConditionAsync(objgs_PaperAttentionEN: clsgs_PaperAttentionEN, strWhereCond: string ): Promise<boolean> 
{
var strAction = "UpdateWithCondition";
 if (objgs_PaperAttentionEN.sf_UpdFldSetStr === null || objgs_PaperAttentionEN.sf_UpdFldSetStr === "")
{
var strMsg = `对象(关键字: ${objgs_PaperAttentionEN.PaperAttentionId })的【修改字段集】为空，不能修改!`;
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
 /// <param name = "objlngPaperAttentionId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static async IsExistRecord_Cache(objgs_PaperAttention_Cond: clsgs_PaperAttentionEN) {
var objgs_PaperAttention_Sim : clsgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttention_Cond);
var arrgs_PaperAttentionObjLst_Cache: Array<clsgs_PaperAttentionEN> = await clsgs_PaperAttentionWApi.GetObjLst_Cache();
var arrgs_PaperAttention_Sel: Array < clsgs_PaperAttentionEN > = arrgs_PaperAttentionObjLst_Cache.filter(x => true);
if (objgs_PaperAttention_Sim.sf_FldComparisonOp == null || objgs_PaperAttention_Sim.sf_FldComparisonOp == "") return arrgs_PaperAttention_Sel.length>0?true:false;
var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperAttention_Sim.sf_FldComparisonOp);
console.log("clsgs_PaperAttentionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_PaperAttention_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objgs_PaperAttention_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] == strValue);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
if (arrgs_PaperAttention_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
var strMsg: string = `根据条件:[${JSON.stringify( objgs_PaperAttention_Sim)}]判断是否存在不成功!`;
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
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <returns>对象</returns>
public static async IsExist_Cache(lngPaperAttentionId: number) {
var arrgs_PaperAttentionObjLst_Cache: Array<clsgs_PaperAttentionEN> = await clsgs_PaperAttentionWApi.GetObjLst_Cache();
var obj: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
try
{
var arrgs_PaperAttention_Sel: Array <clsgs_PaperAttentionEN> = arrgs_PaperAttentionObjLst_Cache.filter(x => x.PaperAttentionId == lngPaperAttentionId);
var objgs_PaperAttention: clsgs_PaperAttentionEN;
if (arrgs_PaperAttention_Sel.length > 0)
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
var strMsg: string = `根据关键字:[${ lngPaperAttentionId }]判断是否存在不成功!`;
alert(strMsg);
}
return false;
};

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 /// </summary>
 /// <param name = "lngPaperAttentionId">关键字</param>
 /// <returns>是否存在?存在返回True</returns>
public static IsExistAsync(lngPaperAttentionId: number): Promise<boolean> 
{
//检测记录是否存在
var strAction = "IsExist";
let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
var mapParam: Dictionary = new Dictionary();
mapParam.add("PaperAttentionId", lngPaperAttentionId);
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
 /// <param name = "objgs_PaperAttention_Cond">条件对象</param>
 /// <returns>对象列表记录数</returns>
public static async GetRecCountByCond_Cache(objgs_PaperAttention_Cond: clsgs_PaperAttentionEN) {
var objgs_PaperAttention_Sim : clsgs_PaperAttentionEN_Sim = clsgs_PaperAttentionBL.GetSimObjFromObj(objgs_PaperAttention_Cond);
var arrgs_PaperAttentionObjLst_Cache: Array<clsgs_PaperAttentionEN> = await clsgs_PaperAttentionWApi.GetObjLst_Cache();
var arrgs_PaperAttention_Sel: Array < clsgs_PaperAttentionEN > = arrgs_PaperAttentionObjLst_Cache.filter(x => true);
if (objgs_PaperAttention_Sim.sf_FldComparisonOp == null || objgs_PaperAttention_Sim.sf_FldComparisonOp == "") return arrgs_PaperAttention_Sel.length;
var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperAttention_Sim.sf_FldComparisonOp);
console.log("clsgs_PaperAttentionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_PaperAttention_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] != null);
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objgs_PaperAttention_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] == strValue);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrgs_PaperAttention_Sel.length;
}
catch (e) {
var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify( objgs_PaperAttention_Sim)}]从缓存对象列表中获取记录数不成功!`;
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
var strKey:string = clsgs_PaperAttentionEN._CurrTabName;
switch (clsgs_PaperAttentionWApi.CacheModeId)
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
clsvgs_PaperAttentionWApi.ReFreshThisCache();
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
var strKey:string = clsgs_PaperAttentionEN._CurrTabName;
switch (clsgs_PaperAttentionWApi.CacheModeId)
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
export class clsgs_PaperAttentionBL
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
 /// </summary>
private arrgs_PaperAttentionObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
 /// </summary>
private intFindFailCount = 0;

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 public CheckPropertyNew(pobjgs_PaperAttentionEN: clsgs_PaperAttentionEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjgs_PaperAttentionEN.UpdUser 
 || null !== pobjgs_PaperAttentionEN.UpdUser && pobjgs_PaperAttentionEN.UpdUser.toString()  ===  "")
{
 throw new Error("(errid:Watl000058)字段[论文关注|修改人]不能为空(NULL)!(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjgs_PaperAttentionEN.PaperId && GetStrLen(pobjgs_PaperAttentionEN.PaperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文关注(gs_PaperAttention)|论文Id(PaperId)]的长度不能超过8!值:$(pobjgs_PaperAttentionEN.PaperId)(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperAttentionEN.UserId && GetStrLen(pobjgs_PaperAttentionEN.UserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[论文关注(gs_PaperAttention)|用户ID(UserId)]的长度不能超过20!值:$(pobjgs_PaperAttentionEN.UserId)(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperAttentionEN.PaperGroupId && GetStrLen(pobjgs_PaperAttentionEN.PaperGroupId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文关注(gs_PaperAttention)|组Id(PaperGroupId)]的长度不能超过8!值:$(pobjgs_PaperAttentionEN.PaperGroupId)(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperAttentionEN.UpdUser && GetStrLen(pobjgs_PaperAttentionEN.UpdUser) > 50)
{
 throw new Error("(errid:Watl000059)字段[论文关注(gs_PaperAttention)|修改人(UpdUser)]的长度不能超过50!值:$(pobjgs_PaperAttentionEN.UpdUser)(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperAttentionEN.UpdDate && GetStrLen(pobjgs_PaperAttentionEN.UpdDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[论文关注(gs_PaperAttention)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjgs_PaperAttentionEN.UpdDate)(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperAttentionEN.Meno && GetStrLen(pobjgs_PaperAttentionEN.Meno) > 2000)
{
 throw new Error("(errid:Watl000059)字段[论文关注(gs_PaperAttention)|备注(Meno)]的长度不能超过2000!值:$(pobjgs_PaperAttentionEN.Meno)(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjgs_PaperAttentionEN.PaperAttentionId && undefined !== pobjgs_PaperAttentionEN.PaperAttentionId && tzDataType.isNumber(pobjgs_PaperAttentionEN.PaperAttentionId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文关注(gs_PaperAttention)|论文收藏Id(PaperAttentionId)]的值:[$(pobjgs_PaperAttentionEN.PaperAttentionId)], 非法，应该为数值型!(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperAttentionEN.PaperId && undefined !== pobjgs_PaperAttentionEN.PaperId && tzDataType.isString(pobjgs_PaperAttentionEN.PaperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文关注(gs_PaperAttention)|论文Id(PaperId)]的值:[$(pobjgs_PaperAttentionEN.PaperId)], 非法，应该为字符型!(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperAttentionEN.UserId && undefined !== pobjgs_PaperAttentionEN.UserId && tzDataType.isString(pobjgs_PaperAttentionEN.UserId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文关注(gs_PaperAttention)|用户ID(UserId)]的值:[$(pobjgs_PaperAttentionEN.UserId)], 非法，应该为字符型!(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperAttentionEN.PaperGroupId && undefined !== pobjgs_PaperAttentionEN.PaperGroupId && tzDataType.isString(pobjgs_PaperAttentionEN.PaperGroupId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文关注(gs_PaperAttention)|组Id(PaperGroupId)]的值:[$(pobjgs_PaperAttentionEN.PaperGroupId)], 非法，应该为字符型!(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperAttentionEN.UpdUser && undefined !== pobjgs_PaperAttentionEN.UpdUser && tzDataType.isString(pobjgs_PaperAttentionEN.UpdUser) === false)
{
 throw new Error("(errid:Watl000060)字段[论文关注(gs_PaperAttention)|修改人(UpdUser)]的值:[$(pobjgs_PaperAttentionEN.UpdUser)], 非法，应该为字符型!(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperAttentionEN.UpdDate && undefined !== pobjgs_PaperAttentionEN.UpdDate && tzDataType.isString(pobjgs_PaperAttentionEN.UpdDate) === false)
{
 throw new Error("(errid:Watl000060)字段[论文关注(gs_PaperAttention)|修改日期(UpdDate)]的值:[$(pobjgs_PaperAttentionEN.UpdDate)], 非法，应该为字符型!(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
if (null !== pobjgs_PaperAttentionEN.Meno && undefined !== pobjgs_PaperAttentionEN.Meno && tzDataType.isString(pobjgs_PaperAttentionEN.Meno) === false)
{
 throw new Error("(errid:Watl000060)字段[论文关注(gs_PaperAttention)|备注(Meno)]的值:[$(pobjgs_PaperAttentionEN.Meno)], 非法，应该为字符型!(clsgs_PaperAttentionBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_PaperAttentionEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 public CheckProperty4Update (pobjgs_PaperAttentionEN: clsgs_PaperAttentionEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjgs_PaperAttentionEN.PaperId && GetStrLen(pobjgs_PaperAttentionEN.PaperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文关注(gs_PaperAttention)|论文Id(PaperId)]的长度不能超过8!值:$(pobjgs_PaperAttentionEN.PaperId)(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperAttentionEN.UserId && GetStrLen(pobjgs_PaperAttentionEN.UserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[论文关注(gs_PaperAttention)|用户ID(UserId)]的长度不能超过20!值:$(pobjgs_PaperAttentionEN.UserId)(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperAttentionEN.PaperGroupId && GetStrLen(pobjgs_PaperAttentionEN.PaperGroupId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文关注(gs_PaperAttention)|组Id(PaperGroupId)]的长度不能超过8!值:$(pobjgs_PaperAttentionEN.PaperGroupId)(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperAttentionEN.UpdUser && GetStrLen(pobjgs_PaperAttentionEN.UpdUser) > 50)
{
 throw new Error("(errid:Watl000062)字段[论文关注(gs_PaperAttention)|修改人(UpdUser)]的长度不能超过50!值:$(pobjgs_PaperAttentionEN.UpdUser)(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperAttentionEN.UpdDate && GetStrLen(pobjgs_PaperAttentionEN.UpdDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[论文关注(gs_PaperAttention)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjgs_PaperAttentionEN.UpdDate)(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperAttentionEN.Meno && GetStrLen(pobjgs_PaperAttentionEN.Meno) > 2000)
{
 throw new Error("(errid:Watl000062)字段[论文关注(gs_PaperAttention)|备注(Meno)]的长度不能超过2000!值:$(pobjgs_PaperAttentionEN.Meno)(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjgs_PaperAttentionEN.PaperAttentionId && undefined !== pobjgs_PaperAttentionEN.PaperAttentionId && tzDataType.isNumber(pobjgs_PaperAttentionEN.PaperAttentionId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文关注(gs_PaperAttention)|论文收藏Id(PaperAttentionId)]的值:[$(pobjgs_PaperAttentionEN.PaperAttentionId)], 非法，应该为数值型!(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperAttentionEN.PaperId && undefined !== pobjgs_PaperAttentionEN.PaperId && tzDataType.isString(pobjgs_PaperAttentionEN.PaperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文关注(gs_PaperAttention)|论文Id(PaperId)]的值:[$(pobjgs_PaperAttentionEN.PaperId)], 非法，应该为字符型!(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperAttentionEN.UserId && undefined !== pobjgs_PaperAttentionEN.UserId && tzDataType.isString(pobjgs_PaperAttentionEN.UserId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文关注(gs_PaperAttention)|用户ID(UserId)]的值:[$(pobjgs_PaperAttentionEN.UserId)], 非法，应该为字符型!(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperAttentionEN.PaperGroupId && undefined !== pobjgs_PaperAttentionEN.PaperGroupId && tzDataType.isString(pobjgs_PaperAttentionEN.PaperGroupId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文关注(gs_PaperAttention)|组Id(PaperGroupId)]的值:[$(pobjgs_PaperAttentionEN.PaperGroupId)], 非法，应该为字符型!(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperAttentionEN.UpdUser && undefined !== pobjgs_PaperAttentionEN.UpdUser && tzDataType.isString(pobjgs_PaperAttentionEN.UpdUser) === false)
{
 throw new Error("(errid:Watl000063)字段[论文关注(gs_PaperAttention)|修改人(UpdUser)]的值:[$(pobjgs_PaperAttentionEN.UpdUser)], 非法，应该为字符型!(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperAttentionEN.UpdDate && undefined !== pobjgs_PaperAttentionEN.UpdDate && tzDataType.isString(pobjgs_PaperAttentionEN.UpdDate) === false)
{
 throw new Error("(errid:Watl000063)字段[论文关注(gs_PaperAttention)|修改日期(UpdDate)]的值:[$(pobjgs_PaperAttentionEN.UpdDate)], 非法，应该为字符型!(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
if (null !== pobjgs_PaperAttentionEN.Meno && undefined !== pobjgs_PaperAttentionEN.Meno && tzDataType.isString(pobjgs_PaperAttentionEN.Meno) === false)
{
 throw new Error("(errid:Watl000063)字段[论文关注(gs_PaperAttention)|备注(Meno)]的值:[$(pobjgs_PaperAttentionEN.Meno)], 非法，应该为字符型!(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_PaperAttentionEN.PaperAttentionId 
 || null !== pobjgs_PaperAttentionEN.PaperAttentionId && pobjgs_PaperAttentionEN.PaperAttentionId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[论文关注|论文收藏Id]不能为空(NULL)!(clsgs_PaperAttentionBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_PaperAttentionEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:pyf2
 /// 日期:20200929000012
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
public static GetJSONStrByObj (pobjgs_PaperAttentionEN: clsgs_PaperAttentionEN): string
{
pobjgs_PaperAttentionEN.sf_UpdFldSetStr = pobjgs_PaperAttentionEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjgs_PaperAttentionEN);
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
 /// 日期:20200929000012
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
public static GetObjLstByJSONStr (strJSON: string): Array<clsgs_PaperAttentionEN>
{
var arrgs_PaperAttentionObjLst = new Array();
if (strJSON === "")
{
return arrgs_PaperAttentionObjLst;
}
try
{
arrgs_PaperAttentionObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_PaperAttentionObjLst;
}
return arrgs_PaperAttentionObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:pyf2
 /// 日期:20200929000012
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
public static GetObjByJSONStr (strJSON: string): clsgs_PaperAttentionEN
{
var pobjgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
if (strJSON === "")
{
return pobjgs_PaperAttentionEN;
}
try
{
pobjgs_PaperAttentionEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_PaperAttentionEN;
}
return pobjgs_PaperAttentionEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objgs_PaperAttentionENS">源简化对象</param>
 /// <param name = "objgs_PaperAttentionENT">目标对象</param>
public static CopyObjFromSimObj(objgs_PaperAttentionENS: clsgs_PaperAttentionEN_Sim, objgs_PaperAttentionENT: clsgs_PaperAttentionEN): void 
{
objgs_PaperAttentionENT.PaperAttentionId = objgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
objgs_PaperAttentionENT.PaperId = objgs_PaperAttentionENS.PaperId; //论文Id
objgs_PaperAttentionENT.UserId = objgs_PaperAttentionENS.UserId; //用户ID
objgs_PaperAttentionENT.PaperGroupId = objgs_PaperAttentionENS.PaperGroupId; //组Id
objgs_PaperAttentionENT.UpdUser = objgs_PaperAttentionENS.UpdUser; //修改人
objgs_PaperAttentionENT.UpdDate = objgs_PaperAttentionENS.UpdDate; //修改日期
objgs_PaperAttentionENT.Meno = objgs_PaperAttentionENS.Meno; //备注
}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static GetCombineCondition(objgs_PaperAttention_Cond: clsgs_PaperAttentionEN ):string
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond: string = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_PaperAttention_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperAttentionEN.con_PaperAttentionId) == true)
{
var strComparisonOp_PaperAttentionId:string = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN.con_PaperAttentionId];
strWhereCond += clsString.Format(" And {0} {2} {1}", clsgs_PaperAttentionEN.con_PaperAttentionId, objgs_PaperAttention_Cond.PaperAttentionId, strComparisonOp_PaperAttentionId);
}
if (objgs_PaperAttention_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperAttentionEN.con_PaperId) == true)
{
var strComparisonOp_PaperId:string = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN.con_PaperId];
strWhereCond += clsString.Format(" And {0} {2} '{1}'", clsgs_PaperAttentionEN.con_PaperId, objgs_PaperAttention_Cond.PaperId, strComparisonOp_PaperId);
}
if (objgs_PaperAttention_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperAttentionEN.con_UserId) == true)
{
var strComparisonOp_UserId:string = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN.con_UserId];
strWhereCond += clsString.Format(" And {0} {2} '{1}'", clsgs_PaperAttentionEN.con_UserId, objgs_PaperAttention_Cond.UserId, strComparisonOp_UserId);
}
if (objgs_PaperAttention_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperAttentionEN.con_PaperGroupId) == true)
{
var strComparisonOp_PaperGroupId:string = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN.con_PaperGroupId];
strWhereCond += clsString.Format(" And {0} {2} '{1}'", clsgs_PaperAttentionEN.con_PaperGroupId, objgs_PaperAttention_Cond.PaperGroupId, strComparisonOp_PaperGroupId);
}
if (objgs_PaperAttention_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperAttentionEN.con_UpdUser) == true)
{
var strComparisonOp_UpdUser:string = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN.con_UpdUser];
strWhereCond += clsString.Format(" And {0} {2} '{1}'", clsgs_PaperAttentionEN.con_UpdUser, objgs_PaperAttention_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objgs_PaperAttention_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperAttentionEN.con_UpdDate) == true)
{
var strComparisonOp_UpdDate:string = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN.con_UpdDate];
strWhereCond += clsString.Format(" And {0} {2} '{1}'", clsgs_PaperAttentionEN.con_UpdDate, objgs_PaperAttention_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objgs_PaperAttention_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperAttentionEN.con_Meno) == true)
{
var strComparisonOp_Meno:string = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN.con_Meno];
strWhereCond += clsString.Format(" And {0} {2} '{1}'", clsgs_PaperAttentionEN.con_Meno, objgs_PaperAttention_Cond.Meno, strComparisonOp_Meno);
}
 return strWhereCond;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objgs_PaperAttentionENS">源对象</param>
 /// <param name = "objgs_PaperAttentionENT">目标对象</param>
public static CopyObjTo(objgs_PaperAttentionENS: clsgs_PaperAttentionEN , objgs_PaperAttentionENT: clsgs_PaperAttentionEN ): void 
{
objgs_PaperAttentionENT.PaperAttentionId = objgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
objgs_PaperAttentionENT.PaperId = objgs_PaperAttentionENS.PaperId; //论文Id
objgs_PaperAttentionENT.UserId = objgs_PaperAttentionENS.UserId; //用户ID
objgs_PaperAttentionENT.PaperGroupId = objgs_PaperAttentionENS.PaperGroupId; //组Id
objgs_PaperAttentionENT.UpdUser = objgs_PaperAttentionENS.UpdUser; //修改人
objgs_PaperAttentionENT.UpdDate = objgs_PaperAttentionENS.UpdDate; //修改日期
objgs_PaperAttentionENT.Meno = objgs_PaperAttentionENS.Meno; //备注
objgs_PaperAttentionENT.sf_UpdFldSetStr = objgs_PaperAttentionENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objgs_PaperAttentionENS">源对象</param>
 /// <param name = "objgs_PaperAttentionENT">目标对象</param>
public static CopyObjToSimObj(objgs_PaperAttentionENS: clsgs_PaperAttentionEN , objgs_PaperAttentionENT: clsgs_PaperAttentionEN_Sim ): void 
{
objgs_PaperAttentionENT.PaperAttentionId = objgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
objgs_PaperAttentionENT.PaperId = objgs_PaperAttentionENS.PaperId; //论文Id
objgs_PaperAttentionENT.UserId = objgs_PaperAttentionENS.UserId; //用户ID
objgs_PaperAttentionENT.PaperGroupId = objgs_PaperAttentionENS.PaperGroupId; //组Id
objgs_PaperAttentionENT.UpdUser = objgs_PaperAttentionENS.UpdUser; //修改人
objgs_PaperAttentionENT.UpdDate = objgs_PaperAttentionENS.UpdDate; //修改日期
objgs_PaperAttentionENT.Meno = objgs_PaperAttentionENS.Meno; //备注
objgs_PaperAttentionENT.sf_UpdFldSetStr = objgs_PaperAttentionENS.UpdFldString; //专门用于记录某字段属性是否修改
objgs_PaperAttentionENT.sf_FldComparisonOp = objgs_PaperAttentionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objgs_PaperAttentionENS">源简化对象</param>
 /// <param name = "objgs_PaperAttentionENT">目标对象</param>
public static CopyObjFromSimObj4Upd(objgs_PaperAttentionENS: clsgs_PaperAttentionEN_Sim, objgs_PaperAttentionENT: clsgs_PaperAttentionEN ): void
 {
   var strsf_UpdFldSetStr: string = objgs_PaperAttentionENS.sf_UpdFldSetStr;
    var sstrFldSet: string[] = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsgs_PaperAttentionEN.con_PaperAttentionId)  >= 0)
{
objgs_PaperAttentionENT.PaperAttentionId = objgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
}
if (sstrFldSet.indexOf(clsgs_PaperAttentionEN.con_PaperId)  >= 0)
{
objgs_PaperAttentionENT.PaperId = objgs_PaperAttentionENS.PaperId; //论文Id
}
if (sstrFldSet.indexOf(clsgs_PaperAttentionEN.con_UserId)  >= 0)
{
objgs_PaperAttentionENT.UserId = objgs_PaperAttentionENS.UserId; //用户ID
}
if (sstrFldSet.indexOf(clsgs_PaperAttentionEN.con_PaperGroupId)  >= 0)
{
objgs_PaperAttentionENT.PaperGroupId = objgs_PaperAttentionENS.PaperGroupId; //组Id
}
if (sstrFldSet.indexOf(clsgs_PaperAttentionEN.con_UpdUser)  >= 0)
{
objgs_PaperAttentionENT.UpdUser = objgs_PaperAttentionENS.UpdUser; //修改人
}
if (sstrFldSet.indexOf(clsgs_PaperAttentionEN.con_UpdDate)  >= 0)
{
objgs_PaperAttentionENT.UpdDate = objgs_PaperAttentionENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsgs_PaperAttentionEN.con_Meno)  >= 0)
{
objgs_PaperAttentionENT.Meno = objgs_PaperAttentionENS.Meno; //备注
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objgs_PaperAttentionENS">源对象</param>
 /// <param name = "objgs_PaperAttentionENT">目标对象</param>
public static GetSimObjFromObj(objgs_PaperAttentionENS: clsgs_PaperAttentionEN): clsgs_PaperAttentionEN_Sim 
{
var objgs_PaperAttentionENT: clsgs_PaperAttentionEN_Sim = new clsgs_PaperAttentionEN_Sim();
objgs_PaperAttentionENT.PaperAttentionId = objgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
objgs_PaperAttentionENT.PaperId = objgs_PaperAttentionENS.PaperId; //论文Id
objgs_PaperAttentionENT.UserId = objgs_PaperAttentionENS.UserId; //用户ID
objgs_PaperAttentionENT.PaperGroupId = objgs_PaperAttentionENS.PaperGroupId; //组Id
objgs_PaperAttentionENT.UpdUser = objgs_PaperAttentionENS.UpdUser; //修改人
objgs_PaperAttentionENT.UpdDate = objgs_PaperAttentionENS.UpdDate; //修改日期
objgs_PaperAttentionENT.Meno = objgs_PaperAttentionENS.Meno; //备注
objgs_PaperAttentionENT.sf_UpdFldSetStr = objgs_PaperAttentionENS.UpdFldString; //专门用于记录某字段属性是否修改
objgs_PaperAttentionENT.sf_FldComparisonOp = objgs_PaperAttentionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objgs_PaperAttentionENT;
}
};