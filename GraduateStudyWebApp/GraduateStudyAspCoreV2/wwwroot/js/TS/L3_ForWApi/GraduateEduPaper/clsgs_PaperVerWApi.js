/**
* 类名:clsgs_PaperVerWApi
* 表名:gs_PaperVer(01120678)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:55:04
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsgs_PaperVerEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperVer_GetObjFromJsonObj = exports.gs_PaperVer_CopyObjTo = exports.gs_PaperVer_GetUniCondStr4Update_PaperVId = exports.gs_PaperVer_GetUniCondStr_PaperVId = exports.gs_PaperVer_GetCombineCondition = exports.gs_PaperVer_GetObjByJSONStr = exports.gs_PaperVer_GetObjLstByJSONObjLst = exports.gs_PaperVer_GetObjLstByJSONStr = exports.gs_PaperVer_GetJSONStrByObj = exports.gs_PaperVer_CheckProperty4Update = exports.gs_PaperVer_CheckPropertyNew = exports.gs_PaperVer_GetWebApiUrl = exports.gs_PaperVer_GetMaxStrIdByPrefix = exports.gs_PaperVer_GetRecCountByCondAsync = exports.gs_PaperVer_IsExistAsync = exports.gs_PaperVer_IsExist = exports.gs_PaperVer_IsExistRecordAsync = exports.gs_PaperVer_UpdateWithConditionAsync = exports.gs_PaperVer_UpdateRecordAsync = exports.gs_PaperVer_AddNewRecordWithReturnKey = exports.gs_PaperVer_AddNewRecordWithReturnKeyAsync = exports.gs_PaperVer_AddNewRecordAsync = exports.gs_PaperVer_Delgs_PaperVersByCondAsync = exports.gs_PaperVer_Delgs_PaperVersAsync = exports.gs_PaperVer_DelRecordAsync = exports.gs_PaperVer_GetObjLstByPagerAsync = exports.gs_PaperVer_GetObjLstByRange = exports.gs_PaperVer_GetObjLstByRangeAsync = exports.gs_PaperVer_GetTopObjLstAsync = exports.gs_PaperVer_GetObjLstByPaperVIdLstAsync = exports.gs_PaperVer_GetObjLstAsync = exports.gs_PaperVer_GetFirstObjAsync = exports.gs_PaperVer_GetFirstID = exports.gs_PaperVer_GetFirstIDAsync = exports.gs_PaperVer_FilterFunByKey = exports.gs_PaperVer_SortFunByKey = exports.gs_PaperVer_SortFun_Defa_2Fld = exports.gs_PaperVer_SortFun_Defa = exports.gs_PaperVer_GetObjByPaperVIdAsync = exports.gs_PaperVer_ConstructorName = exports.gs_PaperVer_Controller = void 0;
    /**
     * 论文历史版本表(gs_PaperVer)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_PaperVerEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperVerEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_PaperVer_Controller = "gs_PaperVerApi";
    exports.gs_PaperVer_ConstructorName = "gs_PaperVer";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperVId:关键字
    * @returns 对象
    **/
    async function gs_PaperVer_GetObjByPaperVIdAsync(lngPaperVId) {
        const strThisFuncName = "GetObjByPaperVIdAsync";
        if (lngPaperVId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngPaperVId]不能为空！(In clsgs_PaperVerWApi.GetObjByPaperVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperVId": lngPaperVId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objgs_PaperVer = gs_PaperVer_GetObjFromJsonObj(returnObj);
                return objgs_PaperVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_GetObjByPaperVIdAsync = gs_PaperVer_GetObjByPaperVIdAsync;
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
    function gs_PaperVer_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperVId - b.paperVId;
    }
    exports.gs_PaperVer_SortFun_Defa = gs_PaperVer_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperVer_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.paperTitle.localeCompare(b.paperTitle);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.gs_PaperVer_SortFun_Defa_2Fld = gs_PaperVer_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperVer_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperVId:
                    return (a, b) => {
                        return a.paperVId - b.paperVId;
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperContent:
                    return (a, b) => {
                        if (a.paperContent == null)
                            return -1;
                        if (b.paperContent == null)
                            return 1;
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical:
                    return (a, b) => {
                        if (a.periodical == null)
                            return -1;
                        if (b.periodical == null)
                            return 1;
                        return a.periodical.localeCompare(b.periodical);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author:
                    return (a, b) => {
                        if (a.author == null)
                            return -1;
                        if (b.author == null)
                            return 1;
                        return a.author.localeCompare(b.author);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (a.researchQuestion == null)
                            return -1;
                        if (b.researchQuestion == null)
                            return 1;
                        return a.researchQuestion.localeCompare(b.researchQuestion);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword:
                    return (a, b) => {
                        if (a.keyword == null)
                            return -1;
                        if (b.keyword == null)
                            return 1;
                        return a.keyword.localeCompare(b.keyword);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources:
                    return (a, b) => {
                        if (a.literatureSources == null)
                            return -1;
                        if (b.literatureSources == null)
                            return 1;
                        return a.literatureSources.localeCompare(b.literatureSources);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink:
                    return (a, b) => {
                        if (a.literatureLink == null)
                            return -1;
                        if (b.literatureLink == null)
                            return 1;
                        return a.literatureLink.localeCompare(b.literatureLink);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl:
                    return (a, b) => {
                        if (a.uploadfileUrl == null)
                            return -1;
                        if (b.uploadfileUrl == null)
                            return 1;
                        return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis:
                    return (a, b) => {
                        if (a.isQuotethesis == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked:
                    return (a, b) => {
                        if (a.isChecked == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_QuoteId:
                    return (a, b) => {
                        if (a.quoteId == null)
                            return -1;
                        if (b.quoteId == null)
                            return 1;
                        return a.quoteId.localeCompare(b.quoteId);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker:
                    return (a, b) => {
                        if (a.checker == null)
                            return -1;
                        if (b.checker == null)
                            return 1;
                        return a.checker.localeCompare(b.checker);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureTypeId:
                    return (a, b) => {
                        return a.literatureTypeId.localeCompare(b.literatureTypeId);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTypeId:
                    return (a, b) => {
                        if (a.paperTypeId == null)
                            return -1;
                        if (b.paperTypeId == null)
                            return 1;
                        return a.paperTypeId.localeCompare(b.paperTypeId);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperStatusId:
                    return (a, b) => {
                        if (a.paperStatusId == null)
                            return -1;
                        if (b.paperStatusId == null)
                            return 1;
                        return a.paperStatusId.localeCompare(b.paperStatusId);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperVer]中不存在！(in ${exports.gs_PaperVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperVId:
                    return (a, b) => {
                        return b.paperVId - a.paperVId;
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperContent:
                    return (a, b) => {
                        if (b.paperContent == null)
                            return -1;
                        if (a.paperContent == null)
                            return 1;
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical:
                    return (a, b) => {
                        if (b.periodical == null)
                            return -1;
                        if (a.periodical == null)
                            return 1;
                        return b.periodical.localeCompare(a.periodical);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author:
                    return (a, b) => {
                        if (b.author == null)
                            return -1;
                        if (a.author == null)
                            return 1;
                        return b.author.localeCompare(a.author);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (b.researchQuestion == null)
                            return -1;
                        if (a.researchQuestion == null)
                            return 1;
                        return b.researchQuestion.localeCompare(a.researchQuestion);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword:
                    return (a, b) => {
                        if (b.keyword == null)
                            return -1;
                        if (a.keyword == null)
                            return 1;
                        return b.keyword.localeCompare(a.keyword);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources:
                    return (a, b) => {
                        if (b.literatureSources == null)
                            return -1;
                        if (a.literatureSources == null)
                            return 1;
                        return b.literatureSources.localeCompare(a.literatureSources);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink:
                    return (a, b) => {
                        if (b.literatureLink == null)
                            return -1;
                        if (a.literatureLink == null)
                            return 1;
                        return b.literatureLink.localeCompare(a.literatureLink);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl:
                    return (a, b) => {
                        if (b.uploadfileUrl == null)
                            return -1;
                        if (a.uploadfileUrl == null)
                            return 1;
                        return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis:
                    return (a, b) => {
                        if (b.isQuotethesis == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked:
                    return (a, b) => {
                        if (b.isChecked == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_QuoteId:
                    return (a, b) => {
                        if (b.quoteId == null)
                            return -1;
                        if (a.quoteId == null)
                            return 1;
                        return b.quoteId.localeCompare(a.quoteId);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker:
                    return (a, b) => {
                        if (b.checker == null)
                            return -1;
                        if (a.checker == null)
                            return 1;
                        return b.checker.localeCompare(a.checker);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureTypeId:
                    return (a, b) => {
                        return b.literatureTypeId.localeCompare(a.literatureTypeId);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTypeId:
                    return (a, b) => {
                        if (b.paperTypeId == null)
                            return -1;
                        if (a.paperTypeId == null)
                            return 1;
                        return b.paperTypeId.localeCompare(a.paperTypeId);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperStatusId:
                    return (a, b) => {
                        if (b.paperStatusId == null)
                            return -1;
                        if (a.paperStatusId == null)
                            return 1;
                        return b.paperStatusId.localeCompare(a.paperStatusId);
                    };
                case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperVer]中不存在！(in ${exports.gs_PaperVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_PaperVer_SortFunByKey = gs_PaperVer_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_PaperVer_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperVId:
                return (obj) => {
                    return obj.paperVId === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical:
                return (obj) => {
                    return obj.periodical === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion:
                return (obj) => {
                    return obj.researchQuestion === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword:
                return (obj) => {
                    return obj.keyword === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources:
                return (obj) => {
                    return obj.literatureSources === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink:
                return (obj) => {
                    return obj.literatureLink === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl:
                return (obj) => {
                    return obj.uploadfileUrl === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis:
                return (obj) => {
                    return obj.isQuotethesis === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked:
                return (obj) => {
                    return obj.isChecked === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_QuoteId:
                return (obj) => {
                    return obj.quoteId === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker:
                return (obj) => {
                    return obj.checker === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureTypeId:
                return (obj) => {
                    return obj.literatureTypeId === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTypeId:
                return (obj) => {
                    return obj.paperTypeId === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperStatusId:
                return (obj) => {
                    return obj.paperStatusId === value;
                };
            case clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_PaperVer]中不存在！(in ${exports.gs_PaperVer_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_PaperVer_FilterFunByKey = gs_PaperVer_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperVer_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_GetFirstIDAsync = gs_PaperVer_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_PaperVer_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_GetFirstID = gs_PaperVer_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_PaperVer_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
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
                const objgs_PaperVer = gs_PaperVer_GetObjFromJsonObj(returnObj);
                return objgs_PaperVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_GetFirstObjAsync = gs_PaperVer_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperVer_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_GetObjLstAsync = gs_PaperVer_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperVId:关键字列表
    * @returns 对象列表
    **/
    async function gs_PaperVer_GetObjLstByPaperVIdLstAsync(arrPaperVId) {
        const strThisFuncName = "GetObjLstByPaperVIdLstAsync";
        const strAction = "GetObjLstByPaperVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_GetObjLstByPaperVIdLstAsync = gs_PaperVer_GetObjLstByPaperVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperVer_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_GetTopObjLstAsync = gs_PaperVer_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperVer_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_GetObjLstByRangeAsync = gs_PaperVer_GetObjLstByRangeAsync;
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
    async function gs_PaperVer_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_GetObjLstByRange = gs_PaperVer_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperVer_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_GetObjLstByPagerAsync = gs_PaperVer_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngPaperVId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_PaperVer_DelRecordAsync(lngPaperVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngPaperVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_DelRecordAsync = gs_PaperVer_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperVer_Delgs_PaperVersAsync(arrPaperVId) {
        const strThisFuncName = "Delgs_PaperVersAsync";
        const strAction = "Delgs_PaperVers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_Delgs_PaperVersAsync = gs_PaperVer_Delgs_PaperVersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperVer_Delgs_PaperVersByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_PaperVersByCondAsync";
        const strAction = "Delgs_PaperVersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_Delgs_PaperVersByCondAsync = gs_PaperVer_Delgs_PaperVersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_PaperVerEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperVer_AddNewRecordAsync(objgs_PaperVerEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_PaperVerEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_AddNewRecordAsync = gs_PaperVer_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_PaperVerEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_PaperVer_AddNewRecordWithReturnKeyAsync(objgs_PaperVerEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_AddNewRecordWithReturnKeyAsync = gs_PaperVer_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_PaperVerEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_PaperVer_AddNewRecordWithReturnKey(objgs_PaperVerEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_PaperVerEN.paperVId === null || objgs_PaperVerEN.paperVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperVerEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_AddNewRecordWithReturnKey = gs_PaperVer_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_PaperVerEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_PaperVer_UpdateRecordAsync(objgs_PaperVerEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_PaperVerEN.sf_UpdFldSetStr === undefined || objgs_PaperVerEN.sf_UpdFldSetStr === null || objgs_PaperVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperVerEN.paperVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_UpdateRecordAsync = gs_PaperVer_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_PaperVerEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperVer_UpdateWithConditionAsync(objgs_PaperVerEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_PaperVerEN.sf_UpdFldSetStr === undefined || objgs_PaperVerEN.sf_UpdFldSetStr === null || objgs_PaperVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperVerEN.paperVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        objgs_PaperVerEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_UpdateWithConditionAsync = gs_PaperVer_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_PaperVer_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_IsExistRecordAsync = gs_PaperVer_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_PaperVer_IsExist(lngPaperVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperVId": lngPaperVId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_IsExist = gs_PaperVer_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_PaperVer_IsExistAsync(lngPaperVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperVId": lngPaperVId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_IsExistAsync = gs_PaperVer_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_PaperVer_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_GetRecCountByCondAsync = gs_PaperVer_GetRecCountByCondAsync;
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
    async function gs_PaperVer_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperVer_GetMaxStrIdByPrefix = gs_PaperVer_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_PaperVer_GetWebApiUrl(strController, strAction) {
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
    exports.gs_PaperVer_GetWebApiUrl = gs_PaperVer_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperVer_CheckPropertyNew(pobjgs_PaperVerEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperId) === true
            || pobjgs_PaperVerEN.paperId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文历史版本表)!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperTitle) === true) {
            throw new Error("(errid:Watl000058)字段[论文标题]不能为空(In 论文历史版本表)!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[作文类型Id]不能为空(In 论文历史版本表)!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperId)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperTitle) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.paperTitle) > 500) {
            throw new Error("(errid:Watl000059)字段[论文标题(paperTitle)]的长度不能超过500(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperTitle)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.periodical) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.periodical) > 100) {
            throw new Error("(errid:Watl000059)字段[期刊(periodical)]的长度不能超过100(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.periodical)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.author) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.author) > 200) {
            throw new Error("(errid:Watl000059)字段[作者(author)]的长度不能超过200(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.author)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.researchQuestion) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.researchQuestion) > 2000) {
            throw new Error("(errid:Watl000059)字段[研究问题(researchQuestion)]的长度不能超过2000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.researchQuestion)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.keyword) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.keyword) > 1000) {
            throw new Error("(errid:Watl000059)字段[关键字(keyword)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.keyword)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureSources) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.literatureSources) > 1000) {
            throw new Error("(errid:Watl000059)字段[文献来源(literatureSources)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.literatureSources)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureLink) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.literatureLink) > 1000) {
            throw new Error("(errid:Watl000059)字段[文献链接(literatureLink)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.literatureLink)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.uploadfileUrl) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.uploadfileUrl) > 1000) {
            throw new Error("(errid:Watl000059)字段[文件地址(uploadfileUrl)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.uploadfileUrl)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.quoteId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.quoteId) > 8) {
            throw new Error("(errid:Watl000059)字段[引用Id(quoteId)]的长度不能超过8(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.quoteId)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.checker) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.checker) > 20) {
            throw new Error("(errid:Watl000059)字段[审核人(checker)]的长度不能超过20(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.checker)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.literatureTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[作文类型Id(literatureTypeId)]的长度不能超过2(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.literatureTypeId)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.updUser)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.updDate)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.id_CurrEduCls)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.paperTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[论文类型Id(paperTypeId)]的长度不能超过2(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperTypeId)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperStatusId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.paperStatusId) > 2) {
            throw new Error("(errid:Watl000059)字段[论文状态Id(paperStatusId)]的长度不能超过2(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperStatusId)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.memo)(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_PaperVerEN.paperVId && undefined !== pobjgs_PaperVerEN.paperVId && clsString_js_1.tzDataType.isNumber(pobjgs_PaperVerEN.paperVId) === false) {
            throw new Error("(errid:Watl000060)字段[PaperVId(paperVId)]的值:[$(pobjgs_PaperVerEN.paperVId)], 非法，应该为数值型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperId) == false && undefined !== pobjgs_PaperVerEN.paperId && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PaperVerEN.paperId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperTitle) == false && undefined !== pobjgs_PaperVerEN.paperTitle && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.paperTitle) === false) {
            throw new Error("(errid:Watl000060)字段[论文标题(paperTitle)]的值:[$(pobjgs_PaperVerEN.paperTitle)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperContent) == false && undefined !== pobjgs_PaperVerEN.paperContent && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.paperContent) === false) {
            throw new Error("(errid:Watl000060)字段[主题内容(paperContent)]的值:[$(pobjgs_PaperVerEN.paperContent)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.periodical) == false && undefined !== pobjgs_PaperVerEN.periodical && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.periodical) === false) {
            throw new Error("(errid:Watl000060)字段[期刊(periodical)]的值:[$(pobjgs_PaperVerEN.periodical)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.author) == false && undefined !== pobjgs_PaperVerEN.author && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.author) === false) {
            throw new Error("(errid:Watl000060)字段[作者(author)]的值:[$(pobjgs_PaperVerEN.author)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.researchQuestion) == false && undefined !== pobjgs_PaperVerEN.researchQuestion && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.researchQuestion) === false) {
            throw new Error("(errid:Watl000060)字段[研究问题(researchQuestion)]的值:[$(pobjgs_PaperVerEN.researchQuestion)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.keyword) == false && undefined !== pobjgs_PaperVerEN.keyword && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.keyword) === false) {
            throw new Error("(errid:Watl000060)字段[关键字(keyword)]的值:[$(pobjgs_PaperVerEN.keyword)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureSources) == false && undefined !== pobjgs_PaperVerEN.literatureSources && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.literatureSources) === false) {
            throw new Error("(errid:Watl000060)字段[文献来源(literatureSources)]的值:[$(pobjgs_PaperVerEN.literatureSources)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureLink) == false && undefined !== pobjgs_PaperVerEN.literatureLink && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.literatureLink) === false) {
            throw new Error("(errid:Watl000060)字段[文献链接(literatureLink)]的值:[$(pobjgs_PaperVerEN.literatureLink)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.uploadfileUrl) == false && undefined !== pobjgs_PaperVerEN.uploadfileUrl && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.uploadfileUrl) === false) {
            throw new Error("(errid:Watl000060)字段[文件地址(uploadfileUrl)]的值:[$(pobjgs_PaperVerEN.uploadfileUrl)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if (null != pobjgs_PaperVerEN.isQuotethesis && undefined !== pobjgs_PaperVerEN.isQuotethesis && clsString_js_1.tzDataType.isBoolean(pobjgs_PaperVerEN.isQuotethesis) === false) {
            throw new Error("(errid:Watl000060)字段[是否引用论文(isQuotethesis)]的值:[$(pobjgs_PaperVerEN.isQuotethesis)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if (null != pobjgs_PaperVerEN.isSubmit && undefined !== pobjgs_PaperVerEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjgs_PaperVerEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_PaperVerEN.isSubmit)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if (null != pobjgs_PaperVerEN.isChecked && undefined !== pobjgs_PaperVerEN.isChecked && clsString_js_1.tzDataType.isBoolean(pobjgs_PaperVerEN.isChecked) === false) {
            throw new Error("(errid:Watl000060)字段[是否检查(isChecked)]的值:[$(pobjgs_PaperVerEN.isChecked)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.quoteId) == false && undefined !== pobjgs_PaperVerEN.quoteId && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.quoteId) === false) {
            throw new Error("(errid:Watl000060)字段[引用Id(quoteId)]的值:[$(pobjgs_PaperVerEN.quoteId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.checker) == false && undefined !== pobjgs_PaperVerEN.checker && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.checker) === false) {
            throw new Error("(errid:Watl000060)字段[审核人(checker)]的值:[$(pobjgs_PaperVerEN.checker)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureTypeId) == false && undefined !== pobjgs_PaperVerEN.literatureTypeId && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.literatureTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[作文类型Id(literatureTypeId)]的值:[$(pobjgs_PaperVerEN.literatureTypeId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.updUser) == false && undefined !== pobjgs_PaperVerEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperVerEN.updUser)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.updDate) == false && undefined !== pobjgs_PaperVerEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperVerEN.updDate)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.id_CurrEduCls) == false && undefined !== pobjgs_PaperVerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_PaperVerEN.id_CurrEduCls)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperTypeId) == false && undefined !== pobjgs_PaperVerEN.paperTypeId && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.paperTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[论文类型Id(paperTypeId)]的值:[$(pobjgs_PaperVerEN.paperTypeId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperStatusId) == false && undefined !== pobjgs_PaperVerEN.paperStatusId && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.paperStatusId) === false) {
            throw new Error("(errid:Watl000060)字段[论文状态Id(paperStatusId)]的值:[$(pobjgs_PaperVerEN.paperStatusId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.memo) == false && undefined !== pobjgs_PaperVerEN.memo && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PaperVerEN.memo)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_PaperVerEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperVer_CheckPropertyNew = gs_PaperVer_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperVer_CheckProperty4Update(pobjgs_PaperVerEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperId)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperTitle) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.paperTitle) > 500) {
            throw new Error("(errid:Watl000062)字段[论文标题(paperTitle)]的长度不能超过500(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperTitle)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.periodical) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.periodical) > 100) {
            throw new Error("(errid:Watl000062)字段[期刊(periodical)]的长度不能超过100(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.periodical)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.author) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.author) > 200) {
            throw new Error("(errid:Watl000062)字段[作者(author)]的长度不能超过200(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.author)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.researchQuestion) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.researchQuestion) > 2000) {
            throw new Error("(errid:Watl000062)字段[研究问题(researchQuestion)]的长度不能超过2000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.researchQuestion)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.keyword) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.keyword) > 1000) {
            throw new Error("(errid:Watl000062)字段[关键字(keyword)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.keyword)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureSources) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.literatureSources) > 1000) {
            throw new Error("(errid:Watl000062)字段[文献来源(literatureSources)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.literatureSources)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureLink) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.literatureLink) > 1000) {
            throw new Error("(errid:Watl000062)字段[文献链接(literatureLink)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.literatureLink)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.uploadfileUrl) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.uploadfileUrl) > 1000) {
            throw new Error("(errid:Watl000062)字段[文件地址(uploadfileUrl)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.uploadfileUrl)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.quoteId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.quoteId) > 8) {
            throw new Error("(errid:Watl000062)字段[引用Id(quoteId)]的长度不能超过8(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.quoteId)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.checker) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.checker) > 20) {
            throw new Error("(errid:Watl000062)字段[审核人(checker)]的长度不能超过20(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.checker)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.literatureTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[作文类型Id(literatureTypeId)]的长度不能超过2(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.literatureTypeId)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.updUser)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.updDate)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.id_CurrEduCls)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.paperTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[论文类型Id(paperTypeId)]的长度不能超过2(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperTypeId)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperStatusId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.paperStatusId) > 2) {
            throw new Error("(errid:Watl000062)字段[论文状态Id(paperStatusId)]的长度不能超过2(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperStatusId)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.memo)(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_PaperVerEN.paperVId && undefined !== pobjgs_PaperVerEN.paperVId && clsString_js_1.tzDataType.isNumber(pobjgs_PaperVerEN.paperVId) === false) {
            throw new Error("(errid:Watl000063)字段[PaperVId(paperVId)]的值:[$(pobjgs_PaperVerEN.paperVId)], 非法，应该为数值型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperId) == false && undefined !== pobjgs_PaperVerEN.paperId && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PaperVerEN.paperId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperTitle) == false && undefined !== pobjgs_PaperVerEN.paperTitle && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.paperTitle) === false) {
            throw new Error("(errid:Watl000063)字段[论文标题(paperTitle)]的值:[$(pobjgs_PaperVerEN.paperTitle)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperContent) == false && undefined !== pobjgs_PaperVerEN.paperContent && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.paperContent) === false) {
            throw new Error("(errid:Watl000063)字段[主题内容(paperContent)]的值:[$(pobjgs_PaperVerEN.paperContent)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.periodical) == false && undefined !== pobjgs_PaperVerEN.periodical && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.periodical) === false) {
            throw new Error("(errid:Watl000063)字段[期刊(periodical)]的值:[$(pobjgs_PaperVerEN.periodical)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.author) == false && undefined !== pobjgs_PaperVerEN.author && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.author) === false) {
            throw new Error("(errid:Watl000063)字段[作者(author)]的值:[$(pobjgs_PaperVerEN.author)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.researchQuestion) == false && undefined !== pobjgs_PaperVerEN.researchQuestion && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.researchQuestion) === false) {
            throw new Error("(errid:Watl000063)字段[研究问题(researchQuestion)]的值:[$(pobjgs_PaperVerEN.researchQuestion)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.keyword) == false && undefined !== pobjgs_PaperVerEN.keyword && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.keyword) === false) {
            throw new Error("(errid:Watl000063)字段[关键字(keyword)]的值:[$(pobjgs_PaperVerEN.keyword)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureSources) == false && undefined !== pobjgs_PaperVerEN.literatureSources && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.literatureSources) === false) {
            throw new Error("(errid:Watl000063)字段[文献来源(literatureSources)]的值:[$(pobjgs_PaperVerEN.literatureSources)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureLink) == false && undefined !== pobjgs_PaperVerEN.literatureLink && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.literatureLink) === false) {
            throw new Error("(errid:Watl000063)字段[文献链接(literatureLink)]的值:[$(pobjgs_PaperVerEN.literatureLink)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.uploadfileUrl) == false && undefined !== pobjgs_PaperVerEN.uploadfileUrl && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.uploadfileUrl) === false) {
            throw new Error("(errid:Watl000063)字段[文件地址(uploadfileUrl)]的值:[$(pobjgs_PaperVerEN.uploadfileUrl)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if (null != pobjgs_PaperVerEN.isQuotethesis && undefined !== pobjgs_PaperVerEN.isQuotethesis && clsString_js_1.tzDataType.isBoolean(pobjgs_PaperVerEN.isQuotethesis) === false) {
            throw new Error("(errid:Watl000063)字段[是否引用论文(isQuotethesis)]的值:[$(pobjgs_PaperVerEN.isQuotethesis)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if (null != pobjgs_PaperVerEN.isSubmit && undefined !== pobjgs_PaperVerEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjgs_PaperVerEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_PaperVerEN.isSubmit)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if (null != pobjgs_PaperVerEN.isChecked && undefined !== pobjgs_PaperVerEN.isChecked && clsString_js_1.tzDataType.isBoolean(pobjgs_PaperVerEN.isChecked) === false) {
            throw new Error("(errid:Watl000063)字段[是否检查(isChecked)]的值:[$(pobjgs_PaperVerEN.isChecked)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.quoteId) == false && undefined !== pobjgs_PaperVerEN.quoteId && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.quoteId) === false) {
            throw new Error("(errid:Watl000063)字段[引用Id(quoteId)]的值:[$(pobjgs_PaperVerEN.quoteId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.checker) == false && undefined !== pobjgs_PaperVerEN.checker && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.checker) === false) {
            throw new Error("(errid:Watl000063)字段[审核人(checker)]的值:[$(pobjgs_PaperVerEN.checker)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.literatureTypeId) == false && undefined !== pobjgs_PaperVerEN.literatureTypeId && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.literatureTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[作文类型Id(literatureTypeId)]的值:[$(pobjgs_PaperVerEN.literatureTypeId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.updUser) == false && undefined !== pobjgs_PaperVerEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperVerEN.updUser)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.updDate) == false && undefined !== pobjgs_PaperVerEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperVerEN.updDate)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.id_CurrEduCls) == false && undefined !== pobjgs_PaperVerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_PaperVerEN.id_CurrEduCls)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperTypeId) == false && undefined !== pobjgs_PaperVerEN.paperTypeId && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.paperTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[论文类型Id(paperTypeId)]的值:[$(pobjgs_PaperVerEN.paperTypeId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.paperStatusId) == false && undefined !== pobjgs_PaperVerEN.paperStatusId && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.paperStatusId) === false) {
            throw new Error("(errid:Watl000063)字段[论文状态Id(paperStatusId)]的值:[$(pobjgs_PaperVerEN.paperStatusId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperVerEN.memo) == false && undefined !== pobjgs_PaperVerEN.memo && clsString_js_1.tzDataType.isString(pobjgs_PaperVerEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PaperVerEN.memo)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_PaperVerEN.paperVId
            || pobjgs_PaperVerEN.paperVId != null && pobjgs_PaperVerEN.paperVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[PaperVId]不能为空(In 论文历史版本表)!(clsgs_PaperVerBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_PaperVerEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperVer_CheckProperty4Update = gs_PaperVer_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperVer_GetJSONStrByObj(pobjgs_PaperVerEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_PaperVerEN.sf_UpdFldSetStr = pobjgs_PaperVerEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_PaperVerEN);
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
    exports.gs_PaperVer_GetJSONStrByObj = gs_PaperVer_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperVer_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_PaperVerObjLst = new Array();
        if (strJSON === "") {
            return arrgs_PaperVerObjLst;
        }
        try {
            arrgs_PaperVerObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_PaperVerObjLst;
        }
        return arrgs_PaperVerObjLst;
    }
    exports.gs_PaperVer_GetObjLstByJSONStr = gs_PaperVer_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_PaperVerObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperVer_GetObjLstByJSONObjLst(arrgs_PaperVerObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_PaperVerObjLst = new Array();
        for (const objInFor of arrgs_PaperVerObjLstS) {
            const obj1 = gs_PaperVer_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_PaperVerObjLst.push(obj1);
        }
        return arrgs_PaperVerObjLst;
    }
    exports.gs_PaperVer_GetObjLstByJSONObjLst = gs_PaperVer_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperVer_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_PaperVerEN = new clsgs_PaperVerEN_js_1.clsgs_PaperVerEN();
        if (strJSON === "") {
            return pobjgs_PaperVerEN;
        }
        try {
            pobjgs_PaperVerEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_PaperVerEN;
        }
        return pobjgs_PaperVerEN;
    }
    exports.gs_PaperVer_GetObjByJSONStr = gs_PaperVer_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_PaperVer_GetCombineCondition(objgs_PaperVer_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperVId) == true) {
            const strComparisonOp_PaperVId = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperVId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperVId, objgs_PaperVer_Cond.paperVId, strComparisonOp_PaperVId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperId, objgs_PaperVer_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle, objgs_PaperVer_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical) == true) {
            const strComparisonOp_Periodical = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical, objgs_PaperVer_Cond.periodical, strComparisonOp_Periodical);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author) == true) {
            const strComparisonOp_Author = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author, objgs_PaperVer_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion) == true) {
            const strComparisonOp_ResearchQuestion = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion, objgs_PaperVer_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword) == true) {
            const strComparisonOp_Keyword = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword, objgs_PaperVer_Cond.keyword, strComparisonOp_Keyword);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources) == true) {
            const strComparisonOp_LiteratureSources = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources, objgs_PaperVer_Cond.literatureSources, strComparisonOp_LiteratureSources);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink) == true) {
            const strComparisonOp_LiteratureLink = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink, objgs_PaperVer_Cond.literatureLink, strComparisonOp_LiteratureLink);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl) == true) {
            const strComparisonOp_UploadfileUrl = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl, objgs_PaperVer_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis) == true) {
            if (objgs_PaperVer_Cond.isQuotethesis == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit) == true) {
            if (objgs_PaperVer_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked) == true) {
            if (objgs_PaperVer_Cond.isChecked == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_QuoteId) == true) {
            const strComparisonOp_QuoteId = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_QuoteId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_QuoteId, objgs_PaperVer_Cond.quoteId, strComparisonOp_QuoteId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker) == true) {
            const strComparisonOp_Checker = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker, objgs_PaperVer_Cond.checker, strComparisonOp_Checker);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureTypeId) == true) {
            const strComparisonOp_LiteratureTypeId = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureTypeId, objgs_PaperVer_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdUser, objgs_PaperVer_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdDate, objgs_PaperVer_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls, objgs_PaperVer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTypeId) == true) {
            const strComparisonOp_PaperTypeId = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTypeId, objgs_PaperVer_Cond.paperTypeId, strComparisonOp_PaperTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperStatusId) == true) {
            const strComparisonOp_PaperStatusId = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperStatusId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperStatusId, objgs_PaperVer_Cond.paperStatusId, strComparisonOp_PaperStatusId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Memo, objgs_PaperVer_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_PaperVer_GetCombineCondition = gs_PaperVer_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperVer(论文历史版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngPaperVId: PaperVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperVer_GetUniCondStr_PaperVId(objgs_PaperVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperVId = '{0}'", objgs_PaperVerEN.paperVId);
        return strWhereCond;
    }
    exports.gs_PaperVer_GetUniCondStr_PaperVId = gs_PaperVer_GetUniCondStr_PaperVId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperVer(论文历史版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngPaperVId: PaperVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperVer_GetUniCondStr4Update_PaperVId(objgs_PaperVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperVId <> '{0}'", objgs_PaperVerEN.paperVId);
        strWhereCond += (0, clsString_js_2.Format)(" and PaperVId = '{0}'", objgs_PaperVerEN.paperVId);
        return strWhereCond;
    }
    exports.gs_PaperVer_GetUniCondStr4Update_PaperVId = gs_PaperVer_GetUniCondStr4Update_PaperVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_PaperVerENS:源对象
     * @param objgs_PaperVerENT:目标对象
    */
    function gs_PaperVer_CopyObjTo(objgs_PaperVerENS, objgs_PaperVerENT) {
        objgs_PaperVerENT.paperVId = objgs_PaperVerENS.paperVId; //PaperVId
        objgs_PaperVerENT.paperId = objgs_PaperVerENS.paperId; //论文Id
        objgs_PaperVerENT.paperTitle = objgs_PaperVerENS.paperTitle; //论文标题
        objgs_PaperVerENT.paperContent = objgs_PaperVerENS.paperContent; //主题内容
        objgs_PaperVerENT.periodical = objgs_PaperVerENS.periodical; //期刊
        objgs_PaperVerENT.author = objgs_PaperVerENS.author; //作者
        objgs_PaperVerENT.researchQuestion = objgs_PaperVerENS.researchQuestion; //研究问题
        objgs_PaperVerENT.keyword = objgs_PaperVerENS.keyword; //关键字
        objgs_PaperVerENT.literatureSources = objgs_PaperVerENS.literatureSources; //文献来源
        objgs_PaperVerENT.literatureLink = objgs_PaperVerENS.literatureLink; //文献链接
        objgs_PaperVerENT.uploadfileUrl = objgs_PaperVerENS.uploadfileUrl; //文件地址
        objgs_PaperVerENT.isQuotethesis = objgs_PaperVerENS.isQuotethesis; //是否引用论文
        objgs_PaperVerENT.isSubmit = objgs_PaperVerENS.isSubmit; //是否提交
        objgs_PaperVerENT.isChecked = objgs_PaperVerENS.isChecked; //是否检查
        objgs_PaperVerENT.quoteId = objgs_PaperVerENS.quoteId; //引用Id
        objgs_PaperVerENT.checker = objgs_PaperVerENS.checker; //审核人
        objgs_PaperVerENT.literatureTypeId = objgs_PaperVerENS.literatureTypeId; //作文类型Id
        objgs_PaperVerENT.updUser = objgs_PaperVerENS.updUser; //修改人
        objgs_PaperVerENT.updDate = objgs_PaperVerENS.updDate; //修改日期
        objgs_PaperVerENT.id_CurrEduCls = objgs_PaperVerENS.id_CurrEduCls; //教学班流水号
        objgs_PaperVerENT.paperTypeId = objgs_PaperVerENS.paperTypeId; //论文类型Id
        objgs_PaperVerENT.paperStatusId = objgs_PaperVerENS.paperStatusId; //论文状态Id
        objgs_PaperVerENT.memo = objgs_PaperVerENS.memo; //备注
        objgs_PaperVerENT.sf_UpdFldSetStr = objgs_PaperVerENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_PaperVer_CopyObjTo = gs_PaperVer_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_PaperVerENS:源对象
     * @param objgs_PaperVerENT:目标对象
    */
    function gs_PaperVer_GetObjFromJsonObj(objgs_PaperVerENS) {
        const objgs_PaperVerENT = new clsgs_PaperVerEN_js_1.clsgs_PaperVerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperVerENT, objgs_PaperVerENS);
        return objgs_PaperVerENT;
    }
    exports.gs_PaperVer_GetObjFromJsonObj = gs_PaperVer_GetObjFromJsonObj;
});
