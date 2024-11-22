/**
* 类名:clsvPaperSubViewpointLikeLogWApi
* 表名:vPaperSubViewpointLikeLog(01120563)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:44:18
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:其他(Other)
* 框架-层名:WA_访问层(TS)(WA_Access)
* 编程语言:TypeScript
* 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
  *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
**/
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/Other/clsvPaperSubViewpointLikeLogEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperSubViewpointLikeLog_GetObjFromJsonObj = exports.vPaperSubViewpointLikeLog_CopyObjTo = exports.vPaperSubViewpointLikeLog_GetCombineCondition = exports.vPaperSubViewpointLikeLog_GetObjByJSONStr = exports.vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst = exports.vPaperSubViewpointLikeLog_GetObjLstByJSONStr = exports.vPaperSubViewpointLikeLog_GetJSONStrByObj = exports.vPaperSubViewpointLikeLog_ReFreshThisCache = exports.vPaperSubViewpointLikeLog_GetWebApiUrl = exports.vPaperSubViewpointLikeLog_GetRecCountByCond_Cache = exports.vPaperSubViewpointLikeLog_GetRecCountByCondAsync = exports.vPaperSubViewpointLikeLog_IsExistAsync = exports.vPaperSubViewpointLikeLog_IsExist_Cache = exports.vPaperSubViewpointLikeLog_IsExist = exports.vPaperSubViewpointLikeLog_IsExistRecordAsync = exports.vPaperSubViewpointLikeLog_IsExistRecord_Cache = exports.vPaperSubViewpointLikeLog_GetObjLstByPagerAsync = exports.vPaperSubViewpointLikeLog_GetObjLstByPager_Cache = exports.vPaperSubViewpointLikeLog_GetObjLstByRange = exports.vPaperSubViewpointLikeLog_GetObjLstByRangeAsync = exports.vPaperSubViewpointLikeLog_GetTopObjLstAsync = exports.vPaperSubViewpointLikeLog_GetObjLstByPaperSubViewpointLikeLogIdLst_Cache = exports.vPaperSubViewpointLikeLog_GetObjLstByPaperSubViewpointLikeLogIdLstAsync = exports.vPaperSubViewpointLikeLog_GetSubObjLst_Cache = exports.vPaperSubViewpointLikeLog_GetObjLst_PureCache = exports.vPaperSubViewpointLikeLog_GetObjLst_Cache = exports.vPaperSubViewpointLikeLog_GetObjLst_sessionStorage_PureCache = exports.vPaperSubViewpointLikeLog_GetObjLst_sessionStorage = exports.vPaperSubViewpointLikeLog_GetObjLstAsync = exports.vPaperSubViewpointLikeLog_GetObjLst_localStorage_PureCache = exports.vPaperSubViewpointLikeLog_GetObjLst_localStorage = exports.vPaperSubViewpointLikeLog_GetObjLst_ClientCache = exports.vPaperSubViewpointLikeLog_GetFirstObjAsync = exports.vPaperSubViewpointLikeLog_GetFirstID = exports.vPaperSubViewpointLikeLog_GetFirstIDAsync = exports.vPaperSubViewpointLikeLog_funcKey = exports.vPaperSubViewpointLikeLog_FilterFunByKey = exports.vPaperSubViewpointLikeLog_SortFunByKey = exports.vPaperSubViewpointLikeLog_SortFun_Defa_2Fld = exports.vPaperSubViewpointLikeLog_SortFun_Defa = exports.vPaperSubViewpointLikeLog_func = exports.vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_localStorage = exports.vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_Cache = exports.vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogIdAsync = exports.vPaperSubViewpointLikeLog_ConstructorName = exports.vPaperSubViewpointLikeLog_Controller = void 0;
    /**
     * v子观点点赞表(vPaperSubViewpointLikeLog)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvPaperSubViewpointLikeLogEN_js_1 = require("../../L0_Entity/Other/clsvPaperSubViewpointLikeLogEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vPaperSubViewpointLikeLog_Controller = "vPaperSubViewpointLikeLogApi";
    exports.vPaperSubViewpointLikeLog_ConstructorName = "vPaperSubViewpointLikeLog";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperSubViewpointLikeLogId:关键字
    * @returns 对象
    **/
    async function vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogIdAsync(lngPaperSubViewpointLikeLogId) {
        const strThisFuncName = "GetObjByPaperSubViewpointLikeLogIdAsync";
        if (lngPaperSubViewpointLikeLogId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperSubViewpointLikeLogId]不能为空！(In clsvPaperSubViewpointLikeLogWApi.GetObjByPaperSubViewpointLikeLogIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperSubViewpointLikeLogId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperSubViewpointLikeLogId": lngPaperSubViewpointLikeLogId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvPaperSubViewpointLikeLog = vPaperSubViewpointLikeLog_GetObjFromJsonObj(returnObj);
                return objvPaperSubViewpointLikeLog;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogIdAsync = vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngPaperSubViewpointLikeLogId:所给的关键字
     * @returns 对象
    */
    async function vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_Cache(lngPaperSubViewpointLikeLogId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPaperSubViewpointLikeLogId_Cache";
        if (lngPaperSubViewpointLikeLogId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperSubViewpointLikeLogId]不能为空！(In clsvPaperSubViewpointLikeLogWApi.GetObjByPaperSubViewpointLikeLogId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
        try {
            const arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLogObjLst_Cache.filter(x => x.paperSubViewpointLikeLogId == lngPaperSubViewpointLikeLogId);
            let objvPaperSubViewpointLikeLog;
            if (arrvPaperSubViewpointLikeLog_Sel.length > 0) {
                objvPaperSubViewpointLikeLog = arrvPaperSubViewpointLikeLog_Sel[0];
                return objvPaperSubViewpointLikeLog;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvPaperSubViewpointLikeLog_Const = await vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogIdAsync(lngPaperSubViewpointLikeLogId);
                    if (objvPaperSubViewpointLikeLog_Const != null) {
                        vPaperSubViewpointLikeLog_ReFreshThisCache();
                        return objvPaperSubViewpointLikeLog_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperSubViewpointLikeLogId, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_Cache = vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngPaperSubViewpointLikeLogId:所给的关键字
     * @returns 对象
    */
    async function vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_localStorage(lngPaperSubViewpointLikeLogId) {
        const strThisFuncName = "GetObjByPaperSubViewpointLikeLogId_localStorage";
        if (lngPaperSubViewpointLikeLogId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperSubViewpointLikeLogId]不能为空！(In clsvPaperSubViewpointLikeLogWApi.GetObjByPaperSubViewpointLikeLogId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN._CurrTabName, lngPaperSubViewpointLikeLogId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvPaperSubViewpointLikeLog_Cache = JSON.parse(strTempObj);
            return objvPaperSubViewpointLikeLog_Cache;
        }
        try {
            const objvPaperSubViewpointLikeLog = await vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogIdAsync(lngPaperSubViewpointLikeLogId);
            if (objvPaperSubViewpointLikeLog != null) {
                localStorage.setItem(strKey, JSON.stringify(objvPaperSubViewpointLikeLog));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvPaperSubViewpointLikeLog;
            }
            return objvPaperSubViewpointLikeLog;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperSubViewpointLikeLogId, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_localStorage = vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vPaperSubViewpointLikeLog_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngPaperSubViewpointLikeLogId = Number(strInValue);
        if (lngPaperSubViewpointLikeLogId == 0) {
            return "";
        }
        const objvPaperSubViewpointLikeLog = await vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_Cache(lngPaperSubViewpointLikeLogId);
        if (objvPaperSubViewpointLikeLog == null)
            return "";
        if (objvPaperSubViewpointLikeLog.GetFldValue(strOutFldName) == null)
            return "";
        return objvPaperSubViewpointLikeLog.GetFldValue(strOutFldName).toString();
    }
    exports.vPaperSubViewpointLikeLog_func = vPaperSubViewpointLikeLog_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSubViewpointLikeLog_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperSubViewpointLikeLogId - b.paperSubViewpointLikeLogId;
    }
    exports.vPaperSubViewpointLikeLog_SortFun_Defa = vPaperSubViewpointLikeLog_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSubViewpointLikeLog_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.subViewpointId == b.subViewpointId)
            return a.updDate.localeCompare(b.updDate);
        else
            return a.subViewpointId.localeCompare(b.subViewpointId);
    }
    exports.vPaperSubViewpointLikeLog_SortFun_Defa_2Fld = vPaperSubViewpointLikeLog_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSubViewpointLikeLog_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
                    return (a, b) => {
                        return a.paperSubViewpointLikeLogId - b.paperSubViewpointLikeLogId;
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_SubViewpointId:
                    return (a, b) => {
                        if (a.subViewpointId == null)
                            return -1;
                        if (b.subViewpointId == null)
                            return 1;
                        return a.subViewpointId.localeCompare(b.subViewpointId);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_RWTitle:
                    return (a, b) => {
                        if (a.rwTitle == null)
                            return -1;
                        if (b.rwTitle == null)
                            return 1;
                        return a.rwTitle.localeCompare(b.rwTitle);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_SubViewpointContent:
                    return (a, b) => {
                        if (a.subViewpointContent == null)
                            return -1;
                        if (b.subViewpointContent == null)
                            return 1;
                        return a.subViewpointContent.localeCompare(b.subViewpointContent);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_ExplainContent:
                    return (a, b) => {
                        if (a.explainContent == null)
                            return -1;
                        if (b.explainContent == null)
                            return 1;
                        return a.explainContent.localeCompare(b.explainContent);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperRWId:
                    return (a, b) => {
                        if (a.paperRWId == null)
                            return -1;
                        if (b.paperRWId == null)
                            return 1;
                        return a.paperRWId.localeCompare(b.paperRWId);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpointLikeLog]中不存在！(in ${exports.vPaperSubViewpointLikeLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
                    return (a, b) => {
                        return b.paperSubViewpointLikeLogId - a.paperSubViewpointLikeLogId;
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_SubViewpointId:
                    return (a, b) => {
                        if (b.subViewpointId == null)
                            return -1;
                        if (a.subViewpointId == null)
                            return 1;
                        return b.subViewpointId.localeCompare(a.subViewpointId);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_RWTitle:
                    return (a, b) => {
                        if (b.rwTitle == null)
                            return -1;
                        if (a.rwTitle == null)
                            return 1;
                        return b.rwTitle.localeCompare(a.rwTitle);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_SubViewpointContent:
                    return (a, b) => {
                        if (b.subViewpointContent == null)
                            return -1;
                        if (a.subViewpointContent == null)
                            return 1;
                        return b.subViewpointContent.localeCompare(a.subViewpointContent);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_ExplainContent:
                    return (a, b) => {
                        if (b.explainContent == null)
                            return -1;
                        if (a.explainContent == null)
                            return 1;
                        return b.explainContent.localeCompare(a.explainContent);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperRWId:
                    return (a, b) => {
                        if (b.paperRWId == null)
                            return -1;
                        if (a.paperRWId == null)
                            return 1;
                        return b.paperRWId.localeCompare(a.paperRWId);
                    };
                case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpointLikeLog]中不存在！(in ${exports.vPaperSubViewpointLikeLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_SortFunByKey = vPaperSubViewpointLikeLog_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperSubViewpointLikeLog_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
                return (obj) => {
                    return obj.paperSubViewpointLikeLogId === value;
                };
            case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_SubViewpointId:
                return (obj) => {
                    return obj.subViewpointId === value;
                };
            case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_RWTitle:
                return (obj) => {
                    return obj.rwTitle === value;
                };
            case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_SubViewpointContent:
                return (obj) => {
                    return obj.subViewpointContent === value;
                };
            case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_ExplainContent:
                return (obj) => {
                    return obj.explainContent === value;
                };
            case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperRWId:
                return (obj) => {
                    return obj.paperRWId === value;
                };
            case clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpointLikeLog]中不存在！(in ${exports.vPaperSubViewpointLikeLog_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vPaperSubViewpointLikeLog_FilterFunByKey = vPaperSubViewpointLikeLog_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function vPaperSubViewpointLikeLog_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrvPaperSubViewpointLikeLog = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
        if (arrvPaperSubViewpointLikeLog == null)
            return [];
        let arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvPaperSubViewpointLikeLog_Sel.length == 0)
            return [];
        return arrvPaperSubViewpointLikeLog_Sel.map(x => x.paperSubViewpointLikeLogId);
    }
    exports.vPaperSubViewpointLikeLog_funcKey = vPaperSubViewpointLikeLog_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vPaperSubViewpointLikeLog_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_GetFirstIDAsync = vPaperSubViewpointLikeLog_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vPaperSubViewpointLikeLog_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_GetFirstID = vPaperSubViewpointLikeLog_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vPaperSubViewpointLikeLog_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvPaperSubViewpointLikeLog = vPaperSubViewpointLikeLog_GetObjFromJsonObj(returnObj);
                return objvPaperSubViewpointLikeLog;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_GetFirstObjAsync = vPaperSubViewpointLikeLog_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointLikeLog_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvPaperSubViewpointLikeLogExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvPaperSubViewpointLikeLogObjLst_T = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrvPaperSubViewpointLikeLogExObjLst_Cache);
            return arrvPaperSubViewpointLikeLogObjLst_T;
        }
        try {
            const arrvPaperSubViewpointLikeLogExObjLst = await vPaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvPaperSubViewpointLikeLogExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointLikeLogExObjLst.length);
            console.log(strInfo);
            return arrvPaperSubViewpointLikeLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperSubViewpointLikeLog_GetObjLst_ClientCache = vPaperSubViewpointLikeLog_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointLikeLog_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvPaperSubViewpointLikeLogExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvPaperSubViewpointLikeLogObjLst_T = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrvPaperSubViewpointLikeLogExObjLst_Cache);
            return arrvPaperSubViewpointLikeLogObjLst_T;
        }
        try {
            const arrvPaperSubViewpointLikeLogExObjLst = await vPaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvPaperSubViewpointLikeLogExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointLikeLogExObjLst.length);
            console.log(strInfo);
            return arrvPaperSubViewpointLikeLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperSubViewpointLikeLog_GetObjLst_localStorage = vPaperSubViewpointLikeLog_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointLikeLog_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvPaperSubViewpointLikeLogObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperSubViewpointLikeLogObjLst_Cache;
        }
        else
            return null;
    }
    exports.vPaperSubViewpointLikeLog_GetObjLst_localStorage_PureCache = vPaperSubViewpointLikeLog_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vPaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_GetObjLstAsync = vPaperSubViewpointLikeLog_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointLikeLog_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvPaperSubViewpointLikeLogExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvPaperSubViewpointLikeLogObjLst_T = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrvPaperSubViewpointLikeLogExObjLst_Cache);
            return arrvPaperSubViewpointLikeLogObjLst_T;
        }
        try {
            const arrvPaperSubViewpointLikeLogExObjLst = await vPaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvPaperSubViewpointLikeLogExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointLikeLogExObjLst.length);
            console.log(strInfo);
            return arrvPaperSubViewpointLikeLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperSubViewpointLikeLog_GetObjLst_sessionStorage = vPaperSubViewpointLikeLog_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointLikeLog_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvPaperSubViewpointLikeLogObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperSubViewpointLikeLogObjLst_Cache;
        }
        else
            return null;
    }
    exports.vPaperSubViewpointLikeLog_GetObjLst_sessionStorage_PureCache = vPaperSubViewpointLikeLog_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointLikeLog_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvPaperSubViewpointLikeLogObjLst_Cache;
        switch (clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_ClientCache();
                break;
            default:
                arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_ClientCache();
                break;
        }
        const arrvPaperSubViewpointLikeLogObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrvPaperSubViewpointLikeLogObjLst_Cache);
        return arrvPaperSubViewpointLikeLogObjLst_Cache;
    }
    exports.vPaperSubViewpointLikeLog_GetObjLst_Cache = vPaperSubViewpointLikeLog_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointLikeLog_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvPaperSubViewpointLikeLogObjLst_Cache;
        switch (clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvPaperSubViewpointLikeLogObjLst_Cache = null;
                break;
            default:
                arrvPaperSubViewpointLikeLogObjLst_Cache = null;
                break;
        }
        return arrvPaperSubViewpointLikeLogObjLst_Cache;
    }
    exports.vPaperSubViewpointLikeLog_GetObjLst_PureCache = vPaperSubViewpointLikeLog_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngPaperSubViewpointLikeLogId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vPaperSubViewpointLikeLog_GetSubObjLst_Cache(objvPaperSubViewpointLikeLog_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
        let arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLogObjLst_Cache;
        if (objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == null || objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == "")
            return arrvPaperSubViewpointLikeLog_Sel;
        const dicFldComparisonOp = JSON.parse(objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperSubViewpointLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperSubViewpointLikeLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpointLikeLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvPaperSubViewpointLikeLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvPaperSubViewpointLikeLog_Cond), exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperSubViewpointLikeLog_GetSubObjLst_Cache = vPaperSubViewpointLikeLog_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperSubViewpointLikeLogId:关键字列表
    * @returns 对象列表
    **/
    async function vPaperSubViewpointLikeLog_GetObjLstByPaperSubViewpointLikeLogIdLstAsync(arrPaperSubViewpointLikeLogId) {
        const strThisFuncName = "GetObjLstByPaperSubViewpointLikeLogIdLstAsync";
        const strAction = "GetObjLstByPaperSubViewpointLikeLogIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperSubViewpointLikeLogId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
                return arrObjLst;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_GetObjLstByPaperSubViewpointLikeLogIdLstAsync = vPaperSubViewpointLikeLog_GetObjLstByPaperSubViewpointLikeLogIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngPaperSubViewpointLikeLogIdLst:关键字列表
     * @returns 对象列表
    */
    async function vPaperSubViewpointLikeLog_GetObjLstByPaperSubViewpointLikeLogIdLst_Cache(arrPaperSubViewpointLikeLogIdLst) {
        const strThisFuncName = "GetObjLstByPaperSubViewpointLikeLogIdLst_Cache";
        try {
            const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
            const arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLogObjLst_Cache.filter(x => arrPaperSubViewpointLikeLogIdLst.indexOf(x.paperSubViewpointLikeLogId) > -1);
            return arrvPaperSubViewpointLikeLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperSubViewpointLikeLogIdLst.join(","), exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vPaperSubViewpointLikeLog_GetObjLstByPaperSubViewpointLikeLogIdLst_Cache = vPaperSubViewpointLikeLog_GetObjLstByPaperSubViewpointLikeLogIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vPaperSubViewpointLikeLog_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_GetTopObjLstAsync = vPaperSubViewpointLikeLog_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperSubViewpointLikeLog_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
                return arrObjLst;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_GetObjLstByRangeAsync = vPaperSubViewpointLikeLog_GetObjLstByRangeAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRange)
     * @param intMinNum:最小记录号
     * @param intMaxNum:最大记录号
     * @param strWhereCond:给定条件
     * @param strOrderBy:排序方式
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取的相应记录对象列表
    */
    async function vPaperSubViewpointLikeLog_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "intMinNum": intMinNum,
                    "intMaxNum": intMaxNum,
                    "strWhereCond": strWhereCond,
                    "strOrderBy": strOrderBy,
                }
            });
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_GetObjLstByRange = vPaperSubViewpointLikeLog_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperSubViewpointLikeLog_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
        if (arrvPaperSubViewpointLikeLogObjLst_Cache.length == 0)
            return arrvPaperSubViewpointLikeLogObjLst_Cache;
        let arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLogObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvPaperSubViewpointLikeLog_Cond = new clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperSubViewpointLikeLog_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperSubViewpointLikeLogWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpointLikeLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperSubViewpointLikeLog_Sel.length == 0)
                return arrvPaperSubViewpointLikeLog_Sel;
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
                arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.sort(vPaperSubViewpointLikeLog_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.slice(intStart, intEnd);
            return arrvPaperSubViewpointLikeLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperSubViewpointLikeLog_GetObjLstByPager_Cache = vPaperSubViewpointLikeLog_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperSubViewpointLikeLog_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
                return arrObjLst;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_GetObjLstByPagerAsync = vPaperSubViewpointLikeLog_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngPaperSubViewpointLikeLogId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vPaperSubViewpointLikeLog_IsExistRecord_Cache(objvPaperSubViewpointLikeLog_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
        if (arrvPaperSubViewpointLikeLogObjLst_Cache == null)
            return false;
        let arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLogObjLst_Cache;
        if (objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == null || objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == "")
            return arrvPaperSubViewpointLikeLog_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperSubViewpointLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperSubViewpointLikeLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpointLikeLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperSubViewpointLikeLog_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvPaperSubViewpointLikeLog_Cond), exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vPaperSubViewpointLikeLog_IsExistRecord_Cache = vPaperSubViewpointLikeLog_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vPaperSubViewpointLikeLog_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnBool;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_IsExistRecordAsync = vPaperSubViewpointLikeLog_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperSubViewpointLikeLogId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vPaperSubViewpointLikeLog_IsExist(lngPaperSubViewpointLikeLogId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperSubViewpointLikeLogId": lngPaperSubViewpointLikeLogId,
                }
            });
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_IsExist = vPaperSubViewpointLikeLog_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngPaperSubViewpointLikeLogId:所给的关键字
     * @returns 对象
    */
    async function vPaperSubViewpointLikeLog_IsExist_Cache(lngPaperSubViewpointLikeLogId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
        if (arrvPaperSubViewpointLikeLogObjLst_Cache == null)
            return false;
        try {
            const arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLogObjLst_Cache.filter(x => x.paperSubViewpointLikeLogId == lngPaperSubViewpointLikeLogId);
            if (arrvPaperSubViewpointLikeLog_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperSubViewpointLikeLogId, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vPaperSubViewpointLikeLog_IsExist_Cache = vPaperSubViewpointLikeLog_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperSubViewpointLikeLogId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vPaperSubViewpointLikeLog_IsExistAsync(lngPaperSubViewpointLikeLogId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperSubViewpointLikeLogId": lngPaperSubViewpointLikeLogId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_IsExistAsync = vPaperSubViewpointLikeLog_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vPaperSubViewpointLikeLog_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnInt;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointLikeLog_GetRecCountByCondAsync = vPaperSubViewpointLikeLog_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvPaperSubViewpointLikeLog_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vPaperSubViewpointLikeLog_GetRecCountByCond_Cache(objvPaperSubViewpointLikeLog_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
        if (arrvPaperSubViewpointLikeLogObjLst_Cache == null)
            return 0;
        let arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLogObjLst_Cache;
        if (objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == null || objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == "")
            return arrvPaperSubViewpointLikeLog_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperSubViewpointLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperSubViewpointLikeLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpointLikeLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvPaperSubViewpointLikeLog_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvPaperSubViewpointLikeLog_Cond), exports.vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vPaperSubViewpointLikeLog_GetRecCountByCond_Cache = vPaperSubViewpointLikeLog_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vPaperSubViewpointLikeLog_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperSubViewpointLikeLog_GetWebApiUrl = vPaperSubViewpointLikeLog_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vPaperSubViewpointLikeLog_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN._CurrTabName;
            switch (clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.CacheModeId) {
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
            const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_1.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.vPaperSubViewpointLikeLog_ReFreshThisCache = vPaperSubViewpointLikeLog_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperSubViewpointLikeLog_GetJSONStrByObj(pobjvPaperSubViewpointLikeLogEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvPaperSubViewpointLikeLogEN);
        }
        catch (objException) {
            const strEx = (0, clsCommFunc4Web_js_1.GetExceptionStr)(objException);
            (0, clsCommFunc4Web_js_1.myShowErrorMsg)(strEx);
        }
        if (strJson == undefined)
            return "";
        else
            return strJson;
    }
    exports.vPaperSubViewpointLikeLog_GetJSONStrByObj = vPaperSubViewpointLikeLog_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vPaperSubViewpointLikeLog_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvPaperSubViewpointLikeLogObjLst = new Array();
        if (strJSON === "") {
            return arrvPaperSubViewpointLikeLogObjLst;
        }
        try {
            arrvPaperSubViewpointLikeLogObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvPaperSubViewpointLikeLogObjLst;
        }
        return arrvPaperSubViewpointLikeLogObjLst;
    }
    exports.vPaperSubViewpointLikeLog_GetObjLstByJSONStr = vPaperSubViewpointLikeLog_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvPaperSubViewpointLikeLogObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrvPaperSubViewpointLikeLogObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvPaperSubViewpointLikeLogObjLst = new Array();
        for (const objInFor of arrvPaperSubViewpointLikeLogObjLstS) {
            const obj1 = vPaperSubViewpointLikeLog_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvPaperSubViewpointLikeLogObjLst.push(obj1);
        }
        return arrvPaperSubViewpointLikeLogObjLst;
    }
    exports.vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperSubViewpointLikeLog_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN();
        if (strJSON === "") {
            return pobjvPaperSubViewpointLikeLogEN;
        }
        try {
            pobjvPaperSubViewpointLikeLogEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvPaperSubViewpointLikeLogEN;
        }
        return pobjvPaperSubViewpointLikeLogEN;
    }
    exports.vPaperSubViewpointLikeLog_GetObjByJSONStr = vPaperSubViewpointLikeLog_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vPaperSubViewpointLikeLog_GetCombineCondition(objvPaperSubViewpointLikeLog_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId) == true) {
            const strComparisonOp_PaperSubViewpointLikeLogId = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId, objvPaperSubViewpointLikeLog_Cond.paperSubViewpointLikeLogId, strComparisonOp_PaperSubViewpointLikeLogId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_SubViewpointId) == true) {
            const strComparisonOp_SubViewpointId = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_SubViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_SubViewpointId, objvPaperSubViewpointLikeLog_Cond.subViewpointId, strComparisonOp_SubViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_UpdDate, objvPaperSubViewpointLikeLog_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_Memo, objvPaperSubViewpointLikeLog_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_RWTitle) == true) {
            const strComparisonOp_RWTitle = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_RWTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_RWTitle, objvPaperSubViewpointLikeLog_Cond.rwTitle, strComparisonOp_RWTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_ExplainContent) == true) {
            const strComparisonOp_ExplainContent = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_ExplainContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_ExplainContent, objvPaperSubViewpointLikeLog_Cond.explainContent, strComparisonOp_ExplainContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperRWId) == true) {
            const strComparisonOp_PaperRWId = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperRWId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_PaperRWId, objvPaperSubViewpointLikeLog_Cond.paperRWId, strComparisonOp_PaperRWId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN.con_UpdUser, objvPaperSubViewpointLikeLog_Cond.updUser, strComparisonOp_UpdUser);
        }
        return strWhereCond;
    }
    exports.vPaperSubViewpointLikeLog_GetCombineCondition = vPaperSubViewpointLikeLog_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvPaperSubViewpointLikeLogENS:源对象
     * @param objvPaperSubViewpointLikeLogENT:目标对象
    */
    function vPaperSubViewpointLikeLog_CopyObjTo(objvPaperSubViewpointLikeLogENS, objvPaperSubViewpointLikeLogENT) {
        objvPaperSubViewpointLikeLogENT.paperSubViewpointLikeLogId = objvPaperSubViewpointLikeLogENS.paperSubViewpointLikeLogId; //点赞Id
        objvPaperSubViewpointLikeLogENT.subViewpointId = objvPaperSubViewpointLikeLogENS.subViewpointId; //子观点Id
        objvPaperSubViewpointLikeLogENT.updDate = objvPaperSubViewpointLikeLogENS.updDate; //修改日期
        objvPaperSubViewpointLikeLogENT.memo = objvPaperSubViewpointLikeLogENS.memo; //备注
        objvPaperSubViewpointLikeLogENT.rwTitle = objvPaperSubViewpointLikeLogENS.rwTitle; //读写标题
        objvPaperSubViewpointLikeLogENT.subViewpointContent = objvPaperSubViewpointLikeLogENS.subViewpointContent; //详情内容
        objvPaperSubViewpointLikeLogENT.explainContent = objvPaperSubViewpointLikeLogENS.explainContent; //说明内容
        objvPaperSubViewpointLikeLogENT.paperRWId = objvPaperSubViewpointLikeLogENS.paperRWId; //课文阅读
        objvPaperSubViewpointLikeLogENT.updUser = objvPaperSubViewpointLikeLogENS.updUser; //修改人
    }
    exports.vPaperSubViewpointLikeLog_CopyObjTo = vPaperSubViewpointLikeLog_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvPaperSubViewpointLikeLogENS:源对象
     * @param objvPaperSubViewpointLikeLogENT:目标对象
    */
    function vPaperSubViewpointLikeLog_GetObjFromJsonObj(objvPaperSubViewpointLikeLogENS) {
        const objvPaperSubViewpointLikeLogENT = new clsvPaperSubViewpointLikeLogEN_js_1.clsvPaperSubViewpointLikeLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperSubViewpointLikeLogENT, objvPaperSubViewpointLikeLogENS);
        return objvPaperSubViewpointLikeLogENT;
    }
    exports.vPaperSubViewpointLikeLog_GetObjFromJsonObj = vPaperSubViewpointLikeLog_GetObjFromJsonObj;
});
