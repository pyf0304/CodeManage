/**
* 类名:clsvPaperWApi
* 表名:vPaper(01120549)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:37
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsvPaperEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaper_GetObjFromJsonObj = exports.vPaper_CopyObjTo = exports.vPaper_GetCombineCondition = exports.vPaper_GetObjByJSONStr = exports.vPaper_GetObjLstByJSONObjLst = exports.vPaper_GetObjLstByJSONStr = exports.vPaper_GetJSONStrByObj = exports.vPaper_ReFreshThisCache = exports.vPaper_GetWebApiUrl = exports.vPaper_GetRecCountByCond_Cache = exports.vPaper_GetRecCountByCondAsync = exports.vPaper_IsExistAsync = exports.vPaper_IsExist_Cache = exports.vPaper_IsExist = exports.vPaper_IsExistRecordAsync = exports.vPaper_IsExistRecord_Cache = exports.vPaper_GetObjLstByPagerAsync = exports.vPaper_GetObjLstByPager_Cache = exports.vPaper_GetObjLstByRange = exports.vPaper_GetObjLstByRangeAsync = exports.vPaper_GetTopObjLstAsync = exports.vPaper_GetObjLstByPaperIdLst_Cache = exports.vPaper_GetObjLstByPaperIdLstAsync = exports.vPaper_GetSubObjLst_Cache = exports.vPaper_GetObjLst_PureCache = exports.vPaper_GetObjLst_Cache = exports.vPaper_GetObjLst_sessionStorage_PureCache = exports.vPaper_GetObjLst_sessionStorage = exports.vPaper_GetObjLstAsync = exports.vPaper_GetObjLst_localStorage_PureCache = exports.vPaper_GetObjLst_localStorage = exports.vPaper_GetObjLst_ClientCache = exports.vPaper_GetFirstObjAsync = exports.vPaper_GetFirstID = exports.vPaper_GetFirstIDAsync = exports.vPaper_FilterFunByKey = exports.vPaper_SortFunByKey = exports.vPaper_SortFun_Defa_2Fld = exports.vPaper_SortFun_Defa = exports.vPaper_func = exports.vPaper_GetObjByPaperId_localStorage = exports.vPaper_GetObjByPaperId_Cache = exports.vPaper_GetObjByPaperIdAsync = exports.vPaper_ConstructorName = exports.vPaper_Controller = void 0;
    /**
     * v论文表(vPaper)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvPaperEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vPaper_Controller = "vPaperApi";
    exports.vPaper_ConstructorName = "vPaper";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strPaperId:关键字
    * @returns 对象
    **/
    async function vPaper_GetObjByPaperIdAsync(strPaperId) {
        const strThisFuncName = "GetObjByPaperIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strPaperId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strPaperId]不能为空！(In GetObjByPaperIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strPaperId]的长度:[{0}]不正确！", strPaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvPaper = vPaper_GetObjFromJsonObj(returnObj);
                return objvPaper;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_GetObjByPaperIdAsync = vPaper_GetObjByPaperIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strPaperId:所给的关键字
     * @returns 对象
    */
    async function vPaper_GetObjByPaperId_Cache(strPaperId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPaperId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strPaperId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strPaperId]不能为空！(In GetObjByPaperId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strPaperId]的长度:[{0}]不正确！", strPaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
        try {
            const arrvPaper_Sel = arrvPaperObjLst_Cache.filter(x => x.paperId == strPaperId);
            let objvPaper;
            if (arrvPaper_Sel.length > 0) {
                objvPaper = arrvPaper_Sel[0];
                return objvPaper;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvPaper = await vPaper_GetObjByPaperIdAsync(strPaperId);
                    if (objvPaper != null) {
                        vPaper_ReFreshThisCache();
                        return objvPaper;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperId, exports.vPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vPaper_GetObjByPaperId_Cache = vPaper_GetObjByPaperId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strPaperId:所给的关键字
     * @returns 对象
    */
    async function vPaper_GetObjByPaperId_localStorage(strPaperId) {
        const strThisFuncName = "GetObjByPaperId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strPaperId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strPaperId]不能为空！(In GetObjByPaperId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strPaperId]的长度:[{0}]不正确！", strPaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperEN_js_1.clsvPaperEN._CurrTabName, strPaperId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvPaper_Cache = JSON.parse(strTempObj);
            return objvPaper_Cache;
        }
        try {
            const objvPaper = await vPaper_GetObjByPaperIdAsync(strPaperId);
            if (objvPaper != null) {
                localStorage.setItem(strKey, JSON.stringify(objvPaper));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvPaper;
            }
            return objvPaper;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperId, exports.vPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vPaper_GetObjByPaperId_localStorage = vPaper_GetObjByPaperId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vPaper_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvPaperEN_js_1.clsvPaperEN.con_PaperId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvPaperEN_js_1.clsvPaperEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvPaperEN_js_1.clsvPaperEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strPaperId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvPaper = await vPaper_GetObjByPaperId_Cache(strPaperId);
        if (objvPaper == null)
            return "";
        return objvPaper.GetFldValue(strOutFldName).toString();
    }
    exports.vPaper_func = vPaper_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaper_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperId.localeCompare(b.paperId);
    }
    exports.vPaper_SortFun_Defa = vPaper_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaper_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperTitle == b.paperTitle)
            return a.paperContent.localeCompare(b.paperContent);
        else
            return a.paperTitle.localeCompare(b.paperTitle);
    }
    exports.vPaper_SortFun_Defa_2Fld = vPaper_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaper_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperContent:
                    return (a, b) => {
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_Periodical:
                    return (a, b) => {
                        return a.periodical.localeCompare(b.periodical);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_Author:
                    return (a, b) => {
                        return a.author.localeCompare(b.author);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_ResearchQuestion:
                    return (a, b) => {
                        return a.researchQuestion.localeCompare(b.researchQuestion);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_Keyword:
                    return (a, b) => {
                        return a.keyword.localeCompare(b.keyword);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_LiteratureSources:
                    return (a, b) => {
                        return a.literatureSources.localeCompare(b.literatureSources);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_LiteratureLink:
                    return (a, b) => {
                        return a.literatureLink.localeCompare(b.literatureLink);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_UploadfileUrl:
                    return (a, b) => {
                        return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_IsQuotethesis:
                    return (a, b) => {
                        if (a.isQuotethesis == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_QuoteId:
                    return (a, b) => {
                        return a.quoteId.localeCompare(b.quoteId);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_IsChecked:
                    return (a, b) => {
                        if (a.isChecked == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_Checker:
                    return (a, b) => {
                        return a.checker.localeCompare(b.checker);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId:
                    return (a, b) => {
                        return a.literatureTypeId.localeCompare(b.literatureTypeId);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeName:
                    return (a, b) => {
                        return a.literatureTypeName.localeCompare(b.literatureTypeName);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_BrowseNumber:
                    return (a, b) => {
                        return a.browseNumber - b.browseNumber;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_AttachmentCount:
                    return (a, b) => {
                        return a.attachmentCount - b.attachmentCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_CollectionCount:
                    return (a, b) => {
                        return a.collectionCount - b.collectionCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_DownloadCount:
                    return (a, b) => {
                        return a.downloadCount - b.downloadCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_Pcount:
                    return (a, b) => {
                        return a.pcount - b.pcount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeId:
                    return (a, b) => {
                        return a.paperTypeId.localeCompare(b.paperTypeId);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeName:
                    return (a, b) => {
                        return a.paperTypeName.localeCompare(b.paperTypeName);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperStatusId:
                    return (a, b) => {
                        return a.paperStatusId.localeCompare(b.paperStatusId);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperStatusName:
                    return (a, b) => {
                        return a.paperStatusName.localeCompare(b.paperStatusName);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_IsPublic:
                    return (a, b) => {
                        if (a.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_AskQuestion:
                    return (a, b) => {
                        return a.askQuestion.localeCompare(b.askQuestion);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_ResearchStatus:
                    return (a, b) => {
                        return a.researchStatus.localeCompare(b.researchStatus);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_InnovationPoints:
                    return (a, b) => {
                        return a.innovationPoints.localeCompare(b.innovationPoints);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_ResearchDesign:
                    return (a, b) => {
                        return a.researchDesign.localeCompare(b.researchDesign);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_DimensionDataProcess:
                    return (a, b) => {
                        return a.dimensionDataProcess.localeCompare(b.dimensionDataProcess);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_ExpectedConclusion:
                    return (a, b) => {
                        return a.expectedConclusion.localeCompare(b.expectedConclusion);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperQCount:
                    return (a, b) => {
                        return a.paperQCount - b.paperQCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_SubVCount:
                    return (a, b) => {
                        return a.subVCount - b.subVCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_TagsCount:
                    return (a, b) => {
                        return a.tagsCount - b.tagsCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_TeaQCount:
                    return (a, b) => {
                        return a.teaQCount - b.teaQCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_CreateDate:
                    return (a, b) => {
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_IsGSuser:
                    return (a, b) => {
                        if (a.isGSuser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaper]中不存在！(in ${exports.vPaper_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperContent:
                    return (a, b) => {
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_Periodical:
                    return (a, b) => {
                        return b.periodical.localeCompare(a.periodical);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_Author:
                    return (a, b) => {
                        return b.author.localeCompare(a.author);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_ResearchQuestion:
                    return (a, b) => {
                        return b.researchQuestion.localeCompare(a.researchQuestion);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_Keyword:
                    return (a, b) => {
                        return b.keyword.localeCompare(a.keyword);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_LiteratureSources:
                    return (a, b) => {
                        return b.literatureSources.localeCompare(a.literatureSources);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_LiteratureLink:
                    return (a, b) => {
                        return b.literatureLink.localeCompare(a.literatureLink);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_UploadfileUrl:
                    return (a, b) => {
                        return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_IsQuotethesis:
                    return (a, b) => {
                        if (b.isQuotethesis == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_QuoteId:
                    return (a, b) => {
                        return b.quoteId.localeCompare(a.quoteId);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_IsChecked:
                    return (a, b) => {
                        if (b.isChecked == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_Checker:
                    return (a, b) => {
                        return b.checker.localeCompare(a.checker);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId:
                    return (a, b) => {
                        return b.literatureTypeId.localeCompare(a.literatureTypeId);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeName:
                    return (a, b) => {
                        return b.literatureTypeName.localeCompare(a.literatureTypeName);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_BrowseNumber:
                    return (a, b) => {
                        return b.browseNumber - a.browseNumber;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_AttachmentCount:
                    return (a, b) => {
                        return b.attachmentCount - a.attachmentCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_CollectionCount:
                    return (a, b) => {
                        return b.collectionCount - a.collectionCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_DownloadCount:
                    return (a, b) => {
                        return b.downloadCount - a.downloadCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_Pcount:
                    return (a, b) => {
                        return b.pcount - a.pcount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeId:
                    return (a, b) => {
                        return b.paperTypeId.localeCompare(a.paperTypeId);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeName:
                    return (a, b) => {
                        return b.paperTypeName.localeCompare(a.paperTypeName);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperStatusId:
                    return (a, b) => {
                        return b.paperStatusId.localeCompare(a.paperStatusId);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperStatusName:
                    return (a, b) => {
                        return b.paperStatusName.localeCompare(a.paperStatusName);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_IsPublic:
                    return (a, b) => {
                        if (b.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_AskQuestion:
                    return (a, b) => {
                        return b.askQuestion.localeCompare(a.askQuestion);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_ResearchStatus:
                    return (a, b) => {
                        return b.researchStatus.localeCompare(a.researchStatus);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_InnovationPoints:
                    return (a, b) => {
                        return b.innovationPoints.localeCompare(a.innovationPoints);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_ResearchDesign:
                    return (a, b) => {
                        return b.researchDesign.localeCompare(a.researchDesign);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_DimensionDataProcess:
                    return (a, b) => {
                        return b.dimensionDataProcess.localeCompare(a.dimensionDataProcess);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_ExpectedConclusion:
                    return (a, b) => {
                        return b.expectedConclusion.localeCompare(a.expectedConclusion);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_PaperQCount:
                    return (a, b) => {
                        return b.paperQCount - a.paperQCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_SubVCount:
                    return (a, b) => {
                        return b.subVCount - a.subVCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_TagsCount:
                    return (a, b) => {
                        return b.tagsCount - a.tagsCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_TeaQCount:
                    return (a, b) => {
                        return b.teaQCount - a.teaQCount;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_CreateDate:
                    return (a, b) => {
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_IsGSuser:
                    return (a, b) => {
                        if (b.isGSuser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvPaperEN_js_1.clsvPaperEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaper]中不存在！(in ${exports.vPaper_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vPaper_SortFunByKey = vPaper_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaper_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvPaperEN_js_1.clsvPaperEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_Periodical:
                return (obj) => {
                    return obj.periodical === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_ResearchQuestion:
                return (obj) => {
                    return obj.researchQuestion === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_Keyword:
                return (obj) => {
                    return obj.keyword === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_LiteratureSources:
                return (obj) => {
                    return obj.literatureSources === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_LiteratureLink:
                return (obj) => {
                    return obj.literatureLink === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_UploadfileUrl:
                return (obj) => {
                    return obj.uploadfileUrl === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_IsQuotethesis:
                return (obj) => {
                    return obj.isQuotethesis === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_QuoteId:
                return (obj) => {
                    return obj.quoteId === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_IsChecked:
                return (obj) => {
                    return obj.isChecked === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_Checker:
                return (obj) => {
                    return obj.checker === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId:
                return (obj) => {
                    return obj.literatureTypeId === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeName:
                return (obj) => {
                    return obj.literatureTypeName === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_BrowseNumber:
                return (obj) => {
                    return obj.browseNumber === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_AttachmentCount:
                return (obj) => {
                    return obj.attachmentCount === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_CollectionCount:
                return (obj) => {
                    return obj.collectionCount === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_DownloadCount:
                return (obj) => {
                    return obj.downloadCount === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_Pcount:
                return (obj) => {
                    return obj.pcount === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeId:
                return (obj) => {
                    return obj.paperTypeId === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeName:
                return (obj) => {
                    return obj.paperTypeName === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_PaperStatusId:
                return (obj) => {
                    return obj.paperStatusId === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_PaperStatusName:
                return (obj) => {
                    return obj.paperStatusName === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_IsPublic:
                return (obj) => {
                    return obj.isPublic === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_AskQuestion:
                return (obj) => {
                    return obj.askQuestion === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_ResearchStatus:
                return (obj) => {
                    return obj.researchStatus === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_InnovationPoints:
                return (obj) => {
                    return obj.innovationPoints === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_ResearchDesign:
                return (obj) => {
                    return obj.researchDesign === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_DimensionDataProcess:
                return (obj) => {
                    return obj.dimensionDataProcess === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_ExpectedConclusion:
                return (obj) => {
                    return obj.expectedConclusion === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_PaperQCount:
                return (obj) => {
                    return obj.paperQCount === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_SubVCount:
                return (obj) => {
                    return obj.subVCount === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_TagsCount:
                return (obj) => {
                    return obj.tagsCount === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_TeaQCount:
                return (obj) => {
                    return obj.teaQCount === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_IsGSuser:
                return (obj) => {
                    return obj.isGSuser === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvPaperEN_js_1.clsvPaperEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPaper]中不存在！(in ${exports.vPaper_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vPaper_FilterFunByKey = vPaper_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vPaper_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_GetFirstIDAsync = vPaper_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vPaper_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_GetFirstID = vPaper_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vPaper_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvPaper = vPaper_GetObjFromJsonObj(returnObj);
                return objvPaper;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_GetFirstObjAsync = vPaper_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaper_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvPaperEN_js_1.clsvPaperEN._CurrTabName;
        clsvPaperEN_js_1.clsvPaperEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvPaperEN_js_1.clsvPaperEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperEN_js_1.clsvPaperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperEN_js_1.clsvPaperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvPaperExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvPaperObjLst_T = vPaper_GetObjLstByJSONObjLst(arrvPaperExObjLst_Cache);
            return arrvPaperObjLst_T;
        }
        try {
            const arrvPaperExObjLst = await vPaper_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvPaperExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperExObjLst.length);
            console.log(strInfo);
            return arrvPaperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaper_GetObjLst_ClientCache = vPaper_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaper_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvPaperEN_js_1.clsvPaperEN._CurrTabName;
        clsvPaperEN_js_1.clsvPaperEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvPaperEN_js_1.clsvPaperEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperEN_js_1.clsvPaperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperEN_js_1.clsvPaperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvPaperExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvPaperObjLst_T = vPaper_GetObjLstByJSONObjLst(arrvPaperExObjLst_Cache);
            return arrvPaperObjLst_T;
        }
        try {
            const arrvPaperExObjLst = await vPaper_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvPaperExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperExObjLst.length);
            console.log(strInfo);
            return arrvPaperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaper_GetObjLst_localStorage = vPaper_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaper_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvPaperEN_js_1.clsvPaperEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperObjLst_Cache;
        }
        else
            return null;
    }
    exports.vPaper_GetObjLst_localStorage_PureCache = vPaper_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vPaper_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_GetObjLstAsync = vPaper_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaper_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvPaperEN_js_1.clsvPaperEN._CurrTabName;
        clsvPaperEN_js_1.clsvPaperEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvPaperEN_js_1.clsvPaperEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperEN_js_1.clsvPaperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperEN_js_1.clsvPaperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvPaperExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvPaperObjLst_T = vPaper_GetObjLstByJSONObjLst(arrvPaperExObjLst_Cache);
            return arrvPaperObjLst_T;
        }
        try {
            const arrvPaperExObjLst = await vPaper_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvPaperExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperExObjLst.length);
            console.log(strInfo);
            return arrvPaperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaper_GetObjLst_sessionStorage = vPaper_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaper_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvPaperEN_js_1.clsvPaperEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperObjLst_Cache;
        }
        else
            return null;
    }
    exports.vPaper_GetObjLst_sessionStorage_PureCache = vPaper_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaper_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvPaperObjLst_Cache;
        switch (clsvPaperEN_js_1.clsvPaperEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperObjLst_Cache = await vPaper_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvPaperObjLst_Cache = await vPaper_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvPaperObjLst_Cache = await vPaper_GetObjLst_ClientCache();
                break;
            default:
                arrvPaperObjLst_Cache = await vPaper_GetObjLst_ClientCache();
                break;
        }
        const arrvPaperObjLst = vPaper_GetObjLstByJSONObjLst(arrvPaperObjLst_Cache);
        return arrvPaperObjLst_Cache;
    }
    exports.vPaper_GetObjLst_Cache = vPaper_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaper_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvPaperObjLst_Cache;
        switch (clsvPaperEN_js_1.clsvPaperEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperObjLst_Cache = await vPaper_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvPaperObjLst_Cache = await vPaper_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvPaperObjLst_Cache = null;
                break;
            default:
                arrvPaperObjLst_Cache = null;
                break;
        }
        return arrvPaperObjLst_Cache;
    }
    exports.vPaper_GetObjLst_PureCache = vPaper_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrPaperId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vPaper_GetSubObjLst_Cache(objvPaper_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
        let arrvPaper_Sel = arrvPaperObjLst_Cache;
        if (objvPaper_Cond.sf_FldComparisonOp == null || objvPaper_Cond.sf_FldComparisonOp == "")
            return arrvPaper_Sel;
        const dicFldComparisonOp = JSON.parse(objvPaper_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaper_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvPaper_Cond), exports.vPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaper_GetSubObjLst_Cache = vPaper_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperId:关键字列表
    * @returns 对象列表
    **/
    async function vPaper_GetObjLstByPaperIdLstAsync(arrPaperId) {
        const strThisFuncName = "GetObjLstByPaperIdLstAsync";
        const strAction = "GetObjLstByPaperIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_GetObjLstByPaperIdLstAsync = vPaper_GetObjLstByPaperIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrPaperIdLst:关键字列表
     * @returns 对象列表
    */
    async function vPaper_GetObjLstByPaperIdLst_Cache(arrPaperIdLst) {
        const strThisFuncName = "GetObjLstByPaperIdLst_Cache";
        try {
            const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
            const arrvPaper_Sel = arrvPaperObjLst_Cache.filter(x => arrPaperIdLst.indexOf(x.paperId) > -1);
            return arrvPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperIdLst.join(","), exports.vPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaper_GetObjLstByPaperIdLst_Cache = vPaper_GetObjLstByPaperIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vPaper_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_GetTopObjLstAsync = vPaper_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaper_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_GetObjLstByRangeAsync = vPaper_GetObjLstByRangeAsync;
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
    async function vPaper_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_GetObjLstByRange = vPaper_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaper_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
        if (arrvPaperObjLst_Cache.length == 0)
            return arrvPaperObjLst_Cache;
        let arrvPaper_Sel = arrvPaperObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvPaper_Cond = new clsvPaperEN_js_1.clsvPaperEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaper_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaper_Sel.length == 0)
                return arrvPaper_Sel;
            let intStart = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
            if (intStart <= 0)
                intStart = 0;
            const intEnd = intStart + objPagerPara.pageSize;
            if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
                const sstrSplit = objPagerPara.orderBy.split(" ");
                let strSortType = "asc";
                const strSortFld = sstrSplit[0];
                if (sstrSplit.length > 1)
                    strSortType = sstrSplit[1];
                arrvPaper_Sel = arrvPaper_Sel.sort(vPaper_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaper_Sel = arrvPaper_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaper_Sel = arrvPaper_Sel.slice(intStart, intEnd);
            return arrvPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaper_GetObjLstByPager_Cache = vPaper_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaper_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_GetObjLstByPagerAsync = vPaper_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrPaperId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vPaper_IsExistRecord_Cache(objvPaper_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
        if (arrvPaperObjLst_Cache == null)
            return false;
        let arrvPaper_Sel = arrvPaperObjLst_Cache;
        if (objvPaper_Cond.sf_FldComparisonOp == null || objvPaper_Cond.sf_FldComparisonOp == "")
            return arrvPaper_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvPaper_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaper_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaper_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvPaper_Cond), exports.vPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vPaper_IsExistRecord_Cache = vPaper_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vPaper_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_IsExistRecordAsync = vPaper_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strPaperId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vPaper_IsExist(strPaperId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_IsExist = vPaper_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strPaperId:所给的关键字
     * @returns 对象
    */
    async function vPaper_IsExist_Cache(strPaperId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
        if (arrvPaperObjLst_Cache == null)
            return false;
        try {
            const arrvPaper_Sel = arrvPaperObjLst_Cache.filter(x => x.paperId == strPaperId);
            if (arrvPaper_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPaperId, exports.vPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vPaper_IsExist_Cache = vPaper_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strPaperId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vPaper_IsExistAsync(strPaperId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_IsExistAsync = vPaper_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vPaper_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaper_GetRecCountByCondAsync = vPaper_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvPaper_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vPaper_GetRecCountByCond_Cache(objvPaper_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
        if (arrvPaperObjLst_Cache == null)
            return 0;
        let arrvPaper_Sel = arrvPaperObjLst_Cache;
        if (objvPaper_Cond.sf_FldComparisonOp == null || objvPaper_Cond.sf_FldComparisonOp == "")
            return arrvPaper_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvPaper_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaper_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvPaper_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvPaper_Cond), exports.vPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vPaper_GetRecCountByCond_Cache = vPaper_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vPaper_GetWebApiUrl(strController, strAction) {
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
    exports.vPaper_GetWebApiUrl = vPaper_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vPaper_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvPaperEN_js_1.clsvPaperEN._CurrTabName;
            switch (clsvPaperEN_js_1.clsvPaperEN.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_2.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_2.CacheHelper.Remove(strKey);
                    break;
            }
            const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_1.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.vPaper_ReFreshThisCache = vPaper_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaper_GetJSONStrByObj(pobjvPaperEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvPaperEN);
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
    exports.vPaper_GetJSONStrByObj = vPaper_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vPaper_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvPaperObjLst = new Array();
        if (strJSON === "") {
            return arrvPaperObjLst;
        }
        try {
            arrvPaperObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvPaperObjLst;
        }
        return arrvPaperObjLst;
    }
    exports.vPaper_GetObjLstByJSONStr = vPaper_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvPaperObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vPaper_GetObjLstByJSONObjLst(arrvPaperObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvPaperObjLst = new Array();
        for (const objInFor of arrvPaperObjLstS) {
            const obj1 = vPaper_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvPaperObjLst.push(obj1);
        }
        return arrvPaperObjLst;
    }
    exports.vPaper_GetObjLstByJSONObjLst = vPaper_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaper_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvPaperEN = new clsvPaperEN_js_1.clsvPaperEN();
        if (strJSON === "") {
            return pobjvPaperEN;
        }
        try {
            pobjvPaperEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvPaperEN;
        }
        return pobjvPaperEN;
    }
    exports.vPaper_GetObjByJSONStr = vPaper_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vPaper_GetCombineCondition(objvPaper_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_PaperId, objvPaper_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle, objvPaper_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_Periodical) == true) {
            const strComparisonOp_Periodical = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_Periodical];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_Periodical, objvPaper_Cond.periodical, strComparisonOp_Periodical);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_Author) == true) {
            const strComparisonOp_Author = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_Author, objvPaper_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_ResearchQuestion) == true) {
            const strComparisonOp_ResearchQuestion = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_ResearchQuestion];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_ResearchQuestion, objvPaper_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_Keyword) == true) {
            const strComparisonOp_Keyword = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_Keyword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_Keyword, objvPaper_Cond.keyword, strComparisonOp_Keyword);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_LiteratureSources) == true) {
            const strComparisonOp_LiteratureSources = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_LiteratureSources];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_LiteratureSources, objvPaper_Cond.literatureSources, strComparisonOp_LiteratureSources);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_LiteratureLink) == true) {
            const strComparisonOp_LiteratureLink = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_LiteratureLink];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_LiteratureLink, objvPaper_Cond.literatureLink, strComparisonOp_LiteratureLink);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_UploadfileUrl) == true) {
            const strComparisonOp_UploadfileUrl = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_UploadfileUrl];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_UploadfileUrl, objvPaper_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_IsQuotethesis) == true) {
            if (objvPaper_Cond.isQuotethesis == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvPaperEN_js_1.clsvPaperEN.con_IsQuotethesis);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvPaperEN_js_1.clsvPaperEN.con_IsQuotethesis);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_QuoteId) == true) {
            const strComparisonOp_QuoteId = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_QuoteId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_QuoteId, objvPaper_Cond.quoteId, strComparisonOp_QuoteId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_IsChecked) == true) {
            if (objvPaper_Cond.isChecked == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvPaperEN_js_1.clsvPaperEN.con_IsChecked);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvPaperEN_js_1.clsvPaperEN.con_IsChecked);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_Checker) == true) {
            const strComparisonOp_Checker = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_Checker];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_Checker, objvPaper_Cond.checker, strComparisonOp_Checker);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId) == true) {
            const strComparisonOp_LiteratureTypeId = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId, objvPaper_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeName) == true) {
            const strComparisonOp_LiteratureTypeName = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeName, objvPaper_Cond.literatureTypeName, strComparisonOp_LiteratureTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_BrowseNumber) == true) {
            const strComparisonOp_BrowseNumber = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_BrowseNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_BrowseNumber, objvPaper_Cond.browseNumber, strComparisonOp_BrowseNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_IsSubmit) == true) {
            if (objvPaper_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvPaperEN_js_1.clsvPaperEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvPaperEN_js_1.clsvPaperEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_AppraiseCount, objvPaper_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_AttachmentCount) == true) {
            const strComparisonOp_AttachmentCount = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_AttachmentCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_AttachmentCount, objvPaper_Cond.attachmentCount, strComparisonOp_AttachmentCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_CollectionCount) == true) {
            const strComparisonOp_CollectionCount = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_CollectionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_CollectionCount, objvPaper_Cond.collectionCount, strComparisonOp_CollectionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_DownloadCount) == true) {
            const strComparisonOp_DownloadCount = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_DownloadCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_DownloadCount, objvPaper_Cond.downloadCount, strComparisonOp_DownloadCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_OkCount, objvPaper_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_Pcount) == true) {
            const strComparisonOp_Pcount = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_Pcount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_Pcount, objvPaper_Cond.pcount, strComparisonOp_Pcount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_score) == true) {
            const strComparisonOp_score = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_score, objvPaper_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_StuScore, objvPaper_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_TeaScore, objvPaper_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeId) == true) {
            const strComparisonOp_PaperTypeId = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeId, objvPaper_Cond.paperTypeId, strComparisonOp_PaperTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeName) == true) {
            const strComparisonOp_PaperTypeName = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeName, objvPaper_Cond.paperTypeName, strComparisonOp_PaperTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_PaperStatusId) == true) {
            const strComparisonOp_PaperStatusId = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_PaperStatusId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_PaperStatusId, objvPaper_Cond.paperStatusId, strComparisonOp_PaperStatusId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_PaperStatusName) == true) {
            const strComparisonOp_PaperStatusName = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_PaperStatusName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_PaperStatusName, objvPaper_Cond.paperStatusName, strComparisonOp_PaperStatusName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_VersionCount, objvPaper_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_IsPublic) == true) {
            if (objvPaper_Cond.isPublic == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvPaperEN_js_1.clsvPaperEN.con_IsPublic);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvPaperEN_js_1.clsvPaperEN.con_IsPublic);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_AskQuestion) == true) {
            const strComparisonOp_AskQuestion = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_AskQuestion];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_AskQuestion, objvPaper_Cond.askQuestion, strComparisonOp_AskQuestion);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_ResearchStatus) == true) {
            const strComparisonOp_ResearchStatus = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_ResearchStatus];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_ResearchStatus, objvPaper_Cond.researchStatus, strComparisonOp_ResearchStatus);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_InnovationPoints) == true) {
            const strComparisonOp_InnovationPoints = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_InnovationPoints];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_InnovationPoints, objvPaper_Cond.innovationPoints, strComparisonOp_InnovationPoints);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_ResearchDesign) == true) {
            const strComparisonOp_ResearchDesign = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_ResearchDesign];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_ResearchDesign, objvPaper_Cond.researchDesign, strComparisonOp_ResearchDesign);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_DimensionDataProcess) == true) {
            const strComparisonOp_DimensionDataProcess = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_DimensionDataProcess];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_DimensionDataProcess, objvPaper_Cond.dimensionDataProcess, strComparisonOp_DimensionDataProcess);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_ExpectedConclusion) == true) {
            const strComparisonOp_ExpectedConclusion = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_ExpectedConclusion];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_ExpectedConclusion, objvPaper_Cond.expectedConclusion, strComparisonOp_ExpectedConclusion);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_ShareId, objvPaper_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_PaperQCount) == true) {
            const strComparisonOp_PaperQCount = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_PaperQCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_PaperQCount, objvPaper_Cond.paperQCount, strComparisonOp_PaperQCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_SubVCount) == true) {
            const strComparisonOp_SubVCount = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_SubVCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_SubVCount, objvPaper_Cond.subVCount, strComparisonOp_SubVCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_TagsCount) == true) {
            const strComparisonOp_TagsCount = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_TagsCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_TagsCount, objvPaper_Cond.tagsCount, strComparisonOp_TagsCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_TeaQCount) == true) {
            const strComparisonOp_TeaQCount = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_TeaQCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEN_js_1.clsvPaperEN.con_TeaQCount, objvPaper_Cond.teaQCount, strComparisonOp_TeaQCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_CreateDate, objvPaper_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_UpdUser, objvPaper_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_UserName, objvPaper_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_IsGSuser) == true) {
            if (objvPaper_Cond.isGSuser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvPaperEN_js_1.clsvPaperEN.con_IsGSuser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvPaperEN_js_1.clsvPaperEN.con_IsGSuser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_CollegeName, objvPaper_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_id_XzCollege, objvPaper_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_id_XzMajor, objvPaper_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_MajorName, objvPaper_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_UpdDate, objvPaper_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN_js_1.clsvPaperEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN_js_1.clsvPaperEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEN_js_1.clsvPaperEN.con_Memo, objvPaper_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vPaper_GetCombineCondition = vPaper_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvPaperENS:源对象
     * @param objvPaperENT:目标对象
    */
    function vPaper_CopyObjTo(objvPaperENS, objvPaperENT) {
        objvPaperENT.paperId = objvPaperENS.paperId; //论文Id
        objvPaperENT.paperTitle = objvPaperENS.paperTitle; //论文标题
        objvPaperENT.paperContent = objvPaperENS.paperContent; //主题内容
        objvPaperENT.periodical = objvPaperENS.periodical; //期刊
        objvPaperENT.author = objvPaperENS.author; //作者
        objvPaperENT.researchQuestion = objvPaperENS.researchQuestion; //研究问题
        objvPaperENT.keyword = objvPaperENS.keyword; //关键字
        objvPaperENT.literatureSources = objvPaperENS.literatureSources; //文献来源
        objvPaperENT.literatureLink = objvPaperENS.literatureLink; //文献链接
        objvPaperENT.uploadfileUrl = objvPaperENS.uploadfileUrl; //文件地址
        objvPaperENT.isQuotethesis = objvPaperENS.isQuotethesis; //是否引用论文
        objvPaperENT.quoteId = objvPaperENS.quoteId; //引用Id
        objvPaperENT.isChecked = objvPaperENS.isChecked; //是否检查
        objvPaperENT.checker = objvPaperENS.checker; //审核人
        objvPaperENT.literatureTypeId = objvPaperENS.literatureTypeId; //作文类型Id
        objvPaperENT.literatureTypeName = objvPaperENS.literatureTypeName; //作文类型名
        objvPaperENT.browseNumber = objvPaperENS.browseNumber; //浏览量
        objvPaperENT.isSubmit = objvPaperENS.isSubmit; //是否提交
        objvPaperENT.appraiseCount = objvPaperENS.appraiseCount; //评论数
        objvPaperENT.attachmentCount = objvPaperENS.attachmentCount; //附件计数
        objvPaperENT.collectionCount = objvPaperENS.collectionCount; //收藏数
        objvPaperENT.downloadCount = objvPaperENS.downloadCount; //下载数
        objvPaperENT.okCount = objvPaperENS.okCount; //点赞统计
        objvPaperENT.pcount = objvPaperENS.pcount; //读写数
        objvPaperENT.score = objvPaperENS.score; //评分
        objvPaperENT.stuScore = objvPaperENS.stuScore; //学生平均分
        objvPaperENT.teaScore = objvPaperENS.teaScore; //教师评分
        objvPaperENT.paperTypeId = objvPaperENS.paperTypeId; //论文类型Id
        objvPaperENT.paperTypeName = objvPaperENS.paperTypeName; //论文类型名
        objvPaperENT.paperStatusId = objvPaperENS.paperStatusId; //论文状态Id
        objvPaperENT.paperStatusName = objvPaperENS.paperStatusName; //论文状态名
        objvPaperENT.versionCount = objvPaperENS.versionCount; //版本统计
        objvPaperENT.isPublic = objvPaperENS.isPublic; //是否公开
        objvPaperENT.askQuestion = objvPaperENS.askQuestion; //问题提出
        objvPaperENT.researchStatus = objvPaperENS.researchStatus; //目前研究的现状
        objvPaperENT.innovationPoints = objvPaperENS.innovationPoints; //创新点
        objvPaperENT.researchDesign = objvPaperENS.researchDesign; //研究设计
        objvPaperENT.dimensionDataProcess = objvPaperENS.dimensionDataProcess; //数据处理的维度
        objvPaperENT.expectedConclusion = objvPaperENS.expectedConclusion; //预期结论
        objvPaperENT.shareId = objvPaperENS.shareId; //分享Id
        objvPaperENT.paperQCount = objvPaperENS.paperQCount; //论文答疑数
        objvPaperENT.subVCount = objvPaperENS.subVCount; //论文子观点数
        objvPaperENT.tagsCount = objvPaperENS.tagsCount; //论文标注数
        objvPaperENT.teaQCount = objvPaperENS.teaQCount; //教师提问数
        objvPaperENT.createDate = objvPaperENS.createDate; //建立日期
        objvPaperENT.updUser = objvPaperENS.updUser; //修改人
        objvPaperENT.userName = objvPaperENS.userName; //用户名
        objvPaperENT.isGSuser = objvPaperENS.isGSuser; //是否GS用户
        objvPaperENT.collegeName = objvPaperENS.collegeName; //学院名称
        objvPaperENT.id_XzCollege = objvPaperENS.id_XzCollege; //学院流水号
        objvPaperENT.id_XzMajor = objvPaperENS.id_XzMajor; //专业流水号
        objvPaperENT.majorName = objvPaperENS.majorName; //专业名称
        objvPaperENT.updDate = objvPaperENS.updDate; //修改日期
        objvPaperENT.memo = objvPaperENS.memo; //备注
    }
    exports.vPaper_CopyObjTo = vPaper_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvPaperENS:源对象
     * @param objvPaperENT:目标对象
    */
    function vPaper_GetObjFromJsonObj(objvPaperENS) {
        const objvPaperENT = new clsvPaperEN_js_1.clsvPaperEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperENT, objvPaperENS);
        return objvPaperENT;
    }
    exports.vPaper_GetObjFromJsonObj = vPaper_GetObjFromJsonObj;
});
