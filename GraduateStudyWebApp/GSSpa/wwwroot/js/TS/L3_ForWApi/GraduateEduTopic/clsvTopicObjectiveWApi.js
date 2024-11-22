/**
* 类名:clsvTopicObjectiveWApi
* 表名:vTopicObjective(01120617)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:51
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vTopicObjective_GetObjFromJsonObj = exports.vTopicObjective_CopyObjTo = exports.vTopicObjective_GetCombineCondition = exports.vTopicObjective_GetObjByJSONStr = exports.vTopicObjective_GetObjLstByJSONObjLst = exports.vTopicObjective_GetObjLstByJSONStr = exports.vTopicObjective_GetJSONStrByObj = exports.vTopicObjective_ReFreshThisCache = exports.vTopicObjective_GetWebApiUrl = exports.vTopicObjective_GetRecCountByCond_Cache = exports.vTopicObjective_GetRecCountByCondAsync = exports.vTopicObjective_IsExistAsync = exports.vTopicObjective_IsExist_Cache = exports.vTopicObjective_IsExist = exports.vTopicObjective_IsExistRecordAsync = exports.vTopicObjective_IsExistRecord_Cache = exports.vTopicObjective_GetObjLstByPagerAsync = exports.vTopicObjective_GetObjLstByPager_Cache = exports.vTopicObjective_GetObjLstByRange = exports.vTopicObjective_GetObjLstByRangeAsync = exports.vTopicObjective_GetTopObjLstAsync = exports.vTopicObjective_GetObjLstByTopicObjectiveIdLst_Cache = exports.vTopicObjective_GetObjLstByTopicObjectiveIdLstAsync = exports.vTopicObjective_GetSubObjLst_Cache = exports.vTopicObjective_GetObjLst_PureCache = exports.vTopicObjective_GetObjLst_Cache = exports.vTopicObjective_GetObjLst_sessionStorage_PureCache = exports.vTopicObjective_GetObjLst_sessionStorage = exports.vTopicObjective_GetObjLstAsync = exports.vTopicObjective_GetObjLst_localStorage_PureCache = exports.vTopicObjective_GetObjLst_localStorage = exports.vTopicObjective_GetObjLst_ClientCache = exports.vTopicObjective_GetFirstObjAsync = exports.vTopicObjective_GetFirstID = exports.vTopicObjective_GetFirstIDAsync = exports.vTopicObjective_FilterFunByKey = exports.vTopicObjective_SortFunByKey = exports.vTopicObjective_SortFun_Defa_2Fld = exports.vTopicObjective_SortFun_Defa = exports.vTopicObjective_func = exports.vTopicObjective_GetObjByTopicObjectiveId_localStorage = exports.vTopicObjective_GetObjByTopicObjectiveId_Cache = exports.vTopicObjective_GetObjByTopicObjectiveIdAsync = exports.vTopicObjective_ConstructorName = exports.vTopicObjective_Controller = void 0;
    /**
     * 客观表视图(vTopicObjective)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvTopicObjectiveEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vTopicObjective_Controller = "vTopicObjectiveApi";
    exports.vTopicObjective_ConstructorName = "vTopicObjective";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strTopicObjectiveId:关键字
    * @returns 对象
    **/
    async function vTopicObjective_GetObjByTopicObjectiveIdAsync(strTopicObjectiveId) {
        const strThisFuncName = "GetObjByTopicObjectiveIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicObjectiveId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicObjectiveId]不能为空！(In GetObjByTopicObjectiveIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicObjectiveId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicObjectiveId]的长度:[{0}]不正确！", strTopicObjectiveId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTopicObjectiveId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strTopicObjectiveId": strTopicObjectiveId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTopicObjective_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvTopicObjective = vTopicObjective_GetObjFromJsonObj(returnObj);
                return objvTopicObjective;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_GetObjByTopicObjectiveIdAsync = vTopicObjective_GetObjByTopicObjectiveIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strTopicObjectiveId:所给的关键字
     * @returns 对象
    */
    async function vTopicObjective_GetObjByTopicObjectiveId_Cache(strTopicObjectiveId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByTopicObjectiveId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicObjectiveId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicObjectiveId]不能为空！(In GetObjByTopicObjectiveId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicObjectiveId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicObjectiveId]的长度:[{0}]不正确！", strTopicObjectiveId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvTopicObjective_Sel = arrvTopicObjectiveObjLst_Cache.filter(x => x.topicObjectiveId == strTopicObjectiveId);
            let objvTopicObjective;
            if (arrvTopicObjective_Sel.length > 0) {
                objvTopicObjective = arrvTopicObjective_Sel[0];
                return objvTopicObjective;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvTopicObjective = await vTopicObjective_GetObjByTopicObjectiveIdAsync(strTopicObjectiveId);
                    if (objvTopicObjective != null) {
                        vTopicObjective_ReFreshThisCache(strid_CurrEduCls);
                        return objvTopicObjective;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicObjectiveId, exports.vTopicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vTopicObjective_GetObjByTopicObjectiveId_Cache = vTopicObjective_GetObjByTopicObjectiveId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strTopicObjectiveId:所给的关键字
     * @returns 对象
    */
    async function vTopicObjective_GetObjByTopicObjectiveId_localStorage(strTopicObjectiveId) {
        const strThisFuncName = "GetObjByTopicObjectiveId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicObjectiveId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicObjectiveId]不能为空！(In GetObjByTopicObjectiveId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicObjectiveId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicObjectiveId]的长度:[{0}]不正确！", strTopicObjectiveId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN._CurrTabName, strTopicObjectiveId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvTopicObjective_Cache = JSON.parse(strTempObj);
            return objvTopicObjective_Cache;
        }
        try {
            const objvTopicObjective = await vTopicObjective_GetObjByTopicObjectiveIdAsync(strTopicObjectiveId);
            if (objvTopicObjective != null) {
                localStorage.setItem(strKey, JSON.stringify(objvTopicObjective));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvTopicObjective;
            }
            return objvTopicObjective;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicObjectiveId, exports.vTopicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vTopicObjective_GetObjByTopicObjectiveId_localStorage = vTopicObjective_GetObjByTopicObjectiveId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function vTopicObjective_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TopicObjectiveId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strTopicObjectiveId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvTopicObjective = await vTopicObjective_GetObjByTopicObjectiveId_Cache(strTopicObjectiveId, strid_CurrEduCls_C);
        if (objvTopicObjective == null)
            return "";
        return objvTopicObjective.GetFldValue(strOutFldName).toString();
    }
    exports.vTopicObjective_func = vTopicObjective_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vTopicObjective_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
    }
    exports.vTopicObjective_SortFun_Defa = vTopicObjective_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vTopicObjective_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperTitle == b.paperTitle)
            return a.paperContent.localeCompare(b.paperContent);
        else
            return a.paperTitle.localeCompare(b.paperTitle);
    }
    exports.vTopicObjective_SortFun_Defa_2Fld = vTopicObjective_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vTopicObjective_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PaperContent:
                    return (a, b) => {
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Author:
                    return (a, b) => {
                        return a.author.localeCompare(b.author);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Keyword:
                    return (a, b) => {
                        return a.keyword.localeCompare(b.keyword);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveName:
                    return (a, b) => {
                        return a.objectiveName.localeCompare(b.objectiveName);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveContent:
                    return (a, b) => {
                        return a.objectiveContent.localeCompare(b.objectiveContent);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveType:
                    return (a, b) => {
                        return a.objectiveType.localeCompare(b.objectiveType);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_SourceId:
                    return (a, b) => {
                        return a.sourceId.localeCompare(b.sourceId);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Conclusion:
                    return (a, b) => {
                        return a.conclusion.localeCompare(b.conclusion);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveTypeName:
                    return (a, b) => {
                        return a.objectiveTypeName.localeCompare(b.objectiveTypeName);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PdfContent:
                    return (a, b) => {
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_CreateDate:
                    return (a, b) => {
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vTopicObjective]中不存在！(in ${exports.vTopicObjective_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PaperContent:
                    return (a, b) => {
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Author:
                    return (a, b) => {
                        return b.author.localeCompare(a.author);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Keyword:
                    return (a, b) => {
                        return b.keyword.localeCompare(a.keyword);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveName:
                    return (a, b) => {
                        return b.objectiveName.localeCompare(a.objectiveName);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveContent:
                    return (a, b) => {
                        return b.objectiveContent.localeCompare(a.objectiveContent);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveType:
                    return (a, b) => {
                        return b.objectiveType.localeCompare(a.objectiveType);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_SourceId:
                    return (a, b) => {
                        return b.sourceId.localeCompare(a.sourceId);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Conclusion:
                    return (a, b) => {
                        return b.conclusion.localeCompare(a.conclusion);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveTypeName:
                    return (a, b) => {
                        return b.objectiveTypeName.localeCompare(a.objectiveTypeName);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PdfContent:
                    return (a, b) => {
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_CreateDate:
                    return (a, b) => {
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vTopicObjective]中不存在！(in ${exports.vTopicObjective_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vTopicObjective_SortFunByKey = vTopicObjective_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vTopicObjective_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Keyword:
                return (obj) => {
                    return obj.keyword === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TopicObjectiveId:
                return (obj) => {
                    return obj.topicObjectiveId === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveName:
                return (obj) => {
                    return obj.objectiveName === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveContent:
                return (obj) => {
                    return obj.objectiveContent === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveType:
                return (obj) => {
                    return obj.objectiveType === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_SourceId:
                return (obj) => {
                    return obj.sourceId === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Conclusion:
                return (obj) => {
                    return obj.conclusion === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveTypeName:
                return (obj) => {
                    return obj.objectiveTypeName === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vTopicObjective]中不存在！(in ${exports.vTopicObjective_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vTopicObjective_FilterFunByKey = vTopicObjective_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vTopicObjective_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_GetFirstIDAsync = vTopicObjective_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vTopicObjective_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_GetFirstID = vTopicObjective_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vTopicObjective_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTopicObjective_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvTopicObjective = vTopicObjective_GetObjFromJsonObj(returnObj);
                return objvTopicObjective;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_GetFirstObjAsync = vTopicObjective_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTopicObjective_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
        clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvTopicObjectiveExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvTopicObjectiveObjLst_T = vTopicObjective_GetObjLstByJSONObjLst(arrvTopicObjectiveExObjLst_Cache);
            return arrvTopicObjectiveObjLst_T;
        }
        try {
            const arrvTopicObjectiveExObjLst = await vTopicObjective_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvTopicObjectiveExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvTopicObjectiveExObjLst.length);
            console.log(strInfo);
            return arrvTopicObjectiveExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vTopicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vTopicObjective_GetObjLst_ClientCache = vTopicObjective_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTopicObjective_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
        clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvTopicObjectiveExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvTopicObjectiveObjLst_T = vTopicObjective_GetObjLstByJSONObjLst(arrvTopicObjectiveExObjLst_Cache);
            return arrvTopicObjectiveObjLst_T;
        }
        try {
            const arrvTopicObjectiveExObjLst = await vTopicObjective_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvTopicObjectiveExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvTopicObjectiveExObjLst.length);
            console.log(strInfo);
            return arrvTopicObjectiveExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vTopicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vTopicObjective_GetObjLst_localStorage = vTopicObjective_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTopicObjective_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvTopicObjectiveObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvTopicObjectiveObjLst_Cache;
        }
        else
            return null;
    }
    exports.vTopicObjective_GetObjLst_localStorage_PureCache = vTopicObjective_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vTopicObjective_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTopicObjective_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTopicObjective_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_GetObjLstAsync = vTopicObjective_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTopicObjective_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
        clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvTopicObjectiveExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvTopicObjectiveObjLst_T = vTopicObjective_GetObjLstByJSONObjLst(arrvTopicObjectiveExObjLst_Cache);
            return arrvTopicObjectiveObjLst_T;
        }
        try {
            const arrvTopicObjectiveExObjLst = await vTopicObjective_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvTopicObjectiveExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvTopicObjectiveExObjLst.length);
            console.log(strInfo);
            return arrvTopicObjectiveExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vTopicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vTopicObjective_GetObjLst_sessionStorage = vTopicObjective_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTopicObjective_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvTopicObjectiveObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvTopicObjectiveObjLst_Cache;
        }
        else
            return null;
    }
    exports.vTopicObjective_GetObjLst_sessionStorage_PureCache = vTopicObjective_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTopicObjective_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvTopicObjectiveObjLst_Cache;
        switch (clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.CacheModeId) {
            case "04": //sessionStorage
                arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvTopicObjectiveObjLst = vTopicObjective_GetObjLstByJSONObjLst(arrvTopicObjectiveObjLst_Cache);
        return arrvTopicObjectiveObjLst_Cache;
    }
    exports.vTopicObjective_GetObjLst_Cache = vTopicObjective_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTopicObjective_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvTopicObjectiveObjLst_Cache;
        switch (clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.CacheModeId) {
            case "04": //sessionStorage
                arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvTopicObjectiveObjLst_Cache = null;
                break;
            default:
                arrvTopicObjectiveObjLst_Cache = null;
                break;
        }
        return arrvTopicObjectiveObjLst_Cache;
    }
    exports.vTopicObjective_GetObjLst_PureCache = vTopicObjective_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrTopicObjectiveId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vTopicObjective_GetSubObjLst_Cache(objvTopicObjective_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_Cache(strid_CurrEduCls);
        let arrvTopicObjective_Sel = arrvTopicObjectiveObjLst_Cache;
        if (objvTopicObjective_Cond.sf_FldComparisonOp == null || objvTopicObjective_Cond.sf_FldComparisonOp == "")
            return arrvTopicObjective_Sel;
        const dicFldComparisonOp = JSON.parse(objvTopicObjective_Cond.sf_FldComparisonOp);
        //console.log("clsvTopicObjectiveWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvTopicObjective_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvTopicObjective_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvTopicObjective_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvTopicObjective_Cond), exports.vTopicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vTopicObjective_GetSubObjLst_Cache = vTopicObjective_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrTopicObjectiveId:关键字列表
    * @returns 对象列表
    **/
    async function vTopicObjective_GetObjLstByTopicObjectiveIdLstAsync(arrTopicObjectiveId) {
        const strThisFuncName = "GetObjLstByTopicObjectiveIdLstAsync";
        const strAction = "GetObjLstByTopicObjectiveIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicObjectiveId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTopicObjective_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTopicObjective_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_GetObjLstByTopicObjectiveIdLstAsync = vTopicObjective_GetObjLstByTopicObjectiveIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrTopicObjectiveIdLst:关键字列表
     * @returns 对象列表
    */
    async function vTopicObjective_GetObjLstByTopicObjectiveIdLst_Cache(arrTopicObjectiveIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByTopicObjectiveIdLst_Cache";
        try {
            const arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_Cache(strid_CurrEduCls);
            const arrvTopicObjective_Sel = arrvTopicObjectiveObjLst_Cache.filter(x => arrTopicObjectiveIdLst.indexOf(x.topicObjectiveId) > -1);
            return arrvTopicObjective_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTopicObjectiveIdLst.join(","), exports.vTopicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vTopicObjective_GetObjLstByTopicObjectiveIdLst_Cache = vTopicObjective_GetObjLstByTopicObjectiveIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vTopicObjective_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTopicObjective_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTopicObjective_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_GetTopObjLstAsync = vTopicObjective_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vTopicObjective_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTopicObjective_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTopicObjective_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_GetObjLstByRangeAsync = vTopicObjective_GetObjLstByRangeAsync;
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
    async function vTopicObjective_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_GetObjLstByRange = vTopicObjective_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vTopicObjective_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvTopicObjectiveObjLst_Cache.length == 0)
            return arrvTopicObjectiveObjLst_Cache;
        let arrvTopicObjective_Sel = arrvTopicObjectiveObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvTopicObjective_Cond = new clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvTopicObjective_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvTopicObjectiveWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvTopicObjective_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvTopicObjective_Sel.length == 0)
                return arrvTopicObjective_Sel;
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
                arrvTopicObjective_Sel = arrvTopicObjective_Sel.sort(vTopicObjective_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvTopicObjective_Sel = arrvTopicObjective_Sel.sort(objPagerPara.sortFun);
            }
            arrvTopicObjective_Sel = arrvTopicObjective_Sel.slice(intStart, intEnd);
            return arrvTopicObjective_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vTopicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vTopicObjective_GetObjLstByPager_Cache = vTopicObjective_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vTopicObjective_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTopicObjective_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTopicObjective_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_GetObjLstByPagerAsync = vTopicObjective_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrTopicObjectiveId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vTopicObjective_IsExistRecord_Cache(objvTopicObjective_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvTopicObjectiveObjLst_Cache == null)
            return false;
        let arrvTopicObjective_Sel = arrvTopicObjectiveObjLst_Cache;
        if (objvTopicObjective_Cond.sf_FldComparisonOp == null || objvTopicObjective_Cond.sf_FldComparisonOp == "")
            return arrvTopicObjective_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvTopicObjective_Cond.sf_FldComparisonOp);
        //console.log("clsvTopicObjectiveWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvTopicObjective_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvTopicObjective_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvTopicObjective_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvTopicObjective_Cond), exports.vTopicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vTopicObjective_IsExistRecord_Cache = vTopicObjective_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vTopicObjective_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_IsExistRecordAsync = vTopicObjective_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strTopicObjectiveId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vTopicObjective_IsExist(strTopicObjectiveId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "TopicObjectiveId": strTopicObjectiveId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_IsExist = vTopicObjective_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strTopicObjectiveId:所给的关键字
     * @returns 对象
    */
    async function vTopicObjective_IsExist_Cache(strTopicObjectiveId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvTopicObjectiveObjLst_Cache == null)
            return false;
        try {
            const arrvTopicObjective_Sel = arrvTopicObjectiveObjLst_Cache.filter(x => x.topicObjectiveId == strTopicObjectiveId);
            if (arrvTopicObjective_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTopicObjectiveId, exports.vTopicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vTopicObjective_IsExist_Cache = vTopicObjective_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strTopicObjectiveId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vTopicObjective_IsExistAsync(strTopicObjectiveId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strTopicObjectiveId": strTopicObjectiveId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_IsExistAsync = vTopicObjective_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vTopicObjective_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTopicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjective_GetRecCountByCondAsync = vTopicObjective_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvTopicObjective_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vTopicObjective_GetRecCountByCond_Cache(objvTopicObjective_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvTopicObjectiveObjLst_Cache = await vTopicObjective_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvTopicObjectiveObjLst_Cache == null)
            return 0;
        let arrvTopicObjective_Sel = arrvTopicObjectiveObjLst_Cache;
        if (objvTopicObjective_Cond.sf_FldComparisonOp == null || objvTopicObjective_Cond.sf_FldComparisonOp == "")
            return arrvTopicObjective_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvTopicObjective_Cond.sf_FldComparisonOp);
        //console.log("clsvTopicObjectiveWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvTopicObjective_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvTopicObjective_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvTopicObjective_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvTopicObjective_Cond), exports.vTopicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vTopicObjective_GetRecCountByCond_Cache = vTopicObjective_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vTopicObjective_GetWebApiUrl(strController, strAction) {
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
    exports.vTopicObjective_GetWebApiUrl = vTopicObjective_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vTopicObjective_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
            switch (clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.CacheModeId) {
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
    exports.vTopicObjective_ReFreshThisCache = vTopicObjective_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vTopicObjective_GetJSONStrByObj(pobjvTopicObjectiveEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvTopicObjectiveEN);
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
    exports.vTopicObjective_GetJSONStrByObj = vTopicObjective_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vTopicObjective_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvTopicObjectiveObjLst = new Array();
        if (strJSON === "") {
            return arrvTopicObjectiveObjLst;
        }
        try {
            arrvTopicObjectiveObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvTopicObjectiveObjLst;
        }
        return arrvTopicObjectiveObjLst;
    }
    exports.vTopicObjective_GetObjLstByJSONStr = vTopicObjective_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvTopicObjectiveObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vTopicObjective_GetObjLstByJSONObjLst(arrvTopicObjectiveObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvTopicObjectiveObjLst = new Array();
        for (const objInFor of arrvTopicObjectiveObjLstS) {
            const obj1 = vTopicObjective_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvTopicObjectiveObjLst.push(obj1);
        }
        return arrvTopicObjectiveObjLst;
    }
    exports.vTopicObjective_GetObjLstByJSONObjLst = vTopicObjective_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vTopicObjective_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvTopicObjectiveEN = new clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN();
        if (strJSON === "") {
            return pobjvTopicObjectiveEN;
        }
        try {
            pobjvTopicObjectiveEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvTopicObjectiveEN;
        }
        return pobjvTopicObjectiveEN;
    }
    exports.vTopicObjective_GetObjByJSONStr = vTopicObjective_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vTopicObjective_GetCombineCondition(objvTopicObjective_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PaperTitle, objvTopicObjective_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Author) == true) {
            const strComparisonOp_Author = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Author, objvTopicObjective_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Keyword) == true) {
            const strComparisonOp_Keyword = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Keyword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Keyword, objvTopicObjective_Cond.keyword, strComparisonOp_Keyword);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TopicObjectiveId) == true) {
            const strComparisonOp_TopicObjectiveId = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TopicObjectiveId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TopicObjectiveId, objvTopicObjective_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveName) == true) {
            const strComparisonOp_ObjectiveName = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveName, objvTopicObjective_Cond.objectiveName, strComparisonOp_ObjectiveName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveType) == true) {
            const strComparisonOp_ObjectiveType = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveType, objvTopicObjective_Cond.objectiveType, strComparisonOp_ObjectiveType);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_SourceId) == true) {
            const strComparisonOp_SourceId = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_SourceId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_SourceId, objvTopicObjective_Cond.sourceId, strComparisonOp_SourceId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_IsSubmit) == true) {
            if (objvTopicObjective_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdDate, objvTopicObjective_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_Memo, objvTopicObjective_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveTypeName) == true) {
            const strComparisonOp_ObjectiveTypeName = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveTypeName, objvTopicObjective_Cond.objectiveTypeName, strComparisonOp_ObjectiveTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_CitationCount, objvTopicObjective_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_AppraiseCount, objvTopicObjective_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_score) == true) {
            const strComparisonOp_score = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_score, objvTopicObjective_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_StuScore, objvTopicObjective_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_TeaScore, objvTopicObjective_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_id_CurrEduCls, objvTopicObjective_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PdfContent, objvTopicObjective_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_PdfPageNum, objvTopicObjective_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_OkCount, objvTopicObjective_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_VersionCount, objvTopicObjective_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_CreateDate, objvTopicObjective_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ShareId, objvTopicObjective_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvTopicObjective_Cond.dicFldComparisonOp, clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvTopicObjective_Cond.dicFldComparisonOp[clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser, objvTopicObjective_Cond.updUser, strComparisonOp_UpdUser);
        }
        return strWhereCond;
    }
    exports.vTopicObjective_GetCombineCondition = vTopicObjective_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvTopicObjectiveENS:源对象
     * @param objvTopicObjectiveENT:目标对象
    */
    function vTopicObjective_CopyObjTo(objvTopicObjectiveENS, objvTopicObjectiveENT) {
        objvTopicObjectiveENT.paperTitle = objvTopicObjectiveENS.paperTitle; //论文标题
        objvTopicObjectiveENT.paperContent = objvTopicObjectiveENS.paperContent; //主题内容
        objvTopicObjectiveENT.author = objvTopicObjectiveENS.author; //作者
        objvTopicObjectiveENT.keyword = objvTopicObjectiveENS.keyword; //关键字
        objvTopicObjectiveENT.topicObjectiveId = objvTopicObjectiveENS.topicObjectiveId; //客观Id
        objvTopicObjectiveENT.objectiveName = objvTopicObjectiveENS.objectiveName; //客观名称
        objvTopicObjectiveENT.objectiveContent = objvTopicObjectiveENS.objectiveContent; //客观内容
        objvTopicObjectiveENT.objectiveType = objvTopicObjectiveENS.objectiveType; //客观类型
        objvTopicObjectiveENT.sourceId = objvTopicObjectiveENS.sourceId; //来源Id
        objvTopicObjectiveENT.conclusion = objvTopicObjectiveENS.conclusion; //结论
        objvTopicObjectiveENT.isSubmit = objvTopicObjectiveENS.isSubmit; //是否提交
        objvTopicObjectiveENT.updDate = objvTopicObjectiveENS.updDate; //修改日期
        objvTopicObjectiveENT.memo = objvTopicObjectiveENS.memo; //备注
        objvTopicObjectiveENT.objectiveTypeName = objvTopicObjectiveENS.objectiveTypeName; //ObjectiveTypeName
        objvTopicObjectiveENT.citationCount = objvTopicObjectiveENS.citationCount; //引用统计
        objvTopicObjectiveENT.appraiseCount = objvTopicObjectiveENS.appraiseCount; //评论数
        objvTopicObjectiveENT.score = objvTopicObjectiveENS.score; //评分
        objvTopicObjectiveENT.stuScore = objvTopicObjectiveENS.stuScore; //学生平均分
        objvTopicObjectiveENT.teaScore = objvTopicObjectiveENS.teaScore; //教师评分
        objvTopicObjectiveENT.id_CurrEduCls = objvTopicObjectiveENS.id_CurrEduCls; //教学班流水号
        objvTopicObjectiveENT.pdfContent = objvTopicObjectiveENS.pdfContent; //Pdf内容
        objvTopicObjectiveENT.pdfPageNum = objvTopicObjectiveENS.pdfPageNum; //Pdf页码
        objvTopicObjectiveENT.okCount = objvTopicObjectiveENS.okCount; //点赞统计
        objvTopicObjectiveENT.versionCount = objvTopicObjectiveENS.versionCount; //版本统计
        objvTopicObjectiveENT.createDate = objvTopicObjectiveENS.createDate; //建立日期
        objvTopicObjectiveENT.shareId = objvTopicObjectiveENS.shareId; //分享Id
        objvTopicObjectiveENT.updUser = objvTopicObjectiveENS.updUser; //修改人
    }
    exports.vTopicObjective_CopyObjTo = vTopicObjective_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvTopicObjectiveENS:源对象
     * @param objvTopicObjectiveENT:目标对象
    */
    function vTopicObjective_GetObjFromJsonObj(objvTopicObjectiveENS) {
        const objvTopicObjectiveENT = new clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvTopicObjectiveENT, objvTopicObjectiveENS);
        return objvTopicObjectiveENT;
    }
    exports.vTopicObjective_GetObjFromJsonObj = vTopicObjective_GetObjFromJsonObj;
});
