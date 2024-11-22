/**
* 类名:clsSectionWApi
* 表名:Section(01120558)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:41
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsSectionEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Section_GetObjFromJsonObj = exports.Section_CopyObjTo = exports.Section_GetUniCondStr4Update_PaperId_SectionName = exports.Section_GetUniCondStr_PaperId_SectionName = exports.Section_GetCombineCondition = exports.Section_GetObjByJSONStr = exports.Section_GetObjLstByJSONObjLst = exports.Section_GetObjLstByJSONStr = exports.Section_GetJSONStrByObj = exports.Section_CheckProperty4Update = exports.Section_CheckPropertyNew = exports.Section_GetWebApiUrl = exports.Section_GetMaxStrIdByPrefix = exports.Section_GetMaxStrIdAsync = exports.Section_GetRecCountByCondAsync = exports.Section_IsExistAsync = exports.Section_IsExist = exports.Section_IsExistRecordAsync = exports.Section_UpdateWithConditionAsync = exports.Section_UpdateRecordAsync = exports.Section_AddNewRecordWithReturnKey = exports.Section_AddNewRecordWithReturnKeyAsync = exports.Section_ReOrderAsync = exports.Section_GoBottomAsync = exports.Section_DownMoveAsync = exports.Section_UpMoveAsync = exports.Section_GoTopAsync = exports.Section_AddNewRecordWithMaxIdAsync = exports.Section_AddNewRecordAsync = exports.Section_DelSectionsByCondAsync = exports.Section_DelSectionsAsync = exports.Section_DelRecordAsync = exports.Section_GetObjLstByPagerAsync = exports.Section_GetObjLstByRange = exports.Section_GetObjLstByRangeAsync = exports.Section_GetTopObjLstAsync = exports.Section_GetObjLstBySectionIdLstAsync = exports.Section_GetObjLstAsync = exports.Section_GetFirstObjAsync = exports.Section_GetFirstID = exports.Section_GetFirstIDAsync = exports.Section_FilterFunByKey = exports.Section_SortFunByKey = exports.Section_SortFun_Defa_2Fld = exports.Section_SortFun_Defa = exports.Section_GetObjBySectionIdAsync = exports.section_ConstructorName = exports.section_Controller = void 0;
    /**
     * 论文节表(Section)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsSectionEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsSectionEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.section_Controller = "SectionApi";
    exports.section_ConstructorName = "section";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strSectionId:关键字
    * @returns 对象
    **/
    async function Section_GetObjBySectionIdAsync(strSectionId) {
        const strThisFuncName = "GetObjBySectionIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSectionId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSectionId]不能为空！(In GetObjBySectionIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSectionId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSectionId]的长度:[{0}]不正确！", strSectionId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySectionId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strSectionId": strSectionId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.section_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSection = Section_GetObjFromJsonObj(returnObj);
                return objSection;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetObjBySectionIdAsync = Section_GetObjBySectionIdAsync;
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
    function Section_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.sectionId.localeCompare(b.sectionId);
    }
    exports.Section_SortFun_Defa = Section_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Section_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.sectionName == b.sectionName)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.sectionName.localeCompare(b.sectionName);
    }
    exports.Section_SortFun_Defa_2Fld = Section_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Section_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSectionEN_js_1.clsSectionEN.con_SectionId:
                    return (a, b) => {
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsSectionEN_js_1.clsSectionEN.con_SectionName:
                    return (a, b) => {
                        return a.sectionName.localeCompare(b.sectionName);
                    };
                case clsSectionEN_js_1.clsSectionEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsSectionEN_js_1.clsSectionEN.con_ParentId:
                    return (a, b) => {
                        return a.parentId.localeCompare(b.parentId);
                    };
                case clsSectionEN_js_1.clsSectionEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsSectionEN_js_1.clsSectionEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsSectionEN_js_1.clsSectionEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsSectionEN_js_1.clsSectionEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Section]中不存在！(in ${exports.section_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSectionEN_js_1.clsSectionEN.con_SectionId:
                    return (a, b) => {
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsSectionEN_js_1.clsSectionEN.con_SectionName:
                    return (a, b) => {
                        return b.sectionName.localeCompare(a.sectionName);
                    };
                case clsSectionEN_js_1.clsSectionEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsSectionEN_js_1.clsSectionEN.con_ParentId:
                    return (a, b) => {
                        return b.parentId.localeCompare(a.parentId);
                    };
                case clsSectionEN_js_1.clsSectionEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsSectionEN_js_1.clsSectionEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsSectionEN_js_1.clsSectionEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsSectionEN_js_1.clsSectionEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Section]中不存在！(in ${exports.section_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.Section_SortFunByKey = Section_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function Section_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSectionEN_js_1.clsSectionEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsSectionEN_js_1.clsSectionEN.con_SectionName:
                return (obj) => {
                    return obj.sectionName === value;
                };
            case clsSectionEN_js_1.clsSectionEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsSectionEN_js_1.clsSectionEN.con_ParentId:
                return (obj) => {
                    return obj.parentId === value;
                };
            case clsSectionEN_js_1.clsSectionEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsSectionEN_js_1.clsSectionEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsSectionEN_js_1.clsSectionEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsSectionEN_js_1.clsSectionEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[Section]中不存在！(in ${exports.section_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.Section_FilterFunByKey = Section_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function Section_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetFirstIDAsync = Section_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function Section_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetFirstID = Section_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function Section_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.section_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSection = Section_GetObjFromJsonObj(returnObj);
                return objSection;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetFirstObjAsync = Section_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function Section_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.section_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetObjLstAsync = Section_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSectionId:关键字列表
    * @returns 对象列表
    **/
    async function Section_GetObjLstBySectionIdLstAsync(arrSectionId) {
        const strThisFuncName = "GetObjLstBySectionIdLstAsync";
        const strAction = "GetObjLstBySectionIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSectionId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.section_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetObjLstBySectionIdLstAsync = Section_GetObjLstBySectionIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function Section_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.section_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetTopObjLstAsync = Section_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Section_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.section_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetObjLstByRangeAsync = Section_GetObjLstByRangeAsync;
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
    async function Section_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetObjLstByRange = Section_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Section_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.section_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetObjLstByPagerAsync = Section_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strSectionId:关键字
    * @returns 获取删除的结果
    **/
    async function Section_DelRecordAsync(strSectionId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strSectionId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strSectionId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_DelRecordAsync = Section_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrSectionId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function Section_DelSectionsAsync(arrSectionId) {
        const strThisFuncName = "DelSectionsAsync";
        const strAction = "DelSections";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSectionId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_DelSectionsAsync = Section_DelSectionsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function Section_DelSectionsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSectionsByCondAsync";
        const strAction = "DelSectionsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_DelSectionsByCondAsync = Section_DelSectionsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSectionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Section_AddNewRecordAsync(objSectionEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objSectionEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSectionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_AddNewRecordAsync = Section_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSectionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Section_AddNewRecordWithMaxIdAsync(objSectionEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSectionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_AddNewRecordWithMaxIdAsync = Section_AddNewRecordWithMaxIdAsync;
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objSectionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Section_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GoTopAsync = Section_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objSectionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Section_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objSectionEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_UpMoveAsync = Section_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objSectionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Section_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objSectionEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_DownMoveAsync = Section_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objSectionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Section_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objSectionEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GoBottomAsync = Section_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objSectionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Section_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objSectionEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_ReOrderAsync = Section_ReOrderAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSectionEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function Section_AddNewRecordWithReturnKeyAsync(objSectionEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSectionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_AddNewRecordWithReturnKeyAsync = Section_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSectionEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function Section_AddNewRecordWithReturnKey(objSectionEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSectionEN.sectionId === null || objSectionEN.sectionId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSectionEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_AddNewRecordWithReturnKey = Section_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSectionEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function Section_UpdateRecordAsync(objSectionEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSectionEN.sf_UpdFldSetStr === undefined || objSectionEN.sf_UpdFldSetStr === null || objSectionEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSectionEN.sectionId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSectionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_UpdateRecordAsync = Section_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSectionEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function Section_UpdateWithConditionAsync(objSectionEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSectionEN.sf_UpdFldSetStr === undefined || objSectionEN.sf_UpdFldSetStr === null || objSectionEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSectionEN.sectionId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        objSectionEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSectionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_UpdateWithConditionAsync = Section_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function Section_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_IsExistRecordAsync = Section_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strSectionId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function Section_IsExist(strSectionId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "SectionId": strSectionId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_IsExist = Section_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strSectionId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function Section_IsExistAsync(strSectionId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strSectionId": strSectionId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_IsExistAsync = Section_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function Section_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetRecCountByCondAsync = Section_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function Section_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetMaxStrIdAsync = Section_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function Section_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.section_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.section_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Section_GetMaxStrIdByPrefix = Section_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function Section_GetWebApiUrl(strController, strAction) {
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
    exports.Section_GetWebApiUrl = Section_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Section_CheckPropertyNew(pobjSectionEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.updUser) === true) {
            throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 论文节表)!(clsSectionBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.sectionId) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.sectionId) > 8) {
            throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文节表(Section))!值:$(pobjSectionEN.sectionId)(clsSectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.sectionName) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.sectionName) > 100) {
            throw new Error("(errid:Watl000059)字段[节名(sectionName)]的长度不能超过100(In 论文节表(Section))!值:$(pobjSectionEN.sectionName)(clsSectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.paperId) > 500) {
            throw new Error("(errid:Watl000059)字段[节名称(paperId)]的长度不能超过500(In 论文节表(Section))!值:$(pobjSectionEN.paperId)(clsSectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.parentId) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.parentId) > 10) {
            throw new Error("(errid:Watl000059)字段[父节点Id(parentId)]的长度不能超过10(In 论文节表(Section))!值:$(pobjSectionEN.parentId)(clsSectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文节表(Section))!值:$(pobjSectionEN.updDate)(clsSectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文节表(Section))!值:$(pobjSectionEN.updUser)(clsSectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文节表(Section))!值:$(pobjSectionEN.memo)(clsSectionBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.sectionId) == false && undefined !== pobjSectionEN.sectionId && jsString_js_1.tzDataType.isString(pobjSectionEN.sectionId) === false) {
            throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjSectionEN.sectionId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.sectionName) == false && undefined !== pobjSectionEN.sectionName && jsString_js_1.tzDataType.isString(pobjSectionEN.sectionName) === false) {
            throw new Error("(errid:Watl000060)字段[节名(sectionName)]的值:[$(pobjSectionEN.sectionName)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.paperId) == false && undefined !== pobjSectionEN.paperId && jsString_js_1.tzDataType.isString(pobjSectionEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[节名称(paperId)]的值:[$(pobjSectionEN.paperId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.parentId) == false && undefined !== pobjSectionEN.parentId && jsString_js_1.tzDataType.isString(pobjSectionEN.parentId) === false) {
            throw new Error("(errid:Watl000060)字段[父节点Id(parentId)]的值:[$(pobjSectionEN.parentId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
        }
        if (null != pobjSectionEN.orderNum && undefined !== pobjSectionEN.orderNum && jsString_js_1.tzDataType.isNumber(pobjSectionEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjSectionEN.orderNum)], 非法，应该为数值型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.updDate) == false && undefined !== pobjSectionEN.updDate && jsString_js_1.tzDataType.isString(pobjSectionEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSectionEN.updDate)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.updUser) == false && undefined !== pobjSectionEN.updUser && jsString_js_1.tzDataType.isString(pobjSectionEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSectionEN.updUser)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.memo) == false && undefined !== pobjSectionEN.memo && jsString_js_1.tzDataType.isString(pobjSectionEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSectionEN.memo)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSectionEN.SetIsCheckProperty(true);
    }
    exports.Section_CheckPropertyNew = Section_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Section_CheckProperty4Update(pobjSectionEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.sectionId) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.sectionId) > 8) {
            throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文节表(Section))!值:$(pobjSectionEN.sectionId)(clsSectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.sectionName) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.sectionName) > 100) {
            throw new Error("(errid:Watl000062)字段[节名(sectionName)]的长度不能超过100(In 论文节表(Section))!值:$(pobjSectionEN.sectionName)(clsSectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.paperId) > 500) {
            throw new Error("(errid:Watl000062)字段[节名称(paperId)]的长度不能超过500(In 论文节表(Section))!值:$(pobjSectionEN.paperId)(clsSectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.parentId) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.parentId) > 10) {
            throw new Error("(errid:Watl000062)字段[父节点Id(parentId)]的长度不能超过10(In 论文节表(Section))!值:$(pobjSectionEN.parentId)(clsSectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文节表(Section))!值:$(pobjSectionEN.updDate)(clsSectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文节表(Section))!值:$(pobjSectionEN.updUser)(clsSectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSectionEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文节表(Section))!值:$(pobjSectionEN.memo)(clsSectionBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.sectionId) == false && undefined !== pobjSectionEN.sectionId && jsString_js_1.tzDataType.isString(pobjSectionEN.sectionId) === false) {
            throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjSectionEN.sectionId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.sectionName) == false && undefined !== pobjSectionEN.sectionName && jsString_js_1.tzDataType.isString(pobjSectionEN.sectionName) === false) {
            throw new Error("(errid:Watl000063)字段[节名(sectionName)]的值:[$(pobjSectionEN.sectionName)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.paperId) == false && undefined !== pobjSectionEN.paperId && jsString_js_1.tzDataType.isString(pobjSectionEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[节名称(paperId)]的值:[$(pobjSectionEN.paperId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.parentId) == false && undefined !== pobjSectionEN.parentId && jsString_js_1.tzDataType.isString(pobjSectionEN.parentId) === false) {
            throw new Error("(errid:Watl000063)字段[父节点Id(parentId)]的值:[$(pobjSectionEN.parentId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
        }
        if (null != pobjSectionEN.orderNum && undefined !== pobjSectionEN.orderNum && jsString_js_1.tzDataType.isNumber(pobjSectionEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjSectionEN.orderNum)], 非法，应该为数值型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.updDate) == false && undefined !== pobjSectionEN.updDate && jsString_js_1.tzDataType.isString(pobjSectionEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSectionEN.updDate)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.updUser) == false && undefined !== pobjSectionEN.updUser && jsString_js_1.tzDataType.isString(pobjSectionEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSectionEN.updUser)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.memo) == false && undefined !== pobjSectionEN.memo && jsString_js_1.tzDataType.isString(pobjSectionEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSectionEN.memo)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSectionEN.sectionId) === true) {
            throw new Error("(errid:Watl000064)字段[节Id]不能为空(In 论文节表)!(clsSectionBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSectionEN.SetIsCheckProperty(true);
    }
    exports.Section_CheckProperty4Update = Section_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Section_GetJSONStrByObj(pobjSectionEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSectionEN.sf_UpdFldSetStr = pobjSectionEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSectionEN);
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
    exports.Section_GetJSONStrByObj = Section_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function Section_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSectionObjLst = new Array();
        if (strJSON === "") {
            return arrSectionObjLst;
        }
        try {
            arrSectionObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSectionObjLst;
        }
        return arrSectionObjLst;
    }
    exports.Section_GetObjLstByJSONStr = Section_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSectionObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function Section_GetObjLstByJSONObjLst(arrSectionObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSectionObjLst = new Array();
        for (const objInFor of arrSectionObjLstS) {
            const obj1 = Section_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSectionObjLst.push(obj1);
        }
        return arrSectionObjLst;
    }
    exports.Section_GetObjLstByJSONObjLst = Section_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Section_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSectionEN = new clsSectionEN_js_1.clsSectionEN();
        if (strJSON === "") {
            return pobjSectionEN;
        }
        try {
            pobjSectionEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSectionEN;
        }
        return pobjSectionEN;
    }
    exports.Section_GetObjByJSONStr = Section_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function Section_GetCombineCondition(objSection_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN_js_1.clsSectionEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objSection_Cond.dicFldComparisonOp[clsSectionEN_js_1.clsSectionEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSectionEN_js_1.clsSectionEN.con_SectionId, objSection_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN_js_1.clsSectionEN.con_SectionName) == true) {
            const strComparisonOp_SectionName = objSection_Cond.dicFldComparisonOp[clsSectionEN_js_1.clsSectionEN.con_SectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSectionEN_js_1.clsSectionEN.con_SectionName, objSection_Cond.sectionName, strComparisonOp_SectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN_js_1.clsSectionEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objSection_Cond.dicFldComparisonOp[clsSectionEN_js_1.clsSectionEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSectionEN_js_1.clsSectionEN.con_PaperId, objSection_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN_js_1.clsSectionEN.con_ParentId) == true) {
            const strComparisonOp_ParentId = objSection_Cond.dicFldComparisonOp[clsSectionEN_js_1.clsSectionEN.con_ParentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSectionEN_js_1.clsSectionEN.con_ParentId, objSection_Cond.parentId, strComparisonOp_ParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN_js_1.clsSectionEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objSection_Cond.dicFldComparisonOp[clsSectionEN_js_1.clsSectionEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsSectionEN_js_1.clsSectionEN.con_OrderNum, objSection_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN_js_1.clsSectionEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objSection_Cond.dicFldComparisonOp[clsSectionEN_js_1.clsSectionEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSectionEN_js_1.clsSectionEN.con_UpdDate, objSection_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN_js_1.clsSectionEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objSection_Cond.dicFldComparisonOp[clsSectionEN_js_1.clsSectionEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSectionEN_js_1.clsSectionEN.con_UpdUser, objSection_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN_js_1.clsSectionEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSection_Cond.dicFldComparisonOp[clsSectionEN_js_1.clsSectionEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSectionEN_js_1.clsSectionEN.con_Memo, objSection_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.Section_GetCombineCondition = Section_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--Section(论文节表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strSectionName: 节名(要求唯一的字段)
    * @param strPaperId: 节名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function Section_GetUniCondStr_PaperId_SectionName(objSectionEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and SectionName = '{0}'", objSectionEN.sectionName);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objSectionEN.paperId);
        return strWhereCond;
    }
    exports.Section_GetUniCondStr_PaperId_SectionName = Section_GetUniCondStr_PaperId_SectionName;
    /**
    *获取唯一性条件串(Uniqueness)--Section(论文节表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strSectionName: 节名(要求唯一的字段)
    * @param strPaperId: 节名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function Section_GetUniCondStr4Update_PaperId_SectionName(objSectionEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and SectionId <> '{0}'", objSectionEN.sectionId);
        strWhereCond += (0, clsString_js_1.Format)(" and SectionName = '{0}'", objSectionEN.sectionName);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objSectionEN.paperId);
        return strWhereCond;
    }
    exports.Section_GetUniCondStr4Update_PaperId_SectionName = Section_GetUniCondStr4Update_PaperId_SectionName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSectionENS:源对象
     * @param objSectionENT:目标对象
    */
    function Section_CopyObjTo(objSectionENS, objSectionENT) {
        objSectionENT.sectionId = objSectionENS.sectionId; //节Id
        objSectionENT.sectionName = objSectionENS.sectionName; //节名
        objSectionENT.paperId = objSectionENS.paperId; //节名称
        objSectionENT.parentId = objSectionENS.parentId; //父节点Id
        objSectionENT.orderNum = objSectionENS.orderNum; //序号
        objSectionENT.updDate = objSectionENS.updDate; //修改日期
        objSectionENT.updUser = objSectionENS.updUser; //修改人
        objSectionENT.memo = objSectionENS.memo; //备注
        objSectionENT.sf_UpdFldSetStr = objSectionENS.updFldString; //sf_UpdFldSetStr
    }
    exports.Section_CopyObjTo = Section_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSectionENS:源对象
     * @param objSectionENT:目标对象
    */
    function Section_GetObjFromJsonObj(objSectionENS) {
        const objSectionENT = new clsSectionEN_js_1.clsSectionEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSectionENT, objSectionENS);
        return objSectionENT;
    }
    exports.Section_GetObjFromJsonObj = Section_GetObjFromJsonObj;
});
