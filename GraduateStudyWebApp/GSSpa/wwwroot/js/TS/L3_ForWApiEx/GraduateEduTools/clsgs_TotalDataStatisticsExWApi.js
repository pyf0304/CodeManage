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
        define(["require", "exports", "jquery", "../../L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsEN.js", "../../L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsCommonFunc4Web2.js", "../../PubFun/stuPagerPara.js", "../../PubFun/tzDictionary.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js", "../../L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsENEx.js", "../../PubFun/clsCommFunc4Web.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TotalDataStatisticsEx_GetObjLstByPagerAsyncEx = exports.gs_TotalDataStatisticsEx_GetObjLstEx = exports.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis = exports.gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync = exports.gs_TotalDataStatisticsEx_GetSubObjLst_CacheEx = exports.gs_TotalDataStatisticsEx_GetObjLst_Cache = exports.gs_TotalDataStatisticsEx_GetObjLst_ClientCache = exports.gs_TotalDataStatisticsEx_FilterFunByKey = exports.gs_TotalDataStatisticsEx_FuncMapByFldName = exports.gs_TotalDataStatisticsEx_SortFunByKey = exports.gs_TotalDataStatisticsEx_GetObjExLstByPagerAsync = exports.gs_TotalDataStatisticsEx_GetObjExLstByPager_Cache = exports.gs_TotalDataStatisticsEx_CopyToEx = exports.gs_TotalDataStatisticsEx_GetWebApiUrl = exports.gs_TotalDataStatisticsEx_ConstructorName = exports.gs_TotalDataStatisticsEx_Controller = void 0;
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const clsgs_TotalDataStatisticsEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsEN.js");
    const clsgs_TotalDataStatisticsWApi_js_1 = require("../../L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCommonFunc4Web2_js_1 = require("../../PubFun/clsCommonFunc4Web2.js");
    const stuPagerPara_js_1 = require("../../PubFun/stuPagerPara.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    var ResponseData;
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsgs_TotalDataStatisticsENEx_js_1 = require("../../L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsENEx.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    exports.gs_TotalDataStatisticsEx_Controller = "gs_TotalDataStatisticsExApi";
    exports.gs_TotalDataStatisticsEx_ConstructorName = "gs_TotalDataStatisticsEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function gs_TotalDataStatisticsEx_GetWebApiUrl(strController, strAction) {
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
    exports.gs_TotalDataStatisticsEx_GetWebApiUrl = gs_TotalDataStatisticsEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objgs_TotalDataStatisticsENS:源对象
    * @returns 目标对象=>clsgs_TotalDataStatisticsEN:objgs_TotalDataStatisticsENT
    **/
    function gs_TotalDataStatisticsEx_CopyToEx(objgs_TotalDataStatisticsENS) {
        const strThisFuncName = gs_TotalDataStatisticsEx_CopyToEx.name;
        const objgs_TotalDataStatisticsENT = new clsgs_TotalDataStatisticsENEx_js_1.clsgs_TotalDataStatisticsENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TotalDataStatisticsENT, objgs_TotalDataStatisticsENS);
            return objgs_TotalDataStatisticsENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.gs_TotalDataStatisticsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objgs_TotalDataStatisticsENT;
        }
    }
    exports.gs_TotalDataStatisticsEx_CopyToEx = gs_TotalDataStatisticsEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_TotalDataStatisticsEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_TotalDataStatisticsObjLst = await (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_GetObjLst_Cache)(strid_CurrEduCls);
        const arrgs_TotalDataStatisticsExObjLst = arrgs_TotalDataStatisticsObjLst.map(gs_TotalDataStatisticsEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_TotalDataStatisticsExObjLst) {
                const conFuncMap = await gs_TotalDataStatisticsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_TotalDataStatisticsExObjLst.length == 0)
            return arrgs_TotalDataStatisticsExObjLst;
        let arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatisticsExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_TotalDataStatistics_Cond = new clsgs_TotalDataStatisticsENEx_js_1.clsgs_TotalDataStatisticsENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TotalDataStatistics_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_TotalDataStatisticsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TotalDataStatistics_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_TotalDataStatistics_Sel.length == 0)
                return arrgs_TotalDataStatistics_Sel;
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
                arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.sort(gs_TotalDataStatisticsEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.slice(intStart, intEnd);
            return arrgs_TotalDataStatistics_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_TotalDataStatisticsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TotalDataStatisticsEx_GetObjExLstByPager_Cache = gs_TotalDataStatisticsEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_TotalDataStatisticsEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrgs_TotalDataStatisticsExObjLst = await (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_TotalDataStatisticsExObjLst) {
                const conFuncMap = await gs_TotalDataStatisticsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_TotalDataStatisticsExObjLst.length == 0)
            return arrgs_TotalDataStatisticsExObjLst;
        let arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatisticsExObjLst;
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
                arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.sort(gs_TotalDataStatisticsEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.slice(intStart, intEnd);
            return arrgs_TotalDataStatistics_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_TotalDataStatisticsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TotalDataStatisticsEx_GetObjExLstByPagerAsync = gs_TotalDataStatisticsEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TotalDataStatisticsEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.gs_TotalDataStatisticsEx_SortFunByKey = gs_TotalDataStatisticsEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function gs_TotalDataStatisticsEx_FuncMapByFldName(strFldName, objgs_TotalDataStatisticsEx) {
        const strThisFuncName = gs_TotalDataStatisticsEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsgs_TotalDataStatisticsEN_js_1.clsgs_TotalDataStatisticsEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.gs_TotalDataStatisticsEx_FuncMapByFldName = gs_TotalDataStatisticsEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_TotalDataStatisticsEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_FilterFunByKey)(strKey, value);
        }
    }
    exports.gs_TotalDataStatisticsEx_FilterFunByKey = gs_TotalDataStatisticsEx_FilterFunByKey;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function gs_TotalDataStatisticsEx_GetObjLst_ClientCache(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        //clsgs_TotalDataStatisticsWApi.InitListCache();
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsgs_TotalDataStatisticsEN_js_1.clsgs_TotalDataStatisticsEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            var arrgs_TotalDataStatisticsObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            return arrgs_TotalDataStatisticsObjLst_Cache;
        }
        try {
            const responseText = await gs_TotalDataStatisticsEx_GetObjLstEx(strWhereCond);
            var arrgs_TotalDataStatisticsObjLst = responseText;
            CacheHelper_js_1.CacheHelper.Add(strKey, arrgs_TotalDataStatisticsObjLst);
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrgs_TotalDataStatisticsObjLst.length}!`;
            console.log(strInfo);
            return arrgs_TotalDataStatisticsObjLst;
        }
        catch (e) {
            console.log("GetObjLst_Cache:e");
            console.error(e);
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            throw (strMsg);
        }
    }
    exports.gs_TotalDataStatisticsEx_GetObjLst_ClientCache = gs_TotalDataStatisticsEx_GetObjLst_ClientCache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function gs_TotalDataStatisticsEx_GetObjLst_Cache(strid_CurrEduCls) {
        var arrgs_TotalDataStatisticsObjLst_Cache;
        switch (clsgs_TotalDataStatisticsEN_js_1.clsgs_TotalDataStatisticsEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TotalDataStatisticsObjLst_Cache = await (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_GetObjLst_sessionStorage)(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrgs_TotalDataStatisticsObjLst_Cache = await (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_GetObjLst_localStorage)(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrgs_TotalDataStatisticsObjLst_Cache = await (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_GetObjLst_ClientCache)(strid_CurrEduCls);
                break;
            default:
                arrgs_TotalDataStatisticsObjLst_Cache = await (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_GetObjLst_ClientCache)(strid_CurrEduCls);
                break;
        }
        return arrgs_TotalDataStatisticsObjLst_Cache;
    }
    exports.gs_TotalDataStatisticsEx_GetObjLst_Cache = gs_TotalDataStatisticsEx_GetObjLst_Cache;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取子集.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
    /// </summary>
    /// <param name = "objstrTotalDataId_Cond">条件对象</param>
    /// <returns>对象列表子集</returns>
    async function gs_TotalDataStatisticsEx_GetSubObjLst_CacheEx(objgs_TotalDataStatistics_Cond, strid_CurrEduCls) {
        var arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatisticsEx_GetObjLst_Cache(strid_CurrEduCls);
        var arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatisticsObjLst_Cache.filter(x => true);
        if (objgs_TotalDataStatistics_Cond.sf_FldComparisonOp == null || objgs_TotalDataStatistics_Cond.sf_FldComparisonOp == "")
            return arrgs_TotalDataStatistics_Sel;
        var dicFldComparisonOp = JSON.parse(objgs_TotalDataStatistics_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TotalDataStatisticsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objgs_TotalDataStatistics_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objgs_TotalDataStatistics_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrgs_TotalDataStatistics_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objgs_TotalDataStatistics_Cond)}]缓存对象列表中获取子集对象不成功!`;
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TotalDataStatisticsEx_GetSubObjLst_CacheEx = gs_TotalDataStatisticsEx_GetSubObjLst_CacheEx;
    ;
    /// <summary>
    /// 根据条件获取是否存在相应的记录？
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>是否存在记录？</returns>
    function gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync(strId_CurrEduCls, updUser) {
        var strAction = "GetTotalStatisticsByTable";
        let strUrl = gs_TotalDataStatisticsEx_GetWebApiUrl(exports.gs_TotalDataStatisticsEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strId_CurrEduCls", strId_CurrEduCls);
        mapParam.add("updUser", updUser);
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
    exports.gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync = gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync;
    ;
    //子数据表添加修改删除、总数据表做出相应的添加修改删除、3个参数(主键，字表类型、页面操作类型123；)、string strTablekey, string strTotalDataTypeId, string PageTypeId
    function gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strTablekey, strTotalDataTypeId, PageTypeId, Id_CurrEduCls) {
        var strAction = "AddAndUpdateAndDeleteTotalStatis";
        let strUrl = gs_TotalDataStatisticsEx_GetWebApiUrl(exports.gs_TotalDataStatisticsEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strTablekey", strTablekey);
        mapParam.add("strTotalDataTypeId", strTotalDataTypeId);
        mapParam.add("PageTypeId", PageTypeId);
        mapParam.add("Id_CurrEduCls", Id_CurrEduCls);
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
    exports.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis = gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis;
    ;
    //获取总表统计 各类型表数据的 教师打分 、学生打分数据；
    function gs_TotalDataStatisticsEx_GetObjLstEx(strWhereCond) {
        var strAction = "GetObjLstEx";
        let strUrl = gs_TotalDataStatisticsEx_GetWebApiUrl(exports.gs_TotalDataStatisticsEx_Controller, strAction);
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
    exports.gs_TotalDataStatisticsEx_GetObjLstEx = gs_TotalDataStatisticsEx_GetObjLstEx;
    ;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    /// </summary>
    /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
    /// <returns>获取的相应记录对象列表</returns>
    function gs_TotalDataStatisticsEx_GetObjLstByPagerAsyncEx(objPagerPara) {
        var strAction = "GetObjLstByPagerEx";
        let strUrl = gs_TotalDataStatisticsEx_GetWebApiUrl(exports.gs_TotalDataStatisticsEx_Controller, strAction);
        var mapParam = stuPagerPara_js_1.stuPagerPara.GetMapParam(objPagerPara);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objPagerPara,
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
    exports.gs_TotalDataStatisticsEx_GetObjLstByPagerAsyncEx = gs_TotalDataStatisticsEx_GetObjLstByPagerAsyncEx;
    ;
});
