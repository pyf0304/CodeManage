/**
* 类名:clscc_CourseWApi
* 表名:cc_Course(01120056)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:13:19
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:课程学习(CourseLearning)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/CourseLearning_Share/clscc_CourseEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_Course_GetObjFromJsonObj = exports.cc_Course_CopyObjTo = exports.cc_Course_GetUniCondStr4Update_CourseId = exports.cc_Course_GetUniCondStr_CourseId = exports.cc_Course_GetCombineCondition = exports.cc_Course_GetObjByJSONStr = exports.cc_Course_GetObjLstByJSONObjLst = exports.cc_Course_GetObjLstByJSONStr = exports.cc_Course_GetJSONStrByObj = exports.cc_Course_CheckProperty4Update = exports.cc_Course_CheckPropertyNew = exports.cc_Course_BindDdl_CourseIdInDiv_Cache = exports.cc_Course_ReFreshThisCache = exports.cc_Course_ReFreshCache = exports.cc_Course_GetWebApiUrl = exports.cc_Course_GetMaxStrIdByPrefix = exports.cc_Course_GetMaxStrIdAsync = exports.cc_Course_GetRecCountByCond_Cache = exports.cc_Course_GetRecCountByCondAsync = exports.cc_Course_IsExistAsync = exports.cc_Course_IsExist_Cache = exports.cc_Course_IsExist = exports.cc_Course_IsExistRecordAsync = exports.cc_Course_IsExistRecord_Cache = exports.cc_Course_UpdateWithConditionAsync = exports.cc_Course_UpdateRecordAsync = exports.cc_Course_AddNewRecordWithReturnKey = exports.cc_Course_AddNewRecordWithReturnKeyAsync = exports.cc_Course_AddNewRecordWithMaxIdAsync = exports.cc_Course_AddNewRecordAsync = exports.cc_Course_Delcc_CoursesByCondAsync = exports.cc_Course_Delcc_CoursesAsync = exports.cc_Course_DelRecordAsync = exports.cc_Course_GetObjLstByPagerAsync = exports.cc_Course_GetObjLstByPager_Cache = exports.cc_Course_GetObjLstByRange = exports.cc_Course_GetObjLstByRangeAsync = exports.cc_Course_GetTopObjLstAsync = exports.cc_Course_GetObjLstByCourseIdLst_Cache = exports.cc_Course_GetObjLstByCourseIdLstAsync = exports.cc_Course_GetSubObjLst_Cache = exports.cc_Course_GetObjLst_PureCache = exports.cc_Course_GetObjLst_Cache = exports.cc_Course_GetObjLst_sessionStorage_PureCache = exports.cc_Course_GetObjLst_sessionStorage = exports.cc_Course_GetObjLstAsync = exports.cc_Course_GetObjLst_localStorage_PureCache = exports.cc_Course_GetObjLst_localStorage = exports.cc_Course_GetObjLst_ClientCache = exports.cc_Course_GetFirstObjAsync = exports.cc_Course_GetFirstID = exports.cc_Course_GetFirstIDAsync = exports.cc_Course_funcKey = exports.cc_Course_FilterFunByKey = exports.cc_Course_SortFunByKey = exports.cc_Course_SortFun_Defa_2Fld = exports.cc_Course_SortFun_Defa = exports.cc_Course_func = exports.cc_Course_GetNameByCourseId_Cache = exports.cc_Course_UpdateObjInLst_Cache = exports.cc_Course_GetObjByCourseId_localStorage = exports.cc_Course_GetObjByCourseId_Cache = exports.cc_Course_GetObjByCourseIdAsync = exports.cc_Course_ConstructorName = exports.cc_Course_Controller = void 0;
    /**
     * 课程(cc_Course)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clscc_CourseEN_js_1 = require("../../L0_Entity/CourseLearning_Share/clscc_CourseEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.cc_Course_Controller = "cc_CourseApi";
    exports.cc_Course_ConstructorName = "cc_Course";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCourseId:关键字
    * @returns 对象
    **/
    async function cc_Course_GetObjByCourseIdAsync(strCourseId) {
        const strThisFuncName = "GetObjByCourseIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clscc_CourseWApi.GetObjByCourseIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clscc_CourseWApi.GetObjByCourseIdAsync)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCourseId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCourseId": strCourseId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objcc_Course = cc_Course_GetObjFromJsonObj(returnObj);
                return objcc_Course;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetObjByCourseIdAsync = cc_Course_GetObjByCourseIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strCourseId:所给的关键字
     * @returns 对象
    */
    async function cc_Course_GetObjByCourseId_Cache(strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByCourseId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clscc_CourseWApi.GetObjByCourseId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clscc_CourseWApi.GetObjByCourseId_Cache)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
        try {
            const arrcc_Course_Sel = arrcc_CourseObjLst_Cache.filter(x => x.courseId == strCourseId);
            let objcc_Course;
            if (arrcc_Course_Sel.length > 0) {
                objcc_Course = arrcc_Course_Sel[0];
                return objcc_Course;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objcc_Course_Const = await cc_Course_GetObjByCourseIdAsync(strCourseId);
                    if (objcc_Course_Const != null) {
                        cc_Course_ReFreshThisCache();
                        return objcc_Course_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseId, exports.cc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.cc_Course_GetObjByCourseId_Cache = cc_Course_GetObjByCourseId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strCourseId:所给的关键字
     * @returns 对象
    */
    async function cc_Course_GetObjByCourseId_localStorage(strCourseId) {
        const strThisFuncName = "GetObjByCourseId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clscc_CourseWApi.GetObjByCourseId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clscc_CourseWApi.GetObjByCourseId_localStorage)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clscc_CourseEN_js_1.clscc_CourseEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objcc_Course_Cache = JSON.parse(strTempObj);
            return objcc_Course_Cache;
        }
        try {
            const objcc_Course = await cc_Course_GetObjByCourseIdAsync(strCourseId);
            if (objcc_Course != null) {
                localStorage.setItem(strKey, JSON.stringify(objcc_Course));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objcc_Course;
            }
            return objcc_Course;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseId, exports.cc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.cc_Course_GetObjByCourseId_localStorage = cc_Course_GetObjByCourseId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objcc_Course:所给的对象
     * @returns 对象
    */
    async function cc_Course_UpdateObjInLst_Cache(objcc_Course) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
            const obj = arrcc_CourseObjLst_Cache.find(x => x.courseId == objcc_Course.courseId);
            if (obj != null) {
                objcc_Course.courseId = obj.courseId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objcc_Course);
            }
            else {
                arrcc_CourseObjLst_Cache.push(objcc_Course);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.cc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_Course_UpdateObjInLst_Cache = cc_Course_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strCourseId:所给的关键字
     * @returns 对象
    */
    async function cc_Course_GetNameByCourseId_Cache(strCourseId) {
        const strThisFuncName = "GetNameByCourseId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clscc_CourseWApi.GetNameByCourseId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clscc_CourseWApi.GetNameByCourseId_Cache)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
        if (arrcc_CourseObjLst_Cache == null)
            return "";
        try {
            const arrcc_Course_Sel = arrcc_CourseObjLst_Cache.filter(x => x.courseId == strCourseId);
            let objcc_Course;
            if (arrcc_Course_Sel.length > 0) {
                objcc_Course = arrcc_Course_Sel[0];
                return objcc_Course.courseName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strCourseId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.cc_Course_GetNameByCourseId_Cache = cc_Course_GetNameByCourseId_Cache;
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
    async function cc_Course_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clscc_CourseEN_js_1.clscc_CourseEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clscc_CourseEN_js_1.clscc_CourseEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strCourseId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objcc_Course = await cc_Course_GetObjByCourseId_Cache(strCourseId);
        if (objcc_Course == null)
            return "";
        if (objcc_Course.GetFldValue(strOutFldName) == null)
            return "";
        return objcc_Course.GetFldValue(strOutFldName).toString();
    }
    exports.cc_Course_func = cc_Course_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_Course_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.courseId.localeCompare(b.courseId);
    }
    exports.cc_Course_SortFun_Defa = cc_Course_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_Course_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.courseCode == b.courseCode)
            return a.courseDescription.localeCompare(b.courseDescription);
        else
            return a.courseCode.localeCompare(b.courseCode);
    }
    exports.cc_Course_SortFun_Defa_2Fld = cc_Course_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_Course_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId:
                    return (a, b) => {
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseCode:
                    return (a, b) => {
                        if (a.courseCode == null)
                            return -1;
                        if (b.courseCode == null)
                            return 1;
                        return a.courseCode.localeCompare(b.courseCode);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseDescription:
                    return (a, b) => {
                        if (a.courseDescription == null)
                            return -1;
                        if (b.courseDescription == null)
                            return 1;
                        return a.courseDescription.localeCompare(b.courseDescription);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseName:
                    return (a, b) => {
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseTypeID:
                    return (a, b) => {
                        if (a.courseTypeID == null)
                            return -1;
                        if (b.courseTypeID == null)
                            return 1;
                        return a.courseTypeID.localeCompare(b.courseTypeID);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_ExcellentTypeId:
                    return (a, b) => {
                        if (a.excellentTypeId == null)
                            return -1;
                        if (b.excellentTypeId == null)
                            return 1;
                        return a.excellentTypeId.localeCompare(b.excellentTypeId);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_ExcellentYear:
                    return (a, b) => {
                        return a.excellentYear - b.excellentYear;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_IsBuildingCourse:
                    return (a, b) => {
                        if (a.isBuildingCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_IsDoubleLanguageCourse:
                    return (a, b) => {
                        if (a.isDoubleLanguageCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_IsOpen:
                    return (a, b) => {
                        if (a.isOpen == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_IsRecommendedCourse:
                    return (a, b) => {
                        if (a.isRecommendedCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_IsSelfPropelledCourse:
                    return (a, b) => {
                        if (a.isSelfPropelledCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_OperationDate:
                    return (a, b) => {
                        if (a.operationDate == null)
                            return -1;
                        if (b.operationDate == null)
                            return 1;
                        return a.operationDate.localeCompare(b.operationDate);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_OuterLink:
                    return (a, b) => {
                        if (a.outerLink == null)
                            return -1;
                        if (b.outerLink == null)
                            return 1;
                        return a.outerLink.localeCompare(b.outerLink);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_ViewCount:
                    return (a, b) => {
                        return a.viewCount - b.viewCount;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_ThemeId:
                    return (a, b) => {
                        if (a.themeId == null)
                            return -1;
                        if (b.themeId == null)
                            return 1;
                        return a.themeId.localeCompare(b.themeId);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_id_School:
                    return (a, b) => {
                        if (a.id_School == null)
                            return -1;
                        if (b.id_School == null)
                            return 1;
                        return a.id_School.localeCompare(b.id_School);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_UpdUserId:
                    return (a, b) => {
                        if (a.updUserId == null)
                            return -1;
                        if (b.updUserId == null)
                            return 1;
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[cc_Course]中不存在！(in ${exports.cc_Course_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId:
                    return (a, b) => {
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseCode:
                    return (a, b) => {
                        if (b.courseCode == null)
                            return -1;
                        if (a.courseCode == null)
                            return 1;
                        return b.courseCode.localeCompare(a.courseCode);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseDescription:
                    return (a, b) => {
                        if (b.courseDescription == null)
                            return -1;
                        if (a.courseDescription == null)
                            return 1;
                        return b.courseDescription.localeCompare(a.courseDescription);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseName:
                    return (a, b) => {
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseTypeID:
                    return (a, b) => {
                        if (b.courseTypeID == null)
                            return -1;
                        if (a.courseTypeID == null)
                            return 1;
                        return b.courseTypeID.localeCompare(a.courseTypeID);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_ExcellentTypeId:
                    return (a, b) => {
                        if (b.excellentTypeId == null)
                            return -1;
                        if (a.excellentTypeId == null)
                            return 1;
                        return b.excellentTypeId.localeCompare(a.excellentTypeId);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_ExcellentYear:
                    return (a, b) => {
                        return b.excellentYear - a.excellentYear;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_IsBuildingCourse:
                    return (a, b) => {
                        if (b.isBuildingCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_IsDoubleLanguageCourse:
                    return (a, b) => {
                        if (b.isDoubleLanguageCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_IsOpen:
                    return (a, b) => {
                        if (b.isOpen == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_IsRecommendedCourse:
                    return (a, b) => {
                        if (b.isRecommendedCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_IsSelfPropelledCourse:
                    return (a, b) => {
                        if (b.isSelfPropelledCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_OperationDate:
                    return (a, b) => {
                        if (b.operationDate == null)
                            return -1;
                        if (a.operationDate == null)
                            return 1;
                        return b.operationDate.localeCompare(a.operationDate);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_OuterLink:
                    return (a, b) => {
                        if (b.outerLink == null)
                            return -1;
                        if (a.outerLink == null)
                            return 1;
                        return b.outerLink.localeCompare(a.outerLink);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_ViewCount:
                    return (a, b) => {
                        return b.viewCount - a.viewCount;
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_ThemeId:
                    return (a, b) => {
                        if (b.themeId == null)
                            return -1;
                        if (a.themeId == null)
                            return 1;
                        return b.themeId.localeCompare(a.themeId);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_id_School:
                    return (a, b) => {
                        if (b.id_School == null)
                            return -1;
                        if (a.id_School == null)
                            return 1;
                        return b.id_School.localeCompare(a.id_School);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_UpdUserId:
                    return (a, b) => {
                        if (b.updUserId == null)
                            return -1;
                        if (a.updUserId == null)
                            return 1;
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clscc_CourseEN_js_1.clscc_CourseEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[cc_Course]中不存在！(in ${exports.cc_Course_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.cc_Course_SortFunByKey = cc_Course_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function cc_Course_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseCode:
                return (obj) => {
                    return obj.courseCode === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseDescription:
                return (obj) => {
                    return obj.courseDescription === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_CourseTypeID:
                return (obj) => {
                    return obj.courseTypeID === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_ExcellentTypeId:
                return (obj) => {
                    return obj.excellentTypeId === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_ExcellentYear:
                return (obj) => {
                    return obj.excellentYear === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_IsBuildingCourse:
                return (obj) => {
                    return obj.isBuildingCourse === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_IsDoubleLanguageCourse:
                return (obj) => {
                    return obj.isDoubleLanguageCourse === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_IsOpen:
                return (obj) => {
                    return obj.isOpen === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_IsRecommendedCourse:
                return (obj) => {
                    return obj.isRecommendedCourse === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_IsSelfPropelledCourse:
                return (obj) => {
                    return obj.isSelfPropelledCourse === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_OperationDate:
                return (obj) => {
                    return obj.operationDate === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_OuterLink:
                return (obj) => {
                    return obj.outerLink === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_ViewCount:
                return (obj) => {
                    return obj.viewCount === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_ThemeId:
                return (obj) => {
                    return obj.themeId === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_id_School:
                return (obj) => {
                    return obj.id_School === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clscc_CourseEN_js_1.clscc_CourseEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[cc_Course]中不存在！(in ${exports.cc_Course_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.cc_Course_FilterFunByKey = cc_Course_FilterFunByKey;
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
    async function cc_Course_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrcc_Course = await cc_Course_GetObjLst_Cache();
        if (arrcc_Course == null)
            return [];
        let arrcc_Course_Sel = arrcc_Course;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrcc_Course_Sel = arrcc_Course_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrcc_Course_Sel.length == 0)
            return [];
        return arrcc_Course_Sel.map(x => x.courseId);
    }
    exports.cc_Course_funcKey = cc_Course_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function cc_Course_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetFirstIDAsync = cc_Course_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function cc_Course_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetFirstID = cc_Course_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function cc_Course_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
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
                const objcc_Course = cc_Course_GetObjFromJsonObj(returnObj);
                return objcc_Course;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetFirstObjAsync = cc_Course_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_Course_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clscc_CourseEN_js_1.clscc_CourseEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseEN_js_1.clscc_CourseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_CourseEN_js_1.clscc_CourseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrcc_CourseExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrcc_CourseObjLst_T = cc_Course_GetObjLstByJSONObjLst(arrcc_CourseExObjLst_Cache);
            return arrcc_CourseObjLst_T;
        }
        try {
            const arrcc_CourseExObjLst = await cc_Course_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrcc_CourseExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseExObjLst.length);
            console.log(strInfo);
            return arrcc_CourseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_Course_GetObjLst_ClientCache = cc_Course_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_Course_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clscc_CourseEN_js_1.clscc_CourseEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseEN_js_1.clscc_CourseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_CourseEN_js_1.clscc_CourseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrcc_CourseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrcc_CourseObjLst_T = cc_Course_GetObjLstByJSONObjLst(arrcc_CourseExObjLst_Cache);
            return arrcc_CourseObjLst_T;
        }
        try {
            const arrcc_CourseExObjLst = await cc_Course_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrcc_CourseExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseExObjLst.length);
            console.log(strInfo);
            return arrcc_CourseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_Course_GetObjLst_localStorage = cc_Course_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_Course_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clscc_CourseEN_js_1.clscc_CourseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrcc_CourseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrcc_CourseObjLst_Cache;
        }
        else
            return null;
    }
    exports.cc_Course_GetObjLst_localStorage_PureCache = cc_Course_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function cc_Course_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_Course_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetObjLstAsync = cc_Course_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_Course_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clscc_CourseEN_js_1.clscc_CourseEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clscc_CourseEN_js_1.clscc_CourseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clscc_CourseEN_js_1.clscc_CourseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrcc_CourseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrcc_CourseObjLst_T = cc_Course_GetObjLstByJSONObjLst(arrcc_CourseExObjLst_Cache);
            return arrcc_CourseObjLst_T;
        }
        try {
            const arrcc_CourseExObjLst = await cc_Course_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrcc_CourseExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseExObjLst.length);
            console.log(strInfo);
            return arrcc_CourseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_Course_GetObjLst_sessionStorage = cc_Course_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_Course_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clscc_CourseEN_js_1.clscc_CourseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrcc_CourseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrcc_CourseObjLst_Cache;
        }
        else
            return null;
    }
    exports.cc_Course_GetObjLst_sessionStorage_PureCache = cc_Course_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_Course_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrcc_CourseObjLst_Cache;
        switch (clscc_CourseEN_js_1.clscc_CourseEN.CacheModeId) {
            case "04": //sessionStorage
                arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_ClientCache();
                break;
            default:
                arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_ClientCache();
                break;
        }
        const arrcc_CourseObjLst = cc_Course_GetObjLstByJSONObjLst(arrcc_CourseObjLst_Cache);
        return arrcc_CourseObjLst_Cache;
    }
    exports.cc_Course_GetObjLst_Cache = cc_Course_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_Course_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrcc_CourseObjLst_Cache;
        switch (clscc_CourseEN_js_1.clscc_CourseEN.CacheModeId) {
            case "04": //sessionStorage
                arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrcc_CourseObjLst_Cache = null;
                break;
            default:
                arrcc_CourseObjLst_Cache = null;
                break;
        }
        return arrcc_CourseObjLst_Cache;
    }
    exports.cc_Course_GetObjLst_PureCache = cc_Course_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrCourseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function cc_Course_GetSubObjLst_Cache(objcc_Course_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
        let arrcc_Course_Sel = arrcc_CourseObjLst_Cache;
        if (objcc_Course_Cond.sf_FldComparisonOp == null || objcc_Course_Cond.sf_FldComparisonOp == "")
            return arrcc_Course_Sel;
        const dicFldComparisonOp = JSON.parse(objcc_Course_Cond.sf_FldComparisonOp);
        //console.log("clscc_CourseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_Course_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_Course_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrcc_Course_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objcc_Course_Cond), exports.cc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_Course_GetSubObjLst_Cache = cc_Course_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCourseId:关键字列表
    * @returns 对象列表
    **/
    async function cc_Course_GetObjLstByCourseIdLstAsync(arrCourseId) {
        const strThisFuncName = "GetObjLstByCourseIdLstAsync";
        const strAction = "GetObjLstByCourseIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_Course_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetObjLstByCourseIdLstAsync = cc_Course_GetObjLstByCourseIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrCourseIdLst:关键字列表
     * @returns 对象列表
    */
    async function cc_Course_GetObjLstByCourseIdLst_Cache(arrCourseIdLst) {
        const strThisFuncName = "GetObjLstByCourseIdLst_Cache";
        try {
            const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
            const arrcc_Course_Sel = arrcc_CourseObjLst_Cache.filter(x => arrCourseIdLst.indexOf(x.courseId) > -1);
            return arrcc_Course_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCourseIdLst.join(","), exports.cc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.cc_Course_GetObjLstByCourseIdLst_Cache = cc_Course_GetObjLstByCourseIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function cc_Course_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_Course_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetTopObjLstAsync = cc_Course_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function cc_Course_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_Course_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetObjLstByRangeAsync = cc_Course_GetObjLstByRangeAsync;
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
    async function cc_Course_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetObjLstByRange = cc_Course_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function cc_Course_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
        if (arrcc_CourseObjLst_Cache.length == 0)
            return arrcc_CourseObjLst_Cache;
        let arrcc_Course_Sel = arrcc_CourseObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objcc_Course_Cond = new clscc_CourseEN_js_1.clscc_CourseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_Course_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clscc_CourseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_Course_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_Course_Sel.length == 0)
                return arrcc_Course_Sel;
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
                arrcc_Course_Sel = arrcc_Course_Sel.sort(cc_Course_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrcc_Course_Sel = arrcc_Course_Sel.sort(objPagerPara.sortFun);
            }
            arrcc_Course_Sel = arrcc_Course_Sel.slice(intStart, intEnd);
            return arrcc_Course_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_Course_GetObjLstByPager_Cache = cc_Course_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function cc_Course_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_Course_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetObjLstByPagerAsync = cc_Course_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strCourseId:关键字
    * @returns 获取删除的结果
    **/
    async function cc_Course_DelRecordAsync(strCourseId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strCourseId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_DelRecordAsync = cc_Course_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrCourseId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function cc_Course_Delcc_CoursesAsync(arrCourseId) {
        const strThisFuncName = "Delcc_CoursesAsync";
        const strAction = "Delcc_Courses";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_Delcc_CoursesAsync = cc_Course_Delcc_CoursesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function cc_Course_Delcc_CoursesByCondAsync(strWhereCond) {
        const strThisFuncName = "Delcc_CoursesByCondAsync";
        const strAction = "Delcc_CoursesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_Delcc_CoursesByCondAsync = cc_Course_Delcc_CoursesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objcc_CourseEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_Course_AddNewRecordAsync(objcc_CourseEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objcc_CourseEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_AddNewRecordAsync = cc_Course_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objcc_CourseEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_Course_AddNewRecordWithMaxIdAsync(objcc_CourseEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_AddNewRecordWithMaxIdAsync = cc_Course_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objcc_CourseEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function cc_Course_AddNewRecordWithReturnKeyAsync(objcc_CourseEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_AddNewRecordWithReturnKeyAsync = cc_Course_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objcc_CourseEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function cc_Course_AddNewRecordWithReturnKey(objcc_CourseEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objcc_CourseEN.courseId === null || objcc_CourseEN.courseId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_AddNewRecordWithReturnKey = cc_Course_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objcc_CourseEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function cc_Course_UpdateRecordAsync(objcc_CourseEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objcc_CourseEN.sf_UpdFldSetStr === undefined || objcc_CourseEN.sf_UpdFldSetStr === null || objcc_CourseEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_CourseEN.courseId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_UpdateRecordAsync = cc_Course_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objcc_CourseEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function cc_Course_UpdateWithConditionAsync(objcc_CourseEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objcc_CourseEN.sf_UpdFldSetStr === undefined || objcc_CourseEN.sf_UpdFldSetStr === null || objcc_CourseEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_CourseEN.courseId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        objcc_CourseEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_UpdateWithConditionAsync = cc_Course_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrCourseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function cc_Course_IsExistRecord_Cache(objcc_Course_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
        if (arrcc_CourseObjLst_Cache == null)
            return false;
        let arrcc_Course_Sel = arrcc_CourseObjLst_Cache;
        if (objcc_Course_Cond.sf_FldComparisonOp == null || objcc_Course_Cond.sf_FldComparisonOp == "")
            return arrcc_Course_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objcc_Course_Cond.sf_FldComparisonOp);
        //console.log("clscc_CourseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_Course_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_Course_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_Course_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objcc_Course_Cond), exports.cc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.cc_Course_IsExistRecord_Cache = cc_Course_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function cc_Course_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_IsExistRecordAsync = cc_Course_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCourseId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function cc_Course_IsExist(strCourseId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CourseId": strCourseId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_IsExist = cc_Course_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strCourseId:所给的关键字
     * @returns 对象
    */
    async function cc_Course_IsExist_Cache(strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
        if (arrcc_CourseObjLst_Cache == null)
            return false;
        try {
            const arrcc_Course_Sel = arrcc_CourseObjLst_Cache.filter(x => x.courseId == strCourseId);
            if (arrcc_Course_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCourseId, exports.cc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.cc_Course_IsExist_Cache = cc_Course_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCourseId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function cc_Course_IsExistAsync(strCourseId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strCourseId": strCourseId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_IsExistAsync = cc_Course_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function cc_Course_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetRecCountByCondAsync = cc_Course_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objcc_Course_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function cc_Course_GetRecCountByCond_Cache(objcc_Course_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
        if (arrcc_CourseObjLst_Cache == null)
            return 0;
        let arrcc_Course_Sel = arrcc_CourseObjLst_Cache;
        if (objcc_Course_Cond.sf_FldComparisonOp == null || objcc_Course_Cond.sf_FldComparisonOp == "")
            return arrcc_Course_Sel.length;
        const dicFldComparisonOp = JSON.parse(objcc_Course_Cond.sf_FldComparisonOp);
        //console.log("clscc_CourseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_Course_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_Course_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrcc_Course_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objcc_Course_Cond), exports.cc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.cc_Course_GetRecCountByCond_Cache = cc_Course_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function cc_Course_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetMaxStrIdAsync = cc_Course_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function cc_Course_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_Course_GetMaxStrIdByPrefix = cc_Course_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function cc_Course_GetWebApiUrl(strController, strAction) {
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
    exports.cc_Course_GetWebApiUrl = cc_Course_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function cc_Course_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clscc_CourseEN_js_1.clscc_CourseEN._CurrTabName;
        switch (clscc_CourseEN_js_1.clscc_CourseEN.CacheModeId) {
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
    exports.cc_Course_ReFreshCache = cc_Course_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function cc_Course_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clscc_CourseEN_js_1.clscc_CourseEN._CurrTabName;
            switch (clscc_CourseEN_js_1.clscc_CourseEN.CacheModeId) {
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
    exports.cc_Course_ReFreshThisCache = cc_Course_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function cc_Course_BindDdl_CourseIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_CourseIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_CourseIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_CourseIdInDiv_Cache");
        const arrObjLst_Sel = await cc_Course_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId, clscc_CourseEN_js_1.clscc_CourseEN.con_CourseName, "课程");
    }
    exports.cc_Course_BindDdl_CourseIdInDiv_Cache = cc_Course_BindDdl_CourseIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function cc_Course_CheckPropertyNew(pobjcc_CourseEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseName) === true) {
            throw new Error("(errid:Watl000058)字段[课程名称]不能为空(In 课程)!(clscc_CourseBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.courseId) > 8) {
            throw new Error("(errid:Watl000059)字段[课程Id(courseId)]的长度不能超过8(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseId)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseCode) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.courseCode) > 20) {
            throw new Error("(errid:Watl000059)字段[课程代码(courseCode)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseCode)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseDescription) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.courseDescription) > 8000) {
            throw new Error("(errid:Watl000059)字段[课程描述(courseDescription)]的长度不能超过8000(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseDescription)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseName) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.courseName) > 100) {
            throw new Error("(errid:Watl000059)字段[课程名称(courseName)]的长度不能超过100(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseName)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseTypeID) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.courseTypeID) > 4) {
            throw new Error("(errid:Watl000059)字段[课程类型ID(courseTypeID)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseTypeID)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.createDate) > 20) {
            throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.createDate)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.excellentTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.excellentTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[精品课程类型Id(excellentTypeId)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.excellentTypeId)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.operationDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.operationDate) > 20) {
            throw new Error("(errid:Watl000059)字段[操作时间(operationDate)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.operationDate)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.outerLink) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.outerLink) > 500) {
            throw new Error("(errid:Watl000059)字段[外链地址(outerLink)]的长度不能超过500(In 课程(cc_Course))!值:$(pobjcc_CourseEN.outerLink)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.themeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.themeId) > 4) {
            throw new Error("(errid:Watl000059)字段[主题Id(themeId)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.themeId)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.id_School) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.id_School) > 4) {
            throw new Error("(errid:Watl000059)字段[学校流水号(id_School)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.id_School)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.id_XzMajor) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 课程(cc_Course))!值:$(pobjcc_CourseEN.id_XzMajor)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.id_XzCollege) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.id_XzCollege)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.updDate)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.updUserId)(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 课程(cc_Course))!值:$(pobjcc_CourseEN.memo)(clscc_CourseBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseId) == false && undefined !== pobjcc_CourseEN.courseId && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.courseId) === false) {
            throw new Error("(errid:Watl000060)字段[课程Id(courseId)]的值:[$(pobjcc_CourseEN.courseId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseCode) == false && undefined !== pobjcc_CourseEN.courseCode && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.courseCode) === false) {
            throw new Error("(errid:Watl000060)字段[课程代码(courseCode)]的值:[$(pobjcc_CourseEN.courseCode)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseDescription) == false && undefined !== pobjcc_CourseEN.courseDescription && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.courseDescription) === false) {
            throw new Error("(errid:Watl000060)字段[课程描述(courseDescription)]的值:[$(pobjcc_CourseEN.courseDescription)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseName) == false && undefined !== pobjcc_CourseEN.courseName && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.courseName) === false) {
            throw new Error("(errid:Watl000060)字段[课程名称(courseName)]的值:[$(pobjcc_CourseEN.courseName)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseTypeID) == false && undefined !== pobjcc_CourseEN.courseTypeID && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.courseTypeID) === false) {
            throw new Error("(errid:Watl000060)字段[课程类型ID(courseTypeID)]的值:[$(pobjcc_CourseEN.courseTypeID)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.createDate) == false && undefined !== pobjcc_CourseEN.createDate && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.createDate) === false) {
            throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjcc_CourseEN.createDate)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.excellentTypeId) == false && undefined !== pobjcc_CourseEN.excellentTypeId && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.excellentTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[精品课程类型Id(excellentTypeId)]的值:[$(pobjcc_CourseEN.excellentTypeId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseEN.excellentYear && undefined !== pobjcc_CourseEN.excellentYear && clsString_js_1.tzDataType.isNumber(pobjcc_CourseEN.excellentYear) === false) {
            throw new Error("(errid:Watl000060)字段[课程年份(excellentYear)]的值:[$(pobjcc_CourseEN.excellentYear)], 非法，应该为数值型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseEN.isBuildingCourse && undefined !== pobjcc_CourseEN.isBuildingCourse && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseEN.isBuildingCourse) === false) {
            throw new Error("(errid:Watl000060)字段[是否已建设课程(isBuildingCourse)]的值:[$(pobjcc_CourseEN.isBuildingCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseEN.isDoubleLanguageCourse && undefined !== pobjcc_CourseEN.isDoubleLanguageCourse && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseEN.isDoubleLanguageCourse) === false) {
            throw new Error("(errid:Watl000060)字段[是否双语课程(isDoubleLanguageCourse)]的值:[$(pobjcc_CourseEN.isDoubleLanguageCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseEN.isOpen && undefined !== pobjcc_CourseEN.isOpen && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseEN.isOpen) === false) {
            throw new Error("(errid:Watl000060)字段[是否公开(isOpen)]的值:[$(pobjcc_CourseEN.isOpen)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseEN.isRecommendedCourse && undefined !== pobjcc_CourseEN.isRecommendedCourse && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseEN.isRecommendedCourse) === false) {
            throw new Error("(errid:Watl000060)字段[是否推荐课程(isRecommendedCourse)]的值:[$(pobjcc_CourseEN.isRecommendedCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseEN.isSelfPropelledCourse && undefined !== pobjcc_CourseEN.isSelfPropelledCourse && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseEN.isSelfPropelledCourse) === false) {
            throw new Error("(errid:Watl000060)字段[是否自荐课程(isSelfPropelledCourse)]的值:[$(pobjcc_CourseEN.isSelfPropelledCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.operationDate) == false && undefined !== pobjcc_CourseEN.operationDate && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.operationDate) === false) {
            throw new Error("(errid:Watl000060)字段[操作时间(operationDate)]的值:[$(pobjcc_CourseEN.operationDate)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseEN.orderNum && undefined !== pobjcc_CourseEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjcc_CourseEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjcc_CourseEN.orderNum)], 非法，应该为数值型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.outerLink) == false && undefined !== pobjcc_CourseEN.outerLink && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.outerLink) === false) {
            throw new Error("(errid:Watl000060)字段[外链地址(outerLink)]的值:[$(pobjcc_CourseEN.outerLink)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseEN.viewCount && undefined !== pobjcc_CourseEN.viewCount && clsString_js_1.tzDataType.isNumber(pobjcc_CourseEN.viewCount) === false) {
            throw new Error("(errid:Watl000060)字段[浏览量(viewCount)]的值:[$(pobjcc_CourseEN.viewCount)], 非法，应该为数值型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.themeId) == false && undefined !== pobjcc_CourseEN.themeId && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.themeId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(themeId)]的值:[$(pobjcc_CourseEN.themeId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.id_School) == false && undefined !== pobjcc_CourseEN.id_School && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.id_School) === false) {
            throw new Error("(errid:Watl000060)字段[学校流水号(id_School)]的值:[$(pobjcc_CourseEN.id_School)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.id_XzMajor) == false && undefined !== pobjcc_CourseEN.id_XzMajor && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjcc_CourseEN.id_XzMajor)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.id_XzCollege) == false && undefined !== pobjcc_CourseEN.id_XzCollege && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjcc_CourseEN.id_XzCollege)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.updDate) == false && undefined !== pobjcc_CourseEN.updDate && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjcc_CourseEN.updDate)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.updUserId) == false && undefined !== pobjcc_CourseEN.updUserId && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjcc_CourseEN.updUserId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.memo) == false && undefined !== pobjcc_CourseEN.memo && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjcc_CourseEN.memo)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseTypeID) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.courseTypeID) != 4) {
            throw ("(errid:Watl000061)字段[课程类型ID]作为外键字段,长度应该为4(In 课程)!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.excellentTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.excellentTypeId) != 4) {
            throw ("(errid:Watl000061)字段[精品课程类型Id]作为外键字段,长度应该为4(In 课程)!(clscc_CourseBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjcc_CourseEN.SetIsCheckProperty(true);
    }
    exports.cc_Course_CheckPropertyNew = cc_Course_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function cc_Course_CheckProperty4Update(pobjcc_CourseEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.courseId) > 8) {
            throw new Error("(errid:Watl000062)字段[课程Id(courseId)]的长度不能超过8(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseId)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseCode) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.courseCode) > 20) {
            throw new Error("(errid:Watl000062)字段[课程代码(courseCode)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseCode)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseDescription) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.courseDescription) > 8000) {
            throw new Error("(errid:Watl000062)字段[课程描述(courseDescription)]的长度不能超过8000(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseDescription)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseName) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.courseName) > 100) {
            throw new Error("(errid:Watl000062)字段[课程名称(courseName)]的长度不能超过100(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseName)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseTypeID) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.courseTypeID) > 4) {
            throw new Error("(errid:Watl000062)字段[课程类型ID(courseTypeID)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseTypeID)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.createDate) > 20) {
            throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.createDate)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.excellentTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.excellentTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[精品课程类型Id(excellentTypeId)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.excellentTypeId)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.operationDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.operationDate) > 20) {
            throw new Error("(errid:Watl000062)字段[操作时间(operationDate)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.operationDate)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.outerLink) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.outerLink) > 500) {
            throw new Error("(errid:Watl000062)字段[外链地址(outerLink)]的长度不能超过500(In 课程(cc_Course))!值:$(pobjcc_CourseEN.outerLink)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.themeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.themeId) > 4) {
            throw new Error("(errid:Watl000062)字段[主题Id(themeId)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.themeId)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.id_School) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.id_School) > 4) {
            throw new Error("(errid:Watl000062)字段[学校流水号(id_School)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.id_School)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.id_XzMajor) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 课程(cc_Course))!值:$(pobjcc_CourseEN.id_XzMajor)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.id_XzCollege) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.id_XzCollege)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.updDate)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.updUserId)(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 课程(cc_Course))!值:$(pobjcc_CourseEN.memo)(clscc_CourseBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseId) == false && undefined !== pobjcc_CourseEN.courseId && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.courseId) === false) {
            throw new Error("(errid:Watl000063)字段[课程Id(courseId)]的值:[$(pobjcc_CourseEN.courseId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseCode) == false && undefined !== pobjcc_CourseEN.courseCode && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.courseCode) === false) {
            throw new Error("(errid:Watl000063)字段[课程代码(courseCode)]的值:[$(pobjcc_CourseEN.courseCode)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseDescription) == false && undefined !== pobjcc_CourseEN.courseDescription && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.courseDescription) === false) {
            throw new Error("(errid:Watl000063)字段[课程描述(courseDescription)]的值:[$(pobjcc_CourseEN.courseDescription)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseName) == false && undefined !== pobjcc_CourseEN.courseName && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.courseName) === false) {
            throw new Error("(errid:Watl000063)字段[课程名称(courseName)]的值:[$(pobjcc_CourseEN.courseName)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseTypeID) == false && undefined !== pobjcc_CourseEN.courseTypeID && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.courseTypeID) === false) {
            throw new Error("(errid:Watl000063)字段[课程类型ID(courseTypeID)]的值:[$(pobjcc_CourseEN.courseTypeID)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.createDate) == false && undefined !== pobjcc_CourseEN.createDate && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.createDate) === false) {
            throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjcc_CourseEN.createDate)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.excellentTypeId) == false && undefined !== pobjcc_CourseEN.excellentTypeId && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.excellentTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[精品课程类型Id(excellentTypeId)]的值:[$(pobjcc_CourseEN.excellentTypeId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseEN.excellentYear && undefined !== pobjcc_CourseEN.excellentYear && clsString_js_1.tzDataType.isNumber(pobjcc_CourseEN.excellentYear) === false) {
            throw new Error("(errid:Watl000063)字段[课程年份(excellentYear)]的值:[$(pobjcc_CourseEN.excellentYear)], 非法，应该为数值型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseEN.isBuildingCourse && undefined !== pobjcc_CourseEN.isBuildingCourse && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseEN.isBuildingCourse) === false) {
            throw new Error("(errid:Watl000063)字段[是否已建设课程(isBuildingCourse)]的值:[$(pobjcc_CourseEN.isBuildingCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseEN.isDoubleLanguageCourse && undefined !== pobjcc_CourseEN.isDoubleLanguageCourse && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseEN.isDoubleLanguageCourse) === false) {
            throw new Error("(errid:Watl000063)字段[是否双语课程(isDoubleLanguageCourse)]的值:[$(pobjcc_CourseEN.isDoubleLanguageCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseEN.isOpen && undefined !== pobjcc_CourseEN.isOpen && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseEN.isOpen) === false) {
            throw new Error("(errid:Watl000063)字段[是否公开(isOpen)]的值:[$(pobjcc_CourseEN.isOpen)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseEN.isRecommendedCourse && undefined !== pobjcc_CourseEN.isRecommendedCourse && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseEN.isRecommendedCourse) === false) {
            throw new Error("(errid:Watl000063)字段[是否推荐课程(isRecommendedCourse)]的值:[$(pobjcc_CourseEN.isRecommendedCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseEN.isSelfPropelledCourse && undefined !== pobjcc_CourseEN.isSelfPropelledCourse && clsString_js_1.tzDataType.isBoolean(pobjcc_CourseEN.isSelfPropelledCourse) === false) {
            throw new Error("(errid:Watl000063)字段[是否自荐课程(isSelfPropelledCourse)]的值:[$(pobjcc_CourseEN.isSelfPropelledCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.operationDate) == false && undefined !== pobjcc_CourseEN.operationDate && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.operationDate) === false) {
            throw new Error("(errid:Watl000063)字段[操作时间(operationDate)]的值:[$(pobjcc_CourseEN.operationDate)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseEN.orderNum && undefined !== pobjcc_CourseEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjcc_CourseEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjcc_CourseEN.orderNum)], 非法，应该为数值型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.outerLink) == false && undefined !== pobjcc_CourseEN.outerLink && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.outerLink) === false) {
            throw new Error("(errid:Watl000063)字段[外链地址(outerLink)]的值:[$(pobjcc_CourseEN.outerLink)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseEN.viewCount && undefined !== pobjcc_CourseEN.viewCount && clsString_js_1.tzDataType.isNumber(pobjcc_CourseEN.viewCount) === false) {
            throw new Error("(errid:Watl000063)字段[浏览量(viewCount)]的值:[$(pobjcc_CourseEN.viewCount)], 非法，应该为数值型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.themeId) == false && undefined !== pobjcc_CourseEN.themeId && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.themeId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(themeId)]的值:[$(pobjcc_CourseEN.themeId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.id_School) == false && undefined !== pobjcc_CourseEN.id_School && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.id_School) === false) {
            throw new Error("(errid:Watl000063)字段[学校流水号(id_School)]的值:[$(pobjcc_CourseEN.id_School)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.id_XzMajor) == false && undefined !== pobjcc_CourseEN.id_XzMajor && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjcc_CourseEN.id_XzMajor)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.id_XzCollege) == false && undefined !== pobjcc_CourseEN.id_XzCollege && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjcc_CourseEN.id_XzCollege)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.updDate) == false && undefined !== pobjcc_CourseEN.updDate && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjcc_CourseEN.updDate)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.updUserId) == false && undefined !== pobjcc_CourseEN.updUserId && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjcc_CourseEN.updUserId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.memo) == false && undefined !== pobjcc_CourseEN.memo && clsString_js_1.tzDataType.isString(pobjcc_CourseEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjcc_CourseEN.memo)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseId) === true
            || pobjcc_CourseEN.courseId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[课程Id]不能为空(In 课程)!(clscc_CourseBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.courseTypeID) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.courseTypeID) != 4) {
            throw ("(errid:Watl000065)字段[课程类型ID]作为外键字段,长度应该为4(In 课程)!(clscc_CourseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjcc_CourseEN.excellentTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjcc_CourseEN.excellentTypeId) != 4) {
            throw ("(errid:Watl000065)字段[精品课程类型Id]作为外键字段,长度应该为4(In 课程)!(clscc_CourseBL:CheckPropertyNew)");
        }
        pobjcc_CourseEN.SetIsCheckProperty(true);
    }
    exports.cc_Course_CheckProperty4Update = cc_Course_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function cc_Course_GetJSONStrByObj(pobjcc_CourseEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjcc_CourseEN.sf_UpdFldSetStr = pobjcc_CourseEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjcc_CourseEN);
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
    exports.cc_Course_GetJSONStrByObj = cc_Course_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function cc_Course_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrcc_CourseObjLst = new Array();
        if (strJSON === "") {
            return arrcc_CourseObjLst;
        }
        try {
            arrcc_CourseObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrcc_CourseObjLst;
        }
        return arrcc_CourseObjLst;
    }
    exports.cc_Course_GetObjLstByJSONStr = cc_Course_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrcc_CourseObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function cc_Course_GetObjLstByJSONObjLst(arrcc_CourseObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrcc_CourseObjLst = new Array();
        for (const objInFor of arrcc_CourseObjLstS) {
            const obj1 = cc_Course_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrcc_CourseObjLst.push(obj1);
        }
        return arrcc_CourseObjLst;
    }
    exports.cc_Course_GetObjLstByJSONObjLst = cc_Course_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function cc_Course_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjcc_CourseEN = new clscc_CourseEN_js_1.clscc_CourseEN();
        if (strJSON === "") {
            return pobjcc_CourseEN;
        }
        try {
            pobjcc_CourseEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjcc_CourseEN;
        }
        return pobjcc_CourseEN;
    }
    exports.cc_Course_GetObjByJSONStr = cc_Course_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function cc_Course_GetCombineCondition(objcc_Course_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId, objcc_Course_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_CourseCode) == true) {
            const strComparisonOp_CourseCode = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_CourseCode];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_CourseCode, objcc_Course_Cond.courseCode, strComparisonOp_CourseCode);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_CourseDescription) == true) {
            const strComparisonOp_CourseDescription = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_CourseDescription];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_CourseDescription, objcc_Course_Cond.courseDescription, strComparisonOp_CourseDescription);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_CourseName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_CourseName, objcc_Course_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_CourseTypeID) == true) {
            const strComparisonOp_CourseTypeID = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_CourseTypeID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_CourseTypeID, objcc_Course_Cond.courseTypeID, strComparisonOp_CourseTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_CreateDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_CreateDate, objcc_Course_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_ExcellentTypeId) == true) {
            const strComparisonOp_ExcellentTypeId = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_ExcellentTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_ExcellentTypeId, objcc_Course_Cond.excellentTypeId, strComparisonOp_ExcellentTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_ExcellentYear) == true) {
            const strComparisonOp_ExcellentYear = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_ExcellentYear];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseEN_js_1.clscc_CourseEN.con_ExcellentYear, objcc_Course_Cond.excellentYear, strComparisonOp_ExcellentYear);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_IsBuildingCourse) == true) {
            if (objcc_Course_Cond.isBuildingCourse == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseEN_js_1.clscc_CourseEN.con_IsBuildingCourse);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseEN_js_1.clscc_CourseEN.con_IsBuildingCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_IsDoubleLanguageCourse) == true) {
            if (objcc_Course_Cond.isDoubleLanguageCourse == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseEN_js_1.clscc_CourseEN.con_IsDoubleLanguageCourse);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseEN_js_1.clscc_CourseEN.con_IsDoubleLanguageCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_IsOpen) == true) {
            if (objcc_Course_Cond.isOpen == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseEN_js_1.clscc_CourseEN.con_IsOpen);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseEN_js_1.clscc_CourseEN.con_IsOpen);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_IsRecommendedCourse) == true) {
            if (objcc_Course_Cond.isRecommendedCourse == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseEN_js_1.clscc_CourseEN.con_IsRecommendedCourse);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseEN_js_1.clscc_CourseEN.con_IsRecommendedCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_IsSelfPropelledCourse) == true) {
            if (objcc_Course_Cond.isSelfPropelledCourse == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clscc_CourseEN_js_1.clscc_CourseEN.con_IsSelfPropelledCourse);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clscc_CourseEN_js_1.clscc_CourseEN.con_IsSelfPropelledCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_OperationDate) == true) {
            const strComparisonOp_OperationDate = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_OperationDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_OperationDate, objcc_Course_Cond.operationDate, strComparisonOp_OperationDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_OrderNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseEN_js_1.clscc_CourseEN.con_OrderNum, objcc_Course_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_OuterLink) == true) {
            const strComparisonOp_OuterLink = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_OuterLink];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_OuterLink, objcc_Course_Cond.outerLink, strComparisonOp_OuterLink);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_ViewCount) == true) {
            const strComparisonOp_ViewCount = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_ViewCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clscc_CourseEN_js_1.clscc_CourseEN.con_ViewCount, objcc_Course_Cond.viewCount, strComparisonOp_ViewCount);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_ThemeId) == true) {
            const strComparisonOp_ThemeId = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_ThemeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_ThemeId, objcc_Course_Cond.themeId, strComparisonOp_ThemeId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_id_School) == true) {
            const strComparisonOp_id_School = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_id_School];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_id_School, objcc_Course_Cond.id_School, strComparisonOp_id_School);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzMajor, objcc_Course_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzCollege, objcc_Course_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_UpdDate, objcc_Course_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_UpdUserId, objcc_Course_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN_js_1.clscc_CourseEN.con_Memo) == true) {
            const strComparisonOp_Memo = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN_js_1.clscc_CourseEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clscc_CourseEN_js_1.clscc_CourseEN.con_Memo, objcc_Course_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.cc_Course_GetCombineCondition = cc_Course_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--cc_Course(课程),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strCourseId: 课程Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function cc_Course_GetUniCondStr_CourseId(objcc_CourseEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and CourseId = '{0}'", objcc_CourseEN.courseId);
        return strWhereCond;
    }
    exports.cc_Course_GetUniCondStr_CourseId = cc_Course_GetUniCondStr_CourseId;
    /**
    *获取唯一性条件串(Uniqueness)--cc_Course(课程),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strCourseId: 课程Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function cc_Course_GetUniCondStr4Update_CourseId(objcc_CourseEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and CourseId <> '{0}'", objcc_CourseEN.courseId);
        strWhereCond += (0, clsString_js_2.Format)(" and CourseId = '{0}'", objcc_CourseEN.courseId);
        return strWhereCond;
    }
    exports.cc_Course_GetUniCondStr4Update_CourseId = cc_Course_GetUniCondStr4Update_CourseId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objcc_CourseENS:源对象
     * @param objcc_CourseENT:目标对象
    */
    function cc_Course_CopyObjTo(objcc_CourseENS, objcc_CourseENT) {
        objcc_CourseENT.courseId = objcc_CourseENS.courseId; //课程Id
        objcc_CourseENT.courseCode = objcc_CourseENS.courseCode; //课程代码
        objcc_CourseENT.courseDescription = objcc_CourseENS.courseDescription; //课程描述
        objcc_CourseENT.courseName = objcc_CourseENS.courseName; //课程名称
        objcc_CourseENT.courseTypeID = objcc_CourseENS.courseTypeID; //课程类型ID
        objcc_CourseENT.createDate = objcc_CourseENS.createDate; //建立日期
        objcc_CourseENT.excellentTypeId = objcc_CourseENS.excellentTypeId; //精品课程类型Id
        objcc_CourseENT.excellentYear = objcc_CourseENS.excellentYear; //课程年份
        objcc_CourseENT.isBuildingCourse = objcc_CourseENS.isBuildingCourse; //是否已建设课程
        objcc_CourseENT.isDoubleLanguageCourse = objcc_CourseENS.isDoubleLanguageCourse; //是否双语课程
        objcc_CourseENT.isOpen = objcc_CourseENS.isOpen; //是否公开
        objcc_CourseENT.isRecommendedCourse = objcc_CourseENS.isRecommendedCourse; //是否推荐课程
        objcc_CourseENT.isSelfPropelledCourse = objcc_CourseENS.isSelfPropelledCourse; //是否自荐课程
        objcc_CourseENT.operationDate = objcc_CourseENS.operationDate; //操作时间
        objcc_CourseENT.orderNum = objcc_CourseENS.orderNum; //序号
        objcc_CourseENT.outerLink = objcc_CourseENS.outerLink; //外链地址
        objcc_CourseENT.viewCount = objcc_CourseENS.viewCount; //浏览量
        objcc_CourseENT.themeId = objcc_CourseENS.themeId; //主题Id
        objcc_CourseENT.id_School = objcc_CourseENS.id_School; //学校流水号
        objcc_CourseENT.id_XzMajor = objcc_CourseENS.id_XzMajor; //专业流水号
        objcc_CourseENT.id_XzCollege = objcc_CourseENS.id_XzCollege; //学院流水号
        objcc_CourseENT.updDate = objcc_CourseENS.updDate; //修改日期
        objcc_CourseENT.updUserId = objcc_CourseENS.updUserId; //修改用户Id
        objcc_CourseENT.memo = objcc_CourseENS.memo; //备注
        objcc_CourseENT.sf_UpdFldSetStr = objcc_CourseENS.updFldString; //sf_UpdFldSetStr
    }
    exports.cc_Course_CopyObjTo = cc_Course_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objcc_CourseENS:源对象
     * @param objcc_CourseENT:目标对象
    */
    function cc_Course_GetObjFromJsonObj(objcc_CourseENS) {
        const objcc_CourseENT = new clscc_CourseEN_js_1.clscc_CourseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_CourseENT, objcc_CourseENS);
        return objcc_CourseENT;
    }
    exports.cc_Course_GetObjFromJsonObj = cc_Course_GetObjFromJsonObj;
});
