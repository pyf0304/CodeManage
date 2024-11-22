/**
* 类名:clsTopicObjectiveVerWApi
* 表名:TopicObjectiveVer(01120648)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:45:24
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsTopicObjectiveVerEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.TopicObjectiveVer_GetObjFromJsonObj = exports.TopicObjectiveVer_CopyObjTo = exports.TopicObjectiveVer_GetUniCondStr4Update_TopicObjectiveVId = exports.TopicObjectiveVer_GetUniCondStr_TopicObjectiveVId = exports.TopicObjectiveVer_GetCombineCondition = exports.TopicObjectiveVer_GetObjByJSONStr = exports.TopicObjectiveVer_GetObjLstByJSONObjLst = exports.TopicObjectiveVer_GetObjLstByJSONStr = exports.TopicObjectiveVer_GetJSONStrByObj = exports.TopicObjectiveVer_CheckProperty4Update = exports.TopicObjectiveVer_CheckPropertyNew = exports.TopicObjectiveVer_GetWebApiUrl = exports.TopicObjectiveVer_GetMaxStrIdByPrefix = exports.TopicObjectiveVer_GetRecCountByCondAsync = exports.TopicObjectiveVer_IsExistAsync = exports.TopicObjectiveVer_IsExist = exports.TopicObjectiveVer_IsExistRecordAsync = exports.TopicObjectiveVer_UpdateWithConditionAsync = exports.TopicObjectiveVer_UpdateRecordAsync = exports.TopicObjectiveVer_AddNewRecordWithReturnKey = exports.TopicObjectiveVer_AddNewRecordWithReturnKeyAsync = exports.TopicObjectiveVer_AddNewRecordAsync = exports.TopicObjectiveVer_DelTopicObjectiveVersByCondAsync = exports.TopicObjectiveVer_DelTopicObjectiveVersAsync = exports.TopicObjectiveVer_DelRecordAsync = exports.TopicObjectiveVer_GetObjLstByPagerAsync = exports.TopicObjectiveVer_GetObjLstByRange = exports.TopicObjectiveVer_GetObjLstByRangeAsync = exports.TopicObjectiveVer_GetTopObjLstAsync = exports.TopicObjectiveVer_GetObjLstByTopicObjectiveVIdLstAsync = exports.TopicObjectiveVer_GetObjLstAsync = exports.TopicObjectiveVer_GetFirstObjAsync = exports.TopicObjectiveVer_GetFirstID = exports.TopicObjectiveVer_GetFirstIDAsync = exports.TopicObjectiveVer_FilterFunByKey = exports.TopicObjectiveVer_SortFunByKey = exports.TopicObjectiveVer_SortFun_Defa_2Fld = exports.TopicObjectiveVer_SortFun_Defa = exports.TopicObjectiveVer_GetObjByTopicObjectiveVIdAsync = exports.topicObjectiveVer_ConstructorName = exports.topicObjectiveVer_Controller = void 0;
    /**
     * 主题客观版本(TopicObjectiveVer)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsTopicObjectiveVerEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsTopicObjectiveVerEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.topicObjectiveVer_Controller = "TopicObjectiveVerApi";
    exports.topicObjectiveVer_ConstructorName = "topicObjectiveVer";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngTopicObjectiveVId:关键字
    * @returns 对象
    **/
    async function TopicObjectiveVer_GetObjByTopicObjectiveVIdAsync(lngTopicObjectiveVId) {
        const strThisFuncName = "GetObjByTopicObjectiveVIdAsync";
        if (lngTopicObjectiveVId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngTopicObjectiveVId]不能为空！(In clsTopicObjectiveVerWApi.GetObjByTopicObjectiveVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTopicObjectiveVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngTopicObjectiveVId": lngTopicObjectiveVId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objTopicObjectiveVer = TopicObjectiveVer_GetObjFromJsonObj(returnObj);
                return objTopicObjectiveVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_GetObjByTopicObjectiveVIdAsync = TopicObjectiveVer_GetObjByTopicObjectiveVIdAsync;
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
    function TopicObjectiveVer_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.topicObjectiveVId - b.topicObjectiveVId;
    }
    exports.TopicObjectiveVer_SortFun_Defa = TopicObjectiveVer_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TopicObjectiveVer_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicObjectiveId == b.topicObjectiveId)
            return a.objectiveName.localeCompare(b.objectiveName);
        else
            return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
    }
    exports.TopicObjectiveVer_SortFun_Defa_2Fld = TopicObjectiveVer_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TopicObjectiveVer_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_TopicObjectiveVId:
                    return (a, b) => {
                        return a.topicObjectiveVId - b.topicObjectiveVId;
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveName:
                    return (a, b) => {
                        if (a.objectiveName == null)
                            return -1;
                        if (b.objectiveName == null)
                            return 1;
                        return a.objectiveName.localeCompare(b.objectiveName);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveContent:
                    return (a, b) => {
                        if (a.objectiveContent == null)
                            return -1;
                        if (b.objectiveContent == null)
                            return 1;
                        return a.objectiveContent.localeCompare(b.objectiveContent);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveType:
                    return (a, b) => {
                        if (a.objectiveType == null)
                            return -1;
                        if (b.objectiveType == null)
                            return 1;
                        return a.objectiveType.localeCompare(b.objectiveType);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_Conclusion:
                    return (a, b) => {
                        if (a.conclusion == null)
                            return -1;
                        if (b.conclusion == null)
                            return 1;
                        return a.conclusion.localeCompare(b.conclusion);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_SourceId:
                    return (a, b) => {
                        if (a.sourceId == null)
                            return -1;
                        if (b.sourceId == null)
                            return 1;
                        return a.sourceId.localeCompare(b.sourceId);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_PdfContent:
                    return (a, b) => {
                        if (a.pdfContent == null)
                            return -1;
                        if (b.pdfContent == null)
                            return 1;
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[TopicObjectiveVer]中不存在！(in ${exports.topicObjectiveVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_TopicObjectiveVId:
                    return (a, b) => {
                        return b.topicObjectiveVId - a.topicObjectiveVId;
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveName:
                    return (a, b) => {
                        if (b.objectiveName == null)
                            return -1;
                        if (a.objectiveName == null)
                            return 1;
                        return b.objectiveName.localeCompare(a.objectiveName);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveContent:
                    return (a, b) => {
                        if (b.objectiveContent == null)
                            return -1;
                        if (a.objectiveContent == null)
                            return 1;
                        return b.objectiveContent.localeCompare(a.objectiveContent);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveType:
                    return (a, b) => {
                        if (b.objectiveType == null)
                            return -1;
                        if (a.objectiveType == null)
                            return 1;
                        return b.objectiveType.localeCompare(a.objectiveType);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_Conclusion:
                    return (a, b) => {
                        if (b.conclusion == null)
                            return -1;
                        if (a.conclusion == null)
                            return 1;
                        return b.conclusion.localeCompare(a.conclusion);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_SourceId:
                    return (a, b) => {
                        if (b.sourceId == null)
                            return -1;
                        if (a.sourceId == null)
                            return 1;
                        return b.sourceId.localeCompare(a.sourceId);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_PdfContent:
                    return (a, b) => {
                        if (b.pdfContent == null)
                            return -1;
                        if (a.pdfContent == null)
                            return 1;
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[TopicObjectiveVer]中不存在！(in ${exports.topicObjectiveVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.TopicObjectiveVer_SortFunByKey = TopicObjectiveVer_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function TopicObjectiveVer_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_TopicObjectiveVId:
                return (obj) => {
                    return obj.topicObjectiveVId === value;
                };
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_TopicObjectiveId:
                return (obj) => {
                    return obj.topicObjectiveId === value;
                };
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveName:
                return (obj) => {
                    return obj.objectiveName === value;
                };
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveContent:
                return (obj) => {
                    return obj.objectiveContent === value;
                };
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveType:
                return (obj) => {
                    return obj.objectiveType === value;
                };
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_Conclusion:
                return (obj) => {
                    return obj.conclusion === value;
                };
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_SourceId:
                return (obj) => {
                    return obj.sourceId === value;
                };
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[TopicObjectiveVer]中不存在！(in ${exports.topicObjectiveVer_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.TopicObjectiveVer_FilterFunByKey = TopicObjectiveVer_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function TopicObjectiveVer_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_GetFirstIDAsync = TopicObjectiveVer_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function TopicObjectiveVer_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_GetFirstID = TopicObjectiveVer_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function TopicObjectiveVer_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
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
                const objTopicObjectiveVer = TopicObjectiveVer_GetObjFromJsonObj(returnObj);
                return objTopicObjectiveVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_GetFirstObjAsync = TopicObjectiveVer_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function TopicObjectiveVer_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjectiveVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_GetObjLstAsync = TopicObjectiveVer_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrTopicObjectiveVId:关键字列表
    * @returns 对象列表
    **/
    async function TopicObjectiveVer_GetObjLstByTopicObjectiveVIdLstAsync(arrTopicObjectiveVId) {
        const strThisFuncName = "GetObjLstByTopicObjectiveVIdLstAsync";
        const strAction = "GetObjLstByTopicObjectiveVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicObjectiveVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjectiveVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_GetObjLstByTopicObjectiveVIdLstAsync = TopicObjectiveVer_GetObjLstByTopicObjectiveVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function TopicObjectiveVer_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjectiveVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_GetTopObjLstAsync = TopicObjectiveVer_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function TopicObjectiveVer_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjectiveVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_GetObjLstByRangeAsync = TopicObjectiveVer_GetObjLstByRangeAsync;
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
    async function TopicObjectiveVer_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_GetObjLstByRange = TopicObjectiveVer_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function TopicObjectiveVer_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjectiveVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_GetObjLstByPagerAsync = TopicObjectiveVer_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngTopicObjectiveVId:关键字
    * @returns 获取删除的结果
    **/
    async function TopicObjectiveVer_DelRecordAsync(lngTopicObjectiveVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngTopicObjectiveVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_DelRecordAsync = TopicObjectiveVer_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrTopicObjectiveVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function TopicObjectiveVer_DelTopicObjectiveVersAsync(arrTopicObjectiveVId) {
        const strThisFuncName = "DelTopicObjectiveVersAsync";
        const strAction = "DelTopicObjectiveVers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicObjectiveVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_DelTopicObjectiveVersAsync = TopicObjectiveVer_DelTopicObjectiveVersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function TopicObjectiveVer_DelTopicObjectiveVersByCondAsync(strWhereCond) {
        const strThisFuncName = "DelTopicObjectiveVersByCondAsync";
        const strAction = "DelTopicObjectiveVersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_DelTopicObjectiveVersByCondAsync = TopicObjectiveVer_DelTopicObjectiveVersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objTopicObjectiveVerEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function TopicObjectiveVer_AddNewRecordAsync(objTopicObjectiveVerEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objTopicObjectiveVerEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_AddNewRecordAsync = TopicObjectiveVer_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objTopicObjectiveVerEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function TopicObjectiveVer_AddNewRecordWithReturnKeyAsync(objTopicObjectiveVerEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_AddNewRecordWithReturnKeyAsync = TopicObjectiveVer_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objTopicObjectiveVerEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function TopicObjectiveVer_AddNewRecordWithReturnKey(objTopicObjectiveVerEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objTopicObjectiveVerEN.topicObjectiveVId === null || objTopicObjectiveVerEN.topicObjectiveVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveVerEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_AddNewRecordWithReturnKey = TopicObjectiveVer_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objTopicObjectiveVerEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function TopicObjectiveVer_UpdateRecordAsync(objTopicObjectiveVerEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objTopicObjectiveVerEN.sf_UpdFldSetStr === undefined || objTopicObjectiveVerEN.sf_UpdFldSetStr === null || objTopicObjectiveVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicObjectiveVerEN.topicObjectiveVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_UpdateRecordAsync = TopicObjectiveVer_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objTopicObjectiveVerEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function TopicObjectiveVer_UpdateWithConditionAsync(objTopicObjectiveVerEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objTopicObjectiveVerEN.sf_UpdFldSetStr === undefined || objTopicObjectiveVerEN.sf_UpdFldSetStr === null || objTopicObjectiveVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicObjectiveVerEN.topicObjectiveVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        objTopicObjectiveVerEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_UpdateWithConditionAsync = TopicObjectiveVer_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function TopicObjectiveVer_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_IsExistRecordAsync = TopicObjectiveVer_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngTopicObjectiveVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function TopicObjectiveVer_IsExist(lngTopicObjectiveVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "TopicObjectiveVId": lngTopicObjectiveVId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_IsExist = TopicObjectiveVer_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngTopicObjectiveVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function TopicObjectiveVer_IsExistAsync(lngTopicObjectiveVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngTopicObjectiveVId": lngTopicObjectiveVId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_IsExistAsync = TopicObjectiveVer_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function TopicObjectiveVer_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_GetRecCountByCondAsync = TopicObjectiveVer_GetRecCountByCondAsync;
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
    async function TopicObjectiveVer_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveVer_GetMaxStrIdByPrefix = TopicObjectiveVer_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function TopicObjectiveVer_GetWebApiUrl(strController, strAction) {
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
    exports.TopicObjectiveVer_GetWebApiUrl = TopicObjectiveVer_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function TopicObjectiveVer_CheckPropertyNew(pobjTopicObjectiveVerEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.topicObjectiveId) === true) {
            throw new Error("(errid:Watl000058)字段[客观Id]不能为空(In 主题客观版本)!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.topicObjectiveId) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.topicObjectiveId) > 8) {
            throw new Error("(errid:Watl000059)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.topicObjectiveId)(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.objectiveName) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.objectiveName) > 500) {
            throw new Error("(errid:Watl000059)字段[客观名称(objectiveName)]的长度不能超过500(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.objectiveName)(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.objectiveType) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.objectiveType) > 2) {
            throw new Error("(errid:Watl000059)字段[客观类型(objectiveType)]的长度不能超过2(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.objectiveType)(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.sourceId) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.sourceId) > 10) {
            throw new Error("(errid:Watl000059)字段[来源Id(sourceId)]的长度不能超过10(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.sourceId)(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.updDate)(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.updUser)(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.id_CurrEduCls)(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.pdfContent)(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.memo)(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjTopicObjectiveVerEN.topicObjectiveVId && undefined !== pobjTopicObjectiveVerEN.topicObjectiveVId && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveVerEN.topicObjectiveVId) === false) {
            throw new Error("(errid:Watl000060)字段[主题客观版本Id(topicObjectiveVId)]的值:[$(pobjTopicObjectiveVerEN.topicObjectiveVId)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.topicObjectiveId) == false && undefined !== pobjTopicObjectiveVerEN.topicObjectiveId && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.topicObjectiveId) === false) {
            throw new Error("(errid:Watl000060)字段[客观Id(topicObjectiveId)]的值:[$(pobjTopicObjectiveVerEN.topicObjectiveId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.objectiveName) == false && undefined !== pobjTopicObjectiveVerEN.objectiveName && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.objectiveName) === false) {
            throw new Error("(errid:Watl000060)字段[客观名称(objectiveName)]的值:[$(pobjTopicObjectiveVerEN.objectiveName)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.objectiveContent) == false && undefined !== pobjTopicObjectiveVerEN.objectiveContent && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.objectiveContent) === false) {
            throw new Error("(errid:Watl000060)字段[客观内容(objectiveContent)]的值:[$(pobjTopicObjectiveVerEN.objectiveContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.objectiveType) == false && undefined !== pobjTopicObjectiveVerEN.objectiveType && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.objectiveType) === false) {
            throw new Error("(errid:Watl000060)字段[客观类型(objectiveType)]的值:[$(pobjTopicObjectiveVerEN.objectiveType)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.conclusion) == false && undefined !== pobjTopicObjectiveVerEN.conclusion && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.conclusion) === false) {
            throw new Error("(errid:Watl000060)字段[结论(conclusion)]的值:[$(pobjTopicObjectiveVerEN.conclusion)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.sourceId) == false && undefined !== pobjTopicObjectiveVerEN.sourceId && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.sourceId) === false) {
            throw new Error("(errid:Watl000060)字段[来源Id(sourceId)]的值:[$(pobjTopicObjectiveVerEN.sourceId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.updDate) == false && undefined !== pobjTopicObjectiveVerEN.updDate && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjTopicObjectiveVerEN.updDate)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.updUser) == false && undefined !== pobjTopicObjectiveVerEN.updUser && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjTopicObjectiveVerEN.updUser)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.id_CurrEduCls) == false && undefined !== pobjTopicObjectiveVerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjTopicObjectiveVerEN.id_CurrEduCls)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.pdfContent) == false && undefined !== pobjTopicObjectiveVerEN.pdfContent && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.pdfContent) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjTopicObjectiveVerEN.pdfContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if (null != pobjTopicObjectiveVerEN.pdfPageNum && undefined !== pobjTopicObjectiveVerEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveVerEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjTopicObjectiveVerEN.pdfPageNum)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.memo) == false && undefined !== pobjTopicObjectiveVerEN.memo && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjTopicObjectiveVerEN.memo)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjTopicObjectiveVerEN.SetIsCheckProperty(true);
    }
    exports.TopicObjectiveVer_CheckPropertyNew = TopicObjectiveVer_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function TopicObjectiveVer_CheckProperty4Update(pobjTopicObjectiveVerEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.topicObjectiveId) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.topicObjectiveId) > 8) {
            throw new Error("(errid:Watl000062)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.topicObjectiveId)(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.objectiveName) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.objectiveName) > 500) {
            throw new Error("(errid:Watl000062)字段[客观名称(objectiveName)]的长度不能超过500(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.objectiveName)(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.objectiveType) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.objectiveType) > 2) {
            throw new Error("(errid:Watl000062)字段[客观类型(objectiveType)]的长度不能超过2(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.objectiveType)(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.sourceId) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.sourceId) > 10) {
            throw new Error("(errid:Watl000062)字段[来源Id(sourceId)]的长度不能超过10(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.sourceId)(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.updDate)(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.updUser)(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.id_CurrEduCls)(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.pdfContent)(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.memo)(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjTopicObjectiveVerEN.topicObjectiveVId && undefined !== pobjTopicObjectiveVerEN.topicObjectiveVId && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveVerEN.topicObjectiveVId) === false) {
            throw new Error("(errid:Watl000063)字段[主题客观版本Id(topicObjectiveVId)]的值:[$(pobjTopicObjectiveVerEN.topicObjectiveVId)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.topicObjectiveId) == false && undefined !== pobjTopicObjectiveVerEN.topicObjectiveId && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.topicObjectiveId) === false) {
            throw new Error("(errid:Watl000063)字段[客观Id(topicObjectiveId)]的值:[$(pobjTopicObjectiveVerEN.topicObjectiveId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.objectiveName) == false && undefined !== pobjTopicObjectiveVerEN.objectiveName && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.objectiveName) === false) {
            throw new Error("(errid:Watl000063)字段[客观名称(objectiveName)]的值:[$(pobjTopicObjectiveVerEN.objectiveName)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.objectiveContent) == false && undefined !== pobjTopicObjectiveVerEN.objectiveContent && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.objectiveContent) === false) {
            throw new Error("(errid:Watl000063)字段[客观内容(objectiveContent)]的值:[$(pobjTopicObjectiveVerEN.objectiveContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.objectiveType) == false && undefined !== pobjTopicObjectiveVerEN.objectiveType && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.objectiveType) === false) {
            throw new Error("(errid:Watl000063)字段[客观类型(objectiveType)]的值:[$(pobjTopicObjectiveVerEN.objectiveType)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.conclusion) == false && undefined !== pobjTopicObjectiveVerEN.conclusion && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.conclusion) === false) {
            throw new Error("(errid:Watl000063)字段[结论(conclusion)]的值:[$(pobjTopicObjectiveVerEN.conclusion)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.sourceId) == false && undefined !== pobjTopicObjectiveVerEN.sourceId && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.sourceId) === false) {
            throw new Error("(errid:Watl000063)字段[来源Id(sourceId)]的值:[$(pobjTopicObjectiveVerEN.sourceId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.updDate) == false && undefined !== pobjTopicObjectiveVerEN.updDate && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjTopicObjectiveVerEN.updDate)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.updUser) == false && undefined !== pobjTopicObjectiveVerEN.updUser && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjTopicObjectiveVerEN.updUser)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.id_CurrEduCls) == false && undefined !== pobjTopicObjectiveVerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjTopicObjectiveVerEN.id_CurrEduCls)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.pdfContent) == false && undefined !== pobjTopicObjectiveVerEN.pdfContent && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.pdfContent) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjTopicObjectiveVerEN.pdfContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if (null != pobjTopicObjectiveVerEN.pdfPageNum && undefined !== pobjTopicObjectiveVerEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveVerEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjTopicObjectiveVerEN.pdfPageNum)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveVerEN.memo) == false && undefined !== pobjTopicObjectiveVerEN.memo && clsString_js_1.tzDataType.isString(pobjTopicObjectiveVerEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjTopicObjectiveVerEN.memo)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjTopicObjectiveVerEN.topicObjectiveVId
            || pobjTopicObjectiveVerEN.topicObjectiveVId != null && pobjTopicObjectiveVerEN.topicObjectiveVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[主题客观版本Id]不能为空(In 主题客观版本)!(clsTopicObjectiveVerBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjTopicObjectiveVerEN.SetIsCheckProperty(true);
    }
    exports.TopicObjectiveVer_CheckProperty4Update = TopicObjectiveVer_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function TopicObjectiveVer_GetJSONStrByObj(pobjTopicObjectiveVerEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjTopicObjectiveVerEN.sf_UpdFldSetStr = pobjTopicObjectiveVerEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjTopicObjectiveVerEN);
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
    exports.TopicObjectiveVer_GetJSONStrByObj = TopicObjectiveVer_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function TopicObjectiveVer_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrTopicObjectiveVerObjLst = new Array();
        if (strJSON === "") {
            return arrTopicObjectiveVerObjLst;
        }
        try {
            arrTopicObjectiveVerObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrTopicObjectiveVerObjLst;
        }
        return arrTopicObjectiveVerObjLst;
    }
    exports.TopicObjectiveVer_GetObjLstByJSONStr = TopicObjectiveVer_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrTopicObjectiveVerObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function TopicObjectiveVer_GetObjLstByJSONObjLst(arrTopicObjectiveVerObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrTopicObjectiveVerObjLst = new Array();
        for (const objInFor of arrTopicObjectiveVerObjLstS) {
            const obj1 = TopicObjectiveVer_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrTopicObjectiveVerObjLst.push(obj1);
        }
        return arrTopicObjectiveVerObjLst;
    }
    exports.TopicObjectiveVer_GetObjLstByJSONObjLst = TopicObjectiveVer_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function TopicObjectiveVer_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjTopicObjectiveVerEN = new clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN();
        if (strJSON === "") {
            return pobjTopicObjectiveVerEN;
        }
        try {
            pobjTopicObjectiveVerEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjTopicObjectiveVerEN;
        }
        return pobjTopicObjectiveVerEN;
    }
    exports.TopicObjectiveVer_GetObjByJSONStr = TopicObjectiveVer_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function TopicObjectiveVer_GetCombineCondition(objTopicObjectiveVer_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_TopicObjectiveVId) == true) {
            const strComparisonOp_TopicObjectiveVId = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_TopicObjectiveVId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_TopicObjectiveVId, objTopicObjectiveVer_Cond.topicObjectiveVId, strComparisonOp_TopicObjectiveVId);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_TopicObjectiveId) == true) {
            const strComparisonOp_TopicObjectiveId = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_TopicObjectiveId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_TopicObjectiveId, objTopicObjectiveVer_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveName) == true) {
            const strComparisonOp_ObjectiveName = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveName, objTopicObjectiveVer_Cond.objectiveName, strComparisonOp_ObjectiveName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveType) == true) {
            const strComparisonOp_ObjectiveType = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_ObjectiveType, objTopicObjectiveVer_Cond.objectiveType, strComparisonOp_ObjectiveType);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_SourceId) == true) {
            const strComparisonOp_SourceId = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_SourceId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_SourceId, objTopicObjectiveVer_Cond.sourceId, strComparisonOp_SourceId);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_UpdDate, objTopicObjectiveVer_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_UpdUser, objTopicObjectiveVer_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_id_CurrEduCls, objTopicObjectiveVer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_PdfContent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_PdfContent, objTopicObjectiveVer_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_PdfPageNum, objTopicObjectiveVer_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_Memo) == true) {
            const strComparisonOp_Memo = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN.con_Memo, objTopicObjectiveVer_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.TopicObjectiveVer_GetCombineCondition = TopicObjectiveVer_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--TopicObjectiveVer(主题客观版本),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngTopicObjectiveVId: 主题客观版本Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function TopicObjectiveVer_GetUniCondStr_TopicObjectiveVId(objTopicObjectiveVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVerEN.topicObjectiveVId);
        return strWhereCond;
    }
    exports.TopicObjectiveVer_GetUniCondStr_TopicObjectiveVId = TopicObjectiveVer_GetUniCondStr_TopicObjectiveVId;
    /**
    *获取唯一性条件串(Uniqueness)--TopicObjectiveVer(主题客观版本),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngTopicObjectiveVId: 主题客观版本Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function TopicObjectiveVer_GetUniCondStr4Update_TopicObjectiveVId(objTopicObjectiveVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and TopicObjectiveVId <> '{0}'", objTopicObjectiveVerEN.topicObjectiveVId);
        strWhereCond += (0, clsString_js_2.Format)(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVerEN.topicObjectiveVId);
        return strWhereCond;
    }
    exports.TopicObjectiveVer_GetUniCondStr4Update_TopicObjectiveVId = TopicObjectiveVer_GetUniCondStr4Update_TopicObjectiveVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objTopicObjectiveVerENS:源对象
     * @param objTopicObjectiveVerENT:目标对象
    */
    function TopicObjectiveVer_CopyObjTo(objTopicObjectiveVerENS, objTopicObjectiveVerENT) {
        objTopicObjectiveVerENT.topicObjectiveVId = objTopicObjectiveVerENS.topicObjectiveVId; //主题客观版本Id
        objTopicObjectiveVerENT.topicObjectiveId = objTopicObjectiveVerENS.topicObjectiveId; //客观Id
        objTopicObjectiveVerENT.objectiveName = objTopicObjectiveVerENS.objectiveName; //客观名称
        objTopicObjectiveVerENT.objectiveContent = objTopicObjectiveVerENS.objectiveContent; //客观内容
        objTopicObjectiveVerENT.objectiveType = objTopicObjectiveVerENS.objectiveType; //客观类型
        objTopicObjectiveVerENT.conclusion = objTopicObjectiveVerENS.conclusion; //结论
        objTopicObjectiveVerENT.sourceId = objTopicObjectiveVerENS.sourceId; //来源Id
        objTopicObjectiveVerENT.updDate = objTopicObjectiveVerENS.updDate; //修改日期
        objTopicObjectiveVerENT.updUser = objTopicObjectiveVerENS.updUser; //修改人
        objTopicObjectiveVerENT.id_CurrEduCls = objTopicObjectiveVerENS.id_CurrEduCls; //教学班流水号
        objTopicObjectiveVerENT.pdfContent = objTopicObjectiveVerENS.pdfContent; //Pdf内容
        objTopicObjectiveVerENT.pdfPageNum = objTopicObjectiveVerENS.pdfPageNum; //Pdf页码
        objTopicObjectiveVerENT.memo = objTopicObjectiveVerENS.memo; //备注
        objTopicObjectiveVerENT.sf_UpdFldSetStr = objTopicObjectiveVerENS.updFldString; //sf_UpdFldSetStr
    }
    exports.TopicObjectiveVer_CopyObjTo = TopicObjectiveVer_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objTopicObjectiveVerENS:源对象
     * @param objTopicObjectiveVerENT:目标对象
    */
    function TopicObjectiveVer_GetObjFromJsonObj(objTopicObjectiveVerENS) {
        const objTopicObjectiveVerENT = new clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objTopicObjectiveVerENT, objTopicObjectiveVerENS);
        return objTopicObjectiveVerENT;
    }
    exports.TopicObjectiveVer_GetObjFromJsonObj = TopicObjectiveVer_GetObjFromJsonObj;
});
