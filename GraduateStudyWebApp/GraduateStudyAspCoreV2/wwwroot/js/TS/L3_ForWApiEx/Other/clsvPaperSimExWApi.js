var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsvPaperSimEN.js", "../../L0_Entity/GraduateEduPaper/clsvPaperSimENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsvPaperSimWApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperSimEx_GetObjLstByPagerById_CurrEduCls_Cache = exports.vPaperSimEx_GetRecCountByCondById_CurrEduCls_Cache = exports.vPaperSimEx_GetSubObjLstById_CurrEduCls_Cache = exports.vPaperSimEx_GetObjLstById_CurrEduCls_sessionStorage = exports.vPaperSimEx_GetObjLstById_CurrEduCls_localStorage = exports.vPaperSimEx_GetObjLstById_CurrEduCls_ClientCache = exports.vPaperSimEx_GetObjLstById_CurrEduCls_Cache = exports.vPaperSimEx_ReFreshThisCacheById_CurrEduCls = exports.vPaperSimEx_GetObjByPaperId_Cache = exports.vPaperSimEx_GetObjLstById_CurrEduCls = exports.vPaperSimEx_FilterFunByKey = exports.vPaperSimEx_FuncMapByFldName = exports.vPaperSimEx_SortFunByKey = exports.vPaperSimEx_GetObjExLstByPagerAsync = exports.vPaperSimEx_GetObjExLstByPager_Cache = exports.vPaperSimEx_CopyToEx = exports.vPaperSimEx_GetWebApiUrl = exports.vPaperSimEx_ConstructorName = exports.vPaperSimEx_Controller = void 0;
    /// <summary>
    /// 论文简化视图(vPaperSim)
    /// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by pyf on 2021年06月11日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const axios_1 = __importDefault(require("axios"));
    const clsvPaperSimEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperSimEN.js");
    const clsvPaperSimENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperSimENEx.js");
    const clsvPaperSimWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsvPaperSimWApi.js");
    //import * as QQ from "q";
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.vPaperSimEx_Controller = "vPaperSimExApi";
    exports.vPaperSimEx_ConstructorName = "vPaperSimEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vPaperSimEx_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperSimEx_GetWebApiUrl = vPaperSimEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvPaperSimENS:源对象
    * @returns 目标对象=>clsvPaperSimEN:objvPaperSimENT
    **/
    function vPaperSimEx_CopyToEx(objvPaperSimENS) {
        const strThisFuncName = vPaperSimEx_CopyToEx.name;
        const objvPaperSimENT = new clsvPaperSimENEx_js_1.clsvPaperSimENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperSimENT, objvPaperSimENS);
            return objvPaperSimENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vPaperSimEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvPaperSimENT;
        }
    }
    exports.vPaperSimEx_CopyToEx = vPaperSimEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperSimEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvPaperSimObjLst = await (0, clsvPaperSimWApi_js_1.vPaperSim_GetObjLst_Cache)();
        const arrvPaperSimExObjLst = arrvPaperSimObjLst.map(vPaperSimEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvPaperSimExObjLst) {
                const conFuncMap = await vPaperSimEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvPaperSimExObjLst.length == 0)
            return arrvPaperSimExObjLst;
        let arrvPaperSim_Sel = arrvPaperSimExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvPaperSim_Cond = new clsvPaperSimENEx_js_1.clsvPaperSimENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperSim_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperSimWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperSim_Sel.length == 0)
                return arrvPaperSim_Sel;
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
                arrvPaperSim_Sel = arrvPaperSim_Sel.sort(vPaperSimEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaperSim_Sel = arrvPaperSim_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaperSim_Sel = arrvPaperSim_Sel.slice(intStart, intEnd);
            return arrvPaperSim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperSimEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperSimEx_GetObjExLstByPager_Cache = vPaperSimEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperSimEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvPaperSimExObjLst = await (0, clsvPaperSimWApi_js_1.vPaperSim_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvPaperSimExObjLst) {
                const conFuncMap = await vPaperSimEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvPaperSimExObjLst.length == 0)
            return arrvPaperSimExObjLst;
        let arrvPaperSim_Sel = arrvPaperSimExObjLst;
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
                arrvPaperSim_Sel = arrvPaperSim_Sel.sort(vPaperSimEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaperSim_Sel = arrvPaperSim_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaperSim_Sel = arrvPaperSim_Sel.slice(intStart, intEnd);
            return arrvPaperSim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperSimEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperSimEx_GetObjExLstByPagerAsync = vPaperSimEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSimEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvPaperSimWApi_js_1.vPaperSim_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvPaperSimWApi_js_1.vPaperSim_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vPaperSimEx_SortFunByKey = vPaperSimEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vPaperSimEx_FuncMapByFldName(strFldName, objvPaperSimEx) {
        const strThisFuncName = vPaperSimEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvPaperSimEN_js_1.clsvPaperSimEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vPaperSimEx_FuncMapByFldName = vPaperSimEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperSimEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvPaperSimWApi_js_1.vPaperSim_FilterFunByKey)(strKey, value);
        }
    }
    exports.vPaperSimEx_FilterFunByKey = vPaperSimEx_FilterFunByKey;
    /// <summary>
    /// 根据教学班获取对象列表，用对象列表表示
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    /// </summary>
    /// <param name = "strId_CurrEduCls">教学班流水号</param>
    /// <returns>获取的相应对象列表</returns>
    async function vPaperSimEx_GetObjLstById_CurrEduCls(strId_CurrEduCls) {
        const strThisFuncName = "GetObjLstById_CurrEduCls";
        var strAction = "GetObjLstById_CurrEduCls";
        let strUrl = vPaperSimEx_GetWebApiUrl(exports.vPaperSimEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strId_CurrEduCls": strId_CurrEduCls }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSimEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = (0, clsvPaperSimWApi_js_1.vPaperSim_GetObjLstByJSONObjLst)(returnObjLst);
                return (arrObjLst);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSimEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSimEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSimEx_GetObjLstById_CurrEduCls = vPaperSimEx_GetObjLstById_CurrEduCls;
    /// <summary>
    /// 根据关键字获取相关对象, 从缓存中获取.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
    /// </summary>
    /// <param name = "strPaperId">所给的关键字</param>
    /// <returns>对象</returns>
    async function vPaperSimEx_GetObjByPaperId_Cache(strPaperId, strid_CurrEduCls) {
        var arrvPaperSimObjLst_Cache = await vPaperSimEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        var obj = new clsvPaperSimEN_js_1.clsvPaperSimEN();
        try {
            var arrvPaperSim_Sel = arrvPaperSimObjLst_Cache.filter(x => x.paperId == strPaperId);
            var objvPaperSim;
            if (arrvPaperSim_Sel.length > 0) {
                objvPaperSim = arrvPaperSim_Sel[0];
                return objvPaperSim;
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
    exports.vPaperSimEx_GetObjByPaperId_Cache = vPaperSimEx_GetObjByPaperId_Cache;
    ;
    /// <summary>
    /// 刷新本类中的缓存.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    /// </summary>
    async function vPaperSimEx_ReFreshThisCacheById_CurrEduCls(strid_CurrEduCls) {
        var strMsg = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            var strKey = `${clsvPaperSimEN_js_1.clsvPaperSimEN._CurrTabName}_${strid_CurrEduCls}`;
            switch (clsvPaperSimEN_js_1.clsvPaperSimEN.CacheModeId) {
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
    exports.vPaperSimEx_ReFreshThisCacheById_CurrEduCls = vPaperSimEx_ReFreshThisCacheById_CurrEduCls;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vPaperSimEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls) {
        var arrvPaperSimObjLst_Cache;
        switch (clsvPaperSimEN_js_1.clsvPaperSimEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperSimObjLst_Cache = await vPaperSimEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvPaperSimObjLst_Cache = await vPaperSimEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvPaperSimObjLst_Cache = await vPaperSimEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvPaperSimObjLst_Cache = await vPaperSimEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls);
                break;
        }
        return arrvPaperSimObjLst_Cache;
    }
    exports.vPaperSimEx_GetObjLstById_CurrEduCls_Cache = vPaperSimEx_GetObjLstById_CurrEduCls_Cache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vPaperSimEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsvPaperSimEN_js_1.clsvPaperSimEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            var arrvPaperSimObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            return arrvPaperSimObjLst_Cache;
        }
        try {
            const responseText = await vPaperSimEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
            var arrvPaperSimObjLst = responseText;
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvPaperSimObjLst);
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrvPaperSimObjLst.length}!`;
            console.log(strInfo);
            return arrvPaperSimObjLst;
        }
        catch (e) {
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperSimEx_GetObjLstById_CurrEduCls_ClientCache = vPaperSimEx_GetObjLstById_CurrEduCls_ClientCache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vPaperSimEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsvPaperSimEN_js_1.clsvPaperSimEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            var strTempObjLst = localStorage.getItem(strKey);
            var arrvPaperSimObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperSimObjLst_Cache;
        }
        try {
            const responseText = await vPaperSimEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
            var arrvPaperSimObjLst = responseText;
            localStorage.setItem(strKey, JSON.stringify(arrvPaperSimObjLst));
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrvPaperSimObjLst.length}!`;
            console.log(strInfo);
            return arrvPaperSimObjLst;
        }
        catch (e) {
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperSimEx_GetObjLstById_CurrEduCls_localStorage = vPaperSimEx_GetObjLstById_CurrEduCls_localStorage;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vPaperSimEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsvPaperSimEN_js_1.clsvPaperSimEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            var strTempObjLst = sessionStorage.getItem(strKey);
            var arrvPaperSimObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperSimObjLst_Cache;
        }
        try {
            const responseText = await vPaperSimEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
            var arrvPaperSimObjLst = responseText;
            sessionStorage.setItem(strKey, JSON.stringify(arrvPaperSimObjLst));
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrvPaperSimObjLst.length}!`;
            console.log(strInfo);
            return arrvPaperSimObjLst;
        }
        catch (e) {
            var strMsg = `从缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperSimEx_GetObjLstById_CurrEduCls_sessionStorage = vPaperSimEx_GetObjLstById_CurrEduCls_sessionStorage;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取子集.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
    /// </summary>
    /// <param name = "objstrSubViewpointId_Cond">条件对象</param>
    /// <returns>对象列表子集</returns>
    async function vPaperSimEx_GetSubObjLstById_CurrEduCls_Cache(objvPaperSim_Cond, strid_CurrEduCls) {
        var arrvPaperSimObjLst_Cache = await vPaperSimEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        var arrvPaperSim_Sel = arrvPaperSimObjLst_Cache.filter(x => true);
        if (objvPaperSim_Cond.sf_FldComparisonOp == null || objvPaperSim_Cond.sf_FldComparisonOp == "")
            return arrvPaperSim_Sel;
        var dicFldComparisonOp = JSON.parse(objvPaperSim_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperSimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperSim_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objvPaperSim_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrvPaperSim_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objvPaperSim_Cond)}]缓存对象列表中获取子集对象不成功!`;
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperSimEx_GetSubObjLstById_CurrEduCls_Cache = vPaperSimEx_GetSubObjLstById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取记录数.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
    /// </summary>
    /// <param name = "objvPaperSim_Cond">条件对象</param>
    /// <returns>对象列表记录数</returns>
    async function vPaperSimEx_GetRecCountByCondById_CurrEduCls_Cache(objvPaperSim_Cond, strid_CurrEduCls) {
        var arrvPaperSimObjLst_Cache = await vPaperSimEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        var arrvPaperSim_Sel = arrvPaperSimObjLst_Cache.filter(x => true);
        if (objvPaperSim_Cond.sf_FldComparisonOp == null || objvPaperSim_Cond.sf_FldComparisonOp == "")
            return arrvPaperSim_Sel.length;
        var dicFldComparisonOp = JSON.parse(objvPaperSim_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperSimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperSim_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objvPaperSim_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrvPaperSim_Sel.length;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objvPaperSim_Cond)}]从缓存对象列表中获取记录数不成功!`;
            console.error(strMsg);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vPaperSimEx_GetRecCountByCondById_CurrEduCls_Cache = vPaperSimEx_GetRecCountByCondById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 从缓存中获取分页对象列表.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
    /// </summary>
    /// <param name = "objPagerPara">分页参数结构</param>
    /// <returns>对象列表</returns>
    async function vPaperSimEx_GetObjLstByPagerById_CurrEduCls_Cache(objPagerPara, strid_CurrEduCls) {
        var arrvPaperSimObjLst_Cache = await vPaperSimEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        if (arrvPaperSimObjLst_Cache.length == 0)
            return arrvPaperSimObjLst_Cache;
        var arrvPaperSim_Sel = arrvPaperSimObjLst_Cache.filter(x => true);
        var obj_Cond = JSON.parse(objPagerPara.whereCond);
        var dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperSimWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] != null);
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
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperSim_Sel.length == 0)
                return arrvPaperSim_Sel;
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
                //                console.log(arrvPaperSim_Sel);
                let objFirst = arrvPaperSim_Sel[0]; //第一个对象
                let strSortValue = objFirst[strSortFld]; //第一个对象排序字段值            
                let strSortFldType = typeof (strSortValue); //排序字段值的数据类型
                //console.log("排序字段的数据类型: " + strSortFldType);
                switch (strSortFldType) {
                    case "string":
                        if (strSortType.toLowerCase() == "asc") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
                        }
                        else {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
                        }
                        break;
                    case "number":
                    case "boolean":
                        if (strSortType.toLowerCase() == "asc") {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.sort((x, y) => x[strSortFld] - y[strSortFld]);
                        }
                        else {
                            arrvPaperSim_Sel = arrvPaperSim_Sel.sort((x, y) => y[strSortFld] - x[strSortFld]);
                        }
                        break;
                }
            }
            else {
                //如果排序字段名[orderBy]为空，就调用排序函数
                arrvPaperSim_Sel = arrvPaperSim_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaperSim_Sel = arrvPaperSim_Sel.slice(intStart, intEnd);
            return arrvPaperSim_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${objPagerPara.whereCond}]获取分页对象列表不成功!(In vPaperSim_GetObjLstByPager_Cache)`;
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperSimEx_GetObjLstByPagerById_CurrEduCls_Cache = vPaperSimEx_GetObjLstByPagerById_CurrEduCls_Cache;
    ;
});
