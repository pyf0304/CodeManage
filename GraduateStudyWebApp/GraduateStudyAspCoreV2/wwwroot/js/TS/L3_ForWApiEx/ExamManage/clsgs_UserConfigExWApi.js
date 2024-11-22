/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_UserConfigWApi
表名:gs_UserConfig(01120693)
生成代码版本:2020.06.27.2
生成日期:2020/07/06 20:43:16
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:考试管理
模块英文名:ExamManage
框架-层名:WA_访问层(WA_Access)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == ==
*/
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "axios", "../../L0_Entity/ExamManage/clsgs_UserConfigEN.js", "../../L0_Entity/ExamManage/clsgs_UserConfigENEx.js", "../../L3_ForWApi/ExamManage/clsgs_UserConfigWApi.js", "../../L3_ForWApi/ExamManage/clsvgs_UserConfigWApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsStackTrace.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/tzDictionary.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_UserConfigEx_ReFreshThisCache = exports.gs_UserConfigEx_ReFreshCache = exports.gs_UserConfigEx_GetAddConfig = exports.gs_UserConfigEx_GetNewReturnShareIdEx = exports.gs_UserConfigEx_FilterFunByKey = exports.gs_UserConfigEx_FuncMapByFldName = exports.gs_UserConfigEx_SortFunByKey = exports.gs_UserConfigEx_GetObjExLstByPagerAsync = exports.gs_UserConfigEx_GetObjExLstByPager_Cache = exports.gs_UserConfigEx_CopyToEx = exports.gs_UserConfigEx_GetWebApiUrl = exports.gs_UserConfigEx_ConstructorName = exports.gs_UserConfigEx_Controller = void 0;
    /// <summary>
    /// 用户配置(gs_UserConfig)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2020年07月06日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const axios_1 = __importDefault(require("axios"));
    const clsgs_UserConfigEN_js_1 = require("../../L0_Entity/ExamManage/clsgs_UserConfigEN.js");
    const clsgs_UserConfigENEx_js_1 = require("../../L0_Entity/ExamManage/clsgs_UserConfigENEx.js");
    const clsgs_UserConfigWApi_js_1 = require("../../L3_ForWApi/ExamManage/clsgs_UserConfigWApi.js");
    const clsvgs_UserConfigWApi_js_1 = require("../../L3_ForWApi/ExamManage/clsvgs_UserConfigWApi.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsStackTrace_js_1 = require("../../PubFun/clsStackTrace.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    var ResponseData;
    exports.gs_UserConfigEx_Controller = "gs_UserConfigExApi";
    exports.gs_UserConfigEx_ConstructorName = "gs_UserConfigEx";
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
     **/
    function gs_UserConfigEx_GetWebApiUrl(strController, strAction) {
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
    exports.gs_UserConfigEx_GetWebApiUrl = gs_UserConfigEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objgs_UserConfigENS:源对象
    * @returns 目标对象=>clsgs_UserConfigEN:objgs_UserConfigENT
    **/
    function gs_UserConfigEx_CopyToEx(objgs_UserConfigENS) {
        const strThisFuncName = gs_UserConfigEx_CopyToEx.name;
        const objgs_UserConfigENT = new clsgs_UserConfigENEx_js_1.clsgs_UserConfigENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_UserConfigENT, objgs_UserConfigENS);
            return objgs_UserConfigENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.gs_UserConfigEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objgs_UserConfigENT;
        }
    }
    exports.gs_UserConfigEx_CopyToEx = gs_UserConfigEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_UserConfigEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_UserConfigObjLst = await (0, clsgs_UserConfigWApi_js_1.gs_UserConfig_GetObjLst_Cache)();
        const arrgs_UserConfigExObjLst = arrgs_UserConfigObjLst.map(gs_UserConfigEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_UserConfigExObjLst) {
                const conFuncMap = await gs_UserConfigEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_UserConfigExObjLst.length == 0)
            return arrgs_UserConfigExObjLst;
        let arrgs_UserConfig_Sel = arrgs_UserConfigExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_UserConfig_Cond = new clsgs_UserConfigENEx_js_1.clsgs_UserConfigENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_UserConfig_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_UserConfigWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_UserConfig_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_UserConfig_Sel.length == 0)
                return arrgs_UserConfig_Sel;
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
                arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.sort(gs_UserConfigEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.slice(intStart, intEnd);
            return arrgs_UserConfig_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_UserConfigEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_UserConfigEx_GetObjExLstByPager_Cache = gs_UserConfigEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_UserConfigEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrgs_UserConfigExObjLst = await (0, clsgs_UserConfigWApi_js_1.gs_UserConfig_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_UserConfigExObjLst) {
                const conFuncMap = await gs_UserConfigEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_UserConfigExObjLst.length == 0)
            return arrgs_UserConfigExObjLst;
        let arrgs_UserConfig_Sel = arrgs_UserConfigExObjLst;
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
                arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.sort(gs_UserConfigEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_UserConfig_Sel = arrgs_UserConfig_Sel.slice(intStart, intEnd);
            return arrgs_UserConfig_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_UserConfigEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_UserConfigEx_GetObjExLstByPagerAsync = gs_UserConfigEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_UserConfigEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsgs_UserConfigWApi_js_1.gs_UserConfig_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsgs_UserConfigWApi_js_1.gs_UserConfig_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.gs_UserConfigEx_SortFunByKey = gs_UserConfigEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function gs_UserConfigEx_FuncMapByFldName(strFldName, objgs_UserConfigEx) {
        const strThisFuncName = gs_UserConfigEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsgs_UserConfigEN_js_1.clsgs_UserConfigEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.gs_UserConfigEx_FuncMapByFldName = gs_UserConfigEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_UserConfigEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsgs_UserConfigWApi_js_1.gs_UserConfig_FilterFunByKey)(strKey, value);
        }
    }
    exports.gs_UserConfigEx_FilterFunByKey = gs_UserConfigEx_FilterFunByKey;
    //export class clsgs_UserConfigExWApi {
    //    public static mstrController: string = "gs_UserConfigExApi";
    //    public static cacheModeId = "04"; //sessionStorage
    //    public objgs_UserConfigEN: clsgs_UserConfigEN = new clsgs_UserConfigEN();
    //    constructor(pobjgs_UserConfigEN: clsgs_UserConfigEN) {
    //        this.objgs_UserConfigEN = pobjgs_UserConfigEN;
    //    };
    /// <summary>
    /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    /// </summary>
    /// <param name = "objgs_UserConfigEN">需要添加的表对象</param>
    /// <returns>返回新添加记录的关键字</returns>
    async function gs_UserConfigEx_GetNewReturnShareIdEx(strConfigTypeId, strUpdUser) {
        const strThisFuncName = "";
        var strAction = "GetNewReturnShareId";
        let strUrl = gs_UserConfigEx_GetWebApiUrl(exports.gs_UserConfigEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strConfigTypeId", strConfigTypeId);
        mapParam.add("strUpdUser", strUpdUser);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strConfigTypeId": strConfigTypeId,
                    "strUpdUser": strUpdUser
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnStr;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserConfigEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserConfigEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserConfigEx_GetNewReturnShareIdEx = gs_UserConfigEx_GetNewReturnShareIdEx;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function gs_UserConfigEx_GetAddConfig(strUpdUser) {
        const strThisFuncName = "";
        var strAction = "GetAddConfigEx";
        let strUrl = gs_UserConfigEx_GetWebApiUrl(exports.gs_UserConfigEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strUpdUser": strUpdUser }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return (data.returnBool);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserConfigEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserConfigEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserConfigEx_GetAddConfig = gs_UserConfigEx_GetAddConfig;
    /// <summary>
    /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    /// </summary>
    async function gs_UserConfigEx_ReFreshCache() {
        var strMsg = `刷新缓存成功！(${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3)}->${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2)}->${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
        console.log(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        var strKey = clsgs_UserConfigEN_js_1.clsgs_UserConfigEN._CurrTabName;
        switch (clsgs_UserConfigEN_js_1.clsgs_UserConfigEN.CacheModeId) {
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
        (0, clsvgs_UserConfigWApi_js_1.vgs_UserConfig_ReFreshThisCache)();
    }
    exports.gs_UserConfigEx_ReFreshCache = gs_UserConfigEx_ReFreshCache;
    /// <summary>
    /// 刷新本类中的缓存.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    /// </summary>
    async function gs_UserConfigEx_ReFreshThisCache() {
        var strMsg = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            var strKey = clsgs_UserConfigEN_js_1.clsgs_UserConfigEN._CurrTabName;
            switch (clsgs_UserConfigEN_js_1.clsgs_UserConfigEN.CacheModeId) {
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
            strMsg = `刷新缓存成功！(${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3)}->${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2)}->${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`,
                console.log(strMsg);
        }
        else {
            strMsg = `刷新缓存已经关闭。(clsSysPara4WebApi.spSetRefreshCacheOn == false)(${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3)}->${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2)}->${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
            console.log(strMsg);
        }
    }
    exports.gs_UserConfigEx_ReFreshThisCache = gs_UserConfigEx_ReFreshThisCache;
});
