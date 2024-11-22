/**
* 类名:clsgs_TobeStudiedProblemVWApi
* 表名:gs_TobeStudiedProblemV(01120775)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:47:12
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemVEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TobeStudiedProblemV_GetObjFromJsonObj = exports.gs_TobeStudiedProblemV_CopyObjTo = exports.gs_TobeStudiedProblemV_GetUniCondStr4Update_ProblemVId = exports.gs_TobeStudiedProblemV_GetUniCondStr_ProblemVId = exports.gs_TobeStudiedProblemV_GetCombineCondition = exports.gs_TobeStudiedProblemV_GetObjByJSONStr = exports.gs_TobeStudiedProblemV_GetObjLstByJSONObjLst = exports.gs_TobeStudiedProblemV_GetObjLstByJSONStr = exports.gs_TobeStudiedProblemV_GetJSONStrByObj = exports.gs_TobeStudiedProblemV_CheckProperty4Update = exports.gs_TobeStudiedProblemV_CheckPropertyNew = exports.gs_TobeStudiedProblemV_GetWebApiUrl = exports.gs_TobeStudiedProblemV_GetMaxStrIdByPrefix = exports.gs_TobeStudiedProblemV_GetRecCountByCondAsync = exports.gs_TobeStudiedProblemV_IsExistAsync = exports.gs_TobeStudiedProblemV_IsExist = exports.gs_TobeStudiedProblemV_IsExistRecordAsync = exports.gs_TobeStudiedProblemV_UpdateWithConditionAsync = exports.gs_TobeStudiedProblemV_UpdateRecordAsync = exports.gs_TobeStudiedProblemV_AddNewRecordWithReturnKey = exports.gs_TobeStudiedProblemV_AddNewRecordWithReturnKeyAsync = exports.gs_TobeStudiedProblemV_AddNewRecordAsync = exports.gs_TobeStudiedProblemV_Delgs_TobeStudiedProblemVsByCondAsync = exports.gs_TobeStudiedProblemV_Delgs_TobeStudiedProblemVsAsync = exports.gs_TobeStudiedProblemV_DelRecordAsync = exports.gs_TobeStudiedProblemV_GetObjLstByPagerAsync = exports.gs_TobeStudiedProblemV_GetObjLstByRange = exports.gs_TobeStudiedProblemV_GetObjLstByRangeAsync = exports.gs_TobeStudiedProblemV_GetTopObjLstAsync = exports.gs_TobeStudiedProblemV_GetObjLstByProblemVIdLstAsync = exports.gs_TobeStudiedProblemV_GetObjLstAsync = exports.gs_TobeStudiedProblemV_GetFirstObjAsync = exports.gs_TobeStudiedProblemV_GetFirstID = exports.gs_TobeStudiedProblemV_GetFirstIDAsync = exports.gs_TobeStudiedProblemV_FilterFunByKey = exports.gs_TobeStudiedProblemV_SortFunByKey = exports.gs_TobeStudiedProblemV_SortFun_Defa_2Fld = exports.gs_TobeStudiedProblemV_SortFun_Defa = exports.gs_TobeStudiedProblemV_GetObjByProblemVIdAsync = exports.gs_TobeStudiedProblemV_ConstructorName = exports.gs_TobeStudiedProblemV_Controller = void 0;
    /**
     * 待研究问题历史版本表(gs_TobeStudiedProblemV)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_TobeStudiedProblemVEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemVEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_TobeStudiedProblemV_Controller = "gs_TobeStudiedProblemVApi";
    exports.gs_TobeStudiedProblemV_ConstructorName = "gs_TobeStudiedProblemV";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngProblemVId:关键字
    * @returns 对象
    **/
    async function gs_TobeStudiedProblemV_GetObjByProblemVIdAsync(lngProblemVId) {
        const strThisFuncName = "GetObjByProblemVIdAsync";
        if (lngProblemVId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngProblemVId]不能为空！(In GetObjByProblemVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByProblemVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_TobeStudiedProblemV = gs_TobeStudiedProblemV_GetObjFromJsonObj(returnObj);
                return objgs_TobeStudiedProblemV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_GetObjByProblemVIdAsync = gs_TobeStudiedProblemV_GetObjByProblemVIdAsync;
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
    function gs_TobeStudiedProblemV_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.problemVId - b.problemVId;
    }
    exports.gs_TobeStudiedProblemV_SortFun_Defa = gs_TobeStudiedProblemV_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TobeStudiedProblemV_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.problemId == b.problemId)
            return a.topicId.localeCompare(b.topicId);
        else
            return a.problemId.localeCompare(b.problemId);
    }
    exports.gs_TobeStudiedProblemV_SortFun_Defa_2Fld = gs_TobeStudiedProblemV_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TobeStudiedProblemV_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemVId:
                    return (a, b) => {
                        return a.problemVId - b.problemVId;
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemId:
                    return (a, b) => {
                        return a.problemId.localeCompare(b.problemId);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemContent:
                    return (a, b) => {
                        return a.problemContent.localeCompare(b.problemContent);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemDate:
                    return (a, b) => {
                        return a.problemDate.localeCompare(b.problemDate);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Participant:
                    return (a, b) => {
                        return a.participant.localeCompare(b.participant);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Year:
                    return (a, b) => {
                        return a.year.localeCompare(b.year);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Month:
                    return (a, b) => {
                        return a.month.localeCompare(b.month);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemTitle:
                    return (a, b) => {
                        return a.problemTitle.localeCompare(b.problemTitle);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblemV]中不存在！(in ${exports.gs_TobeStudiedProblemV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemVId:
                    return (a, b) => {
                        return b.problemVId - a.problemVId;
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemId:
                    return (a, b) => {
                        return b.problemId.localeCompare(a.problemId);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemContent:
                    return (a, b) => {
                        return b.problemContent.localeCompare(a.problemContent);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemDate:
                    return (a, b) => {
                        return b.problemDate.localeCompare(a.problemDate);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Participant:
                    return (a, b) => {
                        return b.participant.localeCompare(a.participant);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Year:
                    return (a, b) => {
                        return b.year.localeCompare(a.year);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Month:
                    return (a, b) => {
                        return b.month.localeCompare(a.month);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemTitle:
                    return (a, b) => {
                        return b.problemTitle.localeCompare(a.problemTitle);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblemV]中不存在！(in ${exports.gs_TobeStudiedProblemV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_TobeStudiedProblemV_SortFunByKey = gs_TobeStudiedProblemV_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_TobeStudiedProblemV_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemVId:
                return (obj) => {
                    return obj.problemVId === value;
                };
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemId:
                return (obj) => {
                    return obj.problemId === value;
                };
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemContent:
                return (obj) => {
                    return obj.problemContent === value;
                };
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemDate:
                return (obj) => {
                    return obj.problemDate === value;
                };
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Participant:
                return (obj) => {
                    return obj.participant === value;
                };
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Year:
                return (obj) => {
                    return obj.year === value;
                };
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Month:
                return (obj) => {
                    return obj.month === value;
                };
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemTitle:
                return (obj) => {
                    return obj.problemTitle === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblemV]中不存在！(in ${exports.gs_TobeStudiedProblemV_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_TobeStudiedProblemV_FilterFunByKey = gs_TobeStudiedProblemV_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TobeStudiedProblemV_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_GetFirstIDAsync = gs_TobeStudiedProblemV_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_TobeStudiedProblemV_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_GetFirstID = gs_TobeStudiedProblemV_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_TobeStudiedProblemV_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_TobeStudiedProblemV = gs_TobeStudiedProblemV_GetObjFromJsonObj(returnObj);
                return objgs_TobeStudiedProblemV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_GetFirstObjAsync = gs_TobeStudiedProblemV_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_TobeStudiedProblemV_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblemV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_GetObjLstAsync = gs_TobeStudiedProblemV_GetObjLstAsync;
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
    async function gs_TobeStudiedProblemV_GetObjLstByProblemVIdLstAsync(arrProblemVId) {
        const strThisFuncName = "GetObjLstByProblemVIdLstAsync";
        const strAction = "GetObjLstByProblemVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrProblemVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblemV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_GetObjLstByProblemVIdLstAsync = gs_TobeStudiedProblemV_GetObjLstByProblemVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_TobeStudiedProblemV_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblemV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_GetTopObjLstAsync = gs_TobeStudiedProblemV_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TobeStudiedProblemV_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblemV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_GetObjLstByRangeAsync = gs_TobeStudiedProblemV_GetObjLstByRangeAsync;
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
    async function gs_TobeStudiedProblemV_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_GetObjLstByRange = gs_TobeStudiedProblemV_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TobeStudiedProblemV_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblemV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_GetObjLstByPagerAsync = gs_TobeStudiedProblemV_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngProblemVId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_TobeStudiedProblemV_DelRecordAsync(lngProblemVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngProblemVId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngProblemVId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_DelRecordAsync = gs_TobeStudiedProblemV_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrProblemVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_TobeStudiedProblemV_Delgs_TobeStudiedProblemVsAsync(arrProblemVId) {
        const strThisFuncName = "Delgs_TobeStudiedProblemVsAsync";
        const strAction = "Delgs_TobeStudiedProblemVs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_Delgs_TobeStudiedProblemVsAsync = gs_TobeStudiedProblemV_Delgs_TobeStudiedProblemVsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_TobeStudiedProblemV_Delgs_TobeStudiedProblemVsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_TobeStudiedProblemVsByCondAsync";
        const strAction = "Delgs_TobeStudiedProblemVsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_Delgs_TobeStudiedProblemVsByCondAsync = gs_TobeStudiedProblemV_Delgs_TobeStudiedProblemVsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_TobeStudiedProblemVEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_TobeStudiedProblemV_AddNewRecordAsync(objgs_TobeStudiedProblemVEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_TobeStudiedProblemVEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_AddNewRecordAsync = gs_TobeStudiedProblemV_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_TobeStudiedProblemVEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_TobeStudiedProblemV_AddNewRecordWithReturnKeyAsync(objgs_TobeStudiedProblemVEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_AddNewRecordWithReturnKeyAsync = gs_TobeStudiedProblemV_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_TobeStudiedProblemVEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_TobeStudiedProblemV_AddNewRecordWithReturnKey(objgs_TobeStudiedProblemVEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_TobeStudiedProblemVEN.problemVId === null || objgs_TobeStudiedProblemVEN.problemVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemVEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_AddNewRecordWithReturnKey = gs_TobeStudiedProblemV_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_TobeStudiedProblemVEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_TobeStudiedProblemV_UpdateRecordAsync(objgs_TobeStudiedProblemVEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_TobeStudiedProblemVEN.sf_UpdFldSetStr === undefined || objgs_TobeStudiedProblemVEN.sf_UpdFldSetStr === null || objgs_TobeStudiedProblemVEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TobeStudiedProblemVEN.problemVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_UpdateRecordAsync = gs_TobeStudiedProblemV_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_TobeStudiedProblemVEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TobeStudiedProblemV_UpdateWithConditionAsync(objgs_TobeStudiedProblemVEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_TobeStudiedProblemVEN.sf_UpdFldSetStr === undefined || objgs_TobeStudiedProblemVEN.sf_UpdFldSetStr === null || objgs_TobeStudiedProblemVEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TobeStudiedProblemVEN.problemVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
        objgs_TobeStudiedProblemVEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_UpdateWithConditionAsync = gs_TobeStudiedProblemV_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_TobeStudiedProblemV_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_IsExistRecordAsync = gs_TobeStudiedProblemV_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngProblemVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_TobeStudiedProblemV_IsExist(lngProblemVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_IsExist = gs_TobeStudiedProblemV_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngProblemVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_TobeStudiedProblemV_IsExistAsync(lngProblemVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_IsExistAsync = gs_TobeStudiedProblemV_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_TobeStudiedProblemV_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_GetRecCountByCondAsync = gs_TobeStudiedProblemV_GetRecCountByCondAsync;
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
    async function gs_TobeStudiedProblemV_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblemV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblemV_GetMaxStrIdByPrefix = gs_TobeStudiedProblemV_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_TobeStudiedProblemV_GetWebApiUrl(strController, strAction) {
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
    exports.gs_TobeStudiedProblemV_GetWebApiUrl = gs_TobeStudiedProblemV_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TobeStudiedProblemV_CheckPropertyNew(pobjgs_TobeStudiedProblemVEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemId) === true) {
            throw new Error("(errid:Watl000058)字段[问题Id]不能为空(In 待研究问题历史版本表)!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.problemId) > 10) {
            throw new Error("(errid:Watl000059)字段[问题Id(problemId)]的长度不能超过10(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemId)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.topicId)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemContent) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.problemContent) > 5000) {
            throw new Error("(errid:Watl000059)字段[问题内容(problemContent)]的长度不能超过5000(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemContent)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.problemDate) > 20) {
            throw new Error("(errid:Watl000059)字段[问题日期(problemDate)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemDate)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.participant) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.participant) > 500) {
            throw new Error("(errid:Watl000059)字段[参与者(participant)]的长度不能超过500(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.participant)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.updDate)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.updUser)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.year) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.year) > 4) {
            throw new Error("(errid:Watl000059)字段[年(year)]的长度不能超过4(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.year)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.month) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.month) > 2) {
            throw new Error("(errid:Watl000059)字段[月(month)]的长度不能超过2(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.month)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.memo)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemTitle) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.problemTitle) > 1000) {
            throw new Error("(errid:Watl000059)字段[问题标题(problemTitle)]的长度不能超过1000(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemTitle)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_TobeStudiedProblemVEN.problemVId && undefined !== pobjgs_TobeStudiedProblemVEN.problemVId && jsString_js_1.tzDataType.isNumber(pobjgs_TobeStudiedProblemVEN.problemVId) === false) {
            throw new Error("(errid:Watl000060)字段[ProblemVId(problemVId)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemVId)], 非法，应该为数值型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemId) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemId && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemId) === false) {
            throw new Error("(errid:Watl000060)字段[问题Id(problemId)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemId)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.topicId) == false && undefined !== pobjgs_TobeStudiedProblemVEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_TobeStudiedProblemVEN.topicId)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if (null != pobjgs_TobeStudiedProblemVEN.isSubmit && undefined !== pobjgs_TobeStudiedProblemVEN.isSubmit && jsString_js_1.tzDataType.isBoolean(pobjgs_TobeStudiedProblemVEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_TobeStudiedProblemVEN.isSubmit)], 非法，应该为布尔型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemContent) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemContent && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemContent) === false) {
            throw new Error("(errid:Watl000060)字段[问题内容(problemContent)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemContent)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemDate) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemDate && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemDate) === false) {
            throw new Error("(errid:Watl000060)字段[问题日期(problemDate)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemDate)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.participant) == false && undefined !== pobjgs_TobeStudiedProblemVEN.participant && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.participant) === false) {
            throw new Error("(errid:Watl000060)字段[参与者(participant)]的值:[$(pobjgs_TobeStudiedProblemVEN.participant)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.updDate) == false && undefined !== pobjgs_TobeStudiedProblemVEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TobeStudiedProblemVEN.updDate)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.updUser) == false && undefined !== pobjgs_TobeStudiedProblemVEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TobeStudiedProblemVEN.updUser)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.year) == false && undefined !== pobjgs_TobeStudiedProblemVEN.year && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.year) === false) {
            throw new Error("(errid:Watl000060)字段[年(year)]的值:[$(pobjgs_TobeStudiedProblemVEN.year)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.month) == false && undefined !== pobjgs_TobeStudiedProblemVEN.month && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.month) === false) {
            throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjgs_TobeStudiedProblemVEN.month)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.memo) == false && undefined !== pobjgs_TobeStudiedProblemVEN.memo && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TobeStudiedProblemVEN.memo)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemTitle) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemTitle && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemTitle) === false) {
            throw new Error("(errid:Watl000060)字段[问题标题(problemTitle)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemTitle)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_TobeStudiedProblemVEN.SetIsCheckProperty(true);
    }
    exports.gs_TobeStudiedProblemV_CheckPropertyNew = gs_TobeStudiedProblemV_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TobeStudiedProblemV_CheckProperty4Update(pobjgs_TobeStudiedProblemVEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.problemId) > 10) {
            throw new Error("(errid:Watl000062)字段[问题Id(problemId)]的长度不能超过10(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemId)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.topicId)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemContent) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.problemContent) > 5000) {
            throw new Error("(errid:Watl000062)字段[问题内容(problemContent)]的长度不能超过5000(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemContent)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.problemDate) > 20) {
            throw new Error("(errid:Watl000062)字段[问题日期(problemDate)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemDate)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.participant) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.participant) > 500) {
            throw new Error("(errid:Watl000062)字段[参与者(participant)]的长度不能超过500(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.participant)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.updDate)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.updUser)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.year) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.year) > 4) {
            throw new Error("(errid:Watl000062)字段[年(year)]的长度不能超过4(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.year)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.month) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.month) > 2) {
            throw new Error("(errid:Watl000062)字段[月(month)]的长度不能超过2(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.month)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.memo)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemTitle) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemVEN.problemTitle) > 1000) {
            throw new Error("(errid:Watl000062)字段[问题标题(problemTitle)]的长度不能超过1000(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemTitle)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_TobeStudiedProblemVEN.problemVId && undefined !== pobjgs_TobeStudiedProblemVEN.problemVId && jsString_js_1.tzDataType.isNumber(pobjgs_TobeStudiedProblemVEN.problemVId) === false) {
            throw new Error("(errid:Watl000063)字段[ProblemVId(problemVId)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemVId)], 非法，应该为数值型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemId) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemId && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemId) === false) {
            throw new Error("(errid:Watl000063)字段[问题Id(problemId)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemId)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.topicId) == false && undefined !== pobjgs_TobeStudiedProblemVEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_TobeStudiedProblemVEN.topicId)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if (null != pobjgs_TobeStudiedProblemVEN.isSubmit && undefined !== pobjgs_TobeStudiedProblemVEN.isSubmit && jsString_js_1.tzDataType.isBoolean(pobjgs_TobeStudiedProblemVEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_TobeStudiedProblemVEN.isSubmit)], 非法，应该为布尔型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemContent) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemContent && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemContent) === false) {
            throw new Error("(errid:Watl000063)字段[问题内容(problemContent)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemContent)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemDate) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemDate && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemDate) === false) {
            throw new Error("(errid:Watl000063)字段[问题日期(problemDate)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemDate)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.participant) == false && undefined !== pobjgs_TobeStudiedProblemVEN.participant && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.participant) === false) {
            throw new Error("(errid:Watl000063)字段[参与者(participant)]的值:[$(pobjgs_TobeStudiedProblemVEN.participant)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.updDate) == false && undefined !== pobjgs_TobeStudiedProblemVEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TobeStudiedProblemVEN.updDate)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.updUser) == false && undefined !== pobjgs_TobeStudiedProblemVEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TobeStudiedProblemVEN.updUser)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.year) == false && undefined !== pobjgs_TobeStudiedProblemVEN.year && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.year) === false) {
            throw new Error("(errid:Watl000063)字段[年(year)]的值:[$(pobjgs_TobeStudiedProblemVEN.year)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.month) == false && undefined !== pobjgs_TobeStudiedProblemVEN.month && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.month) === false) {
            throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjgs_TobeStudiedProblemVEN.month)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.memo) == false && undefined !== pobjgs_TobeStudiedProblemVEN.memo && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TobeStudiedProblemVEN.memo)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemVEN.problemTitle) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemTitle && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemTitle) === false) {
            throw new Error("(errid:Watl000063)字段[问题标题(problemTitle)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemTitle)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_TobeStudiedProblemVEN.problemVId
            || pobjgs_TobeStudiedProblemVEN.problemVId != null && pobjgs_TobeStudiedProblemVEN.problemVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[ProblemVId]不能为空(In 待研究问题历史版本表)!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_TobeStudiedProblemVEN.SetIsCheckProperty(true);
    }
    exports.gs_TobeStudiedProblemV_CheckProperty4Update = gs_TobeStudiedProblemV_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TobeStudiedProblemV_GetJSONStrByObj(pobjgs_TobeStudiedProblemVEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_TobeStudiedProblemVEN.sf_UpdFldSetStr = pobjgs_TobeStudiedProblemVEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_TobeStudiedProblemVEN);
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
    exports.gs_TobeStudiedProblemV_GetJSONStrByObj = gs_TobeStudiedProblemV_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_TobeStudiedProblemV_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_TobeStudiedProblemVObjLst = new Array();
        if (strJSON === "") {
            return arrgs_TobeStudiedProblemVObjLst;
        }
        try {
            arrgs_TobeStudiedProblemVObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_TobeStudiedProblemVObjLst;
        }
        return arrgs_TobeStudiedProblemVObjLst;
    }
    exports.gs_TobeStudiedProblemV_GetObjLstByJSONStr = gs_TobeStudiedProblemV_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_TobeStudiedProblemVObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_TobeStudiedProblemV_GetObjLstByJSONObjLst(arrgs_TobeStudiedProblemVObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_TobeStudiedProblemVObjLst = new Array();
        for (const objInFor of arrgs_TobeStudiedProblemVObjLstS) {
            const obj1 = gs_TobeStudiedProblemV_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_TobeStudiedProblemVObjLst.push(obj1);
        }
        return arrgs_TobeStudiedProblemVObjLst;
    }
    exports.gs_TobeStudiedProblemV_GetObjLstByJSONObjLst = gs_TobeStudiedProblemV_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TobeStudiedProblemV_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_TobeStudiedProblemVEN = new clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN();
        if (strJSON === "") {
            return pobjgs_TobeStudiedProblemVEN;
        }
        try {
            pobjgs_TobeStudiedProblemVEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_TobeStudiedProblemVEN;
        }
        return pobjgs_TobeStudiedProblemVEN;
    }
    exports.gs_TobeStudiedProblemV_GetObjByJSONStr = gs_TobeStudiedProblemV_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_TobeStudiedProblemV_GetCombineCondition(objgs_TobeStudiedProblemV_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemVId) == true) {
            const strComparisonOp_ProblemVId = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemVId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemVId, objgs_TobeStudiedProblemV_Cond.problemVId, strComparisonOp_ProblemVId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemId) == true) {
            const strComparisonOp_ProblemId = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemId, objgs_TobeStudiedProblemV_Cond.problemId, strComparisonOp_ProblemId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_TopicId, objgs_TobeStudiedProblemV_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_IsSubmit) == true) {
            if (objgs_TobeStudiedProblemV_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemContent) == true) {
            const strComparisonOp_ProblemContent = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemContent, objgs_TobeStudiedProblemV_Cond.problemContent, strComparisonOp_ProblemContent);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemDate) == true) {
            const strComparisonOp_ProblemDate = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemDate, objgs_TobeStudiedProblemV_Cond.problemDate, strComparisonOp_ProblemDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Participant) == true) {
            const strComparisonOp_Participant = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Participant];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Participant, objgs_TobeStudiedProblemV_Cond.participant, strComparisonOp_Participant);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_UpdDate, objgs_TobeStudiedProblemV_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_UpdUser, objgs_TobeStudiedProblemV_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Year) == true) {
            const strComparisonOp_Year = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Year];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Year, objgs_TobeStudiedProblemV_Cond.year, strComparisonOp_Year);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Month) == true) {
            const strComparisonOp_Month = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Month];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Month, objgs_TobeStudiedProblemV_Cond.month, strComparisonOp_Month);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_Memo, objgs_TobeStudiedProblemV_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemTitle) == true) {
            const strComparisonOp_ProblemTitle = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN.con_ProblemTitle, objgs_TobeStudiedProblemV_Cond.problemTitle, strComparisonOp_ProblemTitle);
        }
        return strWhereCond;
    }
    exports.gs_TobeStudiedProblemV_GetCombineCondition = gs_TobeStudiedProblemV_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_TobeStudiedProblemV(待研究问题历史版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngProblemVId: ProblemVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_TobeStudiedProblemV_GetUniCondStr_ProblemVId(objgs_TobeStudiedProblemVEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ProblemVId = '{0}'", objgs_TobeStudiedProblemVEN.problemVId);
        return strWhereCond;
    }
    exports.gs_TobeStudiedProblemV_GetUniCondStr_ProblemVId = gs_TobeStudiedProblemV_GetUniCondStr_ProblemVId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_TobeStudiedProblemV(待研究问题历史版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngProblemVId: ProblemVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_TobeStudiedProblemV_GetUniCondStr4Update_ProblemVId(objgs_TobeStudiedProblemVEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ProblemVId <> '{0}'", objgs_TobeStudiedProblemVEN.problemVId);
        strWhereCond += (0, clsString_js_1.Format)(" and ProblemVId = '{0}'", objgs_TobeStudiedProblemVEN.problemVId);
        return strWhereCond;
    }
    exports.gs_TobeStudiedProblemV_GetUniCondStr4Update_ProblemVId = gs_TobeStudiedProblemV_GetUniCondStr4Update_ProblemVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_TobeStudiedProblemVENS:源对象
     * @param objgs_TobeStudiedProblemVENT:目标对象
    */
    function gs_TobeStudiedProblemV_CopyObjTo(objgs_TobeStudiedProblemVENS, objgs_TobeStudiedProblemVENT) {
        objgs_TobeStudiedProblemVENT.problemVId = objgs_TobeStudiedProblemVENS.problemVId; //ProblemVId
        objgs_TobeStudiedProblemVENT.problemId = objgs_TobeStudiedProblemVENS.problemId; //问题Id
        objgs_TobeStudiedProblemVENT.topicId = objgs_TobeStudiedProblemVENS.topicId; //主题Id
        objgs_TobeStudiedProblemVENT.isSubmit = objgs_TobeStudiedProblemVENS.isSubmit; //是否提交
        objgs_TobeStudiedProblemVENT.problemContent = objgs_TobeStudiedProblemVENS.problemContent; //问题内容
        objgs_TobeStudiedProblemVENT.problemDate = objgs_TobeStudiedProblemVENS.problemDate; //问题日期
        objgs_TobeStudiedProblemVENT.participant = objgs_TobeStudiedProblemVENS.participant; //参与者
        objgs_TobeStudiedProblemVENT.updDate = objgs_TobeStudiedProblemVENS.updDate; //修改日期
        objgs_TobeStudiedProblemVENT.updUser = objgs_TobeStudiedProblemVENS.updUser; //修改人
        objgs_TobeStudiedProblemVENT.year = objgs_TobeStudiedProblemVENS.year; //年
        objgs_TobeStudiedProblemVENT.month = objgs_TobeStudiedProblemVENS.month; //月
        objgs_TobeStudiedProblemVENT.memo = objgs_TobeStudiedProblemVENS.memo; //备注
        objgs_TobeStudiedProblemVENT.problemTitle = objgs_TobeStudiedProblemVENS.problemTitle; //问题标题
        objgs_TobeStudiedProblemVENT.sf_UpdFldSetStr = objgs_TobeStudiedProblemVENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_TobeStudiedProblemV_CopyObjTo = gs_TobeStudiedProblemV_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_TobeStudiedProblemVENS:源对象
     * @param objgs_TobeStudiedProblemVENT:目标对象
    */
    function gs_TobeStudiedProblemV_GetObjFromJsonObj(objgs_TobeStudiedProblemVENS) {
        const objgs_TobeStudiedProblemVENT = new clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TobeStudiedProblemVENT, objgs_TobeStudiedProblemVENS);
        return objgs_TobeStudiedProblemVENT;
    }
    exports.gs_TobeStudiedProblemV_GetObjFromJsonObj = gs_TobeStudiedProblemV_GetObjFromJsonObj;
});
