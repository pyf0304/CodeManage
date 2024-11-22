/**
* 类名:clsgs_PaperParagraphVWApi
* 表名:gs_PaperParagraphV(01120743)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:39
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培论文(GraduateEduPaper)
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphVEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperParagraphV_GetObjFromJsonObj = exports.gs_PaperParagraphV_CopyObjTo = exports.gs_PaperParagraphV_GetUniCondStr4Update_ParagraphVId = exports.gs_PaperParagraphV_GetUniCondStr_ParagraphVId = exports.gs_PaperParagraphV_GetCombineCondition = exports.gs_PaperParagraphV_GetObjByJSONStr = exports.gs_PaperParagraphV_GetObjLstByJSONObjLst = exports.gs_PaperParagraphV_GetObjLstByJSONStr = exports.gs_PaperParagraphV_GetJSONStrByObj = exports.gs_PaperParagraphV_CheckProperty4Update = exports.gs_PaperParagraphV_CheckPropertyNew = exports.gs_PaperParagraphV_GetWebApiUrl = exports.gs_PaperParagraphV_GetMaxStrIdByPrefix = exports.gs_PaperParagraphV_GetRecCountByCondAsync = exports.gs_PaperParagraphV_IsExistAsync = exports.gs_PaperParagraphV_IsExist = exports.gs_PaperParagraphV_IsExistRecordAsync = exports.gs_PaperParagraphV_UpdateWithConditionAsync = exports.gs_PaperParagraphV_UpdateRecordAsync = exports.gs_PaperParagraphV_AddNewRecordWithReturnKey = exports.gs_PaperParagraphV_AddNewRecordWithReturnKeyAsync = exports.gs_PaperParagraphV_AddNewRecordAsync = exports.gs_PaperParagraphV_Delgs_PaperParagraphVsByCondAsync = exports.gs_PaperParagraphV_Delgs_PaperParagraphVsAsync = exports.gs_PaperParagraphV_DelRecordAsync = exports.gs_PaperParagraphV_GetObjLstByPagerAsync = exports.gs_PaperParagraphV_GetObjLstByRange = exports.gs_PaperParagraphV_GetObjLstByRangeAsync = exports.gs_PaperParagraphV_GetTopObjLstAsync = exports.gs_PaperParagraphV_GetObjLstByParagraphVIdLstAsync = exports.gs_PaperParagraphV_GetObjLstAsync = exports.gs_PaperParagraphV_GetFirstObjAsync = exports.gs_PaperParagraphV_GetFirstID = exports.gs_PaperParagraphV_GetFirstIDAsync = exports.gs_PaperParagraphV_FilterFunByKey = exports.gs_PaperParagraphV_SortFunByKey = exports.gs_PaperParagraphV_SortFun_Defa_2Fld = exports.gs_PaperParagraphV_SortFun_Defa = exports.gs_PaperParagraphV_GetObjByParagraphVIdAsync = exports.gs_PaperParagraphV_ConstructorName = exports.gs_PaperParagraphV_Controller = void 0;
    /**
     * 论文段落版本(gs_PaperParagraphV)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_PaperParagraphVEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphVEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_PaperParagraphV_Controller = "gs_PaperParagraphVApi";
    exports.gs_PaperParagraphV_ConstructorName = "gs_PaperParagraphV";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngParagraphVId:关键字
    * @returns 对象
    **/
    async function gs_PaperParagraphV_GetObjByParagraphVIdAsync(lngParagraphVId) {
        const strThisFuncName = "GetObjByParagraphVIdAsync";
        if (lngParagraphVId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngParagraphVId]不能为空！(In GetObjByParagraphVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByParagraphVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngParagraphVId": lngParagraphVId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_PaperParagraphV = gs_PaperParagraphV_GetObjFromJsonObj(returnObj);
                return objgs_PaperParagraphV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_GetObjByParagraphVIdAsync = gs_PaperParagraphV_GetObjByParagraphVIdAsync;
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
    function gs_PaperParagraphV_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paragraphVId - b.paragraphVId;
    }
    exports.gs_PaperParagraphV_SortFun_Defa = gs_PaperParagraphV_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperParagraphV_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paragraphId == b.paragraphId)
            return a.sectionId.localeCompare(b.sectionId);
        else
            return a.paragraphId.localeCompare(b.paragraphId);
    }
    exports.gs_PaperParagraphV_SortFun_Defa_2Fld = gs_PaperParagraphV_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperParagraphV_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphVId:
                    return (a, b) => {
                        return a.paragraphVId - b.paragraphVId;
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphId:
                    return (a, b) => {
                        return a.paragraphId.localeCompare(b.paragraphId);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_SectionId:
                    return (a, b) => {
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphTypeId:
                    return (a, b) => {
                        return a.paragraphTypeId.localeCompare(b.paragraphTypeId);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphContent:
                    return (a, b) => {
                        return a.paragraphContent.localeCompare(b.paragraphContent);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraphV]中不存在！(in ${exports.gs_PaperParagraphV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphVId:
                    return (a, b) => {
                        return b.paragraphVId - a.paragraphVId;
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphId:
                    return (a, b) => {
                        return b.paragraphId.localeCompare(a.paragraphId);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_SectionId:
                    return (a, b) => {
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphTypeId:
                    return (a, b) => {
                        return b.paragraphTypeId.localeCompare(a.paragraphTypeId);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphContent:
                    return (a, b) => {
                        return b.paragraphContent.localeCompare(a.paragraphContent);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraphV]中不存在！(in ${exports.gs_PaperParagraphV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_PaperParagraphV_SortFunByKey = gs_PaperParagraphV_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_PaperParagraphV_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphVId:
                return (obj) => {
                    return obj.paragraphVId === value;
                };
            case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphId:
                return (obj) => {
                    return obj.paragraphId === value;
                };
            case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphTypeId:
                return (obj) => {
                    return obj.paragraphTypeId === value;
                };
            case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphContent:
                return (obj) => {
                    return obj.paragraphContent === value;
                };
            case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraphV]中不存在！(in ${exports.gs_PaperParagraphV_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_PaperParagraphV_FilterFunByKey = gs_PaperParagraphV_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperParagraphV_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_GetFirstIDAsync = gs_PaperParagraphV_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_PaperParagraphV_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_GetFirstID = gs_PaperParagraphV_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_PaperParagraphV_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_PaperParagraphV = gs_PaperParagraphV_GetObjFromJsonObj(returnObj);
                return objgs_PaperParagraphV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_GetFirstObjAsync = gs_PaperParagraphV_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperParagraphV_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraphV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_GetObjLstAsync = gs_PaperParagraphV_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrParagraphVId:关键字列表
    * @returns 对象列表
    **/
    async function gs_PaperParagraphV_GetObjLstByParagraphVIdLstAsync(arrParagraphVId) {
        const strThisFuncName = "GetObjLstByParagraphVIdLstAsync";
        const strAction = "GetObjLstByParagraphVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrParagraphVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraphV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_GetObjLstByParagraphVIdLstAsync = gs_PaperParagraphV_GetObjLstByParagraphVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperParagraphV_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraphV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_GetTopObjLstAsync = gs_PaperParagraphV_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperParagraphV_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraphV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_GetObjLstByRangeAsync = gs_PaperParagraphV_GetObjLstByRangeAsync;
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
    async function gs_PaperParagraphV_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_GetObjLstByRange = gs_PaperParagraphV_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperParagraphV_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraphV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_GetObjLstByPagerAsync = gs_PaperParagraphV_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngParagraphVId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_PaperParagraphV_DelRecordAsync(lngParagraphVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngParagraphVId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngParagraphVId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_DelRecordAsync = gs_PaperParagraphV_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrParagraphVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperParagraphV_Delgs_PaperParagraphVsAsync(arrParagraphVId) {
        const strThisFuncName = "Delgs_PaperParagraphVsAsync";
        const strAction = "Delgs_PaperParagraphVs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrParagraphVId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_Delgs_PaperParagraphVsAsync = gs_PaperParagraphV_Delgs_PaperParagraphVsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperParagraphV_Delgs_PaperParagraphVsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_PaperParagraphVsByCondAsync";
        const strAction = "Delgs_PaperParagraphVsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_Delgs_PaperParagraphVsByCondAsync = gs_PaperParagraphV_Delgs_PaperParagraphVsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_PaperParagraphVEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperParagraphV_AddNewRecordAsync(objgs_PaperParagraphVEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_PaperParagraphVEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_AddNewRecordAsync = gs_PaperParagraphV_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_PaperParagraphVEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_PaperParagraphV_AddNewRecordWithReturnKeyAsync(objgs_PaperParagraphVEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_AddNewRecordWithReturnKeyAsync = gs_PaperParagraphV_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_PaperParagraphVEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_PaperParagraphV_AddNewRecordWithReturnKey(objgs_PaperParagraphVEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_PaperParagraphVEN.paragraphVId === null || objgs_PaperParagraphVEN.paragraphVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphVEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_AddNewRecordWithReturnKey = gs_PaperParagraphV_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_PaperParagraphVEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_PaperParagraphV_UpdateRecordAsync(objgs_PaperParagraphVEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_PaperParagraphVEN.sf_UpdFldSetStr === undefined || objgs_PaperParagraphVEN.sf_UpdFldSetStr === null || objgs_PaperParagraphVEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperParagraphVEN.paragraphVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_UpdateRecordAsync = gs_PaperParagraphV_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_PaperParagraphVEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperParagraphV_UpdateWithConditionAsync(objgs_PaperParagraphVEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_PaperParagraphVEN.sf_UpdFldSetStr === undefined || objgs_PaperParagraphVEN.sf_UpdFldSetStr === null || objgs_PaperParagraphVEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperParagraphVEN.paragraphVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        objgs_PaperParagraphVEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_UpdateWithConditionAsync = gs_PaperParagraphV_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_PaperParagraphV_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_IsExistRecordAsync = gs_PaperParagraphV_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngParagraphVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_PaperParagraphV_IsExist(lngParagraphVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ParagraphVId": lngParagraphVId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_IsExist = gs_PaperParagraphV_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngParagraphVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_PaperParagraphV_IsExistAsync(lngParagraphVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngParagraphVId": lngParagraphVId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_IsExistAsync = gs_PaperParagraphV_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_PaperParagraphV_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_GetRecCountByCondAsync = gs_PaperParagraphV_GetRecCountByCondAsync;
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
    async function gs_PaperParagraphV_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphV_GetMaxStrIdByPrefix = gs_PaperParagraphV_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_PaperParagraphV_GetWebApiUrl(strController, strAction) {
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
    exports.gs_PaperParagraphV_GetWebApiUrl = gs_PaperParagraphV_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperParagraphV_CheckPropertyNew(pobjgs_PaperParagraphVEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paragraphId) === true) {
            throw new Error("(errid:Watl000058)字段[段落Id]不能为空(In 论文段落版本)!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.sectionId) === true) {
            throw new Error("(errid:Watl000058)字段[节Id]不能为空(In 论文段落版本)!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paragraphTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[段落类型Id]不能为空(In 论文段落版本)!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paragraphId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.paragraphId) > 10) {
            throw new Error("(errid:Watl000059)字段[段落Id(paragraphId)]的长度不能超过10(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.paragraphId)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.sectionId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.sectionId) > 8) {
            throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.sectionId)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paragraphTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.paragraphTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[段落类型Id(paragraphTypeId)]的长度不能超过2(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.paragraphTypeId)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.updDate)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.updUser)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.memo)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.paperId)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_PaperParagraphVEN.paragraphVId && undefined !== pobjgs_PaperParagraphVEN.paragraphVId && jsString_js_1.tzDataType.isNumber(pobjgs_PaperParagraphVEN.paragraphVId) === false) {
            throw new Error("(errid:Watl000060)字段[段落版本Id(paragraphVId)]的值:[$(pobjgs_PaperParagraphVEN.paragraphVId)], 非法，应该为数值型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paragraphId) == false && undefined !== pobjgs_PaperParagraphVEN.paragraphId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.paragraphId) === false) {
            throw new Error("(errid:Watl000060)字段[段落Id(paragraphId)]的值:[$(pobjgs_PaperParagraphVEN.paragraphId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.sectionId) == false && undefined !== pobjgs_PaperParagraphVEN.sectionId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.sectionId) === false) {
            throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjgs_PaperParagraphVEN.sectionId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paragraphTypeId) == false && undefined !== pobjgs_PaperParagraphVEN.paragraphTypeId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.paragraphTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[段落类型Id(paragraphTypeId)]的值:[$(pobjgs_PaperParagraphVEN.paragraphTypeId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paragraphContent) == false && undefined !== pobjgs_PaperParagraphVEN.paragraphContent && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.paragraphContent) === false) {
            throw new Error("(errid:Watl000060)字段[段落内容(paragraphContent)]的值:[$(pobjgs_PaperParagraphVEN.paragraphContent)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.updDate) == false && undefined !== pobjgs_PaperParagraphVEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperParagraphVEN.updDate)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.updUser) == false && undefined !== pobjgs_PaperParagraphVEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperParagraphVEN.updUser)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.memo) == false && undefined !== pobjgs_PaperParagraphVEN.memo && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PaperParagraphVEN.memo)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paperId) == false && undefined !== pobjgs_PaperParagraphVEN.paperId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PaperParagraphVEN.paperId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_PaperParagraphVEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperParagraphV_CheckPropertyNew = gs_PaperParagraphV_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperParagraphV_CheckProperty4Update(pobjgs_PaperParagraphVEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paragraphId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.paragraphId) > 10) {
            throw new Error("(errid:Watl000062)字段[段落Id(paragraphId)]的长度不能超过10(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.paragraphId)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.sectionId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.sectionId) > 8) {
            throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.sectionId)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paragraphTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.paragraphTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[段落类型Id(paragraphTypeId)]的长度不能超过2(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.paragraphTypeId)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.updDate)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.updUser)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.memo)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphVEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.paperId)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_PaperParagraphVEN.paragraphVId && undefined !== pobjgs_PaperParagraphVEN.paragraphVId && jsString_js_1.tzDataType.isNumber(pobjgs_PaperParagraphVEN.paragraphVId) === false) {
            throw new Error("(errid:Watl000063)字段[段落版本Id(paragraphVId)]的值:[$(pobjgs_PaperParagraphVEN.paragraphVId)], 非法，应该为数值型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paragraphId) == false && undefined !== pobjgs_PaperParagraphVEN.paragraphId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.paragraphId) === false) {
            throw new Error("(errid:Watl000063)字段[段落Id(paragraphId)]的值:[$(pobjgs_PaperParagraphVEN.paragraphId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.sectionId) == false && undefined !== pobjgs_PaperParagraphVEN.sectionId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.sectionId) === false) {
            throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjgs_PaperParagraphVEN.sectionId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paragraphTypeId) == false && undefined !== pobjgs_PaperParagraphVEN.paragraphTypeId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.paragraphTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[段落类型Id(paragraphTypeId)]的值:[$(pobjgs_PaperParagraphVEN.paragraphTypeId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paragraphContent) == false && undefined !== pobjgs_PaperParagraphVEN.paragraphContent && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.paragraphContent) === false) {
            throw new Error("(errid:Watl000063)字段[段落内容(paragraphContent)]的值:[$(pobjgs_PaperParagraphVEN.paragraphContent)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.updDate) == false && undefined !== pobjgs_PaperParagraphVEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperParagraphVEN.updDate)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.updUser) == false && undefined !== pobjgs_PaperParagraphVEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperParagraphVEN.updUser)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.memo) == false && undefined !== pobjgs_PaperParagraphVEN.memo && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PaperParagraphVEN.memo)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphVEN.paperId) == false && undefined !== pobjgs_PaperParagraphVEN.paperId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PaperParagraphVEN.paperId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_PaperParagraphVEN.paragraphVId
            || pobjgs_PaperParagraphVEN.paragraphVId != null && pobjgs_PaperParagraphVEN.paragraphVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[段落版本Id]不能为空(In 论文段落版本)!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_PaperParagraphVEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperParagraphV_CheckProperty4Update = gs_PaperParagraphV_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperParagraphV_GetJSONStrByObj(pobjgs_PaperParagraphVEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_PaperParagraphVEN.sf_UpdFldSetStr = pobjgs_PaperParagraphVEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_PaperParagraphVEN);
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
    exports.gs_PaperParagraphV_GetJSONStrByObj = gs_PaperParagraphV_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperParagraphV_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_PaperParagraphVObjLst = new Array();
        if (strJSON === "") {
            return arrgs_PaperParagraphVObjLst;
        }
        try {
            arrgs_PaperParagraphVObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_PaperParagraphVObjLst;
        }
        return arrgs_PaperParagraphVObjLst;
    }
    exports.gs_PaperParagraphV_GetObjLstByJSONStr = gs_PaperParagraphV_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_PaperParagraphVObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperParagraphV_GetObjLstByJSONObjLst(arrgs_PaperParagraphVObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_PaperParagraphVObjLst = new Array();
        for (const objInFor of arrgs_PaperParagraphVObjLstS) {
            const obj1 = gs_PaperParagraphV_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_PaperParagraphVObjLst.push(obj1);
        }
        return arrgs_PaperParagraphVObjLst;
    }
    exports.gs_PaperParagraphV_GetObjLstByJSONObjLst = gs_PaperParagraphV_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperParagraphV_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_PaperParagraphVEN = new clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN();
        if (strJSON === "") {
            return pobjgs_PaperParagraphVEN;
        }
        try {
            pobjgs_PaperParagraphVEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_PaperParagraphVEN;
        }
        return pobjgs_PaperParagraphVEN;
    }
    exports.gs_PaperParagraphV_GetObjByJSONStr = gs_PaperParagraphV_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_PaperParagraphV_GetCombineCondition(objgs_PaperParagraphV_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphVId) == true) {
            const strComparisonOp_ParagraphVId = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphVId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphVId, objgs_PaperParagraphV_Cond.paragraphVId, strComparisonOp_ParagraphVId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphId) == true) {
            const strComparisonOp_ParagraphId = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphId, objgs_PaperParagraphV_Cond.paragraphId, strComparisonOp_ParagraphId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_SectionId, objgs_PaperParagraphV_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphTypeId) == true) {
            const strComparisonOp_ParagraphTypeId = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_ParagraphTypeId, objgs_PaperParagraphV_Cond.paragraphTypeId, strComparisonOp_ParagraphTypeId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_UpdDate, objgs_PaperParagraphV_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_UpdUser, objgs_PaperParagraphV_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_Memo, objgs_PaperParagraphV_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN.con_PaperId, objgs_PaperParagraphV_Cond.paperId, strComparisonOp_PaperId);
        }
        return strWhereCond;
    }
    exports.gs_PaperParagraphV_GetCombineCondition = gs_PaperParagraphV_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperParagraphV(论文段落版本),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngParagraphVId: 段落版本Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperParagraphV_GetUniCondStr_ParagraphVId(objgs_PaperParagraphVEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ParagraphVId = '{0}'", objgs_PaperParagraphVEN.paragraphVId);
        return strWhereCond;
    }
    exports.gs_PaperParagraphV_GetUniCondStr_ParagraphVId = gs_PaperParagraphV_GetUniCondStr_ParagraphVId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperParagraphV(论文段落版本),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngParagraphVId: 段落版本Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperParagraphV_GetUniCondStr4Update_ParagraphVId(objgs_PaperParagraphVEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ParagraphVId <> '{0}'", objgs_PaperParagraphVEN.paragraphVId);
        strWhereCond += (0, clsString_js_1.Format)(" and ParagraphVId = '{0}'", objgs_PaperParagraphVEN.paragraphVId);
        return strWhereCond;
    }
    exports.gs_PaperParagraphV_GetUniCondStr4Update_ParagraphVId = gs_PaperParagraphV_GetUniCondStr4Update_ParagraphVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_PaperParagraphVENS:源对象
     * @param objgs_PaperParagraphVENT:目标对象
    */
    function gs_PaperParagraphV_CopyObjTo(objgs_PaperParagraphVENS, objgs_PaperParagraphVENT) {
        objgs_PaperParagraphVENT.paragraphVId = objgs_PaperParagraphVENS.paragraphVId; //段落版本Id
        objgs_PaperParagraphVENT.paragraphId = objgs_PaperParagraphVENS.paragraphId; //段落Id
        objgs_PaperParagraphVENT.sectionId = objgs_PaperParagraphVENS.sectionId; //节Id
        objgs_PaperParagraphVENT.paragraphTypeId = objgs_PaperParagraphVENS.paragraphTypeId; //段落类型Id
        objgs_PaperParagraphVENT.paragraphContent = objgs_PaperParagraphVENS.paragraphContent; //段落内容
        objgs_PaperParagraphVENT.updDate = objgs_PaperParagraphVENS.updDate; //修改日期
        objgs_PaperParagraphVENT.updUser = objgs_PaperParagraphVENS.updUser; //修改人
        objgs_PaperParagraphVENT.memo = objgs_PaperParagraphVENS.memo; //备注
        objgs_PaperParagraphVENT.paperId = objgs_PaperParagraphVENS.paperId; //论文Id
        objgs_PaperParagraphVENT.sf_UpdFldSetStr = objgs_PaperParagraphVENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_PaperParagraphV_CopyObjTo = gs_PaperParagraphV_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_PaperParagraphVENS:源对象
     * @param objgs_PaperParagraphVENT:目标对象
    */
    function gs_PaperParagraphV_GetObjFromJsonObj(objgs_PaperParagraphVENS) {
        const objgs_PaperParagraphVENT = new clsgs_PaperParagraphVEN_js_1.clsgs_PaperParagraphVEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperParagraphVENT, objgs_PaperParagraphVENS);
        return objgs_PaperParagraphVENT;
    }
    exports.gs_PaperParagraphV_GetObjFromJsonObj = gs_PaperParagraphV_GetObjFromJsonObj;
});
