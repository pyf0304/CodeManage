/**
* 类名:clsvMessagePushUsersRelationWApi
* 表名:vMessagePushUsersRelation(01120285)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:37
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
        define(["require", "exports", "axios", "../../L0_Entity/NewsAnnouncement/clsvMessagePushUsersRelationEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vMessagePushUsersRelation_GetObjFromJsonObj = exports.vMessagePushUsersRelation_CopyObjTo = exports.vMessagePushUsersRelation_GetCombineCondition = exports.vMessagePushUsersRelation_GetObjByJSONStr = exports.vMessagePushUsersRelation_GetObjLstByJSONObjLst = exports.vMessagePushUsersRelation_GetObjLstByJSONStr = exports.vMessagePushUsersRelation_GetJSONStrByObj = exports.vMessagePushUsersRelation_GetWebApiUrl = exports.vMessagePushUsersRelation_GetRecCountByCondAsync = exports.vMessagePushUsersRelation_IsExistAsync = exports.vMessagePushUsersRelation_IsExist = exports.vMessagePushUsersRelation_IsExistRecordAsync = exports.vMessagePushUsersRelation_GetObjLstByPagerAsync = exports.vMessagePushUsersRelation_GetObjLstByRange = exports.vMessagePushUsersRelation_GetObjLstByRangeAsync = exports.vMessagePushUsersRelation_GetTopObjLstAsync = exports.vMessagePushUsersRelation_GetObjLstByMessagePushUsersRelationIdLstAsync = exports.vMessagePushUsersRelation_GetObjLstAsync = exports.vMessagePushUsersRelation_GetFirstObjAsync = exports.vMessagePushUsersRelation_GetFirstID = exports.vMessagePushUsersRelation_GetFirstIDAsync = exports.vMessagePushUsersRelation_FilterFunByKey = exports.vMessagePushUsersRelation_SortFunByKey = exports.vMessagePushUsersRelation_SortFun_Defa_2Fld = exports.vMessagePushUsersRelation_SortFun_Defa = exports.vMessagePushUsersRelation_GetObjByMessagePushUsersRelationIdAsync = exports.vMessagePushUsersRelation_ConstructorName = exports.vMessagePushUsersRelation_Controller = void 0;
    /**
     * 消息推送用户关系视图(vMessagePushUsersRelation)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvMessagePushUsersRelationEN_js_1 = require("../../L0_Entity/NewsAnnouncement/clsvMessagePushUsersRelationEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vMessagePushUsersRelation_Controller = "vMessagePushUsersRelationApi";
    exports.vMessagePushUsersRelation_ConstructorName = "vMessagePushUsersRelation";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngMessagePushUsersRelationId:关键字
    * @returns 对象
    **/
    async function vMessagePushUsersRelation_GetObjByMessagePushUsersRelationIdAsync(lngMessagePushUsersRelationId) {
        const strThisFuncName = "GetObjByMessagePushUsersRelationIdAsync";
        if (lngMessagePushUsersRelationId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngMessagePushUsersRelationId]不能为空！(In GetObjByMessagePushUsersRelationIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByMessagePushUsersRelationId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvMessagePushUsersRelation = vMessagePushUsersRelation_GetObjFromJsonObj(returnObj);
                return objvMessagePushUsersRelation;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_GetObjByMessagePushUsersRelationIdAsync = vMessagePushUsersRelation_GetObjByMessagePushUsersRelationIdAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vMessagePushUsersRelation_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.messagePushUsersRelationId - b.messagePushUsersRelationId;
    }
    exports.vMessagePushUsersRelation_SortFun_Defa = vMessagePushUsersRelation_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vMessagePushUsersRelation_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.messagePushId == b.messagePushId)
            return a.messagePushNumber.localeCompare(b.messagePushNumber);
        else
            return a.messagePushId.localeCompare(b.messagePushId);
    }
    exports.vMessagePushUsersRelation_SortFun_Defa_2Fld = vMessagePushUsersRelation_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vMessagePushUsersRelation_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushUsersRelationId:
                    return (a, b) => {
                        return a.messagePushUsersRelationId - b.messagePushUsersRelationId;
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushId:
                    return (a, b) => {
                        return a.messagePushId.localeCompare(b.messagePushId);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushNumber:
                    return (a, b) => {
                        return a.messagePushNumber.localeCompare(b.messagePushNumber);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageTitle:
                    return (a, b) => {
                        return a.messageTitle.localeCompare(b.messageTitle);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageContent:
                    return (a, b) => {
                        return a.messageContent.localeCompare(b.messageContent);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageTypeId:
                    return (a, b) => {
                        return a.messageTypeId.localeCompare(b.messageTypeId);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_IsAllpush:
                    return (a, b) => {
                        if (a.isAllpush == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_ClientVersionTypeId:
                    return (a, b) => {
                        return a.clientVersionTypeId.localeCompare(b.clientVersionTypeId);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_ReceivePeople:
                    return (a, b) => {
                        return a.receivePeople.localeCompare(b.receivePeople);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_IsReceive:
                    return (a, b) => {
                        if (a.isReceive == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_CreateTime:
                    return (a, b) => {
                        return a.createTime.localeCompare(b.createTime);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vMessagePushUsersRelation]中不存在！(in ${exports.vMessagePushUsersRelation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushUsersRelationId:
                    return (a, b) => {
                        return b.messagePushUsersRelationId - a.messagePushUsersRelationId;
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushId:
                    return (a, b) => {
                        return b.messagePushId.localeCompare(a.messagePushId);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushNumber:
                    return (a, b) => {
                        return b.messagePushNumber.localeCompare(a.messagePushNumber);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageTitle:
                    return (a, b) => {
                        return b.messageTitle.localeCompare(a.messageTitle);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageContent:
                    return (a, b) => {
                        return b.messageContent.localeCompare(a.messageContent);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageTypeId:
                    return (a, b) => {
                        return b.messageTypeId.localeCompare(a.messageTypeId);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_IsAllpush:
                    return (a, b) => {
                        if (b.isAllpush == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_ClientVersionTypeId:
                    return (a, b) => {
                        return b.clientVersionTypeId.localeCompare(a.clientVersionTypeId);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_ReceivePeople:
                    return (a, b) => {
                        return b.receivePeople.localeCompare(a.receivePeople);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_IsReceive:
                    return (a, b) => {
                        if (b.isReceive == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_CreateTime:
                    return (a, b) => {
                        return b.createTime.localeCompare(a.createTime);
                    };
                case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vMessagePushUsersRelation]中不存在！(in ${exports.vMessagePushUsersRelation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vMessagePushUsersRelation_SortFunByKey = vMessagePushUsersRelation_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vMessagePushUsersRelation_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushUsersRelationId:
                return (obj) => {
                    return obj.messagePushUsersRelationId === value;
                };
            case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushId:
                return (obj) => {
                    return obj.messagePushId === value;
                };
            case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushNumber:
                return (obj) => {
                    return obj.messagePushNumber === value;
                };
            case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageTitle:
                return (obj) => {
                    return obj.messageTitle === value;
                };
            case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageContent:
                return (obj) => {
                    return obj.messageContent === value;
                };
            case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageTypeId:
                return (obj) => {
                    return obj.messageTypeId === value;
                };
            case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_IsAllpush:
                return (obj) => {
                    return obj.isAllpush === value;
                };
            case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_ClientVersionTypeId:
                return (obj) => {
                    return obj.clientVersionTypeId === value;
                };
            case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_ReceivePeople:
                return (obj) => {
                    return obj.receivePeople === value;
                };
            case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_IsReceive:
                return (obj) => {
                    return obj.isReceive === value;
                };
            case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_CreateTime:
                return (obj) => {
                    return obj.createTime === value;
                };
            case clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vMessagePushUsersRelation]中不存在！(in ${exports.vMessagePushUsersRelation_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vMessagePushUsersRelation_FilterFunByKey = vMessagePushUsersRelation_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vMessagePushUsersRelation_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_GetFirstIDAsync = vMessagePushUsersRelation_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vMessagePushUsersRelation_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_GetFirstID = vMessagePushUsersRelation_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vMessagePushUsersRelation_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvMessagePushUsersRelation = vMessagePushUsersRelation_GetObjFromJsonObj(returnObj);
                return objvMessagePushUsersRelation;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_GetFirstObjAsync = vMessagePushUsersRelation_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vMessagePushUsersRelation_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMessagePushUsersRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_GetObjLstAsync = vMessagePushUsersRelation_GetObjLstAsync;
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
    async function vMessagePushUsersRelation_GetObjLstByMessagePushUsersRelationIdLstAsync(arrMessagePushUsersRelationId) {
        const strThisFuncName = "GetObjLstByMessagePushUsersRelationIdLstAsync";
        const strAction = "GetObjLstByMessagePushUsersRelationIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMessagePushUsersRelationId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMessagePushUsersRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_GetObjLstByMessagePushUsersRelationIdLstAsync = vMessagePushUsersRelation_GetObjLstByMessagePushUsersRelationIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vMessagePushUsersRelation_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMessagePushUsersRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_GetTopObjLstAsync = vMessagePushUsersRelation_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vMessagePushUsersRelation_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMessagePushUsersRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_GetObjLstByRangeAsync = vMessagePushUsersRelation_GetObjLstByRangeAsync;
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
    async function vMessagePushUsersRelation_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_GetObjLstByRange = vMessagePushUsersRelation_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vMessagePushUsersRelation_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMessagePushUsersRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_GetObjLstByPagerAsync = vMessagePushUsersRelation_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vMessagePushUsersRelation_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_IsExistRecordAsync = vMessagePushUsersRelation_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngMessagePushUsersRelationId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vMessagePushUsersRelation_IsExist(lngMessagePushUsersRelationId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_IsExist = vMessagePushUsersRelation_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngMessagePushUsersRelationId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vMessagePushUsersRelation_IsExistAsync(lngMessagePushUsersRelationId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_IsExistAsync = vMessagePushUsersRelation_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vMessagePushUsersRelation_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePushUsersRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePushUsersRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePushUsersRelation_GetRecCountByCondAsync = vMessagePushUsersRelation_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vMessagePushUsersRelation_GetWebApiUrl(strController, strAction) {
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
    exports.vMessagePushUsersRelation_GetWebApiUrl = vMessagePushUsersRelation_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vMessagePushUsersRelation_GetJSONStrByObj(pobjvMessagePushUsersRelationEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvMessagePushUsersRelationEN);
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
    exports.vMessagePushUsersRelation_GetJSONStrByObj = vMessagePushUsersRelation_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vMessagePushUsersRelation_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvMessagePushUsersRelationObjLst = new Array();
        if (strJSON === "") {
            return arrvMessagePushUsersRelationObjLst;
        }
        try {
            arrvMessagePushUsersRelationObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvMessagePushUsersRelationObjLst;
        }
        return arrvMessagePushUsersRelationObjLst;
    }
    exports.vMessagePushUsersRelation_GetObjLstByJSONStr = vMessagePushUsersRelation_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvMessagePushUsersRelationObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vMessagePushUsersRelation_GetObjLstByJSONObjLst(arrvMessagePushUsersRelationObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvMessagePushUsersRelationObjLst = new Array();
        for (const objInFor of arrvMessagePushUsersRelationObjLstS) {
            const obj1 = vMessagePushUsersRelation_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvMessagePushUsersRelationObjLst.push(obj1);
        }
        return arrvMessagePushUsersRelationObjLst;
    }
    exports.vMessagePushUsersRelation_GetObjLstByJSONObjLst = vMessagePushUsersRelation_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vMessagePushUsersRelation_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN();
        if (strJSON === "") {
            return pobjvMessagePushUsersRelationEN;
        }
        try {
            pobjvMessagePushUsersRelationEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvMessagePushUsersRelationEN;
        }
        return pobjvMessagePushUsersRelationEN;
    }
    exports.vMessagePushUsersRelation_GetObjByJSONStr = vMessagePushUsersRelation_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vMessagePushUsersRelation_GetCombineCondition(objvMessagePushUsersRelation_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvMessagePushUsersRelation_Cond.dicFldComparisonOp, clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushUsersRelationId) == true) {
            const strComparisonOp_MessagePushUsersRelationId = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushUsersRelationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushUsersRelationId, objvMessagePushUsersRelation_Cond.messagePushUsersRelationId, strComparisonOp_MessagePushUsersRelationId);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePushUsersRelation_Cond.dicFldComparisonOp, clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushId) == true) {
            const strComparisonOp_MessagePushId = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushId, objvMessagePushUsersRelation_Cond.messagePushId, strComparisonOp_MessagePushId);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePushUsersRelation_Cond.dicFldComparisonOp, clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushNumber) == true) {
            const strComparisonOp_MessagePushNumber = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessagePushNumber, objvMessagePushUsersRelation_Cond.messagePushNumber, strComparisonOp_MessagePushNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePushUsersRelation_Cond.dicFldComparisonOp, clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageTitle) == true) {
            const strComparisonOp_MessageTitle = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageTitle, objvMessagePushUsersRelation_Cond.messageTitle, strComparisonOp_MessageTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePushUsersRelation_Cond.dicFldComparisonOp, clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageContent) == true) {
            const strComparisonOp_MessageContent = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageContent, objvMessagePushUsersRelation_Cond.messageContent, strComparisonOp_MessageContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePushUsersRelation_Cond.dicFldComparisonOp, clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageTypeId) == true) {
            const strComparisonOp_MessageTypeId = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_MessageTypeId, objvMessagePushUsersRelation_Cond.messageTypeId, strComparisonOp_MessageTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePushUsersRelation_Cond.dicFldComparisonOp, clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_IsAllpush) == true) {
            if (objvMessagePushUsersRelation_Cond.isAllpush == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_IsAllpush);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_IsAllpush);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePushUsersRelation_Cond.dicFldComparisonOp, clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_ClientVersionTypeId) == true) {
            const strComparisonOp_ClientVersionTypeId = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_ClientVersionTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_ClientVersionTypeId, objvMessagePushUsersRelation_Cond.clientVersionTypeId, strComparisonOp_ClientVersionTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePushUsersRelation_Cond.dicFldComparisonOp, clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_ReceivePeople) == true) {
            const strComparisonOp_ReceivePeople = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_ReceivePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_ReceivePeople, objvMessagePushUsersRelation_Cond.receivePeople, strComparisonOp_ReceivePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePushUsersRelation_Cond.dicFldComparisonOp, clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_IsReceive) == true) {
            if (objvMessagePushUsersRelation_Cond.isReceive == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_IsReceive);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_IsReceive);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePushUsersRelation_Cond.dicFldComparisonOp, clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_CreateTime) == true) {
            const strComparisonOp_CreateTime = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_CreateTime];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_CreateTime, objvMessagePushUsersRelation_Cond.createTime, strComparisonOp_CreateTime);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePushUsersRelation_Cond.dicFldComparisonOp, clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN.con_Memo, objvMessagePushUsersRelation_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vMessagePushUsersRelation_GetCombineCondition = vMessagePushUsersRelation_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvMessagePushUsersRelationENS:源对象
     * @param objvMessagePushUsersRelationENT:目标对象
    */
    function vMessagePushUsersRelation_CopyObjTo(objvMessagePushUsersRelationENS, objvMessagePushUsersRelationENT) {
        objvMessagePushUsersRelationENT.messagePushUsersRelationId = objvMessagePushUsersRelationENS.messagePushUsersRelationId; //消息推送与用户关系Id
        objvMessagePushUsersRelationENT.messagePushId = objvMessagePushUsersRelationENS.messagePushId; //消息Id
        objvMessagePushUsersRelationENT.messagePushNumber = objvMessagePushUsersRelationENS.messagePushNumber; //消息编号
        objvMessagePushUsersRelationENT.messageTitle = objvMessagePushUsersRelationENS.messageTitle; //消息标题
        objvMessagePushUsersRelationENT.messageContent = objvMessagePushUsersRelationENS.messageContent; //消息内容
        objvMessagePushUsersRelationENT.messageTypeId = objvMessagePushUsersRelationENS.messageTypeId; //消息类型Id
        objvMessagePushUsersRelationENT.isAllpush = objvMessagePushUsersRelationENS.isAllpush; //是否全体推送
        objvMessagePushUsersRelationENT.clientVersionTypeId = objvMessagePushUsersRelationENS.clientVersionTypeId; //客户端版本类型Id
        objvMessagePushUsersRelationENT.receivePeople = objvMessagePushUsersRelationENS.receivePeople; //接收人员
        objvMessagePushUsersRelationENT.isReceive = objvMessagePushUsersRelationENS.isReceive; //是否接收
        objvMessagePushUsersRelationENT.createTime = objvMessagePushUsersRelationENS.createTime; //建立时间
        objvMessagePushUsersRelationENT.memo = objvMessagePushUsersRelationENS.memo; //备注
    }
    exports.vMessagePushUsersRelation_CopyObjTo = vMessagePushUsersRelation_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvMessagePushUsersRelationENS:源对象
     * @param objvMessagePushUsersRelationENT:目标对象
    */
    function vMessagePushUsersRelation_GetObjFromJsonObj(objvMessagePushUsersRelationENS) {
        const objvMessagePushUsersRelationENT = new clsvMessagePushUsersRelationEN_js_1.clsvMessagePushUsersRelationEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvMessagePushUsersRelationENT, objvMessagePushUsersRelationENS);
        return objvMessagePushUsersRelationENT;
    }
    exports.vMessagePushUsersRelation_GetObjFromJsonObj = vMessagePushUsersRelation_GetObjFromJsonObj;
});
