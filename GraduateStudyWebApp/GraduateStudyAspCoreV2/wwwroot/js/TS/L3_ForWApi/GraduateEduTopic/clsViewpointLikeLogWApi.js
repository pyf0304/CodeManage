/**
* 类名:clsViewpointLikeLogWApi
* 表名:ViewpointLikeLog(01120601)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:49:09
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培主题(GraduateEduTopic)
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsViewpointLikeLogEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ViewpointLikeLog_GetObjFromJsonObj = exports.ViewpointLikeLog_CopyObjTo = exports.ViewpointLikeLog_GetUniCondStr4Update_ViewpointLikeLogId_ViewpointId = exports.ViewpointLikeLog_GetUniCondStr_ViewpointLikeLogId_ViewpointId = exports.ViewpointLikeLog_GetCombineCondition = exports.ViewpointLikeLog_GetObjByJSONStr = exports.ViewpointLikeLog_GetObjLstByJSONObjLst = exports.ViewpointLikeLog_GetObjLstByJSONStr = exports.ViewpointLikeLog_GetJSONStrByObj = exports.ViewpointLikeLog_CheckProperty4Update = exports.ViewpointLikeLog_CheckPropertyNew = exports.ViewpointLikeLog_GetWebApiUrl = exports.ViewpointLikeLog_GetMaxStrIdByPrefix = exports.ViewpointLikeLog_GetRecCountByCondAsync = exports.ViewpointLikeLog_IsExistAsync = exports.ViewpointLikeLog_IsExist = exports.ViewpointLikeLog_IsExistRecordAsync = exports.ViewpointLikeLog_UpdateWithConditionAsync = exports.ViewpointLikeLog_UpdateRecordAsync = exports.ViewpointLikeLog_AddNewRecordWithReturnKey = exports.ViewpointLikeLog_AddNewRecordWithReturnKeyAsync = exports.ViewpointLikeLog_AddNewRecordAsync = exports.ViewpointLikeLog_DelViewpointLikeLogsByCondAsync = exports.ViewpointLikeLog_DelViewpointLikeLogsAsync = exports.ViewpointLikeLog_DelRecordAsync = exports.ViewpointLikeLog_GetObjLstByPagerAsync = exports.ViewpointLikeLog_GetObjLstByRange = exports.ViewpointLikeLog_GetObjLstByRangeAsync = exports.ViewpointLikeLog_GetTopObjLstAsync = exports.ViewpointLikeLog_GetObjLstByViewpointLikeLogIdLstAsync = exports.ViewpointLikeLog_GetObjLstAsync = exports.ViewpointLikeLog_GetFirstObjAsync = exports.ViewpointLikeLog_GetFirstID = exports.ViewpointLikeLog_GetFirstIDAsync = exports.ViewpointLikeLog_FilterFunByKey = exports.ViewpointLikeLog_SortFunByKey = exports.ViewpointLikeLog_SortFun_Defa_2Fld = exports.ViewpointLikeLog_SortFun_Defa = exports.ViewpointLikeLog_GetObjByViewpointLikeLogIdAsync = exports.viewpointLikeLog_ConstructorName = exports.viewpointLikeLog_Controller = void 0;
    /**
     * 观点点赞表(ViewpointLikeLog)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsViewpointLikeLogEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsViewpointLikeLogEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.viewpointLikeLog_Controller = "ViewpointLikeLogApi";
    exports.viewpointLikeLog_ConstructorName = "viewpointLikeLog";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngViewpointLikeLogId:关键字
    * @returns 对象
    **/
    async function ViewpointLikeLog_GetObjByViewpointLikeLogIdAsync(lngViewpointLikeLogId) {
        const strThisFuncName = "GetObjByViewpointLikeLogIdAsync";
        if (lngViewpointLikeLogId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngViewpointLikeLogId]不能为空！(In clsViewpointLikeLogWApi.GetObjByViewpointLikeLogIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByViewpointLikeLogId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngViewpointLikeLogId": lngViewpointLikeLogId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objViewpointLikeLog = ViewpointLikeLog_GetObjFromJsonObj(returnObj);
                return objViewpointLikeLog;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_GetObjByViewpointLikeLogIdAsync = ViewpointLikeLog_GetObjByViewpointLikeLogIdAsync;
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
    function ViewpointLikeLog_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.viewpointLikeLogId - b.viewpointLikeLogId;
    }
    exports.ViewpointLikeLog_SortFun_Defa = ViewpointLikeLog_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointLikeLog_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.viewpointId == b.viewpointId)
            return a.updDate.localeCompare(b.updDate);
        else
            return a.viewpointId.localeCompare(b.viewpointId);
    }
    exports.ViewpointLikeLog_SortFun_Defa_2Fld = ViewpointLikeLog_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointLikeLog_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_ViewpointLikeLogId:
                    return (a, b) => {
                        return a.viewpointLikeLogId - b.viewpointLikeLogId;
                    };
                case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_ViewpointId:
                    return (a, b) => {
                        if (a.viewpointId == null)
                            return -1;
                        if (b.viewpointId == null)
                            return 1;
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_UpdUserId:
                    return (a, b) => {
                        if (a.updUserId == null)
                            return -1;
                        if (b.updUserId == null)
                            return 1;
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ViewpointLikeLog]中不存在！(in ${exports.viewpointLikeLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_ViewpointLikeLogId:
                    return (a, b) => {
                        return b.viewpointLikeLogId - a.viewpointLikeLogId;
                    };
                case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_ViewpointId:
                    return (a, b) => {
                        if (b.viewpointId == null)
                            return -1;
                        if (a.viewpointId == null)
                            return 1;
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_UpdUserId:
                    return (a, b) => {
                        if (b.updUserId == null)
                            return -1;
                        if (a.updUserId == null)
                            return 1;
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ViewpointLikeLog]中不存在！(in ${exports.viewpointLikeLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ViewpointLikeLog_SortFunByKey = ViewpointLikeLog_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ViewpointLikeLog_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_ViewpointLikeLogId:
                return (obj) => {
                    return obj.viewpointLikeLogId === value;
                };
            case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ViewpointLikeLog]中不存在！(in ${exports.viewpointLikeLog_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ViewpointLikeLog_FilterFunByKey = ViewpointLikeLog_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ViewpointLikeLog_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_GetFirstIDAsync = ViewpointLikeLog_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ViewpointLikeLog_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_GetFirstID = ViewpointLikeLog_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ViewpointLikeLog_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
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
                const objViewpointLikeLog = ViewpointLikeLog_GetObjFromJsonObj(returnObj);
                return objViewpointLikeLog;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_GetFirstObjAsync = ViewpointLikeLog_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ViewpointLikeLog_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_GetObjLstAsync = ViewpointLikeLog_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrViewpointLikeLogId:关键字列表
    * @returns 对象列表
    **/
    async function ViewpointLikeLog_GetObjLstByViewpointLikeLogIdLstAsync(arrViewpointLikeLogId) {
        const strThisFuncName = "GetObjLstByViewpointLikeLogIdLstAsync";
        const strAction = "GetObjLstByViewpointLikeLogIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointLikeLogId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_GetObjLstByViewpointLikeLogIdLstAsync = ViewpointLikeLog_GetObjLstByViewpointLikeLogIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ViewpointLikeLog_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_GetTopObjLstAsync = ViewpointLikeLog_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ViewpointLikeLog_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_GetObjLstByRangeAsync = ViewpointLikeLog_GetObjLstByRangeAsync;
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
    async function ViewpointLikeLog_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_GetObjLstByRange = ViewpointLikeLog_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ViewpointLikeLog_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_GetObjLstByPagerAsync = ViewpointLikeLog_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngViewpointLikeLogId:关键字
    * @returns 获取删除的结果
    **/
    async function ViewpointLikeLog_DelRecordAsync(lngViewpointLikeLogId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngViewpointLikeLogId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_DelRecordAsync = ViewpointLikeLog_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrViewpointLikeLogId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ViewpointLikeLog_DelViewpointLikeLogsAsync(arrViewpointLikeLogId) {
        const strThisFuncName = "DelViewpointLikeLogsAsync";
        const strAction = "DelViewpointLikeLogs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointLikeLogId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_DelViewpointLikeLogsAsync = ViewpointLikeLog_DelViewpointLikeLogsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ViewpointLikeLog_DelViewpointLikeLogsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelViewpointLikeLogsByCondAsync";
        const strAction = "DelViewpointLikeLogsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_DelViewpointLikeLogsByCondAsync = ViewpointLikeLog_DelViewpointLikeLogsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objViewpointLikeLogEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ViewpointLikeLog_AddNewRecordAsync(objViewpointLikeLogEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objViewpointLikeLogEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointLikeLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_AddNewRecordAsync = ViewpointLikeLog_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objViewpointLikeLogEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ViewpointLikeLog_AddNewRecordWithReturnKeyAsync(objViewpointLikeLogEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointLikeLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_AddNewRecordWithReturnKeyAsync = ViewpointLikeLog_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objViewpointLikeLogEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ViewpointLikeLog_AddNewRecordWithReturnKey(objViewpointLikeLogEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objViewpointLikeLogEN.viewpointLikeLogId === null || objViewpointLikeLogEN.viewpointLikeLogId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointLikeLogEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_AddNewRecordWithReturnKey = ViewpointLikeLog_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objViewpointLikeLogEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ViewpointLikeLog_UpdateRecordAsync(objViewpointLikeLogEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objViewpointLikeLogEN.sf_UpdFldSetStr === undefined || objViewpointLikeLogEN.sf_UpdFldSetStr === null || objViewpointLikeLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointLikeLogEN.viewpointLikeLogId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointLikeLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_UpdateRecordAsync = ViewpointLikeLog_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objViewpointLikeLogEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ViewpointLikeLog_UpdateWithConditionAsync(objViewpointLikeLogEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objViewpointLikeLogEN.sf_UpdFldSetStr === undefined || objViewpointLikeLogEN.sf_UpdFldSetStr === null || objViewpointLikeLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointLikeLogEN.viewpointLikeLogId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        objViewpointLikeLogEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objViewpointLikeLogEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_UpdateWithConditionAsync = ViewpointLikeLog_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ViewpointLikeLog_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_IsExistRecordAsync = ViewpointLikeLog_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngViewpointLikeLogId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ViewpointLikeLog_IsExist(lngViewpointLikeLogId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ViewpointLikeLogId": lngViewpointLikeLogId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_IsExist = ViewpointLikeLog_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngViewpointLikeLogId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ViewpointLikeLog_IsExistAsync(lngViewpointLikeLogId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngViewpointLikeLogId": lngViewpointLikeLogId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_IsExistAsync = ViewpointLikeLog_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ViewpointLikeLog_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_GetRecCountByCondAsync = ViewpointLikeLog_GetRecCountByCondAsync;
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
    async function ViewpointLikeLog_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointLikeLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointLikeLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointLikeLog_GetMaxStrIdByPrefix = ViewpointLikeLog_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ViewpointLikeLog_GetWebApiUrl(strController, strAction) {
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
    exports.ViewpointLikeLog_GetWebApiUrl = ViewpointLikeLog_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ViewpointLikeLog_CheckPropertyNew(pobjViewpointLikeLogEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.viewpointId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointLikeLogEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In 观点点赞表(ViewpointLikeLog))!值:$(pobjViewpointLikeLogEN.viewpointId)(clsViewpointLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointLikeLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 观点点赞表(ViewpointLikeLog))!值:$(pobjViewpointLikeLogEN.updDate)(clsViewpointLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointLikeLogEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 观点点赞表(ViewpointLikeLog))!值:$(pobjViewpointLikeLogEN.updUserId)(clsViewpointLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointLikeLogEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 观点点赞表(ViewpointLikeLog))!值:$(pobjViewpointLikeLogEN.memo)(clsViewpointLikeLogBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjViewpointLikeLogEN.viewpointLikeLogId && undefined !== pobjViewpointLikeLogEN.viewpointLikeLogId && clsString_js_1.tzDataType.isNumber(pobjViewpointLikeLogEN.viewpointLikeLogId) === false) {
            throw new Error("(errid:Watl000060)字段[观点点赞Id(viewpointLikeLogId)]的值:[$(pobjViewpointLikeLogEN.viewpointLikeLogId)], 非法，应该为数值型(In 观点点赞表(ViewpointLikeLog))!(clsViewpointLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.viewpointId) == false && undefined !== pobjViewpointLikeLogEN.viewpointId && clsString_js_1.tzDataType.isString(pobjViewpointLikeLogEN.viewpointId) === false) {
            throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjViewpointLikeLogEN.viewpointId)], 非法，应该为字符型(In 观点点赞表(ViewpointLikeLog))!(clsViewpointLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.updDate) == false && undefined !== pobjViewpointLikeLogEN.updDate && clsString_js_1.tzDataType.isString(pobjViewpointLikeLogEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjViewpointLikeLogEN.updDate)], 非法，应该为字符型(In 观点点赞表(ViewpointLikeLog))!(clsViewpointLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.updUserId) == false && undefined !== pobjViewpointLikeLogEN.updUserId && clsString_js_1.tzDataType.isString(pobjViewpointLikeLogEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjViewpointLikeLogEN.updUserId)], 非法，应该为字符型(In 观点点赞表(ViewpointLikeLog))!(clsViewpointLikeLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.memo) == false && undefined !== pobjViewpointLikeLogEN.memo && clsString_js_1.tzDataType.isString(pobjViewpointLikeLogEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjViewpointLikeLogEN.memo)], 非法，应该为字符型(In 观点点赞表(ViewpointLikeLog))!(clsViewpointLikeLogBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjViewpointLikeLogEN.SetIsCheckProperty(true);
    }
    exports.ViewpointLikeLog_CheckPropertyNew = ViewpointLikeLog_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ViewpointLikeLog_CheckProperty4Update(pobjViewpointLikeLogEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.viewpointId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointLikeLogEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In 观点点赞表(ViewpointLikeLog))!值:$(pobjViewpointLikeLogEN.viewpointId)(clsViewpointLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointLikeLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 观点点赞表(ViewpointLikeLog))!值:$(pobjViewpointLikeLogEN.updDate)(clsViewpointLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointLikeLogEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 观点点赞表(ViewpointLikeLog))!值:$(pobjViewpointLikeLogEN.updUserId)(clsViewpointLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointLikeLogEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 观点点赞表(ViewpointLikeLog))!值:$(pobjViewpointLikeLogEN.memo)(clsViewpointLikeLogBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjViewpointLikeLogEN.viewpointLikeLogId && undefined !== pobjViewpointLikeLogEN.viewpointLikeLogId && clsString_js_1.tzDataType.isNumber(pobjViewpointLikeLogEN.viewpointLikeLogId) === false) {
            throw new Error("(errid:Watl000063)字段[观点点赞Id(viewpointLikeLogId)]的值:[$(pobjViewpointLikeLogEN.viewpointLikeLogId)], 非法，应该为数值型(In 观点点赞表(ViewpointLikeLog))!(clsViewpointLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.viewpointId) == false && undefined !== pobjViewpointLikeLogEN.viewpointId && clsString_js_1.tzDataType.isString(pobjViewpointLikeLogEN.viewpointId) === false) {
            throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjViewpointLikeLogEN.viewpointId)], 非法，应该为字符型(In 观点点赞表(ViewpointLikeLog))!(clsViewpointLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.updDate) == false && undefined !== pobjViewpointLikeLogEN.updDate && clsString_js_1.tzDataType.isString(pobjViewpointLikeLogEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjViewpointLikeLogEN.updDate)], 非法，应该为字符型(In 观点点赞表(ViewpointLikeLog))!(clsViewpointLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.updUserId) == false && undefined !== pobjViewpointLikeLogEN.updUserId && clsString_js_1.tzDataType.isString(pobjViewpointLikeLogEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjViewpointLikeLogEN.updUserId)], 非法，应该为字符型(In 观点点赞表(ViewpointLikeLog))!(clsViewpointLikeLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointLikeLogEN.memo) == false && undefined !== pobjViewpointLikeLogEN.memo && clsString_js_1.tzDataType.isString(pobjViewpointLikeLogEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjViewpointLikeLogEN.memo)], 非法，应该为字符型(In 观点点赞表(ViewpointLikeLog))!(clsViewpointLikeLogBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjViewpointLikeLogEN.viewpointLikeLogId
            || pobjViewpointLikeLogEN.viewpointLikeLogId != null && pobjViewpointLikeLogEN.viewpointLikeLogId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[观点点赞Id]不能为空(In 观点点赞表)!(clsViewpointLikeLogBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjViewpointLikeLogEN.SetIsCheckProperty(true);
    }
    exports.ViewpointLikeLog_CheckProperty4Update = ViewpointLikeLog_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ViewpointLikeLog_GetJSONStrByObj(pobjViewpointLikeLogEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjViewpointLikeLogEN.sf_UpdFldSetStr = pobjViewpointLikeLogEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjViewpointLikeLogEN);
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
    exports.ViewpointLikeLog_GetJSONStrByObj = ViewpointLikeLog_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ViewpointLikeLog_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrViewpointLikeLogObjLst = new Array();
        if (strJSON === "") {
            return arrViewpointLikeLogObjLst;
        }
        try {
            arrViewpointLikeLogObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrViewpointLikeLogObjLst;
        }
        return arrViewpointLikeLogObjLst;
    }
    exports.ViewpointLikeLog_GetObjLstByJSONStr = ViewpointLikeLog_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrViewpointLikeLogObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ViewpointLikeLog_GetObjLstByJSONObjLst(arrViewpointLikeLogObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrViewpointLikeLogObjLst = new Array();
        for (const objInFor of arrViewpointLikeLogObjLstS) {
            const obj1 = ViewpointLikeLog_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrViewpointLikeLogObjLst.push(obj1);
        }
        return arrViewpointLikeLogObjLst;
    }
    exports.ViewpointLikeLog_GetObjLstByJSONObjLst = ViewpointLikeLog_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ViewpointLikeLog_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjViewpointLikeLogEN = new clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN();
        if (strJSON === "") {
            return pobjViewpointLikeLogEN;
        }
        try {
            pobjViewpointLikeLogEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjViewpointLikeLogEN;
        }
        return pobjViewpointLikeLogEN;
    }
    exports.ViewpointLikeLog_GetObjByJSONStr = ViewpointLikeLog_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ViewpointLikeLog_GetCombineCondition(objViewpointLikeLog_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objViewpointLikeLog_Cond.dicFldComparisonOp, clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_ViewpointLikeLogId) == true) {
            const strComparisonOp_ViewpointLikeLogId = objViewpointLikeLog_Cond.dicFldComparisonOp[clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_ViewpointLikeLogId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_ViewpointLikeLogId, objViewpointLikeLog_Cond.viewpointLikeLogId, strComparisonOp_ViewpointLikeLogId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointLikeLog_Cond.dicFldComparisonOp, clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objViewpointLikeLog_Cond.dicFldComparisonOp[clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_ViewpointId, objViewpointLikeLog_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointLikeLog_Cond.dicFldComparisonOp, clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objViewpointLikeLog_Cond.dicFldComparisonOp[clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_UpdDate, objViewpointLikeLog_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointLikeLog_Cond.dicFldComparisonOp, clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objViewpointLikeLog_Cond.dicFldComparisonOp[clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_UpdUserId, objViewpointLikeLog_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointLikeLog_Cond.dicFldComparisonOp, clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_Memo) == true) {
            const strComparisonOp_Memo = objViewpointLikeLog_Cond.dicFldComparisonOp[clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN.con_Memo, objViewpointLikeLog_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ViewpointLikeLog_GetCombineCondition = ViewpointLikeLog_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ViewpointLikeLog(观点点赞表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngViewpointLikeLogId: 观点点赞Id(要求唯一的字段)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ViewpointLikeLog_GetUniCondStr_ViewpointLikeLogId_ViewpointId(objViewpointLikeLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointLikeLogId = '{0}'", objViewpointLikeLogEN.viewpointLikeLogId);
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointId = '{0}'", objViewpointLikeLogEN.viewpointId);
        return strWhereCond;
    }
    exports.ViewpointLikeLog_GetUniCondStr_ViewpointLikeLogId_ViewpointId = ViewpointLikeLog_GetUniCondStr_ViewpointLikeLogId_ViewpointId;
    /**
    *获取唯一性条件串(Uniqueness)--ViewpointLikeLog(观点点赞表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngViewpointLikeLogId: 观点点赞Id(要求唯一的字段)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ViewpointLikeLog_GetUniCondStr4Update_ViewpointLikeLogId_ViewpointId(objViewpointLikeLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointLikeLogId <> '{0}'", objViewpointLikeLogEN.viewpointLikeLogId);
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointLikeLogId = '{0}'", objViewpointLikeLogEN.viewpointLikeLogId);
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointId = '{0}'", objViewpointLikeLogEN.viewpointId);
        return strWhereCond;
    }
    exports.ViewpointLikeLog_GetUniCondStr4Update_ViewpointLikeLogId_ViewpointId = ViewpointLikeLog_GetUniCondStr4Update_ViewpointLikeLogId_ViewpointId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objViewpointLikeLogENS:源对象
     * @param objViewpointLikeLogENT:目标对象
    */
    function ViewpointLikeLog_CopyObjTo(objViewpointLikeLogENS, objViewpointLikeLogENT) {
        objViewpointLikeLogENT.viewpointLikeLogId = objViewpointLikeLogENS.viewpointLikeLogId; //观点点赞Id
        objViewpointLikeLogENT.viewpointId = objViewpointLikeLogENS.viewpointId; //观点Id
        objViewpointLikeLogENT.updDate = objViewpointLikeLogENS.updDate; //修改日期
        objViewpointLikeLogENT.updUserId = objViewpointLikeLogENS.updUserId; //修改用户Id
        objViewpointLikeLogENT.memo = objViewpointLikeLogENS.memo; //备注
        objViewpointLikeLogENT.sf_UpdFldSetStr = objViewpointLikeLogENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ViewpointLikeLog_CopyObjTo = ViewpointLikeLog_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objViewpointLikeLogENS:源对象
     * @param objViewpointLikeLogENT:目标对象
    */
    function ViewpointLikeLog_GetObjFromJsonObj(objViewpointLikeLogENS) {
        const objViewpointLikeLogENT = new clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objViewpointLikeLogENT, objViewpointLikeLogENS);
        return objViewpointLikeLogENT;
    }
    exports.ViewpointLikeLog_GetObjFromJsonObj = ViewpointLikeLog_GetObjFromJsonObj;
});
