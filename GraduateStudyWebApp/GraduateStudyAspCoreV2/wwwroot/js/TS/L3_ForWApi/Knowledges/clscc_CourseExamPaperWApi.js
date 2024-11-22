/**
* 类名:clscc_CourseExamPaperWApi
* 表名:cc_CourseExamPaper(01120071)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/15 23:43:45
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/Knowledges/clscc_CourseExamPaperEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_CourseExamPaper_GetObjFromJsonObj = exports.cc_CourseExamPaper_CopyObjTo = exports.cc_CourseExamPaper_GetUniCondStr4Update_ExamPaperName = exports.cc_CourseExamPaper_GetUniCondStr_ExamPaperName = exports.cc_CourseExamPaper_GetCombineCondition = exports.cc_CourseExamPaper_GetObjByJSONStr = exports.cc_CourseExamPaper_GetObjLstByJSONObjLst = exports.cc_CourseExamPaper_GetObjLstByJSONStr = exports.cc_CourseExamPaper_GetJSONStrByObj = exports.cc_CourseExamPaper_CheckProperty4Update = exports.cc_CourseExamPaper_CheckPropertyNew = exports.cc_CourseExamPaper_BindDdl_CourseExamPaperIdInDiv_Cache = exports.cc_CourseExamPaper_ReFreshThisCache = exports.cc_CourseExamPaper_ReFreshCache = exports.cc_CourseExamPaper_GetWebApiUrl = exports.cc_CourseExamPaper_GetMaxStrIdByPrefix = exports.cc_CourseExamPaper_GetMaxStrIdAsync = exports.cc_CourseExamPaper_GetRecCountByCond_Cache = exports.cc_CourseExamPaper_GetRecCountByCondAsync = exports.cc_CourseExamPaper_IsExistAsync = exports.cc_CourseExamPaper_IsExist_Cache = exports.cc_CourseExamPaper_IsExist = exports.cc_CourseExamPaper_IsExistRecordAsync = exports.cc_CourseExamPaper_IsExistRecord_Cache = exports.cc_CourseExamPaper_UpdateWithConditionAsync = exports.cc_CourseExamPaper_UpdateRecordAsync = exports.cc_CourseExamPaper_AddNewRecordWithReturnKey = exports.cc_CourseExamPaper_AddNewRecordWithReturnKeyAsync = exports.cc_CourseExamPaper_AddNewRecordWithMaxIdAsync = exports.cc_CourseExamPaper_AddNewRecordAsync = exports.cc_CourseExamPaper_Delcc_CourseExamPapersByCondAsync = exports.cc_CourseExamPaper_Delcc_CourseExamPapersAsync = exports.cc_CourseExamPaper_DelRecordAsync = exports.cc_CourseExamPaper_GetObjLstByPagerAsync = exports.cc_CourseExamPaper_GetObjLstByPager_Cache = exports.cc_CourseExamPaper_GetObjLstByRange = exports.cc_CourseExamPaper_GetObjLstByRangeAsync = exports.cc_CourseExamPaper_GetTopObjLstAsync = exports.cc_CourseExamPaper_GetObjLstByCourseExamPaperIdLst_Cache = exports.cc_CourseExamPaper_GetObjLstByCourseExamPaperIdLstAsync = exports.cc_CourseExamPaper_GetSubObjLst_Cache = exports.cc_CourseExamPaper_GetObjLst_PureCache = exports.cc_CourseExamPaper_GetObjLst_Cache = exports.cc_CourseExamPaper_GetObjLst_sessionStorage_PureCache = exports.cc_CourseExamPaper_GetObjLst_sessionStorage = exports.cc_CourseExamPaper_GetObjLstAsync = exports.cc_CourseExamPaper_GetObjLst_localStorage_PureCache = exports.cc_CourseExamPaper_GetObjLst_localStorage = exports.cc_CourseExamPaper_GetObjLst_ClientCache = exports.cc_CourseExamPaper_GetFirstObjAsync = exports.cc_CourseExamPaper_GetFirstID = exports.cc_CourseExamPaper_GetFirstIDAsync = exports.cc_CourseExamPaper_funcKey = exports.cc_CourseExamPaper_FilterFunByKey = exports.cc_CourseExamPaper_SortFunByKey = exports.cc_CourseExamPaper_SortFun_Defa_2Fld = exports.cc_CourseExamPaper_SortFun_Defa = exports.cc_CourseExamPaper_func = exports.cc_CourseExamPaper_GetNameByCourseExamPaperId_Cache = exports.cc_CourseExamPaper_UpdateObjInLst_Cache = exports.cc_CourseExamPaper_GetObjByCourseExamPaperId_localStorage = exports.cc_CourseExamPaper_GetObjByCourseExamPaperId_Cache = exports.cc_CourseExamPaper_GetObjByCourseExamPaperIdAsync = exports.cc_CourseExamPaper_ConstructorName = exports.cc_CourseExamPaper_Controller = void 0;
    /**
     * 考卷(cc_CourseExamPaper)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月15日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clscc_CourseExamPaperEN_js_1 = require("../../L0_Entity/Knowledges/clscc_CourseExamPaperEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.cc_CourseExamPaper_Controller = "cc_CourseExamPaperApi";
    exports.cc_CourseExamPaper_ConstructorName = "cc_CourseExamPaper";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCourseExamPaperId:关键字
    * @returns 对象
    **/
    async function cc_CourseExamPaper_GetObjByCourseExamPaperIdAsync(strCourseExamPaperId) {
        const strThisFuncName = "GetObjByCourseExamPaperIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseExamPaperId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseExamPaperId]不能为空！(In clscc_CourseExamPaperWApi.GetObjByCourseExamPaperIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseExamPaperId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseExamPaperId]的长度:[{0}]不正确！(clscc_CourseExamPaperWApi.GetObjByCourseExamPaperIdAsync)", strCourseExamPaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCourseExamPaperId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCourseExamPaperId": strCourseExamPaperId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objcc_CourseExamPaper = cc_CourseExamPaper_GetObjFromJsonObj(returnObj);
                return objcc_CourseExamPaper;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetObjByCourseExamPaperIdAsync = cc_CourseExamPaper_GetObjByCourseExamPaperIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strCourseExamPaperId:所给的关键字
     * @returns 对象
    */
    async function cc_CourseExamPaper_GetObjByCourseExamPaperId_Cache(strCourseExamPaperId, strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByCourseExamPaperId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseExamPaperId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseExamPaperId]不能为空！(In clscc_CourseExamPaperWApi.GetObjByCourseExamPaperId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseExamPaperId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseExamPaperId]的长度:[{0}]不正确！(clscc_CourseExamPaperWApi.GetObjByCourseExamPaperId_Cache)", strCourseExamPaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        try {
            const arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaperObjLst_Cache.filter(x => x.courseExamPaperId == strCourseExamPaperId);
            let objcc_CourseExamPaper;
            if (arrcc_CourseExamPaper_Sel.length > 0) {
                objcc_CourseExamPaper = arrcc_CourseExamPaper_Sel[0];
                return objcc_CourseExamPaper;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objcc_CourseExamPaper_Const = await cc_CourseExamPaper_GetObjByCourseExamPaperIdAsync(strCourseExamPaperId);
                    if (objcc_CourseExamPaper_Const != null) {
                        cc_CourseExamPaper_ReFreshThisCache(strCourseId);
                        return objcc_CourseExamPaper_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseExamPaperId, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.cc_CourseExamPaper_GetObjByCourseExamPaperId_Cache = cc_CourseExamPaper_GetObjByCourseExamPaperId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strCourseExamPaperId:所给的关键字
     * @returns 对象
    */
    async function cc_CourseExamPaper_GetObjByCourseExamPaperId_localStorage(strCourseExamPaperId) {
        const strThisFuncName = "GetObjByCourseExamPaperId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseExamPaperId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseExamPaperId]不能为空！(In clscc_CourseExamPaperWApi.GetObjByCourseExamPaperId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseExamPaperId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseExamPaperId]的长度:[{0}]不正确！(clscc_CourseExamPaperWApi.GetObjByCourseExamPaperId_localStorage)", strCourseExamPaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN._CurrTabName, strCourseExamPaperId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objcc_CourseExamPaper_Cache = JSON.parse(strTempObj);
            return objcc_CourseExamPaper_Cache;
        }
        try {
            const objcc_CourseExamPaper = await cc_CourseExamPaper_GetObjByCourseExamPaperIdAsync(strCourseExamPaperId);
            if (objcc_CourseExamPaper != null) {
                localStorage.setItem(strKey, JSON.stringify(objcc_CourseExamPaper));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objcc_CourseExamPaper;
            }
            return objcc_CourseExamPaper;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseExamPaperId, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.cc_CourseExamPaper_GetObjByCourseExamPaperId_localStorage = cc_CourseExamPaper_GetObjByCourseExamPaperId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objcc_CourseExamPaper:所给的对象
     * @returns 对象
    */
    async function cc_CourseExamPaper_UpdateObjInLst_Cache(objcc_CourseExamPaper, strCourseId) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_Cache(strCourseId);
            const obj = arrcc_CourseExamPaperObjLst_Cache.find(x => x.examPaperName == objcc_CourseExamPaper.examPaperName);
            if (obj != null) {
                objcc_CourseExamPaper.courseExamPaperId = obj.courseExamPaperId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objcc_CourseExamPaper);
            }
            else {
                arrcc_CourseExamPaperObjLst_Cache.push(objcc_CourseExamPaper);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_CourseExamPaper_UpdateObjInLst_Cache = cc_CourseExamPaper_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strCourseExamPaperId:所给的关键字
     * @returns 对象
    */
    async function cc_CourseExamPaper_GetNameByCourseExamPaperId_Cache(strCourseExamPaperId, strCourseId) {
        const strThisFuncName = "GetNameByCourseExamPaperId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseExamPaperId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseExamPaperId]不能为空！(In clscc_CourseExamPaperWApi.GetNameByCourseExamPaperId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseExamPaperId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseExamPaperId]的长度:[{0}]不正确！(clscc_CourseExamPaperWApi.GetNameByCourseExamPaperId_Cache)", strCourseExamPaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        if (arrcc_CourseExamPaperObjLst_Cache == null)
            return "";
        try {
            const arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaperObjLst_Cache.filter(x => x.courseExamPaperId == strCourseExamPaperId);
            let objcc_CourseExamPaper;
            if (arrcc_CourseExamPaper_Sel.length > 0) {
                objcc_CourseExamPaper = arrcc_CourseExamPaper_Sel[0];
                return objcc_CourseExamPaper.examPaperName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strCourseExamPaperId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.cc_CourseExamPaper_GetNameByCourseExamPaperId_Cache = cc_CourseExamPaper_GetNameByCourseExamPaperId_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strCourseId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function cc_CourseExamPaper_func(strInFldName, strOutFldName, strInValue, strCourseId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId_C]不能为空！(In clscc_CourseExamPaperWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clscc_CourseExamPaperWApi.func)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseExamPaperId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strCourseExamPaperId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objcc_CourseExamPaper = await cc_CourseExamPaper_GetObjByCourseExamPaperId_Cache(strCourseExamPaperId, strCourseId_C);
        if (objcc_CourseExamPaper == null)
            return "";
        if (objcc_CourseExamPaper.GetFldValue(strOutFldName) == null)
            return "";
        return objcc_CourseExamPaper.GetFldValue(strOutFldName).toString();
    }
    exports.cc_CourseExamPaper_func = cc_CourseExamPaper_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_CourseExamPaper_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.courseExamPaperId.localeCompare(b.courseExamPaperId);
    }
    exports.cc_CourseExamPaper_SortFun_Defa = cc_CourseExamPaper_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_CourseExamPaper_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.courseId == b.courseId)
            return a.examPaperName.localeCompare(b.examPaperName);
        else
            return a.courseId.localeCompare(b.courseId);
    }
    exports.cc_CourseExamPaper_SortFun_Defa_2Fld = cc_CourseExamPaper_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_CourseExamPaper_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseExamPaperId:
                    return (a, b) => {
                        return a.courseExamPaperId.localeCompare(b.courseExamPaperId);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseId:
                    return (a, b) => {
                        if (a.courseId == null)
                            return -1;
                        if (b.courseId == null)
                            return 1;
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperName:
                    return (a, b) => {
                        if (a.examPaperName == null)
                            return -1;
                        if (b.examPaperName == null)
                            return 1;
                        return a.examPaperName.localeCompare(b.examPaperName);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperIndex:
                    return (a, b) => {
                        return a.paperIndex - b.paperIndex;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperTypeId:
                    return (a, b) => {
                        return a.examPaperTypeId.localeCompare(b.examPaperTypeId);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsShow:
                    return (a, b) => {
                        if (a.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_TotalScore:
                    return (a, b) => {
                        return a.totalScore - b.totalScore;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ViewCount:
                    return (a, b) => {
                        return a.viewCount - b.viewCount;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_DoneNumber:
                    return (a, b) => {
                        return a.doneNumber - b.doneNumber;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperTime:
                    return (a, b) => {
                        return a.paperTime - b.paperTime;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_DownloadNumber:
                    return (a, b) => {
                        return a.downloadNumber - b.downloadNumber;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CollectionCount:
                    return (a, b) => {
                        return a.collectionCount - b.collectionCount;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_LikeCount:
                    return (a, b) => {
                        return a.likeCount - b.likeCount;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperDispModeId:
                    return (a, b) => {
                        if (a.paperDispModeId == null)
                            return -1;
                        if (b.paperDispModeId == null)
                            return 1;
                        return a.paperDispModeId.localeCompare(b.paperDispModeId);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamCreateTime:
                    return (a, b) => {
                        if (a.examCreateTime == null)
                            return -1;
                        if (b.examCreateTime == null)
                            return 1;
                        return a.examCreateTime.localeCompare(b.examCreateTime);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CreateUserID:
                    return (a, b) => {
                        if (a.createUserID == null)
                            return -1;
                        if (b.createUserID == null)
                            return 1;
                        return a.createUserID.localeCompare(b.createUserID);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToAllStu:
                    return (a, b) => {
                        if (a.isOpenToAllStu == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToSchool:
                    return (a, b) => {
                        if (a.isOpenToSchool == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToSocial:
                    return (a, b) => {
                        if (a.isOpenToSocial == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseChapterId:
                    return (a, b) => {
                        if (a.courseChapterId == null)
                            return -1;
                        if (b.courseChapterId == null)
                            return 1;
                        return a.courseChapterId.localeCompare(b.courseChapterId);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsAutoGeneQuestion:
                    return (a, b) => {
                        if (a.isAutoGeneQuestion == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsCanMultiDo:
                    return (a, b) => {
                        if (a.isCanMultiDo == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_UpdUserId:
                    return (a, b) => {
                        if (a.updUserId == null)
                            return -1;
                        if (b.updUserId == null)
                            return 1;
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[cc_CourseExamPaper]中不存在！(in ${exports.cc_CourseExamPaper_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseExamPaperId:
                    return (a, b) => {
                        return b.courseExamPaperId.localeCompare(a.courseExamPaperId);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseId:
                    return (a, b) => {
                        if (b.courseId == null)
                            return -1;
                        if (a.courseId == null)
                            return 1;
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperName:
                    return (a, b) => {
                        if (b.examPaperName == null)
                            return -1;
                        if (a.examPaperName == null)
                            return 1;
                        return b.examPaperName.localeCompare(a.examPaperName);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperIndex:
                    return (a, b) => {
                        return b.paperIndex - a.paperIndex;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperTypeId:
                    return (a, b) => {
                        return b.examPaperTypeId.localeCompare(a.examPaperTypeId);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsShow:
                    return (a, b) => {
                        if (b.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_TotalScore:
                    return (a, b) => {
                        return b.totalScore - a.totalScore;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ViewCount:
                    return (a, b) => {
                        return b.viewCount - a.viewCount;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_DoneNumber:
                    return (a, b) => {
                        return b.doneNumber - a.doneNumber;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperTime:
                    return (a, b) => {
                        return b.paperTime - a.paperTime;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_DownloadNumber:
                    return (a, b) => {
                        return b.downloadNumber - a.downloadNumber;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CollectionCount:
                    return (a, b) => {
                        return b.collectionCount - a.collectionCount;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_LikeCount:
                    return (a, b) => {
                        return b.likeCount - a.likeCount;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperDispModeId:
                    return (a, b) => {
                        if (b.paperDispModeId == null)
                            return -1;
                        if (a.paperDispModeId == null)
                            return 1;
                        return b.paperDispModeId.localeCompare(a.paperDispModeId);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamCreateTime:
                    return (a, b) => {
                        if (b.examCreateTime == null)
                            return -1;
                        if (a.examCreateTime == null)
                            return 1;
                        return b.examCreateTime.localeCompare(a.examCreateTime);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CreateUserID:
                    return (a, b) => {
                        if (b.createUserID == null)
                            return -1;
                        if (a.createUserID == null)
                            return 1;
                        return b.createUserID.localeCompare(a.createUserID);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToAllStu:
                    return (a, b) => {
                        if (b.isOpenToAllStu == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToSchool:
                    return (a, b) => {
                        if (b.isOpenToSchool == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToSocial:
                    return (a, b) => {
                        if (b.isOpenToSocial == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseChapterId:
                    return (a, b) => {
                        if (b.courseChapterId == null)
                            return -1;
                        if (a.courseChapterId == null)
                            return 1;
                        return b.courseChapterId.localeCompare(a.courseChapterId);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsAutoGeneQuestion:
                    return (a, b) => {
                        if (b.isAutoGeneQuestion == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsCanMultiDo:
                    return (a, b) => {
                        if (b.isCanMultiDo == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_UpdUserId:
                    return (a, b) => {
                        if (b.updUserId == null)
                            return -1;
                        if (a.updUserId == null)
                            return 1;
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[cc_CourseExamPaper]中不存在！(in ${exports.cc_CourseExamPaper_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.cc_CourseExamPaper_SortFunByKey = cc_CourseExamPaper_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function cc_CourseExamPaper_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseExamPaperId:
                return (obj) => {
                    return obj.courseExamPaperId === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperName:
                return (obj) => {
                    return obj.examPaperName === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperIndex:
                return (obj) => {
                    return obj.paperIndex === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperTypeId:
                return (obj) => {
                    return obj.examPaperTypeId === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsShow:
                return (obj) => {
                    return obj.isShow === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_TotalScore:
                return (obj) => {
                    return obj.totalScore === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ViewCount:
                return (obj) => {
                    return obj.viewCount === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_DoneNumber:
                return (obj) => {
                    return obj.doneNumber === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperTime:
                return (obj) => {
                    return obj.paperTime === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_DownloadNumber:
                return (obj) => {
                    return obj.downloadNumber === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CollectionCount:
                return (obj) => {
                    return obj.collectionCount === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_LikeCount:
                return (obj) => {
                    return obj.likeCount === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperDispModeId:
                return (obj) => {
                    return obj.paperDispModeId === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamCreateTime:
                return (obj) => {
                    return obj.examCreateTime === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CreateUserID:
                return (obj) => {
                    return obj.createUserID === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToAllStu:
                return (obj) => {
                    return obj.isOpenToAllStu === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToSchool:
                return (obj) => {
                    return obj.isOpenToSchool === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToSocial:
                return (obj) => {
                    return obj.isOpenToSocial === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseChapterId:
                return (obj) => {
                    return obj.courseChapterId === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsAutoGeneQuestion:
                return (obj) => {
                    return obj.isAutoGeneQuestion === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsCanMultiDo:
                return (obj) => {
                    return obj.isCanMultiDo === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[cc_CourseExamPaper]中不存在！(in ${exports.cc_CourseExamPaper_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.cc_CourseExamPaper_FilterFunByKey = cc_CourseExamPaper_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strCourseId:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function cc_CourseExamPaper_funcKey(strInFldName, strInValue, strComparisonOp, strCourseId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId_C]不能为空！(In clscc_CourseExamPaperWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clscc_CourseExamPaperWApi.funcKey)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseExamPaperId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrcc_CourseExamPaper = await cc_CourseExamPaper_GetObjLst_Cache(strCourseId_C);
        if (arrcc_CourseExamPaper == null)
            return [];
        let arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrcc_CourseExamPaper_Sel.length == 0)
            return [];
        return arrcc_CourseExamPaper_Sel.map(x => x.courseExamPaperId);
    }
    exports.cc_CourseExamPaper_funcKey = cc_CourseExamPaper_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function cc_CourseExamPaper_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetFirstIDAsync = cc_CourseExamPaper_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function cc_CourseExamPaper_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetFirstID = cc_CourseExamPaper_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function cc_CourseExamPaper_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
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
                const objcc_CourseExamPaper = cc_CourseExamPaper_GetObjFromJsonObj(returnObj);
                return objcc_CourseExamPaper;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetFirstObjAsync = cc_CourseExamPaper_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseExamPaper_GetObjLst_ClientCache(strCourseId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrcc_CourseExamPaperExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrcc_CourseExamPaperObjLst_T = cc_CourseExamPaper_GetObjLstByJSONObjLst(arrcc_CourseExamPaperExObjLst_Cache);
            return arrcc_CourseExamPaperObjLst_T;
        }
        try {
            const arrcc_CourseExamPaperExObjLst = await cc_CourseExamPaper_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrcc_CourseExamPaperExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseExamPaperExObjLst.length);
            console.log(strInfo);
            return arrcc_CourseExamPaperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseExamPaper_GetObjLst_ClientCache = cc_CourseExamPaper_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseExamPaper_GetObjLst_localStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrcc_CourseExamPaperExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrcc_CourseExamPaperObjLst_T = cc_CourseExamPaper_GetObjLstByJSONObjLst(arrcc_CourseExamPaperExObjLst_Cache);
            return arrcc_CourseExamPaperObjLst_T;
        }
        try {
            const arrcc_CourseExamPaperExObjLst = await cc_CourseExamPaper_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrcc_CourseExamPaperExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseExamPaperExObjLst.length);
            console.log(strInfo);
            return arrcc_CourseExamPaperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseExamPaper_GetObjLst_localStorage = cc_CourseExamPaper_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseExamPaper_GetObjLst_localStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrcc_CourseExamPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrcc_CourseExamPaperObjLst_Cache;
        }
        else
            return null;
    }
    exports.cc_CourseExamPaper_GetObjLst_localStorage_PureCache = cc_CourseExamPaper_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function cc_CourseExamPaper_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetObjLstAsync = cc_CourseExamPaper_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseExamPaper_GetObjLst_sessionStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrcc_CourseExamPaperExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrcc_CourseExamPaperObjLst_T = cc_CourseExamPaper_GetObjLstByJSONObjLst(arrcc_CourseExamPaperExObjLst_Cache);
            return arrcc_CourseExamPaperObjLst_T;
        }
        try {
            const arrcc_CourseExamPaperExObjLst = await cc_CourseExamPaper_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrcc_CourseExamPaperExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseExamPaperExObjLst.length);
            console.log(strInfo);
            return arrcc_CourseExamPaperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseExamPaper_GetObjLst_sessionStorage = cc_CourseExamPaper_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseExamPaper_GetObjLst_sessionStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrcc_CourseExamPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrcc_CourseExamPaperObjLst_Cache;
        }
        else
            return null;
    }
    exports.cc_CourseExamPaper_GetObjLst_sessionStorage_PureCache = cc_CourseExamPaper_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseExamPaper_GetObjLst_Cache(strCourseId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[CourseId]不能为空！(in clscc_CourseExamPaperWApi.cc_CourseExamPaper_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(in clscc_CourseExamPaperWApi.cc_CourseExamPaper_GetObjLst_Cache() )", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrcc_CourseExamPaperObjLst_Cache;
        switch (clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.CacheModeId) {
            case "04": //sessionStorage
                arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_sessionStorage(strCourseId);
                break;
            case "03": //localStorage
                arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_localStorage(strCourseId);
                break;
            case "02": //ClientCache
                arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_ClientCache(strCourseId);
                break;
            default:
                arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_ClientCache(strCourseId);
                break;
        }
        const arrcc_CourseExamPaperObjLst = cc_CourseExamPaper_GetObjLstByJSONObjLst(arrcc_CourseExamPaperObjLst_Cache);
        return arrcc_CourseExamPaperObjLst_Cache;
    }
    exports.cc_CourseExamPaper_GetObjLst_Cache = cc_CourseExamPaper_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseExamPaper_GetObjLst_PureCache(strCourseId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrcc_CourseExamPaperObjLst_Cache;
        switch (clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.CacheModeId) {
            case "04": //sessionStorage
                arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_sessionStorage_PureCache(strCourseId);
                break;
            case "03": //localStorage
                arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_localStorage_PureCache(strCourseId);
                break;
            case "02": //ClientCache
                arrcc_CourseExamPaperObjLst_Cache = null;
                break;
            default:
                arrcc_CourseExamPaperObjLst_Cache = null;
                break;
        }
        return arrcc_CourseExamPaperObjLst_Cache;
    }
    exports.cc_CourseExamPaper_GetObjLst_PureCache = cc_CourseExamPaper_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrCourseExamPaperId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function cc_CourseExamPaper_GetSubObjLst_Cache(objcc_CourseExamPaper_Cond, strCourseId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        let arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaperObjLst_Cache;
        if (objcc_CourseExamPaper_Cond.sf_FldComparisonOp == null || objcc_CourseExamPaper_Cond.sf_FldComparisonOp == "")
            return arrcc_CourseExamPaper_Sel;
        const dicFldComparisonOp = JSON.parse(objcc_CourseExamPaper_Cond.sf_FldComparisonOp);
        //console.log("clscc_CourseExamPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_CourseExamPaper_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseExamPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrcc_CourseExamPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objcc_CourseExamPaper_Cond), exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_CourseExamPaper_GetSubObjLst_Cache = cc_CourseExamPaper_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCourseExamPaperId:关键字列表
    * @returns 对象列表
    **/
    async function cc_CourseExamPaper_GetObjLstByCourseExamPaperIdLstAsync(arrCourseExamPaperId) {
        const strThisFuncName = "GetObjLstByCourseExamPaperIdLstAsync";
        const strAction = "GetObjLstByCourseExamPaperIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseExamPaperId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetObjLstByCourseExamPaperIdLstAsync = cc_CourseExamPaper_GetObjLstByCourseExamPaperIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrCourseExamPaperIdLst:关键字列表
     * @returns 对象列表
    */
    async function cc_CourseExamPaper_GetObjLstByCourseExamPaperIdLst_Cache(arrCourseExamPaperIdLst, strCourseId) {
        const strThisFuncName = "GetObjLstByCourseExamPaperIdLst_Cache";
        try {
            const arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_Cache(strCourseId);
            const arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaperObjLst_Cache.filter(x => arrCourseExamPaperIdLst.indexOf(x.courseExamPaperId) > -1);
            return arrcc_CourseExamPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCourseExamPaperIdLst.join(","), exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.cc_CourseExamPaper_GetObjLstByCourseExamPaperIdLst_Cache = cc_CourseExamPaper_GetObjLstByCourseExamPaperIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function cc_CourseExamPaper_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetTopObjLstAsync = cc_CourseExamPaper_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function cc_CourseExamPaper_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetObjLstByRangeAsync = cc_CourseExamPaper_GetObjLstByRangeAsync;
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
    async function cc_CourseExamPaper_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetObjLstByRange = cc_CourseExamPaper_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function cc_CourseExamPaper_GetObjLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        if (arrcc_CourseExamPaperObjLst_Cache.length == 0)
            return arrcc_CourseExamPaperObjLst_Cache;
        let arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaperObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objcc_CourseExamPaper_Cond = new clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_CourseExamPaper_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clscc_CourseExamPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseExamPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_CourseExamPaper_Sel.length == 0)
                return arrcc_CourseExamPaper_Sel;
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
                arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.sort(cc_CourseExamPaper_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.sort(objPagerPara.sortFun);
            }
            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.slice(intStart, intEnd);
            return arrcc_CourseExamPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_CourseExamPaper_GetObjLstByPager_Cache = cc_CourseExamPaper_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function cc_CourseExamPaper_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetObjLstByPagerAsync = cc_CourseExamPaper_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strCourseExamPaperId:关键字
    * @returns 获取删除的结果
    **/
    async function cc_CourseExamPaper_DelRecordAsync(strCourseExamPaperId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strCourseExamPaperId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_DelRecordAsync = cc_CourseExamPaper_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrCourseExamPaperId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function cc_CourseExamPaper_Delcc_CourseExamPapersAsync(arrCourseExamPaperId) {
        const strThisFuncName = "Delcc_CourseExamPapersAsync";
        const strAction = "Delcc_CourseExamPapers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseExamPaperId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_Delcc_CourseExamPapersAsync = cc_CourseExamPaper_Delcc_CourseExamPapersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function cc_CourseExamPaper_Delcc_CourseExamPapersByCondAsync(strWhereCond) {
        const strThisFuncName = "Delcc_CourseExamPapersByCondAsync";
        const strAction = "Delcc_CourseExamPapersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_Delcc_CourseExamPapersByCondAsync = cc_CourseExamPaper_Delcc_CourseExamPapersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objcc_CourseExamPaperEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_CourseExamPaper_AddNewRecordAsync(objcc_CourseExamPaperEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objcc_CourseExamPaperEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseExamPaperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_AddNewRecordAsync = cc_CourseExamPaper_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objcc_CourseExamPaperEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_CourseExamPaper_AddNewRecordWithMaxIdAsync(objcc_CourseExamPaperEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseExamPaperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_AddNewRecordWithMaxIdAsync = cc_CourseExamPaper_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objcc_CourseExamPaperEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function cc_CourseExamPaper_AddNewRecordWithReturnKeyAsync(objcc_CourseExamPaperEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseExamPaperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_AddNewRecordWithReturnKeyAsync = cc_CourseExamPaper_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objcc_CourseExamPaperEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function cc_CourseExamPaper_AddNewRecordWithReturnKey(objcc_CourseExamPaperEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objcc_CourseExamPaperEN.courseExamPaperId === null || objcc_CourseExamPaperEN.courseExamPaperId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseExamPaperEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_AddNewRecordWithReturnKey = cc_CourseExamPaper_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objcc_CourseExamPaperEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function cc_CourseExamPaper_UpdateRecordAsync(objcc_CourseExamPaperEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objcc_CourseExamPaperEN.sf_UpdFldSetStr === undefined || objcc_CourseExamPaperEN.sf_UpdFldSetStr === null || objcc_CourseExamPaperEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_CourseExamPaperEN.courseExamPaperId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseExamPaperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_UpdateRecordAsync = cc_CourseExamPaper_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objcc_CourseExamPaperEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function cc_CourseExamPaper_UpdateWithConditionAsync(objcc_CourseExamPaperEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objcc_CourseExamPaperEN.sf_UpdFldSetStr === undefined || objcc_CourseExamPaperEN.sf_UpdFldSetStr === null || objcc_CourseExamPaperEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_CourseExamPaperEN.courseExamPaperId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        objcc_CourseExamPaperEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseExamPaperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_UpdateWithConditionAsync = cc_CourseExamPaper_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrCourseExamPaperId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function cc_CourseExamPaper_IsExistRecord_Cache(objcc_CourseExamPaper_Cond, strCourseId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        if (arrcc_CourseExamPaperObjLst_Cache == null)
            return false;
        let arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaperObjLst_Cache;
        if (objcc_CourseExamPaper_Cond.sf_FldComparisonOp == null || objcc_CourseExamPaper_Cond.sf_FldComparisonOp == "")
            return arrcc_CourseExamPaper_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objcc_CourseExamPaper_Cond.sf_FldComparisonOp);
        //console.log("clscc_CourseExamPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_CourseExamPaper_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseExamPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_CourseExamPaper_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objcc_CourseExamPaper_Cond), exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.cc_CourseExamPaper_IsExistRecord_Cache = cc_CourseExamPaper_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function cc_CourseExamPaper_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_IsExistRecordAsync = cc_CourseExamPaper_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCourseExamPaperId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function cc_CourseExamPaper_IsExist(strCourseExamPaperId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CourseExamPaperId": strCourseExamPaperId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_IsExist = cc_CourseExamPaper_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strCourseExamPaperId:所给的关键字
     * @returns 对象
    */
    async function cc_CourseExamPaper_IsExist_Cache(strCourseExamPaperId, strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        if (arrcc_CourseExamPaperObjLst_Cache == null)
            return false;
        try {
            const arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaperObjLst_Cache.filter(x => x.courseExamPaperId == strCourseExamPaperId);
            if (arrcc_CourseExamPaper_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCourseExamPaperId, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.cc_CourseExamPaper_IsExist_Cache = cc_CourseExamPaper_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCourseExamPaperId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function cc_CourseExamPaper_IsExistAsync(strCourseExamPaperId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strCourseExamPaperId": strCourseExamPaperId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_IsExistAsync = cc_CourseExamPaper_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function cc_CourseExamPaper_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetRecCountByCondAsync = cc_CourseExamPaper_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objcc_CourseExamPaper_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function cc_CourseExamPaper_GetRecCountByCond_Cache(objcc_CourseExamPaper_Cond, strCourseId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrcc_CourseExamPaperObjLst_Cache = await cc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        if (arrcc_CourseExamPaperObjLst_Cache == null)
            return 0;
        let arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaperObjLst_Cache;
        if (objcc_CourseExamPaper_Cond.sf_FldComparisonOp == null || objcc_CourseExamPaper_Cond.sf_FldComparisonOp == "")
            return arrcc_CourseExamPaper_Sel.length;
        const dicFldComparisonOp = JSON.parse(objcc_CourseExamPaper_Cond.sf_FldComparisonOp);
        //console.log("clscc_CourseExamPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_CourseExamPaper_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseExamPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseExamPaper_Sel = arrcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrcc_CourseExamPaper_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objcc_CourseExamPaper_Cond), exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.cc_CourseExamPaper_GetRecCountByCond_Cache = cc_CourseExamPaper_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function cc_CourseExamPaper_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetMaxStrIdAsync = cc_CourseExamPaper_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function cc_CourseExamPaper_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseExamPaper_GetMaxStrIdByPrefix = cc_CourseExamPaper_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function cc_CourseExamPaper_GetWebApiUrl(strController, strAction) {
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
    exports.cc_CourseExamPaper_GetWebApiUrl = cc_CourseExamPaper_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function cc_CourseExamPaper_ReFreshCache(strCourseId) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clscc_CourseExamPaperWApi.clscc_CourseExamPaperWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clscc_CourseExamPaperWApi.clscc_CourseExamPaperWApi.ReFreshCache)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN._CurrTabName, strCourseId);
        switch (clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.CacheModeId) {
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
    exports.cc_CourseExamPaper_ReFreshCache = cc_CourseExamPaper_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function cc_CourseExamPaper_ReFreshThisCache(strCourseId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN._CurrTabName, strCourseId);
            switch (clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.CacheModeId) {
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
    exports.cc_CourseExamPaper_ReFreshThisCache = cc_CourseExamPaper_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
     * @param strCourseId:课程Id
    */
    async function cc_CourseExamPaper_BindDdl_CourseExamPaperIdInDiv_Cache(strDivName, strDdlName, strCourseId) {
        const strThisFuncName = "BindDdl_CourseExamPaperIdInDiv_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clscc_CourseExamPaperWApi.BindDdl_CourseExamPaperIdInDiv)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clscc_CourseExamPaperWApi.BindDdl_CourseExamPaperIdInDiv)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_CourseExamPaperIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_CourseExamPaperIdInDiv_Cache");
        let arrObjLst_Sel = await cc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseExamPaperId, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperName, "考卷");
    }
    exports.cc_CourseExamPaper_BindDdl_CourseExamPaperIdInDiv_Cache = cc_CourseExamPaper_BindDdl_CourseExamPaperIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function cc_CourseExamPaper_CheckPropertyNew(pobjcc_CourseExamPaperEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examPaperTypeId) === true
            || pobjcc_CourseExamPaperEN.examPaperTypeId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[试卷类型Id]不能为空(In 考卷)!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseExamPaperId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.courseExamPaperId) > 8) {
            throw new Error("(errid:Watl000059)字段[考卷流水号(courseExamPaperId)]的长度不能超过8(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.courseExamPaperId)(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.courseId) > 8) {
            throw new Error("(errid:Watl000059)字段[课程Id(courseId)]的长度不能超过8(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.courseId)(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examPaperName) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.examPaperName) > 500) {
            throw new Error("(errid:Watl000059)字段[考卷名称(examPaperName)]的长度不能超过500(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.examPaperName)(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examPaperTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.examPaperTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[试卷类型Id(examPaperTypeId)]的长度不能超过2(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.examPaperTypeId)(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.id_XzMajor) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.id_XzMajor)(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.paperDispModeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.paperDispModeId) > 4) {
            throw new Error("(errid:Watl000059)字段[试卷显示模式Id(paperDispModeId)]的长度不能超过4(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.paperDispModeId)(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examCreateTime) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.examCreateTime) > 14) {
            throw new Error("(errid:Watl000059)字段[考卷建立时间(examCreateTime)]的长度不能超过14(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.examCreateTime)(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.createUserID) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.createUserID) > 20) {
            throw new Error("(errid:Watl000059)字段[建立用户ID(createUserID)]的长度不能超过20(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.createUserID)(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseChapterId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.courseChapterId) > 8) {
            throw new Error("(errid:Watl000059)字段[课程章节ID(courseChapterId)]的长度不能超过8(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.courseChapterId)(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.updDate)(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.updUserId)(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.memo)(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseExamPaperId) == false && undefined !== pobjcc_CourseExamPaperEN.courseExamPaperId && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.courseExamPaperId) === false) {
            throw new Error("(errid:Watl000060)字段[考卷流水号(courseExamPaperId)]的值:[$(pobjcc_CourseExamPaperEN.courseExamPaperId)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseId) == false && undefined !== pobjcc_CourseExamPaperEN.courseId && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.courseId) === false) {
            throw new Error("(errid:Watl000060)字段[课程Id(courseId)]的值:[$(pobjcc_CourseExamPaperEN.courseId)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examPaperName) == false && undefined !== pobjcc_CourseExamPaperEN.examPaperName && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.examPaperName) === false) {
            throw new Error("(errid:Watl000060)字段[考卷名称(examPaperName)]的值:[$(pobjcc_CourseExamPaperEN.examPaperName)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.paperIndex && undefined !== pobjcc_CourseExamPaperEN.paperIndex && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.paperIndex) === false) {
            throw new Error("(errid:Watl000060)字段[试卷序号(paperIndex)]的值:[$(pobjcc_CourseExamPaperEN.paperIndex)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examPaperTypeId) == false && undefined !== pobjcc_CourseExamPaperEN.examPaperTypeId && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.examPaperTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[试卷类型Id(examPaperTypeId)]的值:[$(pobjcc_CourseExamPaperEN.examPaperTypeId)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.isShow && undefined !== pobjcc_CourseExamPaperEN.isShow && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseExamPaperEN.isShow) === false) {
            throw new Error("(errid:Watl000060)字段[是否启用(isShow)]的值:[$(pobjcc_CourseExamPaperEN.isShow)], 非法，应该为布尔型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.totalScore && undefined !== pobjcc_CourseExamPaperEN.totalScore && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.totalScore) === false) {
            throw new Error("(errid:Watl000060)字段[总得分(totalScore)]的值:[$(pobjcc_CourseExamPaperEN.totalScore)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.viewCount && undefined !== pobjcc_CourseExamPaperEN.viewCount && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.viewCount) === false) {
            throw new Error("(errid:Watl000060)字段[浏览量(viewCount)]的值:[$(pobjcc_CourseExamPaperEN.viewCount)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.doneNumber && undefined !== pobjcc_CourseExamPaperEN.doneNumber && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.doneNumber) === false) {
            throw new Error("(errid:Watl000060)字段[已做人数(doneNumber)]的值:[$(pobjcc_CourseExamPaperEN.doneNumber)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.paperTime && undefined !== pobjcc_CourseExamPaperEN.paperTime && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.paperTime) === false) {
            throw new Error("(errid:Watl000060)字段[考试时间（分钟）(paperTime)]的值:[$(pobjcc_CourseExamPaperEN.paperTime)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.downloadNumber && undefined !== pobjcc_CourseExamPaperEN.downloadNumber && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.downloadNumber) === false) {
            throw new Error("(errid:Watl000060)字段[下载数目(downloadNumber)]的值:[$(pobjcc_CourseExamPaperEN.downloadNumber)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.collectionCount && undefined !== pobjcc_CourseExamPaperEN.collectionCount && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.collectionCount) === false) {
            throw new Error("(errid:Watl000060)字段[收藏数量(collectionCount)]的值:[$(pobjcc_CourseExamPaperEN.collectionCount)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.likeCount && undefined !== pobjcc_CourseExamPaperEN.likeCount && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.likeCount) === false) {
            throw new Error("(errid:Watl000060)字段[资源喜欢数量(likeCount)]的值:[$(pobjcc_CourseExamPaperEN.likeCount)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.id_XzMajor) == false && undefined !== pobjcc_CourseExamPaperEN.id_XzMajor && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjcc_CourseExamPaperEN.id_XzMajor)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.paperDispModeId) == false && undefined !== pobjcc_CourseExamPaperEN.paperDispModeId && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.paperDispModeId) === false) {
            throw new Error("(errid:Watl000060)字段[试卷显示模式Id(paperDispModeId)]的值:[$(pobjcc_CourseExamPaperEN.paperDispModeId)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examCreateTime) == false && undefined !== pobjcc_CourseExamPaperEN.examCreateTime && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.examCreateTime) === false) {
            throw new Error("(errid:Watl000060)字段[考卷建立时间(examCreateTime)]的值:[$(pobjcc_CourseExamPaperEN.examCreateTime)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.createUserID) == false && undefined !== pobjcc_CourseExamPaperEN.createUserID && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.createUserID) === false) {
            throw new Error("(errid:Watl000060)字段[建立用户ID(createUserID)]的值:[$(pobjcc_CourseExamPaperEN.createUserID)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.isOpenToAllStu && undefined !== pobjcc_CourseExamPaperEN.isOpenToAllStu && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseExamPaperEN.isOpenToAllStu) === false) {
            throw new Error("(errid:Watl000060)字段[全校师生(isOpenToAllStu)]的值:[$(pobjcc_CourseExamPaperEN.isOpenToAllStu)], 非法，应该为布尔型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.isOpenToSchool && undefined !== pobjcc_CourseExamPaperEN.isOpenToSchool && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseExamPaperEN.isOpenToSchool) === false) {
            throw new Error("(errid:Watl000060)字段[全校师生公开(isOpenToSchool)]的值:[$(pobjcc_CourseExamPaperEN.isOpenToSchool)], 非法，应该为布尔型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.isOpenToSocial && undefined !== pobjcc_CourseExamPaperEN.isOpenToSocial && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseExamPaperEN.isOpenToSocial) === false) {
            throw new Error("(errid:Watl000060)字段[社会公众(isOpenToSocial)]的值:[$(pobjcc_CourseExamPaperEN.isOpenToSocial)], 非法，应该为布尔型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseChapterId) == false && undefined !== pobjcc_CourseExamPaperEN.courseChapterId && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.courseChapterId) === false) {
            throw new Error("(errid:Watl000060)字段[课程章节ID(courseChapterId)]的值:[$(pobjcc_CourseExamPaperEN.courseChapterId)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.isAutoGeneQuestion && undefined !== pobjcc_CourseExamPaperEN.isAutoGeneQuestion && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseExamPaperEN.isAutoGeneQuestion) === false) {
            throw new Error("(errid:Watl000060)字段[是否自动生成题目(isAutoGeneQuestion)]的值:[$(pobjcc_CourseExamPaperEN.isAutoGeneQuestion)], 非法，应该为布尔型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseExamPaperEN.isCanMultiDo && undefined !== pobjcc_CourseExamPaperEN.isCanMultiDo && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseExamPaperEN.isCanMultiDo) === false) {
            throw new Error("(errid:Watl000060)字段[是否可以做多次(isCanMultiDo)]的值:[$(pobjcc_CourseExamPaperEN.isCanMultiDo)], 非法，应该为布尔型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.updDate) == false && undefined !== pobjcc_CourseExamPaperEN.updDate && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjcc_CourseExamPaperEN.updDate)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.updUserId) == false && undefined !== pobjcc_CourseExamPaperEN.updUserId && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjcc_CourseExamPaperEN.updUserId)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.memo) == false && undefined !== pobjcc_CourseExamPaperEN.memo && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjcc_CourseExamPaperEN.memo)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.courseId) != 8) {
            throw ("(errid:Watl000061)字段[课程Id]作为外键字段,长度应该为8(In 考卷)!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.id_XzMajor) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.id_XzMajor) != 8) {
            throw ("(errid:Watl000061)字段[专业流水号]作为外键字段,长度应该为8(In 考卷)!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjcc_CourseExamPaperEN.SetIsCheckProperty(true);
    }
    exports.cc_CourseExamPaper_CheckPropertyNew = cc_CourseExamPaper_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function cc_CourseExamPaper_CheckProperty4Update(pobjcc_CourseExamPaperEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseExamPaperId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.courseExamPaperId) > 8) {
            throw new Error("(errid:Watl000062)字段[考卷流水号(courseExamPaperId)]的长度不能超过8(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.courseExamPaperId)(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.courseId) > 8) {
            throw new Error("(errid:Watl000062)字段[课程Id(courseId)]的长度不能超过8(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.courseId)(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examPaperName) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.examPaperName) > 500) {
            throw new Error("(errid:Watl000062)字段[考卷名称(examPaperName)]的长度不能超过500(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.examPaperName)(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examPaperTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.examPaperTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[试卷类型Id(examPaperTypeId)]的长度不能超过2(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.examPaperTypeId)(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.id_XzMajor) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.id_XzMajor)(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.paperDispModeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.paperDispModeId) > 4) {
            throw new Error("(errid:Watl000062)字段[试卷显示模式Id(paperDispModeId)]的长度不能超过4(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.paperDispModeId)(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examCreateTime) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.examCreateTime) > 14) {
            throw new Error("(errid:Watl000062)字段[考卷建立时间(examCreateTime)]的长度不能超过14(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.examCreateTime)(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.createUserID) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.createUserID) > 20) {
            throw new Error("(errid:Watl000062)字段[建立用户ID(createUserID)]的长度不能超过20(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.createUserID)(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseChapterId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.courseChapterId) > 8) {
            throw new Error("(errid:Watl000062)字段[课程章节ID(courseChapterId)]的长度不能超过8(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.courseChapterId)(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.updDate)(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.updUserId)(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 考卷(cc_CourseExamPaper))!值:$(pobjcc_CourseExamPaperEN.memo)(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseExamPaperId) == false && undefined !== pobjcc_CourseExamPaperEN.courseExamPaperId && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.courseExamPaperId) === false) {
            throw new Error("(errid:Watl000063)字段[考卷流水号(courseExamPaperId)]的值:[$(pobjcc_CourseExamPaperEN.courseExamPaperId)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseId) == false && undefined !== pobjcc_CourseExamPaperEN.courseId && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.courseId) === false) {
            throw new Error("(errid:Watl000063)字段[课程Id(courseId)]的值:[$(pobjcc_CourseExamPaperEN.courseId)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examPaperName) == false && undefined !== pobjcc_CourseExamPaperEN.examPaperName && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.examPaperName) === false) {
            throw new Error("(errid:Watl000063)字段[考卷名称(examPaperName)]的值:[$(pobjcc_CourseExamPaperEN.examPaperName)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.paperIndex && undefined !== pobjcc_CourseExamPaperEN.paperIndex && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.paperIndex) === false) {
            throw new Error("(errid:Watl000063)字段[试卷序号(paperIndex)]的值:[$(pobjcc_CourseExamPaperEN.paperIndex)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examPaperTypeId) == false && undefined !== pobjcc_CourseExamPaperEN.examPaperTypeId && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.examPaperTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[试卷类型Id(examPaperTypeId)]的值:[$(pobjcc_CourseExamPaperEN.examPaperTypeId)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.isShow && undefined !== pobjcc_CourseExamPaperEN.isShow && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseExamPaperEN.isShow) === false) {
            throw new Error("(errid:Watl000063)字段[是否启用(isShow)]的值:[$(pobjcc_CourseExamPaperEN.isShow)], 非法，应该为布尔型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.totalScore && undefined !== pobjcc_CourseExamPaperEN.totalScore && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.totalScore) === false) {
            throw new Error("(errid:Watl000063)字段[总得分(totalScore)]的值:[$(pobjcc_CourseExamPaperEN.totalScore)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.viewCount && undefined !== pobjcc_CourseExamPaperEN.viewCount && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.viewCount) === false) {
            throw new Error("(errid:Watl000063)字段[浏览量(viewCount)]的值:[$(pobjcc_CourseExamPaperEN.viewCount)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.doneNumber && undefined !== pobjcc_CourseExamPaperEN.doneNumber && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.doneNumber) === false) {
            throw new Error("(errid:Watl000063)字段[已做人数(doneNumber)]的值:[$(pobjcc_CourseExamPaperEN.doneNumber)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.paperTime && undefined !== pobjcc_CourseExamPaperEN.paperTime && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.paperTime) === false) {
            throw new Error("(errid:Watl000063)字段[考试时间（分钟）(paperTime)]的值:[$(pobjcc_CourseExamPaperEN.paperTime)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.downloadNumber && undefined !== pobjcc_CourseExamPaperEN.downloadNumber && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.downloadNumber) === false) {
            throw new Error("(errid:Watl000063)字段[下载数目(downloadNumber)]的值:[$(pobjcc_CourseExamPaperEN.downloadNumber)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.collectionCount && undefined !== pobjcc_CourseExamPaperEN.collectionCount && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.collectionCount) === false) {
            throw new Error("(errid:Watl000063)字段[收藏数量(collectionCount)]的值:[$(pobjcc_CourseExamPaperEN.collectionCount)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.likeCount && undefined !== pobjcc_CourseExamPaperEN.likeCount && clsString_js_1.tzDataType.isNumber(pobjcc_CourseExamPaperEN.likeCount) === false) {
            throw new Error("(errid:Watl000063)字段[资源喜欢数量(likeCount)]的值:[$(pobjcc_CourseExamPaperEN.likeCount)], 非法，应该为数值型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.id_XzMajor) == false && undefined !== pobjcc_CourseExamPaperEN.id_XzMajor && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjcc_CourseExamPaperEN.id_XzMajor)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.paperDispModeId) == false && undefined !== pobjcc_CourseExamPaperEN.paperDispModeId && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.paperDispModeId) === false) {
            throw new Error("(errid:Watl000063)字段[试卷显示模式Id(paperDispModeId)]的值:[$(pobjcc_CourseExamPaperEN.paperDispModeId)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.examCreateTime) == false && undefined !== pobjcc_CourseExamPaperEN.examCreateTime && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.examCreateTime) === false) {
            throw new Error("(errid:Watl000063)字段[考卷建立时间(examCreateTime)]的值:[$(pobjcc_CourseExamPaperEN.examCreateTime)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.createUserID) == false && undefined !== pobjcc_CourseExamPaperEN.createUserID && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.createUserID) === false) {
            throw new Error("(errid:Watl000063)字段[建立用户ID(createUserID)]的值:[$(pobjcc_CourseExamPaperEN.createUserID)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.isOpenToAllStu && undefined !== pobjcc_CourseExamPaperEN.isOpenToAllStu && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseExamPaperEN.isOpenToAllStu) === false) {
            throw new Error("(errid:Watl000063)字段[全校师生(isOpenToAllStu)]的值:[$(pobjcc_CourseExamPaperEN.isOpenToAllStu)], 非法，应该为布尔型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.isOpenToSchool && undefined !== pobjcc_CourseExamPaperEN.isOpenToSchool && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseExamPaperEN.isOpenToSchool) === false) {
            throw new Error("(errid:Watl000063)字段[全校师生公开(isOpenToSchool)]的值:[$(pobjcc_CourseExamPaperEN.isOpenToSchool)], 非法，应该为布尔型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.isOpenToSocial && undefined !== pobjcc_CourseExamPaperEN.isOpenToSocial && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseExamPaperEN.isOpenToSocial) === false) {
            throw new Error("(errid:Watl000063)字段[社会公众(isOpenToSocial)]的值:[$(pobjcc_CourseExamPaperEN.isOpenToSocial)], 非法，应该为布尔型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseChapterId) == false && undefined !== pobjcc_CourseExamPaperEN.courseChapterId && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.courseChapterId) === false) {
            throw new Error("(errid:Watl000063)字段[课程章节ID(courseChapterId)]的值:[$(pobjcc_CourseExamPaperEN.courseChapterId)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.isAutoGeneQuestion && undefined !== pobjcc_CourseExamPaperEN.isAutoGeneQuestion && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseExamPaperEN.isAutoGeneQuestion) === false) {
            throw new Error("(errid:Watl000063)字段[是否自动生成题目(isAutoGeneQuestion)]的值:[$(pobjcc_CourseExamPaperEN.isAutoGeneQuestion)], 非法，应该为布尔型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseExamPaperEN.isCanMultiDo && undefined !== pobjcc_CourseExamPaperEN.isCanMultiDo && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseExamPaperEN.isCanMultiDo) === false) {
            throw new Error("(errid:Watl000063)字段[是否可以做多次(isCanMultiDo)]的值:[$(pobjcc_CourseExamPaperEN.isCanMultiDo)], 非法，应该为布尔型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.updDate) == false && undefined !== pobjcc_CourseExamPaperEN.updDate && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjcc_CourseExamPaperEN.updDate)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.updUserId) == false && undefined !== pobjcc_CourseExamPaperEN.updUserId && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjcc_CourseExamPaperEN.updUserId)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.memo) == false && undefined !== pobjcc_CourseExamPaperEN.memo && clsString_js_1.tzDataType.isString(pobjcc_CourseExamPaperEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjcc_CourseExamPaperEN.memo)], 非法，应该为字符型(In 考卷(cc_CourseExamPaper))!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseExamPaperId) === true
            || pobjcc_CourseExamPaperEN.courseExamPaperId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[考卷流水号]不能为空(In 考卷)!(clscc_CourseExamPaperBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.courseId) != 8) {
            throw ("(errid:Watl000065)字段[课程Id]作为外键字段,长度应该为8(In 考卷)!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseExamPaperEN.id_XzMajor) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseExamPaperEN.id_XzMajor) != 8) {
            throw ("(errid:Watl000065)字段[专业流水号]作为外键字段,长度应该为8(In 考卷)!(clscc_CourseExamPaperBL:CheckPropertyNew)");
        }
        pobjcc_CourseExamPaperEN.SetIsCheckProperty(true);
    }
    exports.cc_CourseExamPaper_CheckProperty4Update = cc_CourseExamPaper_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function cc_CourseExamPaper_GetJSONStrByObj(pobjcc_CourseExamPaperEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjcc_CourseExamPaperEN.sf_UpdFldSetStr = pobjcc_CourseExamPaperEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjcc_CourseExamPaperEN);
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
    exports.cc_CourseExamPaper_GetJSONStrByObj = cc_CourseExamPaper_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function cc_CourseExamPaper_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrcc_CourseExamPaperObjLst = new Array();
        if (strJSON === "") {
            return arrcc_CourseExamPaperObjLst;
        }
        try {
            arrcc_CourseExamPaperObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrcc_CourseExamPaperObjLst;
        }
        return arrcc_CourseExamPaperObjLst;
    }
    exports.cc_CourseExamPaper_GetObjLstByJSONStr = cc_CourseExamPaper_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrcc_CourseExamPaperObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function cc_CourseExamPaper_GetObjLstByJSONObjLst(arrcc_CourseExamPaperObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrcc_CourseExamPaperObjLst = new Array();
        for (const objInFor of arrcc_CourseExamPaperObjLstS) {
            const obj1 = cc_CourseExamPaper_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrcc_CourseExamPaperObjLst.push(obj1);
        }
        return arrcc_CourseExamPaperObjLst;
    }
    exports.cc_CourseExamPaper_GetObjLstByJSONObjLst = cc_CourseExamPaper_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function cc_CourseExamPaper_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjcc_CourseExamPaperEN = new clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN();
        if (strJSON === "") {
            return pobjcc_CourseExamPaperEN;
        }
        try {
            pobjcc_CourseExamPaperEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjcc_CourseExamPaperEN;
        }
        return pobjcc_CourseExamPaperEN;
    }
    exports.cc_CourseExamPaper_GetObjByJSONStr = cc_CourseExamPaper_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function cc_CourseExamPaper_GetCombineCondition(objcc_CourseExamPaper_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseExamPaperId) == true) {
            const strComparisonOp_CourseExamPaperId = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseExamPaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseExamPaperId, objcc_CourseExamPaper_Cond.courseExamPaperId, strComparisonOp_CourseExamPaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseId, objcc_CourseExamPaper_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperName) == true) {
            const strComparisonOp_ExamPaperName = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperName, objcc_CourseExamPaper_Cond.examPaperName, strComparisonOp_ExamPaperName);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperIndex) == true) {
            const strComparisonOp_PaperIndex = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperIndex];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperIndex, objcc_CourseExamPaper_Cond.paperIndex, strComparisonOp_PaperIndex);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperTypeId) == true) {
            const strComparisonOp_ExamPaperTypeId = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamPaperTypeId, objcc_CourseExamPaper_Cond.examPaperTypeId, strComparisonOp_ExamPaperTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsShow) == true) {
            if (objcc_CourseExamPaper_Cond.isShow == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsShow);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsShow);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_TotalScore) == true) {
            const strComparisonOp_TotalScore = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_TotalScore];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_TotalScore, objcc_CourseExamPaper_Cond.totalScore, strComparisonOp_TotalScore);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ViewCount) == true) {
            const strComparisonOp_ViewCount = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ViewCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ViewCount, objcc_CourseExamPaper_Cond.viewCount, strComparisonOp_ViewCount);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_DoneNumber) == true) {
            const strComparisonOp_DoneNumber = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_DoneNumber];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_DoneNumber, objcc_CourseExamPaper_Cond.doneNumber, strComparisonOp_DoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperTime) == true) {
            const strComparisonOp_PaperTime = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperTime];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperTime, objcc_CourseExamPaper_Cond.paperTime, strComparisonOp_PaperTime);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_DownloadNumber) == true) {
            const strComparisonOp_DownloadNumber = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_DownloadNumber];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_DownloadNumber, objcc_CourseExamPaper_Cond.downloadNumber, strComparisonOp_DownloadNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CollectionCount) == true) {
            const strComparisonOp_CollectionCount = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CollectionCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CollectionCount, objcc_CourseExamPaper_Cond.collectionCount, strComparisonOp_CollectionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_LikeCount) == true) {
            const strComparisonOp_LikeCount = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_LikeCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_LikeCount, objcc_CourseExamPaper_Cond.likeCount, strComparisonOp_LikeCount);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_id_XzMajor, objcc_CourseExamPaper_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperDispModeId) == true) {
            const strComparisonOp_PaperDispModeId = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperDispModeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_PaperDispModeId, objcc_CourseExamPaper_Cond.paperDispModeId, strComparisonOp_PaperDispModeId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamCreateTime) == true) {
            const strComparisonOp_ExamCreateTime = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamCreateTime];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_ExamCreateTime, objcc_CourseExamPaper_Cond.examCreateTime, strComparisonOp_ExamCreateTime);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CreateUserID) == true) {
            const strComparisonOp_CreateUserID = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CreateUserID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CreateUserID, objcc_CourseExamPaper_Cond.createUserID, strComparisonOp_CreateUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToAllStu) == true) {
            if (objcc_CourseExamPaper_Cond.isOpenToAllStu == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToAllStu);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToAllStu);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToSchool) == true) {
            if (objcc_CourseExamPaper_Cond.isOpenToSchool == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToSchool);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToSchool);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToSocial) == true) {
            if (objcc_CourseExamPaper_Cond.isOpenToSocial == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToSocial);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsOpenToSocial);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseChapterId) == true) {
            const strComparisonOp_CourseChapterId = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseChapterId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_CourseChapterId, objcc_CourseExamPaper_Cond.courseChapterId, strComparisonOp_CourseChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsAutoGeneQuestion) == true) {
            if (objcc_CourseExamPaper_Cond.isAutoGeneQuestion == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsAutoGeneQuestion);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsAutoGeneQuestion);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsCanMultiDo) == true) {
            if (objcc_CourseExamPaper_Cond.isCanMultiDo == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsCanMultiDo);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_IsCanMultiDo);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_UpdDate, objcc_CourseExamPaper_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_UpdUserId, objcc_CourseExamPaper_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseExamPaper_Cond.dicFldComparisonOp, clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_Memo) == true) {
            const strComparisonOp_Memo = objcc_CourseExamPaper_Cond.dicFldComparisonOp[clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN.con_Memo, objcc_CourseExamPaper_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.cc_CourseExamPaper_GetCombineCondition = cc_CourseExamPaper_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--cc_CourseExamPaper(考卷),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strExamPaperName: 考卷名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function cc_CourseExamPaper_GetUniCondStr_ExamPaperName(objcc_CourseExamPaperEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ExamPaperName = '{0}'", objcc_CourseExamPaperEN.examPaperName);
        return strWhereCond;
    }
    exports.cc_CourseExamPaper_GetUniCondStr_ExamPaperName = cc_CourseExamPaper_GetUniCondStr_ExamPaperName;
    /**
    *获取唯一性条件串(Uniqueness)--cc_CourseExamPaper(考卷),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strExamPaperName: 考卷名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function cc_CourseExamPaper_GetUniCondStr4Update_ExamPaperName(objcc_CourseExamPaperEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and CourseExamPaperId <> '{0}'", objcc_CourseExamPaperEN.courseExamPaperId);
        strWhereCond += (0, clsString_js_2.Format)(" and ExamPaperName = '{0}'", objcc_CourseExamPaperEN.examPaperName);
        return strWhereCond;
    }
    exports.cc_CourseExamPaper_GetUniCondStr4Update_ExamPaperName = cc_CourseExamPaper_GetUniCondStr4Update_ExamPaperName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objcc_CourseExamPaperENS:源对象
     * @param objcc_CourseExamPaperENT:目标对象
    */
    function cc_CourseExamPaper_CopyObjTo(objcc_CourseExamPaperENS, objcc_CourseExamPaperENT) {
        objcc_CourseExamPaperENT.courseExamPaperId = objcc_CourseExamPaperENS.courseExamPaperId; //考卷流水号
        objcc_CourseExamPaperENT.courseId = objcc_CourseExamPaperENS.courseId; //课程Id
        objcc_CourseExamPaperENT.examPaperName = objcc_CourseExamPaperENS.examPaperName; //考卷名称
        objcc_CourseExamPaperENT.paperIndex = objcc_CourseExamPaperENS.paperIndex; //试卷序号
        objcc_CourseExamPaperENT.examPaperTypeId = objcc_CourseExamPaperENS.examPaperTypeId; //试卷类型Id
        objcc_CourseExamPaperENT.isShow = objcc_CourseExamPaperENS.isShow; //是否启用
        objcc_CourseExamPaperENT.totalScore = objcc_CourseExamPaperENS.totalScore; //总得分
        objcc_CourseExamPaperENT.viewCount = objcc_CourseExamPaperENS.viewCount; //浏览量
        objcc_CourseExamPaperENT.doneNumber = objcc_CourseExamPaperENS.doneNumber; //已做人数
        objcc_CourseExamPaperENT.paperTime = objcc_CourseExamPaperENS.paperTime; //考试时间（分钟）
        objcc_CourseExamPaperENT.downloadNumber = objcc_CourseExamPaperENS.downloadNumber; //下载数目
        objcc_CourseExamPaperENT.collectionCount = objcc_CourseExamPaperENS.collectionCount; //收藏数量
        objcc_CourseExamPaperENT.likeCount = objcc_CourseExamPaperENS.likeCount; //资源喜欢数量
        objcc_CourseExamPaperENT.id_XzMajor = objcc_CourseExamPaperENS.id_XzMajor; //专业流水号
        objcc_CourseExamPaperENT.paperDispModeId = objcc_CourseExamPaperENS.paperDispModeId; //试卷显示模式Id
        objcc_CourseExamPaperENT.examCreateTime = objcc_CourseExamPaperENS.examCreateTime; //考卷建立时间
        objcc_CourseExamPaperENT.createUserID = objcc_CourseExamPaperENS.createUserID; //建立用户ID
        objcc_CourseExamPaperENT.isOpenToAllStu = objcc_CourseExamPaperENS.isOpenToAllStu; //全校师生
        objcc_CourseExamPaperENT.isOpenToSchool = objcc_CourseExamPaperENS.isOpenToSchool; //全校师生公开
        objcc_CourseExamPaperENT.isOpenToSocial = objcc_CourseExamPaperENS.isOpenToSocial; //社会公众
        objcc_CourseExamPaperENT.courseChapterId = objcc_CourseExamPaperENS.courseChapterId; //课程章节ID
        objcc_CourseExamPaperENT.isAutoGeneQuestion = objcc_CourseExamPaperENS.isAutoGeneQuestion; //是否自动生成题目
        objcc_CourseExamPaperENT.isCanMultiDo = objcc_CourseExamPaperENS.isCanMultiDo; //是否可以做多次
        objcc_CourseExamPaperENT.updDate = objcc_CourseExamPaperENS.updDate; //修改日期
        objcc_CourseExamPaperENT.updUserId = objcc_CourseExamPaperENS.updUserId; //修改用户Id
        objcc_CourseExamPaperENT.memo = objcc_CourseExamPaperENS.memo; //备注
        objcc_CourseExamPaperENT.sf_UpdFldSetStr = objcc_CourseExamPaperENS.updFldString; //sf_UpdFldSetStr
    }
    exports.cc_CourseExamPaper_CopyObjTo = cc_CourseExamPaper_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objcc_CourseExamPaperENS:源对象
     * @param objcc_CourseExamPaperENT:目标对象
    */
    function cc_CourseExamPaper_GetObjFromJsonObj(objcc_CourseExamPaperENS) {
        const objcc_CourseExamPaperENT = new clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_CourseExamPaperENT, objcc_CourseExamPaperENS);
        return objcc_CourseExamPaperENT;
    }
    exports.cc_CourseExamPaper_GetObjFromJsonObj = cc_CourseExamPaper_GetObjFromJsonObj;
});
