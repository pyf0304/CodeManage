﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEditRegionFldsWApi
 表名:vEditRegionFlds(00050126)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:38
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:区域管理
 模块英文名:RegionManage
 框架-层名:WA_访问层RJ(WA_AccessRJ)
 编程语言:JavaScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
var __importStar = (this && this.__importStar) || function(mod) {
if (mod && mod.__esModule) return mod;
var result = { };
if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];
result["default"] = mod;
return result;
};
(function(factory) {
if (typeof module === "object" && typeof module.exports === "object")
{
var v = factory(require, exports);
if (v !== undefined) module.exports = v;
}
else if (typeof define === "function" && define.amd)
{
define(["require", "exports", "jquery", "../../L0_Entity/RegionManage/clsvEditRegionFldsEN.js","clscommonfunc4web","clsstacktrace","../../L2_BLL/RegionManage/clsvEditRegionFldsBL.js","tzdictionary","clssyspara4webapi","../../PubFun/stuTopPara.js","../../PubFun/stuRangePara.js","../../PubFun/stuPagerPara.js","cachehelper","clsfldcomparisonobj","../../L3_ForWApi/RegionManage/clsEditRegionFldsWApi.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvEditRegionFldsEN_js_1 = require("../../L0_Entity/RegionManage/clsvEditRegionFldsEN.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsvEditRegionFldsBL_js_1 = require("../../L2_BLL/RegionManage/clsvEditRegionFldsBL.js");
var Dictionary_js_1 = require("tzdictionary");
var clsSysPara4WebApi_js_1 = require("clssyspara4webapi");
var stuTopPara_js_1 = require("../../PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../PubFun/stuPagerPara.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
var clsEditRegionFldsWApi_js_1 = require("../../L3_ForWApi/RegionManage/clsEditRegionFldsWApi.js");

 /// <summary>
 /// v编辑区域字段(vEditRegionFlds)
 /// (AutoGCLib.WA_AccessRJ4JavaScript:GeneCode)
 /// </summary>
var ResponseData;
var clsvEditRegionFldsWApi = /** @class */ (function() {
function clsvEditRegionFldsWApi(pobjvEditRegionFldsEN)
{
this.objvEditRegionFldsEN = new clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN();
this.objvEditRegionFldsEN = pobjvEditRegionFldsEN;
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">关键字</param>
 /// <returns>对象</returns>
clsvEditRegionFldsWApi.GetObjBymId = function(lngmId)  
{
var strAction = "GetObjBymId";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("mId", lngmId);
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjByKeyId_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>对象</returns>
clsvEditRegionFldsWApi.GetObjBymId_Cache = async function(lngmId,strPrjId) {
var arrvEditRegionFldsObjLst_Cache = await clsvEditRegionFldsWApi.GetObjLst_Cache(strPrjId);
var obj = new clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN();
try
{
var arrvEditRegionFlds_Sel = arrvEditRegionFldsObjLst_Cache.filter(x => x.mId == lngmId);
var objvEditRegionFlds;
if (arrvEditRegionFlds_Sel.length > 0)
{
objvEditRegionFlds = arrvEditRegionFlds_Sel[0];
return objvEditRegionFlds;
}
else
{
return obj;
}
}
catch (e)
{
var strMsg = "根据关键字:[" + lngmId  + "]获取相应的对象不成功!";
alert(strMsg);
}
return obj;
};

 /// <summary>
 /// 根据关键字获取相应的对象
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "lngmId">关键字</param>
 /// <returns>对象</returns>
clsvEditRegionFldsWApi.GetObjBymId_WA_Cache = function(lngmId, strPrjId)  
{
var strAction = "GetObjBymId_Cache";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("mId", lngmId);
mapParam.add("PrjId", strPrjId);
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetFirstId)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>返回的第一条记录的关键字值</returns>
clsvEditRegionFldsWApi.GetFirstID = function(strWhereCond)  
{
var strAction = "GetFirstID";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取的相应对象</returns>
clsvEditRegionFldsWApi.GetFirstObj = function(strWhereCond)  
{
var strAction = "GetFirstObj";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_Cache)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
clsvEditRegionFldsWApi.GetObjLst_Cache = async function(strPrjId)
{
var arrvEditRegionFldsObjLst_Cache;
switch (clsvEditRegionFldsWApi.CacheModeId)
{
case "04"://sessionStorage
arrvEditRegionFldsObjLst_Cache = await clsvEditRegionFldsWApi.GetObjLst_sessionStorage(strPrjId);
break;
case "03"://localStorage
arrvEditRegionFldsObjLst_Cache = await clsvEditRegionFldsWApi.GetObjLst_localStorage(strPrjId);
break;
case "02"://ClientCache
arrvEditRegionFldsObjLst_Cache = await clsvEditRegionFldsWApi.GetObjLst_ClientCache(strPrjId);
break;
default:
arrvEditRegionFldsObjLst_Cache = await clsvEditRegionFldsWApi.GetObjLst_ClientCache(strPrjId);
break;
}
return arrvEditRegionFldsObjLst_Cache;
}

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_ClientCache)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
clsvEditRegionFldsWApi.GetObjLst_ClientCache = async function(strPrjId)
{
//初始化列表缓存
var strWhereCond = "1=1";
clsvEditRegionFldsWApi.InitListCache(); 
strWhereCond = "PrjId='" +  strPrjId + "'";
var strKey =   clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN._CurrTabName+ "_" +  strPrjId;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper_js_1.CacheHelper.Exsits(strKey))
{
//缓存存在，直接取出返回
var arrvEditRegionFldsObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
return arrvEditRegionFldsObjLst_Cache;
}
try
{
const responseText = await clsvEditRegionFldsWApi.GetObjLst(strWhereCond);
var arrvEditRegionFldsObjLst = responseText;
CacheHelper_js_1.CacheHelper.Add(strKey, arrvEditRegionFldsObjLst);
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrvEditRegionFldsObjLst.length+ " !";
console.log(strInfo);
return arrvEditRegionFldsObjLst;
}
catch (e)
{
console.log("GetObjLst_Cache:e");
console.log(e);
var strMsg = "从缓存中获取所有对象列表出错," +e + ".";
throw (strMsg);
}
}

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_localStorage)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
clsvEditRegionFldsWApi.GetObjLst_localStorage = async function(strPrjId)
{
//初始化列表缓存
var strWhereCond = "1=1";
clsvEditRegionFldsWApi.InitListCache(); 
strWhereCond = "PrjId='" +  strPrjId + "'";
var strKey =   clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN._CurrTabName+ "_" +  strPrjId;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (localStorage.hasOwnProperty(strKey))
{
//缓存存在，直接取出返回
var strTempObjLst = localStorage.getItem(strKey);
var arrvEditRegionFldsObjLst_Cache = JSON.parse(strTempObjLst);
return arrvEditRegionFldsObjLst_Cache;
}
try
{
const responseText = await clsvEditRegionFldsWApi.GetObjLst(strWhereCond);
var arrvEditRegionFldsObjLst = responseText;
localStorage.setItem(strKey, JSON.stringify(arrvEditRegionFldsObjLst));
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrvEditRegionFldsObjLst.length+ " !";
console.log(strInfo);
return arrvEditRegionFldsObjLst;
}
catch (e)
{
console.log("GetObjLst_Cache:e");
console.log(e);
var strMsg = "从缓存中获取所有对象列表出错," +e + ".";
throw (strMsg);
}
}

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_sessionStorage)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
clsvEditRegionFldsWApi.GetObjLst_sessionStorage = async function(strPrjId)
{
//初始化列表缓存
var strWhereCond = "1=1";
clsvEditRegionFldsWApi.InitListCache(); 
strWhereCond = "PrjId='" +  strPrjId + "'";
var strKey =   clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN._CurrTabName+ "_" +  strPrjId;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (sessionStorage.hasOwnProperty(strKey))
{
//缓存存在，直接取出返回
var strTempObjLst = sessionStorage.getItem(strKey);
var arrvEditRegionFldsObjLst_Cache = JSON.parse(strTempObjLst);
return arrvEditRegionFldsObjLst_Cache;
}
try
{
const responseText = await clsvEditRegionFldsWApi.GetObjLst(strWhereCond);
var arrvEditRegionFldsObjLst = responseText;
sessionStorage.setItem(strKey, JSON.stringify(arrvEditRegionFldsObjLst));
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrvEditRegionFldsObjLst.length+ " !";
console.log(strInfo);
return arrvEditRegionFldsObjLst;
}
catch (e)
{
console.log("GetObjLst_Cache:e");
console.log(e);
var strMsg = "从缓存中获取所有对象列表出错," +e + ".";
throw (strMsg);
}
}

 /// <summary>
 /// 获取服务器缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取的相应对象列表</returns>
clsvEditRegionFldsWApi.GetObjLst_WA_Cache = function()  
{
var strAction = "GetObjLst_Cache";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objlngmId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
clsvEditRegionFldsWApi.GetSubObjLst_Cache =  async function(objvEditRegionFlds_Cond,strPrjId) {
var objvEditRegionFlds_Sim = clsvEditRegionFldsBL_js_1.clsvEditRegionFldsBL.GetSimObjFromObj(objvEditRegionFlds_Cond);
var arrvEditRegionFldsObjLst_Cache = await clsvEditRegionFldsWApi.GetObjLst_Cache(strPrjId);
var arrvEditRegionFlds_Sel = arrvEditRegionFldsObjLst_Cache.filter(x => true);
if (objvEditRegionFlds_Sim.sf_FldComparisonOp == null || objvEditRegionFlds_Sim.sf_FldComparisonOp == "") return arrvEditRegionFlds_Sel;
var dicFldComparisonOp = JSON.parse(objvEditRegionFlds_Sim.sf_FldComparisonOp);
console.log("clsvEditRegionFldsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvEditRegionFlds_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objvEditRegionFlds_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrvEditRegionFlds_Sel;
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objvEditRegionFlds_Sim) + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return null;
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetSubObjLst_WA_Cache)
 /// </summary>
 /// <param name = "objvEditRegionFlds_Cond">条件对象</param>
 /// <returns>获取的相应记录对象列表</returns>
clsvEditRegionFldsWApi.GetSubObjLst_WA_Cache = function(objvEditRegionFlds_Cond)  
{
var strAction = "GetSubObjLst_Cache";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var objvEditRegionFldsEN_Sim = clsvEditRegionFldsBL_js_1.clsvEditRegionFldsBL.GetSimObjFromObj(objvEditRegionFlds_Cond);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objvEditRegionFldsEN_Sim,
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrmId">关键字列表</param>
 /// <returns>对象列表</returns>
clsvEditRegionFldsWApi.GetObjLstBymIdLst = function(arrmId)  
{
var strAction = "GetObjLstBymIdLst";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrmId },
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrlngmIdLst">关键字列表</param>
 /// <returns>对象列表</returns>
clsvEditRegionFldsWApi.GetObjLstBymIdLst_Cache =  async function(arrmIdLst,strPrjId) {
try
{
var arrvEditRegionFldsObjLst_Cache = await clsvEditRegionFldsWApi.GetObjLst_Cache(strPrjId);
var arrvEditRegionFlds_Sel = arrvEditRegionFldsObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrvEditRegionFlds_Sel;
}
catch (e)
{
var strMsg = "根据关键字:[" + arrmIdLst.join(",")  + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return null;
};

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 从WebApi缓存中获取
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "arrmId">关键字列表</param>
 /// <returns>对象列表</returns>
clsvEditRegionFldsWApi.GetObjLstBymIdLst_WA_Cache = function(arrmId, strPrjId)  
{
var strAction = "GetObjLstBymIdLst_Cache";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("PrjId", strPrjId);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrmId },
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取的相应对象列表</returns>
clsvEditRegionFldsWApi.GetObjLst = function(strWhereCond)  
{
var strAction = "GetObjLst";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>获取的相应对象列表</returns>
clsvEditRegionFldsWApi.GetTopObjLst = function(objTopPara)  
{
var strAction = "GetTopObjLst";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam =  stuTopPara_js_1.stuTopPara.GetMapParam(objTopPara);
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取对象列表的参数对象</param>
 /// <returns>获取的相应记录对象列表</returns>
clsvEditRegionFldsWApi.GetObjLstByRange = function(objRangePara)  
{
var strAction = "GetObjLstByRange";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = stuRangePara_js_1.stuRangePara.GetMapParam(objRangePara);
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页参数结构</param>
 /// <returns>对象列表</returns>
clsvEditRegionFldsWApi.GetObjLstByPager_Cache =  async function(objPagerPara,strPrjId) {
var arrvEditRegionFldsObjLst_Cache = await clsvEditRegionFldsWApi.GetObjLst_Cache(strPrjId);
var arrvEditRegionFlds_Sel = arrvEditRegionFldsObjLst_Cache.filter(x => true);
var obj_Cond = JSON.parse(objPagerPara.WhereCond);
var dicFldComparisonOp = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
console.log("clsvEditRegionFldsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(obj_Cond);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = obj_Cond[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
var intStart = objPagerPara.PageSize* (objPagerPara.PageIndex - 1);
if (intStart <= 0) intStart = 0;
var intEnd = intStart + objPagerPara.PageSize;
if (objPagerPara.OrderBy.length>0) {
var sstrSplit = objPagerPara.OrderBy.split(" ");
var strSortType = "asc";
var strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
if (strSortType.toLowerCase() == "asc") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
}
else {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
}
}
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.slice(intStart, intEnd);     
return arrvEditRegionFlds_Sel;
}
catch (e) {
var strMsg = "根据条件:[" +objPagerPara.WhereCond + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return null;
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByPager_WA_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
 /// <returns>获取的相应记录对象列表</returns>
clsvEditRegionFldsWApi.GetObjLstByPager_WA_Cache = function(objPagerPara)  
{
var strAction = "GetObjLstByPager_Cache";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = stuPagerPara_js_1.stuPagerPara.GetMapParam(objPagerPara);
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
 /// <returns>获取的相应记录对象列表</returns>
clsvEditRegionFldsWApi.GetObjLstByPager = function(objPagerPara)  
{
var strAction = "GetObjLstByPager";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = stuPagerPara_js_1.stuPagerPara.GetMapParam(objPagerPara);
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// 根据条件获取是否存在相应的记录？
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>是否存在记录？</returns>
clsvEditRegionFldsWApi.IsExistRecord = function(strWhereCond)  
{
var strAction = "IsExistRecord";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_IsExistRecord_Cache)
 /// </summary>
 /// <param name = "objlngmId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
clsvEditRegionFldsWApi.IsExistRecord_Cache =  async function(objvEditRegionFlds_Cond,strPrjId) {
var objvEditRegionFlds_Sim = clsvEditRegionFldsBL_js_1.clsvEditRegionFldsBL.GetSimObjFromObj(objvEditRegionFlds_Cond);
var arrvEditRegionFldsObjLst_Cache = await clsvEditRegionFldsWApi.GetObjLst_Cache(strPrjId);
var arrvEditRegionFlds_Sel = arrvEditRegionFldsObjLst_Cache.filter(x => true);
if (objvEditRegionFlds_Sim.sf_FldComparisonOp == null || objvEditRegionFlds_Sim.sf_FldComparisonOp == "") return arrvEditRegionFlds_Sel.length>0?true:false;
var dicFldComparisonOp = JSON.parse(objvEditRegionFlds_Sim.sf_FldComparisonOp);
console.log("clsvEditRegionFldsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvEditRegionFlds_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objvEditRegionFlds_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
if (arrvEditRegionFlds_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objvEditRegionFlds_Sim) + "]判断是否存在不成功!";
throw new Error(strMsg);
}
return false;
};

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_IsExist)
 /// </summary>
 /// <param name = "lngmId">关键字</param>
 /// <returns>是否存在?存在返回True</returns>
clsvEditRegionFldsWApi.IsExist = function(lngmId) 
{
//检测记录是否存在
var strAction = "IsExist";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("mId", lngmId);
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// 根据关键字判断是否存在记录, 从本地缓存中判断.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_IsExist_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>对象</returns>
clsvEditRegionFldsWApi.IsExist_Cache = async function(lngmId,strPrjId) {
var arrvEditRegionFldsObjLst_Cache = await clsvEditRegionFldsWApi.GetObjLst_Cache(strPrjId);
var obj = new clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN();
try
{
var arrvEditRegionFlds_Sel = arrvEditRegionFldsObjLst_Cache.filter(x => x.mId == lngmId);
var objvEditRegionFlds;
if (arrvEditRegionFlds_Sel.length > 0)
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
var strMsg = "根据关键字:[" + lngmId  + "]判断是否存在不成功!";
alert(strMsg);
}
return false;
};

 /// <summary>
 /// 获取某一条件的记录数
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取某一条件的记录数</returns>
clsvEditRegionFldsWApi.GetRecCountByCond = function(strWhereCond)  
{
var strAction = "GetRecCountByCond";
let strUrl = this.GetWebApiUrl(clsvEditRegionFldsWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
console.log('GetRecCountByCond:strData:');
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
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetRecCountByCond_Cache)
 /// </summary>
 /// <param name = "objvEditRegionFlds_Cond">条件对象</param>
 /// <returns>对象列表记录数</returns>
clsvEditRegionFldsWApi.GetRecCountByCond_Cache =  async function(objvEditRegionFlds_Cond,strPrjId) {
var objvEditRegionFlds_Sim = clsvEditRegionFldsBL_js_1.clsvEditRegionFldsBL.GetSimObjFromObj(objvEditRegionFlds_Cond);
var arrvEditRegionFldsObjLst_Cache = await clsvEditRegionFldsWApi.GetObjLst_Cache(strPrjId);
var arrvEditRegionFlds_Sel = arrvEditRegionFldsObjLst_Cache.filter(x => true);
if (objvEditRegionFlds_Sim.sf_FldComparisonOp == null || objvEditRegionFlds_Sim.sf_FldComparisonOp == "") return arrvEditRegionFlds_Sel.length;
var dicFldComparisonOp = JSON.parse(objvEditRegionFlds_Sim.sf_FldComparisonOp);
console.log("clsvEditRegionFldsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvEditRegionFlds_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objvEditRegionFlds_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrvEditRegionFlds_Sel = arrvEditRegionFlds_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrvEditRegionFlds_Sel.length;
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objvEditRegionFlds_Sim) + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return 0;
};

 /// <summary>
 /// 获取WebApi的地址
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetWebApiUrl)
 /// </summary>
 /// <returns>返回当前文件中Web服务的地址</returns>
clsvEditRegionFldsWApi.GetWebApiUrl = function(strController, strAction) {
var strServiceUrl;
if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
strServiceUrl = "http://" + clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort+ "/" + clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx+ "/" + strController+ "/" + strAction;
}
else {
strServiceUrl = "http://" +  clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local+ "/" +  clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx+ "/" + strController+ "/" + strAction;
}
return strServiceUrl;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_InitListCache)
 /// </summary>
clsvEditRegionFldsWApi.InitListCache = function() 
{
//初始化列表缓存
if (clsEditRegionFldsWApi_js_1.clsEditRegionFldsWApi.objCommFun4BL == null)
{
strMsg = "类clsEditRegionFldsWApi没有刷新缓存机制(clsEditRegionFldsWApi.objCommFun4BL == null), 请联系程序员！(from {clsStackTrace.GetCurrClassFunction()})";
throw (strMsg);
}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_ReFreshThisCache)
 /// </summary>
clsvEditRegionFldsWApi. ReFreshThisCache = function(strPrjId)
{
var strMsg = "";
if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
var strKey = clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN._CurrTabName + "_" + strPrjId ;
switch (clsvEditRegionFldsWApi.CacheModeId)
{
case "04"://sessionStorage
sessionStorage.removeItem(strKey);
break;
case "03"://localStorage
localStorage.removeItem(strKey);
break;
case "02"://ClientCache
CacheHelper_js_1.CacheHelper.Remove(strKey);
break;
default:
CacheHelper_js_1.CacheHelper.Remove(strKey);
break;
}
strMsg = "刷新缓存成功！(" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction();
console.log(strMsg);
}
else
{
strMsg = "刷新缓存已经关闭。(clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == false)(" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()+ ")";
console.log(strMsg);
}
}
clsvEditRegionFldsWApi.mstrController = "vEditRegionFldsApi";
clsvEditRegionFldsWApi.CacheModeId = ""; //
return clsvEditRegionFldsWApi;
}());
exports.clsvEditRegionFldsWApi = clsvEditRegionFldsWApi;
});