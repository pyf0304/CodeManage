/**
* 类名:clsgs_OriginalPaperLogTypeWApi
* 表名:gs_OriginalPaperLogType(01120679)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:54:52
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培参数(ParameterTable)
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
        define(["require", "exports", "axios", "../../L0_Entity/ParameterTable/clsgs_OriginalPaperLogTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_OriginalPaperLogType_GetObjFromJsonObj = exports.gs_OriginalPaperLogType_CopyObjTo = exports.gs_OriginalPaperLogType_GetUniCondStr4Update_LogTypeId = exports.gs_OriginalPaperLogType_GetUniCondStr_LogTypeId = exports.gs_OriginalPaperLogType_GetCombineCondition = exports.gs_OriginalPaperLogType_GetObjByJSONStr = exports.gs_OriginalPaperLogType_GetObjLstByJSONObjLst = exports.gs_OriginalPaperLogType_GetObjLstByJSONStr = exports.gs_OriginalPaperLogType_GetJSONStrByObj = exports.gs_OriginalPaperLogType_CheckProperty4Update = exports.gs_OriginalPaperLogType_CheckPropertyNew = exports.gs_OriginalPaperLogType_GetWebApiUrl = exports.gs_OriginalPaperLogType_GetMaxStrIdByPrefix = exports.gs_OriginalPaperLogType_GetMaxStrIdAsync = exports.gs_OriginalPaperLogType_GetRecCountByCondAsync = exports.gs_OriginalPaperLogType_IsExistAsync = exports.gs_OriginalPaperLogType_IsExist = exports.gs_OriginalPaperLogType_IsExistRecordAsync = exports.gs_OriginalPaperLogType_UpdateWithConditionAsync = exports.gs_OriginalPaperLogType_UpdateRecordAsync = exports.gs_OriginalPaperLogType_AddNewRecordWithReturnKey = exports.gs_OriginalPaperLogType_AddNewRecordWithReturnKeyAsync = exports.gs_OriginalPaperLogType_AddNewRecordWithMaxIdAsync = exports.gs_OriginalPaperLogType_AddNewRecordAsync = exports.gs_OriginalPaperLogType_Delgs_OriginalPaperLogTypesByCondAsync = exports.gs_OriginalPaperLogType_Delgs_OriginalPaperLogTypesAsync = exports.gs_OriginalPaperLogType_DelRecordAsync = exports.gs_OriginalPaperLogType_GetObjLstByPagerAsync = exports.gs_OriginalPaperLogType_GetObjLstByRange = exports.gs_OriginalPaperLogType_GetObjLstByRangeAsync = exports.gs_OriginalPaperLogType_GetTopObjLstAsync = exports.gs_OriginalPaperLogType_GetObjLstByLogTypeIdLstAsync = exports.gs_OriginalPaperLogType_GetObjLstAsync = exports.gs_OriginalPaperLogType_GetFirstObjAsync = exports.gs_OriginalPaperLogType_GetFirstID = exports.gs_OriginalPaperLogType_GetFirstIDAsync = exports.gs_OriginalPaperLogType_FilterFunByKey = exports.gs_OriginalPaperLogType_SortFunByKey = exports.gs_OriginalPaperLogType_SortFun_Defa_2Fld = exports.gs_OriginalPaperLogType_SortFun_Defa = exports.gs_OriginalPaperLogType_GetObjByLogTypeIdAsync = exports.gs_OriginalPaperLogType_ConstructorName = exports.gs_OriginalPaperLogType_Controller = void 0;
    /**
     * 论文日志类型(gs_OriginalPaperLogType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_OriginalPaperLogTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsgs_OriginalPaperLogTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_OriginalPaperLogType_Controller = "gs_OriginalPaperLogTypeApi";
    exports.gs_OriginalPaperLogType_ConstructorName = "gs_OriginalPaperLogType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strLogTypeId:关键字
    * @returns 对象
    **/
    async function gs_OriginalPaperLogType_GetObjByLogTypeIdAsync(strLogTypeId) {
        const strThisFuncName = "GetObjByLogTypeIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strLogTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strLogTypeId]不能为空！(In clsgs_OriginalPaperLogTypeWApi.GetObjByLogTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLogTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strLogTypeId]的长度:[{0}]不正确！(clsgs_OriginalPaperLogTypeWApi.GetObjByLogTypeIdAsync)", strLogTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByLogTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strLogTypeId": strLogTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objgs_OriginalPaperLogType = gs_OriginalPaperLogType_GetObjFromJsonObj(returnObj);
                return objgs_OriginalPaperLogType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetObjByLogTypeIdAsync = gs_OriginalPaperLogType_GetObjByLogTypeIdAsync;
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
    function gs_OriginalPaperLogType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.logTypeId.localeCompare(b.logTypeId);
    }
    exports.gs_OriginalPaperLogType_SortFun_Defa = gs_OriginalPaperLogType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_OriginalPaperLogType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.logTypeName == b.logTypeName)
            return a.updUser.localeCompare(b.updUser);
        else
            return a.logTypeName.localeCompare(b.logTypeName);
    }
    exports.gs_OriginalPaperLogType_SortFun_Defa_2Fld = gs_OriginalPaperLogType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_OriginalPaperLogType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_LogTypeId:
                    return (a, b) => {
                        return a.logTypeId.localeCompare(b.logTypeId);
                    };
                case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_LogTypeName:
                    return (a, b) => {
                        if (a.logTypeName == null)
                            return -1;
                        if (b.logTypeName == null)
                            return 1;
                        return a.logTypeName.localeCompare(b.logTypeName);
                    };
                case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_OriginalPaperLogType]中不存在！(in ${exports.gs_OriginalPaperLogType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_LogTypeId:
                    return (a, b) => {
                        return b.logTypeId.localeCompare(a.logTypeId);
                    };
                case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_LogTypeName:
                    return (a, b) => {
                        if (b.logTypeName == null)
                            return -1;
                        if (a.logTypeName == null)
                            return 1;
                        return b.logTypeName.localeCompare(a.logTypeName);
                    };
                case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_OriginalPaperLogType]中不存在！(in ${exports.gs_OriginalPaperLogType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_OriginalPaperLogType_SortFunByKey = gs_OriginalPaperLogType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_OriginalPaperLogType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_LogTypeId:
                return (obj) => {
                    return obj.logTypeId === value;
                };
            case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_LogTypeName:
                return (obj) => {
                    return obj.logTypeName === value;
                };
            case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_OriginalPaperLogType]中不存在！(in ${exports.gs_OriginalPaperLogType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_OriginalPaperLogType_FilterFunByKey = gs_OriginalPaperLogType_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_OriginalPaperLogType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetFirstIDAsync = gs_OriginalPaperLogType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_OriginalPaperLogType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetFirstID = gs_OriginalPaperLogType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_OriginalPaperLogType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
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
                const objgs_OriginalPaperLogType = gs_OriginalPaperLogType_GetObjFromJsonObj(returnObj);
                return objgs_OriginalPaperLogType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetFirstObjAsync = gs_OriginalPaperLogType_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_OriginalPaperLogType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_OriginalPaperLogType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetObjLstAsync = gs_OriginalPaperLogType_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrLogTypeId:关键字列表
    * @returns 对象列表
    **/
    async function gs_OriginalPaperLogType_GetObjLstByLogTypeIdLstAsync(arrLogTypeId) {
        const strThisFuncName = "GetObjLstByLogTypeIdLstAsync";
        const strAction = "GetObjLstByLogTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrLogTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_OriginalPaperLogType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetObjLstByLogTypeIdLstAsync = gs_OriginalPaperLogType_GetObjLstByLogTypeIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_OriginalPaperLogType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_OriginalPaperLogType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetTopObjLstAsync = gs_OriginalPaperLogType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_OriginalPaperLogType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_OriginalPaperLogType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetObjLstByRangeAsync = gs_OriginalPaperLogType_GetObjLstByRangeAsync;
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
    async function gs_OriginalPaperLogType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetObjLstByRange = gs_OriginalPaperLogType_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_OriginalPaperLogType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_OriginalPaperLogType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetObjLstByPagerAsync = gs_OriginalPaperLogType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strLogTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_OriginalPaperLogType_DelRecordAsync(strLogTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strLogTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_DelRecordAsync = gs_OriginalPaperLogType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrLogTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_OriginalPaperLogType_Delgs_OriginalPaperLogTypesAsync(arrLogTypeId) {
        const strThisFuncName = "Delgs_OriginalPaperLogTypesAsync";
        const strAction = "Delgs_OriginalPaperLogTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrLogTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_Delgs_OriginalPaperLogTypesAsync = gs_OriginalPaperLogType_Delgs_OriginalPaperLogTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_OriginalPaperLogType_Delgs_OriginalPaperLogTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_OriginalPaperLogTypesByCondAsync";
        const strAction = "Delgs_OriginalPaperLogTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_Delgs_OriginalPaperLogTypesByCondAsync = gs_OriginalPaperLogType_Delgs_OriginalPaperLogTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_OriginalPaperLogTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_OriginalPaperLogType_AddNewRecordAsync(objgs_OriginalPaperLogTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_OriginalPaperLogTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_OriginalPaperLogTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_AddNewRecordAsync = gs_OriginalPaperLogType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_OriginalPaperLogTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_OriginalPaperLogType_AddNewRecordWithMaxIdAsync(objgs_OriginalPaperLogTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_OriginalPaperLogTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_AddNewRecordWithMaxIdAsync = gs_OriginalPaperLogType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_OriginalPaperLogTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_OriginalPaperLogType_AddNewRecordWithReturnKeyAsync(objgs_OriginalPaperLogTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_OriginalPaperLogTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_AddNewRecordWithReturnKeyAsync = gs_OriginalPaperLogType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_OriginalPaperLogTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_OriginalPaperLogType_AddNewRecordWithReturnKey(objgs_OriginalPaperLogTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_OriginalPaperLogTypeEN.logTypeId === null || objgs_OriginalPaperLogTypeEN.logTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_OriginalPaperLogTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_AddNewRecordWithReturnKey = gs_OriginalPaperLogType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_OriginalPaperLogTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_OriginalPaperLogType_UpdateRecordAsync(objgs_OriginalPaperLogTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_OriginalPaperLogTypeEN.sf_UpdFldSetStr === undefined || objgs_OriginalPaperLogTypeEN.sf_UpdFldSetStr === null || objgs_OriginalPaperLogTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_OriginalPaperLogTypeEN.logTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_OriginalPaperLogTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_UpdateRecordAsync = gs_OriginalPaperLogType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_OriginalPaperLogTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_OriginalPaperLogType_UpdateWithConditionAsync(objgs_OriginalPaperLogTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_OriginalPaperLogTypeEN.sf_UpdFldSetStr === undefined || objgs_OriginalPaperLogTypeEN.sf_UpdFldSetStr === null || objgs_OriginalPaperLogTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_OriginalPaperLogTypeEN.logTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        objgs_OriginalPaperLogTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_OriginalPaperLogTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_UpdateWithConditionAsync = gs_OriginalPaperLogType_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_OriginalPaperLogType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_IsExistRecordAsync = gs_OriginalPaperLogType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strLogTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_OriginalPaperLogType_IsExist(strLogTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "LogTypeId": strLogTypeId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_IsExist = gs_OriginalPaperLogType_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strLogTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_OriginalPaperLogType_IsExistAsync(strLogTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strLogTypeId": strLogTypeId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_IsExistAsync = gs_OriginalPaperLogType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_OriginalPaperLogType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetRecCountByCondAsync = gs_OriginalPaperLogType_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_OriginalPaperLogType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetMaxStrIdAsync = gs_OriginalPaperLogType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_OriginalPaperLogType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_OriginalPaperLogType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_OriginalPaperLogType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_OriginalPaperLogType_GetMaxStrIdByPrefix = gs_OriginalPaperLogType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_OriginalPaperLogType_GetWebApiUrl(strController, strAction) {
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
    exports.gs_OriginalPaperLogType_GetWebApiUrl = gs_OriginalPaperLogType_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_OriginalPaperLogType_CheckPropertyNew(pobjgs_OriginalPaperLogTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.logTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogTypeEN.logTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[日志类型Id(logTypeId)]的长度不能超过2(In 论文日志类型(gs_OriginalPaperLogType))!值:$(pobjgs_OriginalPaperLogTypeEN.logTypeId)(clsgs_OriginalPaperLogTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.logTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogTypeEN.logTypeName) > 200) {
            throw new Error("(errid:Watl000059)字段[日志类型名(logTypeName)]的长度不能超过200(In 论文日志类型(gs_OriginalPaperLogType))!值:$(pobjgs_OriginalPaperLogTypeEN.logTypeName)(clsgs_OriginalPaperLogTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogTypeEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文日志类型(gs_OriginalPaperLogType))!值:$(pobjgs_OriginalPaperLogTypeEN.updUser)(clsgs_OriginalPaperLogTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文日志类型(gs_OriginalPaperLogType))!值:$(pobjgs_OriginalPaperLogTypeEN.updDate)(clsgs_OriginalPaperLogTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文日志类型(gs_OriginalPaperLogType))!值:$(pobjgs_OriginalPaperLogTypeEN.memo)(clsgs_OriginalPaperLogTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.logTypeId) == false && undefined !== pobjgs_OriginalPaperLogTypeEN.logTypeId && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogTypeEN.logTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[日志类型Id(logTypeId)]的值:[$(pobjgs_OriginalPaperLogTypeEN.logTypeId)], 非法，应该为字符型(In 论文日志类型(gs_OriginalPaperLogType))!(clsgs_OriginalPaperLogTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.logTypeName) == false && undefined !== pobjgs_OriginalPaperLogTypeEN.logTypeName && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogTypeEN.logTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[日志类型名(logTypeName)]的值:[$(pobjgs_OriginalPaperLogTypeEN.logTypeName)], 非法，应该为字符型(In 论文日志类型(gs_OriginalPaperLogType))!(clsgs_OriginalPaperLogTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.updUser) == false && undefined !== pobjgs_OriginalPaperLogTypeEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogTypeEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_OriginalPaperLogTypeEN.updUser)], 非法，应该为字符型(In 论文日志类型(gs_OriginalPaperLogType))!(clsgs_OriginalPaperLogTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.updDate) == false && undefined !== pobjgs_OriginalPaperLogTypeEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_OriginalPaperLogTypeEN.updDate)], 非法，应该为字符型(In 论文日志类型(gs_OriginalPaperLogType))!(clsgs_OriginalPaperLogTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.memo) == false && undefined !== pobjgs_OriginalPaperLogTypeEN.memo && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_OriginalPaperLogTypeEN.memo)], 非法，应该为字符型(In 论文日志类型(gs_OriginalPaperLogType))!(clsgs_OriginalPaperLogTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_OriginalPaperLogTypeEN.SetIsCheckProperty(true);
    }
    exports.gs_OriginalPaperLogType_CheckPropertyNew = gs_OriginalPaperLogType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_OriginalPaperLogType_CheckProperty4Update(pobjgs_OriginalPaperLogTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.logTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogTypeEN.logTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[日志类型Id(logTypeId)]的长度不能超过2(In 论文日志类型(gs_OriginalPaperLogType))!值:$(pobjgs_OriginalPaperLogTypeEN.logTypeId)(clsgs_OriginalPaperLogTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.logTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogTypeEN.logTypeName) > 200) {
            throw new Error("(errid:Watl000062)字段[日志类型名(logTypeName)]的长度不能超过200(In 论文日志类型(gs_OriginalPaperLogType))!值:$(pobjgs_OriginalPaperLogTypeEN.logTypeName)(clsgs_OriginalPaperLogTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogTypeEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文日志类型(gs_OriginalPaperLogType))!值:$(pobjgs_OriginalPaperLogTypeEN.updUser)(clsgs_OriginalPaperLogTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文日志类型(gs_OriginalPaperLogType))!值:$(pobjgs_OriginalPaperLogTypeEN.updDate)(clsgs_OriginalPaperLogTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_OriginalPaperLogTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文日志类型(gs_OriginalPaperLogType))!值:$(pobjgs_OriginalPaperLogTypeEN.memo)(clsgs_OriginalPaperLogTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.logTypeId) == false && undefined !== pobjgs_OriginalPaperLogTypeEN.logTypeId && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogTypeEN.logTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[日志类型Id(logTypeId)]的值:[$(pobjgs_OriginalPaperLogTypeEN.logTypeId)], 非法，应该为字符型(In 论文日志类型(gs_OriginalPaperLogType))!(clsgs_OriginalPaperLogTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.logTypeName) == false && undefined !== pobjgs_OriginalPaperLogTypeEN.logTypeName && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogTypeEN.logTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[日志类型名(logTypeName)]的值:[$(pobjgs_OriginalPaperLogTypeEN.logTypeName)], 非法，应该为字符型(In 论文日志类型(gs_OriginalPaperLogType))!(clsgs_OriginalPaperLogTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.updUser) == false && undefined !== pobjgs_OriginalPaperLogTypeEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogTypeEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_OriginalPaperLogTypeEN.updUser)], 非法，应该为字符型(In 论文日志类型(gs_OriginalPaperLogType))!(clsgs_OriginalPaperLogTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.updDate) == false && undefined !== pobjgs_OriginalPaperLogTypeEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_OriginalPaperLogTypeEN.updDate)], 非法，应该为字符型(In 论文日志类型(gs_OriginalPaperLogType))!(clsgs_OriginalPaperLogTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.memo) == false && undefined !== pobjgs_OriginalPaperLogTypeEN.memo && clsString_js_1.tzDataType.isString(pobjgs_OriginalPaperLogTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_OriginalPaperLogTypeEN.memo)], 非法，应该为字符型(In 论文日志类型(gs_OriginalPaperLogType))!(clsgs_OriginalPaperLogTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_OriginalPaperLogTypeEN.logTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[日志类型Id]不能为空(In 论文日志类型)!(clsgs_OriginalPaperLogTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_OriginalPaperLogTypeEN.SetIsCheckProperty(true);
    }
    exports.gs_OriginalPaperLogType_CheckProperty4Update = gs_OriginalPaperLogType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_OriginalPaperLogType_GetJSONStrByObj(pobjgs_OriginalPaperLogTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_OriginalPaperLogTypeEN.sf_UpdFldSetStr = pobjgs_OriginalPaperLogTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_OriginalPaperLogTypeEN);
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
    exports.gs_OriginalPaperLogType_GetJSONStrByObj = gs_OriginalPaperLogType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_OriginalPaperLogType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_OriginalPaperLogTypeObjLst = new Array();
        if (strJSON === "") {
            return arrgs_OriginalPaperLogTypeObjLst;
        }
        try {
            arrgs_OriginalPaperLogTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_OriginalPaperLogTypeObjLst;
        }
        return arrgs_OriginalPaperLogTypeObjLst;
    }
    exports.gs_OriginalPaperLogType_GetObjLstByJSONStr = gs_OriginalPaperLogType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_OriginalPaperLogTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_OriginalPaperLogType_GetObjLstByJSONObjLst(arrgs_OriginalPaperLogTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_OriginalPaperLogTypeObjLst = new Array();
        for (const objInFor of arrgs_OriginalPaperLogTypeObjLstS) {
            const obj1 = gs_OriginalPaperLogType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_OriginalPaperLogTypeObjLst.push(obj1);
        }
        return arrgs_OriginalPaperLogTypeObjLst;
    }
    exports.gs_OriginalPaperLogType_GetObjLstByJSONObjLst = gs_OriginalPaperLogType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_OriginalPaperLogType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_OriginalPaperLogTypeEN = new clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN();
        if (strJSON === "") {
            return pobjgs_OriginalPaperLogTypeEN;
        }
        try {
            pobjgs_OriginalPaperLogTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_OriginalPaperLogTypeEN;
        }
        return pobjgs_OriginalPaperLogTypeEN;
    }
    exports.gs_OriginalPaperLogType_GetObjByJSONStr = gs_OriginalPaperLogType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_OriginalPaperLogType_GetCombineCondition(objgs_OriginalPaperLogType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_OriginalPaperLogType_Cond.dicFldComparisonOp, clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_LogTypeId) == true) {
            const strComparisonOp_LogTypeId = objgs_OriginalPaperLogType_Cond.dicFldComparisonOp[clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_LogTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_LogTypeId, objgs_OriginalPaperLogType_Cond.logTypeId, strComparisonOp_LogTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_OriginalPaperLogType_Cond.dicFldComparisonOp, clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_LogTypeName) == true) {
            const strComparisonOp_LogTypeName = objgs_OriginalPaperLogType_Cond.dicFldComparisonOp[clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_LogTypeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_LogTypeName, objgs_OriginalPaperLogType_Cond.logTypeName, strComparisonOp_LogTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_OriginalPaperLogType_Cond.dicFldComparisonOp, clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_OriginalPaperLogType_Cond.dicFldComparisonOp[clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_UpdUser, objgs_OriginalPaperLogType_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_OriginalPaperLogType_Cond.dicFldComparisonOp, clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_OriginalPaperLogType_Cond.dicFldComparisonOp[clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_UpdDate, objgs_OriginalPaperLogType_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_OriginalPaperLogType_Cond.dicFldComparisonOp, clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_OriginalPaperLogType_Cond.dicFldComparisonOp[clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN.con_Memo, objgs_OriginalPaperLogType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_OriginalPaperLogType_GetCombineCondition = gs_OriginalPaperLogType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_OriginalPaperLogType(论文日志类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strLogTypeId: 日志类型Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_OriginalPaperLogType_GetUniCondStr_LogTypeId(objgs_OriginalPaperLogTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and LogTypeId = '{0}'", objgs_OriginalPaperLogTypeEN.logTypeId);
        return strWhereCond;
    }
    exports.gs_OriginalPaperLogType_GetUniCondStr_LogTypeId = gs_OriginalPaperLogType_GetUniCondStr_LogTypeId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_OriginalPaperLogType(论文日志类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strLogTypeId: 日志类型Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_OriginalPaperLogType_GetUniCondStr4Update_LogTypeId(objgs_OriginalPaperLogTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and LogTypeId <> '{0}'", objgs_OriginalPaperLogTypeEN.logTypeId);
        strWhereCond += (0, clsString_js_2.Format)(" and LogTypeId = '{0}'", objgs_OriginalPaperLogTypeEN.logTypeId);
        return strWhereCond;
    }
    exports.gs_OriginalPaperLogType_GetUniCondStr4Update_LogTypeId = gs_OriginalPaperLogType_GetUniCondStr4Update_LogTypeId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_OriginalPaperLogTypeENS:源对象
     * @param objgs_OriginalPaperLogTypeENT:目标对象
    */
    function gs_OriginalPaperLogType_CopyObjTo(objgs_OriginalPaperLogTypeENS, objgs_OriginalPaperLogTypeENT) {
        objgs_OriginalPaperLogTypeENT.logTypeId = objgs_OriginalPaperLogTypeENS.logTypeId; //日志类型Id
        objgs_OriginalPaperLogTypeENT.logTypeName = objgs_OriginalPaperLogTypeENS.logTypeName; //日志类型名
        objgs_OriginalPaperLogTypeENT.updUser = objgs_OriginalPaperLogTypeENS.updUser; //修改人
        objgs_OriginalPaperLogTypeENT.updDate = objgs_OriginalPaperLogTypeENS.updDate; //修改日期
        objgs_OriginalPaperLogTypeENT.memo = objgs_OriginalPaperLogTypeENS.memo; //备注
        objgs_OriginalPaperLogTypeENT.sf_UpdFldSetStr = objgs_OriginalPaperLogTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_OriginalPaperLogType_CopyObjTo = gs_OriginalPaperLogType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_OriginalPaperLogTypeENS:源对象
     * @param objgs_OriginalPaperLogTypeENT:目标对象
    */
    function gs_OriginalPaperLogType_GetObjFromJsonObj(objgs_OriginalPaperLogTypeENS) {
        const objgs_OriginalPaperLogTypeENT = new clsgs_OriginalPaperLogTypeEN_js_1.clsgs_OriginalPaperLogTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_OriginalPaperLogTypeENT, objgs_OriginalPaperLogTypeENS);
        return objgs_OriginalPaperLogTypeENT;
    }
    exports.gs_OriginalPaperLogType_GetObjFromJsonObj = gs_OriginalPaperLogType_GetObjFromJsonObj;
});
