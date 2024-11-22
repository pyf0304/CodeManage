/**
* 类名:clsPaperLikeLogWApi
* 表名:PaperLikeLog(01120566)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:54:10
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/Other/clsPaperLikeLogEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperLikeLog_GetObjFromJsonObj = exports.PaperLikeLog_CopyObjTo = exports.PaperLikeLog_GetUniCondStr4Update_PaperId_UpdUser = exports.PaperLikeLog_GetUniCondStr_PaperId_UpdUser = exports.PaperLikeLog_GetCombineCondition = exports.PaperLikeLog_GetObjByJSONStr = exports.PaperLikeLog_GetObjLstByJSONObjLst = exports.PaperLikeLog_GetObjLstByJSONStr = exports.PaperLikeLog_GetJSONStrByObj = exports.PaperLikeLog_CheckProperty4Update = exports.PaperLikeLog_CheckPropertyNew = exports.PaperLikeLog_ReFreshThisCache = exports.PaperLikeLog_ReFreshCache = exports.PaperLikeLog_GetWebApiUrl = exports.PaperLikeLog_GetMaxStrIdByPrefix = exports.PaperLikeLog_GetRecCountByCond_Cache = exports.PaperLikeLog_GetRecCountByCondAsync = exports.PaperLikeLog_IsExistAsync = exports.PaperLikeLog_IsExist_Cache = exports.PaperLikeLog_IsExist = exports.PaperLikeLog_IsExistRecordAsync = exports.PaperLikeLog_IsExistRecord_Cache = exports.PaperLikeLog_UpdateWithConditionAsync = exports.PaperLikeLog_UpdateRecordAsync = exports.PaperLikeLog_AddNewRecordWithReturnKey = exports.PaperLikeLog_AddNewRecordWithReturnKeyAsync = exports.PaperLikeLog_AddNewRecordAsync = exports.PaperLikeLog_DelPaperLikeLogsByCondAsync = exports.PaperLikeLog_DelPaperLikeLogsAsync = exports.PaperLikeLog_DelRecordAsync = exports.PaperLikeLog_GetObjLstByPagerAsync = exports.PaperLikeLog_GetObjLstByPager_Cache = exports.PaperLikeLog_GetObjLstByRange = exports.PaperLikeLog_GetObjLstByRangeAsync = exports.PaperLikeLog_GetTopObjLstAsync = exports.PaperLikeLog_GetObjLstByPaperLikeLogIdLst_Cache = exports.PaperLikeLog_GetObjLstByPaperLikeLogIdLstAsync = exports.PaperLikeLog_GetSubObjLst_Cache = exports.PaperLikeLog_GetObjLst_PureCache = exports.PaperLikeLog_GetObjLst_Cache = exports.PaperLikeLog_GetObjLst_sessionStorage_PureCache = exports.PaperLikeLog_GetObjLst_sessionStorage = exports.PaperLikeLog_GetObjLstAsync = exports.PaperLikeLog_GetObjLst_localStorage_PureCache = exports.PaperLikeLog_GetObjLst_localStorage = exports.PaperLikeLog_GetObjLst_ClientCache = exports.PaperLikeLog_GetFirstObjAsync = exports.PaperLikeLog_GetFirstID = exports.PaperLikeLog_GetFirstIDAsync = exports.PaperLikeLog_funcKey = exports.PaperLikeLog_FilterFunByKey = exports.PaperLikeLog_SortFunByKey = exports.PaperLikeLog_SortFun_Defa_2Fld = exports.PaperLikeLog_SortFun_Defa = exports.PaperLikeLog_func = exports.PaperLikeLog_UpdateObjInLst_Cache = exports.PaperLikeLog_GetObjByPaperLikeLogId_localStorage = exports.PaperLikeLog_GetObjByPaperLikeLogId_Cache = exports.PaperLikeLog_GetObjByPaperLikeLogIdAsync = exports.paperLikeLog_ConstructorName = exports.paperLikeLog_Controller = void 0;
    /**
     * 论文点赞表(PaperLikeLog)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsPaperLikeLogEN_js_1 = require("../../L0_Entity/Other/clsPaperLikeLogEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.paperLikeLog_Controller = "PaperLikeLogApi";
    exports.paperLikeLog_ConstructorName = "paperLikeLog";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperLikeLogId:关键字
    * @returns 对象
    **/
    async function PaperLikeLog_GetObjByPaperLikeLogIdAsync(lngPaperLikeLogId) {
        const strThisFuncName = "GetObjByPaperLikeLogIdAsync";
        if (lngPaperLikeLogId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngPaperLikeLogId]不能为空！(In clsPaperLikeLogWApi.GetObjByPaperLikeLogIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperLikeLogId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperLikeLogId": lngPaperLikeLogId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objPaperLikeLog = PaperLikeLog_GetObjFromJsonObj(returnObj);
                return objPaperLikeLog;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_GetObjByPaperLikeLogIdAsync = PaperLikeLog_GetObjByPaperLikeLogIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngPaperLikeLogId:所给的关键字
     * @returns 对象
    */
    async function PaperLikeLog_GetObjByPaperLikeLogId_Cache(lngPaperLikeLogId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPaperLikeLogId_Cache";
        if (lngPaperLikeLogId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngPaperLikeLogId]不能为空！(In clsPaperLikeLogWApi.GetObjByPaperLikeLogId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
        try {
            const arrPaperLikeLog_Sel = arrPaperLikeLogObjLst_Cache.filter(x => x.paperLikeLogId == lngPaperLikeLogId);
            let objPaperLikeLog;
            if (arrPaperLikeLog_Sel.length > 0) {
                objPaperLikeLog = arrPaperLikeLog_Sel[0];
                return objPaperLikeLog;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objPaperLikeLog_Const = await PaperLikeLog_GetObjByPaperLikeLogIdAsync(lngPaperLikeLogId);
                    if (objPaperLikeLog_Const != null) {
                        PaperLikeLog_ReFreshThisCache();
                        return objPaperLikeLog_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperLikeLogId, exports.paperLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.PaperLikeLog_GetObjByPaperLikeLogId_Cache = PaperLikeLog_GetObjByPaperLikeLogId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngPaperLikeLogId:所给的关键字
     * @returns 对象
    */
    async function PaperLikeLog_GetObjByPaperLikeLogId_localStorage(lngPaperLikeLogId) {
        const strThisFuncName = "GetObjByPaperLikeLogId_localStorage";
        if (lngPaperLikeLogId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngPaperLikeLogId]不能为空！(In clsPaperLikeLogWApi.GetObjByPaperLikeLogId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperLikeLogEN_js_1.clsPaperLikeLogEN._CurrTabName, lngPaperLikeLogId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objPaperLikeLog_Cache = JSON.parse(strTempObj);
            return objPaperLikeLog_Cache;
        }
        try {
            const objPaperLikeLog = await PaperLikeLog_GetObjByPaperLikeLogIdAsync(lngPaperLikeLogId);
            if (objPaperLikeLog != null) {
                localStorage.setItem(strKey, JSON.stringify(objPaperLikeLog));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objPaperLikeLog;
            }
            return objPaperLikeLog;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperLikeLogId, exports.paperLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.PaperLikeLog_GetObjByPaperLikeLogId_localStorage = PaperLikeLog_GetObjByPaperLikeLogId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objPaperLikeLog:所给的对象
     * @returns 对象
    */
    async function PaperLikeLog_UpdateObjInLst_Cache(objPaperLikeLog) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
            const obj = arrPaperLikeLogObjLst_Cache.find(x => x.paperId == objPaperLikeLog.paperId && x.updUser == objPaperLikeLog.updUser);
            if (obj != null) {
                objPaperLikeLog.paperLikeLogId = obj.paperLikeLogId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objPaperLikeLog);
            }
            else {
                arrPaperLikeLogObjLst_Cache.push(objPaperLikeLog);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.paperLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperLikeLog_UpdateObjInLst_Cache = PaperLikeLog_UpdateObjInLst_Cache;
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
    async function PaperLikeLog_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperLikeLogId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngPaperLikeLogId = Number(strInValue);
        if (lngPaperLikeLogId == 0) {
            return "";
        }
        const objPaperLikeLog = await PaperLikeLog_GetObjByPaperLikeLogId_Cache(lngPaperLikeLogId);
        if (objPaperLikeLog == null)
            return "";
        if (objPaperLikeLog.GetFldValue(strOutFldName) == null)
            return "";
        return objPaperLikeLog.GetFldValue(strOutFldName).toString();
    }
    exports.PaperLikeLog_func = PaperLikeLog_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperLikeLog_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperLikeLogId - b.paperLikeLogId;
    }
    exports.PaperLikeLog_SortFun_Defa = PaperLikeLog_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperLikeLog_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.updUser.localeCompare(b.updUser);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.PaperLikeLog_SortFun_Defa_2Fld = PaperLikeLog_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperLikeLog_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperLikeLogId:
                    return (a, b) => {
                        return a.paperLikeLogId - b.paperLikeLogId;
                    };
                case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperLikeLog]中不存在！(in ${exports.paperLikeLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperLikeLogId:
                    return (a, b) => {
                        return b.paperLikeLogId - a.paperLikeLogId;
                    };
                case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperLikeLog]中不存在！(in ${exports.paperLikeLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.PaperLikeLog_SortFunByKey = PaperLikeLog_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperLikeLog_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperLikeLogId:
                return (obj) => {
                    return obj.paperLikeLogId === value;
                };
            case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[PaperLikeLog]中不存在！(in ${exports.paperLikeLog_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.PaperLikeLog_FilterFunByKey = PaperLikeLog_FilterFunByKey;
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
    async function PaperLikeLog_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperLikeLogId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrPaperLikeLog = await PaperLikeLog_GetObjLst_Cache();
        if (arrPaperLikeLog == null)
            return [];
        let arrPaperLikeLog_Sel = arrPaperLikeLog;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrPaperLikeLog_Sel.length == 0)
            return [];
        return arrPaperLikeLog_Sel.map(x => x.paperLikeLogId);
    }
    exports.PaperLikeLog_funcKey = PaperLikeLog_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperLikeLog_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_GetFirstIDAsync = PaperLikeLog_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function PaperLikeLog_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_GetFirstID = PaperLikeLog_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function PaperLikeLog_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
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
                const objPaperLikeLog = PaperLikeLog_GetObjFromJsonObj(returnObj);
                return objPaperLikeLog;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_GetFirstObjAsync = PaperLikeLog_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperLikeLog_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPaperLikeLogEN_js_1.clsPaperLikeLogEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrPaperLikeLogExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrPaperLikeLogObjLst_T = PaperLikeLog_GetObjLstByJSONObjLst(arrPaperLikeLogExObjLst_Cache);
            return arrPaperLikeLogObjLst_T;
        }
        try {
            const arrPaperLikeLogExObjLst = await PaperLikeLog_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrPaperLikeLogExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperLikeLogExObjLst.length);
            console.log(strInfo);
            return arrPaperLikeLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperLikeLog_GetObjLst_ClientCache = PaperLikeLog_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperLikeLog_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPaperLikeLogEN_js_1.clsPaperLikeLogEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperLikeLogExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperLikeLogObjLst_T = PaperLikeLog_GetObjLstByJSONObjLst(arrPaperLikeLogExObjLst_Cache);
            return arrPaperLikeLogObjLst_T;
        }
        try {
            const arrPaperLikeLogExObjLst = await PaperLikeLog_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrPaperLikeLogExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperLikeLogExObjLst.length);
            console.log(strInfo);
            return arrPaperLikeLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperLikeLog_GetObjLst_localStorage = PaperLikeLog_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperLikeLog_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsPaperLikeLogEN_js_1.clsPaperLikeLogEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperLikeLogObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperLikeLogObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperLikeLog_GetObjLst_localStorage_PureCache = PaperLikeLog_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function PaperLikeLog_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_GetObjLstAsync = PaperLikeLog_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperLikeLog_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPaperLikeLogEN_js_1.clsPaperLikeLogEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperLikeLogExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperLikeLogObjLst_T = PaperLikeLog_GetObjLstByJSONObjLst(arrPaperLikeLogExObjLst_Cache);
            return arrPaperLikeLogObjLst_T;
        }
        try {
            const arrPaperLikeLogExObjLst = await PaperLikeLog_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrPaperLikeLogExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperLikeLogExObjLst.length);
            console.log(strInfo);
            return arrPaperLikeLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperLikeLog_GetObjLst_sessionStorage = PaperLikeLog_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperLikeLog_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsPaperLikeLogEN_js_1.clsPaperLikeLogEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperLikeLogObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperLikeLogObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperLikeLog_GetObjLst_sessionStorage_PureCache = PaperLikeLog_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperLikeLog_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrPaperLikeLogObjLst_Cache;
        switch (clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_ClientCache();
                break;
            default:
                arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_ClientCache();
                break;
        }
        const arrPaperLikeLogObjLst = PaperLikeLog_GetObjLstByJSONObjLst(arrPaperLikeLogObjLst_Cache);
        return arrPaperLikeLogObjLst_Cache;
    }
    exports.PaperLikeLog_GetObjLst_Cache = PaperLikeLog_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperLikeLog_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrPaperLikeLogObjLst_Cache;
        switch (clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrPaperLikeLogObjLst_Cache = null;
                break;
            default:
                arrPaperLikeLogObjLst_Cache = null;
                break;
        }
        return arrPaperLikeLogObjLst_Cache;
    }
    exports.PaperLikeLog_GetObjLst_PureCache = PaperLikeLog_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngPaperLikeLogId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperLikeLog_GetSubObjLst_Cache(objPaperLikeLog_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
        let arrPaperLikeLog_Sel = arrPaperLikeLogObjLst_Cache;
        if (objPaperLikeLog_Cond.sf_FldComparisonOp == null || objPaperLikeLog_Cond.sf_FldComparisonOp == "")
            return arrPaperLikeLog_Sel;
        const dicFldComparisonOp = JSON.parse(objPaperLikeLog_Cond.sf_FldComparisonOp);
        //console.log("clsPaperLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperLikeLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperLikeLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperLikeLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objPaperLikeLog_Cond), exports.paperLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperLikeLog_GetSubObjLst_Cache = PaperLikeLog_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperLikeLogId:关键字列表
    * @returns 对象列表
    **/
    async function PaperLikeLog_GetObjLstByPaperLikeLogIdLstAsync(arrPaperLikeLogId) {
        const strThisFuncName = "GetObjLstByPaperLikeLogIdLstAsync";
        const strAction = "GetObjLstByPaperLikeLogIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperLikeLogId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_GetObjLstByPaperLikeLogIdLstAsync = PaperLikeLog_GetObjLstByPaperLikeLogIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngPaperLikeLogIdLst:关键字列表
     * @returns 对象列表
    */
    async function PaperLikeLog_GetObjLstByPaperLikeLogIdLst_Cache(arrPaperLikeLogIdLst) {
        const strThisFuncName = "GetObjLstByPaperLikeLogIdLst_Cache";
        try {
            const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
            const arrPaperLikeLog_Sel = arrPaperLikeLogObjLst_Cache.filter(x => arrPaperLikeLogIdLst.indexOf(x.paperLikeLogId) > -1);
            return arrPaperLikeLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperLikeLogIdLst.join(","), exports.paperLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.PaperLikeLog_GetObjLstByPaperLikeLogIdLst_Cache = PaperLikeLog_GetObjLstByPaperLikeLogIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function PaperLikeLog_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_GetTopObjLstAsync = PaperLikeLog_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperLikeLog_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_GetObjLstByRangeAsync = PaperLikeLog_GetObjLstByRangeAsync;
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
    async function PaperLikeLog_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_GetObjLstByRange = PaperLikeLog_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperLikeLog_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
        if (arrPaperLikeLogObjLst_Cache.length == 0)
            return arrPaperLikeLogObjLst_Cache;
        let arrPaperLikeLog_Sel = arrPaperLikeLogObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objPaperLikeLog_Cond = new clsPaperLikeLogEN_js_1.clsPaperLikeLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperLikeLog_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPaperLikeLogWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperLikeLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperLikeLog_Sel.length == 0)
                return arrPaperLikeLog_Sel;
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
                arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.sort(PaperLikeLog_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.sort(objPagerPara.sortFun);
            }
            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.slice(intStart, intEnd);
            return arrPaperLikeLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperLikeLog_GetObjLstByPager_Cache = PaperLikeLog_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperLikeLog_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_GetObjLstByPagerAsync = PaperLikeLog_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngPaperLikeLogId:关键字
    * @returns 获取删除的结果
    **/
    async function PaperLikeLog_DelRecordAsync(lngPaperLikeLogId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngPaperLikeLogId);
        try {
            const response = await axios_1.default.delete(strUrl);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_DelRecordAsync = PaperLikeLog_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperLikeLogId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function PaperLikeLog_DelPaperLikeLogsAsync(arrPaperLikeLogId) {
        const strThisFuncName = "DelPaperLikeLogsAsync";
        const strAction = "DelPaperLikeLogs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperLikeLogId);
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnInt;
            }
            else {
                console.error(data.errorMsg);
                throw data.errorMsg;
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_DelPaperLikeLogsAsync = PaperLikeLog_DelPaperLikeLogsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function PaperLikeLog_DelPaperLikeLogsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelPaperLikeLogsByCondAsync";
        const strAction = "DelPaperLikeLogsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_DelPaperLikeLogsByCondAsync = PaperLikeLog_DelPaperLikeLogsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objPaperLikeLogEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperLikeLog_AddNewRecordAsync(objPaperLikeLogEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objPaperLikeLogEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperLikeLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_AddNewRecordAsync = PaperLikeLog_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objPaperLikeLogEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function PaperLikeLog_AddNewRecordWithReturnKeyAsync(objPaperLikeLogEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperLikeLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_AddNewRecordWithReturnKeyAsync = PaperLikeLog_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objPaperLikeLogEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function PaperLikeLog_AddNewRecordWithReturnKey(objPaperLikeLogEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objPaperLikeLogEN.paperLikeLogId === null || objPaperLikeLogEN.paperLikeLogId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperLikeLogEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_AddNewRecordWithReturnKey = PaperLikeLog_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objPaperLikeLogEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function PaperLikeLog_UpdateRecordAsync(objPaperLikeLogEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objPaperLikeLogEN.sf_UpdFldSetStr === undefined || objPaperLikeLogEN.sf_UpdFldSetStr === null || objPaperLikeLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperLikeLogEN.paperLikeLogId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperLikeLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_UpdateRecordAsync = PaperLikeLog_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objPaperLikeLogEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperLikeLog_UpdateWithConditionAsync(objPaperLikeLogEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objPaperLikeLogEN.sf_UpdFldSetStr === undefined || objPaperLikeLogEN.sf_UpdFldSetStr === null || objPaperLikeLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperLikeLogEN.paperLikeLogId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        objPaperLikeLogEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objPaperLikeLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_UpdateWithConditionAsync = PaperLikeLog_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngPaperLikeLogId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperLikeLog_IsExistRecord_Cache(objPaperLikeLog_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
        if (arrPaperLikeLogObjLst_Cache == null)
            return false;
        let arrPaperLikeLog_Sel = arrPaperLikeLogObjLst_Cache;
        if (objPaperLikeLog_Cond.sf_FldComparisonOp == null || objPaperLikeLog_Cond.sf_FldComparisonOp == "")
            return arrPaperLikeLog_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objPaperLikeLog_Cond.sf_FldComparisonOp);
        //console.log("clsPaperLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperLikeLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperLikeLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperLikeLog_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objPaperLikeLog_Cond), exports.paperLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.PaperLikeLog_IsExistRecord_Cache = PaperLikeLog_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function PaperLikeLog_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_IsExistRecordAsync = PaperLikeLog_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperLikeLogId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function PaperLikeLog_IsExist(lngPaperLikeLogId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperLikeLogId": lngPaperLikeLogId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_IsExist = PaperLikeLog_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngPaperLikeLogId:所给的关键字
     * @returns 对象
    */
    async function PaperLikeLog_IsExist_Cache(lngPaperLikeLogId) {
        const strThisFuncName = "IsExist_Cache";
        const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
        if (arrPaperLikeLogObjLst_Cache == null)
            return false;
        try {
            const arrPaperLikeLog_Sel = arrPaperLikeLogObjLst_Cache.filter(x => x.paperLikeLogId == lngPaperLikeLogId);
            if (arrPaperLikeLog_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperLikeLogId, exports.paperLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.PaperLikeLog_IsExist_Cache = PaperLikeLog_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperLikeLogId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function PaperLikeLog_IsExistAsync(lngPaperLikeLogId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperLikeLogId": lngPaperLikeLogId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_IsExistAsync = PaperLikeLog_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function PaperLikeLog_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_GetRecCountByCondAsync = PaperLikeLog_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objPaperLikeLog_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function PaperLikeLog_GetRecCountByCond_Cache(objPaperLikeLog_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
        if (arrPaperLikeLogObjLst_Cache == null)
            return 0;
        let arrPaperLikeLog_Sel = arrPaperLikeLogObjLst_Cache;
        if (objPaperLikeLog_Cond.sf_FldComparisonOp == null || objPaperLikeLog_Cond.sf_FldComparisonOp == "")
            return arrPaperLikeLog_Sel.length;
        const dicFldComparisonOp = JSON.parse(objPaperLikeLog_Cond.sf_FldComparisonOp);
        //console.log("clsPaperLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperLikeLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperLikeLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperLikeLog_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objPaperLikeLog_Cond), exports.paperLikeLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.PaperLikeLog_GetRecCountByCond_Cache = PaperLikeLog_GetRecCountByCond_Cache;
    /*该表的关键字类型不是字符型自增，不需要生成获取最大关键字函数！*/
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function PaperLikeLog_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strPrefix": strPrefix }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperLikeLog_GetMaxStrIdByPrefix = PaperLikeLog_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function PaperLikeLog_GetWebApiUrl(strController, strAction) {
        const strThisFuncName = "GetWebApiUrl";
        let strServiceUrl;
        let strCurrIPAddressAndPort = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort;
        }
        else {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local;
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx) == true) {
            strServiceUrl = (0, clsString_js_2.Format)("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
        }
        else {
            strServiceUrl = (0, clsString_js_2.Format)("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx, strController, strAction);
        }
        return strServiceUrl;
    }
    exports.PaperLikeLog_GetWebApiUrl = PaperLikeLog_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function PaperLikeLog_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsPaperLikeLogEN_js_1.clsPaperLikeLogEN._CurrTabName;
        switch (clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.CacheModeId) {
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
    }
    exports.PaperLikeLog_ReFreshCache = PaperLikeLog_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function PaperLikeLog_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsPaperLikeLogEN_js_1.clsPaperLikeLogEN._CurrTabName;
            switch (clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.CacheModeId) {
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
            const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_2.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.PaperLikeLog_ReFreshThisCache = PaperLikeLog_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperLikeLog_CheckPropertyNew(pobjPaperLikeLogEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.updUser) === true) {
            throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 论文点赞表)!(clsPaperLikeLogBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperLikeLogEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.paperId)(clsPaperLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjPaperLikeLogEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.updUser)(clsPaperLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjPaperLikeLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.updDate)(clsPaperLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjPaperLikeLogEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.memo)(clsPaperLikeLogBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperLikeLogEN.paperLikeLogId && undefined !== pobjPaperLikeLogEN.paperLikeLogId && clsString_js_1.tzDataType.isNumber(pobjPaperLikeLogEN.paperLikeLogId) === false) {
            throw new Error("(errid:Watl000060)字段[论文点赞表Id(paperLikeLogId)]的值:[$(pobjPaperLikeLogEN.paperLikeLogId)], 非法，应该为数值型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.paperId) == false && undefined !== pobjPaperLikeLogEN.paperId && clsString_js_1.tzDataType.isString(pobjPaperLikeLogEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperLikeLogEN.paperId)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.updUser) == false && undefined !== pobjPaperLikeLogEN.updUser && clsString_js_1.tzDataType.isString(pobjPaperLikeLogEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperLikeLogEN.updUser)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.updDate) == false && undefined !== pobjPaperLikeLogEN.updDate && clsString_js_1.tzDataType.isString(pobjPaperLikeLogEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperLikeLogEN.updDate)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.memo) == false && undefined !== pobjPaperLikeLogEN.memo && clsString_js_1.tzDataType.isString(pobjPaperLikeLogEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperLikeLogEN.memo)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjPaperLikeLogEN.SetIsCheckProperty(true);
    }
    exports.PaperLikeLog_CheckPropertyNew = PaperLikeLog_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperLikeLog_CheckProperty4Update(pobjPaperLikeLogEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperLikeLogEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.paperId)(clsPaperLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjPaperLikeLogEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.updUser)(clsPaperLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjPaperLikeLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.updDate)(clsPaperLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjPaperLikeLogEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.memo)(clsPaperLikeLogBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperLikeLogEN.paperLikeLogId && undefined !== pobjPaperLikeLogEN.paperLikeLogId && clsString_js_1.tzDataType.isNumber(pobjPaperLikeLogEN.paperLikeLogId) === false) {
            throw new Error("(errid:Watl000063)字段[论文点赞表Id(paperLikeLogId)]的值:[$(pobjPaperLikeLogEN.paperLikeLogId)], 非法，应该为数值型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.paperId) == false && undefined !== pobjPaperLikeLogEN.paperId && clsString_js_1.tzDataType.isString(pobjPaperLikeLogEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperLikeLogEN.paperId)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.updUser) == false && undefined !== pobjPaperLikeLogEN.updUser && clsString_js_1.tzDataType.isString(pobjPaperLikeLogEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperLikeLogEN.updUser)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.updDate) == false && undefined !== pobjPaperLikeLogEN.updDate && clsString_js_1.tzDataType.isString(pobjPaperLikeLogEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperLikeLogEN.updDate)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperLikeLogEN.memo) == false && undefined !== pobjPaperLikeLogEN.memo && clsString_js_1.tzDataType.isString(pobjPaperLikeLogEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperLikeLogEN.memo)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjPaperLikeLogEN.paperLikeLogId
            || pobjPaperLikeLogEN.paperLikeLogId != null && pobjPaperLikeLogEN.paperLikeLogId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[论文点赞表Id]不能为空(In 论文点赞表)!(clsPaperLikeLogBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjPaperLikeLogEN.SetIsCheckProperty(true);
    }
    exports.PaperLikeLog_CheckProperty4Update = PaperLikeLog_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperLikeLog_GetJSONStrByObj(pobjPaperLikeLogEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjPaperLikeLogEN.sf_UpdFldSetStr = pobjPaperLikeLogEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjPaperLikeLogEN);
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
    exports.PaperLikeLog_GetJSONStrByObj = PaperLikeLog_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function PaperLikeLog_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrPaperLikeLogObjLst = new Array();
        if (strJSON === "") {
            return arrPaperLikeLogObjLst;
        }
        try {
            arrPaperLikeLogObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrPaperLikeLogObjLst;
        }
        return arrPaperLikeLogObjLst;
    }
    exports.PaperLikeLog_GetObjLstByJSONStr = PaperLikeLog_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrPaperLikeLogObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function PaperLikeLog_GetObjLstByJSONObjLst(arrPaperLikeLogObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrPaperLikeLogObjLst = new Array();
        for (const objInFor of arrPaperLikeLogObjLstS) {
            const obj1 = PaperLikeLog_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrPaperLikeLogObjLst.push(obj1);
        }
        return arrPaperLikeLogObjLst;
    }
    exports.PaperLikeLog_GetObjLstByJSONObjLst = PaperLikeLog_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperLikeLog_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjPaperLikeLogEN = new clsPaperLikeLogEN_js_1.clsPaperLikeLogEN();
        if (strJSON === "") {
            return pobjPaperLikeLogEN;
        }
        try {
            pobjPaperLikeLogEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjPaperLikeLogEN;
        }
        return pobjPaperLikeLogEN;
    }
    exports.PaperLikeLog_GetObjByJSONStr = PaperLikeLog_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function PaperLikeLog_GetCombineCondition(objPaperLikeLog_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objPaperLikeLog_Cond.dicFldComparisonOp, clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperLikeLogId) == true) {
            const strComparisonOp_PaperLikeLogId = objPaperLikeLog_Cond.dicFldComparisonOp[clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperLikeLogId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperLikeLogId, objPaperLikeLog_Cond.paperLikeLogId, strComparisonOp_PaperLikeLogId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperLikeLog_Cond.dicFldComparisonOp, clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objPaperLikeLog_Cond.dicFldComparisonOp[clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_PaperId, objPaperLikeLog_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperLikeLog_Cond.dicFldComparisonOp, clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objPaperLikeLog_Cond.dicFldComparisonOp[clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_UpdUser, objPaperLikeLog_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperLikeLog_Cond.dicFldComparisonOp, clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objPaperLikeLog_Cond.dicFldComparisonOp[clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_UpdDate, objPaperLikeLog_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperLikeLog_Cond.dicFldComparisonOp, clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_Memo) == true) {
            const strComparisonOp_Memo = objPaperLikeLog_Cond.dicFldComparisonOp[clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperLikeLogEN_js_1.clsPaperLikeLogEN.con_Memo, objPaperLikeLog_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.PaperLikeLog_GetCombineCondition = PaperLikeLog_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--PaperLikeLog(论文点赞表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @param strUpdUser: 修改人(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperLikeLog_GetUniCondStr_PaperId_UpdUser(objPaperLikeLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperId = '{0}'", objPaperLikeLogEN.paperId);
        strWhereCond += (0, clsString_js_2.Format)(" and UpdUser = '{0}'", objPaperLikeLogEN.updUser);
        return strWhereCond;
    }
    exports.PaperLikeLog_GetUniCondStr_PaperId_UpdUser = PaperLikeLog_GetUniCondStr_PaperId_UpdUser;
    /**
    *获取唯一性条件串(Uniqueness)--PaperLikeLog(论文点赞表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @param strUpdUser: 修改人(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperLikeLog_GetUniCondStr4Update_PaperId_UpdUser(objPaperLikeLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperLikeLogId <> '{0}'", objPaperLikeLogEN.paperLikeLogId);
        strWhereCond += (0, clsString_js_2.Format)(" and PaperId = '{0}'", objPaperLikeLogEN.paperId);
        strWhereCond += (0, clsString_js_2.Format)(" and UpdUser = '{0}'", objPaperLikeLogEN.updUser);
        return strWhereCond;
    }
    exports.PaperLikeLog_GetUniCondStr4Update_PaperId_UpdUser = PaperLikeLog_GetUniCondStr4Update_PaperId_UpdUser;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objPaperLikeLogENS:源对象
     * @param objPaperLikeLogENT:目标对象
    */
    function PaperLikeLog_CopyObjTo(objPaperLikeLogENS, objPaperLikeLogENT) {
        objPaperLikeLogENT.paperLikeLogId = objPaperLikeLogENS.paperLikeLogId; //论文点赞表Id
        objPaperLikeLogENT.paperId = objPaperLikeLogENS.paperId; //论文Id
        objPaperLikeLogENT.updUser = objPaperLikeLogENS.updUser; //修改人
        objPaperLikeLogENT.updDate = objPaperLikeLogENS.updDate; //修改日期
        objPaperLikeLogENT.memo = objPaperLikeLogENS.memo; //备注
        objPaperLikeLogENT.sf_UpdFldSetStr = objPaperLikeLogENS.updFldString; //sf_UpdFldSetStr
    }
    exports.PaperLikeLog_CopyObjTo = PaperLikeLog_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objPaperLikeLogENS:源对象
     * @param objPaperLikeLogENT:目标对象
    */
    function PaperLikeLog_GetObjFromJsonObj(objPaperLikeLogENS) {
        const objPaperLikeLogENT = new clsPaperLikeLogEN_js_1.clsPaperLikeLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperLikeLogENT, objPaperLikeLogENS);
        return objPaperLikeLogENT;
    }
    exports.PaperLikeLog_GetObjFromJsonObj = PaperLikeLog_GetObjFromJsonObj;
});
