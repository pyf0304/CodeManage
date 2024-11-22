/**
* 类名:clsgs_KnowledgesLogicRelaWApi
* 表名:gs_KnowledgesLogicRela(01120870)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:01
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:知识点相关(Knowledges)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/Knowledges/clsgs_KnowledgesLogicRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_KnowledgesLogicRela_GetObjFromJsonObj = exports.gs_KnowledgesLogicRela_CopyObjTo = exports.gs_KnowledgesLogicRela_GetUniCondStr4Update_KnowledgeGraphId_CourseKnowledgeIdA_CourseKnowledgeIdB = exports.gs_KnowledgesLogicRela_GetUniCondStr_KnowledgeGraphId_CourseKnowledgeIdA_CourseKnowledgeIdB = exports.gs_KnowledgesLogicRela_GetCombineCondition = exports.gs_KnowledgesLogicRela_GetObjByJSONStr = exports.gs_KnowledgesLogicRela_GetObjLstByJSONObjLst = exports.gs_KnowledgesLogicRela_GetObjLstByJSONStr = exports.gs_KnowledgesLogicRela_GetJSONStrByObj = exports.gs_KnowledgesLogicRela_CheckProperty4Update = exports.gs_KnowledgesLogicRela_CheckPropertyNew = exports.gs_KnowledgesLogicRela_ReFreshThisCache = exports.gs_KnowledgesLogicRela_ReFreshCache = exports.gs_KnowledgesLogicRela_GetWebApiUrl = exports.gs_KnowledgesLogicRela_GetMaxStrIdByPrefix = exports.gs_KnowledgesLogicRela_GetRecCountByCond_Cache = exports.gs_KnowledgesLogicRela_GetRecCountByCondAsync = exports.gs_KnowledgesLogicRela_IsExistAsync = exports.gs_KnowledgesLogicRela_IsExist_Cache = exports.gs_KnowledgesLogicRela_IsExist = exports.gs_KnowledgesLogicRela_IsExistRecordAsync = exports.gs_KnowledgesLogicRela_IsExistRecord_Cache = exports.gs_KnowledgesLogicRela_UpdateWithConditionAsync = exports.gs_KnowledgesLogicRela_UpdateRecordAsync = exports.gs_KnowledgesLogicRela_AddNewRecordWithReturnKey = exports.gs_KnowledgesLogicRela_AddNewRecordWithReturnKeyAsync = exports.gs_KnowledgesLogicRela_AddNewRecordAsync = exports.gs_KnowledgesLogicRela_Delgs_KnowledgesLogicRelasByCondAsync = exports.gs_KnowledgesLogicRela_Delgs_KnowledgesLogicRelasAsync = exports.gs_KnowledgesLogicRela_DelRecordAsync = exports.gs_KnowledgesLogicRela_GetObjLstByPagerAsync = exports.gs_KnowledgesLogicRela_GetObjLstByPager_Cache = exports.gs_KnowledgesLogicRela_GetObjLstByRange = exports.gs_KnowledgesLogicRela_GetObjLstByRangeAsync = exports.gs_KnowledgesLogicRela_GetTopObjLstAsync = exports.gs_KnowledgesLogicRela_GetObjLstBymIdLst_Cache = exports.gs_KnowledgesLogicRela_GetObjLstBymIdLstAsync = exports.gs_KnowledgesLogicRela_GetSubObjLst_Cache = exports.gs_KnowledgesLogicRela_GetObjLst_PureCache = exports.gs_KnowledgesLogicRela_GetObjLst_Cache = exports.gs_KnowledgesLogicRela_GetObjLst_sessionStorage_PureCache = exports.gs_KnowledgesLogicRela_GetObjLst_sessionStorage = exports.gs_KnowledgesLogicRela_GetObjLstAsync = exports.gs_KnowledgesLogicRela_GetObjLst_localStorage_PureCache = exports.gs_KnowledgesLogicRela_GetObjLst_localStorage = exports.gs_KnowledgesLogicRela_GetObjLst_ClientCache = exports.gs_KnowledgesLogicRela_GetFirstObjAsync = exports.gs_KnowledgesLogicRela_GetFirstID = exports.gs_KnowledgesLogicRela_GetFirstIDAsync = exports.gs_KnowledgesLogicRela_FilterFunByKey = exports.gs_KnowledgesLogicRela_SortFunByKey = exports.gs_KnowledgesLogicRela_SortFun_Defa_2Fld = exports.gs_KnowledgesLogicRela_SortFun_Defa = exports.gs_KnowledgesLogicRela_func = exports.gs_KnowledgesLogicRela_UpdateObjInLst_Cache = exports.gs_KnowledgesLogicRela_GetObjBymId_localStorage = exports.gs_KnowledgesLogicRela_GetObjBymId_Cache = exports.gs_KnowledgesLogicRela_GetObjBymIdAsync = exports.gs_KnowledgesLogicRela_ConstructorName = exports.gs_KnowledgesLogicRela_Controller = void 0;
    /**
     * 知识点逻辑关系表(gs_KnowledgesLogicRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_KnowledgesLogicRelaEN_js_1 = require("../../L0_Entity/Knowledges/clsgs_KnowledgesLogicRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_KnowledgesLogicRela_Controller = "gs_KnowledgesLogicRelaApi";
    exports.gs_KnowledgesLogicRela_ConstructorName = "gs_KnowledgesLogicRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function gs_KnowledgesLogicRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngmId": lngmId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_KnowledgesLogicRela = gs_KnowledgesLogicRela_GetObjFromJsonObj(returnObj);
                return objgs_KnowledgesLogicRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_GetObjBymIdAsync = gs_KnowledgesLogicRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_KnowledgesLogicRela_GetObjBymId_Cache(lngmId, strKnowledgeGraphId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_Cache(strKnowledgeGraphId);
        try {
            const arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objgs_KnowledgesLogicRela;
            if (arrgs_KnowledgesLogicRela_Sel.length > 0) {
                objgs_KnowledgesLogicRela = arrgs_KnowledgesLogicRela_Sel[0];
                return objgs_KnowledgesLogicRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objgs_KnowledgesLogicRela = await gs_KnowledgesLogicRela_GetObjBymIdAsync(lngmId);
                    if (objgs_KnowledgesLogicRela != null) {
                        gs_KnowledgesLogicRela_ReFreshThisCache(strKnowledgeGraphId);
                        return objgs_KnowledgesLogicRela;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_KnowledgesLogicRela_GetObjBymId_Cache = gs_KnowledgesLogicRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_KnowledgesLogicRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_KnowledgesLogicRela_Cache = JSON.parse(strTempObj);
            return objgs_KnowledgesLogicRela_Cache;
        }
        try {
            const objgs_KnowledgesLogicRela = await gs_KnowledgesLogicRela_GetObjBymIdAsync(lngmId);
            if (objgs_KnowledgesLogicRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_KnowledgesLogicRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_KnowledgesLogicRela;
            }
            return objgs_KnowledgesLogicRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_KnowledgesLogicRela_GetObjBymId_localStorage = gs_KnowledgesLogicRela_GetObjBymId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_KnowledgesLogicRela:所给的对象
     * @returns 对象
    */
    async function gs_KnowledgesLogicRela_UpdateObjInLst_Cache(objgs_KnowledgesLogicRela, strKnowledgeGraphId) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_Cache(strKnowledgeGraphId);
            const obj = arrgs_KnowledgesLogicRelaObjLst_Cache.find(x => x.knowledgeGraphId == objgs_KnowledgesLogicRela.knowledgeGraphId && x.courseKnowledgeIdA == objgs_KnowledgesLogicRela.courseKnowledgeIdA && x.courseKnowledgeIdB == objgs_KnowledgesLogicRela.courseKnowledgeIdB);
            if (obj != null) {
                objgs_KnowledgesLogicRela.mId = obj.mId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_KnowledgesLogicRela);
            }
            else {
                arrgs_KnowledgesLogicRelaObjLst_Cache.push(objgs_KnowledgesLogicRela);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_KnowledgesLogicRela_UpdateObjInLst_Cache = gs_KnowledgesLogicRela_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strKnowledgeGraphId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function gs_KnowledgesLogicRela_func(strInFldName, strOutFldName, strInValue, strKnowledgeGraphId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strKnowledgeGraphId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strKnowledgeGraphId_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strKnowledgeGraphId_C.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strKnowledgeGraphId_C]的长度:[{0}]不正确！", strKnowledgeGraphId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objgs_KnowledgesLogicRela = await gs_KnowledgesLogicRela_GetObjBymId_Cache(lngmId, strKnowledgeGraphId_C);
        if (objgs_KnowledgesLogicRela == null)
            return "";
        return objgs_KnowledgesLogicRela.GetFldValue(strOutFldName).toString();
    }
    exports.gs_KnowledgesLogicRela_func = gs_KnowledgesLogicRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_KnowledgesLogicRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.gs_KnowledgesLogicRela_SortFun_Defa = gs_KnowledgesLogicRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_KnowledgesLogicRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.courseKnowledgeIdA == b.courseKnowledgeIdA)
            return a.courseKnowledgeTitleA.localeCompare(b.courseKnowledgeTitleA);
        else
            return a.courseKnowledgeIdA.localeCompare(b.courseKnowledgeIdA);
    }
    exports.gs_KnowledgesLogicRela_SortFun_Defa_2Fld = gs_KnowledgesLogicRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_KnowledgesLogicRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdA:
                    return (a, b) => {
                        return a.courseKnowledgeIdA.localeCompare(b.courseKnowledgeIdA);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleA:
                    return (a, b) => {
                        return a.courseKnowledgeTitleA.localeCompare(b.courseKnowledgeTitleA);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdB:
                    return (a, b) => {
                        return a.courseKnowledgeIdB.localeCompare(b.courseKnowledgeIdB);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleB:
                    return (a, b) => {
                        return a.courseKnowledgeTitleB.localeCompare(b.courseKnowledgeTitleB);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_KnowledgeGraphId:
                    return (a, b) => {
                        return a.knowledgeGraphId.localeCompare(b.knowledgeGraphId);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_SourceAnchor:
                    return (a, b) => {
                        return a.sourceAnchor.localeCompare(b.sourceAnchor);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_TargetAnchor:
                    return (a, b) => {
                        return a.targetAnchor.localeCompare(b.targetAnchor);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_RelaTitle:
                    return (a, b) => {
                        return a.relaTitle.localeCompare(b.relaTitle);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_RelaTypeId:
                    return (a, b) => {
                        return a.relaTypeId.localeCompare(b.relaTypeId);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseId:
                    return (a, b) => {
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_KnowledgesLogicRela]中不存在！(in ${exports.gs_KnowledgesLogicRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdA:
                    return (a, b) => {
                        return b.courseKnowledgeIdA.localeCompare(a.courseKnowledgeIdA);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleA:
                    return (a, b) => {
                        return b.courseKnowledgeTitleA.localeCompare(a.courseKnowledgeTitleA);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdB:
                    return (a, b) => {
                        return b.courseKnowledgeIdB.localeCompare(a.courseKnowledgeIdB);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleB:
                    return (a, b) => {
                        return b.courseKnowledgeTitleB.localeCompare(a.courseKnowledgeTitleB);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_KnowledgeGraphId:
                    return (a, b) => {
                        return b.knowledgeGraphId.localeCompare(a.knowledgeGraphId);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_SourceAnchor:
                    return (a, b) => {
                        return b.sourceAnchor.localeCompare(a.sourceAnchor);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_TargetAnchor:
                    return (a, b) => {
                        return b.targetAnchor.localeCompare(a.targetAnchor);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_RelaTitle:
                    return (a, b) => {
                        return b.relaTitle.localeCompare(a.relaTitle);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_RelaTypeId:
                    return (a, b) => {
                        return b.relaTypeId.localeCompare(a.relaTypeId);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseId:
                    return (a, b) => {
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_KnowledgesLogicRela]中不存在！(in ${exports.gs_KnowledgesLogicRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_KnowledgesLogicRela_SortFunByKey = gs_KnowledgesLogicRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_KnowledgesLogicRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdA:
                return (obj) => {
                    return obj.courseKnowledgeIdA === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleA:
                return (obj) => {
                    return obj.courseKnowledgeTitleA === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdB:
                return (obj) => {
                    return obj.courseKnowledgeIdB === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleB:
                return (obj) => {
                    return obj.courseKnowledgeTitleB === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_KnowledgeGraphId:
                return (obj) => {
                    return obj.knowledgeGraphId === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_SourceAnchor:
                return (obj) => {
                    return obj.sourceAnchor === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_TargetAnchor:
                return (obj) => {
                    return obj.targetAnchor === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_RelaTitle:
                return (obj) => {
                    return obj.relaTitle === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_RelaTypeId:
                return (obj) => {
                    return obj.relaTypeId === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_KnowledgesLogicRela]中不存在！(in ${exports.gs_KnowledgesLogicRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_KnowledgesLogicRela_FilterFunByKey = gs_KnowledgesLogicRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_KnowledgesLogicRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_GetFirstIDAsync = gs_KnowledgesLogicRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_KnowledgesLogicRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_GetFirstID = gs_KnowledgesLogicRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_KnowledgesLogicRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_KnowledgesLogicRela = gs_KnowledgesLogicRela_GetObjFromJsonObj(returnObj);
                return objgs_KnowledgesLogicRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_GetFirstObjAsync = gs_KnowledgesLogicRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesLogicRela_GetObjLst_ClientCache(strKnowledgeGraphId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("KnowledgeGraphId='{0}'", strKnowledgeGraphId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN._CurrTabName, strKnowledgeGraphId);
        clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_KnowledgesLogicRelaExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrgs_KnowledgesLogicRelaObjLst_T = gs_KnowledgesLogicRela_GetObjLstByJSONObjLst(arrgs_KnowledgesLogicRelaExObjLst_Cache);
            return arrgs_KnowledgesLogicRelaObjLst_T;
        }
        try {
            const arrgs_KnowledgesLogicRelaExObjLst = await gs_KnowledgesLogicRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrgs_KnowledgesLogicRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_KnowledgesLogicRelaExObjLst.length);
            console.log(strInfo);
            return arrgs_KnowledgesLogicRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_KnowledgesLogicRela_GetObjLst_ClientCache = gs_KnowledgesLogicRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesLogicRela_GetObjLst_localStorage(strKnowledgeGraphId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("KnowledgeGraphId='{0}'", strKnowledgeGraphId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN._CurrTabName, strKnowledgeGraphId);
        clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_KnowledgesLogicRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_KnowledgesLogicRelaObjLst_T = gs_KnowledgesLogicRela_GetObjLstByJSONObjLst(arrgs_KnowledgesLogicRelaExObjLst_Cache);
            return arrgs_KnowledgesLogicRelaObjLst_T;
        }
        try {
            const arrgs_KnowledgesLogicRelaExObjLst = await gs_KnowledgesLogicRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_KnowledgesLogicRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_KnowledgesLogicRelaExObjLst.length);
            console.log(strInfo);
            return arrgs_KnowledgesLogicRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_KnowledgesLogicRela_GetObjLst_localStorage = gs_KnowledgesLogicRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesLogicRela_GetObjLst_localStorage_PureCache(strKnowledgeGraphId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("KnowledgeGraphId='{0}'", strKnowledgeGraphId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN._CurrTabName, strKnowledgeGraphId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_KnowledgesLogicRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_KnowledgesLogicRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_KnowledgesLogicRela_GetObjLst_localStorage_PureCache = gs_KnowledgesLogicRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_KnowledgesLogicRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_KnowledgesLogicRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_GetObjLstAsync = gs_KnowledgesLogicRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesLogicRela_GetObjLst_sessionStorage(strKnowledgeGraphId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("KnowledgeGraphId='{0}'", strKnowledgeGraphId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN._CurrTabName, strKnowledgeGraphId);
        clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_KnowledgesLogicRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_KnowledgesLogicRelaObjLst_T = gs_KnowledgesLogicRela_GetObjLstByJSONObjLst(arrgs_KnowledgesLogicRelaExObjLst_Cache);
            return arrgs_KnowledgesLogicRelaObjLst_T;
        }
        try {
            const arrgs_KnowledgesLogicRelaExObjLst = await gs_KnowledgesLogicRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_KnowledgesLogicRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_KnowledgesLogicRelaExObjLst.length);
            console.log(strInfo);
            return arrgs_KnowledgesLogicRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_KnowledgesLogicRela_GetObjLst_sessionStorage = gs_KnowledgesLogicRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesLogicRela_GetObjLst_sessionStorage_PureCache(strKnowledgeGraphId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("KnowledgeGraphId='{0}'", strKnowledgeGraphId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN._CurrTabName, strKnowledgeGraphId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_KnowledgesLogicRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_KnowledgesLogicRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_KnowledgesLogicRela_GetObjLst_sessionStorage_PureCache = gs_KnowledgesLogicRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesLogicRela_GetObjLst_Cache(strKnowledgeGraphId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strKnowledgeGraphId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[KnowledgeGraphId]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strKnowledgeGraphId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strKnowledgeGraphId]的长度:[{0}]不正确！", strKnowledgeGraphId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrgs_KnowledgesLogicRelaObjLst_Cache;
        switch (clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_sessionStorage(strKnowledgeGraphId);
                break;
            case "03": //localStorage
                arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_localStorage(strKnowledgeGraphId);
                break;
            case "02": //ClientCache
                arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_ClientCache(strKnowledgeGraphId);
                break;
            default:
                arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_ClientCache(strKnowledgeGraphId);
                break;
        }
        const arrgs_KnowledgesLogicRelaObjLst = gs_KnowledgesLogicRela_GetObjLstByJSONObjLst(arrgs_KnowledgesLogicRelaObjLst_Cache);
        return arrgs_KnowledgesLogicRelaObjLst_Cache;
    }
    exports.gs_KnowledgesLogicRela_GetObjLst_Cache = gs_KnowledgesLogicRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesLogicRela_GetObjLst_PureCache(strKnowledgeGraphId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_KnowledgesLogicRelaObjLst_Cache;
        switch (clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_sessionStorage_PureCache(strKnowledgeGraphId);
                break;
            case "03": //localStorage
                arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_localStorage_PureCache(strKnowledgeGraphId);
                break;
            case "02": //ClientCache
                arrgs_KnowledgesLogicRelaObjLst_Cache = null;
                break;
            default:
                arrgs_KnowledgesLogicRelaObjLst_Cache = null;
                break;
        }
        return arrgs_KnowledgesLogicRelaObjLst_Cache;
    }
    exports.gs_KnowledgesLogicRela_GetObjLst_PureCache = gs_KnowledgesLogicRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_KnowledgesLogicRela_GetSubObjLst_Cache(objgs_KnowledgesLogicRela_Cond, strKnowledgeGraphId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_Cache(strKnowledgeGraphId);
        let arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRelaObjLst_Cache;
        if (objgs_KnowledgesLogicRela_Cond.sf_FldComparisonOp == null || objgs_KnowledgesLogicRela_Cond.sf_FldComparisonOp == "")
            return arrgs_KnowledgesLogicRela_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_KnowledgesLogicRela_Cond.sf_FldComparisonOp);
        //console.log("clsgs_KnowledgesLogicRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_KnowledgesLogicRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_KnowledgesLogicRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_KnowledgesLogicRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_KnowledgesLogicRela_Cond), exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_KnowledgesLogicRela_GetSubObjLst_Cache = gs_KnowledgesLogicRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function gs_KnowledgesLogicRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_KnowledgesLogicRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_GetObjLstBymIdLstAsync = gs_KnowledgesLogicRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_KnowledgesLogicRela_GetObjLstBymIdLst_Cache(arrmIdLst, strKnowledgeGraphId) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_Cache(strKnowledgeGraphId);
            const arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrgs_KnowledgesLogicRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_KnowledgesLogicRela_GetObjLstBymIdLst_Cache = gs_KnowledgesLogicRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_KnowledgesLogicRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_KnowledgesLogicRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_GetTopObjLstAsync = gs_KnowledgesLogicRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_KnowledgesLogicRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_KnowledgesLogicRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_GetObjLstByRangeAsync = gs_KnowledgesLogicRela_GetObjLstByRangeAsync;
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
    async function gs_KnowledgesLogicRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_GetObjLstByRange = gs_KnowledgesLogicRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_KnowledgesLogicRela_GetObjLstByPager_Cache(objPagerPara, strKnowledgeGraphId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_Cache(strKnowledgeGraphId);
        if (arrgs_KnowledgesLogicRelaObjLst_Cache.length == 0)
            return arrgs_KnowledgesLogicRelaObjLst_Cache;
        let arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_KnowledgesLogicRela_Cond = new clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_KnowledgesLogicRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_KnowledgesLogicRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_KnowledgesLogicRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_KnowledgesLogicRela_Sel.length == 0)
                return arrgs_KnowledgesLogicRela_Sel;
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
                arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.sort(gs_KnowledgesLogicRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.slice(intStart, intEnd);
            return arrgs_KnowledgesLogicRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_KnowledgesLogicRela_GetObjLstByPager_Cache = gs_KnowledgesLogicRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_KnowledgesLogicRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_KnowledgesLogicRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_GetObjLstByPagerAsync = gs_KnowledgesLogicRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_KnowledgesLogicRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngmId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngmId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_DelRecordAsync = gs_KnowledgesLogicRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_KnowledgesLogicRela_Delgs_KnowledgesLogicRelasAsync(arrmId) {
        const strThisFuncName = "Delgs_KnowledgesLogicRelasAsync";
        const strAction = "Delgs_KnowledgesLogicRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_Delgs_KnowledgesLogicRelasAsync = gs_KnowledgesLogicRela_Delgs_KnowledgesLogicRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_KnowledgesLogicRela_Delgs_KnowledgesLogicRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_KnowledgesLogicRelasByCondAsync";
        const strAction = "Delgs_KnowledgesLogicRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_Delgs_KnowledgesLogicRelasByCondAsync = gs_KnowledgesLogicRela_Delgs_KnowledgesLogicRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_KnowledgesLogicRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_KnowledgesLogicRela_AddNewRecordAsync(objgs_KnowledgesLogicRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_KnowledgesLogicRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_KnowledgesLogicRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_AddNewRecordAsync = gs_KnowledgesLogicRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_KnowledgesLogicRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_KnowledgesLogicRela_AddNewRecordWithReturnKeyAsync(objgs_KnowledgesLogicRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_KnowledgesLogicRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_AddNewRecordWithReturnKeyAsync = gs_KnowledgesLogicRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_KnowledgesLogicRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_KnowledgesLogicRela_AddNewRecordWithReturnKey(objgs_KnowledgesLogicRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_KnowledgesLogicRelaEN.mId === null || objgs_KnowledgesLogicRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_KnowledgesLogicRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_AddNewRecordWithReturnKey = gs_KnowledgesLogicRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_KnowledgesLogicRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_KnowledgesLogicRela_UpdateRecordAsync(objgs_KnowledgesLogicRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_KnowledgesLogicRelaEN.sf_UpdFldSetStr === undefined || objgs_KnowledgesLogicRelaEN.sf_UpdFldSetStr === null || objgs_KnowledgesLogicRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_KnowledgesLogicRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_KnowledgesLogicRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_UpdateRecordAsync = gs_KnowledgesLogicRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_KnowledgesLogicRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_KnowledgesLogicRela_UpdateWithConditionAsync(objgs_KnowledgesLogicRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_KnowledgesLogicRelaEN.sf_UpdFldSetStr === undefined || objgs_KnowledgesLogicRelaEN.sf_UpdFldSetStr === null || objgs_KnowledgesLogicRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_KnowledgesLogicRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        objgs_KnowledgesLogicRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_KnowledgesLogicRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_UpdateWithConditionAsync = gs_KnowledgesLogicRela_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_KnowledgesLogicRela_IsExistRecord_Cache(objgs_KnowledgesLogicRela_Cond, strKnowledgeGraphId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_Cache(strKnowledgeGraphId);
        if (arrgs_KnowledgesLogicRelaObjLst_Cache == null)
            return false;
        let arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRelaObjLst_Cache;
        if (objgs_KnowledgesLogicRela_Cond.sf_FldComparisonOp == null || objgs_KnowledgesLogicRela_Cond.sf_FldComparisonOp == "")
            return arrgs_KnowledgesLogicRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_KnowledgesLogicRela_Cond.sf_FldComparisonOp);
        //console.log("clsgs_KnowledgesLogicRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_KnowledgesLogicRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_KnowledgesLogicRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_KnowledgesLogicRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_KnowledgesLogicRela_Cond), exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_KnowledgesLogicRela_IsExistRecord_Cache = gs_KnowledgesLogicRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_KnowledgesLogicRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_IsExistRecordAsync = gs_KnowledgesLogicRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_KnowledgesLogicRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "mId": lngmId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_IsExist = gs_KnowledgesLogicRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_KnowledgesLogicRela_IsExist_Cache(lngmId, strKnowledgeGraphId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_Cache(strKnowledgeGraphId);
        if (arrgs_KnowledgesLogicRelaObjLst_Cache == null)
            return false;
        try {
            const arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrgs_KnowledgesLogicRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_KnowledgesLogicRela_IsExist_Cache = gs_KnowledgesLogicRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_KnowledgesLogicRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngmId": lngmId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_IsExistAsync = gs_KnowledgesLogicRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_KnowledgesLogicRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_GetRecCountByCondAsync = gs_KnowledgesLogicRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_KnowledgesLogicRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_KnowledgesLogicRela_GetRecCountByCond_Cache(objgs_KnowledgesLogicRela_Cond, strKnowledgeGraphId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_KnowledgesLogicRelaObjLst_Cache = await gs_KnowledgesLogicRela_GetObjLst_Cache(strKnowledgeGraphId);
        if (arrgs_KnowledgesLogicRelaObjLst_Cache == null)
            return 0;
        let arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRelaObjLst_Cache;
        if (objgs_KnowledgesLogicRela_Cond.sf_FldComparisonOp == null || objgs_KnowledgesLogicRela_Cond.sf_FldComparisonOp == "")
            return arrgs_KnowledgesLogicRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_KnowledgesLogicRela_Cond.sf_FldComparisonOp);
        //console.log("clsgs_KnowledgesLogicRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_KnowledgesLogicRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_KnowledgesLogicRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_KnowledgesLogicRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_KnowledgesLogicRela_Cond), exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_KnowledgesLogicRela_GetRecCountByCond_Cache = gs_KnowledgesLogicRela_GetRecCountByCond_Cache;
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
    async function gs_KnowledgesLogicRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesLogicRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRela_GetMaxStrIdByPrefix = gs_KnowledgesLogicRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_KnowledgesLogicRela_GetWebApiUrl(strController, strAction) {
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
    exports.gs_KnowledgesLogicRela_GetWebApiUrl = gs_KnowledgesLogicRela_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_KnowledgesLogicRela_ReFreshCache(strKnowledgeGraphId) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strKnowledgeGraphId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strKnowledgeGraphId]不能为空！(In clsgs_KnowledgesLogicRelaWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strKnowledgeGraphId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strKnowledgeGraphId]的长度:[{0}]不正确！", strKnowledgeGraphId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN._CurrTabName, strKnowledgeGraphId);
        switch (clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheModeId) {
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
    }
    exports.gs_KnowledgesLogicRela_ReFreshCache = gs_KnowledgesLogicRela_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_KnowledgesLogicRela_ReFreshThisCache(strKnowledgeGraphId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN._CurrTabName, strKnowledgeGraphId);
            switch (clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.CacheModeId) {
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
    exports.gs_KnowledgesLogicRela_ReFreshThisCache = gs_KnowledgesLogicRela_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_KnowledgesLogicRela_CheckPropertyNew(pobjgs_KnowledgesLogicRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA) === true) {
            throw new Error("(errid:Watl000058)字段[课程知识点AId]不能为空(In 知识点逻辑关系表)!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB) === true) {
            throw new Error("(errid:Watl000058)字段[课程知识点BId]不能为空(In 知识点逻辑关系表)!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseId) === true
            || pobjgs_KnowledgesLogicRelaEN.courseId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[课程Id]不能为空(In 知识点逻辑关系表)!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA) > 8) {
            throw new Error("(errid:Watl000059)字段[课程知识点AId(courseKnowledgeIdA)]的长度不能超过8(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA) > 100) {
            throw new Error("(errid:Watl000059)字段[课程知识点标题A(courseKnowledgeTitleA)]的长度不能超过100(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB) > 8) {
            throw new Error("(errid:Watl000059)字段[课程知识点BId(courseKnowledgeIdB)]的长度不能超过8(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB) > 100) {
            throw new Error("(errid:Watl000059)字段[课程知识点标题B(courseKnowledgeTitleB)]的长度不能超过100(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId) > 10) {
            throw new Error("(errid:Watl000059)字段[知识点图Id(knowledgeGraphId)]的长度不能超过10(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.sourceAnchor) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.sourceAnchor) > 50) {
            throw new Error("(errid:Watl000059)字段[源锚点(sourceAnchor)]的长度不能超过50(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.sourceAnchor)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.targetAnchor) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.targetAnchor) > 50) {
            throw new Error("(errid:Watl000059)字段[目标锚点(targetAnchor)]的长度不能超过50(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.targetAnchor)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.relaTitle) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.relaTitle) > 100) {
            throw new Error("(errid:Watl000059)字段[关系标题(relaTitle)]的长度不能超过100(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.relaTitle)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.relaTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.relaTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[关系类型Id(relaTypeId)]的长度不能超过2(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.relaTypeId)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.courseId) > 8) {
            throw new Error("(errid:Watl000059)字段[课程Id(courseId)]的长度不能超过8(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.courseId)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.updUser)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.updDate)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.memo)(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_KnowledgesLogicRelaEN.mId && undefined !== pobjgs_KnowledgesLogicRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjgs_KnowledgesLogicRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_KnowledgesLogicRelaEN.mId)], 非法，应该为数值型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA) === false) {
            throw new Error("(errid:Watl000060)字段[课程知识点AId(courseKnowledgeIdA)]的值:[$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA) === false) {
            throw new Error("(errid:Watl000060)字段[课程知识点标题A(courseKnowledgeTitleA)]的值:[$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB) === false) {
            throw new Error("(errid:Watl000060)字段[课程知识点BId(courseKnowledgeIdB)]的值:[$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB) === false) {
            throw new Error("(errid:Watl000060)字段[课程知识点标题B(courseKnowledgeTitleB)]的值:[$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId) === false) {
            throw new Error("(errid:Watl000060)字段[知识点图Id(knowledgeGraphId)]的值:[$(pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.sourceAnchor) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.sourceAnchor && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.sourceAnchor) === false) {
            throw new Error("(errid:Watl000060)字段[源锚点(sourceAnchor)]的值:[$(pobjgs_KnowledgesLogicRelaEN.sourceAnchor)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.targetAnchor) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.targetAnchor && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.targetAnchor) === false) {
            throw new Error("(errid:Watl000060)字段[目标锚点(targetAnchor)]的值:[$(pobjgs_KnowledgesLogicRelaEN.targetAnchor)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.relaTitle) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.relaTitle && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.relaTitle) === false) {
            throw new Error("(errid:Watl000060)字段[关系标题(relaTitle)]的值:[$(pobjgs_KnowledgesLogicRelaEN.relaTitle)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.relaTypeId) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.relaTypeId && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.relaTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[关系类型Id(relaTypeId)]的值:[$(pobjgs_KnowledgesLogicRelaEN.relaTypeId)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseId) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.courseId && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.courseId) === false) {
            throw new Error("(errid:Watl000060)字段[课程Id(courseId)]的值:[$(pobjgs_KnowledgesLogicRelaEN.courseId)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.updUser) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_KnowledgesLogicRelaEN.updUser)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.updDate) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_KnowledgesLogicRelaEN.updDate)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.memo) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.memo && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_KnowledgesLogicRelaEN.memo)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_KnowledgesLogicRelaEN.SetIsCheckProperty(true);
    }
    exports.gs_KnowledgesLogicRela_CheckPropertyNew = gs_KnowledgesLogicRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_KnowledgesLogicRela_CheckProperty4Update(pobjgs_KnowledgesLogicRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA) > 8) {
            throw new Error("(errid:Watl000062)字段[课程知识点AId(courseKnowledgeIdA)]的长度不能超过8(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA) > 100) {
            throw new Error("(errid:Watl000062)字段[课程知识点标题A(courseKnowledgeTitleA)]的长度不能超过100(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB) > 8) {
            throw new Error("(errid:Watl000062)字段[课程知识点BId(courseKnowledgeIdB)]的长度不能超过8(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB) > 100) {
            throw new Error("(errid:Watl000062)字段[课程知识点标题B(courseKnowledgeTitleB)]的长度不能超过100(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId) > 10) {
            throw new Error("(errid:Watl000062)字段[知识点图Id(knowledgeGraphId)]的长度不能超过10(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.sourceAnchor) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.sourceAnchor) > 50) {
            throw new Error("(errid:Watl000062)字段[源锚点(sourceAnchor)]的长度不能超过50(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.sourceAnchor)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.targetAnchor) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.targetAnchor) > 50) {
            throw new Error("(errid:Watl000062)字段[目标锚点(targetAnchor)]的长度不能超过50(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.targetAnchor)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.relaTitle) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.relaTitle) > 100) {
            throw new Error("(errid:Watl000062)字段[关系标题(relaTitle)]的长度不能超过100(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.relaTitle)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.relaTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.relaTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[关系类型Id(relaTypeId)]的长度不能超过2(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.relaTypeId)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.courseId) > 8) {
            throw new Error("(errid:Watl000062)字段[课程Id(courseId)]的长度不能超过8(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.courseId)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.updUser)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.updDate)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesLogicRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!值:$(pobjgs_KnowledgesLogicRelaEN.memo)(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_KnowledgesLogicRelaEN.mId && undefined !== pobjgs_KnowledgesLogicRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjgs_KnowledgesLogicRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_KnowledgesLogicRelaEN.mId)], 非法，应该为数值型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA) === false) {
            throw new Error("(errid:Watl000063)字段[课程知识点AId(courseKnowledgeIdA)]的值:[$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdA)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA) === false) {
            throw new Error("(errid:Watl000063)字段[课程知识点标题A(courseKnowledgeTitleA)]的值:[$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleA)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB) === false) {
            throw new Error("(errid:Watl000063)字段[课程知识点BId(courseKnowledgeIdB)]的值:[$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeIdB)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB) === false) {
            throw new Error("(errid:Watl000063)字段[课程知识点标题B(courseKnowledgeTitleB)]的值:[$(pobjgs_KnowledgesLogicRelaEN.courseKnowledgeTitleB)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId) === false) {
            throw new Error("(errid:Watl000063)字段[知识点图Id(knowledgeGraphId)]的值:[$(pobjgs_KnowledgesLogicRelaEN.knowledgeGraphId)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.sourceAnchor) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.sourceAnchor && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.sourceAnchor) === false) {
            throw new Error("(errid:Watl000063)字段[源锚点(sourceAnchor)]的值:[$(pobjgs_KnowledgesLogicRelaEN.sourceAnchor)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.targetAnchor) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.targetAnchor && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.targetAnchor) === false) {
            throw new Error("(errid:Watl000063)字段[目标锚点(targetAnchor)]的值:[$(pobjgs_KnowledgesLogicRelaEN.targetAnchor)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.relaTitle) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.relaTitle && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.relaTitle) === false) {
            throw new Error("(errid:Watl000063)字段[关系标题(relaTitle)]的值:[$(pobjgs_KnowledgesLogicRelaEN.relaTitle)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.relaTypeId) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.relaTypeId && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.relaTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[关系类型Id(relaTypeId)]的值:[$(pobjgs_KnowledgesLogicRelaEN.relaTypeId)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.courseId) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.courseId && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.courseId) === false) {
            throw new Error("(errid:Watl000063)字段[课程Id(courseId)]的值:[$(pobjgs_KnowledgesLogicRelaEN.courseId)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.updUser) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_KnowledgesLogicRelaEN.updUser)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.updDate) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_KnowledgesLogicRelaEN.updDate)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesLogicRelaEN.memo) == false && undefined !== pobjgs_KnowledgesLogicRelaEN.memo && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesLogicRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_KnowledgesLogicRelaEN.memo)], 非法，应该为字符型(In 知识点逻辑关系表(gs_KnowledgesLogicRela))!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_KnowledgesLogicRelaEN.mId
            || pobjgs_KnowledgesLogicRelaEN.mId != null && pobjgs_KnowledgesLogicRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 知识点逻辑关系表)!(clsgs_KnowledgesLogicRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_KnowledgesLogicRelaEN.SetIsCheckProperty(true);
    }
    exports.gs_KnowledgesLogicRela_CheckProperty4Update = gs_KnowledgesLogicRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_KnowledgesLogicRela_GetJSONStrByObj(pobjgs_KnowledgesLogicRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_KnowledgesLogicRelaEN.sf_UpdFldSetStr = pobjgs_KnowledgesLogicRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_KnowledgesLogicRelaEN);
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
    exports.gs_KnowledgesLogicRela_GetJSONStrByObj = gs_KnowledgesLogicRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_KnowledgesLogicRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_KnowledgesLogicRelaObjLst = new Array();
        if (strJSON === "") {
            return arrgs_KnowledgesLogicRelaObjLst;
        }
        try {
            arrgs_KnowledgesLogicRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_KnowledgesLogicRelaObjLst;
        }
        return arrgs_KnowledgesLogicRelaObjLst;
    }
    exports.gs_KnowledgesLogicRela_GetObjLstByJSONStr = gs_KnowledgesLogicRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_KnowledgesLogicRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_KnowledgesLogicRela_GetObjLstByJSONObjLst(arrgs_KnowledgesLogicRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_KnowledgesLogicRelaObjLst = new Array();
        for (const objInFor of arrgs_KnowledgesLogicRelaObjLstS) {
            const obj1 = gs_KnowledgesLogicRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_KnowledgesLogicRelaObjLst.push(obj1);
        }
        return arrgs_KnowledgesLogicRelaObjLst;
    }
    exports.gs_KnowledgesLogicRela_GetObjLstByJSONObjLst = gs_KnowledgesLogicRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_KnowledgesLogicRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_KnowledgesLogicRelaEN = new clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN();
        if (strJSON === "") {
            return pobjgs_KnowledgesLogicRelaEN;
        }
        try {
            pobjgs_KnowledgesLogicRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_KnowledgesLogicRelaEN;
        }
        return pobjgs_KnowledgesLogicRelaEN;
    }
    exports.gs_KnowledgesLogicRela_GetObjByJSONStr = gs_KnowledgesLogicRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_KnowledgesLogicRela_GetCombineCondition(objgs_KnowledgesLogicRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_mId, objgs_KnowledgesLogicRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdA) == true) {
            const strComparisonOp_CourseKnowledgeIdA = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdA, objgs_KnowledgesLogicRela_Cond.courseKnowledgeIdA, strComparisonOp_CourseKnowledgeIdA);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleA) == true) {
            const strComparisonOp_CourseKnowledgeTitleA = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleA, objgs_KnowledgesLogicRela_Cond.courseKnowledgeTitleA, strComparisonOp_CourseKnowledgeTitleA);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdB) == true) {
            const strComparisonOp_CourseKnowledgeIdB = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdB];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdB, objgs_KnowledgesLogicRela_Cond.courseKnowledgeIdB, strComparisonOp_CourseKnowledgeIdB);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleB) == true) {
            const strComparisonOp_CourseKnowledgeTitleB = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleB];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleB, objgs_KnowledgesLogicRela_Cond.courseKnowledgeTitleB, strComparisonOp_CourseKnowledgeTitleB);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_KnowledgeGraphId) == true) {
            const strComparisonOp_KnowledgeGraphId = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_KnowledgeGraphId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_KnowledgeGraphId, objgs_KnowledgesLogicRela_Cond.knowledgeGraphId, strComparisonOp_KnowledgeGraphId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_SourceAnchor) == true) {
            const strComparisonOp_SourceAnchor = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_SourceAnchor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_SourceAnchor, objgs_KnowledgesLogicRela_Cond.sourceAnchor, strComparisonOp_SourceAnchor);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_TargetAnchor) == true) {
            const strComparisonOp_TargetAnchor = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_TargetAnchor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_TargetAnchor, objgs_KnowledgesLogicRela_Cond.targetAnchor, strComparisonOp_TargetAnchor);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_RelaTitle) == true) {
            const strComparisonOp_RelaTitle = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_RelaTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_RelaTitle, objgs_KnowledgesLogicRela_Cond.relaTitle, strComparisonOp_RelaTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_RelaTypeId) == true) {
            const strComparisonOp_RelaTypeId = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_RelaTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_RelaTypeId, objgs_KnowledgesLogicRela_Cond.relaTypeId, strComparisonOp_RelaTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_CourseId, objgs_KnowledgesLogicRela_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_UpdUser, objgs_KnowledgesLogicRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_UpdDate, objgs_KnowledgesLogicRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp, clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_KnowledgesLogicRela_Cond.dicFldComparisonOp[clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.con_Memo, objgs_KnowledgesLogicRela_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_KnowledgesLogicRela_GetCombineCondition = gs_KnowledgesLogicRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_KnowledgesLogicRela(知识点逻辑关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strKnowledgeGraphId: 知识点图Id(要求唯一的字段)
    * @param strCourseKnowledgeIdA: 课程知识点AId(要求唯一的字段)
    * @param strCourseKnowledgeIdB: 课程知识点BId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_KnowledgesLogicRela_GetUniCondStr_KnowledgeGraphId_CourseKnowledgeIdA_CourseKnowledgeIdB(objgs_KnowledgesLogicRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and KnowledgeGraphId = '{0}'", objgs_KnowledgesLogicRelaEN.knowledgeGraphId);
        strWhereCond += (0, clsString_js_1.Format)(" and CourseKnowledgeIdA = '{0}'", objgs_KnowledgesLogicRelaEN.courseKnowledgeIdA);
        strWhereCond += (0, clsString_js_1.Format)(" and CourseKnowledgeIdB = '{0}'", objgs_KnowledgesLogicRelaEN.courseKnowledgeIdB);
        return strWhereCond;
    }
    exports.gs_KnowledgesLogicRela_GetUniCondStr_KnowledgeGraphId_CourseKnowledgeIdA_CourseKnowledgeIdB = gs_KnowledgesLogicRela_GetUniCondStr_KnowledgeGraphId_CourseKnowledgeIdA_CourseKnowledgeIdB;
    /**
    *获取唯一性条件串(Uniqueness)--gs_KnowledgesLogicRela(知识点逻辑关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strKnowledgeGraphId: 知识点图Id(要求唯一的字段)
    * @param strCourseKnowledgeIdA: 课程知识点AId(要求唯一的字段)
    * @param strCourseKnowledgeIdB: 课程知识点BId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_KnowledgesLogicRela_GetUniCondStr4Update_KnowledgeGraphId_CourseKnowledgeIdA_CourseKnowledgeIdB(objgs_KnowledgesLogicRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objgs_KnowledgesLogicRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and KnowledgeGraphId = '{0}'", objgs_KnowledgesLogicRelaEN.knowledgeGraphId);
        strWhereCond += (0, clsString_js_1.Format)(" and CourseKnowledgeIdA = '{0}'", objgs_KnowledgesLogicRelaEN.courseKnowledgeIdA);
        strWhereCond += (0, clsString_js_1.Format)(" and CourseKnowledgeIdB = '{0}'", objgs_KnowledgesLogicRelaEN.courseKnowledgeIdB);
        return strWhereCond;
    }
    exports.gs_KnowledgesLogicRela_GetUniCondStr4Update_KnowledgeGraphId_CourseKnowledgeIdA_CourseKnowledgeIdB = gs_KnowledgesLogicRela_GetUniCondStr4Update_KnowledgeGraphId_CourseKnowledgeIdA_CourseKnowledgeIdB;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_KnowledgesLogicRelaENS:源对象
     * @param objgs_KnowledgesLogicRelaENT:目标对象
    */
    function gs_KnowledgesLogicRela_CopyObjTo(objgs_KnowledgesLogicRelaENS, objgs_KnowledgesLogicRelaENT) {
        objgs_KnowledgesLogicRelaENT.mId = objgs_KnowledgesLogicRelaENS.mId; //mId
        objgs_KnowledgesLogicRelaENT.courseKnowledgeIdA = objgs_KnowledgesLogicRelaENS.courseKnowledgeIdA; //课程知识点AId
        objgs_KnowledgesLogicRelaENT.courseKnowledgeTitleA = objgs_KnowledgesLogicRelaENS.courseKnowledgeTitleA; //课程知识点标题A
        objgs_KnowledgesLogicRelaENT.courseKnowledgeIdB = objgs_KnowledgesLogicRelaENS.courseKnowledgeIdB; //课程知识点BId
        objgs_KnowledgesLogicRelaENT.courseKnowledgeTitleB = objgs_KnowledgesLogicRelaENS.courseKnowledgeTitleB; //课程知识点标题B
        objgs_KnowledgesLogicRelaENT.knowledgeGraphId = objgs_KnowledgesLogicRelaENS.knowledgeGraphId; //知识点图Id
        objgs_KnowledgesLogicRelaENT.sourceAnchor = objgs_KnowledgesLogicRelaENS.sourceAnchor; //源锚点
        objgs_KnowledgesLogicRelaENT.targetAnchor = objgs_KnowledgesLogicRelaENS.targetAnchor; //目标锚点
        objgs_KnowledgesLogicRelaENT.relaTitle = objgs_KnowledgesLogicRelaENS.relaTitle; //关系标题
        objgs_KnowledgesLogicRelaENT.relaTypeId = objgs_KnowledgesLogicRelaENS.relaTypeId; //关系类型Id
        objgs_KnowledgesLogicRelaENT.courseId = objgs_KnowledgesLogicRelaENS.courseId; //课程Id
        objgs_KnowledgesLogicRelaENT.updUser = objgs_KnowledgesLogicRelaENS.updUser; //修改人
        objgs_KnowledgesLogicRelaENT.updDate = objgs_KnowledgesLogicRelaENS.updDate; //修改日期
        objgs_KnowledgesLogicRelaENT.memo = objgs_KnowledgesLogicRelaENS.memo; //备注
        objgs_KnowledgesLogicRelaENT.sf_UpdFldSetStr = objgs_KnowledgesLogicRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_KnowledgesLogicRela_CopyObjTo = gs_KnowledgesLogicRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_KnowledgesLogicRelaENS:源对象
     * @param objgs_KnowledgesLogicRelaENT:目标对象
    */
    function gs_KnowledgesLogicRela_GetObjFromJsonObj(objgs_KnowledgesLogicRelaENS) {
        const objgs_KnowledgesLogicRelaENT = new clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_KnowledgesLogicRelaENT, objgs_KnowledgesLogicRelaENS);
        return objgs_KnowledgesLogicRelaENT;
    }
    exports.gs_KnowledgesLogicRela_GetObjFromJsonObj = gs_KnowledgesLogicRela_GetObjFromJsonObj;
});