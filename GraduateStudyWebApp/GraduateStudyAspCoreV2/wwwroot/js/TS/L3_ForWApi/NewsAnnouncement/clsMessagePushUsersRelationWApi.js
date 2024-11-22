/**
* 类名:clsMessagePushUsersRelationWApi
* 表名:MessagePushUsersRelation(01120284)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:51:22
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:新闻公告(NewsAnnouncement)
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
        define(["require", "exports", "axios", "../../L0_Entity/NewsAnnouncement/clsMessagePushUsersRelationEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.MessagePushUsersRelation_GetObjFromJsonObj = exports.MessagePushUsersRelation_CopyObjTo = exports.MessagePushUsersRelation_GetUniCondStr4Update_MessagePushId_ReceivePeople = exports.MessagePushUsersRelation_GetUniCondStr_MessagePushId_ReceivePeople = exports.MessagePushUsersRelation_GetCombineCondition = exports.MessagePushUsersRelation_GetObjByJSONStr = exports.MessagePushUsersRelation_GetObjLstByJSONObjLst = exports.MessagePushUsersRelation_GetObjLstByJSONStr = exports.MessagePushUsersRelation_GetJSONStrByObj = exports.MessagePushUsersRelation_CheckProperty4Update = exports.MessagePushUsersRelation_CheckPropertyNew = exports.MessagePushUsersRelation_GetWebApiUrl = exports.MessagePushUsersRelation_GetMaxStrIdByPrefix = exports.MessagePushUsersRelation_GetRecCountByCondAsync = exports.MessagePushUsersRelation_IsExistAsync = exports.MessagePushUsersRelation_IsExist = exports.MessagePushUsersRelation_IsExistRecordAsync = exports.MessagePushUsersRelation_UpdateWithConditionAsync = exports.MessagePushUsersRelation_UpdateRecordAsync = exports.MessagePushUsersRelation_AddNewRecordWithReturnKey = exports.MessagePushUsersRelation_AddNewRecordWithReturnKeyAsync = exports.MessagePushUsersRelation_AddNewRecordAsync = exports.MessagePushUsersRelation_DelMessagePushUsersRelationsByCondAsync = exports.MessagePushUsersRelation_DelMessagePushUsersRelationsAsync = exports.MessagePushUsersRelation_DelRecordAsync = exports.MessagePushUsersRelation_GetObjLstByPagerAsync = exports.MessagePushUsersRelation_GetObjLstByRange = exports.MessagePushUsersRelation_GetObjLstByRangeAsync = exports.MessagePushUsersRelation_GetTopObjLstAsync = exports.MessagePushUsersRelation_GetObjLstByMessagePushUsersRelationIdLstAsync = exports.MessagePushUsersRelation_GetObjLstAsync = exports.MessagePushUsersRelation_GetFirstObjAsync = exports.MessagePushUsersRelation_GetFirstID = exports.MessagePushUsersRelation_GetFirstIDAsync = exports.MessagePushUsersRelation_FilterFunByKey = exports.MessagePushUsersRelation_SortFunByKey = exports.MessagePushUsersRelation_SortFun_Defa_2Fld = exports.MessagePushUsersRelation_SortFun_Defa = exports.MessagePushUsersRelation_GetObjByMessagePushUsersRelationIdAsync = exports.messagePushUsersRelation_ConstructorName = exports.messagePushUsersRelation_Controller = void 0;
    /**
     * 消息推送与用户关系(MessagePushUsersRelation)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsMessagePushUsersRelationEN_js_1 = require("../../L0_Entity/NewsAnnouncement/clsMessagePushUsersRelationEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.messagePushUsersRelation_Controller = "MessagePushUsersRelationApi";
    exports.messagePushUsersRelation_ConstructorName = "messagePushUsersRelation";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngMessagePushUsersRelationId:关键字
    * @returns 对象
    **/
    async function MessagePushUsersRelation_GetObjByMessagePushUsersRelationIdAsync(lngMessagePushUsersRelationId) {
        const strThisFuncName = "GetObjByMessagePushUsersRelationIdAsync";
        if (lngMessagePushUsersRelationId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngMessagePushUsersRelationId]不能为空！(In clsMessagePushUsersRelationWApi.GetObjByMessagePushUsersRelationIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByMessagePushUsersRelationId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngMessagePushUsersRelationId": lngMessagePushUsersRelationId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objMessagePushUsersRelation = MessagePushUsersRelation_GetObjFromJsonObj(returnObj);
                return objMessagePushUsersRelation;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_GetObjByMessagePushUsersRelationIdAsync = MessagePushUsersRelation_GetObjByMessagePushUsersRelationIdAsync;
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
    function MessagePushUsersRelation_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.messagePushUsersRelationId - b.messagePushUsersRelationId;
    }
    exports.MessagePushUsersRelation_SortFun_Defa = MessagePushUsersRelation_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function MessagePushUsersRelation_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.messagePushId == b.messagePushId)
            return a.receivePeople.localeCompare(b.receivePeople);
        else
            return a.messagePushId.localeCompare(b.messagePushId);
    }
    exports.MessagePushUsersRelation_SortFun_Defa_2Fld = MessagePushUsersRelation_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function MessagePushUsersRelation_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_MessagePushUsersRelationId:
                    return (a, b) => {
                        return a.messagePushUsersRelationId - b.messagePushUsersRelationId;
                    };
                case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_MessagePushId:
                    return (a, b) => {
                        return a.messagePushId.localeCompare(b.messagePushId);
                    };
                case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_ReceivePeople:
                    return (a, b) => {
                        return a.receivePeople.localeCompare(b.receivePeople);
                    };
                case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_IsReceive:
                    return (a, b) => {
                        if (a.isReceive == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_CreateTime:
                    return (a, b) => {
                        if (a.createTime == null)
                            return -1;
                        if (b.createTime == null)
                            return 1;
                        return a.createTime.localeCompare(b.createTime);
                    };
                case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[MessagePushUsersRelation]中不存在！(in ${exports.messagePushUsersRelation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_MessagePushUsersRelationId:
                    return (a, b) => {
                        return b.messagePushUsersRelationId - a.messagePushUsersRelationId;
                    };
                case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_MessagePushId:
                    return (a, b) => {
                        return b.messagePushId.localeCompare(a.messagePushId);
                    };
                case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_ReceivePeople:
                    return (a, b) => {
                        return b.receivePeople.localeCompare(a.receivePeople);
                    };
                case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_IsReceive:
                    return (a, b) => {
                        if (b.isReceive == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_CreateTime:
                    return (a, b) => {
                        if (b.createTime == null)
                            return -1;
                        if (a.createTime == null)
                            return 1;
                        return b.createTime.localeCompare(a.createTime);
                    };
                case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[MessagePushUsersRelation]中不存在！(in ${exports.messagePushUsersRelation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.MessagePushUsersRelation_SortFunByKey = MessagePushUsersRelation_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function MessagePushUsersRelation_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_MessagePushUsersRelationId:
                return (obj) => {
                    return obj.messagePushUsersRelationId === value;
                };
            case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_MessagePushId:
                return (obj) => {
                    return obj.messagePushId === value;
                };
            case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_ReceivePeople:
                return (obj) => {
                    return obj.receivePeople === value;
                };
            case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_IsReceive:
                return (obj) => {
                    return obj.isReceive === value;
                };
            case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_CreateTime:
                return (obj) => {
                    return obj.createTime === value;
                };
            case clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[MessagePushUsersRelation]中不存在！(in ${exports.messagePushUsersRelation_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.MessagePushUsersRelation_FilterFunByKey = MessagePushUsersRelation_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function MessagePushUsersRelation_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_GetFirstIDAsync = MessagePushUsersRelation_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function MessagePushUsersRelation_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_GetFirstID = MessagePushUsersRelation_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function MessagePushUsersRelation_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
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
                const objMessagePushUsersRelation = MessagePushUsersRelation_GetObjFromJsonObj(returnObj);
                return objMessagePushUsersRelation;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_GetFirstObjAsync = MessagePushUsersRelation_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function MessagePushUsersRelation_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MessagePushUsersRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_GetObjLstAsync = MessagePushUsersRelation_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrMessagePushUsersRelationId:关键字列表
    * @returns 对象列表
    **/
    async function MessagePushUsersRelation_GetObjLstByMessagePushUsersRelationIdLstAsync(arrMessagePushUsersRelationId) {
        const strThisFuncName = "GetObjLstByMessagePushUsersRelationIdLstAsync";
        const strAction = "GetObjLstByMessagePushUsersRelationIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMessagePushUsersRelationId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MessagePushUsersRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_GetObjLstByMessagePushUsersRelationIdLstAsync = MessagePushUsersRelation_GetObjLstByMessagePushUsersRelationIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function MessagePushUsersRelation_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MessagePushUsersRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_GetTopObjLstAsync = MessagePushUsersRelation_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function MessagePushUsersRelation_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MessagePushUsersRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_GetObjLstByRangeAsync = MessagePushUsersRelation_GetObjLstByRangeAsync;
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
    async function MessagePushUsersRelation_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_GetObjLstByRange = MessagePushUsersRelation_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function MessagePushUsersRelation_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MessagePushUsersRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_GetObjLstByPagerAsync = MessagePushUsersRelation_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngMessagePushUsersRelationId:关键字
    * @returns 获取删除的结果
    **/
    async function MessagePushUsersRelation_DelRecordAsync(lngMessagePushUsersRelationId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngMessagePushUsersRelationId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_DelRecordAsync = MessagePushUsersRelation_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrMessagePushUsersRelationId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function MessagePushUsersRelation_DelMessagePushUsersRelationsAsync(arrMessagePushUsersRelationId) {
        const strThisFuncName = "DelMessagePushUsersRelationsAsync";
        const strAction = "DelMessagePushUsersRelations";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMessagePushUsersRelationId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_DelMessagePushUsersRelationsAsync = MessagePushUsersRelation_DelMessagePushUsersRelationsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function MessagePushUsersRelation_DelMessagePushUsersRelationsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelMessagePushUsersRelationsByCondAsync";
        const strAction = "DelMessagePushUsersRelationsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_DelMessagePushUsersRelationsByCondAsync = MessagePushUsersRelation_DelMessagePushUsersRelationsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objMessagePushUsersRelationEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function MessagePushUsersRelation_AddNewRecordAsync(objMessagePushUsersRelationEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objMessagePushUsersRelationEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMessagePushUsersRelationEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_AddNewRecordAsync = MessagePushUsersRelation_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objMessagePushUsersRelationEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function MessagePushUsersRelation_AddNewRecordWithReturnKeyAsync(objMessagePushUsersRelationEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMessagePushUsersRelationEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_AddNewRecordWithReturnKeyAsync = MessagePushUsersRelation_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objMessagePushUsersRelationEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function MessagePushUsersRelation_AddNewRecordWithReturnKey(objMessagePushUsersRelationEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objMessagePushUsersRelationEN.messagePushUsersRelationId === null || objMessagePushUsersRelationEN.messagePushUsersRelationId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMessagePushUsersRelationEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_AddNewRecordWithReturnKey = MessagePushUsersRelation_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objMessagePushUsersRelationEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function MessagePushUsersRelation_UpdateRecordAsync(objMessagePushUsersRelationEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objMessagePushUsersRelationEN.sf_UpdFldSetStr === undefined || objMessagePushUsersRelationEN.sf_UpdFldSetStr === null || objMessagePushUsersRelationEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objMessagePushUsersRelationEN.messagePushUsersRelationId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMessagePushUsersRelationEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_UpdateRecordAsync = MessagePushUsersRelation_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objMessagePushUsersRelationEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function MessagePushUsersRelation_UpdateWithConditionAsync(objMessagePushUsersRelationEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objMessagePushUsersRelationEN.sf_UpdFldSetStr === undefined || objMessagePushUsersRelationEN.sf_UpdFldSetStr === null || objMessagePushUsersRelationEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objMessagePushUsersRelationEN.messagePushUsersRelationId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        objMessagePushUsersRelationEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objMessagePushUsersRelationEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_UpdateWithConditionAsync = MessagePushUsersRelation_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function MessagePushUsersRelation_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_IsExistRecordAsync = MessagePushUsersRelation_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngMessagePushUsersRelationId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function MessagePushUsersRelation_IsExist(lngMessagePushUsersRelationId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "MessagePushUsersRelationId": lngMessagePushUsersRelationId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_IsExist = MessagePushUsersRelation_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngMessagePushUsersRelationId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function MessagePushUsersRelation_IsExistAsync(lngMessagePushUsersRelationId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngMessagePushUsersRelationId": lngMessagePushUsersRelationId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_IsExistAsync = MessagePushUsersRelation_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function MessagePushUsersRelation_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_GetRecCountByCondAsync = MessagePushUsersRelation_GetRecCountByCondAsync;
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
    async function MessagePushUsersRelation_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePushUsersRelation_GetMaxStrIdByPrefix = MessagePushUsersRelation_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function MessagePushUsersRelation_GetWebApiUrl(strController, strAction) {
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
    exports.MessagePushUsersRelation_GetWebApiUrl = MessagePushUsersRelation_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function MessagePushUsersRelation_CheckPropertyNew(pobjMessagePushUsersRelationEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.messagePushId) === true) {
            throw new Error("(errid:Watl000058)字段[消息Id]不能为空(In 消息推送与用户关系)!(clsMessagePushUsersRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.receivePeople) === true) {
            throw new Error("(errid:Watl000058)字段[接收人员]不能为空(In 消息推送与用户关系)!(clsMessagePushUsersRelationBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.messagePushId) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushUsersRelationEN.messagePushId) > 8) {
            throw new Error("(errid:Watl000059)字段[消息Id(messagePushId)]的长度不能超过8(In 消息推送与用户关系(MessagePushUsersRelation))!值:$(pobjMessagePushUsersRelationEN.messagePushId)(clsMessagePushUsersRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.receivePeople) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushUsersRelationEN.receivePeople) > 50) {
            throw new Error("(errid:Watl000059)字段[接收人员(receivePeople)]的长度不能超过50(In 消息推送与用户关系(MessagePushUsersRelation))!值:$(pobjMessagePushUsersRelationEN.receivePeople)(clsMessagePushUsersRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.createTime) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushUsersRelationEN.createTime) > 16) {
            throw new Error("(errid:Watl000059)字段[建立时间(createTime)]的长度不能超过16(In 消息推送与用户关系(MessagePushUsersRelation))!值:$(pobjMessagePushUsersRelationEN.createTime)(clsMessagePushUsersRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushUsersRelationEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 消息推送与用户关系(MessagePushUsersRelation))!值:$(pobjMessagePushUsersRelationEN.memo)(clsMessagePushUsersRelationBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjMessagePushUsersRelationEN.messagePushUsersRelationId && undefined !== pobjMessagePushUsersRelationEN.messagePushUsersRelationId && clsString_js_1.tzDataType.isNumber(pobjMessagePushUsersRelationEN.messagePushUsersRelationId) === false) {
            throw new Error("(errid:Watl000060)字段[消息推送用户关系Id(messagePushUsersRelationId)]的值:[$(pobjMessagePushUsersRelationEN.messagePushUsersRelationId)], 非法，应该为数值型(In 消息推送与用户关系(MessagePushUsersRelation))!(clsMessagePushUsersRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.messagePushId) == false && undefined !== pobjMessagePushUsersRelationEN.messagePushId && clsString_js_1.tzDataType.isString(pobjMessagePushUsersRelationEN.messagePushId) === false) {
            throw new Error("(errid:Watl000060)字段[消息Id(messagePushId)]的值:[$(pobjMessagePushUsersRelationEN.messagePushId)], 非法，应该为字符型(In 消息推送与用户关系(MessagePushUsersRelation))!(clsMessagePushUsersRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.receivePeople) == false && undefined !== pobjMessagePushUsersRelationEN.receivePeople && clsString_js_1.tzDataType.isString(pobjMessagePushUsersRelationEN.receivePeople) === false) {
            throw new Error("(errid:Watl000060)字段[接收人员(receivePeople)]的值:[$(pobjMessagePushUsersRelationEN.receivePeople)], 非法，应该为字符型(In 消息推送与用户关系(MessagePushUsersRelation))!(clsMessagePushUsersRelationBL:CheckPropertyNew)");
        }
        if (null != pobjMessagePushUsersRelationEN.isReceive && undefined !== pobjMessagePushUsersRelationEN.isReceive && clsString_js_1.tzDataType.isBoolean(pobjMessagePushUsersRelationEN.isReceive) === false) {
            throw new Error("(errid:Watl000060)字段[是否接收(isReceive)]的值:[$(pobjMessagePushUsersRelationEN.isReceive)], 非法，应该为布尔型(In 消息推送与用户关系(MessagePushUsersRelation))!(clsMessagePushUsersRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.createTime) == false && undefined !== pobjMessagePushUsersRelationEN.createTime && clsString_js_1.tzDataType.isString(pobjMessagePushUsersRelationEN.createTime) === false) {
            throw new Error("(errid:Watl000060)字段[建立时间(createTime)]的值:[$(pobjMessagePushUsersRelationEN.createTime)], 非法，应该为字符型(In 消息推送与用户关系(MessagePushUsersRelation))!(clsMessagePushUsersRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.memo) == false && undefined !== pobjMessagePushUsersRelationEN.memo && clsString_js_1.tzDataType.isString(pobjMessagePushUsersRelationEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjMessagePushUsersRelationEN.memo)], 非法，应该为字符型(In 消息推送与用户关系(MessagePushUsersRelation))!(clsMessagePushUsersRelationBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjMessagePushUsersRelationEN.SetIsCheckProperty(true);
    }
    exports.MessagePushUsersRelation_CheckPropertyNew = MessagePushUsersRelation_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function MessagePushUsersRelation_CheckProperty4Update(pobjMessagePushUsersRelationEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.messagePushId) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushUsersRelationEN.messagePushId) > 8) {
            throw new Error("(errid:Watl000062)字段[消息Id(messagePushId)]的长度不能超过8(In 消息推送与用户关系(MessagePushUsersRelation))!值:$(pobjMessagePushUsersRelationEN.messagePushId)(clsMessagePushUsersRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.receivePeople) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushUsersRelationEN.receivePeople) > 50) {
            throw new Error("(errid:Watl000062)字段[接收人员(receivePeople)]的长度不能超过50(In 消息推送与用户关系(MessagePushUsersRelation))!值:$(pobjMessagePushUsersRelationEN.receivePeople)(clsMessagePushUsersRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.createTime) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushUsersRelationEN.createTime) > 16) {
            throw new Error("(errid:Watl000062)字段[建立时间(createTime)]的长度不能超过16(In 消息推送与用户关系(MessagePushUsersRelation))!值:$(pobjMessagePushUsersRelationEN.createTime)(clsMessagePushUsersRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushUsersRelationEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 消息推送与用户关系(MessagePushUsersRelation))!值:$(pobjMessagePushUsersRelationEN.memo)(clsMessagePushUsersRelationBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjMessagePushUsersRelationEN.messagePushUsersRelationId && undefined !== pobjMessagePushUsersRelationEN.messagePushUsersRelationId && clsString_js_1.tzDataType.isNumber(pobjMessagePushUsersRelationEN.messagePushUsersRelationId) === false) {
            throw new Error("(errid:Watl000063)字段[消息推送用户关系Id(messagePushUsersRelationId)]的值:[$(pobjMessagePushUsersRelationEN.messagePushUsersRelationId)], 非法，应该为数值型(In 消息推送与用户关系(MessagePushUsersRelation))!(clsMessagePushUsersRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.messagePushId) == false && undefined !== pobjMessagePushUsersRelationEN.messagePushId && clsString_js_1.tzDataType.isString(pobjMessagePushUsersRelationEN.messagePushId) === false) {
            throw new Error("(errid:Watl000063)字段[消息Id(messagePushId)]的值:[$(pobjMessagePushUsersRelationEN.messagePushId)], 非法，应该为字符型(In 消息推送与用户关系(MessagePushUsersRelation))!(clsMessagePushUsersRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.receivePeople) == false && undefined !== pobjMessagePushUsersRelationEN.receivePeople && clsString_js_1.tzDataType.isString(pobjMessagePushUsersRelationEN.receivePeople) === false) {
            throw new Error("(errid:Watl000063)字段[接收人员(receivePeople)]的值:[$(pobjMessagePushUsersRelationEN.receivePeople)], 非法，应该为字符型(In 消息推送与用户关系(MessagePushUsersRelation))!(clsMessagePushUsersRelationBL:CheckProperty4Update)");
        }
        if (null != pobjMessagePushUsersRelationEN.isReceive && undefined !== pobjMessagePushUsersRelationEN.isReceive && clsString_js_1.tzDataType.isBoolean(pobjMessagePushUsersRelationEN.isReceive) === false) {
            throw new Error("(errid:Watl000063)字段[是否接收(isReceive)]的值:[$(pobjMessagePushUsersRelationEN.isReceive)], 非法，应该为布尔型(In 消息推送与用户关系(MessagePushUsersRelation))!(clsMessagePushUsersRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.createTime) == false && undefined !== pobjMessagePushUsersRelationEN.createTime && clsString_js_1.tzDataType.isString(pobjMessagePushUsersRelationEN.createTime) === false) {
            throw new Error("(errid:Watl000063)字段[建立时间(createTime)]的值:[$(pobjMessagePushUsersRelationEN.createTime)], 非法，应该为字符型(In 消息推送与用户关系(MessagePushUsersRelation))!(clsMessagePushUsersRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushUsersRelationEN.memo) == false && undefined !== pobjMessagePushUsersRelationEN.memo && clsString_js_1.tzDataType.isString(pobjMessagePushUsersRelationEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjMessagePushUsersRelationEN.memo)], 非法，应该为字符型(In 消息推送与用户关系(MessagePushUsersRelation))!(clsMessagePushUsersRelationBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjMessagePushUsersRelationEN.messagePushUsersRelationId
            || pobjMessagePushUsersRelationEN.messagePushUsersRelationId != null && pobjMessagePushUsersRelationEN.messagePushUsersRelationId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[消息推送用户关系Id]不能为空(In 消息推送与用户关系)!(clsMessagePushUsersRelationBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjMessagePushUsersRelationEN.SetIsCheckProperty(true);
    }
    exports.MessagePushUsersRelation_CheckProperty4Update = MessagePushUsersRelation_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function MessagePushUsersRelation_GetJSONStrByObj(pobjMessagePushUsersRelationEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjMessagePushUsersRelationEN.sf_UpdFldSetStr = pobjMessagePushUsersRelationEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjMessagePushUsersRelationEN);
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
    exports.MessagePushUsersRelation_GetJSONStrByObj = MessagePushUsersRelation_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function MessagePushUsersRelation_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrMessagePushUsersRelationObjLst = new Array();
        if (strJSON === "") {
            return arrMessagePushUsersRelationObjLst;
        }
        try {
            arrMessagePushUsersRelationObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrMessagePushUsersRelationObjLst;
        }
        return arrMessagePushUsersRelationObjLst;
    }
    exports.MessagePushUsersRelation_GetObjLstByJSONStr = MessagePushUsersRelation_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrMessagePushUsersRelationObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function MessagePushUsersRelation_GetObjLstByJSONObjLst(arrMessagePushUsersRelationObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrMessagePushUsersRelationObjLst = new Array();
        for (const objInFor of arrMessagePushUsersRelationObjLstS) {
            const obj1 = MessagePushUsersRelation_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrMessagePushUsersRelationObjLst.push(obj1);
        }
        return arrMessagePushUsersRelationObjLst;
    }
    exports.MessagePushUsersRelation_GetObjLstByJSONObjLst = MessagePushUsersRelation_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function MessagePushUsersRelation_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjMessagePushUsersRelationEN = new clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN();
        if (strJSON === "") {
            return pobjMessagePushUsersRelationEN;
        }
        try {
            pobjMessagePushUsersRelationEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjMessagePushUsersRelationEN;
        }
        return pobjMessagePushUsersRelationEN;
    }
    exports.MessagePushUsersRelation_GetObjByJSONStr = MessagePushUsersRelation_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function MessagePushUsersRelation_GetCombineCondition(objMessagePushUsersRelation_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objMessagePushUsersRelation_Cond.dicFldComparisonOp, clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_MessagePushUsersRelationId) == true) {
            const strComparisonOp_MessagePushUsersRelationId = objMessagePushUsersRelation_Cond.dicFldComparisonOp[clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_MessagePushUsersRelationId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_MessagePushUsersRelationId, objMessagePushUsersRelation_Cond.messagePushUsersRelationId, strComparisonOp_MessagePushUsersRelationId);
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePushUsersRelation_Cond.dicFldComparisonOp, clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_MessagePushId) == true) {
            const strComparisonOp_MessagePushId = objMessagePushUsersRelation_Cond.dicFldComparisonOp[clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_MessagePushId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_MessagePushId, objMessagePushUsersRelation_Cond.messagePushId, strComparisonOp_MessagePushId);
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePushUsersRelation_Cond.dicFldComparisonOp, clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_ReceivePeople) == true) {
            const strComparisonOp_ReceivePeople = objMessagePushUsersRelation_Cond.dicFldComparisonOp[clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_ReceivePeople];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_ReceivePeople, objMessagePushUsersRelation_Cond.receivePeople, strComparisonOp_ReceivePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePushUsersRelation_Cond.dicFldComparisonOp, clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_IsReceive) == true) {
            if (objMessagePushUsersRelation_Cond.isReceive == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_IsReceive);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_IsReceive);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePushUsersRelation_Cond.dicFldComparisonOp, clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_CreateTime) == true) {
            const strComparisonOp_CreateTime = objMessagePushUsersRelation_Cond.dicFldComparisonOp[clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_CreateTime];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_CreateTime, objMessagePushUsersRelation_Cond.createTime, strComparisonOp_CreateTime);
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePushUsersRelation_Cond.dicFldComparisonOp, clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_Memo) == true) {
            const strComparisonOp_Memo = objMessagePushUsersRelation_Cond.dicFldComparisonOp[clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN.con_Memo, objMessagePushUsersRelation_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.MessagePushUsersRelation_GetCombineCondition = MessagePushUsersRelation_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--MessagePushUsersRelation(消息推送与用户关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strMessagePushId: 消息Id(要求唯一的字段)
    * @param strReceivePeople: 接收人员(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function MessagePushUsersRelation_GetUniCondStr_MessagePushId_ReceivePeople(objMessagePushUsersRelationEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and MessagePushId = '{0}'", objMessagePushUsersRelationEN.messagePushId);
        strWhereCond += (0, clsString_js_2.Format)(" and ReceivePeople = '{0}'", objMessagePushUsersRelationEN.receivePeople);
        return strWhereCond;
    }
    exports.MessagePushUsersRelation_GetUniCondStr_MessagePushId_ReceivePeople = MessagePushUsersRelation_GetUniCondStr_MessagePushId_ReceivePeople;
    /**
    *获取唯一性条件串(Uniqueness)--MessagePushUsersRelation(消息推送与用户关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strMessagePushId: 消息Id(要求唯一的字段)
    * @param strReceivePeople: 接收人员(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function MessagePushUsersRelation_GetUniCondStr4Update_MessagePushId_ReceivePeople(objMessagePushUsersRelationEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and MessagePushUsersRelationId <> '{0}'", objMessagePushUsersRelationEN.messagePushUsersRelationId);
        strWhereCond += (0, clsString_js_2.Format)(" and MessagePushId = '{0}'", objMessagePushUsersRelationEN.messagePushId);
        strWhereCond += (0, clsString_js_2.Format)(" and ReceivePeople = '{0}'", objMessagePushUsersRelationEN.receivePeople);
        return strWhereCond;
    }
    exports.MessagePushUsersRelation_GetUniCondStr4Update_MessagePushId_ReceivePeople = MessagePushUsersRelation_GetUniCondStr4Update_MessagePushId_ReceivePeople;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objMessagePushUsersRelationENS:源对象
     * @param objMessagePushUsersRelationENT:目标对象
    */
    function MessagePushUsersRelation_CopyObjTo(objMessagePushUsersRelationENS, objMessagePushUsersRelationENT) {
        objMessagePushUsersRelationENT.messagePushUsersRelationId = objMessagePushUsersRelationENS.messagePushUsersRelationId; //消息推送用户关系Id
        objMessagePushUsersRelationENT.messagePushId = objMessagePushUsersRelationENS.messagePushId; //消息Id
        objMessagePushUsersRelationENT.receivePeople = objMessagePushUsersRelationENS.receivePeople; //接收人员
        objMessagePushUsersRelationENT.isReceive = objMessagePushUsersRelationENS.isReceive; //是否接收
        objMessagePushUsersRelationENT.createTime = objMessagePushUsersRelationENS.createTime; //建立时间
        objMessagePushUsersRelationENT.memo = objMessagePushUsersRelationENS.memo; //备注
        objMessagePushUsersRelationENT.sf_UpdFldSetStr = objMessagePushUsersRelationENS.updFldString; //sf_UpdFldSetStr
    }
    exports.MessagePushUsersRelation_CopyObjTo = MessagePushUsersRelation_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objMessagePushUsersRelationENS:源对象
     * @param objMessagePushUsersRelationENT:目标对象
    */
    function MessagePushUsersRelation_GetObjFromJsonObj(objMessagePushUsersRelationENS) {
        const objMessagePushUsersRelationENT = new clsMessagePushUsersRelationEN_js_1.clsMessagePushUsersRelationEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objMessagePushUsersRelationENT, objMessagePushUsersRelationENS);
        return objMessagePushUsersRelationENT;
    }
    exports.MessagePushUsersRelation_GetObjFromJsonObj = MessagePushUsersRelation_GetObjFromJsonObj;
});
