/**
* 类名:clsvConceptWApi
* 表名:vConcept(01120619)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:45:44
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvConceptEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vConcept_GetObjFromJsonObj = exports.vConcept_CopyObjTo = exports.vConcept_GetCombineCondition = exports.vConcept_GetObjByJSONStr = exports.vConcept_GetObjLstByJSONObjLst = exports.vConcept_GetObjLstByJSONStr = exports.vConcept_GetJSONStrByObj = exports.vConcept_ReFreshThisCache = exports.vConcept_GetWebApiUrl = exports.vConcept_GetRecCountByCond_Cache = exports.vConcept_GetRecCountByCondAsync = exports.vConcept_IsExistAsync = exports.vConcept_IsExist_Cache = exports.vConcept_IsExist = exports.vConcept_IsExistRecordAsync = exports.vConcept_IsExistRecord_Cache = exports.vConcept_GetObjLstByPagerAsync = exports.vConcept_GetObjLstByPager_Cache = exports.vConcept_GetObjLstByRange = exports.vConcept_GetObjLstByRangeAsync = exports.vConcept_GetTopObjLstAsync = exports.vConcept_GetObjLstByConceptIdLst_Cache = exports.vConcept_GetObjLstByConceptIdLstAsync = exports.vConcept_GetSubObjLst_Cache = exports.vConcept_GetObjLst_PureCache = exports.vConcept_GetObjLst_Cache = exports.vConcept_GetObjLst_sessionStorage_PureCache = exports.vConcept_GetObjLst_sessionStorage = exports.vConcept_GetObjLstAsync = exports.vConcept_GetObjLst_localStorage_PureCache = exports.vConcept_GetObjLst_localStorage = exports.vConcept_GetObjLst_ClientCache = exports.vConcept_GetFirstObjAsync = exports.vConcept_GetFirstID = exports.vConcept_GetFirstIDAsync = exports.vConcept_funcKey = exports.vConcept_FilterFunByKey = exports.vConcept_SortFunByKey = exports.vConcept_SortFun_Defa_2Fld = exports.vConcept_SortFun_Defa = exports.vConcept_func = exports.vConcept_GetObjByConceptId_localStorage = exports.vConcept_GetObjByConceptId_Cache = exports.vConcept_GetObjByConceptIdAsync = exports.vConcept_ConstructorName = exports.vConcept_Controller = void 0;
    /**
     * 概念视图(vConcept)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvConceptEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvConceptEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vConcept_Controller = "vConceptApi";
    exports.vConcept_ConstructorName = "vConcept";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strConceptId:关键字
    * @returns 对象
    **/
    async function vConcept_GetObjByConceptIdAsync(strConceptId) {
        const strThisFuncName = "GetObjByConceptIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strConceptId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strConceptId]不能为空！(In clsvConceptWApi.GetObjByConceptIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strConceptId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strConceptId]的长度:[{0}]不正确！(clsvConceptWApi.GetObjByConceptIdAsync)", strConceptId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByConceptId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strConceptId": strConceptId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvConcept = vConcept_GetObjFromJsonObj(returnObj);
                return objvConcept;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_GetObjByConceptIdAsync = vConcept_GetObjByConceptIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strConceptId:所给的关键字
     * @returns 对象
    */
    async function vConcept_GetObjByConceptId_Cache(strConceptId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByConceptId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strConceptId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strConceptId]不能为空！(In clsvConceptWApi.GetObjByConceptId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strConceptId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strConceptId]的长度:[{0}]不正确！(clsvConceptWApi.GetObjByConceptId_Cache)", strConceptId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvConcept_Sel = arrvConceptObjLst_Cache.filter(x => x.conceptId == strConceptId);
            let objvConcept;
            if (arrvConcept_Sel.length > 0) {
                objvConcept = arrvConcept_Sel[0];
                return objvConcept;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvConcept_Const = await vConcept_GetObjByConceptIdAsync(strConceptId);
                    if (objvConcept_Const != null) {
                        vConcept_ReFreshThisCache(strid_CurrEduCls);
                        return objvConcept_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strConceptId, exports.vConcept_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vConcept_GetObjByConceptId_Cache = vConcept_GetObjByConceptId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strConceptId:所给的关键字
     * @returns 对象
    */
    async function vConcept_GetObjByConceptId_localStorage(strConceptId) {
        const strThisFuncName = "GetObjByConceptId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strConceptId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strConceptId]不能为空！(In clsvConceptWApi.GetObjByConceptId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strConceptId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strConceptId]的长度:[{0}]不正确！(clsvConceptWApi.GetObjByConceptId_localStorage)", strConceptId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptEN_js_1.clsvConceptEN._CurrTabName, strConceptId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvConcept_Cache = JSON.parse(strTempObj);
            return objvConcept_Cache;
        }
        try {
            const objvConcept = await vConcept_GetObjByConceptIdAsync(strConceptId);
            if (objvConcept != null) {
                localStorage.setItem(strKey, JSON.stringify(objvConcept));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvConcept;
            }
            return objvConcept;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strConceptId, exports.vConcept_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vConcept_GetObjByConceptId_localStorage = vConcept_GetObjByConceptId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function vConcept_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvConceptWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvConceptWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvConceptEN_js_1.clsvConceptEN.con_ConceptId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvConceptEN_js_1.clsvConceptEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvConceptEN_js_1.clsvConceptEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strConceptId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvConcept = await vConcept_GetObjByConceptId_Cache(strConceptId, strid_CurrEduCls_C);
        if (objvConcept == null)
            return "";
        if (objvConcept.GetFldValue(strOutFldName) == null)
            return "";
        return objvConcept.GetFldValue(strOutFldName).toString();
    }
    exports.vConcept_func = vConcept_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vConcept_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.conceptId.localeCompare(b.conceptId);
    }
    exports.vConcept_SortFun_Defa = vConcept_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vConcept_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.conceptContent == b.conceptContent)
            return a.conceptName.localeCompare(b.conceptName);
        else
            return a.conceptContent.localeCompare(b.conceptContent);
    }
    exports.vConcept_SortFun_Defa_2Fld = vConcept_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vConcept_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvConceptEN_js_1.clsvConceptEN.con_ConceptContent:
                    return (a, b) => {
                        if (a.conceptContent == null)
                            return -1;
                        if (b.conceptContent == null)
                            return 1;
                        return a.conceptContent.localeCompare(b.conceptContent);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_ConceptName:
                    return (a, b) => {
                        if (a.conceptName == null)
                            return -1;
                        if (b.conceptName == null)
                            return 1;
                        return a.conceptName.localeCompare(b.conceptName);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_ConceptId:
                    return (a, b) => {
                        return a.conceptId.localeCompare(b.conceptId);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_Author:
                    return (a, b) => {
                        if (a.author == null)
                            return -1;
                        if (b.author == null)
                            return 1;
                        return a.author.localeCompare(b.author);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_CitationId:
                    return (a, b) => {
                        if (a.citationId == null)
                            return -1;
                        if (b.citationId == null)
                            return 1;
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_Keyword:
                    return (a, b) => {
                        if (a.keyword == null)
                            return -1;
                        if (b.keyword == null)
                            return 1;
                        return a.keyword.localeCompare(b.keyword);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_PaperTitle:
                    return (a, b) => {
                        if (a.paperTitle == null)
                            return -1;
                        if (b.paperTitle == null)
                            return 1;
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_Periodical:
                    return (a, b) => {
                        if (a.periodical == null)
                            return -1;
                        if (b.periodical == null)
                            return 1;
                        return a.periodical.localeCompare(b.periodical);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (a.researchQuestion == null)
                            return -1;
                        if (b.researchQuestion == null)
                            return 1;
                        return a.researchQuestion.localeCompare(b.researchQuestion);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_PdfContent:
                    return (a, b) => {
                        if (a.pdfContent == null)
                            return -1;
                        if (b.pdfContent == null)
                            return 1;
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vConcept]中不存在！(in ${exports.vConcept_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvConceptEN_js_1.clsvConceptEN.con_ConceptContent:
                    return (a, b) => {
                        if (b.conceptContent == null)
                            return -1;
                        if (a.conceptContent == null)
                            return 1;
                        return b.conceptContent.localeCompare(a.conceptContent);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_ConceptName:
                    return (a, b) => {
                        if (b.conceptName == null)
                            return -1;
                        if (a.conceptName == null)
                            return 1;
                        return b.conceptName.localeCompare(a.conceptName);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_ConceptId:
                    return (a, b) => {
                        return b.conceptId.localeCompare(a.conceptId);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_Author:
                    return (a, b) => {
                        if (b.author == null)
                            return -1;
                        if (a.author == null)
                            return 1;
                        return b.author.localeCompare(a.author);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_CitationId:
                    return (a, b) => {
                        if (b.citationId == null)
                            return -1;
                        if (a.citationId == null)
                            return 1;
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_Keyword:
                    return (a, b) => {
                        if (b.keyword == null)
                            return -1;
                        if (a.keyword == null)
                            return 1;
                        return b.keyword.localeCompare(a.keyword);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_PaperTitle:
                    return (a, b) => {
                        if (b.paperTitle == null)
                            return -1;
                        if (a.paperTitle == null)
                            return 1;
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_Periodical:
                    return (a, b) => {
                        if (b.periodical == null)
                            return -1;
                        if (a.periodical == null)
                            return 1;
                        return b.periodical.localeCompare(a.periodical);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (b.researchQuestion == null)
                            return -1;
                        if (a.researchQuestion == null)
                            return 1;
                        return b.researchQuestion.localeCompare(a.researchQuestion);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvConceptEN_js_1.clsvConceptEN.con_PdfContent:
                    return (a, b) => {
                        if (b.pdfContent == null)
                            return -1;
                        if (a.pdfContent == null)
                            return 1;
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vConcept]中不存在！(in ${exports.vConcept_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vConcept_SortFunByKey = vConcept_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vConcept_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvConceptEN_js_1.clsvConceptEN.con_ConceptContent:
                return (obj) => {
                    return obj.conceptContent === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_ConceptName:
                return (obj) => {
                    return obj.conceptName === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_ConceptId:
                return (obj) => {
                    return obj.conceptId === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_Keyword:
                return (obj) => {
                    return obj.keyword === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_Periodical:
                return (obj) => {
                    return obj.periodical === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_ResearchQuestion:
                return (obj) => {
                    return obj.researchQuestion === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvConceptEN_js_1.clsvConceptEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vConcept]中不存在！(in ${exports.vConcept_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vConcept_FilterFunByKey = vConcept_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function vConcept_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvConceptWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvConceptWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvConceptEN_js_1.clsvConceptEN.con_ConceptId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvConcept = await vConcept_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrvConcept == null)
            return [];
        let arrvConcept_Sel = arrvConcept;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvConcept_Sel = arrvConcept_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvConcept_Sel.length == 0)
            return [];
        return arrvConcept_Sel.map(x => x.conceptId);
    }
    exports.vConcept_funcKey = vConcept_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vConcept_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_GetFirstIDAsync = vConcept_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vConcept_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_GetFirstID = vConcept_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vConcept_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
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
                const objvConcept = vConcept_GetObjFromJsonObj(returnObj);
                return objvConcept;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_GetFirstObjAsync = vConcept_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConcept_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvConceptEN_js_1.clsvConceptEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvConceptEN_js_1.clsvConceptEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptEN_js_1.clsvConceptEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvConceptEN_js_1.clsvConceptEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvConceptEN_js_1.clsvConceptEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvConceptExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvConceptObjLst_T = vConcept_GetObjLstByJSONObjLst(arrvConceptExObjLst_Cache);
            return arrvConceptObjLst_T;
        }
        try {
            const arrvConceptExObjLst = await vConcept_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvConceptExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvConceptExObjLst.length);
            console.log(strInfo);
            return arrvConceptExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vConcept_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vConcept_GetObjLst_ClientCache = vConcept_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConcept_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvConceptEN_js_1.clsvConceptEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvConceptEN_js_1.clsvConceptEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptEN_js_1.clsvConceptEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvConceptEN_js_1.clsvConceptEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvConceptEN_js_1.clsvConceptEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvConceptExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvConceptObjLst_T = vConcept_GetObjLstByJSONObjLst(arrvConceptExObjLst_Cache);
            return arrvConceptObjLst_T;
        }
        try {
            const arrvConceptExObjLst = await vConcept_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvConceptExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvConceptExObjLst.length);
            console.log(strInfo);
            return arrvConceptExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vConcept_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vConcept_GetObjLst_localStorage = vConcept_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConcept_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptEN_js_1.clsvConceptEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvConceptObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvConceptObjLst_Cache;
        }
        else
            return null;
    }
    exports.vConcept_GetObjLst_localStorage_PureCache = vConcept_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vConcept_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConcept_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConcept_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_GetObjLstAsync = vConcept_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConcept_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvConceptEN_js_1.clsvConceptEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvConceptEN_js_1.clsvConceptEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptEN_js_1.clsvConceptEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvConceptEN_js_1.clsvConceptEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvConceptEN_js_1.clsvConceptEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvConceptExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvConceptObjLst_T = vConcept_GetObjLstByJSONObjLst(arrvConceptExObjLst_Cache);
            return arrvConceptObjLst_T;
        }
        try {
            const arrvConceptExObjLst = await vConcept_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvConceptExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvConceptExObjLst.length);
            console.log(strInfo);
            return arrvConceptExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vConcept_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vConcept_GetObjLst_sessionStorage = vConcept_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConcept_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptEN_js_1.clsvConceptEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvConceptObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvConceptObjLst_Cache;
        }
        else
            return null;
    }
    exports.vConcept_GetObjLst_sessionStorage_PureCache = vConcept_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConcept_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvConceptWApi.vConcept_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvConceptWApi.vConcept_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvConceptObjLst_Cache;
        switch (clsvConceptEN_js_1.clsvConceptEN.CacheModeId) {
            case "04": //sessionStorage
                arrvConceptObjLst_Cache = await vConcept_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvConceptObjLst_Cache = await vConcept_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvConceptObjLst_Cache = await vConcept_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvConceptObjLst_Cache = await vConcept_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvConceptObjLst = vConcept_GetObjLstByJSONObjLst(arrvConceptObjLst_Cache);
        return arrvConceptObjLst_Cache;
    }
    exports.vConcept_GetObjLst_Cache = vConcept_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConcept_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvConceptObjLst_Cache;
        switch (clsvConceptEN_js_1.clsvConceptEN.CacheModeId) {
            case "04": //sessionStorage
                arrvConceptObjLst_Cache = await vConcept_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvConceptObjLst_Cache = await vConcept_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvConceptObjLst_Cache = null;
                break;
            default:
                arrvConceptObjLst_Cache = null;
                break;
        }
        return arrvConceptObjLst_Cache;
    }
    exports.vConcept_GetObjLst_PureCache = vConcept_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrConceptId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vConcept_GetSubObjLst_Cache(objvConcept_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
        let arrvConcept_Sel = arrvConceptObjLst_Cache;
        if (objvConcept_Cond.sf_FldComparisonOp == null || objvConcept_Cond.sf_FldComparisonOp == "")
            return arrvConcept_Sel;
        const dicFldComparisonOp = JSON.parse(objvConcept_Cond.sf_FldComparisonOp);
        //console.log("clsvConceptWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvConcept_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvConcept_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvConcept_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvConcept_Cond), exports.vConcept_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vConcept_GetSubObjLst_Cache = vConcept_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrConceptId:关键字列表
    * @returns 对象列表
    **/
    async function vConcept_GetObjLstByConceptIdLstAsync(arrConceptId) {
        const strThisFuncName = "GetObjLstByConceptIdLstAsync";
        const strAction = "GetObjLstByConceptIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrConceptId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConcept_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConcept_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_GetObjLstByConceptIdLstAsync = vConcept_GetObjLstByConceptIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrConceptIdLst:关键字列表
     * @returns 对象列表
    */
    async function vConcept_GetObjLstByConceptIdLst_Cache(arrConceptIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByConceptIdLst_Cache";
        try {
            const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
            const arrvConcept_Sel = arrvConceptObjLst_Cache.filter(x => arrConceptIdLst.indexOf(x.conceptId) > -1);
            return arrvConcept_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrConceptIdLst.join(","), exports.vConcept_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vConcept_GetObjLstByConceptIdLst_Cache = vConcept_GetObjLstByConceptIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vConcept_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConcept_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConcept_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_GetTopObjLstAsync = vConcept_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vConcept_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConcept_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConcept_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_GetObjLstByRangeAsync = vConcept_GetObjLstByRangeAsync;
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
    async function vConcept_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_GetObjLstByRange = vConcept_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vConcept_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvConceptObjLst_Cache.length == 0)
            return arrvConceptObjLst_Cache;
        let arrvConcept_Sel = arrvConceptObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvConcept_Cond = new clsvConceptEN_js_1.clsvConceptEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvConcept_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvConceptWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvConcept_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvConcept_Sel.length == 0)
                return arrvConcept_Sel;
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
                arrvConcept_Sel = arrvConcept_Sel.sort(vConcept_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvConcept_Sel = arrvConcept_Sel.sort(objPagerPara.sortFun);
            }
            arrvConcept_Sel = arrvConcept_Sel.slice(intStart, intEnd);
            return arrvConcept_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vConcept_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vConcept_GetObjLstByPager_Cache = vConcept_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vConcept_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConcept_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConcept_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_GetObjLstByPagerAsync = vConcept_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrConceptId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vConcept_IsExistRecord_Cache(objvConcept_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvConceptObjLst_Cache == null)
            return false;
        let arrvConcept_Sel = arrvConceptObjLst_Cache;
        if (objvConcept_Cond.sf_FldComparisonOp == null || objvConcept_Cond.sf_FldComparisonOp == "")
            return arrvConcept_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvConcept_Cond.sf_FldComparisonOp);
        //console.log("clsvConceptWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvConcept_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvConcept_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvConcept_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvConcept_Cond), exports.vConcept_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vConcept_IsExistRecord_Cache = vConcept_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vConcept_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_IsExistRecordAsync = vConcept_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strConceptId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vConcept_IsExist(strConceptId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ConceptId": strConceptId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_IsExist = vConcept_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strConceptId:所给的关键字
     * @returns 对象
    */
    async function vConcept_IsExist_Cache(strConceptId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvConceptObjLst_Cache == null)
            return false;
        try {
            const arrvConcept_Sel = arrvConceptObjLst_Cache.filter(x => x.conceptId == strConceptId);
            if (arrvConcept_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strConceptId, exports.vConcept_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vConcept_IsExist_Cache = vConcept_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strConceptId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vConcept_IsExistAsync(strConceptId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strConceptId": strConceptId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_IsExistAsync = vConcept_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vConcept_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConcept_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConcept_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConcept_GetRecCountByCondAsync = vConcept_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvConcept_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vConcept_GetRecCountByCond_Cache(objvConcept_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvConceptObjLst_Cache == null)
            return 0;
        let arrvConcept_Sel = arrvConceptObjLst_Cache;
        if (objvConcept_Cond.sf_FldComparisonOp == null || objvConcept_Cond.sf_FldComparisonOp == "")
            return arrvConcept_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvConcept_Cond.sf_FldComparisonOp);
        //console.log("clsvConceptWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvConcept_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvConcept_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvConcept_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvConcept_Cond), exports.vConcept_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vConcept_GetRecCountByCond_Cache = vConcept_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vConcept_GetWebApiUrl(strController, strAction) {
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
    exports.vConcept_GetWebApiUrl = vConcept_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vConcept_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptEN_js_1.clsvConceptEN._CurrTabName, strid_CurrEduCls);
            switch (clsvConceptEN_js_1.clsvConceptEN.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
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
    exports.vConcept_ReFreshThisCache = vConcept_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vConcept_GetJSONStrByObj(pobjvConceptEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvConceptEN);
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
    exports.vConcept_GetJSONStrByObj = vConcept_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vConcept_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvConceptObjLst = new Array();
        if (strJSON === "") {
            return arrvConceptObjLst;
        }
        try {
            arrvConceptObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvConceptObjLst;
        }
        return arrvConceptObjLst;
    }
    exports.vConcept_GetObjLstByJSONStr = vConcept_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvConceptObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vConcept_GetObjLstByJSONObjLst(arrvConceptObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvConceptObjLst = new Array();
        for (const objInFor of arrvConceptObjLstS) {
            const obj1 = vConcept_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvConceptObjLst.push(obj1);
        }
        return arrvConceptObjLst;
    }
    exports.vConcept_GetObjLstByJSONObjLst = vConcept_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vConcept_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvConceptEN = new clsvConceptEN_js_1.clsvConceptEN();
        if (strJSON === "") {
            return pobjvConceptEN;
        }
        try {
            pobjvConceptEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvConceptEN;
        }
        return pobjvConceptEN;
    }
    exports.vConcept_GetObjByJSONStr = vConcept_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vConcept_GetCombineCondition(objvConcept_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_ConceptName) == true) {
            const strComparisonOp_ConceptName = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_ConceptName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_ConceptName, objvConcept_Cond.conceptName, strComparisonOp_ConceptName);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_IsSubmit) == true) {
            if (objvConcept_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvConceptEN_js_1.clsvConceptEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvConceptEN_js_1.clsvConceptEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_ConceptId) == true) {
            const strComparisonOp_ConceptId = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_ConceptId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_ConceptId, objvConcept_Cond.conceptId, strComparisonOp_ConceptId);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_UpdDate, objvConcept_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_Memo, objvConcept_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_Author) == true) {
            const strComparisonOp_Author = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_Author, objvConcept_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_CitationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_CitationId, objvConcept_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_Keyword) == true) {
            const strComparisonOp_Keyword = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_Keyword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_Keyword, objvConcept_Cond.keyword, strComparisonOp_Keyword);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_PaperTitle, objvConcept_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_Periodical) == true) {
            const strComparisonOp_Periodical = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_Periodical];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_Periodical, objvConcept_Cond.periodical, strComparisonOp_Periodical);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_ResearchQuestion) == true) {
            const strComparisonOp_ResearchQuestion = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_ResearchQuestion];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_ResearchQuestion, objvConcept_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvConceptEN_js_1.clsvConceptEN.con_CitationCount, objvConcept_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvConceptEN_js_1.clsvConceptEN.con_AppraiseCount, objvConcept_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_Score) == true) {
            const strComparisonOp_Score = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_Score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvConceptEN_js_1.clsvConceptEN.con_Score, objvConcept_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvConceptEN_js_1.clsvConceptEN.con_StuScore, objvConcept_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvConceptEN_js_1.clsvConceptEN.con_TeaScore, objvConcept_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_id_CurrEduCls, objvConcept_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvConceptEN_js_1.clsvConceptEN.con_PdfPageNum, objvConcept_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvConceptEN_js_1.clsvConceptEN.con_OkCount, objvConcept_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvConceptEN_js_1.clsvConceptEN.con_VersionCount, objvConcept_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_CreateDate, objvConcept_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_ShareId, objvConcept_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_UpdUser, objvConcept_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN_js_1.clsvConceptEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN_js_1.clsvConceptEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptEN_js_1.clsvConceptEN.con_PdfContent, objvConcept_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        return strWhereCond;
    }
    exports.vConcept_GetCombineCondition = vConcept_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvConceptENS:源对象
     * @param objvConceptENT:目标对象
    */
    function vConcept_CopyObjTo(objvConceptENS, objvConceptENT) {
        objvConceptENT.conceptContent = objvConceptENS.conceptContent; //概念内容
        objvConceptENT.conceptName = objvConceptENS.conceptName; //概念名称
        objvConceptENT.isSubmit = objvConceptENS.isSubmit; //是否提交
        objvConceptENT.conceptId = objvConceptENS.conceptId; //概念Id
        objvConceptENT.updDate = objvConceptENS.updDate; //修改日期
        objvConceptENT.memo = objvConceptENS.memo; //备注
        objvConceptENT.author = objvConceptENS.author; //作者
        objvConceptENT.citationId = objvConceptENS.citationId; //引用Id
        objvConceptENT.keyword = objvConceptENS.keyword; //关键字
        objvConceptENT.paperTitle = objvConceptENS.paperTitle; //论文标题
        objvConceptENT.periodical = objvConceptENS.periodical; //期刊
        objvConceptENT.researchQuestion = objvConceptENS.researchQuestion; //研究问题
        objvConceptENT.citationCount = objvConceptENS.citationCount; //引用统计
        objvConceptENT.appraiseCount = objvConceptENS.appraiseCount; //评论数
        objvConceptENT.score = objvConceptENS.score; //评分
        objvConceptENT.stuScore = objvConceptENS.stuScore; //学生平均分
        objvConceptENT.teaScore = objvConceptENS.teaScore; //教师评分
        objvConceptENT.id_CurrEduCls = objvConceptENS.id_CurrEduCls; //教学班流水号
        objvConceptENT.pdfPageNum = objvConceptENS.pdfPageNum; //Pdf页码
        objvConceptENT.okCount = objvConceptENS.okCount; //点赞统计
        objvConceptENT.versionCount = objvConceptENS.versionCount; //版本统计
        objvConceptENT.createDate = objvConceptENS.createDate; //建立日期
        objvConceptENT.shareId = objvConceptENS.shareId; //分享Id
        objvConceptENT.updUser = objvConceptENS.updUser; //修改人
        objvConceptENT.pdfContent = objvConceptENS.pdfContent; //Pdf内容
    }
    exports.vConcept_CopyObjTo = vConcept_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvConceptENS:源对象
     * @param objvConceptENT:目标对象
    */
    function vConcept_GetObjFromJsonObj(objvConceptENS) {
        const objvConceptENT = new clsvConceptEN_js_1.clsvConceptEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvConceptENT, objvConceptENS);
        return objvConceptENT;
    }
    exports.vConcept_GetObjFromJsonObj = vConcept_GetObjFromJsonObj;
});
