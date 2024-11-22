/**
* 类名:clsConceptVerWApi
* 表名:ConceptVer(01120649)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:48:19
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsConceptVerEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ConceptVer_GetObjFromJsonObj = exports.ConceptVer_CopyObjTo = exports.ConceptVer_GetUniCondStr4Update_ConceptVId = exports.ConceptVer_GetUniCondStr_ConceptVId = exports.ConceptVer_GetCombineCondition = exports.ConceptVer_GetObjByJSONStr = exports.ConceptVer_GetObjLstByJSONObjLst = exports.ConceptVer_GetObjLstByJSONStr = exports.ConceptVer_GetJSONStrByObj = exports.ConceptVer_CheckProperty4Update = exports.ConceptVer_CheckPropertyNew = exports.ConceptVer_GetWebApiUrl = exports.ConceptVer_GetMaxStrIdByPrefix = exports.ConceptVer_GetRecCountByCondAsync = exports.ConceptVer_IsExistAsync = exports.ConceptVer_IsExist = exports.ConceptVer_IsExistRecordAsync = exports.ConceptVer_UpdateWithConditionAsync = exports.ConceptVer_UpdateRecordAsync = exports.ConceptVer_AddNewRecordWithReturnKey = exports.ConceptVer_AddNewRecordWithReturnKeyAsync = exports.ConceptVer_AddNewRecordAsync = exports.ConceptVer_DelConceptVersByCondAsync = exports.ConceptVer_DelConceptVersAsync = exports.ConceptVer_DelRecordAsync = exports.ConceptVer_GetObjLstByPagerAsync = exports.ConceptVer_GetObjLstByRange = exports.ConceptVer_GetObjLstByRangeAsync = exports.ConceptVer_GetTopObjLstAsync = exports.ConceptVer_GetObjLstByConceptVIdLstAsync = exports.ConceptVer_GetObjLstAsync = exports.ConceptVer_GetFirstObjAsync = exports.ConceptVer_GetFirstID = exports.ConceptVer_GetFirstIDAsync = exports.ConceptVer_FilterFunByKey = exports.ConceptVer_SortFunByKey = exports.ConceptVer_SortFun_Defa_2Fld = exports.ConceptVer_SortFun_Defa = exports.ConceptVer_GetObjByConceptVIdAsync = exports.conceptVer_ConstructorName = exports.conceptVer_Controller = void 0;
    /**
     * 概念版本表(ConceptVer)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsConceptVerEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsConceptVerEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.conceptVer_Controller = "ConceptVerApi";
    exports.conceptVer_ConstructorName = "conceptVer";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngConceptVId:关键字
    * @returns 对象
    **/
    async function ConceptVer_GetObjByConceptVIdAsync(lngConceptVId) {
        const strThisFuncName = "GetObjByConceptVIdAsync";
        if (lngConceptVId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngConceptVId]不能为空！(In clsConceptVerWApi.GetObjByConceptVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByConceptVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
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
                    return null;
                }
                //console.log(returnObj);
                const objConceptVer = ConceptVer_GetObjFromJsonObj(returnObj);
                return objConceptVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_GetObjByConceptVIdAsync = ConceptVer_GetObjByConceptVIdAsync;
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
    function ConceptVer_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.conceptVId - b.conceptVId;
    }
    exports.ConceptVer_SortFun_Defa = ConceptVer_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ConceptVer_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.conceptId == b.conceptId)
            return a.conceptContent.localeCompare(b.conceptContent);
        else
            return a.conceptId.localeCompare(b.conceptId);
    }
    exports.ConceptVer_SortFun_Defa_2Fld = ConceptVer_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ConceptVer_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptVId:
                    return (a, b) => {
                        return a.conceptVId - b.conceptVId;
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptId:
                    return (a, b) => {
                        return a.conceptId.localeCompare(b.conceptId);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptContent:
                    return (a, b) => {
                        if (a.conceptContent == null)
                            return -1;
                        if (b.conceptContent == null)
                            return 1;
                        return a.conceptContent.localeCompare(b.conceptContent);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptName:
                    return (a, b) => {
                        if (a.conceptName == null)
                            return -1;
                        if (b.conceptName == null)
                            return 1;
                        return a.conceptName.localeCompare(b.conceptName);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_CitationId:
                    return (a, b) => {
                        if (a.citationId == null)
                            return -1;
                        if (b.citationId == null)
                            return 1;
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_PdfContent:
                    return (a, b) => {
                        if (a.pdfContent == null)
                            return -1;
                        if (b.pdfContent == null)
                            return 1;
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ConceptVer]中不存在！(in ${exports.conceptVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptVId:
                    return (a, b) => {
                        return b.conceptVId - a.conceptVId;
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptId:
                    return (a, b) => {
                        return b.conceptId.localeCompare(a.conceptId);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptContent:
                    return (a, b) => {
                        if (b.conceptContent == null)
                            return -1;
                        if (a.conceptContent == null)
                            return 1;
                        return b.conceptContent.localeCompare(a.conceptContent);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptName:
                    return (a, b) => {
                        if (b.conceptName == null)
                            return -1;
                        if (a.conceptName == null)
                            return 1;
                        return b.conceptName.localeCompare(a.conceptName);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_CitationId:
                    return (a, b) => {
                        if (b.citationId == null)
                            return -1;
                        if (a.citationId == null)
                            return 1;
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_PdfContent:
                    return (a, b) => {
                        if (b.pdfContent == null)
                            return -1;
                        if (a.pdfContent == null)
                            return 1;
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsConceptVerEN_js_1.clsConceptVerEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ConceptVer]中不存在！(in ${exports.conceptVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ConceptVer_SortFunByKey = ConceptVer_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ConceptVer_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptVId:
                return (obj) => {
                    return obj.conceptVId === value;
                };
            case clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptId:
                return (obj) => {
                    return obj.conceptId === value;
                };
            case clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptContent:
                return (obj) => {
                    return obj.conceptContent === value;
                };
            case clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptName:
                return (obj) => {
                    return obj.conceptName === value;
                };
            case clsConceptVerEN_js_1.clsConceptVerEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsConceptVerEN_js_1.clsConceptVerEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsConceptVerEN_js_1.clsConceptVerEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsConceptVerEN_js_1.clsConceptVerEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsConceptVerEN_js_1.clsConceptVerEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsConceptVerEN_js_1.clsConceptVerEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsConceptVerEN_js_1.clsConceptVerEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ConceptVer]中不存在！(in ${exports.conceptVer_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ConceptVer_FilterFunByKey = ConceptVer_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ConceptVer_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_GetFirstIDAsync = ConceptVer_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ConceptVer_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_GetFirstID = ConceptVer_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ConceptVer_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
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
                const objConceptVer = ConceptVer_GetObjFromJsonObj(returnObj);
                return objConceptVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_GetFirstObjAsync = ConceptVer_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ConceptVer_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_GetObjLstAsync = ConceptVer_GetObjLstAsync;
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
    async function ConceptVer_GetObjLstByConceptVIdLstAsync(arrConceptVId) {
        const strThisFuncName = "GetObjLstByConceptVIdLstAsync";
        const strAction = "GetObjLstByConceptVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrConceptVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_GetObjLstByConceptVIdLstAsync = ConceptVer_GetObjLstByConceptVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ConceptVer_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_GetTopObjLstAsync = ConceptVer_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ConceptVer_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_GetObjLstByRangeAsync = ConceptVer_GetObjLstByRangeAsync;
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
    async function ConceptVer_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_GetObjLstByRange = ConceptVer_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ConceptVer_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_GetObjLstByPagerAsync = ConceptVer_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngConceptVId:关键字
    * @returns 获取删除的结果
    **/
    async function ConceptVer_DelRecordAsync(lngConceptVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngConceptVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_DelRecordAsync = ConceptVer_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrConceptVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ConceptVer_DelConceptVersAsync(arrConceptVId) {
        const strThisFuncName = "DelConceptVersAsync";
        const strAction = "DelConceptVers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_DelConceptVersAsync = ConceptVer_DelConceptVersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ConceptVer_DelConceptVersByCondAsync(strWhereCond) {
        const strThisFuncName = "DelConceptVersByCondAsync";
        const strAction = "DelConceptVersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_DelConceptVersByCondAsync = ConceptVer_DelConceptVersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objConceptVerEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ConceptVer_AddNewRecordAsync(objConceptVerEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objConceptVerEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_AddNewRecordAsync = ConceptVer_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objConceptVerEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ConceptVer_AddNewRecordWithReturnKeyAsync(objConceptVerEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_AddNewRecordWithReturnKeyAsync = ConceptVer_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objConceptVerEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ConceptVer_AddNewRecordWithReturnKey(objConceptVerEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objConceptVerEN.conceptVId === null || objConceptVerEN.conceptVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptVerEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_AddNewRecordWithReturnKey = ConceptVer_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objConceptVerEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ConceptVer_UpdateRecordAsync(objConceptVerEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objConceptVerEN.sf_UpdFldSetStr === undefined || objConceptVerEN.sf_UpdFldSetStr === null || objConceptVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptVerEN.conceptVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_UpdateRecordAsync = ConceptVer_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objConceptVerEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ConceptVer_UpdateWithConditionAsync(objConceptVerEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objConceptVerEN.sf_UpdFldSetStr === undefined || objConceptVerEN.sf_UpdFldSetStr === null || objConceptVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptVerEN.conceptVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
        objConceptVerEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objConceptVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_UpdateWithConditionAsync = ConceptVer_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ConceptVer_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_IsExistRecordAsync = ConceptVer_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngConceptVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ConceptVer_IsExist(lngConceptVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_IsExist = ConceptVer_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngConceptVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ConceptVer_IsExistAsync(lngConceptVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_IsExistAsync = ConceptVer_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ConceptVer_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_GetRecCountByCondAsync = ConceptVer_GetRecCountByCondAsync;
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
    async function ConceptVer_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptVer_GetMaxStrIdByPrefix = ConceptVer_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ConceptVer_GetWebApiUrl(strController, strAction) {
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
    exports.ConceptVer_GetWebApiUrl = ConceptVer_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ConceptVer_CheckPropertyNew(pobjConceptVerEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.conceptId) === true) {
            throw new Error("(errid:Watl000058)字段[概念Id]不能为空(In 概念版本表)!(clsConceptVerBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.conceptId) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.conceptId) > 8) {
            throw new Error("(errid:Watl000059)字段[概念Id(conceptId)]的长度不能超过8(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.conceptId)(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.conceptName) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.conceptName) > 500) {
            throw new Error("(errid:Watl000059)字段[概念名称(conceptName)]的长度不能超过500(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.conceptName)(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.citationId) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.citationId) > 8) {
            throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.citationId)(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.updDate)(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.updUser)(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.id_CurrEduCls)(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.pdfContent)(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.memo)(clsConceptVerBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjConceptVerEN.conceptVId && undefined !== pobjConceptVerEN.conceptVId && clsString_js_1.tzDataType.isNumber(pobjConceptVerEN.conceptVId) === false) {
            throw new Error("(errid:Watl000060)字段[ConceptVId(conceptVId)]的值:[$(pobjConceptVerEN.conceptVId)], 非法，应该为数值型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.conceptId) == false && undefined !== pobjConceptVerEN.conceptId && clsString_js_1.tzDataType.isString(pobjConceptVerEN.conceptId) === false) {
            throw new Error("(errid:Watl000060)字段[概念Id(conceptId)]的值:[$(pobjConceptVerEN.conceptId)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.conceptContent) == false && undefined !== pobjConceptVerEN.conceptContent && clsString_js_1.tzDataType.isString(pobjConceptVerEN.conceptContent) === false) {
            throw new Error("(errid:Watl000060)字段[概念内容(conceptContent)]的值:[$(pobjConceptVerEN.conceptContent)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.conceptName) == false && undefined !== pobjConceptVerEN.conceptName && clsString_js_1.tzDataType.isString(pobjConceptVerEN.conceptName) === false) {
            throw new Error("(errid:Watl000060)字段[概念名称(conceptName)]的值:[$(pobjConceptVerEN.conceptName)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.citationId) == false && undefined !== pobjConceptVerEN.citationId && clsString_js_1.tzDataType.isString(pobjConceptVerEN.citationId) === false) {
            throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjConceptVerEN.citationId)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.updDate) == false && undefined !== pobjConceptVerEN.updDate && clsString_js_1.tzDataType.isString(pobjConceptVerEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjConceptVerEN.updDate)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.updUser) == false && undefined !== pobjConceptVerEN.updUser && clsString_js_1.tzDataType.isString(pobjConceptVerEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjConceptVerEN.updUser)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.id_CurrEduCls) == false && undefined !== pobjConceptVerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjConceptVerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjConceptVerEN.id_CurrEduCls)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.pdfContent) == false && undefined !== pobjConceptVerEN.pdfContent && clsString_js_1.tzDataType.isString(pobjConceptVerEN.pdfContent) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjConceptVerEN.pdfContent)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
        }
        if (null != pobjConceptVerEN.pdfPageNum && undefined !== pobjConceptVerEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjConceptVerEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjConceptVerEN.pdfPageNum)], 非法，应该为数值型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.memo) == false && undefined !== pobjConceptVerEN.memo && clsString_js_1.tzDataType.isString(pobjConceptVerEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjConceptVerEN.memo)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjConceptVerEN.SetIsCheckProperty(true);
    }
    exports.ConceptVer_CheckPropertyNew = ConceptVer_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ConceptVer_CheckProperty4Update(pobjConceptVerEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.conceptId) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.conceptId) > 8) {
            throw new Error("(errid:Watl000062)字段[概念Id(conceptId)]的长度不能超过8(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.conceptId)(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.conceptName) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.conceptName) > 500) {
            throw new Error("(errid:Watl000062)字段[概念名称(conceptName)]的长度不能超过500(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.conceptName)(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.citationId) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.citationId) > 8) {
            throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.citationId)(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.updDate)(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.updUser)(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.id_CurrEduCls)(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.pdfContent)(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjConceptVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.memo)(clsConceptVerBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjConceptVerEN.conceptVId && undefined !== pobjConceptVerEN.conceptVId && clsString_js_1.tzDataType.isNumber(pobjConceptVerEN.conceptVId) === false) {
            throw new Error("(errid:Watl000063)字段[ConceptVId(conceptVId)]的值:[$(pobjConceptVerEN.conceptVId)], 非法，应该为数值型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.conceptId) == false && undefined !== pobjConceptVerEN.conceptId && clsString_js_1.tzDataType.isString(pobjConceptVerEN.conceptId) === false) {
            throw new Error("(errid:Watl000063)字段[概念Id(conceptId)]的值:[$(pobjConceptVerEN.conceptId)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.conceptContent) == false && undefined !== pobjConceptVerEN.conceptContent && clsString_js_1.tzDataType.isString(pobjConceptVerEN.conceptContent) === false) {
            throw new Error("(errid:Watl000063)字段[概念内容(conceptContent)]的值:[$(pobjConceptVerEN.conceptContent)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.conceptName) == false && undefined !== pobjConceptVerEN.conceptName && clsString_js_1.tzDataType.isString(pobjConceptVerEN.conceptName) === false) {
            throw new Error("(errid:Watl000063)字段[概念名称(conceptName)]的值:[$(pobjConceptVerEN.conceptName)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.citationId) == false && undefined !== pobjConceptVerEN.citationId && clsString_js_1.tzDataType.isString(pobjConceptVerEN.citationId) === false) {
            throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjConceptVerEN.citationId)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.updDate) == false && undefined !== pobjConceptVerEN.updDate && clsString_js_1.tzDataType.isString(pobjConceptVerEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjConceptVerEN.updDate)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.updUser) == false && undefined !== pobjConceptVerEN.updUser && clsString_js_1.tzDataType.isString(pobjConceptVerEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjConceptVerEN.updUser)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.id_CurrEduCls) == false && undefined !== pobjConceptVerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjConceptVerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjConceptVerEN.id_CurrEduCls)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.pdfContent) == false && undefined !== pobjConceptVerEN.pdfContent && clsString_js_1.tzDataType.isString(pobjConceptVerEN.pdfContent) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjConceptVerEN.pdfContent)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
        }
        if (null != pobjConceptVerEN.pdfPageNum && undefined !== pobjConceptVerEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjConceptVerEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjConceptVerEN.pdfPageNum)], 非法，应该为数值型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptVerEN.memo) == false && undefined !== pobjConceptVerEN.memo && clsString_js_1.tzDataType.isString(pobjConceptVerEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjConceptVerEN.memo)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjConceptVerEN.conceptVId
            || pobjConceptVerEN.conceptVId != null && pobjConceptVerEN.conceptVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[ConceptVId]不能为空(In 概念版本表)!(clsConceptVerBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjConceptVerEN.SetIsCheckProperty(true);
    }
    exports.ConceptVer_CheckProperty4Update = ConceptVer_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ConceptVer_GetJSONStrByObj(pobjConceptVerEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjConceptVerEN.sf_UpdFldSetStr = pobjConceptVerEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjConceptVerEN);
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
    exports.ConceptVer_GetJSONStrByObj = ConceptVer_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ConceptVer_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrConceptVerObjLst = new Array();
        if (strJSON === "") {
            return arrConceptVerObjLst;
        }
        try {
            arrConceptVerObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrConceptVerObjLst;
        }
        return arrConceptVerObjLst;
    }
    exports.ConceptVer_GetObjLstByJSONStr = ConceptVer_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrConceptVerObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ConceptVer_GetObjLstByJSONObjLst(arrConceptVerObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrConceptVerObjLst = new Array();
        for (const objInFor of arrConceptVerObjLstS) {
            const obj1 = ConceptVer_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrConceptVerObjLst.push(obj1);
        }
        return arrConceptVerObjLst;
    }
    exports.ConceptVer_GetObjLstByJSONObjLst = ConceptVer_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ConceptVer_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjConceptVerEN = new clsConceptVerEN_js_1.clsConceptVerEN();
        if (strJSON === "") {
            return pobjConceptVerEN;
        }
        try {
            pobjConceptVerEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjConceptVerEN;
        }
        return pobjConceptVerEN;
    }
    exports.ConceptVer_GetObjByJSONStr = ConceptVer_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ConceptVer_GetCombineCondition(objConceptVer_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptVId) == true) {
            const strComparisonOp_ConceptVId = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptVId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptVId, objConceptVer_Cond.conceptVId, strComparisonOp_ConceptVId);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptId) == true) {
            const strComparisonOp_ConceptId = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptId, objConceptVer_Cond.conceptId, strComparisonOp_ConceptId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptName) == true) {
            const strComparisonOp_ConceptName = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptVerEN_js_1.clsConceptVerEN.con_ConceptName, objConceptVer_Cond.conceptName, strComparisonOp_ConceptName);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN_js_1.clsConceptVerEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN_js_1.clsConceptVerEN.con_CitationId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptVerEN_js_1.clsConceptVerEN.con_CitationId, objConceptVer_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN_js_1.clsConceptVerEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN_js_1.clsConceptVerEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptVerEN_js_1.clsConceptVerEN.con_UpdDate, objConceptVer_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN_js_1.clsConceptVerEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN_js_1.clsConceptVerEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptVerEN_js_1.clsConceptVerEN.con_UpdUser, objConceptVer_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN_js_1.clsConceptVerEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN_js_1.clsConceptVerEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptVerEN_js_1.clsConceptVerEN.con_id_CurrEduCls, objConceptVer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN_js_1.clsConceptVerEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN_js_1.clsConceptVerEN.con_PdfContent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptVerEN_js_1.clsConceptVerEN.con_PdfContent, objConceptVer_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN_js_1.clsConceptVerEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN_js_1.clsConceptVerEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsConceptVerEN_js_1.clsConceptVerEN.con_PdfPageNum, objConceptVer_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN_js_1.clsConceptVerEN.con_Memo) == true) {
            const strComparisonOp_Memo = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN_js_1.clsConceptVerEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptVerEN_js_1.clsConceptVerEN.con_Memo, objConceptVer_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ConceptVer_GetCombineCondition = ConceptVer_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ConceptVer(概念版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngConceptVId: ConceptVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ConceptVer_GetUniCondStr_ConceptVId(objConceptVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ConceptVId = '{0}'", objConceptVerEN.conceptVId);
        return strWhereCond;
    }
    exports.ConceptVer_GetUniCondStr_ConceptVId = ConceptVer_GetUniCondStr_ConceptVId;
    /**
    *获取唯一性条件串(Uniqueness)--ConceptVer(概念版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngConceptVId: ConceptVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ConceptVer_GetUniCondStr4Update_ConceptVId(objConceptVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ConceptVId <> '{0}'", objConceptVerEN.conceptVId);
        strWhereCond += (0, clsString_js_2.Format)(" and ConceptVId = '{0}'", objConceptVerEN.conceptVId);
        return strWhereCond;
    }
    exports.ConceptVer_GetUniCondStr4Update_ConceptVId = ConceptVer_GetUniCondStr4Update_ConceptVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objConceptVerENS:源对象
     * @param objConceptVerENT:目标对象
    */
    function ConceptVer_CopyObjTo(objConceptVerENS, objConceptVerENT) {
        objConceptVerENT.conceptVId = objConceptVerENS.conceptVId; //ConceptVId
        objConceptVerENT.conceptId = objConceptVerENS.conceptId; //概念Id
        objConceptVerENT.conceptContent = objConceptVerENS.conceptContent; //概念内容
        objConceptVerENT.conceptName = objConceptVerENS.conceptName; //概念名称
        objConceptVerENT.citationId = objConceptVerENS.citationId; //引用Id
        objConceptVerENT.updDate = objConceptVerENS.updDate; //修改日期
        objConceptVerENT.updUser = objConceptVerENS.updUser; //修改人
        objConceptVerENT.id_CurrEduCls = objConceptVerENS.id_CurrEduCls; //教学班流水号
        objConceptVerENT.pdfContent = objConceptVerENS.pdfContent; //Pdf内容
        objConceptVerENT.pdfPageNum = objConceptVerENS.pdfPageNum; //Pdf页码
        objConceptVerENT.memo = objConceptVerENS.memo; //备注
        objConceptVerENT.sf_UpdFldSetStr = objConceptVerENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ConceptVer_CopyObjTo = ConceptVer_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objConceptVerENS:源对象
     * @param objConceptVerENT:目标对象
    */
    function ConceptVer_GetObjFromJsonObj(objConceptVerENS) {
        const objConceptVerENT = new clsConceptVerEN_js_1.clsConceptVerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objConceptVerENT, objConceptVerENS);
        return objConceptVerENT;
    }
    exports.ConceptVer_GetObjFromJsonObj = ConceptVer_GetObjFromJsonObj;
});
