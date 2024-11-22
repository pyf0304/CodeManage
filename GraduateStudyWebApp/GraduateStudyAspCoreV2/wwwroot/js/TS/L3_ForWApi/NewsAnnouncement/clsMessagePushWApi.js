/**
* 类名:clsMessagePushWApi
* 表名:MessagePush(01120280)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:51:19
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
        define(["require", "exports", "axios", "../../L0_Entity/NewsAnnouncement/clsMessagePushEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.MessagePush_GetObjFromJsonObj = exports.MessagePush_CopyObjTo = exports.MessagePush_GetUniCondStr4Update_MessagePushNumber_UpdDate = exports.MessagePush_GetUniCondStr_MessagePushNumber_UpdDate = exports.MessagePush_GetCombineCondition = exports.MessagePush_GetObjByJSONStr = exports.MessagePush_GetObjLstByJSONObjLst = exports.MessagePush_GetObjLstByJSONStr = exports.MessagePush_GetJSONStrByObj = exports.MessagePush_CheckProperty4Update = exports.MessagePush_CheckPropertyNew = exports.MessagePush_GetWebApiUrl = exports.MessagePush_GetMaxStrIdByPrefix = exports.MessagePush_GetMaxStrIdAsync = exports.MessagePush_GetRecCountByCondAsync = exports.MessagePush_IsExistAsync = exports.MessagePush_IsExist = exports.MessagePush_IsExistRecordAsync = exports.MessagePush_UpdateWithConditionAsync = exports.MessagePush_UpdateRecordAsync = exports.MessagePush_AddNewRecordWithReturnKey = exports.MessagePush_AddNewRecordWithReturnKeyAsync = exports.MessagePush_AddNewRecordWithMaxIdAsync = exports.MessagePush_AddNewRecordAsync = exports.MessagePush_DelMessagePushsByCondAsync = exports.MessagePush_DelMessagePushsAsync = exports.MessagePush_DelRecordAsync = exports.MessagePush_GetObjLstByPagerAsync = exports.MessagePush_GetObjLstByRange = exports.MessagePush_GetObjLstByRangeAsync = exports.MessagePush_GetTopObjLstAsync = exports.MessagePush_GetObjLstByMessagePushIdLstAsync = exports.MessagePush_GetObjLstAsync = exports.MessagePush_GetFirstObjAsync = exports.MessagePush_GetFirstID = exports.MessagePush_GetFirstIDAsync = exports.MessagePush_FilterFunByKey = exports.MessagePush_SortFunByKey = exports.MessagePush_SortFun_Defa_2Fld = exports.MessagePush_SortFun_Defa = exports.MessagePush_GetObjByMessagePushIdAsync = exports.messagePush_ConstructorName = exports.messagePush_Controller = void 0;
    /**
     * 消息推送(MessagePush)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsMessagePushEN_js_1 = require("../../L0_Entity/NewsAnnouncement/clsMessagePushEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.messagePush_Controller = "MessagePushApi";
    exports.messagePush_ConstructorName = "messagePush";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strMessagePushId:关键字
    * @returns 对象
    **/
    async function MessagePush_GetObjByMessagePushIdAsync(strMessagePushId) {
        const strThisFuncName = "GetObjByMessagePushIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strMessagePushId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strMessagePushId]不能为空！(In clsMessagePushWApi.GetObjByMessagePushIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strMessagePushId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strMessagePushId]的长度:[{0}]不正确！(clsMessagePushWApi.GetObjByMessagePushIdAsync)", strMessagePushId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByMessagePushId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strMessagePushId": strMessagePushId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objMessagePush = MessagePush_GetObjFromJsonObj(returnObj);
                return objMessagePush;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetObjByMessagePushIdAsync = MessagePush_GetObjByMessagePushIdAsync;
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
    function MessagePush_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.messagePushId.localeCompare(b.messagePushId);
    }
    exports.MessagePush_SortFun_Defa = MessagePush_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function MessagePush_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.messagePushNumber == b.messagePushNumber)
            return a.messageTitle.localeCompare(b.messageTitle);
        else
            return a.messagePushNumber.localeCompare(b.messagePushNumber);
    }
    exports.MessagePush_SortFun_Defa_2Fld = MessagePush_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function MessagePush_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsMessagePushEN_js_1.clsMessagePushEN.con_MessagePushId:
                    return (a, b) => {
                        return a.messagePushId.localeCompare(b.messagePushId);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_MessagePushNumber:
                    return (a, b) => {
                        if (a.messagePushNumber == null)
                            return -1;
                        if (b.messagePushNumber == null)
                            return 1;
                        return a.messagePushNumber.localeCompare(b.messagePushNumber);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_MessageTitle:
                    return (a, b) => {
                        if (a.messageTitle == null)
                            return -1;
                        if (b.messageTitle == null)
                            return 1;
                        return a.messageTitle.localeCompare(b.messageTitle);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_MessageContent:
                    return (a, b) => {
                        if (a.messageContent == null)
                            return -1;
                        if (b.messageContent == null)
                            return 1;
                        return a.messageContent.localeCompare(b.messageContent);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_ReceivePeople:
                    return (a, b) => {
                        if (a.receivePeople == null)
                            return -1;
                        if (b.receivePeople == null)
                            return 1;
                        return a.receivePeople.localeCompare(b.receivePeople);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_MessageTypeId:
                    return (a, b) => {
                        return a.messageTypeId.localeCompare(b.messageTypeId);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_IsAllpush:
                    return (a, b) => {
                        if (a.isAllpush == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_IsReceive:
                    return (a, b) => {
                        if (a.isReceive == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_ClientVersionTypeId:
                    return (a, b) => {
                        if (a.clientVersionTypeId == null)
                            return -1;
                        if (b.clientVersionTypeId == null)
                            return 1;
                        return a.clientVersionTypeId.localeCompare(b.clientVersionTypeId);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[MessagePush]中不存在！(in ${exports.messagePush_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsMessagePushEN_js_1.clsMessagePushEN.con_MessagePushId:
                    return (a, b) => {
                        return b.messagePushId.localeCompare(a.messagePushId);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_MessagePushNumber:
                    return (a, b) => {
                        if (b.messagePushNumber == null)
                            return -1;
                        if (a.messagePushNumber == null)
                            return 1;
                        return b.messagePushNumber.localeCompare(a.messagePushNumber);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_MessageTitle:
                    return (a, b) => {
                        if (b.messageTitle == null)
                            return -1;
                        if (a.messageTitle == null)
                            return 1;
                        return b.messageTitle.localeCompare(a.messageTitle);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_MessageContent:
                    return (a, b) => {
                        if (b.messageContent == null)
                            return -1;
                        if (a.messageContent == null)
                            return 1;
                        return b.messageContent.localeCompare(a.messageContent);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_ReceivePeople:
                    return (a, b) => {
                        if (b.receivePeople == null)
                            return -1;
                        if (a.receivePeople == null)
                            return 1;
                        return b.receivePeople.localeCompare(a.receivePeople);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_MessageTypeId:
                    return (a, b) => {
                        return b.messageTypeId.localeCompare(a.messageTypeId);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_IsAllpush:
                    return (a, b) => {
                        if (b.isAllpush == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_IsReceive:
                    return (a, b) => {
                        if (b.isReceive == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_ClientVersionTypeId:
                    return (a, b) => {
                        if (b.clientVersionTypeId == null)
                            return -1;
                        if (a.clientVersionTypeId == null)
                            return 1;
                        return b.clientVersionTypeId.localeCompare(a.clientVersionTypeId);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsMessagePushEN_js_1.clsMessagePushEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[MessagePush]中不存在！(in ${exports.messagePush_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.MessagePush_SortFunByKey = MessagePush_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function MessagePush_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsMessagePushEN_js_1.clsMessagePushEN.con_MessagePushId:
                return (obj) => {
                    return obj.messagePushId === value;
                };
            case clsMessagePushEN_js_1.clsMessagePushEN.con_MessagePushNumber:
                return (obj) => {
                    return obj.messagePushNumber === value;
                };
            case clsMessagePushEN_js_1.clsMessagePushEN.con_MessageTitle:
                return (obj) => {
                    return obj.messageTitle === value;
                };
            case clsMessagePushEN_js_1.clsMessagePushEN.con_MessageContent:
                return (obj) => {
                    return obj.messageContent === value;
                };
            case clsMessagePushEN_js_1.clsMessagePushEN.con_ReceivePeople:
                return (obj) => {
                    return obj.receivePeople === value;
                };
            case clsMessagePushEN_js_1.clsMessagePushEN.con_MessageTypeId:
                return (obj) => {
                    return obj.messageTypeId === value;
                };
            case clsMessagePushEN_js_1.clsMessagePushEN.con_IsAllpush:
                return (obj) => {
                    return obj.isAllpush === value;
                };
            case clsMessagePushEN_js_1.clsMessagePushEN.con_IsReceive:
                return (obj) => {
                    return obj.isReceive === value;
                };
            case clsMessagePushEN_js_1.clsMessagePushEN.con_ClientVersionTypeId:
                return (obj) => {
                    return obj.clientVersionTypeId === value;
                };
            case clsMessagePushEN_js_1.clsMessagePushEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsMessagePushEN_js_1.clsMessagePushEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[MessagePush]中不存在！(in ${exports.messagePush_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.MessagePush_FilterFunByKey = MessagePush_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function MessagePush_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetFirstIDAsync = MessagePush_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function MessagePush_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetFirstID = MessagePush_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function MessagePush_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
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
                const objMessagePush = MessagePush_GetObjFromJsonObj(returnObj);
                return objMessagePush;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetFirstObjAsync = MessagePush_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function MessagePush_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.messagePush_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MessagePush_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetObjLstAsync = MessagePush_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrMessagePushId:关键字列表
    * @returns 对象列表
    **/
    async function MessagePush_GetObjLstByMessagePushIdLstAsync(arrMessagePushId) {
        const strThisFuncName = "GetObjLstByMessagePushIdLstAsync";
        const strAction = "GetObjLstByMessagePushIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMessagePushId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.messagePush_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MessagePush_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetObjLstByMessagePushIdLstAsync = MessagePush_GetObjLstByMessagePushIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function MessagePush_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.messagePush_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MessagePush_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetTopObjLstAsync = MessagePush_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function MessagePush_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.messagePush_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MessagePush_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetObjLstByRangeAsync = MessagePush_GetObjLstByRangeAsync;
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
    async function MessagePush_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetObjLstByRange = MessagePush_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function MessagePush_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.messagePush_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MessagePush_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetObjLstByPagerAsync = MessagePush_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strMessagePushId:关键字
    * @returns 获取删除的结果
    **/
    async function MessagePush_DelRecordAsync(strMessagePushId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strMessagePushId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_DelRecordAsync = MessagePush_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrMessagePushId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function MessagePush_DelMessagePushsAsync(arrMessagePushId) {
        const strThisFuncName = "DelMessagePushsAsync";
        const strAction = "DelMessagePushs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMessagePushId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_DelMessagePushsAsync = MessagePush_DelMessagePushsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function MessagePush_DelMessagePushsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelMessagePushsByCondAsync";
        const strAction = "DelMessagePushsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_DelMessagePushsByCondAsync = MessagePush_DelMessagePushsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objMessagePushEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function MessagePush_AddNewRecordAsync(objMessagePushEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objMessagePushEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMessagePushEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_AddNewRecordAsync = MessagePush_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objMessagePushEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function MessagePush_AddNewRecordWithMaxIdAsync(objMessagePushEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMessagePushEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_AddNewRecordWithMaxIdAsync = MessagePush_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objMessagePushEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function MessagePush_AddNewRecordWithReturnKeyAsync(objMessagePushEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMessagePushEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_AddNewRecordWithReturnKeyAsync = MessagePush_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objMessagePushEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function MessagePush_AddNewRecordWithReturnKey(objMessagePushEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objMessagePushEN.messagePushId === null || objMessagePushEN.messagePushId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMessagePushEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_AddNewRecordWithReturnKey = MessagePush_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objMessagePushEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function MessagePush_UpdateRecordAsync(objMessagePushEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objMessagePushEN.sf_UpdFldSetStr === undefined || objMessagePushEN.sf_UpdFldSetStr === null || objMessagePushEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objMessagePushEN.messagePushId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMessagePushEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_UpdateRecordAsync = MessagePush_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objMessagePushEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function MessagePush_UpdateWithConditionAsync(objMessagePushEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objMessagePushEN.sf_UpdFldSetStr === undefined || objMessagePushEN.sf_UpdFldSetStr === null || objMessagePushEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objMessagePushEN.messagePushId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        objMessagePushEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objMessagePushEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_UpdateWithConditionAsync = MessagePush_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function MessagePush_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_IsExistRecordAsync = MessagePush_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strMessagePushId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function MessagePush_IsExist(strMessagePushId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "MessagePushId": strMessagePushId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_IsExist = MessagePush_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strMessagePushId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function MessagePush_IsExistAsync(strMessagePushId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strMessagePushId": strMessagePushId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_IsExistAsync = MessagePush_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function MessagePush_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetRecCountByCondAsync = MessagePush_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function MessagePush_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetMaxStrIdAsync = MessagePush_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function MessagePush_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.messagePush_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.messagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MessagePush_GetMaxStrIdByPrefix = MessagePush_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function MessagePush_GetWebApiUrl(strController, strAction) {
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
    exports.MessagePush_GetWebApiUrl = MessagePush_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function MessagePush_CheckPropertyNew(pobjMessagePushEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[消息类型Id]不能为空(In 消息推送)!(clsMessagePushBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messagePushId) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.messagePushId) > 8) {
            throw new Error("(errid:Watl000059)字段[消息Id(messagePushId)]的长度不能超过8(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.messagePushId)(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messagePushNumber) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.messagePushNumber) > 200) {
            throw new Error("(errid:Watl000059)字段[消息编号(messagePushNumber)]的长度不能超过200(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.messagePushNumber)(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageTitle) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.messageTitle) > 500) {
            throw new Error("(errid:Watl000059)字段[消息标题(messageTitle)]的长度不能超过500(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.messageTitle)(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageContent) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.messageContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[消息内容(messageContent)]的长度不能超过2000(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.messageContent)(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.receivePeople) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.receivePeople) > 50) {
            throw new Error("(errid:Watl000059)字段[接收人员(receivePeople)]的长度不能超过50(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.receivePeople)(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.messageTypeId) > 8) {
            throw new Error("(errid:Watl000059)字段[消息类型Id(messageTypeId)]的长度不能超过8(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.messageTypeId)(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.clientVersionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.clientVersionTypeId) > 8) {
            throw new Error("(errid:Watl000059)字段[客户端版本类型Id(clientVersionTypeId)]的长度不能超过8(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.clientVersionTypeId)(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.updDate)(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.memo)(clsMessagePushBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messagePushId) == false && undefined !== pobjMessagePushEN.messagePushId && clsString_js_1.tzDataType.isString(pobjMessagePushEN.messagePushId) === false) {
            throw new Error("(errid:Watl000060)字段[消息Id(messagePushId)]的值:[$(pobjMessagePushEN.messagePushId)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messagePushNumber) == false && undefined !== pobjMessagePushEN.messagePushNumber && clsString_js_1.tzDataType.isString(pobjMessagePushEN.messagePushNumber) === false) {
            throw new Error("(errid:Watl000060)字段[消息编号(messagePushNumber)]的值:[$(pobjMessagePushEN.messagePushNumber)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageTitle) == false && undefined !== pobjMessagePushEN.messageTitle && clsString_js_1.tzDataType.isString(pobjMessagePushEN.messageTitle) === false) {
            throw new Error("(errid:Watl000060)字段[消息标题(messageTitle)]的值:[$(pobjMessagePushEN.messageTitle)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageContent) == false && undefined !== pobjMessagePushEN.messageContent && clsString_js_1.tzDataType.isString(pobjMessagePushEN.messageContent) === false) {
            throw new Error("(errid:Watl000060)字段[消息内容(messageContent)]的值:[$(pobjMessagePushEN.messageContent)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.receivePeople) == false && undefined !== pobjMessagePushEN.receivePeople && clsString_js_1.tzDataType.isString(pobjMessagePushEN.receivePeople) === false) {
            throw new Error("(errid:Watl000060)字段[接收人员(receivePeople)]的值:[$(pobjMessagePushEN.receivePeople)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageTypeId) == false && undefined !== pobjMessagePushEN.messageTypeId && clsString_js_1.tzDataType.isString(pobjMessagePushEN.messageTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[消息类型Id(messageTypeId)]的值:[$(pobjMessagePushEN.messageTypeId)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckPropertyNew)");
        }
        if (null != pobjMessagePushEN.isAllpush && undefined !== pobjMessagePushEN.isAllpush && clsString_js_1.tzDataType.isBoolean(pobjMessagePushEN.isAllpush) === false) {
            throw new Error("(errid:Watl000060)字段[是否全体推送(isAllpush)]的值:[$(pobjMessagePushEN.isAllpush)], 非法，应该为布尔型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckPropertyNew)");
        }
        if (null != pobjMessagePushEN.isReceive && undefined !== pobjMessagePushEN.isReceive && clsString_js_1.tzDataType.isBoolean(pobjMessagePushEN.isReceive) === false) {
            throw new Error("(errid:Watl000060)字段[是否接收(isReceive)]的值:[$(pobjMessagePushEN.isReceive)], 非法，应该为布尔型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.clientVersionTypeId) == false && undefined !== pobjMessagePushEN.clientVersionTypeId && clsString_js_1.tzDataType.isString(pobjMessagePushEN.clientVersionTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[客户端版本类型Id(clientVersionTypeId)]的值:[$(pobjMessagePushEN.clientVersionTypeId)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.updDate) == false && undefined !== pobjMessagePushEN.updDate && clsString_js_1.tzDataType.isString(pobjMessagePushEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjMessagePushEN.updDate)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.memo) == false && undefined !== pobjMessagePushEN.memo && clsString_js_1.tzDataType.isString(pobjMessagePushEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjMessagePushEN.memo)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.messageTypeId) != 8) {
            throw ("(errid:Watl000061)字段[消息类型Id]作为外键字段,长度应该为8(In 消息推送)!(clsMessagePushBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjMessagePushEN.SetIsCheckProperty(true);
    }
    exports.MessagePush_CheckPropertyNew = MessagePush_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function MessagePush_CheckProperty4Update(pobjMessagePushEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messagePushId) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.messagePushId) > 8) {
            throw new Error("(errid:Watl000062)字段[消息Id(messagePushId)]的长度不能超过8(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.messagePushId)(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messagePushNumber) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.messagePushNumber) > 200) {
            throw new Error("(errid:Watl000062)字段[消息编号(messagePushNumber)]的长度不能超过200(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.messagePushNumber)(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageTitle) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.messageTitle) > 500) {
            throw new Error("(errid:Watl000062)字段[消息标题(messageTitle)]的长度不能超过500(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.messageTitle)(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageContent) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.messageContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[消息内容(messageContent)]的长度不能超过2000(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.messageContent)(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.receivePeople) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.receivePeople) > 50) {
            throw new Error("(errid:Watl000062)字段[接收人员(receivePeople)]的长度不能超过50(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.receivePeople)(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.messageTypeId) > 8) {
            throw new Error("(errid:Watl000062)字段[消息类型Id(messageTypeId)]的长度不能超过8(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.messageTypeId)(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.clientVersionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.clientVersionTypeId) > 8) {
            throw new Error("(errid:Watl000062)字段[客户端版本类型Id(clientVersionTypeId)]的长度不能超过8(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.clientVersionTypeId)(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.updDate)(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 消息推送(MessagePush))!值:$(pobjMessagePushEN.memo)(clsMessagePushBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messagePushId) == false && undefined !== pobjMessagePushEN.messagePushId && clsString_js_1.tzDataType.isString(pobjMessagePushEN.messagePushId) === false) {
            throw new Error("(errid:Watl000063)字段[消息Id(messagePushId)]的值:[$(pobjMessagePushEN.messagePushId)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messagePushNumber) == false && undefined !== pobjMessagePushEN.messagePushNumber && clsString_js_1.tzDataType.isString(pobjMessagePushEN.messagePushNumber) === false) {
            throw new Error("(errid:Watl000063)字段[消息编号(messagePushNumber)]的值:[$(pobjMessagePushEN.messagePushNumber)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageTitle) == false && undefined !== pobjMessagePushEN.messageTitle && clsString_js_1.tzDataType.isString(pobjMessagePushEN.messageTitle) === false) {
            throw new Error("(errid:Watl000063)字段[消息标题(messageTitle)]的值:[$(pobjMessagePushEN.messageTitle)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageContent) == false && undefined !== pobjMessagePushEN.messageContent && clsString_js_1.tzDataType.isString(pobjMessagePushEN.messageContent) === false) {
            throw new Error("(errid:Watl000063)字段[消息内容(messageContent)]的值:[$(pobjMessagePushEN.messageContent)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.receivePeople) == false && undefined !== pobjMessagePushEN.receivePeople && clsString_js_1.tzDataType.isString(pobjMessagePushEN.receivePeople) === false) {
            throw new Error("(errid:Watl000063)字段[接收人员(receivePeople)]的值:[$(pobjMessagePushEN.receivePeople)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageTypeId) == false && undefined !== pobjMessagePushEN.messageTypeId && clsString_js_1.tzDataType.isString(pobjMessagePushEN.messageTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[消息类型Id(messageTypeId)]的值:[$(pobjMessagePushEN.messageTypeId)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckProperty4Update)");
        }
        if (null != pobjMessagePushEN.isAllpush && undefined !== pobjMessagePushEN.isAllpush && clsString_js_1.tzDataType.isBoolean(pobjMessagePushEN.isAllpush) === false) {
            throw new Error("(errid:Watl000063)字段[是否全体推送(isAllpush)]的值:[$(pobjMessagePushEN.isAllpush)], 非法，应该为布尔型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckProperty4Update)");
        }
        if (null != pobjMessagePushEN.isReceive && undefined !== pobjMessagePushEN.isReceive && clsString_js_1.tzDataType.isBoolean(pobjMessagePushEN.isReceive) === false) {
            throw new Error("(errid:Watl000063)字段[是否接收(isReceive)]的值:[$(pobjMessagePushEN.isReceive)], 非法，应该为布尔型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.clientVersionTypeId) == false && undefined !== pobjMessagePushEN.clientVersionTypeId && clsString_js_1.tzDataType.isString(pobjMessagePushEN.clientVersionTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[客户端版本类型Id(clientVersionTypeId)]的值:[$(pobjMessagePushEN.clientVersionTypeId)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.updDate) == false && undefined !== pobjMessagePushEN.updDate && clsString_js_1.tzDataType.isString(pobjMessagePushEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjMessagePushEN.updDate)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.memo) == false && undefined !== pobjMessagePushEN.memo && clsString_js_1.tzDataType.isString(pobjMessagePushEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjMessagePushEN.memo)], 非法，应该为字符型(In 消息推送(MessagePush))!(clsMessagePushBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messagePushId) === true) {
            throw new Error("(errid:Watl000064)字段[消息Id]不能为空(In 消息推送)!(clsMessagePushBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjMessagePushEN.messageTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjMessagePushEN.messageTypeId) != 8) {
            throw ("(errid:Watl000065)字段[消息类型Id]作为外键字段,长度应该为8(In 消息推送)!(clsMessagePushBL:CheckPropertyNew)");
        }
        pobjMessagePushEN.SetIsCheckProperty(true);
    }
    exports.MessagePush_CheckProperty4Update = MessagePush_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function MessagePush_GetJSONStrByObj(pobjMessagePushEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjMessagePushEN.sf_UpdFldSetStr = pobjMessagePushEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjMessagePushEN);
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
    exports.MessagePush_GetJSONStrByObj = MessagePush_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function MessagePush_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrMessagePushObjLst = new Array();
        if (strJSON === "") {
            return arrMessagePushObjLst;
        }
        try {
            arrMessagePushObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrMessagePushObjLst;
        }
        return arrMessagePushObjLst;
    }
    exports.MessagePush_GetObjLstByJSONStr = MessagePush_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrMessagePushObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function MessagePush_GetObjLstByJSONObjLst(arrMessagePushObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrMessagePushObjLst = new Array();
        for (const objInFor of arrMessagePushObjLstS) {
            const obj1 = MessagePush_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrMessagePushObjLst.push(obj1);
        }
        return arrMessagePushObjLst;
    }
    exports.MessagePush_GetObjLstByJSONObjLst = MessagePush_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function MessagePush_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjMessagePushEN = new clsMessagePushEN_js_1.clsMessagePushEN();
        if (strJSON === "") {
            return pobjMessagePushEN;
        }
        try {
            pobjMessagePushEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjMessagePushEN;
        }
        return pobjMessagePushEN;
    }
    exports.MessagePush_GetObjByJSONStr = MessagePush_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function MessagePush_GetCombineCondition(objMessagePush_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objMessagePush_Cond.dicFldComparisonOp, clsMessagePushEN_js_1.clsMessagePushEN.con_MessagePushId) == true) {
            const strComparisonOp_MessagePushId = objMessagePush_Cond.dicFldComparisonOp[clsMessagePushEN_js_1.clsMessagePushEN.con_MessagePushId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushEN_js_1.clsMessagePushEN.con_MessagePushId, objMessagePush_Cond.messagePushId, strComparisonOp_MessagePushId);
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePush_Cond.dicFldComparisonOp, clsMessagePushEN_js_1.clsMessagePushEN.con_MessagePushNumber) == true) {
            const strComparisonOp_MessagePushNumber = objMessagePush_Cond.dicFldComparisonOp[clsMessagePushEN_js_1.clsMessagePushEN.con_MessagePushNumber];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushEN_js_1.clsMessagePushEN.con_MessagePushNumber, objMessagePush_Cond.messagePushNumber, strComparisonOp_MessagePushNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePush_Cond.dicFldComparisonOp, clsMessagePushEN_js_1.clsMessagePushEN.con_MessageTitle) == true) {
            const strComparisonOp_MessageTitle = objMessagePush_Cond.dicFldComparisonOp[clsMessagePushEN_js_1.clsMessagePushEN.con_MessageTitle];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushEN_js_1.clsMessagePushEN.con_MessageTitle, objMessagePush_Cond.messageTitle, strComparisonOp_MessageTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePush_Cond.dicFldComparisonOp, clsMessagePushEN_js_1.clsMessagePushEN.con_MessageContent) == true) {
            const strComparisonOp_MessageContent = objMessagePush_Cond.dicFldComparisonOp[clsMessagePushEN_js_1.clsMessagePushEN.con_MessageContent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushEN_js_1.clsMessagePushEN.con_MessageContent, objMessagePush_Cond.messageContent, strComparisonOp_MessageContent);
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePush_Cond.dicFldComparisonOp, clsMessagePushEN_js_1.clsMessagePushEN.con_ReceivePeople) == true) {
            const strComparisonOp_ReceivePeople = objMessagePush_Cond.dicFldComparisonOp[clsMessagePushEN_js_1.clsMessagePushEN.con_ReceivePeople];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushEN_js_1.clsMessagePushEN.con_ReceivePeople, objMessagePush_Cond.receivePeople, strComparisonOp_ReceivePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePush_Cond.dicFldComparisonOp, clsMessagePushEN_js_1.clsMessagePushEN.con_MessageTypeId) == true) {
            const strComparisonOp_MessageTypeId = objMessagePush_Cond.dicFldComparisonOp[clsMessagePushEN_js_1.clsMessagePushEN.con_MessageTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushEN_js_1.clsMessagePushEN.con_MessageTypeId, objMessagePush_Cond.messageTypeId, strComparisonOp_MessageTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePush_Cond.dicFldComparisonOp, clsMessagePushEN_js_1.clsMessagePushEN.con_IsAllpush) == true) {
            if (objMessagePush_Cond.isAllpush == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsMessagePushEN_js_1.clsMessagePushEN.con_IsAllpush);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsMessagePushEN_js_1.clsMessagePushEN.con_IsAllpush);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePush_Cond.dicFldComparisonOp, clsMessagePushEN_js_1.clsMessagePushEN.con_IsReceive) == true) {
            if (objMessagePush_Cond.isReceive == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsMessagePushEN_js_1.clsMessagePushEN.con_IsReceive);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsMessagePushEN_js_1.clsMessagePushEN.con_IsReceive);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePush_Cond.dicFldComparisonOp, clsMessagePushEN_js_1.clsMessagePushEN.con_ClientVersionTypeId) == true) {
            const strComparisonOp_ClientVersionTypeId = objMessagePush_Cond.dicFldComparisonOp[clsMessagePushEN_js_1.clsMessagePushEN.con_ClientVersionTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushEN_js_1.clsMessagePushEN.con_ClientVersionTypeId, objMessagePush_Cond.clientVersionTypeId, strComparisonOp_ClientVersionTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePush_Cond.dicFldComparisonOp, clsMessagePushEN_js_1.clsMessagePushEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objMessagePush_Cond.dicFldComparisonOp[clsMessagePushEN_js_1.clsMessagePushEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushEN_js_1.clsMessagePushEN.con_UpdDate, objMessagePush_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objMessagePush_Cond.dicFldComparisonOp, clsMessagePushEN_js_1.clsMessagePushEN.con_Memo) == true) {
            const strComparisonOp_Memo = objMessagePush_Cond.dicFldComparisonOp[clsMessagePushEN_js_1.clsMessagePushEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsMessagePushEN_js_1.clsMessagePushEN.con_Memo, objMessagePush_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.MessagePush_GetCombineCondition = MessagePush_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--MessagePush(消息推送),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strMessagePushNumber: 消息编号(要求唯一的字段)
    * @param strUpdDate: 修改日期(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function MessagePush_GetUniCondStr_MessagePushNumber_UpdDate(objMessagePushEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and MessagePushNumber = '{0}'", objMessagePushEN.messagePushNumber);
        strWhereCond += (0, clsString_js_2.Format)(" and UpdDate = '{0}'", objMessagePushEN.updDate);
        return strWhereCond;
    }
    exports.MessagePush_GetUniCondStr_MessagePushNumber_UpdDate = MessagePush_GetUniCondStr_MessagePushNumber_UpdDate;
    /**
    *获取唯一性条件串(Uniqueness)--MessagePush(消息推送),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strMessagePushNumber: 消息编号(要求唯一的字段)
    * @param strUpdDate: 修改日期(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function MessagePush_GetUniCondStr4Update_MessagePushNumber_UpdDate(objMessagePushEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and MessagePushId <> '{0}'", objMessagePushEN.messagePushId);
        strWhereCond += (0, clsString_js_2.Format)(" and MessagePushNumber = '{0}'", objMessagePushEN.messagePushNumber);
        strWhereCond += (0, clsString_js_2.Format)(" and UpdDate = '{0}'", objMessagePushEN.updDate);
        return strWhereCond;
    }
    exports.MessagePush_GetUniCondStr4Update_MessagePushNumber_UpdDate = MessagePush_GetUniCondStr4Update_MessagePushNumber_UpdDate;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objMessagePushENS:源对象
     * @param objMessagePushENT:目标对象
    */
    function MessagePush_CopyObjTo(objMessagePushENS, objMessagePushENT) {
        objMessagePushENT.messagePushId = objMessagePushENS.messagePushId; //消息Id
        objMessagePushENT.messagePushNumber = objMessagePushENS.messagePushNumber; //消息编号
        objMessagePushENT.messageTitle = objMessagePushENS.messageTitle; //消息标题
        objMessagePushENT.messageContent = objMessagePushENS.messageContent; //消息内容
        objMessagePushENT.receivePeople = objMessagePushENS.receivePeople; //接收人员
        objMessagePushENT.messageTypeId = objMessagePushENS.messageTypeId; //消息类型Id
        objMessagePushENT.isAllpush = objMessagePushENS.isAllpush; //是否全体推送
        objMessagePushENT.isReceive = objMessagePushENS.isReceive; //是否接收
        objMessagePushENT.clientVersionTypeId = objMessagePushENS.clientVersionTypeId; //客户端版本类型Id
        objMessagePushENT.updDate = objMessagePushENS.updDate; //修改日期
        objMessagePushENT.memo = objMessagePushENS.memo; //备注
        objMessagePushENT.sf_UpdFldSetStr = objMessagePushENS.updFldString; //sf_UpdFldSetStr
    }
    exports.MessagePush_CopyObjTo = MessagePush_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objMessagePushENS:源对象
     * @param objMessagePushENT:目标对象
    */
    function MessagePush_GetObjFromJsonObj(objMessagePushENS) {
        const objMessagePushENT = new clsMessagePushEN_js_1.clsMessagePushEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objMessagePushENT, objMessagePushENS);
        return objMessagePushENT;
    }
    exports.MessagePush_GetObjFromJsonObj = MessagePush_GetObjFromJsonObj;
});
