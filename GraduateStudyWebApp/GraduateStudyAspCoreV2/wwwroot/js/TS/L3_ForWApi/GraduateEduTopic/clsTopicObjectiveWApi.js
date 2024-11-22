/**
* 类名:clsTopicObjectiveWApi
* 表名:TopicObjective(01120613)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:50:25
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.TopicObjective_GetObjFromJsonObj = exports.TopicObjective_CopyObjTo = exports.TopicObjective_GetUniCondStr4Update_ObjectiveName_id_CurrEduCls = exports.TopicObjective_GetUniCondStr_ObjectiveName_id_CurrEduCls = exports.TopicObjective_GetCombineCondition = exports.TopicObjective_GetObjByJSONStr = exports.TopicObjective_GetObjLstByJSONObjLst = exports.TopicObjective_GetObjLstByJSONStr = exports.TopicObjective_GetJSONStrByObj = exports.TopicObjective_CheckProperty4Update = exports.TopicObjective_CheckPropertyNew = exports.TopicObjective_ReFreshThisCache = exports.TopicObjective_ReFreshCache = exports.TopicObjective_GetWebApiUrl = exports.TopicObjective_GetMaxStrIdByPrefix = exports.TopicObjective_GetMaxStrIdAsync = exports.TopicObjective_GetRecCountByCond_Cache = exports.TopicObjective_GetRecCountByCondAsync = exports.TopicObjective_IsExistAsync = exports.TopicObjective_IsExist_Cache = exports.TopicObjective_IsExist = exports.TopicObjective_IsExistRecordAsync = exports.TopicObjective_IsExistRecord_Cache = exports.TopicObjective_UpdateWithConditionAsync = exports.TopicObjective_UpdateRecordAsync = exports.TopicObjective_AddNewRecordWithReturnKey = exports.TopicObjective_AddNewRecordWithReturnKeyAsync = exports.TopicObjective_AddNewRecordWithMaxIdAsync = exports.TopicObjective_AddNewRecordAsync = exports.TopicObjective_DelTopicObjectivesByCondAsync = exports.TopicObjective_DelTopicObjectivesAsync = exports.TopicObjective_DelRecordAsync = exports.TopicObjective_GetObjLstByPagerAsync = exports.TopicObjective_GetObjLstByPager_Cache = exports.TopicObjective_GetObjLstByRange = exports.TopicObjective_GetObjLstByRangeAsync = exports.TopicObjective_GetTopObjLstAsync = exports.TopicObjective_GetObjLstByTopicObjectiveIdLst_Cache = exports.TopicObjective_GetObjLstByTopicObjectiveIdLstAsync = exports.TopicObjective_GetSubObjLst_Cache = exports.TopicObjective_GetObjLst_PureCache = exports.TopicObjective_GetObjLst_Cache = exports.TopicObjective_GetObjLst_sessionStorage_PureCache = exports.TopicObjective_GetObjLst_sessionStorage = exports.TopicObjective_GetObjLstAsync = exports.TopicObjective_GetObjLst_localStorage_PureCache = exports.TopicObjective_GetObjLst_localStorage = exports.TopicObjective_GetObjLst_ClientCache = exports.TopicObjective_GetFirstObjAsync = exports.TopicObjective_GetFirstID = exports.TopicObjective_GetFirstIDAsync = exports.TopicObjective_funcKey = exports.TopicObjective_FilterFunByKey = exports.TopicObjective_SortFunByKey = exports.TopicObjective_SortFun_Defa_2Fld = exports.TopicObjective_SortFun_Defa = exports.TopicObjective_func = exports.TopicObjective_UpdateObjInLst_Cache = exports.TopicObjective_GetObjByTopicObjectiveId_localStorage = exports.TopicObjective_GetObjByTopicObjectiveId_Cache = exports.TopicObjective_GetObjByTopicObjectiveIdAsync = exports.topicObjective_ConstructorName = exports.topicObjective_Controller = void 0;
    /**
     * 主题客观表(TopicObjective)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsTopicObjectiveEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js");
    const clsvTopicObjectiveWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.topicObjective_Controller = "TopicObjectiveApi";
    exports.topicObjective_ConstructorName = "topicObjective";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strTopicObjectiveId:关键字
    * @returns 对象
    **/
    async function TopicObjective_GetObjByTopicObjectiveIdAsync(strTopicObjectiveId) {
        const strThisFuncName = "GetObjByTopicObjectiveIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicObjectiveId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicObjectiveId]不能为空！(In clsTopicObjectiveWApi.GetObjByTopicObjectiveIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicObjectiveId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicObjectiveId]的长度:[{0}]不正确！(clsTopicObjectiveWApi.GetObjByTopicObjectiveIdAsync)", strTopicObjectiveId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTopicObjectiveId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
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
                    return null;
                }
                //console.log(returnObj);
                const objTopicObjective = TopicObjective_GetObjFromJsonObj(returnObj);
                return objTopicObjective;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetObjByTopicObjectiveIdAsync = TopicObjective_GetObjByTopicObjectiveIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strTopicObjectiveId:所给的关键字
     * @returns 对象
    */
    async function TopicObjective_GetObjByTopicObjectiveId_Cache(strTopicObjectiveId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByTopicObjectiveId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicObjectiveId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicObjectiveId]不能为空！(In clsTopicObjectiveWApi.GetObjByTopicObjectiveId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicObjectiveId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicObjectiveId]的长度:[{0}]不正确！(clsTopicObjectiveWApi.GetObjByTopicObjectiveId_Cache)", strTopicObjectiveId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrTopicObjective_Sel = arrTopicObjectiveObjLst_Cache.filter(x => x.topicObjectiveId == strTopicObjectiveId);
            let objTopicObjective;
            if (arrTopicObjective_Sel.length > 0) {
                objTopicObjective = arrTopicObjective_Sel[0];
                return objTopicObjective;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objTopicObjective_Const = await TopicObjective_GetObjByTopicObjectiveIdAsync(strTopicObjectiveId);
                    if (objTopicObjective_Const != null) {
                        TopicObjective_ReFreshThisCache(strid_CurrEduCls);
                        return objTopicObjective_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicObjectiveId, exports.topicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.TopicObjective_GetObjByTopicObjectiveId_Cache = TopicObjective_GetObjByTopicObjectiveId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strTopicObjectiveId:所给的关键字
     * @returns 对象
    */
    async function TopicObjective_GetObjByTopicObjectiveId_localStorage(strTopicObjectiveId) {
        const strThisFuncName = "GetObjByTopicObjectiveId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicObjectiveId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicObjectiveId]不能为空！(In clsTopicObjectiveWApi.GetObjByTopicObjectiveId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicObjectiveId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicObjectiveId]的长度:[{0}]不正确！(clsTopicObjectiveWApi.GetObjByTopicObjectiveId_localStorage)", strTopicObjectiveId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN._CurrTabName, strTopicObjectiveId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objTopicObjective_Cache = JSON.parse(strTempObj);
            return objTopicObjective_Cache;
        }
        try {
            const objTopicObjective = await TopicObjective_GetObjByTopicObjectiveIdAsync(strTopicObjectiveId);
            if (objTopicObjective != null) {
                localStorage.setItem(strKey, JSON.stringify(objTopicObjective));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objTopicObjective;
            }
            return objTopicObjective;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicObjectiveId, exports.topicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.TopicObjective_GetObjByTopicObjectiveId_localStorage = TopicObjective_GetObjByTopicObjectiveId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objTopicObjective:所给的对象
     * @returns 对象
    */
    async function TopicObjective_UpdateObjInLst_Cache(objTopicObjective, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrTopicObjectiveObjLst_Cache.find(x => x.objectiveName == objTopicObjective.objectiveName && x.id_CurrEduCls == objTopicObjective.id_CurrEduCls);
            if (obj != null) {
                objTopicObjective.topicObjectiveId = obj.topicObjectiveId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objTopicObjective);
            }
            else {
                arrTopicObjectiveObjLst_Cache.push(objTopicObjective);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.topicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.TopicObjective_UpdateObjInLst_Cache = TopicObjective_UpdateObjInLst_Cache;
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
    async function TopicObjective_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsTopicObjectiveWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsTopicObjectiveWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TopicObjectiveId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strTopicObjectiveId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objTopicObjective = await TopicObjective_GetObjByTopicObjectiveId_Cache(strTopicObjectiveId, strid_CurrEduCls_C);
        if (objTopicObjective == null)
            return "";
        if (objTopicObjective.GetFldValue(strOutFldName) == null)
            return "";
        return objTopicObjective.GetFldValue(strOutFldName).toString();
    }
    exports.TopicObjective_func = TopicObjective_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TopicObjective_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
    }
    exports.TopicObjective_SortFun_Defa = TopicObjective_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TopicObjective_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.objectiveName == b.objectiveName)
            return a.objectiveContent.localeCompare(b.objectiveContent);
        else
            return a.objectiveName.localeCompare(b.objectiveName);
    }
    exports.TopicObjective_SortFun_Defa_2Fld = TopicObjective_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TopicObjective_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveName:
                    return (a, b) => {
                        if (a.objectiveName == null)
                            return -1;
                        if (b.objectiveName == null)
                            return 1;
                        return a.objectiveName.localeCompare(b.objectiveName);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveContent:
                    return (a, b) => {
                        if (a.objectiveContent == null)
                            return -1;
                        if (b.objectiveContent == null)
                            return 1;
                        return a.objectiveContent.localeCompare(b.objectiveContent);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveType:
                    return (a, b) => {
                        if (a.objectiveType == null)
                            return -1;
                        if (b.objectiveType == null)
                            return 1;
                        return a.objectiveType.localeCompare(b.objectiveType);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_SourceId:
                    return (a, b) => {
                        if (a.sourceId == null)
                            return -1;
                        if (b.sourceId == null)
                            return 1;
                        return a.sourceId.localeCompare(b.sourceId);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Conclusion:
                    return (a, b) => {
                        if (a.conclusion == null)
                            return -1;
                        if (b.conclusion == null)
                            return 1;
                        return a.conclusion.localeCompare(b.conclusion);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_PdfContent:
                    return (a, b) => {
                        if (a.pdfContent == null)
                            return -1;
                        if (b.pdfContent == null)
                            return 1;
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ShareId:
                    return (a, b) => {
                        if (a.shareId == null)
                            return -1;
                        if (b.shareId == null)
                            return 1;
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[TopicObjective]中不存在！(in ${exports.topicObjective_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveName:
                    return (a, b) => {
                        if (b.objectiveName == null)
                            return -1;
                        if (a.objectiveName == null)
                            return 1;
                        return b.objectiveName.localeCompare(a.objectiveName);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveContent:
                    return (a, b) => {
                        if (b.objectiveContent == null)
                            return -1;
                        if (a.objectiveContent == null)
                            return 1;
                        return b.objectiveContent.localeCompare(a.objectiveContent);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveType:
                    return (a, b) => {
                        if (b.objectiveType == null)
                            return -1;
                        if (a.objectiveType == null)
                            return 1;
                        return b.objectiveType.localeCompare(a.objectiveType);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_SourceId:
                    return (a, b) => {
                        if (b.sourceId == null)
                            return -1;
                        if (a.sourceId == null)
                            return 1;
                        return b.sourceId.localeCompare(a.sourceId);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Conclusion:
                    return (a, b) => {
                        if (b.conclusion == null)
                            return -1;
                        if (a.conclusion == null)
                            return 1;
                        return b.conclusion.localeCompare(a.conclusion);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_PdfContent:
                    return (a, b) => {
                        if (b.pdfContent == null)
                            return -1;
                        if (a.pdfContent == null)
                            return 1;
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ShareId:
                    return (a, b) => {
                        if (b.shareId == null)
                            return -1;
                        if (a.shareId == null)
                            return 1;
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[TopicObjective]中不存在！(in ${exports.topicObjective_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.TopicObjective_SortFunByKey = TopicObjective_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function TopicObjective_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TopicObjectiveId:
                return (obj) => {
                    return obj.topicObjectiveId === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveName:
                return (obj) => {
                    return obj.objectiveName === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveContent:
                return (obj) => {
                    return obj.objectiveContent === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveType:
                return (obj) => {
                    return obj.objectiveType === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_SourceId:
                return (obj) => {
                    return obj.sourceId === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Conclusion:
                return (obj) => {
                    return obj.conclusion === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[TopicObjective]中不存在！(in ${exports.topicObjective_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.TopicObjective_FilterFunByKey = TopicObjective_FilterFunByKey;
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
    async function TopicObjective_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsTopicObjectiveWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsTopicObjectiveWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TopicObjectiveId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrTopicObjective = await TopicObjective_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrTopicObjective == null)
            return [];
        let arrTopicObjective_Sel = arrTopicObjective;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrTopicObjective_Sel.length == 0)
            return [];
        return arrTopicObjective_Sel.map(x => x.topicObjectiveId);
    }
    exports.TopicObjective_funcKey = TopicObjective_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function TopicObjective_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetFirstIDAsync = TopicObjective_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function TopicObjective_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetFirstID = TopicObjective_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function TopicObjective_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
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
                const objTopicObjective = TopicObjective_GetObjFromJsonObj(returnObj);
                return objTopicObjective;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetFirstObjAsync = TopicObjective_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicObjective_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrTopicObjectiveExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrTopicObjectiveObjLst_T = TopicObjective_GetObjLstByJSONObjLst(arrTopicObjectiveExObjLst_Cache);
            return arrTopicObjectiveObjLst_T;
        }
        try {
            const arrTopicObjectiveExObjLst = await TopicObjective_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrTopicObjectiveExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTopicObjectiveExObjLst.length);
            console.log(strInfo);
            return arrTopicObjectiveExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.topicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.TopicObjective_GetObjLst_ClientCache = TopicObjective_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicObjective_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrTopicObjectiveExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrTopicObjectiveObjLst_T = TopicObjective_GetObjLstByJSONObjLst(arrTopicObjectiveExObjLst_Cache);
            return arrTopicObjectiveObjLst_T;
        }
        try {
            const arrTopicObjectiveExObjLst = await TopicObjective_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrTopicObjectiveExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTopicObjectiveExObjLst.length);
            console.log(strInfo);
            return arrTopicObjectiveExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.topicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.TopicObjective_GetObjLst_localStorage = TopicObjective_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicObjective_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrTopicObjectiveObjLst_Cache = JSON.parse(strTempObjLst);
            return arrTopicObjectiveObjLst_Cache;
        }
        else
            return null;
    }
    exports.TopicObjective_GetObjLst_localStorage_PureCache = TopicObjective_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function TopicObjective_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjective_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjective_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetObjLstAsync = TopicObjective_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicObjective_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrTopicObjectiveExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrTopicObjectiveObjLst_T = TopicObjective_GetObjLstByJSONObjLst(arrTopicObjectiveExObjLst_Cache);
            return arrTopicObjectiveObjLst_T;
        }
        try {
            const arrTopicObjectiveExObjLst = await TopicObjective_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrTopicObjectiveExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTopicObjectiveExObjLst.length);
            console.log(strInfo);
            return arrTopicObjectiveExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.topicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.TopicObjective_GetObjLst_sessionStorage = TopicObjective_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicObjective_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrTopicObjectiveObjLst_Cache = JSON.parse(strTempObjLst);
            return arrTopicObjectiveObjLst_Cache;
        }
        else
            return null;
    }
    exports.TopicObjective_GetObjLst_sessionStorage_PureCache = TopicObjective_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicObjective_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsTopicObjectiveWApi.TopicObjective_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsTopicObjectiveWApi.TopicObjective_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrTopicObjectiveObjLst_Cache;
        switch (clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.CacheModeId) {
            case "04": //sessionStorage
                arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrTopicObjectiveObjLst = TopicObjective_GetObjLstByJSONObjLst(arrTopicObjectiveObjLst_Cache);
        return arrTopicObjectiveObjLst_Cache;
    }
    exports.TopicObjective_GetObjLst_Cache = TopicObjective_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicObjective_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrTopicObjectiveObjLst_Cache;
        switch (clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.CacheModeId) {
            case "04": //sessionStorage
                arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrTopicObjectiveObjLst_Cache = null;
                break;
            default:
                arrTopicObjectiveObjLst_Cache = null;
                break;
        }
        return arrTopicObjectiveObjLst_Cache;
    }
    exports.TopicObjective_GetObjLst_PureCache = TopicObjective_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrTopicObjectiveId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function TopicObjective_GetSubObjLst_Cache(objTopicObjective_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_Cache(strid_CurrEduCls);
        let arrTopicObjective_Sel = arrTopicObjectiveObjLst_Cache;
        if (objTopicObjective_Cond.sf_FldComparisonOp == null || objTopicObjective_Cond.sf_FldComparisonOp == "")
            return arrTopicObjective_Sel;
        const dicFldComparisonOp = JSON.parse(objTopicObjective_Cond.sf_FldComparisonOp);
        //console.log("clsTopicObjectiveWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objTopicObjective_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objTopicObjective_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrTopicObjective_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objTopicObjective_Cond), exports.topicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.TopicObjective_GetSubObjLst_Cache = TopicObjective_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrTopicObjectiveId:关键字列表
    * @returns 对象列表
    **/
    async function TopicObjective_GetObjLstByTopicObjectiveIdLstAsync(arrTopicObjectiveId) {
        const strThisFuncName = "GetObjLstByTopicObjectiveIdLstAsync";
        const strAction = "GetObjLstByTopicObjectiveIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicObjectiveId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjective_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjective_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetObjLstByTopicObjectiveIdLstAsync = TopicObjective_GetObjLstByTopicObjectiveIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrTopicObjectiveIdLst:关键字列表
     * @returns 对象列表
    */
    async function TopicObjective_GetObjLstByTopicObjectiveIdLst_Cache(arrTopicObjectiveIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByTopicObjectiveIdLst_Cache";
        try {
            const arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_Cache(strid_CurrEduCls);
            const arrTopicObjective_Sel = arrTopicObjectiveObjLst_Cache.filter(x => arrTopicObjectiveIdLst.indexOf(x.topicObjectiveId) > -1);
            return arrTopicObjective_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTopicObjectiveIdLst.join(","), exports.topicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.TopicObjective_GetObjLstByTopicObjectiveIdLst_Cache = TopicObjective_GetObjLstByTopicObjectiveIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function TopicObjective_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjective_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjective_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetTopObjLstAsync = TopicObjective_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function TopicObjective_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjective_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjective_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetObjLstByRangeAsync = TopicObjective_GetObjLstByRangeAsync;
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
    async function TopicObjective_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetObjLstByRange = TopicObjective_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function TopicObjective_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_Cache(strid_CurrEduCls);
        if (arrTopicObjectiveObjLst_Cache.length == 0)
            return arrTopicObjectiveObjLst_Cache;
        let arrTopicObjective_Sel = arrTopicObjectiveObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objTopicObjective_Cond = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objTopicObjective_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsTopicObjectiveWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objTopicObjective_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrTopicObjective_Sel.length == 0)
                return arrTopicObjective_Sel;
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
                arrTopicObjective_Sel = arrTopicObjective_Sel.sort(TopicObjective_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrTopicObjective_Sel = arrTopicObjective_Sel.sort(objPagerPara.sortFun);
            }
            arrTopicObjective_Sel = arrTopicObjective_Sel.slice(intStart, intEnd);
            return arrTopicObjective_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.topicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.TopicObjective_GetObjLstByPager_Cache = TopicObjective_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function TopicObjective_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicObjective_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicObjective_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetObjLstByPagerAsync = TopicObjective_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strTopicObjectiveId:关键字
    * @returns 获取删除的结果
    **/
    async function TopicObjective_DelRecordAsync(strTopicObjectiveId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strTopicObjectiveId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_DelRecordAsync = TopicObjective_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrTopicObjectiveId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function TopicObjective_DelTopicObjectivesAsync(arrTopicObjectiveId) {
        const strThisFuncName = "DelTopicObjectivesAsync";
        const strAction = "DelTopicObjectives";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicObjectiveId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_DelTopicObjectivesAsync = TopicObjective_DelTopicObjectivesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function TopicObjective_DelTopicObjectivesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelTopicObjectivesByCondAsync";
        const strAction = "DelTopicObjectivesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_DelTopicObjectivesByCondAsync = TopicObjective_DelTopicObjectivesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objTopicObjectiveEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function TopicObjective_AddNewRecordAsync(objTopicObjectiveEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objTopicObjectiveEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_AddNewRecordAsync = TopicObjective_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objTopicObjectiveEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function TopicObjective_AddNewRecordWithMaxIdAsync(objTopicObjectiveEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_AddNewRecordWithMaxIdAsync = TopicObjective_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objTopicObjectiveEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function TopicObjective_AddNewRecordWithReturnKeyAsync(objTopicObjectiveEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_AddNewRecordWithReturnKeyAsync = TopicObjective_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objTopicObjectiveEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function TopicObjective_AddNewRecordWithReturnKey(objTopicObjectiveEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objTopicObjectiveEN.topicObjectiveId === null || objTopicObjectiveEN.topicObjectiveId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_AddNewRecordWithReturnKey = TopicObjective_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objTopicObjectiveEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function TopicObjective_UpdateRecordAsync(objTopicObjectiveEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objTopicObjectiveEN.sf_UpdFldSetStr === undefined || objTopicObjectiveEN.sf_UpdFldSetStr === null || objTopicObjectiveEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicObjectiveEN.topicObjectiveId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_UpdateRecordAsync = TopicObjective_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objTopicObjectiveEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function TopicObjective_UpdateWithConditionAsync(objTopicObjectiveEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objTopicObjectiveEN.sf_UpdFldSetStr === undefined || objTopicObjectiveEN.sf_UpdFldSetStr === null || objTopicObjectiveEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicObjectiveEN.topicObjectiveId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
        objTopicObjectiveEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objTopicObjectiveEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_UpdateWithConditionAsync = TopicObjective_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrTopicObjectiveId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function TopicObjective_IsExistRecord_Cache(objTopicObjective_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_Cache(strid_CurrEduCls);
        if (arrTopicObjectiveObjLst_Cache == null)
            return false;
        let arrTopicObjective_Sel = arrTopicObjectiveObjLst_Cache;
        if (objTopicObjective_Cond.sf_FldComparisonOp == null || objTopicObjective_Cond.sf_FldComparisonOp == "")
            return arrTopicObjective_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objTopicObjective_Cond.sf_FldComparisonOp);
        //console.log("clsTopicObjectiveWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objTopicObjective_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objTopicObjective_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrTopicObjective_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objTopicObjective_Cond), exports.topicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.TopicObjective_IsExistRecord_Cache = TopicObjective_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function TopicObjective_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_IsExistRecordAsync = TopicObjective_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strTopicObjectiveId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function TopicObjective_IsExist(strTopicObjectiveId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_IsExist = TopicObjective_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strTopicObjectiveId:所给的关键字
     * @returns 对象
    */
    async function TopicObjective_IsExist_Cache(strTopicObjectiveId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_Cache(strid_CurrEduCls);
        if (arrTopicObjectiveObjLst_Cache == null)
            return false;
        try {
            const arrTopicObjective_Sel = arrTopicObjectiveObjLst_Cache.filter(x => x.topicObjectiveId == strTopicObjectiveId);
            if (arrTopicObjective_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTopicObjectiveId, exports.topicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.TopicObjective_IsExist_Cache = TopicObjective_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strTopicObjectiveId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function TopicObjective_IsExistAsync(strTopicObjectiveId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_IsExistAsync = TopicObjective_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function TopicObjective_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetRecCountByCondAsync = TopicObjective_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objTopicObjective_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function TopicObjective_GetRecCountByCond_Cache(objTopicObjective_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrTopicObjectiveObjLst_Cache = await TopicObjective_GetObjLst_Cache(strid_CurrEduCls);
        if (arrTopicObjectiveObjLst_Cache == null)
            return 0;
        let arrTopicObjective_Sel = arrTopicObjectiveObjLst_Cache;
        if (objTopicObjective_Cond.sf_FldComparisonOp == null || objTopicObjective_Cond.sf_FldComparisonOp == "")
            return arrTopicObjective_Sel.length;
        const dicFldComparisonOp = JSON.parse(objTopicObjective_Cond.sf_FldComparisonOp);
        //console.log("clsTopicObjectiveWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objTopicObjective_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objTopicObjective_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrTopicObjective_Sel = arrTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrTopicObjective_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objTopicObjective_Cond), exports.topicObjective_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.TopicObjective_GetRecCountByCond_Cache = TopicObjective_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function TopicObjective_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetMaxStrIdAsync = TopicObjective_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function TopicObjective_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicObjective_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicObjective_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicObjective_GetMaxStrIdByPrefix = TopicObjective_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function TopicObjective_GetWebApiUrl(strController, strAction) {
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
    exports.TopicObjective_GetWebApiUrl = TopicObjective_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function TopicObjective_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsTopicObjectiveWApi.clsTopicObjectiveWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsTopicObjectiveWApi.clsTopicObjectiveWApi.ReFreshCache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
        switch (clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.CacheModeId) {
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
        (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.TopicObjective_ReFreshCache = TopicObjective_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function TopicObjective_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN._CurrTabName, strid_CurrEduCls);
            switch (clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.CacheModeId) {
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
            const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_2.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.TopicObjective_ReFreshThisCache = TopicObjective_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function TopicObjective_CheckPropertyNew(pobjTopicObjectiveEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.topicObjectiveId) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.topicObjectiveId) > 8) {
            throw new Error("(errid:Watl000059)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.topicObjectiveId)(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.objectiveName) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.objectiveName) > 500) {
            throw new Error("(errid:Watl000059)字段[客观名称(objectiveName)]的长度不能超过500(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.objectiveName)(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.objectiveType) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.objectiveType) > 2) {
            throw new Error("(errid:Watl000059)字段[客观类型(objectiveType)]的长度不能超过2(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.objectiveType)(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.sourceId) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.sourceId) > 10) {
            throw new Error("(errid:Watl000059)字段[来源Id(sourceId)]的长度不能超过10(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.sourceId)(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.id_CurrEduCls)(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.pdfContent)(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.createDate) > 20) {
            throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.createDate)(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.shareId) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.shareId) > 2) {
            throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.shareId)(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.updUser)(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.updDate)(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.memo)(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.topicObjectiveId) == false && undefined !== pobjTopicObjectiveEN.topicObjectiveId && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.topicObjectiveId) === false) {
            throw new Error("(errid:Watl000060)字段[客观Id(topicObjectiveId)]的值:[$(pobjTopicObjectiveEN.topicObjectiveId)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.objectiveName) == false && undefined !== pobjTopicObjectiveEN.objectiveName && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.objectiveName) === false) {
            throw new Error("(errid:Watl000060)字段[客观名称(objectiveName)]的值:[$(pobjTopicObjectiveEN.objectiveName)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.objectiveContent) == false && undefined !== pobjTopicObjectiveEN.objectiveContent && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.objectiveContent) === false) {
            throw new Error("(errid:Watl000060)字段[客观内容(objectiveContent)]的值:[$(pobjTopicObjectiveEN.objectiveContent)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.objectiveType) == false && undefined !== pobjTopicObjectiveEN.objectiveType && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.objectiveType) === false) {
            throw new Error("(errid:Watl000060)字段[客观类型(objectiveType)]的值:[$(pobjTopicObjectiveEN.objectiveType)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.sourceId) == false && undefined !== pobjTopicObjectiveEN.sourceId && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.sourceId) === false) {
            throw new Error("(errid:Watl000060)字段[来源Id(sourceId)]的值:[$(pobjTopicObjectiveEN.sourceId)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.conclusion) == false && undefined !== pobjTopicObjectiveEN.conclusion && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.conclusion) === false) {
            throw new Error("(errid:Watl000060)字段[结论(conclusion)]的值:[$(pobjTopicObjectiveEN.conclusion)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if (null != pobjTopicObjectiveEN.isSubmit && undefined !== pobjTopicObjectiveEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjTopicObjectiveEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjTopicObjectiveEN.isSubmit)], 非法，应该为布尔型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if (null != pobjTopicObjectiveEN.appraiseCount && undefined !== pobjTopicObjectiveEN.appraiseCount && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000060)字段[评论数(appraiseCount)]的值:[$(pobjTopicObjectiveEN.appraiseCount)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if (null != pobjTopicObjectiveEN.okCount && undefined !== pobjTopicObjectiveEN.okCount && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.okCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjTopicObjectiveEN.okCount)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if (null != pobjTopicObjectiveEN.score && undefined !== pobjTopicObjectiveEN.score && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjTopicObjectiveEN.score)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if (null != pobjTopicObjectiveEN.stuScore && undefined !== pobjTopicObjectiveEN.stuScore && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.stuScore) === false) {
            throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjTopicObjectiveEN.stuScore)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if (null != pobjTopicObjectiveEN.teaScore && undefined !== pobjTopicObjectiveEN.teaScore && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.teaScore) === false) {
            throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjTopicObjectiveEN.teaScore)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.id_CurrEduCls) == false && undefined !== pobjTopicObjectiveEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjTopicObjectiveEN.id_CurrEduCls)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.pdfContent) == false && undefined !== pobjTopicObjectiveEN.pdfContent && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.pdfContent) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjTopicObjectiveEN.pdfContent)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if (null != pobjTopicObjectiveEN.pdfPageNum && undefined !== pobjTopicObjectiveEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjTopicObjectiveEN.pdfPageNum)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if (null != pobjTopicObjectiveEN.citationCount && undefined !== pobjTopicObjectiveEN.citationCount && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.citationCount) === false) {
            throw new Error("(errid:Watl000060)字段[引用统计(citationCount)]的值:[$(pobjTopicObjectiveEN.citationCount)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if (null != pobjTopicObjectiveEN.versionCount && undefined !== pobjTopicObjectiveEN.versionCount && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.versionCount) === false) {
            throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjTopicObjectiveEN.versionCount)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.createDate) == false && undefined !== pobjTopicObjectiveEN.createDate && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.createDate) === false) {
            throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjTopicObjectiveEN.createDate)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.shareId) == false && undefined !== pobjTopicObjectiveEN.shareId && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.shareId) === false) {
            throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjTopicObjectiveEN.shareId)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.updUser) == false && undefined !== pobjTopicObjectiveEN.updUser && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjTopicObjectiveEN.updUser)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.updDate) == false && undefined !== pobjTopicObjectiveEN.updDate && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjTopicObjectiveEN.updDate)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.memo) == false && undefined !== pobjTopicObjectiveEN.memo && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjTopicObjectiveEN.memo)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjTopicObjectiveEN.SetIsCheckProperty(true);
    }
    exports.TopicObjective_CheckPropertyNew = TopicObjective_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function TopicObjective_CheckProperty4Update(pobjTopicObjectiveEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.topicObjectiveId) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.topicObjectiveId) > 8) {
            throw new Error("(errid:Watl000062)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.topicObjectiveId)(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.objectiveName) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.objectiveName) > 500) {
            throw new Error("(errid:Watl000062)字段[客观名称(objectiveName)]的长度不能超过500(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.objectiveName)(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.objectiveType) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.objectiveType) > 2) {
            throw new Error("(errid:Watl000062)字段[客观类型(objectiveType)]的长度不能超过2(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.objectiveType)(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.sourceId) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.sourceId) > 10) {
            throw new Error("(errid:Watl000062)字段[来源Id(sourceId)]的长度不能超过10(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.sourceId)(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.id_CurrEduCls)(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.pdfContent)(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.createDate) > 20) {
            throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.createDate)(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.shareId) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.shareId) > 2) {
            throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.shareId)(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.updUser)(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.updDate)(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjTopicObjectiveEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题客观表(TopicObjective))!值:$(pobjTopicObjectiveEN.memo)(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.topicObjectiveId) == false && undefined !== pobjTopicObjectiveEN.topicObjectiveId && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.topicObjectiveId) === false) {
            throw new Error("(errid:Watl000063)字段[客观Id(topicObjectiveId)]的值:[$(pobjTopicObjectiveEN.topicObjectiveId)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.objectiveName) == false && undefined !== pobjTopicObjectiveEN.objectiveName && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.objectiveName) === false) {
            throw new Error("(errid:Watl000063)字段[客观名称(objectiveName)]的值:[$(pobjTopicObjectiveEN.objectiveName)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.objectiveContent) == false && undefined !== pobjTopicObjectiveEN.objectiveContent && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.objectiveContent) === false) {
            throw new Error("(errid:Watl000063)字段[客观内容(objectiveContent)]的值:[$(pobjTopicObjectiveEN.objectiveContent)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.objectiveType) == false && undefined !== pobjTopicObjectiveEN.objectiveType && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.objectiveType) === false) {
            throw new Error("(errid:Watl000063)字段[客观类型(objectiveType)]的值:[$(pobjTopicObjectiveEN.objectiveType)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.sourceId) == false && undefined !== pobjTopicObjectiveEN.sourceId && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.sourceId) === false) {
            throw new Error("(errid:Watl000063)字段[来源Id(sourceId)]的值:[$(pobjTopicObjectiveEN.sourceId)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.conclusion) == false && undefined !== pobjTopicObjectiveEN.conclusion && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.conclusion) === false) {
            throw new Error("(errid:Watl000063)字段[结论(conclusion)]的值:[$(pobjTopicObjectiveEN.conclusion)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if (null != pobjTopicObjectiveEN.isSubmit && undefined !== pobjTopicObjectiveEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjTopicObjectiveEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjTopicObjectiveEN.isSubmit)], 非法，应该为布尔型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if (null != pobjTopicObjectiveEN.appraiseCount && undefined !== pobjTopicObjectiveEN.appraiseCount && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000063)字段[评论数(appraiseCount)]的值:[$(pobjTopicObjectiveEN.appraiseCount)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if (null != pobjTopicObjectiveEN.okCount && undefined !== pobjTopicObjectiveEN.okCount && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.okCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjTopicObjectiveEN.okCount)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if (null != pobjTopicObjectiveEN.score && undefined !== pobjTopicObjectiveEN.score && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjTopicObjectiveEN.score)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if (null != pobjTopicObjectiveEN.stuScore && undefined !== pobjTopicObjectiveEN.stuScore && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.stuScore) === false) {
            throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjTopicObjectiveEN.stuScore)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if (null != pobjTopicObjectiveEN.teaScore && undefined !== pobjTopicObjectiveEN.teaScore && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.teaScore) === false) {
            throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjTopicObjectiveEN.teaScore)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.id_CurrEduCls) == false && undefined !== pobjTopicObjectiveEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjTopicObjectiveEN.id_CurrEduCls)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.pdfContent) == false && undefined !== pobjTopicObjectiveEN.pdfContent && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.pdfContent) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjTopicObjectiveEN.pdfContent)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if (null != pobjTopicObjectiveEN.pdfPageNum && undefined !== pobjTopicObjectiveEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjTopicObjectiveEN.pdfPageNum)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if (null != pobjTopicObjectiveEN.citationCount && undefined !== pobjTopicObjectiveEN.citationCount && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.citationCount) === false) {
            throw new Error("(errid:Watl000063)字段[引用统计(citationCount)]的值:[$(pobjTopicObjectiveEN.citationCount)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if (null != pobjTopicObjectiveEN.versionCount && undefined !== pobjTopicObjectiveEN.versionCount && clsString_js_1.tzDataType.isNumber(pobjTopicObjectiveEN.versionCount) === false) {
            throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjTopicObjectiveEN.versionCount)], 非法，应该为数值型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.createDate) == false && undefined !== pobjTopicObjectiveEN.createDate && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.createDate) === false) {
            throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjTopicObjectiveEN.createDate)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.shareId) == false && undefined !== pobjTopicObjectiveEN.shareId && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.shareId) === false) {
            throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjTopicObjectiveEN.shareId)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.updUser) == false && undefined !== pobjTopicObjectiveEN.updUser && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjTopicObjectiveEN.updUser)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.updDate) == false && undefined !== pobjTopicObjectiveEN.updDate && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjTopicObjectiveEN.updDate)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.memo) == false && undefined !== pobjTopicObjectiveEN.memo && clsString_js_1.tzDataType.isString(pobjTopicObjectiveEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjTopicObjectiveEN.memo)], 非法，应该为字符型(In 主题客观表(TopicObjective))!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjTopicObjectiveEN.topicObjectiveId) === true) {
            throw new Error("(errid:Watl000064)字段[客观Id]不能为空(In 主题客观表)!(clsTopicObjectiveBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjTopicObjectiveEN.SetIsCheckProperty(true);
    }
    exports.TopicObjective_CheckProperty4Update = TopicObjective_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function TopicObjective_GetJSONStrByObj(pobjTopicObjectiveEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjTopicObjectiveEN.sf_UpdFldSetStr = pobjTopicObjectiveEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjTopicObjectiveEN);
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
    exports.TopicObjective_GetJSONStrByObj = TopicObjective_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function TopicObjective_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrTopicObjectiveObjLst = new Array();
        if (strJSON === "") {
            return arrTopicObjectiveObjLst;
        }
        try {
            arrTopicObjectiveObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrTopicObjectiveObjLst;
        }
        return arrTopicObjectiveObjLst;
    }
    exports.TopicObjective_GetObjLstByJSONStr = TopicObjective_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrTopicObjectiveObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function TopicObjective_GetObjLstByJSONObjLst(arrTopicObjectiveObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrTopicObjectiveObjLst = new Array();
        for (const objInFor of arrTopicObjectiveObjLstS) {
            const obj1 = TopicObjective_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrTopicObjectiveObjLst.push(obj1);
        }
        return arrTopicObjectiveObjLst;
    }
    exports.TopicObjective_GetObjLstByJSONObjLst = TopicObjective_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function TopicObjective_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
        if (strJSON === "") {
            return pobjTopicObjectiveEN;
        }
        try {
            pobjTopicObjectiveEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjTopicObjectiveEN;
        }
        return pobjTopicObjectiveEN;
    }
    exports.TopicObjective_GetObjByJSONStr = TopicObjective_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function TopicObjective_GetCombineCondition(objTopicObjective_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TopicObjectiveId) == true) {
            const strComparisonOp_TopicObjectiveId = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TopicObjectiveId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TopicObjectiveId, objTopicObjective_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveName) == true) {
            const strComparisonOp_ObjectiveName = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveName, objTopicObjective_Cond.objectiveName, strComparisonOp_ObjectiveName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveType) == true) {
            const strComparisonOp_ObjectiveType = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveType, objTopicObjective_Cond.objectiveType, strComparisonOp_ObjectiveType);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_SourceId) == true) {
            const strComparisonOp_SourceId = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_SourceId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_SourceId, objTopicObjective_Cond.sourceId, strComparisonOp_SourceId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_IsSubmit) == true) {
            if (objTopicObjective_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_AppraiseCount, objTopicObjective_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_OkCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_OkCount, objTopicObjective_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Score) == true) {
            const strComparisonOp_Score = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Score];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Score, objTopicObjective_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_StuScore];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_StuScore, objTopicObjective_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TeaScore];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_TeaScore, objTopicObjective_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_id_CurrEduCls, objTopicObjective_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_PdfContent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_PdfContent, objTopicObjective_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_PdfPageNum, objTopicObjective_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_CitationCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_CitationCount, objTopicObjective_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_VersionCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_VersionCount, objTopicObjective_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_CreateDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_CreateDate, objTopicObjective_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ShareId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ShareId, objTopicObjective_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_UpdUser, objTopicObjective_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_UpdDate, objTopicObjective_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicObjective_Cond.dicFldComparisonOp, clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Memo) == true) {
            const strComparisonOp_Memo = objTopicObjective_Cond.dicFldComparisonOp[clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_Memo, objTopicObjective_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.TopicObjective_GetCombineCondition = TopicObjective_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--TopicObjective(主题客观表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strObjectiveName: 客观名称(要求唯一的字段)
    * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function TopicObjective_GetUniCondStr_ObjectiveName_id_CurrEduCls(objTopicObjectiveEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ObjectiveName = '{0}'", objTopicObjectiveEN.objectiveName);
        strWhereCond += (0, clsString_js_2.Format)(" and id_CurrEduCls = '{0}'", objTopicObjectiveEN.id_CurrEduCls);
        return strWhereCond;
    }
    exports.TopicObjective_GetUniCondStr_ObjectiveName_id_CurrEduCls = TopicObjective_GetUniCondStr_ObjectiveName_id_CurrEduCls;
    /**
    *获取唯一性条件串(Uniqueness)--TopicObjective(主题客观表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strObjectiveName: 客观名称(要求唯一的字段)
    * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function TopicObjective_GetUniCondStr4Update_ObjectiveName_id_CurrEduCls(objTopicObjectiveEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and TopicObjectiveId <> '{0}'", objTopicObjectiveEN.topicObjectiveId);
        strWhereCond += (0, clsString_js_2.Format)(" and ObjectiveName = '{0}'", objTopicObjectiveEN.objectiveName);
        strWhereCond += (0, clsString_js_2.Format)(" and id_CurrEduCls = '{0}'", objTopicObjectiveEN.id_CurrEduCls);
        return strWhereCond;
    }
    exports.TopicObjective_GetUniCondStr4Update_ObjectiveName_id_CurrEduCls = TopicObjective_GetUniCondStr4Update_ObjectiveName_id_CurrEduCls;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objTopicObjectiveENS:源对象
     * @param objTopicObjectiveENT:目标对象
    */
    function TopicObjective_CopyObjTo(objTopicObjectiveENS, objTopicObjectiveENT) {
        objTopicObjectiveENT.topicObjectiveId = objTopicObjectiveENS.topicObjectiveId; //客观Id
        objTopicObjectiveENT.objectiveName = objTopicObjectiveENS.objectiveName; //客观名称
        objTopicObjectiveENT.objectiveContent = objTopicObjectiveENS.objectiveContent; //客观内容
        objTopicObjectiveENT.objectiveType = objTopicObjectiveENS.objectiveType; //客观类型
        objTopicObjectiveENT.sourceId = objTopicObjectiveENS.sourceId; //来源Id
        objTopicObjectiveENT.conclusion = objTopicObjectiveENS.conclusion; //结论
        objTopicObjectiveENT.isSubmit = objTopicObjectiveENS.isSubmit; //是否提交
        objTopicObjectiveENT.appraiseCount = objTopicObjectiveENS.appraiseCount; //评论数
        objTopicObjectiveENT.okCount = objTopicObjectiveENS.okCount; //点赞统计
        objTopicObjectiveENT.score = objTopicObjectiveENS.score; //评分
        objTopicObjectiveENT.stuScore = objTopicObjectiveENS.stuScore; //学生平均分
        objTopicObjectiveENT.teaScore = objTopicObjectiveENS.teaScore; //教师评分
        objTopicObjectiveENT.id_CurrEduCls = objTopicObjectiveENS.id_CurrEduCls; //教学班流水号
        objTopicObjectiveENT.pdfContent = objTopicObjectiveENS.pdfContent; //Pdf内容
        objTopicObjectiveENT.pdfPageNum = objTopicObjectiveENS.pdfPageNum; //Pdf页码
        objTopicObjectiveENT.citationCount = objTopicObjectiveENS.citationCount; //引用统计
        objTopicObjectiveENT.versionCount = objTopicObjectiveENS.versionCount; //版本统计
        objTopicObjectiveENT.createDate = objTopicObjectiveENS.createDate; //建立日期
        objTopicObjectiveENT.shareId = objTopicObjectiveENS.shareId; //分享Id
        objTopicObjectiveENT.updUser = objTopicObjectiveENS.updUser; //修改人
        objTopicObjectiveENT.updDate = objTopicObjectiveENS.updDate; //修改日期
        objTopicObjectiveENT.memo = objTopicObjectiveENS.memo; //备注
        objTopicObjectiveENT.sf_UpdFldSetStr = objTopicObjectiveENS.updFldString; //sf_UpdFldSetStr
    }
    exports.TopicObjective_CopyObjTo = TopicObjective_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objTopicObjectiveENS:源对象
     * @param objTopicObjectiveENT:目标对象
    */
    function TopicObjective_GetObjFromJsonObj(objTopicObjectiveENS) {
        const objTopicObjectiveENT = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objTopicObjectiveENT, objTopicObjectiveENS);
        return objTopicObjectiveENT;
    }
    exports.TopicObjective_GetObjFromJsonObj = TopicObjective_GetObjFromJsonObj;
});
