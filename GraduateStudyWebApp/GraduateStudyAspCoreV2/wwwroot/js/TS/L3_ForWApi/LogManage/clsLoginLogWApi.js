/**
* 类名:clsLoginLogWApi
* 表名:LoginLog(01120357)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:52:52
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:日志管理(LogManage)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/LogManage/clsLoginLogEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.LoginLog_GetObjFromJsonObj = exports.LoginLog_CopyObjTo = exports.LoginLog_GetUniCondStr4Update_LoginUserId_LoginIP_LoginTime = exports.LoginLog_GetUniCondStr_LoginUserId_LoginIP_LoginTime = exports.LoginLog_GetCombineCondition = exports.LoginLog_GetObjByJSONStr = exports.LoginLog_GetObjLstByJSONObjLst = exports.LoginLog_GetObjLstByJSONStr = exports.LoginLog_GetJSONStrByObj = exports.LoginLog_CheckProperty4Update = exports.LoginLog_CheckPropertyNew = exports.LoginLog_ReFreshThisCache = exports.LoginLog_ReFreshCache = exports.LoginLog_GetWebApiUrl = exports.LoginLog_GetMaxStrIdByPrefix = exports.LoginLog_GetRecCountByCond_Cache = exports.LoginLog_GetRecCountByCondAsync = exports.LoginLog_IsExistAsync = exports.LoginLog_IsExist_Cache = exports.LoginLog_IsExist = exports.LoginLog_IsExistRecordAsync = exports.LoginLog_IsExistRecord_Cache = exports.LoginLog_UpdateWithConditionAsync = exports.LoginLog_UpdateRecordAsync = exports.LoginLog_AddNewRecordWithReturnKey = exports.LoginLog_AddNewRecordWithReturnKeyAsync = exports.LoginLog_AddNewRecordAsync = exports.LoginLog_DelLoginLogsByCondAsync = exports.LoginLog_DelLoginLogsAsync = exports.LoginLog_DelRecordAsync = exports.LoginLog_GetObjLstByPagerAsync = exports.LoginLog_GetObjLstByPager_Cache = exports.LoginLog_GetObjLstByRange = exports.LoginLog_GetObjLstByRangeAsync = exports.LoginLog_GetTopObjLstAsync = exports.LoginLog_GetObjLstByLoginLogIdLst_Cache = exports.LoginLog_GetObjLstByLoginLogIdLstAsync = exports.LoginLog_GetSubObjLst_Cache = exports.LoginLog_GetObjLst_PureCache = exports.LoginLog_GetObjLst_Cache = exports.LoginLog_GetObjLst_sessionStorage_PureCache = exports.LoginLog_GetObjLst_sessionStorage = exports.LoginLog_GetObjLstAsync = exports.LoginLog_GetObjLst_localStorage_PureCache = exports.LoginLog_GetObjLst_localStorage = exports.LoginLog_GetObjLst_ClientCache = exports.LoginLog_GetFirstObjAsync = exports.LoginLog_GetFirstID = exports.LoginLog_GetFirstIDAsync = exports.LoginLog_funcKey = exports.LoginLog_FilterFunByKey = exports.LoginLog_SortFunByKey = exports.LoginLog_SortFun_Defa_2Fld = exports.LoginLog_SortFun_Defa = exports.LoginLog_func = exports.LoginLog_UpdateObjInLst_Cache = exports.LoginLog_GetObjByLoginLogId_localStorage = exports.LoginLog_GetObjByLoginLogId_Cache = exports.LoginLog_GetObjByLoginLogIdAsync = exports.loginLog_ConstructorName = exports.loginLog_Controller = void 0;
    /**
     * 登录日志(LoginLog)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsLoginLogEN_js_1 = require("../../L0_Entity/LogManage/clsLoginLogEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.loginLog_Controller = "LoginLogApi";
    exports.loginLog_ConstructorName = "loginLog";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngLoginLogId:关键字
    * @returns 对象
    **/
    async function LoginLog_GetObjByLoginLogIdAsync(lngLoginLogId) {
        const strThisFuncName = "GetObjByLoginLogIdAsync";
        if (lngLoginLogId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngLoginLogId]不能为空！(In clsLoginLogWApi.GetObjByLoginLogIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByLoginLogId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngLoginLogId": lngLoginLogId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objLoginLog = LoginLog_GetObjFromJsonObj(returnObj);
                return objLoginLog;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_GetObjByLoginLogIdAsync = LoginLog_GetObjByLoginLogIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngLoginLogId:所给的关键字
     * @returns 对象
    */
    async function LoginLog_GetObjByLoginLogId_Cache(lngLoginLogId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByLoginLogId_Cache";
        if (lngLoginLogId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngLoginLogId]不能为空！(In clsLoginLogWApi.GetObjByLoginLogId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
        try {
            const arrLoginLog_Sel = arrLoginLogObjLst_Cache.filter(x => x.loginLogId == lngLoginLogId);
            let objLoginLog;
            if (arrLoginLog_Sel.length > 0) {
                objLoginLog = arrLoginLog_Sel[0];
                return objLoginLog;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objLoginLog_Const = await LoginLog_GetObjByLoginLogIdAsync(lngLoginLogId);
                    if (objLoginLog_Const != null) {
                        LoginLog_ReFreshThisCache();
                        return objLoginLog_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngLoginLogId, exports.loginLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.LoginLog_GetObjByLoginLogId_Cache = LoginLog_GetObjByLoginLogId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngLoginLogId:所给的关键字
     * @returns 对象
    */
    async function LoginLog_GetObjByLoginLogId_localStorage(lngLoginLogId) {
        const strThisFuncName = "GetObjByLoginLogId_localStorage";
        if (lngLoginLogId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngLoginLogId]不能为空！(In clsLoginLogWApi.GetObjByLoginLogId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsLoginLogEN_js_1.clsLoginLogEN._CurrTabName, lngLoginLogId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objLoginLog_Cache = JSON.parse(strTempObj);
            return objLoginLog_Cache;
        }
        try {
            const objLoginLog = await LoginLog_GetObjByLoginLogIdAsync(lngLoginLogId);
            if (objLoginLog != null) {
                localStorage.setItem(strKey, JSON.stringify(objLoginLog));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objLoginLog;
            }
            return objLoginLog;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngLoginLogId, exports.loginLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.LoginLog_GetObjByLoginLogId_localStorage = LoginLog_GetObjByLoginLogId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objLoginLog:所给的对象
     * @returns 对象
    */
    async function LoginLog_UpdateObjInLst_Cache(objLoginLog) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
            const obj = arrLoginLogObjLst_Cache.find(x => x.loginUserId == objLoginLog.loginUserId && x.loginIP == objLoginLog.loginIP && x.loginTime == objLoginLog.loginTime);
            if (obj != null) {
                objLoginLog.loginLogId = obj.loginLogId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objLoginLog);
            }
            else {
                arrLoginLogObjLst_Cache.push(objLoginLog);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.loginLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.LoginLog_UpdateObjInLst_Cache = LoginLog_UpdateObjInLst_Cache;
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
    async function LoginLog_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsLoginLogEN_js_1.clsLoginLogEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsLoginLogEN_js_1.clsLoginLogEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngLoginLogId = Number(strInValue);
        if (lngLoginLogId == 0) {
            return "";
        }
        const objLoginLog = await LoginLog_GetObjByLoginLogId_Cache(lngLoginLogId);
        if (objLoginLog == null)
            return "";
        if (objLoginLog.GetFldValue(strOutFldName) == null)
            return "";
        return objLoginLog.GetFldValue(strOutFldName).toString();
    }
    exports.LoginLog_func = LoginLog_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function LoginLog_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.loginLogId - b.loginLogId;
    }
    exports.LoginLog_SortFun_Defa = LoginLog_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function LoginLog_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.loginLogNumber == b.loginLogNumber)
            return a.loginIP.localeCompare(b.loginIP);
        else
            return a.loginLogNumber.localeCompare(b.loginLogNumber);
    }
    exports.LoginLog_SortFun_Defa_2Fld = LoginLog_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function LoginLog_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogId:
                    return (a, b) => {
                        return a.loginLogId - b.loginLogId;
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogNumber:
                    return (a, b) => {
                        if (a.loginLogNumber == null)
                            return -1;
                        if (b.loginLogNumber == null)
                            return 1;
                        return a.loginLogNumber.localeCompare(b.loginLogNumber);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginIP:
                    return (a, b) => {
                        if (a.loginIP == null)
                            return -1;
                        if (b.loginIP == null)
                            return 1;
                        return a.loginIP.localeCompare(b.loginIP);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_FailReason:
                    return (a, b) => {
                        if (a.failReason == null)
                            return -1;
                        if (b.failReason == null)
                            return 1;
                        return a.failReason.localeCompare(b.failReason);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginResult:
                    return (a, b) => {
                        if (a.loginResult == null)
                            return -1;
                        if (b.loginResult == null)
                            return 1;
                        return a.loginResult.localeCompare(b.loginResult);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginTime:
                    return (a, b) => {
                        if (a.loginTime == null)
                            return -1;
                        if (b.loginTime == null)
                            return 1;
                        return a.loginTime.localeCompare(b.loginTime);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginUserId:
                    return (a, b) => {
                        if (a.loginUserId == null)
                            return -1;
                        if (b.loginUserId == null)
                            return 1;
                        return a.loginUserId.localeCompare(b.loginUserId);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_OnlineTime:
                    return (a, b) => {
                        if (a.onlineTime == null)
                            return -1;
                        if (b.onlineTime == null)
                            return 1;
                        return a.onlineTime.localeCompare(b.onlineTime);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_OutTime:
                    return (a, b) => {
                        if (a.outTime == null)
                            return -1;
                        if (b.outTime == null)
                            return 1;
                        return a.outTime.localeCompare(b.outTime);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[LoginLog]中不存在！(in ${exports.loginLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogId:
                    return (a, b) => {
                        return b.loginLogId - a.loginLogId;
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogNumber:
                    return (a, b) => {
                        if (b.loginLogNumber == null)
                            return -1;
                        if (a.loginLogNumber == null)
                            return 1;
                        return b.loginLogNumber.localeCompare(a.loginLogNumber);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginIP:
                    return (a, b) => {
                        if (b.loginIP == null)
                            return -1;
                        if (a.loginIP == null)
                            return 1;
                        return b.loginIP.localeCompare(a.loginIP);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_FailReason:
                    return (a, b) => {
                        if (b.failReason == null)
                            return -1;
                        if (a.failReason == null)
                            return 1;
                        return b.failReason.localeCompare(a.failReason);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginResult:
                    return (a, b) => {
                        if (b.loginResult == null)
                            return -1;
                        if (a.loginResult == null)
                            return 1;
                        return b.loginResult.localeCompare(a.loginResult);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginTime:
                    return (a, b) => {
                        if (b.loginTime == null)
                            return -1;
                        if (a.loginTime == null)
                            return 1;
                        return b.loginTime.localeCompare(a.loginTime);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginUserId:
                    return (a, b) => {
                        if (b.loginUserId == null)
                            return -1;
                        if (a.loginUserId == null)
                            return 1;
                        return b.loginUserId.localeCompare(a.loginUserId);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_OnlineTime:
                    return (a, b) => {
                        if (b.onlineTime == null)
                            return -1;
                        if (a.onlineTime == null)
                            return 1;
                        return b.onlineTime.localeCompare(a.onlineTime);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_OutTime:
                    return (a, b) => {
                        if (b.outTime == null)
                            return -1;
                        if (a.outTime == null)
                            return 1;
                        return b.outTime.localeCompare(a.outTime);
                    };
                case clsLoginLogEN_js_1.clsLoginLogEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[LoginLog]中不存在！(in ${exports.loginLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.LoginLog_SortFunByKey = LoginLog_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function LoginLog_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogId:
                return (obj) => {
                    return obj.loginLogId === value;
                };
            case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogNumber:
                return (obj) => {
                    return obj.loginLogNumber === value;
                };
            case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginIP:
                return (obj) => {
                    return obj.loginIP === value;
                };
            case clsLoginLogEN_js_1.clsLoginLogEN.con_FailReason:
                return (obj) => {
                    return obj.failReason === value;
                };
            case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginResult:
                return (obj) => {
                    return obj.loginResult === value;
                };
            case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginTime:
                return (obj) => {
                    return obj.loginTime === value;
                };
            case clsLoginLogEN_js_1.clsLoginLogEN.con_LoginUserId:
                return (obj) => {
                    return obj.loginUserId === value;
                };
            case clsLoginLogEN_js_1.clsLoginLogEN.con_OnlineTime:
                return (obj) => {
                    return obj.onlineTime === value;
                };
            case clsLoginLogEN_js_1.clsLoginLogEN.con_OutTime:
                return (obj) => {
                    return obj.outTime === value;
                };
            case clsLoginLogEN_js_1.clsLoginLogEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[LoginLog]中不存在！(in ${exports.loginLog_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.LoginLog_FilterFunByKey = LoginLog_FilterFunByKey;
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
    async function LoginLog_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrLoginLog = await LoginLog_GetObjLst_Cache();
        if (arrLoginLog == null)
            return [];
        let arrLoginLog_Sel = arrLoginLog;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrLoginLog_Sel = arrLoginLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrLoginLog_Sel.length == 0)
            return [];
        return arrLoginLog_Sel.map(x => x.loginLogId);
    }
    exports.LoginLog_funcKey = LoginLog_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function LoginLog_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_GetFirstIDAsync = LoginLog_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function LoginLog_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_GetFirstID = LoginLog_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function LoginLog_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
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
                const objLoginLog = LoginLog_GetObjFromJsonObj(returnObj);
                return objLoginLog;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_GetFirstObjAsync = LoginLog_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LoginLog_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsLoginLogEN_js_1.clsLoginLogEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsLoginLogEN_js_1.clsLoginLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsLoginLogEN_js_1.clsLoginLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrLoginLogExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrLoginLogObjLst_T = LoginLog_GetObjLstByJSONObjLst(arrLoginLogExObjLst_Cache);
            return arrLoginLogObjLst_T;
        }
        try {
            const arrLoginLogExObjLst = await LoginLog_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrLoginLogExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrLoginLogExObjLst.length);
            console.log(strInfo);
            return arrLoginLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.loginLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.LoginLog_GetObjLst_ClientCache = LoginLog_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LoginLog_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsLoginLogEN_js_1.clsLoginLogEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsLoginLogEN_js_1.clsLoginLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsLoginLogEN_js_1.clsLoginLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrLoginLogExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrLoginLogObjLst_T = LoginLog_GetObjLstByJSONObjLst(arrLoginLogExObjLst_Cache);
            return arrLoginLogObjLst_T;
        }
        try {
            const arrLoginLogExObjLst = await LoginLog_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrLoginLogExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrLoginLogExObjLst.length);
            console.log(strInfo);
            return arrLoginLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.loginLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.LoginLog_GetObjLst_localStorage = LoginLog_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LoginLog_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsLoginLogEN_js_1.clsLoginLogEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrLoginLogObjLst_Cache = JSON.parse(strTempObjLst);
            return arrLoginLogObjLst_Cache;
        }
        else
            return null;
    }
    exports.LoginLog_GetObjLst_localStorage_PureCache = LoginLog_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function LoginLog_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.loginLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = LoginLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_GetObjLstAsync = LoginLog_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LoginLog_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsLoginLogEN_js_1.clsLoginLogEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsLoginLogEN_js_1.clsLoginLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsLoginLogEN_js_1.clsLoginLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrLoginLogExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrLoginLogObjLst_T = LoginLog_GetObjLstByJSONObjLst(arrLoginLogExObjLst_Cache);
            return arrLoginLogObjLst_T;
        }
        try {
            const arrLoginLogExObjLst = await LoginLog_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrLoginLogExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrLoginLogExObjLst.length);
            console.log(strInfo);
            return arrLoginLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.loginLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.LoginLog_GetObjLst_sessionStorage = LoginLog_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LoginLog_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsLoginLogEN_js_1.clsLoginLogEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrLoginLogObjLst_Cache = JSON.parse(strTempObjLst);
            return arrLoginLogObjLst_Cache;
        }
        else
            return null;
    }
    exports.LoginLog_GetObjLst_sessionStorage_PureCache = LoginLog_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LoginLog_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrLoginLogObjLst_Cache;
        switch (clsLoginLogEN_js_1.clsLoginLogEN.CacheModeId) {
            case "04": //sessionStorage
                arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_ClientCache();
                break;
            default:
                arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_ClientCache();
                break;
        }
        const arrLoginLogObjLst = LoginLog_GetObjLstByJSONObjLst(arrLoginLogObjLst_Cache);
        return arrLoginLogObjLst_Cache;
    }
    exports.LoginLog_GetObjLst_Cache = LoginLog_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LoginLog_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrLoginLogObjLst_Cache;
        switch (clsLoginLogEN_js_1.clsLoginLogEN.CacheModeId) {
            case "04": //sessionStorage
                arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrLoginLogObjLst_Cache = null;
                break;
            default:
                arrLoginLogObjLst_Cache = null;
                break;
        }
        return arrLoginLogObjLst_Cache;
    }
    exports.LoginLog_GetObjLst_PureCache = LoginLog_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngLoginLogId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function LoginLog_GetSubObjLst_Cache(objLoginLog_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
        let arrLoginLog_Sel = arrLoginLogObjLst_Cache;
        if (objLoginLog_Cond.sf_FldComparisonOp == null || objLoginLog_Cond.sf_FldComparisonOp == "")
            return arrLoginLog_Sel;
        const dicFldComparisonOp = JSON.parse(objLoginLog_Cond.sf_FldComparisonOp);
        //console.log("clsLoginLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objLoginLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objLoginLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrLoginLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objLoginLog_Cond), exports.loginLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.LoginLog_GetSubObjLst_Cache = LoginLog_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrLoginLogId:关键字列表
    * @returns 对象列表
    **/
    async function LoginLog_GetObjLstByLoginLogIdLstAsync(arrLoginLogId) {
        const strThisFuncName = "GetObjLstByLoginLogIdLstAsync";
        const strAction = "GetObjLstByLoginLogIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrLoginLogId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.loginLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = LoginLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_GetObjLstByLoginLogIdLstAsync = LoginLog_GetObjLstByLoginLogIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngLoginLogIdLst:关键字列表
     * @returns 对象列表
    */
    async function LoginLog_GetObjLstByLoginLogIdLst_Cache(arrLoginLogIdLst) {
        const strThisFuncName = "GetObjLstByLoginLogIdLst_Cache";
        try {
            const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
            const arrLoginLog_Sel = arrLoginLogObjLst_Cache.filter(x => arrLoginLogIdLst.indexOf(x.loginLogId) > -1);
            return arrLoginLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrLoginLogIdLst.join(","), exports.loginLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.LoginLog_GetObjLstByLoginLogIdLst_Cache = LoginLog_GetObjLstByLoginLogIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function LoginLog_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.loginLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = LoginLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_GetTopObjLstAsync = LoginLog_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function LoginLog_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.loginLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = LoginLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_GetObjLstByRangeAsync = LoginLog_GetObjLstByRangeAsync;
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
    async function LoginLog_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_GetObjLstByRange = LoginLog_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function LoginLog_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
        if (arrLoginLogObjLst_Cache.length == 0)
            return arrLoginLogObjLst_Cache;
        let arrLoginLog_Sel = arrLoginLogObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objLoginLog_Cond = new clsLoginLogEN_js_1.clsLoginLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objLoginLog_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsLoginLogWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objLoginLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrLoginLog_Sel.length == 0)
                return arrLoginLog_Sel;
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
                arrLoginLog_Sel = arrLoginLog_Sel.sort(LoginLog_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrLoginLog_Sel = arrLoginLog_Sel.sort(objPagerPara.sortFun);
            }
            arrLoginLog_Sel = arrLoginLog_Sel.slice(intStart, intEnd);
            return arrLoginLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.loginLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.LoginLog_GetObjLstByPager_Cache = LoginLog_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function LoginLog_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.loginLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = LoginLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_GetObjLstByPagerAsync = LoginLog_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngLoginLogId:关键字
    * @returns 获取删除的结果
    **/
    async function LoginLog_DelRecordAsync(lngLoginLogId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngLoginLogId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_DelRecordAsync = LoginLog_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrLoginLogId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function LoginLog_DelLoginLogsAsync(arrLoginLogId) {
        const strThisFuncName = "DelLoginLogsAsync";
        const strAction = "DelLoginLogs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrLoginLogId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_DelLoginLogsAsync = LoginLog_DelLoginLogsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function LoginLog_DelLoginLogsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelLoginLogsByCondAsync";
        const strAction = "DelLoginLogsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_DelLoginLogsByCondAsync = LoginLog_DelLoginLogsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objLoginLogEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function LoginLog_AddNewRecordAsync(objLoginLogEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objLoginLogEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objLoginLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_AddNewRecordAsync = LoginLog_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objLoginLogEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function LoginLog_AddNewRecordWithReturnKeyAsync(objLoginLogEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objLoginLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_AddNewRecordWithReturnKeyAsync = LoginLog_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objLoginLogEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function LoginLog_AddNewRecordWithReturnKey(objLoginLogEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objLoginLogEN.loginLogId === null || objLoginLogEN.loginLogId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objLoginLogEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_AddNewRecordWithReturnKey = LoginLog_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objLoginLogEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function LoginLog_UpdateRecordAsync(objLoginLogEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objLoginLogEN.sf_UpdFldSetStr === undefined || objLoginLogEN.sf_UpdFldSetStr === null || objLoginLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objLoginLogEN.loginLogId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objLoginLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_UpdateRecordAsync = LoginLog_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objLoginLogEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function LoginLog_UpdateWithConditionAsync(objLoginLogEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objLoginLogEN.sf_UpdFldSetStr === undefined || objLoginLogEN.sf_UpdFldSetStr === null || objLoginLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objLoginLogEN.loginLogId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        objLoginLogEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objLoginLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_UpdateWithConditionAsync = LoginLog_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngLoginLogId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function LoginLog_IsExistRecord_Cache(objLoginLog_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
        if (arrLoginLogObjLst_Cache == null)
            return false;
        let arrLoginLog_Sel = arrLoginLogObjLst_Cache;
        if (objLoginLog_Cond.sf_FldComparisonOp == null || objLoginLog_Cond.sf_FldComparisonOp == "")
            return arrLoginLog_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objLoginLog_Cond.sf_FldComparisonOp);
        //console.log("clsLoginLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objLoginLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objLoginLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrLoginLog_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objLoginLog_Cond), exports.loginLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.LoginLog_IsExistRecord_Cache = LoginLog_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function LoginLog_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_IsExistRecordAsync = LoginLog_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngLoginLogId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function LoginLog_IsExist(lngLoginLogId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "LoginLogId": lngLoginLogId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_IsExist = LoginLog_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngLoginLogId:所给的关键字
     * @returns 对象
    */
    async function LoginLog_IsExist_Cache(lngLoginLogId) {
        const strThisFuncName = "IsExist_Cache";
        const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
        if (arrLoginLogObjLst_Cache == null)
            return false;
        try {
            const arrLoginLog_Sel = arrLoginLogObjLst_Cache.filter(x => x.loginLogId == lngLoginLogId);
            if (arrLoginLog_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngLoginLogId, exports.loginLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.LoginLog_IsExist_Cache = LoginLog_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngLoginLogId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function LoginLog_IsExistAsync(lngLoginLogId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngLoginLogId": lngLoginLogId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_IsExistAsync = LoginLog_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function LoginLog_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_GetRecCountByCondAsync = LoginLog_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objLoginLog_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function LoginLog_GetRecCountByCond_Cache(objLoginLog_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
        if (arrLoginLogObjLst_Cache == null)
            return 0;
        let arrLoginLog_Sel = arrLoginLogObjLst_Cache;
        if (objLoginLog_Cond.sf_FldComparisonOp == null || objLoginLog_Cond.sf_FldComparisonOp == "")
            return arrLoginLog_Sel.length;
        const dicFldComparisonOp = JSON.parse(objLoginLog_Cond.sf_FldComparisonOp);
        //console.log("clsLoginLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objLoginLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objLoginLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrLoginLog_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objLoginLog_Cond), exports.loginLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.LoginLog_GetRecCountByCond_Cache = LoginLog_GetRecCountByCond_Cache;
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
    async function LoginLog_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.loginLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.loginLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LoginLog_GetMaxStrIdByPrefix = LoginLog_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function LoginLog_GetWebApiUrl(strController, strAction) {
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
    exports.LoginLog_GetWebApiUrl = LoginLog_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function LoginLog_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsLoginLogEN_js_1.clsLoginLogEN._CurrTabName;
        switch (clsLoginLogEN_js_1.clsLoginLogEN.CacheModeId) {
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
    exports.LoginLog_ReFreshCache = LoginLog_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function LoginLog_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsLoginLogEN_js_1.clsLoginLogEN._CurrTabName;
            switch (clsLoginLogEN_js_1.clsLoginLogEN.CacheModeId) {
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
    exports.LoginLog_ReFreshThisCache = LoginLog_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function LoginLog_CheckPropertyNew(pobjLoginLogEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginLogNumber) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.loginLogNumber) > 500) {
            throw new Error("(errid:Watl000059)字段[LoginLogNumber(loginLogNumber)]的长度不能超过500(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginLogNumber)(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginIP) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.loginIP) > 200) {
            throw new Error("(errid:Watl000059)字段[LoginIP(loginIP)]的长度不能超过200(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginIP)(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.failReason) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.failReason) > 500) {
            throw new Error("(errid:Watl000059)字段[FailReason(failReason)]的长度不能超过500(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.failReason)(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginResult) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.loginResult) > 500) {
            throw new Error("(errid:Watl000059)字段[LoginResult(loginResult)]的长度不能超过500(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginResult)(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginTime) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.loginTime) > 20) {
            throw new Error("(errid:Watl000059)字段[LoginTime(loginTime)]的长度不能超过20(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginTime)(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginUserId) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.loginUserId) > 200) {
            throw new Error("(errid:Watl000059)字段[LoginUserId(loginUserId)]的长度不能超过200(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginUserId)(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.onlineTime) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.onlineTime) > 200) {
            throw new Error("(errid:Watl000059)字段[OnlineTime(onlineTime)]的长度不能超过200(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.onlineTime)(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.outTime) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.outTime) > 20) {
            throw new Error("(errid:Watl000059)字段[OutTime(outTime)]的长度不能超过20(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.outTime)(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.memo)(clsLoginLogBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjLoginLogEN.loginLogId && undefined !== pobjLoginLogEN.loginLogId && clsString_js_1.tzDataType.isNumber(pobjLoginLogEN.loginLogId) === false) {
            throw new Error("(errid:Watl000060)字段[LoginLogId(loginLogId)]的值:[$(pobjLoginLogEN.loginLogId)], 非法，应该为数值型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginLogNumber) == false && undefined !== pobjLoginLogEN.loginLogNumber && clsString_js_1.tzDataType.isString(pobjLoginLogEN.loginLogNumber) === false) {
            throw new Error("(errid:Watl000060)字段[LoginLogNumber(loginLogNumber)]的值:[$(pobjLoginLogEN.loginLogNumber)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginIP) == false && undefined !== pobjLoginLogEN.loginIP && clsString_js_1.tzDataType.isString(pobjLoginLogEN.loginIP) === false) {
            throw new Error("(errid:Watl000060)字段[LoginIP(loginIP)]的值:[$(pobjLoginLogEN.loginIP)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.failReason) == false && undefined !== pobjLoginLogEN.failReason && clsString_js_1.tzDataType.isString(pobjLoginLogEN.failReason) === false) {
            throw new Error("(errid:Watl000060)字段[FailReason(failReason)]的值:[$(pobjLoginLogEN.failReason)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginResult) == false && undefined !== pobjLoginLogEN.loginResult && clsString_js_1.tzDataType.isString(pobjLoginLogEN.loginResult) === false) {
            throw new Error("(errid:Watl000060)字段[LoginResult(loginResult)]的值:[$(pobjLoginLogEN.loginResult)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginTime) == false && undefined !== pobjLoginLogEN.loginTime && clsString_js_1.tzDataType.isString(pobjLoginLogEN.loginTime) === false) {
            throw new Error("(errid:Watl000060)字段[LoginTime(loginTime)]的值:[$(pobjLoginLogEN.loginTime)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginUserId) == false && undefined !== pobjLoginLogEN.loginUserId && clsString_js_1.tzDataType.isString(pobjLoginLogEN.loginUserId) === false) {
            throw new Error("(errid:Watl000060)字段[LoginUserId(loginUserId)]的值:[$(pobjLoginLogEN.loginUserId)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.onlineTime) == false && undefined !== pobjLoginLogEN.onlineTime && clsString_js_1.tzDataType.isString(pobjLoginLogEN.onlineTime) === false) {
            throw new Error("(errid:Watl000060)字段[OnlineTime(onlineTime)]的值:[$(pobjLoginLogEN.onlineTime)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.outTime) == false && undefined !== pobjLoginLogEN.outTime && clsString_js_1.tzDataType.isString(pobjLoginLogEN.outTime) === false) {
            throw new Error("(errid:Watl000060)字段[OutTime(outTime)]的值:[$(pobjLoginLogEN.outTime)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.memo) == false && undefined !== pobjLoginLogEN.memo && clsString_js_1.tzDataType.isString(pobjLoginLogEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjLoginLogEN.memo)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjLoginLogEN.SetIsCheckProperty(true);
    }
    exports.LoginLog_CheckPropertyNew = LoginLog_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function LoginLog_CheckProperty4Update(pobjLoginLogEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginLogNumber) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.loginLogNumber) > 500) {
            throw new Error("(errid:Watl000062)字段[LoginLogNumber(loginLogNumber)]的长度不能超过500(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginLogNumber)(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginIP) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.loginIP) > 200) {
            throw new Error("(errid:Watl000062)字段[LoginIP(loginIP)]的长度不能超过200(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginIP)(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.failReason) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.failReason) > 500) {
            throw new Error("(errid:Watl000062)字段[FailReason(failReason)]的长度不能超过500(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.failReason)(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginResult) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.loginResult) > 500) {
            throw new Error("(errid:Watl000062)字段[LoginResult(loginResult)]的长度不能超过500(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginResult)(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginTime) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.loginTime) > 20) {
            throw new Error("(errid:Watl000062)字段[LoginTime(loginTime)]的长度不能超过20(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginTime)(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginUserId) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.loginUserId) > 200) {
            throw new Error("(errid:Watl000062)字段[LoginUserId(loginUserId)]的长度不能超过200(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginUserId)(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.onlineTime) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.onlineTime) > 200) {
            throw new Error("(errid:Watl000062)字段[OnlineTime(onlineTime)]的长度不能超过200(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.onlineTime)(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.outTime) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.outTime) > 20) {
            throw new Error("(errid:Watl000062)字段[OutTime(outTime)]的长度不能超过20(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.outTime)(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjLoginLogEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.memo)(clsLoginLogBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjLoginLogEN.loginLogId && undefined !== pobjLoginLogEN.loginLogId && clsString_js_1.tzDataType.isNumber(pobjLoginLogEN.loginLogId) === false) {
            throw new Error("(errid:Watl000063)字段[LoginLogId(loginLogId)]的值:[$(pobjLoginLogEN.loginLogId)], 非法，应该为数值型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginLogNumber) == false && undefined !== pobjLoginLogEN.loginLogNumber && clsString_js_1.tzDataType.isString(pobjLoginLogEN.loginLogNumber) === false) {
            throw new Error("(errid:Watl000063)字段[LoginLogNumber(loginLogNumber)]的值:[$(pobjLoginLogEN.loginLogNumber)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginIP) == false && undefined !== pobjLoginLogEN.loginIP && clsString_js_1.tzDataType.isString(pobjLoginLogEN.loginIP) === false) {
            throw new Error("(errid:Watl000063)字段[LoginIP(loginIP)]的值:[$(pobjLoginLogEN.loginIP)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.failReason) == false && undefined !== pobjLoginLogEN.failReason && clsString_js_1.tzDataType.isString(pobjLoginLogEN.failReason) === false) {
            throw new Error("(errid:Watl000063)字段[FailReason(failReason)]的值:[$(pobjLoginLogEN.failReason)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginResult) == false && undefined !== pobjLoginLogEN.loginResult && clsString_js_1.tzDataType.isString(pobjLoginLogEN.loginResult) === false) {
            throw new Error("(errid:Watl000063)字段[LoginResult(loginResult)]的值:[$(pobjLoginLogEN.loginResult)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginTime) == false && undefined !== pobjLoginLogEN.loginTime && clsString_js_1.tzDataType.isString(pobjLoginLogEN.loginTime) === false) {
            throw new Error("(errid:Watl000063)字段[LoginTime(loginTime)]的值:[$(pobjLoginLogEN.loginTime)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.loginUserId) == false && undefined !== pobjLoginLogEN.loginUserId && clsString_js_1.tzDataType.isString(pobjLoginLogEN.loginUserId) === false) {
            throw new Error("(errid:Watl000063)字段[LoginUserId(loginUserId)]的值:[$(pobjLoginLogEN.loginUserId)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.onlineTime) == false && undefined !== pobjLoginLogEN.onlineTime && clsString_js_1.tzDataType.isString(pobjLoginLogEN.onlineTime) === false) {
            throw new Error("(errid:Watl000063)字段[OnlineTime(onlineTime)]的值:[$(pobjLoginLogEN.onlineTime)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.outTime) == false && undefined !== pobjLoginLogEN.outTime && clsString_js_1.tzDataType.isString(pobjLoginLogEN.outTime) === false) {
            throw new Error("(errid:Watl000063)字段[OutTime(outTime)]的值:[$(pobjLoginLogEN.outTime)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjLoginLogEN.memo) == false && undefined !== pobjLoginLogEN.memo && clsString_js_1.tzDataType.isString(pobjLoginLogEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjLoginLogEN.memo)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjLoginLogEN.loginLogId
            || pobjLoginLogEN.loginLogId != null && pobjLoginLogEN.loginLogId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[LoginLogId]不能为空(In 登录日志)!(clsLoginLogBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjLoginLogEN.SetIsCheckProperty(true);
    }
    exports.LoginLog_CheckProperty4Update = LoginLog_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function LoginLog_GetJSONStrByObj(pobjLoginLogEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjLoginLogEN.sf_UpdFldSetStr = pobjLoginLogEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjLoginLogEN);
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
    exports.LoginLog_GetJSONStrByObj = LoginLog_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function LoginLog_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrLoginLogObjLst = new Array();
        if (strJSON === "") {
            return arrLoginLogObjLst;
        }
        try {
            arrLoginLogObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrLoginLogObjLst;
        }
        return arrLoginLogObjLst;
    }
    exports.LoginLog_GetObjLstByJSONStr = LoginLog_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrLoginLogObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function LoginLog_GetObjLstByJSONObjLst(arrLoginLogObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrLoginLogObjLst = new Array();
        for (const objInFor of arrLoginLogObjLstS) {
            const obj1 = LoginLog_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrLoginLogObjLst.push(obj1);
        }
        return arrLoginLogObjLst;
    }
    exports.LoginLog_GetObjLstByJSONObjLst = LoginLog_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function LoginLog_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjLoginLogEN = new clsLoginLogEN_js_1.clsLoginLogEN();
        if (strJSON === "") {
            return pobjLoginLogEN;
        }
        try {
            pobjLoginLogEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjLoginLogEN;
        }
        return pobjLoginLogEN;
    }
    exports.LoginLog_GetObjByJSONStr = LoginLog_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function LoginLog_GetCombineCondition(objLoginLog_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogId) == true) {
            const strComparisonOp_LoginLogId = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogId, objLoginLog_Cond.loginLogId, strComparisonOp_LoginLogId);
        }
        if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogNumber) == true) {
            const strComparisonOp_LoginLogNumber = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogNumber];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsLoginLogEN_js_1.clsLoginLogEN.con_LoginLogNumber, objLoginLog_Cond.loginLogNumber, strComparisonOp_LoginLogNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN_js_1.clsLoginLogEN.con_LoginIP) == true) {
            const strComparisonOp_LoginIP = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN_js_1.clsLoginLogEN.con_LoginIP];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsLoginLogEN_js_1.clsLoginLogEN.con_LoginIP, objLoginLog_Cond.loginIP, strComparisonOp_LoginIP);
        }
        if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN_js_1.clsLoginLogEN.con_FailReason) == true) {
            const strComparisonOp_FailReason = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN_js_1.clsLoginLogEN.con_FailReason];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsLoginLogEN_js_1.clsLoginLogEN.con_FailReason, objLoginLog_Cond.failReason, strComparisonOp_FailReason);
        }
        if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN_js_1.clsLoginLogEN.con_LoginResult) == true) {
            const strComparisonOp_LoginResult = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN_js_1.clsLoginLogEN.con_LoginResult];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsLoginLogEN_js_1.clsLoginLogEN.con_LoginResult, objLoginLog_Cond.loginResult, strComparisonOp_LoginResult);
        }
        if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN_js_1.clsLoginLogEN.con_LoginTime) == true) {
            const strComparisonOp_LoginTime = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN_js_1.clsLoginLogEN.con_LoginTime];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsLoginLogEN_js_1.clsLoginLogEN.con_LoginTime, objLoginLog_Cond.loginTime, strComparisonOp_LoginTime);
        }
        if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN_js_1.clsLoginLogEN.con_LoginUserId) == true) {
            const strComparisonOp_LoginUserId = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN_js_1.clsLoginLogEN.con_LoginUserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsLoginLogEN_js_1.clsLoginLogEN.con_LoginUserId, objLoginLog_Cond.loginUserId, strComparisonOp_LoginUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN_js_1.clsLoginLogEN.con_OnlineTime) == true) {
            const strComparisonOp_OnlineTime = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN_js_1.clsLoginLogEN.con_OnlineTime];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsLoginLogEN_js_1.clsLoginLogEN.con_OnlineTime, objLoginLog_Cond.onlineTime, strComparisonOp_OnlineTime);
        }
        if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN_js_1.clsLoginLogEN.con_OutTime) == true) {
            const strComparisonOp_OutTime = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN_js_1.clsLoginLogEN.con_OutTime];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsLoginLogEN_js_1.clsLoginLogEN.con_OutTime, objLoginLog_Cond.outTime, strComparisonOp_OutTime);
        }
        if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN_js_1.clsLoginLogEN.con_Memo) == true) {
            const strComparisonOp_Memo = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN_js_1.clsLoginLogEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsLoginLogEN_js_1.clsLoginLogEN.con_Memo, objLoginLog_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.LoginLog_GetCombineCondition = LoginLog_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--LoginLog(登录日志),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strLoginUserId: LoginUserId(要求唯一的字段)
    * @param strLoginIP: LoginIP(要求唯一的字段)
    * @param strLoginTime: LoginTime(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function LoginLog_GetUniCondStr_LoginUserId_LoginIP_LoginTime(objLoginLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and LoginUserId = '{0}'", objLoginLogEN.loginUserId);
        strWhereCond += (0, clsString_js_2.Format)(" and LoginIP = '{0}'", objLoginLogEN.loginIP);
        strWhereCond += (0, clsString_js_2.Format)(" and LoginTime = '{0}'", objLoginLogEN.loginTime);
        return strWhereCond;
    }
    exports.LoginLog_GetUniCondStr_LoginUserId_LoginIP_LoginTime = LoginLog_GetUniCondStr_LoginUserId_LoginIP_LoginTime;
    /**
    *获取唯一性条件串(Uniqueness)--LoginLog(登录日志),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strLoginUserId: LoginUserId(要求唯一的字段)
    * @param strLoginIP: LoginIP(要求唯一的字段)
    * @param strLoginTime: LoginTime(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function LoginLog_GetUniCondStr4Update_LoginUserId_LoginIP_LoginTime(objLoginLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and LoginLogId <> '{0}'", objLoginLogEN.loginLogId);
        strWhereCond += (0, clsString_js_2.Format)(" and LoginUserId = '{0}'", objLoginLogEN.loginUserId);
        strWhereCond += (0, clsString_js_2.Format)(" and LoginIP = '{0}'", objLoginLogEN.loginIP);
        strWhereCond += (0, clsString_js_2.Format)(" and LoginTime = '{0}'", objLoginLogEN.loginTime);
        return strWhereCond;
    }
    exports.LoginLog_GetUniCondStr4Update_LoginUserId_LoginIP_LoginTime = LoginLog_GetUniCondStr4Update_LoginUserId_LoginIP_LoginTime;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objLoginLogENS:源对象
     * @param objLoginLogENT:目标对象
    */
    function LoginLog_CopyObjTo(objLoginLogENS, objLoginLogENT) {
        objLoginLogENT.loginLogId = objLoginLogENS.loginLogId; //LoginLogId
        objLoginLogENT.loginLogNumber = objLoginLogENS.loginLogNumber; //LoginLogNumber
        objLoginLogENT.loginIP = objLoginLogENS.loginIP; //LoginIP
        objLoginLogENT.failReason = objLoginLogENS.failReason; //FailReason
        objLoginLogENT.loginResult = objLoginLogENS.loginResult; //LoginResult
        objLoginLogENT.loginTime = objLoginLogENS.loginTime; //LoginTime
        objLoginLogENT.loginUserId = objLoginLogENS.loginUserId; //LoginUserId
        objLoginLogENT.onlineTime = objLoginLogENS.onlineTime; //OnlineTime
        objLoginLogENT.outTime = objLoginLogENS.outTime; //OutTime
        objLoginLogENT.memo = objLoginLogENS.memo; //备注
        objLoginLogENT.sf_UpdFldSetStr = objLoginLogENS.updFldString; //sf_UpdFldSetStr
    }
    exports.LoginLog_CopyObjTo = LoginLog_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objLoginLogENS:源对象
     * @param objLoginLogENT:目标对象
    */
    function LoginLog_GetObjFromJsonObj(objLoginLogENS) {
        const objLoginLogENT = new clsLoginLogEN_js_1.clsLoginLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objLoginLogENT, objLoginLogENS);
        return objLoginLogENT;
    }
    exports.LoginLog_GetObjFromJsonObj = LoginLog_GetObjFromJsonObj;
});
