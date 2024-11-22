/**
* 类名:clsConceptCitationWApi
* 表名:ConceptCitation(01120604)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:50
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsConceptCitationEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ConceptCitation_GetObjFromJsonObj = exports.ConceptCitation_CopyObjTo = exports.ConceptCitation_GetUniCondStr4Update_mId_ConceptId_PaperId = exports.ConceptCitation_GetUniCondStr_mId_ConceptId_PaperId = exports.ConceptCitation_GetCombineCondition = exports.ConceptCitation_GetObjByJSONStr = exports.ConceptCitation_GetObjLstByJSONObjLst = exports.ConceptCitation_GetObjLstByJSONStr = exports.ConceptCitation_GetJSONStrByObj = exports.ConceptCitation_CheckProperty4Update = exports.ConceptCitation_CheckPropertyNew = exports.ConceptCitation_GetWebApiUrl = exports.ConceptCitation_GetMaxStrIdByPrefix = exports.ConceptCitation_GetRecCountByCondAsync = exports.ConceptCitation_IsExistAsync = exports.ConceptCitation_IsExist = exports.ConceptCitation_IsExistRecordAsync = exports.ConceptCitation_UpdateWithConditionAsync = exports.ConceptCitation_UpdateRecordAsync = exports.ConceptCitation_AddNewRecordWithReturnKey = exports.ConceptCitation_AddNewRecordWithReturnKeyAsync = exports.ConceptCitation_AddNewRecordAsync = exports.ConceptCitation_DelConceptCitationsByCondAsync = exports.ConceptCitation_DelConceptCitationsAsync = exports.ConceptCitation_DelRecordAsync = exports.ConceptCitation_GetObjLstByPagerAsync = exports.ConceptCitation_GetObjLstByRange = exports.ConceptCitation_GetObjLstByRangeAsync = exports.ConceptCitation_GetTopObjLstAsync = exports.ConceptCitation_GetObjLstBymIdLstAsync = exports.ConceptCitation_GetObjLstAsync = exports.ConceptCitation_GetFirstObjAsync = exports.ConceptCitation_GetFirstID = exports.ConceptCitation_GetFirstIDAsync = exports.ConceptCitation_FilterFunByKey = exports.ConceptCitation_SortFunByKey = exports.ConceptCitation_SortFun_Defa_2Fld = exports.ConceptCitation_SortFun_Defa = exports.ConceptCitation_GetObjBymIdAsync = exports.conceptCitation_ConstructorName = exports.conceptCitation_Controller = void 0;
    /**
     * 概念引用(ConceptCitation)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsConceptCitationEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsConceptCitationEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.conceptCitation_Controller = "ConceptCitationApi";
    exports.conceptCitation_ConstructorName = "conceptCitation";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function ConceptCitation_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objConceptCitation = ConceptCitation_GetObjFromJsonObj(returnObj);
                return objConceptCitation;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_GetObjBymIdAsync = ConceptCitation_GetObjBymIdAsync;
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
    function ConceptCitation_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.ConceptCitation_SortFun_Defa = ConceptCitation_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ConceptCitation_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.conceptId == b.conceptId)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.conceptId.localeCompare(b.conceptId);
    }
    exports.ConceptCitation_SortFun_Defa_2Fld = ConceptCitation_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ConceptCitation_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsConceptCitationEN_js_1.clsConceptCitationEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsConceptCitationEN_js_1.clsConceptCitationEN.con_ConceptId:
                    return (a, b) => {
                        return a.conceptId.localeCompare(b.conceptId);
                    };
                case clsConceptCitationEN_js_1.clsConceptCitationEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsConceptCitationEN_js_1.clsConceptCitationEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsConceptCitationEN_js_1.clsConceptCitationEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsConceptCitationEN_js_1.clsConceptCitationEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ConceptCitation]中不存在！(in ${exports.conceptCitation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsConceptCitationEN_js_1.clsConceptCitationEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsConceptCitationEN_js_1.clsConceptCitationEN.con_ConceptId:
                    return (a, b) => {
                        return b.conceptId.localeCompare(a.conceptId);
                    };
                case clsConceptCitationEN_js_1.clsConceptCitationEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsConceptCitationEN_js_1.clsConceptCitationEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsConceptCitationEN_js_1.clsConceptCitationEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsConceptCitationEN_js_1.clsConceptCitationEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ConceptCitation]中不存在！(in ${exports.conceptCitation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ConceptCitation_SortFunByKey = ConceptCitation_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ConceptCitation_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsConceptCitationEN_js_1.clsConceptCitationEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsConceptCitationEN_js_1.clsConceptCitationEN.con_ConceptId:
                return (obj) => {
                    return obj.conceptId === value;
                };
            case clsConceptCitationEN_js_1.clsConceptCitationEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsConceptCitationEN_js_1.clsConceptCitationEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsConceptCitationEN_js_1.clsConceptCitationEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsConceptCitationEN_js_1.clsConceptCitationEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ConceptCitation]中不存在！(in ${exports.conceptCitation_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ConceptCitation_FilterFunByKey = ConceptCitation_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ConceptCitation_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_GetFirstIDAsync = ConceptCitation_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ConceptCitation_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_GetFirstID = ConceptCitation_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ConceptCitation_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objConceptCitation = ConceptCitation_GetObjFromJsonObj(returnObj);
                return objConceptCitation;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_GetFirstObjAsync = ConceptCitation_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ConceptCitation_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_GetObjLstAsync = ConceptCitation_GetObjLstAsync;
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
    async function ConceptCitation_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_GetObjLstBymIdLstAsync = ConceptCitation_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ConceptCitation_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_GetTopObjLstAsync = ConceptCitation_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ConceptCitation_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_GetObjLstByRangeAsync = ConceptCitation_GetObjLstByRangeAsync;
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
    async function ConceptCitation_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_GetObjLstByRange = ConceptCitation_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ConceptCitation_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_GetObjLstByPagerAsync = ConceptCitation_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function ConceptCitation_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngmId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngmId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_DelRecordAsync = ConceptCitation_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ConceptCitation_DelConceptCitationsAsync(arrmId) {
        const strThisFuncName = "DelConceptCitationsAsync";
        const strAction = "DelConceptCitations";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_DelConceptCitationsAsync = ConceptCitation_DelConceptCitationsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ConceptCitation_DelConceptCitationsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelConceptCitationsByCondAsync";
        const strAction = "DelConceptCitationsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_DelConceptCitationsByCondAsync = ConceptCitation_DelConceptCitationsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objConceptCitationEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ConceptCitation_AddNewRecordAsync(objConceptCitationEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objConceptCitationEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptCitationEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_AddNewRecordAsync = ConceptCitation_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objConceptCitationEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ConceptCitation_AddNewRecordWithReturnKeyAsync(objConceptCitationEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptCitationEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_AddNewRecordWithReturnKeyAsync = ConceptCitation_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objConceptCitationEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ConceptCitation_AddNewRecordWithReturnKey(objConceptCitationEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objConceptCitationEN.mId === null || objConceptCitationEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptCitationEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_AddNewRecordWithReturnKey = ConceptCitation_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objConceptCitationEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ConceptCitation_UpdateRecordAsync(objConceptCitationEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objConceptCitationEN.sf_UpdFldSetStr === undefined || objConceptCitationEN.sf_UpdFldSetStr === null || objConceptCitationEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptCitationEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptCitationEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_UpdateRecordAsync = ConceptCitation_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objConceptCitationEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ConceptCitation_UpdateWithConditionAsync(objConceptCitationEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objConceptCitationEN.sf_UpdFldSetStr === undefined || objConceptCitationEN.sf_UpdFldSetStr === null || objConceptCitationEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptCitationEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
        objConceptCitationEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objConceptCitationEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_UpdateWithConditionAsync = ConceptCitation_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ConceptCitation_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_IsExistRecordAsync = ConceptCitation_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ConceptCitation_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_IsExist = ConceptCitation_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ConceptCitation_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_IsExistAsync = ConceptCitation_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ConceptCitation_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_GetRecCountByCondAsync = ConceptCitation_GetRecCountByCondAsync;
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
    async function ConceptCitation_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptCitation_GetMaxStrIdByPrefix = ConceptCitation_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ConceptCitation_GetWebApiUrl(strController, strAction) {
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
    exports.ConceptCitation_GetWebApiUrl = ConceptCitation_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ConceptCitation_CheckPropertyNew(pobjConceptCitationEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.conceptId) === true) {
            throw new Error("(errid:Watl000058)字段[概念Id]不能为空(In 概念引用)!(clsConceptCitationBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.conceptId) == false && (0, clsString_js_1.GetStrLen)(pobjConceptCitationEN.conceptId) > 8) {
            throw new Error("(errid:Watl000059)字段[概念Id(conceptId)]的长度不能超过8(In 概念引用(ConceptCitation))!值:$(pobjConceptCitationEN.conceptId)(clsConceptCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjConceptCitationEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 概念引用(ConceptCitation))!值:$(pobjConceptCitationEN.paperId)(clsConceptCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjConceptCitationEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 概念引用(ConceptCitation))!值:$(pobjConceptCitationEN.updDate)(clsConceptCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjConceptCitationEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 概念引用(ConceptCitation))!值:$(pobjConceptCitationEN.updUserId)(clsConceptCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjConceptCitationEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 概念引用(ConceptCitation))!值:$(pobjConceptCitationEN.memo)(clsConceptCitationBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjConceptCitationEN.mId && undefined !== pobjConceptCitationEN.mId && jsString_js_1.tzDataType.isNumber(pobjConceptCitationEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjConceptCitationEN.mId)], 非法，应该为数值型(In 概念引用(ConceptCitation))!(clsConceptCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.conceptId) == false && undefined !== pobjConceptCitationEN.conceptId && jsString_js_1.tzDataType.isString(pobjConceptCitationEN.conceptId) === false) {
            throw new Error("(errid:Watl000060)字段[概念Id(conceptId)]的值:[$(pobjConceptCitationEN.conceptId)], 非法，应该为字符型(In 概念引用(ConceptCitation))!(clsConceptCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.paperId) == false && undefined !== pobjConceptCitationEN.paperId && jsString_js_1.tzDataType.isString(pobjConceptCitationEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjConceptCitationEN.paperId)], 非法，应该为字符型(In 概念引用(ConceptCitation))!(clsConceptCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.updDate) == false && undefined !== pobjConceptCitationEN.updDate && jsString_js_1.tzDataType.isString(pobjConceptCitationEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjConceptCitationEN.updDate)], 非法，应该为字符型(In 概念引用(ConceptCitation))!(clsConceptCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.updUserId) == false && undefined !== pobjConceptCitationEN.updUserId && jsString_js_1.tzDataType.isString(pobjConceptCitationEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjConceptCitationEN.updUserId)], 非法，应该为字符型(In 概念引用(ConceptCitation))!(clsConceptCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.memo) == false && undefined !== pobjConceptCitationEN.memo && jsString_js_1.tzDataType.isString(pobjConceptCitationEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjConceptCitationEN.memo)], 非法，应该为字符型(In 概念引用(ConceptCitation))!(clsConceptCitationBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjConceptCitationEN.SetIsCheckProperty(true);
    }
    exports.ConceptCitation_CheckPropertyNew = ConceptCitation_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ConceptCitation_CheckProperty4Update(pobjConceptCitationEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.conceptId) == false && (0, clsString_js_1.GetStrLen)(pobjConceptCitationEN.conceptId) > 8) {
            throw new Error("(errid:Watl000062)字段[概念Id(conceptId)]的长度不能超过8(In 概念引用(ConceptCitation))!值:$(pobjConceptCitationEN.conceptId)(clsConceptCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjConceptCitationEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 概念引用(ConceptCitation))!值:$(pobjConceptCitationEN.paperId)(clsConceptCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjConceptCitationEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 概念引用(ConceptCitation))!值:$(pobjConceptCitationEN.updDate)(clsConceptCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjConceptCitationEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 概念引用(ConceptCitation))!值:$(pobjConceptCitationEN.updUserId)(clsConceptCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjConceptCitationEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 概念引用(ConceptCitation))!值:$(pobjConceptCitationEN.memo)(clsConceptCitationBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjConceptCitationEN.mId && undefined !== pobjConceptCitationEN.mId && jsString_js_1.tzDataType.isNumber(pobjConceptCitationEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjConceptCitationEN.mId)], 非法，应该为数值型(In 概念引用(ConceptCitation))!(clsConceptCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.conceptId) == false && undefined !== pobjConceptCitationEN.conceptId && jsString_js_1.tzDataType.isString(pobjConceptCitationEN.conceptId) === false) {
            throw new Error("(errid:Watl000063)字段[概念Id(conceptId)]的值:[$(pobjConceptCitationEN.conceptId)], 非法，应该为字符型(In 概念引用(ConceptCitation))!(clsConceptCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.paperId) == false && undefined !== pobjConceptCitationEN.paperId && jsString_js_1.tzDataType.isString(pobjConceptCitationEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjConceptCitationEN.paperId)], 非法，应该为字符型(In 概念引用(ConceptCitation))!(clsConceptCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.updDate) == false && undefined !== pobjConceptCitationEN.updDate && jsString_js_1.tzDataType.isString(pobjConceptCitationEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjConceptCitationEN.updDate)], 非法，应该为字符型(In 概念引用(ConceptCitation))!(clsConceptCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.updUserId) == false && undefined !== pobjConceptCitationEN.updUserId && jsString_js_1.tzDataType.isString(pobjConceptCitationEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjConceptCitationEN.updUserId)], 非法，应该为字符型(In 概念引用(ConceptCitation))!(clsConceptCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptCitationEN.memo) == false && undefined !== pobjConceptCitationEN.memo && jsString_js_1.tzDataType.isString(pobjConceptCitationEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjConceptCitationEN.memo)], 非法，应该为字符型(In 概念引用(ConceptCitation))!(clsConceptCitationBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjConceptCitationEN.mId
            || pobjConceptCitationEN.mId != null && pobjConceptCitationEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 概念引用)!(clsConceptCitationBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjConceptCitationEN.SetIsCheckProperty(true);
    }
    exports.ConceptCitation_CheckProperty4Update = ConceptCitation_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ConceptCitation_GetJSONStrByObj(pobjConceptCitationEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjConceptCitationEN.sf_UpdFldSetStr = pobjConceptCitationEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjConceptCitationEN);
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
    exports.ConceptCitation_GetJSONStrByObj = ConceptCitation_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ConceptCitation_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrConceptCitationObjLst = new Array();
        if (strJSON === "") {
            return arrConceptCitationObjLst;
        }
        try {
            arrConceptCitationObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrConceptCitationObjLst;
        }
        return arrConceptCitationObjLst;
    }
    exports.ConceptCitation_GetObjLstByJSONStr = ConceptCitation_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrConceptCitationObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ConceptCitation_GetObjLstByJSONObjLst(arrConceptCitationObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrConceptCitationObjLst = new Array();
        for (const objInFor of arrConceptCitationObjLstS) {
            const obj1 = ConceptCitation_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrConceptCitationObjLst.push(obj1);
        }
        return arrConceptCitationObjLst;
    }
    exports.ConceptCitation_GetObjLstByJSONObjLst = ConceptCitation_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ConceptCitation_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjConceptCitationEN = new clsConceptCitationEN_js_1.clsConceptCitationEN();
        if (strJSON === "") {
            return pobjConceptCitationEN;
        }
        try {
            pobjConceptCitationEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjConceptCitationEN;
        }
        return pobjConceptCitationEN;
    }
    exports.ConceptCitation_GetObjByJSONStr = ConceptCitation_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ConceptCitation_GetCombineCondition(objConceptCitation_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objConceptCitation_Cond.dicFldComparisonOp, clsConceptCitationEN_js_1.clsConceptCitationEN.con_mId) == true) {
            const strComparisonOp_mId = objConceptCitation_Cond.dicFldComparisonOp[clsConceptCitationEN_js_1.clsConceptCitationEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsConceptCitationEN_js_1.clsConceptCitationEN.con_mId, objConceptCitation_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptCitation_Cond.dicFldComparisonOp, clsConceptCitationEN_js_1.clsConceptCitationEN.con_ConceptId) == true) {
            const strComparisonOp_ConceptId = objConceptCitation_Cond.dicFldComparisonOp[clsConceptCitationEN_js_1.clsConceptCitationEN.con_ConceptId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptCitationEN_js_1.clsConceptCitationEN.con_ConceptId, objConceptCitation_Cond.conceptId, strComparisonOp_ConceptId);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptCitation_Cond.dicFldComparisonOp, clsConceptCitationEN_js_1.clsConceptCitationEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objConceptCitation_Cond.dicFldComparisonOp[clsConceptCitationEN_js_1.clsConceptCitationEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptCitationEN_js_1.clsConceptCitationEN.con_PaperId, objConceptCitation_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptCitation_Cond.dicFldComparisonOp, clsConceptCitationEN_js_1.clsConceptCitationEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objConceptCitation_Cond.dicFldComparisonOp[clsConceptCitationEN_js_1.clsConceptCitationEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptCitationEN_js_1.clsConceptCitationEN.con_UpdDate, objConceptCitation_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptCitation_Cond.dicFldComparisonOp, clsConceptCitationEN_js_1.clsConceptCitationEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objConceptCitation_Cond.dicFldComparisonOp[clsConceptCitationEN_js_1.clsConceptCitationEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptCitationEN_js_1.clsConceptCitationEN.con_UpdUserId, objConceptCitation_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptCitation_Cond.dicFldComparisonOp, clsConceptCitationEN_js_1.clsConceptCitationEN.con_Memo) == true) {
            const strComparisonOp_Memo = objConceptCitation_Cond.dicFldComparisonOp[clsConceptCitationEN_js_1.clsConceptCitationEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptCitationEN_js_1.clsConceptCitationEN.con_Memo, objConceptCitation_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ConceptCitation_GetCombineCondition = ConceptCitation_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ConceptCitation(概念引用),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @param strConceptId: 概念Id(要求唯一的字段)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ConceptCitation_GetUniCondStr_mId_ConceptId_PaperId(objConceptCitationEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objConceptCitationEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptId = '{0}'", objConceptCitationEN.conceptId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objConceptCitationEN.paperId);
        return strWhereCond;
    }
    exports.ConceptCitation_GetUniCondStr_mId_ConceptId_PaperId = ConceptCitation_GetUniCondStr_mId_ConceptId_PaperId;
    /**
    *获取唯一性条件串(Uniqueness)--ConceptCitation(概念引用),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @param strConceptId: 概念Id(要求唯一的字段)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ConceptCitation_GetUniCondStr4Update_mId_ConceptId_PaperId(objConceptCitationEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objConceptCitationEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objConceptCitationEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptId = '{0}'", objConceptCitationEN.conceptId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objConceptCitationEN.paperId);
        return strWhereCond;
    }
    exports.ConceptCitation_GetUniCondStr4Update_mId_ConceptId_PaperId = ConceptCitation_GetUniCondStr4Update_mId_ConceptId_PaperId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objConceptCitationENS:源对象
     * @param objConceptCitationENT:目标对象
    */
    function ConceptCitation_CopyObjTo(objConceptCitationENS, objConceptCitationENT) {
        objConceptCitationENT.mId = objConceptCitationENS.mId; //mId
        objConceptCitationENT.conceptId = objConceptCitationENS.conceptId; //概念Id
        objConceptCitationENT.paperId = objConceptCitationENS.paperId; //论文Id
        objConceptCitationENT.updDate = objConceptCitationENS.updDate; //修改日期
        objConceptCitationENT.updUserId = objConceptCitationENS.updUserId; //修改用户Id
        objConceptCitationENT.memo = objConceptCitationENS.memo; //备注
        objConceptCitationENT.sf_UpdFldSetStr = objConceptCitationENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ConceptCitation_CopyObjTo = ConceptCitation_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objConceptCitationENS:源对象
     * @param objConceptCitationENT:目标对象
    */
    function ConceptCitation_GetObjFromJsonObj(objConceptCitationENS) {
        const objConceptCitationENT = new clsConceptCitationEN_js_1.clsConceptCitationEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objConceptCitationENT, objConceptCitationENS);
        return objConceptCitationENT;
    }
    exports.ConceptCitation_GetObjFromJsonObj = ConceptCitation_GetObjFromJsonObj;
});
