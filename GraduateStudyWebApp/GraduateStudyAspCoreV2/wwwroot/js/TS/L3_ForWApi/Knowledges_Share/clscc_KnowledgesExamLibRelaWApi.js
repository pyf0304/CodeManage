/**
* 类名:clscc_KnowledgesExamLibRelaWApi
* 表名:cc_KnowledgesExamLibRela(01120140)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 03:26:21
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:游戏化教育平台(变量首字母小写)-全部函数集
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/Knowledges_Share/clscc_KnowledgesExamLibRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_KnowledgesExamLibRela_GetObjFromJsonObj = exports.cc_KnowledgesExamLibRela_CopyObjTo = exports.cc_KnowledgesExamLibRela_GetUniCondStr4Update_CourseKnowledgeId_QuestionID = exports.cc_KnowledgesExamLibRela_GetUniCondStr_CourseKnowledgeId_QuestionID = exports.cc_KnowledgesExamLibRela_GetCombineCondition = exports.cc_KnowledgesExamLibRela_GetObjByJSONStr = exports.cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst = exports.cc_KnowledgesExamLibRela_GetObjLstByJSONStr = exports.cc_KnowledgesExamLibRela_GetJSONStrByObj = exports.cc_KnowledgesExamLibRela_CheckProperty4Update = exports.cc_KnowledgesExamLibRela_CheckPropertyNew = exports.cc_KnowledgesExamLibRela_ReFreshThisCache = exports.cc_KnowledgesExamLibRela_ReFreshCache = exports.cc_KnowledgesExamLibRela_GetWebApiUrl = exports.cc_KnowledgesExamLibRela_GetMaxStrIdByPrefix = exports.cc_KnowledgesExamLibRela_GetRecCountByCond_Cache = exports.cc_KnowledgesExamLibRela_GetRecCountByCondAsync = exports.cc_KnowledgesExamLibRela_IsExistAsync = exports.cc_KnowledgesExamLibRela_IsExist_Cache = exports.cc_KnowledgesExamLibRela_IsExist = exports.cc_KnowledgesExamLibRela_IsExistRecordAsync = exports.cc_KnowledgesExamLibRela_IsExistRecord_Cache = exports.cc_KnowledgesExamLibRela_UpdateWithConditionAsync = exports.cc_KnowledgesExamLibRela_UpdateRecordAsync = exports.cc_KnowledgesExamLibRela_AddNewRecordWithReturnKey = exports.cc_KnowledgesExamLibRela_AddNewRecordWithReturnKeyAsync = exports.cc_KnowledgesExamLibRela_AddNewRecordAsync = exports.cc_KnowledgesExamLibRela_Delcc_KnowledgesExamLibRelasByCondAsync = exports.cc_KnowledgesExamLibRela_Delcc_KnowledgesExamLibRelasAsync = exports.cc_KnowledgesExamLibRela_DelRecordAsync = exports.cc_KnowledgesExamLibRela_GetObjLstByPagerAsync = exports.cc_KnowledgesExamLibRela_GetObjLstByPager_Cache = exports.cc_KnowledgesExamLibRela_GetObjLstByRange = exports.cc_KnowledgesExamLibRela_GetObjLstByRangeAsync = exports.cc_KnowledgesExamLibRela_GetTopObjLstAsync = exports.cc_KnowledgesExamLibRela_GetObjLstBymIdLst_Cache = exports.cc_KnowledgesExamLibRela_GetObjLstBymIdLstAsync = exports.cc_KnowledgesExamLibRela_GetSubObjLst_Cache = exports.cc_KnowledgesExamLibRela_GetObjLst_PureCache = exports.cc_KnowledgesExamLibRela_GetObjLst_Cache = exports.cc_KnowledgesExamLibRela_GetObjLst_sessionStorage_PureCache = exports.cc_KnowledgesExamLibRela_GetObjLst_sessionStorage = exports.cc_KnowledgesExamLibRela_GetObjLstAsync = exports.cc_KnowledgesExamLibRela_GetObjLst_localStorage_PureCache = exports.cc_KnowledgesExamLibRela_GetObjLst_localStorage = exports.cc_KnowledgesExamLibRela_GetObjLst_ClientCache = exports.cc_KnowledgesExamLibRela_GetFirstObjAsync = exports.cc_KnowledgesExamLibRela_GetFirstID = exports.cc_KnowledgesExamLibRela_GetFirstIDAsync = exports.cc_KnowledgesExamLibRela_funcKey = exports.cc_KnowledgesExamLibRela_FilterFunByKey = exports.cc_KnowledgesExamLibRela_SortFunByKey = exports.cc_KnowledgesExamLibRela_SortFun_Defa_2Fld = exports.cc_KnowledgesExamLibRela_SortFun_Defa = exports.cc_KnowledgesExamLibRela_func = exports.cc_KnowledgesExamLibRela_UpdateObjInLst_Cache = exports.cc_KnowledgesExamLibRela_GetObjBymId_localStorage = exports.cc_KnowledgesExamLibRela_GetObjBymId_Cache = exports.cc_KnowledgesExamLibRela_GetObjBymIdAsync = exports.cc_KnowledgesExamLibRela_ConstructorName = exports.cc_KnowledgesExamLibRela_Controller = void 0;
    /**
     * 知识点习题关系(cc_KnowledgesExamLibRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clscc_KnowledgesExamLibRelaEN_js_1 = require("../../L0_Entity/Knowledges_Share/clscc_KnowledgesExamLibRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.cc_KnowledgesExamLibRela_Controller = "cc_KnowledgesExamLibRelaApi";
    exports.cc_KnowledgesExamLibRela_ConstructorName = "cc_KnowledgesExamLibRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function cc_KnowledgesExamLibRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clscc_KnowledgesExamLibRelaWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
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
                    return null;
                }
                //console.log(returnObj);
                const objcc_KnowledgesExamLibRela = cc_KnowledgesExamLibRela_GetObjFromJsonObj(returnObj);
                return objcc_KnowledgesExamLibRela;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_GetObjBymIdAsync = cc_KnowledgesExamLibRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function cc_KnowledgesExamLibRela_GetObjBymId_Cache(lngmId, strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clscc_KnowledgesExamLibRelaWApi.GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_Cache(strCourseId);
        try {
            const arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objcc_KnowledgesExamLibRela;
            if (arrcc_KnowledgesExamLibRela_Sel.length > 0) {
                objcc_KnowledgesExamLibRela = arrcc_KnowledgesExamLibRela_Sel[0];
                return objcc_KnowledgesExamLibRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objcc_KnowledgesExamLibRela_Const = await cc_KnowledgesExamLibRela_GetObjBymIdAsync(lngmId);
                    if (objcc_KnowledgesExamLibRela_Const != null) {
                        cc_KnowledgesExamLibRela_ReFreshThisCache(strCourseId);
                        return objcc_KnowledgesExamLibRela_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.cc_KnowledgesExamLibRela_GetObjBymId_Cache = cc_KnowledgesExamLibRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function cc_KnowledgesExamLibRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clscc_KnowledgesExamLibRelaWApi.GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objcc_KnowledgesExamLibRela_Cache = JSON.parse(strTempObj);
            return objcc_KnowledgesExamLibRela_Cache;
        }
        try {
            const objcc_KnowledgesExamLibRela = await cc_KnowledgesExamLibRela_GetObjBymIdAsync(lngmId);
            if (objcc_KnowledgesExamLibRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objcc_KnowledgesExamLibRela));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objcc_KnowledgesExamLibRela;
            }
            return objcc_KnowledgesExamLibRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.cc_KnowledgesExamLibRela_GetObjBymId_localStorage = cc_KnowledgesExamLibRela_GetObjBymId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objcc_KnowledgesExamLibRela:所给的对象
     * @returns 对象
    */
    async function cc_KnowledgesExamLibRela_UpdateObjInLst_Cache(objcc_KnowledgesExamLibRela, strCourseId) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_Cache(strCourseId);
            const obj = arrcc_KnowledgesExamLibRelaObjLst_Cache.find(x => x.questionID == objcc_KnowledgesExamLibRela.questionID && x.courseKnowledgeId == objcc_KnowledgesExamLibRela.courseKnowledgeId);
            if (obj != null) {
                objcc_KnowledgesExamLibRela.mId = obj.mId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objcc_KnowledgesExamLibRela);
            }
            else {
                arrcc_KnowledgesExamLibRelaObjLst_Cache.push(objcc_KnowledgesExamLibRela);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_KnowledgesExamLibRela_UpdateObjInLst_Cache = cc_KnowledgesExamLibRela_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strCourseId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function cc_KnowledgesExamLibRela_func(strInFldName, strOutFldName, strInValue, strCourseId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId_C]不能为空！(In clscc_KnowledgesExamLibRelaWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clscc_KnowledgesExamLibRelaWApi.func)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_mId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objcc_KnowledgesExamLibRela = await cc_KnowledgesExamLibRela_GetObjBymId_Cache(lngmId, strCourseId_C);
        if (objcc_KnowledgesExamLibRela == null)
            return "";
        if (objcc_KnowledgesExamLibRela.GetFldValue(strOutFldName) == null)
            return "";
        return objcc_KnowledgesExamLibRela.GetFldValue(strOutFldName).toString();
    }
    exports.cc_KnowledgesExamLibRela_func = cc_KnowledgesExamLibRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_KnowledgesExamLibRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.cc_KnowledgesExamLibRela_SortFun_Defa = cc_KnowledgesExamLibRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_KnowledgesExamLibRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.questionID == b.questionID)
            return a.courseId.localeCompare(b.courseId);
        else
            return a.questionID.localeCompare(b.questionID);
    }
    exports.cc_KnowledgesExamLibRela_SortFun_Defa_2Fld = cc_KnowledgesExamLibRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_KnowledgesExamLibRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_QuestionID:
                    return (a, b) => {
                        return a.questionID.localeCompare(b.questionID);
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseId:
                    return (a, b) => {
                        if (a.courseId == null)
                            return -1;
                        if (b.courseId == null)
                            return 1;
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_PositiveCorrelation:
                    return (a, b) => {
                        return a.positiveCorrelation - b.positiveCorrelation;
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseKnowledgeId:
                    return (a, b) => {
                        return a.courseKnowledgeId.localeCompare(b.courseKnowledgeId);
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_NegativeCorrelation:
                    return (a, b) => {
                        return a.negativeCorrelation - b.negativeCorrelation;
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_UpdUserId:
                    return (a, b) => {
                        if (a.updUserId == null)
                            return -1;
                        if (b.updUserId == null)
                            return 1;
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[cc_KnowledgesExamLibRela]中不存在！(in ${exports.cc_KnowledgesExamLibRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_QuestionID:
                    return (a, b) => {
                        return b.questionID.localeCompare(a.questionID);
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseId:
                    return (a, b) => {
                        if (b.courseId == null)
                            return -1;
                        if (a.courseId == null)
                            return 1;
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_PositiveCorrelation:
                    return (a, b) => {
                        return b.positiveCorrelation - a.positiveCorrelation;
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseKnowledgeId:
                    return (a, b) => {
                        return b.courseKnowledgeId.localeCompare(a.courseKnowledgeId);
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_NegativeCorrelation:
                    return (a, b) => {
                        return b.negativeCorrelation - a.negativeCorrelation;
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_UpdUserId:
                    return (a, b) => {
                        if (b.updUserId == null)
                            return -1;
                        if (a.updUserId == null)
                            return 1;
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[cc_KnowledgesExamLibRela]中不存在！(in ${exports.cc_KnowledgesExamLibRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_SortFunByKey = cc_KnowledgesExamLibRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function cc_KnowledgesExamLibRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_QuestionID:
                return (obj) => {
                    return obj.questionID === value;
                };
            case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_PositiveCorrelation:
                return (obj) => {
                    return obj.positiveCorrelation === value;
                };
            case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseKnowledgeId:
                return (obj) => {
                    return obj.courseKnowledgeId === value;
                };
            case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_NegativeCorrelation:
                return (obj) => {
                    return obj.negativeCorrelation === value;
                };
            case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[cc_KnowledgesExamLibRela]中不存在！(in ${exports.cc_KnowledgesExamLibRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.cc_KnowledgesExamLibRela_FilterFunByKey = cc_KnowledgesExamLibRela_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strCourseId:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function cc_KnowledgesExamLibRela_funcKey(strInFldName, strInValue, strComparisonOp, strCourseId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId_C]不能为空！(In clscc_KnowledgesExamLibRelaWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clscc_KnowledgesExamLibRelaWApi.funcKey)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_mId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrcc_KnowledgesExamLibRela = await cc_KnowledgesExamLibRela_GetObjLst_Cache(strCourseId_C);
        if (arrcc_KnowledgesExamLibRela == null)
            return [];
        let arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrcc_KnowledgesExamLibRela_Sel.length == 0)
            return [];
        return arrcc_KnowledgesExamLibRela_Sel.map(x => x.mId);
    }
    exports.cc_KnowledgesExamLibRela_funcKey = cc_KnowledgesExamLibRela_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function cc_KnowledgesExamLibRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_GetFirstIDAsync = cc_KnowledgesExamLibRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function cc_KnowledgesExamLibRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_GetFirstID = cc_KnowledgesExamLibRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function cc_KnowledgesExamLibRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
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
                const objcc_KnowledgesExamLibRela = cc_KnowledgesExamLibRela_GetObjFromJsonObj(returnObj);
                return objcc_KnowledgesExamLibRela;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_GetFirstObjAsync = cc_KnowledgesExamLibRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_KnowledgesExamLibRela_GetObjLst_ClientCache(strCourseId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrcc_KnowledgesExamLibRelaExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrcc_KnowledgesExamLibRelaObjLst_T = cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst(arrcc_KnowledgesExamLibRelaExObjLst_Cache);
            return arrcc_KnowledgesExamLibRelaObjLst_T;
        }
        try {
            const arrcc_KnowledgesExamLibRelaExObjLst = await cc_KnowledgesExamLibRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrcc_KnowledgesExamLibRelaExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_KnowledgesExamLibRelaExObjLst.length);
            console.log(strInfo);
            return arrcc_KnowledgesExamLibRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_KnowledgesExamLibRela_GetObjLst_ClientCache = cc_KnowledgesExamLibRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_KnowledgesExamLibRela_GetObjLst_localStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrcc_KnowledgesExamLibRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrcc_KnowledgesExamLibRelaObjLst_T = cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst(arrcc_KnowledgesExamLibRelaExObjLst_Cache);
            return arrcc_KnowledgesExamLibRelaObjLst_T;
        }
        try {
            const arrcc_KnowledgesExamLibRelaExObjLst = await cc_KnowledgesExamLibRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrcc_KnowledgesExamLibRelaExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_KnowledgesExamLibRelaExObjLst.length);
            console.log(strInfo);
            return arrcc_KnowledgesExamLibRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_KnowledgesExamLibRela_GetObjLst_localStorage = cc_KnowledgesExamLibRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_KnowledgesExamLibRela_GetObjLst_localStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrcc_KnowledgesExamLibRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrcc_KnowledgesExamLibRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.cc_KnowledgesExamLibRela_GetObjLst_localStorage_PureCache = cc_KnowledgesExamLibRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function cc_KnowledgesExamLibRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_GetObjLstAsync = cc_KnowledgesExamLibRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_KnowledgesExamLibRela_GetObjLst_sessionStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrcc_KnowledgesExamLibRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrcc_KnowledgesExamLibRelaObjLst_T = cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst(arrcc_KnowledgesExamLibRelaExObjLst_Cache);
            return arrcc_KnowledgesExamLibRelaObjLst_T;
        }
        try {
            const arrcc_KnowledgesExamLibRelaExObjLst = await cc_KnowledgesExamLibRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrcc_KnowledgesExamLibRelaExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_KnowledgesExamLibRelaExObjLst.length);
            console.log(strInfo);
            return arrcc_KnowledgesExamLibRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_KnowledgesExamLibRela_GetObjLst_sessionStorage = cc_KnowledgesExamLibRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_KnowledgesExamLibRela_GetObjLst_sessionStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrcc_KnowledgesExamLibRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrcc_KnowledgesExamLibRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.cc_KnowledgesExamLibRela_GetObjLst_sessionStorage_PureCache = cc_KnowledgesExamLibRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_KnowledgesExamLibRela_GetObjLst_Cache(strCourseId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[CourseId]不能为空！(in clscc_KnowledgesExamLibRelaWApi.cc_KnowledgesExamLibRela_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(in clscc_KnowledgesExamLibRelaWApi.cc_KnowledgesExamLibRela_GetObjLst_Cache() )", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrcc_KnowledgesExamLibRelaObjLst_Cache;
        switch (clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_sessionStorage(strCourseId);
                break;
            case "03": //localStorage
                arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_localStorage(strCourseId);
                break;
            case "02": //ClientCache
                arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_ClientCache(strCourseId);
                break;
            default:
                arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_ClientCache(strCourseId);
                break;
        }
        const arrcc_KnowledgesExamLibRelaObjLst = cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst(arrcc_KnowledgesExamLibRelaObjLst_Cache);
        return arrcc_KnowledgesExamLibRelaObjLst_Cache;
    }
    exports.cc_KnowledgesExamLibRela_GetObjLst_Cache = cc_KnowledgesExamLibRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_KnowledgesExamLibRela_GetObjLst_PureCache(strCourseId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrcc_KnowledgesExamLibRelaObjLst_Cache;
        switch (clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_sessionStorage_PureCache(strCourseId);
                break;
            case "03": //localStorage
                arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_localStorage_PureCache(strCourseId);
                break;
            case "02": //ClientCache
                arrcc_KnowledgesExamLibRelaObjLst_Cache = null;
                break;
            default:
                arrcc_KnowledgesExamLibRelaObjLst_Cache = null;
                break;
        }
        return arrcc_KnowledgesExamLibRelaObjLst_Cache;
    }
    exports.cc_KnowledgesExamLibRela_GetObjLst_PureCache = cc_KnowledgesExamLibRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function cc_KnowledgesExamLibRela_GetSubObjLst_Cache(objcc_KnowledgesExamLibRela_Cond, strCourseId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_Cache(strCourseId);
        let arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRelaObjLst_Cache;
        if (objcc_KnowledgesExamLibRela_Cond.sf_FldComparisonOp == null || objcc_KnowledgesExamLibRela_Cond.sf_FldComparisonOp == "")
            return arrcc_KnowledgesExamLibRela_Sel;
        const dicFldComparisonOp = JSON.parse(objcc_KnowledgesExamLibRela_Cond.sf_FldComparisonOp);
        //console.log("clscc_KnowledgesExamLibRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_KnowledgesExamLibRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_KnowledgesExamLibRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrcc_KnowledgesExamLibRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objcc_KnowledgesExamLibRela_Cond), exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_KnowledgesExamLibRela_GetSubObjLst_Cache = cc_KnowledgesExamLibRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function cc_KnowledgesExamLibRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_GetObjLstBymIdLstAsync = cc_KnowledgesExamLibRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function cc_KnowledgesExamLibRela_GetObjLstBymIdLst_Cache(arrmIdLst, strCourseId) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_Cache(strCourseId);
            const arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrcc_KnowledgesExamLibRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.cc_KnowledgesExamLibRela_GetObjLstBymIdLst_Cache = cc_KnowledgesExamLibRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function cc_KnowledgesExamLibRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_GetTopObjLstAsync = cc_KnowledgesExamLibRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function cc_KnowledgesExamLibRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_GetObjLstByRangeAsync = cc_KnowledgesExamLibRela_GetObjLstByRangeAsync;
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
    async function cc_KnowledgesExamLibRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_GetObjLstByRange = cc_KnowledgesExamLibRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function cc_KnowledgesExamLibRela_GetObjLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_Cache(strCourseId);
        if (arrcc_KnowledgesExamLibRelaObjLst_Cache.length == 0)
            return arrcc_KnowledgesExamLibRelaObjLst_Cache;
        let arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objcc_KnowledgesExamLibRela_Cond = new clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_KnowledgesExamLibRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clscc_KnowledgesExamLibRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_KnowledgesExamLibRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_KnowledgesExamLibRela_Sel.length == 0)
                return arrcc_KnowledgesExamLibRela_Sel;
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
                arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.sort(cc_KnowledgesExamLibRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.sort(objPagerPara.sortFun);
            }
            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.slice(intStart, intEnd);
            return arrcc_KnowledgesExamLibRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_KnowledgesExamLibRela_GetObjLstByPager_Cache = cc_KnowledgesExamLibRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function cc_KnowledgesExamLibRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_GetObjLstByPagerAsync = cc_KnowledgesExamLibRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function cc_KnowledgesExamLibRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngmId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_DelRecordAsync = cc_KnowledgesExamLibRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function cc_KnowledgesExamLibRela_Delcc_KnowledgesExamLibRelasAsync(arrmId) {
        const strThisFuncName = "Delcc_KnowledgesExamLibRelasAsync";
        const strAction = "Delcc_KnowledgesExamLibRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_Delcc_KnowledgesExamLibRelasAsync = cc_KnowledgesExamLibRela_Delcc_KnowledgesExamLibRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function cc_KnowledgesExamLibRela_Delcc_KnowledgesExamLibRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "Delcc_KnowledgesExamLibRelasByCondAsync";
        const strAction = "Delcc_KnowledgesExamLibRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_Delcc_KnowledgesExamLibRelasByCondAsync = cc_KnowledgesExamLibRela_Delcc_KnowledgesExamLibRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objcc_KnowledgesExamLibRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_KnowledgesExamLibRela_AddNewRecordAsync(objcc_KnowledgesExamLibRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objcc_KnowledgesExamLibRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_KnowledgesExamLibRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_AddNewRecordAsync = cc_KnowledgesExamLibRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objcc_KnowledgesExamLibRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function cc_KnowledgesExamLibRela_AddNewRecordWithReturnKeyAsync(objcc_KnowledgesExamLibRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_KnowledgesExamLibRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_AddNewRecordWithReturnKeyAsync = cc_KnowledgesExamLibRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objcc_KnowledgesExamLibRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function cc_KnowledgesExamLibRela_AddNewRecordWithReturnKey(objcc_KnowledgesExamLibRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objcc_KnowledgesExamLibRelaEN.mId === null || objcc_KnowledgesExamLibRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_KnowledgesExamLibRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_AddNewRecordWithReturnKey = cc_KnowledgesExamLibRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objcc_KnowledgesExamLibRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function cc_KnowledgesExamLibRela_UpdateRecordAsync(objcc_KnowledgesExamLibRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objcc_KnowledgesExamLibRelaEN.sf_UpdFldSetStr === undefined || objcc_KnowledgesExamLibRelaEN.sf_UpdFldSetStr === null || objcc_KnowledgesExamLibRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_KnowledgesExamLibRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_KnowledgesExamLibRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_UpdateRecordAsync = cc_KnowledgesExamLibRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objcc_KnowledgesExamLibRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function cc_KnowledgesExamLibRela_UpdateWithConditionAsync(objcc_KnowledgesExamLibRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objcc_KnowledgesExamLibRelaEN.sf_UpdFldSetStr === undefined || objcc_KnowledgesExamLibRelaEN.sf_UpdFldSetStr === null || objcc_KnowledgesExamLibRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_KnowledgesExamLibRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
        objcc_KnowledgesExamLibRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objcc_KnowledgesExamLibRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_UpdateWithConditionAsync = cc_KnowledgesExamLibRela_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function cc_KnowledgesExamLibRela_IsExistRecord_Cache(objcc_KnowledgesExamLibRela_Cond, strCourseId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_Cache(strCourseId);
        if (arrcc_KnowledgesExamLibRelaObjLst_Cache == null)
            return false;
        let arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRelaObjLst_Cache;
        if (objcc_KnowledgesExamLibRela_Cond.sf_FldComparisonOp == null || objcc_KnowledgesExamLibRela_Cond.sf_FldComparisonOp == "")
            return arrcc_KnowledgesExamLibRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objcc_KnowledgesExamLibRela_Cond.sf_FldComparisonOp);
        //console.log("clscc_KnowledgesExamLibRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_KnowledgesExamLibRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_KnowledgesExamLibRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_KnowledgesExamLibRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objcc_KnowledgesExamLibRela_Cond), exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.cc_KnowledgesExamLibRela_IsExistRecord_Cache = cc_KnowledgesExamLibRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function cc_KnowledgesExamLibRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_IsExistRecordAsync = cc_KnowledgesExamLibRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function cc_KnowledgesExamLibRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_IsExist = cc_KnowledgesExamLibRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function cc_KnowledgesExamLibRela_IsExist_Cache(lngmId, strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_Cache(strCourseId);
        if (arrcc_KnowledgesExamLibRelaObjLst_Cache == null)
            return false;
        try {
            const arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrcc_KnowledgesExamLibRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.cc_KnowledgesExamLibRela_IsExist_Cache = cc_KnowledgesExamLibRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function cc_KnowledgesExamLibRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_IsExistAsync = cc_KnowledgesExamLibRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function cc_KnowledgesExamLibRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_GetRecCountByCondAsync = cc_KnowledgesExamLibRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objcc_KnowledgesExamLibRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function cc_KnowledgesExamLibRela_GetRecCountByCond_Cache(objcc_KnowledgesExamLibRela_Cond, strCourseId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrcc_KnowledgesExamLibRelaObjLst_Cache = await cc_KnowledgesExamLibRela_GetObjLst_Cache(strCourseId);
        if (arrcc_KnowledgesExamLibRelaObjLst_Cache == null)
            return 0;
        let arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRelaObjLst_Cache;
        if (objcc_KnowledgesExamLibRela_Cond.sf_FldComparisonOp == null || objcc_KnowledgesExamLibRela_Cond.sf_FldComparisonOp == "")
            return arrcc_KnowledgesExamLibRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objcc_KnowledgesExamLibRela_Cond.sf_FldComparisonOp);
        //console.log("clscc_KnowledgesExamLibRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_KnowledgesExamLibRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_KnowledgesExamLibRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrcc_KnowledgesExamLibRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objcc_KnowledgesExamLibRela_Cond), exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.cc_KnowledgesExamLibRela_GetRecCountByCond_Cache = cc_KnowledgesExamLibRela_GetRecCountByCond_Cache;
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
    async function cc_KnowledgesExamLibRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_KnowledgesExamLibRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_KnowledgesExamLibRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_KnowledgesExamLibRela_GetMaxStrIdByPrefix = cc_KnowledgesExamLibRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function cc_KnowledgesExamLibRela_GetWebApiUrl(strController, strAction) {
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
    exports.cc_KnowledgesExamLibRela_GetWebApiUrl = cc_KnowledgesExamLibRela_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function cc_KnowledgesExamLibRela_ReFreshCache(strCourseId) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clscc_KnowledgesExamLibRelaWApi.clscc_KnowledgesExamLibRelaWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clscc_KnowledgesExamLibRelaWApi.clscc_KnowledgesExamLibRelaWApi.ReFreshCache)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN._CurrTabName, strCourseId);
        switch (clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.CacheModeId) {
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
    }
    exports.cc_KnowledgesExamLibRela_ReFreshCache = cc_KnowledgesExamLibRela_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function cc_KnowledgesExamLibRela_ReFreshThisCache(strCourseId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN._CurrTabName, strCourseId);
            switch (clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.CacheModeId) {
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
    exports.cc_KnowledgesExamLibRela_ReFreshThisCache = cc_KnowledgesExamLibRela_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function cc_KnowledgesExamLibRela_CheckPropertyNew(pobjcc_KnowledgesExamLibRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.questionID) === true
            || pobjcc_KnowledgesExamLibRelaEN.questionID.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[题目ID]不能为空(In 知识点习题关系)!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) === true
            || pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[知识点Id]不能为空(In 知识点习题关系)!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.questionID) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.questionID) > 8) {
            throw new Error("(errid:Watl000059)字段[题目ID(questionID)]的长度不能超过8(In 知识点习题关系(cc_KnowledgesExamLibRela))!值:$(pobjcc_KnowledgesExamLibRelaEN.questionID)(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.courseId) > 8) {
            throw new Error("(errid:Watl000059)字段[课程Id(courseId)]的长度不能超过8(In 知识点习题关系(cc_KnowledgesExamLibRela))!值:$(pobjcc_KnowledgesExamLibRelaEN.courseId)(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) > 8) {
            throw new Error("(errid:Watl000059)字段[知识点Id(courseKnowledgeId)]的长度不能超过8(In 知识点习题关系(cc_KnowledgesExamLibRela))!值:$(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId)(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 知识点习题关系(cc_KnowledgesExamLibRela))!值:$(pobjcc_KnowledgesExamLibRelaEN.updDate)(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 知识点习题关系(cc_KnowledgesExamLibRela))!值:$(pobjcc_KnowledgesExamLibRelaEN.updUserId)(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 知识点习题关系(cc_KnowledgesExamLibRela))!值:$(pobjcc_KnowledgesExamLibRelaEN.memo)(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjcc_KnowledgesExamLibRelaEN.mId && undefined !== pobjcc_KnowledgesExamLibRelaEN.mId && clsString_js_1.tzDataType.isNumber(pobjcc_KnowledgesExamLibRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.mId)], 非法，应该为数值型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.questionID) == false && undefined !== pobjcc_KnowledgesExamLibRelaEN.questionID && clsString_js_1.tzDataType.isString(pobjcc_KnowledgesExamLibRelaEN.questionID) === false) {
            throw new Error("(errid:Watl000060)字段[题目ID(questionID)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.questionID)], 非法，应该为字符型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseId) == false && undefined !== pobjcc_KnowledgesExamLibRelaEN.courseId && clsString_js_1.tzDataType.isString(pobjcc_KnowledgesExamLibRelaEN.courseId) === false) {
            throw new Error("(errid:Watl000060)字段[课程Id(courseId)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.courseId)], 非法，应该为字符型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if (null != pobjcc_KnowledgesExamLibRelaEN.positiveCorrelation && undefined !== pobjcc_KnowledgesExamLibRelaEN.positiveCorrelation && clsString_js_1.tzDataType.isNumber(pobjcc_KnowledgesExamLibRelaEN.positiveCorrelation) === false) {
            throw new Error("(errid:Watl000060)字段[正相关度(positiveCorrelation)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.positiveCorrelation)], 非法，应该为数值型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) == false && undefined !== pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId && clsString_js_1.tzDataType.isString(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) === false) {
            throw new Error("(errid:Watl000060)字段[知识点Id(courseKnowledgeId)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId)], 非法，应该为字符型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if (null != pobjcc_KnowledgesExamLibRelaEN.negativeCorrelation && undefined !== pobjcc_KnowledgesExamLibRelaEN.negativeCorrelation && clsString_js_1.tzDataType.isNumber(pobjcc_KnowledgesExamLibRelaEN.negativeCorrelation) === false) {
            throw new Error("(errid:Watl000060)字段[负相关度(negativeCorrelation)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.negativeCorrelation)], 非法，应该为数值型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.updDate) == false && undefined !== pobjcc_KnowledgesExamLibRelaEN.updDate && clsString_js_1.tzDataType.isString(pobjcc_KnowledgesExamLibRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.updDate)], 非法，应该为字符型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.updUserId) == false && undefined !== pobjcc_KnowledgesExamLibRelaEN.updUserId && clsString_js_1.tzDataType.isString(pobjcc_KnowledgesExamLibRelaEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.updUserId)], 非法，应该为字符型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.memo) == false && undefined !== pobjcc_KnowledgesExamLibRelaEN.memo && clsString_js_1.tzDataType.isString(pobjcc_KnowledgesExamLibRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.memo)], 非法，应该为字符型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.questionID) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.questionID) != 8) {
            throw ("(errid:Watl000061)字段[题目ID]作为外键字段,长度应该为8(In 知识点习题关系)!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.courseId) != 8) {
            throw ("(errid:Watl000061)字段[课程Id]作为外键字段,长度应该为8(In 知识点习题关系)!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) != 8) {
            throw ("(errid:Watl000061)字段[知识点Id]作为外键字段,长度应该为8(In 知识点习题关系)!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjcc_KnowledgesExamLibRelaEN.SetIsCheckProperty(true);
    }
    exports.cc_KnowledgesExamLibRela_CheckPropertyNew = cc_KnowledgesExamLibRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function cc_KnowledgesExamLibRela_CheckProperty4Update(pobjcc_KnowledgesExamLibRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.questionID) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.questionID) > 8) {
            throw new Error("(errid:Watl000062)字段[题目ID(questionID)]的长度不能超过8(In 知识点习题关系(cc_KnowledgesExamLibRela))!值:$(pobjcc_KnowledgesExamLibRelaEN.questionID)(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.courseId) > 8) {
            throw new Error("(errid:Watl000062)字段[课程Id(courseId)]的长度不能超过8(In 知识点习题关系(cc_KnowledgesExamLibRela))!值:$(pobjcc_KnowledgesExamLibRelaEN.courseId)(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) > 8) {
            throw new Error("(errid:Watl000062)字段[知识点Id(courseKnowledgeId)]的长度不能超过8(In 知识点习题关系(cc_KnowledgesExamLibRela))!值:$(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId)(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 知识点习题关系(cc_KnowledgesExamLibRela))!值:$(pobjcc_KnowledgesExamLibRelaEN.updDate)(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 知识点习题关系(cc_KnowledgesExamLibRela))!值:$(pobjcc_KnowledgesExamLibRelaEN.updUserId)(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 知识点习题关系(cc_KnowledgesExamLibRela))!值:$(pobjcc_KnowledgesExamLibRelaEN.memo)(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjcc_KnowledgesExamLibRelaEN.mId && undefined !== pobjcc_KnowledgesExamLibRelaEN.mId && clsString_js_1.tzDataType.isNumber(pobjcc_KnowledgesExamLibRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.mId)], 非法，应该为数值型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.questionID) == false && undefined !== pobjcc_KnowledgesExamLibRelaEN.questionID && clsString_js_1.tzDataType.isString(pobjcc_KnowledgesExamLibRelaEN.questionID) === false) {
            throw new Error("(errid:Watl000063)字段[题目ID(questionID)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.questionID)], 非法，应该为字符型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseId) == false && undefined !== pobjcc_KnowledgesExamLibRelaEN.courseId && clsString_js_1.tzDataType.isString(pobjcc_KnowledgesExamLibRelaEN.courseId) === false) {
            throw new Error("(errid:Watl000063)字段[课程Id(courseId)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.courseId)], 非法，应该为字符型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if (null != pobjcc_KnowledgesExamLibRelaEN.positiveCorrelation && undefined !== pobjcc_KnowledgesExamLibRelaEN.positiveCorrelation && clsString_js_1.tzDataType.isNumber(pobjcc_KnowledgesExamLibRelaEN.positiveCorrelation) === false) {
            throw new Error("(errid:Watl000063)字段[正相关度(positiveCorrelation)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.positiveCorrelation)], 非法，应该为数值型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) == false && undefined !== pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId && clsString_js_1.tzDataType.isString(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) === false) {
            throw new Error("(errid:Watl000063)字段[知识点Id(courseKnowledgeId)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId)], 非法，应该为字符型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if (null != pobjcc_KnowledgesExamLibRelaEN.negativeCorrelation && undefined !== pobjcc_KnowledgesExamLibRelaEN.negativeCorrelation && clsString_js_1.tzDataType.isNumber(pobjcc_KnowledgesExamLibRelaEN.negativeCorrelation) === false) {
            throw new Error("(errid:Watl000063)字段[负相关度(negativeCorrelation)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.negativeCorrelation)], 非法，应该为数值型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.updDate) == false && undefined !== pobjcc_KnowledgesExamLibRelaEN.updDate && clsString_js_1.tzDataType.isString(pobjcc_KnowledgesExamLibRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.updDate)], 非法，应该为字符型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.updUserId) == false && undefined !== pobjcc_KnowledgesExamLibRelaEN.updUserId && clsString_js_1.tzDataType.isString(pobjcc_KnowledgesExamLibRelaEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.updUserId)], 非法，应该为字符型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.memo) == false && undefined !== pobjcc_KnowledgesExamLibRelaEN.memo && clsString_js_1.tzDataType.isString(pobjcc_KnowledgesExamLibRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjcc_KnowledgesExamLibRelaEN.memo)], 非法，应该为字符型(In 知识点习题关系(cc_KnowledgesExamLibRela))!(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjcc_KnowledgesExamLibRelaEN.mId
            || pobjcc_KnowledgesExamLibRelaEN.mId != null && pobjcc_KnowledgesExamLibRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 知识点习题关系)!(clscc_KnowledgesExamLibRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.questionID) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.questionID) != 8) {
            throw ("(errid:Watl000065)字段[题目ID]作为外键字段,长度应该为8(In 知识点习题关系)!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.courseId) != 8) {
            throw ("(errid:Watl000065)字段[课程Id]作为外键字段,长度应该为8(In 知识点习题关系)!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_KnowledgesExamLibRelaEN.courseKnowledgeId) != 8) {
            throw ("(errid:Watl000065)字段[知识点Id]作为外键字段,长度应该为8(In 知识点习题关系)!(clscc_KnowledgesExamLibRelaBL:CheckPropertyNew)");
        }
        pobjcc_KnowledgesExamLibRelaEN.SetIsCheckProperty(true);
    }
    exports.cc_KnowledgesExamLibRela_CheckProperty4Update = cc_KnowledgesExamLibRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function cc_KnowledgesExamLibRela_GetJSONStrByObj(pobjcc_KnowledgesExamLibRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjcc_KnowledgesExamLibRelaEN.sf_UpdFldSetStr = pobjcc_KnowledgesExamLibRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjcc_KnowledgesExamLibRelaEN);
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
    exports.cc_KnowledgesExamLibRela_GetJSONStrByObj = cc_KnowledgesExamLibRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function cc_KnowledgesExamLibRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrcc_KnowledgesExamLibRelaObjLst = new Array();
        if (strJSON === "") {
            return arrcc_KnowledgesExamLibRelaObjLst;
        }
        try {
            arrcc_KnowledgesExamLibRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrcc_KnowledgesExamLibRelaObjLst;
        }
        return arrcc_KnowledgesExamLibRelaObjLst;
    }
    exports.cc_KnowledgesExamLibRela_GetObjLstByJSONStr = cc_KnowledgesExamLibRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrcc_KnowledgesExamLibRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst(arrcc_KnowledgesExamLibRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrcc_KnowledgesExamLibRelaObjLst = new Array();
        for (const objInFor of arrcc_KnowledgesExamLibRelaObjLstS) {
            const obj1 = cc_KnowledgesExamLibRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrcc_KnowledgesExamLibRelaObjLst.push(obj1);
        }
        return arrcc_KnowledgesExamLibRelaObjLst;
    }
    exports.cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst = cc_KnowledgesExamLibRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function cc_KnowledgesExamLibRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjcc_KnowledgesExamLibRelaEN = new clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN();
        if (strJSON === "") {
            return pobjcc_KnowledgesExamLibRelaEN;
        }
        try {
            pobjcc_KnowledgesExamLibRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjcc_KnowledgesExamLibRelaEN;
        }
        return pobjcc_KnowledgesExamLibRelaEN;
    }
    exports.cc_KnowledgesExamLibRela_GetObjByJSONStr = cc_KnowledgesExamLibRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function cc_KnowledgesExamLibRela_GetCombineCondition(objcc_KnowledgesExamLibRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp, clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_mId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_mId, objcc_KnowledgesExamLibRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp, clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_QuestionID) == true) {
            const strComparisonOp_QuestionID = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_QuestionID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_QuestionID, objcc_KnowledgesExamLibRela_Cond.questionID, strComparisonOp_QuestionID);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp, clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseId, objcc_KnowledgesExamLibRela_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp, clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_PositiveCorrelation) == true) {
            const strComparisonOp_PositiveCorrelation = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_PositiveCorrelation];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_PositiveCorrelation, objcc_KnowledgesExamLibRela_Cond.positiveCorrelation, strComparisonOp_PositiveCorrelation);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp, clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseKnowledgeId) == true) {
            const strComparisonOp_CourseKnowledgeId = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseKnowledgeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseKnowledgeId, objcc_KnowledgesExamLibRela_Cond.courseKnowledgeId, strComparisonOp_CourseKnowledgeId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp, clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_NegativeCorrelation) == true) {
            const strComparisonOp_NegativeCorrelation = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_NegativeCorrelation];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_NegativeCorrelation, objcc_KnowledgesExamLibRela_Cond.negativeCorrelation, strComparisonOp_NegativeCorrelation);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp, clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_UpdDate, objcc_KnowledgesExamLibRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp, clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_UpdUserId, objcc_KnowledgesExamLibRela_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp, clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_Memo, objcc_KnowledgesExamLibRela_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.cc_KnowledgesExamLibRela_GetCombineCondition = cc_KnowledgesExamLibRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--cc_KnowledgesExamLibRela(知识点习题关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strQuestionID: 题目ID(要求唯一的字段)
    * @param strCourseKnowledgeId: 知识点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function cc_KnowledgesExamLibRela_GetUniCondStr_CourseKnowledgeId_QuestionID(objcc_KnowledgesExamLibRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and QuestionID = '{0}'", objcc_KnowledgesExamLibRelaEN.questionID);
        strWhereCond += (0, clsString_js_2.Format)(" and CourseKnowledgeId = '{0}'", objcc_KnowledgesExamLibRelaEN.courseKnowledgeId);
        return strWhereCond;
    }
    exports.cc_KnowledgesExamLibRela_GetUniCondStr_CourseKnowledgeId_QuestionID = cc_KnowledgesExamLibRela_GetUniCondStr_CourseKnowledgeId_QuestionID;
    /**
    *获取唯一性条件串(Uniqueness)--cc_KnowledgesExamLibRela(知识点习题关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strQuestionID: 题目ID(要求唯一的字段)
    * @param strCourseKnowledgeId: 知识点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function cc_KnowledgesExamLibRela_GetUniCondStr4Update_CourseKnowledgeId_QuestionID(objcc_KnowledgesExamLibRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId <> '{0}'", objcc_KnowledgesExamLibRelaEN.mId);
        strWhereCond += (0, clsString_js_2.Format)(" and QuestionID = '{0}'", objcc_KnowledgesExamLibRelaEN.questionID);
        strWhereCond += (0, clsString_js_2.Format)(" and CourseKnowledgeId = '{0}'", objcc_KnowledgesExamLibRelaEN.courseKnowledgeId);
        return strWhereCond;
    }
    exports.cc_KnowledgesExamLibRela_GetUniCondStr4Update_CourseKnowledgeId_QuestionID = cc_KnowledgesExamLibRela_GetUniCondStr4Update_CourseKnowledgeId_QuestionID;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objcc_KnowledgesExamLibRelaENS:源对象
     * @param objcc_KnowledgesExamLibRelaENT:目标对象
    */
    function cc_KnowledgesExamLibRela_CopyObjTo(objcc_KnowledgesExamLibRelaENS, objcc_KnowledgesExamLibRelaENT) {
        objcc_KnowledgesExamLibRelaENT.mId = objcc_KnowledgesExamLibRelaENS.mId; //mId
        objcc_KnowledgesExamLibRelaENT.questionID = objcc_KnowledgesExamLibRelaENS.questionID; //题目ID
        objcc_KnowledgesExamLibRelaENT.courseId = objcc_KnowledgesExamLibRelaENS.courseId; //课程Id
        objcc_KnowledgesExamLibRelaENT.positiveCorrelation = objcc_KnowledgesExamLibRelaENS.positiveCorrelation; //正相关度
        objcc_KnowledgesExamLibRelaENT.courseKnowledgeId = objcc_KnowledgesExamLibRelaENS.courseKnowledgeId; //知识点Id
        objcc_KnowledgesExamLibRelaENT.negativeCorrelation = objcc_KnowledgesExamLibRelaENS.negativeCorrelation; //负相关度
        objcc_KnowledgesExamLibRelaENT.updDate = objcc_KnowledgesExamLibRelaENS.updDate; //修改日期
        objcc_KnowledgesExamLibRelaENT.updUserId = objcc_KnowledgesExamLibRelaENS.updUserId; //修改用户Id
        objcc_KnowledgesExamLibRelaENT.memo = objcc_KnowledgesExamLibRelaENS.memo; //备注
        objcc_KnowledgesExamLibRelaENT.sf_UpdFldSetStr = objcc_KnowledgesExamLibRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.cc_KnowledgesExamLibRela_CopyObjTo = cc_KnowledgesExamLibRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objcc_KnowledgesExamLibRelaENS:源对象
     * @param objcc_KnowledgesExamLibRelaENT:目标对象
    */
    function cc_KnowledgesExamLibRela_GetObjFromJsonObj(objcc_KnowledgesExamLibRelaENS) {
        const objcc_KnowledgesExamLibRelaENT = new clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_KnowledgesExamLibRelaENT, objcc_KnowledgesExamLibRelaENS);
        return objcc_KnowledgesExamLibRelaENT;
    }
    exports.cc_KnowledgesExamLibRela_GetObjFromJsonObj = cc_KnowledgesExamLibRela_GetObjFromJsonObj;
});
