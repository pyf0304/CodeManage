/**
* 类名:clsgs_MeetingMinutesWApi
* 表名:gs_MeetingMinutes(01120770)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:48:50
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsgs_MeetingMinutesEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_MeetingMinutes_GetObjFromJsonObj = exports.gs_MeetingMinutes_CopyObjTo = exports.gs_MeetingMinutes_GetUniCondStr4Update_MeetingId = exports.gs_MeetingMinutes_GetUniCondStr_MeetingId = exports.gs_MeetingMinutes_GetCombineCondition = exports.gs_MeetingMinutes_GetObjByJSONStr = exports.gs_MeetingMinutes_GetObjLstByJSONObjLst = exports.gs_MeetingMinutes_GetObjLstByJSONStr = exports.gs_MeetingMinutes_GetJSONStrByObj = exports.gs_MeetingMinutes_CheckProperty4Update = exports.gs_MeetingMinutes_CheckPropertyNew = exports.gs_MeetingMinutes_GetWebApiUrl = exports.gs_MeetingMinutes_GetMaxStrIdByPrefix = exports.gs_MeetingMinutes_GetMaxStrIdAsync = exports.gs_MeetingMinutes_GetRecCountByCondAsync = exports.gs_MeetingMinutes_IsExistAsync = exports.gs_MeetingMinutes_IsExist = exports.gs_MeetingMinutes_IsExistRecordAsync = exports.gs_MeetingMinutes_UpdateWithConditionAsync = exports.gs_MeetingMinutes_UpdateRecordAsync = exports.gs_MeetingMinutes_AddNewRecordWithReturnKey = exports.gs_MeetingMinutes_AddNewRecordWithReturnKeyAsync = exports.gs_MeetingMinutes_AddNewRecordWithMaxIdAsync = exports.gs_MeetingMinutes_AddNewRecordAsync = exports.gs_MeetingMinutes_Delgs_MeetingMinutessByCondAsync = exports.gs_MeetingMinutes_Delgs_MeetingMinutessAsync = exports.gs_MeetingMinutes_DelRecordAsync = exports.gs_MeetingMinutes_GetObjLstByPagerAsync = exports.gs_MeetingMinutes_GetObjLstByRange = exports.gs_MeetingMinutes_GetObjLstByRangeAsync = exports.gs_MeetingMinutes_GetTopObjLstAsync = exports.gs_MeetingMinutes_GetObjLstByMeetingIdLstAsync = exports.gs_MeetingMinutes_GetObjLstAsync = exports.gs_MeetingMinutes_GetFirstObjAsync = exports.gs_MeetingMinutes_GetFirstID = exports.gs_MeetingMinutes_GetFirstIDAsync = exports.gs_MeetingMinutes_FilterFunByKey = exports.gs_MeetingMinutes_SortFunByKey = exports.gs_MeetingMinutes_SortFun_Defa_2Fld = exports.gs_MeetingMinutes_SortFun_Defa = exports.gs_MeetingMinutes_GetObjByMeetingIdAsync = exports.gs_MeetingMinutes_ConstructorName = exports.gs_MeetingMinutes_Controller = void 0;
    /**
     * 会议纪要(gs_MeetingMinutes)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_MeetingMinutesEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_MeetingMinutesEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_MeetingMinutes_Controller = "gs_MeetingMinutesApi";
    exports.gs_MeetingMinutes_ConstructorName = "gs_MeetingMinutes";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strMeetingId:关键字
    * @returns 对象
    **/
    async function gs_MeetingMinutes_GetObjByMeetingIdAsync(strMeetingId) {
        const strThisFuncName = "GetObjByMeetingIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strMeetingId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strMeetingId]不能为空！(In clsgs_MeetingMinutesWApi.GetObjByMeetingIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strMeetingId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strMeetingId]的长度:[{0}]不正确！(clsgs_MeetingMinutesWApi.GetObjByMeetingIdAsync)", strMeetingId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByMeetingId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strMeetingId": strMeetingId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objgs_MeetingMinutes = gs_MeetingMinutes_GetObjFromJsonObj(returnObj);
                return objgs_MeetingMinutes;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetObjByMeetingIdAsync = gs_MeetingMinutes_GetObjByMeetingIdAsync;
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
    function gs_MeetingMinutes_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.meetingId.localeCompare(b.meetingId);
    }
    exports.gs_MeetingMinutes_SortFun_Defa = gs_MeetingMinutes_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_MeetingMinutes_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.meetingContent.localeCompare(b.meetingContent);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.gs_MeetingMinutes_SortFun_Defa_2Fld = gs_MeetingMinutes_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_MeetingMinutes_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingId:
                    return (a, b) => {
                        return a.meetingId.localeCompare(b.meetingId);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingContent:
                    return (a, b) => {
                        if (a.meetingContent == null)
                            return -1;
                        if (b.meetingContent == null)
                            return 1;
                        return a.meetingContent.localeCompare(b.meetingContent);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingDate:
                    return (a, b) => {
                        if (a.meetingDate == null)
                            return -1;
                        if (b.meetingDate == null)
                            return 1;
                        return a.meetingDate.localeCompare(b.meetingDate);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Year:
                    return (a, b) => {
                        if (a.year == null)
                            return -1;
                        if (b.year == null)
                            return 1;
                        return a.year.localeCompare(b.year);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Month:
                    return (a, b) => {
                        if (a.month == null)
                            return -1;
                        if (b.month == null)
                            return 1;
                        return a.month.localeCompare(b.month);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Participants:
                    return (a, b) => {
                        if (a.participants == null)
                            return -1;
                        if (b.participants == null)
                            return 1;
                        return a.participants.localeCompare(b.participants);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_MeetingMinutes]中不存在！(in ${exports.gs_MeetingMinutes_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingId:
                    return (a, b) => {
                        return b.meetingId.localeCompare(a.meetingId);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingContent:
                    return (a, b) => {
                        if (b.meetingContent == null)
                            return -1;
                        if (a.meetingContent == null)
                            return 1;
                        return b.meetingContent.localeCompare(a.meetingContent);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingDate:
                    return (a, b) => {
                        if (b.meetingDate == null)
                            return -1;
                        if (a.meetingDate == null)
                            return 1;
                        return b.meetingDate.localeCompare(a.meetingDate);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Year:
                    return (a, b) => {
                        if (b.year == null)
                            return -1;
                        if (a.year == null)
                            return 1;
                        return b.year.localeCompare(a.year);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Month:
                    return (a, b) => {
                        if (b.month == null)
                            return -1;
                        if (a.month == null)
                            return 1;
                        return b.month.localeCompare(a.month);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Participants:
                    return (a, b) => {
                        if (b.participants == null)
                            return -1;
                        if (a.participants == null)
                            return 1;
                        return b.participants.localeCompare(a.participants);
                    };
                case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_MeetingMinutes]中不存在！(in ${exports.gs_MeetingMinutes_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_MeetingMinutes_SortFunByKey = gs_MeetingMinutes_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_MeetingMinutes_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingId:
                return (obj) => {
                    return obj.meetingId === value;
                };
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingContent:
                return (obj) => {
                    return obj.meetingContent === value;
                };
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingDate:
                return (obj) => {
                    return obj.meetingDate === value;
                };
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Year:
                return (obj) => {
                    return obj.year === value;
                };
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Month:
                return (obj) => {
                    return obj.month === value;
                };
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Participants:
                return (obj) => {
                    return obj.participants === value;
                };
            case clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_MeetingMinutes]中不存在！(in ${exports.gs_MeetingMinutes_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_MeetingMinutes_FilterFunByKey = gs_MeetingMinutes_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_MeetingMinutes_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetFirstIDAsync = gs_MeetingMinutes_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_MeetingMinutes_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetFirstID = gs_MeetingMinutes_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_MeetingMinutes_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
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
                const objgs_MeetingMinutes = gs_MeetingMinutes_GetObjFromJsonObj(returnObj);
                return objgs_MeetingMinutes;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetFirstObjAsync = gs_MeetingMinutes_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_MeetingMinutes_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_MeetingMinutes_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetObjLstAsync = gs_MeetingMinutes_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrMeetingId:关键字列表
    * @returns 对象列表
    **/
    async function gs_MeetingMinutes_GetObjLstByMeetingIdLstAsync(arrMeetingId) {
        const strThisFuncName = "GetObjLstByMeetingIdLstAsync";
        const strAction = "GetObjLstByMeetingIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMeetingId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_MeetingMinutes_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetObjLstByMeetingIdLstAsync = gs_MeetingMinutes_GetObjLstByMeetingIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_MeetingMinutes_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_MeetingMinutes_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetTopObjLstAsync = gs_MeetingMinutes_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_MeetingMinutes_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_MeetingMinutes_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetObjLstByRangeAsync = gs_MeetingMinutes_GetObjLstByRangeAsync;
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
    async function gs_MeetingMinutes_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetObjLstByRange = gs_MeetingMinutes_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_MeetingMinutes_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_MeetingMinutes_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetObjLstByPagerAsync = gs_MeetingMinutes_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strMeetingId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_MeetingMinutes_DelRecordAsync(strMeetingId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strMeetingId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_DelRecordAsync = gs_MeetingMinutes_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrMeetingId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_MeetingMinutes_Delgs_MeetingMinutessAsync(arrMeetingId) {
        const strThisFuncName = "Delgs_MeetingMinutessAsync";
        const strAction = "Delgs_MeetingMinutess";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMeetingId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_Delgs_MeetingMinutessAsync = gs_MeetingMinutes_Delgs_MeetingMinutessAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_MeetingMinutes_Delgs_MeetingMinutessByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_MeetingMinutessByCondAsync";
        const strAction = "Delgs_MeetingMinutessByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_Delgs_MeetingMinutessByCondAsync = gs_MeetingMinutes_Delgs_MeetingMinutessByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_MeetingMinutesEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_MeetingMinutes_AddNewRecordAsync(objgs_MeetingMinutesEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_MeetingMinutesEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_MeetingMinutesEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_AddNewRecordAsync = gs_MeetingMinutes_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_MeetingMinutesEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_MeetingMinutes_AddNewRecordWithMaxIdAsync(objgs_MeetingMinutesEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_MeetingMinutesEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_AddNewRecordWithMaxIdAsync = gs_MeetingMinutes_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_MeetingMinutesEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_MeetingMinutes_AddNewRecordWithReturnKeyAsync(objgs_MeetingMinutesEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_MeetingMinutesEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_AddNewRecordWithReturnKeyAsync = gs_MeetingMinutes_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_MeetingMinutesEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_MeetingMinutes_AddNewRecordWithReturnKey(objgs_MeetingMinutesEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_MeetingMinutesEN.meetingId === null || objgs_MeetingMinutesEN.meetingId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_MeetingMinutesEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_AddNewRecordWithReturnKey = gs_MeetingMinutes_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_MeetingMinutesEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_MeetingMinutes_UpdateRecordAsync(objgs_MeetingMinutesEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_MeetingMinutesEN.sf_UpdFldSetStr === undefined || objgs_MeetingMinutesEN.sf_UpdFldSetStr === null || objgs_MeetingMinutesEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_MeetingMinutesEN.meetingId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_MeetingMinutesEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_UpdateRecordAsync = gs_MeetingMinutes_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_MeetingMinutesEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_MeetingMinutes_UpdateWithConditionAsync(objgs_MeetingMinutesEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_MeetingMinutesEN.sf_UpdFldSetStr === undefined || objgs_MeetingMinutesEN.sf_UpdFldSetStr === null || objgs_MeetingMinutesEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_MeetingMinutesEN.meetingId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        objgs_MeetingMinutesEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_MeetingMinutesEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_UpdateWithConditionAsync = gs_MeetingMinutes_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_MeetingMinutes_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_IsExistRecordAsync = gs_MeetingMinutes_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strMeetingId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_MeetingMinutes_IsExist(strMeetingId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "MeetingId": strMeetingId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_IsExist = gs_MeetingMinutes_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strMeetingId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_MeetingMinutes_IsExistAsync(strMeetingId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strMeetingId": strMeetingId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_IsExistAsync = gs_MeetingMinutes_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_MeetingMinutes_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetRecCountByCondAsync = gs_MeetingMinutes_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_MeetingMinutes_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetMaxStrIdAsync = gs_MeetingMinutes_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_MeetingMinutes_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutes_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutes_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutes_GetMaxStrIdByPrefix = gs_MeetingMinutes_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_MeetingMinutes_GetWebApiUrl(strController, strAction) {
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
    exports.gs_MeetingMinutes_GetWebApiUrl = gs_MeetingMinutes_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_MeetingMinutes_CheckPropertyNew(pobjgs_MeetingMinutesEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.meetingId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.meetingId) > 10) {
            throw new Error("(errid:Watl000059)字段[会议Id(meetingId)]的长度不能超过10(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.meetingId)(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.topicId)(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.meetingDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.meetingDate) > 20) {
            throw new Error("(errid:Watl000059)字段[会议日期(meetingDate)]的长度不能超过20(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.meetingDate)(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.updDate)(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.updUser)(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.year) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.year) > 4) {
            throw new Error("(errid:Watl000059)字段[年(year)]的长度不能超过4(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.year)(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.month) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.month) > 2) {
            throw new Error("(errid:Watl000059)字段[月(month)]的长度不能超过2(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.month)(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.memo)(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.participants) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.participants) > 500) {
            throw new Error("(errid:Watl000059)字段[参会者(participants)]的长度不能超过500(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.participants)(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.id_CurrEduCls)(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.meetingId) == false && undefined !== pobjgs_MeetingMinutesEN.meetingId && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.meetingId) === false) {
            throw new Error("(errid:Watl000060)字段[会议Id(meetingId)]的值:[$(pobjgs_MeetingMinutesEN.meetingId)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.topicId) == false && undefined !== pobjgs_MeetingMinutesEN.topicId && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_MeetingMinutesEN.topicId)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if (null != pobjgs_MeetingMinutesEN.isSubmit && undefined !== pobjgs_MeetingMinutesEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjgs_MeetingMinutesEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_MeetingMinutesEN.isSubmit)], 非法，应该为布尔型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.meetingContent) == false && undefined !== pobjgs_MeetingMinutesEN.meetingContent && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.meetingContent) === false) {
            throw new Error("(errid:Watl000060)字段[会议内容(meetingContent)]的值:[$(pobjgs_MeetingMinutesEN.meetingContent)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.meetingDate) == false && undefined !== pobjgs_MeetingMinutesEN.meetingDate && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.meetingDate) === false) {
            throw new Error("(errid:Watl000060)字段[会议日期(meetingDate)]的值:[$(pobjgs_MeetingMinutesEN.meetingDate)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.updDate) == false && undefined !== pobjgs_MeetingMinutesEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_MeetingMinutesEN.updDate)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.updUser) == false && undefined !== pobjgs_MeetingMinutesEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_MeetingMinutesEN.updUser)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.year) == false && undefined !== pobjgs_MeetingMinutesEN.year && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.year) === false) {
            throw new Error("(errid:Watl000060)字段[年(year)]的值:[$(pobjgs_MeetingMinutesEN.year)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.month) == false && undefined !== pobjgs_MeetingMinutesEN.month && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.month) === false) {
            throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjgs_MeetingMinutesEN.month)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.memo) == false && undefined !== pobjgs_MeetingMinutesEN.memo && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_MeetingMinutesEN.memo)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if (null != pobjgs_MeetingMinutesEN.versionCount && undefined !== pobjgs_MeetingMinutesEN.versionCount && clsString_js_1.tzDataType.isNumber(pobjgs_MeetingMinutesEN.versionCount) === false) {
            throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjgs_MeetingMinutesEN.versionCount)], 非法，应该为数值型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.participants) == false && undefined !== pobjgs_MeetingMinutesEN.participants && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.participants) === false) {
            throw new Error("(errid:Watl000060)字段[参会者(participants)]的值:[$(pobjgs_MeetingMinutesEN.participants)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.id_CurrEduCls) == false && undefined !== pobjgs_MeetingMinutesEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_MeetingMinutesEN.id_CurrEduCls)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_MeetingMinutesEN.SetIsCheckProperty(true);
    }
    exports.gs_MeetingMinutes_CheckPropertyNew = gs_MeetingMinutes_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_MeetingMinutes_CheckProperty4Update(pobjgs_MeetingMinutesEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.meetingId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.meetingId) > 10) {
            throw new Error("(errid:Watl000062)字段[会议Id(meetingId)]的长度不能超过10(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.meetingId)(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.topicId)(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.meetingDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.meetingDate) > 20) {
            throw new Error("(errid:Watl000062)字段[会议日期(meetingDate)]的长度不能超过20(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.meetingDate)(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.updDate)(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.updUser)(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.year) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.year) > 4) {
            throw new Error("(errid:Watl000062)字段[年(year)]的长度不能超过4(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.year)(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.month) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.month) > 2) {
            throw new Error("(errid:Watl000062)字段[月(month)]的长度不能超过2(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.month)(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.memo)(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.participants) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.participants) > 500) {
            throw new Error("(errid:Watl000062)字段[参会者(participants)]的长度不能超过500(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.participants)(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_MeetingMinutesEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 会议纪要(gs_MeetingMinutes))!值:$(pobjgs_MeetingMinutesEN.id_CurrEduCls)(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.meetingId) == false && undefined !== pobjgs_MeetingMinutesEN.meetingId && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.meetingId) === false) {
            throw new Error("(errid:Watl000063)字段[会议Id(meetingId)]的值:[$(pobjgs_MeetingMinutesEN.meetingId)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.topicId) == false && undefined !== pobjgs_MeetingMinutesEN.topicId && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_MeetingMinutesEN.topicId)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if (null != pobjgs_MeetingMinutesEN.isSubmit && undefined !== pobjgs_MeetingMinutesEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjgs_MeetingMinutesEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_MeetingMinutesEN.isSubmit)], 非法，应该为布尔型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.meetingContent) == false && undefined !== pobjgs_MeetingMinutesEN.meetingContent && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.meetingContent) === false) {
            throw new Error("(errid:Watl000063)字段[会议内容(meetingContent)]的值:[$(pobjgs_MeetingMinutesEN.meetingContent)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.meetingDate) == false && undefined !== pobjgs_MeetingMinutesEN.meetingDate && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.meetingDate) === false) {
            throw new Error("(errid:Watl000063)字段[会议日期(meetingDate)]的值:[$(pobjgs_MeetingMinutesEN.meetingDate)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.updDate) == false && undefined !== pobjgs_MeetingMinutesEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_MeetingMinutesEN.updDate)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.updUser) == false && undefined !== pobjgs_MeetingMinutesEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_MeetingMinutesEN.updUser)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.year) == false && undefined !== pobjgs_MeetingMinutesEN.year && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.year) === false) {
            throw new Error("(errid:Watl000063)字段[年(year)]的值:[$(pobjgs_MeetingMinutesEN.year)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.month) == false && undefined !== pobjgs_MeetingMinutesEN.month && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.month) === false) {
            throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjgs_MeetingMinutesEN.month)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.memo) == false && undefined !== pobjgs_MeetingMinutesEN.memo && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_MeetingMinutesEN.memo)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if (null != pobjgs_MeetingMinutesEN.versionCount && undefined !== pobjgs_MeetingMinutesEN.versionCount && clsString_js_1.tzDataType.isNumber(pobjgs_MeetingMinutesEN.versionCount) === false) {
            throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjgs_MeetingMinutesEN.versionCount)], 非法，应该为数值型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.participants) == false && undefined !== pobjgs_MeetingMinutesEN.participants && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.participants) === false) {
            throw new Error("(errid:Watl000063)字段[参会者(participants)]的值:[$(pobjgs_MeetingMinutesEN.participants)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.id_CurrEduCls) == false && undefined !== pobjgs_MeetingMinutesEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_MeetingMinutesEN.id_CurrEduCls)], 非法，应该为字符型(In 会议纪要(gs_MeetingMinutes))!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_MeetingMinutesEN.meetingId) === true) {
            throw new Error("(errid:Watl000064)字段[会议Id]不能为空(In 会议纪要)!(clsgs_MeetingMinutesBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_MeetingMinutesEN.SetIsCheckProperty(true);
    }
    exports.gs_MeetingMinutes_CheckProperty4Update = gs_MeetingMinutes_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_MeetingMinutes_GetJSONStrByObj(pobjgs_MeetingMinutesEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_MeetingMinutesEN.sf_UpdFldSetStr = pobjgs_MeetingMinutesEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_MeetingMinutesEN);
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
    exports.gs_MeetingMinutes_GetJSONStrByObj = gs_MeetingMinutes_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_MeetingMinutes_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_MeetingMinutesObjLst = new Array();
        if (strJSON === "") {
            return arrgs_MeetingMinutesObjLst;
        }
        try {
            arrgs_MeetingMinutesObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_MeetingMinutesObjLst;
        }
        return arrgs_MeetingMinutesObjLst;
    }
    exports.gs_MeetingMinutes_GetObjLstByJSONStr = gs_MeetingMinutes_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_MeetingMinutesObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_MeetingMinutes_GetObjLstByJSONObjLst(arrgs_MeetingMinutesObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_MeetingMinutesObjLst = new Array();
        for (const objInFor of arrgs_MeetingMinutesObjLstS) {
            const obj1 = gs_MeetingMinutes_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_MeetingMinutesObjLst.push(obj1);
        }
        return arrgs_MeetingMinutesObjLst;
    }
    exports.gs_MeetingMinutes_GetObjLstByJSONObjLst = gs_MeetingMinutes_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_MeetingMinutes_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_MeetingMinutesEN = new clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN();
        if (strJSON === "") {
            return pobjgs_MeetingMinutesEN;
        }
        try {
            pobjgs_MeetingMinutesEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_MeetingMinutesEN;
        }
        return pobjgs_MeetingMinutesEN;
    }
    exports.gs_MeetingMinutes_GetObjByJSONStr = gs_MeetingMinutes_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_MeetingMinutes_GetCombineCondition(objgs_MeetingMinutes_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutes_Cond.dicFldComparisonOp, clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingId) == true) {
            const strComparisonOp_MeetingId = objgs_MeetingMinutes_Cond.dicFldComparisonOp[clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingId, objgs_MeetingMinutes_Cond.meetingId, strComparisonOp_MeetingId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutes_Cond.dicFldComparisonOp, clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_MeetingMinutes_Cond.dicFldComparisonOp[clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_TopicId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_TopicId, objgs_MeetingMinutes_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutes_Cond.dicFldComparisonOp, clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_IsSubmit) == true) {
            if (objgs_MeetingMinutes_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_IsSubmit);
            }
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutes_Cond.dicFldComparisonOp, clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingDate) == true) {
            const strComparisonOp_MeetingDate = objgs_MeetingMinutes_Cond.dicFldComparisonOp[clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_MeetingDate, objgs_MeetingMinutes_Cond.meetingDate, strComparisonOp_MeetingDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutes_Cond.dicFldComparisonOp, clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_MeetingMinutes_Cond.dicFldComparisonOp[clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_UpdDate, objgs_MeetingMinutes_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutes_Cond.dicFldComparisonOp, clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_MeetingMinutes_Cond.dicFldComparisonOp[clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_UpdUser, objgs_MeetingMinutes_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutes_Cond.dicFldComparisonOp, clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Year) == true) {
            const strComparisonOp_Year = objgs_MeetingMinutes_Cond.dicFldComparisonOp[clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Year];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Year, objgs_MeetingMinutes_Cond.year, strComparisonOp_Year);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutes_Cond.dicFldComparisonOp, clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Month) == true) {
            const strComparisonOp_Month = objgs_MeetingMinutes_Cond.dicFldComparisonOp[clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Month];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Month, objgs_MeetingMinutes_Cond.month, strComparisonOp_Month);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutes_Cond.dicFldComparisonOp, clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_MeetingMinutes_Cond.dicFldComparisonOp[clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Memo, objgs_MeetingMinutes_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutes_Cond.dicFldComparisonOp, clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objgs_MeetingMinutes_Cond.dicFldComparisonOp[clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_VersionCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_VersionCount, objgs_MeetingMinutes_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutes_Cond.dicFldComparisonOp, clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Participants) == true) {
            const strComparisonOp_Participants = objgs_MeetingMinutes_Cond.dicFldComparisonOp[clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Participants];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_Participants, objgs_MeetingMinutes_Cond.participants, strComparisonOp_Participants);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutes_Cond.dicFldComparisonOp, clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objgs_MeetingMinutes_Cond.dicFldComparisonOp[clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN.con_id_CurrEduCls, objgs_MeetingMinutes_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.gs_MeetingMinutes_GetCombineCondition = gs_MeetingMinutes_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_MeetingMinutes(会议纪要),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strMeetingId: 会议Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_MeetingMinutes_GetUniCondStr_MeetingId(objgs_MeetingMinutesEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and MeetingId = '{0}'", objgs_MeetingMinutesEN.meetingId);
        return strWhereCond;
    }
    exports.gs_MeetingMinutes_GetUniCondStr_MeetingId = gs_MeetingMinutes_GetUniCondStr_MeetingId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_MeetingMinutes(会议纪要),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strMeetingId: 会议Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_MeetingMinutes_GetUniCondStr4Update_MeetingId(objgs_MeetingMinutesEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and MeetingId <> '{0}'", objgs_MeetingMinutesEN.meetingId);
        strWhereCond += (0, clsString_js_2.Format)(" and MeetingId = '{0}'", objgs_MeetingMinutesEN.meetingId);
        return strWhereCond;
    }
    exports.gs_MeetingMinutes_GetUniCondStr4Update_MeetingId = gs_MeetingMinutes_GetUniCondStr4Update_MeetingId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_MeetingMinutesENS:源对象
     * @param objgs_MeetingMinutesENT:目标对象
    */
    function gs_MeetingMinutes_CopyObjTo(objgs_MeetingMinutesENS, objgs_MeetingMinutesENT) {
        objgs_MeetingMinutesENT.meetingId = objgs_MeetingMinutesENS.meetingId; //会议Id
        objgs_MeetingMinutesENT.topicId = objgs_MeetingMinutesENS.topicId; //主题Id
        objgs_MeetingMinutesENT.isSubmit = objgs_MeetingMinutesENS.isSubmit; //是否提交
        objgs_MeetingMinutesENT.meetingContent = objgs_MeetingMinutesENS.meetingContent; //会议内容
        objgs_MeetingMinutesENT.meetingDate = objgs_MeetingMinutesENS.meetingDate; //会议日期
        objgs_MeetingMinutesENT.updDate = objgs_MeetingMinutesENS.updDate; //修改日期
        objgs_MeetingMinutesENT.updUser = objgs_MeetingMinutesENS.updUser; //修改人
        objgs_MeetingMinutesENT.year = objgs_MeetingMinutesENS.year; //年
        objgs_MeetingMinutesENT.month = objgs_MeetingMinutesENS.month; //月
        objgs_MeetingMinutesENT.memo = objgs_MeetingMinutesENS.memo; //备注
        objgs_MeetingMinutesENT.versionCount = objgs_MeetingMinutesENS.versionCount; //版本统计
        objgs_MeetingMinutesENT.participants = objgs_MeetingMinutesENS.participants; //参会者
        objgs_MeetingMinutesENT.id_CurrEduCls = objgs_MeetingMinutesENS.id_CurrEduCls; //教学班流水号
        objgs_MeetingMinutesENT.sf_UpdFldSetStr = objgs_MeetingMinutesENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_MeetingMinutes_CopyObjTo = gs_MeetingMinutes_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_MeetingMinutesENS:源对象
     * @param objgs_MeetingMinutesENT:目标对象
    */
    function gs_MeetingMinutes_GetObjFromJsonObj(objgs_MeetingMinutesENS) {
        const objgs_MeetingMinutesENT = new clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_MeetingMinutesENT, objgs_MeetingMinutesENS);
        return objgs_MeetingMinutesENT;
    }
    exports.gs_MeetingMinutes_GetObjFromJsonObj = gs_MeetingMinutes_GetObjFromJsonObj;
});
