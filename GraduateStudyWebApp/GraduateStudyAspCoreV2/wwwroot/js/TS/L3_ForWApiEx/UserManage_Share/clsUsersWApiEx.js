"use strict";
///*-- -- -- -- -- -- -- -- -- -- --
//类名:clsUsersWApiEx
//表名:Users(01120034)
//生成代码版本:2020.06.05.2
//生成日期:2020/06/05 19:26:05
//生成者:
//生成服务器IP:192.168.1.10
//工程名称:问卷调查
//工程ID:0112
//相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
//PrjDataBaseId:0122
//模块中文名:用户管理
//模块英文名:UserManage
//框架-层名:WA_访问层(WA_Access)
//编程语言:TypeScript
//注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
//       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
//== == == == == == == == == == == == 
//*/
///// <summary>
///// 用户(Users)
///// (AutoGCLib.WA_Access4TypeScript:GeneCode)
///// </summary>
///**
//* Created by  on 2020年06月05日.
//* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
//*/
/////// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////// <reference path="../../../scripts/typings/q/q.d.ts" />
/////// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
////import * as QQ from "q";
//import { clsUsersEN } from "../../L0_Entity/UserManage_Share/clsUsersEN.js";
//import { vUsers_ReFreshThisCache } from "../../L3_ForWApi/UserManage_Share/clsvUsersWApi.js";
//import { CacheHelper } from "../../PubFun/CacheHelper.js";
//import { clsStackTrace } from "../../PubFun/clsStackTrace.js";
//import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
//import { tzDataType } from "../../PubFun/clsString.js";
//import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
//import { stuRangePara } from "../../PubFun/stuRangePara.js";
//import { stuTopPara } from "../../PubFun/stuTopPara.js";
//import { Dictionary } from "../../PubFun/tzDictionary.js";
//import { GetStrLen, myShowErrorMsg } from "../../PubFun/tzPubFun.js";
//import { tzResponseData } from "../../PubFun/tzResponseData.js";
//var ResponseData: tzResponseData;
//export class clsUsersWApiEx {
//    public static mstrController: string = "UsersApi";
//    public static cacheModeId = "02"; //sessionStorage
//    public objUsersEN: clsUsersEN = new clsUsersEN();
//    constructor(pobjUsersEN: clsUsersEN) {
//        this.objUsersEN = pobjUsersEN;
//    };
//    /// <summary>
//    /// 根据关键字获取相应的记录的对象
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
//    /// </summary>
//    /// <param name = "strUserId">关键字</param>
//    /// <returns>对象</returns>
//    public static GetObjByUserIdAsync(strUserId: string): Promise<clsUsersEN> {
//        var strAction = "GetObjByUserId";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        mapParam.add("userId", strUserId);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "json",
//                data: strData,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObj = JSON.parse(data.ReturnObj);
//                        //console.log(returnObj);
//                        resolve(returnObj);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据关键字获取相关对象, 从缓存中获取.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
//    /// </summary>
//    /// <param name = "strUserId">所给的关键字</param>
//    /// <returns>对象</returns>
//    public static async GetObjByUserId_Cache(strUserId: string) {
//        var arrUsersObjLst_Cache: Array<clsUsersEN> = await clsUsersWApiEx.GetObjLstAsync("1=1");
//        var obj: clsUsersEN = new clsUsersEN();
//        try {
//            var arrUsers_Sel: Array<clsUsersEN> = arrUsersObjLst_Cache.filter(x => x.userId == strUserId);
//            var objUsers: clsUsersEN;
//            if (arrUsers_Sel.length > 0) {
//                objUsers = arrUsers_Sel[0];
//                return objUsers;
//            }
//            else {
//                return obj;
//            }
//        }
//        catch (e) {
//            var strMsg: string = `错误:[${e}]. \n根据关键字:[${strUserId}]获取相应的对象不成功!`;
//            alert(strMsg);
//        }
//        return obj;
//    };
//    /// <summary>
//    /// 根据关键字获取相关对象, 从缓存中获取.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SetCache)
//    /// </summary>
//    /// <param name = "strUserId">所给的关键字</param>
//    /// <returns>对象</returns>
//    public static SetCache() {
//    };
//    /// <summary>
//    /// 根据关键字获取相应的对象
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_WA_CacheAsync)
//    /// </summary>
//    /// <param name = "strUserId">关键字</param>
//    /// <returns>对象</returns>
//    public static GetObjByUserId_WA_CacheAsync(strUserId: string): Promise<clsUsersEN> {
//        var strAction = "GetObjByUserId_Cache";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        mapParam.add("userId", strUserId);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "json",
//                data: strData,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObj = JSON.parse(data.ReturnObj);
//                        //console.log(returnObj);
//                        resolve(returnObj);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据条件获取相应的记录对象列表
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
//    /// </summary>
//    /// <param name = "strWhereCond">条件</param>
//    /// <returns>返回的第一条记录的关键字值</returns>
//    public static GetFirstIDAsync(strWhereCond: string): Promise<string> {
//        var strAction = "GetFirstID";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        mapParam.add("strWhereCond", strWhereCond);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "json",
//                data: strData,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnStr);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    }
//    /// <summary>
//    /// 根据条件获取相应的记录对象列表
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
//    /// </summary>
//    /// <param name = "strWhereCond">条件</param>
//    /// <returns>获取的相应对象</returns>
//    public static GetFirstObjAsync(strWhereCond: string): Promise<clsUsersEN> {
//        var strAction = "GetFirstObj";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        mapParam.add("strWhereCond", strWhereCond);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "json",
//                data: strData,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObj = JSON.parse(data.ReturnObj);
//                        //console.log(returnObj);
//                        resolve(returnObj);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
//    /// </summary>
//    /// <returns>从本地缓存中获取的对象列表</returns>
//    public static async GetObjLst_ClientCache() {
//        //初始化列表缓存
//        var strWhereCond: string = "1=1";
//        clsUsersWApiEx.InitListCache();
//        var strKey: string = clsUsersEN._CurrTabName;
//        if (strKey == "") {
//            console.log("关键字为空！不正确");
//            throw new Error("关键字为空！不正确");
//        }
//        if (CacheHelper.Exsits(strKey)) {
//            //缓存存在，直接返回
//            var arrUsersObjLst_Cache: Array<clsUsersEN> = CacheHelper.Get(strKey);
//            return arrUsersObjLst_Cache;
//        }
//        try {
//            const responseText = await clsUsersWApiEx.GetObjLstAsync(strWhereCond);
//            var arrUsersObjLst: Array<clsUsersEN> = <Array<clsUsersEN>>responseText;
//            CacheHelper.Add(strKey, arrUsersObjLst);
//            var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrUsersObjLst.length}!`;
//            console.log(strInfo);
//            return arrUsersObjLst;
//        }
//        catch (e) {
//            console.log("GetObjLst_Cache:e");
//            console.error(e);
//            var strMsg: string = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
//            throw (strMsg);
//        }
//    }
//    /// <summary>
//    /// 根据条件获取相应的记录对象列表
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
//    /// </summary>
//    /// <param name = "strWhereCond">条件</param>
//    /// <returns>获取的相应对象列表</returns>
//    public static GetObjLstAsync(strWhereCond: string): Promise<Array<clsUsersEN>> {
//        var strAction = "GetObjLst";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        mapParam.add("strWhereCond", strWhereCond);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "json",
//                data: strData,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObjLst = JSON.parse(data.ReturnObjLst);
//                        //console.log(returnObjLst);
//                        resolve(returnObjLst);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
//    /// </summary>
//    /// <returns>从本地缓存中获取的对象列表</returns>
//    public static async GetObjLst_localStorage() {
//        //初始化列表缓存
//        var strWhereCond: string = "1=1";
//        clsUsersWApiEx.InitListCache();
//        var strKey: string = clsUsersEN._CurrTabName;
//        if (strKey == "") {
//            console.log("关键字为空！不正确");
//            throw new Error("关键字为空！不正确");
//        }
//        if (localStorage.hasOwnProperty(strKey)) {
//            //缓存存在，直接返回
//            var strTempObjLst: string = localStorage.getItem(strKey) as string;
//            var arrUsersObjLst_Cache: Array<clsUsersEN> = JSON.parse(strTempObjLst);
//            return arrUsersObjLst_Cache;
//        }
//        try {
//            const responseText = await clsUsersWApiEx.GetObjLstAsync(strWhereCond);
//            var arrUsersObjLst: Array<clsUsersEN> = <Array<clsUsersEN>>responseText;
//            localStorage.setItem(strKey, JSON.stringify(arrUsersObjLst));
//            var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrUsersObjLst.length}!`;
//            console.log(strInfo);
//            return arrUsersObjLst;
//        }
//        catch (e) {
//            console.log("GetObjLst_Cache:e");
//            console.error(e);
//            var strMsg: string = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
//            throw (strMsg);
//        }
//    }
//    /// <summary>
//    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
//    /// </summary>
//    /// <returns>从本地缓存中获取的对象列表</returns>
//    public static async GetObjLst_CacheBak() {
//        var arrUsersObjLst_Cache: Array<clsUsersEN>;
//        switch (clsUsersWApiEx.cacheModeId) {
//            case "04"://sessionStorage
//                arrUsersObjLst_Cache = await clsUsersWApiEx.GetObjLst_sessionStorage();
//                break;
//            case "03"://localStorage
//                arrUsersObjLst_Cache = await clsUsersWApiEx.GetObjLst_localStorage();
//                break;
//            case "02"://ClientCache
//                arrUsersObjLst_Cache = await clsUsersWApiEx.GetObjLst_ClientCache();
//                break;
//            default:
//                arrUsersObjLst_Cache = await clsUsersWApiEx.GetObjLst_ClientCache();
//                break;
//        }
//        return arrUsersObjLst_Cache;
//    }
//    /// <summary>
//    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
//    /// </summary>
//    /// <returns>从本地缓存中获取的对象列表</returns>
//    public static async GetObjLst_sessionStorage() {
//        //初始化列表缓存
//        var strWhereCond: string = "1=1 and IsGSuser=1";
//        clsUsersWApiEx.InitListCache();
//        var strKey: string = clsUsersEN._CurrTabName;
//        if (strKey == "") {
//            console.log("关键字为空！不正确");
//            throw new Error("关键字为空！不正确");
//        }
//        if (sessionStorage.hasOwnProperty(strKey)) {
//            //缓存存在，直接返回
//            var strTempObjLst: string = sessionStorage.getItem(strKey) as string;
//            var arrUsersObjLst_Cache: Array<clsUsersEN> = JSON.parse(strTempObjLst);
//            return arrUsersObjLst_Cache;
//        }
//        try {
//            const responseText = await clsUsersWApiEx.GetObjLstAsync(strWhereCond);
//            var arrUsersObjLst: Array<clsUsersEN> = <Array<clsUsersEN>>responseText;
//            sessionStorage.setItem(strKey, JSON.stringify(arrUsersObjLst));
//            var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrUsersObjLst.length}!`;
//            console.log(strInfo);
//            return arrUsersObjLst;
//        }
//        catch (e) {
//            console.log("GetObjLst_Cache:e");
//            console.error(e);
//            var strMsg: string = `从缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
//            throw (strMsg);
//        }
//    }
//    /// <summary>
//    /// 获取服务器缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_WA_CacheAsync)
//    /// </summary>
//    /// <param name = "strWhereCond">条件</param>
//    /// <returns>获取的相应对象列表</returns>
//    public static GetObjLst_WA_CacheAsync(): Promise<Array<clsUsersEN>> {
//        var strAction = "GetObjLst_Cache";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "json",
//                data: strData,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObjLst = JSON.parse(data.ReturnObjLst);
//                        //console.log(returnObjLst);
//                        resolve(returnObjLst);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据条件对象, 从缓存的对象列表中获取子集.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
//    /// </summary>
//    /// <param name = "objstrUserId_Cond">条件对象</param>
//    /// <returns>对象列表子集</returns>
//    public static async GetSubObjLst_Cache(objUsers_Cond: clsUsersEN) {
//        var arrUsersObjLst_Cache: Array<clsUsersEN> = await clsUsersWApiEx.GetObjLstAsync("1=1");
//        var arrUsers_Sel: Array<clsUsersEN> = arrUsersObjLst_Cache.filter(x => true);
//        if (objUsers_Cond.sf_FldComparisonOp == null || objUsers_Cond.sf_FldComparisonOp == "") return arrUsers_Sel;
//        var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objUsers_Sim.sf_FldComparisonOp);
//        console.log("clsUsersWApiEx->GetSubObjLst_Cache->dicFldComparisonOp:");
//        console.log(dicFldComparisonOp);
//        try {
//            var sstrKeys = GetObjKeys(objUsers_Cond);
//            console.log(sstrKeys);
//            for (let strKey of sstrKeys) {
//                if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
//                var strComparisonOp = dicFldComparisonOp[strKey];
//                var strValue = objUsers_Sim[strKey];
//                var strType = typeof (strValue);
//                switch (strType) {
//                    case "string":
//                        if (strValue == null) continue;
//                        if (strValue == "") continue;
//                        if (strComparisonOp == "=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString() == strValue.toString());
//                        }
//                        else if (strComparisonOp == "like") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
//                        }
//                        break;
//                    case "number":
//                        if (strValue == 0) continue;
//                        if (strComparisonOp == "=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] == strValue);
//                        }
//                        else if (strComparisonOp == ">=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] >= strValue);
//                        }
//                        else if (strComparisonOp == "<=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
//                        }
//                        else if (strComparisonOp == ">") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] > strValue);
//                        }
//                        else if (strComparisonOp == "<") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
//                        }
//                        break;
//                }
//            }
//            return arrUsers_Sel;
//        }
//        catch (e) {
//            var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify(objUsers_Sim)}]缓存对象列表中获取子集对象不成功!`;
//            throw new Error(strMsg);
//        }
//        return new Array<clsUsersEN>();
//    };
//    /// <summary>
//    /// 根据条件获取相应的记录对象列表
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_WA_CacheAsync)
//    /// </summary>
//    /// <param name = "objUsers_Cond">条件对象</param>
//    /// <returns>获取的相应记录对象列表</returns>
//    public static GetSubObjLst_WA_CacheAsync(objUsers_Cond: clsUsersEN): Promise<Array<clsUsersEN>> {
//        var strAction = "GetSubObjLst_Cache";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: objUsers_Cond,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObjLst = JSON.parse(data.ReturnObjLst);
//                        //console.log(returnObjLst);
//                        resolve(returnObjLst);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据关键字列表获取相关对象列表
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
//    /// </summary>
//    /// <param name = "arrUserId">关键字列表</param>
//    /// <returns>对象列表</returns>
//    public static GetObjLstByUserIdLstAsync(arrUserId: Array<string>): Promise<Array<clsUsersEN>> {
//        var strAction = "GetObjLstByUserIdLst";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: { "": arrUserId },
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObjLst = JSON.parse(data.ReturnObjLst);
//                        //console.log(returnObjLst);
//                        resolve(returnObjLst);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据关键字列表获取相关对象列表, 从缓存中获取.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
//    /// </summary>
//    /// <param name = "arrstrUserIdLst">关键字列表</param>
//    /// <returns>对象列表</returns>
//    public static async GetObjLstByUserIdLst_Cache(arrUserIdLst: Array<string>) {
//        try {
//            var arrUsersObjLst_Cache: Array<clsUsersEN> = await clsUsersWApiEx.GetObjLstAsync("1=1");
//            var arrUsers_Sel: Array<clsUsersEN> = arrUsersObjLst_Cache.filter(x => arrUserIdLst.indexOf(x.userId) > -1);
//            return arrUsers_Sel;
//        }
//        catch (e) {
//            var strMsg: string = `错误:[${e}]. \n根据关键字:[${arrUserIdLst.join(",")}]获取对象列表不成功!`;
//            throw new Error(strMsg);
//        }
//        return new Array<clsUsersEN>();
//    };
//    /// <summary>
//    /// 根据关键字列表获取相关对象列表, 从WebApi缓存中获取
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_WA_CacheAsync)
//    /// </summary>
//    /// <param name = "arrUserId">关键字列表</param>
//    /// <returns>对象列表</returns>
//    public static GetObjLstByUserIdLst_WA_CacheAsync(arrUserId: Array<string>): Promise<Array<clsUsersEN>> {
//        var strAction = "GetObjLstByUserIdLst_Cache";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: { "": arrUserId },
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObjLst = JSON.parse(data.ReturnObjLst);
//                        //console.log(returnObjLst);
//                        resolve(returnObjLst);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据条件获取相应的记录对象列表
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
//    /// </summary>
//    /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
//    /// <returns>获取的相应对象列表</returns>
//    public static GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsUsersEN>> {
//        var strAction = "GetTopObjLst";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = stuTopPara.GetMapParam(objTopPara);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: objTopPara,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObjLst = JSON.parse(data.ReturnObjLst);
//                        //console.log(returnObjLst);
//                        resolve(returnObjLst);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据条件获取相应的记录对象列表
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
//    /// </summary>
//    /// <param name = "objRangePara">根据范围获取对象列表的参数对象</param>
//    /// <returns>获取的相应记录对象列表</returns>
//    public static GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsUsersEN>> {
//        var strAction = "GetObjLstByRange";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = stuRangePara.GetMapParam(objRangePara);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: objRangePara,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObjLst = JSON.parse(data.ReturnObjLst);
//                        //console.log(returnObjLst);
//                        resolve(returnObjLst);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    }
//    /// <summary>
//    /// 从缓存中获取分页对象列表.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
//    /// </summary>
//    /// <param name = "objPagerPara">分页参数结构</param>
//    /// <returns>对象列表</returns>
//    public static async GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
//        var arrUsersObjLst_Cache: Array<clsUsersEN> = await clsUsersWApiEx.GetObjLstAsync("1=1");
//        if (arrUsersObjLst_Cache.length == 0) return arrUsersObjLst_Cache;
//        var arrUsers_Sel: Array<clsUsersEN> = arrUsersObjLst_Cache.filter(x => true);
//        var obj_Cond: clsUsersEN_Sim = JSON.parse(objPagerPara.whereCond);
//        var dicFldComparisonOp: { [index: string]: string } = {};
//        if (obj_Cond.sf_FldComparisonOp != "") {
//            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
//        }
//        console.log("clsUsersWApiEx->GetObjLstByPager_Cache->dicFldComparisonOp:");
//        console.log(dicFldComparisonOp);
//        try {
//            var sstrKeys = GetObjKeys(obj_Cond);
//            console.log(sstrKeys);
//            for (let strKey of sstrKeys) {
//                if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
//                var strComparisonOp = dicFldComparisonOp[strKey];
//                var strValue = obj_Cond[strKey];
//                var strType = typeof (strValue);
//                switch (strType) {
//                    case "string":
//                        if (strValue == null) continue;
//                        if (strValue == "") continue;
//                        if (strComparisonOp == "=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString() == strValue.toString());
//                        }
//                        else if (strComparisonOp == "like") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
//                        }
//                        break;
//                    case "number":
//                        if (strValue == 0) continue;
//                        if (strComparisonOp == "=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] == strValue);
//                        }
//                        else if (strComparisonOp == ">=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] >= strValue);
//                        }
//                        else if (strComparisonOp == "<=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
//                        }
//                        else if (strComparisonOp == ">") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] > strValue);
//                        }
//                        else if (strComparisonOp == "<") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
//                        }
//                        break;
//                }
//            }
//            if (arrUsers_Sel.length == 0) return arrUsers_Sel;
//            var intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
//            if (intStart <= 0) intStart = 0;
//            var intEnd = intStart + objPagerPara.pageSize;
//            if (objPagerPara.orderBy.length > 0) {
//                var sstrSplit: string[] = objPagerPara.orderBy.split(" ");
//                var strSortType: string = "asc";
//                var strSortFld = sstrSplit[0];
//                if (sstrSplit.length > 1) strSortType = sstrSplit[1];
//                //                console.log(arrUsers_Sel);
//                let objFirst = arrUsers_Sel[0];//第一个对象
//                let strSortValue = objFirst[strSortFld];  //第一个对象排序字段值            
//                let strSortFldType = typeof (strSortValue);//排序字段值的数据类型
//                //console.log("排序字段的数据类型: " + strSortFldType);
//                switch (strSortFldType) {
//                    case "string":
//                        if (strSortType.toLowerCase() == "asc") {
//                            arrUsers_Sel = arrUsers_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
//                        }
//                        else {
//                            arrUsers_Sel = arrUsers_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
//                        }
//                        break;
//                    case "number":
//                    case "boolean":
//                        if (strSortType.toLowerCase() == "asc") {
//                            arrUsers_Sel = arrUsers_Sel.sort((x, y) => x[strSortFld] - y[strSortFld]);
//                        }
//                        else {
//                            arrUsers_Sel = arrUsers_Sel.sort((x, y) => y[strSortFld] - x[strSortFld]);
//                        }
//                        break;
//                }
//            }
//            arrUsers_Sel = arrUsers_Sel.slice(intStart, intEnd);
//            return arrUsers_Sel;
//        }
//        catch (e) {
//            var strMsg: string = `错误:[${e}]. \n根据条件:[${objPagerPara.whereCond}]获取分页对象列表不成功!(In clsUsersWApiEx.GetObjLstByPager_Cache)`;
//            throw new Error(strMsg);
//        }
//        return new Array<clsUsersEN>();
//    };
//    /// <summary>
//    /// 根据条件获取相应的记录对象列表
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_WA_CacheAsync)
//    /// </summary>
//    /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
//    /// <returns>获取的相应记录对象列表</returns>
//    public static GetObjLstByPager_WA_CacheAsync(objPagerPara: stuPagerPara): Promise<Array<clsUsersEN>> {
//        var strAction = "GetObjLstByPager_Cache";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = stuPagerPara.GetMapParam(objPagerPara);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: objPagerPara,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObjLst = JSON.parse(data.ReturnObjLst);
//                        //console.log(returnObjLst);
//                        resolve(returnObjLst);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据条件获取相应的记录对象列表
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
//    /// </summary>
//    /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
//    /// <returns>获取的相应记录对象列表</returns>
//    public static GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsUsersEN>> {
//        var strAction = "GetObjLstByPager";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = stuPagerPara.GetMapParam(objPagerPara);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: objPagerPara,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObjLst = JSON.parse(data.ReturnObjLst);
//                        //console.log(returnObjLst);
//                        resolve(returnObjLst);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 调用WebApi来删除记录
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
//    /// </summary>
//    /// <param name = "strUserId">关键字</param>
//    /// <returns>获取删除的结果</returns>
//    public static DelRecordAsync(strUserId: string): Promise<number> {
//        var strAction = "DelRecord";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        strUrl = `${strUrl}/${strUserId}`;
//        var mapParam: Dictionary = new Dictionary();
//        mapParam.add("strUserId", strUserId);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "DELETE",
//                dataType: "json",
//                data: { "": strUserId },
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnInt);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据关键字列表删除记录
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
//    /// </summary>
//    /// <param name = "arrUserId">关键字列表</param>
//    /// <returns>实际删除记录的个数</returns>
//    public static DelUserssAsync(arrUserId: Array<string>): Promise<number> {
//        var strAction = "DelUserss";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: { "": arrUserId },
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnInt);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    }
//    /// <summary>
//    /// 根据条件删除记录
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
//    /// </summary>
//    /// <returns>实际删除记录的个数</returns>
//    public static DelUserssByCondAsync(strWhereCond: string): Promise<number> {
//        var strAction = "DelUserssByCond";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: { "": strWhereCond },
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnInt);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    }
//    /// <summary>
//    /// 调用WebApi来添加记录，数据传递使用JSON串
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
//    /// </summary>
//    /// <param name = "objUsersEN">需要添加的对象</param>
//    /// <returns>获取相应的记录的对象</returns>
//    public static AddNewRecordAsync(objUsersEN: clsUsersEN): Promise<boolean> {
//        var strMsg = "";
//        var strAction = "AddNewRecord";
//        if (objUsersEN.userId === null || objUsersEN.userId === "") {
//            strMsg = "需要的对象的关键字为空，不能添加!";
//            throw strMsg;
//        }
//        //var strJSON = JSON.stringify(objUsersEN_Sim);
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: objUsersEN,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnBool);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 调用WebApi来添加记录，数据传递使用JSON串
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
//    /// </summary>
//    /// <param name = "objUsersEN">需要添加的对象</param>
//    /// <returns>获取相应的记录的对象</returns>
//    public static AddNewRecordWithMaxIdAsync(objUsersEN: clsUsersEN): Promise<boolean> {
//        var strMsg = "";
//        var strAction = "AddNewRecordWithMaxId";
//        //var strJSON = JSON.stringify(objUsersEN_Sim);
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: objUsersEN,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnBool);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
//    /// </summary>
//    /// <param name = "objUsersEN">需要添加的表对象</param>
//    /// <returns>返回新添加记录的关键字</returns>
//    public static AddNewRecordWithReturnKeyAsync(objUsersEN: clsUsersEN): Promise<string> {
//        var strAction = "AddNewRecordWithReturnKey";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: objUsersEN,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnStr);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    }
//    /// <summary>
//    /// 调用WebApi来修改记录，数据传递使用JSON串
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
//    /// </summary>
//    /// <param name = "objUsersEN">需要添加的对象</param>
//    /// <returns>获取修改是否成功？</returns>
//    public static UpdateRecordAsync(objUsersEN: clsUsersEN): Promise<boolean> {
//        var strMsg = "";
//        var strAction = "UpdateRecord";
//        if (objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "") {
//            strMsg = `对象(关键字: ${objUsersEN.userId})的【修改字段集】为空，不能修改!`;
//            throw strMsg;
//        }
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: objUsersEN,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnBool);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据条件来修改记录
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
//    /// </summary>
//    /// <param name = "objUsersEN">需要修改的对象</param>
//    /// <param name = "strWhereCond">条件串</param>
//    /// <returns>返回的第一条记录的关键字值</returns>
//    public static UpdateWithConditionAsync(objUsersEN: clsUsersEN, strWhereCond: string): Promise<boolean> {
//        var strAction = "UpdateWithCondition";
//        if (objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "") {
//            var strMsg = `对象(关键字: ${objUsersEN.userId})的【修改字段集】为空，不能修改!`;
//            throw new Error(strMsg);
//        }
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        mapParam.add("strWhereCond", strWhereCond);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "POST",
//                dataType: "json",
//                data: strData,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnBool);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    }
//    /// <summary>
//    /// 根据条件对象, 从缓存的对象列表中获取子集.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
//    /// </summary>
//    /// <param name = "objstrUserId_Cond">条件对象</param>
//    /// <returns>对象列表子集</returns>
//    public static async IsExistRecord_Cache(objUsers_Cond: clsUsersEN) {
//        var arrUsersObjLst_Cache: Array<clsUsersEN> = await clsUsersWApiEx.GetObjLstAsync("1=1");
//        var arrUsers_Sel: Array<clsUsersEN> = arrUsersObjLst_Cache.filter(x => true);
//        if (objUsers_Cond.sf_FldComparisonOp == null || objUsers_Cond.sf_FldComparisonOp == "") return arrUsers_Sel.length > 0 ? true : false;
//        var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objUsers_Cond.sf_FldComparisonOp);
//        console.log("clsUsersWApiEx->GetSubObjLst_Cache->dicFldComparisonOp:");
//        console.log(dicFldComparisonOp);
//        try {
//            var sstrKeys = GetObjKeys(objUsers_Cond);
//            console.log(sstrKeys);
//            for (let strKey of sstrKeys) {
//                if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
//                var strComparisonOp = dicFldComparisonOp[strKey];
//                var strValue = objUsers_Sim[strKey];
//                var strType = typeof (strValue);
//                switch (strType) {
//                    case "string":
//                        if (strValue == null) continue;
//                        if (strValue == "") continue;
//                        if (strComparisonOp == "=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString() == strValue.toString());
//                        }
//                        else if (strComparisonOp == "like") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
//                        }
//                        break;
//                    case "number":
//                        if (strValue == 0) continue;
//                        if (strComparisonOp == "=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] == strValue);
//                        }
//                        else if (strComparisonOp == ">=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] >= strValue);
//                        }
//                        else if (strComparisonOp == "<=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
//                        }
//                        else if (strComparisonOp == ">") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] > strValue);
//                        }
//                        else if (strComparisonOp == "<") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
//                        }
//                        break;
//                }
//            }
//            if (arrUsers_Sel.length > 0) {
//                return true;
//            }
//            else {
//                return false;
//            }
//        }
//        catch (e) {
//            var strMsg: string = `根据条件:[${JSON.stringify(objUsers_Sim)}]判断是否存在不成功!`;
//            throw new Error(strMsg);
//        }
//        return false;
//    };
//    /// <summary>
//    /// 根据条件获取是否存在相应的记录？
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
//    /// </summary>
//    /// <param name = "strWhereCond">条件</param>
//    /// <returns>是否存在记录？</returns>
//    public static IsExistRecordAsync(strWhereCond: string): Promise<boolean> {
//        var strAction = "IsExistRecord";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        mapParam.add("strWhereCond", strWhereCond);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "json",
//                data: strData,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnBool);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据关键字判断是否存在记录, 从本地缓存中判断.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
//    /// </summary>
//    /// <param name = "strUserId">所给的关键字</param>
//    /// <returns>对象</returns>
//    public static async IsExist_Cache(strUserId: string) {
//        var arrUsersObjLst_Cache: Array<clsUsersEN> = await clsUsersWApiEx.GetObjLstAsync("1=1");
//        var obj: clsUsersEN = new clsUsersEN();
//        try {
//            var arrUsers_Sel: Array<clsUsersEN> = arrUsersObjLst_Cache.filter(x => x.userId == strUserId);
//            var objUsers: clsUsersEN;
//            if (arrUsers_Sel.length > 0) {
//                return true;
//            }
//            else {
//                return false;
//            }
//        }
//        catch (e) {
//            var strMsg: string = `根据关键字:[${strUserId}]判断是否存在不成功!`;
//            alert(strMsg);
//        }
//        return false;
//    };
//    /// <summary>
//    /// 根据关键字判断是否存在记录
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
//    /// </summary>
//    /// <param name = "strUserId">关键字</param>
//    /// <returns>是否存在?存在返回True</returns>
//    public static IsExistAsync(strUserId: string): Promise<boolean> {
//        //检测记录是否存在
//        var strAction = "IsExist";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        mapParam.add("userId", strUserId);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "json",
//                data: strData,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnBool);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    }
//    /// <summary>
//    /// 获取某一条件的记录数
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
//    /// </summary>
//    /// <param name = "strWhereCond">条件</param>
//    /// <returns>获取某一条件的记录数</returns>
//    public static GetRecCountByCondAsync(strWhereCond: string): Promise<number> {
//        var strAction = "GetRecCountByCond";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        mapParam.add("strWhereCond", strWhereCond);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        console.log('GetRecCountByCondAsync:strData:');
//        console.log(strData);
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "json",
//                data: strData,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnInt);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据条件对象, 从缓存的对象列表中获取记录数.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
//    /// </summary>
//    /// <param name = "objUsers_Cond">条件对象</param>
//    /// <returns>对象列表记录数</returns>
//    public static async GetRecCountByCond_Cache(objUsers_Cond: clsUsersEN) {
//        var arrUsersObjLst_Cache: Array<clsUsersEN> = await clsUsersWApiEx.GetObjLstAsync("1=1");
//        var arrUsers_Sel: Array<clsUsersEN> = arrUsersObjLst_Cache.filter(x => true);
//        if (objUsers_Cond.sf_FldComparisonOp == null || objUsers_Cond.sf_FldComparisonOp == "") return arrUsers_Sel.length;
//        var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objUsers_Cond.sf_FldComparisonOp);
//        console.log("clsUsersWApiEx->GetSubObjLst_Cache->dicFldComparisonOp:");
//        console.log(dicFldComparisonOp);
//        try {
//            var sstrKeys = GetObjKeys(objUsers_Cond);
//            console.log(sstrKeys);
//            for (let strKey of sstrKeys) {
//                if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
//                var strComparisonOp = dicFldComparisonOp[strKey];
//                var strValue = objUsers_Sim[strKey];
//                var strType = typeof (strValue);
//                switch (strType) {
//                    case "string":
//                        if (strValue == null) continue;
//                        if (strValue == "") continue;
//                        if (strComparisonOp == "=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString() == strValue.toString());
//                        }
//                        else if (strComparisonOp == "like") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
//                        }
//                        break;
//                    case "number":
//                        if (strValue == 0) continue;
//                        if (strComparisonOp == "=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] == strValue);
//                        }
//                        else if (strComparisonOp == ">=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] >= strValue);
//                        }
//                        else if (strComparisonOp == "<=") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
//                        }
//                        else if (strComparisonOp == ">") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] > strValue);
//                        }
//                        else if (strComparisonOp == "<") {
//                            arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
//                        }
//                        break;
//                }
//            }
//            return arrUsers_Sel.length;
//        }
//        catch (e) {
//            var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify(objUsers_Sim)}]从缓存对象列表中获取记录数不成功!`;
//            throw new Error(strMsg);
//        }
//        return 0;
//    };
//    /// <summary>
//    /// 获取表的最大关键字
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
//    /// </summary>
//    /// <returns>获取表的最大关键字</returns>
//    public static GetMaxStrIdAsync(): Promise<string> {
//        var strAction = "GetMaxStrId";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "json",
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnStr);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefixAsync)
//    /// </summary>
//    /// <param name = "mapParam">参数列表</param>
//    /// <returns>获取当前表关键字值的最大值</returns>
//    public static GetMaxStrIdByPrefixAsync(strPrefix: string): Promise<string> {
//        var strAction = "GetMaxStrIdByPrefix";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        mapParam.add("strPrefix", strPrefix);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "json",
//                data: strData,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        resolve(data.ReturnStr);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    };
//    /// <summary>
//    /// 获取WebApi的地址
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
//    /// </summary>
//    /// <returns>返回当前文件中Web服务的地址</returns>
//    public static GetWebApiUrl(strController: string, strAction: string): string {
//        var strServiceUrl: string;
//        if (clsSysPara4WebApi.bolIsLocalHost == false) {
//            strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
//        }
//        else {
//            strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
//        }
//        return strServiceUrl;
//    }
//    /// <summary>
//    /// 为下拉框获取数据,从表:[Users]中获取
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DdlBind_Cache)
//    /// </summary>
//    /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
//    public async BindDdl_UserId_Cache2(strDdlName: string, objUsers_Cond: clsUsersEN) {
//        //var strWhereCond = " 1 =1 ";
//        var objDdl = document.getElementById(strDdlName);
//        if (objDdl == null) {
//            var strMsg = `下拉框：${strDdlName} 不存在！`;
//            alert(strMsg);
//            throw (strMsg);
//        }
//        try {
//            var arrObjLst_Sel: Array<clsUsersEN> = await clsUsersWApiEx.GetSubObjLst_Cache(objUsers_Cond);
//            BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsUsersEN.con_UserId, clsUsersEN.con_UserName, "用户");
//            console.log("完成BindDdl_UserId!");
//        }
//        catch (e) {
//            var strMsg: string = `使用缓存对象列表绑定下拉框出错,${e}.`;
//            alert(strMsg);
//        }
//    }
//    /// <summary>
//    /// 初始化列表缓存.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_InitListCache)
//    /// </summary>
//    public static InitListCache(): void {
//    }
//    /// <summary>
//    /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
//    /// </summary>
//    public static ReFreshCache(): void {
//        var strMsg: string = `刷新缓存成功！(${clsStackTrace.GetCurrClassFunctionByLevel(3)}->${clsStackTrace.GetCurrClassFunctionByLevel(2)}->${clsStackTrace.GetCurrClassFunction()})`;
//        console.log(strMsg);
//        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
//        var strKey: string = clsUsersEN._CurrTabName;
//        switch (clsUsersWApiEx.cacheModeId) {
//            case "04"://sessionStorage
//                sessionStorage.removeItem(strKey);
//                break;
//            case "03"://localStorage
//                localStorage.removeItem(strKey);
//                break;
//            case "02"://ClientCache
//                CacheHelper.Remove(strKey);
//                break;
//            default:
//                CacheHelper.Remove(strKey);
//                break;
//        }
//        vUsers_ReFreshThisCache();
//    }
//    /// <summary>
//    /// 刷新本类中的缓存.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
//    /// </summary>
//    public static ReFreshThisCache(): void {
//        var strMsg: string = "";
//        if (clsSysPara4WebApi.spSetRefreshCacheOn == true) {
//            var strKey: string = clsUsersEN._CurrTabName;
//            switch (clsUsersWApiEx.cacheModeId) {
//                case "04"://sessionStorage
//                    sessionStorage.removeItem(strKey);
//                    break;
//                case "03"://localStorage
//                    localStorage.removeItem(strKey);
//                    break;
//                case "02"://ClientCache
//                    CacheHelper.Remove(strKey);
//                    break;
//                default:
//                    CacheHelper.Remove(strKey);
//                    break;
//            }
//            strMsg = `刷新缓存成功！(${clsStackTrace.GetCurrClassFunctionByLevel(3)}->${clsStackTrace.GetCurrClassFunctionByLevel(2)}->${clsStackTrace.GetCurrClassFunction()})`,
//                console.log(strMsg);
//        }
//        else {
//            strMsg = `刷新缓存已经关闭。(clsSysPara4WebApi.spSetRefreshCacheOn == false)(${clsStackTrace.GetCurrClassFunctionByLevel(3)}->${clsStackTrace.GetCurrClassFunctionByLevel(2)}->${clsStackTrace.GetCurrClassFunction()})`;
//            console.log(strMsg);
//        }
//    }
//    /// <summary>
//    /// 绑定基于Web的下拉框
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
//    /// </summary>
//    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
//    public static async BindDdl_UserId_Cache(strDdlName: string, objUsers_Cond: clsUsersEN) {
//        var objDdl = document.getElementById(strDdlName);
//        if (objDdl == null) {
//            var strMsg = `下拉框：${strDdlName} 不存在！`;
//            alert(strMsg);
//            throw (strMsg);
//        }
//        //为数据源于表的下拉框设置内容
//        console.log("开始：BindDdl_UserId_Cache");
//        var arrObjLst_Sel: Array<clsUsersEN> = await clsUsersWApiEx.GetSubObjLst_Cache(objUsers_Cond);
//        BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsUsersEN.con_UserId, clsUsersEN.con_UserName, "用户");
//    }
//};
//export class clsUsersBL {
//    /// <summary>
//    /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
//    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
//    /// </summary>
//    private arrUsersObjLst_Cache = new Array();
//    /// <summary>
//    /// 从缓存中查找失败的次数
//    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
//    /// </summary>
//    private intFindFailCount = 0;
//    /// <summary>
//    /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
//    /// </summary>
//    public CheckPropertyNew(pobjUsersEN: clsUsersEN) {
//        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
//        if (null === pobjUsersEN.userName
//            || null !== pobjUsersEN.userName && pobjUsersEN.userName.toString() === "") {
//            throw new Error("(errid:Watl000058)字段[用户|用户名]不能为空(NULL)!(Users_CheckPropertyNew)");
//        }
//        if (null === pobjUsersEN.userStateId
//            || null !== pobjUsersEN.userStateId && pobjUsersEN.userStateId.toString() === "") {
//            throw new Error("(errid:Watl000058)字段[用户|用户状态Id]不能为空(NULL)!(Users_CheckPropertyNew)");
//        }
//        if (null === pobjUsersEN.identityID
//            || null !== pobjUsersEN.identityID && pobjUsersEN.identityID.toString() === ""
//            || null !== pobjUsersEN.identityID && pobjUsersEN.identityID.toString() === "0") {
//            throw new Error("(errid:Watl000058)字段[用户|身份编号]不能为空(NULL)!(Users_CheckPropertyNew)");
//        }
//        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
//        if (null !== pobjUsersEN.userId && GetStrLen(pobjUsersEN.userId) > 20) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|用户ID(userId)]的长度不能超过20!值:$(pobjUsersEN.userId)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.userName && GetStrLen(pobjUsersEN.userName) > 30) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|用户名(userName)]的长度不能超过30!值:$(pobjUsersEN.userName)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.departmentId && GetStrLen(pobjUsersEN.departmentId) > 8) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|部门Id(departmentId)]的长度不能超过8!值:$(pobjUsersEN.departmentId)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.userStateId && GetStrLen(pobjUsersEN.userStateId) > 2) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|用户状态Id(userStateId)]的长度不能超过2!值:$(pobjUsersEN.userStateId)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.password && GetStrLen(pobjUsersEN.password) > 20) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|password(password)]的长度不能超过20!值:$(pobjUsersEN.password)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.SchoolID1 && GetStrLen(pobjUsersEN.SchoolID1) > 4) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|学校编号(SchoolID1)]的长度不能超过4!值:$(pobjUsersEN.SchoolID1)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.BeginYearMonth && GetStrLen(pobjUsersEN.BeginYearMonth) > 8) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|开始年月(BeginYearMonth)]的长度不能超过8!值:$(pobjUsersEN.BeginYearMonth)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.EndYearMonth && GetStrLen(pobjUsersEN.EndYearMonth) > 8) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|结束年月(EndYearMonth)]的长度不能超过8!值:$(pobjUsersEN.EndYearMonth)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.id_GradeBase && GetStrLen(pobjUsersEN.id_GradeBase) > 4) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|年级流水号(id_GradeBase)]的长度不能超过4!值:$(pobjUsersEN.id_GradeBase)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.id_XzCollege && GetStrLen(pobjUsersEN.id_XzCollege) > 4) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|学院流水号(id_XzCollege)]的长度不能超过4!值:$(pobjUsersEN.id_XzCollege)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.id_XzMajor && GetStrLen(pobjUsersEN.id_XzMajor) > 8) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|专业流水号(id_XzMajor)]的长度不能超过8!值:$(pobjUsersEN.id_XzMajor)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.stuIdTeacherId && GetStrLen(pobjUsersEN.stuIdTeacherId) > 20) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|学工号(stuIdTeacherId)]的长度不能超过20!值:$(pobjUsersEN.stuIdTeacherId)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.email && GetStrLen(pobjUsersEN.email) > 100) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|电子邮箱(email)]的长度不能超过100!值:$(pobjUsersEN.email)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.PhoneNumber && GetStrLen(pobjUsersEN.PhoneNumber) > 15) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|PhoneNumber(PhoneNumber)]的长度不能超过15!值:$(pobjUsersEN.PhoneNumber)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.AvatarsPicture && GetStrLen(pobjUsersEN.AvatarsPicture) > 100) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|AvatarsPicture(AvatarsPicture)]的长度不能超过100!值:$(pobjUsersEN.AvatarsPicture)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.identityID && GetStrLen(pobjUsersEN.identityID) > 2) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|身份编号(identityID)]的长度不能超过2!值:$(pobjUsersEN.identityID)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.AuditDate && GetStrLen(pobjUsersEN.AuditDate) > 14) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|AuditDate(AuditDate)]的长度不能超过14!值:$(pobjUsersEN.AuditDate)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.AuditUser && GetStrLen(pobjUsersEN.AuditUser) > 18) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|AuditUser(AuditUser)]的长度不能超过18!值:$(pobjUsersEN.AuditUser)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.registerDate && GetStrLen(pobjUsersEN.registerDate) > 14) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|registerDate(registerDate)]的长度不能超过14!值:$(pobjUsersEN.registerDate)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.mobilePhone && GetStrLen(pobjUsersEN.mobilePhone) > 20) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|手机(mobilePhone)]的长度不能超过20!值:$(pobjUsersEN.mobilePhone)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.openId && GetStrLen(pobjUsersEN.openId) > 50) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|微信openId(openId)]的长度不能超过50!值:$(pobjUsersEN.openId)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.updDate && GetStrLen(pobjUsersEN.updDate) > 20) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|修改日期(updDate)]的长度不能超过20!值:$(pobjUsersEN.updDate)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.updUser && GetStrLen(pobjUsersEN.updUser) > 20) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|修改人(updUser)]的长度不能超过20!值:$(pobjUsersEN.updUser)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.memo && GetStrLen(pobjUsersEN.memo) > 1000) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|备注(memo)]的长度不能超过1000!值:$(pobjUsersEN.memo)(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.headPic && GetStrLen(pobjUsersEN.headPic) > 500) {
//            throw new Error("(errid:Watl000059)字段[用户(Users)|头像(headPic)]的长度不能超过500!值:$(pobjUsersEN.headPic)(Users_CheckPropertyNew)");
//        }
//        //检查字段的数据类型是否正确
//        if (null !== pobjUsersEN.userId && undefined !== pobjUsersEN.userId && tzDataType.isString(pobjUsersEN.userId) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|用户ID(userId)]的值:[$(pobjUsersEN.userId)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.userName && undefined !== pobjUsersEN.userName && tzDataType.isString(pobjUsersEN.userName) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|用户名(userName)]的值:[$(pobjUsersEN.userName)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.departmentId && undefined !== pobjUsersEN.departmentId && tzDataType.isString(pobjUsersEN.departmentId) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|部门Id(departmentId)]的值:[$(pobjUsersEN.departmentId)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.userStateId && undefined !== pobjUsersEN.userStateId && tzDataType.isString(pobjUsersEN.userStateId) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|用户状态Id(userStateId)]的值:[$(pobjUsersEN.userStateId)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.password && undefined !== pobjUsersEN.password && tzDataType.isString(pobjUsersEN.password) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|password(password)]的值:[$(pobjUsersEN.password)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.isGpUser && undefined !== pobjUsersEN.isGpUser && tzDataType.isBoolean(pobjUsersEN.isGpUser) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|是否Gp用户(isGpUser)]的值:[$(pobjUsersEN.isGpUser)], 非法，应该为布尔型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.SchoolID1 && undefined !== pobjUsersEN.SchoolID1 && tzDataType.isString(pobjUsersEN.SchoolID1) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|学校编号(SchoolID1)]的值:[$(pobjUsersEN.SchoolID1)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.BeginYearMonth && undefined !== pobjUsersEN.BeginYearMonth && tzDataType.isString(pobjUsersEN.BeginYearMonth) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|开始年月(BeginYearMonth)]的值:[$(pobjUsersEN.BeginYearMonth)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.EndYearMonth && undefined !== pobjUsersEN.EndYearMonth && tzDataType.isString(pobjUsersEN.EndYearMonth) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|结束年月(EndYearMonth)]的值:[$(pobjUsersEN.EndYearMonth)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.id_GradeBase && undefined !== pobjUsersEN.id_GradeBase && tzDataType.isString(pobjUsersEN.id_GradeBase) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|年级流水号(id_GradeBase)]的值:[$(pobjUsersEN.id_GradeBase)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.id_XzCollege && undefined !== pobjUsersEN.id_XzCollege && tzDataType.isString(pobjUsersEN.id_XzCollege) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|学院流水号(id_XzCollege)]的值:[$(pobjUsersEN.id_XzCollege)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.id_XzMajor && undefined !== pobjUsersEN.id_XzMajor && tzDataType.isString(pobjUsersEN.id_XzMajor) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|专业流水号(id_XzMajor)]的值:[$(pobjUsersEN.id_XzMajor)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.isLeaved && undefined !== pobjUsersEN.isLeaved && tzDataType.isBoolean(pobjUsersEN.isLeaved) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|isLeaved(isLeaved)]的值:[$(pobjUsersEN.isLeaved)], 非法，应该为布尔型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.stuIdTeacherId && undefined !== pobjUsersEN.stuIdTeacherId && tzDataType.isString(pobjUsersEN.stuIdTeacherId) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|学工号(stuIdTeacherId)]的值:[$(pobjUsersEN.stuIdTeacherId)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.email && undefined !== pobjUsersEN.email && tzDataType.isString(pobjUsersEN.email) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|电子邮箱(email)]的值:[$(pobjUsersEN.email)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.PhoneNumber && undefined !== pobjUsersEN.PhoneNumber && tzDataType.isString(pobjUsersEN.PhoneNumber) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|PhoneNumber(PhoneNumber)]的值:[$(pobjUsersEN.PhoneNumber)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.AvatarsPicture && undefined !== pobjUsersEN.AvatarsPicture && tzDataType.isString(pobjUsersEN.AvatarsPicture) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|AvatarsPicture(AvatarsPicture)]的值:[$(pobjUsersEN.AvatarsPicture)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.identityID && undefined !== pobjUsersEN.identityID && tzDataType.isString(pobjUsersEN.identityID) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|身份编号(identityID)]的值:[$(pobjUsersEN.identityID)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.AuditDate && undefined !== pobjUsersEN.AuditDate && tzDataType.isString(pobjUsersEN.AuditDate) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|AuditDate(AuditDate)]的值:[$(pobjUsersEN.AuditDate)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.AuditUser && undefined !== pobjUsersEN.AuditUser && tzDataType.isString(pobjUsersEN.AuditUser) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|AuditUser(AuditUser)]的值:[$(pobjUsersEN.AuditUser)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.IsAudit && undefined !== pobjUsersEN.IsAudit && tzDataType.isBoolean(pobjUsersEN.IsAudit) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|是否审核(IsAudit)]的值:[$(pobjUsersEN.IsAudit)], 非法，应该为布尔型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.isRegister && undefined !== pobjUsersEN.isRegister && tzDataType.isBoolean(pobjUsersEN.isRegister) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|isRegister(isRegister)]的值:[$(pobjUsersEN.isRegister)], 非法，应该为布尔型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.registerDate && undefined !== pobjUsersEN.registerDate && tzDataType.isString(pobjUsersEN.registerDate) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|registerDate(registerDate)]的值:[$(pobjUsersEN.registerDate)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.mobilePhone && undefined !== pobjUsersEN.mobilePhone && tzDataType.isString(pobjUsersEN.mobilePhone) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|手机(mobilePhone)]的值:[$(pobjUsersEN.mobilePhone)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.openId && undefined !== pobjUsersEN.openId && tzDataType.isString(pobjUsersEN.openId) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|微信openId(openId)]的值:[$(pobjUsersEN.openId)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.updDate && undefined !== pobjUsersEN.updDate && tzDataType.isString(pobjUsersEN.updDate) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|修改日期(updDate)]的值:[$(pobjUsersEN.updDate)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.updUser && undefined !== pobjUsersEN.updUser && tzDataType.isString(pobjUsersEN.updUser) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|修改人(updUser)]的值:[$(pobjUsersEN.updUser)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.memo && undefined !== pobjUsersEN.memo && tzDataType.isString(pobjUsersEN.memo) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|备注(memo)]的值:[$(pobjUsersEN.memo)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.headPic && undefined !== pobjUsersEN.headPic && tzDataType.isString(pobjUsersEN.headPic) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|头像(headPic)]的值:[$(pobjUsersEN.headPic)], 非法，应该为字符型!(Users_CheckPropertyNew)");
//        }
//        if (null !== pobjUsersEN.IsGSuser && undefined !== pobjUsersEN.IsGSuser && tzDataType.isBoolean(pobjUsersEN.IsGSuser) === false) {
//            throw new Error("(errid:Watl000060)字段[用户(Users)|是否GS用户(IsGSuser)]的值:[$(pobjUsersEN.IsGSuser)], 非法，应该为布尔型!(Users_CheckPropertyNew)");
//        }
//        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
//        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
//        pobjUsersEN._IsCheckProperty = true;
//    };
//    /// <summary>
//    /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
//    /// </summary>
//    public CheckProperty4Update(pobjUsersEN: clsUsersEN) {
//        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
//        if (null !== pobjUsersEN.userId && GetStrLen(pobjUsersEN.userId) > 20) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|用户ID(userId)]的长度不能超过20!值:$(pobjUsersEN.userId)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.userName && GetStrLen(pobjUsersEN.userName) > 30) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|用户名(userName)]的长度不能超过30!值:$(pobjUsersEN.userName)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.departmentId && GetStrLen(pobjUsersEN.departmentId) > 8) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|部门Id(departmentId)]的长度不能超过8!值:$(pobjUsersEN.departmentId)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.userStateId && GetStrLen(pobjUsersEN.userStateId) > 2) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|用户状态Id(userStateId)]的长度不能超过2!值:$(pobjUsersEN.userStateId)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.password && GetStrLen(pobjUsersEN.password) > 20) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|password(password)]的长度不能超过20!值:$(pobjUsersEN.password)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.SchoolID1 && GetStrLen(pobjUsersEN.SchoolID1) > 4) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|学校编号(SchoolID1)]的长度不能超过4!值:$(pobjUsersEN.SchoolID1)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.BeginYearMonth && GetStrLen(pobjUsersEN.BeginYearMonth) > 8) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|开始年月(BeginYearMonth)]的长度不能超过8!值:$(pobjUsersEN.BeginYearMonth)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.EndYearMonth && GetStrLen(pobjUsersEN.EndYearMonth) > 8) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|结束年月(EndYearMonth)]的长度不能超过8!值:$(pobjUsersEN.EndYearMonth)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.id_GradeBase && GetStrLen(pobjUsersEN.id_GradeBase) > 4) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|年级流水号(id_GradeBase)]的长度不能超过4!值:$(pobjUsersEN.id_GradeBase)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.id_XzCollege && GetStrLen(pobjUsersEN.id_XzCollege) > 4) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|学院流水号(id_XzCollege)]的长度不能超过4!值:$(pobjUsersEN.id_XzCollege)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.id_XzMajor && GetStrLen(pobjUsersEN.id_XzMajor) > 8) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|专业流水号(id_XzMajor)]的长度不能超过8!值:$(pobjUsersEN.id_XzMajor)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.stuIdTeacherId && GetStrLen(pobjUsersEN.stuIdTeacherId) > 20) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|学工号(stuIdTeacherId)]的长度不能超过20!值:$(pobjUsersEN.stuIdTeacherId)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.email && GetStrLen(pobjUsersEN.email) > 100) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|电子邮箱(email)]的长度不能超过100!值:$(pobjUsersEN.email)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.PhoneNumber && GetStrLen(pobjUsersEN.PhoneNumber) > 15) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|PhoneNumber(PhoneNumber)]的长度不能超过15!值:$(pobjUsersEN.PhoneNumber)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.AvatarsPicture && GetStrLen(pobjUsersEN.AvatarsPicture) > 100) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|AvatarsPicture(AvatarsPicture)]的长度不能超过100!值:$(pobjUsersEN.AvatarsPicture)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.identityID && GetStrLen(pobjUsersEN.identityID) > 2) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|身份编号(identityID)]的长度不能超过2!值:$(pobjUsersEN.identityID)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.AuditDate && GetStrLen(pobjUsersEN.AuditDate) > 14) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|AuditDate(AuditDate)]的长度不能超过14!值:$(pobjUsersEN.AuditDate)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.AuditUser && GetStrLen(pobjUsersEN.AuditUser) > 18) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|AuditUser(AuditUser)]的长度不能超过18!值:$(pobjUsersEN.AuditUser)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.registerDate && GetStrLen(pobjUsersEN.registerDate) > 14) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|registerDate(registerDate)]的长度不能超过14!值:$(pobjUsersEN.registerDate)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.mobilePhone && GetStrLen(pobjUsersEN.mobilePhone) > 20) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|手机(mobilePhone)]的长度不能超过20!值:$(pobjUsersEN.mobilePhone)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.openId && GetStrLen(pobjUsersEN.openId) > 50) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|微信openId(openId)]的长度不能超过50!值:$(pobjUsersEN.openId)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.updDate && GetStrLen(pobjUsersEN.updDate) > 20) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|修改日期(updDate)]的长度不能超过20!值:$(pobjUsersEN.updDate)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.updUser && GetStrLen(pobjUsersEN.updUser) > 20) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|修改人(updUser)]的长度不能超过20!值:$(pobjUsersEN.updUser)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.memo && GetStrLen(pobjUsersEN.memo) > 1000) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|备注(memo)]的长度不能超过1000!值:$(pobjUsersEN.memo)(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.headPic && GetStrLen(pobjUsersEN.headPic) > 500) {
//            throw new Error("(errid:Watl000062)字段[用户(Users)|头像(headPic)]的长度不能超过500!值:$(pobjUsersEN.headPic)(Users_CheckProperty4Update)");
//        }
//        //检查字段的数据类型是否正确
//        if (null !== pobjUsersEN.userId && undefined !== pobjUsersEN.userId && tzDataType.isString(pobjUsersEN.userId) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|用户ID(userId)]的值:[$(pobjUsersEN.userId)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.userName && undefined !== pobjUsersEN.userName && tzDataType.isString(pobjUsersEN.userName) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|用户名(userName)]的值:[$(pobjUsersEN.userName)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.departmentId && undefined !== pobjUsersEN.departmentId && tzDataType.isString(pobjUsersEN.departmentId) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|部门Id(departmentId)]的值:[$(pobjUsersEN.departmentId)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.userStateId && undefined !== pobjUsersEN.userStateId && tzDataType.isString(pobjUsersEN.userStateId) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|用户状态Id(userStateId)]的值:[$(pobjUsersEN.userStateId)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.password && undefined !== pobjUsersEN.password && tzDataType.isString(pobjUsersEN.password) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|password(password)]的值:[$(pobjUsersEN.password)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.isGpUser && undefined !== pobjUsersEN.isGpUser && tzDataType.isBoolean(pobjUsersEN.isGpUser) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|是否Gp用户(isGpUser)]的值:[$(pobjUsersEN.isGpUser)], 非法，应该为布尔型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.SchoolID1 && undefined !== pobjUsersEN.SchoolID1 && tzDataType.isString(pobjUsersEN.SchoolID1) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|学校编号(SchoolID1)]的值:[$(pobjUsersEN.SchoolID1)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.BeginYearMonth && undefined !== pobjUsersEN.BeginYearMonth && tzDataType.isString(pobjUsersEN.BeginYearMonth) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|开始年月(BeginYearMonth)]的值:[$(pobjUsersEN.BeginYearMonth)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.EndYearMonth && undefined !== pobjUsersEN.EndYearMonth && tzDataType.isString(pobjUsersEN.EndYearMonth) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|结束年月(EndYearMonth)]的值:[$(pobjUsersEN.EndYearMonth)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.id_GradeBase && undefined !== pobjUsersEN.id_GradeBase && tzDataType.isString(pobjUsersEN.id_GradeBase) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|年级流水号(id_GradeBase)]的值:[$(pobjUsersEN.id_GradeBase)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.id_XzCollege && undefined !== pobjUsersEN.id_XzCollege && tzDataType.isString(pobjUsersEN.id_XzCollege) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|学院流水号(id_XzCollege)]的值:[$(pobjUsersEN.id_XzCollege)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.id_XzMajor && undefined !== pobjUsersEN.id_XzMajor && tzDataType.isString(pobjUsersEN.id_XzMajor) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|专业流水号(id_XzMajor)]的值:[$(pobjUsersEN.id_XzMajor)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.isLeaved && undefined !== pobjUsersEN.isLeaved && tzDataType.isBoolean(pobjUsersEN.isLeaved) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|isLeaved(isLeaved)]的值:[$(pobjUsersEN.isLeaved)], 非法，应该为布尔型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.stuIdTeacherId && undefined !== pobjUsersEN.stuIdTeacherId && tzDataType.isString(pobjUsersEN.stuIdTeacherId) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|学工号(stuIdTeacherId)]的值:[$(pobjUsersEN.stuIdTeacherId)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.email && undefined !== pobjUsersEN.email && tzDataType.isString(pobjUsersEN.email) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|电子邮箱(email)]的值:[$(pobjUsersEN.email)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.PhoneNumber && undefined !== pobjUsersEN.PhoneNumber && tzDataType.isString(pobjUsersEN.PhoneNumber) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|PhoneNumber(PhoneNumber)]的值:[$(pobjUsersEN.PhoneNumber)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.AvatarsPicture && undefined !== pobjUsersEN.AvatarsPicture && tzDataType.isString(pobjUsersEN.AvatarsPicture) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|AvatarsPicture(AvatarsPicture)]的值:[$(pobjUsersEN.AvatarsPicture)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.identityID && undefined !== pobjUsersEN.identityID && tzDataType.isString(pobjUsersEN.identityID) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|身份编号(identityID)]的值:[$(pobjUsersEN.identityID)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.AuditDate && undefined !== pobjUsersEN.AuditDate && tzDataType.isString(pobjUsersEN.AuditDate) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|AuditDate(AuditDate)]的值:[$(pobjUsersEN.AuditDate)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.AuditUser && undefined !== pobjUsersEN.AuditUser && tzDataType.isString(pobjUsersEN.AuditUser) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|AuditUser(AuditUser)]的值:[$(pobjUsersEN.AuditUser)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.IsAudit && undefined !== pobjUsersEN.IsAudit && tzDataType.isBoolean(pobjUsersEN.IsAudit) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|是否审核(IsAudit)]的值:[$(pobjUsersEN.IsAudit)], 非法，应该为布尔型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.isRegister && undefined !== pobjUsersEN.isRegister && tzDataType.isBoolean(pobjUsersEN.isRegister) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|isRegister(isRegister)]的值:[$(pobjUsersEN.isRegister)], 非法，应该为布尔型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.registerDate && undefined !== pobjUsersEN.registerDate && tzDataType.isString(pobjUsersEN.registerDate) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|registerDate(registerDate)]的值:[$(pobjUsersEN.registerDate)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.mobilePhone && undefined !== pobjUsersEN.mobilePhone && tzDataType.isString(pobjUsersEN.mobilePhone) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|手机(mobilePhone)]的值:[$(pobjUsersEN.mobilePhone)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.openId && undefined !== pobjUsersEN.openId && tzDataType.isString(pobjUsersEN.openId) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|微信openId(openId)]的值:[$(pobjUsersEN.openId)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.updDate && undefined !== pobjUsersEN.updDate && tzDataType.isString(pobjUsersEN.updDate) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|修改日期(updDate)]的值:[$(pobjUsersEN.updDate)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.updUser && undefined !== pobjUsersEN.updUser && tzDataType.isString(pobjUsersEN.updUser) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|修改人(updUser)]的值:[$(pobjUsersEN.updUser)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.memo && undefined !== pobjUsersEN.memo && tzDataType.isString(pobjUsersEN.memo) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|备注(memo)]的值:[$(pobjUsersEN.memo)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.headPic && undefined !== pobjUsersEN.headPic && tzDataType.isString(pobjUsersEN.headPic) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|头像(headPic)]的值:[$(pobjUsersEN.headPic)], 非法，应该为字符型!(Users_CheckProperty4Update)");
//        }
//        if (null !== pobjUsersEN.IsGSuser && undefined !== pobjUsersEN.IsGSuser && tzDataType.isBoolean(pobjUsersEN.IsGSuser) === false) {
//            throw new Error("(errid:Watl000063)字段[用户(Users)|是否GS用户(IsGSuser)]的值:[$(pobjUsersEN.IsGSuser)], 非法，应该为布尔型!(Users_CheckProperty4Update)");
//        }
//        //检查主键是否为Null或者空！
//        if (null === pobjUsersEN.userId
//            || null !== pobjUsersEN.userId && pobjUsersEN.userId.toString() === "") {
//            throw new Error("(errid:Watl000064)字段[用户|用户ID]不能为空(NULL)!(Users_CheckProperty4Update)");
//        }
//        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
//        pobjUsersEN._IsCheckProperty = true;
//    };
//    /// <summary>
//    /// 把一个对象转化为一个JSON串
//    /// 作者:
//    /// 日期:20200605192605
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
//    /// </summary>
//    /// <param name = "strJSON">需要转化的JSON串</param>
//    /// <returns>返回一个生成的对象</returns>
//    public static GetJSONStrByObj(pobjUsersEN: clsUsersEN): string {
//        pobjUsersEN.sf_UpdFldSetStr = pobjUsersEN.updFldString;
//        var strJson;
//        var jsonData;
//        try {
//            strJson = JSON.stringify(pobjUsersEN);
//        }
//        catch (objException) {
//            myShowErrorMsg(objException);
//        }
//        return strJson;
//    };
//    /// <summary>
//    /// 把一个JSON串转化为一个对象列表
//    /// 作者:
//    /// 日期:20200605192605
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
//    /// </summary>
//    /// <param name = "strJSON">需要转化的JSON串</param>
//    /// <returns>返回一个生成的对象列表</returns>
//    public static GetObjLstByJSONStr(strJSON: string): Array<clsUsersEN> {
//        var arrUsersObjLst = new Array();
//        if (strJSON === "") {
//            return arrUsersObjLst;
//        }
//        try {
//            arrUsersObjLst = JSON.parse(strJSON);
//        }
//        catch (objException) {
//            return arrUsersObjLst;
//        }
//        return arrUsersObjLst;
//    };
//    /// <summary>
//    /// 把一个JSON串转化为一个对象
//    /// 作者:
//    /// 日期:20200605192605
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
//    /// </summary>
//    /// <param name = "strJSON">需要转化的JSON串</param>
//    /// <returns>返回一个生成的对象</returns>
//    public static GetObjByJSONStr(strJSON: string): clsUsersEN {
//        var pobjUsersEN = new clsUsersEN();
//        if (strJSON === "") {
//            return pobjUsersEN;
//        }
//        try {
//            pobjUsersEN = JSON.parse(strJSON);
//        }
//        catch (objException) {
//            return pobjUsersEN;
//        }
//        return pobjUsersEN;
//    };
//    /// <summary>
//    /// 把同一个类的对象,从简化对象复制到对象
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjFromSimObj)
//    /// </summary>
//    /// <param name = "objUsersENS">源简化对象</param>
//    /// <param name = "objUsersENT">目标对象</param>
//    public static CopyObjFromSimObj(objUsersENS: clsUsersEN_Sim, objUsersENT: clsUsersEN): void {
//        objUsersENT.userId = objUsersENS.userId; //用户ID
//        objUsersENT.userName = objUsersENS.userName; //用户名
//        objUsersENT.departmentId = objUsersENS.departmentId; //部门Id
//        objUsersENT.userStateId = objUsersENS.userStateId; //用户状态Id
//        objUsersENT.password = objUsersENS.password; //password
//        objUsersENT.isGpUser = objUsersENS.isGpUser; //是否Gp用户
//        objUsersENT.SchoolID1 = objUsersENS.SchoolID1; //学校编号
//        objUsersENT.BeginYearMonth = objUsersENS.BeginYearMonth; //开始年月
//        objUsersENT.EndYearMonth = objUsersENS.EndYearMonth; //结束年月
//        objUsersENT.id_GradeBase = objUsersENS.id_GradeBase; //年级流水号
//        objUsersENT.id_XzCollege = objUsersENS.id_XzCollege; //学院流水号
//        objUsersENT.id_XzMajor = objUsersENS.id_XzMajor; //专业流水号
//        objUsersENT.isLeaved = objUsersENS.isLeaved; //isLeaved
//        objUsersENT.stuIdTeacherId = objUsersENS.stuIdTeacherId; //学工号
//        objUsersENT.email = objUsersENS.email; //电子邮箱
//        objUsersENT.PhoneNumber = objUsersENS.PhoneNumber; //PhoneNumber
//        objUsersENT.AvatarsPicture = objUsersENS.AvatarsPicture; //AvatarsPicture
//        objUsersENT.identityID = objUsersENS.identityID; //身份编号
//        objUsersENT.AuditDate = objUsersENS.AuditDate; //AuditDate
//        objUsersENT.AuditUser = objUsersENS.AuditUser; //AuditUser
//        objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
//        objUsersENT.isRegister = objUsersENS.isRegister; //isRegister
//        objUsersENT.registerDate = objUsersENS.registerDate; //registerDate
//        objUsersENT.mobilePhone = objUsersENS.mobilePhone; //手机
//        objUsersENT.openId = objUsersENS.openId; //微信openId
//        objUsersENT.updDate = objUsersENS.updDate; //修改日期
//        objUsersENT.updUser = objUsersENS.updUser; //修改人
//        objUsersENT.memo = objUsersENS.memo; //备注
//        objUsersENT.headPic = objUsersENS.headPic; //头像
//        objUsersENT.IsGSuser = objUsersENS.IsGSuser; //是否GS用户
//    }
//    /// <summary>
//    /// 把同一个类的对象,复制到另一个对象
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
//    /// </summary>
//    /// <param name = "objUsersENS">源对象</param>
//    /// <param name = "objUsersENT">目标对象</param>
//    public static CopyObjTo(objUsersENS: clsUsersEN, objUsersENT: clsUsersEN): void {
//        objUsersENT.userId = objUsersENS.userId; //用户ID
//        objUsersENT.userName = objUsersENS.userName; //用户名
//        objUsersENT.departmentId = objUsersENS.departmentId; //部门Id
//        objUsersENT.userStateId = objUsersENS.userStateId; //用户状态Id
//        objUsersENT.password = objUsersENS.password; //password
//        objUsersENT.isGpUser = objUsersENS.isGpUser; //是否Gp用户
//        objUsersENT.SchoolID1 = objUsersENS.SchoolID1; //学校编号
//        objUsersENT.BeginYearMonth = objUsersENS.BeginYearMonth; //开始年月
//        objUsersENT.EndYearMonth = objUsersENS.EndYearMonth; //结束年月
//        objUsersENT.id_GradeBase = objUsersENS.id_GradeBase; //年级流水号
//        objUsersENT.id_XzCollege = objUsersENS.id_XzCollege; //学院流水号
//        objUsersENT.id_XzMajor = objUsersENS.id_XzMajor; //专业流水号
//        objUsersENT.isLeaved = objUsersENS.isLeaved; //isLeaved
//        objUsersENT.stuIdTeacherId = objUsersENS.stuIdTeacherId; //学工号
//        objUsersENT.email = objUsersENS.email; //电子邮箱
//        objUsersENT.PhoneNumber = objUsersENS.PhoneNumber; //PhoneNumber
//        objUsersENT.AvatarsPicture = objUsersENS.AvatarsPicture; //AvatarsPicture
//        objUsersENT.identityID = objUsersENS.identityID; //身份编号
//        objUsersENT.AuditDate = objUsersENS.AuditDate; //AuditDate
//        objUsersENT.AuditUser = objUsersENS.AuditUser; //AuditUser
//        objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
//        objUsersENT.isRegister = objUsersENS.isRegister; //isRegister
//        objUsersENT.registerDate = objUsersENS.registerDate; //registerDate
//        objUsersENT.mobilePhone = objUsersENS.mobilePhone; //手机
//        objUsersENT.openId = objUsersENS.openId; //微信openId
//        objUsersENT.updDate = objUsersENS.updDate; //修改日期
//        objUsersENT.updUser = objUsersENS.updUser; //修改人
//        objUsersENT.memo = objUsersENS.memo; //备注
//        objUsersENT.headPic = objUsersENS.headPic; //头像
//        objUsersENT.IsGSuser = objUsersENS.IsGSuser; //是否GS用户
//        objUsersENT.sf_UpdFldSetStr = objUsersENS.updFldString; //sf_UpdFldSetStr
//    }
//    /// <summary>
//    /// 把同一个类的对象,复制到另一个对象(简单)
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjToSimObj)
//    /// </summary>
//    /// <param name = "objUsersENS">源对象</param>
//    /// <param name = "objUsersENT">目标对象</param>
//    public static CopyObjToSimObj(objUsersENS: clsUsersEN, objUsersENT: clsUsersEN_Sim): void {
//        objUsersENT.userId = objUsersENS.userId; //用户ID
//        objUsersENT.userName = objUsersENS.userName; //用户名
//        objUsersENT.departmentId = objUsersENS.departmentId; //部门Id
//        objUsersENT.userStateId = objUsersENS.userStateId; //用户状态Id
//        objUsersENT.password = objUsersENS.password; //password
//        objUsersENT.isGpUser = objUsersENS.isGpUser; //是否Gp用户
//        objUsersENT.SchoolID1 = objUsersENS.SchoolID1; //学校编号
//        objUsersENT.BeginYearMonth = objUsersENS.BeginYearMonth; //开始年月
//        objUsersENT.EndYearMonth = objUsersENS.EndYearMonth; //结束年月
//        objUsersENT.id_GradeBase = objUsersENS.id_GradeBase; //年级流水号
//        objUsersENT.id_XzCollege = objUsersENS.id_XzCollege; //学院流水号
//        objUsersENT.id_XzMajor = objUsersENS.id_XzMajor; //专业流水号
//        objUsersENT.isLeaved = objUsersENS.isLeaved; //isLeaved
//        objUsersENT.stuIdTeacherId = objUsersENS.stuIdTeacherId; //学工号
//        objUsersENT.email = objUsersENS.email; //电子邮箱
//        objUsersENT.PhoneNumber = objUsersENS.PhoneNumber; //PhoneNumber
//        objUsersENT.AvatarsPicture = objUsersENS.AvatarsPicture; //AvatarsPicture
//        objUsersENT.identityID = objUsersENS.identityID; //身份编号
//        objUsersENT.AuditDate = objUsersENS.AuditDate; //AuditDate
//        objUsersENT.AuditUser = objUsersENS.AuditUser; //AuditUser
//        objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
//        objUsersENT.isRegister = objUsersENS.isRegister; //isRegister
//        objUsersENT.registerDate = objUsersENS.registerDate; //registerDate
//        objUsersENT.mobilePhone = objUsersENS.mobilePhone; //手机
//        objUsersENT.openId = objUsersENS.openId; //微信openId
//        objUsersENT.updDate = objUsersENS.updDate; //修改日期
//        objUsersENT.updUser = objUsersENS.updUser; //修改人
//        objUsersENT.memo = objUsersENS.memo; //备注
//        objUsersENT.headPic = objUsersENS.headPic; //头像
//        objUsersENT.IsGSuser = objUsersENS.IsGSuser; //是否GS用户
//        objUsersENT.sf_UpdFldSetStr = objUsersENS.updFldString; //专门用于记录某字段属性是否修改
//        objUsersENT.sf_FldComparisonOp = objUsersENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
//    }
//    /// <summary>
//    /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
//    /// </summary>
//    /// <param name = "objUsersENS">源简化对象</param>
//    /// <param name = "objUsersENT">目标对象</param>
//    public static CopyObjFromSimObj4Upd(objUsersENS: clsUsersEN_Sim, objUsersENT: clsUsersEN): void {
//        var strsf_UpdFldSetStr: string = objUsersENS.sf_UpdFldSetStr;
//        var sstrFldSet: string[] = strsf_UpdFldSetStr.split('|');
//        if (sstrFldSet.indexOf(clsUsersEN.con_UserId) >= 0) {
//            objUsersENT.userId = objUsersENS.userId; //用户ID
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_UserName) >= 0) {
//            objUsersENT.userName = objUsersENS.userName; //用户名
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_DepartmentId) >= 0) {
//            objUsersENT.departmentId = objUsersENS.departmentId; //部门Id
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_UserStateId) >= 0) {
//            objUsersENT.userStateId = objUsersENS.userStateId; //用户状态Id
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_Password) >= 0) {
//            objUsersENT.password = objUsersENS.password; //password
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_IsGpUser) >= 0) {
//            objUsersENT.isGpUser = objUsersENS.isGpUser; //是否Gp用户
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_SchoolID1) >= 0) {
//            objUsersENT.SchoolID1 = objUsersENS.SchoolID1; //学校编号
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_BeginYearMonth) >= 0) {
//            objUsersENT.BeginYearMonth = objUsersENS.BeginYearMonth; //开始年月
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_EndYearMonth) >= 0) {
//            objUsersENT.EndYearMonth = objUsersENS.EndYearMonth; //结束年月
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_id_GradeBase) >= 0) {
//            objUsersENT.id_GradeBase = objUsersENS.id_GradeBase; //年级流水号
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_id_XzCollege) >= 0) {
//            objUsersENT.id_XzCollege = objUsersENS.id_XzCollege; //学院流水号
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_id_XzMajor) >= 0) {
//            objUsersENT.id_XzMajor = objUsersENS.id_XzMajor; //专业流水号
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_IsLeaved) >= 0) {
//            objUsersENT.isLeaved = objUsersENS.isLeaved; //isLeaved
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_StuIdTeacherId) >= 0) {
//            objUsersENT.stuIdTeacherId = objUsersENS.stuIdTeacherId; //学工号
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_Email) >= 0) {
//            objUsersENT.email = objUsersENS.email; //电子邮箱
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_PhoneNumber) >= 0) {
//            objUsersENT.PhoneNumber = objUsersENS.PhoneNumber; //PhoneNumber
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_AvatarsPicture) >= 0) {
//            objUsersENT.AvatarsPicture = objUsersENS.AvatarsPicture; //AvatarsPicture
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_IdentityID) >= 0) {
//            objUsersENT.identityID = objUsersENS.identityID; //身份编号
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_AuditDate) >= 0) {
//            objUsersENT.AuditDate = objUsersENS.AuditDate; //AuditDate
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_AuditUser) >= 0) {
//            objUsersENT.AuditUser = objUsersENS.AuditUser; //AuditUser
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_IsAudit) >= 0) {
//            objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_IsRegister) >= 0) {
//            objUsersENT.isRegister = objUsersENS.isRegister; //isRegister
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_RegisterDate) >= 0) {
//            objUsersENT.registerDate = objUsersENS.registerDate; //registerDate
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_MobilePhone) >= 0) {
//            objUsersENT.mobilePhone = objUsersENS.mobilePhone; //手机
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_OpenId) >= 0) {
//            objUsersENT.openId = objUsersENS.openId; //微信openId
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_UpdDate) >= 0) {
//            objUsersENT.updDate = objUsersENS.updDate; //修改日期
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_UpdUser) >= 0) {
//            objUsersENT.updUser = objUsersENS.updUser; //修改人
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_Memo) >= 0) {
//            objUsersENT.memo = objUsersENS.memo; //备注
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_HeadPic) >= 0) {
//            objUsersENT.headPic = objUsersENS.headPic; //头像
//        }
//        if (sstrFldSet.indexOf(clsUsersEN.con_IsGSuser) >= 0) {
//            objUsersENT.IsGSuser = objUsersENS.IsGSuser; //是否GS用户
//        }
//    }
//    /// <summary>
//    /// 把同一个类的对象,复制到另一个对象(简单)
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetSimObjFromObj)
//    /// </summary>
//    /// <param name = "objUsersENS">源对象</param>
//    /// <param name = "objUsersENT">目标对象</param>
//    public static GetSimObjFromObj(objUsersENS: clsUsersEN): clsUsersEN_Sim {
//        var objUsersENT: clsUsersEN_Sim = new clsUsersEN_Sim();
//        objUsersENT.userId = objUsersENS.userId; //用户ID
//        objUsersENT.userName = objUsersENS.userName; //用户名
//        objUsersENT.departmentId = objUsersENS.departmentId; //部门Id
//        objUsersENT.userStateId = objUsersENS.userStateId; //用户状态Id
//        objUsersENT.password = objUsersENS.password; //password
//        objUsersENT.isGpUser = objUsersENS.isGpUser; //是否Gp用户
//        objUsersENT.SchoolID1 = objUsersENS.SchoolID1; //学校编号
//        objUsersENT.BeginYearMonth = objUsersENS.BeginYearMonth; //开始年月
//        objUsersENT.EndYearMonth = objUsersENS.EndYearMonth; //结束年月
//        objUsersENT.id_GradeBase = objUsersENS.id_GradeBase; //年级流水号
//        objUsersENT.id_XzCollege = objUsersENS.id_XzCollege; //学院流水号
//        objUsersENT.id_XzMajor = objUsersENS.id_XzMajor; //专业流水号
//        objUsersENT.isLeaved = objUsersENS.isLeaved; //isLeaved
//        objUsersENT.stuIdTeacherId = objUsersENS.stuIdTeacherId; //学工号
//        objUsersENT.email = objUsersENS.email; //电子邮箱
//        objUsersENT.PhoneNumber = objUsersENS.PhoneNumber; //PhoneNumber
//        objUsersENT.AvatarsPicture = objUsersENS.AvatarsPicture; //AvatarsPicture
//        objUsersENT.identityID = objUsersENS.identityID; //身份编号
//        objUsersENT.AuditDate = objUsersENS.AuditDate; //AuditDate
//        objUsersENT.AuditUser = objUsersENS.AuditUser; //AuditUser
//        objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
//        objUsersENT.isRegister = objUsersENS.isRegister; //isRegister
//        objUsersENT.registerDate = objUsersENS.registerDate; //registerDate
//        objUsersENT.mobilePhone = objUsersENS.mobilePhone; //手机
//        objUsersENT.openId = objUsersENS.openId; //微信openId
//        objUsersENT.updDate = objUsersENS.updDate; //修改日期
//        objUsersENT.updUser = objUsersENS.updUser; //修改人
//        objUsersENT.memo = objUsersENS.memo; //备注
//        objUsersENT.headPic = objUsersENS.headPic; //头像
//        objUsersENT.IsGSuser = objUsersENS.IsGSuser; //是否GS用户
//        objUsersENT.sf_UpdFldSetStr = objUsersENS.updFldString; //专门用于记录某字段属性是否修改
//        objUsersENT.sf_FldComparisonOp = objUsersENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
//        return objUsersENT;
//    }
//};