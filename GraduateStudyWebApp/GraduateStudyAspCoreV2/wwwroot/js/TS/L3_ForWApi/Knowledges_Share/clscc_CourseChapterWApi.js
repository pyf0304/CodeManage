/**
* 类名:clscc_CourseChapterWApi
* 表名:cc_CourseChapter(01120060)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:12:56
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_CourseChapter_GetObjFromJsonObj = exports.cc_CourseChapter_CopyObjTo = exports.cc_CourseChapter_GetUniCondStr4Update_CourseId_CourseChapterName = exports.cc_CourseChapter_GetUniCondStr_CourseId_CourseChapterName = exports.cc_CourseChapter_GetCombineCondition = exports.cc_CourseChapter_GetObjByJSONStr = exports.cc_CourseChapter_GetObjLstByJSONObjLst = exports.cc_CourseChapter_GetObjLstByJSONStr = exports.cc_CourseChapter_GetJSONStrByObj = exports.cc_CourseChapter_CheckProperty4Update = exports.cc_CourseChapter_CheckPropertyNew = exports.cc_CourseChapter_BindDdl_CourseChapterIdInDiv_Cache = exports.cc_CourseChapter_ReFreshThisCache = exports.cc_CourseChapter_ReFreshCache = exports.cc_CourseChapter_GetWebApiUrl = exports.cc_CourseChapter_GetMaxStrIdByPrefix = exports.cc_CourseChapter_GetMaxStrIdAsync = exports.cc_CourseChapter_GetRecCountByCond_Cache = exports.cc_CourseChapter_GetRecCountByCondAsync = exports.cc_CourseChapter_IsExistAsync = exports.cc_CourseChapter_IsExist_Cache = exports.cc_CourseChapter_IsExist = exports.cc_CourseChapter_IsExistRecordAsync = exports.cc_CourseChapter_IsExistRecord_Cache = exports.cc_CourseChapter_UpdateWithConditionAsync = exports.cc_CourseChapter_UpdateRecordAsync = exports.cc_CourseChapter_AddNewRecordWithReturnKey = exports.cc_CourseChapter_AddNewRecordWithReturnKeyAsync = exports.cc_CourseChapter_ReOrderAsync = exports.cc_CourseChapter_GoBottomAsync = exports.cc_CourseChapter_DownMoveAsync = exports.cc_CourseChapter_UpMoveAsync = exports.cc_CourseChapter_GoTopAsync = exports.cc_CourseChapter_AddNewRecordWithMaxIdAsync = exports.cc_CourseChapter_AddNewRecordAsync = exports.cc_CourseChapter_Delcc_CourseChaptersByCondAsync = exports.cc_CourseChapter_Delcc_CourseChaptersAsync = exports.cc_CourseChapter_DelRecordAsync = exports.cc_CourseChapter_GetObjLstByPagerAsync = exports.cc_CourseChapter_GetObjLstByPager_Cache = exports.cc_CourseChapter_GetObjLstByRange = exports.cc_CourseChapter_GetObjLstByRangeAsync = exports.cc_CourseChapter_GetTopObjLstAsync = exports.cc_CourseChapter_GetObjLstByCourseChapterIdLst_Cache = exports.cc_CourseChapter_GetObjLstByCourseChapterIdLstAsync = exports.cc_CourseChapter_GetSubObjLst_Cache = exports.cc_CourseChapter_GetObjLst_PureCache = exports.cc_CourseChapter_GetObjLst_Cache = exports.cc_CourseChapter_GetObjLst_sessionStorage_PureCache = exports.cc_CourseChapter_GetObjLst_sessionStorage = exports.cc_CourseChapter_GetObjLstAsync = exports.cc_CourseChapter_GetObjLst_localStorage_PureCache = exports.cc_CourseChapter_GetObjLst_localStorage = exports.cc_CourseChapter_GetObjLst_ClientCache = exports.cc_CourseChapter_GetFirstObjAsync = exports.cc_CourseChapter_GetFirstID = exports.cc_CourseChapter_GetFirstIDAsync = exports.cc_CourseChapter_funcKey = exports.cc_CourseChapter_FilterFunByKey = exports.cc_CourseChapter_SortFunByKey = exports.cc_CourseChapter_SortFun_Defa_2Fld = exports.cc_CourseChapter_SortFun_Defa = exports.cc_CourseChapter_func = exports.cc_CourseChapter_GetNameByCourseChapterId_Cache = exports.cc_CourseChapter_UpdateObjInLst_Cache = exports.cc_CourseChapter_GetObjByCourseChapterId_localStorage = exports.cc_CourseChapter_GetObjByCourseChapterId_Cache = exports.cc_CourseChapter_GetObjByCourseChapterIdAsync = exports.cc_CourseChapter_ConstructorName = exports.cc_CourseChapter_Controller = void 0;
    /**
     * 课程章节(cc_CourseChapter)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clscc_CourseChapterEN_js_1 = require("../../L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.cc_CourseChapter_Controller = "cc_CourseChapterApi";
    exports.cc_CourseChapter_ConstructorName = "cc_CourseChapter";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCourseChapterId:关键字
    * @returns 对象
    **/
    async function cc_CourseChapter_GetObjByCourseChapterIdAsync(strCourseChapterId) {
        const strThisFuncName = "GetObjByCourseChapterIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseChapterId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseChapterId]不能为空！(In clscc_CourseChapterWApi.GetObjByCourseChapterIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseChapterId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseChapterId]的长度:[{0}]不正确！(clscc_CourseChapterWApi.GetObjByCourseChapterIdAsync)", strCourseChapterId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCourseChapterId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCourseChapterId": strCourseChapterId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objcc_CourseChapter = cc_CourseChapter_GetObjFromJsonObj(returnObj);
                return objcc_CourseChapter;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetObjByCourseChapterIdAsync = cc_CourseChapter_GetObjByCourseChapterIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strCourseChapterId:所给的关键字
     * @returns 对象
    */
    async function cc_CourseChapter_GetObjByCourseChapterId_Cache(strCourseChapterId, strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByCourseChapterId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseChapterId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseChapterId]不能为空！(In clscc_CourseChapterWApi.GetObjByCourseChapterId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseChapterId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseChapterId]的长度:[{0}]不正确！(clscc_CourseChapterWApi.GetObjByCourseChapterId_Cache)", strCourseChapterId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_Cache(strCourseId);
        try {
            const arrcc_CourseChapter_Sel = arrcc_CourseChapterObjLst_Cache.filter(x => x.courseChapterId == strCourseChapterId);
            let objcc_CourseChapter;
            if (arrcc_CourseChapter_Sel.length > 0) {
                objcc_CourseChapter = arrcc_CourseChapter_Sel[0];
                return objcc_CourseChapter;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objcc_CourseChapter_Const = await cc_CourseChapter_GetObjByCourseChapterIdAsync(strCourseChapterId);
                    if (objcc_CourseChapter_Const != null) {
                        cc_CourseChapter_ReFreshThisCache(strCourseId);
                        return objcc_CourseChapter_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseChapterId, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.cc_CourseChapter_GetObjByCourseChapterId_Cache = cc_CourseChapter_GetObjByCourseChapterId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strCourseChapterId:所给的关键字
     * @returns 对象
    */
    async function cc_CourseChapter_GetObjByCourseChapterId_localStorage(strCourseChapterId) {
        const strThisFuncName = "GetObjByCourseChapterId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseChapterId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseChapterId]不能为空！(In clscc_CourseChapterWApi.GetObjByCourseChapterId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseChapterId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseChapterId]的长度:[{0}]不正确！(clscc_CourseChapterWApi.GetObjByCourseChapterId_localStorage)", strCourseChapterId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, strCourseChapterId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objcc_CourseChapter_Cache = JSON.parse(strTempObj);
            return objcc_CourseChapter_Cache;
        }
        try {
            const objcc_CourseChapter = await cc_CourseChapter_GetObjByCourseChapterIdAsync(strCourseChapterId);
            if (objcc_CourseChapter != null) {
                localStorage.setItem(strKey, JSON.stringify(objcc_CourseChapter));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objcc_CourseChapter;
            }
            return objcc_CourseChapter;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseChapterId, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.cc_CourseChapter_GetObjByCourseChapterId_localStorage = cc_CourseChapter_GetObjByCourseChapterId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objcc_CourseChapter:所给的对象
     * @returns 对象
    */
    async function cc_CourseChapter_UpdateObjInLst_Cache(objcc_CourseChapter, strCourseId) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_Cache(strCourseId);
            const obj = arrcc_CourseChapterObjLst_Cache.find(x => x.courseId == objcc_CourseChapter.courseId && x.courseChapterName == objcc_CourseChapter.courseChapterName);
            if (obj != null) {
                objcc_CourseChapter.courseChapterId = obj.courseChapterId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objcc_CourseChapter);
            }
            else {
                arrcc_CourseChapterObjLst_Cache.push(objcc_CourseChapter);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_CourseChapter_UpdateObjInLst_Cache = cc_CourseChapter_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strCourseChapterId:所给的关键字
     * @returns 对象
    */
    async function cc_CourseChapter_GetNameByCourseChapterId_Cache(strCourseChapterId, strCourseId) {
        const strThisFuncName = "GetNameByCourseChapterId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseChapterId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseChapterId]不能为空！(In clscc_CourseChapterWApi.GetNameByCourseChapterId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseChapterId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseChapterId]的长度:[{0}]不正确！(clscc_CourseChapterWApi.GetNameByCourseChapterId_Cache)", strCourseChapterId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_Cache(strCourseId);
        if (arrcc_CourseChapterObjLst_Cache == null)
            return "";
        try {
            const arrcc_CourseChapter_Sel = arrcc_CourseChapterObjLst_Cache.filter(x => x.courseChapterId == strCourseChapterId);
            let objcc_CourseChapter;
            if (arrcc_CourseChapter_Sel.length > 0) {
                objcc_CourseChapter = arrcc_CourseChapter_Sel[0];
                return objcc_CourseChapter.courseChapterName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strCourseChapterId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.cc_CourseChapter_GetNameByCourseChapterId_Cache = cc_CourseChapter_GetNameByCourseChapterId_Cache;
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
    async function cc_CourseChapter_func(strInFldName, strOutFldName, strInValue, strCourseId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId_C]不能为空！(In clscc_CourseChapterWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clscc_CourseChapterWApi.func)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strCourseChapterId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objcc_CourseChapter = await cc_CourseChapter_GetObjByCourseChapterId_Cache(strCourseChapterId, strCourseId_C);
        if (objcc_CourseChapter == null)
            return "";
        if (objcc_CourseChapter.GetFldValue(strOutFldName) == null)
            return "";
        return objcc_CourseChapter.GetFldValue(strOutFldName).toString();
    }
    exports.cc_CourseChapter_func = cc_CourseChapter_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_CourseChapter_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.courseChapterId.localeCompare(b.courseChapterId);
    }
    exports.cc_CourseChapter_SortFun_Defa = cc_CourseChapter_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_CourseChapter_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.courseChapterName == b.courseChapterName)
            return a.chapterId.localeCompare(b.chapterId);
        else
            return a.courseChapterName.localeCompare(b.courseChapterName);
    }
    exports.cc_CourseChapter_SortFun_Defa_2Fld = cc_CourseChapter_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_CourseChapter_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId:
                    return (a, b) => {
                        return a.courseChapterId.localeCompare(b.courseChapterId);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName:
                    return (a, b) => {
                        return a.courseChapterName.localeCompare(b.courseChapterName);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterId:
                    return (a, b) => {
                        if (a.chapterId == null)
                            return -1;
                        if (b.chapterId == null)
                            return 1;
                        return a.chapterId.localeCompare(b.chapterId);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionId:
                    return (a, b) => {
                        if (a.sectionId == null)
                            return -1;
                        if (b.sectionId == null)
                            return 1;
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName:
                    return (a, b) => {
                        if (a.chapterName == null)
                            return -1;
                        if (b.chapterName == null)
                            return 1;
                        return a.chapterName.localeCompare(b.chapterName);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName:
                    return (a, b) => {
                        if (a.sectionName == null)
                            return -1;
                        if (b.sectionName == null)
                            return 1;
                        return a.sectionName.localeCompare(b.sectionName);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName_Sim:
                    return (a, b) => {
                        if (a.chapterName_Sim == null)
                            return -1;
                        if (b.chapterName_Sim == null)
                            return 1;
                        return a.chapterName_Sim.localeCompare(b.chapterName_Sim);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName_Sim:
                    return (a, b) => {
                        if (a.sectionName_Sim == null)
                            return -1;
                        if (b.sectionName_Sim == null)
                            return 1;
                        return a.sectionName_Sim.localeCompare(b.sectionName_Sim);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterContent:
                    return (a, b) => {
                        if (a.chapterContent == null)
                            return -1;
                        if (b.chapterContent == null)
                            return 1;
                        return a.chapterContent.localeCompare(b.chapterContent);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseId:
                    return (a, b) => {
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ParentNodeID:
                    return (a, b) => {
                        return a.parentNodeID.localeCompare(b.parentNodeID);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToAllStu:
                    return (a, b) => {
                        if (a.isOpenToAllStu == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToSchool:
                    return (a, b) => {
                        if (a.isOpenToSchool == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToSocial:
                    return (a, b) => {
                        if (a.isOpenToSocial == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsMustMenu:
                    return (a, b) => {
                        if (a.isMustMenu == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ThemeName:
                    return (a, b) => {
                        if (a.themeName == null)
                            return -1;
                        if (b.themeName == null)
                            return 1;
                        return a.themeName.localeCompare(b.themeName);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsFile:
                    return (a, b) => {
                        if (a.isFile == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsUse:
                    return (a, b) => {
                        if (a.isUse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ViewCount:
                    return (a, b) => {
                        return a.viewCount - b.viewCount;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterReferred:
                    return (a, b) => {
                        if (a.courseChapterReferred == null)
                            return -1;
                        if (b.courseChapterReferred == null)
                            return 1;
                        return a.courseChapterReferred.localeCompare(b.courseChapterReferred);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_EditPeople:
                    return (a, b) => {
                        if (a.editPeople == null)
                            return -1;
                        if (b.editPeople == null)
                            return 1;
                        return a.editPeople.localeCompare(b.editPeople);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[cc_CourseChapter]中不存在！(in ${exports.cc_CourseChapter_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId:
                    return (a, b) => {
                        return b.courseChapterId.localeCompare(a.courseChapterId);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName:
                    return (a, b) => {
                        return b.courseChapterName.localeCompare(a.courseChapterName);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterId:
                    return (a, b) => {
                        if (b.chapterId == null)
                            return -1;
                        if (a.chapterId == null)
                            return 1;
                        return b.chapterId.localeCompare(a.chapterId);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionId:
                    return (a, b) => {
                        if (b.sectionId == null)
                            return -1;
                        if (a.sectionId == null)
                            return 1;
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName:
                    return (a, b) => {
                        if (b.chapterName == null)
                            return -1;
                        if (a.chapterName == null)
                            return 1;
                        return b.chapterName.localeCompare(a.chapterName);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName:
                    return (a, b) => {
                        if (b.sectionName == null)
                            return -1;
                        if (a.sectionName == null)
                            return 1;
                        return b.sectionName.localeCompare(a.sectionName);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName_Sim:
                    return (a, b) => {
                        if (b.chapterName_Sim == null)
                            return -1;
                        if (a.chapterName_Sim == null)
                            return 1;
                        return b.chapterName_Sim.localeCompare(a.chapterName_Sim);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName_Sim:
                    return (a, b) => {
                        if (b.sectionName_Sim == null)
                            return -1;
                        if (a.sectionName_Sim == null)
                            return 1;
                        return b.sectionName_Sim.localeCompare(a.sectionName_Sim);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterContent:
                    return (a, b) => {
                        if (b.chapterContent == null)
                            return -1;
                        if (a.chapterContent == null)
                            return 1;
                        return b.chapterContent.localeCompare(a.chapterContent);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseId:
                    return (a, b) => {
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ParentNodeID:
                    return (a, b) => {
                        return b.parentNodeID.localeCompare(a.parentNodeID);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToAllStu:
                    return (a, b) => {
                        if (b.isOpenToAllStu == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToSchool:
                    return (a, b) => {
                        if (b.isOpenToSchool == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToSocial:
                    return (a, b) => {
                        if (b.isOpenToSocial == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsMustMenu:
                    return (a, b) => {
                        if (b.isMustMenu == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ThemeName:
                    return (a, b) => {
                        if (b.themeName == null)
                            return -1;
                        if (a.themeName == null)
                            return 1;
                        return b.themeName.localeCompare(a.themeName);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsFile:
                    return (a, b) => {
                        if (b.isFile == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsUse:
                    return (a, b) => {
                        if (b.isUse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ViewCount:
                    return (a, b) => {
                        return b.viewCount - a.viewCount;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterReferred:
                    return (a, b) => {
                        if (b.courseChapterReferred == null)
                            return -1;
                        if (a.courseChapterReferred == null)
                            return 1;
                        return b.courseChapterReferred.localeCompare(a.courseChapterReferred);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_EditPeople:
                    return (a, b) => {
                        if (b.editPeople == null)
                            return -1;
                        if (a.editPeople == null)
                            return 1;
                        return b.editPeople.localeCompare(a.editPeople);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[cc_CourseChapter]中不存在！(in ${exports.cc_CourseChapter_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.cc_CourseChapter_SortFunByKey = cc_CourseChapter_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function cc_CourseChapter_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId:
                return (obj) => {
                    return obj.courseChapterId === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName:
                return (obj) => {
                    return obj.courseChapterName === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterId:
                return (obj) => {
                    return obj.chapterId === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName:
                return (obj) => {
                    return obj.chapterName === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName:
                return (obj) => {
                    return obj.sectionName === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName_Sim:
                return (obj) => {
                    return obj.chapterName_Sim === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName_Sim:
                return (obj) => {
                    return obj.sectionName_Sim === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterContent:
                return (obj) => {
                    return obj.chapterContent === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ParentNodeID:
                return (obj) => {
                    return obj.parentNodeID === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToAllStu:
                return (obj) => {
                    return obj.isOpenToAllStu === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToSchool:
                return (obj) => {
                    return obj.isOpenToSchool === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToSocial:
                return (obj) => {
                    return obj.isOpenToSocial === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsMustMenu:
                return (obj) => {
                    return obj.isMustMenu === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ThemeName:
                return (obj) => {
                    return obj.themeName === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsFile:
                return (obj) => {
                    return obj.isFile === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsUse:
                return (obj) => {
                    return obj.isUse === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ViewCount:
                return (obj) => {
                    return obj.viewCount === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterReferred:
                return (obj) => {
                    return obj.courseChapterReferred === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_EditPeople:
                return (obj) => {
                    return obj.editPeople === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[cc_CourseChapter]中不存在！(in ${exports.cc_CourseChapter_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.cc_CourseChapter_FilterFunByKey = cc_CourseChapter_FilterFunByKey;
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
    async function cc_CourseChapter_funcKey(strInFldName, strInValue, strComparisonOp, strCourseId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId_C]不能为空！(In clscc_CourseChapterWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clscc_CourseChapterWApi.funcKey)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrcc_CourseChapter = await cc_CourseChapter_GetObjLst_Cache(strCourseId_C);
        if (arrcc_CourseChapter == null)
            return [];
        let arrcc_CourseChapter_Sel = arrcc_CourseChapter;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrcc_CourseChapter_Sel.length == 0)
            return [];
        return arrcc_CourseChapter_Sel.map(x => x.courseChapterId);
    }
    exports.cc_CourseChapter_funcKey = cc_CourseChapter_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function cc_CourseChapter_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetFirstIDAsync = cc_CourseChapter_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function cc_CourseChapter_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetFirstID = cc_CourseChapter_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function cc_CourseChapter_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
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
                const objcc_CourseChapter = cc_CourseChapter_GetObjFromJsonObj(returnObj);
                return objcc_CourseChapter;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetFirstObjAsync = cc_CourseChapter_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseChapter_GetObjLst_ClientCache(strCourseId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrcc_CourseChapterExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrcc_CourseChapterObjLst_T = cc_CourseChapter_GetObjLstByJSONObjLst(arrcc_CourseChapterExObjLst_Cache);
            return arrcc_CourseChapterObjLst_T;
        }
        try {
            const arrcc_CourseChapterExObjLst = await cc_CourseChapter_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrcc_CourseChapterExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseChapterExObjLst.length);
            console.log(strInfo);
            return arrcc_CourseChapterExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseChapter_GetObjLst_ClientCache = cc_CourseChapter_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseChapter_GetObjLst_localStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrcc_CourseChapterExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrcc_CourseChapterObjLst_T = cc_CourseChapter_GetObjLstByJSONObjLst(arrcc_CourseChapterExObjLst_Cache);
            return arrcc_CourseChapterObjLst_T;
        }
        try {
            const arrcc_CourseChapterExObjLst = await cc_CourseChapter_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrcc_CourseChapterExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseChapterExObjLst.length);
            console.log(strInfo);
            return arrcc_CourseChapterExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseChapter_GetObjLst_localStorage = cc_CourseChapter_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseChapter_GetObjLst_localStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrcc_CourseChapterObjLst_Cache = JSON.parse(strTempObjLst);
            return arrcc_CourseChapterObjLst_Cache;
        }
        else
            return null;
    }
    exports.cc_CourseChapter_GetObjLst_localStorage_PureCache = cc_CourseChapter_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function cc_CourseChapter_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseChapter_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetObjLstAsync = cc_CourseChapter_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseChapter_GetObjLst_sessionStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrcc_CourseChapterExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrcc_CourseChapterObjLst_T = cc_CourseChapter_GetObjLstByJSONObjLst(arrcc_CourseChapterExObjLst_Cache);
            return arrcc_CourseChapterObjLst_T;
        }
        try {
            const arrcc_CourseChapterExObjLst = await cc_CourseChapter_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrcc_CourseChapterExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseChapterExObjLst.length);
            console.log(strInfo);
            return arrcc_CourseChapterExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseChapter_GetObjLst_sessionStorage = cc_CourseChapter_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseChapter_GetObjLst_sessionStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrcc_CourseChapterObjLst_Cache = JSON.parse(strTempObjLst);
            return arrcc_CourseChapterObjLst_Cache;
        }
        else
            return null;
    }
    exports.cc_CourseChapter_GetObjLst_sessionStorage_PureCache = cc_CourseChapter_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseChapter_GetObjLst_Cache(strCourseId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[CourseId]不能为空！(in clscc_CourseChapterWApi.cc_CourseChapter_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(in clscc_CourseChapterWApi.cc_CourseChapter_GetObjLst_Cache() )", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrcc_CourseChapterObjLst_Cache;
        switch (clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.CacheModeId) {
            case "04": //sessionStorage
                arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_sessionStorage(strCourseId);
                break;
            case "03": //localStorage
                arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_localStorage(strCourseId);
                break;
            case "02": //ClientCache
                arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_ClientCache(strCourseId);
                break;
            default:
                arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_ClientCache(strCourseId);
                break;
        }
        const arrcc_CourseChapterObjLst = cc_CourseChapter_GetObjLstByJSONObjLst(arrcc_CourseChapterObjLst_Cache);
        return arrcc_CourseChapterObjLst_Cache;
    }
    exports.cc_CourseChapter_GetObjLst_Cache = cc_CourseChapter_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseChapter_GetObjLst_PureCache(strCourseId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrcc_CourseChapterObjLst_Cache;
        switch (clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.CacheModeId) {
            case "04": //sessionStorage
                arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_sessionStorage_PureCache(strCourseId);
                break;
            case "03": //localStorage
                arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_localStorage_PureCache(strCourseId);
                break;
            case "02": //ClientCache
                arrcc_CourseChapterObjLst_Cache = null;
                break;
            default:
                arrcc_CourseChapterObjLst_Cache = null;
                break;
        }
        return arrcc_CourseChapterObjLst_Cache;
    }
    exports.cc_CourseChapter_GetObjLst_PureCache = cc_CourseChapter_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrCourseChapterId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function cc_CourseChapter_GetSubObjLst_Cache(objcc_CourseChapter_Cond, strCourseId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_Cache(strCourseId);
        let arrcc_CourseChapter_Sel = arrcc_CourseChapterObjLst_Cache;
        if (objcc_CourseChapter_Cond.sf_FldComparisonOp == null || objcc_CourseChapter_Cond.sf_FldComparisonOp == "")
            return arrcc_CourseChapter_Sel;
        const dicFldComparisonOp = JSON.parse(objcc_CourseChapter_Cond.sf_FldComparisonOp);
        //console.log("clscc_CourseChapterWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_CourseChapter_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseChapter_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrcc_CourseChapter_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objcc_CourseChapter_Cond), exports.cc_CourseChapter_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_CourseChapter_GetSubObjLst_Cache = cc_CourseChapter_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCourseChapterId:关键字列表
    * @returns 对象列表
    **/
    async function cc_CourseChapter_GetObjLstByCourseChapterIdLstAsync(arrCourseChapterId) {
        const strThisFuncName = "GetObjLstByCourseChapterIdLstAsync";
        const strAction = "GetObjLstByCourseChapterIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseChapterId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseChapter_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetObjLstByCourseChapterIdLstAsync = cc_CourseChapter_GetObjLstByCourseChapterIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrCourseChapterIdLst:关键字列表
     * @returns 对象列表
    */
    async function cc_CourseChapter_GetObjLstByCourseChapterIdLst_Cache(arrCourseChapterIdLst, strCourseId) {
        const strThisFuncName = "GetObjLstByCourseChapterIdLst_Cache";
        try {
            const arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_Cache(strCourseId);
            const arrcc_CourseChapter_Sel = arrcc_CourseChapterObjLst_Cache.filter(x => arrCourseChapterIdLst.indexOf(x.courseChapterId) > -1);
            return arrcc_CourseChapter_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCourseChapterIdLst.join(","), exports.cc_CourseChapter_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.cc_CourseChapter_GetObjLstByCourseChapterIdLst_Cache = cc_CourseChapter_GetObjLstByCourseChapterIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function cc_CourseChapter_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseChapter_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetTopObjLstAsync = cc_CourseChapter_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function cc_CourseChapter_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseChapter_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetObjLstByRangeAsync = cc_CourseChapter_GetObjLstByRangeAsync;
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
    async function cc_CourseChapter_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetObjLstByRange = cc_CourseChapter_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function cc_CourseChapter_GetObjLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_Cache(strCourseId);
        if (arrcc_CourseChapterObjLst_Cache.length == 0)
            return arrcc_CourseChapterObjLst_Cache;
        let arrcc_CourseChapter_Sel = arrcc_CourseChapterObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objcc_CourseChapter_Cond = new clscc_CourseChapterEN_js_1.clscc_CourseChapterEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_CourseChapter_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clscc_CourseChapterWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseChapter_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_CourseChapter_Sel.length == 0)
                return arrcc_CourseChapter_Sel;
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
                arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.sort(cc_CourseChapter_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.sort(objPagerPara.sortFun);
            }
            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.slice(intStart, intEnd);
            return arrcc_CourseChapter_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_CourseChapter_GetObjLstByPager_Cache = cc_CourseChapter_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function cc_CourseChapter_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseChapter_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetObjLstByPagerAsync = cc_CourseChapter_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strCourseChapterId:关键字
    * @returns 获取删除的结果
    **/
    async function cc_CourseChapter_DelRecordAsync(strCourseChapterId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strCourseChapterId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_DelRecordAsync = cc_CourseChapter_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrCourseChapterId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function cc_CourseChapter_Delcc_CourseChaptersAsync(arrCourseChapterId) {
        const strThisFuncName = "Delcc_CourseChaptersAsync";
        const strAction = "Delcc_CourseChapters";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseChapterId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_Delcc_CourseChaptersAsync = cc_CourseChapter_Delcc_CourseChaptersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function cc_CourseChapter_Delcc_CourseChaptersByCondAsync(strWhereCond) {
        const strThisFuncName = "Delcc_CourseChaptersByCondAsync";
        const strAction = "Delcc_CourseChaptersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_Delcc_CourseChaptersByCondAsync = cc_CourseChapter_Delcc_CourseChaptersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objcc_CourseChapterEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_CourseChapter_AddNewRecordAsync(objcc_CourseChapterEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objcc_CourseChapterEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseChapterEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_AddNewRecordAsync = cc_CourseChapter_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objcc_CourseChapterEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_CourseChapter_AddNewRecordWithMaxIdAsync(objcc_CourseChapterEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseChapterEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_AddNewRecordWithMaxIdAsync = cc_CourseChapter_AddNewRecordWithMaxIdAsync;
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objcc_CourseChapterEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_CourseChapter_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GoTopAsync = cc_CourseChapter_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objcc_CourseChapterEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_CourseChapter_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objcc_CourseChapterEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_UpMoveAsync = cc_CourseChapter_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objcc_CourseChapterEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_CourseChapter_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objcc_CourseChapterEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_DownMoveAsync = cc_CourseChapter_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objcc_CourseChapterEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_CourseChapter_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objcc_CourseChapterEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GoBottomAsync = cc_CourseChapter_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objcc_CourseChapterEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_CourseChapter_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objcc_CourseChapterEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_ReOrderAsync = cc_CourseChapter_ReOrderAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objcc_CourseChapterEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function cc_CourseChapter_AddNewRecordWithReturnKeyAsync(objcc_CourseChapterEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseChapterEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_AddNewRecordWithReturnKeyAsync = cc_CourseChapter_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objcc_CourseChapterEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function cc_CourseChapter_AddNewRecordWithReturnKey(objcc_CourseChapterEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objcc_CourseChapterEN.courseChapterId === null || objcc_CourseChapterEN.courseChapterId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseChapterEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_AddNewRecordWithReturnKey = cc_CourseChapter_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objcc_CourseChapterEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function cc_CourseChapter_UpdateRecordAsync(objcc_CourseChapterEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objcc_CourseChapterEN.sf_UpdFldSetStr === undefined || objcc_CourseChapterEN.sf_UpdFldSetStr === null || objcc_CourseChapterEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_CourseChapterEN.courseChapterId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseChapterEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_UpdateRecordAsync = cc_CourseChapter_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objcc_CourseChapterEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function cc_CourseChapter_UpdateWithConditionAsync(objcc_CourseChapterEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objcc_CourseChapterEN.sf_UpdFldSetStr === undefined || objcc_CourseChapterEN.sf_UpdFldSetStr === null || objcc_CourseChapterEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_CourseChapterEN.courseChapterId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        objcc_CourseChapterEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseChapterEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_UpdateWithConditionAsync = cc_CourseChapter_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrCourseChapterId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function cc_CourseChapter_IsExistRecord_Cache(objcc_CourseChapter_Cond, strCourseId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_Cache(strCourseId);
        if (arrcc_CourseChapterObjLst_Cache == null)
            return false;
        let arrcc_CourseChapter_Sel = arrcc_CourseChapterObjLst_Cache;
        if (objcc_CourseChapter_Cond.sf_FldComparisonOp == null || objcc_CourseChapter_Cond.sf_FldComparisonOp == "")
            return arrcc_CourseChapter_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objcc_CourseChapter_Cond.sf_FldComparisonOp);
        //console.log("clscc_CourseChapterWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_CourseChapter_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseChapter_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_CourseChapter_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objcc_CourseChapter_Cond), exports.cc_CourseChapter_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.cc_CourseChapter_IsExistRecord_Cache = cc_CourseChapter_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function cc_CourseChapter_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_IsExistRecordAsync = cc_CourseChapter_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCourseChapterId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function cc_CourseChapter_IsExist(strCourseChapterId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CourseChapterId": strCourseChapterId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_IsExist = cc_CourseChapter_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strCourseChapterId:所给的关键字
     * @returns 对象
    */
    async function cc_CourseChapter_IsExist_Cache(strCourseChapterId, strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_Cache(strCourseId);
        if (arrcc_CourseChapterObjLst_Cache == null)
            return false;
        try {
            const arrcc_CourseChapter_Sel = arrcc_CourseChapterObjLst_Cache.filter(x => x.courseChapterId == strCourseChapterId);
            if (arrcc_CourseChapter_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCourseChapterId, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.cc_CourseChapter_IsExist_Cache = cc_CourseChapter_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCourseChapterId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function cc_CourseChapter_IsExistAsync(strCourseChapterId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strCourseChapterId": strCourseChapterId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_IsExistAsync = cc_CourseChapter_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function cc_CourseChapter_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetRecCountByCondAsync = cc_CourseChapter_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objcc_CourseChapter_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function cc_CourseChapter_GetRecCountByCond_Cache(objcc_CourseChapter_Cond, strCourseId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrcc_CourseChapterObjLst_Cache = await cc_CourseChapter_GetObjLst_Cache(strCourseId);
        if (arrcc_CourseChapterObjLst_Cache == null)
            return 0;
        let arrcc_CourseChapter_Sel = arrcc_CourseChapterObjLst_Cache;
        if (objcc_CourseChapter_Cond.sf_FldComparisonOp == null || objcc_CourseChapter_Cond.sf_FldComparisonOp == "")
            return arrcc_CourseChapter_Sel.length;
        const dicFldComparisonOp = JSON.parse(objcc_CourseChapter_Cond.sf_FldComparisonOp);
        //console.log("clscc_CourseChapterWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_CourseChapter_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseChapter_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrcc_CourseChapter_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objcc_CourseChapter_Cond), exports.cc_CourseChapter_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.cc_CourseChapter_GetRecCountByCond_Cache = cc_CourseChapter_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function cc_CourseChapter_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetMaxStrIdAsync = cc_CourseChapter_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function cc_CourseChapter_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseChapter_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseChapter_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseChapter_GetMaxStrIdByPrefix = cc_CourseChapter_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function cc_CourseChapter_GetWebApiUrl(strController, strAction) {
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
    exports.cc_CourseChapter_GetWebApiUrl = cc_CourseChapter_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function cc_CourseChapter_ReFreshCache(strCourseId) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clscc_CourseChapterWApi.clscc_CourseChapterWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clscc_CourseChapterWApi.clscc_CourseChapterWApi.ReFreshCache)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, strCourseId);
        switch (clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.CacheModeId) {
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
    exports.cc_CourseChapter_ReFreshCache = cc_CourseChapter_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function cc_CourseChapter_ReFreshThisCache(strCourseId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, strCourseId);
            switch (clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.CacheModeId) {
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
    exports.cc_CourseChapter_ReFreshThisCache = cc_CourseChapter_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
     * @param strCourseId:课程Id
    */
    async function cc_CourseChapter_BindDdl_CourseChapterIdInDiv_Cache(strDivName, strDdlName, strCourseId) {
        const strThisFuncName = "BindDdl_CourseChapterIdInDiv_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clscc_CourseChapterWApi.BindDdl_CourseChapterIdInDiv)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clscc_CourseChapterWApi.BindDdl_CourseChapterIdInDiv)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_CourseChapterIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_CourseChapterIdInDiv_Cache");
        let arrObjLst_Sel = await cc_CourseChapter_GetObjLst_Cache(strCourseId);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName, "课程章节");
    }
    exports.cc_CourseChapter_BindDdl_CourseChapterIdInDiv_Cache = cc_CourseChapter_BindDdl_CourseChapterIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function cc_CourseChapter_CheckPropertyNew(pobjcc_CourseChapterEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterName) === true) {
            throw new Error("(errid:Watl000058)字段[课程章节名称]不能为空(In 课程章节)!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseId) === true
            || pobjcc_CourseChapterEN.courseId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[课程Id]不能为空(In 课程章节)!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.parentNodeID) === true) {
            throw new Error("(errid:Watl000058)字段[父节点编号]不能为空(In 课程章节)!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null === pobjcc_CourseChapterEN.isOpenToAllStu
            || pobjcc_CourseChapterEN.isOpenToAllStu != null && pobjcc_CourseChapterEN.isOpenToAllStu.toString() === "") {
            throw new Error("(errid:Watl000058)字段[全校师生]不能为空(In 课程章节)!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null === pobjcc_CourseChapterEN.isOpenToSchool
            || pobjcc_CourseChapterEN.isOpenToSchool != null && pobjcc_CourseChapterEN.isOpenToSchool.toString() === "") {
            throw new Error("(errid:Watl000058)字段[全校师生公开]不能为空(In 课程章节)!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null === pobjcc_CourseChapterEN.isOpenToSocial
            || pobjcc_CourseChapterEN.isOpenToSocial != null && pobjcc_CourseChapterEN.isOpenToSocial.toString() === "") {
            throw new Error("(errid:Watl000058)字段[社会公众]不能为空(In 课程章节)!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null === pobjcc_CourseChapterEN.isMustMenu
            || pobjcc_CourseChapterEN.isMustMenu != null && pobjcc_CourseChapterEN.isMustMenu.toString() === "") {
            throw new Error("(errid:Watl000058)字段[是否必建栏目]不能为空(In 课程章节)!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null === pobjcc_CourseChapterEN.isFile
            || pobjcc_CourseChapterEN.isFile != null && pobjcc_CourseChapterEN.isFile.toString() === "") {
            throw new Error("(errid:Watl000058)字段[项目或文件夹]不能为空(In 课程章节)!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.courseChapterId) > 8) {
            throw new Error("(errid:Watl000059)字段[课程章节ID(courseChapterId)]的长度不能超过8(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.courseChapterId)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterName) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.courseChapterName) > 100) {
            throw new Error("(errid:Watl000059)字段[课程章节名称(courseChapterName)]的长度不能超过100(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.courseChapterName)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.chapterId) > 8) {
            throw new Error("(errid:Watl000059)字段[章Id(chapterId)]的长度不能超过8(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.chapterId)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.sectionId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.sectionId) > 8) {
            throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.sectionId)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterName) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.chapterName) > 100) {
            throw new Error("(errid:Watl000059)字段[章名(chapterName)]的长度不能超过100(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.chapterName)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.sectionName) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.sectionName) > 100) {
            throw new Error("(errid:Watl000059)字段[节名(sectionName)]的长度不能超过100(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.sectionName)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterName_Sim) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.chapterName_Sim) > 10) {
            throw new Error("(errid:Watl000059)字段[章名简称(chapterName_Sim)]的长度不能超过10(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.chapterName_Sim)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.sectionName_Sim) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.sectionName_Sim) > 10) {
            throw new Error("(errid:Watl000059)字段[节名简称(sectionName_Sim)]的长度不能超过10(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.sectionName_Sim)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.courseId) > 8) {
            throw new Error("(errid:Watl000059)字段[课程Id(courseId)]的长度不能超过8(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.courseId)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.parentNodeID) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.parentNodeID) > 8) {
            throw new Error("(errid:Watl000059)字段[父节点编号(parentNodeID)]的长度不能超过8(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.parentNodeID)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.themeName) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.themeName) > 200) {
            throw new Error("(errid:Watl000059)字段[主题名(themeName)]的长度不能超过200(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.themeName)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterReferred) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.courseChapterReferred) > 10) {
            throw new Error("(errid:Watl000059)字段[节简称(courseChapterReferred)]的长度不能超过10(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.courseChapterReferred)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.createDate) > 20) {
            throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.createDate)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.editPeople) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.editPeople) > 50) {
            throw new Error("(errid:Watl000059)字段[修改人(editPeople)]的长度不能超过50(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.editPeople)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.updDate)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.memo)(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterId) == false && undefined !== pobjcc_CourseChapterEN.courseChapterId && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.courseChapterId) === false) {
            throw new Error("(errid:Watl000060)字段[课程章节ID(courseChapterId)]的值:[$(pobjcc_CourseChapterEN.courseChapterId)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterName) == false && undefined !== pobjcc_CourseChapterEN.courseChapterName && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.courseChapterName) === false) {
            throw new Error("(errid:Watl000060)字段[课程章节名称(courseChapterName)]的值:[$(pobjcc_CourseChapterEN.courseChapterName)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterId) == false && undefined !== pobjcc_CourseChapterEN.chapterId && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.chapterId) === false) {
            throw new Error("(errid:Watl000060)字段[章Id(chapterId)]的值:[$(pobjcc_CourseChapterEN.chapterId)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.sectionId) == false && undefined !== pobjcc_CourseChapterEN.sectionId && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.sectionId) === false) {
            throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjcc_CourseChapterEN.sectionId)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterName) == false && undefined !== pobjcc_CourseChapterEN.chapterName && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.chapterName) === false) {
            throw new Error("(errid:Watl000060)字段[章名(chapterName)]的值:[$(pobjcc_CourseChapterEN.chapterName)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.sectionName) == false && undefined !== pobjcc_CourseChapterEN.sectionName && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.sectionName) === false) {
            throw new Error("(errid:Watl000060)字段[节名(sectionName)]的值:[$(pobjcc_CourseChapterEN.sectionName)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterName_Sim) == false && undefined !== pobjcc_CourseChapterEN.chapterName_Sim && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.chapterName_Sim) === false) {
            throw new Error("(errid:Watl000060)字段[章名简称(chapterName_Sim)]的值:[$(pobjcc_CourseChapterEN.chapterName_Sim)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.sectionName_Sim) == false && undefined !== pobjcc_CourseChapterEN.sectionName_Sim && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.sectionName_Sim) === false) {
            throw new Error("(errid:Watl000060)字段[节名简称(sectionName_Sim)]的值:[$(pobjcc_CourseChapterEN.sectionName_Sim)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterContent) == false && undefined !== pobjcc_CourseChapterEN.chapterContent && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.chapterContent) === false) {
            throw new Error("(errid:Watl000060)字段[章节内容(chapterContent)]的值:[$(pobjcc_CourseChapterEN.chapterContent)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseId) == false && undefined !== pobjcc_CourseChapterEN.courseId && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.courseId) === false) {
            throw new Error("(errid:Watl000060)字段[课程Id(courseId)]的值:[$(pobjcc_CourseChapterEN.courseId)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.parentNodeID) == false && undefined !== pobjcc_CourseChapterEN.parentNodeID && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.parentNodeID) === false) {
            throw new Error("(errid:Watl000060)字段[父节点编号(parentNodeID)]的值:[$(pobjcc_CourseChapterEN.parentNodeID)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseChapterEN.isOpenToAllStu && undefined !== pobjcc_CourseChapterEN.isOpenToAllStu && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseChapterEN.isOpenToAllStu) === false) {
            throw new Error("(errid:Watl000060)字段[全校师生(isOpenToAllStu)]的值:[$(pobjcc_CourseChapterEN.isOpenToAllStu)], 非法，应该为布尔型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseChapterEN.isOpenToSchool && undefined !== pobjcc_CourseChapterEN.isOpenToSchool && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseChapterEN.isOpenToSchool) === false) {
            throw new Error("(errid:Watl000060)字段[全校师生公开(isOpenToSchool)]的值:[$(pobjcc_CourseChapterEN.isOpenToSchool)], 非法，应该为布尔型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseChapterEN.isOpenToSocial && undefined !== pobjcc_CourseChapterEN.isOpenToSocial && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseChapterEN.isOpenToSocial) === false) {
            throw new Error("(errid:Watl000060)字段[社会公众(isOpenToSocial)]的值:[$(pobjcc_CourseChapterEN.isOpenToSocial)], 非法，应该为布尔型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseChapterEN.isMustMenu && undefined !== pobjcc_CourseChapterEN.isMustMenu && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseChapterEN.isMustMenu) === false) {
            throw new Error("(errid:Watl000060)字段[是否必建栏目(isMustMenu)]的值:[$(pobjcc_CourseChapterEN.isMustMenu)], 非法，应该为布尔型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.themeName) == false && undefined !== pobjcc_CourseChapterEN.themeName && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.themeName) === false) {
            throw new Error("(errid:Watl000060)字段[主题名(themeName)]的值:[$(pobjcc_CourseChapterEN.themeName)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseChapterEN.isFile && undefined !== pobjcc_CourseChapterEN.isFile && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseChapterEN.isFile) === false) {
            throw new Error("(errid:Watl000060)字段[项目或文件夹(isFile)]的值:[$(pobjcc_CourseChapterEN.isFile)], 非法，应该为布尔型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseChapterEN.isUse && undefined !== pobjcc_CourseChapterEN.isUse && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseChapterEN.isUse) === false) {
            throw new Error("(errid:Watl000060)字段[是否使用(isUse)]的值:[$(pobjcc_CourseChapterEN.isUse)], 非法，应该为布尔型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseChapterEN.viewCount && undefined !== pobjcc_CourseChapterEN.viewCount && clsString_js_1.tzDataType.isNumber(pobjcc_CourseChapterEN.viewCount) === false) {
            throw new Error("(errid:Watl000060)字段[浏览量(viewCount)]的值:[$(pobjcc_CourseChapterEN.viewCount)], 非法，应该为数值型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterReferred) == false && undefined !== pobjcc_CourseChapterEN.courseChapterReferred && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.courseChapterReferred) === false) {
            throw new Error("(errid:Watl000060)字段[节简称(courseChapterReferred)]的值:[$(pobjcc_CourseChapterEN.courseChapterReferred)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseChapterEN.orderNum && undefined !== pobjcc_CourseChapterEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjcc_CourseChapterEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjcc_CourseChapterEN.orderNum)], 非法，应该为数值型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.createDate) == false && undefined !== pobjcc_CourseChapterEN.createDate && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.createDate) === false) {
            throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjcc_CourseChapterEN.createDate)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.editPeople) == false && undefined !== pobjcc_CourseChapterEN.editPeople && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.editPeople) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(editPeople)]的值:[$(pobjcc_CourseChapterEN.editPeople)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.updDate) == false && undefined !== pobjcc_CourseChapterEN.updDate && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjcc_CourseChapterEN.updDate)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.memo) == false && undefined !== pobjcc_CourseChapterEN.memo && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjcc_CourseChapterEN.memo)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjcc_CourseChapterEN.SetIsCheckProperty(true);
    }
    exports.cc_CourseChapter_CheckPropertyNew = cc_CourseChapter_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function cc_CourseChapter_CheckProperty4Update(pobjcc_CourseChapterEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.courseChapterId) > 8) {
            throw new Error("(errid:Watl000062)字段[课程章节ID(courseChapterId)]的长度不能超过8(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.courseChapterId)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterName) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.courseChapterName) > 100) {
            throw new Error("(errid:Watl000062)字段[课程章节名称(courseChapterName)]的长度不能超过100(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.courseChapterName)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.chapterId) > 8) {
            throw new Error("(errid:Watl000062)字段[章Id(chapterId)]的长度不能超过8(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.chapterId)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.sectionId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.sectionId) > 8) {
            throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.sectionId)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterName) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.chapterName) > 100) {
            throw new Error("(errid:Watl000062)字段[章名(chapterName)]的长度不能超过100(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.chapterName)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.sectionName) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.sectionName) > 100) {
            throw new Error("(errid:Watl000062)字段[节名(sectionName)]的长度不能超过100(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.sectionName)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterName_Sim) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.chapterName_Sim) > 10) {
            throw new Error("(errid:Watl000062)字段[章名简称(chapterName_Sim)]的长度不能超过10(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.chapterName_Sim)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.sectionName_Sim) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.sectionName_Sim) > 10) {
            throw new Error("(errid:Watl000062)字段[节名简称(sectionName_Sim)]的长度不能超过10(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.sectionName_Sim)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.courseId) > 8) {
            throw new Error("(errid:Watl000062)字段[课程Id(courseId)]的长度不能超过8(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.courseId)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.parentNodeID) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.parentNodeID) > 8) {
            throw new Error("(errid:Watl000062)字段[父节点编号(parentNodeID)]的长度不能超过8(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.parentNodeID)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.themeName) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.themeName) > 200) {
            throw new Error("(errid:Watl000062)字段[主题名(themeName)]的长度不能超过200(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.themeName)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterReferred) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.courseChapterReferred) > 10) {
            throw new Error("(errid:Watl000062)字段[节简称(courseChapterReferred)]的长度不能超过10(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.courseChapterReferred)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.createDate) > 20) {
            throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.createDate)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.editPeople) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.editPeople) > 50) {
            throw new Error("(errid:Watl000062)字段[修改人(editPeople)]的长度不能超过50(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.editPeople)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.updDate)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseChapterEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 课程章节(cc_CourseChapter))!值:$(pobjcc_CourseChapterEN.memo)(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterId) == false && undefined !== pobjcc_CourseChapterEN.courseChapterId && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.courseChapterId) === false) {
            throw new Error("(errid:Watl000063)字段[课程章节ID(courseChapterId)]的值:[$(pobjcc_CourseChapterEN.courseChapterId)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterName) == false && undefined !== pobjcc_CourseChapterEN.courseChapterName && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.courseChapterName) === false) {
            throw new Error("(errid:Watl000063)字段[课程章节名称(courseChapterName)]的值:[$(pobjcc_CourseChapterEN.courseChapterName)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterId) == false && undefined !== pobjcc_CourseChapterEN.chapterId && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.chapterId) === false) {
            throw new Error("(errid:Watl000063)字段[章Id(chapterId)]的值:[$(pobjcc_CourseChapterEN.chapterId)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.sectionId) == false && undefined !== pobjcc_CourseChapterEN.sectionId && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.sectionId) === false) {
            throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjcc_CourseChapterEN.sectionId)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterName) == false && undefined !== pobjcc_CourseChapterEN.chapterName && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.chapterName) === false) {
            throw new Error("(errid:Watl000063)字段[章名(chapterName)]的值:[$(pobjcc_CourseChapterEN.chapterName)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.sectionName) == false && undefined !== pobjcc_CourseChapterEN.sectionName && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.sectionName) === false) {
            throw new Error("(errid:Watl000063)字段[节名(sectionName)]的值:[$(pobjcc_CourseChapterEN.sectionName)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterName_Sim) == false && undefined !== pobjcc_CourseChapterEN.chapterName_Sim && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.chapterName_Sim) === false) {
            throw new Error("(errid:Watl000063)字段[章名简称(chapterName_Sim)]的值:[$(pobjcc_CourseChapterEN.chapterName_Sim)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.sectionName_Sim) == false && undefined !== pobjcc_CourseChapterEN.sectionName_Sim && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.sectionName_Sim) === false) {
            throw new Error("(errid:Watl000063)字段[节名简称(sectionName_Sim)]的值:[$(pobjcc_CourseChapterEN.sectionName_Sim)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.chapterContent) == false && undefined !== pobjcc_CourseChapterEN.chapterContent && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.chapterContent) === false) {
            throw new Error("(errid:Watl000063)字段[章节内容(chapterContent)]的值:[$(pobjcc_CourseChapterEN.chapterContent)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseId) == false && undefined !== pobjcc_CourseChapterEN.courseId && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.courseId) === false) {
            throw new Error("(errid:Watl000063)字段[课程Id(courseId)]的值:[$(pobjcc_CourseChapterEN.courseId)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.parentNodeID) == false && undefined !== pobjcc_CourseChapterEN.parentNodeID && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.parentNodeID) === false) {
            throw new Error("(errid:Watl000063)字段[父节点编号(parentNodeID)]的值:[$(pobjcc_CourseChapterEN.parentNodeID)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseChapterEN.isOpenToAllStu && undefined !== pobjcc_CourseChapterEN.isOpenToAllStu && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseChapterEN.isOpenToAllStu) === false) {
            throw new Error("(errid:Watl000063)字段[全校师生(isOpenToAllStu)]的值:[$(pobjcc_CourseChapterEN.isOpenToAllStu)], 非法，应该为布尔型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseChapterEN.isOpenToSchool && undefined !== pobjcc_CourseChapterEN.isOpenToSchool && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseChapterEN.isOpenToSchool) === false) {
            throw new Error("(errid:Watl000063)字段[全校师生公开(isOpenToSchool)]的值:[$(pobjcc_CourseChapterEN.isOpenToSchool)], 非法，应该为布尔型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseChapterEN.isOpenToSocial && undefined !== pobjcc_CourseChapterEN.isOpenToSocial && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseChapterEN.isOpenToSocial) === false) {
            throw new Error("(errid:Watl000063)字段[社会公众(isOpenToSocial)]的值:[$(pobjcc_CourseChapterEN.isOpenToSocial)], 非法，应该为布尔型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseChapterEN.isMustMenu && undefined !== pobjcc_CourseChapterEN.isMustMenu && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseChapterEN.isMustMenu) === false) {
            throw new Error("(errid:Watl000063)字段[是否必建栏目(isMustMenu)]的值:[$(pobjcc_CourseChapterEN.isMustMenu)], 非法，应该为布尔型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.themeName) == false && undefined !== pobjcc_CourseChapterEN.themeName && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.themeName) === false) {
            throw new Error("(errid:Watl000063)字段[主题名(themeName)]的值:[$(pobjcc_CourseChapterEN.themeName)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseChapterEN.isFile && undefined !== pobjcc_CourseChapterEN.isFile && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseChapterEN.isFile) === false) {
            throw new Error("(errid:Watl000063)字段[项目或文件夹(isFile)]的值:[$(pobjcc_CourseChapterEN.isFile)], 非法，应该为布尔型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseChapterEN.isUse && undefined !== pobjcc_CourseChapterEN.isUse && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseChapterEN.isUse) === false) {
            throw new Error("(errid:Watl000063)字段[是否使用(isUse)]的值:[$(pobjcc_CourseChapterEN.isUse)], 非法，应该为布尔型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseChapterEN.viewCount && undefined !== pobjcc_CourseChapterEN.viewCount && clsString_js_1.tzDataType.isNumber(pobjcc_CourseChapterEN.viewCount) === false) {
            throw new Error("(errid:Watl000063)字段[浏览量(viewCount)]的值:[$(pobjcc_CourseChapterEN.viewCount)], 非法，应该为数值型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterReferred) == false && undefined !== pobjcc_CourseChapterEN.courseChapterReferred && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.courseChapterReferred) === false) {
            throw new Error("(errid:Watl000063)字段[节简称(courseChapterReferred)]的值:[$(pobjcc_CourseChapterEN.courseChapterReferred)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseChapterEN.orderNum && undefined !== pobjcc_CourseChapterEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjcc_CourseChapterEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjcc_CourseChapterEN.orderNum)], 非法，应该为数值型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.createDate) == false && undefined !== pobjcc_CourseChapterEN.createDate && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.createDate) === false) {
            throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjcc_CourseChapterEN.createDate)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.editPeople) == false && undefined !== pobjcc_CourseChapterEN.editPeople && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.editPeople) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(editPeople)]的值:[$(pobjcc_CourseChapterEN.editPeople)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.updDate) == false && undefined !== pobjcc_CourseChapterEN.updDate && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjcc_CourseChapterEN.updDate)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.memo) == false && undefined !== pobjcc_CourseChapterEN.memo && clsString_js_1.tzDataType.isString(pobjcc_CourseChapterEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjcc_CourseChapterEN.memo)], 非法，应该为字符型(In 课程章节(cc_CourseChapter))!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseChapterEN.courseChapterId) === true
            || pobjcc_CourseChapterEN.courseChapterId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[课程章节ID]不能为空(In 课程章节)!(clscc_CourseChapterBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjcc_CourseChapterEN.SetIsCheckProperty(true);
    }
    exports.cc_CourseChapter_CheckProperty4Update = cc_CourseChapter_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function cc_CourseChapter_GetJSONStrByObj(pobjcc_CourseChapterEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjcc_CourseChapterEN.sf_UpdFldSetStr = pobjcc_CourseChapterEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjcc_CourseChapterEN);
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
    exports.cc_CourseChapter_GetJSONStrByObj = cc_CourseChapter_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function cc_CourseChapter_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrcc_CourseChapterObjLst = new Array();
        if (strJSON === "") {
            return arrcc_CourseChapterObjLst;
        }
        try {
            arrcc_CourseChapterObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrcc_CourseChapterObjLst;
        }
        return arrcc_CourseChapterObjLst;
    }
    exports.cc_CourseChapter_GetObjLstByJSONStr = cc_CourseChapter_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrcc_CourseChapterObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function cc_CourseChapter_GetObjLstByJSONObjLst(arrcc_CourseChapterObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrcc_CourseChapterObjLst = new Array();
        for (const objInFor of arrcc_CourseChapterObjLstS) {
            const obj1 = cc_CourseChapter_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrcc_CourseChapterObjLst.push(obj1);
        }
        return arrcc_CourseChapterObjLst;
    }
    exports.cc_CourseChapter_GetObjLstByJSONObjLst = cc_CourseChapter_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function cc_CourseChapter_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjcc_CourseChapterEN = new clscc_CourseChapterEN_js_1.clscc_CourseChapterEN();
        if (strJSON === "") {
            return pobjcc_CourseChapterEN;
        }
        try {
            pobjcc_CourseChapterEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjcc_CourseChapterEN;
        }
        return pobjcc_CourseChapterEN;
    }
    exports.cc_CourseChapter_GetObjByJSONStr = cc_CourseChapter_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function cc_CourseChapter_GetCombineCondition(objcc_CourseChapter_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId) == true) {
            const strComparisonOp_CourseChapterId = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId, objcc_CourseChapter_Cond.courseChapterId, strComparisonOp_CourseChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName) == true) {
            const strComparisonOp_CourseChapterName = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName, objcc_CourseChapter_Cond.courseChapterName, strComparisonOp_CourseChapterName);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterId) == true) {
            const strComparisonOp_ChapterId = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterId, objcc_CourseChapter_Cond.chapterId, strComparisonOp_ChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionId, objcc_CourseChapter_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName) == true) {
            const strComparisonOp_ChapterName = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName, objcc_CourseChapter_Cond.chapterName, strComparisonOp_ChapterName);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName) == true) {
            const strComparisonOp_SectionName = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName, objcc_CourseChapter_Cond.sectionName, strComparisonOp_SectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName_Sim) == true) {
            const strComparisonOp_ChapterName_Sim = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName_Sim];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName_Sim, objcc_CourseChapter_Cond.chapterName_Sim, strComparisonOp_ChapterName_Sim);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName_Sim) == true) {
            const strComparisonOp_SectionName_Sim = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName_Sim];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName_Sim, objcc_CourseChapter_Cond.sectionName_Sim, strComparisonOp_SectionName_Sim);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseId, objcc_CourseChapter_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ParentNodeID) == true) {
            const strComparisonOp_ParentNodeID = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ParentNodeID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ParentNodeID, objcc_CourseChapter_Cond.parentNodeID, strComparisonOp_ParentNodeID);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToAllStu) == true) {
            if (objcc_CourseChapter_Cond.isOpenToAllStu == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToAllStu);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToAllStu);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToSchool) == true) {
            if (objcc_CourseChapter_Cond.isOpenToSchool == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToSchool);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToSchool);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToSocial) == true) {
            if (objcc_CourseChapter_Cond.isOpenToSocial == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToSocial);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsOpenToSocial);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsMustMenu) == true) {
            if (objcc_CourseChapter_Cond.isMustMenu == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsMustMenu);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsMustMenu);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ThemeName) == true) {
            const strComparisonOp_ThemeName = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ThemeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ThemeName, objcc_CourseChapter_Cond.themeName, strComparisonOp_ThemeName);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsFile) == true) {
            if (objcc_CourseChapter_Cond.isFile == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsFile);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsFile);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsUse) == true) {
            if (objcc_CourseChapter_Cond.isUse == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsUse);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_IsUse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ViewCount) == true) {
            const strComparisonOp_ViewCount = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ViewCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ViewCount, objcc_CourseChapter_Cond.viewCount, strComparisonOp_ViewCount);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterReferred) == true) {
            const strComparisonOp_CourseChapterReferred = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterReferred];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterReferred, objcc_CourseChapter_Cond.courseChapterReferred, strComparisonOp_CourseChapterReferred);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_OrderNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_OrderNum, objcc_CourseChapter_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CreateDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CreateDate, objcc_CourseChapter_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_EditPeople) == true) {
            const strComparisonOp_EditPeople = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_EditPeople];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_EditPeople, objcc_CourseChapter_Cond.editPeople, strComparisonOp_EditPeople);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_UpdDate, objcc_CourseChapter_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseChapter_Cond.dicFldComparisonOp, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_Memo) == true) {
            const strComparisonOp_Memo = objcc_CourseChapter_Cond.dicFldComparisonOp[clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_Memo, objcc_CourseChapter_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.cc_CourseChapter_GetCombineCondition = cc_CourseChapter_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--cc_CourseChapter(课程章节),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strCourseId: 课程Id(要求唯一的字段)
    * @param strCourseChapterName: 课程章节名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function cc_CourseChapter_GetUniCondStr_CourseId_CourseChapterName(objcc_CourseChapterEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and CourseId = '{0}'", objcc_CourseChapterEN.courseId);
        strWhereCond += (0, clsString_js_2.Format)(" and CourseChapterName = '{0}'", objcc_CourseChapterEN.courseChapterName);
        return strWhereCond;
    }
    exports.cc_CourseChapter_GetUniCondStr_CourseId_CourseChapterName = cc_CourseChapter_GetUniCondStr_CourseId_CourseChapterName;
    /**
    *获取唯一性条件串(Uniqueness)--cc_CourseChapter(课程章节),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strCourseId: 课程Id(要求唯一的字段)
    * @param strCourseChapterName: 课程章节名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function cc_CourseChapter_GetUniCondStr4Update_CourseId_CourseChapterName(objcc_CourseChapterEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and CourseChapterId <> '{0}'", objcc_CourseChapterEN.courseChapterId);
        strWhereCond += (0, clsString_js_2.Format)(" and CourseId = '{0}'", objcc_CourseChapterEN.courseId);
        strWhereCond += (0, clsString_js_2.Format)(" and CourseChapterName = '{0}'", objcc_CourseChapterEN.courseChapterName);
        return strWhereCond;
    }
    exports.cc_CourseChapter_GetUniCondStr4Update_CourseId_CourseChapterName = cc_CourseChapter_GetUniCondStr4Update_CourseId_CourseChapterName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objcc_CourseChapterENS:源对象
     * @param objcc_CourseChapterENT:目标对象
    */
    function cc_CourseChapter_CopyObjTo(objcc_CourseChapterENS, objcc_CourseChapterENT) {
        objcc_CourseChapterENT.courseChapterId = objcc_CourseChapterENS.courseChapterId; //课程章节ID
        objcc_CourseChapterENT.courseChapterName = objcc_CourseChapterENS.courseChapterName; //课程章节名称
        objcc_CourseChapterENT.chapterId = objcc_CourseChapterENS.chapterId; //章Id
        objcc_CourseChapterENT.sectionId = objcc_CourseChapterENS.sectionId; //节Id
        objcc_CourseChapterENT.chapterName = objcc_CourseChapterENS.chapterName; //章名
        objcc_CourseChapterENT.sectionName = objcc_CourseChapterENS.sectionName; //节名
        objcc_CourseChapterENT.chapterName_Sim = objcc_CourseChapterENS.chapterName_Sim; //章名简称
        objcc_CourseChapterENT.sectionName_Sim = objcc_CourseChapterENS.sectionName_Sim; //节名简称
        objcc_CourseChapterENT.chapterContent = objcc_CourseChapterENS.chapterContent; //章节内容
        objcc_CourseChapterENT.courseId = objcc_CourseChapterENS.courseId; //课程Id
        objcc_CourseChapterENT.parentNodeID = objcc_CourseChapterENS.parentNodeID; //父节点编号
        objcc_CourseChapterENT.isOpenToAllStu = objcc_CourseChapterENS.isOpenToAllStu; //全校师生
        objcc_CourseChapterENT.isOpenToSchool = objcc_CourseChapterENS.isOpenToSchool; //全校师生公开
        objcc_CourseChapterENT.isOpenToSocial = objcc_CourseChapterENS.isOpenToSocial; //社会公众
        objcc_CourseChapterENT.isMustMenu = objcc_CourseChapterENS.isMustMenu; //是否必建栏目
        objcc_CourseChapterENT.themeName = objcc_CourseChapterENS.themeName; //主题名
        objcc_CourseChapterENT.isFile = objcc_CourseChapterENS.isFile; //项目或文件夹
        objcc_CourseChapterENT.isUse = objcc_CourseChapterENS.isUse; //是否使用
        objcc_CourseChapterENT.viewCount = objcc_CourseChapterENS.viewCount; //浏览量
        objcc_CourseChapterENT.courseChapterReferred = objcc_CourseChapterENS.courseChapterReferred; //节简称
        objcc_CourseChapterENT.orderNum = objcc_CourseChapterENS.orderNum; //序号
        objcc_CourseChapterENT.createDate = objcc_CourseChapterENS.createDate; //建立日期
        objcc_CourseChapterENT.editPeople = objcc_CourseChapterENS.editPeople; //修改人
        objcc_CourseChapterENT.updDate = objcc_CourseChapterENS.updDate; //修改日期
        objcc_CourseChapterENT.memo = objcc_CourseChapterENS.memo; //备注
        objcc_CourseChapterENT.sf_UpdFldSetStr = objcc_CourseChapterENS.updFldString; //sf_UpdFldSetStr
    }
    exports.cc_CourseChapter_CopyObjTo = cc_CourseChapter_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objcc_CourseChapterENS:源对象
     * @param objcc_CourseChapterENT:目标对象
    */
    function cc_CourseChapter_GetObjFromJsonObj(objcc_CourseChapterENS) {
        const objcc_CourseChapterENT = new clscc_CourseChapterEN_js_1.clscc_CourseChapterEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_CourseChapterENT, objcc_CourseChapterENS);
        return objcc_CourseChapterENT;
    }
    exports.cc_CourseChapter_GetObjFromJsonObj = cc_CourseChapter_GetObjFromJsonObj;
});
