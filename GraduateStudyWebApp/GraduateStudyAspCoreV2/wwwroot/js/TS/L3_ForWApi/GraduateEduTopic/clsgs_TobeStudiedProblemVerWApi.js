/**
* 类名:clsgs_TobeStudiedProblemVerWApi
* 表名:gs_TobeStudiedProblemVer(01120775)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:44:38
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemVerEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TobeStudiedProblemVer_GetObjFromJsonObj = exports.gs_TobeStudiedProblemVer_CopyObjTo = exports.gs_TobeStudiedProblemVer_GetUniCondStr4Update_ProblemVId = exports.gs_TobeStudiedProblemVer_GetUniCondStr_ProblemVId = exports.gs_TobeStudiedProblemVer_GetCombineCondition = exports.gs_TobeStudiedProblemVer_GetObjByJSONStr = exports.gs_TobeStudiedProblemVer_GetObjLstByJSONObjLst = exports.gs_TobeStudiedProblemVer_GetObjLstByJSONStr = exports.gs_TobeStudiedProblemVer_GetJSONStrByObj = exports.gs_TobeStudiedProblemVer_CheckProperty4Update = exports.gs_TobeStudiedProblemVer_CheckPropertyNew = exports.gs_TobeStudiedProblemVer_GetWebApiUrl = exports.gs_TobeStudiedProblemVer_GetMaxStrIdByPrefix = exports.gs_TobeStudiedProblemVer_GetRecCountByCondAsync = exports.gs_TobeStudiedProblemVer_IsExistAsync = exports.gs_TobeStudiedProblemVer_IsExist = exports.gs_TobeStudiedProblemVer_IsExistRecordAsync = exports.gs_TobeStudiedProblemVer_UpdateWithConditionAsync = exports.gs_TobeStudiedProblemVer_UpdateRecordAsync = exports.gs_TobeStudiedProblemVer_AddNewRecordWithReturnKey = exports.gs_TobeStudiedProblemVer_AddNewRecordWithReturnKeyAsync = exports.gs_TobeStudiedProblemVer_AddNewRecordAsync = exports.gs_TobeStudiedProblemVer_Delgs_TobeStudiedProblemVersByCondAsync = exports.gs_TobeStudiedProblemVer_Delgs_TobeStudiedProblemVersAsync = exports.gs_TobeStudiedProblemVer_DelRecordAsync = exports.gs_TobeStudiedProblemVer_GetObjLstByPagerAsync = exports.gs_TobeStudiedProblemVer_GetObjLstByRange = exports.gs_TobeStudiedProblemVer_GetObjLstByRangeAsync = exports.gs_TobeStudiedProblemVer_GetTopObjLstAsync = exports.gs_TobeStudiedProblemVer_GetObjLstByProblemVIdLstAsync = exports.gs_TobeStudiedProblemVer_GetObjLstAsync = exports.gs_TobeStudiedProblemVer_GetFirstObjAsync = exports.gs_TobeStudiedProblemVer_GetFirstID = exports.gs_TobeStudiedProblemVer_GetFirstIDAsync = exports.gs_TobeStudiedProblemVer_FilterFunByKey = exports.gs_TobeStudiedProblemVer_SortFunByKey = exports.gs_TobeStudiedProblemVer_SortFun_Defa_2Fld = exports.gs_TobeStudiedProblemVer_SortFun_Defa = exports.gs_TobeStudiedProblemVer_GetObjByProblemVIdAsync = exports.gs_TobeStudiedProblemVer_ConstructorName = exports.gs_TobeStudiedProblemVer_Controller = void 0;
    /**
     * 待研究问题历史版本表(gs_TobeStudiedProblemVer)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_TobeStudiedProblemVerEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemVerEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_TobeStudiedProblemVer_Controller = "gs_TobeStudiedProblemVerApi";
    exports.gs_TobeStudiedProblemVer_ConstructorName = "gs_TobeStudiedProblemVer";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngProblemVId:关键字
    * @returns 对象
    **/
    async function gs_TobeStudiedProblemVer_GetObjByProblemVIdAsync(lngProblemVId) {
        const strThisFuncName = "GetObjByProblemVIdAsync";
        if (lngProblemVId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngProblemVId]不能为空！(In clsgs_TobeStudiedProblemVerWApi.GetObjByProblemVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByProblemVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngProblemVId": lngProblemVId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objgs_TobeStudiedProblemVer = gs_TobeStudiedProblemVer_GetObjFromJsonObj(returnObj);
                return objgs_TobeStudiedProblemVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_GetObjByProblemVIdAsync = gs_TobeStudiedProblemVer_GetObjByProblemVIdAsync;
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
    function gs_TobeStudiedProblemVer_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.problemVId - b.problemVId;
    }
    exports.gs_TobeStudiedProblemVer_SortFun_Defa = gs_TobeStudiedProblemVer_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TobeStudiedProblemVer_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.problemId == b.problemId)
            return a.topicId.localeCompare(b.topicId);
        else
            return a.problemId.localeCompare(b.problemId);
    }
    exports.gs_TobeStudiedProblemVer_SortFun_Defa_2Fld = gs_TobeStudiedProblemVer_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TobeStudiedProblemVer_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemVId:
                    return (a, b) => {
                        return a.problemVId - b.problemVId;
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemId:
                    return (a, b) => {
                        return a.problemId.localeCompare(b.problemId);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemContent:
                    return (a, b) => {
                        if (a.problemContent == null)
                            return -1;
                        if (b.problemContent == null)
                            return 1;
                        return a.problemContent.localeCompare(b.problemContent);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemDate:
                    return (a, b) => {
                        if (a.problemDate == null)
                            return -1;
                        if (b.problemDate == null)
                            return 1;
                        return a.problemDate.localeCompare(b.problemDate);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Participant:
                    return (a, b) => {
                        if (a.participant == null)
                            return -1;
                        if (b.participant == null)
                            return 1;
                        return a.participant.localeCompare(b.participant);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Year:
                    return (a, b) => {
                        if (a.year == null)
                            return -1;
                        if (b.year == null)
                            return 1;
                        return a.year.localeCompare(b.year);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Month:
                    return (a, b) => {
                        if (a.month == null)
                            return -1;
                        if (b.month == null)
                            return 1;
                        return a.month.localeCompare(b.month);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemTitle:
                    return (a, b) => {
                        if (a.problemTitle == null)
                            return -1;
                        if (b.problemTitle == null)
                            return 1;
                        return a.problemTitle.localeCompare(b.problemTitle);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblemVer]中不存在！(in ${exports.gs_TobeStudiedProblemVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemVId:
                    return (a, b) => {
                        return b.problemVId - a.problemVId;
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemId:
                    return (a, b) => {
                        return b.problemId.localeCompare(a.problemId);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemContent:
                    return (a, b) => {
                        if (b.problemContent == null)
                            return -1;
                        if (a.problemContent == null)
                            return 1;
                        return b.problemContent.localeCompare(a.problemContent);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemDate:
                    return (a, b) => {
                        if (b.problemDate == null)
                            return -1;
                        if (a.problemDate == null)
                            return 1;
                        return b.problemDate.localeCompare(a.problemDate);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Participant:
                    return (a, b) => {
                        if (b.participant == null)
                            return -1;
                        if (a.participant == null)
                            return 1;
                        return b.participant.localeCompare(a.participant);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Year:
                    return (a, b) => {
                        if (b.year == null)
                            return -1;
                        if (a.year == null)
                            return 1;
                        return b.year.localeCompare(a.year);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Month:
                    return (a, b) => {
                        if (b.month == null)
                            return -1;
                        if (a.month == null)
                            return 1;
                        return b.month.localeCompare(a.month);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemTitle:
                    return (a, b) => {
                        if (b.problemTitle == null)
                            return -1;
                        if (a.problemTitle == null)
                            return 1;
                        return b.problemTitle.localeCompare(a.problemTitle);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblemVer]中不存在！(in ${exports.gs_TobeStudiedProblemVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_SortFunByKey = gs_TobeStudiedProblemVer_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_TobeStudiedProblemVer_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemVId:
                return (obj) => {
                    return obj.problemVId === value;
                };
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemId:
                return (obj) => {
                    return obj.problemId === value;
                };
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemContent:
                return (obj) => {
                    return obj.problemContent === value;
                };
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemDate:
                return (obj) => {
                    return obj.problemDate === value;
                };
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Participant:
                return (obj) => {
                    return obj.participant === value;
                };
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Year:
                return (obj) => {
                    return obj.year === value;
                };
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Month:
                return (obj) => {
                    return obj.month === value;
                };
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemTitle:
                return (obj) => {
                    return obj.problemTitle === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblemVer]中不存在！(in ${exports.gs_TobeStudiedProblemVer_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_TobeStudiedProblemVer_FilterFunByKey = gs_TobeStudiedProblemVer_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TobeStudiedProblemVer_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_GetFirstIDAsync = gs_TobeStudiedProblemVer_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_TobeStudiedProblemVer_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_GetFirstID = gs_TobeStudiedProblemVer_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_TobeStudiedProblemVer_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
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
                const objgs_TobeStudiedProblemVer = gs_TobeStudiedProblemVer_GetObjFromJsonObj(returnObj);
                return objgs_TobeStudiedProblemVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_GetFirstObjAsync = gs_TobeStudiedProblemVer_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_TobeStudiedProblemVer_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblemVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_GetObjLstAsync = gs_TobeStudiedProblemVer_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrProblemVId:关键字列表
    * @returns 对象列表
    **/
    async function gs_TobeStudiedProblemVer_GetObjLstByProblemVIdLstAsync(arrProblemVId) {
        const strThisFuncName = "GetObjLstByProblemVIdLstAsync";
        const strAction = "GetObjLstByProblemVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrProblemVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblemVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_GetObjLstByProblemVIdLstAsync = gs_TobeStudiedProblemVer_GetObjLstByProblemVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_TobeStudiedProblemVer_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblemVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_GetTopObjLstAsync = gs_TobeStudiedProblemVer_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TobeStudiedProblemVer_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblemVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_GetObjLstByRangeAsync = gs_TobeStudiedProblemVer_GetObjLstByRangeAsync;
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
    async function gs_TobeStudiedProblemVer_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_GetObjLstByRange = gs_TobeStudiedProblemVer_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TobeStudiedProblemVer_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblemVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_GetObjLstByPagerAsync = gs_TobeStudiedProblemVer_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngProblemVId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_TobeStudiedProblemVer_DelRecordAsync(lngProblemVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngProblemVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_DelRecordAsync = gs_TobeStudiedProblemVer_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrProblemVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_TobeStudiedProblemVer_Delgs_TobeStudiedProblemVersAsync(arrProblemVId) {
        const strThisFuncName = "Delgs_TobeStudiedProblemVersAsync";
        const strAction = "Delgs_TobeStudiedProblemVers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrProblemVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_Delgs_TobeStudiedProblemVersAsync = gs_TobeStudiedProblemVer_Delgs_TobeStudiedProblemVersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_TobeStudiedProblemVer_Delgs_TobeStudiedProblemVersByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_TobeStudiedProblemVersByCondAsync";
        const strAction = "Delgs_TobeStudiedProblemVersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_Delgs_TobeStudiedProblemVersByCondAsync = gs_TobeStudiedProblemVer_Delgs_TobeStudiedProblemVersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_TobeStudiedProblemVerEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_TobeStudiedProblemVer_AddNewRecordAsync(objgs_TobeStudiedProblemVerEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_TobeStudiedProblemVerEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_AddNewRecordAsync = gs_TobeStudiedProblemVer_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_TobeStudiedProblemVerEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_TobeStudiedProblemVer_AddNewRecordWithReturnKeyAsync(objgs_TobeStudiedProblemVerEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_AddNewRecordWithReturnKeyAsync = gs_TobeStudiedProblemVer_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_TobeStudiedProblemVerEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_TobeStudiedProblemVer_AddNewRecordWithReturnKey(objgs_TobeStudiedProblemVerEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_TobeStudiedProblemVerEN.problemVId === null || objgs_TobeStudiedProblemVerEN.problemVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemVerEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_AddNewRecordWithReturnKey = gs_TobeStudiedProblemVer_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_TobeStudiedProblemVerEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_TobeStudiedProblemVer_UpdateRecordAsync(objgs_TobeStudiedProblemVerEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_TobeStudiedProblemVerEN.sf_UpdFldSetStr === undefined || objgs_TobeStudiedProblemVerEN.sf_UpdFldSetStr === null || objgs_TobeStudiedProblemVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TobeStudiedProblemVerEN.problemVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_UpdateRecordAsync = gs_TobeStudiedProblemVer_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_TobeStudiedProblemVerEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TobeStudiedProblemVer_UpdateWithConditionAsync(objgs_TobeStudiedProblemVerEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_TobeStudiedProblemVerEN.sf_UpdFldSetStr === undefined || objgs_TobeStudiedProblemVerEN.sf_UpdFldSetStr === null || objgs_TobeStudiedProblemVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TobeStudiedProblemVerEN.problemVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        objgs_TobeStudiedProblemVerEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_UpdateWithConditionAsync = gs_TobeStudiedProblemVer_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_TobeStudiedProblemVer_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_IsExistRecordAsync = gs_TobeStudiedProblemVer_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngProblemVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_TobeStudiedProblemVer_IsExist(lngProblemVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ProblemVId": lngProblemVId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_IsExist = gs_TobeStudiedProblemVer_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngProblemVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_TobeStudiedProblemVer_IsExistAsync(lngProblemVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngProblemVId": lngProblemVId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_IsExistAsync = gs_TobeStudiedProblemVer_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_TobeStudiedProblemVer_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_GetRecCountByCondAsync = gs_TobeStudiedProblemVer_GetRecCountByCondAsync;
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
    async function gs_TobeStudiedProblemVer_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemVer_GetMaxStrIdByPrefix = gs_TobeStudiedProblemVer_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_TobeStudiedProblemVer_GetWebApiUrl(strController, strAction) {
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
    exports.gs_TobeStudiedProblemVer_GetWebApiUrl = gs_TobeStudiedProblemVer_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TobeStudiedProblemVer_CheckPropertyNew(pobjgs_TobeStudiedProblemVerEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemId) === true) {
            throw new Error("(errid:Watl000058)字段[问题Id]不能为空(In 待研究问题历史版本表)!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.problemId) > 10) {
            throw new Error("(errid:Watl000059)字段[问题Id(problemId)]的长度不能超过10(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.problemId)(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.topicId)(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemContent) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.problemContent) > 5000) {
            throw new Error("(errid:Watl000059)字段[问题内容(problemContent)]的长度不能超过5000(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.problemContent)(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.problemDate) > 20) {
            throw new Error("(errid:Watl000059)字段[问题日期(problemDate)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.problemDate)(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.participant) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.participant) > 500) {
            throw new Error("(errid:Watl000059)字段[参与者(participant)]的长度不能超过500(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.participant)(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.updDate)(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.updUser)(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.year) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.year) > 4) {
            throw new Error("(errid:Watl000059)字段[年(year)]的长度不能超过4(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.year)(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.month) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.month) > 2) {
            throw new Error("(errid:Watl000059)字段[月(month)]的长度不能超过2(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.month)(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.memo)(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemTitle) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.problemTitle) > 1000) {
            throw new Error("(errid:Watl000059)字段[问题标题(problemTitle)]的长度不能超过1000(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.problemTitle)(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_TobeStudiedProblemVerEN.problemVId && undefined !== pobjgs_TobeStudiedProblemVerEN.problemVId && clsString_js_1.tzDataType.isNumber(pobjgs_TobeStudiedProblemVerEN.problemVId) === false) {
            throw new Error("(errid:Watl000060)字段[ProblemVId(problemVId)]的值:[$(pobjgs_TobeStudiedProblemVerEN.problemVId)], 非法，应该为数值型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemId) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.problemId && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.problemId) === false) {
            throw new Error("(errid:Watl000060)字段[问题Id(problemId)]的值:[$(pobjgs_TobeStudiedProblemVerEN.problemId)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.topicId) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.topicId && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_TobeStudiedProblemVerEN.topicId)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if (null != pobjgs_TobeStudiedProblemVerEN.isSubmit && undefined !== pobjgs_TobeStudiedProblemVerEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjgs_TobeStudiedProblemVerEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_TobeStudiedProblemVerEN.isSubmit)], 非法，应该为布尔型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemContent) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.problemContent && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.problemContent) === false) {
            throw new Error("(errid:Watl000060)字段[问题内容(problemContent)]的值:[$(pobjgs_TobeStudiedProblemVerEN.problemContent)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemDate) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.problemDate && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.problemDate) === false) {
            throw new Error("(errid:Watl000060)字段[问题日期(problemDate)]的值:[$(pobjgs_TobeStudiedProblemVerEN.problemDate)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.participant) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.participant && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.participant) === false) {
            throw new Error("(errid:Watl000060)字段[参与者(participant)]的值:[$(pobjgs_TobeStudiedProblemVerEN.participant)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.updDate) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TobeStudiedProblemVerEN.updDate)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.updUser) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TobeStudiedProblemVerEN.updUser)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.year) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.year && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.year) === false) {
            throw new Error("(errid:Watl000060)字段[年(year)]的值:[$(pobjgs_TobeStudiedProblemVerEN.year)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.month) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.month && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.month) === false) {
            throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjgs_TobeStudiedProblemVerEN.month)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.memo) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.memo && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TobeStudiedProblemVerEN.memo)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemTitle) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.problemTitle && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.problemTitle) === false) {
            throw new Error("(errid:Watl000060)字段[问题标题(problemTitle)]的值:[$(pobjgs_TobeStudiedProblemVerEN.problemTitle)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_TobeStudiedProblemVerEN.SetIsCheckProperty(true);
    }
    exports.gs_TobeStudiedProblemVer_CheckPropertyNew = gs_TobeStudiedProblemVer_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TobeStudiedProblemVer_CheckProperty4Update(pobjgs_TobeStudiedProblemVerEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.problemId) > 10) {
            throw new Error("(errid:Watl000062)字段[问题Id(problemId)]的长度不能超过10(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.problemId)(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.topicId)(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemContent) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.problemContent) > 5000) {
            throw new Error("(errid:Watl000062)字段[问题内容(problemContent)]的长度不能超过5000(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.problemContent)(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.problemDate) > 20) {
            throw new Error("(errid:Watl000062)字段[问题日期(problemDate)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.problemDate)(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.participant) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.participant) > 500) {
            throw new Error("(errid:Watl000062)字段[参与者(participant)]的长度不能超过500(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.participant)(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.updDate)(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.updUser)(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.year) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.year) > 4) {
            throw new Error("(errid:Watl000062)字段[年(year)]的长度不能超过4(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.year)(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.month) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.month) > 2) {
            throw new Error("(errid:Watl000062)字段[月(month)]的长度不能超过2(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.month)(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.memo)(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemTitle) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TobeStudiedProblemVerEN.problemTitle) > 1000) {
            throw new Error("(errid:Watl000062)字段[问题标题(problemTitle)]的长度不能超过1000(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!值:$(pobjgs_TobeStudiedProblemVerEN.problemTitle)(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_TobeStudiedProblemVerEN.problemVId && undefined !== pobjgs_TobeStudiedProblemVerEN.problemVId && clsString_js_1.tzDataType.isNumber(pobjgs_TobeStudiedProblemVerEN.problemVId) === false) {
            throw new Error("(errid:Watl000063)字段[ProblemVId(problemVId)]的值:[$(pobjgs_TobeStudiedProblemVerEN.problemVId)], 非法，应该为数值型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemId) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.problemId && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.problemId) === false) {
            throw new Error("(errid:Watl000063)字段[问题Id(problemId)]的值:[$(pobjgs_TobeStudiedProblemVerEN.problemId)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.topicId) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.topicId && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_TobeStudiedProblemVerEN.topicId)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if (null != pobjgs_TobeStudiedProblemVerEN.isSubmit && undefined !== pobjgs_TobeStudiedProblemVerEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjgs_TobeStudiedProblemVerEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_TobeStudiedProblemVerEN.isSubmit)], 非法，应该为布尔型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemContent) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.problemContent && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.problemContent) === false) {
            throw new Error("(errid:Watl000063)字段[问题内容(problemContent)]的值:[$(pobjgs_TobeStudiedProblemVerEN.problemContent)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemDate) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.problemDate && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.problemDate) === false) {
            throw new Error("(errid:Watl000063)字段[问题日期(problemDate)]的值:[$(pobjgs_TobeStudiedProblemVerEN.problemDate)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.participant) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.participant && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.participant) === false) {
            throw new Error("(errid:Watl000063)字段[参与者(participant)]的值:[$(pobjgs_TobeStudiedProblemVerEN.participant)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.updDate) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TobeStudiedProblemVerEN.updDate)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.updUser) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TobeStudiedProblemVerEN.updUser)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.year) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.year && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.year) === false) {
            throw new Error("(errid:Watl000063)字段[年(year)]的值:[$(pobjgs_TobeStudiedProblemVerEN.year)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.month) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.month && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.month) === false) {
            throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjgs_TobeStudiedProblemVerEN.month)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.memo) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.memo && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TobeStudiedProblemVerEN.memo)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVerEN.problemTitle) == false && undefined !== pobjgs_TobeStudiedProblemVerEN.problemTitle && clsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVerEN.problemTitle) === false) {
            throw new Error("(errid:Watl000063)字段[问题标题(problemTitle)]的值:[$(pobjgs_TobeStudiedProblemVerEN.problemTitle)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemVer))!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_TobeStudiedProblemVerEN.problemVId
            || pobjgs_TobeStudiedProblemVerEN.problemVId != null && pobjgs_TobeStudiedProblemVerEN.problemVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[ProblemVId]不能为空(In 待研究问题历史版本表)!(clsgs_TobeStudiedProblemVerBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_TobeStudiedProblemVerEN.SetIsCheckProperty(true);
    }
    exports.gs_TobeStudiedProblemVer_CheckProperty4Update = gs_TobeStudiedProblemVer_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TobeStudiedProblemVer_GetJSONStrByObj(pobjgs_TobeStudiedProblemVerEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_TobeStudiedProblemVerEN.sf_UpdFldSetStr = pobjgs_TobeStudiedProblemVerEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_TobeStudiedProblemVerEN);
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
    exports.gs_TobeStudiedProblemVer_GetJSONStrByObj = gs_TobeStudiedProblemVer_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_TobeStudiedProblemVer_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_TobeStudiedProblemVerObjLst = new Array();
        if (strJSON === "") {
            return arrgs_TobeStudiedProblemVerObjLst;
        }
        try {
            arrgs_TobeStudiedProblemVerObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_TobeStudiedProblemVerObjLst;
        }
        return arrgs_TobeStudiedProblemVerObjLst;
    }
    exports.gs_TobeStudiedProblemVer_GetObjLstByJSONStr = gs_TobeStudiedProblemVer_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_TobeStudiedProblemVerObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_TobeStudiedProblemVer_GetObjLstByJSONObjLst(arrgs_TobeStudiedProblemVerObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_TobeStudiedProblemVerObjLst = new Array();
        for (const objInFor of arrgs_TobeStudiedProblemVerObjLstS) {
            const obj1 = gs_TobeStudiedProblemVer_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_TobeStudiedProblemVerObjLst.push(obj1);
        }
        return arrgs_TobeStudiedProblemVerObjLst;
    }
    exports.gs_TobeStudiedProblemVer_GetObjLstByJSONObjLst = gs_TobeStudiedProblemVer_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TobeStudiedProblemVer_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_TobeStudiedProblemVerEN = new clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN();
        if (strJSON === "") {
            return pobjgs_TobeStudiedProblemVerEN;
        }
        try {
            pobjgs_TobeStudiedProblemVerEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_TobeStudiedProblemVerEN;
        }
        return pobjgs_TobeStudiedProblemVerEN;
    }
    exports.gs_TobeStudiedProblemVer_GetObjByJSONStr = gs_TobeStudiedProblemVer_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_TobeStudiedProblemVer_GetCombineCondition(objgs_TobeStudiedProblemVer_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemVId) == true) {
            const strComparisonOp_ProblemVId = objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemVId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemVId, objgs_TobeStudiedProblemVer_Cond.problemVId, strComparisonOp_ProblemVId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemId) == true) {
            const strComparisonOp_ProblemId = objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemId, objgs_TobeStudiedProblemVer_Cond.problemId, strComparisonOp_ProblemId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_TopicId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_TopicId, objgs_TobeStudiedProblemVer_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_IsSubmit) == true) {
            if (objgs_TobeStudiedProblemVer_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemContent) == true) {
            const strComparisonOp_ProblemContent = objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemContent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemContent, objgs_TobeStudiedProblemVer_Cond.problemContent, strComparisonOp_ProblemContent);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemDate) == true) {
            const strComparisonOp_ProblemDate = objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemDate, objgs_TobeStudiedProblemVer_Cond.problemDate, strComparisonOp_ProblemDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Participant) == true) {
            const strComparisonOp_Participant = objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Participant];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Participant, objgs_TobeStudiedProblemVer_Cond.participant, strComparisonOp_Participant);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_UpdDate, objgs_TobeStudiedProblemVer_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_UpdUser, objgs_TobeStudiedProblemVer_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Year) == true) {
            const strComparisonOp_Year = objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Year];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Year, objgs_TobeStudiedProblemVer_Cond.year, strComparisonOp_Year);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Month) == true) {
            const strComparisonOp_Month = objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Month];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Month, objgs_TobeStudiedProblemVer_Cond.month, strComparisonOp_Month);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_Memo, objgs_TobeStudiedProblemVer_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemTitle) == true) {
            const strComparisonOp_ProblemTitle = objgs_TobeStudiedProblemVer_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemTitle];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN.con_ProblemTitle, objgs_TobeStudiedProblemVer_Cond.problemTitle, strComparisonOp_ProblemTitle);
        }
        return strWhereCond;
    }
    exports.gs_TobeStudiedProblemVer_GetCombineCondition = gs_TobeStudiedProblemVer_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_TobeStudiedProblemVer(待研究问题历史版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngProblemVId: ProblemVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_TobeStudiedProblemVer_GetUniCondStr_ProblemVId(objgs_TobeStudiedProblemVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ProblemVId = '{0}'", objgs_TobeStudiedProblemVerEN.problemVId);
        return strWhereCond;
    }
    exports.gs_TobeStudiedProblemVer_GetUniCondStr_ProblemVId = gs_TobeStudiedProblemVer_GetUniCondStr_ProblemVId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_TobeStudiedProblemVer(待研究问题历史版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngProblemVId: ProblemVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_TobeStudiedProblemVer_GetUniCondStr4Update_ProblemVId(objgs_TobeStudiedProblemVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ProblemVId <> '{0}'", objgs_TobeStudiedProblemVerEN.problemVId);
        strWhereCond += (0, clsString_js_2.Format)(" and ProblemVId = '{0}'", objgs_TobeStudiedProblemVerEN.problemVId);
        return strWhereCond;
    }
    exports.gs_TobeStudiedProblemVer_GetUniCondStr4Update_ProblemVId = gs_TobeStudiedProblemVer_GetUniCondStr4Update_ProblemVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_TobeStudiedProblemVerENS:源对象
     * @param objgs_TobeStudiedProblemVerENT:目标对象
    */
    function gs_TobeStudiedProblemVer_CopyObjTo(objgs_TobeStudiedProblemVerENS, objgs_TobeStudiedProblemVerENT) {
        objgs_TobeStudiedProblemVerENT.problemVId = objgs_TobeStudiedProblemVerENS.problemVId; //ProblemVId
        objgs_TobeStudiedProblemVerENT.problemId = objgs_TobeStudiedProblemVerENS.problemId; //问题Id
        objgs_TobeStudiedProblemVerENT.topicId = objgs_TobeStudiedProblemVerENS.topicId; //主题Id
        objgs_TobeStudiedProblemVerENT.isSubmit = objgs_TobeStudiedProblemVerENS.isSubmit; //是否提交
        objgs_TobeStudiedProblemVerENT.problemContent = objgs_TobeStudiedProblemVerENS.problemContent; //问题内容
        objgs_TobeStudiedProblemVerENT.problemDate = objgs_TobeStudiedProblemVerENS.problemDate; //问题日期
        objgs_TobeStudiedProblemVerENT.participant = objgs_TobeStudiedProblemVerENS.participant; //参与者
        objgs_TobeStudiedProblemVerENT.updDate = objgs_TobeStudiedProblemVerENS.updDate; //修改日期
        objgs_TobeStudiedProblemVerENT.updUser = objgs_TobeStudiedProblemVerENS.updUser; //修改人
        objgs_TobeStudiedProblemVerENT.year = objgs_TobeStudiedProblemVerENS.year; //年
        objgs_TobeStudiedProblemVerENT.month = objgs_TobeStudiedProblemVerENS.month; //月
        objgs_TobeStudiedProblemVerENT.memo = objgs_TobeStudiedProblemVerENS.memo; //备注
        objgs_TobeStudiedProblemVerENT.problemTitle = objgs_TobeStudiedProblemVerENS.problemTitle; //问题标题
        objgs_TobeStudiedProblemVerENT.sf_UpdFldSetStr = objgs_TobeStudiedProblemVerENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_TobeStudiedProblemVer_CopyObjTo = gs_TobeStudiedProblemVer_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_TobeStudiedProblemVerENS:源对象
     * @param objgs_TobeStudiedProblemVerENT:目标对象
    */
    function gs_TobeStudiedProblemVer_GetObjFromJsonObj(objgs_TobeStudiedProblemVerENS) {
        const objgs_TobeStudiedProblemVerENT = new clsgs_TobeStudiedProblemVerEN_js_1.clsgs_TobeStudiedProblemVerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TobeStudiedProblemVerENT, objgs_TobeStudiedProblemVerENS);
        return objgs_TobeStudiedProblemVerENT;
    }
    exports.gs_TobeStudiedProblemVer_GetObjFromJsonObj = gs_TobeStudiedProblemVer_GetObjFromJsonObj;
});
