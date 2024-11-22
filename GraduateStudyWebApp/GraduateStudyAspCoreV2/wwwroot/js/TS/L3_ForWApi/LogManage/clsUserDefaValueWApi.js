/**
* 类名:clsUserDefaValueWApi
* 表名:UserDefaValue(01120203)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:52:27
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
        define(["require", "exports", "axios", "../../L0_Entity/LogManage/clsUserDefaValueEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.UserDefaValue_GetObjFromJsonObj = exports.UserDefaValue_CopyObjTo = exports.UserDefaValue_GetUniCondStr4Update_DefaValNameId_UserId = exports.UserDefaValue_GetUniCondStr_DefaValNameId_UserId = exports.UserDefaValue_GetCombineCondition = exports.UserDefaValue_GetObjByJSONStr = exports.UserDefaValue_GetObjLstByJSONObjLst = exports.UserDefaValue_GetObjLstByJSONStr = exports.UserDefaValue_GetJSONStrByObj = exports.UserDefaValue_CheckProperty4Update = exports.UserDefaValue_CheckPropertyNew = exports.UserDefaValue_GetWebApiUrl = exports.UserDefaValue_GetMaxStrIdByPrefix = exports.UserDefaValue_GetRecCountByCondAsync = exports.UserDefaValue_IsExistAsync = exports.UserDefaValue_IsExist = exports.UserDefaValue_IsExistRecordAsync = exports.UserDefaValue_UpdateWithConditionAsync = exports.UserDefaValue_UpdateRecordAsync = exports.UserDefaValue_AddNewRecordWithReturnKey = exports.UserDefaValue_AddNewRecordWithReturnKeyAsync = exports.UserDefaValue_AddNewRecordAsync = exports.UserDefaValue_DelUserDefaValuesByCondAsync = exports.UserDefaValue_DelUserDefaValuesAsync = exports.UserDefaValue_DelRecordAsync = exports.UserDefaValue_GetObjLstByPagerAsync = exports.UserDefaValue_GetObjLstByRange = exports.UserDefaValue_GetObjLstByRangeAsync = exports.UserDefaValue_GetTopObjLstAsync = exports.UserDefaValue_GetObjLstBymIdLstAsync = exports.UserDefaValue_GetObjLstAsync = exports.UserDefaValue_GetFirstObjAsync = exports.UserDefaValue_GetFirstID = exports.UserDefaValue_GetFirstIDAsync = exports.UserDefaValue_FilterFunByKey = exports.UserDefaValue_SortFunByKey = exports.UserDefaValue_SortFun_Defa_2Fld = exports.UserDefaValue_SortFun_Defa = exports.UserDefaValue_GetObjBymIdAsync = exports.userDefaValue_ConstructorName = exports.userDefaValue_Controller = void 0;
    /**
     * 用户缺省值(UserDefaValue)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsUserDefaValueEN_js_1 = require("../../L0_Entity/LogManage/clsUserDefaValueEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.userDefaValue_Controller = "UserDefaValueApi";
    exports.userDefaValue_ConstructorName = "userDefaValue";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function UserDefaValue_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clsUserDefaValueWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngmId": lngmId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objUserDefaValue = UserDefaValue_GetObjFromJsonObj(returnObj);
                return objUserDefaValue;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_GetObjBymIdAsync = UserDefaValue_GetObjBymIdAsync;
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
    function UserDefaValue_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.UserDefaValue_SortFun_Defa = UserDefaValue_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function UserDefaValue_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.defaValNameId == b.defaValNameId)
            return a.userId.localeCompare(b.userId);
        else
            return a.defaValNameId.localeCompare(b.defaValNameId);
    }
    exports.UserDefaValue_SortFun_Defa_2Fld = UserDefaValue_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function UserDefaValue_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_DefaValNameId:
                    return (a, b) => {
                        return a.defaValNameId.localeCompare(b.defaValNameId);
                    };
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UserDefaValue:
                    return (a, b) => {
                        return a.userDefaValue.localeCompare(b.userDefaValue);
                    };
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[UserDefaValue]中不存在！(in ${exports.userDefaValue_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_DefaValNameId:
                    return (a, b) => {
                        return b.defaValNameId.localeCompare(a.defaValNameId);
                    };
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UserDefaValue:
                    return (a, b) => {
                        return b.userDefaValue.localeCompare(a.userDefaValue);
                    };
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[UserDefaValue]中不存在！(in ${exports.userDefaValue_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.UserDefaValue_SortFunByKey = UserDefaValue_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function UserDefaValue_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_DefaValNameId:
                return (obj) => {
                    return obj.defaValNameId === value;
                };
            case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UserDefaValue:
                return (obj) => {
                    return obj.userDefaValue === value;
                };
            case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[UserDefaValue]中不存在！(in ${exports.userDefaValue_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.UserDefaValue_FilterFunByKey = UserDefaValue_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function UserDefaValue_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_GetFirstIDAsync = UserDefaValue_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function UserDefaValue_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_GetFirstID = UserDefaValue_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function UserDefaValue_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
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
                const objUserDefaValue = UserDefaValue_GetObjFromJsonObj(returnObj);
                return objUserDefaValue;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_GetFirstObjAsync = UserDefaValue_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function UserDefaValue_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.userDefaValue_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = UserDefaValue_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_GetObjLstAsync = UserDefaValue_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function UserDefaValue_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.userDefaValue_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = UserDefaValue_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_GetObjLstBymIdLstAsync = UserDefaValue_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function UserDefaValue_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.userDefaValue_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = UserDefaValue_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_GetTopObjLstAsync = UserDefaValue_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function UserDefaValue_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.userDefaValue_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = UserDefaValue_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_GetObjLstByRangeAsync = UserDefaValue_GetObjLstByRangeAsync;
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
    async function UserDefaValue_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_GetObjLstByRange = UserDefaValue_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function UserDefaValue_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.userDefaValue_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = UserDefaValue_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_GetObjLstByPagerAsync = UserDefaValue_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function UserDefaValue_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngmId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_DelRecordAsync = UserDefaValue_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function UserDefaValue_DelUserDefaValuesAsync(arrmId) {
        const strThisFuncName = "DelUserDefaValuesAsync";
        const strAction = "DelUserDefaValues";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_DelUserDefaValuesAsync = UserDefaValue_DelUserDefaValuesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function UserDefaValue_DelUserDefaValuesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelUserDefaValuesByCondAsync";
        const strAction = "DelUserDefaValuesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_DelUserDefaValuesByCondAsync = UserDefaValue_DelUserDefaValuesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objUserDefaValueEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function UserDefaValue_AddNewRecordAsync(objUserDefaValueEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objUserDefaValueEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUserDefaValueEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_AddNewRecordAsync = UserDefaValue_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objUserDefaValueEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function UserDefaValue_AddNewRecordWithReturnKeyAsync(objUserDefaValueEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUserDefaValueEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_AddNewRecordWithReturnKeyAsync = UserDefaValue_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objUserDefaValueEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function UserDefaValue_AddNewRecordWithReturnKey(objUserDefaValueEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objUserDefaValueEN.mId === null || objUserDefaValueEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUserDefaValueEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_AddNewRecordWithReturnKey = UserDefaValue_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objUserDefaValueEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function UserDefaValue_UpdateRecordAsync(objUserDefaValueEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objUserDefaValueEN.sf_UpdFldSetStr === undefined || objUserDefaValueEN.sf_UpdFldSetStr === null || objUserDefaValueEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objUserDefaValueEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUserDefaValueEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_UpdateRecordAsync = UserDefaValue_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objUserDefaValueEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function UserDefaValue_UpdateWithConditionAsync(objUserDefaValueEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objUserDefaValueEN.sf_UpdFldSetStr === undefined || objUserDefaValueEN.sf_UpdFldSetStr === null || objUserDefaValueEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objUserDefaValueEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        objUserDefaValueEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objUserDefaValueEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_UpdateWithConditionAsync = UserDefaValue_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function UserDefaValue_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_IsExistRecordAsync = UserDefaValue_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function UserDefaValue_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "mId": lngmId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_IsExist = UserDefaValue_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function UserDefaValue_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngmId": lngmId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_IsExistAsync = UserDefaValue_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function UserDefaValue_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_GetRecCountByCondAsync = UserDefaValue_GetRecCountByCondAsync;
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
    async function UserDefaValue_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userDefaValue_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userDefaValue_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserDefaValue_GetMaxStrIdByPrefix = UserDefaValue_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function UserDefaValue_GetWebApiUrl(strController, strAction) {
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
    exports.UserDefaValue_GetWebApiUrl = UserDefaValue_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function UserDefaValue_CheckPropertyNew(pobjUserDefaValueEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.defaValNameId) === true) {
            throw new Error("(errid:Watl000058)字段[缺省值名称Id]不能为空(In 用户缺省值)!(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.userId) === true) {
            throw new Error("(errid:Watl000058)字段[用户ID]不能为空(In 用户缺省值)!(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.userDefaValue) === true) {
            throw new Error("(errid:Watl000058)字段[用户缺省值]不能为空(In 用户缺省值)!(clsUserDefaValueBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.defaValNameId) == false && (0, clsString_js_2.GetStrLen)(pobjUserDefaValueEN.defaValNameId) > 8) {
            throw new Error("(errid:Watl000059)字段[缺省值名称Id(defaValNameId)]的长度不能超过8(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.defaValNameId)(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjUserDefaValueEN.userId) > 18) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过18(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.userId)(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.userDefaValue) == false && (0, clsString_js_2.GetStrLen)(pobjUserDefaValueEN.userDefaValue) > 100) {
            throw new Error("(errid:Watl000059)字段[用户缺省值(userDefaValue)]的长度不能超过100(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.userDefaValue)(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjUserDefaValueEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.updDate)(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjUserDefaValueEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.updUser)(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjUserDefaValueEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.memo)(clsUserDefaValueBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjUserDefaValueEN.mId && undefined !== pobjUserDefaValueEN.mId && clsString_js_1.tzDataType.isNumber(pobjUserDefaValueEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjUserDefaValueEN.mId)], 非法，应该为数值型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.defaValNameId) == false && undefined !== pobjUserDefaValueEN.defaValNameId && clsString_js_1.tzDataType.isString(pobjUserDefaValueEN.defaValNameId) === false) {
            throw new Error("(errid:Watl000060)字段[缺省值名称Id(defaValNameId)]的值:[$(pobjUserDefaValueEN.defaValNameId)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.userId) == false && undefined !== pobjUserDefaValueEN.userId && clsString_js_1.tzDataType.isString(pobjUserDefaValueEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjUserDefaValueEN.userId)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.userDefaValue) == false && undefined !== pobjUserDefaValueEN.userDefaValue && clsString_js_1.tzDataType.isString(pobjUserDefaValueEN.userDefaValue) === false) {
            throw new Error("(errid:Watl000060)字段[用户缺省值(userDefaValue)]的值:[$(pobjUserDefaValueEN.userDefaValue)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.updDate) == false && undefined !== pobjUserDefaValueEN.updDate && clsString_js_1.tzDataType.isString(pobjUserDefaValueEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjUserDefaValueEN.updDate)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.updUser) == false && undefined !== pobjUserDefaValueEN.updUser && clsString_js_1.tzDataType.isString(pobjUserDefaValueEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjUserDefaValueEN.updUser)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.memo) == false && undefined !== pobjUserDefaValueEN.memo && clsString_js_1.tzDataType.isString(pobjUserDefaValueEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjUserDefaValueEN.memo)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjUserDefaValueEN.SetIsCheckProperty(true);
    }
    exports.UserDefaValue_CheckPropertyNew = UserDefaValue_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function UserDefaValue_CheckProperty4Update(pobjUserDefaValueEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.defaValNameId) == false && (0, clsString_js_2.GetStrLen)(pobjUserDefaValueEN.defaValNameId) > 8) {
            throw new Error("(errid:Watl000062)字段[缺省值名称Id(defaValNameId)]的长度不能超过8(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.defaValNameId)(clsUserDefaValueBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjUserDefaValueEN.userId) > 18) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过18(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.userId)(clsUserDefaValueBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.userDefaValue) == false && (0, clsString_js_2.GetStrLen)(pobjUserDefaValueEN.userDefaValue) > 100) {
            throw new Error("(errid:Watl000062)字段[用户缺省值(userDefaValue)]的长度不能超过100(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.userDefaValue)(clsUserDefaValueBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjUserDefaValueEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.updDate)(clsUserDefaValueBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjUserDefaValueEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.updUser)(clsUserDefaValueBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjUserDefaValueEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.memo)(clsUserDefaValueBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjUserDefaValueEN.mId && undefined !== pobjUserDefaValueEN.mId && clsString_js_1.tzDataType.isNumber(pobjUserDefaValueEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjUserDefaValueEN.mId)], 非法，应该为数值型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.defaValNameId) == false && undefined !== pobjUserDefaValueEN.defaValNameId && clsString_js_1.tzDataType.isString(pobjUserDefaValueEN.defaValNameId) === false) {
            throw new Error("(errid:Watl000063)字段[缺省值名称Id(defaValNameId)]的值:[$(pobjUserDefaValueEN.defaValNameId)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.userId) == false && undefined !== pobjUserDefaValueEN.userId && clsString_js_1.tzDataType.isString(pobjUserDefaValueEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjUserDefaValueEN.userId)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.userDefaValue) == false && undefined !== pobjUserDefaValueEN.userDefaValue && clsString_js_1.tzDataType.isString(pobjUserDefaValueEN.userDefaValue) === false) {
            throw new Error("(errid:Watl000063)字段[用户缺省值(userDefaValue)]的值:[$(pobjUserDefaValueEN.userDefaValue)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.updDate) == false && undefined !== pobjUserDefaValueEN.updDate && clsString_js_1.tzDataType.isString(pobjUserDefaValueEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjUserDefaValueEN.updDate)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.updUser) == false && undefined !== pobjUserDefaValueEN.updUser && clsString_js_1.tzDataType.isString(pobjUserDefaValueEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjUserDefaValueEN.updUser)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjUserDefaValueEN.memo) == false && undefined !== pobjUserDefaValueEN.memo && clsString_js_1.tzDataType.isString(pobjUserDefaValueEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjUserDefaValueEN.memo)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjUserDefaValueEN.mId
            || pobjUserDefaValueEN.mId != null && pobjUserDefaValueEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 用户缺省值)!(clsUserDefaValueBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjUserDefaValueEN.SetIsCheckProperty(true);
    }
    exports.UserDefaValue_CheckProperty4Update = UserDefaValue_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function UserDefaValue_GetJSONStrByObj(pobjUserDefaValueEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjUserDefaValueEN.sf_UpdFldSetStr = pobjUserDefaValueEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjUserDefaValueEN);
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
    exports.UserDefaValue_GetJSONStrByObj = UserDefaValue_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function UserDefaValue_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrUserDefaValueObjLst = new Array();
        if (strJSON === "") {
            return arrUserDefaValueObjLst;
        }
        try {
            arrUserDefaValueObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrUserDefaValueObjLst;
        }
        return arrUserDefaValueObjLst;
    }
    exports.UserDefaValue_GetObjLstByJSONStr = UserDefaValue_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrUserDefaValueObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function UserDefaValue_GetObjLstByJSONObjLst(arrUserDefaValueObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrUserDefaValueObjLst = new Array();
        for (const objInFor of arrUserDefaValueObjLstS) {
            const obj1 = UserDefaValue_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrUserDefaValueObjLst.push(obj1);
        }
        return arrUserDefaValueObjLst;
    }
    exports.UserDefaValue_GetObjLstByJSONObjLst = UserDefaValue_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function UserDefaValue_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjUserDefaValueEN = new clsUserDefaValueEN_js_1.clsUserDefaValueEN();
        if (strJSON === "") {
            return pobjUserDefaValueEN;
        }
        try {
            pobjUserDefaValueEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjUserDefaValueEN;
        }
        return pobjUserDefaValueEN;
    }
    exports.UserDefaValue_GetObjByJSONStr = UserDefaValue_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function UserDefaValue_GetCombineCondition(objUserDefaValue_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_mId) == true) {
            const strComparisonOp_mId = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_mId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_mId, objUserDefaValue_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_DefaValNameId) == true) {
            const strComparisonOp_DefaValNameId = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_DefaValNameId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_DefaValNameId, objUserDefaValue_Cond.defaValNameId, strComparisonOp_DefaValNameId);
        }
        if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UserId) == true) {
            const strComparisonOp_UserId = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UserId, objUserDefaValue_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UserDefaValue) == true) {
            const strComparisonOp_UserDefaValue = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UserDefaValue];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UserDefaValue, objUserDefaValue_Cond.userDefaValue, strComparisonOp_UserDefaValue);
        }
        if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UpdDate, objUserDefaValue_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_UpdUser, objUserDefaValue_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_Memo) == true) {
            const strComparisonOp_Memo = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsUserDefaValueEN_js_1.clsUserDefaValueEN.con_Memo, objUserDefaValue_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.UserDefaValue_GetCombineCondition = UserDefaValue_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--UserDefaValue(用户缺省值),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strDefaValNameId: 缺省值名称Id(要求唯一的字段)
    * @param strUserId: 用户ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function UserDefaValue_GetUniCondStr_DefaValNameId_UserId(objUserDefaValueEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and DefaValNameId = '{0}'", objUserDefaValueEN.defaValNameId);
        strWhereCond += (0, clsString_js_2.Format)(" and UserId = '{0}'", objUserDefaValueEN.userId);
        return strWhereCond;
    }
    exports.UserDefaValue_GetUniCondStr_DefaValNameId_UserId = UserDefaValue_GetUniCondStr_DefaValNameId_UserId;
    /**
    *获取唯一性条件串(Uniqueness)--UserDefaValue(用户缺省值),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strDefaValNameId: 缺省值名称Id(要求唯一的字段)
    * @param strUserId: 用户ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function UserDefaValue_GetUniCondStr4Update_DefaValNameId_UserId(objUserDefaValueEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId <> '{0}'", objUserDefaValueEN.mId);
        strWhereCond += (0, clsString_js_2.Format)(" and DefaValNameId = '{0}'", objUserDefaValueEN.defaValNameId);
        strWhereCond += (0, clsString_js_2.Format)(" and UserId = '{0}'", objUserDefaValueEN.userId);
        return strWhereCond;
    }
    exports.UserDefaValue_GetUniCondStr4Update_DefaValNameId_UserId = UserDefaValue_GetUniCondStr4Update_DefaValNameId_UserId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objUserDefaValueENS:源对象
     * @param objUserDefaValueENT:目标对象
    */
    function UserDefaValue_CopyObjTo(objUserDefaValueENS, objUserDefaValueENT) {
        objUserDefaValueENT.mId = objUserDefaValueENS.mId; //mId
        objUserDefaValueENT.defaValNameId = objUserDefaValueENS.defaValNameId; //缺省值名称Id
        objUserDefaValueENT.userId = objUserDefaValueENS.userId; //用户ID
        objUserDefaValueENT.userDefaValue = objUserDefaValueENS.userDefaValue; //用户缺省值
        objUserDefaValueENT.updDate = objUserDefaValueENS.updDate; //修改日期
        objUserDefaValueENT.updUser = objUserDefaValueENS.updUser; //修改人
        objUserDefaValueENT.memo = objUserDefaValueENS.memo; //备注
        objUserDefaValueENT.sf_UpdFldSetStr = objUserDefaValueENS.updFldString; //sf_UpdFldSetStr
    }
    exports.UserDefaValue_CopyObjTo = UserDefaValue_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objUserDefaValueENS:源对象
     * @param objUserDefaValueENT:目标对象
    */
    function UserDefaValue_GetObjFromJsonObj(objUserDefaValueENS) {
        const objUserDefaValueENT = new clsUserDefaValueEN_js_1.clsUserDefaValueEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objUserDefaValueENT, objUserDefaValueENS);
        return objUserDefaValueENT;
    }
    exports.UserDefaValue_GetObjFromJsonObj = UserDefaValue_GetObjFromJsonObj;
});
