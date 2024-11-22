/**
* 类名:clsvgs_ResearchResultWApi
* 表名:vgs_ResearchResult(01120778)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:47:01
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvgs_ResearchResultEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_ResearchResult_GetObjFromJsonObj = exports.vgs_ResearchResult_CopyObjTo = exports.vgs_ResearchResult_GetCombineCondition = exports.vgs_ResearchResult_GetObjByJSONStr = exports.vgs_ResearchResult_GetObjLstByJSONObjLst = exports.vgs_ResearchResult_GetObjLstByJSONStr = exports.vgs_ResearchResult_GetJSONStrByObj = exports.vgs_ResearchResult_ReFreshThisCache = exports.vgs_ResearchResult_GetWebApiUrl = exports.vgs_ResearchResult_GetRecCountByCond_Cache = exports.vgs_ResearchResult_GetRecCountByCondAsync = exports.vgs_ResearchResult_IsExistAsync = exports.vgs_ResearchResult_IsExist_Cache = exports.vgs_ResearchResult_IsExist = exports.vgs_ResearchResult_IsExistRecordAsync = exports.vgs_ResearchResult_IsExistRecord_Cache = exports.vgs_ResearchResult_GetObjLstByPagerAsync = exports.vgs_ResearchResult_GetObjLstByPager_Cache = exports.vgs_ResearchResult_GetObjLstByRange = exports.vgs_ResearchResult_GetObjLstByRangeAsync = exports.vgs_ResearchResult_GetTopObjLstAsync = exports.vgs_ResearchResult_GetObjLstByResultIdLst_Cache = exports.vgs_ResearchResult_GetObjLstByResultIdLstAsync = exports.vgs_ResearchResult_GetSubObjLst_Cache = exports.vgs_ResearchResult_GetObjLst_PureCache = exports.vgs_ResearchResult_GetObjLst_Cache = exports.vgs_ResearchResult_GetObjLst_sessionStorage_PureCache = exports.vgs_ResearchResult_GetObjLst_sessionStorage = exports.vgs_ResearchResult_GetObjLstAsync = exports.vgs_ResearchResult_GetObjLst_localStorage_PureCache = exports.vgs_ResearchResult_GetObjLst_localStorage = exports.vgs_ResearchResult_GetObjLst_ClientCache = exports.vgs_ResearchResult_GetFirstObjAsync = exports.vgs_ResearchResult_GetFirstID = exports.vgs_ResearchResult_GetFirstIDAsync = exports.vgs_ResearchResult_funcKey = exports.vgs_ResearchResult_FilterFunByKey = exports.vgs_ResearchResult_SortFunByKey = exports.vgs_ResearchResult_SortFun_Defa_2Fld = exports.vgs_ResearchResult_SortFun_Defa = exports.vgs_ResearchResult_func = exports.vgs_ResearchResult_GetObjByResultId_localStorage = exports.vgs_ResearchResult_GetObjByResultId_Cache = exports.vgs_ResearchResult_GetObjByResultIdAsync = exports.vgs_ResearchResult_ConstructorName = exports.vgs_ResearchResult_Controller = void 0;
    /**
     * 研究成果视图(vgs_ResearchResult)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvgs_ResearchResultEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvgs_ResearchResultEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_ResearchResult_Controller = "vgs_ResearchResultApi";
    exports.vgs_ResearchResult_ConstructorName = "vgs_ResearchResult";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strResultId:关键字
    * @returns 对象
    **/
    async function vgs_ResearchResult_GetObjByResultIdAsync(strResultId) {
        const strThisFuncName = "GetObjByResultIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strResultId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strResultId]不能为空！(In clsvgs_ResearchResultWApi.GetObjByResultIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strResultId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strResultId]的长度:[{0}]不正确！(clsvgs_ResearchResultWApi.GetObjByResultIdAsync)", strResultId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByResultId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strResultId": strResultId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvgs_ResearchResult = vgs_ResearchResult_GetObjFromJsonObj(returnObj);
                return objvgs_ResearchResult;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_GetObjByResultIdAsync = vgs_ResearchResult_GetObjByResultIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strResultId:所给的关键字
     * @returns 对象
    */
    async function vgs_ResearchResult_GetObjByResultId_Cache(strResultId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByResultId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strResultId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strResultId]不能为空！(In clsvgs_ResearchResultWApi.GetObjByResultId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strResultId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strResultId]的长度:[{0}]不正确！(clsvgs_ResearchResultWApi.GetObjByResultId_Cache)", strResultId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
        try {
            const arrvgs_ResearchResult_Sel = arrvgs_ResearchResultObjLst_Cache.filter(x => x.resultId == strResultId);
            let objvgs_ResearchResult;
            if (arrvgs_ResearchResult_Sel.length > 0) {
                objvgs_ResearchResult = arrvgs_ResearchResult_Sel[0];
                return objvgs_ResearchResult;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvgs_ResearchResult_Const = await vgs_ResearchResult_GetObjByResultIdAsync(strResultId);
                    if (objvgs_ResearchResult_Const != null) {
                        vgs_ResearchResult_ReFreshThisCache();
                        return objvgs_ResearchResult_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strResultId, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vgs_ResearchResult_GetObjByResultId_Cache = vgs_ResearchResult_GetObjByResultId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strResultId:所给的关键字
     * @returns 对象
    */
    async function vgs_ResearchResult_GetObjByResultId_localStorage(strResultId) {
        const strThisFuncName = "GetObjByResultId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strResultId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strResultId]不能为空！(In clsvgs_ResearchResultWApi.GetObjByResultId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strResultId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strResultId]的长度:[{0}]不正确！(clsvgs_ResearchResultWApi.GetObjByResultId_localStorage)", strResultId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN._CurrTabName, strResultId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvgs_ResearchResult_Cache = JSON.parse(strTempObj);
            return objvgs_ResearchResult_Cache;
        }
        try {
            const objvgs_ResearchResult = await vgs_ResearchResult_GetObjByResultIdAsync(strResultId);
            if (objvgs_ResearchResult != null) {
                localStorage.setItem(strKey, JSON.stringify(objvgs_ResearchResult));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvgs_ResearchResult;
            }
            return objvgs_ResearchResult;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strResultId, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vgs_ResearchResult_GetObjByResultId_localStorage = vgs_ResearchResult_GetObjByResultId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vgs_ResearchResult_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strResultId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvgs_ResearchResult = await vgs_ResearchResult_GetObjByResultId_Cache(strResultId);
        if (objvgs_ResearchResult == null)
            return "";
        if (objvgs_ResearchResult.GetFldValue(strOutFldName) == null)
            return "";
        return objvgs_ResearchResult.GetFldValue(strOutFldName).toString();
    }
    exports.vgs_ResearchResult_func = vgs_ResearchResult_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_ResearchResult_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.resultId.localeCompare(b.resultId);
    }
    exports.vgs_ResearchResult_SortFun_Defa = vgs_ResearchResult_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_ResearchResult_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.topicName.localeCompare(b.topicName);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.vgs_ResearchResult_SortFun_Defa_2Fld = vgs_ResearchResult_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_ResearchResult_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultId:
                    return (a, b) => {
                        return a.resultId.localeCompare(b.resultId);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TopicName:
                    return (a, b) => {
                        if (a.topicName == null)
                            return -1;
                        if (b.topicName == null)
                            return 1;
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultTypeId:
                    return (a, b) => {
                        if (a.resultTypeId == null)
                            return -1;
                        if (b.resultTypeId == null)
                            return 1;
                        return a.resultTypeId.localeCompare(b.resultTypeId);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultName:
                    return (a, b) => {
                        if (a.resultName == null)
                            return -1;
                        if (b.resultName == null)
                            return 1;
                        return a.resultName.localeCompare(b.resultName);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultContent:
                    return (a, b) => {
                        if (a.resultContent == null)
                            return -1;
                        if (b.resultContent == null)
                            return 1;
                        return a.resultContent.localeCompare(b.resultContent);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Author:
                    return (a, b) => {
                        if (a.author == null)
                            return -1;
                        if (b.author == null)
                            return 1;
                        return a.author.localeCompare(b.author);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Division:
                    return (a, b) => {
                        if (a.division == null)
                            return -1;
                        if (b.division == null)
                            return 1;
                        return a.division.localeCompare(b.division);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_ResearchResult]中不存在！(in ${exports.vgs_ResearchResult_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultId:
                    return (a, b) => {
                        return b.resultId.localeCompare(a.resultId);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TopicName:
                    return (a, b) => {
                        if (b.topicName == null)
                            return -1;
                        if (a.topicName == null)
                            return 1;
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultTypeId:
                    return (a, b) => {
                        if (b.resultTypeId == null)
                            return -1;
                        if (a.resultTypeId == null)
                            return 1;
                        return b.resultTypeId.localeCompare(a.resultTypeId);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultName:
                    return (a, b) => {
                        if (b.resultName == null)
                            return -1;
                        if (a.resultName == null)
                            return 1;
                        return b.resultName.localeCompare(a.resultName);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultContent:
                    return (a, b) => {
                        if (b.resultContent == null)
                            return -1;
                        if (a.resultContent == null)
                            return 1;
                        return b.resultContent.localeCompare(a.resultContent);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Author:
                    return (a, b) => {
                        if (b.author == null)
                            return -1;
                        if (a.author == null)
                            return 1;
                        return b.author.localeCompare(a.author);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Division:
                    return (a, b) => {
                        if (b.division == null)
                            return -1;
                        if (a.division == null)
                            return 1;
                        return b.division.localeCompare(a.division);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_ResearchResult]中不存在！(in ${exports.vgs_ResearchResult_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_ResearchResult_SortFunByKey = vgs_ResearchResult_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_ResearchResult_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultId:
                return (obj) => {
                    return obj.resultId === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultTypeId:
                return (obj) => {
                    return obj.resultTypeId === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultName:
                return (obj) => {
                    return obj.resultName === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultContent:
                return (obj) => {
                    return obj.resultContent === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Division:
                return (obj) => {
                    return obj.division === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_ResearchResult]中不存在！(in ${exports.vgs_ResearchResult_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_ResearchResult_FilterFunByKey = vgs_ResearchResult_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function vgs_ResearchResult_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvgs_ResearchResult = await vgs_ResearchResult_GetObjLst_Cache();
        if (arrvgs_ResearchResult == null)
            return [];
        let arrvgs_ResearchResult_Sel = arrvgs_ResearchResult;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvgs_ResearchResult_Sel.length == 0)
            return [];
        return arrvgs_ResearchResult_Sel.map(x => x.resultId);
    }
    exports.vgs_ResearchResult_funcKey = vgs_ResearchResult_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_ResearchResult_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_GetFirstIDAsync = vgs_ResearchResult_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_ResearchResult_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_GetFirstID = vgs_ResearchResult_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_ResearchResult_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
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
                const objvgs_ResearchResult = vgs_ResearchResult_GetObjFromJsonObj(returnObj);
                return objvgs_ResearchResult;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_GetFirstObjAsync = vgs_ResearchResult_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchResult_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvgs_ResearchResultExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvgs_ResearchResultObjLst_T = vgs_ResearchResult_GetObjLstByJSONObjLst(arrvgs_ResearchResultExObjLst_Cache);
            return arrvgs_ResearchResultObjLst_T;
        }
        try {
            const arrvgs_ResearchResultExObjLst = await vgs_ResearchResult_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvgs_ResearchResultExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_ResearchResultExObjLst.length);
            console.log(strInfo);
            return arrvgs_ResearchResultExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_ResearchResult_GetObjLst_ClientCache = vgs_ResearchResult_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchResult_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_ResearchResultExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_ResearchResultObjLst_T = vgs_ResearchResult_GetObjLstByJSONObjLst(arrvgs_ResearchResultExObjLst_Cache);
            return arrvgs_ResearchResultObjLst_T;
        }
        try {
            const arrvgs_ResearchResultExObjLst = await vgs_ResearchResult_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvgs_ResearchResultExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_ResearchResultExObjLst.length);
            console.log(strInfo);
            return arrvgs_ResearchResultExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_ResearchResult_GetObjLst_localStorage = vgs_ResearchResult_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchResult_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_ResearchResultObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_ResearchResultObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_ResearchResult_GetObjLst_localStorage_PureCache = vgs_ResearchResult_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_ResearchResult_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_GetObjLstAsync = vgs_ResearchResult_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchResult_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_ResearchResultExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_ResearchResultObjLst_T = vgs_ResearchResult_GetObjLstByJSONObjLst(arrvgs_ResearchResultExObjLst_Cache);
            return arrvgs_ResearchResultObjLst_T;
        }
        try {
            const arrvgs_ResearchResultExObjLst = await vgs_ResearchResult_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvgs_ResearchResultExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_ResearchResultExObjLst.length);
            console.log(strInfo);
            return arrvgs_ResearchResultExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_ResearchResult_GetObjLst_sessionStorage = vgs_ResearchResult_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchResult_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_ResearchResultObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_ResearchResultObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_ResearchResult_GetObjLst_sessionStorage_PureCache = vgs_ResearchResult_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchResult_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvgs_ResearchResultObjLst_Cache;
        switch (clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_ClientCache();
                break;
            default:
                arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_ClientCache();
                break;
        }
        const arrvgs_ResearchResultObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst(arrvgs_ResearchResultObjLst_Cache);
        return arrvgs_ResearchResultObjLst_Cache;
    }
    exports.vgs_ResearchResult_GetObjLst_Cache = vgs_ResearchResult_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchResult_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvgs_ResearchResultObjLst_Cache;
        switch (clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvgs_ResearchResultObjLst_Cache = null;
                break;
            default:
                arrvgs_ResearchResultObjLst_Cache = null;
                break;
        }
        return arrvgs_ResearchResultObjLst_Cache;
    }
    exports.vgs_ResearchResult_GetObjLst_PureCache = vgs_ResearchResult_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrResultId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_ResearchResult_GetSubObjLst_Cache(objvgs_ResearchResult_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
        let arrvgs_ResearchResult_Sel = arrvgs_ResearchResultObjLst_Cache;
        if (objvgs_ResearchResult_Cond.sf_FldComparisonOp == null || objvgs_ResearchResult_Cond.sf_FldComparisonOp == "")
            return arrvgs_ResearchResult_Sel;
        const dicFldComparisonOp = JSON.parse(objvgs_ResearchResult_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_ResearchResultWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_ResearchResult_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_ResearchResult_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_ResearchResult_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvgs_ResearchResult_Cond), exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_ResearchResult_GetSubObjLst_Cache = vgs_ResearchResult_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrResultId:关键字列表
    * @returns 对象列表
    **/
    async function vgs_ResearchResult_GetObjLstByResultIdLstAsync(arrResultId) {
        const strThisFuncName = "GetObjLstByResultIdLstAsync";
        const strAction = "GetObjLstByResultIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrResultId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_GetObjLstByResultIdLstAsync = vgs_ResearchResult_GetObjLstByResultIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrResultIdLst:关键字列表
     * @returns 对象列表
    */
    async function vgs_ResearchResult_GetObjLstByResultIdLst_Cache(arrResultIdLst) {
        const strThisFuncName = "GetObjLstByResultIdLst_Cache";
        try {
            const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
            const arrvgs_ResearchResult_Sel = arrvgs_ResearchResultObjLst_Cache.filter(x => arrResultIdLst.indexOf(x.resultId) > -1);
            return arrvgs_ResearchResult_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrResultIdLst.join(","), exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vgs_ResearchResult_GetObjLstByResultIdLst_Cache = vgs_ResearchResult_GetObjLstByResultIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_ResearchResult_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_GetTopObjLstAsync = vgs_ResearchResult_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_ResearchResult_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_GetObjLstByRangeAsync = vgs_ResearchResult_GetObjLstByRangeAsync;
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
    async function vgs_ResearchResult_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_GetObjLstByRange = vgs_ResearchResult_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_ResearchResult_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
        if (arrvgs_ResearchResultObjLst_Cache.length == 0)
            return arrvgs_ResearchResultObjLst_Cache;
        let arrvgs_ResearchResult_Sel = arrvgs_ResearchResultObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvgs_ResearchResult_Cond = new clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_ResearchResult_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvgs_ResearchResultWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_ResearchResult_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_ResearchResult_Sel.length == 0)
                return arrvgs_ResearchResult_Sel;
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
                arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.sort(vgs_ResearchResult_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.slice(intStart, intEnd);
            return arrvgs_ResearchResult_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_ResearchResult_GetObjLstByPager_Cache = vgs_ResearchResult_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_ResearchResult_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_GetObjLstByPagerAsync = vgs_ResearchResult_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrResultId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_ResearchResult_IsExistRecord_Cache(objvgs_ResearchResult_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
        if (arrvgs_ResearchResultObjLst_Cache == null)
            return false;
        let arrvgs_ResearchResult_Sel = arrvgs_ResearchResultObjLst_Cache;
        if (objvgs_ResearchResult_Cond.sf_FldComparisonOp == null || objvgs_ResearchResult_Cond.sf_FldComparisonOp == "")
            return arrvgs_ResearchResult_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvgs_ResearchResult_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_ResearchResultWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_ResearchResult_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_ResearchResult_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_ResearchResult_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvgs_ResearchResult_Cond), exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vgs_ResearchResult_IsExistRecord_Cache = vgs_ResearchResult_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_ResearchResult_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_IsExistRecordAsync = vgs_ResearchResult_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strResultId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_ResearchResult_IsExist(strResultId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ResultId": strResultId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_IsExist = vgs_ResearchResult_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strResultId:所给的关键字
     * @returns 对象
    */
    async function vgs_ResearchResult_IsExist_Cache(strResultId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
        if (arrvgs_ResearchResultObjLst_Cache == null)
            return false;
        try {
            const arrvgs_ResearchResult_Sel = arrvgs_ResearchResultObjLst_Cache.filter(x => x.resultId == strResultId);
            if (arrvgs_ResearchResult_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strResultId, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vgs_ResearchResult_IsExist_Cache = vgs_ResearchResult_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strResultId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_ResearchResult_IsExistAsync(strResultId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strResultId": strResultId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_IsExistAsync = vgs_ResearchResult_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_ResearchResult_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchResult_GetRecCountByCondAsync = vgs_ResearchResult_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvgs_ResearchResult_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vgs_ResearchResult_GetRecCountByCond_Cache(objvgs_ResearchResult_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
        if (arrvgs_ResearchResultObjLst_Cache == null)
            return 0;
        let arrvgs_ResearchResult_Sel = arrvgs_ResearchResultObjLst_Cache;
        if (objvgs_ResearchResult_Cond.sf_FldComparisonOp == null || objvgs_ResearchResult_Cond.sf_FldComparisonOp == "")
            return arrvgs_ResearchResult_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvgs_ResearchResult_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_ResearchResultWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_ResearchResult_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_ResearchResult_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_ResearchResult_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvgs_ResearchResult_Cond), exports.vgs_ResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vgs_ResearchResult_GetRecCountByCond_Cache = vgs_ResearchResult_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_ResearchResult_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_ResearchResult_GetWebApiUrl = vgs_ResearchResult_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vgs_ResearchResult_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN._CurrTabName;
            switch (clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.CacheModeId) {
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
    exports.vgs_ResearchResult_ReFreshThisCache = vgs_ResearchResult_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_ResearchResult_GetJSONStrByObj(pobjvgs_ResearchResultEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_ResearchResultEN);
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
    exports.vgs_ResearchResult_GetJSONStrByObj = vgs_ResearchResult_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_ResearchResult_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_ResearchResultObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_ResearchResultObjLst;
        }
        try {
            arrvgs_ResearchResultObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_ResearchResultObjLst;
        }
        return arrvgs_ResearchResultObjLst;
    }
    exports.vgs_ResearchResult_GetObjLstByJSONStr = vgs_ResearchResult_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_ResearchResultObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_ResearchResult_GetObjLstByJSONObjLst(arrvgs_ResearchResultObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_ResearchResultObjLst = new Array();
        for (const objInFor of arrvgs_ResearchResultObjLstS) {
            const obj1 = vgs_ResearchResult_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_ResearchResultObjLst.push(obj1);
        }
        return arrvgs_ResearchResultObjLst;
    }
    exports.vgs_ResearchResult_GetObjLstByJSONObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_ResearchResult_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_ResearchResultEN = new clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN();
        if (strJSON === "") {
            return pobjvgs_ResearchResultEN;
        }
        try {
            pobjvgs_ResearchResultEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_ResearchResultEN;
        }
        return pobjvgs_ResearchResultEN;
    }
    exports.vgs_ResearchResult_GetObjByJSONStr = vgs_ResearchResult_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_ResearchResult_GetCombineCondition(objvgs_ResearchResult_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultId) == true) {
            const strComparisonOp_ResultId = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultId, objvgs_ResearchResult_Cond.resultId, strComparisonOp_ResultId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TopicId, objvgs_ResearchResult_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TopicName, objvgs_ResearchResult_Cond.topicName, strComparisonOp_TopicName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_PaperId, objvgs_ResearchResult_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_id_CurrEduCls, objvgs_ResearchResult_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultTypeId) == true) {
            const strComparisonOp_ResultTypeId = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultTypeId, objvgs_ResearchResult_Cond.resultTypeId, strComparisonOp_ResultTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultName) == true) {
            const strComparisonOp_ResultName = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultName, objvgs_ResearchResult_Cond.resultName, strComparisonOp_ResultName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Author) == true) {
            const strComparisonOp_Author = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Author, objvgs_ResearchResult_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Division) == true) {
            const strComparisonOp_Division = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Division];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Division, objvgs_ResearchResult_Cond.division, strComparisonOp_Division);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_VersionCount, objvgs_ResearchResult_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_OkCount, objvgs_ResearchResult_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_AppraiseCount, objvgs_ResearchResult_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Score) == true) {
            const strComparisonOp_Score = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Score, objvgs_ResearchResult_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_StuScore, objvgs_ResearchResult_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_TeaScore, objvgs_ResearchResult_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdDate, objvgs_ResearchResult_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdUser, objvgs_ResearchResult_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_Memo, objvgs_ResearchResult_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vgs_ResearchResult_GetCombineCondition = vgs_ResearchResult_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_ResearchResultENS:源对象
     * @param objvgs_ResearchResultENT:目标对象
    */
    function vgs_ResearchResult_CopyObjTo(objvgs_ResearchResultENS, objvgs_ResearchResultENT) {
        objvgs_ResearchResultENT.resultId = objvgs_ResearchResultENS.resultId; //成果Id
        objvgs_ResearchResultENT.topicId = objvgs_ResearchResultENS.topicId; //主题Id
        objvgs_ResearchResultENT.topicName = objvgs_ResearchResultENS.topicName; //栏目主题
        objvgs_ResearchResultENT.paperId = objvgs_ResearchResultENS.paperId; //论文Id
        objvgs_ResearchResultENT.id_CurrEduCls = objvgs_ResearchResultENS.id_CurrEduCls; //教学班流水号
        objvgs_ResearchResultENT.resultTypeId = objvgs_ResearchResultENS.resultTypeId; //成果类型Id
        objvgs_ResearchResultENT.resultName = objvgs_ResearchResultENS.resultName; //成果名称
        objvgs_ResearchResultENT.resultContent = objvgs_ResearchResultENS.resultContent; //成果内容
        objvgs_ResearchResultENT.author = objvgs_ResearchResultENS.author; //作者
        objvgs_ResearchResultENT.division = objvgs_ResearchResultENS.division; //分工
        objvgs_ResearchResultENT.versionCount = objvgs_ResearchResultENS.versionCount; //版本统计
        objvgs_ResearchResultENT.okCount = objvgs_ResearchResultENS.okCount; //点赞统计
        objvgs_ResearchResultENT.appraiseCount = objvgs_ResearchResultENS.appraiseCount; //评论数
        objvgs_ResearchResultENT.score = objvgs_ResearchResultENS.score; //评分
        objvgs_ResearchResultENT.stuScore = objvgs_ResearchResultENS.stuScore; //学生平均分
        objvgs_ResearchResultENT.teaScore = objvgs_ResearchResultENS.teaScore; //教师评分
        objvgs_ResearchResultENT.updDate = objvgs_ResearchResultENS.updDate; //修改日期
        objvgs_ResearchResultENT.updUser = objvgs_ResearchResultENS.updUser; //修改人
        objvgs_ResearchResultENT.memo = objvgs_ResearchResultENS.memo; //备注
    }
    exports.vgs_ResearchResult_CopyObjTo = vgs_ResearchResult_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_ResearchResultENS:源对象
     * @param objvgs_ResearchResultENT:目标对象
    */
    function vgs_ResearchResult_GetObjFromJsonObj(objvgs_ResearchResultENS) {
        const objvgs_ResearchResultENT = new clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_ResearchResultENT, objvgs_ResearchResultENS);
        return objvgs_ResearchResultENT;
    }
    exports.vgs_ResearchResult_GetObjFromJsonObj = vgs_ResearchResult_GetObjFromJsonObj;
});