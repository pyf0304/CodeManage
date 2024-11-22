/**
* 类名:clsgs_ResearchResultWApi
* 表名:gs_ResearchResult(01120780)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:47:06
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsgs_ResearchResultEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ResearchResult_GetObjFromJsonObj = exports.gs_ResearchResult_CopyObjTo = exports.gs_ResearchResult_GetUniCondStr4Update_TopicId_ResultTypeId_ResultName = exports.gs_ResearchResult_GetUniCondStr_TopicId_ResultTypeId_ResultName = exports.gs_ResearchResult_GetCombineCondition = exports.gs_ResearchResult_GetObjByJSONStr = exports.gs_ResearchResult_GetObjLstByJSONObjLst = exports.gs_ResearchResult_GetObjLstByJSONStr = exports.gs_ResearchResult_GetJSONStrByObj = exports.gs_ResearchResult_CheckProperty4Update = exports.gs_ResearchResult_CheckPropertyNew = exports.gs_ResearchResult_GetWebApiUrl = exports.gs_ResearchResult_GetMaxStrIdByPrefix = exports.gs_ResearchResult_GetMaxStrIdAsync = exports.gs_ResearchResult_GetRecCountByCondAsync = exports.gs_ResearchResult_IsExistAsync = exports.gs_ResearchResult_IsExist = exports.gs_ResearchResult_IsExistRecordAsync = exports.gs_ResearchResult_UpdateWithConditionAsync = exports.gs_ResearchResult_UpdateRecordAsync = exports.gs_ResearchResult_AddNewRecordWithReturnKey = exports.gs_ResearchResult_AddNewRecordWithReturnKeyAsync = exports.gs_ResearchResult_AddNewRecordWithMaxIdAsync = exports.gs_ResearchResult_AddNewRecordAsync = exports.gs_ResearchResult_Delgs_ResearchResultsByCondAsync = exports.gs_ResearchResult_Delgs_ResearchResultsAsync = exports.gs_ResearchResult_DelRecordAsync = exports.gs_ResearchResult_GetObjLstByPagerAsync = exports.gs_ResearchResult_GetObjLstByRange = exports.gs_ResearchResult_GetObjLstByRangeAsync = exports.gs_ResearchResult_GetTopObjLstAsync = exports.gs_ResearchResult_GetObjLstByResultIdLstAsync = exports.gs_ResearchResult_GetObjLstAsync = exports.gs_ResearchResult_GetFirstObjAsync = exports.gs_ResearchResult_GetFirstID = exports.gs_ResearchResult_GetFirstIDAsync = exports.gs_ResearchResult_FilterFunByKey = exports.gs_ResearchResult_SortFunByKey = exports.gs_ResearchResult_SortFun_Defa_2Fld = exports.gs_ResearchResult_SortFun_Defa = exports.gs_ResearchResult_GetObjByResultIdAsync = exports.gs_ResearchResult_ConstructorName = exports.gs_ResearchResult_Controller = void 0;
    /**
     * 研究成果(gs_ResearchResult)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_ResearchResultEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_ResearchResultEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_ResearchResult_Controller = "gs_ResearchResultApi";
    exports.gs_ResearchResult_ConstructorName = "gs_ResearchResult";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strResultId:关键字
    * @returns 对象
    **/
    async function gs_ResearchResult_GetObjByResultIdAsync(strResultId) {
        const strThisFuncName = "GetObjByResultIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strResultId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strResultId]不能为空！(In GetObjByResultIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strResultId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strResultId]的长度:[{0}]不正确！", strResultId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByResultId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strResultId": strResultId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_ResearchResult = gs_ResearchResult_GetObjFromJsonObj(returnObj);
                return objgs_ResearchResult;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetObjByResultIdAsync = gs_ResearchResult_GetObjByResultIdAsync;
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
    function gs_ResearchResult_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.resultId.localeCompare(b.resultId);
    }
    exports.gs_ResearchResult_SortFun_Defa = gs_ResearchResult_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ResearchResult_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.gs_ResearchResult_SortFun_Defa_2Fld = gs_ResearchResult_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ResearchResult_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultId:
                    return (a, b) => {
                        return a.resultId.localeCompare(b.resultId);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultTypeId:
                    return (a, b) => {
                        return a.resultTypeId.localeCompare(b.resultTypeId);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultName:
                    return (a, b) => {
                        return a.resultName.localeCompare(b.resultName);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultContent:
                    return (a, b) => {
                        return a.resultContent.localeCompare(b.resultContent);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Author:
                    return (a, b) => {
                        return a.author.localeCompare(b.author);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Division:
                    return (a, b) => {
                        return a.division.localeCompare(b.division);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchResult]中不存在！(in ${exports.gs_ResearchResult_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultId:
                    return (a, b) => {
                        return b.resultId.localeCompare(a.resultId);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultTypeId:
                    return (a, b) => {
                        return b.resultTypeId.localeCompare(a.resultTypeId);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultName:
                    return (a, b) => {
                        return b.resultName.localeCompare(a.resultName);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultContent:
                    return (a, b) => {
                        return b.resultContent.localeCompare(a.resultContent);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Author:
                    return (a, b) => {
                        return b.author.localeCompare(a.author);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Division:
                    return (a, b) => {
                        return b.division.localeCompare(a.division);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchResult]中不存在！(in ${exports.gs_ResearchResult_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_ResearchResult_SortFunByKey = gs_ResearchResult_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_ResearchResult_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultId:
                return (obj) => {
                    return obj.resultId === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultTypeId:
                return (obj) => {
                    return obj.resultTypeId === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultName:
                return (obj) => {
                    return obj.resultName === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultContent:
                return (obj) => {
                    return obj.resultContent === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Division:
                return (obj) => {
                    return obj.division === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchResult]中不存在！(in ${exports.gs_ResearchResult_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_ResearchResult_FilterFunByKey = gs_ResearchResult_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_ResearchResult_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetFirstIDAsync = gs_ResearchResult_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_ResearchResult_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetFirstID = gs_ResearchResult_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_ResearchResult_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_ResearchResult = gs_ResearchResult_GetObjFromJsonObj(returnObj);
                return objgs_ResearchResult;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetFirstObjAsync = gs_ResearchResult_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_ResearchResult_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetObjLstAsync = gs_ResearchResult_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrResultId:关键字列表
    * @returns 对象列表
    **/
    async function gs_ResearchResult_GetObjLstByResultIdLstAsync(arrResultId) {
        const strThisFuncName = "GetObjLstByResultIdLstAsync";
        const strAction = "GetObjLstByResultIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrResultId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetObjLstByResultIdLstAsync = gs_ResearchResult_GetObjLstByResultIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_ResearchResult_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetTopObjLstAsync = gs_ResearchResult_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_ResearchResult_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetObjLstByRangeAsync = gs_ResearchResult_GetObjLstByRangeAsync;
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
    async function gs_ResearchResult_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetObjLstByRange = gs_ResearchResult_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_ResearchResult_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetObjLstByPagerAsync = gs_ResearchResult_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strResultId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_ResearchResult_DelRecordAsync(strResultId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strResultId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strResultId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_DelRecordAsync = gs_ResearchResult_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrResultId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_ResearchResult_Delgs_ResearchResultsAsync(arrResultId) {
        const strThisFuncName = "Delgs_ResearchResultsAsync";
        const strAction = "Delgs_ResearchResults";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrResultId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_Delgs_ResearchResultsAsync = gs_ResearchResult_Delgs_ResearchResultsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_ResearchResult_Delgs_ResearchResultsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_ResearchResultsByCondAsync";
        const strAction = "Delgs_ResearchResultsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_Delgs_ResearchResultsByCondAsync = gs_ResearchResult_Delgs_ResearchResultsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_ResearchResultEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_ResearchResult_AddNewRecordAsync(objgs_ResearchResultEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_ResearchResultEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchResultEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_AddNewRecordAsync = gs_ResearchResult_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_ResearchResultEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_ResearchResult_AddNewRecordWithMaxIdAsync(objgs_ResearchResultEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchResultEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_AddNewRecordWithMaxIdAsync = gs_ResearchResult_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_ResearchResultEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_ResearchResult_AddNewRecordWithReturnKeyAsync(objgs_ResearchResultEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchResultEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_AddNewRecordWithReturnKeyAsync = gs_ResearchResult_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_ResearchResultEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_ResearchResult_AddNewRecordWithReturnKey(objgs_ResearchResultEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_ResearchResultEN.resultId === null || objgs_ResearchResultEN.resultId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchResultEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_AddNewRecordWithReturnKey = gs_ResearchResult_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_ResearchResultEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_ResearchResult_UpdateRecordAsync(objgs_ResearchResultEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_ResearchResultEN.sf_UpdFldSetStr === undefined || objgs_ResearchResultEN.sf_UpdFldSetStr === null || objgs_ResearchResultEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ResearchResultEN.resultId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchResultEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_UpdateRecordAsync = gs_ResearchResult_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_ResearchResultEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_ResearchResult_UpdateWithConditionAsync(objgs_ResearchResultEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_ResearchResultEN.sf_UpdFldSetStr === undefined || objgs_ResearchResultEN.sf_UpdFldSetStr === null || objgs_ResearchResultEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ResearchResultEN.resultId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        objgs_ResearchResultEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchResultEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_UpdateWithConditionAsync = gs_ResearchResult_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_ResearchResult_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_IsExistRecordAsync = gs_ResearchResult_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strResultId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_ResearchResult_IsExist(strResultId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ResultId": strResultId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_IsExist = gs_ResearchResult_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strResultId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_ResearchResult_IsExistAsync(strResultId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strResultId": strResultId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_IsExistAsync = gs_ResearchResult_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_ResearchResult_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetRecCountByCondAsync = gs_ResearchResult_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_ResearchResult_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetMaxStrIdAsync = gs_ResearchResult_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_ResearchResult_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResult_GetMaxStrIdByPrefix = gs_ResearchResult_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_ResearchResult_GetWebApiUrl(strController, strAction) {
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
    exports.gs_ResearchResult_GetWebApiUrl = gs_ResearchResult_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_ResearchResult_CheckPropertyNew(pobjgs_ResearchResultEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.resultId) > 10) {
            throw new Error("(errid:Watl000059)字段[成果Id(resultId)]的长度不能超过10(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.resultId)(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.topicId)(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.paperId)(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.resultTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[成果类型Id(resultTypeId)]的长度不能超过2(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.resultTypeId)(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.resultName) > 500) {
            throw new Error("(errid:Watl000059)字段[成果名称(resultName)]的长度不能超过500(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.resultName)(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.author) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.author) > 200) {
            throw new Error("(errid:Watl000059)字段[作者(author)]的长度不能超过200(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.author)(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.division) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.division) > 500) {
            throw new Error("(errid:Watl000059)字段[分工(division)]的长度不能超过500(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.division)(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.id_CurrEduCls)(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.updDate)(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.updUser)(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.memo)(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultId) == false && undefined !== pobjgs_ResearchResultEN.resultId && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.resultId) === false) {
            throw new Error("(errid:Watl000060)字段[成果Id(resultId)]的值:[$(pobjgs_ResearchResultEN.resultId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.topicId) == false && undefined !== pobjgs_ResearchResultEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_ResearchResultEN.topicId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.paperId) == false && undefined !== pobjgs_ResearchResultEN.paperId && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_ResearchResultEN.paperId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultTypeId) == false && undefined !== pobjgs_ResearchResultEN.resultTypeId && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.resultTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[成果类型Id(resultTypeId)]的值:[$(pobjgs_ResearchResultEN.resultTypeId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultName) == false && undefined !== pobjgs_ResearchResultEN.resultName && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.resultName) === false) {
            throw new Error("(errid:Watl000060)字段[成果名称(resultName)]的值:[$(pobjgs_ResearchResultEN.resultName)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultContent) == false && undefined !== pobjgs_ResearchResultEN.resultContent && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.resultContent) === false) {
            throw new Error("(errid:Watl000060)字段[成果内容(resultContent)]的值:[$(pobjgs_ResearchResultEN.resultContent)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.author) == false && undefined !== pobjgs_ResearchResultEN.author && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.author) === false) {
            throw new Error("(errid:Watl000060)字段[作者(author)]的值:[$(pobjgs_ResearchResultEN.author)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.division) == false && undefined !== pobjgs_ResearchResultEN.division && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.division) === false) {
            throw new Error("(errid:Watl000060)字段[分工(division)]的值:[$(pobjgs_ResearchResultEN.division)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if (null != pobjgs_ResearchResultEN.versionCount && undefined !== pobjgs_ResearchResultEN.versionCount && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultEN.versionCount) === false) {
            throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjgs_ResearchResultEN.versionCount)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if (null != pobjgs_ResearchResultEN.okCount && undefined !== pobjgs_ResearchResultEN.okCount && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultEN.okCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjgs_ResearchResultEN.okCount)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if (null != pobjgs_ResearchResultEN.appraiseCount && undefined !== pobjgs_ResearchResultEN.appraiseCount && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000060)字段[评论数(appraiseCount)]的值:[$(pobjgs_ResearchResultEN.appraiseCount)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if (null != pobjgs_ResearchResultEN.score && undefined !== pobjgs_ResearchResultEN.score && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjgs_ResearchResultEN.score)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if (null != pobjgs_ResearchResultEN.stuScore && undefined !== pobjgs_ResearchResultEN.stuScore && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultEN.stuScore) === false) {
            throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjgs_ResearchResultEN.stuScore)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if (null != pobjgs_ResearchResultEN.teaScore && undefined !== pobjgs_ResearchResultEN.teaScore && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultEN.teaScore) === false) {
            throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjgs_ResearchResultEN.teaScore)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.id_CurrEduCls) == false && undefined !== pobjgs_ResearchResultEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_ResearchResultEN.id_CurrEduCls)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.updDate) == false && undefined !== pobjgs_ResearchResultEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_ResearchResultEN.updDate)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.updUser) == false && undefined !== pobjgs_ResearchResultEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_ResearchResultEN.updUser)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.memo) == false && undefined !== pobjgs_ResearchResultEN.memo && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_ResearchResultEN.memo)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_ResearchResultEN.SetIsCheckProperty(true);
    }
    exports.gs_ResearchResult_CheckPropertyNew = gs_ResearchResult_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_ResearchResult_CheckProperty4Update(pobjgs_ResearchResultEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.resultId) > 10) {
            throw new Error("(errid:Watl000062)字段[成果Id(resultId)]的长度不能超过10(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.resultId)(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.topicId)(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.paperId)(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.resultTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[成果类型Id(resultTypeId)]的长度不能超过2(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.resultTypeId)(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.resultName) > 500) {
            throw new Error("(errid:Watl000062)字段[成果名称(resultName)]的长度不能超过500(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.resultName)(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.author) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.author) > 200) {
            throw new Error("(errid:Watl000062)字段[作者(author)]的长度不能超过200(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.author)(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.division) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.division) > 500) {
            throw new Error("(errid:Watl000062)字段[分工(division)]的长度不能超过500(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.division)(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.id_CurrEduCls)(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.updDate)(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.updUser)(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.memo)(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultId) == false && undefined !== pobjgs_ResearchResultEN.resultId && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.resultId) === false) {
            throw new Error("(errid:Watl000063)字段[成果Id(resultId)]的值:[$(pobjgs_ResearchResultEN.resultId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.topicId) == false && undefined !== pobjgs_ResearchResultEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_ResearchResultEN.topicId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.paperId) == false && undefined !== pobjgs_ResearchResultEN.paperId && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_ResearchResultEN.paperId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultTypeId) == false && undefined !== pobjgs_ResearchResultEN.resultTypeId && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.resultTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[成果类型Id(resultTypeId)]的值:[$(pobjgs_ResearchResultEN.resultTypeId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultName) == false && undefined !== pobjgs_ResearchResultEN.resultName && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.resultName) === false) {
            throw new Error("(errid:Watl000063)字段[成果名称(resultName)]的值:[$(pobjgs_ResearchResultEN.resultName)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultContent) == false && undefined !== pobjgs_ResearchResultEN.resultContent && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.resultContent) === false) {
            throw new Error("(errid:Watl000063)字段[成果内容(resultContent)]的值:[$(pobjgs_ResearchResultEN.resultContent)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.author) == false && undefined !== pobjgs_ResearchResultEN.author && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.author) === false) {
            throw new Error("(errid:Watl000063)字段[作者(author)]的值:[$(pobjgs_ResearchResultEN.author)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.division) == false && undefined !== pobjgs_ResearchResultEN.division && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.division) === false) {
            throw new Error("(errid:Watl000063)字段[分工(division)]的值:[$(pobjgs_ResearchResultEN.division)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if (null != pobjgs_ResearchResultEN.versionCount && undefined !== pobjgs_ResearchResultEN.versionCount && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultEN.versionCount) === false) {
            throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjgs_ResearchResultEN.versionCount)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if (null != pobjgs_ResearchResultEN.okCount && undefined !== pobjgs_ResearchResultEN.okCount && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultEN.okCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjgs_ResearchResultEN.okCount)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if (null != pobjgs_ResearchResultEN.appraiseCount && undefined !== pobjgs_ResearchResultEN.appraiseCount && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000063)字段[评论数(appraiseCount)]的值:[$(pobjgs_ResearchResultEN.appraiseCount)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if (null != pobjgs_ResearchResultEN.score && undefined !== pobjgs_ResearchResultEN.score && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjgs_ResearchResultEN.score)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if (null != pobjgs_ResearchResultEN.stuScore && undefined !== pobjgs_ResearchResultEN.stuScore && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultEN.stuScore) === false) {
            throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjgs_ResearchResultEN.stuScore)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if (null != pobjgs_ResearchResultEN.teaScore && undefined !== pobjgs_ResearchResultEN.teaScore && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultEN.teaScore) === false) {
            throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjgs_ResearchResultEN.teaScore)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.id_CurrEduCls) == false && undefined !== pobjgs_ResearchResultEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_ResearchResultEN.id_CurrEduCls)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.updDate) == false && undefined !== pobjgs_ResearchResultEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_ResearchResultEN.updDate)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.updUser) == false && undefined !== pobjgs_ResearchResultEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_ResearchResultEN.updUser)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.memo) == false && undefined !== pobjgs_ResearchResultEN.memo && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_ResearchResultEN.memo)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultEN.resultId) === true) {
            throw new Error("(errid:Watl000064)字段[成果Id]不能为空(In 研究成果)!(clsgs_ResearchResultBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_ResearchResultEN.SetIsCheckProperty(true);
    }
    exports.gs_ResearchResult_CheckProperty4Update = gs_ResearchResult_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_ResearchResult_GetJSONStrByObj(pobjgs_ResearchResultEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_ResearchResultEN.sf_UpdFldSetStr = pobjgs_ResearchResultEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_ResearchResultEN);
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
    exports.gs_ResearchResult_GetJSONStrByObj = gs_ResearchResult_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_ResearchResult_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_ResearchResultObjLst = new Array();
        if (strJSON === "") {
            return arrgs_ResearchResultObjLst;
        }
        try {
            arrgs_ResearchResultObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_ResearchResultObjLst;
        }
        return arrgs_ResearchResultObjLst;
    }
    exports.gs_ResearchResult_GetObjLstByJSONStr = gs_ResearchResult_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_ResearchResultObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_ResearchResult_GetObjLstByJSONObjLst(arrgs_ResearchResultObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_ResearchResultObjLst = new Array();
        for (const objInFor of arrgs_ResearchResultObjLstS) {
            const obj1 = gs_ResearchResult_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_ResearchResultObjLst.push(obj1);
        }
        return arrgs_ResearchResultObjLst;
    }
    exports.gs_ResearchResult_GetObjLstByJSONObjLst = gs_ResearchResult_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_ResearchResult_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_ResearchResultEN = new clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN();
        if (strJSON === "") {
            return pobjgs_ResearchResultEN;
        }
        try {
            pobjgs_ResearchResultEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_ResearchResultEN;
        }
        return pobjgs_ResearchResultEN;
    }
    exports.gs_ResearchResult_GetObjByJSONStr = gs_ResearchResult_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_ResearchResult_GetCombineCondition(objgs_ResearchResult_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultId) == true) {
            const strComparisonOp_ResultId = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultId, objgs_ResearchResult_Cond.resultId, strComparisonOp_ResultId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_TopicId, objgs_ResearchResult_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_PaperId, objgs_ResearchResult_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultTypeId) == true) {
            const strComparisonOp_ResultTypeId = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultTypeId, objgs_ResearchResult_Cond.resultTypeId, strComparisonOp_ResultTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultName) == true) {
            const strComparisonOp_ResultName = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_ResultName, objgs_ResearchResult_Cond.resultName, strComparisonOp_ResultName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Author) == true) {
            const strComparisonOp_Author = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Author, objgs_ResearchResult_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Division) == true) {
            const strComparisonOp_Division = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Division];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Division, objgs_ResearchResult_Cond.division, strComparisonOp_Division);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_VersionCount, objgs_ResearchResult_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_OkCount, objgs_ResearchResult_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_AppraiseCount, objgs_ResearchResult_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_score) == true) {
            const strComparisonOp_score = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_score, objgs_ResearchResult_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_StuScore, objgs_ResearchResult_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_TeaScore, objgs_ResearchResult_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_id_CurrEduCls, objgs_ResearchResult_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_UpdDate, objgs_ResearchResult_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_UpdUser, objgs_ResearchResult_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN.con_Memo, objgs_ResearchResult_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_ResearchResult_GetCombineCondition = gs_ResearchResult_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_ResearchResult(研究成果),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @param strResultTypeId: 成果类型Id(要求唯一的字段)
    * @param strResultName: 成果名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_ResearchResult_GetUniCondStr_TopicId_ResultTypeId_ResultName(objgs_ResearchResultEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and TopicId = '{0}'", objgs_ResearchResultEN.topicId);
        strWhereCond += (0, clsString_js_1.Format)(" and ResultTypeId = '{0}'", objgs_ResearchResultEN.resultTypeId);
        strWhereCond += (0, clsString_js_1.Format)(" and ResultName = '{0}'", objgs_ResearchResultEN.resultName);
        return strWhereCond;
    }
    exports.gs_ResearchResult_GetUniCondStr_TopicId_ResultTypeId_ResultName = gs_ResearchResult_GetUniCondStr_TopicId_ResultTypeId_ResultName;
    /**
    *获取唯一性条件串(Uniqueness)--gs_ResearchResult(研究成果),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @param strResultTypeId: 成果类型Id(要求唯一的字段)
    * @param strResultName: 成果名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_ResearchResult_GetUniCondStr4Update_TopicId_ResultTypeId_ResultName(objgs_ResearchResultEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ResultId <> '{0}'", objgs_ResearchResultEN.resultId);
        strWhereCond += (0, clsString_js_1.Format)(" and TopicId = '{0}'", objgs_ResearchResultEN.topicId);
        strWhereCond += (0, clsString_js_1.Format)(" and ResultTypeId = '{0}'", objgs_ResearchResultEN.resultTypeId);
        strWhereCond += (0, clsString_js_1.Format)(" and ResultName = '{0}'", objgs_ResearchResultEN.resultName);
        return strWhereCond;
    }
    exports.gs_ResearchResult_GetUniCondStr4Update_TopicId_ResultTypeId_ResultName = gs_ResearchResult_GetUniCondStr4Update_TopicId_ResultTypeId_ResultName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_ResearchResultENS:源对象
     * @param objgs_ResearchResultENT:目标对象
    */
    function gs_ResearchResult_CopyObjTo(objgs_ResearchResultENS, objgs_ResearchResultENT) {
        objgs_ResearchResultENT.resultId = objgs_ResearchResultENS.resultId; //成果Id
        objgs_ResearchResultENT.topicId = objgs_ResearchResultENS.topicId; //主题Id
        objgs_ResearchResultENT.paperId = objgs_ResearchResultENS.paperId; //论文Id
        objgs_ResearchResultENT.resultTypeId = objgs_ResearchResultENS.resultTypeId; //成果类型Id
        objgs_ResearchResultENT.resultName = objgs_ResearchResultENS.resultName; //成果名称
        objgs_ResearchResultENT.resultContent = objgs_ResearchResultENS.resultContent; //成果内容
        objgs_ResearchResultENT.author = objgs_ResearchResultENS.author; //作者
        objgs_ResearchResultENT.division = objgs_ResearchResultENS.division; //分工
        objgs_ResearchResultENT.versionCount = objgs_ResearchResultENS.versionCount; //版本统计
        objgs_ResearchResultENT.okCount = objgs_ResearchResultENS.okCount; //点赞统计
        objgs_ResearchResultENT.appraiseCount = objgs_ResearchResultENS.appraiseCount; //评论数
        objgs_ResearchResultENT.score = objgs_ResearchResultENS.score; //评分
        objgs_ResearchResultENT.stuScore = objgs_ResearchResultENS.stuScore; //学生平均分
        objgs_ResearchResultENT.teaScore = objgs_ResearchResultENS.teaScore; //教师评分
        objgs_ResearchResultENT.id_CurrEduCls = objgs_ResearchResultENS.id_CurrEduCls; //教学班流水号
        objgs_ResearchResultENT.updDate = objgs_ResearchResultENS.updDate; //修改日期
        objgs_ResearchResultENT.updUser = objgs_ResearchResultENS.updUser; //修改人
        objgs_ResearchResultENT.memo = objgs_ResearchResultENS.memo; //备注
        objgs_ResearchResultENT.sf_UpdFldSetStr = objgs_ResearchResultENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_ResearchResult_CopyObjTo = gs_ResearchResult_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_ResearchResultENS:源对象
     * @param objgs_ResearchResultENT:目标对象
    */
    function gs_ResearchResult_GetObjFromJsonObj(objgs_ResearchResultENS) {
        const objgs_ResearchResultENT = new clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_ResearchResultENT, objgs_ResearchResultENS);
        return objgs_ResearchResultENT;
    }
    exports.gs_ResearchResult_GetObjFromJsonObj = gs_ResearchResult_GetObjFromJsonObj;
});
