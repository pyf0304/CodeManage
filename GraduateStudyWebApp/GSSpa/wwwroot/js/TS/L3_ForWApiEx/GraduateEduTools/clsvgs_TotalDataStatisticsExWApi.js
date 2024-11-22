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
        define(["require", "exports", "jquery", "../../L0_Entity/GraduateEduTools/clsvgs_TotalDataStatisticsEN.js", "../../L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsCommonFunc4Web2.js", "../../PubFun/tzDictionary.js", "../../L0_Entity/GraduateEduTools/clsvgs_TotalDataStatisticsENEx.js", "../../L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLstAsync = exports.vgs_TotalDataStatisticsEx_GetUser_WeekNumSubObjLst_Cache = exports.vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLst_ClientCache = exports.vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLstAsync = exports.vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreSubObjLst_Cache = exports.vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLst_ClientCache = exports.vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync = exports.vgs_TotalDataStatisticsEx_GetWeekNumSubObjLst_Cache = exports.vgs_TotalDataStatisticsEx_GetWeekNumObjLst_ClientCache = exports.vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync = exports.vgs_TotalDataStatisticsEx_GetUserNumSubObjLst_Cache = exports.vgs_TotalDataStatisticsEx_GetObjLst_Cache = exports.vgs_TotalDataStatisticsEx_GetObjLst_ClientCache = exports.vgs_TotalDataStatisticsEx_FilterFunByKey = exports.vgs_TotalDataStatisticsEx_FuncMapByFldName = exports.vgs_TotalDataStatisticsEx_SortFunByKey = exports.vgs_TotalDataStatisticsEx_GetObjExLstByPagerAsync = exports.vgs_TotalDataStatisticsEx_GetObjExLstByPager_Cache = exports.vgs_TotalDataStatisticsEx_CopyToEx = exports.vgs_TotalDataStatisticsEx_GetWebApiUrl = exports.vgs_TotalDataStatisticsEx_ConstructorName = exports.vgs_TotalDataStatisticsEx_Controller = void 0;
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const clsvgs_TotalDataStatisticsEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsvgs_TotalDataStatisticsEN.js");
    const clsvgs_TotalDataStatisticsWApi_js_1 = require("../../L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCommonFunc4Web2_js_1 = require("../../PubFun/clsCommonFunc4Web2.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsvgs_TotalDataStatisticsENEx_js_1 = require("../../L0_Entity/GraduateEduTools/clsvgs_TotalDataStatisticsENEx.js");
    const clsvgs_TotalDataStatisticsWApi_js_2 = require("../../L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.vgs_TotalDataStatisticsEx_Controller = "vgs_TotalDataStatisticsExApi";
    exports.vgs_TotalDataStatisticsEx_ConstructorName = "vgs_TotalDataStatisticsEx";
    //public static cacheModeId = "02"; //客户端缓存
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vgs_TotalDataStatisticsEx_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_TotalDataStatisticsEx_GetWebApiUrl = vgs_TotalDataStatisticsEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvgs_TotalDataStatisticsENS:源对象
    * @returns 目标对象=>clsvgs_TotalDataStatisticsEN:objvgs_TotalDataStatisticsENT
    **/
    function vgs_TotalDataStatisticsEx_CopyToEx(objvgs_TotalDataStatisticsENS) {
        const strThisFuncName = vgs_TotalDataStatisticsEx_CopyToEx.name;
        const objvgs_TotalDataStatisticsENT = new clsvgs_TotalDataStatisticsENEx_js_1.clsvgs_TotalDataStatisticsENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_TotalDataStatisticsENT, objvgs_TotalDataStatisticsENS);
            return objvgs_TotalDataStatisticsENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vgs_TotalDataStatisticsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvgs_TotalDataStatisticsENT;
        }
    }
    exports.vgs_TotalDataStatisticsEx_CopyToEx = vgs_TotalDataStatisticsEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_TotalDataStatisticsEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvgs_TotalDataStatisticsObjLst = await (0, clsvgs_TotalDataStatisticsWApi_js_2.vgs_TotalDataStatistics_GetObjLst_Cache)(strid_CurrEduCls);
        const arrvgs_TotalDataStatisticsExObjLst = arrvgs_TotalDataStatisticsObjLst.map(vgs_TotalDataStatisticsEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvgs_TotalDataStatisticsExObjLst) {
                const conFuncMap = await vgs_TotalDataStatisticsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvgs_TotalDataStatisticsExObjLst.length == 0)
            return arrvgs_TotalDataStatisticsExObjLst;
        let arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatisticsExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvgs_TotalDataStatistics_Cond = new clsvgs_TotalDataStatisticsENEx_js_1.clsvgs_TotalDataStatisticsENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_TotalDataStatistics_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvgs_TotalDataStatisticsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_TotalDataStatistics_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_TotalDataStatistics_Sel.length == 0)
                return arrvgs_TotalDataStatistics_Sel;
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
                arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.sort(vgs_TotalDataStatisticsEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.slice(intStart, intEnd);
            return arrvgs_TotalDataStatistics_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_TotalDataStatisticsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_TotalDataStatisticsEx_GetObjExLstByPager_Cache = vgs_TotalDataStatisticsEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_TotalDataStatisticsEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvgs_TotalDataStatisticsExObjLst = await (0, clsvgs_TotalDataStatisticsWApi_js_2.vgs_TotalDataStatistics_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvgs_TotalDataStatisticsExObjLst) {
                const conFuncMap = await vgs_TotalDataStatisticsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvgs_TotalDataStatisticsExObjLst.length == 0)
            return arrvgs_TotalDataStatisticsExObjLst;
        let arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatisticsExObjLst;
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
                arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.sort(vgs_TotalDataStatisticsEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.slice(intStart, intEnd);
            return arrvgs_TotalDataStatistics_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_TotalDataStatisticsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_TotalDataStatisticsEx_GetObjExLstByPagerAsync = vgs_TotalDataStatisticsEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_TotalDataStatisticsEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvgs_TotalDataStatisticsWApi_js_2.vgs_TotalDataStatistics_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvgs_TotalDataStatisticsWApi_js_2.vgs_TotalDataStatistics_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vgs_TotalDataStatisticsEx_SortFunByKey = vgs_TotalDataStatisticsEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vgs_TotalDataStatisticsEx_FuncMapByFldName(strFldName, objvgs_TotalDataStatisticsEx) {
        const strThisFuncName = vgs_TotalDataStatisticsEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vgs_TotalDataStatisticsEx_FuncMapByFldName = vgs_TotalDataStatisticsEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_TotalDataStatisticsEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvgs_TotalDataStatisticsWApi_js_1.vgs_TotalDataStatistics_FilterFunByKey)(strKey, value);
        }
    }
    exports.vgs_TotalDataStatisticsEx_FilterFunByKey = vgs_TotalDataStatisticsEx_FilterFunByKey;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vgs_TotalDataStatisticsEx_GetObjLst_ClientCache(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            var arrvgs_TotalDataStatisticsObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            return arrvgs_TotalDataStatisticsObjLst_Cache;
        }
        try {
            //const responseText = await vgs_TotalDataStatistics_GetObjLstAsync(strWhereCond);
            const responseText = await vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync(strWhereCond);
            var arrvgs_TotalDataStatisticsObjLst = responseText;
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvgs_TotalDataStatisticsObjLst);
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrvgs_TotalDataStatisticsObjLst.length}!`;
            console.log(strInfo);
            return arrvgs_TotalDataStatisticsObjLst;
        }
        catch (e) {
            console.log("GetObjLst_Cache:e");
            console.error(e);
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            throw (strMsg);
        }
    }
    exports.vgs_TotalDataStatisticsEx_GetObjLst_ClientCache = vgs_TotalDataStatisticsEx_GetObjLst_ClientCache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vgs_TotalDataStatisticsEx_GetObjLst_Cache(strid_CurrEduCls) {
        var arrvgs_TotalDataStatisticsObjLst_Cache;
        switch (clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_TotalDataStatisticsObjLst_Cache = await (0, clsvgs_TotalDataStatisticsWApi_js_1.vgs_TotalDataStatistics_GetObjLst_sessionStorage)(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvgs_TotalDataStatisticsObjLst_Cache = await (0, clsvgs_TotalDataStatisticsWApi_js_1.vgs_TotalDataStatistics_GetObjLst_localStorage)(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvgs_TotalDataStatisticsObjLst_Cache = await (0, clsvgs_TotalDataStatisticsWApi_js_1.vgs_TotalDataStatistics_GetObjLst_ClientCache)(strid_CurrEduCls);
                break;
            default:
                arrvgs_TotalDataStatisticsObjLst_Cache = await (0, clsvgs_TotalDataStatisticsWApi_js_1.vgs_TotalDataStatistics_GetObjLst_ClientCache)(strid_CurrEduCls);
                break;
        }
        return arrvgs_TotalDataStatisticsObjLst_Cache;
    }
    exports.vgs_TotalDataStatisticsEx_GetObjLst_Cache = vgs_TotalDataStatisticsEx_GetObjLst_Cache;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取子集.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
    /// </summary>
    /// <param name = "objstrTotalDataId_Cond">条件对象</param>
    /// <returns>对象列表子集</returns>
    async function vgs_TotalDataStatisticsEx_GetUserNumSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, strid_CurrEduCls) {
        var arrvgs_TotalDataStatisticsObjLst_Cache = await vgs_TotalDataStatisticsEx_GetObjLst_Cache(strid_CurrEduCls);
        var arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatisticsObjLst_Cache.filter(x => true);
        if (objvgs_TotalDataStatistics_Cond.sf_FldComparisonOp == null || objvgs_TotalDataStatistics_Cond.sf_FldComparisonOp == "")
            return arrvgs_TotalDataStatistics_Sel;
        var dicFldComparisonOp = JSON.parse(objvgs_TotalDataStatistics_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_TotalDataStatisticsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objvgs_TotalDataStatistics_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objvgs_TotalDataStatistics_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_TotalDataStatistics_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objvgs_TotalDataStatistics_Cond)}]缓存对象列表中获取子集对象不成功!`;
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_TotalDataStatisticsEx_GetUserNumSubObjLst_Cache = vgs_TotalDataStatisticsEx_GetUserNumSubObjLst_Cache;
    ;
    /// <summary>
    /// 用户统计
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync(strWhereCond) {
        var strAction = "GetUserNumObjLst";
        let strUrl = vgs_TotalDataStatisticsEx_GetWebApiUrl(exports.vgs_TotalDataStatisticsEx_Controller, strAction);
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
    exports.vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync = vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync;
    ;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vgs_TotalDataStatisticsEx_GetWeekNumObjLst_ClientCache(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            var arrvgs_TotalDataStatisticsObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            return arrvgs_TotalDataStatisticsObjLst_Cache;
        }
        try {
            //const responseText = await vgs_TotalDataStatistics_GetObjLstAsync(strWhereCond);
            const responseText = await vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync(strWhereCond);
            var arrvgs_TotalDataStatisticsObjLst = responseText;
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvgs_TotalDataStatisticsObjLst);
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrvgs_TotalDataStatisticsObjLst.length}!`;
            console.log(strInfo);
            return arrvgs_TotalDataStatisticsObjLst;
        }
        catch (e) {
            console.log("GetObjLst_Cache:e");
            console.error(e);
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            throw (strMsg);
        }
    }
    exports.vgs_TotalDataStatisticsEx_GetWeekNumObjLst_ClientCache = vgs_TotalDataStatisticsEx_GetWeekNumObjLst_ClientCache;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取子集.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
    /// </summary>
    /// <param name = "objstrTotalDataId_Cond">条件对象</param>
    /// <returns>对象列表子集</returns>
    async function vgs_TotalDataStatisticsEx_GetWeekNumSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, strid_CurrEduCls) {
        var arrvgs_TotalDataStatisticsObjLst_Cache = await vgs_TotalDataStatisticsEx_GetWeekNumObjLst_ClientCache(strid_CurrEduCls);
        var arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatisticsObjLst_Cache.filter(x => true);
        if (objvgs_TotalDataStatistics_Cond.sf_FldComparisonOp == null || objvgs_TotalDataStatistics_Cond.sf_FldComparisonOp == "")
            return arrvgs_TotalDataStatistics_Sel;
        var dicFldComparisonOp = JSON.parse(objvgs_TotalDataStatistics_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_TotalDataStatisticsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objvgs_TotalDataStatistics_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objvgs_TotalDataStatistics_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_TotalDataStatistics_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objvgs_TotalDataStatistics_Cond)}]缓存对象列表中获取子集对象不成功!`;
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_TotalDataStatisticsEx_GetWeekNumSubObjLst_Cache = vgs_TotalDataStatisticsEx_GetWeekNumSubObjLst_Cache;
    ;
    /// <summary>
    /// 周期统计
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync(strWhereCond) {
        var strAction = "GetWeekNumObjLst";
        let strUrl = vgs_TotalDataStatisticsEx_GetWebApiUrl(exports.vgs_TotalDataStatisticsEx_Controller, strAction);
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
    exports.vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync = vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync;
    ;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLst_ClientCache(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            var arrvgs_TotalDataStatisticsObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            return arrvgs_TotalDataStatisticsObjLst_Cache;
        }
        try {
            //const responseText = await vgs_TotalDataStatistics_GetObjLstAsync(strWhereCond);
            const responseText = await vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLstAsync(strWhereCond);
            var arrvgs_TotalDataStatisticsObjLst = responseText;
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvgs_TotalDataStatisticsObjLst);
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrvgs_TotalDataStatisticsObjLst.length}!`;
            console.log(strInfo);
            return arrvgs_TotalDataStatisticsObjLst;
        }
        catch (e) {
            console.log("GetObjLst_Cache:e");
            console.error(e);
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            throw (strMsg);
        }
    }
    exports.vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLst_ClientCache = vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLst_ClientCache;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取子集.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
    /// </summary>
    /// <param name = "objstrTotalDataId_Cond">条件对象</param>
    /// <returns>对象列表子集</returns>
    async function vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, strid_CurrEduCls) {
        var arrvgs_TotalDataStatisticsObjLst_Cache = await vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLst_ClientCache(strid_CurrEduCls);
        var arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatisticsObjLst_Cache.filter(x => true);
        if (objvgs_TotalDataStatistics_Cond.sf_FldComparisonOp == null || objvgs_TotalDataStatistics_Cond.sf_FldComparisonOp == "")
            return arrvgs_TotalDataStatistics_Sel;
        var dicFldComparisonOp = JSON.parse(objvgs_TotalDataStatistics_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_TotalDataStatisticsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objvgs_TotalDataStatistics_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objvgs_TotalDataStatistics_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_TotalDataStatistics_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objvgs_TotalDataStatistics_Cond)}]缓存对象列表中获取子集对象不成功!`;
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreSubObjLst_Cache = vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreSubObjLst_Cache;
    ;
    /// <summary>
    /// 获取教学班周教师打分平均分
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLstAsync(strWhereCond) {
        var strAction = "GetWeekAVGTeaScoreObjLst";
        let strUrl = vgs_TotalDataStatisticsEx_GetWebApiUrl(exports.vgs_TotalDataStatisticsEx_Controller, strAction);
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
    exports.vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLstAsync = vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLstAsync;
    ;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLst_ClientCache(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            var arrvgs_TotalDataStatisticsObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            return arrvgs_TotalDataStatisticsObjLst_Cache;
        }
        try {
            //const responseText = await vgs_TotalDataStatistics_GetObjLstAsync(strWhereCond);
            const responseText = await vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLstAsync(strWhereCond);
            var arrvgs_TotalDataStatisticsObjLst = responseText;
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvgs_TotalDataStatisticsObjLst);
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrvgs_TotalDataStatisticsObjLst.length}!`;
            console.log(strInfo);
            return arrvgs_TotalDataStatisticsObjLst;
        }
        catch (e) {
            console.log("GetObjLst_Cache:e");
            console.error(e);
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            throw (strMsg);
        }
    }
    exports.vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLst_ClientCache = vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLst_ClientCache;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取子集.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
    /// </summary>
    /// <param name = "objstrTotalDataId_Cond">条件对象</param>
    /// <returns>对象列表子集</returns>
    async function vgs_TotalDataStatisticsEx_GetUser_WeekNumSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, strid_CurrEduCls) {
        var arrvgs_TotalDataStatisticsObjLst_Cache = await vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLst_ClientCache(strid_CurrEduCls);
        var arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatisticsObjLst_Cache.filter(x => true);
        if (objvgs_TotalDataStatistics_Cond.sf_FldComparisonOp == null || objvgs_TotalDataStatistics_Cond.sf_FldComparisonOp == "")
            return arrvgs_TotalDataStatistics_Sel;
        var dicFldComparisonOp = JSON.parse(objvgs_TotalDataStatistics_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_TotalDataStatisticsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objvgs_TotalDataStatistics_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objvgs_TotalDataStatistics_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_TotalDataStatistics_Sel = arrvgs_TotalDataStatistics_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_TotalDataStatistics_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objvgs_TotalDataStatistics_Cond)}]缓存对象列表中获取子集对象不成功!`;
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_TotalDataStatisticsEx_GetUser_WeekNumSubObjLst_Cache = vgs_TotalDataStatisticsEx_GetUser_WeekNumSubObjLst_Cache;
    ;
    /// <summary>
    /// 周期用户统计
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLstAsync(strWhereCond) {
        var strAction = "GetUser_WeekNumObjLst";
        let strUrl = vgs_TotalDataStatisticsEx_GetWebApiUrl(exports.vgs_TotalDataStatisticsEx_Controller, strAction);
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
    exports.vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLstAsync = vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLstAsync;
    ;
});
