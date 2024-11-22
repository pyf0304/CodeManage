/**
* 类名:clsgs_PaperParagraphVerWApi
* 表名:gs_PaperParagraphVer(01120743)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:54:58
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphVerEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperParagraphVer_GetObjFromJsonObj = exports.gs_PaperParagraphVer_CopyObjTo = exports.gs_PaperParagraphVer_GetUniCondStr4Update_ParagraphVId = exports.gs_PaperParagraphVer_GetUniCondStr_ParagraphVId = exports.gs_PaperParagraphVer_GetCombineCondition = exports.gs_PaperParagraphVer_GetObjByJSONStr = exports.gs_PaperParagraphVer_GetObjLstByJSONObjLst = exports.gs_PaperParagraphVer_GetObjLstByJSONStr = exports.gs_PaperParagraphVer_GetJSONStrByObj = exports.gs_PaperParagraphVer_CheckProperty4Update = exports.gs_PaperParagraphVer_CheckPropertyNew = exports.gs_PaperParagraphVer_GetWebApiUrl = exports.gs_PaperParagraphVer_GetMaxStrIdByPrefix = exports.gs_PaperParagraphVer_GetRecCountByCondAsync = exports.gs_PaperParagraphVer_IsExistAsync = exports.gs_PaperParagraphVer_IsExist = exports.gs_PaperParagraphVer_IsExistRecordAsync = exports.gs_PaperParagraphVer_UpdateWithConditionAsync = exports.gs_PaperParagraphVer_UpdateRecordAsync = exports.gs_PaperParagraphVer_AddNewRecordWithReturnKey = exports.gs_PaperParagraphVer_AddNewRecordWithReturnKeyAsync = exports.gs_PaperParagraphVer_AddNewRecordAsync = exports.gs_PaperParagraphVer_Delgs_PaperParagraphVersByCondAsync = exports.gs_PaperParagraphVer_Delgs_PaperParagraphVersAsync = exports.gs_PaperParagraphVer_DelRecordAsync = exports.gs_PaperParagraphVer_GetObjLstByPagerAsync = exports.gs_PaperParagraphVer_GetObjLstByRange = exports.gs_PaperParagraphVer_GetObjLstByRangeAsync = exports.gs_PaperParagraphVer_GetTopObjLstAsync = exports.gs_PaperParagraphVer_GetObjLstByParagraphVIdLstAsync = exports.gs_PaperParagraphVer_GetObjLstAsync = exports.gs_PaperParagraphVer_GetFirstObjAsync = exports.gs_PaperParagraphVer_GetFirstID = exports.gs_PaperParagraphVer_GetFirstIDAsync = exports.gs_PaperParagraphVer_FilterFunByKey = exports.gs_PaperParagraphVer_SortFunByKey = exports.gs_PaperParagraphVer_SortFun_Defa_2Fld = exports.gs_PaperParagraphVer_SortFun_Defa = exports.gs_PaperParagraphVer_GetObjByParagraphVIdAsync = exports.gs_PaperParagraphVer_ConstructorName = exports.gs_PaperParagraphVer_Controller = void 0;
    /**
     * 论文段落版本(gs_PaperParagraphVer)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_PaperParagraphVerEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphVerEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_PaperParagraphVer_Controller = "gs_PaperParagraphVerApi";
    exports.gs_PaperParagraphVer_ConstructorName = "gs_PaperParagraphVer";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngParagraphVId:关键字
    * @returns 对象
    **/
    async function gs_PaperParagraphVer_GetObjByParagraphVIdAsync(lngParagraphVId) {
        const strThisFuncName = "GetObjByParagraphVIdAsync";
        if (lngParagraphVId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngParagraphVId]不能为空！(In clsgs_PaperParagraphVerWApi.GetObjByParagraphVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByParagraphVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
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
                    return null;
                }
                //console.log(returnObj);
                const objgs_PaperParagraphVer = gs_PaperParagraphVer_GetObjFromJsonObj(returnObj);
                return objgs_PaperParagraphVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_GetObjByParagraphVIdAsync = gs_PaperParagraphVer_GetObjByParagraphVIdAsync;
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
    function gs_PaperParagraphVer_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paragraphVId - b.paragraphVId;
    }
    exports.gs_PaperParagraphVer_SortFun_Defa = gs_PaperParagraphVer_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperParagraphVer_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paragraphId == b.paragraphId)
            return a.sectionId.localeCompare(b.sectionId);
        else
            return a.paragraphId.localeCompare(b.paragraphId);
    }
    exports.gs_PaperParagraphVer_SortFun_Defa_2Fld = gs_PaperParagraphVer_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperParagraphVer_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphVId:
                    return (a, b) => {
                        return a.paragraphVId - b.paragraphVId;
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphId:
                    return (a, b) => {
                        return a.paragraphId.localeCompare(b.paragraphId);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_SectionId:
                    return (a, b) => {
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphTypeId:
                    return (a, b) => {
                        return a.paragraphTypeId.localeCompare(b.paragraphTypeId);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphContent:
                    return (a, b) => {
                        if (a.paragraphContent == null)
                            return -1;
                        if (b.paragraphContent == null)
                            return 1;
                        return a.paragraphContent.localeCompare(b.paragraphContent);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraphVer]中不存在！(in ${exports.gs_PaperParagraphVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphVId:
                    return (a, b) => {
                        return b.paragraphVId - a.paragraphVId;
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphId:
                    return (a, b) => {
                        return b.paragraphId.localeCompare(a.paragraphId);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_SectionId:
                    return (a, b) => {
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphTypeId:
                    return (a, b) => {
                        return b.paragraphTypeId.localeCompare(a.paragraphTypeId);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphContent:
                    return (a, b) => {
                        if (b.paragraphContent == null)
                            return -1;
                        if (a.paragraphContent == null)
                            return 1;
                        return b.paragraphContent.localeCompare(a.paragraphContent);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraphVer]中不存在！(in ${exports.gs_PaperParagraphVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_PaperParagraphVer_SortFunByKey = gs_PaperParagraphVer_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_PaperParagraphVer_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphVId:
                return (obj) => {
                    return obj.paragraphVId === value;
                };
            case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphId:
                return (obj) => {
                    return obj.paragraphId === value;
                };
            case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphTypeId:
                return (obj) => {
                    return obj.paragraphTypeId === value;
                };
            case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphContent:
                return (obj) => {
                    return obj.paragraphContent === value;
                };
            case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraphVer]中不存在！(in ${exports.gs_PaperParagraphVer_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_PaperParagraphVer_FilterFunByKey = gs_PaperParagraphVer_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperParagraphVer_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_GetFirstIDAsync = gs_PaperParagraphVer_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_PaperParagraphVer_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_GetFirstID = gs_PaperParagraphVer_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_PaperParagraphVer_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
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
                const objgs_PaperParagraphVer = gs_PaperParagraphVer_GetObjFromJsonObj(returnObj);
                return objgs_PaperParagraphVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_GetFirstObjAsync = gs_PaperParagraphVer_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperParagraphVer_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraphVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_GetObjLstAsync = gs_PaperParagraphVer_GetObjLstAsync;
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
    async function gs_PaperParagraphVer_GetObjLstByParagraphVIdLstAsync(arrParagraphVId) {
        const strThisFuncName = "GetObjLstByParagraphVIdLstAsync";
        const strAction = "GetObjLstByParagraphVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrParagraphVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraphVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_GetObjLstByParagraphVIdLstAsync = gs_PaperParagraphVer_GetObjLstByParagraphVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperParagraphVer_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraphVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_GetTopObjLstAsync = gs_PaperParagraphVer_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperParagraphVer_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraphVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_GetObjLstByRangeAsync = gs_PaperParagraphVer_GetObjLstByRangeAsync;
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
    async function gs_PaperParagraphVer_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_GetObjLstByRange = gs_PaperParagraphVer_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperParagraphVer_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraphVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_GetObjLstByPagerAsync = gs_PaperParagraphVer_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngParagraphVId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_PaperParagraphVer_DelRecordAsync(lngParagraphVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngParagraphVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_DelRecordAsync = gs_PaperParagraphVer_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrParagraphVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperParagraphVer_Delgs_PaperParagraphVersAsync(arrParagraphVId) {
        const strThisFuncName = "Delgs_PaperParagraphVersAsync";
        const strAction = "Delgs_PaperParagraphVers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_Delgs_PaperParagraphVersAsync = gs_PaperParagraphVer_Delgs_PaperParagraphVersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperParagraphVer_Delgs_PaperParagraphVersByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_PaperParagraphVersByCondAsync";
        const strAction = "Delgs_PaperParagraphVersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_Delgs_PaperParagraphVersByCondAsync = gs_PaperParagraphVer_Delgs_PaperParagraphVersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_PaperParagraphVerEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperParagraphVer_AddNewRecordAsync(objgs_PaperParagraphVerEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_PaperParagraphVerEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_AddNewRecordAsync = gs_PaperParagraphVer_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_PaperParagraphVerEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_PaperParagraphVer_AddNewRecordWithReturnKeyAsync(objgs_PaperParagraphVerEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_AddNewRecordWithReturnKeyAsync = gs_PaperParagraphVer_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_PaperParagraphVerEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_PaperParagraphVer_AddNewRecordWithReturnKey(objgs_PaperParagraphVerEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_PaperParagraphVerEN.paragraphVId === null || objgs_PaperParagraphVerEN.paragraphVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphVerEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_AddNewRecordWithReturnKey = gs_PaperParagraphVer_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_PaperParagraphVerEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_PaperParagraphVer_UpdateRecordAsync(objgs_PaperParagraphVerEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_PaperParagraphVerEN.sf_UpdFldSetStr === undefined || objgs_PaperParagraphVerEN.sf_UpdFldSetStr === null || objgs_PaperParagraphVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperParagraphVerEN.paragraphVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_UpdateRecordAsync = gs_PaperParagraphVer_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_PaperParagraphVerEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperParagraphVer_UpdateWithConditionAsync(objgs_PaperParagraphVerEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_PaperParagraphVerEN.sf_UpdFldSetStr === undefined || objgs_PaperParagraphVerEN.sf_UpdFldSetStr === null || objgs_PaperParagraphVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperParagraphVerEN.paragraphVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
        objgs_PaperParagraphVerEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_UpdateWithConditionAsync = gs_PaperParagraphVer_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_PaperParagraphVer_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_IsExistRecordAsync = gs_PaperParagraphVer_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngParagraphVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_PaperParagraphVer_IsExist(lngParagraphVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_IsExist = gs_PaperParagraphVer_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngParagraphVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_PaperParagraphVer_IsExistAsync(lngParagraphVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_IsExistAsync = gs_PaperParagraphVer_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_PaperParagraphVer_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_GetRecCountByCondAsync = gs_PaperParagraphVer_GetRecCountByCondAsync;
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
    async function gs_PaperParagraphVer_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraphVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphVer_GetMaxStrIdByPrefix = gs_PaperParagraphVer_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_PaperParagraphVer_GetWebApiUrl(strController, strAction) {
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
    exports.gs_PaperParagraphVer_GetWebApiUrl = gs_PaperParagraphVer_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperParagraphVer_CheckPropertyNew(pobjgs_PaperParagraphVerEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paragraphId) === true) {
            throw new Error("(errid:Watl000058)字段[段落Id]不能为空(In 论文段落版本)!(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.sectionId) === true) {
            throw new Error("(errid:Watl000058)字段[节Id]不能为空(In 论文段落版本)!(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paragraphTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[段落类型Id]不能为空(In 论文段落版本)!(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paragraphId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.paragraphId) > 10) {
            throw new Error("(errid:Watl000059)字段[段落Id(paragraphId)]的长度不能超过10(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.paragraphId)(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.sectionId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.sectionId) > 8) {
            throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.sectionId)(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paragraphTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.paragraphTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[段落类型Id(paragraphTypeId)]的长度不能超过2(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.paragraphTypeId)(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.updDate)(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.updUser)(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.memo)(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.paperId)(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_PaperParagraphVerEN.paragraphVId && undefined !== pobjgs_PaperParagraphVerEN.paragraphVId && clsString_js_1.tzDataType.isNumber(pobjgs_PaperParagraphVerEN.paragraphVId) === false) {
            throw new Error("(errid:Watl000060)字段[段落版本Id(paragraphVId)]的值:[$(pobjgs_PaperParagraphVerEN.paragraphVId)], 非法，应该为数值型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paragraphId) == false && undefined !== pobjgs_PaperParagraphVerEN.paragraphId && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.paragraphId) === false) {
            throw new Error("(errid:Watl000060)字段[段落Id(paragraphId)]的值:[$(pobjgs_PaperParagraphVerEN.paragraphId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.sectionId) == false && undefined !== pobjgs_PaperParagraphVerEN.sectionId && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.sectionId) === false) {
            throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjgs_PaperParagraphVerEN.sectionId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paragraphTypeId) == false && undefined !== pobjgs_PaperParagraphVerEN.paragraphTypeId && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.paragraphTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[段落类型Id(paragraphTypeId)]的值:[$(pobjgs_PaperParagraphVerEN.paragraphTypeId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paragraphContent) == false && undefined !== pobjgs_PaperParagraphVerEN.paragraphContent && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.paragraphContent) === false) {
            throw new Error("(errid:Watl000060)字段[段落内容(paragraphContent)]的值:[$(pobjgs_PaperParagraphVerEN.paragraphContent)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.updDate) == false && undefined !== pobjgs_PaperParagraphVerEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperParagraphVerEN.updDate)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.updUser) == false && undefined !== pobjgs_PaperParagraphVerEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperParagraphVerEN.updUser)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.memo) == false && undefined !== pobjgs_PaperParagraphVerEN.memo && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PaperParagraphVerEN.memo)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paperId) == false && undefined !== pobjgs_PaperParagraphVerEN.paperId && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PaperParagraphVerEN.paperId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_PaperParagraphVerEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperParagraphVer_CheckPropertyNew = gs_PaperParagraphVer_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperParagraphVer_CheckProperty4Update(pobjgs_PaperParagraphVerEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paragraphId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.paragraphId) > 10) {
            throw new Error("(errid:Watl000062)字段[段落Id(paragraphId)]的长度不能超过10(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.paragraphId)(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.sectionId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.sectionId) > 8) {
            throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.sectionId)(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paragraphTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.paragraphTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[段落类型Id(paragraphTypeId)]的长度不能超过2(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.paragraphTypeId)(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.updDate)(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.updUser)(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.memo)(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperParagraphVerEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文段落版本(gs_PaperParagraphVer))!值:$(pobjgs_PaperParagraphVerEN.paperId)(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_PaperParagraphVerEN.paragraphVId && undefined !== pobjgs_PaperParagraphVerEN.paragraphVId && clsString_js_1.tzDataType.isNumber(pobjgs_PaperParagraphVerEN.paragraphVId) === false) {
            throw new Error("(errid:Watl000063)字段[段落版本Id(paragraphVId)]的值:[$(pobjgs_PaperParagraphVerEN.paragraphVId)], 非法，应该为数值型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paragraphId) == false && undefined !== pobjgs_PaperParagraphVerEN.paragraphId && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.paragraphId) === false) {
            throw new Error("(errid:Watl000063)字段[段落Id(paragraphId)]的值:[$(pobjgs_PaperParagraphVerEN.paragraphId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.sectionId) == false && undefined !== pobjgs_PaperParagraphVerEN.sectionId && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.sectionId) === false) {
            throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjgs_PaperParagraphVerEN.sectionId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paragraphTypeId) == false && undefined !== pobjgs_PaperParagraphVerEN.paragraphTypeId && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.paragraphTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[段落类型Id(paragraphTypeId)]的值:[$(pobjgs_PaperParagraphVerEN.paragraphTypeId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paragraphContent) == false && undefined !== pobjgs_PaperParagraphVerEN.paragraphContent && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.paragraphContent) === false) {
            throw new Error("(errid:Watl000063)字段[段落内容(paragraphContent)]的值:[$(pobjgs_PaperParagraphVerEN.paragraphContent)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.updDate) == false && undefined !== pobjgs_PaperParagraphVerEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperParagraphVerEN.updDate)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.updUser) == false && undefined !== pobjgs_PaperParagraphVerEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperParagraphVerEN.updUser)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.memo) == false && undefined !== pobjgs_PaperParagraphVerEN.memo && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PaperParagraphVerEN.memo)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperParagraphVerEN.paperId) == false && undefined !== pobjgs_PaperParagraphVerEN.paperId && clsString_js_1.tzDataType.isString(pobjgs_PaperParagraphVerEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PaperParagraphVerEN.paperId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphVer))!(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_PaperParagraphVerEN.paragraphVId
            || pobjgs_PaperParagraphVerEN.paragraphVId != null && pobjgs_PaperParagraphVerEN.paragraphVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[段落版本Id]不能为空(In 论文段落版本)!(clsgs_PaperParagraphVerBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_PaperParagraphVerEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperParagraphVer_CheckProperty4Update = gs_PaperParagraphVer_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperParagraphVer_GetJSONStrByObj(pobjgs_PaperParagraphVerEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_PaperParagraphVerEN.sf_UpdFldSetStr = pobjgs_PaperParagraphVerEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_PaperParagraphVerEN);
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
    exports.gs_PaperParagraphVer_GetJSONStrByObj = gs_PaperParagraphVer_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperParagraphVer_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_PaperParagraphVerObjLst = new Array();
        if (strJSON === "") {
            return arrgs_PaperParagraphVerObjLst;
        }
        try {
            arrgs_PaperParagraphVerObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_PaperParagraphVerObjLst;
        }
        return arrgs_PaperParagraphVerObjLst;
    }
    exports.gs_PaperParagraphVer_GetObjLstByJSONStr = gs_PaperParagraphVer_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_PaperParagraphVerObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperParagraphVer_GetObjLstByJSONObjLst(arrgs_PaperParagraphVerObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_PaperParagraphVerObjLst = new Array();
        for (const objInFor of arrgs_PaperParagraphVerObjLstS) {
            const obj1 = gs_PaperParagraphVer_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_PaperParagraphVerObjLst.push(obj1);
        }
        return arrgs_PaperParagraphVerObjLst;
    }
    exports.gs_PaperParagraphVer_GetObjLstByJSONObjLst = gs_PaperParagraphVer_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperParagraphVer_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN();
        if (strJSON === "") {
            return pobjgs_PaperParagraphVerEN;
        }
        try {
            pobjgs_PaperParagraphVerEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_PaperParagraphVerEN;
        }
        return pobjgs_PaperParagraphVerEN;
    }
    exports.gs_PaperParagraphVer_GetObjByJSONStr = gs_PaperParagraphVer_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_PaperParagraphVer_GetCombineCondition(objgs_PaperParagraphVer_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphVer_Cond.dicFldComparisonOp, clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphVId) == true) {
            const strComparisonOp_ParagraphVId = objgs_PaperParagraphVer_Cond.dicFldComparisonOp[clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphVId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphVId, objgs_PaperParagraphVer_Cond.paragraphVId, strComparisonOp_ParagraphVId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphVer_Cond.dicFldComparisonOp, clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphId) == true) {
            const strComparisonOp_ParagraphId = objgs_PaperParagraphVer_Cond.dicFldComparisonOp[clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphId, objgs_PaperParagraphVer_Cond.paragraphId, strComparisonOp_ParagraphId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphVer_Cond.dicFldComparisonOp, clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objgs_PaperParagraphVer_Cond.dicFldComparisonOp[clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_SectionId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_SectionId, objgs_PaperParagraphVer_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphVer_Cond.dicFldComparisonOp, clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphTypeId) == true) {
            const strComparisonOp_ParagraphTypeId = objgs_PaperParagraphVer_Cond.dicFldComparisonOp[clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_ParagraphTypeId, objgs_PaperParagraphVer_Cond.paragraphTypeId, strComparisonOp_ParagraphTypeId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphVer_Cond.dicFldComparisonOp, clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_PaperParagraphVer_Cond.dicFldComparisonOp[clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_UpdDate, objgs_PaperParagraphVer_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphVer_Cond.dicFldComparisonOp, clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_PaperParagraphVer_Cond.dicFldComparisonOp[clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_UpdUser, objgs_PaperParagraphVer_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphVer_Cond.dicFldComparisonOp, clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_PaperParagraphVer_Cond.dicFldComparisonOp[clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_Memo, objgs_PaperParagraphVer_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphVer_Cond.dicFldComparisonOp, clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objgs_PaperParagraphVer_Cond.dicFldComparisonOp[clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_PaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_PaperId, objgs_PaperParagraphVer_Cond.paperId, strComparisonOp_PaperId);
        }
        return strWhereCond;
    }
    exports.gs_PaperParagraphVer_GetCombineCondition = gs_PaperParagraphVer_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperParagraphVer(论文段落版本),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngParagraphVId: 段落版本Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperParagraphVer_GetUniCondStr_ParagraphVId(objgs_PaperParagraphVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ParagraphVId = '{0}'", objgs_PaperParagraphVerEN.paragraphVId);
        return strWhereCond;
    }
    exports.gs_PaperParagraphVer_GetUniCondStr_ParagraphVId = gs_PaperParagraphVer_GetUniCondStr_ParagraphVId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperParagraphVer(论文段落版本),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngParagraphVId: 段落版本Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperParagraphVer_GetUniCondStr4Update_ParagraphVId(objgs_PaperParagraphVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ParagraphVId <> '{0}'", objgs_PaperParagraphVerEN.paragraphVId);
        strWhereCond += (0, clsString_js_2.Format)(" and ParagraphVId = '{0}'", objgs_PaperParagraphVerEN.paragraphVId);
        return strWhereCond;
    }
    exports.gs_PaperParagraphVer_GetUniCondStr4Update_ParagraphVId = gs_PaperParagraphVer_GetUniCondStr4Update_ParagraphVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_PaperParagraphVerENS:源对象
     * @param objgs_PaperParagraphVerENT:目标对象
    */
    function gs_PaperParagraphVer_CopyObjTo(objgs_PaperParagraphVerENS, objgs_PaperParagraphVerENT) {
        objgs_PaperParagraphVerENT.paragraphVId = objgs_PaperParagraphVerENS.paragraphVId; //段落版本Id
        objgs_PaperParagraphVerENT.paragraphId = objgs_PaperParagraphVerENS.paragraphId; //段落Id
        objgs_PaperParagraphVerENT.sectionId = objgs_PaperParagraphVerENS.sectionId; //节Id
        objgs_PaperParagraphVerENT.paragraphTypeId = objgs_PaperParagraphVerENS.paragraphTypeId; //段落类型Id
        objgs_PaperParagraphVerENT.paragraphContent = objgs_PaperParagraphVerENS.paragraphContent; //段落内容
        objgs_PaperParagraphVerENT.updDate = objgs_PaperParagraphVerENS.updDate; //修改日期
        objgs_PaperParagraphVerENT.updUser = objgs_PaperParagraphVerENS.updUser; //修改人
        objgs_PaperParagraphVerENT.memo = objgs_PaperParagraphVerENS.memo; //备注
        objgs_PaperParagraphVerENT.paperId = objgs_PaperParagraphVerENS.paperId; //论文Id
        objgs_PaperParagraphVerENT.sf_UpdFldSetStr = objgs_PaperParagraphVerENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_PaperParagraphVer_CopyObjTo = gs_PaperParagraphVer_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_PaperParagraphVerENS:源对象
     * @param objgs_PaperParagraphVerENT:目标对象
    */
    function gs_PaperParagraphVer_GetObjFromJsonObj(objgs_PaperParagraphVerENS) {
        const objgs_PaperParagraphVerENT = new clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperParagraphVerENT, objgs_PaperParagraphVerENS);
        return objgs_PaperParagraphVerENT;
    }
    exports.gs_PaperParagraphVer_GetObjFromJsonObj = gs_PaperParagraphVer_GetObjFromJsonObj;
});
