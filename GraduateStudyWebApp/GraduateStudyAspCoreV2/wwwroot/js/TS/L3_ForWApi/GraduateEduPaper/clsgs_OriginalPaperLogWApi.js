/**
* 类名:clsgs_OriginalPaperLogWApi
* 表名:gs_OriginalPaperLog(01120680)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:54:16
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_OriginalPaperLog_GetObjFromJsonObj = exports.gs_OriginalPaperLog_CopyObjTo = exports.gs_OriginalPaperLog_GetUniCondStr4Update_PaperLogId = exports.gs_OriginalPaperLog_GetUniCondStr_PaperLogId = exports.gs_OriginalPaperLog_GetCombineCondition = exports.gs_OriginalPaperLog_GetObjByJSONStr = exports.gs_OriginalPaperLog_GetObjLstByJSONObjLst = exports.gs_OriginalPaperLog_GetObjLstByJSONStr = exports.gs_OriginalPaperLog_GetJSONStrByObj = exports.gs_OriginalPaperLog_CheckProperty4Update = exports.gs_OriginalPaperLog_CheckPropertyNew = exports.gs_OriginalPaperLog_GetWebApiUrl = exports.gs_OriginalPaperLog_GetMaxStrIdByPrefix = exports.gs_OriginalPaperLog_GetRecCountByCondAsync = exports.gs_OriginalPaperLog_IsExistAsync = exports.gs_OriginalPaperLog_IsExist = exports.gs_OriginalPaperLog_IsExistRecordAsync = exports.gs_OriginalPaperLog_UpdateWithConditionAsync = exports.gs_OriginalPaperLog_UpdateRecordAsync = exports.gs_OriginalPaperLog_AddNewRecordWithReturnKey = exports.gs_OriginalPaperLog_AddNewRecordWithReturnKeyAsync = exports.gs_OriginalPaperLog_AddNewRecordAsync = exports.gs_OriginalPaperLog_Delgs_OriginalPaperLogsByCondAsync = exports.gs_OriginalPaperLog_Delgs_OriginalPaperLogsAsync = exports.gs_OriginalPaperLog_DelRecordAsync = exports.gs_OriginalPaperLog_GetObjLstByPagerAsync = exports.gs_OriginalPaperLog_GetObjLstByRange = exports.gs_OriginalPaperLog_GetObjLstByRangeAsync = exports.gs_OriginalPaperLog_GetTopObjLstAsync = exports.gs_OriginalPaperLog_GetObjLstByPaperLogIdLstAsync = exports.gs_OriginalPaperLog_GetObjLstAsync = exports.gs_OriginalPaperLog_GetFirstObjAsync = exports.gs_OriginalPaperLog_GetFirstID = exports.gs_OriginalPaperLog_GetFirstIDAsync = exports.gs_OriginalPaperLog_FilterFunByKey = exports.gs_OriginalPaperLog_SortFunByKey = exports.gs_OriginalPaperLog_SortFun_Defa_2Fld = exports.gs_OriginalPaperLog_SortFun_Defa = exports.gs_OriginalPaperLog_GetObjByPaperLogIdAsync = exports.gs_OriginalPaperLog_ConstructorName = exports.gs_OriginalPaperLog_Controller = void 0;
    /**
     * 论文日志表(gs_OriginalPaperLog)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_OriginalPaperLogEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_OriginalPaperLog_Controller = "gs_OriginalPaperLogApi";
    exports.gs_OriginalPaperLog_ConstructorName = "gs_OriginalPaperLog";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperLogId:关键字
    * @returns 对象
    **/
    async function gs_OriginalPaperLog_GetObjByPaperLogIdAsync(lngPaperLogId) {
        const strThisFuncName = "GetObjByPaperLogIdAsync";
        if (lngPaperLogId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngPaperLogId]不能为空！(In clsgs_OriginalPaperLogWApi.GetObjByPaperLogIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperLogId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperLogId": lngPaperLogId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objgs_OriginalPaperLog = gs_OriginalPaperLog_GetObjFromJsonObj(returnObj);
                return objgs_OriginalPaperLog;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_GetObjByPaperLogIdAsync = gs_OriginalPaperLog_GetObjByPaperLogIdAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_OriginalPaperLog_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperLogId - b.paperLogId;
    }
    exports.gs_OriginalPaperLog_SortFun_Defa = gs_OriginalPaperLog_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_OriginalPaperLog_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.logTypeId.localeCompare(b.logTypeId);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.gs_OriginalPaperLog_SortFun_Defa_2Fld = gs_OriginalPaperLog_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_OriginalPaperLog_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_PaperLogId:
                    return (a, b) => {
                        return a.paperLogId - b.paperLogId;
                    };
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_LogTypeId:
                    return (a, b) => {
                        return a.logTypeId.localeCompare(b.logTypeId);
                    };
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_LogDescription:
                    return (a, b) => {
                        if (a.logDescription == null)
                            return -1;
                        if (b.logDescription == null)
                            return 1;
                        return a.logDescription.localeCompare(b.logDescription);
                    };
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_OriginalPaperLog]中不存在！(in ${exports.gs_OriginalPaperLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_PaperLogId:
                    return (a, b) => {
                        return b.paperLogId - a.paperLogId;
                    };
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_LogTypeId:
                    return (a, b) => {
                        return b.logTypeId.localeCompare(a.logTypeId);
                    };
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_LogDescription:
                    return (a, b) => {
                        if (b.logDescription == null)
                            return -1;
                        if (a.logDescription == null)
                            return 1;
                        return b.logDescription.localeCompare(a.logDescription);
                    };
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_OriginalPaperLog]中不存在！(in ${exports.gs_OriginalPaperLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_OriginalPaperLog_SortFunByKey = gs_OriginalPaperLog_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_OriginalPaperLog_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_PaperLogId:
                return (obj) => {
                    return obj.paperLogId === value;
                };
            case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_LogTypeId:
                return (obj) => {
                    return obj.logTypeId === value;
                };
            case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_LogDescription:
                return (obj) => {
                    return obj.logDescription === value;
                };
            case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_OriginalPaperLog]中不存在！(in ${exports.gs_OriginalPaperLog_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_OriginalPaperLog_FilterFunByKey = gs_OriginalPaperLog_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_OriginalPaperLog_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_GetFirstIDAsync = gs_OriginalPaperLog_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_OriginalPaperLog_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_GetFirstID = gs_OriginalPaperLog_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_OriginalPaperLog_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
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
                const objgs_OriginalPaperLog = gs_OriginalPaperLog_GetObjFromJsonObj(returnObj);
                return objgs_OriginalPaperLog;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_GetFirstObjAsync = gs_OriginalPaperLog_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_OriginalPaperLog_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_OriginalPaperLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_GetObjLstAsync = gs_OriginalPaperLog_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperLogId:关键字列表
    * @returns 对象列表
    **/
    async function gs_OriginalPaperLog_GetObjLstByPaperLogIdLstAsync(arrPaperLogId) {
        const strThisFuncName = "GetObjLstByPaperLogIdLstAsync";
        const strAction = "GetObjLstByPaperLogIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperLogId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_OriginalPaperLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_GetObjLstByPaperLogIdLstAsync = gs_OriginalPaperLog_GetObjLstByPaperLogIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_OriginalPaperLog_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_OriginalPaperLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_GetTopObjLstAsync = gs_OriginalPaperLog_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_OriginalPaperLog_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_OriginalPaperLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_GetObjLstByRangeAsync = gs_OriginalPaperLog_GetObjLstByRangeAsync;
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
    async function gs_OriginalPaperLog_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_GetObjLstByRange = gs_OriginalPaperLog_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_OriginalPaperLog_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_OriginalPaperLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_GetObjLstByPagerAsync = gs_OriginalPaperLog_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngPaperLogId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_OriginalPaperLog_DelRecordAsync(lngPaperLogId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngPaperLogId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_DelRecordAsync = gs_OriginalPaperLog_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperLogId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_OriginalPaperLog_Delgs_OriginalPaperLogsAsync(arrPaperLogId) {
        const strThisFuncName = "Delgs_OriginalPaperLogsAsync";
        const strAction = "Delgs_OriginalPaperLogs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperLogId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_Delgs_OriginalPaperLogsAsync = gs_OriginalPaperLog_Delgs_OriginalPaperLogsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_OriginalPaperLog_Delgs_OriginalPaperLogsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_OriginalPaperLogsByCondAsync";
        const strAction = "Delgs_OriginalPaperLogsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_Delgs_OriginalPaperLogsByCondAsync = gs_OriginalPaperLog_Delgs_OriginalPaperLogsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_OriginalPaperLogEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_OriginalPaperLog_AddNewRecordAsync(objgs_OriginalPaperLogEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_OriginalPaperLogEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_OriginalPaperLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_AddNewRecordAsync = gs_OriginalPaperLog_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_OriginalPaperLogEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_OriginalPaperLog_AddNewRecordWithReturnKeyAsync(objgs_OriginalPaperLogEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_OriginalPaperLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_AddNewRecordWithReturnKeyAsync = gs_OriginalPaperLog_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_OriginalPaperLogEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_OriginalPaperLog_AddNewRecordWithReturnKey(objgs_OriginalPaperLogEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_OriginalPaperLogEN.paperLogId === null || objgs_OriginalPaperLogEN.paperLogId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_OriginalPaperLogEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_AddNewRecordWithReturnKey = gs_OriginalPaperLog_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_OriginalPaperLogEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_OriginalPaperLog_UpdateRecordAsync(objgs_OriginalPaperLogEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_OriginalPaperLogEN.sf_UpdFldSetStr === undefined || objgs_OriginalPaperLogEN.sf_UpdFldSetStr === null || objgs_OriginalPaperLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_OriginalPaperLogEN.paperLogId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_OriginalPaperLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_UpdateRecordAsync = gs_OriginalPaperLog_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_OriginalPaperLogEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_OriginalPaperLog_UpdateWithConditionAsync(objgs_OriginalPaperLogEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_OriginalPaperLogEN.sf_UpdFldSetStr === undefined || objgs_OriginalPaperLogEN.sf_UpdFldSetStr === null || objgs_OriginalPaperLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_OriginalPaperLogEN.paperLogId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        objgs_OriginalPaperLogEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_OriginalPaperLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_UpdateWithConditionAsync = gs_OriginalPaperLog_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_OriginalPaperLog_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_IsExistRecordAsync = gs_OriginalPaperLog_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperLogId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_OriginalPaperLog_IsExist(lngPaperLogId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperLogId": lngPaperLogId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_IsExist = gs_OriginalPaperLog_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperLogId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_OriginalPaperLog_IsExistAsync(lngPaperLogId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperLogId": lngPaperLogId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_IsExistAsync = gs_OriginalPaperLog_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_OriginalPaperLog_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_GetRecCountByCondAsync = gs_OriginalPaperLog_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
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
    async function gs_OriginalPaperLog_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLog_GetMaxStrIdByPrefix = gs_OriginalPaperLog_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_OriginalPaperLog_GetWebApiUrl(strController, strAction) {
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
    exports.gs_OriginalPaperLog_GetWebApiUrl = gs_OriginalPaperLog_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_OriginalPaperLog_CheckPropertyNew(pobjgs_OriginalPaperLogEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.logTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[日志类型Id]不能为空(In 论文日志表)!(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文日志表(gs_OriginalPaperLog))!值:$(pobjgs_OriginalPaperLogEN.paperId)(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.logTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogEN.logTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[日志类型Id(logTypeId)]的长度不能超过2(In 论文日志表(gs_OriginalPaperLog))!值:$(pobjgs_OriginalPaperLogEN.logTypeId)(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.logDescription) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogEN.logDescription) > 500) {
            throw new Error("(errid:Watl000059)字段[日志描述(logDescription)]的长度不能超过500(In 论文日志表(gs_OriginalPaperLog))!值:$(pobjgs_OriginalPaperLogEN.logDescription)(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文日志表(gs_OriginalPaperLog))!值:$(pobjgs_OriginalPaperLogEN.updUser)(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文日志表(gs_OriginalPaperLog))!值:$(pobjgs_OriginalPaperLogEN.updDate)(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文日志表(gs_OriginalPaperLog))!值:$(pobjgs_OriginalPaperLogEN.memo)(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_OriginalPaperLogEN.paperLogId && undefined !== pobjgs_OriginalPaperLogEN.paperLogId && clsString_js_1.tzDataType.isNumber(pobjgs_OriginalPaperLogEN.paperLogId) === false) {
            throw new Error("(errid:Watl000060)字段[论文日志Id(paperLogId)]的值:[$(pobjgs_OriginalPaperLogEN.paperLogId)], 非法，应该为数值型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.paperId) == false && undefined !== pobjgs_OriginalPaperLogEN.paperId && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_OriginalPaperLogEN.paperId)], 非法，应该为字符型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.logTypeId) == false && undefined !== pobjgs_OriginalPaperLogEN.logTypeId && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogEN.logTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[日志类型Id(logTypeId)]的值:[$(pobjgs_OriginalPaperLogEN.logTypeId)], 非法，应该为字符型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.logDescription) == false && undefined !== pobjgs_OriginalPaperLogEN.logDescription && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogEN.logDescription) === false) {
            throw new Error("(errid:Watl000060)字段[日志描述(logDescription)]的值:[$(pobjgs_OriginalPaperLogEN.logDescription)], 非法，应该为字符型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.updUser) == false && undefined !== pobjgs_OriginalPaperLogEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_OriginalPaperLogEN.updUser)], 非法，应该为字符型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.updDate) == false && undefined !== pobjgs_OriginalPaperLogEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_OriginalPaperLogEN.updDate)], 非法，应该为字符型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.memo) == false && undefined !== pobjgs_OriginalPaperLogEN.memo && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_OriginalPaperLogEN.memo)], 非法，应该为字符型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_OriginalPaperLogEN.SetIsCheckProperty(true);
    }
    exports.gs_OriginalPaperLog_CheckPropertyNew = gs_OriginalPaperLog_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_OriginalPaperLog_CheckProperty4Update(pobjgs_OriginalPaperLogEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文日志表(gs_OriginalPaperLog))!值:$(pobjgs_OriginalPaperLogEN.paperId)(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.logTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogEN.logTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[日志类型Id(logTypeId)]的长度不能超过2(In 论文日志表(gs_OriginalPaperLog))!值:$(pobjgs_OriginalPaperLogEN.logTypeId)(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.logDescription) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogEN.logDescription) > 500) {
            throw new Error("(errid:Watl000062)字段[日志描述(logDescription)]的长度不能超过500(In 论文日志表(gs_OriginalPaperLog))!值:$(pobjgs_OriginalPaperLogEN.logDescription)(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文日志表(gs_OriginalPaperLog))!值:$(pobjgs_OriginalPaperLogEN.updUser)(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文日志表(gs_OriginalPaperLog))!值:$(pobjgs_OriginalPaperLogEN.updDate)(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文日志表(gs_OriginalPaperLog))!值:$(pobjgs_OriginalPaperLogEN.memo)(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_OriginalPaperLogEN.paperLogId && undefined !== pobjgs_OriginalPaperLogEN.paperLogId && clsString_js_1.tzDataType.isNumber(pobjgs_OriginalPaperLogEN.paperLogId) === false) {
            throw new Error("(errid:Watl000063)字段[论文日志Id(paperLogId)]的值:[$(pobjgs_OriginalPaperLogEN.paperLogId)], 非法，应该为数值型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.paperId) == false && undefined !== pobjgs_OriginalPaperLogEN.paperId && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_OriginalPaperLogEN.paperId)], 非法，应该为字符型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.logTypeId) == false && undefined !== pobjgs_OriginalPaperLogEN.logTypeId && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogEN.logTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[日志类型Id(logTypeId)]的值:[$(pobjgs_OriginalPaperLogEN.logTypeId)], 非法，应该为字符型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.logDescription) == false && undefined !== pobjgs_OriginalPaperLogEN.logDescription && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogEN.logDescription) === false) {
            throw new Error("(errid:Watl000063)字段[日志描述(logDescription)]的值:[$(pobjgs_OriginalPaperLogEN.logDescription)], 非法，应该为字符型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.updUser) == false && undefined !== pobjgs_OriginalPaperLogEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_OriginalPaperLogEN.updUser)], 非法，应该为字符型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.updDate) == false && undefined !== pobjgs_OriginalPaperLogEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_OriginalPaperLogEN.updDate)], 非法，应该为字符型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogEN.memo) == false && undefined !== pobjgs_OriginalPaperLogEN.memo && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_OriginalPaperLogEN.memo)], 非法，应该为字符型(In 论文日志表(gs_OriginalPaperLog))!(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_OriginalPaperLogEN.paperLogId
            || pobjgs_OriginalPaperLogEN.paperLogId != null && pobjgs_OriginalPaperLogEN.paperLogId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[论文日志Id]不能为空(In 论文日志表)!(clsgs_OriginalPaperLogBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_OriginalPaperLogEN.SetIsCheckProperty(true);
    }
    exports.gs_OriginalPaperLog_CheckProperty4Update = gs_OriginalPaperLog_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_OriginalPaperLog_GetJSONStrByObj(pobjgs_OriginalPaperLogEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_OriginalPaperLogEN.sf_UpdFldSetStr = pobjgs_OriginalPaperLogEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_OriginalPaperLogEN);
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
    exports.gs_OriginalPaperLog_GetJSONStrByObj = gs_OriginalPaperLog_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_OriginalPaperLog_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_OriginalPaperLogObjLst = new Array();
        if (strJSON === "") {
            return arrgs_OriginalPaperLogObjLst;
        }
        try {
            arrgs_OriginalPaperLogObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_OriginalPaperLogObjLst;
        }
        return arrgs_OriginalPaperLogObjLst;
    }
    exports.gs_OriginalPaperLog_GetObjLstByJSONStr = gs_OriginalPaperLog_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_OriginalPaperLogObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_OriginalPaperLog_GetObjLstByJSONObjLst(arrgs_OriginalPaperLogObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_OriginalPaperLogObjLst = new Array();
        for (const objInFor of arrgs_OriginalPaperLogObjLstS) {
            const obj1 = gs_OriginalPaperLog_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_OriginalPaperLogObjLst.push(obj1);
        }
        return arrgs_OriginalPaperLogObjLst;
    }
    exports.gs_OriginalPaperLog_GetObjLstByJSONObjLst = gs_OriginalPaperLog_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_OriginalPaperLog_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN();
        if (strJSON === "") {
            return pobjgs_OriginalPaperLogEN;
        }
        try {
            pobjgs_OriginalPaperLogEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_OriginalPaperLogEN;
        }
        return pobjgs_OriginalPaperLogEN;
    }
    exports.gs_OriginalPaperLog_GetObjByJSONStr = gs_OriginalPaperLog_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_OriginalPaperLog_GetCombineCondition(objgs_OriginalPaperLog_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_OriginalPaperLog_Cond.dicFldComparisonOp, clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_PaperLogId) == true) {
            const strComparisonOp_PaperLogId = objgs_OriginalPaperLog_Cond.dicFldComparisonOp[clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_PaperLogId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_PaperLogId, objgs_OriginalPaperLog_Cond.paperLogId, strComparisonOp_PaperLogId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_OriginalPaperLog_Cond.dicFldComparisonOp, clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objgs_OriginalPaperLog_Cond.dicFldComparisonOp[clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_PaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_PaperId, objgs_OriginalPaperLog_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_OriginalPaperLog_Cond.dicFldComparisonOp, clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_LogTypeId) == true) {
            const strComparisonOp_LogTypeId = objgs_OriginalPaperLog_Cond.dicFldComparisonOp[clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_LogTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_LogTypeId, objgs_OriginalPaperLog_Cond.logTypeId, strComparisonOp_LogTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_OriginalPaperLog_Cond.dicFldComparisonOp, clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_LogDescription) == true) {
            const strComparisonOp_LogDescription = objgs_OriginalPaperLog_Cond.dicFldComparisonOp[clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_LogDescription];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_LogDescription, objgs_OriginalPaperLog_Cond.logDescription, strComparisonOp_LogDescription);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_OriginalPaperLog_Cond.dicFldComparisonOp, clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_OriginalPaperLog_Cond.dicFldComparisonOp[clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_UpdUser, objgs_OriginalPaperLog_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_OriginalPaperLog_Cond.dicFldComparisonOp, clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_OriginalPaperLog_Cond.dicFldComparisonOp[clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_UpdDate, objgs_OriginalPaperLog_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_OriginalPaperLog_Cond.dicFldComparisonOp, clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_OriginalPaperLog_Cond.dicFldComparisonOp[clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN.con_Memo, objgs_OriginalPaperLog_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_OriginalPaperLog_GetCombineCondition = gs_OriginalPaperLog_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_OriginalPaperLog(论文日志表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngPaperLogId: 论文日志Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_OriginalPaperLog_GetUniCondStr_PaperLogId(objgs_OriginalPaperLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperLogId = '{0}'", objgs_OriginalPaperLogEN.paperLogId);
        return strWhereCond;
    }
    exports.gs_OriginalPaperLog_GetUniCondStr_PaperLogId = gs_OriginalPaperLog_GetUniCondStr_PaperLogId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_OriginalPaperLog(论文日志表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngPaperLogId: 论文日志Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_OriginalPaperLog_GetUniCondStr4Update_PaperLogId(objgs_OriginalPaperLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperLogId <> '{0}'", objgs_OriginalPaperLogEN.paperLogId);
        strWhereCond += (0, clsString_js_2.Format)(" and PaperLogId = '{0}'", objgs_OriginalPaperLogEN.paperLogId);
        return strWhereCond;
    }
    exports.gs_OriginalPaperLog_GetUniCondStr4Update_PaperLogId = gs_OriginalPaperLog_GetUniCondStr4Update_PaperLogId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_OriginalPaperLogENS:源对象
     * @param objgs_OriginalPaperLogENT:目标对象
    */
    function gs_OriginalPaperLog_CopyObjTo(objgs_OriginalPaperLogENS, objgs_OriginalPaperLogENT) {
        objgs_OriginalPaperLogENT.paperLogId = objgs_OriginalPaperLogENS.paperLogId; //论文日志Id
        objgs_OriginalPaperLogENT.paperId = objgs_OriginalPaperLogENS.paperId; //论文Id
        objgs_OriginalPaperLogENT.logTypeId = objgs_OriginalPaperLogENS.logTypeId; //日志类型Id
        objgs_OriginalPaperLogENT.logDescription = objgs_OriginalPaperLogENS.logDescription; //日志描述
        objgs_OriginalPaperLogENT.updUser = objgs_OriginalPaperLogENS.updUser; //修改人
        objgs_OriginalPaperLogENT.updDate = objgs_OriginalPaperLogENS.updDate; //修改日期
        objgs_OriginalPaperLogENT.memo = objgs_OriginalPaperLogENS.memo; //备注
        objgs_OriginalPaperLogENT.sf_UpdFldSetStr = objgs_OriginalPaperLogENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_OriginalPaperLog_CopyObjTo = gs_OriginalPaperLog_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_OriginalPaperLogENS:源对象
     * @param objgs_OriginalPaperLogENT:目标对象
    */
    function gs_OriginalPaperLog_GetObjFromJsonObj(objgs_OriginalPaperLogENS) {
        const objgs_OriginalPaperLogENT = new clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_OriginalPaperLogENT, objgs_OriginalPaperLogENS);
        return objgs_OriginalPaperLogENT;
    }
    exports.gs_OriginalPaperLog_GetObjFromJsonObj = gs_OriginalPaperLog_GetObjFromJsonObj;
});
