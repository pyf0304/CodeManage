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
        define(["require", "exports", "jquery", "../../L0_Entity/GraduateEduPaper/clsvPaperEN.js", "../../L0_Entity/UserManage/clsUsersEN.js", "../../PubFun/clsCommonFunc4Web2.js", "../../PubFun/clsSysPara4WebApi2.js", "../../PubFun/tzDictionary.js", "../../L0_Entity/BaseInfo/clsXzMajorEN.js", "../../L0_Entity/GraduateEduPaper/clsvPaperENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js", "../../L3_ForWApi/Other/clsvPaperSimWApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperEx_GetObjLstByPagerById_CurrEduCls_Cache = exports.vPaperEx_GetRecCountByCondById_CurrEduCls_Cache = exports.vPaperEx_GetSubObjLstById_CurrEduCls_Cache = exports.vPaperEx_GetObjLstById_CurrEduCls_sessionStorage = exports.vPaperEx_GetObjLstById_CurrEduCls_localStorage = exports.vPaperEx_GetObjLstById_CurrEduCls_ClientCache = exports.vPaperEx_GetObjLstById_CurrEduCls_Cache = exports.vPaperEx_ReFreshThisCacheById_CurrEduCls = exports.vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache = exports.vPaperEx_GetObjLstById_CurrEduCls = exports.vPaperEx_GetXzMajorBvPaperSim = exports.vPaperEx_XzMajorIsExist = exports.vPaperEx_XzMajorUniq = exports.vPaperEx_BindDdl_XzMajorInvSimPaper_Cache = exports.vPaperEx_GetUsersBvPaperSim = exports.vPaperEx_IsExist = exports.vPaperEx_uniq = exports.vPaperEx_BindDdl_UsersInvSimPaper_Cache = exports.vPaperEx_SynPaperStatisticsAsync = exports.vPaperEx_GetUserNumObjLstAsync = exports.vPaperEx_FilterFunByKey = exports.vPaperEx_FuncMapByFldName = exports.vPaperEx_SortFunByKey = exports.vPaperEx_GetObjExLstByPagerAsync = exports.vPaperEx_GetObjExLstByPager_Cache = exports.vPaperEx_CopyToEx = exports.vPaperEx_GetWebApiUrl = exports.vPaperEx_ConstructorName = exports.vPaperEx_Controller = void 0;
    /// <summary>
    /// 论文读写表(Paper)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2020年01月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const clsvPaperEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperEN.js");
    const clsUsersEN_js_1 = require("../../L0_Entity/UserManage/clsUsersEN.js");
    const clsCommonFunc4Web2_js_1 = require("../../PubFun/clsCommonFunc4Web2.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsXzMajorEN_js_1 = require("../../L0_Entity/BaseInfo/clsXzMajorEN.js");
    const clsvPaperENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperENEx.js");
    const clsvPaperWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js");
    const clsvPaperSimWApi_js_1 = require("../../L3_ForWApi/Other/clsvPaperSimWApi.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.vPaperEx_Controller = "vPaperExApi";
    exports.vPaperEx_ConstructorName = "vPaperEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vPaperEx_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperEx_GetWebApiUrl = vPaperEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvPaperENS:源对象
    * @returns 目标对象=>clsvPaperEN:objvPaperENT
    **/
    function vPaperEx_CopyToEx(objvPaperENS) {
        const strThisFuncName = vPaperEx_CopyToEx.name;
        const objvPaperENT = new clsvPaperENEx_js_1.clsvPaperENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperENT, objvPaperENS);
            return objvPaperENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vPaperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvPaperENT;
        }
    }
    exports.vPaperEx_CopyToEx = vPaperEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvPaperObjLst = await (0, clsvPaperWApi_js_1.vPaper_GetObjLst_Cache)();
        const arrvPaperExObjLst = arrvPaperObjLst.map(vPaperEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvPaperExObjLst) {
                const conFuncMap = await vPaperEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvPaperExObjLst.length == 0)
            return arrvPaperExObjLst;
        let arrvPaper_Sel = arrvPaperExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvPaper_Cond = new clsvPaperENEx_js_1.clsvPaperENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaper_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaper_Sel.length == 0)
                return arrvPaper_Sel;
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
                arrvPaper_Sel = arrvPaper_Sel.sort(vPaperEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaper_Sel = arrvPaper_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaper_Sel = arrvPaper_Sel.slice(intStart, intEnd);
            return arrvPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperEx_GetObjExLstByPager_Cache = vPaperEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvPaperExObjLst = await (0, clsvPaperWApi_js_1.vPaper_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvPaperExObjLst) {
                const conFuncMap = await vPaperEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvPaperExObjLst.length == 0)
            return arrvPaperExObjLst;
        let arrvPaper_Sel = arrvPaperExObjLst;
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
                arrvPaper_Sel = arrvPaper_Sel.sort(vPaperEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaper_Sel = arrvPaper_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaper_Sel = arrvPaper_Sel.slice(intStart, intEnd);
            return arrvPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperEx_GetObjExLstByPagerAsync = vPaperEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvPaperWApi_js_1.vPaper_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvPaperWApi_js_1.vPaper_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vPaperEx_SortFunByKey = vPaperEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vPaperEx_FuncMapByFldName(strFldName, objvPaperEx) {
        const strThisFuncName = vPaperEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvPaperEN_js_1.clsvPaperEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vPaperEx_FuncMapByFldName = vPaperEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvPaperWApi_js_1.vPaper_FilterFunByKey)(strKey, value);
        }
    }
    exports.vPaperEx_FilterFunByKey = vPaperEx_FilterFunByKey;
    /// <summary>
    /// 获取论文中的用户数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function vPaperEx_GetUserNumObjLstAsync(strWhereCond) {
        var strAction = "GetUserNumObjLst";
        let strUrl = vPaperEx_GetWebApiUrl(exports.vPaperEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    if (data.ErrorId == 0) {
                        var returnObjLst = JSON.parse(data.ReturnObjLst);
                        //console.log(returnObjLst);
                        resolve(returnObjLst);
                    }
                    else {
                        console.log(data.ErrorMsg);
                        reject(data.ErrorMsg);
                    }
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.vPaperEx_GetUserNumObjLstAsync = vPaperEx_GetUserNumObjLstAsync;
    ;
    ///// <summary>
    ///// 获取论文中的专业数量
    ///// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    ///// </summary>
    ///// <param name = "strWhereCond">条件</param>
    ///// <returns>获取的相应对象列表</returns>
    //public static GetMajorNumObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperEN>> {
    //    var strAction = "GetMajorNumObjLst";
    //    let strUrl = vPaperEx_GetWebApiUrl(vPaperEx_Controller, strAction);
    //    var mapParam: Dictionary = new Dictionary();
    //    mapParam.add("strWhereCond", strWhereCond);
    //    let strData = mapParam.getParamText();// "例如: strIdentityID =01";
    //    return new Promise(function (resolve, reject) {
    //        $.ajax({
    //            url: strUrl,
    //            method: "GET",
    //            dataType: "json",
    //            data: strData,
    //            success: function (data) {
    //                if (data.ErrorId == 0) {
    //                    var returnObjLst = JSON.parse(data.ReturnObjLst);
    //                    //console.log(returnObjLst);
    //                    resolve(returnObjLst);
    //                }
    //                else {
    //                    console.log(data.ErrorMsg);
    //                    reject(data.ErrorMsg);
    //                }
    //            },
    //            error: (e) => {
    //                console.error(e);
    //                var strErrMsg = decodeURIComponent(e.responseText)
    //                reject(e);
    //            }
    //        });
    //    });
    //};
    ///// <summary>
    ///// 获取论文中的点赞数量
    ///// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    ///// </summary>
    ///// <param name = "strWhereCond">条件</param>
    ///// <returns>获取的相应对象列表</returns>
    //public static GetPaperLikeNumObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperLikeLogEN>> {
    //    var strAction = "GetPaperLikeNumObjLst";
    //    let strUrl = vPaperEx_GetWebApiUrl(vPaperEx_Controller, strAction);
    //    var mapParam: Dictionary = new Dictionary();
    //    mapParam.add("strWhereCond", strWhereCond);
    //    let strData = mapParam.getParamText();// "例如: strIdentityID =01";
    //    return new Promise(function (resolve, reject) {
    //        $.ajax({
    //            url: strUrl,
    //            method: "GET",
    //            dataType: "json",
    //            data: strData,
    //            success: function (data) {
    //                if (data.ErrorId == 0) {
    //                    var returnObjLst = JSON.parse(data.ReturnObjLst);
    //                    //console.log(returnObjLst);
    //                    resolve(returnObjLst);
    //                }
    //                else {
    //                    console.log(data.ErrorMsg);
    //                    reject(data.ErrorMsg);
    //                }
    //            },
    //            error: (e) => {
    //                console.error(e);
    //                var strErrMsg = decodeURIComponent(e.responseText)
    //                reject(e);
    //            }
    //        });
    //    });
    //};
    ///// <summary>
    ///// 获取论文中的评论数量
    ///// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    ///// </summary>
    ///// <param name = "strWhereCond">条件</param>
    ///// <returns>获取的相应对象列表</returns>
    //public static GetPaperAppraiseNumObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperAppraiseEN>> {
    //    var strAction = "GetPaperAppraiseNumObjLst";
    //    let strUrl = vPaperEx_GetWebApiUrl(vPaperEx_Controller, strAction);
    //    var mapParam: Dictionary = new Dictionary();
    //    mapParam.add("strWhereCond", strWhereCond);
    //    let strData = mapParam.getParamText();// "例如: strIdentityID =01";
    //    return new Promise(function (resolve, reject) {
    //        $.ajax({
    //            url: strUrl,
    //            method: "GET",
    //            dataType: "json",
    //            data: strData,
    //            success: function (data) {
    //                if (data.ErrorId == 0) {
    //                    var returnObjLst = JSON.parse(data.ReturnObjLst);
    //                    //console.log(returnObjLst);
    //                    resolve(returnObjLst);
    //                }
    //                else {
    //                    console.log(data.ErrorMsg);
    //                    reject(data.ErrorMsg);
    //                }
    //            },
    //            error: (e) => {
    //                console.error(e);
    //                var strErrMsg = decodeURIComponent(e.responseText)
    //                reject(e);
    //            }
    //        });
    //    });
    //};
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>返回的第一条记录的关键字值</returns>
    async function vPaperEx_SynPaperStatisticsAsync(TeaUserId) {
        var strAction = "GetTotalRevalidation";
        let strUrl = vPaperEx_GetWebApiUrl(exports.vPaperEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("updUser", TeaUserId);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    if (data.ErrorId == 0) {
                        resolve(data.ReturnStr);
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
    exports.vPaperEx_SynPaperStatisticsAsync = vPaperEx_SynPaperStatisticsAsync;
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// 绑定基于论文缓存的用户下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    async function vPaperEx_BindDdl_UsersInvSimPaper_Cache(strDdlName, objUsers_Cond) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserId_Cache");
        var arrvPaperSim = await (0, clsvPaperSimWApi_js_1.vPaperSim_GetObjLstAsync)("1=1");
        var arrObjLst_Sel = arrvPaperSim.map(vPaperEx_GetUsersBvPaperSim);
        arrObjLst_Sel = vPaperEx_uniq(arrObjLst_Sel);
        console.log(arrObjLst_Sel);
        arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsUsersEN_js_1.clsUsersEN.con_UserName]);
        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsUsersEN_js_1.clsUsersEN.con_UserId, clsUsersEN_js_1.clsUsersEN.con_UserName, "编辑用户");
    }
    exports.vPaperEx_BindDdl_UsersInvSimPaper_Cache = vPaperEx_BindDdl_UsersInvSimPaper_Cache;
    function vPaperEx_uniq(arr) {
        let arrObjLst_New = new Array();
        for (let x of arr) {
            if (vPaperEx_IsExist(arrObjLst_New, x) == false) {
                arrObjLst_New.push(x);
            }
        }
        return arrObjLst_New;
    }
    exports.vPaperEx_uniq = vPaperEx_uniq;
    function vPaperEx_IsExist(arr, key) {
        let arr_Sel = arr.filter(x => x.userId == key.userId);
        if (arr_Sel.length > 0)
            return true;
        return false;
    }
    exports.vPaperEx_IsExist = vPaperEx_IsExist;
    function vPaperEx_GetUsersBvPaperSim(objvPaperSim) {
        var objUsers = new clsUsersEN_js_1.clsUsersEN();
        objUsers.userId = objvPaperSim.updUser;
        objUsers.userName = objvPaperSim.userName;
        return objUsers;
    }
    exports.vPaperEx_GetUsersBvPaperSim = vPaperEx_GetUsersBvPaperSim;
    /// <summary>
    /// 绑定基于论文缓存的专业下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    async function vPaperEx_BindDdl_XzMajorInvSimPaper_Cache(strDdlName, objXzMajor_Cond) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_id_XzMajor_Cache");
        var arrvPaperSim = await (0, clsvPaperSimWApi_js_1.vPaperSim_GetObjLstAsync)("1=1");
        var arrObjLst_Sel = arrvPaperSim.map(vPaperEx_GetXzMajorBvPaperSim);
        arrObjLst_Sel = vPaperEx_XzMajorUniq(arrObjLst_Sel);
        console.log(arrObjLst_Sel);
        arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName]);
        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, "专业");
    }
    exports.vPaperEx_BindDdl_XzMajorInvSimPaper_Cache = vPaperEx_BindDdl_XzMajorInvSimPaper_Cache;
    function vPaperEx_XzMajorUniq(arr) {
        let arrObjLst_New = new Array();
        for (let x of arr) {
            if (vPaperEx_XzMajorIsExist(arrObjLst_New, x) == false) {
                arrObjLst_New.push(x);
            }
        }
        return arrObjLst_New;
    }
    exports.vPaperEx_XzMajorUniq = vPaperEx_XzMajorUniq;
    function vPaperEx_XzMajorIsExist(arr, key) {
        let arr_Sel = arr.filter(x => x.id_XzMajor == key.id_XzMajor);
        if (arr_Sel.length > 0)
            return true;
        return false;
    }
    exports.vPaperEx_XzMajorIsExist = vPaperEx_XzMajorIsExist;
    function vPaperEx_GetXzMajorBvPaperSim(objvPaperSim) {
        var objXzMajor = new clsXzMajorEN_js_1.clsXzMajorEN();
        objXzMajor.id_XzMajor = objvPaperSim.id_XzMajor;
        objXzMajor.majorName = objvPaperSim.majorName;
        return objXzMajor;
    }
    exports.vPaperEx_GetXzMajorBvPaperSim = vPaperEx_GetXzMajorBvPaperSim;
    /// <summary>
    /// 根据教学班获取对象列表，用对象列表表示
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    /// </summary>
    /// <param name = "strId_CurrEduCls">教学班流水号</param>
    /// <returns>获取的相应对象列表</returns>
    async function vPaperEx_GetObjLstById_CurrEduCls(strId_CurrEduCls) {
        var strAction = "GetObjLstById_CurrEduCls";
        let strUrl = vPaperEx_GetWebApiUrl(exports.vPaperEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strId_CurrEduCls", strId_CurrEduCls);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Get",
                dataType: "json",
                data: strData,
                success: function (data) {
                    if (data.ErrorId == 0) {
                        var returnObjLst = JSON.parse(data.ReturnObjLst);
                        //console.log(returnObjLst);
                        resolve(returnObjLst);
                    }
                    else {
                        console.error(data.ErrorMsg);
                        reject(data.ErrorMsg);
                    }
                },
                error: function (result) {
                    console.error(result);
                    console.error(JSON.stringify(result));
                    if (result.statusText == "error") {
                        var strInfo = `网络错误！访问地址:${strUrl} 不成功！`;
                        reject(strInfo);
                    }
                    else {
                        reject(result.statusText);
                    }
                }
            });
        });
    }
    exports.vPaperEx_GetObjLstById_CurrEduCls = vPaperEx_GetObjLstById_CurrEduCls;
    ;
    /// <summary>
    /// 根据关键字获取相关对象, 从缓存中获取.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
    /// </summary>
    /// <param name = "strPaperId">所给的关键字</param>
    /// <returns>对象</returns>
    async function vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache(strPaperId, strid_CurrEduCls) {
        var arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        var obj = new clsvPaperEN_js_1.clsvPaperEN();
        try {
            var arrvPaper_Sel = arrvPaperObjLst_Cache.filter(x => x.paperId == strPaperId);
            var objvPaper;
            if (arrvPaper_Sel.length > 0) {
                objvPaper = arrvPaper_Sel[0];
                return objvPaper;
            }
            else {
                return obj;
            }
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据关键字:[${strPaperId}]获取相应的对象不成功!`;
            console.error(strMsg);
            alert(strMsg);
        }
        return obj;
    }
    exports.vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache = vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 刷新本类中的缓存.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    /// </summary>
    function vPaperEx_ReFreshThisCacheById_CurrEduCls(strid_CurrEduCls) {
        var strMsg = "";
        if (clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.spSetRefreshCacheOn == true) {
            var strKey = `${clsvPaperEN_js_1.clsvPaperEN._CurrTabName}_${strid_CurrEduCls}`;
            switch (clsvPaperEN_js_1.clsvPaperEN.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
            }
            strMsg = `刷新缓存成功！`,
                console.trace(strMsg);
        }
        else {
            strMsg = `刷新缓存已经关闭。`;
            console.trace(strMsg);
        }
    }
    exports.vPaperEx_ReFreshThisCacheById_CurrEduCls = vPaperEx_ReFreshThisCacheById_CurrEduCls;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls) {
        var arrvPaperObjLst_Cache;
        switch (clsvPaperEN_js_1.clsvPaperEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls);
                break;
        }
        return arrvPaperObjLst_Cache;
    }
    exports.vPaperEx_GetObjLstById_CurrEduCls_Cache = vPaperEx_GetObjLstById_CurrEduCls_Cache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vPaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsvPaperEN_js_1.clsvPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            var arrvPaperObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            return arrvPaperObjLst_Cache;
        }
        try {
            const responseText = await vPaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
            var arrvPaperObjLst = responseText;
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvPaperObjLst);
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrvPaperObjLst.length}!`;
            console.log(strInfo);
            return arrvPaperObjLst;
        }
        catch (e) {
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperEx_GetObjLstById_CurrEduCls_ClientCache = vPaperEx_GetObjLstById_CurrEduCls_ClientCache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vPaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsvPaperEN_js_1.clsvPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            var strTempObjLst = localStorage.getItem(strKey);
            var arrvPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperObjLst_Cache;
        }
        try {
            const responseText = await vPaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
            var arrvPaperObjLst = responseText;
            localStorage.setItem(strKey, JSON.stringify(arrvPaperObjLst));
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrvPaperObjLst.length}!`;
            console.log(strInfo);
            return arrvPaperObjLst;
        }
        catch (e) {
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperEx_GetObjLstById_CurrEduCls_localStorage = vPaperEx_GetObjLstById_CurrEduCls_localStorage;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vPaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsvPaperEN_js_1.clsvPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            var strTempObjLst = sessionStorage.getItem(strKey);
            var arrvPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperObjLst_Cache;
        }
        try {
            const responseText = await vPaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
            var arrvPaperObjLst = responseText;
            sessionStorage.setItem(strKey, JSON.stringify(arrvPaperObjLst));
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrvPaperObjLst.length}!`;
            console.log(strInfo);
            return arrvPaperObjLst;
        }
        catch (e) {
            var strMsg = `从缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperEx_GetObjLstById_CurrEduCls_sessionStorage = vPaperEx_GetObjLstById_CurrEduCls_sessionStorage;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取子集.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
    /// </summary>
    /// <param name = "objstrSubViewpointId_Cond">条件对象</param>
    /// <returns>对象列表子集</returns>
    async function vPaperEx_GetSubObjLstById_CurrEduCls_Cache(objvPaper_Cond, strid_CurrEduCls) {
        var arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        var arrvPaper_Sel = arrvPaperObjLst_Cache.filter(x => true);
        if (objvPaper_Cond.sf_FldComparisonOp == null || objvPaper_Cond.sf_FldComparisonOp == "")
            return arrvPaper_Sel;
        var dicFldComparisonOp = JSON.parse(objvPaper_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objvPaper_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objvPaper_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrvPaper_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objvPaper_Cond)}]缓存对象列表中获取子集对象不成功!`;
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperEx_GetSubObjLstById_CurrEduCls_Cache = vPaperEx_GetSubObjLstById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取记录数.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
    /// </summary>
    /// <param name = "objvPaper_Cond">条件对象</param>
    /// <returns>对象列表记录数</returns>
    async function vPaperEx_GetRecCountByCondById_CurrEduCls_Cache(objvPaper_Cond, strid_CurrEduCls) {
        var arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        var arrvPaper_Sel = arrvPaperObjLst_Cache.filter(x => true);
        if (objvPaper_Cond.sf_FldComparisonOp == null || objvPaper_Cond.sf_FldComparisonOp == "")
            return arrvPaper_Sel.length;
        var dicFldComparisonOp = JSON.parse(objvPaper_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objvPaper_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objvPaper_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrvPaper_Sel.length;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objvPaper_Cond)}]从缓存对象列表中获取记录数不成功!`;
            console.error(strMsg);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vPaperEx_GetRecCountByCondById_CurrEduCls_Cache = vPaperEx_GetRecCountByCondById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 从缓存中获取分页对象列表.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
    /// </summary>
    /// <param name = "objPagerPara">分页参数结构</param>
    /// <returns>对象列表</returns>
    async function vPaperEx_GetObjLstByPagerById_CurrEduCls_Cache(objPagerPara, strid_CurrEduCls) {
        var arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        if (arrvPaperObjLst_Cache.length == 0)
            return arrvPaperObjLst_Cache;
        var arrvPaper_Sel = arrvPaperObjLst_Cache.filter(x => true);
        var obj_Cond = JSON.parse(objPagerPara.whereCond);
        var dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(obj_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = obj_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaper_Sel.length == 0)
                return arrvPaper_Sel;
            var intStart = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
            if (intStart <= 0)
                intStart = 0;
            var intEnd = intStart + objPagerPara.pageSize;
            if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
                var sstrSplit = objPagerPara.orderBy.split(" ");
                var strSortType = "asc";
                var strSortFld = sstrSplit[0];
                if (sstrSplit.length > 1)
                    strSortType = sstrSplit[1];
                //                console.log(arrvPaper_Sel);
                let objFirst = arrvPaper_Sel[0]; //第一个对象
                let strSortValue = objFirst[strSortFld]; //第一个对象排序字段值            
                let strSortFldType = typeof (strSortValue); //排序字段值的数据类型
                //console.log("排序字段的数据类型: " + strSortFldType);
                switch (strSortFldType) {
                    case "string":
                        if (strSortType.toLowerCase() == "asc") {
                            arrvPaper_Sel = arrvPaper_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
                        }
                        else {
                            arrvPaper_Sel = arrvPaper_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
                        }
                        break;
                    case "number":
                    case "boolean":
                        if (strSortType.toLowerCase() == "asc") {
                            arrvPaper_Sel = arrvPaper_Sel.sort((x, y) => x[strSortFld] - y[strSortFld]);
                        }
                        else {
                            arrvPaper_Sel = arrvPaper_Sel.sort((x, y) => y[strSortFld] - x[strSortFld]);
                        }
                        break;
                }
            }
            else {
                //如果排序字段名[orderBy]为空，就调用排序函数
                arrvPaper_Sel = arrvPaper_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaper_Sel = arrvPaper_Sel.slice(intStart, intEnd);
            return arrvPaper_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${objPagerPara.whereCond}]获取分页对象列表不成功!(In vPaper_GetObjLstByPager_Cache)`;
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperEx_GetObjLstByPagerById_CurrEduCls_Cache = vPaperEx_GetObjLstByPagerById_CurrEduCls_Cache;
    ;
});
