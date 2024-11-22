/**
* 类名:clsPaperWApi
* 表名:Paper(01120535)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/15 23:44:10
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsPaperEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Paper_GetObjFromJsonObj = exports.Paper_CopyObjTo = exports.Paper_GetUniCondStr4Update_PaperTitle_Author = exports.Paper_GetUniCondStr_PaperTitle_Author = exports.Paper_GetCombineCondition = exports.Paper_GetObjByJSONStr = exports.Paper_GetObjLstByJSONObjLst = exports.Paper_GetObjLstByJSONStr = exports.Paper_GetJSONStrByObj = exports.Paper_CheckProperty4Update = exports.Paper_CheckPropertyNew = exports.Paper_GetWebApiUrl = exports.Paper_GetMaxStrIdByPrefix = exports.Paper_GetMaxStrIdAsync = exports.Paper_GetRecCountByCondAsync = exports.Paper_IsExistAsync = exports.Paper_IsExist = exports.Paper_IsExistRecordAsync = exports.Paper_UpdateWithConditionAsync = exports.Paper_UpdateRecordAsync = exports.Paper_AddNewRecordWithReturnKey = exports.Paper_AddNewRecordWithReturnKeyAsync = exports.Paper_AddNewRecordWithMaxIdAsync = exports.Paper_AddNewRecordAsync = exports.Paper_DelPapersByCondAsync = exports.Paper_DelPapersAsync = exports.Paper_DelRecordAsync = exports.Paper_GetObjLstByPagerAsync = exports.Paper_GetObjLstByRange = exports.Paper_GetObjLstByRangeAsync = exports.Paper_GetTopObjLstAsync = exports.Paper_GetObjLstByPaperIdLstAsync = exports.Paper_GetObjLstAsync = exports.Paper_GetFirstObjAsync = exports.Paper_GetFirstID = exports.Paper_GetFirstIDAsync = exports.Paper_FilterFunByKey = exports.Paper_SortFunByKey = exports.Paper_SortFun_Defa_2Fld = exports.Paper_SortFun_Defa = exports.Paper_GetObjByPaperIdAsync = exports.paper_ConstructorName = exports.paper_Controller = void 0;
    /**
     * 论文表(Paper)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月15日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsPaperEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.paper_Controller = "PaperApi";
    exports.paper_ConstructorName = "paper";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strPaperId:关键字
    * @returns 对象
    **/
    async function Paper_GetObjByPaperIdAsync(strPaperId) {
        const strThisFuncName = "GetObjByPaperIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPaperId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPaperId]不能为空！(In clsPaperWApi.GetObjByPaperIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPaperId]的长度:[{0}]不正确！(clsPaperWApi.GetObjByPaperIdAsync)", strPaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strPaperId": strPaperId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objPaper = Paper_GetObjFromJsonObj(returnObj);
                return objPaper;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetObjByPaperIdAsync = Paper_GetObjByPaperIdAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Paper_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperId.localeCompare(b.paperId);
    }
    exports.Paper_SortFun_Defa = Paper_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Paper_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperTitle == b.paperTitle)
            return a.paperContent.localeCompare(b.paperContent);
        else
            return a.paperTitle.localeCompare(b.paperTitle);
    }
    exports.Paper_SortFun_Defa_2Fld = Paper_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Paper_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPaperEN_js_1.clsPaperEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_PaperContent:
                    return (a, b) => {
                        if (a.paperContent == null)
                            return -1;
                        if (b.paperContent == null)
                            return 1;
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Periodical:
                    return (a, b) => {
                        if (a.periodical == null)
                            return -1;
                        if (b.periodical == null)
                            return 1;
                        return a.periodical.localeCompare(b.periodical);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Author:
                    return (a, b) => {
                        if (a.author == null)
                            return -1;
                        if (b.author == null)
                            return 1;
                        return a.author.localeCompare(b.author);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (a.researchQuestion == null)
                            return -1;
                        if (b.researchQuestion == null)
                            return 1;
                        return a.researchQuestion.localeCompare(b.researchQuestion);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Keyword:
                    return (a, b) => {
                        if (a.keyword == null)
                            return -1;
                        if (b.keyword == null)
                            return 1;
                        return a.keyword.localeCompare(b.keyword);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_LiteratureSources:
                    return (a, b) => {
                        if (a.literatureSources == null)
                            return -1;
                        if (b.literatureSources == null)
                            return 1;
                        return a.literatureSources.localeCompare(b.literatureSources);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_LiteratureLink:
                    return (a, b) => {
                        if (a.literatureLink == null)
                            return -1;
                        if (b.literatureLink == null)
                            return 1;
                        return a.literatureLink.localeCompare(b.literatureLink);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_UploadfileUrl:
                    return (a, b) => {
                        if (a.uploadfileUrl == null)
                            return -1;
                        if (b.uploadfileUrl == null)
                            return 1;
                        return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_IsQuotethesis:
                    return (a, b) => {
                        if (a.isQuotethesis == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_QuoteId:
                    return (a, b) => {
                        if (a.quoteId == null)
                            return -1;
                        if (b.quoteId == null)
                            return 1;
                        return a.quoteId.localeCompare(b.quoteId);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_IsChecked:
                    return (a, b) => {
                        if (a.isChecked == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Checker:
                    return (a, b) => {
                        if (a.checker == null)
                            return -1;
                        if (b.checker == null)
                            return 1;
                        return a.checker.localeCompare(b.checker);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId:
                    return (a, b) => {
                        return a.literatureTypeId.localeCompare(b.literatureTypeId);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_BrowseNumber:
                    return (a, b) => {
                        return a.browseNumber - b.browseNumber;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_AttachmentCount:
                    return (a, b) => {
                        return a.attachmentCount - b.attachmentCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_CollectionCount:
                    return (a, b) => {
                        return a.collectionCount - b.collectionCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_DownloadCount:
                    return (a, b) => {
                        return a.downloadCount - b.downloadCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Pcount:
                    return (a, b) => {
                        return a.pcount - b.pcount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_PaperTypeId:
                    return (a, b) => {
                        if (a.paperTypeId == null)
                            return -1;
                        if (b.paperTypeId == null)
                            return 1;
                        return a.paperTypeId.localeCompare(b.paperTypeId);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_PaperStatusId:
                    return (a, b) => {
                        if (a.paperStatusId == null)
                            return -1;
                        if (b.paperStatusId == null)
                            return 1;
                        return a.paperStatusId.localeCompare(b.paperStatusId);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_IsPublic:
                    return (a, b) => {
                        if (a.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_AskQuestion:
                    return (a, b) => {
                        if (a.askQuestion == null)
                            return -1;
                        if (b.askQuestion == null)
                            return 1;
                        return a.askQuestion.localeCompare(b.askQuestion);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_ResearchStatus:
                    return (a, b) => {
                        if (a.researchStatus == null)
                            return -1;
                        if (b.researchStatus == null)
                            return 1;
                        return a.researchStatus.localeCompare(b.researchStatus);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_InnovationPoints:
                    return (a, b) => {
                        if (a.innovationPoints == null)
                            return -1;
                        if (b.innovationPoints == null)
                            return 1;
                        return a.innovationPoints.localeCompare(b.innovationPoints);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_ResearchDesign:
                    return (a, b) => {
                        if (a.researchDesign == null)
                            return -1;
                        if (b.researchDesign == null)
                            return 1;
                        return a.researchDesign.localeCompare(b.researchDesign);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_DimensionDataProcess:
                    return (a, b) => {
                        if (a.dimensionDataProcess == null)
                            return -1;
                        if (b.dimensionDataProcess == null)
                            return 1;
                        return a.dimensionDataProcess.localeCompare(b.dimensionDataProcess);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_ExpectedConclusion:
                    return (a, b) => {
                        if (a.expectedConclusion == null)
                            return -1;
                        if (b.expectedConclusion == null)
                            return 1;
                        return a.expectedConclusion.localeCompare(b.expectedConclusion);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_ShareId:
                    return (a, b) => {
                        if (a.shareId == null)
                            return -1;
                        if (b.shareId == null)
                            return 1;
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_PaperQCount:
                    return (a, b) => {
                        return a.paperQCount - b.paperQCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_SubVCount:
                    return (a, b) => {
                        return a.subVCount - b.subVCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_TagsCount:
                    return (a, b) => {
                        return a.tagsCount - b.tagsCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_TeaQCount:
                    return (a, b) => {
                        return a.teaQCount - b.teaQCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Paper]中不存在！(in ${exports.paper_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsPaperEN_js_1.clsPaperEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_PaperContent:
                    return (a, b) => {
                        if (b.paperContent == null)
                            return -1;
                        if (a.paperContent == null)
                            return 1;
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Periodical:
                    return (a, b) => {
                        if (b.periodical == null)
                            return -1;
                        if (a.periodical == null)
                            return 1;
                        return b.periodical.localeCompare(a.periodical);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Author:
                    return (a, b) => {
                        if (b.author == null)
                            return -1;
                        if (a.author == null)
                            return 1;
                        return b.author.localeCompare(a.author);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (b.researchQuestion == null)
                            return -1;
                        if (a.researchQuestion == null)
                            return 1;
                        return b.researchQuestion.localeCompare(a.researchQuestion);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Keyword:
                    return (a, b) => {
                        if (b.keyword == null)
                            return -1;
                        if (a.keyword == null)
                            return 1;
                        return b.keyword.localeCompare(a.keyword);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_LiteratureSources:
                    return (a, b) => {
                        if (b.literatureSources == null)
                            return -1;
                        if (a.literatureSources == null)
                            return 1;
                        return b.literatureSources.localeCompare(a.literatureSources);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_LiteratureLink:
                    return (a, b) => {
                        if (b.literatureLink == null)
                            return -1;
                        if (a.literatureLink == null)
                            return 1;
                        return b.literatureLink.localeCompare(a.literatureLink);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_UploadfileUrl:
                    return (a, b) => {
                        if (b.uploadfileUrl == null)
                            return -1;
                        if (a.uploadfileUrl == null)
                            return 1;
                        return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_IsQuotethesis:
                    return (a, b) => {
                        if (b.isQuotethesis == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_QuoteId:
                    return (a, b) => {
                        if (b.quoteId == null)
                            return -1;
                        if (a.quoteId == null)
                            return 1;
                        return b.quoteId.localeCompare(a.quoteId);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_IsChecked:
                    return (a, b) => {
                        if (b.isChecked == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Checker:
                    return (a, b) => {
                        if (b.checker == null)
                            return -1;
                        if (a.checker == null)
                            return 1;
                        return b.checker.localeCompare(a.checker);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId:
                    return (a, b) => {
                        return b.literatureTypeId.localeCompare(a.literatureTypeId);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_BrowseNumber:
                    return (a, b) => {
                        return b.browseNumber - a.browseNumber;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_AttachmentCount:
                    return (a, b) => {
                        return b.attachmentCount - a.attachmentCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_CollectionCount:
                    return (a, b) => {
                        return b.collectionCount - a.collectionCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_DownloadCount:
                    return (a, b) => {
                        return b.downloadCount - a.downloadCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Pcount:
                    return (a, b) => {
                        return b.pcount - a.pcount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_PaperTypeId:
                    return (a, b) => {
                        if (b.paperTypeId == null)
                            return -1;
                        if (a.paperTypeId == null)
                            return 1;
                        return b.paperTypeId.localeCompare(a.paperTypeId);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_PaperStatusId:
                    return (a, b) => {
                        if (b.paperStatusId == null)
                            return -1;
                        if (a.paperStatusId == null)
                            return 1;
                        return b.paperStatusId.localeCompare(a.paperStatusId);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_IsPublic:
                    return (a, b) => {
                        if (b.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_AskQuestion:
                    return (a, b) => {
                        if (b.askQuestion == null)
                            return -1;
                        if (a.askQuestion == null)
                            return 1;
                        return b.askQuestion.localeCompare(a.askQuestion);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_ResearchStatus:
                    return (a, b) => {
                        if (b.researchStatus == null)
                            return -1;
                        if (a.researchStatus == null)
                            return 1;
                        return b.researchStatus.localeCompare(a.researchStatus);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_InnovationPoints:
                    return (a, b) => {
                        if (b.innovationPoints == null)
                            return -1;
                        if (a.innovationPoints == null)
                            return 1;
                        return b.innovationPoints.localeCompare(a.innovationPoints);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_ResearchDesign:
                    return (a, b) => {
                        if (b.researchDesign == null)
                            return -1;
                        if (a.researchDesign == null)
                            return 1;
                        return b.researchDesign.localeCompare(a.researchDesign);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_DimensionDataProcess:
                    return (a, b) => {
                        if (b.dimensionDataProcess == null)
                            return -1;
                        if (a.dimensionDataProcess == null)
                            return 1;
                        return b.dimensionDataProcess.localeCompare(a.dimensionDataProcess);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_ExpectedConclusion:
                    return (a, b) => {
                        if (b.expectedConclusion == null)
                            return -1;
                        if (a.expectedConclusion == null)
                            return 1;
                        return b.expectedConclusion.localeCompare(a.expectedConclusion);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_ShareId:
                    return (a, b) => {
                        if (b.shareId == null)
                            return -1;
                        if (a.shareId == null)
                            return 1;
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_PaperQCount:
                    return (a, b) => {
                        return b.paperQCount - a.paperQCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_SubVCount:
                    return (a, b) => {
                        return b.subVCount - a.subVCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_TagsCount:
                    return (a, b) => {
                        return b.tagsCount - a.tagsCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_TeaQCount:
                    return (a, b) => {
                        return b.teaQCount - a.teaQCount;
                    };
                case clsPaperEN_js_1.clsPaperEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsPaperEN_js_1.clsPaperEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Paper]中不存在！(in ${exports.paper_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.Paper_SortFunByKey = Paper_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function Paper_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsPaperEN_js_1.clsPaperEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_Periodical:
                return (obj) => {
                    return obj.periodical === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_ResearchQuestion:
                return (obj) => {
                    return obj.researchQuestion === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_Keyword:
                return (obj) => {
                    return obj.keyword === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_LiteratureSources:
                return (obj) => {
                    return obj.literatureSources === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_LiteratureLink:
                return (obj) => {
                    return obj.literatureLink === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_UploadfileUrl:
                return (obj) => {
                    return obj.uploadfileUrl === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_IsQuotethesis:
                return (obj) => {
                    return obj.isQuotethesis === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_QuoteId:
                return (obj) => {
                    return obj.quoteId === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_IsChecked:
                return (obj) => {
                    return obj.isChecked === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_Checker:
                return (obj) => {
                    return obj.checker === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId:
                return (obj) => {
                    return obj.literatureTypeId === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_BrowseNumber:
                return (obj) => {
                    return obj.browseNumber === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_AttachmentCount:
                return (obj) => {
                    return obj.attachmentCount === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_CollectionCount:
                return (obj) => {
                    return obj.collectionCount === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_DownloadCount:
                return (obj) => {
                    return obj.downloadCount === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_Pcount:
                return (obj) => {
                    return obj.pcount === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_PaperTypeId:
                return (obj) => {
                    return obj.paperTypeId === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_PaperStatusId:
                return (obj) => {
                    return obj.paperStatusId === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_IsPublic:
                return (obj) => {
                    return obj.isPublic === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_AskQuestion:
                return (obj) => {
                    return obj.askQuestion === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_ResearchStatus:
                return (obj) => {
                    return obj.researchStatus === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_InnovationPoints:
                return (obj) => {
                    return obj.innovationPoints === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_ResearchDesign:
                return (obj) => {
                    return obj.researchDesign === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_DimensionDataProcess:
                return (obj) => {
                    return obj.dimensionDataProcess === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_ExpectedConclusion:
                return (obj) => {
                    return obj.expectedConclusion === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_PaperQCount:
                return (obj) => {
                    return obj.paperQCount === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_SubVCount:
                return (obj) => {
                    return obj.subVCount === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_TagsCount:
                return (obj) => {
                    return obj.tagsCount === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_TeaQCount:
                return (obj) => {
                    return obj.teaQCount === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsPaperEN_js_1.clsPaperEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[Paper]中不存在！(in ${exports.paper_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.Paper_FilterFunByKey = Paper_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function Paper_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetFirstIDAsync = Paper_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function Paper_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetFirstID = Paper_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function Paper_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
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
                const objPaper = Paper_GetObjFromJsonObj(returnObj);
                return objPaper;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetFirstObjAsync = Paper_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function Paper_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Paper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetObjLstAsync = Paper_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperId:关键字列表
    * @returns 对象列表
    **/
    async function Paper_GetObjLstByPaperIdLstAsync(arrPaperId) {
        const strThisFuncName = "GetObjLstByPaperIdLstAsync";
        const strAction = "GetObjLstByPaperIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Paper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetObjLstByPaperIdLstAsync = Paper_GetObjLstByPaperIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function Paper_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Paper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetTopObjLstAsync = Paper_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Paper_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Paper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetObjLstByRangeAsync = Paper_GetObjLstByRangeAsync;
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
    async function Paper_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetObjLstByRange = Paper_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Paper_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Paper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetObjLstByPagerAsync = Paper_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strPaperId:关键字
    * @returns 获取删除的结果
    **/
    async function Paper_DelRecordAsync(strPaperId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strPaperId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_DelRecordAsync = Paper_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function Paper_DelPapersAsync(arrPaperId) {
        const strThisFuncName = "DelPapersAsync";
        const strAction = "DelPapers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_DelPapersAsync = Paper_DelPapersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function Paper_DelPapersByCondAsync(strWhereCond) {
        const strThisFuncName = "DelPapersByCondAsync";
        const strAction = "DelPapersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_DelPapersByCondAsync = Paper_DelPapersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objPaperEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Paper_AddNewRecordAsync(objPaperEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objPaperEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_AddNewRecordAsync = Paper_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objPaperEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Paper_AddNewRecordWithMaxIdAsync(objPaperEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_AddNewRecordWithMaxIdAsync = Paper_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objPaperEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function Paper_AddNewRecordWithReturnKeyAsync(objPaperEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_AddNewRecordWithReturnKeyAsync = Paper_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objPaperEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function Paper_AddNewRecordWithReturnKey(objPaperEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objPaperEN.paperId === null || objPaperEN.paperId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_AddNewRecordWithReturnKey = Paper_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objPaperEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function Paper_UpdateRecordAsync(objPaperEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objPaperEN.sf_UpdFldSetStr === undefined || objPaperEN.sf_UpdFldSetStr === null || objPaperEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperEN.paperId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_UpdateRecordAsync = Paper_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objPaperEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function Paper_UpdateWithConditionAsync(objPaperEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objPaperEN.sf_UpdFldSetStr === undefined || objPaperEN.sf_UpdFldSetStr === null || objPaperEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperEN.paperId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        objPaperEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objPaperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_UpdateWithConditionAsync = Paper_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function Paper_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_IsExistRecordAsync = Paper_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strPaperId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function Paper_IsExist(strPaperId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperId": strPaperId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_IsExist = Paper_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strPaperId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function Paper_IsExistAsync(strPaperId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strPaperId": strPaperId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_IsExistAsync = Paper_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function Paper_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetRecCountByCondAsync = Paper_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function Paper_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetMaxStrIdAsync = Paper_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function Paper_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Paper_GetMaxStrIdByPrefix = Paper_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function Paper_GetWebApiUrl(strController, strAction) {
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
    exports.Paper_GetWebApiUrl = Paper_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Paper_CheckPropertyNew(pobjPaperEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperTitle) === true) {
            throw new Error("(errid:Watl000058)字段[论文标题]不能为空(In 论文表)!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[作文类型Id]不能为空(In 论文表)!(clsPaperBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文表(Paper))!值:$(pobjPaperEN.paperId)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperTitle) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.paperTitle) > 500) {
            throw new Error("(errid:Watl000059)字段[论文标题(paperTitle)]的长度不能超过500(In 论文表(Paper))!值:$(pobjPaperEN.paperTitle)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.periodical) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.periodical) > 100) {
            throw new Error("(errid:Watl000059)字段[期刊(periodical)]的长度不能超过100(In 论文表(Paper))!值:$(pobjPaperEN.periodical)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.author) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.author) > 200) {
            throw new Error("(errid:Watl000059)字段[作者(author)]的长度不能超过200(In 论文表(Paper))!值:$(pobjPaperEN.author)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.researchQuestion) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.researchQuestion) > 2000) {
            throw new Error("(errid:Watl000059)字段[研究问题(researchQuestion)]的长度不能超过2000(In 论文表(Paper))!值:$(pobjPaperEN.researchQuestion)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.keyword) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.keyword) > 1000) {
            throw new Error("(errid:Watl000059)字段[关键字(keyword)]的长度不能超过1000(In 论文表(Paper))!值:$(pobjPaperEN.keyword)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureSources) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.literatureSources) > 1000) {
            throw new Error("(errid:Watl000059)字段[文献来源(literatureSources)]的长度不能超过1000(In 论文表(Paper))!值:$(pobjPaperEN.literatureSources)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureLink) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.literatureLink) > 1000) {
            throw new Error("(errid:Watl000059)字段[文献链接(literatureLink)]的长度不能超过1000(In 论文表(Paper))!值:$(pobjPaperEN.literatureLink)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.uploadfileUrl) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.uploadfileUrl) > 1000) {
            throw new Error("(errid:Watl000059)字段[文件地址(uploadfileUrl)]的长度不能超过1000(In 论文表(Paper))!值:$(pobjPaperEN.uploadfileUrl)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.quoteId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.quoteId) > 8) {
            throw new Error("(errid:Watl000059)字段[引用Id(quoteId)]的长度不能超过8(In 论文表(Paper))!值:$(pobjPaperEN.quoteId)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.checker) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.checker) > 20) {
            throw new Error("(errid:Watl000059)字段[审核人(checker)]的长度不能超过20(In 论文表(Paper))!值:$(pobjPaperEN.checker)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.literatureTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[作文类型Id(literatureTypeId)]的长度不能超过2(In 论文表(Paper))!值:$(pobjPaperEN.literatureTypeId)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.paperTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[论文类型Id(paperTypeId)]的长度不能超过2(In 论文表(Paper))!值:$(pobjPaperEN.paperTypeId)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperStatusId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.paperStatusId) > 2) {
            throw new Error("(errid:Watl000059)字段[论文状态Id(paperStatusId)]的长度不能超过2(In 论文表(Paper))!值:$(pobjPaperEN.paperStatusId)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.askQuestion) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.askQuestion) > 5000) {
            throw new Error("(errid:Watl000059)字段[问题提出(askQuestion)]的长度不能超过5000(In 论文表(Paper))!值:$(pobjPaperEN.askQuestion)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.researchStatus) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.researchStatus) > 5000) {
            throw new Error("(errid:Watl000059)字段[目前研究的现状(researchStatus)]的长度不能超过5000(In 论文表(Paper))!值:$(pobjPaperEN.researchStatus)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.innovationPoints) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.innovationPoints) > 5000) {
            throw new Error("(errid:Watl000059)字段[创新点(innovationPoints)]的长度不能超过5000(In 论文表(Paper))!值:$(pobjPaperEN.innovationPoints)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.researchDesign) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.researchDesign) > 5000) {
            throw new Error("(errid:Watl000059)字段[研究设计(researchDesign)]的长度不能超过5000(In 论文表(Paper))!值:$(pobjPaperEN.researchDesign)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.dimensionDataProcess) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.dimensionDataProcess) > 5000) {
            throw new Error("(errid:Watl000059)字段[数据处理的维度(dimensionDataProcess)]的长度不能超过5000(In 论文表(Paper))!值:$(pobjPaperEN.dimensionDataProcess)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.expectedConclusion) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.expectedConclusion) > 5000) {
            throw new Error("(errid:Watl000059)字段[预期结论(expectedConclusion)]的长度不能超过5000(In 论文表(Paper))!值:$(pobjPaperEN.expectedConclusion)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.shareId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.shareId) > 2) {
            throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 论文表(Paper))!值:$(pobjPaperEN.shareId)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.createDate) > 20) {
            throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 论文表(Paper))!值:$(pobjPaperEN.createDate)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文表(Paper))!值:$(pobjPaperEN.updUser)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文表(Paper))!值:$(pobjPaperEN.updDate)(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文表(Paper))!值:$(pobjPaperEN.memo)(clsPaperBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperId) == false && undefined !== pobjPaperEN.paperId && clsString_js_1.tzDataType.isString(pobjPaperEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperEN.paperId)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperTitle) == false && undefined !== pobjPaperEN.paperTitle && clsString_js_1.tzDataType.isString(pobjPaperEN.paperTitle) === false) {
            throw new Error("(errid:Watl000060)字段[论文标题(paperTitle)]的值:[$(pobjPaperEN.paperTitle)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperContent) == false && undefined !== pobjPaperEN.paperContent && clsString_js_1.tzDataType.isString(pobjPaperEN.paperContent) === false) {
            throw new Error("(errid:Watl000060)字段[主题内容(paperContent)]的值:[$(pobjPaperEN.paperContent)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.periodical) == false && undefined !== pobjPaperEN.periodical && clsString_js_1.tzDataType.isString(pobjPaperEN.periodical) === false) {
            throw new Error("(errid:Watl000060)字段[期刊(periodical)]的值:[$(pobjPaperEN.periodical)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.author) == false && undefined !== pobjPaperEN.author && clsString_js_1.tzDataType.isString(pobjPaperEN.author) === false) {
            throw new Error("(errid:Watl000060)字段[作者(author)]的值:[$(pobjPaperEN.author)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.researchQuestion) == false && undefined !== pobjPaperEN.researchQuestion && clsString_js_1.tzDataType.isString(pobjPaperEN.researchQuestion) === false) {
            throw new Error("(errid:Watl000060)字段[研究问题(researchQuestion)]的值:[$(pobjPaperEN.researchQuestion)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.keyword) == false && undefined !== pobjPaperEN.keyword && clsString_js_1.tzDataType.isString(pobjPaperEN.keyword) === false) {
            throw new Error("(errid:Watl000060)字段[关键字(keyword)]的值:[$(pobjPaperEN.keyword)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureSources) == false && undefined !== pobjPaperEN.literatureSources && clsString_js_1.tzDataType.isString(pobjPaperEN.literatureSources) === false) {
            throw new Error("(errid:Watl000060)字段[文献来源(literatureSources)]的值:[$(pobjPaperEN.literatureSources)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureLink) == false && undefined !== pobjPaperEN.literatureLink && clsString_js_1.tzDataType.isString(pobjPaperEN.literatureLink) === false) {
            throw new Error("(errid:Watl000060)字段[文献链接(literatureLink)]的值:[$(pobjPaperEN.literatureLink)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.uploadfileUrl) == false && undefined !== pobjPaperEN.uploadfileUrl && clsString_js_1.tzDataType.isString(pobjPaperEN.uploadfileUrl) === false) {
            throw new Error("(errid:Watl000060)字段[文件地址(uploadfileUrl)]的值:[$(pobjPaperEN.uploadfileUrl)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.isQuotethesis && undefined !== pobjPaperEN.isQuotethesis && clsString_js_1.tzDataType.isBoolean(pobjPaperEN.isQuotethesis) === false) {
            throw new Error("(errid:Watl000060)字段[是否引用论文(isQuotethesis)]的值:[$(pobjPaperEN.isQuotethesis)], 非法，应该为布尔型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.quoteId) == false && undefined !== pobjPaperEN.quoteId && clsString_js_1.tzDataType.isString(pobjPaperEN.quoteId) === false) {
            throw new Error("(errid:Watl000060)字段[引用Id(quoteId)]的值:[$(pobjPaperEN.quoteId)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.isChecked && undefined !== pobjPaperEN.isChecked && clsString_js_1.tzDataType.isBoolean(pobjPaperEN.isChecked) === false) {
            throw new Error("(errid:Watl000060)字段[是否检查(isChecked)]的值:[$(pobjPaperEN.isChecked)], 非法，应该为布尔型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.checker) == false && undefined !== pobjPaperEN.checker && clsString_js_1.tzDataType.isString(pobjPaperEN.checker) === false) {
            throw new Error("(errid:Watl000060)字段[审核人(checker)]的值:[$(pobjPaperEN.checker)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureTypeId) == false && undefined !== pobjPaperEN.literatureTypeId && clsString_js_1.tzDataType.isString(pobjPaperEN.literatureTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[作文类型Id(literatureTypeId)]的值:[$(pobjPaperEN.literatureTypeId)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.browseNumber && undefined !== pobjPaperEN.browseNumber && clsString_js_1.tzDataType.isNumber(pobjPaperEN.browseNumber) === false) {
            throw new Error("(errid:Watl000060)字段[浏览量(browseNumber)]的值:[$(pobjPaperEN.browseNumber)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.isSubmit && undefined !== pobjPaperEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjPaperEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjPaperEN.isSubmit)], 非法，应该为布尔型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.appraiseCount && undefined !== pobjPaperEN.appraiseCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000060)字段[评论数(appraiseCount)]的值:[$(pobjPaperEN.appraiseCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.attachmentCount && undefined !== pobjPaperEN.attachmentCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.attachmentCount) === false) {
            throw new Error("(errid:Watl000060)字段[附件计数(attachmentCount)]的值:[$(pobjPaperEN.attachmentCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.collectionCount && undefined !== pobjPaperEN.collectionCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.collectionCount) === false) {
            throw new Error("(errid:Watl000060)字段[收藏数量(collectionCount)]的值:[$(pobjPaperEN.collectionCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.downloadCount && undefined !== pobjPaperEN.downloadCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.downloadCount) === false) {
            throw new Error("(errid:Watl000060)字段[下载数(downloadCount)]的值:[$(pobjPaperEN.downloadCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.okCount && undefined !== pobjPaperEN.okCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.okCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjPaperEN.okCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.pcount && undefined !== pobjPaperEN.pcount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.pcount) === false) {
            throw new Error("(errid:Watl000060)字段[读写数(pcount)]的值:[$(pobjPaperEN.pcount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.score && undefined !== pobjPaperEN.score && clsString_js_1.tzDataType.isNumber(pobjPaperEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjPaperEN.score)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.stuScore && undefined !== pobjPaperEN.stuScore && clsString_js_1.tzDataType.isNumber(pobjPaperEN.stuScore) === false) {
            throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjPaperEN.stuScore)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.teaScore && undefined !== pobjPaperEN.teaScore && clsString_js_1.tzDataType.isNumber(pobjPaperEN.teaScore) === false) {
            throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjPaperEN.teaScore)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperTypeId) == false && undefined !== pobjPaperEN.paperTypeId && clsString_js_1.tzDataType.isString(pobjPaperEN.paperTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[论文类型Id(paperTypeId)]的值:[$(pobjPaperEN.paperTypeId)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperStatusId) == false && undefined !== pobjPaperEN.paperStatusId && clsString_js_1.tzDataType.isString(pobjPaperEN.paperStatusId) === false) {
            throw new Error("(errid:Watl000060)字段[论文状态Id(paperStatusId)]的值:[$(pobjPaperEN.paperStatusId)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.versionCount && undefined !== pobjPaperEN.versionCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.versionCount) === false) {
            throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjPaperEN.versionCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.isPublic && undefined !== pobjPaperEN.isPublic && clsString_js_1.tzDataType.isBoolean(pobjPaperEN.isPublic) === false) {
            throw new Error("(errid:Watl000060)字段[是否公开(isPublic)]的值:[$(pobjPaperEN.isPublic)], 非法，应该为布尔型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.askQuestion) == false && undefined !== pobjPaperEN.askQuestion && clsString_js_1.tzDataType.isString(pobjPaperEN.askQuestion) === false) {
            throw new Error("(errid:Watl000060)字段[问题提出(askQuestion)]的值:[$(pobjPaperEN.askQuestion)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.researchStatus) == false && undefined !== pobjPaperEN.researchStatus && clsString_js_1.tzDataType.isString(pobjPaperEN.researchStatus) === false) {
            throw new Error("(errid:Watl000060)字段[目前研究的现状(researchStatus)]的值:[$(pobjPaperEN.researchStatus)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.innovationPoints) == false && undefined !== pobjPaperEN.innovationPoints && clsString_js_1.tzDataType.isString(pobjPaperEN.innovationPoints) === false) {
            throw new Error("(errid:Watl000060)字段[创新点(innovationPoints)]的值:[$(pobjPaperEN.innovationPoints)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.researchDesign) == false && undefined !== pobjPaperEN.researchDesign && clsString_js_1.tzDataType.isString(pobjPaperEN.researchDesign) === false) {
            throw new Error("(errid:Watl000060)字段[研究设计(researchDesign)]的值:[$(pobjPaperEN.researchDesign)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.dimensionDataProcess) == false && undefined !== pobjPaperEN.dimensionDataProcess && clsString_js_1.tzDataType.isString(pobjPaperEN.dimensionDataProcess) === false) {
            throw new Error("(errid:Watl000060)字段[数据处理的维度(dimensionDataProcess)]的值:[$(pobjPaperEN.dimensionDataProcess)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.expectedConclusion) == false && undefined !== pobjPaperEN.expectedConclusion && clsString_js_1.tzDataType.isString(pobjPaperEN.expectedConclusion) === false) {
            throw new Error("(errid:Watl000060)字段[预期结论(expectedConclusion)]的值:[$(pobjPaperEN.expectedConclusion)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.shareId) == false && undefined !== pobjPaperEN.shareId && clsString_js_1.tzDataType.isString(pobjPaperEN.shareId) === false) {
            throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjPaperEN.shareId)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.paperQCount && undefined !== pobjPaperEN.paperQCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.paperQCount) === false) {
            throw new Error("(errid:Watl000060)字段[论文答疑数(paperQCount)]的值:[$(pobjPaperEN.paperQCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.subVCount && undefined !== pobjPaperEN.subVCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.subVCount) === false) {
            throw new Error("(errid:Watl000060)字段[论文子观点数(subVCount)]的值:[$(pobjPaperEN.subVCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.tagsCount && undefined !== pobjPaperEN.tagsCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.tagsCount) === false) {
            throw new Error("(errid:Watl000060)字段[论文标注数(tagsCount)]的值:[$(pobjPaperEN.tagsCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if (null != pobjPaperEN.teaQCount && undefined !== pobjPaperEN.teaQCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.teaQCount) === false) {
            throw new Error("(errid:Watl000060)字段[教师提问数(teaQCount)]的值:[$(pobjPaperEN.teaQCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.createDate) == false && undefined !== pobjPaperEN.createDate && clsString_js_1.tzDataType.isString(pobjPaperEN.createDate) === false) {
            throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjPaperEN.createDate)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.updUser) == false && undefined !== pobjPaperEN.updUser && clsString_js_1.tzDataType.isString(pobjPaperEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperEN.updUser)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.updDate) == false && undefined !== pobjPaperEN.updDate && clsString_js_1.tzDataType.isString(pobjPaperEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperEN.updDate)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.memo) == false && undefined !== pobjPaperEN.memo && clsString_js_1.tzDataType.isString(pobjPaperEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperEN.memo)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjPaperEN.SetIsCheckProperty(true);
    }
    exports.Paper_CheckPropertyNew = Paper_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Paper_CheckProperty4Update(pobjPaperEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文表(Paper))!值:$(pobjPaperEN.paperId)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperTitle) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.paperTitle) > 500) {
            throw new Error("(errid:Watl000062)字段[论文标题(paperTitle)]的长度不能超过500(In 论文表(Paper))!值:$(pobjPaperEN.paperTitle)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.periodical) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.periodical) > 100) {
            throw new Error("(errid:Watl000062)字段[期刊(periodical)]的长度不能超过100(In 论文表(Paper))!值:$(pobjPaperEN.periodical)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.author) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.author) > 200) {
            throw new Error("(errid:Watl000062)字段[作者(author)]的长度不能超过200(In 论文表(Paper))!值:$(pobjPaperEN.author)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.researchQuestion) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.researchQuestion) > 2000) {
            throw new Error("(errid:Watl000062)字段[研究问题(researchQuestion)]的长度不能超过2000(In 论文表(Paper))!值:$(pobjPaperEN.researchQuestion)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.keyword) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.keyword) > 1000) {
            throw new Error("(errid:Watl000062)字段[关键字(keyword)]的长度不能超过1000(In 论文表(Paper))!值:$(pobjPaperEN.keyword)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureSources) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.literatureSources) > 1000) {
            throw new Error("(errid:Watl000062)字段[文献来源(literatureSources)]的长度不能超过1000(In 论文表(Paper))!值:$(pobjPaperEN.literatureSources)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureLink) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.literatureLink) > 1000) {
            throw new Error("(errid:Watl000062)字段[文献链接(literatureLink)]的长度不能超过1000(In 论文表(Paper))!值:$(pobjPaperEN.literatureLink)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.uploadfileUrl) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.uploadfileUrl) > 1000) {
            throw new Error("(errid:Watl000062)字段[文件地址(uploadfileUrl)]的长度不能超过1000(In 论文表(Paper))!值:$(pobjPaperEN.uploadfileUrl)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.quoteId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.quoteId) > 8) {
            throw new Error("(errid:Watl000062)字段[引用Id(quoteId)]的长度不能超过8(In 论文表(Paper))!值:$(pobjPaperEN.quoteId)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.checker) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.checker) > 20) {
            throw new Error("(errid:Watl000062)字段[审核人(checker)]的长度不能超过20(In 论文表(Paper))!值:$(pobjPaperEN.checker)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.literatureTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[作文类型Id(literatureTypeId)]的长度不能超过2(In 论文表(Paper))!值:$(pobjPaperEN.literatureTypeId)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.paperTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[论文类型Id(paperTypeId)]的长度不能超过2(In 论文表(Paper))!值:$(pobjPaperEN.paperTypeId)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperStatusId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.paperStatusId) > 2) {
            throw new Error("(errid:Watl000062)字段[论文状态Id(paperStatusId)]的长度不能超过2(In 论文表(Paper))!值:$(pobjPaperEN.paperStatusId)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.askQuestion) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.askQuestion) > 5000) {
            throw new Error("(errid:Watl000062)字段[问题提出(askQuestion)]的长度不能超过5000(In 论文表(Paper))!值:$(pobjPaperEN.askQuestion)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.researchStatus) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.researchStatus) > 5000) {
            throw new Error("(errid:Watl000062)字段[目前研究的现状(researchStatus)]的长度不能超过5000(In 论文表(Paper))!值:$(pobjPaperEN.researchStatus)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.innovationPoints) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.innovationPoints) > 5000) {
            throw new Error("(errid:Watl000062)字段[创新点(innovationPoints)]的长度不能超过5000(In 论文表(Paper))!值:$(pobjPaperEN.innovationPoints)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.researchDesign) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.researchDesign) > 5000) {
            throw new Error("(errid:Watl000062)字段[研究设计(researchDesign)]的长度不能超过5000(In 论文表(Paper))!值:$(pobjPaperEN.researchDesign)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.dimensionDataProcess) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.dimensionDataProcess) > 5000) {
            throw new Error("(errid:Watl000062)字段[数据处理的维度(dimensionDataProcess)]的长度不能超过5000(In 论文表(Paper))!值:$(pobjPaperEN.dimensionDataProcess)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.expectedConclusion) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.expectedConclusion) > 5000) {
            throw new Error("(errid:Watl000062)字段[预期结论(expectedConclusion)]的长度不能超过5000(In 论文表(Paper))!值:$(pobjPaperEN.expectedConclusion)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.shareId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.shareId) > 2) {
            throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 论文表(Paper))!值:$(pobjPaperEN.shareId)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.createDate) > 20) {
            throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 论文表(Paper))!值:$(pobjPaperEN.createDate)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文表(Paper))!值:$(pobjPaperEN.updUser)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文表(Paper))!值:$(pobjPaperEN.updDate)(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjPaperEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文表(Paper))!值:$(pobjPaperEN.memo)(clsPaperBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperId) == false && undefined !== pobjPaperEN.paperId && clsString_js_1.tzDataType.isString(pobjPaperEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperEN.paperId)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperTitle) == false && undefined !== pobjPaperEN.paperTitle && clsString_js_1.tzDataType.isString(pobjPaperEN.paperTitle) === false) {
            throw new Error("(errid:Watl000063)字段[论文标题(paperTitle)]的值:[$(pobjPaperEN.paperTitle)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperContent) == false && undefined !== pobjPaperEN.paperContent && clsString_js_1.tzDataType.isString(pobjPaperEN.paperContent) === false) {
            throw new Error("(errid:Watl000063)字段[主题内容(paperContent)]的值:[$(pobjPaperEN.paperContent)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.periodical) == false && undefined !== pobjPaperEN.periodical && clsString_js_1.tzDataType.isString(pobjPaperEN.periodical) === false) {
            throw new Error("(errid:Watl000063)字段[期刊(periodical)]的值:[$(pobjPaperEN.periodical)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.author) == false && undefined !== pobjPaperEN.author && clsString_js_1.tzDataType.isString(pobjPaperEN.author) === false) {
            throw new Error("(errid:Watl000063)字段[作者(author)]的值:[$(pobjPaperEN.author)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.researchQuestion) == false && undefined !== pobjPaperEN.researchQuestion && clsString_js_1.tzDataType.isString(pobjPaperEN.researchQuestion) === false) {
            throw new Error("(errid:Watl000063)字段[研究问题(researchQuestion)]的值:[$(pobjPaperEN.researchQuestion)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.keyword) == false && undefined !== pobjPaperEN.keyword && clsString_js_1.tzDataType.isString(pobjPaperEN.keyword) === false) {
            throw new Error("(errid:Watl000063)字段[关键字(keyword)]的值:[$(pobjPaperEN.keyword)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureSources) == false && undefined !== pobjPaperEN.literatureSources && clsString_js_1.tzDataType.isString(pobjPaperEN.literatureSources) === false) {
            throw new Error("(errid:Watl000063)字段[文献来源(literatureSources)]的值:[$(pobjPaperEN.literatureSources)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureLink) == false && undefined !== pobjPaperEN.literatureLink && clsString_js_1.tzDataType.isString(pobjPaperEN.literatureLink) === false) {
            throw new Error("(errid:Watl000063)字段[文献链接(literatureLink)]的值:[$(pobjPaperEN.literatureLink)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.uploadfileUrl) == false && undefined !== pobjPaperEN.uploadfileUrl && clsString_js_1.tzDataType.isString(pobjPaperEN.uploadfileUrl) === false) {
            throw new Error("(errid:Watl000063)字段[文件地址(uploadfileUrl)]的值:[$(pobjPaperEN.uploadfileUrl)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.isQuotethesis && undefined !== pobjPaperEN.isQuotethesis && clsString_js_1.tzDataType.isBoolean(pobjPaperEN.isQuotethesis) === false) {
            throw new Error("(errid:Watl000063)字段[是否引用论文(isQuotethesis)]的值:[$(pobjPaperEN.isQuotethesis)], 非法，应该为布尔型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.quoteId) == false && undefined !== pobjPaperEN.quoteId && clsString_js_1.tzDataType.isString(pobjPaperEN.quoteId) === false) {
            throw new Error("(errid:Watl000063)字段[引用Id(quoteId)]的值:[$(pobjPaperEN.quoteId)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.isChecked && undefined !== pobjPaperEN.isChecked && clsString_js_1.tzDataType.isBoolean(pobjPaperEN.isChecked) === false) {
            throw new Error("(errid:Watl000063)字段[是否检查(isChecked)]的值:[$(pobjPaperEN.isChecked)], 非法，应该为布尔型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.checker) == false && undefined !== pobjPaperEN.checker && clsString_js_1.tzDataType.isString(pobjPaperEN.checker) === false) {
            throw new Error("(errid:Watl000063)字段[审核人(checker)]的值:[$(pobjPaperEN.checker)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.literatureTypeId) == false && undefined !== pobjPaperEN.literatureTypeId && clsString_js_1.tzDataType.isString(pobjPaperEN.literatureTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[作文类型Id(literatureTypeId)]的值:[$(pobjPaperEN.literatureTypeId)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.browseNumber && undefined !== pobjPaperEN.browseNumber && clsString_js_1.tzDataType.isNumber(pobjPaperEN.browseNumber) === false) {
            throw new Error("(errid:Watl000063)字段[浏览量(browseNumber)]的值:[$(pobjPaperEN.browseNumber)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.isSubmit && undefined !== pobjPaperEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjPaperEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjPaperEN.isSubmit)], 非法，应该为布尔型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.appraiseCount && undefined !== pobjPaperEN.appraiseCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000063)字段[评论数(appraiseCount)]的值:[$(pobjPaperEN.appraiseCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.attachmentCount && undefined !== pobjPaperEN.attachmentCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.attachmentCount) === false) {
            throw new Error("(errid:Watl000063)字段[附件计数(attachmentCount)]的值:[$(pobjPaperEN.attachmentCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.collectionCount && undefined !== pobjPaperEN.collectionCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.collectionCount) === false) {
            throw new Error("(errid:Watl000063)字段[收藏数量(collectionCount)]的值:[$(pobjPaperEN.collectionCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.downloadCount && undefined !== pobjPaperEN.downloadCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.downloadCount) === false) {
            throw new Error("(errid:Watl000063)字段[下载数(downloadCount)]的值:[$(pobjPaperEN.downloadCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.okCount && undefined !== pobjPaperEN.okCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.okCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjPaperEN.okCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.pcount && undefined !== pobjPaperEN.pcount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.pcount) === false) {
            throw new Error("(errid:Watl000063)字段[读写数(pcount)]的值:[$(pobjPaperEN.pcount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.score && undefined !== pobjPaperEN.score && clsString_js_1.tzDataType.isNumber(pobjPaperEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjPaperEN.score)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.stuScore && undefined !== pobjPaperEN.stuScore && clsString_js_1.tzDataType.isNumber(pobjPaperEN.stuScore) === false) {
            throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjPaperEN.stuScore)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.teaScore && undefined !== pobjPaperEN.teaScore && clsString_js_1.tzDataType.isNumber(pobjPaperEN.teaScore) === false) {
            throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjPaperEN.teaScore)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperTypeId) == false && undefined !== pobjPaperEN.paperTypeId && clsString_js_1.tzDataType.isString(pobjPaperEN.paperTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[论文类型Id(paperTypeId)]的值:[$(pobjPaperEN.paperTypeId)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperStatusId) == false && undefined !== pobjPaperEN.paperStatusId && clsString_js_1.tzDataType.isString(pobjPaperEN.paperStatusId) === false) {
            throw new Error("(errid:Watl000063)字段[论文状态Id(paperStatusId)]的值:[$(pobjPaperEN.paperStatusId)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.versionCount && undefined !== pobjPaperEN.versionCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.versionCount) === false) {
            throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjPaperEN.versionCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.isPublic && undefined !== pobjPaperEN.isPublic && clsString_js_1.tzDataType.isBoolean(pobjPaperEN.isPublic) === false) {
            throw new Error("(errid:Watl000063)字段[是否公开(isPublic)]的值:[$(pobjPaperEN.isPublic)], 非法，应该为布尔型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.askQuestion) == false && undefined !== pobjPaperEN.askQuestion && clsString_js_1.tzDataType.isString(pobjPaperEN.askQuestion) === false) {
            throw new Error("(errid:Watl000063)字段[问题提出(askQuestion)]的值:[$(pobjPaperEN.askQuestion)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.researchStatus) == false && undefined !== pobjPaperEN.researchStatus && clsString_js_1.tzDataType.isString(pobjPaperEN.researchStatus) === false) {
            throw new Error("(errid:Watl000063)字段[目前研究的现状(researchStatus)]的值:[$(pobjPaperEN.researchStatus)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.innovationPoints) == false && undefined !== pobjPaperEN.innovationPoints && clsString_js_1.tzDataType.isString(pobjPaperEN.innovationPoints) === false) {
            throw new Error("(errid:Watl000063)字段[创新点(innovationPoints)]的值:[$(pobjPaperEN.innovationPoints)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.researchDesign) == false && undefined !== pobjPaperEN.researchDesign && clsString_js_1.tzDataType.isString(pobjPaperEN.researchDesign) === false) {
            throw new Error("(errid:Watl000063)字段[研究设计(researchDesign)]的值:[$(pobjPaperEN.researchDesign)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.dimensionDataProcess) == false && undefined !== pobjPaperEN.dimensionDataProcess && clsString_js_1.tzDataType.isString(pobjPaperEN.dimensionDataProcess) === false) {
            throw new Error("(errid:Watl000063)字段[数据处理的维度(dimensionDataProcess)]的值:[$(pobjPaperEN.dimensionDataProcess)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.expectedConclusion) == false && undefined !== pobjPaperEN.expectedConclusion && clsString_js_1.tzDataType.isString(pobjPaperEN.expectedConclusion) === false) {
            throw new Error("(errid:Watl000063)字段[预期结论(expectedConclusion)]的值:[$(pobjPaperEN.expectedConclusion)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.shareId) == false && undefined !== pobjPaperEN.shareId && clsString_js_1.tzDataType.isString(pobjPaperEN.shareId) === false) {
            throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjPaperEN.shareId)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.paperQCount && undefined !== pobjPaperEN.paperQCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.paperQCount) === false) {
            throw new Error("(errid:Watl000063)字段[论文答疑数(paperQCount)]的值:[$(pobjPaperEN.paperQCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.subVCount && undefined !== pobjPaperEN.subVCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.subVCount) === false) {
            throw new Error("(errid:Watl000063)字段[论文子观点数(subVCount)]的值:[$(pobjPaperEN.subVCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.tagsCount && undefined !== pobjPaperEN.tagsCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.tagsCount) === false) {
            throw new Error("(errid:Watl000063)字段[论文标注数(tagsCount)]的值:[$(pobjPaperEN.tagsCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if (null != pobjPaperEN.teaQCount && undefined !== pobjPaperEN.teaQCount && clsString_js_1.tzDataType.isNumber(pobjPaperEN.teaQCount) === false) {
            throw new Error("(errid:Watl000063)字段[教师提问数(teaQCount)]的值:[$(pobjPaperEN.teaQCount)], 非法，应该为数值型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.createDate) == false && undefined !== pobjPaperEN.createDate && clsString_js_1.tzDataType.isString(pobjPaperEN.createDate) === false) {
            throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjPaperEN.createDate)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.updUser) == false && undefined !== pobjPaperEN.updUser && clsString_js_1.tzDataType.isString(pobjPaperEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperEN.updUser)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.updDate) == false && undefined !== pobjPaperEN.updDate && clsString_js_1.tzDataType.isString(pobjPaperEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperEN.updDate)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.memo) == false && undefined !== pobjPaperEN.memo && clsString_js_1.tzDataType.isString(pobjPaperEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperEN.memo)], 非法，应该为字符型(In 论文表(Paper))!(clsPaperBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperEN.paperId) === true
            || pobjPaperEN.paperId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[论文Id]不能为空(In 论文表)!(clsPaperBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjPaperEN.SetIsCheckProperty(true);
    }
    exports.Paper_CheckProperty4Update = Paper_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Paper_GetJSONStrByObj(pobjPaperEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjPaperEN.sf_UpdFldSetStr = pobjPaperEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjPaperEN);
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
    exports.Paper_GetJSONStrByObj = Paper_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function Paper_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrPaperObjLst = new Array();
        if (strJSON === "") {
            return arrPaperObjLst;
        }
        try {
            arrPaperObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrPaperObjLst;
        }
        return arrPaperObjLst;
    }
    exports.Paper_GetObjLstByJSONStr = Paper_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrPaperObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function Paper_GetObjLstByJSONObjLst(arrPaperObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrPaperObjLst = new Array();
        for (const objInFor of arrPaperObjLstS) {
            const obj1 = Paper_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrPaperObjLst.push(obj1);
        }
        return arrPaperObjLst;
    }
    exports.Paper_GetObjLstByJSONObjLst = Paper_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Paper_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjPaperEN = new clsPaperEN_js_1.clsPaperEN();
        if (strJSON === "") {
            return pobjPaperEN;
        }
        try {
            pobjPaperEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjPaperEN;
        }
        return pobjPaperEN;
    }
    exports.Paper_GetObjByJSONStr = Paper_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function Paper_GetCombineCondition(objPaper_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_PaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_PaperId, objPaper_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_PaperTitle, objPaper_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_Periodical) == true) {
            const strComparisonOp_Periodical = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_Periodical];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_Periodical, objPaper_Cond.periodical, strComparisonOp_Periodical);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_Author) == true) {
            const strComparisonOp_Author = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_Author];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_Author, objPaper_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_ResearchQuestion) == true) {
            const strComparisonOp_ResearchQuestion = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_ResearchQuestion];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_ResearchQuestion, objPaper_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_Keyword) == true) {
            const strComparisonOp_Keyword = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_Keyword];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_Keyword, objPaper_Cond.keyword, strComparisonOp_Keyword);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_LiteratureSources) == true) {
            const strComparisonOp_LiteratureSources = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_LiteratureSources];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_LiteratureSources, objPaper_Cond.literatureSources, strComparisonOp_LiteratureSources);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_LiteratureLink) == true) {
            const strComparisonOp_LiteratureLink = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_LiteratureLink];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_LiteratureLink, objPaper_Cond.literatureLink, strComparisonOp_LiteratureLink);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_UploadfileUrl) == true) {
            const strComparisonOp_UploadfileUrl = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_UploadfileUrl];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_UploadfileUrl, objPaper_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_IsQuotethesis) == true) {
            if (objPaper_Cond.isQuotethesis == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsPaperEN_js_1.clsPaperEN.con_IsQuotethesis);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsPaperEN_js_1.clsPaperEN.con_IsQuotethesis);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_QuoteId) == true) {
            const strComparisonOp_QuoteId = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_QuoteId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_QuoteId, objPaper_Cond.quoteId, strComparisonOp_QuoteId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_IsChecked) == true) {
            if (objPaper_Cond.isChecked == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsPaperEN_js_1.clsPaperEN.con_IsChecked);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsPaperEN_js_1.clsPaperEN.con_IsChecked);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_Checker) == true) {
            const strComparisonOp_Checker = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_Checker];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_Checker, objPaper_Cond.checker, strComparisonOp_Checker);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId) == true) {
            const strComparisonOp_LiteratureTypeId = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId, objPaper_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_BrowseNumber) == true) {
            const strComparisonOp_BrowseNumber = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_BrowseNumber];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_BrowseNumber, objPaper_Cond.browseNumber, strComparisonOp_BrowseNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_IsSubmit) == true) {
            if (objPaper_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsPaperEN_js_1.clsPaperEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsPaperEN_js_1.clsPaperEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_AppraiseCount, objPaper_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_AttachmentCount) == true) {
            const strComparisonOp_AttachmentCount = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_AttachmentCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_AttachmentCount, objPaper_Cond.attachmentCount, strComparisonOp_AttachmentCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_CollectionCount) == true) {
            const strComparisonOp_CollectionCount = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_CollectionCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_CollectionCount, objPaper_Cond.collectionCount, strComparisonOp_CollectionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_DownloadCount) == true) {
            const strComparisonOp_DownloadCount = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_DownloadCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_DownloadCount, objPaper_Cond.downloadCount, strComparisonOp_DownloadCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_OkCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_OkCount, objPaper_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_Pcount) == true) {
            const strComparisonOp_Pcount = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_Pcount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_Pcount, objPaper_Cond.pcount, strComparisonOp_Pcount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_Score) == true) {
            const strComparisonOp_Score = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_Score];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_Score, objPaper_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_StuScore];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_StuScore, objPaper_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_TeaScore];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_TeaScore, objPaper_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_PaperTypeId) == true) {
            const strComparisonOp_PaperTypeId = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_PaperTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_PaperTypeId, objPaper_Cond.paperTypeId, strComparisonOp_PaperTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_PaperStatusId) == true) {
            const strComparisonOp_PaperStatusId = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_PaperStatusId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_PaperStatusId, objPaper_Cond.paperStatusId, strComparisonOp_PaperStatusId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_VersionCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_VersionCount, objPaper_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_IsPublic) == true) {
            if (objPaper_Cond.isPublic == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsPaperEN_js_1.clsPaperEN.con_IsPublic);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsPaperEN_js_1.clsPaperEN.con_IsPublic);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_AskQuestion) == true) {
            const strComparisonOp_AskQuestion = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_AskQuestion];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_AskQuestion, objPaper_Cond.askQuestion, strComparisonOp_AskQuestion);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_ResearchStatus) == true) {
            const strComparisonOp_ResearchStatus = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_ResearchStatus];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_ResearchStatus, objPaper_Cond.researchStatus, strComparisonOp_ResearchStatus);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_InnovationPoints) == true) {
            const strComparisonOp_InnovationPoints = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_InnovationPoints];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_InnovationPoints, objPaper_Cond.innovationPoints, strComparisonOp_InnovationPoints);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_ResearchDesign) == true) {
            const strComparisonOp_ResearchDesign = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_ResearchDesign];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_ResearchDesign, objPaper_Cond.researchDesign, strComparisonOp_ResearchDesign);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_DimensionDataProcess) == true) {
            const strComparisonOp_DimensionDataProcess = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_DimensionDataProcess];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_DimensionDataProcess, objPaper_Cond.dimensionDataProcess, strComparisonOp_DimensionDataProcess);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_ExpectedConclusion) == true) {
            const strComparisonOp_ExpectedConclusion = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_ExpectedConclusion];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_ExpectedConclusion, objPaper_Cond.expectedConclusion, strComparisonOp_ExpectedConclusion);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_ShareId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_ShareId, objPaper_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_PaperQCount) == true) {
            const strComparisonOp_PaperQCount = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_PaperQCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_PaperQCount, objPaper_Cond.paperQCount, strComparisonOp_PaperQCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_SubVCount) == true) {
            const strComparisonOp_SubVCount = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_SubVCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_SubVCount, objPaper_Cond.subVCount, strComparisonOp_SubVCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_TagsCount) == true) {
            const strComparisonOp_TagsCount = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_TagsCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_TagsCount, objPaper_Cond.tagsCount, strComparisonOp_TagsCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_TeaQCount) == true) {
            const strComparisonOp_TeaQCount = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_TeaQCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperEN_js_1.clsPaperEN.con_TeaQCount, objPaper_Cond.teaQCount, strComparisonOp_TeaQCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_CreateDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_CreateDate, objPaper_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_UpdUser, objPaper_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_UpdDate, objPaper_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaper_Cond.dicFldComparisonOp, clsPaperEN_js_1.clsPaperEN.con_Memo) == true) {
            const strComparisonOp_Memo = objPaper_Cond.dicFldComparisonOp[clsPaperEN_js_1.clsPaperEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperEN_js_1.clsPaperEN.con_Memo, objPaper_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.Paper_GetCombineCondition = Paper_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--Paper(论文表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strPaperTitle: 论文标题(要求唯一的字段)
    * @param strAuthor: 作者(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function Paper_GetUniCondStr_PaperTitle_Author(objPaperEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperTitle = '{0}'", objPaperEN.paperTitle);
        strWhereCond += (0, clsString_js_2.Format)(" and Author = '{0}'", objPaperEN.author);
        return strWhereCond;
    }
    exports.Paper_GetUniCondStr_PaperTitle_Author = Paper_GetUniCondStr_PaperTitle_Author;
    /**
    *获取唯一性条件串(Uniqueness)--Paper(论文表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strPaperTitle: 论文标题(要求唯一的字段)
    * @param strAuthor: 作者(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function Paper_GetUniCondStr4Update_PaperTitle_Author(objPaperEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperId <> '{0}'", objPaperEN.paperId);
        strWhereCond += (0, clsString_js_2.Format)(" and PaperTitle = '{0}'", objPaperEN.paperTitle);
        strWhereCond += (0, clsString_js_2.Format)(" and Author = '{0}'", objPaperEN.author);
        return strWhereCond;
    }
    exports.Paper_GetUniCondStr4Update_PaperTitle_Author = Paper_GetUniCondStr4Update_PaperTitle_Author;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objPaperENS:源对象
     * @param objPaperENT:目标对象
    */
    function Paper_CopyObjTo(objPaperENS, objPaperENT) {
        objPaperENT.paperId = objPaperENS.paperId; //论文Id
        objPaperENT.paperTitle = objPaperENS.paperTitle; //论文标题
        objPaperENT.paperContent = objPaperENS.paperContent; //主题内容
        objPaperENT.periodical = objPaperENS.periodical; //期刊
        objPaperENT.author = objPaperENS.author; //作者
        objPaperENT.researchQuestion = objPaperENS.researchQuestion; //研究问题
        objPaperENT.keyword = objPaperENS.keyword; //关键字
        objPaperENT.literatureSources = objPaperENS.literatureSources; //文献来源
        objPaperENT.literatureLink = objPaperENS.literatureLink; //文献链接
        objPaperENT.uploadfileUrl = objPaperENS.uploadfileUrl; //文件地址
        objPaperENT.isQuotethesis = objPaperENS.isQuotethesis; //是否引用论文
        objPaperENT.quoteId = objPaperENS.quoteId; //引用Id
        objPaperENT.isChecked = objPaperENS.isChecked; //是否检查
        objPaperENT.checker = objPaperENS.checker; //审核人
        objPaperENT.literatureTypeId = objPaperENS.literatureTypeId; //作文类型Id
        objPaperENT.browseNumber = objPaperENS.browseNumber; //浏览量
        objPaperENT.isSubmit = objPaperENS.isSubmit; //是否提交
        objPaperENT.appraiseCount = objPaperENS.appraiseCount; //评论数
        objPaperENT.attachmentCount = objPaperENS.attachmentCount; //附件计数
        objPaperENT.collectionCount = objPaperENS.collectionCount; //收藏数量
        objPaperENT.downloadCount = objPaperENS.downloadCount; //下载数
        objPaperENT.okCount = objPaperENS.okCount; //点赞统计
        objPaperENT.pcount = objPaperENS.pcount; //读写数
        objPaperENT.score = objPaperENS.score; //评分
        objPaperENT.stuScore = objPaperENS.stuScore; //学生平均分
        objPaperENT.teaScore = objPaperENS.teaScore; //教师评分
        objPaperENT.paperTypeId = objPaperENS.paperTypeId; //论文类型Id
        objPaperENT.paperStatusId = objPaperENS.paperStatusId; //论文状态Id
        objPaperENT.versionCount = objPaperENS.versionCount; //版本统计
        objPaperENT.isPublic = objPaperENS.isPublic; //是否公开
        objPaperENT.askQuestion = objPaperENS.askQuestion; //问题提出
        objPaperENT.researchStatus = objPaperENS.researchStatus; //目前研究的现状
        objPaperENT.innovationPoints = objPaperENS.innovationPoints; //创新点
        objPaperENT.researchDesign = objPaperENS.researchDesign; //研究设计
        objPaperENT.dimensionDataProcess = objPaperENS.dimensionDataProcess; //数据处理的维度
        objPaperENT.expectedConclusion = objPaperENS.expectedConclusion; //预期结论
        objPaperENT.shareId = objPaperENS.shareId; //分享Id
        objPaperENT.paperQCount = objPaperENS.paperQCount; //论文答疑数
        objPaperENT.subVCount = objPaperENS.subVCount; //论文子观点数
        objPaperENT.tagsCount = objPaperENS.tagsCount; //论文标注数
        objPaperENT.teaQCount = objPaperENS.teaQCount; //教师提问数
        objPaperENT.createDate = objPaperENS.createDate; //建立日期
        objPaperENT.updUser = objPaperENS.updUser; //修改人
        objPaperENT.updDate = objPaperENS.updDate; //修改日期
        objPaperENT.memo = objPaperENS.memo; //备注
        objPaperENT.sf_UpdFldSetStr = objPaperENS.updFldString; //sf_UpdFldSetStr
    }
    exports.Paper_CopyObjTo = Paper_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objPaperENS:源对象
     * @param objPaperENT:目标对象
    */
    function Paper_GetObjFromJsonObj(objPaperENS) {
        const objPaperENT = new clsPaperEN_js_1.clsPaperEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperENT, objPaperENS);
        return objPaperENT;
    }
    exports.Paper_GetObjFromJsonObj = Paper_GetObjFromJsonObj;
});
