/**
* 类名:clsgs_TobeStudiedProblemWApi
* 表名:gs_TobeStudiedProblem(01120776)
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TobeStudiedProblem_GetObjFromJsonObj = exports.gs_TobeStudiedProblem_CopyObjTo = exports.gs_TobeStudiedProblem_GetUniCondStr4Update_ProblemId = exports.gs_TobeStudiedProblem_GetUniCondStr_ProblemId = exports.gs_TobeStudiedProblem_GetCombineCondition = exports.gs_TobeStudiedProblem_GetObjByJSONStr = exports.gs_TobeStudiedProblem_GetObjLstByJSONObjLst = exports.gs_TobeStudiedProblem_GetObjLstByJSONStr = exports.gs_TobeStudiedProblem_GetJSONStrByObj = exports.gs_TobeStudiedProblem_CheckProperty4Update = exports.gs_TobeStudiedProblem_CheckPropertyNew = exports.gs_TobeStudiedProblem_GetWebApiUrl = exports.gs_TobeStudiedProblem_GetMaxStrIdByPrefix = exports.gs_TobeStudiedProblem_GetMaxStrIdAsync = exports.gs_TobeStudiedProblem_GetRecCountByCondAsync = exports.gs_TobeStudiedProblem_IsExistAsync = exports.gs_TobeStudiedProblem_IsExist = exports.gs_TobeStudiedProblem_IsExistRecordAsync = exports.gs_TobeStudiedProblem_UpdateWithConditionAsync = exports.gs_TobeStudiedProblem_UpdateRecordAsync = exports.gs_TobeStudiedProblem_AddNewRecordWithReturnKey = exports.gs_TobeStudiedProblem_AddNewRecordWithReturnKeyAsync = exports.gs_TobeStudiedProblem_AddNewRecordWithMaxIdAsync = exports.gs_TobeStudiedProblem_AddNewRecordAsync = exports.gs_TobeStudiedProblem_Delgs_TobeStudiedProblemsByCondAsync = exports.gs_TobeStudiedProblem_Delgs_TobeStudiedProblemsAsync = exports.gs_TobeStudiedProblem_DelRecordAsync = exports.gs_TobeStudiedProblem_GetObjLstByPagerAsync = exports.gs_TobeStudiedProblem_GetObjLstByRange = exports.gs_TobeStudiedProblem_GetObjLstByRangeAsync = exports.gs_TobeStudiedProblem_GetTopObjLstAsync = exports.gs_TobeStudiedProblem_GetObjLstByProblemIdLstAsync = exports.gs_TobeStudiedProblem_GetObjLstAsync = exports.gs_TobeStudiedProblem_GetFirstObjAsync = exports.gs_TobeStudiedProblem_GetFirstID = exports.gs_TobeStudiedProblem_GetFirstIDAsync = exports.gs_TobeStudiedProblem_FilterFunByKey = exports.gs_TobeStudiedProblem_SortFunByKey = exports.gs_TobeStudiedProblem_SortFun_Defa_2Fld = exports.gs_TobeStudiedProblem_SortFun_Defa = exports.gs_TobeStudiedProblem_GetObjByProblemIdAsync = exports.gs_TobeStudiedProblem_ConstructorName = exports.gs_TobeStudiedProblem_Controller = void 0;
    /**
     * 待研究问题(gs_TobeStudiedProblem)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_TobeStudiedProblemEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_TobeStudiedProblem_Controller = "gs_TobeStudiedProblemApi";
    exports.gs_TobeStudiedProblem_ConstructorName = "gs_TobeStudiedProblem";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strProblemId:关键字
    * @returns 对象
    **/
    async function gs_TobeStudiedProblem_GetObjByProblemIdAsync(strProblemId) {
        const strThisFuncName = "GetObjByProblemIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strProblemId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strProblemId]不能为空！(In GetObjByProblemIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strProblemId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strProblemId]的长度:[{0}]不正确！", strProblemId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByProblemId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strProblemId": strProblemId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_TobeStudiedProblem = gs_TobeStudiedProblem_GetObjFromJsonObj(returnObj);
                return objgs_TobeStudiedProblem;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetObjByProblemIdAsync = gs_TobeStudiedProblem_GetObjByProblemIdAsync;
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
    function gs_TobeStudiedProblem_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.problemId.localeCompare(b.problemId);
    }
    exports.gs_TobeStudiedProblem_SortFun_Defa = gs_TobeStudiedProblem_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TobeStudiedProblem_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.problemTitle == b.problemTitle)
            return a.problemContent.localeCompare(b.problemContent);
        else
            return a.problemTitle.localeCompare(b.problemTitle);
    }
    exports.gs_TobeStudiedProblem_SortFun_Defa_2Fld = gs_TobeStudiedProblem_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TobeStudiedProblem_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemId:
                    return (a, b) => {
                        return a.problemId.localeCompare(b.problemId);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemTitle:
                    return (a, b) => {
                        return a.problemTitle.localeCompare(b.problemTitle);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemContent:
                    return (a, b) => {
                        return a.problemContent.localeCompare(b.problemContent);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemDate:
                    return (a, b) => {
                        return a.problemDate.localeCompare(b.problemDate);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Year:
                    return (a, b) => {
                        return a.year.localeCompare(b.year);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Month:
                    return (a, b) => {
                        return a.month.localeCompare(b.month);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Participant:
                    return (a, b) => {
                        return a.participant.localeCompare(b.participant);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblem]中不存在！(in ${exports.gs_TobeStudiedProblem_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemId:
                    return (a, b) => {
                        return b.problemId.localeCompare(a.problemId);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemTitle:
                    return (a, b) => {
                        return b.problemTitle.localeCompare(a.problemTitle);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemContent:
                    return (a, b) => {
                        return b.problemContent.localeCompare(a.problemContent);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemDate:
                    return (a, b) => {
                        return b.problemDate.localeCompare(a.problemDate);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Year:
                    return (a, b) => {
                        return b.year.localeCompare(a.year);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Month:
                    return (a, b) => {
                        return b.month.localeCompare(a.month);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Participant:
                    return (a, b) => {
                        return b.participant.localeCompare(a.participant);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblem]中不存在！(in ${exports.gs_TobeStudiedProblem_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_TobeStudiedProblem_SortFunByKey = gs_TobeStudiedProblem_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_TobeStudiedProblem_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemId:
                return (obj) => {
                    return obj.problemId === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemTitle:
                return (obj) => {
                    return obj.problemTitle === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemContent:
                return (obj) => {
                    return obj.problemContent === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemDate:
                return (obj) => {
                    return obj.problemDate === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Year:
                return (obj) => {
                    return obj.year === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Month:
                return (obj) => {
                    return obj.month === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Participant:
                return (obj) => {
                    return obj.participant === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblem]中不存在！(in ${exports.gs_TobeStudiedProblem_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_TobeStudiedProblem_FilterFunByKey = gs_TobeStudiedProblem_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TobeStudiedProblem_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetFirstIDAsync = gs_TobeStudiedProblem_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_TobeStudiedProblem_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetFirstID = gs_TobeStudiedProblem_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_TobeStudiedProblem_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_TobeStudiedProblem = gs_TobeStudiedProblem_GetObjFromJsonObj(returnObj);
                return objgs_TobeStudiedProblem;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetFirstObjAsync = gs_TobeStudiedProblem_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_TobeStudiedProblem_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetObjLstAsync = gs_TobeStudiedProblem_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrProblemId:关键字列表
    * @returns 对象列表
    **/
    async function gs_TobeStudiedProblem_GetObjLstByProblemIdLstAsync(arrProblemId) {
        const strThisFuncName = "GetObjLstByProblemIdLstAsync";
        const strAction = "GetObjLstByProblemIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrProblemId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetObjLstByProblemIdLstAsync = gs_TobeStudiedProblem_GetObjLstByProblemIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_TobeStudiedProblem_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetTopObjLstAsync = gs_TobeStudiedProblem_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TobeStudiedProblem_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetObjLstByRangeAsync = gs_TobeStudiedProblem_GetObjLstByRangeAsync;
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
    async function gs_TobeStudiedProblem_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetObjLstByRange = gs_TobeStudiedProblem_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TobeStudiedProblem_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetObjLstByPagerAsync = gs_TobeStudiedProblem_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strProblemId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_TobeStudiedProblem_DelRecordAsync(strProblemId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strProblemId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strProblemId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_DelRecordAsync = gs_TobeStudiedProblem_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrProblemId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_TobeStudiedProblem_Delgs_TobeStudiedProblemsAsync(arrProblemId) {
        const strThisFuncName = "Delgs_TobeStudiedProblemsAsync";
        const strAction = "Delgs_TobeStudiedProblems";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrProblemId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_Delgs_TobeStudiedProblemsAsync = gs_TobeStudiedProblem_Delgs_TobeStudiedProblemsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_TobeStudiedProblem_Delgs_TobeStudiedProblemsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_TobeStudiedProblemsByCondAsync";
        const strAction = "Delgs_TobeStudiedProblemsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_Delgs_TobeStudiedProblemsByCondAsync = gs_TobeStudiedProblem_Delgs_TobeStudiedProblemsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_TobeStudiedProblemEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_TobeStudiedProblem_AddNewRecordAsync(objgs_TobeStudiedProblemEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_TobeStudiedProblemEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_AddNewRecordAsync = gs_TobeStudiedProblem_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_TobeStudiedProblemEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_TobeStudiedProblem_AddNewRecordWithMaxIdAsync(objgs_TobeStudiedProblemEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_AddNewRecordWithMaxIdAsync = gs_TobeStudiedProblem_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_TobeStudiedProblemEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_TobeStudiedProblem_AddNewRecordWithReturnKeyAsync(objgs_TobeStudiedProblemEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_AddNewRecordWithReturnKeyAsync = gs_TobeStudiedProblem_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_TobeStudiedProblemEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_TobeStudiedProblem_AddNewRecordWithReturnKey(objgs_TobeStudiedProblemEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_TobeStudiedProblemEN.problemId === null || objgs_TobeStudiedProblemEN.problemId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_AddNewRecordWithReturnKey = gs_TobeStudiedProblem_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_TobeStudiedProblemEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_TobeStudiedProblem_UpdateRecordAsync(objgs_TobeStudiedProblemEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_TobeStudiedProblemEN.sf_UpdFldSetStr === undefined || objgs_TobeStudiedProblemEN.sf_UpdFldSetStr === null || objgs_TobeStudiedProblemEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TobeStudiedProblemEN.problemId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_UpdateRecordAsync = gs_TobeStudiedProblem_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_TobeStudiedProblemEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TobeStudiedProblem_UpdateWithConditionAsync(objgs_TobeStudiedProblemEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_TobeStudiedProblemEN.sf_UpdFldSetStr === undefined || objgs_TobeStudiedProblemEN.sf_UpdFldSetStr === null || objgs_TobeStudiedProblemEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TobeStudiedProblemEN.problemId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        objgs_TobeStudiedProblemEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_TobeStudiedProblemEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_UpdateWithConditionAsync = gs_TobeStudiedProblem_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_TobeStudiedProblem_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_IsExistRecordAsync = gs_TobeStudiedProblem_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strProblemId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_TobeStudiedProblem_IsExist(strProblemId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ProblemId": strProblemId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_IsExist = gs_TobeStudiedProblem_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strProblemId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_TobeStudiedProblem_IsExistAsync(strProblemId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strProblemId": strProblemId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_IsExistAsync = gs_TobeStudiedProblem_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_TobeStudiedProblem_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetRecCountByCondAsync = gs_TobeStudiedProblem_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_TobeStudiedProblem_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetMaxStrIdAsync = gs_TobeStudiedProblem_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_TobeStudiedProblem_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TobeStudiedProblem_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TobeStudiedProblem_GetMaxStrIdByPrefix = gs_TobeStudiedProblem_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_TobeStudiedProblem_GetWebApiUrl(strController, strAction) {
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
    exports.gs_TobeStudiedProblem_GetWebApiUrl = gs_TobeStudiedProblem_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TobeStudiedProblem_CheckPropertyNew(pobjgs_TobeStudiedProblemEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.problemId) > 10) {
            throw new Error("(errid:Watl000059)字段[问题Id(problemId)]的长度不能超过10(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.problemId)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemTitle) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.problemTitle) > 1000) {
            throw new Error("(errid:Watl000059)字段[问题标题(problemTitle)]的长度不能超过1000(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.problemTitle)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.topicId)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.problemDate) > 20) {
            throw new Error("(errid:Watl000059)字段[问题日期(problemDate)]的长度不能超过20(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.problemDate)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.updDate)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.updUser)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.year) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.year) > 4) {
            throw new Error("(errid:Watl000059)字段[年(year)]的长度不能超过4(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.year)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.month) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.month) > 2) {
            throw new Error("(errid:Watl000059)字段[月(month)]的长度不能超过2(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.month)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.participant) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.participant) > 500) {
            throw new Error("(errid:Watl000059)字段[参与者(participant)]的长度不能超过500(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.participant)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.memo)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.id_CurrEduCls)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemId) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemId && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemId) === false) {
            throw new Error("(errid:Watl000060)字段[问题Id(problemId)]的值:[$(pobjgs_TobeStudiedProblemEN.problemId)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemTitle) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemTitle && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemTitle) === false) {
            throw new Error("(errid:Watl000060)字段[问题标题(problemTitle)]的值:[$(pobjgs_TobeStudiedProblemEN.problemTitle)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemContent) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemContent && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemContent) === false) {
            throw new Error("(errid:Watl000060)字段[问题内容(problemContent)]的值:[$(pobjgs_TobeStudiedProblemEN.problemContent)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.topicId) == false && undefined !== pobjgs_TobeStudiedProblemEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_TobeStudiedProblemEN.topicId)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if (null != pobjgs_TobeStudiedProblemEN.isSubmit && undefined !== pobjgs_TobeStudiedProblemEN.isSubmit && jsString_js_1.tzDataType.isBoolean(pobjgs_TobeStudiedProblemEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_TobeStudiedProblemEN.isSubmit)], 非法，应该为布尔型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemDate) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemDate && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemDate) === false) {
            throw new Error("(errid:Watl000060)字段[问题日期(problemDate)]的值:[$(pobjgs_TobeStudiedProblemEN.problemDate)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.updDate) == false && undefined !== pobjgs_TobeStudiedProblemEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TobeStudiedProblemEN.updDate)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.updUser) == false && undefined !== pobjgs_TobeStudiedProblemEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TobeStudiedProblemEN.updUser)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.year) == false && undefined !== pobjgs_TobeStudiedProblemEN.year && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.year) === false) {
            throw new Error("(errid:Watl000060)字段[年(year)]的值:[$(pobjgs_TobeStudiedProblemEN.year)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.month) == false && undefined !== pobjgs_TobeStudiedProblemEN.month && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.month) === false) {
            throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjgs_TobeStudiedProblemEN.month)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if (null != pobjgs_TobeStudiedProblemEN.versionCount && undefined !== pobjgs_TobeStudiedProblemEN.versionCount && jsString_js_1.tzDataType.isNumber(pobjgs_TobeStudiedProblemEN.versionCount) === false) {
            throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjgs_TobeStudiedProblemEN.versionCount)], 非法，应该为数值型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.participant) == false && undefined !== pobjgs_TobeStudiedProblemEN.participant && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.participant) === false) {
            throw new Error("(errid:Watl000060)字段[参与者(participant)]的值:[$(pobjgs_TobeStudiedProblemEN.participant)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.memo) == false && undefined !== pobjgs_TobeStudiedProblemEN.memo && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TobeStudiedProblemEN.memo)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) == false && undefined !== pobjgs_TobeStudiedProblemEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TobeStudiedProblemEN.id_CurrEduCls)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_TobeStudiedProblemEN.SetIsCheckProperty(true);
    }
    exports.gs_TobeStudiedProblem_CheckPropertyNew = gs_TobeStudiedProblem_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TobeStudiedProblem_CheckProperty4Update(pobjgs_TobeStudiedProblemEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.problemId) > 10) {
            throw new Error("(errid:Watl000062)字段[问题Id(problemId)]的长度不能超过10(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.problemId)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemTitle) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.problemTitle) > 1000) {
            throw new Error("(errid:Watl000062)字段[问题标题(problemTitle)]的长度不能超过1000(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.problemTitle)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.topicId)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.problemDate) > 20) {
            throw new Error("(errid:Watl000062)字段[问题日期(problemDate)]的长度不能超过20(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.problemDate)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.updDate)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.updUser)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.year) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.year) > 4) {
            throw new Error("(errid:Watl000062)字段[年(year)]的长度不能超过4(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.year)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.month) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.month) > 2) {
            throw new Error("(errid:Watl000062)字段[月(month)]的长度不能超过2(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.month)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.participant) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.participant) > 500) {
            throw new Error("(errid:Watl000062)字段[参与者(participant)]的长度不能超过500(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.participant)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.memo)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.id_CurrEduCls)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemId) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemId && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemId) === false) {
            throw new Error("(errid:Watl000063)字段[问题Id(problemId)]的值:[$(pobjgs_TobeStudiedProblemEN.problemId)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemTitle) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemTitle && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemTitle) === false) {
            throw new Error("(errid:Watl000063)字段[问题标题(problemTitle)]的值:[$(pobjgs_TobeStudiedProblemEN.problemTitle)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemContent) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemContent && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemContent) === false) {
            throw new Error("(errid:Watl000063)字段[问题内容(problemContent)]的值:[$(pobjgs_TobeStudiedProblemEN.problemContent)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.topicId) == false && undefined !== pobjgs_TobeStudiedProblemEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_TobeStudiedProblemEN.topicId)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if (null != pobjgs_TobeStudiedProblemEN.isSubmit && undefined !== pobjgs_TobeStudiedProblemEN.isSubmit && jsString_js_1.tzDataType.isBoolean(pobjgs_TobeStudiedProblemEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_TobeStudiedProblemEN.isSubmit)], 非法，应该为布尔型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemDate) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemDate && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemDate) === false) {
            throw new Error("(errid:Watl000063)字段[问题日期(problemDate)]的值:[$(pobjgs_TobeStudiedProblemEN.problemDate)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.updDate) == false && undefined !== pobjgs_TobeStudiedProblemEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TobeStudiedProblemEN.updDate)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.updUser) == false && undefined !== pobjgs_TobeStudiedProblemEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TobeStudiedProblemEN.updUser)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.year) == false && undefined !== pobjgs_TobeStudiedProblemEN.year && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.year) === false) {
            throw new Error("(errid:Watl000063)字段[年(year)]的值:[$(pobjgs_TobeStudiedProblemEN.year)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.month) == false && undefined !== pobjgs_TobeStudiedProblemEN.month && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.month) === false) {
            throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjgs_TobeStudiedProblemEN.month)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if (null != pobjgs_TobeStudiedProblemEN.versionCount && undefined !== pobjgs_TobeStudiedProblemEN.versionCount && jsString_js_1.tzDataType.isNumber(pobjgs_TobeStudiedProblemEN.versionCount) === false) {
            throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjgs_TobeStudiedProblemEN.versionCount)], 非法，应该为数值型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.participant) == false && undefined !== pobjgs_TobeStudiedProblemEN.participant && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.participant) === false) {
            throw new Error("(errid:Watl000063)字段[参与者(participant)]的值:[$(pobjgs_TobeStudiedProblemEN.participant)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.memo) == false && undefined !== pobjgs_TobeStudiedProblemEN.memo && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TobeStudiedProblemEN.memo)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) == false && undefined !== pobjgs_TobeStudiedProblemEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TobeStudiedProblemEN.id_CurrEduCls)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TobeStudiedProblemEN.problemId) === true) {
            throw new Error("(errid:Watl000064)字段[问题Id]不能为空(In 待研究问题)!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_TobeStudiedProblemEN.SetIsCheckProperty(true);
    }
    exports.gs_TobeStudiedProblem_CheckProperty4Update = gs_TobeStudiedProblem_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TobeStudiedProblem_GetJSONStrByObj(pobjgs_TobeStudiedProblemEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_TobeStudiedProblemEN.sf_UpdFldSetStr = pobjgs_TobeStudiedProblemEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_TobeStudiedProblemEN);
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
    exports.gs_TobeStudiedProblem_GetJSONStrByObj = gs_TobeStudiedProblem_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_TobeStudiedProblem_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_TobeStudiedProblemObjLst = new Array();
        if (strJSON === "") {
            return arrgs_TobeStudiedProblemObjLst;
        }
        try {
            arrgs_TobeStudiedProblemObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_TobeStudiedProblemObjLst;
        }
        return arrgs_TobeStudiedProblemObjLst;
    }
    exports.gs_TobeStudiedProblem_GetObjLstByJSONStr = gs_TobeStudiedProblem_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_TobeStudiedProblemObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_TobeStudiedProblem_GetObjLstByJSONObjLst(arrgs_TobeStudiedProblemObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_TobeStudiedProblemObjLst = new Array();
        for (const objInFor of arrgs_TobeStudiedProblemObjLstS) {
            const obj1 = gs_TobeStudiedProblem_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_TobeStudiedProblemObjLst.push(obj1);
        }
        return arrgs_TobeStudiedProblemObjLst;
    }
    exports.gs_TobeStudiedProblem_GetObjLstByJSONObjLst = gs_TobeStudiedProblem_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TobeStudiedProblem_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN();
        if (strJSON === "") {
            return pobjgs_TobeStudiedProblemEN;
        }
        try {
            pobjgs_TobeStudiedProblemEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_TobeStudiedProblemEN;
        }
        return pobjgs_TobeStudiedProblemEN;
    }
    exports.gs_TobeStudiedProblem_GetObjByJSONStr = gs_TobeStudiedProblem_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_TobeStudiedProblem_GetCombineCondition(objgs_TobeStudiedProblem_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemId) == true) {
            const strComparisonOp_ProblemId = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemId, objgs_TobeStudiedProblem_Cond.problemId, strComparisonOp_ProblemId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemTitle) == true) {
            const strComparisonOp_ProblemTitle = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemTitle, objgs_TobeStudiedProblem_Cond.problemTitle, strComparisonOp_ProblemTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_TopicId, objgs_TobeStudiedProblem_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_IsSubmit) == true) {
            if (objgs_TobeStudiedProblem_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemDate) == true) {
            const strComparisonOp_ProblemDate = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_ProblemDate, objgs_TobeStudiedProblem_Cond.problemDate, strComparisonOp_ProblemDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_UpdDate, objgs_TobeStudiedProblem_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_UpdUser, objgs_TobeStudiedProblem_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Year) == true) {
            const strComparisonOp_Year = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Year];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Year, objgs_TobeStudiedProblem_Cond.year, strComparisonOp_Year);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Month) == true) {
            const strComparisonOp_Month = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Month];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Month, objgs_TobeStudiedProblem_Cond.month, strComparisonOp_Month);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_VersionCount, objgs_TobeStudiedProblem_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Participant) == true) {
            const strComparisonOp_Participant = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Participant];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Participant, objgs_TobeStudiedProblem_Cond.participant, strComparisonOp_Participant);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_Memo, objgs_TobeStudiedProblem_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.con_id_CurrEduCls, objgs_TobeStudiedProblem_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.gs_TobeStudiedProblem_GetCombineCondition = gs_TobeStudiedProblem_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_TobeStudiedProblem(待研究问题),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strProblemId: 问题Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_TobeStudiedProblem_GetUniCondStr_ProblemId(objgs_TobeStudiedProblemEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ProblemId = '{0}'", objgs_TobeStudiedProblemEN.problemId);
        return strWhereCond;
    }
    exports.gs_TobeStudiedProblem_GetUniCondStr_ProblemId = gs_TobeStudiedProblem_GetUniCondStr_ProblemId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_TobeStudiedProblem(待研究问题),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strProblemId: 问题Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_TobeStudiedProblem_GetUniCondStr4Update_ProblemId(objgs_TobeStudiedProblemEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ProblemId <> '{0}'", objgs_TobeStudiedProblemEN.problemId);
        strWhereCond += (0, clsString_js_1.Format)(" and ProblemId = '{0}'", objgs_TobeStudiedProblemEN.problemId);
        return strWhereCond;
    }
    exports.gs_TobeStudiedProblem_GetUniCondStr4Update_ProblemId = gs_TobeStudiedProblem_GetUniCondStr4Update_ProblemId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_TobeStudiedProblemENS:源对象
     * @param objgs_TobeStudiedProblemENT:目标对象
    */
    function gs_TobeStudiedProblem_CopyObjTo(objgs_TobeStudiedProblemENS, objgs_TobeStudiedProblemENT) {
        objgs_TobeStudiedProblemENT.problemId = objgs_TobeStudiedProblemENS.problemId; //问题Id
        objgs_TobeStudiedProblemENT.problemTitle = objgs_TobeStudiedProblemENS.problemTitle; //问题标题
        objgs_TobeStudiedProblemENT.problemContent = objgs_TobeStudiedProblemENS.problemContent; //问题内容
        objgs_TobeStudiedProblemENT.topicId = objgs_TobeStudiedProblemENS.topicId; //主题Id
        objgs_TobeStudiedProblemENT.isSubmit = objgs_TobeStudiedProblemENS.isSubmit; //是否提交
        objgs_TobeStudiedProblemENT.problemDate = objgs_TobeStudiedProblemENS.problemDate; //问题日期
        objgs_TobeStudiedProblemENT.updDate = objgs_TobeStudiedProblemENS.updDate; //修改日期
        objgs_TobeStudiedProblemENT.updUser = objgs_TobeStudiedProblemENS.updUser; //修改人
        objgs_TobeStudiedProblemENT.year = objgs_TobeStudiedProblemENS.year; //年
        objgs_TobeStudiedProblemENT.month = objgs_TobeStudiedProblemENS.month; //月
        objgs_TobeStudiedProblemENT.versionCount = objgs_TobeStudiedProblemENS.versionCount; //版本统计
        objgs_TobeStudiedProblemENT.participant = objgs_TobeStudiedProblemENS.participant; //参与者
        objgs_TobeStudiedProblemENT.memo = objgs_TobeStudiedProblemENS.memo; //备注
        objgs_TobeStudiedProblemENT.id_CurrEduCls = objgs_TobeStudiedProblemENS.id_CurrEduCls; //教学班流水号
        objgs_TobeStudiedProblemENT.sf_UpdFldSetStr = objgs_TobeStudiedProblemENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_TobeStudiedProblem_CopyObjTo = gs_TobeStudiedProblem_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_TobeStudiedProblemENS:源对象
     * @param objgs_TobeStudiedProblemENT:目标对象
    */
    function gs_TobeStudiedProblem_GetObjFromJsonObj(objgs_TobeStudiedProblemENS) {
        const objgs_TobeStudiedProblemENT = new clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TobeStudiedProblemENT, objgs_TobeStudiedProblemENS);
        return objgs_TobeStudiedProblemENT;
    }
    exports.gs_TobeStudiedProblem_GetObjFromJsonObj = gs_TobeStudiedProblem_GetObjFromJsonObj;
});
