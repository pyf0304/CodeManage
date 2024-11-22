/**
* 类名:clsConceptVWApi
* 表名:ConceptV(01120649)
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsConceptVEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ConceptV_GetObjFromJsonObj = exports.ConceptV_CopyObjTo = exports.ConceptV_GetUniCondStr4Update_ConceptVId = exports.ConceptV_GetUniCondStr_ConceptVId = exports.ConceptV_GetCombineCondition = exports.ConceptV_GetObjByJSONStr = exports.ConceptV_GetObjLstByJSONObjLst = exports.ConceptV_GetObjLstByJSONStr = exports.ConceptV_GetJSONStrByObj = exports.ConceptV_CheckProperty4Update = exports.ConceptV_CheckPropertyNew = exports.ConceptV_GetWebApiUrl = exports.ConceptV_GetMaxStrIdByPrefix = exports.ConceptV_GetRecCountByCondAsync = exports.ConceptV_IsExistAsync = exports.ConceptV_IsExist = exports.ConceptV_IsExistRecordAsync = exports.ConceptV_UpdateWithConditionAsync = exports.ConceptV_UpdateRecordAsync = exports.ConceptV_AddNewRecordWithReturnKey = exports.ConceptV_AddNewRecordWithReturnKeyAsync = exports.ConceptV_AddNewRecordAsync = exports.ConceptV_DelConceptVsByCondAsync = exports.ConceptV_DelConceptVsAsync = exports.ConceptV_DelRecordAsync = exports.ConceptV_GetObjLstByPagerAsync = exports.ConceptV_GetObjLstByRange = exports.ConceptV_GetObjLstByRangeAsync = exports.ConceptV_GetTopObjLstAsync = exports.ConceptV_GetObjLstByConceptVIdLstAsync = exports.ConceptV_GetObjLstAsync = exports.ConceptV_GetFirstObjAsync = exports.ConceptV_GetFirstID = exports.ConceptV_GetFirstIDAsync = exports.ConceptV_FilterFunByKey = exports.ConceptV_SortFunByKey = exports.ConceptV_SortFun_Defa_2Fld = exports.ConceptV_SortFun_Defa = exports.ConceptV_GetObjByConceptVIdAsync = exports.conceptV_ConstructorName = exports.conceptV_Controller = void 0;
    /**
     * 概念版本表(ConceptV)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsConceptVEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsConceptVEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.conceptV_Controller = "ConceptVApi";
    exports.conceptV_ConstructorName = "conceptV";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngConceptVId:关键字
    * @returns 对象
    **/
    async function ConceptV_GetObjByConceptVIdAsync(lngConceptVId) {
        const strThisFuncName = "GetObjByConceptVIdAsync";
        if (lngConceptVId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngConceptVId]不能为空！(In GetObjByConceptVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByConceptVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngConceptVId": lngConceptVId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objConceptV = ConceptV_GetObjFromJsonObj(returnObj);
                return objConceptV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_GetObjByConceptVIdAsync = ConceptV_GetObjByConceptVIdAsync;
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
    function ConceptV_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.conceptVId - b.conceptVId;
    }
    exports.ConceptV_SortFun_Defa = ConceptV_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ConceptV_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.conceptId == b.conceptId)
            return a.conceptContent.localeCompare(b.conceptContent);
        else
            return a.conceptId.localeCompare(b.conceptId);
    }
    exports.ConceptV_SortFun_Defa_2Fld = ConceptV_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ConceptV_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsConceptVEN_js_1.clsConceptVEN.con_ConceptVId:
                    return (a, b) => {
                        return a.conceptVId - b.conceptVId;
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_ConceptId:
                    return (a, b) => {
                        return a.conceptId.localeCompare(b.conceptId);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_ConceptContent:
                    return (a, b) => {
                        return a.conceptContent.localeCompare(b.conceptContent);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_ConceptName:
                    return (a, b) => {
                        return a.conceptName.localeCompare(b.conceptName);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_CitationId:
                    return (a, b) => {
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_PdfContent:
                    return (a, b) => {
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ConceptV]中不存在！(in ${exports.conceptV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsConceptVEN_js_1.clsConceptVEN.con_ConceptVId:
                    return (a, b) => {
                        return b.conceptVId - a.conceptVId;
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_ConceptId:
                    return (a, b) => {
                        return b.conceptId.localeCompare(a.conceptId);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_ConceptContent:
                    return (a, b) => {
                        return b.conceptContent.localeCompare(a.conceptContent);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_ConceptName:
                    return (a, b) => {
                        return b.conceptName.localeCompare(a.conceptName);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_CitationId:
                    return (a, b) => {
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_PdfContent:
                    return (a, b) => {
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsConceptVEN_js_1.clsConceptVEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ConceptV]中不存在！(in ${exports.conceptV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ConceptV_SortFunByKey = ConceptV_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ConceptV_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsConceptVEN_js_1.clsConceptVEN.con_ConceptVId:
                return (obj) => {
                    return obj.conceptVId === value;
                };
            case clsConceptVEN_js_1.clsConceptVEN.con_ConceptId:
                return (obj) => {
                    return obj.conceptId === value;
                };
            case clsConceptVEN_js_1.clsConceptVEN.con_ConceptContent:
                return (obj) => {
                    return obj.conceptContent === value;
                };
            case clsConceptVEN_js_1.clsConceptVEN.con_ConceptName:
                return (obj) => {
                    return obj.conceptName === value;
                };
            case clsConceptVEN_js_1.clsConceptVEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsConceptVEN_js_1.clsConceptVEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsConceptVEN_js_1.clsConceptVEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsConceptVEN_js_1.clsConceptVEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsConceptVEN_js_1.clsConceptVEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsConceptVEN_js_1.clsConceptVEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsConceptVEN_js_1.clsConceptVEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ConceptV]中不存在！(in ${exports.conceptV_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ConceptV_FilterFunByKey = ConceptV_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ConceptV_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_GetFirstIDAsync = ConceptV_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ConceptV_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_GetFirstID = ConceptV_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ConceptV_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objConceptV = ConceptV_GetObjFromJsonObj(returnObj);
                return objConceptV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_GetFirstObjAsync = ConceptV_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ConceptV_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_GetObjLstAsync = ConceptV_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrConceptVId:关键字列表
    * @returns 对象列表
    **/
    async function ConceptV_GetObjLstByConceptVIdLstAsync(arrConceptVId) {
        const strThisFuncName = "GetObjLstByConceptVIdLstAsync";
        const strAction = "GetObjLstByConceptVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrConceptVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_GetObjLstByConceptVIdLstAsync = ConceptV_GetObjLstByConceptVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ConceptV_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_GetTopObjLstAsync = ConceptV_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ConceptV_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_GetObjLstByRangeAsync = ConceptV_GetObjLstByRangeAsync;
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
    async function ConceptV_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_GetObjLstByRange = ConceptV_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ConceptV_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_GetObjLstByPagerAsync = ConceptV_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngConceptVId:关键字
    * @returns 获取删除的结果
    **/
    async function ConceptV_DelRecordAsync(lngConceptVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngConceptVId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngConceptVId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_DelRecordAsync = ConceptV_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrConceptVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ConceptV_DelConceptVsAsync(arrConceptVId) {
        const strThisFuncName = "DelConceptVsAsync";
        const strAction = "DelConceptVs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrConceptVId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_DelConceptVsAsync = ConceptV_DelConceptVsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ConceptV_DelConceptVsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelConceptVsByCondAsync";
        const strAction = "DelConceptVsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_DelConceptVsByCondAsync = ConceptV_DelConceptVsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objConceptVEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ConceptV_AddNewRecordAsync(objConceptVEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objConceptVEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_AddNewRecordAsync = ConceptV_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objConceptVEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ConceptV_AddNewRecordWithReturnKeyAsync(objConceptVEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_AddNewRecordWithReturnKeyAsync = ConceptV_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objConceptVEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ConceptV_AddNewRecordWithReturnKey(objConceptVEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objConceptVEN.conceptVId === null || objConceptVEN.conceptVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptVEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_AddNewRecordWithReturnKey = ConceptV_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objConceptVEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ConceptV_UpdateRecordAsync(objConceptVEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objConceptVEN.sf_UpdFldSetStr === undefined || objConceptVEN.sf_UpdFldSetStr === null || objConceptVEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptVEN.conceptVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_UpdateRecordAsync = ConceptV_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objConceptVEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ConceptV_UpdateWithConditionAsync(objConceptVEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objConceptVEN.sf_UpdFldSetStr === undefined || objConceptVEN.sf_UpdFldSetStr === null || objConceptVEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptVEN.conceptVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        objConceptVEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objConceptVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_UpdateWithConditionAsync = ConceptV_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ConceptV_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_IsExistRecordAsync = ConceptV_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngConceptVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ConceptV_IsExist(lngConceptVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ConceptVId": lngConceptVId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_IsExist = ConceptV_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngConceptVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ConceptV_IsExistAsync(lngConceptVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngConceptVId": lngConceptVId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_IsExistAsync = ConceptV_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ConceptV_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_GetRecCountByCondAsync = ConceptV_GetRecCountByCondAsync;
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
    async function ConceptV_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptV_GetMaxStrIdByPrefix = ConceptV_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ConceptV_GetWebApiUrl(strController, strAction) {
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
    exports.ConceptV_GetWebApiUrl = ConceptV_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ConceptV_CheckPropertyNew(pobjConceptVEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.conceptId) === true) {
            throw new Error("(errid:Watl000058)字段[概念Id]不能为空(In 概念版本表)!(clsConceptVBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.conceptId) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.conceptId) > 8) {
            throw new Error("(errid:Watl000059)字段[概念Id(conceptId)]的长度不能超过8(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.conceptId)(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.conceptName) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.conceptName) > 500) {
            throw new Error("(errid:Watl000059)字段[概念名称(conceptName)]的长度不能超过500(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.conceptName)(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.citationId) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.citationId) > 8) {
            throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.citationId)(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.updDate)(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.updUser)(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.id_CurrEduCls)(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.pdfContent) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.pdfContent)(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.memo)(clsConceptVBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjConceptVEN.conceptVId && undefined !== pobjConceptVEN.conceptVId && jsString_js_1.tzDataType.isNumber(pobjConceptVEN.conceptVId) === false) {
            throw new Error("(errid:Watl000060)字段[ConceptVId(conceptVId)]的值:[$(pobjConceptVEN.conceptVId)], 非法，应该为数值型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.conceptId) == false && undefined !== pobjConceptVEN.conceptId && jsString_js_1.tzDataType.isString(pobjConceptVEN.conceptId) === false) {
            throw new Error("(errid:Watl000060)字段[概念Id(conceptId)]的值:[$(pobjConceptVEN.conceptId)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.conceptContent) == false && undefined !== pobjConceptVEN.conceptContent && jsString_js_1.tzDataType.isString(pobjConceptVEN.conceptContent) === false) {
            throw new Error("(errid:Watl000060)字段[概念内容(conceptContent)]的值:[$(pobjConceptVEN.conceptContent)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.conceptName) == false && undefined !== pobjConceptVEN.conceptName && jsString_js_1.tzDataType.isString(pobjConceptVEN.conceptName) === false) {
            throw new Error("(errid:Watl000060)字段[概念名称(conceptName)]的值:[$(pobjConceptVEN.conceptName)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.citationId) == false && undefined !== pobjConceptVEN.citationId && jsString_js_1.tzDataType.isString(pobjConceptVEN.citationId) === false) {
            throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjConceptVEN.citationId)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.updDate) == false && undefined !== pobjConceptVEN.updDate && jsString_js_1.tzDataType.isString(pobjConceptVEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjConceptVEN.updDate)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.updUser) == false && undefined !== pobjConceptVEN.updUser && jsString_js_1.tzDataType.isString(pobjConceptVEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjConceptVEN.updUser)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.id_CurrEduCls) == false && undefined !== pobjConceptVEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjConceptVEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjConceptVEN.id_CurrEduCls)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.pdfContent) == false && undefined !== pobjConceptVEN.pdfContent && jsString_js_1.tzDataType.isString(pobjConceptVEN.pdfContent) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjConceptVEN.pdfContent)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
        }
        if (null != pobjConceptVEN.pdfPageNum && undefined !== pobjConceptVEN.pdfPageNum && jsString_js_1.tzDataType.isNumber(pobjConceptVEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjConceptVEN.pdfPageNum)], 非法，应该为数值型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.memo) == false && undefined !== pobjConceptVEN.memo && jsString_js_1.tzDataType.isString(pobjConceptVEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjConceptVEN.memo)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjConceptVEN.SetIsCheckProperty(true);
    }
    exports.ConceptV_CheckPropertyNew = ConceptV_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ConceptV_CheckProperty4Update(pobjConceptVEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.conceptId) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.conceptId) > 8) {
            throw new Error("(errid:Watl000062)字段[概念Id(conceptId)]的长度不能超过8(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.conceptId)(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.conceptName) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.conceptName) > 500) {
            throw new Error("(errid:Watl000062)字段[概念名称(conceptName)]的长度不能超过500(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.conceptName)(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.citationId) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.citationId) > 8) {
            throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.citationId)(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.updDate)(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.updUser)(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.id_CurrEduCls)(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.pdfContent) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.pdfContent)(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjConceptVEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.memo)(clsConceptVBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjConceptVEN.conceptVId && undefined !== pobjConceptVEN.conceptVId && jsString_js_1.tzDataType.isNumber(pobjConceptVEN.conceptVId) === false) {
            throw new Error("(errid:Watl000063)字段[ConceptVId(conceptVId)]的值:[$(pobjConceptVEN.conceptVId)], 非法，应该为数值型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.conceptId) == false && undefined !== pobjConceptVEN.conceptId && jsString_js_1.tzDataType.isString(pobjConceptVEN.conceptId) === false) {
            throw new Error("(errid:Watl000063)字段[概念Id(conceptId)]的值:[$(pobjConceptVEN.conceptId)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.conceptContent) == false && undefined !== pobjConceptVEN.conceptContent && jsString_js_1.tzDataType.isString(pobjConceptVEN.conceptContent) === false) {
            throw new Error("(errid:Watl000063)字段[概念内容(conceptContent)]的值:[$(pobjConceptVEN.conceptContent)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.conceptName) == false && undefined !== pobjConceptVEN.conceptName && jsString_js_1.tzDataType.isString(pobjConceptVEN.conceptName) === false) {
            throw new Error("(errid:Watl000063)字段[概念名称(conceptName)]的值:[$(pobjConceptVEN.conceptName)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.citationId) == false && undefined !== pobjConceptVEN.citationId && jsString_js_1.tzDataType.isString(pobjConceptVEN.citationId) === false) {
            throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjConceptVEN.citationId)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.updDate) == false && undefined !== pobjConceptVEN.updDate && jsString_js_1.tzDataType.isString(pobjConceptVEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjConceptVEN.updDate)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.updUser) == false && undefined !== pobjConceptVEN.updUser && jsString_js_1.tzDataType.isString(pobjConceptVEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjConceptVEN.updUser)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.id_CurrEduCls) == false && undefined !== pobjConceptVEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjConceptVEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjConceptVEN.id_CurrEduCls)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.pdfContent) == false && undefined !== pobjConceptVEN.pdfContent && jsString_js_1.tzDataType.isString(pobjConceptVEN.pdfContent) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjConceptVEN.pdfContent)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
        }
        if (null != pobjConceptVEN.pdfPageNum && undefined !== pobjConceptVEN.pdfPageNum && jsString_js_1.tzDataType.isNumber(pobjConceptVEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjConceptVEN.pdfPageNum)], 非法，应该为数值型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjConceptVEN.memo) == false && undefined !== pobjConceptVEN.memo && jsString_js_1.tzDataType.isString(pobjConceptVEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjConceptVEN.memo)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjConceptVEN.conceptVId
            || pobjConceptVEN.conceptVId != null && pobjConceptVEN.conceptVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[ConceptVId]不能为空(In 概念版本表)!(clsConceptVBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjConceptVEN.SetIsCheckProperty(true);
    }
    exports.ConceptV_CheckProperty4Update = ConceptV_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ConceptV_GetJSONStrByObj(pobjConceptVEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjConceptVEN.sf_UpdFldSetStr = pobjConceptVEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjConceptVEN);
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
    exports.ConceptV_GetJSONStrByObj = ConceptV_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ConceptV_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrConceptVObjLst = new Array();
        if (strJSON === "") {
            return arrConceptVObjLst;
        }
        try {
            arrConceptVObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrConceptVObjLst;
        }
        return arrConceptVObjLst;
    }
    exports.ConceptV_GetObjLstByJSONStr = ConceptV_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrConceptVObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ConceptV_GetObjLstByJSONObjLst(arrConceptVObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrConceptVObjLst = new Array();
        for (const objInFor of arrConceptVObjLstS) {
            const obj1 = ConceptV_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrConceptVObjLst.push(obj1);
        }
        return arrConceptVObjLst;
    }
    exports.ConceptV_GetObjLstByJSONObjLst = ConceptV_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ConceptV_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjConceptVEN = new clsConceptVEN_js_1.clsConceptVEN();
        if (strJSON === "") {
            return pobjConceptVEN;
        }
        try {
            pobjConceptVEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjConceptVEN;
        }
        return pobjConceptVEN;
    }
    exports.ConceptV_GetObjByJSONStr = ConceptV_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ConceptV_GetCombineCondition(objConceptV_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN_js_1.clsConceptVEN.con_ConceptVId) == true) {
            const strComparisonOp_ConceptVId = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN_js_1.clsConceptVEN.con_ConceptVId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsConceptVEN_js_1.clsConceptVEN.con_ConceptVId, objConceptV_Cond.conceptVId, strComparisonOp_ConceptVId);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN_js_1.clsConceptVEN.con_ConceptId) == true) {
            const strComparisonOp_ConceptId = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN_js_1.clsConceptVEN.con_ConceptId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptVEN_js_1.clsConceptVEN.con_ConceptId, objConceptV_Cond.conceptId, strComparisonOp_ConceptId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN_js_1.clsConceptVEN.con_ConceptName) == true) {
            const strComparisonOp_ConceptName = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN_js_1.clsConceptVEN.con_ConceptName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptVEN_js_1.clsConceptVEN.con_ConceptName, objConceptV_Cond.conceptName, strComparisonOp_ConceptName);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN_js_1.clsConceptVEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN_js_1.clsConceptVEN.con_CitationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptVEN_js_1.clsConceptVEN.con_CitationId, objConceptV_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN_js_1.clsConceptVEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN_js_1.clsConceptVEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptVEN_js_1.clsConceptVEN.con_UpdDate, objConceptV_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN_js_1.clsConceptVEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN_js_1.clsConceptVEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptVEN_js_1.clsConceptVEN.con_UpdUser, objConceptV_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN_js_1.clsConceptVEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN_js_1.clsConceptVEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptVEN_js_1.clsConceptVEN.con_id_CurrEduCls, objConceptV_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN_js_1.clsConceptVEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN_js_1.clsConceptVEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptVEN_js_1.clsConceptVEN.con_PdfContent, objConceptV_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN_js_1.clsConceptVEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN_js_1.clsConceptVEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsConceptVEN_js_1.clsConceptVEN.con_PdfPageNum, objConceptV_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN_js_1.clsConceptVEN.con_Memo) == true) {
            const strComparisonOp_Memo = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN_js_1.clsConceptVEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsConceptVEN_js_1.clsConceptVEN.con_Memo, objConceptV_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ConceptV_GetCombineCondition = ConceptV_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ConceptV(概念版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngConceptVId: ConceptVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ConceptV_GetUniCondStr_ConceptVId(objConceptVEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptVId = '{0}'", objConceptVEN.conceptVId);
        return strWhereCond;
    }
    exports.ConceptV_GetUniCondStr_ConceptVId = ConceptV_GetUniCondStr_ConceptVId;
    /**
    *获取唯一性条件串(Uniqueness)--ConceptV(概念版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngConceptVId: ConceptVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ConceptV_GetUniCondStr4Update_ConceptVId(objConceptVEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptVId <> '{0}'", objConceptVEN.conceptVId);
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptVId = '{0}'", objConceptVEN.conceptVId);
        return strWhereCond;
    }
    exports.ConceptV_GetUniCondStr4Update_ConceptVId = ConceptV_GetUniCondStr4Update_ConceptVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objConceptVENS:源对象
     * @param objConceptVENT:目标对象
    */
    function ConceptV_CopyObjTo(objConceptVENS, objConceptVENT) {
        objConceptVENT.conceptVId = objConceptVENS.conceptVId; //ConceptVId
        objConceptVENT.conceptId = objConceptVENS.conceptId; //概念Id
        objConceptVENT.conceptContent = objConceptVENS.conceptContent; //概念内容
        objConceptVENT.conceptName = objConceptVENS.conceptName; //概念名称
        objConceptVENT.citationId = objConceptVENS.citationId; //引用Id
        objConceptVENT.updDate = objConceptVENS.updDate; //修改日期
        objConceptVENT.updUser = objConceptVENS.updUser; //修改人
        objConceptVENT.id_CurrEduCls = objConceptVENS.id_CurrEduCls; //教学班流水号
        objConceptVENT.pdfContent = objConceptVENS.pdfContent; //Pdf内容
        objConceptVENT.pdfPageNum = objConceptVENS.pdfPageNum; //Pdf页码
        objConceptVENT.memo = objConceptVENS.memo; //备注
        objConceptVENT.sf_UpdFldSetStr = objConceptVENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ConceptV_CopyObjTo = ConceptV_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objConceptVENS:源对象
     * @param objConceptVENT:目标对象
    */
    function ConceptV_GetObjFromJsonObj(objConceptVENS) {
        const objConceptVENT = new clsConceptVEN_js_1.clsConceptVEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objConceptVENT, objConceptVENS);
        return objConceptVENT;
    }
    exports.ConceptV_GetObjFromJsonObj = ConceptV_GetObjFromJsonObj;
});
