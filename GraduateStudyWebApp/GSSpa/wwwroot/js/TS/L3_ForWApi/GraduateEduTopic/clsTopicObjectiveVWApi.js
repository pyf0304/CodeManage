/**
* 类名:clsTopicObjectiveVWApi
* 表名:TopicObjectiveV(01120648)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:59
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsTopicObjectiveVEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.TopicObjectiveV_GetObjFromJsonObj = exports.TopicObjectiveV_CopyObjTo = exports.TopicObjectiveV_GetUniCondStr4Update_TopicObjectiveVId = exports.TopicObjectiveV_GetUniCondStr_TopicObjectiveVId = exports.TopicObjectiveV_GetCombineCondition = exports.TopicObjectiveV_GetObjByJSONStr = exports.TopicObjectiveV_GetObjLstByJSONObjLst = exports.TopicObjectiveV_GetObjLstByJSONStr = exports.TopicObjectiveV_GetJSONStrByObj = exports.TopicObjectiveV_CheckProperty4Update = exports.TopicObjectiveV_CheckPropertyNew = exports.TopicObjectiveV_GetWebApiUrl = exports.TopicObjectiveV_GetMaxStrIdByPrefix = exports.TopicObjectiveV_GetRecCountByCondAsync = exports.TopicObjectiveV_IsExistAsync = exports.TopicObjectiveV_IsExist = exports.TopicObjectiveV_IsExistRecordAsync = exports.TopicObjectiveV_UpdateWithConditionAsync = exports.TopicObjectiveV_UpdateRecordAsync = exports.TopicObjectiveV_AddNewRecordWithReturnKey = exports.TopicObjectiveV_AddNewRecordWithReturnKeyAsync = exports.TopicObjectiveV_AddNewRecordAsync = exports.TopicObjectiveV_DelTopicObjectiveVsByCondAsync = exports.TopicObjectiveV_DelTopicObjectiveVsAsync = exports.TopicObjectiveV_DelRecordAsync = exports.TopicObjectiveV_GetObjLstByPagerAsync = exports.TopicObjectiveV_GetObjLstByRange = exports.TopicObjectiveV_GetObjLstByRangeAsync = exports.TopicObjectiveV_GetTopObjLstAsync = exports.TopicObjectiveV_GetObjLstByTopicObjectiveVIdLstAsync = exports.TopicObjectiveV_GetObjLstAsync = exports.TopicObjectiveV_GetFirstObjAsync = exports.TopicObjectiveV_GetFirstID = exports.TopicObjectiveV_GetFirstIDAsync = exports.TopicObjectiveV_FilterFunByKey = exports.TopicObjectiveV_SortFunByKey = exports.TopicObjectiveV_SortFun_Defa_2Fld = exports.TopicObjectiveV_SortFun_Defa = exports.TopicObjectiveV_GetObjByTopicObjectiveVIdAsync = exports.topicObjectiveV_ConstructorName = exports.topicObjectiveV_Controller = void 0;
    /**
     * 主题客观版本(TopicObjectiveV)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsTopicObjectiveVEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsTopicObjectiveVEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.topicObjectiveV_Controller = "TopicObjectiveVApi";
    exports.topicObjectiveV_ConstructorName = "topicObjectiveV";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngTopicObjectiveVId:关键字
    * @returns 对象
    **/
    async function TopicObjectiveV_GetObjByTopicObjectiveVIdAsync(lngTopicObjectiveVId) {
        const strThisFuncName = "GetObjByTopicObjectiveVIdAsync";
        if (lngTopicObjectiveVId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngTopicObjectiveVId]不能为空！(In GetObjByTopicObjectiveVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTopicObjectiveVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjectiveV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objTopicObjectiveV = TopicObjectiveV_GetObjFromJsonObj(returnObj);
                return objTopicObjectiveV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_GetObjByTopicObjectiveVIdAsync = TopicObjectiveV_GetObjByTopicObjectiveVIdAsync;
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
    function TopicObjectiveV_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.topicObjectiveVId - b.topicObjectiveVId;
    }
    exports.TopicObjectiveV_SortFun_Defa = TopicObjectiveV_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TopicObjectiveV_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicObjectiveId == b.topicObjectiveId)
            return a.objectiveName.localeCompare(b.objectiveName);
        else
            return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
    }
    exports.TopicObjectiveV_SortFun_Defa_2Fld = TopicObjectiveV_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TopicObjectiveV_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_TopicObjectiveVId:
                    return (a, b) => {
                        return a.topicObjectiveVId - b.topicObjectiveVId;
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveName:
                    return (a, b) => {
                        return a.objectiveName.localeCompare(b.objectiveName);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveContent:
                    return (a, b) => {
                        return a.objectiveContent.localeCompare(b.objectiveContent);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveType:
                    return (a, b) => {
                        return a.objectiveType.localeCompare(b.objectiveType);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_Conclusion:
                    return (a, b) => {
                        return a.conclusion.localeCompare(b.conclusion);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_SourceId:
                    return (a, b) => {
                        return a.sourceId.localeCompare(b.sourceId);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_PdfContent:
                    return (a, b) => {
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[TopicObjectiveV]中不存在！(in ${exports.topicObjectiveV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_TopicObjectiveVId:
                    return (a, b) => {
                        return b.topicObjectiveVId - a.topicObjectiveVId;
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveName:
                    return (a, b) => {
                        return b.objectiveName.localeCompare(a.objectiveName);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveContent:
                    return (a, b) => {
                        return b.objectiveContent.localeCompare(a.objectiveContent);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveType:
                    return (a, b) => {
                        return b.objectiveType.localeCompare(a.objectiveType);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_Conclusion:
                    return (a, b) => {
                        return b.conclusion.localeCompare(a.conclusion);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_SourceId:
                    return (a, b) => {
                        return b.sourceId.localeCompare(a.sourceId);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_PdfContent:
                    return (a, b) => {
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[TopicObjectiveV]中不存在！(in ${exports.topicObjectiveV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.TopicObjectiveV_SortFunByKey = TopicObjectiveV_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function TopicObjectiveV_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_TopicObjectiveVId:
                return (obj) => {
                    return obj.topicObjectiveVId === value;
                };
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_TopicObjectiveId:
                return (obj) => {
                    return obj.topicObjectiveId === value;
                };
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveName:
                return (obj) => {
                    return obj.objectiveName === value;
                };
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveContent:
                return (obj) => {
                    return obj.objectiveContent === value;
                };
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveType:
                return (obj) => {
                    return obj.objectiveType === value;
                };
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_Conclusion:
                return (obj) => {
                    return obj.conclusion === value;
                };
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_SourceId:
                return (obj) => {
                    return obj.sourceId === value;
                };
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[TopicObjectiveV]中不存在！(in ${exports.topicObjectiveV_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.TopicObjectiveV_FilterFunByKey = TopicObjectiveV_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function TopicObjectiveV_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_GetFirstIDAsync = TopicObjectiveV_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function TopicObjectiveV_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_GetFirstID = TopicObjectiveV_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function TopicObjectiveV_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjectiveV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objTopicObjectiveV = TopicObjectiveV_GetObjFromJsonObj(returnObj);
                return objTopicObjectiveV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_GetFirstObjAsync = TopicObjectiveV_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function TopicObjectiveV_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjectiveV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjectiveV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_GetObjLstAsync = TopicObjectiveV_GetObjLstAsync;
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
    async function TopicObjectiveV_GetObjLstByTopicObjectiveVIdLstAsync(arrTopicObjectiveVId) {
        const strThisFuncName = "GetObjLstByTopicObjectiveVIdLstAsync";
        const strAction = "GetObjLstByTopicObjectiveVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicObjectiveVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjectiveV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjectiveV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_GetObjLstByTopicObjectiveVIdLstAsync = TopicObjectiveV_GetObjLstByTopicObjectiveVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function TopicObjectiveV_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjectiveV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjectiveV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_GetTopObjLstAsync = TopicObjectiveV_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function TopicObjectiveV_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjectiveV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjectiveV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_GetObjLstByRangeAsync = TopicObjectiveV_GetObjLstByRangeAsync;
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
    async function TopicObjectiveV_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_GetObjLstByRange = TopicObjectiveV_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function TopicObjectiveV_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjectiveV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjectiveV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_GetObjLstByPagerAsync = TopicObjectiveV_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngTopicObjectiveVId:关键字
    * @returns 获取删除的结果
    **/
    async function TopicObjectiveV_DelRecordAsync(lngTopicObjectiveVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngTopicObjectiveVId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngTopicObjectiveVId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_DelRecordAsync = TopicObjectiveV_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrTopicObjectiveVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function TopicObjectiveV_DelTopicObjectiveVsAsync(arrTopicObjectiveVId) {
        const strThisFuncName = "DelTopicObjectiveVsAsync";
        const strAction = "DelTopicObjectiveVs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_DelTopicObjectiveVsAsync = TopicObjectiveV_DelTopicObjectiveVsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function TopicObjectiveV_DelTopicObjectiveVsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelTopicObjectiveVsByCondAsync";
        const strAction = "DelTopicObjectiveVsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_DelTopicObjectiveVsByCondAsync = TopicObjectiveV_DelTopicObjectiveVsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objTopicObjectiveVEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function TopicObjectiveV_AddNewRecordAsync(objTopicObjectiveVEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objTopicObjectiveVEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_AddNewRecordAsync = TopicObjectiveV_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objTopicObjectiveVEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function TopicObjectiveV_AddNewRecordWithReturnKeyAsync(objTopicObjectiveVEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_AddNewRecordWithReturnKeyAsync = TopicObjectiveV_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objTopicObjectiveVEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function TopicObjectiveV_AddNewRecordWithReturnKey(objTopicObjectiveVEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objTopicObjectiveVEN.topicObjectiveVId === null || objTopicObjectiveVEN.topicObjectiveVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveVEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_AddNewRecordWithReturnKey = TopicObjectiveV_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objTopicObjectiveVEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function TopicObjectiveV_UpdateRecordAsync(objTopicObjectiveVEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objTopicObjectiveVEN.sf_UpdFldSetStr === undefined || objTopicObjectiveVEN.sf_UpdFldSetStr === null || objTopicObjectiveVEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicObjectiveVEN.topicObjectiveVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_UpdateRecordAsync = TopicObjectiveV_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objTopicObjectiveVEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function TopicObjectiveV_UpdateWithConditionAsync(objTopicObjectiveVEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objTopicObjectiveVEN.sf_UpdFldSetStr === undefined || objTopicObjectiveVEN.sf_UpdFldSetStr === null || objTopicObjectiveVEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicObjectiveVEN.topicObjectiveVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
        objTopicObjectiveVEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_UpdateWithConditionAsync = TopicObjectiveV_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function TopicObjectiveV_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_IsExistRecordAsync = TopicObjectiveV_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngTopicObjectiveVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function TopicObjectiveV_IsExist(lngTopicObjectiveVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_IsExist = TopicObjectiveV_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngTopicObjectiveVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function TopicObjectiveV_IsExistAsync(lngTopicObjectiveVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_IsExistAsync = TopicObjectiveV_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function TopicObjectiveV_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_GetRecCountByCondAsync = TopicObjectiveV_GetRecCountByCondAsync;
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
    async function TopicObjectiveV_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjectiveV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjectiveV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjectiveV_GetMaxStrIdByPrefix = TopicObjectiveV_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function TopicObjectiveV_GetWebApiUrl(strController, strAction) {
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
    exports.TopicObjectiveV_GetWebApiUrl = TopicObjectiveV_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function TopicObjectiveV_CheckPropertyNew(pobjTopicObjectiveVEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.topicObjectiveId) === true) {
            throw new Error("(errid:Watl000058)字段[客观Id]不能为空(In 主题客观版本)!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.topicObjectiveId) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.topicObjectiveId) > 8) {
            throw new Error("(errid:Watl000059)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.topicObjectiveId)(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.objectiveName) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.objectiveName) > 500) {
            throw new Error("(errid:Watl000059)字段[客观名称(objectiveName)]的长度不能超过500(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.objectiveName)(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.objectiveType) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.objectiveType) > 2) {
            throw new Error("(errid:Watl000059)字段[客观类型(objectiveType)]的长度不能超过2(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.objectiveType)(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.sourceId) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.sourceId) > 10) {
            throw new Error("(errid:Watl000059)字段[来源Id(sourceId)]的长度不能超过10(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.sourceId)(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.updDate)(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.updUser)(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.id_CurrEduCls)(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.pdfContent) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.pdfContent)(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.memo)(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjTopicObjectiveVEN.topicObjectiveVId && undefined !== pobjTopicObjectiveVEN.topicObjectiveVId && jsString_js_1.tzDataType.isNumber(pobjTopicObjectiveVEN.topicObjectiveVId) === false) {
            throw new Error("(errid:Watl000060)字段[主题客观版本Id(topicObjectiveVId)]的值:[$(pobjTopicObjectiveVEN.topicObjectiveVId)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.topicObjectiveId) == false && undefined !== pobjTopicObjectiveVEN.topicObjectiveId && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.topicObjectiveId) === false) {
            throw new Error("(errid:Watl000060)字段[客观Id(topicObjectiveId)]的值:[$(pobjTopicObjectiveVEN.topicObjectiveId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.objectiveName) == false && undefined !== pobjTopicObjectiveVEN.objectiveName && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.objectiveName) === false) {
            throw new Error("(errid:Watl000060)字段[客观名称(objectiveName)]的值:[$(pobjTopicObjectiveVEN.objectiveName)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.objectiveContent) == false && undefined !== pobjTopicObjectiveVEN.objectiveContent && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.objectiveContent) === false) {
            throw new Error("(errid:Watl000060)字段[客观内容(objectiveContent)]的值:[$(pobjTopicObjectiveVEN.objectiveContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.objectiveType) == false && undefined !== pobjTopicObjectiveVEN.objectiveType && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.objectiveType) === false) {
            throw new Error("(errid:Watl000060)字段[客观类型(objectiveType)]的值:[$(pobjTopicObjectiveVEN.objectiveType)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.conclusion) == false && undefined !== pobjTopicObjectiveVEN.conclusion && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.conclusion) === false) {
            throw new Error("(errid:Watl000060)字段[结论(conclusion)]的值:[$(pobjTopicObjectiveVEN.conclusion)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.sourceId) == false && undefined !== pobjTopicObjectiveVEN.sourceId && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.sourceId) === false) {
            throw new Error("(errid:Watl000060)字段[来源Id(sourceId)]的值:[$(pobjTopicObjectiveVEN.sourceId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.updDate) == false && undefined !== pobjTopicObjectiveVEN.updDate && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjTopicObjectiveVEN.updDate)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.updUser) == false && undefined !== pobjTopicObjectiveVEN.updUser && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjTopicObjectiveVEN.updUser)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.id_CurrEduCls) == false && undefined !== pobjTopicObjectiveVEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjTopicObjectiveVEN.id_CurrEduCls)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.pdfContent) == false && undefined !== pobjTopicObjectiveVEN.pdfContent && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.pdfContent) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjTopicObjectiveVEN.pdfContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if (null != pobjTopicObjectiveVEN.pdfPageNum && undefined !== pobjTopicObjectiveVEN.pdfPageNum && jsString_js_1.tzDataType.isNumber(pobjTopicObjectiveVEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjTopicObjectiveVEN.pdfPageNum)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.memo) == false && undefined !== pobjTopicObjectiveVEN.memo && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjTopicObjectiveVEN.memo)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjTopicObjectiveVEN.SetIsCheckProperty(true);
    }
    exports.TopicObjectiveV_CheckPropertyNew = TopicObjectiveV_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function TopicObjectiveV_CheckProperty4Update(pobjTopicObjectiveVEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.topicObjectiveId) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.topicObjectiveId) > 8) {
            throw new Error("(errid:Watl000062)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.topicObjectiveId)(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.objectiveName) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.objectiveName) > 500) {
            throw new Error("(errid:Watl000062)字段[客观名称(objectiveName)]的长度不能超过500(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.objectiveName)(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.objectiveType) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.objectiveType) > 2) {
            throw new Error("(errid:Watl000062)字段[客观类型(objectiveType)]的长度不能超过2(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.objectiveType)(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.sourceId) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.sourceId) > 10) {
            throw new Error("(errid:Watl000062)字段[来源Id(sourceId)]的长度不能超过10(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.sourceId)(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.updDate)(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.updUser)(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.id_CurrEduCls)(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.pdfContent) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.pdfContent)(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjTopicObjectiveVEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.memo)(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjTopicObjectiveVEN.topicObjectiveVId && undefined !== pobjTopicObjectiveVEN.topicObjectiveVId && jsString_js_1.tzDataType.isNumber(pobjTopicObjectiveVEN.topicObjectiveVId) === false) {
            throw new Error("(errid:Watl000063)字段[主题客观版本Id(topicObjectiveVId)]的值:[$(pobjTopicObjectiveVEN.topicObjectiveVId)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.topicObjectiveId) == false && undefined !== pobjTopicObjectiveVEN.topicObjectiveId && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.topicObjectiveId) === false) {
            throw new Error("(errid:Watl000063)字段[客观Id(topicObjectiveId)]的值:[$(pobjTopicObjectiveVEN.topicObjectiveId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.objectiveName) == false && undefined !== pobjTopicObjectiveVEN.objectiveName && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.objectiveName) === false) {
            throw new Error("(errid:Watl000063)字段[客观名称(objectiveName)]的值:[$(pobjTopicObjectiveVEN.objectiveName)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.objectiveContent) == false && undefined !== pobjTopicObjectiveVEN.objectiveContent && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.objectiveContent) === false) {
            throw new Error("(errid:Watl000063)字段[客观内容(objectiveContent)]的值:[$(pobjTopicObjectiveVEN.objectiveContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.objectiveType) == false && undefined !== pobjTopicObjectiveVEN.objectiveType && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.objectiveType) === false) {
            throw new Error("(errid:Watl000063)字段[客观类型(objectiveType)]的值:[$(pobjTopicObjectiveVEN.objectiveType)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.conclusion) == false && undefined !== pobjTopicObjectiveVEN.conclusion && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.conclusion) === false) {
            throw new Error("(errid:Watl000063)字段[结论(conclusion)]的值:[$(pobjTopicObjectiveVEN.conclusion)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.sourceId) == false && undefined !== pobjTopicObjectiveVEN.sourceId && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.sourceId) === false) {
            throw new Error("(errid:Watl000063)字段[来源Id(sourceId)]的值:[$(pobjTopicObjectiveVEN.sourceId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.updDate) == false && undefined !== pobjTopicObjectiveVEN.updDate && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjTopicObjectiveVEN.updDate)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.updUser) == false && undefined !== pobjTopicObjectiveVEN.updUser && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjTopicObjectiveVEN.updUser)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.id_CurrEduCls) == false && undefined !== pobjTopicObjectiveVEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjTopicObjectiveVEN.id_CurrEduCls)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.pdfContent) == false && undefined !== pobjTopicObjectiveVEN.pdfContent && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.pdfContent) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjTopicObjectiveVEN.pdfContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if (null != pobjTopicObjectiveVEN.pdfPageNum && undefined !== pobjTopicObjectiveVEN.pdfPageNum && jsString_js_1.tzDataType.isNumber(pobjTopicObjectiveVEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjTopicObjectiveVEN.pdfPageNum)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicObjectiveVEN.memo) == false && undefined !== pobjTopicObjectiveVEN.memo && jsString_js_1.tzDataType.isString(pobjTopicObjectiveVEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjTopicObjectiveVEN.memo)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjTopicObjectiveVEN.topicObjectiveVId
            || pobjTopicObjectiveVEN.topicObjectiveVId != null && pobjTopicObjectiveVEN.topicObjectiveVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[主题客观版本Id]不能为空(In 主题客观版本)!(clsTopicObjectiveVBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjTopicObjectiveVEN.SetIsCheckProperty(true);
    }
    exports.TopicObjectiveV_CheckProperty4Update = TopicObjectiveV_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function TopicObjectiveV_GetJSONStrByObj(pobjTopicObjectiveVEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjTopicObjectiveVEN.sf_UpdFldSetStr = pobjTopicObjectiveVEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjTopicObjectiveVEN);
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
    exports.TopicObjectiveV_GetJSONStrByObj = TopicObjectiveV_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function TopicObjectiveV_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrTopicObjectiveVObjLst = new Array();
        if (strJSON === "") {
            return arrTopicObjectiveVObjLst;
        }
        try {
            arrTopicObjectiveVObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrTopicObjectiveVObjLst;
        }
        return arrTopicObjectiveVObjLst;
    }
    exports.TopicObjectiveV_GetObjLstByJSONStr = TopicObjectiveV_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrTopicObjectiveVObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function TopicObjectiveV_GetObjLstByJSONObjLst(arrTopicObjectiveVObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrTopicObjectiveVObjLst = new Array();
        for (const objInFor of arrTopicObjectiveVObjLstS) {
            const obj1 = TopicObjectiveV_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrTopicObjectiveVObjLst.push(obj1);
        }
        return arrTopicObjectiveVObjLst;
    }
    exports.TopicObjectiveV_GetObjLstByJSONObjLst = TopicObjectiveV_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function TopicObjectiveV_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjTopicObjectiveVEN = new clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN();
        if (strJSON === "") {
            return pobjTopicObjectiveVEN;
        }
        try {
            pobjTopicObjectiveVEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjTopicObjectiveVEN;
        }
        return pobjTopicObjectiveVEN;
    }
    exports.TopicObjectiveV_GetObjByJSONStr = TopicObjectiveV_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function TopicObjectiveV_GetCombineCondition(objTopicObjectiveV_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_TopicObjectiveVId) == true) {
            const strComparisonOp_TopicObjectiveVId = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_TopicObjectiveVId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_TopicObjectiveVId, objTopicObjectiveV_Cond.topicObjectiveVId, strComparisonOp_TopicObjectiveVId);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_TopicObjectiveId) == true) {
            const strComparisonOp_TopicObjectiveId = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_TopicObjectiveId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_TopicObjectiveId, objTopicObjectiveV_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveName) == true) {
            const strComparisonOp_ObjectiveName = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveName, objTopicObjectiveV_Cond.objectiveName, strComparisonOp_ObjectiveName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveType) == true) {
            const strComparisonOp_ObjectiveType = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_ObjectiveType, objTopicObjectiveV_Cond.objectiveType, strComparisonOp_ObjectiveType);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_SourceId) == true) {
            const strComparisonOp_SourceId = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_SourceId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_SourceId, objTopicObjectiveV_Cond.sourceId, strComparisonOp_SourceId);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_UpdDate, objTopicObjectiveV_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_UpdUser, objTopicObjectiveV_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_id_CurrEduCls, objTopicObjectiveV_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_PdfContent, objTopicObjectiveV_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_PdfPageNum, objTopicObjectiveV_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_Memo) == true) {
            const strComparisonOp_Memo = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN.con_Memo, objTopicObjectiveV_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.TopicObjectiveV_GetCombineCondition = TopicObjectiveV_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--TopicObjectiveV(主题客观版本),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngTopicObjectiveVId: 主题客观版本Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function TopicObjectiveV_GetUniCondStr_TopicObjectiveVId(objTopicObjectiveVEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVEN.topicObjectiveVId);
        return strWhereCond;
    }
    exports.TopicObjectiveV_GetUniCondStr_TopicObjectiveVId = TopicObjectiveV_GetUniCondStr_TopicObjectiveVId;
    /**
    *获取唯一性条件串(Uniqueness)--TopicObjectiveV(主题客观版本),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngTopicObjectiveVId: 主题客观版本Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function TopicObjectiveV_GetUniCondStr4Update_TopicObjectiveVId(objTopicObjectiveVEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and TopicObjectiveVId <> '{0}'", objTopicObjectiveVEN.topicObjectiveVId);
        strWhereCond += (0, clsString_js_1.Format)(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVEN.topicObjectiveVId);
        return strWhereCond;
    }
    exports.TopicObjectiveV_GetUniCondStr4Update_TopicObjectiveVId = TopicObjectiveV_GetUniCondStr4Update_TopicObjectiveVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objTopicObjectiveVENS:源对象
     * @param objTopicObjectiveVENT:目标对象
    */
    function TopicObjectiveV_CopyObjTo(objTopicObjectiveVENS, objTopicObjectiveVENT) {
        objTopicObjectiveVENT.topicObjectiveVId = objTopicObjectiveVENS.topicObjectiveVId; //主题客观版本Id
        objTopicObjectiveVENT.topicObjectiveId = objTopicObjectiveVENS.topicObjectiveId; //客观Id
        objTopicObjectiveVENT.objectiveName = objTopicObjectiveVENS.objectiveName; //客观名称
        objTopicObjectiveVENT.objectiveContent = objTopicObjectiveVENS.objectiveContent; //客观内容
        objTopicObjectiveVENT.objectiveType = objTopicObjectiveVENS.objectiveType; //客观类型
        objTopicObjectiveVENT.conclusion = objTopicObjectiveVENS.conclusion; //结论
        objTopicObjectiveVENT.sourceId = objTopicObjectiveVENS.sourceId; //来源Id
        objTopicObjectiveVENT.updDate = objTopicObjectiveVENS.updDate; //修改日期
        objTopicObjectiveVENT.updUser = objTopicObjectiveVENS.updUser; //修改人
        objTopicObjectiveVENT.id_CurrEduCls = objTopicObjectiveVENS.id_CurrEduCls; //教学班流水号
        objTopicObjectiveVENT.pdfContent = objTopicObjectiveVENS.pdfContent; //Pdf内容
        objTopicObjectiveVENT.pdfPageNum = objTopicObjectiveVENS.pdfPageNum; //Pdf页码
        objTopicObjectiveVENT.memo = objTopicObjectiveVENS.memo; //备注
        objTopicObjectiveVENT.sf_UpdFldSetStr = objTopicObjectiveVENS.updFldString; //sf_UpdFldSetStr
    }
    exports.TopicObjectiveV_CopyObjTo = TopicObjectiveV_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objTopicObjectiveVENS:源对象
     * @param objTopicObjectiveVENT:目标对象
    */
    function TopicObjectiveV_GetObjFromJsonObj(objTopicObjectiveVENS) {
        const objTopicObjectiveVENT = new clsTopicObjectiveVEN_js_1.clsTopicObjectiveVEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objTopicObjectiveVENT, objTopicObjectiveVENS);
        return objTopicObjectiveVENT;
    }
    exports.TopicObjectiveV_GetObjFromJsonObj = TopicObjectiveV_GetObjFromJsonObj;
});
