/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_TopicRoleExWApi
表名:gs_TopicRole(01120869)
生成代码版本:2021.01.08.1
生成日期:2021/01/08 00:53:27
生成者:lyl
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == ==
*/
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "jquery", "../../L0_Entity/GraduateEduTopic/clsgs_TopicRoleEN.js", "../../PubFun/tzDictionary.js", "../../L0_Entity/GraduateEduTopic/clsgs_TopicRoleENEx.js", "../../L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TopicRoleEx_AddDefaultSettingsAsync = exports.gs_TopicRoleEx_FilterFunByKey = exports.gs_TopicRoleEx_FuncMapByFldName = exports.gs_TopicRoleEx_SortFunByKey = exports.gs_TopicRoleEx_GetObjExLstByPagerAsync = exports.gs_TopicRoleEx_GetObjExLstByPager_Cache = exports.gs_TopicRoleEx_CopyToEx = exports.gs_TopicRoleEx_GetWebApiUrl = exports.gs_TopicRoleEx_ConstructorName = exports.gs_TopicRoleEx_Controller = void 0;
    /// <summary>
    /// 主题权限表(gs_TopicRole)
    /// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by lyl on 2021年01月08日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const clsgs_TopicRoleEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_TopicRoleEN.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsgs_TopicRoleENEx_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_TopicRoleENEx.js");
    const clsgs_TopicRoleWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.gs_TopicRoleEx_Controller = "gs_TopicRoleExApi";
    exports.gs_TopicRoleEx_ConstructorName = "gs_TopicRoleEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function gs_TopicRoleEx_GetWebApiUrl(strController, strAction) {
        const strThisFuncName = "GetWebApiUrl";
        let strServiceUrl;
        let strCurrIPAddressAndPort = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort;
        }
        else {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local;
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx) == true) {
            strServiceUrl = (0, clsString_js_1.Format)("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
        }
        else {
            strServiceUrl = (0, clsString_js_1.Format)("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx, strController, strAction);
        }
        return strServiceUrl;
    }
    exports.gs_TopicRoleEx_GetWebApiUrl = gs_TopicRoleEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objgs_TopicRoleENS:源对象
    * @returns 目标对象=>clsgs_TopicRoleEN:objgs_TopicRoleENT
    **/
    function gs_TopicRoleEx_CopyToEx(objgs_TopicRoleENS) {
        const strThisFuncName = gs_TopicRoleEx_CopyToEx.name;
        const objgs_TopicRoleENT = new clsgs_TopicRoleENEx_js_1.clsgs_TopicRoleENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TopicRoleENT, objgs_TopicRoleENS);
            return objgs_TopicRoleENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.gs_TopicRoleEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objgs_TopicRoleENT;
        }
    }
    exports.gs_TopicRoleEx_CopyToEx = gs_TopicRoleEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_TopicRoleEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_TopicRoleObjLst = await (0, clsgs_TopicRoleWApi_js_1.gs_TopicRole_GetObjLst_Cache)();
        const arrgs_TopicRoleExObjLst = arrgs_TopicRoleObjLst.map(gs_TopicRoleEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_TopicRoleExObjLst) {
                const conFuncMap = await gs_TopicRoleEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_TopicRoleExObjLst.length == 0)
            return arrgs_TopicRoleExObjLst;
        let arrgs_TopicRole_Sel = arrgs_TopicRoleExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_TopicRole_Cond = new clsgs_TopicRoleENEx_js_1.clsgs_TopicRoleENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TopicRole_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_TopicRoleWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TopicRole_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_TopicRole_Sel.length == 0)
                return arrgs_TopicRole_Sel;
            let intStart = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
            if (intStart <= 0)
                intStart = 0;
            const intEnd = intStart + objPagerPara.pageSize;
            if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
                const sstrSplit = objPagerPara.orderBy.split(" ");
                let strSortType = "asc";
                const strSortFld = sstrSplit[0];
                if (sstrSplit.length > 1)
                    strSortType = sstrSplit[1];
                arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.sort(gs_TopicRoleEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.slice(intStart, intEnd);
            return arrgs_TopicRole_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_TopicRoleEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TopicRoleEx_GetObjExLstByPager_Cache = gs_TopicRoleEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_TopicRoleEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrgs_TopicRoleExObjLst = await (0, clsgs_TopicRoleWApi_js_1.gs_TopicRole_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_TopicRoleExObjLst) {
                const conFuncMap = await gs_TopicRoleEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_TopicRoleExObjLst.length == 0)
            return arrgs_TopicRoleExObjLst;
        let arrgs_TopicRole_Sel = arrgs_TopicRoleExObjLst;
        try {
            let intStart = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
            if (intStart <= 0)
                intStart = 0;
            const intEnd = intStart + objPagerPara.pageSize;
            if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
                const sstrSplit = objPagerPara.orderBy.split(" ");
                let strSortType = "asc";
                const strSortFld = sstrSplit[0];
                if (sstrSplit.length > 1)
                    strSortType = sstrSplit[1];
                arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.sort(gs_TopicRoleEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.slice(intStart, intEnd);
            return arrgs_TopicRole_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_TopicRoleEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TopicRoleEx_GetObjExLstByPagerAsync = gs_TopicRoleEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TopicRoleEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsgs_TopicRoleWApi_js_1.gs_TopicRole_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsgs_TopicRoleWApi_js_1.gs_TopicRole_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.gs_TopicRoleEx_SortFunByKey = gs_TopicRoleEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function gs_TopicRoleEx_FuncMapByFldName(strFldName, objgs_TopicRoleEx) {
        const strThisFuncName = gs_TopicRoleEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.gs_TopicRoleEx_FuncMapByFldName = gs_TopicRoleEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_TopicRoleEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsgs_TopicRoleWApi_js_1.gs_TopicRole_FilterFunByKey)(strKey, value);
        }
    }
    exports.gs_TopicRoleEx_FilterFunByKey = gs_TopicRoleEx_FilterFunByKey;
    //添加默认设置
    async function gs_TopicRoleEx_AddDefaultSettingsAsync(strTopicId, strUpdUser) {
        var strAction = "AddDefaultSettings";
        let strUrl = gs_TopicRoleEx_GetWebApiUrl(exports.gs_TopicRoleEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strTopicId", strTopicId);
        mapParam.add("strUpdUser", strUpdUser);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    if (data.ErrorId == 0) {
                        resolve(data.ReturnBool);
                    }
                    else {
                        console.log(data.ErrorMsg);
                        reject(data.ErrorMsg);
                    }
                },
                error: function (result) {
                    console.log(result);
                    console.log(JSON.stringify(result));
                    if (result.statusText == "error") {
                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
                        reject(strInfo);
                    }
                    else {
                        reject(result.statusText);
                    }
                }
            });
        });
    }
    exports.gs_TopicRoleEx_AddDefaultSettingsAsync = gs_TopicRoleEx_AddDefaultSettingsAsync;
    ;
});
