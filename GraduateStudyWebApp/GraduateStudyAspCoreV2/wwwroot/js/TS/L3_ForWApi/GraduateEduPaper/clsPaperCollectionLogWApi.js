/**
* 类名:clsPaperCollectionLogWApi
* 表名:PaperCollectionLog(01120565)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:53:16
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培论文(GraduateEduPaper)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperCollectionLog_GetObjFromJsonObj = exports.PaperCollectionLog_CopyObjTo = exports.PaperCollectionLog_GetUniCondStr4Update_PaperCollectionLogId = exports.PaperCollectionLog_GetUniCondStr_PaperCollectionLogId = exports.PaperCollectionLog_GetCombineCondition = exports.PaperCollectionLog_GetObjByJSONStr = exports.PaperCollectionLog_GetObjLstByJSONObjLst = exports.PaperCollectionLog_GetObjLstByJSONStr = exports.PaperCollectionLog_GetJSONStrByObj = exports.PaperCollectionLog_CheckProperty4Update = exports.PaperCollectionLog_CheckPropertyNew = exports.PaperCollectionLog_ReFreshThisCache = exports.PaperCollectionLog_ReFreshCache = exports.PaperCollectionLog_GetWebApiUrl = exports.PaperCollectionLog_GetMaxStrIdByPrefix = exports.PaperCollectionLog_GetRecCountByCond_Cache = exports.PaperCollectionLog_GetRecCountByCondAsync = exports.PaperCollectionLog_IsExistAsync = exports.PaperCollectionLog_IsExist_Cache = exports.PaperCollectionLog_IsExist = exports.PaperCollectionLog_IsExistRecordAsync = exports.PaperCollectionLog_IsExistRecord_Cache = exports.PaperCollectionLog_UpdateWithConditionAsync = exports.PaperCollectionLog_UpdateRecordAsync = exports.PaperCollectionLog_AddNewRecordWithReturnKey = exports.PaperCollectionLog_AddNewRecordWithReturnKeyAsync = exports.PaperCollectionLog_AddNewRecordAsync = exports.PaperCollectionLog_DelPaperCollectionLogsByCondAsync = exports.PaperCollectionLog_DelPaperCollectionLogsAsync = exports.PaperCollectionLog_DelRecordAsync = exports.PaperCollectionLog_GetObjLstByPagerAsync = exports.PaperCollectionLog_GetObjLstByPager_Cache = exports.PaperCollectionLog_GetObjLstByRange = exports.PaperCollectionLog_GetObjLstByRangeAsync = exports.PaperCollectionLog_GetTopObjLstAsync = exports.PaperCollectionLog_GetObjLstByPaperCollectionLogIdLst_Cache = exports.PaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync = exports.PaperCollectionLog_GetSubObjLst_Cache = exports.PaperCollectionLog_GetObjLst_PureCache = exports.PaperCollectionLog_GetObjLst_Cache = exports.PaperCollectionLog_GetObjLst_sessionStorage_PureCache = exports.PaperCollectionLog_GetObjLst_sessionStorage = exports.PaperCollectionLog_GetObjLstAsync = exports.PaperCollectionLog_GetObjLst_localStorage_PureCache = exports.PaperCollectionLog_GetObjLst_localStorage = exports.PaperCollectionLog_GetObjLst_ClientCache = exports.PaperCollectionLog_GetFirstObjAsync = exports.PaperCollectionLog_GetFirstID = exports.PaperCollectionLog_GetFirstIDAsync = exports.PaperCollectionLog_funcKey = exports.PaperCollectionLog_FilterFunByKey = exports.PaperCollectionLog_SortFunByKey = exports.PaperCollectionLog_SortFun_Defa_2Fld = exports.PaperCollectionLog_SortFun_Defa = exports.PaperCollectionLog_func = exports.PaperCollectionLog_UpdateObjInLst_Cache = exports.PaperCollectionLog_GetObjByPaperCollectionLogId_localStorage = exports.PaperCollectionLog_GetObjByPaperCollectionLogId_Cache = exports.PaperCollectionLog_GetObjByPaperCollectionLogIdAsync = exports.paperCollectionLog_ConstructorName = exports.paperCollectionLog_Controller = void 0;
    /**
     * 论文收藏(PaperCollectionLog)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsPaperCollectionLogEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.paperCollectionLog_Controller = "PaperCollectionLogApi";
    exports.paperCollectionLog_ConstructorName = "paperCollectionLog";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperCollectionLogId:关键字
    * @returns 对象
    **/
    async function PaperCollectionLog_GetObjByPaperCollectionLogIdAsync(lngPaperCollectionLogId) {
        const strThisFuncName = "GetObjByPaperCollectionLogIdAsync";
        if (lngPaperCollectionLogId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngPaperCollectionLogId]不能为空！(In clsPaperCollectionLogWApi.GetObjByPaperCollectionLogIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperCollectionLogId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperCollectionLogId": lngPaperCollectionLogId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objPaperCollectionLog = PaperCollectionLog_GetObjFromJsonObj(returnObj);
                return objPaperCollectionLog;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetObjByPaperCollectionLogIdAsync = PaperCollectionLog_GetObjByPaperCollectionLogIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngPaperCollectionLogId:所给的关键字
     * @returns 对象
    */
    async function PaperCollectionLog_GetObjByPaperCollectionLogId_Cache(lngPaperCollectionLogId, strUpdUser, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPaperCollectionLogId_Cache";
        if (lngPaperCollectionLogId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngPaperCollectionLogId]不能为空！(In clsPaperCollectionLogWApi.GetObjByPaperCollectionLogId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_Cache(strUpdUser);
        try {
            const arrPaperCollectionLog_Sel = arrPaperCollectionLogObjLst_Cache.filter(x => x.paperCollectionLogId == lngPaperCollectionLogId);
            let objPaperCollectionLog;
            if (arrPaperCollectionLog_Sel.length > 0) {
                objPaperCollectionLog = arrPaperCollectionLog_Sel[0];
                return objPaperCollectionLog;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objPaperCollectionLog_Const = await PaperCollectionLog_GetObjByPaperCollectionLogIdAsync(lngPaperCollectionLogId);
                    if (objPaperCollectionLog_Const != null) {
                        PaperCollectionLog_ReFreshThisCache(strUpdUser);
                        return objPaperCollectionLog_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperCollectionLogId, exports.paperCollectionLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.PaperCollectionLog_GetObjByPaperCollectionLogId_Cache = PaperCollectionLog_GetObjByPaperCollectionLogId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngPaperCollectionLogId:所给的关键字
     * @returns 对象
    */
    async function PaperCollectionLog_GetObjByPaperCollectionLogId_localStorage(lngPaperCollectionLogId) {
        const strThisFuncName = "GetObjByPaperCollectionLogId_localStorage";
        if (lngPaperCollectionLogId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngPaperCollectionLogId]不能为空！(In clsPaperCollectionLogWApi.GetObjByPaperCollectionLogId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN._CurrTabName, lngPaperCollectionLogId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objPaperCollectionLog_Cache = JSON.parse(strTempObj);
            return objPaperCollectionLog_Cache;
        }
        try {
            const objPaperCollectionLog = await PaperCollectionLog_GetObjByPaperCollectionLogIdAsync(lngPaperCollectionLogId);
            if (objPaperCollectionLog != null) {
                localStorage.setItem(strKey, JSON.stringify(objPaperCollectionLog));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objPaperCollectionLog;
            }
            return objPaperCollectionLog;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperCollectionLogId, exports.paperCollectionLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.PaperCollectionLog_GetObjByPaperCollectionLogId_localStorage = PaperCollectionLog_GetObjByPaperCollectionLogId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objPaperCollectionLog:所给的对象
     * @returns 对象
    */
    async function PaperCollectionLog_UpdateObjInLst_Cache(objPaperCollectionLog, strUpdUser) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_Cache(strUpdUser);
            const obj = arrPaperCollectionLogObjLst_Cache.find(x => x.paperCollectionLogId == objPaperCollectionLog.paperCollectionLogId);
            if (obj != null) {
                objPaperCollectionLog.paperCollectionLogId = obj.paperCollectionLogId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objPaperCollectionLog);
            }
            else {
                arrPaperCollectionLogObjLst_Cache.push(objPaperCollectionLog);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.paperCollectionLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperCollectionLog_UpdateObjInLst_Cache = PaperCollectionLog_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strUpdUser:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function PaperCollectionLog_func(strInFldName, strOutFldName, strInValue, strUpdUser_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strUpdUser_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strUpdUser_C]不能为空！(In clsPaperCollectionLogWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngPaperCollectionLogId = Number(strInValue);
        if (lngPaperCollectionLogId == 0) {
            return "";
        }
        const objPaperCollectionLog = await PaperCollectionLog_GetObjByPaperCollectionLogId_Cache(lngPaperCollectionLogId, strUpdUser_C);
        if (objPaperCollectionLog == null)
            return "";
        if (objPaperCollectionLog.GetFldValue(strOutFldName) == null)
            return "";
        return objPaperCollectionLog.GetFldValue(strOutFldName).toString();
    }
    exports.PaperCollectionLog_func = PaperCollectionLog_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperCollectionLog_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperCollectionLogId - b.paperCollectionLogId;
    }
    exports.PaperCollectionLog_SortFun_Defa = PaperCollectionLog_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperCollectionLog_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.updUser.localeCompare(b.updUser);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.PaperCollectionLog_SortFun_Defa_2Fld = PaperCollectionLog_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperCollectionLog_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId:
                    return (a, b) => {
                        return a.paperCollectionLogId - b.paperCollectionLogId;
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_Meno:
                    return (a, b) => {
                        if (a.meno == null)
                            return -1;
                        if (b.meno == null)
                            return 1;
                        return a.meno.localeCompare(b.meno);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperCollectionLog]中不存在！(in ${exports.paperCollectionLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId:
                    return (a, b) => {
                        return b.paperCollectionLogId - a.paperCollectionLogId;
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_Meno:
                    return (a, b) => {
                        if (b.meno == null)
                            return -1;
                        if (a.meno == null)
                            return 1;
                        return b.meno.localeCompare(a.meno);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperCollectionLog]中不存在！(in ${exports.paperCollectionLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.PaperCollectionLog_SortFunByKey = PaperCollectionLog_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperCollectionLog_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId:
                return (obj) => {
                    return obj.paperCollectionLogId === value;
                };
            case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_Meno:
                return (obj) => {
                    return obj.meno === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[PaperCollectionLog]中不存在！(in ${exports.paperCollectionLog_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.PaperCollectionLog_FilterFunByKey = PaperCollectionLog_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strUpdUser:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function PaperCollectionLog_funcKey(strInFldName, strInValue, strComparisonOp, strUpdUser_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strUpdUser_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strUpdUser_C]不能为空！(In clsPaperCollectionLogWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrPaperCollectionLog = await PaperCollectionLog_GetObjLst_Cache(strUpdUser_C);
        if (arrPaperCollectionLog == null)
            return [];
        let arrPaperCollectionLog_Sel = arrPaperCollectionLog;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrPaperCollectionLog_Sel.length == 0)
            return [];
        return arrPaperCollectionLog_Sel.map(x => x.paperCollectionLogId);
    }
    exports.PaperCollectionLog_funcKey = PaperCollectionLog_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperCollectionLog_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetFirstIDAsync = PaperCollectionLog_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function PaperCollectionLog_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetFirstID = PaperCollectionLog_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function PaperCollectionLog_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const objPaperCollectionLog = PaperCollectionLog_GetObjFromJsonObj(returnObj);
                return objPaperCollectionLog;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetFirstObjAsync = PaperCollectionLog_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperCollectionLog_GetObjLst_ClientCache(strUpdUser) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.WhereFormat, strUpdUser);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("UpdUser='{0}'", strUpdUser);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN._CurrTabName, strUpdUser);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrPaperCollectionLogExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrPaperCollectionLogObjLst_T = PaperCollectionLog_GetObjLstByJSONObjLst(arrPaperCollectionLogExObjLst_Cache);
            return arrPaperCollectionLogObjLst_T;
        }
        try {
            const arrPaperCollectionLogExObjLst = await PaperCollectionLog_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrPaperCollectionLogExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperCollectionLogExObjLst.length);
            console.log(strInfo);
            return arrPaperCollectionLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperCollectionLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperCollectionLog_GetObjLst_ClientCache = PaperCollectionLog_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperCollectionLog_GetObjLst_localStorage(strUpdUser) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.WhereFormat, strUpdUser);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("UpdUser='{0}'", strUpdUser);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN._CurrTabName, strUpdUser);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperCollectionLogExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperCollectionLogObjLst_T = PaperCollectionLog_GetObjLstByJSONObjLst(arrPaperCollectionLogExObjLst_Cache);
            return arrPaperCollectionLogObjLst_T;
        }
        try {
            const arrPaperCollectionLogExObjLst = await PaperCollectionLog_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrPaperCollectionLogExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperCollectionLogExObjLst.length);
            console.log(strInfo);
            return arrPaperCollectionLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperCollectionLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperCollectionLog_GetObjLst_localStorage = PaperCollectionLog_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperCollectionLog_GetObjLst_localStorage_PureCache(strUpdUser) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("UpdUser='{0}'", strUpdUser);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN._CurrTabName, strUpdUser);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperCollectionLogObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperCollectionLogObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperCollectionLog_GetObjLst_localStorage_PureCache = PaperCollectionLog_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function PaperCollectionLog_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetObjLstAsync = PaperCollectionLog_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperCollectionLog_GetObjLst_sessionStorage(strUpdUser) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.WhereFormat, strUpdUser);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("UpdUser='{0}'", strUpdUser);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN._CurrTabName, strUpdUser);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperCollectionLogExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperCollectionLogObjLst_T = PaperCollectionLog_GetObjLstByJSONObjLst(arrPaperCollectionLogExObjLst_Cache);
            return arrPaperCollectionLogObjLst_T;
        }
        try {
            const arrPaperCollectionLogExObjLst = await PaperCollectionLog_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrPaperCollectionLogExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperCollectionLogExObjLst.length);
            console.log(strInfo);
            return arrPaperCollectionLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperCollectionLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperCollectionLog_GetObjLst_sessionStorage = PaperCollectionLog_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperCollectionLog_GetObjLst_sessionStorage_PureCache(strUpdUser) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("UpdUser='{0}'", strUpdUser);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN._CurrTabName, strUpdUser);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperCollectionLogObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperCollectionLogObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperCollectionLog_GetObjLst_sessionStorage_PureCache = PaperCollectionLog_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperCollectionLog_GetObjLst_Cache(strUpdUser) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strUpdUser) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[UpdUser]不能为空！(in clsPaperCollectionLogWApi.PaperCollectionLog_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        let arrPaperCollectionLogObjLst_Cache;
        switch (clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_sessionStorage(strUpdUser);
                break;
            case "03": //localStorage
                arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_localStorage(strUpdUser);
                break;
            case "02": //ClientCache
                arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_ClientCache(strUpdUser);
                break;
            default:
                arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_ClientCache(strUpdUser);
                break;
        }
        const arrPaperCollectionLogObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(arrPaperCollectionLogObjLst_Cache);
        return arrPaperCollectionLogObjLst_Cache;
    }
    exports.PaperCollectionLog_GetObjLst_Cache = PaperCollectionLog_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperCollectionLog_GetObjLst_PureCache(strUpdUser) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrPaperCollectionLogObjLst_Cache;
        switch (clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_sessionStorage_PureCache(strUpdUser);
                break;
            case "03": //localStorage
                arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_localStorage_PureCache(strUpdUser);
                break;
            case "02": //ClientCache
                arrPaperCollectionLogObjLst_Cache = null;
                break;
            default:
                arrPaperCollectionLogObjLst_Cache = null;
                break;
        }
        return arrPaperCollectionLogObjLst_Cache;
    }
    exports.PaperCollectionLog_GetObjLst_PureCache = PaperCollectionLog_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngPaperCollectionLogId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperCollectionLog_GetSubObjLst_Cache(objPaperCollectionLog_Cond, strUpdUser) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_Cache(strUpdUser);
        let arrPaperCollectionLog_Sel = arrPaperCollectionLogObjLst_Cache;
        if (objPaperCollectionLog_Cond.sf_FldComparisonOp == null || objPaperCollectionLog_Cond.sf_FldComparisonOp == "")
            return arrPaperCollectionLog_Sel;
        const dicFldComparisonOp = JSON.parse(objPaperCollectionLog_Cond.sf_FldComparisonOp);
        //console.log("clsPaperCollectionLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperCollectionLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperCollectionLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperCollectionLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objPaperCollectionLog_Cond), exports.paperCollectionLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperCollectionLog_GetSubObjLst_Cache = PaperCollectionLog_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperCollectionLogId:关键字列表
    * @returns 对象列表
    **/
    async function PaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync(arrPaperCollectionLogId) {
        const strThisFuncName = "GetObjLstByPaperCollectionLogIdLstAsync";
        const strAction = "GetObjLstByPaperCollectionLogIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperCollectionLogId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync = PaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngPaperCollectionLogIdLst:关键字列表
     * @returns 对象列表
    */
    async function PaperCollectionLog_GetObjLstByPaperCollectionLogIdLst_Cache(arrPaperCollectionLogIdLst, strUpdUser) {
        const strThisFuncName = "GetObjLstByPaperCollectionLogIdLst_Cache";
        try {
            const arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_Cache(strUpdUser);
            const arrPaperCollectionLog_Sel = arrPaperCollectionLogObjLst_Cache.filter(x => arrPaperCollectionLogIdLst.indexOf(x.paperCollectionLogId) > -1);
            return arrPaperCollectionLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperCollectionLogIdLst.join(","), exports.paperCollectionLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.PaperCollectionLog_GetObjLstByPaperCollectionLogIdLst_Cache = PaperCollectionLog_GetObjLstByPaperCollectionLogIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function PaperCollectionLog_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetTopObjLstAsync = PaperCollectionLog_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperCollectionLog_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetObjLstByRangeAsync = PaperCollectionLog_GetObjLstByRangeAsync;
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
    async function PaperCollectionLog_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetObjLstByRange = PaperCollectionLog_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperCollectionLog_GetObjLstByPager_Cache(objPagerPara, strUpdUser) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_Cache(strUpdUser);
        if (arrPaperCollectionLogObjLst_Cache.length == 0)
            return arrPaperCollectionLogObjLst_Cache;
        let arrPaperCollectionLog_Sel = arrPaperCollectionLogObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objPaperCollectionLog_Cond = new clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperCollectionLog_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPaperCollectionLogWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperCollectionLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperCollectionLog_Sel.length == 0)
                return arrPaperCollectionLog_Sel;
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
                arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.sort(PaperCollectionLog_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.sort(objPagerPara.sortFun);
            }
            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.slice(intStart, intEnd);
            return arrPaperCollectionLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperCollectionLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperCollectionLog_GetObjLstByPager_Cache = PaperCollectionLog_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperCollectionLog_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetObjLstByPagerAsync = PaperCollectionLog_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngPaperCollectionLogId:关键字
    * @returns 获取删除的结果
    **/
    async function PaperCollectionLog_DelRecordAsync(lngPaperCollectionLogId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngPaperCollectionLogId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_DelRecordAsync = PaperCollectionLog_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperCollectionLogId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function PaperCollectionLog_DelPaperCollectionLogsAsync(arrPaperCollectionLogId) {
        const strThisFuncName = "DelPaperCollectionLogsAsync";
        const strAction = "DelPaperCollectionLogs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperCollectionLogId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_DelPaperCollectionLogsAsync = PaperCollectionLog_DelPaperCollectionLogsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function PaperCollectionLog_DelPaperCollectionLogsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelPaperCollectionLogsByCondAsync";
        const strAction = "DelPaperCollectionLogsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_DelPaperCollectionLogsByCondAsync = PaperCollectionLog_DelPaperCollectionLogsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objPaperCollectionLogEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperCollectionLog_AddNewRecordAsync(objPaperCollectionLogEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objPaperCollectionLogEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperCollectionLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_AddNewRecordAsync = PaperCollectionLog_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objPaperCollectionLogEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function PaperCollectionLog_AddNewRecordWithReturnKeyAsync(objPaperCollectionLogEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperCollectionLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_AddNewRecordWithReturnKeyAsync = PaperCollectionLog_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objPaperCollectionLogEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function PaperCollectionLog_AddNewRecordWithReturnKey(objPaperCollectionLogEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objPaperCollectionLogEN.paperCollectionLogId === null || objPaperCollectionLogEN.paperCollectionLogId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperCollectionLogEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_AddNewRecordWithReturnKey = PaperCollectionLog_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objPaperCollectionLogEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function PaperCollectionLog_UpdateRecordAsync(objPaperCollectionLogEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objPaperCollectionLogEN.sf_UpdFldSetStr === undefined || objPaperCollectionLogEN.sf_UpdFldSetStr === null || objPaperCollectionLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperCollectionLogEN.paperCollectionLogId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperCollectionLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_UpdateRecordAsync = PaperCollectionLog_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objPaperCollectionLogEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperCollectionLog_UpdateWithConditionAsync(objPaperCollectionLogEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objPaperCollectionLogEN.sf_UpdFldSetStr === undefined || objPaperCollectionLogEN.sf_UpdFldSetStr === null || objPaperCollectionLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperCollectionLogEN.paperCollectionLogId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        objPaperCollectionLogEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objPaperCollectionLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_UpdateWithConditionAsync = PaperCollectionLog_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngPaperCollectionLogId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperCollectionLog_IsExistRecord_Cache(objPaperCollectionLog_Cond, strUpdUser) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_Cache(strUpdUser);
        if (arrPaperCollectionLogObjLst_Cache == null)
            return false;
        let arrPaperCollectionLog_Sel = arrPaperCollectionLogObjLst_Cache;
        if (objPaperCollectionLog_Cond.sf_FldComparisonOp == null || objPaperCollectionLog_Cond.sf_FldComparisonOp == "")
            return arrPaperCollectionLog_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objPaperCollectionLog_Cond.sf_FldComparisonOp);
        //console.log("clsPaperCollectionLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperCollectionLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperCollectionLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperCollectionLog_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objPaperCollectionLog_Cond), exports.paperCollectionLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.PaperCollectionLog_IsExistRecord_Cache = PaperCollectionLog_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function PaperCollectionLog_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_IsExistRecordAsync = PaperCollectionLog_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperCollectionLogId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function PaperCollectionLog_IsExist(lngPaperCollectionLogId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperCollectionLogId": lngPaperCollectionLogId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_IsExist = PaperCollectionLog_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngPaperCollectionLogId:所给的关键字
     * @returns 对象
    */
    async function PaperCollectionLog_IsExist_Cache(lngPaperCollectionLogId, strUpdUser) {
        const strThisFuncName = "IsExist_Cache";
        const arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_Cache(strUpdUser);
        if (arrPaperCollectionLogObjLst_Cache == null)
            return false;
        try {
            const arrPaperCollectionLog_Sel = arrPaperCollectionLogObjLst_Cache.filter(x => x.paperCollectionLogId == lngPaperCollectionLogId);
            if (arrPaperCollectionLog_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperCollectionLogId, exports.paperCollectionLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.PaperCollectionLog_IsExist_Cache = PaperCollectionLog_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperCollectionLogId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function PaperCollectionLog_IsExistAsync(lngPaperCollectionLogId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperCollectionLogId": lngPaperCollectionLogId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_IsExistAsync = PaperCollectionLog_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function PaperCollectionLog_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetRecCountByCondAsync = PaperCollectionLog_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objPaperCollectionLog_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function PaperCollectionLog_GetRecCountByCond_Cache(objPaperCollectionLog_Cond, strUpdUser) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrPaperCollectionLogObjLst_Cache = await PaperCollectionLog_GetObjLst_Cache(strUpdUser);
        if (arrPaperCollectionLogObjLst_Cache == null)
            return 0;
        let arrPaperCollectionLog_Sel = arrPaperCollectionLogObjLst_Cache;
        if (objPaperCollectionLog_Cond.sf_FldComparisonOp == null || objPaperCollectionLog_Cond.sf_FldComparisonOp == "")
            return arrPaperCollectionLog_Sel.length;
        const dicFldComparisonOp = JSON.parse(objPaperCollectionLog_Cond.sf_FldComparisonOp);
        //console.log("clsPaperCollectionLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperCollectionLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperCollectionLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperCollectionLog_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objPaperCollectionLog_Cond), exports.paperCollectionLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.PaperCollectionLog_GetRecCountByCond_Cache = PaperCollectionLog_GetRecCountByCond_Cache;
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
    async function PaperCollectionLog_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetMaxStrIdByPrefix = PaperCollectionLog_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function PaperCollectionLog_GetWebApiUrl(strController, strAction) {
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
    exports.PaperCollectionLog_GetWebApiUrl = PaperCollectionLog_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function PaperCollectionLog_ReFreshCache(strUpdUser) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strUpdUser) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strUpdUser]不能为空！(In clsPaperCollectionLogWApi.clsPaperCollectionLogWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN._CurrTabName, strUpdUser);
        switch (clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.CacheModeId) {
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
    exports.PaperCollectionLog_ReFreshCache = PaperCollectionLog_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function PaperCollectionLog_ReFreshThisCache(strUpdUser) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN._CurrTabName, strUpdUser);
            switch (clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.CacheModeId) {
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
    exports.PaperCollectionLog_ReFreshThisCache = PaperCollectionLog_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperCollectionLog_CheckPropertyNew(pobjPaperCollectionLogEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.updUser) === true) {
            throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 论文收藏)!(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperCollectionLogEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.paperId)(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjPaperCollectionLogEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.updUser)(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjPaperCollectionLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.updDate)(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.meno) == false && (0, clsString_js_2.GetStrLen)(pobjPaperCollectionLogEN.meno) > 2000) {
            throw new Error("(errid:Watl000059)字段[备注(meno)]的长度不能超过2000(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.meno)(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperCollectionLogEN.paperCollectionLogId && undefined !== pobjPaperCollectionLogEN.paperCollectionLogId && clsString_js_1.tzDataType.isNumber(pobjPaperCollectionLogEN.paperCollectionLogId) === false) {
            throw new Error("(errid:Watl000060)字段[论文收藏Id(paperCollectionLogId)]的值:[$(pobjPaperCollectionLogEN.paperCollectionLogId)], 非法，应该为数值型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.paperId) == false && undefined !== pobjPaperCollectionLogEN.paperId && clsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperCollectionLogEN.paperId)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.updUser) == false && undefined !== pobjPaperCollectionLogEN.updUser && clsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperCollectionLogEN.updUser)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.updDate) == false && undefined !== pobjPaperCollectionLogEN.updDate && clsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperCollectionLogEN.updDate)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.meno) == false && undefined !== pobjPaperCollectionLogEN.meno && clsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.meno) === false) {
            throw new Error("(errid:Watl000060)字段[备注(meno)]的值:[$(pobjPaperCollectionLogEN.meno)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjPaperCollectionLogEN.SetIsCheckProperty(true);
    }
    exports.PaperCollectionLog_CheckPropertyNew = PaperCollectionLog_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperCollectionLog_CheckProperty4Update(pobjPaperCollectionLogEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperCollectionLogEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.paperId)(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjPaperCollectionLogEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.updUser)(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjPaperCollectionLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.updDate)(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.meno) == false && (0, clsString_js_2.GetStrLen)(pobjPaperCollectionLogEN.meno) > 2000) {
            throw new Error("(errid:Watl000062)字段[备注(meno)]的长度不能超过2000(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.meno)(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperCollectionLogEN.paperCollectionLogId && undefined !== pobjPaperCollectionLogEN.paperCollectionLogId && clsString_js_1.tzDataType.isNumber(pobjPaperCollectionLogEN.paperCollectionLogId) === false) {
            throw new Error("(errid:Watl000063)字段[论文收藏Id(paperCollectionLogId)]的值:[$(pobjPaperCollectionLogEN.paperCollectionLogId)], 非法，应该为数值型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.paperId) == false && undefined !== pobjPaperCollectionLogEN.paperId && clsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperCollectionLogEN.paperId)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.updUser) == false && undefined !== pobjPaperCollectionLogEN.updUser && clsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperCollectionLogEN.updUser)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.updDate) == false && undefined !== pobjPaperCollectionLogEN.updDate && clsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperCollectionLogEN.updDate)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperCollectionLogEN.meno) == false && undefined !== pobjPaperCollectionLogEN.meno && clsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.meno) === false) {
            throw new Error("(errid:Watl000063)字段[备注(meno)]的值:[$(pobjPaperCollectionLogEN.meno)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjPaperCollectionLogEN.paperCollectionLogId
            || pobjPaperCollectionLogEN.paperCollectionLogId != null && pobjPaperCollectionLogEN.paperCollectionLogId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[论文收藏Id]不能为空(In 论文收藏)!(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjPaperCollectionLogEN.SetIsCheckProperty(true);
    }
    exports.PaperCollectionLog_CheckProperty4Update = PaperCollectionLog_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperCollectionLog_GetJSONStrByObj(pobjPaperCollectionLogEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjPaperCollectionLogEN.sf_UpdFldSetStr = pobjPaperCollectionLogEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjPaperCollectionLogEN);
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
    exports.PaperCollectionLog_GetJSONStrByObj = PaperCollectionLog_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function PaperCollectionLog_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrPaperCollectionLogObjLst = new Array();
        if (strJSON === "") {
            return arrPaperCollectionLogObjLst;
        }
        try {
            arrPaperCollectionLogObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrPaperCollectionLogObjLst;
        }
        return arrPaperCollectionLogObjLst;
    }
    exports.PaperCollectionLog_GetObjLstByJSONStr = PaperCollectionLog_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrPaperCollectionLogObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function PaperCollectionLog_GetObjLstByJSONObjLst(arrPaperCollectionLogObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrPaperCollectionLogObjLst = new Array();
        for (const objInFor of arrPaperCollectionLogObjLstS) {
            const obj1 = PaperCollectionLog_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrPaperCollectionLogObjLst.push(obj1);
        }
        return arrPaperCollectionLogObjLst;
    }
    exports.PaperCollectionLog_GetObjLstByJSONObjLst = PaperCollectionLog_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperCollectionLog_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjPaperCollectionLogEN = new clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN();
        if (strJSON === "") {
            return pobjPaperCollectionLogEN;
        }
        try {
            pobjPaperCollectionLogEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjPaperCollectionLogEN;
        }
        return pobjPaperCollectionLogEN;
    }
    exports.PaperCollectionLog_GetObjByJSONStr = PaperCollectionLog_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function PaperCollectionLog_GetCombineCondition(objPaperCollectionLog_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId) == true) {
            const strComparisonOp_PaperCollectionLogId = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId, objPaperCollectionLog_Cond.paperCollectionLogId, strComparisonOp_PaperCollectionLogId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperId, objPaperCollectionLog_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdUser, objPaperCollectionLog_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate, objPaperCollectionLog_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_Meno) == true) {
            const strComparisonOp_Meno = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_Meno];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_Meno, objPaperCollectionLog_Cond.meno, strComparisonOp_Meno);
        }
        return strWhereCond;
    }
    exports.PaperCollectionLog_GetCombineCondition = PaperCollectionLog_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--PaperCollectionLog(论文收藏),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngPaperCollectionLogId: 论文收藏Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperCollectionLog_GetUniCondStr_PaperCollectionLogId(objPaperCollectionLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperCollectionLogId = '{0}'", objPaperCollectionLogEN.paperCollectionLogId);
        return strWhereCond;
    }
    exports.PaperCollectionLog_GetUniCondStr_PaperCollectionLogId = PaperCollectionLog_GetUniCondStr_PaperCollectionLogId;
    /**
    *获取唯一性条件串(Uniqueness)--PaperCollectionLog(论文收藏),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngPaperCollectionLogId: 论文收藏Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperCollectionLog_GetUniCondStr4Update_PaperCollectionLogId(objPaperCollectionLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperCollectionLogId <> '{0}'", objPaperCollectionLogEN.paperCollectionLogId);
        strWhereCond += (0, clsString_js_2.Format)(" and PaperCollectionLogId = '{0}'", objPaperCollectionLogEN.paperCollectionLogId);
        return strWhereCond;
    }
    exports.PaperCollectionLog_GetUniCondStr4Update_PaperCollectionLogId = PaperCollectionLog_GetUniCondStr4Update_PaperCollectionLogId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objPaperCollectionLogENS:源对象
     * @param objPaperCollectionLogENT:目标对象
    */
    function PaperCollectionLog_CopyObjTo(objPaperCollectionLogENS, objPaperCollectionLogENT) {
        objPaperCollectionLogENT.paperCollectionLogId = objPaperCollectionLogENS.paperCollectionLogId; //论文收藏Id
        objPaperCollectionLogENT.paperId = objPaperCollectionLogENS.paperId; //论文Id
        objPaperCollectionLogENT.updUser = objPaperCollectionLogENS.updUser; //修改人
        objPaperCollectionLogENT.updDate = objPaperCollectionLogENS.updDate; //修改日期
        objPaperCollectionLogENT.meno = objPaperCollectionLogENS.meno; //备注
        objPaperCollectionLogENT.sf_UpdFldSetStr = objPaperCollectionLogENS.updFldString; //sf_UpdFldSetStr
    }
    exports.PaperCollectionLog_CopyObjTo = PaperCollectionLog_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objPaperCollectionLogENS:源对象
     * @param objPaperCollectionLogENT:目标对象
    */
    function PaperCollectionLog_GetObjFromJsonObj(objPaperCollectionLogENS) {
        const objPaperCollectionLogENT = new clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperCollectionLogENT, objPaperCollectionLogENS);
        return objPaperCollectionLogENT;
    }
    exports.PaperCollectionLog_GetObjFromJsonObj = PaperCollectionLog_GetObjFromJsonObj;
});
