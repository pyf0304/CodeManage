/**
* 类名:clsgs_MeetingMinutesVWApi
* 表名:gs_MeetingMinutesV(01120769)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:47:04
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsgs_MeetingMinutesVEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_MeetingMinutesV_GetObjFromJsonObj = exports.gs_MeetingMinutesV_CopyObjTo = exports.gs_MeetingMinutesV_GetUniCondStr4Update_MeetingVId = exports.gs_MeetingMinutesV_GetUniCondStr_MeetingVId = exports.gs_MeetingMinutesV_GetCombineCondition = exports.gs_MeetingMinutesV_GetObjByJSONStr = exports.gs_MeetingMinutesV_GetObjLstByJSONObjLst = exports.gs_MeetingMinutesV_GetObjLstByJSONStr = exports.gs_MeetingMinutesV_GetJSONStrByObj = exports.gs_MeetingMinutesV_CheckProperty4Update = exports.gs_MeetingMinutesV_CheckPropertyNew = exports.gs_MeetingMinutesV_GetWebApiUrl = exports.gs_MeetingMinutesV_GetMaxStrIdByPrefix = exports.gs_MeetingMinutesV_GetRecCountByCondAsync = exports.gs_MeetingMinutesV_IsExistAsync = exports.gs_MeetingMinutesV_IsExist = exports.gs_MeetingMinutesV_IsExistRecordAsync = exports.gs_MeetingMinutesV_UpdateWithConditionAsync = exports.gs_MeetingMinutesV_UpdateRecordAsync = exports.gs_MeetingMinutesV_AddNewRecordWithReturnKey = exports.gs_MeetingMinutesV_AddNewRecordWithReturnKeyAsync = exports.gs_MeetingMinutesV_AddNewRecordAsync = exports.gs_MeetingMinutesV_Delgs_MeetingMinutesVsByCondAsync = exports.gs_MeetingMinutesV_Delgs_MeetingMinutesVsAsync = exports.gs_MeetingMinutesV_DelRecordAsync = exports.gs_MeetingMinutesV_GetObjLstByPagerAsync = exports.gs_MeetingMinutesV_GetObjLstByRange = exports.gs_MeetingMinutesV_GetObjLstByRangeAsync = exports.gs_MeetingMinutesV_GetTopObjLstAsync = exports.gs_MeetingMinutesV_GetObjLstByMeetingVIdLstAsync = exports.gs_MeetingMinutesV_GetObjLstAsync = exports.gs_MeetingMinutesV_GetFirstObjAsync = exports.gs_MeetingMinutesV_GetFirstID = exports.gs_MeetingMinutesV_GetFirstIDAsync = exports.gs_MeetingMinutesV_FilterFunByKey = exports.gs_MeetingMinutesV_SortFunByKey = exports.gs_MeetingMinutesV_SortFun_Defa_2Fld = exports.gs_MeetingMinutesV_SortFun_Defa = exports.gs_MeetingMinutesV_GetObjByMeetingVIdAsync = exports.gs_MeetingMinutesV_ConstructorName = exports.gs_MeetingMinutesV_Controller = void 0;
    /**
     * 会议纪要历史版(gs_MeetingMinutesV)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_MeetingMinutesVEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_MeetingMinutesVEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_MeetingMinutesV_Controller = "gs_MeetingMinutesVApi";
    exports.gs_MeetingMinutesV_ConstructorName = "gs_MeetingMinutesV";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngMeetingVId:关键字
    * @returns 对象
    **/
    async function gs_MeetingMinutesV_GetObjByMeetingVIdAsync(lngMeetingVId) {
        const strThisFuncName = "GetObjByMeetingVIdAsync";
        if (lngMeetingVId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngMeetingVId]不能为空！(In GetObjByMeetingVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByMeetingVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngMeetingVId": lngMeetingVId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_MeetingMinutesV = gs_MeetingMinutesV_GetObjFromJsonObj(returnObj);
                return objgs_MeetingMinutesV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_GetObjByMeetingVIdAsync = gs_MeetingMinutesV_GetObjByMeetingVIdAsync;
    //该表在前台TypeScript中，不需要使用Cache;
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
    function gs_MeetingMinutesV_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.meetingVId - b.meetingVId;
    }
    exports.gs_MeetingMinutesV_SortFun_Defa = gs_MeetingMinutesV_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_MeetingMinutesV_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.meetingId == b.meetingId)
            return a.topicId.localeCompare(b.topicId);
        else
            return a.meetingId.localeCompare(b.meetingId);
    }
    exports.gs_MeetingMinutesV_SortFun_Defa_2Fld = gs_MeetingMinutesV_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_MeetingMinutesV_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingVId:
                    return (a, b) => {
                        return a.meetingVId - b.meetingVId;
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingId:
                    return (a, b) => {
                        return a.meetingId.localeCompare(b.meetingId);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingContent:
                    return (a, b) => {
                        return a.meetingContent.localeCompare(b.meetingContent);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingDate:
                    return (a, b) => {
                        return a.meetingDate.localeCompare(b.meetingDate);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Year:
                    return (a, b) => {
                        return a.year.localeCompare(b.year);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Month:
                    return (a, b) => {
                        return a.month.localeCompare(b.month);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Participants:
                    return (a, b) => {
                        return a.participants.localeCompare(b.participants);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_MeetingMinutesV]中不存在！(in ${exports.gs_MeetingMinutesV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingVId:
                    return (a, b) => {
                        return b.meetingVId - a.meetingVId;
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingId:
                    return (a, b) => {
                        return b.meetingId.localeCompare(a.meetingId);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingContent:
                    return (a, b) => {
                        return b.meetingContent.localeCompare(a.meetingContent);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingDate:
                    return (a, b) => {
                        return b.meetingDate.localeCompare(a.meetingDate);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Year:
                    return (a, b) => {
                        return b.year.localeCompare(a.year);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Month:
                    return (a, b) => {
                        return b.month.localeCompare(a.month);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Participants:
                    return (a, b) => {
                        return b.participants.localeCompare(a.participants);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_MeetingMinutesV]中不存在！(in ${exports.gs_MeetingMinutesV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_MeetingMinutesV_SortFunByKey = gs_MeetingMinutesV_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_MeetingMinutesV_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingVId:
                return (obj) => {
                    return obj.meetingVId === value;
                };
            case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingId:
                return (obj) => {
                    return obj.meetingId === value;
                };
            case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingContent:
                return (obj) => {
                    return obj.meetingContent === value;
                };
            case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingDate:
                return (obj) => {
                    return obj.meetingDate === value;
                };
            case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Year:
                return (obj) => {
                    return obj.year === value;
                };
            case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Month:
                return (obj) => {
                    return obj.month === value;
                };
            case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Participants:
                return (obj) => {
                    return obj.participants === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_MeetingMinutesV]中不存在！(in ${exports.gs_MeetingMinutesV_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_MeetingMinutesV_FilterFunByKey = gs_MeetingMinutesV_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_MeetingMinutesV_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_GetFirstIDAsync = gs_MeetingMinutesV_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_MeetingMinutesV_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_GetFirstID = gs_MeetingMinutesV_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_MeetingMinutesV_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_MeetingMinutesV = gs_MeetingMinutesV_GetObjFromJsonObj(returnObj);
                return objgs_MeetingMinutesV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_GetFirstObjAsync = gs_MeetingMinutesV_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_MeetingMinutesV_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_MeetingMinutesV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_GetObjLstAsync = gs_MeetingMinutesV_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrMeetingVId:关键字列表
    * @returns 对象列表
    **/
    async function gs_MeetingMinutesV_GetObjLstByMeetingVIdLstAsync(arrMeetingVId) {
        const strThisFuncName = "GetObjLstByMeetingVIdLstAsync";
        const strAction = "GetObjLstByMeetingVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMeetingVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_MeetingMinutesV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_GetObjLstByMeetingVIdLstAsync = gs_MeetingMinutesV_GetObjLstByMeetingVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_MeetingMinutesV_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_MeetingMinutesV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_GetTopObjLstAsync = gs_MeetingMinutesV_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_MeetingMinutesV_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_MeetingMinutesV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_GetObjLstByRangeAsync = gs_MeetingMinutesV_GetObjLstByRangeAsync;
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
    async function gs_MeetingMinutesV_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_GetObjLstByRange = gs_MeetingMinutesV_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_MeetingMinutesV_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_MeetingMinutesV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_GetObjLstByPagerAsync = gs_MeetingMinutesV_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngMeetingVId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_MeetingMinutesV_DelRecordAsync(lngMeetingVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngMeetingVId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngMeetingVId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_DelRecordAsync = gs_MeetingMinutesV_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrMeetingVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_MeetingMinutesV_Delgs_MeetingMinutesVsAsync(arrMeetingVId) {
        const strThisFuncName = "Delgs_MeetingMinutesVsAsync";
        const strAction = "Delgs_MeetingMinutesVs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMeetingVId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_Delgs_MeetingMinutesVsAsync = gs_MeetingMinutesV_Delgs_MeetingMinutesVsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_MeetingMinutesV_Delgs_MeetingMinutesVsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_MeetingMinutesVsByCondAsync";
        const strAction = "Delgs_MeetingMinutesVsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_Delgs_MeetingMinutesVsByCondAsync = gs_MeetingMinutesV_Delgs_MeetingMinutesVsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_MeetingMinutesVEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_MeetingMinutesV_AddNewRecordAsync(objgs_MeetingMinutesVEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_MeetingMinutesVEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_MeetingMinutesVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_AddNewRecordAsync = gs_MeetingMinutesV_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_MeetingMinutesVEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_MeetingMinutesV_AddNewRecordWithReturnKeyAsync(objgs_MeetingMinutesVEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_MeetingMinutesVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_AddNewRecordWithReturnKeyAsync = gs_MeetingMinutesV_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_MeetingMinutesVEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_MeetingMinutesV_AddNewRecordWithReturnKey(objgs_MeetingMinutesVEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_MeetingMinutesVEN.meetingVId === null || objgs_MeetingMinutesVEN.meetingVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_MeetingMinutesVEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_AddNewRecordWithReturnKey = gs_MeetingMinutesV_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_MeetingMinutesVEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_MeetingMinutesV_UpdateRecordAsync(objgs_MeetingMinutesVEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_MeetingMinutesVEN.sf_UpdFldSetStr === undefined || objgs_MeetingMinutesVEN.sf_UpdFldSetStr === null || objgs_MeetingMinutesVEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_MeetingMinutesVEN.meetingVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_MeetingMinutesVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_UpdateRecordAsync = gs_MeetingMinutesV_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_MeetingMinutesVEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_MeetingMinutesV_UpdateWithConditionAsync(objgs_MeetingMinutesVEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_MeetingMinutesVEN.sf_UpdFldSetStr === undefined || objgs_MeetingMinutesVEN.sf_UpdFldSetStr === null || objgs_MeetingMinutesVEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_MeetingMinutesVEN.meetingVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        objgs_MeetingMinutesVEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_MeetingMinutesVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_UpdateWithConditionAsync = gs_MeetingMinutesV_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_MeetingMinutesV_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_IsExistRecordAsync = gs_MeetingMinutesV_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngMeetingVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_MeetingMinutesV_IsExist(lngMeetingVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "MeetingVId": lngMeetingVId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_IsExist = gs_MeetingMinutesV_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngMeetingVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_MeetingMinutesV_IsExistAsync(lngMeetingVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngMeetingVId": lngMeetingVId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_IsExistAsync = gs_MeetingMinutesV_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_MeetingMinutesV_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_GetRecCountByCondAsync = gs_MeetingMinutesV_GetRecCountByCondAsync;
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
    async function gs_MeetingMinutesV_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_MeetingMinutesV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_MeetingMinutesV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_MeetingMinutesV_GetMaxStrIdByPrefix = gs_MeetingMinutesV_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_MeetingMinutesV_GetWebApiUrl(strController, strAction) {
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
    exports.gs_MeetingMinutesV_GetWebApiUrl = gs_MeetingMinutesV_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_MeetingMinutesV_CheckPropertyNew(pobjgs_MeetingMinutesVEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.meetingId) === true) {
            throw new Error("(errid:Watl000058)字段[会议Id]不能为空(In 会议纪要历史版)!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.meetingId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.meetingId) > 10) {
            throw new Error("(errid:Watl000059)字段[会议Id(meetingId)]的长度不能超过10(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.meetingId)(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.topicId)(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.meetingDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.meetingDate) > 20) {
            throw new Error("(errid:Watl000059)字段[会议日期(meetingDate)]的长度不能超过20(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.meetingDate)(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.updDate)(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.updUser)(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.year) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.year) > 4) {
            throw new Error("(errid:Watl000059)字段[年(year)]的长度不能超过4(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.year)(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.month) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.month) > 2) {
            throw new Error("(errid:Watl000059)字段[月(month)]的长度不能超过2(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.month)(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.memo)(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.participants) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.participants) > 500) {
            throw new Error("(errid:Watl000059)字段[参会者(participants)]的长度不能超过500(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.participants)(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_MeetingMinutesVEN.meetingVId && undefined !== pobjgs_MeetingMinutesVEN.meetingVId && jsString_js_1.tzDataType.isNumber(pobjgs_MeetingMinutesVEN.meetingVId) === false) {
            throw new Error("(errid:Watl000060)字段[MeetingVId(meetingVId)]的值:[$(pobjgs_MeetingMinutesVEN.meetingVId)], 非法，应该为数值型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.meetingId) == false && undefined !== pobjgs_MeetingMinutesVEN.meetingId && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.meetingId) === false) {
            throw new Error("(errid:Watl000060)字段[会议Id(meetingId)]的值:[$(pobjgs_MeetingMinutesVEN.meetingId)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.topicId) == false && undefined !== pobjgs_MeetingMinutesVEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_MeetingMinutesVEN.topicId)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if (null != pobjgs_MeetingMinutesVEN.isSubmit && undefined !== pobjgs_MeetingMinutesVEN.isSubmit && jsString_js_1.tzDataType.isBoolean(pobjgs_MeetingMinutesVEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_MeetingMinutesVEN.isSubmit)], 非法，应该为布尔型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.meetingContent) == false && undefined !== pobjgs_MeetingMinutesVEN.meetingContent && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.meetingContent) === false) {
            throw new Error("(errid:Watl000060)字段[会议内容(meetingContent)]的值:[$(pobjgs_MeetingMinutesVEN.meetingContent)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.meetingDate) == false && undefined !== pobjgs_MeetingMinutesVEN.meetingDate && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.meetingDate) === false) {
            throw new Error("(errid:Watl000060)字段[会议日期(meetingDate)]的值:[$(pobjgs_MeetingMinutesVEN.meetingDate)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.updDate) == false && undefined !== pobjgs_MeetingMinutesVEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_MeetingMinutesVEN.updDate)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.updUser) == false && undefined !== pobjgs_MeetingMinutesVEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_MeetingMinutesVEN.updUser)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.year) == false && undefined !== pobjgs_MeetingMinutesVEN.year && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.year) === false) {
            throw new Error("(errid:Watl000060)字段[年(year)]的值:[$(pobjgs_MeetingMinutesVEN.year)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.month) == false && undefined !== pobjgs_MeetingMinutesVEN.month && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.month) === false) {
            throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjgs_MeetingMinutesVEN.month)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.memo) == false && undefined !== pobjgs_MeetingMinutesVEN.memo && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_MeetingMinutesVEN.memo)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.participants) == false && undefined !== pobjgs_MeetingMinutesVEN.participants && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.participants) === false) {
            throw new Error("(errid:Watl000060)字段[参会者(participants)]的值:[$(pobjgs_MeetingMinutesVEN.participants)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_MeetingMinutesVEN.SetIsCheckProperty(true);
    }
    exports.gs_MeetingMinutesV_CheckPropertyNew = gs_MeetingMinutesV_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_MeetingMinutesV_CheckProperty4Update(pobjgs_MeetingMinutesVEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.meetingId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.meetingId) > 10) {
            throw new Error("(errid:Watl000062)字段[会议Id(meetingId)]的长度不能超过10(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.meetingId)(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.topicId)(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.meetingDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.meetingDate) > 20) {
            throw new Error("(errid:Watl000062)字段[会议日期(meetingDate)]的长度不能超过20(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.meetingDate)(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.updDate)(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.updUser)(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.year) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.year) > 4) {
            throw new Error("(errid:Watl000062)字段[年(year)]的长度不能超过4(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.year)(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.month) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.month) > 2) {
            throw new Error("(errid:Watl000062)字段[月(month)]的长度不能超过2(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.month)(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.memo)(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.participants) == false && (0, clsString_js_1.GetStrLen)(pobjgs_MeetingMinutesVEN.participants) > 500) {
            throw new Error("(errid:Watl000062)字段[参会者(participants)]的长度不能超过500(In 会议纪要历史版(gs_MeetingMinutesV))!值:$(pobjgs_MeetingMinutesVEN.participants)(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_MeetingMinutesVEN.meetingVId && undefined !== pobjgs_MeetingMinutesVEN.meetingVId && jsString_js_1.tzDataType.isNumber(pobjgs_MeetingMinutesVEN.meetingVId) === false) {
            throw new Error("(errid:Watl000063)字段[MeetingVId(meetingVId)]的值:[$(pobjgs_MeetingMinutesVEN.meetingVId)], 非法，应该为数值型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.meetingId) == false && undefined !== pobjgs_MeetingMinutesVEN.meetingId && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.meetingId) === false) {
            throw new Error("(errid:Watl000063)字段[会议Id(meetingId)]的值:[$(pobjgs_MeetingMinutesVEN.meetingId)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.topicId) == false && undefined !== pobjgs_MeetingMinutesVEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_MeetingMinutesVEN.topicId)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if (null != pobjgs_MeetingMinutesVEN.isSubmit && undefined !== pobjgs_MeetingMinutesVEN.isSubmit && jsString_js_1.tzDataType.isBoolean(pobjgs_MeetingMinutesVEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_MeetingMinutesVEN.isSubmit)], 非法，应该为布尔型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.meetingContent) == false && undefined !== pobjgs_MeetingMinutesVEN.meetingContent && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.meetingContent) === false) {
            throw new Error("(errid:Watl000063)字段[会议内容(meetingContent)]的值:[$(pobjgs_MeetingMinutesVEN.meetingContent)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.meetingDate) == false && undefined !== pobjgs_MeetingMinutesVEN.meetingDate && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.meetingDate) === false) {
            throw new Error("(errid:Watl000063)字段[会议日期(meetingDate)]的值:[$(pobjgs_MeetingMinutesVEN.meetingDate)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.updDate) == false && undefined !== pobjgs_MeetingMinutesVEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_MeetingMinutesVEN.updDate)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.updUser) == false && undefined !== pobjgs_MeetingMinutesVEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_MeetingMinutesVEN.updUser)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.year) == false && undefined !== pobjgs_MeetingMinutesVEN.year && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.year) === false) {
            throw new Error("(errid:Watl000063)字段[年(year)]的值:[$(pobjgs_MeetingMinutesVEN.year)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.month) == false && undefined !== pobjgs_MeetingMinutesVEN.month && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.month) === false) {
            throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjgs_MeetingMinutesVEN.month)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.memo) == false && undefined !== pobjgs_MeetingMinutesVEN.memo && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_MeetingMinutesVEN.memo)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_MeetingMinutesVEN.participants) == false && undefined !== pobjgs_MeetingMinutesVEN.participants && jsString_js_1.tzDataType.isString(pobjgs_MeetingMinutesVEN.participants) === false) {
            throw new Error("(errid:Watl000063)字段[参会者(participants)]的值:[$(pobjgs_MeetingMinutesVEN.participants)], 非法，应该为字符型(In 会议纪要历史版(gs_MeetingMinutesV))!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_MeetingMinutesVEN.meetingVId
            || pobjgs_MeetingMinutesVEN.meetingVId != null && pobjgs_MeetingMinutesVEN.meetingVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[MeetingVId]不能为空(In 会议纪要历史版)!(clsgs_MeetingMinutesVBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_MeetingMinutesVEN.SetIsCheckProperty(true);
    }
    exports.gs_MeetingMinutesV_CheckProperty4Update = gs_MeetingMinutesV_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_MeetingMinutesV_GetJSONStrByObj(pobjgs_MeetingMinutesVEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_MeetingMinutesVEN.sf_UpdFldSetStr = pobjgs_MeetingMinutesVEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_MeetingMinutesVEN);
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
    exports.gs_MeetingMinutesV_GetJSONStrByObj = gs_MeetingMinutesV_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_MeetingMinutesV_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_MeetingMinutesVObjLst = new Array();
        if (strJSON === "") {
            return arrgs_MeetingMinutesVObjLst;
        }
        try {
            arrgs_MeetingMinutesVObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_MeetingMinutesVObjLst;
        }
        return arrgs_MeetingMinutesVObjLst;
    }
    exports.gs_MeetingMinutesV_GetObjLstByJSONStr = gs_MeetingMinutesV_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_MeetingMinutesVObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_MeetingMinutesV_GetObjLstByJSONObjLst(arrgs_MeetingMinutesVObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_MeetingMinutesVObjLst = new Array();
        for (const objInFor of arrgs_MeetingMinutesVObjLstS) {
            const obj1 = gs_MeetingMinutesV_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_MeetingMinutesVObjLst.push(obj1);
        }
        return arrgs_MeetingMinutesVObjLst;
    }
    exports.gs_MeetingMinutesV_GetObjLstByJSONObjLst = gs_MeetingMinutesV_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_MeetingMinutesV_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_MeetingMinutesVEN = new clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN();
        if (strJSON === "") {
            return pobjgs_MeetingMinutesVEN;
        }
        try {
            pobjgs_MeetingMinutesVEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_MeetingMinutesVEN;
        }
        return pobjgs_MeetingMinutesVEN;
    }
    exports.gs_MeetingMinutesV_GetObjByJSONStr = gs_MeetingMinutesV_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_MeetingMinutesV_GetCombineCondition(objgs_MeetingMinutesV_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutesV_Cond.dicFldComparisonOp, clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingVId) == true) {
            const strComparisonOp_MeetingVId = objgs_MeetingMinutesV_Cond.dicFldComparisonOp[clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingVId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingVId, objgs_MeetingMinutesV_Cond.meetingVId, strComparisonOp_MeetingVId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutesV_Cond.dicFldComparisonOp, clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingId) == true) {
            const strComparisonOp_MeetingId = objgs_MeetingMinutesV_Cond.dicFldComparisonOp[clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingId, objgs_MeetingMinutesV_Cond.meetingId, strComparisonOp_MeetingId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutesV_Cond.dicFldComparisonOp, clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_MeetingMinutesV_Cond.dicFldComparisonOp[clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_TopicId, objgs_MeetingMinutesV_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutesV_Cond.dicFldComparisonOp, clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_IsSubmit) == true) {
            if (objgs_MeetingMinutesV_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_IsSubmit);
            }
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutesV_Cond.dicFldComparisonOp, clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingDate) == true) {
            const strComparisonOp_MeetingDate = objgs_MeetingMinutesV_Cond.dicFldComparisonOp[clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_MeetingDate, objgs_MeetingMinutesV_Cond.meetingDate, strComparisonOp_MeetingDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutesV_Cond.dicFldComparisonOp, clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_MeetingMinutesV_Cond.dicFldComparisonOp[clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_UpdDate, objgs_MeetingMinutesV_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutesV_Cond.dicFldComparisonOp, clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_MeetingMinutesV_Cond.dicFldComparisonOp[clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_UpdUser, objgs_MeetingMinutesV_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutesV_Cond.dicFldComparisonOp, clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Year) == true) {
            const strComparisonOp_Year = objgs_MeetingMinutesV_Cond.dicFldComparisonOp[clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Year];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Year, objgs_MeetingMinutesV_Cond.year, strComparisonOp_Year);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutesV_Cond.dicFldComparisonOp, clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Month) == true) {
            const strComparisonOp_Month = objgs_MeetingMinutesV_Cond.dicFldComparisonOp[clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Month];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Month, objgs_MeetingMinutesV_Cond.month, strComparisonOp_Month);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutesV_Cond.dicFldComparisonOp, clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_MeetingMinutesV_Cond.dicFldComparisonOp[clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Memo, objgs_MeetingMinutesV_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_MeetingMinutesV_Cond.dicFldComparisonOp, clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Participants) == true) {
            const strComparisonOp_Participants = objgs_MeetingMinutesV_Cond.dicFldComparisonOp[clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Participants];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN.con_Participants, objgs_MeetingMinutesV_Cond.participants, strComparisonOp_Participants);
        }
        return strWhereCond;
    }
    exports.gs_MeetingMinutesV_GetCombineCondition = gs_MeetingMinutesV_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_MeetingMinutesV(会议纪要历史版),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngMeetingVId: MeetingVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_MeetingMinutesV_GetUniCondStr_MeetingVId(objgs_MeetingMinutesVEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and MeetingVId = '{0}'", objgs_MeetingMinutesVEN.meetingVId);
        return strWhereCond;
    }
    exports.gs_MeetingMinutesV_GetUniCondStr_MeetingVId = gs_MeetingMinutesV_GetUniCondStr_MeetingVId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_MeetingMinutesV(会议纪要历史版),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngMeetingVId: MeetingVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_MeetingMinutesV_GetUniCondStr4Update_MeetingVId(objgs_MeetingMinutesVEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and MeetingVId <> '{0}'", objgs_MeetingMinutesVEN.meetingVId);
        strWhereCond += (0, clsString_js_1.Format)(" and MeetingVId = '{0}'", objgs_MeetingMinutesVEN.meetingVId);
        return strWhereCond;
    }
    exports.gs_MeetingMinutesV_GetUniCondStr4Update_MeetingVId = gs_MeetingMinutesV_GetUniCondStr4Update_MeetingVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_MeetingMinutesVENS:源对象
     * @param objgs_MeetingMinutesVENT:目标对象
    */
    function gs_MeetingMinutesV_CopyObjTo(objgs_MeetingMinutesVENS, objgs_MeetingMinutesVENT) {
        objgs_MeetingMinutesVENT.meetingVId = objgs_MeetingMinutesVENS.meetingVId; //MeetingVId
        objgs_MeetingMinutesVENT.meetingId = objgs_MeetingMinutesVENS.meetingId; //会议Id
        objgs_MeetingMinutesVENT.topicId = objgs_MeetingMinutesVENS.topicId; //主题Id
        objgs_MeetingMinutesVENT.isSubmit = objgs_MeetingMinutesVENS.isSubmit; //是否提交
        objgs_MeetingMinutesVENT.meetingContent = objgs_MeetingMinutesVENS.meetingContent; //会议内容
        objgs_MeetingMinutesVENT.meetingDate = objgs_MeetingMinutesVENS.meetingDate; //会议日期
        objgs_MeetingMinutesVENT.updDate = objgs_MeetingMinutesVENS.updDate; //修改日期
        objgs_MeetingMinutesVENT.updUser = objgs_MeetingMinutesVENS.updUser; //修改人
        objgs_MeetingMinutesVENT.year = objgs_MeetingMinutesVENS.year; //年
        objgs_MeetingMinutesVENT.month = objgs_MeetingMinutesVENS.month; //月
        objgs_MeetingMinutesVENT.memo = objgs_MeetingMinutesVENS.memo; //备注
        objgs_MeetingMinutesVENT.participants = objgs_MeetingMinutesVENS.participants; //参会者
        objgs_MeetingMinutesVENT.sf_UpdFldSetStr = objgs_MeetingMinutesVENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_MeetingMinutesV_CopyObjTo = gs_MeetingMinutesV_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_MeetingMinutesVENS:源对象
     * @param objgs_MeetingMinutesVENT:目标对象
    */
    function gs_MeetingMinutesV_GetObjFromJsonObj(objgs_MeetingMinutesVENS) {
        const objgs_MeetingMinutesVENT = new clsgs_MeetingMinutesVEN_js_1.clsgs_MeetingMinutesVEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_MeetingMinutesVENT, objgs_MeetingMinutesVENS);
        return objgs_MeetingMinutesVENT;
    }
    exports.gs_MeetingMinutesV_GetObjFromJsonObj = gs_MeetingMinutesV_GetObjFromJsonObj;
});
