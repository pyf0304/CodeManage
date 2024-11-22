/**
* 类名:clscc_ExamPaperStuRelationWApi
* 表名:cc_ExamPaperStuRelation(01120235)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:54:46
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:互动管理(InteractManage)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/InteractManage/clscc_ExamPaperStuRelationEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_ExamPaperStuRelation_GetObjFromJsonObj = exports.cc_ExamPaperStuRelation_CopyObjTo = exports.cc_ExamPaperStuRelation_GetUniCondStr4Update_CourseExamPaperId_id_StudentInfo_id_CurrEduCls = exports.cc_ExamPaperStuRelation_GetUniCondStr_CourseExamPaperId_id_StudentInfo_id_CurrEduCls = exports.cc_ExamPaperStuRelation_GetCombineCondition = exports.cc_ExamPaperStuRelation_GetObjByJSONStr = exports.cc_ExamPaperStuRelation_GetObjLstByJSONObjLst = exports.cc_ExamPaperStuRelation_GetObjLstByJSONStr = exports.cc_ExamPaperStuRelation_GetJSONStrByObj = exports.cc_ExamPaperStuRelation_CheckProperty4Update = exports.cc_ExamPaperStuRelation_CheckPropertyNew = exports.cc_ExamPaperStuRelation_ReFreshThisCache = exports.cc_ExamPaperStuRelation_ReFreshCache = exports.cc_ExamPaperStuRelation_GetWebApiUrl = exports.cc_ExamPaperStuRelation_GetMaxStrIdByPrefix = exports.cc_ExamPaperStuRelation_GetRecCountByCond_Cache = exports.cc_ExamPaperStuRelation_GetRecCountByCondAsync = exports.cc_ExamPaperStuRelation_IsExistAsync = exports.cc_ExamPaperStuRelation_IsExist_Cache = exports.cc_ExamPaperStuRelation_IsExist = exports.cc_ExamPaperStuRelation_IsExistRecordAsync = exports.cc_ExamPaperStuRelation_IsExistRecord_Cache = exports.cc_ExamPaperStuRelation_UpdateWithConditionAsync = exports.cc_ExamPaperStuRelation_UpdateRecordAsync = exports.cc_ExamPaperStuRelation_AddNewRecordWithReturnKey = exports.cc_ExamPaperStuRelation_AddNewRecordWithReturnKeyAsync = exports.cc_ExamPaperStuRelation_AddNewRecordAsync = exports.cc_ExamPaperStuRelation_Delcc_ExamPaperStuRelationsByCondAsync = exports.cc_ExamPaperStuRelation_Delcc_ExamPaperStuRelationsAsync = exports.cc_ExamPaperStuRelation_DelRecordAsync = exports.cc_ExamPaperStuRelation_GetObjLstByPagerAsync = exports.cc_ExamPaperStuRelation_GetObjLstByPager_Cache = exports.cc_ExamPaperStuRelation_GetObjLstByRange = exports.cc_ExamPaperStuRelation_GetObjLstByRangeAsync = exports.cc_ExamPaperStuRelation_GetTopObjLstAsync = exports.cc_ExamPaperStuRelation_GetObjLstById_ExamPaperStuRelationLst_Cache = exports.cc_ExamPaperStuRelation_GetObjLstById_ExamPaperStuRelationLstAsync = exports.cc_ExamPaperStuRelation_GetSubObjLst_Cache = exports.cc_ExamPaperStuRelation_GetObjLst_PureCache = exports.cc_ExamPaperStuRelation_GetObjLst_Cache = exports.cc_ExamPaperStuRelation_GetObjLst_sessionStorage_PureCache = exports.cc_ExamPaperStuRelation_GetObjLst_sessionStorage = exports.cc_ExamPaperStuRelation_GetObjLstAsync = exports.cc_ExamPaperStuRelation_GetObjLst_localStorage_PureCache = exports.cc_ExamPaperStuRelation_GetObjLst_localStorage = exports.cc_ExamPaperStuRelation_GetObjLst_ClientCache = exports.cc_ExamPaperStuRelation_GetFirstObjAsync = exports.cc_ExamPaperStuRelation_GetFirstID = exports.cc_ExamPaperStuRelation_GetFirstIDAsync = exports.cc_ExamPaperStuRelation_funcKey = exports.cc_ExamPaperStuRelation_FilterFunByKey = exports.cc_ExamPaperStuRelation_SortFunByKey = exports.cc_ExamPaperStuRelation_SortFun_Defa_2Fld = exports.cc_ExamPaperStuRelation_SortFun_Defa = exports.cc_ExamPaperStuRelation_func = exports.cc_ExamPaperStuRelation_UpdateObjInLst_Cache = exports.cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelation_localStorage = exports.cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelation_Cache = exports.cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelationAsync = exports.cc_ExamPaperStuRelation_ConstructorName = exports.cc_ExamPaperStuRelation_Controller = void 0;
    /**
     * 考卷与学生关系(cc_ExamPaperStuRelation)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clscc_ExamPaperStuRelationEN_js_1 = require("../../L0_Entity/InteractManage/clscc_ExamPaperStuRelationEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.cc_ExamPaperStuRelation_Controller = "cc_ExamPaperStuRelationApi";
    exports.cc_ExamPaperStuRelation_ConstructorName = "cc_ExamPaperStuRelation";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngId_ExamPaperStuRelation:关键字
    * @returns 对象
    **/
    async function cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelationAsync(lngId_ExamPaperStuRelation) {
        const strThisFuncName = "GetObjById_ExamPaperStuRelationAsync";
        if (lngId_ExamPaperStuRelation == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngId_ExamPaperStuRelation]不能为空！(In clscc_ExamPaperStuRelationWApi.GetObjById_ExamPaperStuRelationAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjById_ExamPaperStuRelation";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngId_ExamPaperStuRelation": lngId_ExamPaperStuRelation,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objcc_ExamPaperStuRelation = cc_ExamPaperStuRelation_GetObjFromJsonObj(returnObj);
                return objcc_ExamPaperStuRelation;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelationAsync = cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelationAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngId_ExamPaperStuRelation:所给的关键字
     * @returns 对象
    */
    async function cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelation_Cache(lngId_ExamPaperStuRelation, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjById_ExamPaperStuRelation_Cache";
        if (lngId_ExamPaperStuRelation == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngId_ExamPaperStuRelation]不能为空！(In clscc_ExamPaperStuRelationWApi.GetObjById_ExamPaperStuRelation_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelationObjLst_Cache.filter(x => x.id_ExamPaperStuRelation == lngId_ExamPaperStuRelation);
            let objcc_ExamPaperStuRelation;
            if (arrcc_ExamPaperStuRelation_Sel.length > 0) {
                objcc_ExamPaperStuRelation = arrcc_ExamPaperStuRelation_Sel[0];
                return objcc_ExamPaperStuRelation;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objcc_ExamPaperStuRelation_Const = await cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelationAsync(lngId_ExamPaperStuRelation);
                    if (objcc_ExamPaperStuRelation_Const != null) {
                        cc_ExamPaperStuRelation_ReFreshThisCache(strid_CurrEduCls);
                        return objcc_ExamPaperStuRelation_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngId_ExamPaperStuRelation, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelation_Cache = cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelation_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngId_ExamPaperStuRelation:所给的关键字
     * @returns 对象
    */
    async function cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelation_localStorage(lngId_ExamPaperStuRelation) {
        const strThisFuncName = "GetObjById_ExamPaperStuRelation_localStorage";
        if (lngId_ExamPaperStuRelation == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngId_ExamPaperStuRelation]不能为空！(In clscc_ExamPaperStuRelationWApi.GetObjById_ExamPaperStuRelation_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN._CurrTabName, lngId_ExamPaperStuRelation);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objcc_ExamPaperStuRelation_Cache = JSON.parse(strTempObj);
            return objcc_ExamPaperStuRelation_Cache;
        }
        try {
            const objcc_ExamPaperStuRelation = await cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelationAsync(lngId_ExamPaperStuRelation);
            if (objcc_ExamPaperStuRelation != null) {
                localStorage.setItem(strKey, JSON.stringify(objcc_ExamPaperStuRelation));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objcc_ExamPaperStuRelation;
            }
            return objcc_ExamPaperStuRelation;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngId_ExamPaperStuRelation, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelation_localStorage = cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelation_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objcc_ExamPaperStuRelation:所给的对象
     * @returns 对象
    */
    async function cc_ExamPaperStuRelation_UpdateObjInLst_Cache(objcc_ExamPaperStuRelation, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrcc_ExamPaperStuRelationObjLst_Cache.find(x => x.courseExamPaperId == objcc_ExamPaperStuRelation.courseExamPaperId && x.id_StudentInfo == objcc_ExamPaperStuRelation.id_StudentInfo && x.id_CurrEduCls == objcc_ExamPaperStuRelation.id_CurrEduCls);
            if (obj != null) {
                objcc_ExamPaperStuRelation.id_ExamPaperStuRelation = obj.id_ExamPaperStuRelation;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objcc_ExamPaperStuRelation);
            }
            else {
                arrcc_ExamPaperStuRelationObjLst_Cache.push(objcc_ExamPaperStuRelation);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_ExamPaperStuRelation_UpdateObjInLst_Cache = cc_ExamPaperStuRelation_UpdateObjInLst_Cache;
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
    async function cc_ExamPaperStuRelation_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clscc_ExamPaperStuRelationWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clscc_ExamPaperStuRelationWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Id_ExamPaperStuRelation) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngId_ExamPaperStuRelation = Number(strInValue);
        if (lngId_ExamPaperStuRelation == 0) {
            return "";
        }
        const objcc_ExamPaperStuRelation = await cc_ExamPaperStuRelation_GetObjById_ExamPaperStuRelation_Cache(lngId_ExamPaperStuRelation, strid_CurrEduCls_C);
        if (objcc_ExamPaperStuRelation == null)
            return "";
        if (objcc_ExamPaperStuRelation.GetFldValue(strOutFldName) == null)
            return "";
        return objcc_ExamPaperStuRelation.GetFldValue(strOutFldName).toString();
    }
    exports.cc_ExamPaperStuRelation_func = cc_ExamPaperStuRelation_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_ExamPaperStuRelation_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_ExamPaperStuRelation - b.id_ExamPaperStuRelation;
    }
    exports.cc_ExamPaperStuRelation_SortFun_Defa = cc_ExamPaperStuRelation_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_ExamPaperStuRelation_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.courseExamPaperId == b.courseExamPaperId)
            return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
        else
            return a.courseExamPaperId.localeCompare(b.courseExamPaperId);
    }
    exports.cc_ExamPaperStuRelation_SortFun_Defa_2Fld = cc_ExamPaperStuRelation_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_ExamPaperStuRelation_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Id_ExamPaperStuRelation:
                    return (a, b) => {
                        return a.id_ExamPaperStuRelation - b.id_ExamPaperStuRelation;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_CourseExamPaperId:
                    return (a, b) => {
                        if (a.courseExamPaperId == null)
                            return -1;
                        if (b.courseExamPaperId == null)
                            return 1;
                        return a.courseExamPaperId.localeCompare(b.courseExamPaperId);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Scores:
                    return (a, b) => {
                        return a.scores - b.scores;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SpecifyCompletionDate:
                    return (a, b) => {
                        return a.specifyCompletionDate.localeCompare(b.specifyCompletionDate);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_id_StudentInfo:
                    return (a, b) => {
                        return a.id_StudentInfo.localeCompare(b.id_StudentInfo);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerModeId:
                    return (a, b) => {
                        if (a.answerModeId == null)
                            return -1;
                        if (b.answerModeId == null)
                            return 1;
                        return a.answerModeId.localeCompare(b.answerModeId);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerOptionId:
                    return (a, b) => {
                        if (a.answerOptionId == null)
                            return -1;
                        if (b.answerOptionId == null)
                            return 1;
                        return a.answerOptionId.localeCompare(b.answerOptionId);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerMultiOptions:
                    return (a, b) => {
                        if (a.answerMultiOptions == null)
                            return -1;
                        if (b.answerMultiOptions == null)
                            return 1;
                        return a.answerMultiOptions.localeCompare(b.answerMultiOptions);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_StuAnswerText:
                    return (a, b) => {
                        if (a.stuAnswerText == null)
                            return -1;
                        if (b.stuAnswerText == null)
                            return 1;
                        return a.stuAnswerText.localeCompare(b.stuAnswerText);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsPublish:
                    return (a, b) => {
                        if (a.isPublish == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsLook:
                    return (a, b) => {
                        if (a.isLook == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSave:
                    return (a, b) => {
                        if (a.isSave == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_ApplySendBackDate:
                    return (a, b) => {
                        if (a.applySendBackDate == null)
                            return -1;
                        if (b.applySendBackDate == null)
                            return 1;
                        return a.applySendBackDate.localeCompare(b.applySendBackDate);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsApplySendBack:
                    return (a, b) => {
                        if (a.isApplySendBack == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_RealFinishDate:
                    return (a, b) => {
                        if (a.realFinishDate == null)
                            return -1;
                        if (b.realFinishDate == null)
                            return 1;
                        return a.realFinishDate.localeCompare(b.realFinishDate);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_OperateTime:
                    return (a, b) => {
                        if (a.operateTime == null)
                            return -1;
                        if (b.operateTime == null)
                            return 1;
                        return a.operateTime.localeCompare(b.operateTime);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Comment:
                    return (a, b) => {
                        if (a.comment == null)
                            return -1;
                        if (b.comment == null)
                            return 1;
                        return a.comment.localeCompare(b.comment);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsMarking:
                    return (a, b) => {
                        if (a.isMarking == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_MarkerId:
                    return (a, b) => {
                        if (a.markerId == null)
                            return -1;
                        if (b.markerId == null)
                            return 1;
                        return a.markerId.localeCompare(b.markerId);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_MarkDate:
                    return (a, b) => {
                        if (a.markDate == null)
                            return -1;
                        if (b.markDate == null)
                            return 1;
                        return a.markDate.localeCompare(b.markDate);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSendBack:
                    return (a, b) => {
                        if (a.isSendBack == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsInErrorQuestion:
                    return (a, b) => {
                        if (a.isInErrorQuestion == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_WorkTypeId:
                    return (a, b) => {
                        return a.workTypeId.localeCompare(b.workTypeId);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerIP:
                    return (a, b) => {
                        if (a.answerIP == null)
                            return -1;
                        if (b.answerIP == null)
                            return 1;
                        return a.answerIP.localeCompare(b.answerIP);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerDate:
                    return (a, b) => {
                        if (a.answerDate == null)
                            return -1;
                        if (b.answerDate == null)
                            return 1;
                        return a.answerDate.localeCompare(b.answerDate);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerTime:
                    return (a, b) => {
                        if (a.answerTime == null)
                            return -1;
                        if (b.answerTime == null)
                            return 1;
                        return a.answerTime.localeCompare(b.answerTime);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsRight:
                    return (a, b) => {
                        if (a.isRight == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsAccessKnowledge:
                    return (a, b) => {
                        if (a.isAccessKnowledge == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsNotProcessTimeout:
                    return (a, b) => {
                        if (a.isNotProcessTimeout == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SchoolYear:
                    return (a, b) => {
                        if (a.schoolYear == null)
                            return -1;
                        if (b.schoolYear == null)
                            return 1;
                        return a.schoolYear.localeCompare(b.schoolYear);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SchoolTerm:
                    return (a, b) => {
                        if (a.schoolTerm == null)
                            return -1;
                        if (b.schoolTerm == null)
                            return 1;
                        return a.schoolTerm.localeCompare(b.schoolTerm);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_UpdUserId:
                    return (a, b) => {
                        if (a.updUserId == null)
                            return -1;
                        if (b.updUserId == null)
                            return 1;
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[cc_ExamPaperStuRelation]中不存在！(in ${exports.cc_ExamPaperStuRelation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Id_ExamPaperStuRelation:
                    return (a, b) => {
                        return b.id_ExamPaperStuRelation - a.id_ExamPaperStuRelation;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_CourseExamPaperId:
                    return (a, b) => {
                        if (b.courseExamPaperId == null)
                            return -1;
                        if (a.courseExamPaperId == null)
                            return 1;
                        return b.courseExamPaperId.localeCompare(a.courseExamPaperId);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Scores:
                    return (a, b) => {
                        return b.scores - a.scores;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SpecifyCompletionDate:
                    return (a, b) => {
                        return b.specifyCompletionDate.localeCompare(a.specifyCompletionDate);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_id_StudentInfo:
                    return (a, b) => {
                        return b.id_StudentInfo.localeCompare(a.id_StudentInfo);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerModeId:
                    return (a, b) => {
                        if (b.answerModeId == null)
                            return -1;
                        if (a.answerModeId == null)
                            return 1;
                        return b.answerModeId.localeCompare(a.answerModeId);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerOptionId:
                    return (a, b) => {
                        if (b.answerOptionId == null)
                            return -1;
                        if (a.answerOptionId == null)
                            return 1;
                        return b.answerOptionId.localeCompare(a.answerOptionId);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerMultiOptions:
                    return (a, b) => {
                        if (b.answerMultiOptions == null)
                            return -1;
                        if (a.answerMultiOptions == null)
                            return 1;
                        return b.answerMultiOptions.localeCompare(a.answerMultiOptions);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_StuAnswerText:
                    return (a, b) => {
                        if (b.stuAnswerText == null)
                            return -1;
                        if (a.stuAnswerText == null)
                            return 1;
                        return b.stuAnswerText.localeCompare(a.stuAnswerText);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsPublish:
                    return (a, b) => {
                        if (b.isPublish == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsLook:
                    return (a, b) => {
                        if (b.isLook == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSave:
                    return (a, b) => {
                        if (b.isSave == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_ApplySendBackDate:
                    return (a, b) => {
                        if (b.applySendBackDate == null)
                            return -1;
                        if (a.applySendBackDate == null)
                            return 1;
                        return b.applySendBackDate.localeCompare(a.applySendBackDate);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsApplySendBack:
                    return (a, b) => {
                        if (b.isApplySendBack == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_RealFinishDate:
                    return (a, b) => {
                        if (b.realFinishDate == null)
                            return -1;
                        if (a.realFinishDate == null)
                            return 1;
                        return b.realFinishDate.localeCompare(a.realFinishDate);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_OperateTime:
                    return (a, b) => {
                        if (b.operateTime == null)
                            return -1;
                        if (a.operateTime == null)
                            return 1;
                        return b.operateTime.localeCompare(a.operateTime);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Comment:
                    return (a, b) => {
                        if (b.comment == null)
                            return -1;
                        if (a.comment == null)
                            return 1;
                        return b.comment.localeCompare(a.comment);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsMarking:
                    return (a, b) => {
                        if (b.isMarking == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_MarkerId:
                    return (a, b) => {
                        if (b.markerId == null)
                            return -1;
                        if (a.markerId == null)
                            return 1;
                        return b.markerId.localeCompare(a.markerId);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_MarkDate:
                    return (a, b) => {
                        if (b.markDate == null)
                            return -1;
                        if (a.markDate == null)
                            return 1;
                        return b.markDate.localeCompare(a.markDate);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSendBack:
                    return (a, b) => {
                        if (b.isSendBack == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsInErrorQuestion:
                    return (a, b) => {
                        if (b.isInErrorQuestion == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_WorkTypeId:
                    return (a, b) => {
                        return b.workTypeId.localeCompare(a.workTypeId);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerIP:
                    return (a, b) => {
                        if (b.answerIP == null)
                            return -1;
                        if (a.answerIP == null)
                            return 1;
                        return b.answerIP.localeCompare(a.answerIP);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerDate:
                    return (a, b) => {
                        if (b.answerDate == null)
                            return -1;
                        if (a.answerDate == null)
                            return 1;
                        return b.answerDate.localeCompare(a.answerDate);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerTime:
                    return (a, b) => {
                        if (b.answerTime == null)
                            return -1;
                        if (a.answerTime == null)
                            return 1;
                        return b.answerTime.localeCompare(a.answerTime);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsRight:
                    return (a, b) => {
                        if (b.isRight == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsAccessKnowledge:
                    return (a, b) => {
                        if (b.isAccessKnowledge == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsNotProcessTimeout:
                    return (a, b) => {
                        if (b.isNotProcessTimeout == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SchoolYear:
                    return (a, b) => {
                        if (b.schoolYear == null)
                            return -1;
                        if (a.schoolYear == null)
                            return 1;
                        return b.schoolYear.localeCompare(a.schoolYear);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SchoolTerm:
                    return (a, b) => {
                        if (b.schoolTerm == null)
                            return -1;
                        if (a.schoolTerm == null)
                            return 1;
                        return b.schoolTerm.localeCompare(a.schoolTerm);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_UpdUserId:
                    return (a, b) => {
                        if (b.updUserId == null)
                            return -1;
                        if (a.updUserId == null)
                            return 1;
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[cc_ExamPaperStuRelation]中不存在！(in ${exports.cc_ExamPaperStuRelation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.cc_ExamPaperStuRelation_SortFunByKey = cc_ExamPaperStuRelation_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function cc_ExamPaperStuRelation_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Id_ExamPaperStuRelation:
                return (obj) => {
                    return obj.id_ExamPaperStuRelation === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_CourseExamPaperId:
                return (obj) => {
                    return obj.courseExamPaperId === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Scores:
                return (obj) => {
                    return obj.scores === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SpecifyCompletionDate:
                return (obj) => {
                    return obj.specifyCompletionDate === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_id_StudentInfo:
                return (obj) => {
                    return obj.id_StudentInfo === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerModeId:
                return (obj) => {
                    return obj.answerModeId === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerOptionId:
                return (obj) => {
                    return obj.answerOptionId === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerMultiOptions:
                return (obj) => {
                    return obj.answerMultiOptions === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_StuAnswerText:
                return (obj) => {
                    return obj.stuAnswerText === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsPublish:
                return (obj) => {
                    return obj.isPublish === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsLook:
                return (obj) => {
                    return obj.isLook === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSave:
                return (obj) => {
                    return obj.isSave === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_ApplySendBackDate:
                return (obj) => {
                    return obj.applySendBackDate === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsApplySendBack:
                return (obj) => {
                    return obj.isApplySendBack === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_RealFinishDate:
                return (obj) => {
                    return obj.realFinishDate === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_OperateTime:
                return (obj) => {
                    return obj.operateTime === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Comment:
                return (obj) => {
                    return obj.comment === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsMarking:
                return (obj) => {
                    return obj.isMarking === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_MarkerId:
                return (obj) => {
                    return obj.markerId === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_MarkDate:
                return (obj) => {
                    return obj.markDate === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSendBack:
                return (obj) => {
                    return obj.isSendBack === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsInErrorQuestion:
                return (obj) => {
                    return obj.isInErrorQuestion === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_WorkTypeId:
                return (obj) => {
                    return obj.workTypeId === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerIP:
                return (obj) => {
                    return obj.answerIP === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerDate:
                return (obj) => {
                    return obj.answerDate === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerTime:
                return (obj) => {
                    return obj.answerTime === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsRight:
                return (obj) => {
                    return obj.isRight === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsAccessKnowledge:
                return (obj) => {
                    return obj.isAccessKnowledge === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsNotProcessTimeout:
                return (obj) => {
                    return obj.isNotProcessTimeout === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SchoolYear:
                return (obj) => {
                    return obj.schoolYear === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SchoolTerm:
                return (obj) => {
                    return obj.schoolTerm === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[cc_ExamPaperStuRelation]中不存在！(in ${exports.cc_ExamPaperStuRelation_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.cc_ExamPaperStuRelation_FilterFunByKey = cc_ExamPaperStuRelation_FilterFunByKey;
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
    async function cc_ExamPaperStuRelation_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clscc_ExamPaperStuRelationWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clscc_ExamPaperStuRelationWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Id_ExamPaperStuRelation) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrcc_ExamPaperStuRelation = await cc_ExamPaperStuRelation_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrcc_ExamPaperStuRelation == null)
            return [];
        let arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrcc_ExamPaperStuRelation_Sel.length == 0)
            return [];
        return arrcc_ExamPaperStuRelation_Sel.map(x => x.id_ExamPaperStuRelation);
    }
    exports.cc_ExamPaperStuRelation_funcKey = cc_ExamPaperStuRelation_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function cc_ExamPaperStuRelation_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_GetFirstIDAsync = cc_ExamPaperStuRelation_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function cc_ExamPaperStuRelation_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_GetFirstID = cc_ExamPaperStuRelation_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function cc_ExamPaperStuRelation_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
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
                const objcc_ExamPaperStuRelation = cc_ExamPaperStuRelation_GetObjFromJsonObj(returnObj);
                return objcc_ExamPaperStuRelation;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_GetFirstObjAsync = cc_ExamPaperStuRelation_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_ExamPaperStuRelation_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrcc_ExamPaperStuRelationExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrcc_ExamPaperStuRelationObjLst_T = cc_ExamPaperStuRelation_GetObjLstByJSONObjLst(arrcc_ExamPaperStuRelationExObjLst_Cache);
            return arrcc_ExamPaperStuRelationObjLst_T;
        }
        try {
            const arrcc_ExamPaperStuRelationExObjLst = await cc_ExamPaperStuRelation_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrcc_ExamPaperStuRelationExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_ExamPaperStuRelationExObjLst.length);
            console.log(strInfo);
            return arrcc_ExamPaperStuRelationExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_ExamPaperStuRelation_GetObjLst_ClientCache = cc_ExamPaperStuRelation_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_ExamPaperStuRelation_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrcc_ExamPaperStuRelationExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrcc_ExamPaperStuRelationObjLst_T = cc_ExamPaperStuRelation_GetObjLstByJSONObjLst(arrcc_ExamPaperStuRelationExObjLst_Cache);
            return arrcc_ExamPaperStuRelationObjLst_T;
        }
        try {
            const arrcc_ExamPaperStuRelationExObjLst = await cc_ExamPaperStuRelation_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrcc_ExamPaperStuRelationExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_ExamPaperStuRelationExObjLst.length);
            console.log(strInfo);
            return arrcc_ExamPaperStuRelationExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_ExamPaperStuRelation_GetObjLst_localStorage = cc_ExamPaperStuRelation_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_ExamPaperStuRelation_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrcc_ExamPaperStuRelationObjLst_Cache = JSON.parse(strTempObjLst);
            return arrcc_ExamPaperStuRelationObjLst_Cache;
        }
        else
            return null;
    }
    exports.cc_ExamPaperStuRelation_GetObjLst_localStorage_PureCache = cc_ExamPaperStuRelation_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function cc_ExamPaperStuRelation_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_ExamPaperStuRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_GetObjLstAsync = cc_ExamPaperStuRelation_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_ExamPaperStuRelation_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrcc_ExamPaperStuRelationExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrcc_ExamPaperStuRelationObjLst_T = cc_ExamPaperStuRelation_GetObjLstByJSONObjLst(arrcc_ExamPaperStuRelationExObjLst_Cache);
            return arrcc_ExamPaperStuRelationObjLst_T;
        }
        try {
            const arrcc_ExamPaperStuRelationExObjLst = await cc_ExamPaperStuRelation_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrcc_ExamPaperStuRelationExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_ExamPaperStuRelationExObjLst.length);
            console.log(strInfo);
            return arrcc_ExamPaperStuRelationExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_ExamPaperStuRelation_GetObjLst_sessionStorage = cc_ExamPaperStuRelation_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_ExamPaperStuRelation_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrcc_ExamPaperStuRelationObjLst_Cache = JSON.parse(strTempObjLst);
            return arrcc_ExamPaperStuRelationObjLst_Cache;
        }
        else
            return null;
    }
    exports.cc_ExamPaperStuRelation_GetObjLst_sessionStorage_PureCache = cc_ExamPaperStuRelation_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_ExamPaperStuRelation_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clscc_ExamPaperStuRelationWApi.cc_ExamPaperStuRelation_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clscc_ExamPaperStuRelationWApi.cc_ExamPaperStuRelation_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrcc_ExamPaperStuRelationObjLst_Cache;
        switch (clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.CacheModeId) {
            case "04": //sessionStorage
                arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrcc_ExamPaperStuRelationObjLst = cc_ExamPaperStuRelation_GetObjLstByJSONObjLst(arrcc_ExamPaperStuRelationObjLst_Cache);
        return arrcc_ExamPaperStuRelationObjLst_Cache;
    }
    exports.cc_ExamPaperStuRelation_GetObjLst_Cache = cc_ExamPaperStuRelation_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_ExamPaperStuRelation_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrcc_ExamPaperStuRelationObjLst_Cache;
        switch (clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.CacheModeId) {
            case "04": //sessionStorage
                arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrcc_ExamPaperStuRelationObjLst_Cache = null;
                break;
            default:
                arrcc_ExamPaperStuRelationObjLst_Cache = null;
                break;
        }
        return arrcc_ExamPaperStuRelationObjLst_Cache;
    }
    exports.cc_ExamPaperStuRelation_GetObjLst_PureCache = cc_ExamPaperStuRelation_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngId_ExamPaperStuRelation_Cond:条件对象
     * @returns 对象列表子集
    */
    async function cc_ExamPaperStuRelation_GetSubObjLst_Cache(objcc_ExamPaperStuRelation_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_Cache(strid_CurrEduCls);
        let arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelationObjLst_Cache;
        if (objcc_ExamPaperStuRelation_Cond.sf_FldComparisonOp == null || objcc_ExamPaperStuRelation_Cond.sf_FldComparisonOp == "")
            return arrcc_ExamPaperStuRelation_Sel;
        const dicFldComparisonOp = JSON.parse(objcc_ExamPaperStuRelation_Cond.sf_FldComparisonOp);
        //console.log("clscc_ExamPaperStuRelationWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_ExamPaperStuRelation_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_ExamPaperStuRelation_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrcc_ExamPaperStuRelation_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objcc_ExamPaperStuRelation_Cond), exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_ExamPaperStuRelation_GetSubObjLst_Cache = cc_ExamPaperStuRelation_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrId_ExamPaperStuRelation:关键字列表
    * @returns 对象列表
    **/
    async function cc_ExamPaperStuRelation_GetObjLstById_ExamPaperStuRelationLstAsync(arrId_ExamPaperStuRelation) {
        const strThisFuncName = "GetObjLstById_ExamPaperStuRelationLstAsync";
        const strAction = "GetObjLstById_ExamPaperStuRelationLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrId_ExamPaperStuRelation);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_ExamPaperStuRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_GetObjLstById_ExamPaperStuRelationLstAsync = cc_ExamPaperStuRelation_GetObjLstById_ExamPaperStuRelationLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngId_ExamPaperStuRelationLst:关键字列表
     * @returns 对象列表
    */
    async function cc_ExamPaperStuRelation_GetObjLstById_ExamPaperStuRelationLst_Cache(arrId_ExamPaperStuRelationLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstById_ExamPaperStuRelationLst_Cache";
        try {
            const arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_Cache(strid_CurrEduCls);
            const arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelationObjLst_Cache.filter(x => arrId_ExamPaperStuRelationLst.indexOf(x.id_ExamPaperStuRelation) > -1);
            return arrcc_ExamPaperStuRelation_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrId_ExamPaperStuRelationLst.join(","), exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.cc_ExamPaperStuRelation_GetObjLstById_ExamPaperStuRelationLst_Cache = cc_ExamPaperStuRelation_GetObjLstById_ExamPaperStuRelationLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function cc_ExamPaperStuRelation_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_ExamPaperStuRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_GetTopObjLstAsync = cc_ExamPaperStuRelation_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function cc_ExamPaperStuRelation_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_ExamPaperStuRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_GetObjLstByRangeAsync = cc_ExamPaperStuRelation_GetObjLstByRangeAsync;
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
    async function cc_ExamPaperStuRelation_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_GetObjLstByRange = cc_ExamPaperStuRelation_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function cc_ExamPaperStuRelation_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_Cache(strid_CurrEduCls);
        if (arrcc_ExamPaperStuRelationObjLst_Cache.length == 0)
            return arrcc_ExamPaperStuRelationObjLst_Cache;
        let arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelationObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objcc_ExamPaperStuRelation_Cond = new clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_ExamPaperStuRelation_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clscc_ExamPaperStuRelationWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_ExamPaperStuRelation_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_ExamPaperStuRelation_Sel.length == 0)
                return arrcc_ExamPaperStuRelation_Sel;
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
                arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.sort(cc_ExamPaperStuRelation_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.sort(objPagerPara.sortFun);
            }
            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.slice(intStart, intEnd);
            return arrcc_ExamPaperStuRelation_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_ExamPaperStuRelation_GetObjLstByPager_Cache = cc_ExamPaperStuRelation_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function cc_ExamPaperStuRelation_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_ExamPaperStuRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_GetObjLstByPagerAsync = cc_ExamPaperStuRelation_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngId_ExamPaperStuRelation:关键字
    * @returns 获取删除的结果
    **/
    async function cc_ExamPaperStuRelation_DelRecordAsync(lngId_ExamPaperStuRelation) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngId_ExamPaperStuRelation);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_DelRecordAsync = cc_ExamPaperStuRelation_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrId_ExamPaperStuRelation:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function cc_ExamPaperStuRelation_Delcc_ExamPaperStuRelationsAsync(arrId_ExamPaperStuRelation) {
        const strThisFuncName = "Delcc_ExamPaperStuRelationsAsync";
        const strAction = "Delcc_ExamPaperStuRelations";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrId_ExamPaperStuRelation);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_Delcc_ExamPaperStuRelationsAsync = cc_ExamPaperStuRelation_Delcc_ExamPaperStuRelationsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function cc_ExamPaperStuRelation_Delcc_ExamPaperStuRelationsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delcc_ExamPaperStuRelationsByCondAsync";
        const strAction = "Delcc_ExamPaperStuRelationsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_Delcc_ExamPaperStuRelationsByCondAsync = cc_ExamPaperStuRelation_Delcc_ExamPaperStuRelationsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objcc_ExamPaperStuRelationEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_ExamPaperStuRelation_AddNewRecordAsync(objcc_ExamPaperStuRelationEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objcc_ExamPaperStuRelationEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_ExamPaperStuRelationEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_AddNewRecordAsync = cc_ExamPaperStuRelation_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objcc_ExamPaperStuRelationEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function cc_ExamPaperStuRelation_AddNewRecordWithReturnKeyAsync(objcc_ExamPaperStuRelationEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_ExamPaperStuRelationEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_AddNewRecordWithReturnKeyAsync = cc_ExamPaperStuRelation_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objcc_ExamPaperStuRelationEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function cc_ExamPaperStuRelation_AddNewRecordWithReturnKey(objcc_ExamPaperStuRelationEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation === null || objcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_ExamPaperStuRelationEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_AddNewRecordWithReturnKey = cc_ExamPaperStuRelation_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objcc_ExamPaperStuRelationEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function cc_ExamPaperStuRelation_UpdateRecordAsync(objcc_ExamPaperStuRelationEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objcc_ExamPaperStuRelationEN.sf_UpdFldSetStr === undefined || objcc_ExamPaperStuRelationEN.sf_UpdFldSetStr === null || objcc_ExamPaperStuRelationEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_ExamPaperStuRelationEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_UpdateRecordAsync = cc_ExamPaperStuRelation_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objcc_ExamPaperStuRelationEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function cc_ExamPaperStuRelation_UpdateWithConditionAsync(objcc_ExamPaperStuRelationEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objcc_ExamPaperStuRelationEN.sf_UpdFldSetStr === undefined || objcc_ExamPaperStuRelationEN.sf_UpdFldSetStr === null || objcc_ExamPaperStuRelationEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        objcc_ExamPaperStuRelationEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objcc_ExamPaperStuRelationEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_UpdateWithConditionAsync = cc_ExamPaperStuRelation_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngId_ExamPaperStuRelation_Cond:条件对象
     * @returns 对象列表子集
    */
    async function cc_ExamPaperStuRelation_IsExistRecord_Cache(objcc_ExamPaperStuRelation_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_Cache(strid_CurrEduCls);
        if (arrcc_ExamPaperStuRelationObjLst_Cache == null)
            return false;
        let arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelationObjLst_Cache;
        if (objcc_ExamPaperStuRelation_Cond.sf_FldComparisonOp == null || objcc_ExamPaperStuRelation_Cond.sf_FldComparisonOp == "")
            return arrcc_ExamPaperStuRelation_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objcc_ExamPaperStuRelation_Cond.sf_FldComparisonOp);
        //console.log("clscc_ExamPaperStuRelationWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_ExamPaperStuRelation_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_ExamPaperStuRelation_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_ExamPaperStuRelation_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objcc_ExamPaperStuRelation_Cond), exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.cc_ExamPaperStuRelation_IsExistRecord_Cache = cc_ExamPaperStuRelation_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function cc_ExamPaperStuRelation_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_IsExistRecordAsync = cc_ExamPaperStuRelation_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngId_ExamPaperStuRelation:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function cc_ExamPaperStuRelation_IsExist(lngId_ExamPaperStuRelation, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "Id_ExamPaperStuRelation": lngId_ExamPaperStuRelation,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_IsExist = cc_ExamPaperStuRelation_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngId_ExamPaperStuRelation:所给的关键字
     * @returns 对象
    */
    async function cc_ExamPaperStuRelation_IsExist_Cache(lngId_ExamPaperStuRelation, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_Cache(strid_CurrEduCls);
        if (arrcc_ExamPaperStuRelationObjLst_Cache == null)
            return false;
        try {
            const arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelationObjLst_Cache.filter(x => x.id_ExamPaperStuRelation == lngId_ExamPaperStuRelation);
            if (arrcc_ExamPaperStuRelation_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngId_ExamPaperStuRelation, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.cc_ExamPaperStuRelation_IsExist_Cache = cc_ExamPaperStuRelation_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngId_ExamPaperStuRelation:关键字
    * @returns 是否存在?存在返回True
    **/
    async function cc_ExamPaperStuRelation_IsExistAsync(lngId_ExamPaperStuRelation) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngId_ExamPaperStuRelation": lngId_ExamPaperStuRelation }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_IsExistAsync = cc_ExamPaperStuRelation_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function cc_ExamPaperStuRelation_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_GetRecCountByCondAsync = cc_ExamPaperStuRelation_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objcc_ExamPaperStuRelation_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function cc_ExamPaperStuRelation_GetRecCountByCond_Cache(objcc_ExamPaperStuRelation_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrcc_ExamPaperStuRelationObjLst_Cache = await cc_ExamPaperStuRelation_GetObjLst_Cache(strid_CurrEduCls);
        if (arrcc_ExamPaperStuRelationObjLst_Cache == null)
            return 0;
        let arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelationObjLst_Cache;
        if (objcc_ExamPaperStuRelation_Cond.sf_FldComparisonOp == null || objcc_ExamPaperStuRelation_Cond.sf_FldComparisonOp == "")
            return arrcc_ExamPaperStuRelation_Sel.length;
        const dicFldComparisonOp = JSON.parse(objcc_ExamPaperStuRelation_Cond.sf_FldComparisonOp);
        //console.log("clscc_ExamPaperStuRelationWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_ExamPaperStuRelation_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_ExamPaperStuRelation_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_ExamPaperStuRelation_Sel = arrcc_ExamPaperStuRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrcc_ExamPaperStuRelation_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objcc_ExamPaperStuRelation_Cond), exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.cc_ExamPaperStuRelation_GetRecCountByCond_Cache = cc_ExamPaperStuRelation_GetRecCountByCond_Cache;
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
    async function cc_ExamPaperStuRelation_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_ExamPaperStuRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_ExamPaperStuRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_ExamPaperStuRelation_GetMaxStrIdByPrefix = cc_ExamPaperStuRelation_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function cc_ExamPaperStuRelation_GetWebApiUrl(strController, strAction) {
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
    exports.cc_ExamPaperStuRelation_GetWebApiUrl = cc_ExamPaperStuRelation_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function cc_ExamPaperStuRelation_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clscc_ExamPaperStuRelationWApi.clscc_ExamPaperStuRelationWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clscc_ExamPaperStuRelationWApi.clscc_ExamPaperStuRelationWApi.ReFreshCache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN._CurrTabName, strid_CurrEduCls);
        switch (clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.CacheModeId) {
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
    exports.cc_ExamPaperStuRelation_ReFreshCache = cc_ExamPaperStuRelation_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function cc_ExamPaperStuRelation_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN._CurrTabName, strid_CurrEduCls);
            switch (clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.CacheModeId) {
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
    exports.cc_ExamPaperStuRelation_ReFreshThisCache = cc_ExamPaperStuRelation_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function cc_ExamPaperStuRelation_CheckPropertyNew(pobjcc_ExamPaperStuRelationEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) === true
            || pobjcc_ExamPaperStuRelationEN.id_CurrEduCls.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[教学班流水号]不能为空(In 考卷与学生关系)!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate) === true) {
            throw new Error("(errid:Watl000058)字段[指定完成日期]不能为空(In 考卷与学生关系)!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) === true) {
            throw new Error("(errid:Watl000058)字段[学生流水号]不能为空(In 考卷与学生关系)!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.workTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[作业类型Id]不能为空(In 考卷与学生关系)!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.courseExamPaperId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.courseExamPaperId) > 8) {
            throw new Error("(errid:Watl000059)字段[考卷流水号(courseExamPaperId)]的长度不能超过8(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.courseExamPaperId)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate) > 14) {
            throw new Error("(errid:Watl000059)字段[指定完成日期(specifyCompletionDate)]的长度不能超过14(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) > 8) {
            throw new Error("(errid:Watl000059)字段[学生流水号(id_StudentInfo)]的长度不能超过8(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.id_StudentInfo)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerModeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.answerModeId) > 4) {
            throw new Error("(errid:Watl000059)字段[答案模式Id(answerModeId)]的长度不能超过4(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.answerModeId)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerOptionId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.answerOptionId) > 8) {
            throw new Error("(errid:Watl000059)字段[回答选项Id(answerOptionId)]的长度不能超过8(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.answerOptionId)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerMultiOptions) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.answerMultiOptions) > 300) {
            throw new Error("(errid:Watl000059)字段[多选项答案(answerMultiOptions)]的长度不能超过300(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.answerMultiOptions)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.applySendBackDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.applySendBackDate) > 14) {
            throw new Error("(errid:Watl000059)字段[申请退回日期(applySendBackDate)]的长度不能超过14(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.applySendBackDate)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.realFinishDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.realFinishDate) > 14) {
            throw new Error("(errid:Watl000059)字段[实际完成日期(realFinishDate)]的长度不能超过14(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.realFinishDate)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.operateTime) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.operateTime) > 14) {
            throw new Error("(errid:Watl000059)字段[操作时间(operateTime)]的长度不能超过14(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.operateTime)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.markerId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.markerId) > 20) {
            throw new Error("(errid:Watl000059)字段[打分者(markerId)]的长度不能超过20(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.markerId)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.markDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.markDate) > 14) {
            throw new Error("(errid:Watl000059)字段[打分日期(markDate)]的长度不能超过14(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.markDate)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.workTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.workTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[作业类型Id(workTypeId)]的长度不能超过2(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.workTypeId)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerIP) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.answerIP) > 30) {
            throw new Error("(errid:Watl000059)字段[回答IP(answerIP)]的长度不能超过30(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.answerIP)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.answerDate) > 8) {
            throw new Error("(errid:Watl000059)字段[回答日期(answerDate)]的长度不能超过8(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.answerDate)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerTime) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.answerTime) > 10) {
            throw new Error("(errid:Watl000059)字段[回答时间(answerTime)]的长度不能超过10(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.answerTime)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.schoolYear) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.schoolYear) > 10) {
            throw new Error("(errid:Watl000059)字段[学年(schoolYear)]的长度不能超过10(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.schoolYear)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.schoolTerm) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.schoolTerm) > 1) {
            throw new Error("(errid:Watl000059)字段[学期(schoolTerm)]的长度不能超过1(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.schoolTerm)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.updDate)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.updUserId)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.memo)(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation && undefined !== pobjcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation && clsString_js_1.tzDataType.isNumber(pobjcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation) === false) {
            throw new Error("(errid:Watl000060)字段[流水号(id_ExamPaperStuRelation)]的值:[$(pobjcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation)], 非法，应该为数值型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.courseExamPaperId) == false && undefined !== pobjcc_ExamPaperStuRelationEN.courseExamPaperId && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.courseExamPaperId) === false) {
            throw new Error("(errid:Watl000060)字段[考卷流水号(courseExamPaperId)]的值:[$(pobjcc_ExamPaperStuRelationEN.courseExamPaperId)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) == false && undefined !== pobjcc_ExamPaperStuRelationEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.scores && undefined !== pobjcc_ExamPaperStuRelationEN.scores && clsString_js_1.tzDataType.isNumber(pobjcc_ExamPaperStuRelationEN.scores) === false) {
            throw new Error("(errid:Watl000060)字段[分值(scores)]的值:[$(pobjcc_ExamPaperStuRelationEN.scores)], 非法，应该为数值型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate) == false && undefined !== pobjcc_ExamPaperStuRelationEN.specifyCompletionDate && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate) === false) {
            throw new Error("(errid:Watl000060)字段[指定完成日期(specifyCompletionDate)]的值:[$(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) == false && undefined !== pobjcc_ExamPaperStuRelationEN.id_StudentInfo && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) === false) {
            throw new Error("(errid:Watl000060)字段[学生流水号(id_StudentInfo)]的值:[$(pobjcc_ExamPaperStuRelationEN.id_StudentInfo)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerModeId) == false && undefined !== pobjcc_ExamPaperStuRelationEN.answerModeId && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.answerModeId) === false) {
            throw new Error("(errid:Watl000060)字段[答案模式Id(answerModeId)]的值:[$(pobjcc_ExamPaperStuRelationEN.answerModeId)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerOptionId) == false && undefined !== pobjcc_ExamPaperStuRelationEN.answerOptionId && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.answerOptionId) === false) {
            throw new Error("(errid:Watl000060)字段[回答选项Id(answerOptionId)]的值:[$(pobjcc_ExamPaperStuRelationEN.answerOptionId)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerMultiOptions) == false && undefined !== pobjcc_ExamPaperStuRelationEN.answerMultiOptions && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.answerMultiOptions) === false) {
            throw new Error("(errid:Watl000060)字段[多选项答案(answerMultiOptions)]的值:[$(pobjcc_ExamPaperStuRelationEN.answerMultiOptions)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.stuAnswerText) == false && undefined !== pobjcc_ExamPaperStuRelationEN.stuAnswerText && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.stuAnswerText) === false) {
            throw new Error("(errid:Watl000060)字段[学生回答文本(stuAnswerText)]的值:[$(pobjcc_ExamPaperStuRelationEN.stuAnswerText)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isPublish && undefined !== pobjcc_ExamPaperStuRelationEN.isPublish && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isPublish) === false) {
            throw new Error("(errid:Watl000060)字段[是否发布(isPublish)]的值:[$(pobjcc_ExamPaperStuRelationEN.isPublish)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isLook && undefined !== pobjcc_ExamPaperStuRelationEN.isLook && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isLook) === false) {
            throw new Error("(errid:Watl000060)字段[是否查看(isLook)]的值:[$(pobjcc_ExamPaperStuRelationEN.isLook)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isSave && undefined !== pobjcc_ExamPaperStuRelationEN.isSave && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isSave) === false) {
            throw new Error("(errid:Watl000060)字段[是否保存(isSave)]的值:[$(pobjcc_ExamPaperStuRelationEN.isSave)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isSubmit && undefined !== pobjcc_ExamPaperStuRelationEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjcc_ExamPaperStuRelationEN.isSubmit)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.applySendBackDate) == false && undefined !== pobjcc_ExamPaperStuRelationEN.applySendBackDate && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.applySendBackDate) === false) {
            throw new Error("(errid:Watl000060)字段[申请退回日期(applySendBackDate)]的值:[$(pobjcc_ExamPaperStuRelationEN.applySendBackDate)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isApplySendBack && undefined !== pobjcc_ExamPaperStuRelationEN.isApplySendBack && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isApplySendBack) === false) {
            throw new Error("(errid:Watl000060)字段[是否申请退回(isApplySendBack)]的值:[$(pobjcc_ExamPaperStuRelationEN.isApplySendBack)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.realFinishDate) == false && undefined !== pobjcc_ExamPaperStuRelationEN.realFinishDate && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.realFinishDate) === false) {
            throw new Error("(errid:Watl000060)字段[实际完成日期(realFinishDate)]的值:[$(pobjcc_ExamPaperStuRelationEN.realFinishDate)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.operateTime) == false && undefined !== pobjcc_ExamPaperStuRelationEN.operateTime && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.operateTime) === false) {
            throw new Error("(errid:Watl000060)字段[操作时间(operateTime)]的值:[$(pobjcc_ExamPaperStuRelationEN.operateTime)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.score && undefined !== pobjcc_ExamPaperStuRelationEN.score && clsString_js_1.tzDataType.isNumber(pobjcc_ExamPaperStuRelationEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[得分(score)]的值:[$(pobjcc_ExamPaperStuRelationEN.score)], 非法，应该为数值型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.comment) == false && undefined !== pobjcc_ExamPaperStuRelationEN.comment && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.comment) === false) {
            throw new Error("(errid:Watl000060)字段[批注(comment)]的值:[$(pobjcc_ExamPaperStuRelationEN.comment)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isMarking && undefined !== pobjcc_ExamPaperStuRelationEN.isMarking && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isMarking) === false) {
            throw new Error("(errid:Watl000060)字段[是否批阅(isMarking)]的值:[$(pobjcc_ExamPaperStuRelationEN.isMarking)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.markerId) == false && undefined !== pobjcc_ExamPaperStuRelationEN.markerId && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.markerId) === false) {
            throw new Error("(errid:Watl000060)字段[打分者(markerId)]的值:[$(pobjcc_ExamPaperStuRelationEN.markerId)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.markDate) == false && undefined !== pobjcc_ExamPaperStuRelationEN.markDate && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.markDate) === false) {
            throw new Error("(errid:Watl000060)字段[打分日期(markDate)]的值:[$(pobjcc_ExamPaperStuRelationEN.markDate)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isSendBack && undefined !== pobjcc_ExamPaperStuRelationEN.isSendBack && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isSendBack) === false) {
            throw new Error("(errid:Watl000060)字段[是否退回(isSendBack)]的值:[$(pobjcc_ExamPaperStuRelationEN.isSendBack)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isInErrorQuestion && undefined !== pobjcc_ExamPaperStuRelationEN.isInErrorQuestion && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isInErrorQuestion) === false) {
            throw new Error("(errid:Watl000060)字段[是否进入错题(isInErrorQuestion)]的值:[$(pobjcc_ExamPaperStuRelationEN.isInErrorQuestion)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.workTypeId) == false && undefined !== pobjcc_ExamPaperStuRelationEN.workTypeId && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.workTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[作业类型Id(workTypeId)]的值:[$(pobjcc_ExamPaperStuRelationEN.workTypeId)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerIP) == false && undefined !== pobjcc_ExamPaperStuRelationEN.answerIP && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.answerIP) === false) {
            throw new Error("(errid:Watl000060)字段[回答IP(answerIP)]的值:[$(pobjcc_ExamPaperStuRelationEN.answerIP)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerDate) == false && undefined !== pobjcc_ExamPaperStuRelationEN.answerDate && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.answerDate) === false) {
            throw new Error("(errid:Watl000060)字段[回答日期(answerDate)]的值:[$(pobjcc_ExamPaperStuRelationEN.answerDate)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerTime) == false && undefined !== pobjcc_ExamPaperStuRelationEN.answerTime && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.answerTime) === false) {
            throw new Error("(errid:Watl000060)字段[回答时间(answerTime)]的值:[$(pobjcc_ExamPaperStuRelationEN.answerTime)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isRight && undefined !== pobjcc_ExamPaperStuRelationEN.isRight && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isRight) === false) {
            throw new Error("(errid:Watl000060)字段[是否正确(isRight)]的值:[$(pobjcc_ExamPaperStuRelationEN.isRight)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isAccessKnowledge && undefined !== pobjcc_ExamPaperStuRelationEN.isAccessKnowledge && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isAccessKnowledge) === false) {
            throw new Error("(errid:Watl000060)字段[是否处理知识点(isAccessKnowledge)]的值:[$(pobjcc_ExamPaperStuRelationEN.isAccessKnowledge)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isNotProcessTimeout && undefined !== pobjcc_ExamPaperStuRelationEN.isNotProcessTimeout && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isNotProcessTimeout) === false) {
            throw new Error("(errid:Watl000060)字段[是否不处理超时(isNotProcessTimeout)]的值:[$(pobjcc_ExamPaperStuRelationEN.isNotProcessTimeout)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.schoolYear) == false && undefined !== pobjcc_ExamPaperStuRelationEN.schoolYear && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.schoolYear) === false) {
            throw new Error("(errid:Watl000060)字段[学年(schoolYear)]的值:[$(pobjcc_ExamPaperStuRelationEN.schoolYear)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.schoolTerm) == false && undefined !== pobjcc_ExamPaperStuRelationEN.schoolTerm && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.schoolTerm) === false) {
            throw new Error("(errid:Watl000060)字段[学期(schoolTerm)]的值:[$(pobjcc_ExamPaperStuRelationEN.schoolTerm)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.updDate) == false && undefined !== pobjcc_ExamPaperStuRelationEN.updDate && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjcc_ExamPaperStuRelationEN.updDate)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.updUserId) == false && undefined !== pobjcc_ExamPaperStuRelationEN.updUserId && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjcc_ExamPaperStuRelationEN.updUserId)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.memo) == false && undefined !== pobjcc_ExamPaperStuRelationEN.memo && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjcc_ExamPaperStuRelationEN.memo)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.courseExamPaperId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.courseExamPaperId) != 8) {
            throw ("(errid:Watl000061)字段[考卷流水号]作为外键字段,长度应该为8(In 考卷与学生关系)!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) != 8) {
            throw ("(errid:Watl000061)字段[教学班流水号]作为外键字段,长度应该为8(In 考卷与学生关系)!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) != 8) {
            throw ("(errid:Watl000061)字段[学生流水号]作为外键字段,长度应该为8(In 考卷与学生关系)!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjcc_ExamPaperStuRelationEN.SetIsCheckProperty(true);
    }
    exports.cc_ExamPaperStuRelation_CheckPropertyNew = cc_ExamPaperStuRelation_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function cc_ExamPaperStuRelation_CheckProperty4Update(pobjcc_ExamPaperStuRelationEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.courseExamPaperId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.courseExamPaperId) > 8) {
            throw new Error("(errid:Watl000062)字段[考卷流水号(courseExamPaperId)]的长度不能超过8(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.courseExamPaperId)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate) > 14) {
            throw new Error("(errid:Watl000062)字段[指定完成日期(specifyCompletionDate)]的长度不能超过14(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) > 8) {
            throw new Error("(errid:Watl000062)字段[学生流水号(id_StudentInfo)]的长度不能超过8(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.id_StudentInfo)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerModeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.answerModeId) > 4) {
            throw new Error("(errid:Watl000062)字段[答案模式Id(answerModeId)]的长度不能超过4(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.answerModeId)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerOptionId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.answerOptionId) > 8) {
            throw new Error("(errid:Watl000062)字段[回答选项Id(answerOptionId)]的长度不能超过8(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.answerOptionId)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerMultiOptions) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.answerMultiOptions) > 300) {
            throw new Error("(errid:Watl000062)字段[多选项答案(answerMultiOptions)]的长度不能超过300(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.answerMultiOptions)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.applySendBackDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.applySendBackDate) > 14) {
            throw new Error("(errid:Watl000062)字段[申请退回日期(applySendBackDate)]的长度不能超过14(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.applySendBackDate)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.realFinishDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.realFinishDate) > 14) {
            throw new Error("(errid:Watl000062)字段[实际完成日期(realFinishDate)]的长度不能超过14(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.realFinishDate)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.operateTime) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.operateTime) > 14) {
            throw new Error("(errid:Watl000062)字段[操作时间(operateTime)]的长度不能超过14(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.operateTime)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.markerId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.markerId) > 20) {
            throw new Error("(errid:Watl000062)字段[打分者(markerId)]的长度不能超过20(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.markerId)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.markDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.markDate) > 14) {
            throw new Error("(errid:Watl000062)字段[打分日期(markDate)]的长度不能超过14(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.markDate)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.workTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.workTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[作业类型Id(workTypeId)]的长度不能超过2(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.workTypeId)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerIP) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.answerIP) > 30) {
            throw new Error("(errid:Watl000062)字段[回答IP(answerIP)]的长度不能超过30(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.answerIP)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.answerDate) > 8) {
            throw new Error("(errid:Watl000062)字段[回答日期(answerDate)]的长度不能超过8(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.answerDate)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerTime) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.answerTime) > 10) {
            throw new Error("(errid:Watl000062)字段[回答时间(answerTime)]的长度不能超过10(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.answerTime)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.schoolYear) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.schoolYear) > 10) {
            throw new Error("(errid:Watl000062)字段[学年(schoolYear)]的长度不能超过10(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.schoolYear)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.schoolTerm) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.schoolTerm) > 1) {
            throw new Error("(errid:Watl000062)字段[学期(schoolTerm)]的长度不能超过1(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.schoolTerm)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.updDate)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.updUserId)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 考卷与学生关系(cc_ExamPaperStuRelation))!值:$(pobjcc_ExamPaperStuRelationEN.memo)(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation && undefined !== pobjcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation && clsString_js_1.tzDataType.isNumber(pobjcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation) === false) {
            throw new Error("(errid:Watl000063)字段[流水号(id_ExamPaperStuRelation)]的值:[$(pobjcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation)], 非法，应该为数值型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.courseExamPaperId) == false && undefined !== pobjcc_ExamPaperStuRelationEN.courseExamPaperId && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.courseExamPaperId) === false) {
            throw new Error("(errid:Watl000063)字段[考卷流水号(courseExamPaperId)]的值:[$(pobjcc_ExamPaperStuRelationEN.courseExamPaperId)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) == false && undefined !== pobjcc_ExamPaperStuRelationEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.scores && undefined !== pobjcc_ExamPaperStuRelationEN.scores && clsString_js_1.tzDataType.isNumber(pobjcc_ExamPaperStuRelationEN.scores) === false) {
            throw new Error("(errid:Watl000063)字段[分值(scores)]的值:[$(pobjcc_ExamPaperStuRelationEN.scores)], 非法，应该为数值型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate) == false && undefined !== pobjcc_ExamPaperStuRelationEN.specifyCompletionDate && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate) === false) {
            throw new Error("(errid:Watl000063)字段[指定完成日期(specifyCompletionDate)]的值:[$(pobjcc_ExamPaperStuRelationEN.specifyCompletionDate)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) == false && undefined !== pobjcc_ExamPaperStuRelationEN.id_StudentInfo && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) === false) {
            throw new Error("(errid:Watl000063)字段[学生流水号(id_StudentInfo)]的值:[$(pobjcc_ExamPaperStuRelationEN.id_StudentInfo)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerModeId) == false && undefined !== pobjcc_ExamPaperStuRelationEN.answerModeId && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.answerModeId) === false) {
            throw new Error("(errid:Watl000063)字段[答案模式Id(answerModeId)]的值:[$(pobjcc_ExamPaperStuRelationEN.answerModeId)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerOptionId) == false && undefined !== pobjcc_ExamPaperStuRelationEN.answerOptionId && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.answerOptionId) === false) {
            throw new Error("(errid:Watl000063)字段[回答选项Id(answerOptionId)]的值:[$(pobjcc_ExamPaperStuRelationEN.answerOptionId)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerMultiOptions) == false && undefined !== pobjcc_ExamPaperStuRelationEN.answerMultiOptions && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.answerMultiOptions) === false) {
            throw new Error("(errid:Watl000063)字段[多选项答案(answerMultiOptions)]的值:[$(pobjcc_ExamPaperStuRelationEN.answerMultiOptions)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.stuAnswerText) == false && undefined !== pobjcc_ExamPaperStuRelationEN.stuAnswerText && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.stuAnswerText) === false) {
            throw new Error("(errid:Watl000063)字段[学生回答文本(stuAnswerText)]的值:[$(pobjcc_ExamPaperStuRelationEN.stuAnswerText)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isPublish && undefined !== pobjcc_ExamPaperStuRelationEN.isPublish && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isPublish) === false) {
            throw new Error("(errid:Watl000063)字段[是否发布(isPublish)]的值:[$(pobjcc_ExamPaperStuRelationEN.isPublish)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isLook && undefined !== pobjcc_ExamPaperStuRelationEN.isLook && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isLook) === false) {
            throw new Error("(errid:Watl000063)字段[是否查看(isLook)]的值:[$(pobjcc_ExamPaperStuRelationEN.isLook)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isSave && undefined !== pobjcc_ExamPaperStuRelationEN.isSave && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isSave) === false) {
            throw new Error("(errid:Watl000063)字段[是否保存(isSave)]的值:[$(pobjcc_ExamPaperStuRelationEN.isSave)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isSubmit && undefined !== pobjcc_ExamPaperStuRelationEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjcc_ExamPaperStuRelationEN.isSubmit)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.applySendBackDate) == false && undefined !== pobjcc_ExamPaperStuRelationEN.applySendBackDate && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.applySendBackDate) === false) {
            throw new Error("(errid:Watl000063)字段[申请退回日期(applySendBackDate)]的值:[$(pobjcc_ExamPaperStuRelationEN.applySendBackDate)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isApplySendBack && undefined !== pobjcc_ExamPaperStuRelationEN.isApplySendBack && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isApplySendBack) === false) {
            throw new Error("(errid:Watl000063)字段[是否申请退回(isApplySendBack)]的值:[$(pobjcc_ExamPaperStuRelationEN.isApplySendBack)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.realFinishDate) == false && undefined !== pobjcc_ExamPaperStuRelationEN.realFinishDate && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.realFinishDate) === false) {
            throw new Error("(errid:Watl000063)字段[实际完成日期(realFinishDate)]的值:[$(pobjcc_ExamPaperStuRelationEN.realFinishDate)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.operateTime) == false && undefined !== pobjcc_ExamPaperStuRelationEN.operateTime && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.operateTime) === false) {
            throw new Error("(errid:Watl000063)字段[操作时间(operateTime)]的值:[$(pobjcc_ExamPaperStuRelationEN.operateTime)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.score && undefined !== pobjcc_ExamPaperStuRelationEN.score && clsString_js_1.tzDataType.isNumber(pobjcc_ExamPaperStuRelationEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[得分(score)]的值:[$(pobjcc_ExamPaperStuRelationEN.score)], 非法，应该为数值型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.comment) == false && undefined !== pobjcc_ExamPaperStuRelationEN.comment && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.comment) === false) {
            throw new Error("(errid:Watl000063)字段[批注(comment)]的值:[$(pobjcc_ExamPaperStuRelationEN.comment)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isMarking && undefined !== pobjcc_ExamPaperStuRelationEN.isMarking && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isMarking) === false) {
            throw new Error("(errid:Watl000063)字段[是否批阅(isMarking)]的值:[$(pobjcc_ExamPaperStuRelationEN.isMarking)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.markerId) == false && undefined !== pobjcc_ExamPaperStuRelationEN.markerId && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.markerId) === false) {
            throw new Error("(errid:Watl000063)字段[打分者(markerId)]的值:[$(pobjcc_ExamPaperStuRelationEN.markerId)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.markDate) == false && undefined !== pobjcc_ExamPaperStuRelationEN.markDate && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.markDate) === false) {
            throw new Error("(errid:Watl000063)字段[打分日期(markDate)]的值:[$(pobjcc_ExamPaperStuRelationEN.markDate)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isSendBack && undefined !== pobjcc_ExamPaperStuRelationEN.isSendBack && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isSendBack) === false) {
            throw new Error("(errid:Watl000063)字段[是否退回(isSendBack)]的值:[$(pobjcc_ExamPaperStuRelationEN.isSendBack)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isInErrorQuestion && undefined !== pobjcc_ExamPaperStuRelationEN.isInErrorQuestion && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isInErrorQuestion) === false) {
            throw new Error("(errid:Watl000063)字段[是否进入错题(isInErrorQuestion)]的值:[$(pobjcc_ExamPaperStuRelationEN.isInErrorQuestion)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.workTypeId) == false && undefined !== pobjcc_ExamPaperStuRelationEN.workTypeId && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.workTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[作业类型Id(workTypeId)]的值:[$(pobjcc_ExamPaperStuRelationEN.workTypeId)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerIP) == false && undefined !== pobjcc_ExamPaperStuRelationEN.answerIP && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.answerIP) === false) {
            throw new Error("(errid:Watl000063)字段[回答IP(answerIP)]的值:[$(pobjcc_ExamPaperStuRelationEN.answerIP)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerDate) == false && undefined !== pobjcc_ExamPaperStuRelationEN.answerDate && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.answerDate) === false) {
            throw new Error("(errid:Watl000063)字段[回答日期(answerDate)]的值:[$(pobjcc_ExamPaperStuRelationEN.answerDate)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.answerTime) == false && undefined !== pobjcc_ExamPaperStuRelationEN.answerTime && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.answerTime) === false) {
            throw new Error("(errid:Watl000063)字段[回答时间(answerTime)]的值:[$(pobjcc_ExamPaperStuRelationEN.answerTime)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isRight && undefined !== pobjcc_ExamPaperStuRelationEN.isRight && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isRight) === false) {
            throw new Error("(errid:Watl000063)字段[是否正确(isRight)]的值:[$(pobjcc_ExamPaperStuRelationEN.isRight)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isAccessKnowledge && undefined !== pobjcc_ExamPaperStuRelationEN.isAccessKnowledge && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isAccessKnowledge) === false) {
            throw new Error("(errid:Watl000063)字段[是否处理知识点(isAccessKnowledge)]的值:[$(pobjcc_ExamPaperStuRelationEN.isAccessKnowledge)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if (null != pobjcc_ExamPaperStuRelationEN.isNotProcessTimeout && undefined !== pobjcc_ExamPaperStuRelationEN.isNotProcessTimeout && clsString_js_1.tzDataType.isBoolean(pobjcc_ExamPaperStuRelationEN.isNotProcessTimeout) === false) {
            throw new Error("(errid:Watl000063)字段[是否不处理超时(isNotProcessTimeout)]的值:[$(pobjcc_ExamPaperStuRelationEN.isNotProcessTimeout)], 非法，应该为布尔型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.schoolYear) == false && undefined !== pobjcc_ExamPaperStuRelationEN.schoolYear && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.schoolYear) === false) {
            throw new Error("(errid:Watl000063)字段[学年(schoolYear)]的值:[$(pobjcc_ExamPaperStuRelationEN.schoolYear)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.schoolTerm) == false && undefined !== pobjcc_ExamPaperStuRelationEN.schoolTerm && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.schoolTerm) === false) {
            throw new Error("(errid:Watl000063)字段[学期(schoolTerm)]的值:[$(pobjcc_ExamPaperStuRelationEN.schoolTerm)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.updDate) == false && undefined !== pobjcc_ExamPaperStuRelationEN.updDate && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjcc_ExamPaperStuRelationEN.updDate)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.updUserId) == false && undefined !== pobjcc_ExamPaperStuRelationEN.updUserId && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjcc_ExamPaperStuRelationEN.updUserId)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.memo) == false && undefined !== pobjcc_ExamPaperStuRelationEN.memo && clsString_js_1.tzDataType.isString(pobjcc_ExamPaperStuRelationEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjcc_ExamPaperStuRelationEN.memo)], 非法，应该为字符型(In 考卷与学生关系(cc_ExamPaperStuRelation))!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation
            || pobjcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation != null && pobjcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation.toString() === "") {
            throw new Error("(errid:Watl000064)字段[流水号]不能为空(In 考卷与学生关系)!(clscc_ExamPaperStuRelationBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.courseExamPaperId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.courseExamPaperId) != 8) {
            throw ("(errid:Watl000065)字段[考卷流水号]作为外键字段,长度应该为8(In 考卷与学生关系)!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.id_CurrEduCls) != 8) {
            throw ("(errid:Watl000065)字段[教学班流水号]作为外键字段,长度应该为8(In 考卷与学生关系)!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_ExamPaperStuRelationEN.id_StudentInfo) != 8) {
            throw ("(errid:Watl000065)字段[学生流水号]作为外键字段,长度应该为8(In 考卷与学生关系)!(clscc_ExamPaperStuRelationBL:CheckPropertyNew)");
        }
        pobjcc_ExamPaperStuRelationEN.SetIsCheckProperty(true);
    }
    exports.cc_ExamPaperStuRelation_CheckProperty4Update = cc_ExamPaperStuRelation_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function cc_ExamPaperStuRelation_GetJSONStrByObj(pobjcc_ExamPaperStuRelationEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjcc_ExamPaperStuRelationEN.sf_UpdFldSetStr = pobjcc_ExamPaperStuRelationEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjcc_ExamPaperStuRelationEN);
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
    exports.cc_ExamPaperStuRelation_GetJSONStrByObj = cc_ExamPaperStuRelation_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function cc_ExamPaperStuRelation_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrcc_ExamPaperStuRelationObjLst = new Array();
        if (strJSON === "") {
            return arrcc_ExamPaperStuRelationObjLst;
        }
        try {
            arrcc_ExamPaperStuRelationObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrcc_ExamPaperStuRelationObjLst;
        }
        return arrcc_ExamPaperStuRelationObjLst;
    }
    exports.cc_ExamPaperStuRelation_GetObjLstByJSONStr = cc_ExamPaperStuRelation_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrcc_ExamPaperStuRelationObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function cc_ExamPaperStuRelation_GetObjLstByJSONObjLst(arrcc_ExamPaperStuRelationObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrcc_ExamPaperStuRelationObjLst = new Array();
        for (const objInFor of arrcc_ExamPaperStuRelationObjLstS) {
            const obj1 = cc_ExamPaperStuRelation_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrcc_ExamPaperStuRelationObjLst.push(obj1);
        }
        return arrcc_ExamPaperStuRelationObjLst;
    }
    exports.cc_ExamPaperStuRelation_GetObjLstByJSONObjLst = cc_ExamPaperStuRelation_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function cc_ExamPaperStuRelation_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN();
        if (strJSON === "") {
            return pobjcc_ExamPaperStuRelationEN;
        }
        try {
            pobjcc_ExamPaperStuRelationEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjcc_ExamPaperStuRelationEN;
        }
        return pobjcc_ExamPaperStuRelationEN;
    }
    exports.cc_ExamPaperStuRelation_GetObjByJSONStr = cc_ExamPaperStuRelation_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function cc_ExamPaperStuRelation_GetCombineCondition(objcc_ExamPaperStuRelation_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Id_ExamPaperStuRelation) == true) {
            const strComparisonOp_Id_ExamPaperStuRelation = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Id_ExamPaperStuRelation];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Id_ExamPaperStuRelation, objcc_ExamPaperStuRelation_Cond.id_ExamPaperStuRelation, strComparisonOp_Id_ExamPaperStuRelation);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_CourseExamPaperId) == true) {
            const strComparisonOp_CourseExamPaperId = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_CourseExamPaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_CourseExamPaperId, objcc_ExamPaperStuRelation_Cond.courseExamPaperId, strComparisonOp_CourseExamPaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_id_CurrEduCls, objcc_ExamPaperStuRelation_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Scores) == true) {
            const strComparisonOp_Scores = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Scores];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Scores, objcc_ExamPaperStuRelation_Cond.scores, strComparisonOp_Scores);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SpecifyCompletionDate) == true) {
            const strComparisonOp_SpecifyCompletionDate = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SpecifyCompletionDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SpecifyCompletionDate, objcc_ExamPaperStuRelation_Cond.specifyCompletionDate, strComparisonOp_SpecifyCompletionDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_id_StudentInfo) == true) {
            const strComparisonOp_id_StudentInfo = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_id_StudentInfo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_id_StudentInfo, objcc_ExamPaperStuRelation_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerModeId) == true) {
            const strComparisonOp_AnswerModeId = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerModeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerModeId, objcc_ExamPaperStuRelation_Cond.answerModeId, strComparisonOp_AnswerModeId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerOptionId) == true) {
            const strComparisonOp_AnswerOptionId = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerOptionId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerOptionId, objcc_ExamPaperStuRelation_Cond.answerOptionId, strComparisonOp_AnswerOptionId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerMultiOptions) == true) {
            const strComparisonOp_AnswerMultiOptions = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerMultiOptions];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerMultiOptions, objcc_ExamPaperStuRelation_Cond.answerMultiOptions, strComparisonOp_AnswerMultiOptions);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsPublish) == true) {
            if (objcc_ExamPaperStuRelation_Cond.isPublish == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsPublish);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsPublish);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsLook) == true) {
            if (objcc_ExamPaperStuRelation_Cond.isLook == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsLook);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsLook);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSave) == true) {
            if (objcc_ExamPaperStuRelation_Cond.isSave == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSave);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSave);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSubmit) == true) {
            if (objcc_ExamPaperStuRelation_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_ApplySendBackDate) == true) {
            const strComparisonOp_ApplySendBackDate = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_ApplySendBackDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_ApplySendBackDate, objcc_ExamPaperStuRelation_Cond.applySendBackDate, strComparisonOp_ApplySendBackDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsApplySendBack) == true) {
            if (objcc_ExamPaperStuRelation_Cond.isApplySendBack == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsApplySendBack);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsApplySendBack);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_RealFinishDate) == true) {
            const strComparisonOp_RealFinishDate = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_RealFinishDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_RealFinishDate, objcc_ExamPaperStuRelation_Cond.realFinishDate, strComparisonOp_RealFinishDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_OperateTime) == true) {
            const strComparisonOp_OperateTime = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_OperateTime];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_OperateTime, objcc_ExamPaperStuRelation_Cond.operateTime, strComparisonOp_OperateTime);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Score) == true) {
            const strComparisonOp_Score = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Score];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Score, objcc_ExamPaperStuRelation_Cond.score, strComparisonOp_Score);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsMarking) == true) {
            if (objcc_ExamPaperStuRelation_Cond.isMarking == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsMarking);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsMarking);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_MarkerId) == true) {
            const strComparisonOp_MarkerId = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_MarkerId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_MarkerId, objcc_ExamPaperStuRelation_Cond.markerId, strComparisonOp_MarkerId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_MarkDate) == true) {
            const strComparisonOp_MarkDate = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_MarkDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_MarkDate, objcc_ExamPaperStuRelation_Cond.markDate, strComparisonOp_MarkDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSendBack) == true) {
            if (objcc_ExamPaperStuRelation_Cond.isSendBack == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSendBack);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsSendBack);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsInErrorQuestion) == true) {
            if (objcc_ExamPaperStuRelation_Cond.isInErrorQuestion == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsInErrorQuestion);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsInErrorQuestion);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_WorkTypeId) == true) {
            const strComparisonOp_WorkTypeId = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_WorkTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_WorkTypeId, objcc_ExamPaperStuRelation_Cond.workTypeId, strComparisonOp_WorkTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerIP) == true) {
            const strComparisonOp_AnswerIP = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerIP];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerIP, objcc_ExamPaperStuRelation_Cond.answerIP, strComparisonOp_AnswerIP);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerDate) == true) {
            const strComparisonOp_AnswerDate = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerDate, objcc_ExamPaperStuRelation_Cond.answerDate, strComparisonOp_AnswerDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerTime) == true) {
            const strComparisonOp_AnswerTime = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerTime];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_AnswerTime, objcc_ExamPaperStuRelation_Cond.answerTime, strComparisonOp_AnswerTime);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsRight) == true) {
            if (objcc_ExamPaperStuRelation_Cond.isRight == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsRight);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsRight);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsAccessKnowledge) == true) {
            if (objcc_ExamPaperStuRelation_Cond.isAccessKnowledge == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsAccessKnowledge);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsAccessKnowledge);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsNotProcessTimeout) == true) {
            if (objcc_ExamPaperStuRelation_Cond.isNotProcessTimeout == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsNotProcessTimeout);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_IsNotProcessTimeout);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SchoolYear) == true) {
            const strComparisonOp_SchoolYear = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SchoolYear];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SchoolYear, objcc_ExamPaperStuRelation_Cond.schoolYear, strComparisonOp_SchoolYear);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SchoolTerm) == true) {
            const strComparisonOp_SchoolTerm = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SchoolTerm];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_SchoolTerm, objcc_ExamPaperStuRelation_Cond.schoolTerm, strComparisonOp_SchoolTerm);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_UpdDate, objcc_ExamPaperStuRelation_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_UpdUserId, objcc_ExamPaperStuRelation_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp, clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Memo) == true) {
            const strComparisonOp_Memo = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN.con_Memo, objcc_ExamPaperStuRelation_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.cc_ExamPaperStuRelation_GetCombineCondition = cc_ExamPaperStuRelation_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--cc_ExamPaperStuRelation(考卷与学生关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strCourseExamPaperId: 考卷流水号(要求唯一的字段)
    * @param strid_StudentInfo: 学生流水号(要求唯一的字段)
    * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function cc_ExamPaperStuRelation_GetUniCondStr_CourseExamPaperId_id_StudentInfo_id_CurrEduCls(objcc_ExamPaperStuRelationEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuRelationEN.courseExamPaperId);
        strWhereCond += (0, clsString_js_2.Format)(" and id_StudentInfo = '{0}'", objcc_ExamPaperStuRelationEN.id_StudentInfo);
        strWhereCond += (0, clsString_js_2.Format)(" and id_CurrEduCls = '{0}'", objcc_ExamPaperStuRelationEN.id_CurrEduCls);
        return strWhereCond;
    }
    exports.cc_ExamPaperStuRelation_GetUniCondStr_CourseExamPaperId_id_StudentInfo_id_CurrEduCls = cc_ExamPaperStuRelation_GetUniCondStr_CourseExamPaperId_id_StudentInfo_id_CurrEduCls;
    /**
    *获取唯一性条件串(Uniqueness)--cc_ExamPaperStuRelation(考卷与学生关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strCourseExamPaperId: 考卷流水号(要求唯一的字段)
    * @param strid_StudentInfo: 学生流水号(要求唯一的字段)
    * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function cc_ExamPaperStuRelation_GetUniCondStr4Update_CourseExamPaperId_id_StudentInfo_id_CurrEduCls(objcc_ExamPaperStuRelationEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and Id_ExamPaperStuRelation <> '{0}'", objcc_ExamPaperStuRelationEN.id_ExamPaperStuRelation);
        strWhereCond += (0, clsString_js_2.Format)(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuRelationEN.courseExamPaperId);
        strWhereCond += (0, clsString_js_2.Format)(" and id_StudentInfo = '{0}'", objcc_ExamPaperStuRelationEN.id_StudentInfo);
        strWhereCond += (0, clsString_js_2.Format)(" and id_CurrEduCls = '{0}'", objcc_ExamPaperStuRelationEN.id_CurrEduCls);
        return strWhereCond;
    }
    exports.cc_ExamPaperStuRelation_GetUniCondStr4Update_CourseExamPaperId_id_StudentInfo_id_CurrEduCls = cc_ExamPaperStuRelation_GetUniCondStr4Update_CourseExamPaperId_id_StudentInfo_id_CurrEduCls;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objcc_ExamPaperStuRelationENS:源对象
     * @param objcc_ExamPaperStuRelationENT:目标对象
    */
    function cc_ExamPaperStuRelation_CopyObjTo(objcc_ExamPaperStuRelationENS, objcc_ExamPaperStuRelationENT) {
        objcc_ExamPaperStuRelationENT.id_ExamPaperStuRelation = objcc_ExamPaperStuRelationENS.id_ExamPaperStuRelation; //流水号
        objcc_ExamPaperStuRelationENT.courseExamPaperId = objcc_ExamPaperStuRelationENS.courseExamPaperId; //考卷流水号
        objcc_ExamPaperStuRelationENT.id_CurrEduCls = objcc_ExamPaperStuRelationENS.id_CurrEduCls; //教学班流水号
        objcc_ExamPaperStuRelationENT.scores = objcc_ExamPaperStuRelationENS.scores; //分值
        objcc_ExamPaperStuRelationENT.specifyCompletionDate = objcc_ExamPaperStuRelationENS.specifyCompletionDate; //指定完成日期
        objcc_ExamPaperStuRelationENT.id_StudentInfo = objcc_ExamPaperStuRelationENS.id_StudentInfo; //学生流水号
        objcc_ExamPaperStuRelationENT.answerModeId = objcc_ExamPaperStuRelationENS.answerModeId; //答案模式Id
        objcc_ExamPaperStuRelationENT.answerOptionId = objcc_ExamPaperStuRelationENS.answerOptionId; //回答选项Id
        objcc_ExamPaperStuRelationENT.answerMultiOptions = objcc_ExamPaperStuRelationENS.answerMultiOptions; //多选项答案
        objcc_ExamPaperStuRelationENT.stuAnswerText = objcc_ExamPaperStuRelationENS.stuAnswerText; //学生回答文本
        objcc_ExamPaperStuRelationENT.isPublish = objcc_ExamPaperStuRelationENS.isPublish; //是否发布
        objcc_ExamPaperStuRelationENT.isLook = objcc_ExamPaperStuRelationENS.isLook; //是否查看
        objcc_ExamPaperStuRelationENT.isSave = objcc_ExamPaperStuRelationENS.isSave; //是否保存
        objcc_ExamPaperStuRelationENT.isSubmit = objcc_ExamPaperStuRelationENS.isSubmit; //是否提交
        objcc_ExamPaperStuRelationENT.applySendBackDate = objcc_ExamPaperStuRelationENS.applySendBackDate; //申请退回日期
        objcc_ExamPaperStuRelationENT.isApplySendBack = objcc_ExamPaperStuRelationENS.isApplySendBack; //是否申请退回
        objcc_ExamPaperStuRelationENT.realFinishDate = objcc_ExamPaperStuRelationENS.realFinishDate; //实际完成日期
        objcc_ExamPaperStuRelationENT.operateTime = objcc_ExamPaperStuRelationENS.operateTime; //操作时间
        objcc_ExamPaperStuRelationENT.score = objcc_ExamPaperStuRelationENS.score; //得分
        objcc_ExamPaperStuRelationENT.comment = objcc_ExamPaperStuRelationENS.comment; //批注
        objcc_ExamPaperStuRelationENT.isMarking = objcc_ExamPaperStuRelationENS.isMarking; //是否批阅
        objcc_ExamPaperStuRelationENT.markerId = objcc_ExamPaperStuRelationENS.markerId; //打分者
        objcc_ExamPaperStuRelationENT.markDate = objcc_ExamPaperStuRelationENS.markDate; //打分日期
        objcc_ExamPaperStuRelationENT.isSendBack = objcc_ExamPaperStuRelationENS.isSendBack; //是否退回
        objcc_ExamPaperStuRelationENT.isInErrorQuestion = objcc_ExamPaperStuRelationENS.isInErrorQuestion; //是否进入错题
        objcc_ExamPaperStuRelationENT.workTypeId = objcc_ExamPaperStuRelationENS.workTypeId; //作业类型Id
        objcc_ExamPaperStuRelationENT.answerIP = objcc_ExamPaperStuRelationENS.answerIP; //回答IP
        objcc_ExamPaperStuRelationENT.answerDate = objcc_ExamPaperStuRelationENS.answerDate; //回答日期
        objcc_ExamPaperStuRelationENT.answerTime = objcc_ExamPaperStuRelationENS.answerTime; //回答时间
        objcc_ExamPaperStuRelationENT.isRight = objcc_ExamPaperStuRelationENS.isRight; //是否正确
        objcc_ExamPaperStuRelationENT.isAccessKnowledge = objcc_ExamPaperStuRelationENS.isAccessKnowledge; //是否处理知识点
        objcc_ExamPaperStuRelationENT.isNotProcessTimeout = objcc_ExamPaperStuRelationENS.isNotProcessTimeout; //是否不处理超时
        objcc_ExamPaperStuRelationENT.schoolYear = objcc_ExamPaperStuRelationENS.schoolYear; //学年
        objcc_ExamPaperStuRelationENT.schoolTerm = objcc_ExamPaperStuRelationENS.schoolTerm; //学期
        objcc_ExamPaperStuRelationENT.updDate = objcc_ExamPaperStuRelationENS.updDate; //修改日期
        objcc_ExamPaperStuRelationENT.updUserId = objcc_ExamPaperStuRelationENS.updUserId; //修改用户Id
        objcc_ExamPaperStuRelationENT.memo = objcc_ExamPaperStuRelationENS.memo; //备注
        objcc_ExamPaperStuRelationENT.sf_UpdFldSetStr = objcc_ExamPaperStuRelationENS.updFldString; //sf_UpdFldSetStr
    }
    exports.cc_ExamPaperStuRelation_CopyObjTo = cc_ExamPaperStuRelation_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objcc_ExamPaperStuRelationENS:源对象
     * @param objcc_ExamPaperStuRelationENT:目标对象
    */
    function cc_ExamPaperStuRelation_GetObjFromJsonObj(objcc_ExamPaperStuRelationENS) {
        const objcc_ExamPaperStuRelationENT = new clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_ExamPaperStuRelationENT, objcc_ExamPaperStuRelationENS);
        return objcc_ExamPaperStuRelationENT;
    }
    exports.cc_ExamPaperStuRelation_GetObjFromJsonObj = cc_ExamPaperStuRelation_GetObjFromJsonObj;
});
