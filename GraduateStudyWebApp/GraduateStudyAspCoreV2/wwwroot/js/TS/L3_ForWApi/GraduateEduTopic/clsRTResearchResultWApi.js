/**
* 类名:clsRTResearchResultWApi
* 表名:RTResearchResult(01120620)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:50:32
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsRTResearchResultEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.RTResearchResult_GetObjFromJsonObj = exports.RTResearchResult_CopyObjTo = exports.RTResearchResult_GetUniCondStr4Update_mId_TopicId_PaperId = exports.RTResearchResult_GetUniCondStr_mId_TopicId_PaperId = exports.RTResearchResult_GetCombineCondition = exports.RTResearchResult_GetObjByJSONStr = exports.RTResearchResult_GetObjLstByJSONObjLst = exports.RTResearchResult_GetObjLstByJSONStr = exports.RTResearchResult_GetJSONStrByObj = exports.RTResearchResult_CheckProperty4Update = exports.RTResearchResult_CheckPropertyNew = exports.RTResearchResult_GetWebApiUrl = exports.RTResearchResult_GetMaxStrIdByPrefix = exports.RTResearchResult_GetRecCountByCondAsync = exports.RTResearchResult_IsExistAsync = exports.RTResearchResult_IsExist = exports.RTResearchResult_IsExistRecordAsync = exports.RTResearchResult_UpdateWithConditionAsync = exports.RTResearchResult_UpdateRecordAsync = exports.RTResearchResult_AddNewRecordWithReturnKey = exports.RTResearchResult_AddNewRecordWithReturnKeyAsync = exports.RTResearchResult_AddNewRecordAsync = exports.RTResearchResult_DelRTResearchResultsByCondAsync = exports.RTResearchResult_DelRTResearchResultsAsync = exports.RTResearchResult_DelRecordAsync = exports.RTResearchResult_GetObjLstByPagerAsync = exports.RTResearchResult_GetObjLstByRange = exports.RTResearchResult_GetObjLstByRangeAsync = exports.RTResearchResult_GetTopObjLstAsync = exports.RTResearchResult_GetObjLstBymIdLstAsync = exports.RTResearchResult_GetObjLstAsync = exports.RTResearchResult_GetFirstObjAsync = exports.RTResearchResult_GetFirstID = exports.RTResearchResult_GetFirstIDAsync = exports.RTResearchResult_FilterFunByKey = exports.RTResearchResult_SortFunByKey = exports.RTResearchResult_SortFun_Defa_2Fld = exports.RTResearchResult_SortFun_Defa = exports.RTResearchResult_GetObjBymIdAsync = exports.rTResearchResult_ConstructorName = exports.rTResearchResult_Controller = void 0;
    /**
     * 研究结果(RTResearchResult)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsRTResearchResultEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsRTResearchResultEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.rTResearchResult_Controller = "RTResearchResultApi";
    exports.rTResearchResult_ConstructorName = "rTResearchResult";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function RTResearchResult_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clsRTResearchResultWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngmId": lngmId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objRTResearchResult = RTResearchResult_GetObjFromJsonObj(returnObj);
                return objRTResearchResult;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_GetObjBymIdAsync = RTResearchResult_GetObjBymIdAsync;
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
    function RTResearchResult_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.RTResearchResult_SortFun_Defa = RTResearchResult_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTResearchResult_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.RTResearchResult_SortFun_Defa_2Fld = RTResearchResult_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTResearchResult_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RTResearchResult]中不存在！(in ${exports.rTResearchResult_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RTResearchResult]中不存在！(in ${exports.rTResearchResult_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.RTResearchResult_SortFunByKey = RTResearchResult_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function RTResearchResult_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[RTResearchResult]中不存在！(in ${exports.rTResearchResult_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.RTResearchResult_FilterFunByKey = RTResearchResult_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function RTResearchResult_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_GetFirstIDAsync = RTResearchResult_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function RTResearchResult_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_GetFirstID = RTResearchResult_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function RTResearchResult_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
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
                const objRTResearchResult = RTResearchResult_GetObjFromJsonObj(returnObj);
                return objRTResearchResult;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_GetFirstObjAsync = RTResearchResult_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function RTResearchResult_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_GetObjLstAsync = RTResearchResult_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function RTResearchResult_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_GetObjLstBymIdLstAsync = RTResearchResult_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function RTResearchResult_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_GetTopObjLstAsync = RTResearchResult_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RTResearchResult_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_GetObjLstByRangeAsync = RTResearchResult_GetObjLstByRangeAsync;
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
    async function RTResearchResult_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_GetObjLstByRange = RTResearchResult_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RTResearchResult_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_GetObjLstByPagerAsync = RTResearchResult_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function RTResearchResult_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngmId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_DelRecordAsync = RTResearchResult_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function RTResearchResult_DelRTResearchResultsAsync(arrmId) {
        const strThisFuncName = "DelRTResearchResultsAsync";
        const strAction = "DelRTResearchResults";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_DelRTResearchResultsAsync = RTResearchResult_DelRTResearchResultsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function RTResearchResult_DelRTResearchResultsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelRTResearchResultsByCondAsync";
        const strAction = "DelRTResearchResultsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_DelRTResearchResultsByCondAsync = RTResearchResult_DelRTResearchResultsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objRTResearchResultEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RTResearchResult_AddNewRecordAsync(objRTResearchResultEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objRTResearchResultEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTResearchResultEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_AddNewRecordAsync = RTResearchResult_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objRTResearchResultEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function RTResearchResult_AddNewRecordWithReturnKeyAsync(objRTResearchResultEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTResearchResultEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_AddNewRecordWithReturnKeyAsync = RTResearchResult_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objRTResearchResultEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function RTResearchResult_AddNewRecordWithReturnKey(objRTResearchResultEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objRTResearchResultEN.mId === null || objRTResearchResultEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTResearchResultEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_AddNewRecordWithReturnKey = RTResearchResult_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objRTResearchResultEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function RTResearchResult_UpdateRecordAsync(objRTResearchResultEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objRTResearchResultEN.sf_UpdFldSetStr === undefined || objRTResearchResultEN.sf_UpdFldSetStr === null || objRTResearchResultEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTResearchResultEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTResearchResultEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_UpdateRecordAsync = RTResearchResult_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objRTResearchResultEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function RTResearchResult_UpdateWithConditionAsync(objRTResearchResultEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objRTResearchResultEN.sf_UpdFldSetStr === undefined || objRTResearchResultEN.sf_UpdFldSetStr === null || objRTResearchResultEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTResearchResultEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        objRTResearchResultEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objRTResearchResultEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_UpdateWithConditionAsync = RTResearchResult_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function RTResearchResult_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_IsExistRecordAsync = RTResearchResult_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function RTResearchResult_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "mId": lngmId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_IsExist = RTResearchResult_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function RTResearchResult_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngmId": lngmId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_IsExistAsync = RTResearchResult_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function RTResearchResult_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_GetRecCountByCondAsync = RTResearchResult_GetRecCountByCondAsync;
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
    async function RTResearchResult_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTResearchResult_GetMaxStrIdByPrefix = RTResearchResult_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function RTResearchResult_GetWebApiUrl(strController, strAction) {
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
    exports.RTResearchResult_GetWebApiUrl = RTResearchResult_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RTResearchResult_CheckPropertyNew(pobjRTResearchResultEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.updUser) === true) {
            throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 研究结果)!(clsRTResearchResultBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjRTResearchResultEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.topicId)(clsRTResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjRTResearchResultEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.paperId)(clsRTResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjRTResearchResultEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.updDate)(clsRTResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjRTResearchResultEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.updUser)(clsRTResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjRTResearchResultEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.memo)(clsRTResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjRTResearchResultEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.id_CurrEduCls)(clsRTResearchResultBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjRTResearchResultEN.mId && undefined !== pobjRTResearchResultEN.mId && clsString_js_1.tzDataType.isNumber(pobjRTResearchResultEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjRTResearchResultEN.mId)], 非法，应该为数值型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.topicId) == false && undefined !== pobjRTResearchResultEN.topicId && clsString_js_1.tzDataType.isString(pobjRTResearchResultEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjRTResearchResultEN.topicId)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.paperId) == false && undefined !== pobjRTResearchResultEN.paperId && clsString_js_1.tzDataType.isString(pobjRTResearchResultEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjRTResearchResultEN.paperId)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.updDate) == false && undefined !== pobjRTResearchResultEN.updDate && clsString_js_1.tzDataType.isString(pobjRTResearchResultEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjRTResearchResultEN.updDate)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.updUser) == false && undefined !== pobjRTResearchResultEN.updUser && clsString_js_1.tzDataType.isString(pobjRTResearchResultEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjRTResearchResultEN.updUser)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.memo) == false && undefined !== pobjRTResearchResultEN.memo && clsString_js_1.tzDataType.isString(pobjRTResearchResultEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRTResearchResultEN.memo)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.id_CurrEduCls) == false && undefined !== pobjRTResearchResultEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjRTResearchResultEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTResearchResultEN.id_CurrEduCls)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjRTResearchResultEN.SetIsCheckProperty(true);
    }
    exports.RTResearchResult_CheckPropertyNew = RTResearchResult_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RTResearchResult_CheckProperty4Update(pobjRTResearchResultEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjRTResearchResultEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.topicId)(clsRTResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjRTResearchResultEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.paperId)(clsRTResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjRTResearchResultEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.updDate)(clsRTResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjRTResearchResultEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.updUser)(clsRTResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjRTResearchResultEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.memo)(clsRTResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjRTResearchResultEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.id_CurrEduCls)(clsRTResearchResultBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjRTResearchResultEN.mId && undefined !== pobjRTResearchResultEN.mId && clsString_js_1.tzDataType.isNumber(pobjRTResearchResultEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjRTResearchResultEN.mId)], 非法，应该为数值型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.topicId) == false && undefined !== pobjRTResearchResultEN.topicId && clsString_js_1.tzDataType.isString(pobjRTResearchResultEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjRTResearchResultEN.topicId)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.paperId) == false && undefined !== pobjRTResearchResultEN.paperId && clsString_js_1.tzDataType.isString(pobjRTResearchResultEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjRTResearchResultEN.paperId)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.updDate) == false && undefined !== pobjRTResearchResultEN.updDate && clsString_js_1.tzDataType.isString(pobjRTResearchResultEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjRTResearchResultEN.updDate)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.updUser) == false && undefined !== pobjRTResearchResultEN.updUser && clsString_js_1.tzDataType.isString(pobjRTResearchResultEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjRTResearchResultEN.updUser)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.memo) == false && undefined !== pobjRTResearchResultEN.memo && clsString_js_1.tzDataType.isString(pobjRTResearchResultEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRTResearchResultEN.memo)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTResearchResultEN.id_CurrEduCls) == false && undefined !== pobjRTResearchResultEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjRTResearchResultEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTResearchResultEN.id_CurrEduCls)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjRTResearchResultEN.mId
            || pobjRTResearchResultEN.mId != null && pobjRTResearchResultEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 研究结果)!(clsRTResearchResultBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjRTResearchResultEN.SetIsCheckProperty(true);
    }
    exports.RTResearchResult_CheckProperty4Update = RTResearchResult_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RTResearchResult_GetJSONStrByObj(pobjRTResearchResultEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjRTResearchResultEN.sf_UpdFldSetStr = pobjRTResearchResultEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjRTResearchResultEN);
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
    exports.RTResearchResult_GetJSONStrByObj = RTResearchResult_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function RTResearchResult_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrRTResearchResultObjLst = new Array();
        if (strJSON === "") {
            return arrRTResearchResultObjLst;
        }
        try {
            arrRTResearchResultObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrRTResearchResultObjLst;
        }
        return arrRTResearchResultObjLst;
    }
    exports.RTResearchResult_GetObjLstByJSONStr = RTResearchResult_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrRTResearchResultObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function RTResearchResult_GetObjLstByJSONObjLst(arrRTResearchResultObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrRTResearchResultObjLst = new Array();
        for (const objInFor of arrRTResearchResultObjLstS) {
            const obj1 = RTResearchResult_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrRTResearchResultObjLst.push(obj1);
        }
        return arrRTResearchResultObjLst;
    }
    exports.RTResearchResult_GetObjLstByJSONObjLst = RTResearchResult_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RTResearchResult_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjRTResearchResultEN = new clsRTResearchResultEN_js_1.clsRTResearchResultEN();
        if (strJSON === "") {
            return pobjRTResearchResultEN;
        }
        try {
            pobjRTResearchResultEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjRTResearchResultEN;
        }
        return pobjRTResearchResultEN;
    }
    exports.RTResearchResult_GetObjByJSONStr = RTResearchResult_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function RTResearchResult_GetCombineCondition(objRTResearchResult_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_mId) == true) {
            const strComparisonOp_mId = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_mId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_mId, objRTResearchResult_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_TopicId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_TopicId, objRTResearchResult_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_PaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_PaperId, objRTResearchResult_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_UpdDate, objRTResearchResult_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_UpdUser, objRTResearchResult_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_Memo) == true) {
            const strComparisonOp_Memo = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_Memo, objRTResearchResult_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTResearchResultEN_js_1.clsRTResearchResultEN.con_id_CurrEduCls, objRTResearchResult_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.RTResearchResult_GetCombineCondition = RTResearchResult_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--RTResearchResult(研究结果),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function RTResearchResult_GetUniCondStr_mId_TopicId_PaperId(objRTResearchResultEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId = '{0}'", objRTResearchResultEN.mId);
        strWhereCond += (0, clsString_js_2.Format)(" and TopicId = '{0}'", objRTResearchResultEN.topicId);
        strWhereCond += (0, clsString_js_2.Format)(" and PaperId = '{0}'", objRTResearchResultEN.paperId);
        return strWhereCond;
    }
    exports.RTResearchResult_GetUniCondStr_mId_TopicId_PaperId = RTResearchResult_GetUniCondStr_mId_TopicId_PaperId;
    /**
    *获取唯一性条件串(Uniqueness)--RTResearchResult(研究结果),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function RTResearchResult_GetUniCondStr4Update_mId_TopicId_PaperId(objRTResearchResultEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId <> '{0}'", objRTResearchResultEN.mId);
        strWhereCond += (0, clsString_js_2.Format)(" and mId = '{0}'", objRTResearchResultEN.mId);
        strWhereCond += (0, clsString_js_2.Format)(" and TopicId = '{0}'", objRTResearchResultEN.topicId);
        strWhereCond += (0, clsString_js_2.Format)(" and PaperId = '{0}'", objRTResearchResultEN.paperId);
        return strWhereCond;
    }
    exports.RTResearchResult_GetUniCondStr4Update_mId_TopicId_PaperId = RTResearchResult_GetUniCondStr4Update_mId_TopicId_PaperId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objRTResearchResultENS:源对象
     * @param objRTResearchResultENT:目标对象
    */
    function RTResearchResult_CopyObjTo(objRTResearchResultENS, objRTResearchResultENT) {
        objRTResearchResultENT.mId = objRTResearchResultENS.mId; //mId
        objRTResearchResultENT.topicId = objRTResearchResultENS.topicId; //主题Id
        objRTResearchResultENT.paperId = objRTResearchResultENS.paperId; //论文Id
        objRTResearchResultENT.updDate = objRTResearchResultENS.updDate; //修改日期
        objRTResearchResultENT.updUser = objRTResearchResultENS.updUser; //修改人
        objRTResearchResultENT.memo = objRTResearchResultENS.memo; //备注
        objRTResearchResultENT.id_CurrEduCls = objRTResearchResultENS.id_CurrEduCls; //教学班流水号
        objRTResearchResultENT.sf_UpdFldSetStr = objRTResearchResultENS.updFldString; //sf_UpdFldSetStr
    }
    exports.RTResearchResult_CopyObjTo = RTResearchResult_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objRTResearchResultENS:源对象
     * @param objRTResearchResultENT:目标对象
    */
    function RTResearchResult_GetObjFromJsonObj(objRTResearchResultENS) {
        const objRTResearchResultENT = new clsRTResearchResultEN_js_1.clsRTResearchResultEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRTResearchResultENT, objRTResearchResultENS);
        return objRTResearchResultENT;
    }
    exports.RTResearchResult_GetObjFromJsonObj = RTResearchResult_GetObjFromJsonObj;
});
