/**
* 类名:clsvgs_PaperVerWApi
* 表名:vgs_PaperVer(01120677)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:55:19
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsvgs_PaperVerEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_PaperVer_GetObjFromJsonObj = exports.vgs_PaperVer_CopyObjTo = exports.vgs_PaperVer_GetCombineCondition = exports.vgs_PaperVer_GetObjByJSONStr = exports.vgs_PaperVer_GetObjLstByJSONObjLst = exports.vgs_PaperVer_GetObjLstByJSONStr = exports.vgs_PaperVer_GetJSONStrByObj = exports.vgs_PaperVer_GetWebApiUrl = exports.vgs_PaperVer_GetRecCountByCondAsync = exports.vgs_PaperVer_IsExistAsync = exports.vgs_PaperVer_IsExist = exports.vgs_PaperVer_IsExistRecordAsync = exports.vgs_PaperVer_GetObjLstByPagerAsync = exports.vgs_PaperVer_GetObjLstByRange = exports.vgs_PaperVer_GetObjLstByRangeAsync = exports.vgs_PaperVer_GetTopObjLstAsync = exports.vgs_PaperVer_GetObjLstByPaperVIdLstAsync = exports.vgs_PaperVer_GetObjLstAsync = exports.vgs_PaperVer_GetFirstObjAsync = exports.vgs_PaperVer_GetFirstID = exports.vgs_PaperVer_GetFirstIDAsync = exports.vgs_PaperVer_FilterFunByKey = exports.vgs_PaperVer_SortFunByKey = exports.vgs_PaperVer_SortFun_Defa_2Fld = exports.vgs_PaperVer_SortFun_Defa = exports.vgs_PaperVer_GetObjByPaperVIdAsync = exports.vgs_PaperVer_ConstructorName = exports.vgs_PaperVer_Controller = void 0;
    /**
     * 论文历史版本视图(vgs_PaperVer)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvgs_PaperVerEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvgs_PaperVerEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_PaperVer_Controller = "vgs_PaperVerApi";
    exports.vgs_PaperVer_ConstructorName = "vgs_PaperVer";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperVId:关键字
    * @returns 对象
    **/
    async function vgs_PaperVer_GetObjByPaperVIdAsync(lngPaperVId) {
        const strThisFuncName = "GetObjByPaperVIdAsync";
        if (lngPaperVId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperVId]不能为空！(In clsvgs_PaperVerWApi.GetObjByPaperVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
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
                const objvgs_PaperVer = vgs_PaperVer_GetObjFromJsonObj(returnObj);
                return objvgs_PaperVer;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_GetObjByPaperVIdAsync = vgs_PaperVer_GetObjByPaperVIdAsync;
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
    function vgs_PaperVer_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperVId - b.paperVId;
    }
    exports.vgs_PaperVer_SortFun_Defa = vgs_PaperVer_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PaperVer_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.paperTitle.localeCompare(b.paperTitle);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.vgs_PaperVer_SortFun_Defa_2Fld = vgs_PaperVer_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PaperVer_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperVId:
                    return (a, b) => {
                        return a.paperVId - b.paperVId;
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperContent:
                    return (a, b) => {
                        if (a.paperContent == null)
                            return -1;
                        if (b.paperContent == null)
                            return 1;
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Periodical:
                    return (a, b) => {
                        if (a.periodical == null)
                            return -1;
                        if (b.periodical == null)
                            return 1;
                        return a.periodical.localeCompare(b.periodical);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Author:
                    return (a, b) => {
                        if (a.author == null)
                            return -1;
                        if (b.author == null)
                            return 1;
                        return a.author.localeCompare(b.author);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (a.researchQuestion == null)
                            return -1;
                        if (b.researchQuestion == null)
                            return 1;
                        return a.researchQuestion.localeCompare(b.researchQuestion);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Keyword:
                    return (a, b) => {
                        if (a.keyword == null)
                            return -1;
                        if (b.keyword == null)
                            return 1;
                        return a.keyword.localeCompare(b.keyword);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureSources:
                    return (a, b) => {
                        if (a.literatureSources == null)
                            return -1;
                        if (b.literatureSources == null)
                            return 1;
                        return a.literatureSources.localeCompare(b.literatureSources);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureLink:
                    return (a, b) => {
                        if (a.literatureLink == null)
                            return -1;
                        if (b.literatureLink == null)
                            return 1;
                        return a.literatureLink.localeCompare(b.literatureLink);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UploadfileUrl:
                    return (a, b) => {
                        if (a.uploadfileUrl == null)
                            return -1;
                        if (b.uploadfileUrl == null)
                            return 1;
                        return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsQuotethesis:
                    return (a, b) => {
                        if (a.isQuotethesis == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsChecked:
                    return (a, b) => {
                        if (a.isChecked == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_QuoteId:
                    return (a, b) => {
                        if (a.quoteId == null)
                            return -1;
                        if (b.quoteId == null)
                            return 1;
                        return a.quoteId.localeCompare(b.quoteId);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Checker:
                    return (a, b) => {
                        if (a.checker == null)
                            return -1;
                        if (b.checker == null)
                            return 1;
                        return a.checker.localeCompare(b.checker);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureTypeId:
                    return (a, b) => {
                        return a.literatureTypeId.localeCompare(b.literatureTypeId);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureTypeName:
                    return (a, b) => {
                        if (a.literatureTypeName == null)
                            return -1;
                        if (b.literatureTypeName == null)
                            return 1;
                        return a.literatureTypeName.localeCompare(b.literatureTypeName);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTypeId:
                    return (a, b) => {
                        if (a.paperTypeId == null)
                            return -1;
                        if (b.paperTypeId == null)
                            return 1;
                        return a.paperTypeId.localeCompare(b.paperTypeId);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTypeName:
                    return (a, b) => {
                        if (a.paperTypeName == null)
                            return -1;
                        if (b.paperTypeName == null)
                            return 1;
                        return a.paperTypeName.localeCompare(b.paperTypeName);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperStatusId:
                    return (a, b) => {
                        if (a.paperStatusId == null)
                            return -1;
                        if (b.paperStatusId == null)
                            return 1;
                        return a.paperStatusId.localeCompare(b.paperStatusId);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperStatusName:
                    return (a, b) => {
                        if (a.paperStatusName == null)
                            return -1;
                        if (b.paperStatusName == null)
                            return 1;
                        return a.paperStatusName.localeCompare(b.paperStatusName);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperVer]中不存在！(in ${exports.vgs_PaperVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperVId:
                    return (a, b) => {
                        return b.paperVId - a.paperVId;
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperContent:
                    return (a, b) => {
                        if (b.paperContent == null)
                            return -1;
                        if (a.paperContent == null)
                            return 1;
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Periodical:
                    return (a, b) => {
                        if (b.periodical == null)
                            return -1;
                        if (a.periodical == null)
                            return 1;
                        return b.periodical.localeCompare(a.periodical);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Author:
                    return (a, b) => {
                        if (b.author == null)
                            return -1;
                        if (a.author == null)
                            return 1;
                        return b.author.localeCompare(a.author);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (b.researchQuestion == null)
                            return -1;
                        if (a.researchQuestion == null)
                            return 1;
                        return b.researchQuestion.localeCompare(a.researchQuestion);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Keyword:
                    return (a, b) => {
                        if (b.keyword == null)
                            return -1;
                        if (a.keyword == null)
                            return 1;
                        return b.keyword.localeCompare(a.keyword);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureSources:
                    return (a, b) => {
                        if (b.literatureSources == null)
                            return -1;
                        if (a.literatureSources == null)
                            return 1;
                        return b.literatureSources.localeCompare(a.literatureSources);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureLink:
                    return (a, b) => {
                        if (b.literatureLink == null)
                            return -1;
                        if (a.literatureLink == null)
                            return 1;
                        return b.literatureLink.localeCompare(a.literatureLink);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UploadfileUrl:
                    return (a, b) => {
                        if (b.uploadfileUrl == null)
                            return -1;
                        if (a.uploadfileUrl == null)
                            return 1;
                        return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsQuotethesis:
                    return (a, b) => {
                        if (b.isQuotethesis == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsChecked:
                    return (a, b) => {
                        if (b.isChecked == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_QuoteId:
                    return (a, b) => {
                        if (b.quoteId == null)
                            return -1;
                        if (a.quoteId == null)
                            return 1;
                        return b.quoteId.localeCompare(a.quoteId);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Checker:
                    return (a, b) => {
                        if (b.checker == null)
                            return -1;
                        if (a.checker == null)
                            return 1;
                        return b.checker.localeCompare(a.checker);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureTypeId:
                    return (a, b) => {
                        return b.literatureTypeId.localeCompare(a.literatureTypeId);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureTypeName:
                    return (a, b) => {
                        if (b.literatureTypeName == null)
                            return -1;
                        if (a.literatureTypeName == null)
                            return 1;
                        return b.literatureTypeName.localeCompare(a.literatureTypeName);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTypeId:
                    return (a, b) => {
                        if (b.paperTypeId == null)
                            return -1;
                        if (a.paperTypeId == null)
                            return 1;
                        return b.paperTypeId.localeCompare(a.paperTypeId);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTypeName:
                    return (a, b) => {
                        if (b.paperTypeName == null)
                            return -1;
                        if (a.paperTypeName == null)
                            return 1;
                        return b.paperTypeName.localeCompare(a.paperTypeName);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperStatusId:
                    return (a, b) => {
                        if (b.paperStatusId == null)
                            return -1;
                        if (a.paperStatusId == null)
                            return 1;
                        return b.paperStatusId.localeCompare(a.paperStatusId);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperStatusName:
                    return (a, b) => {
                        if (b.paperStatusName == null)
                            return -1;
                        if (a.paperStatusName == null)
                            return 1;
                        return b.paperStatusName.localeCompare(a.paperStatusName);
                    };
                case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperVer]中不存在！(in ${exports.vgs_PaperVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_PaperVer_SortFunByKey = vgs_PaperVer_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_PaperVer_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperVId:
                return (obj) => {
                    return obj.paperVId === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Periodical:
                return (obj) => {
                    return obj.periodical === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_ResearchQuestion:
                return (obj) => {
                    return obj.researchQuestion === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Keyword:
                return (obj) => {
                    return obj.keyword === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureSources:
                return (obj) => {
                    return obj.literatureSources === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureLink:
                return (obj) => {
                    return obj.literatureLink === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UploadfileUrl:
                return (obj) => {
                    return obj.uploadfileUrl === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsQuotethesis:
                return (obj) => {
                    return obj.isQuotethesis === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsChecked:
                return (obj) => {
                    return obj.isChecked === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_QuoteId:
                return (obj) => {
                    return obj.quoteId === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Checker:
                return (obj) => {
                    return obj.checker === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureTypeId:
                return (obj) => {
                    return obj.literatureTypeId === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureTypeName:
                return (obj) => {
                    return obj.literatureTypeName === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTypeId:
                return (obj) => {
                    return obj.paperTypeId === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTypeName:
                return (obj) => {
                    return obj.paperTypeName === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperStatusId:
                return (obj) => {
                    return obj.paperStatusId === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperStatusName:
                return (obj) => {
                    return obj.paperStatusName === value;
                };
            case clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperVer]中不存在！(in ${exports.vgs_PaperVer_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_PaperVer_FilterFunByKey = vgs_PaperVer_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_PaperVer_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_GetFirstIDAsync = vgs_PaperVer_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_PaperVer_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_GetFirstID = vgs_PaperVer_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_PaperVer_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
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
                const objvgs_PaperVer = vgs_PaperVer_GetObjFromJsonObj(returnObj);
                return objvgs_PaperVer;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_GetFirstObjAsync = vgs_PaperVer_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_PaperVer_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_GetObjLstAsync = vgs_PaperVer_GetObjLstAsync;
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
    async function vgs_PaperVer_GetObjLstByPaperVIdLstAsync(arrPaperVId) {
        const strThisFuncName = "GetObjLstByPaperVIdLstAsync";
        const strAction = "GetObjLstByPaperVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_GetObjLstByPaperVIdLstAsync = vgs_PaperVer_GetObjLstByPaperVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_PaperVer_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_GetTopObjLstAsync = vgs_PaperVer_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PaperVer_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_GetObjLstByRangeAsync = vgs_PaperVer_GetObjLstByRangeAsync;
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
    async function vgs_PaperVer_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_GetObjLstByRange = vgs_PaperVer_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PaperVer_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_GetObjLstByPagerAsync = vgs_PaperVer_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_PaperVer_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_IsExistRecordAsync = vgs_PaperVer_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_PaperVer_IsExist(lngPaperVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_IsExist = vgs_PaperVer_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_PaperVer_IsExistAsync(lngPaperVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_IsExistAsync = vgs_PaperVer_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_PaperVer_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperVer_GetRecCountByCondAsync = vgs_PaperVer_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_PaperVer_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_PaperVer_GetWebApiUrl = vgs_PaperVer_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_PaperVer_GetJSONStrByObj(pobjvgs_PaperVerEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_PaperVerEN);
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
    exports.vgs_PaperVer_GetJSONStrByObj = vgs_PaperVer_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_PaperVer_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_PaperVerObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_PaperVerObjLst;
        }
        try {
            arrvgs_PaperVerObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_PaperVerObjLst;
        }
        return arrvgs_PaperVerObjLst;
    }
    exports.vgs_PaperVer_GetObjLstByJSONStr = vgs_PaperVer_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_PaperVerObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_PaperVer_GetObjLstByJSONObjLst(arrvgs_PaperVerObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_PaperVerObjLst = new Array();
        for (const objInFor of arrvgs_PaperVerObjLstS) {
            const obj1 = vgs_PaperVer_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_PaperVerObjLst.push(obj1);
        }
        return arrvgs_PaperVerObjLst;
    }
    exports.vgs_PaperVer_GetObjLstByJSONObjLst = vgs_PaperVer_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_PaperVer_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_PaperVerEN = new clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN();
        if (strJSON === "") {
            return pobjvgs_PaperVerEN;
        }
        try {
            pobjvgs_PaperVerEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_PaperVerEN;
        }
        return pobjvgs_PaperVerEN;
    }
    exports.vgs_PaperVer_GetObjByJSONStr = vgs_PaperVer_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_PaperVer_GetCombineCondition(objvgs_PaperVer_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperVId) == true) {
            const strComparisonOp_PaperVId = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperVId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperVId, objvgs_PaperVer_Cond.paperVId, strComparisonOp_PaperVId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperId, objvgs_PaperVer_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTitle, objvgs_PaperVer_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Periodical) == true) {
            const strComparisonOp_Periodical = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Periodical];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Periodical, objvgs_PaperVer_Cond.periodical, strComparisonOp_Periodical);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Author) == true) {
            const strComparisonOp_Author = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Author, objvgs_PaperVer_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_ResearchQuestion) == true) {
            const strComparisonOp_ResearchQuestion = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_ResearchQuestion];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_ResearchQuestion, objvgs_PaperVer_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Keyword) == true) {
            const strComparisonOp_Keyword = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Keyword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Keyword, objvgs_PaperVer_Cond.keyword, strComparisonOp_Keyword);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureSources) == true) {
            const strComparisonOp_LiteratureSources = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureSources];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureSources, objvgs_PaperVer_Cond.literatureSources, strComparisonOp_LiteratureSources);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureLink) == true) {
            const strComparisonOp_LiteratureLink = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureLink];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureLink, objvgs_PaperVer_Cond.literatureLink, strComparisonOp_LiteratureLink);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UploadfileUrl) == true) {
            const strComparisonOp_UploadfileUrl = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UploadfileUrl];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UploadfileUrl, objvgs_PaperVer_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsQuotethesis) == true) {
            if (objvgs_PaperVer_Cond.isQuotethesis == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsQuotethesis);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsQuotethesis);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsSubmit) == true) {
            if (objvgs_PaperVer_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsChecked) == true) {
            if (objvgs_PaperVer_Cond.isChecked == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsChecked);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_IsChecked);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_QuoteId) == true) {
            const strComparisonOp_QuoteId = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_QuoteId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_QuoteId, objvgs_PaperVer_Cond.quoteId, strComparisonOp_QuoteId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Checker) == true) {
            const strComparisonOp_Checker = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Checker];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Checker, objvgs_PaperVer_Cond.checker, strComparisonOp_Checker);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureTypeId) == true) {
            const strComparisonOp_LiteratureTypeId = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureTypeId, objvgs_PaperVer_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureTypeName) == true) {
            const strComparisonOp_LiteratureTypeName = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_LiteratureTypeName, objvgs_PaperVer_Cond.literatureTypeName, strComparisonOp_LiteratureTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UpdUser, objvgs_PaperVer_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_UpdDate, objvgs_PaperVer_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_id_CurrEduCls, objvgs_PaperVer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTypeId) == true) {
            const strComparisonOp_PaperTypeId = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTypeId, objvgs_PaperVer_Cond.paperTypeId, strComparisonOp_PaperTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTypeName) == true) {
            const strComparisonOp_PaperTypeName = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperTypeName, objvgs_PaperVer_Cond.paperTypeName, strComparisonOp_PaperTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperStatusId) == true) {
            const strComparisonOp_PaperStatusId = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperStatusId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperStatusId, objvgs_PaperVer_Cond.paperStatusId, strComparisonOp_PaperStatusId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperStatusName) == true) {
            const strComparisonOp_PaperStatusName = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperStatusName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_PaperStatusName, objvgs_PaperVer_Cond.paperStatusName, strComparisonOp_PaperStatusName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperVer_Cond.dicFldComparisonOp, clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_PaperVer_Cond.dicFldComparisonOp[clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN.con_Memo, objvgs_PaperVer_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vgs_PaperVer_GetCombineCondition = vgs_PaperVer_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_PaperVerENS:源对象
     * @param objvgs_PaperVerENT:目标对象
    */
    function vgs_PaperVer_CopyObjTo(objvgs_PaperVerENS, objvgs_PaperVerENT) {
        objvgs_PaperVerENT.paperVId = objvgs_PaperVerENS.paperVId; //PaperVId
        objvgs_PaperVerENT.paperId = objvgs_PaperVerENS.paperId; //论文Id
        objvgs_PaperVerENT.paperTitle = objvgs_PaperVerENS.paperTitle; //论文标题
        objvgs_PaperVerENT.paperContent = objvgs_PaperVerENS.paperContent; //主题内容
        objvgs_PaperVerENT.periodical = objvgs_PaperVerENS.periodical; //期刊
        objvgs_PaperVerENT.author = objvgs_PaperVerENS.author; //作者
        objvgs_PaperVerENT.researchQuestion = objvgs_PaperVerENS.researchQuestion; //研究问题
        objvgs_PaperVerENT.keyword = objvgs_PaperVerENS.keyword; //关键字
        objvgs_PaperVerENT.literatureSources = objvgs_PaperVerENS.literatureSources; //文献来源
        objvgs_PaperVerENT.literatureLink = objvgs_PaperVerENS.literatureLink; //文献链接
        objvgs_PaperVerENT.uploadfileUrl = objvgs_PaperVerENS.uploadfileUrl; //文件地址
        objvgs_PaperVerENT.isQuotethesis = objvgs_PaperVerENS.isQuotethesis; //是否引用论文
        objvgs_PaperVerENT.isSubmit = objvgs_PaperVerENS.isSubmit; //是否提交
        objvgs_PaperVerENT.isChecked = objvgs_PaperVerENS.isChecked; //是否检查
        objvgs_PaperVerENT.quoteId = objvgs_PaperVerENS.quoteId; //引用Id
        objvgs_PaperVerENT.checker = objvgs_PaperVerENS.checker; //审核人
        objvgs_PaperVerENT.literatureTypeId = objvgs_PaperVerENS.literatureTypeId; //作文类型Id
        objvgs_PaperVerENT.literatureTypeName = objvgs_PaperVerENS.literatureTypeName; //作文类型名
        objvgs_PaperVerENT.updUser = objvgs_PaperVerENS.updUser; //修改人
        objvgs_PaperVerENT.updDate = objvgs_PaperVerENS.updDate; //修改日期
        objvgs_PaperVerENT.id_CurrEduCls = objvgs_PaperVerENS.id_CurrEduCls; //教学班流水号
        objvgs_PaperVerENT.paperTypeId = objvgs_PaperVerENS.paperTypeId; //论文类型Id
        objvgs_PaperVerENT.paperTypeName = objvgs_PaperVerENS.paperTypeName; //论文类型名
        objvgs_PaperVerENT.paperStatusId = objvgs_PaperVerENS.paperStatusId; //论文状态Id
        objvgs_PaperVerENT.paperStatusName = objvgs_PaperVerENS.paperStatusName; //论文状态名
        objvgs_PaperVerENT.memo = objvgs_PaperVerENS.memo; //备注
    }
    exports.vgs_PaperVer_CopyObjTo = vgs_PaperVer_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_PaperVerENS:源对象
     * @param objvgs_PaperVerENT:目标对象
    */
    function vgs_PaperVer_GetObjFromJsonObj(objvgs_PaperVerENS) {
        const objvgs_PaperVerENT = new clsvgs_PaperVerEN_js_1.clsvgs_PaperVerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_PaperVerENT, objvgs_PaperVerENS);
        return objvgs_PaperVerENT;
    }
    exports.vgs_PaperVer_GetObjFromJsonObj = vgs_PaperVer_GetObjFromJsonObj;
});
