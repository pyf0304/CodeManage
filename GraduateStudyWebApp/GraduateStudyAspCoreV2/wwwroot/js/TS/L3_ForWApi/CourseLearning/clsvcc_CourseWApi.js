/**
* 类名:clsvcc_CourseWApi
* 表名:vcc_Course(01120058)
* 版本:2023.02.24.1(服务器:WIN-SRV103-116)
* 日期:2023/02/24 13:49:03
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/CourseLearning/clsvcc_CourseEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vcc_Course_GetObjFromJsonObj = exports.vcc_Course_CopyObjTo = exports.vcc_Course_GetCombineCondition = exports.vcc_Course_GetObjByJSONStr = exports.vcc_Course_GetObjLstByJSONObjLst = exports.vcc_Course_GetObjLstByJSONStr = exports.vcc_Course_GetJSONStrByObj = exports.vcc_Course_ReFreshThisCache = exports.vcc_Course_GetWebApiUrl = exports.vcc_Course_GetRecCountByCond_Cache = exports.vcc_Course_GetRecCountByCondAsync = exports.vcc_Course_IsExistAsync = exports.vcc_Course_IsExist_Cache = exports.vcc_Course_IsExist = exports.vcc_Course_IsExistRecordAsync = exports.vcc_Course_IsExistRecord_Cache = exports.vcc_Course_GetObjLstByPagerAsync = exports.vcc_Course_GetObjLstByPager_Cache = exports.vcc_Course_GetObjLstByRange = exports.vcc_Course_GetObjLstByRangeAsync = exports.vcc_Course_GetTopObjLstAsync = exports.vcc_Course_GetObjLstByCourseIdLst_Cache = exports.vcc_Course_GetObjLstByCourseIdLstAsync = exports.vcc_Course_GetSubObjLst_Cache = exports.vcc_Course_GetObjLst_PureCache = exports.vcc_Course_GetObjLst_Cache = exports.vcc_Course_GetObjLst_sessionStorage_PureCache = exports.vcc_Course_GetObjLst_sessionStorage = exports.vcc_Course_GetObjLstAsync = exports.vcc_Course_GetObjLst_localStorage_PureCache = exports.vcc_Course_GetObjLst_localStorage = exports.vcc_Course_GetObjLst_ClientCache = exports.vcc_Course_GetFirstObjAsync = exports.vcc_Course_GetFirstID = exports.vcc_Course_GetFirstIDAsync = exports.vcc_Course_funcKey = exports.vcc_Course_FilterFunByKey = exports.vcc_Course_SortFunByKey = exports.vcc_Course_SortFun_Defa_2Fld = exports.vcc_Course_SortFun_Defa = exports.vcc_Course_func = exports.vcc_Course_GetObjByCourseId_localStorage = exports.vcc_Course_GetObjByCourseId_Cache = exports.vcc_Course_GetObjByCourseIdAsync = exports.vcc_Course_ConstructorName = exports.vcc_Course_Controller = void 0;
    /**
     * v课程(vcc_Course)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年02月24日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvcc_CourseEN_js_1 = require("../../L0_Entity/CourseLearning/clsvcc_CourseEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vcc_Course_Controller = "vcc_CourseApi";
    exports.vcc_Course_ConstructorName = "vcc_Course";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCourseId:关键字
    * @returns 对象
    **/
    async function vcc_Course_GetObjByCourseIdAsync(strCourseId) {
        const strThisFuncName = "GetObjByCourseIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId]不能为空！(In GetObjByCourseIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCourseId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
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
                const objvcc_Course = vcc_Course_GetObjFromJsonObj(returnObj);
                return objvcc_Course;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_GetObjByCourseIdAsync = vcc_Course_GetObjByCourseIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strCourseId:所给的关键字
     * @returns 对象
    */
    async function vcc_Course_GetObjByCourseId_Cache(strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByCourseId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId]不能为空！(In GetObjByCourseId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
        try {
            const arrvcc_Course_Sel = arrvcc_CourseObjLst_Cache.filter(x => x.courseId == strCourseId);
            let objvcc_Course;
            if (arrvcc_Course_Sel.length > 0) {
                objvcc_Course = arrvcc_Course_Sel[0];
                return objvcc_Course;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvcc_Course_Const = await vcc_Course_GetObjByCourseIdAsync(strCourseId);
                    if (objvcc_Course_Const != null) {
                        vcc_Course_ReFreshThisCache();
                        return objvcc_Course_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseId, exports.vcc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vcc_Course_GetObjByCourseId_Cache = vcc_Course_GetObjByCourseId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strCourseId:所给的关键字
     * @returns 对象
    */
    async function vcc_Course_GetObjByCourseId_localStorage(strCourseId) {
        const strThisFuncName = "GetObjByCourseId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId]不能为空！(In GetObjByCourseId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseEN_js_1.clsvcc_CourseEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvcc_Course_Cache = JSON.parse(strTempObj);
            return objvcc_Course_Cache;
        }
        try {
            const objvcc_Course = await vcc_Course_GetObjByCourseIdAsync(strCourseId);
            if (objvcc_Course != null) {
                localStorage.setItem(strKey, JSON.stringify(objvcc_Course));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvcc_Course;
            }
            return objvcc_Course;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseId, exports.vcc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vcc_Course_GetObjByCourseId_localStorage = vcc_Course_GetObjByCourseId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vcc_Course_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvcc_CourseEN_js_1.clsvcc_CourseEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvcc_CourseEN_js_1.clsvcc_CourseEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strCourseId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvcc_Course = await vcc_Course_GetObjByCourseId_Cache(strCourseId);
        if (objvcc_Course == null)
            return "";
        if (objvcc_Course.GetFldValue(strOutFldName) == null)
            return "";
        return objvcc_Course.GetFldValue(strOutFldName).toString();
    }
    exports.vcc_Course_func = vcc_Course_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_Course_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.courseId.localeCompare(b.courseId);
    }
    exports.vcc_Course_SortFun_Defa = vcc_Course_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_Course_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.likeCount == b.likeCount)
            return a.courseCode.localeCompare(b.courseCode);
        else
            return a.likeCount - b.likeCount;
    }
    exports.vcc_Course_SortFun_Defa_2Fld = vcc_Course_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_Course_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseId:
                    return (a, b) => {
                        if (a.courseId == null)
                            return -1;
                        if (b.courseId == null)
                            return 1;
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_LikeCount:
                    return (a, b) => {
                        return a.likeCount - b.likeCount;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseCode:
                    return (a, b) => {
                        if (a.courseCode == null)
                            return -1;
                        if (b.courseCode == null)
                            return 1;
                        return a.courseCode.localeCompare(b.courseCode);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseDescription:
                    return (a, b) => {
                        if (a.courseDescription == null)
                            return -1;
                        if (b.courseDescription == null)
                            return 1;
                        return a.courseDescription.localeCompare(b.courseDescription);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseName:
                    return (a, b) => {
                        if (a.courseName == null)
                            return -1;
                        if (b.courseName == null)
                            return 1;
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseTypeID:
                    return (a, b) => {
                        return a.courseTypeID.localeCompare(b.courseTypeID);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseTypeName:
                    return (a, b) => {
                        return a.courseTypeName.localeCompare(b.courseTypeName);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentTypeId:
                    return (a, b) => {
                        if (a.excellentTypeId == null)
                            return -1;
                        if (b.excellentTypeId == null)
                            return 1;
                        return a.excellentTypeId.localeCompare(b.excellentTypeId);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentTypeName:
                    return (a, b) => {
                        if (a.excellentTypeName == null)
                            return -1;
                        if (b.excellentTypeName == null)
                            return 1;
                        return a.excellentTypeName.localeCompare(b.excellentTypeName);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentYear:
                    return (a, b) => {
                        return a.excellentYear - b.excellentYear;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsBuildingCourse:
                    return (a, b) => {
                        if (a.isBuildingCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsDoubleLanguageCourse:
                    return (a, b) => {
                        if (a.isDoubleLanguageCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsOpen:
                    return (a, b) => {
                        if (a.isOpen == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsRecommendedCourse:
                    return (a, b) => {
                        if (a.isRecommendedCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsSelfPropelledCourse:
                    return (a, b) => {
                        if (a.isSelfPropelledCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OperationDate:
                    return (a, b) => {
                        if (a.operationDate == null)
                            return -1;
                        if (b.operationDate == null)
                            return 1;
                        return a.operationDate.localeCompare(b.operationDate);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OuterLink:
                    return (a, b) => {
                        if (a.outerLink == null)
                            return -1;
                        if (b.outerLink == null)
                            return 1;
                        return a.outerLink.localeCompare(b.outerLink);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ViewCount:
                    return (a, b) => {
                        return a.viewCount - b.viewCount;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ThemeId:
                    return (a, b) => {
                        if (a.themeId == null)
                            return -1;
                        if (b.themeId == null)
                            return 1;
                        return a.themeId.localeCompare(b.themeId);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ThemeName:
                    return (a, b) => {
                        if (a.themeName == null)
                            return -1;
                        if (b.themeName == null)
                            return 1;
                        return a.themeName.localeCompare(b.themeName);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExampleImgPath:
                    return (a, b) => {
                        if (a.exampleImgPath == null)
                            return -1;
                        if (b.exampleImgPath == null)
                            return 1;
                        return a.exampleImgPath.localeCompare(b.exampleImgPath);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_MajorID:
                    return (a, b) => {
                        if (a.majorID == null)
                            return -1;
                        if (b.majorID == null)
                            return 1;
                        return a.majorID.localeCompare(b.majorID);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeID:
                    return (a, b) => {
                        if (a.collegeID == null)
                            return -1;
                        if (b.collegeID == null)
                            return 1;
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeNameA:
                    return (a, b) => {
                        if (a.collegeNameA == null)
                            return -1;
                        if (b.collegeNameA == null)
                            return 1;
                        return a.collegeNameA.localeCompare(b.collegeNameA);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_Course]中不存在！(in ${exports.vcc_Course_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseId:
                    return (a, b) => {
                        if (b.courseId == null)
                            return -1;
                        if (a.courseId == null)
                            return 1;
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_LikeCount:
                    return (a, b) => {
                        return b.likeCount - a.likeCount;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseCode:
                    return (a, b) => {
                        if (b.courseCode == null)
                            return -1;
                        if (a.courseCode == null)
                            return 1;
                        return b.courseCode.localeCompare(a.courseCode);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseDescription:
                    return (a, b) => {
                        if (b.courseDescription == null)
                            return -1;
                        if (a.courseDescription == null)
                            return 1;
                        return b.courseDescription.localeCompare(a.courseDescription);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseName:
                    return (a, b) => {
                        if (b.courseName == null)
                            return -1;
                        if (a.courseName == null)
                            return 1;
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseTypeID:
                    return (a, b) => {
                        return b.courseTypeID.localeCompare(a.courseTypeID);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseTypeName:
                    return (a, b) => {
                        return b.courseTypeName.localeCompare(a.courseTypeName);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentTypeId:
                    return (a, b) => {
                        if (b.excellentTypeId == null)
                            return -1;
                        if (a.excellentTypeId == null)
                            return 1;
                        return b.excellentTypeId.localeCompare(a.excellentTypeId);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentTypeName:
                    return (a, b) => {
                        if (b.excellentTypeName == null)
                            return -1;
                        if (a.excellentTypeName == null)
                            return 1;
                        return b.excellentTypeName.localeCompare(a.excellentTypeName);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentYear:
                    return (a, b) => {
                        return b.excellentYear - a.excellentYear;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsBuildingCourse:
                    return (a, b) => {
                        if (b.isBuildingCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsDoubleLanguageCourse:
                    return (a, b) => {
                        if (b.isDoubleLanguageCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsOpen:
                    return (a, b) => {
                        if (b.isOpen == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsRecommendedCourse:
                    return (a, b) => {
                        if (b.isRecommendedCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsSelfPropelledCourse:
                    return (a, b) => {
                        if (b.isSelfPropelledCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OperationDate:
                    return (a, b) => {
                        if (b.operationDate == null)
                            return -1;
                        if (a.operationDate == null)
                            return 1;
                        return b.operationDate.localeCompare(a.operationDate);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OuterLink:
                    return (a, b) => {
                        if (b.outerLink == null)
                            return -1;
                        if (a.outerLink == null)
                            return 1;
                        return b.outerLink.localeCompare(a.outerLink);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ViewCount:
                    return (a, b) => {
                        return b.viewCount - a.viewCount;
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ThemeId:
                    return (a, b) => {
                        if (b.themeId == null)
                            return -1;
                        if (a.themeId == null)
                            return 1;
                        return b.themeId.localeCompare(a.themeId);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ThemeName:
                    return (a, b) => {
                        if (b.themeName == null)
                            return -1;
                        if (a.themeName == null)
                            return 1;
                        return b.themeName.localeCompare(a.themeName);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExampleImgPath:
                    return (a, b) => {
                        if (b.exampleImgPath == null)
                            return -1;
                        if (a.exampleImgPath == null)
                            return 1;
                        return b.exampleImgPath.localeCompare(a.exampleImgPath);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_MajorID:
                    return (a, b) => {
                        if (b.majorID == null)
                            return -1;
                        if (a.majorID == null)
                            return 1;
                        return b.majorID.localeCompare(a.majorID);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeID:
                    return (a, b) => {
                        if (b.collegeID == null)
                            return -1;
                        if (a.collegeID == null)
                            return 1;
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeNameA:
                    return (a, b) => {
                        if (b.collegeNameA == null)
                            return -1;
                        if (a.collegeNameA == null)
                            return 1;
                        return b.collegeNameA.localeCompare(a.collegeNameA);
                    };
                case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_Course]中不存在！(in ${exports.vcc_Course_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vcc_Course_SortFunByKey = vcc_Course_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vcc_Course_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_LikeCount:
                return (obj) => {
                    return obj.likeCount === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseCode:
                return (obj) => {
                    return obj.courseCode === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseDescription:
                return (obj) => {
                    return obj.courseDescription === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseTypeID:
                return (obj) => {
                    return obj.courseTypeID === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseTypeName:
                return (obj) => {
                    return obj.courseTypeName === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentTypeId:
                return (obj) => {
                    return obj.excellentTypeId === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentTypeName:
                return (obj) => {
                    return obj.excellentTypeName === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentYear:
                return (obj) => {
                    return obj.excellentYear === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsBuildingCourse:
                return (obj) => {
                    return obj.isBuildingCourse === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsDoubleLanguageCourse:
                return (obj) => {
                    return obj.isDoubleLanguageCourse === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsOpen:
                return (obj) => {
                    return obj.isOpen === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsRecommendedCourse:
                return (obj) => {
                    return obj.isRecommendedCourse === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsSelfPropelledCourse:
                return (obj) => {
                    return obj.isSelfPropelledCourse === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OperationDate:
                return (obj) => {
                    return obj.operationDate === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OuterLink:
                return (obj) => {
                    return obj.outerLink === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ViewCount:
                return (obj) => {
                    return obj.viewCount === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ThemeId:
                return (obj) => {
                    return obj.themeId === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ThemeName:
                return (obj) => {
                    return obj.themeName === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExampleImgPath:
                return (obj) => {
                    return obj.exampleImgPath === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_MajorID:
                return (obj) => {
                    return obj.majorID === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeNameA:
                return (obj) => {
                    return obj.collegeNameA === value;
                };
            case clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vcc_Course]中不存在！(in ${exports.vcc_Course_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vcc_Course_FilterFunByKey = vcc_Course_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function vcc_Course_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvcc_Course = await vcc_Course_GetObjLst_Cache();
        if (arrvcc_Course == null)
            return [];
        let arrvcc_Course_Sel = arrvcc_Course;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvcc_Course_Sel.length == 0)
            return [];
        return arrvcc_Course_Sel.map(x => x.courseId);
    }
    exports.vcc_Course_funcKey = vcc_Course_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vcc_Course_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_GetFirstIDAsync = vcc_Course_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vcc_Course_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_GetFirstID = vcc_Course_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vcc_Course_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
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
                const objvcc_Course = vcc_Course_GetObjFromJsonObj(returnObj);
                return objvcc_Course;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_GetFirstObjAsync = vcc_Course_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvcc_CourseEN_js_1.clsvcc_CourseEN._CurrTabName;
        clsvcc_CourseEN_js_1.clsvcc_CourseEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvcc_CourseEN_js_1.clsvcc_CourseEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseEN_js_1.clsvcc_CourseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvcc_CourseEN_js_1.clsvcc_CourseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvcc_CourseExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvcc_CourseObjLst_T = vcc_Course_GetObjLstByJSONObjLst(arrvcc_CourseExObjLst_Cache);
            return arrvcc_CourseObjLst_T;
        }
        try {
            const arrvcc_CourseExObjLst = await vcc_Course_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvcc_CourseExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseExObjLst.length);
            console.log(strInfo);
            return arrvcc_CourseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vcc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vcc_Course_GetObjLst_ClientCache = vcc_Course_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvcc_CourseEN_js_1.clsvcc_CourseEN._CurrTabName;
        clsvcc_CourseEN_js_1.clsvcc_CourseEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvcc_CourseEN_js_1.clsvcc_CourseEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseEN_js_1.clsvcc_CourseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvcc_CourseEN_js_1.clsvcc_CourseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvcc_CourseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvcc_CourseObjLst_T = vcc_Course_GetObjLstByJSONObjLst(arrvcc_CourseExObjLst_Cache);
            return arrvcc_CourseObjLst_T;
        }
        try {
            const arrvcc_CourseExObjLst = await vcc_Course_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvcc_CourseExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseExObjLst.length);
            console.log(strInfo);
            return arrvcc_CourseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vcc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vcc_Course_GetObjLst_localStorage = vcc_Course_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvcc_CourseEN_js_1.clsvcc_CourseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvcc_CourseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvcc_CourseObjLst_Cache;
        }
        else
            return null;
    }
    exports.vcc_Course_GetObjLst_localStorage_PureCache = vcc_Course_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vcc_Course_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_Course_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_GetObjLstAsync = vcc_Course_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvcc_CourseEN_js_1.clsvcc_CourseEN._CurrTabName;
        clsvcc_CourseEN_js_1.clsvcc_CourseEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvcc_CourseEN_js_1.clsvcc_CourseEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseEN_js_1.clsvcc_CourseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvcc_CourseEN_js_1.clsvcc_CourseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvcc_CourseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvcc_CourseObjLst_T = vcc_Course_GetObjLstByJSONObjLst(arrvcc_CourseExObjLst_Cache);
            return arrvcc_CourseObjLst_T;
        }
        try {
            const arrvcc_CourseExObjLst = await vcc_Course_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvcc_CourseExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseExObjLst.length);
            console.log(strInfo);
            return arrvcc_CourseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vcc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vcc_Course_GetObjLst_sessionStorage = vcc_Course_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvcc_CourseEN_js_1.clsvcc_CourseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvcc_CourseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvcc_CourseObjLst_Cache;
        }
        else
            return null;
    }
    exports.vcc_Course_GetObjLst_sessionStorage_PureCache = vcc_Course_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvcc_CourseObjLst_Cache;
        switch (clsvcc_CourseEN_js_1.clsvcc_CourseEN.CacheModeId) {
            case "04": //sessionStorage
                arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_ClientCache();
                break;
            default:
                arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_ClientCache();
                break;
        }
        const arrvcc_CourseObjLst = vcc_Course_GetObjLstByJSONObjLst(arrvcc_CourseObjLst_Cache);
        return arrvcc_CourseObjLst_Cache;
    }
    exports.vcc_Course_GetObjLst_Cache = vcc_Course_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvcc_CourseObjLst_Cache;
        switch (clsvcc_CourseEN_js_1.clsvcc_CourseEN.CacheModeId) {
            case "04": //sessionStorage
                arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvcc_CourseObjLst_Cache = null;
                break;
            default:
                arrvcc_CourseObjLst_Cache = null;
                break;
        }
        return arrvcc_CourseObjLst_Cache;
    }
    exports.vcc_Course_GetObjLst_PureCache = vcc_Course_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrCourseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vcc_Course_GetSubObjLst_Cache(objvcc_Course_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
        let arrvcc_Course_Sel = arrvcc_CourseObjLst_Cache;
        if (objvcc_Course_Cond.sf_FldComparisonOp == null || objvcc_Course_Cond.sf_FldComparisonOp == "")
            return arrvcc_Course_Sel;
        const dicFldComparisonOp = JSON.parse(objvcc_Course_Cond.sf_FldComparisonOp);
        //console.log("clsvcc_CourseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvcc_Course_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_Course_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvcc_Course_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvcc_Course_Cond), exports.vcc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_Course_GetSubObjLst_Cache = vcc_Course_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCourseId:关键字列表
    * @returns 对象列表
    **/
    async function vcc_Course_GetObjLstByCourseIdLstAsync(arrCourseId) {
        const strThisFuncName = "GetObjLstByCourseIdLstAsync";
        const strAction = "GetObjLstByCourseIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_Course_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_GetObjLstByCourseIdLstAsync = vcc_Course_GetObjLstByCourseIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrCourseIdLst:关键字列表
     * @returns 对象列表
    */
    async function vcc_Course_GetObjLstByCourseIdLst_Cache(arrCourseIdLst) {
        const strThisFuncName = "GetObjLstByCourseIdLst_Cache";
        try {
            const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
            const arrvcc_Course_Sel = arrvcc_CourseObjLst_Cache.filter(x => arrCourseIdLst.indexOf(x.courseId) > -1);
            return arrvcc_Course_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCourseIdLst.join(","), exports.vcc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_Course_GetObjLstByCourseIdLst_Cache = vcc_Course_GetObjLstByCourseIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vcc_Course_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_Course_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_GetTopObjLstAsync = vcc_Course_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_Course_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_Course_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_GetObjLstByRangeAsync = vcc_Course_GetObjLstByRangeAsync;
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
    async function vcc_Course_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_GetObjLstByRange = vcc_Course_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vcc_Course_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
        if (arrvcc_CourseObjLst_Cache.length == 0)
            return arrvcc_CourseObjLst_Cache;
        let arrvcc_Course_Sel = arrvcc_CourseObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvcc_Course_Cond = new clsvcc_CourseEN_js_1.clsvcc_CourseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_Course_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvcc_CourseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_Course_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvcc_Course_Sel.length == 0)
                return arrvcc_Course_Sel;
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
                arrvcc_Course_Sel = arrvcc_Course_Sel.sort(vcc_Course_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvcc_Course_Sel = arrvcc_Course_Sel.sort(objPagerPara.sortFun);
            }
            arrvcc_Course_Sel = arrvcc_Course_Sel.slice(intStart, intEnd);
            return arrvcc_Course_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vcc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_Course_GetObjLstByPager_Cache = vcc_Course_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_Course_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_Course_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_GetObjLstByPagerAsync = vcc_Course_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrCourseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vcc_Course_IsExistRecord_Cache(objvcc_Course_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
        if (arrvcc_CourseObjLst_Cache == null)
            return false;
        let arrvcc_Course_Sel = arrvcc_CourseObjLst_Cache;
        if (objvcc_Course_Cond.sf_FldComparisonOp == null || objvcc_Course_Cond.sf_FldComparisonOp == "")
            return arrvcc_Course_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvcc_Course_Cond.sf_FldComparisonOp);
        //console.log("clsvcc_CourseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvcc_Course_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_Course_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvcc_Course_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvcc_Course_Cond), exports.vcc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vcc_Course_IsExistRecord_Cache = vcc_Course_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vcc_Course_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_IsExistRecordAsync = vcc_Course_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCourseId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vcc_Course_IsExist(strCourseId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_IsExist = vcc_Course_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strCourseId:所给的关键字
     * @returns 对象
    */
    async function vcc_Course_IsExist_Cache(strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
        if (arrvcc_CourseObjLst_Cache == null)
            return false;
        try {
            const arrvcc_Course_Sel = arrvcc_CourseObjLst_Cache.filter(x => x.courseId == strCourseId);
            if (arrvcc_Course_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCourseId, exports.vcc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vcc_Course_IsExist_Cache = vcc_Course_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCourseId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vcc_Course_IsExistAsync(strCourseId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_IsExistAsync = vcc_Course_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vcc_Course_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_GetRecCountByCondAsync = vcc_Course_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvcc_Course_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vcc_Course_GetRecCountByCond_Cache(objvcc_Course_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
        if (arrvcc_CourseObjLst_Cache == null)
            return 0;
        let arrvcc_Course_Sel = arrvcc_CourseObjLst_Cache;
        if (objvcc_Course_Cond.sf_FldComparisonOp == null || objvcc_Course_Cond.sf_FldComparisonOp == "")
            return arrvcc_Course_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvcc_Course_Cond.sf_FldComparisonOp);
        //console.log("clsvcc_CourseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvcc_Course_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_Course_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvcc_Course_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvcc_Course_Cond), exports.vcc_Course_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vcc_Course_GetRecCountByCond_Cache = vcc_Course_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vcc_Course_GetWebApiUrl(strController, strAction) {
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
    exports.vcc_Course_GetWebApiUrl = vcc_Course_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vcc_Course_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvcc_CourseEN_js_1.clsvcc_CourseEN._CurrTabName;
            switch (clsvcc_CourseEN_js_1.clsvcc_CourseEN.CacheModeId) {
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
    exports.vcc_Course_ReFreshThisCache = vcc_Course_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_Course_GetJSONStrByObj(pobjvcc_CourseEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvcc_CourseEN);
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
    exports.vcc_Course_GetJSONStrByObj = vcc_Course_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vcc_Course_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvcc_CourseObjLst = new Array();
        if (strJSON === "") {
            return arrvcc_CourseObjLst;
        }
        try {
            arrvcc_CourseObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvcc_CourseObjLst;
        }
        return arrvcc_CourseObjLst;
    }
    exports.vcc_Course_GetObjLstByJSONStr = vcc_Course_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvcc_CourseObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vcc_Course_GetObjLstByJSONObjLst(arrvcc_CourseObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvcc_CourseObjLst = new Array();
        for (const objInFor of arrvcc_CourseObjLstS) {
            const obj1 = vcc_Course_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvcc_CourseObjLst.push(obj1);
        }
        return arrvcc_CourseObjLst;
    }
    exports.vcc_Course_GetObjLstByJSONObjLst = vcc_Course_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_Course_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvcc_CourseEN = new clsvcc_CourseEN_js_1.clsvcc_CourseEN();
        if (strJSON === "") {
            return pobjvcc_CourseEN;
        }
        try {
            pobjvcc_CourseEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvcc_CourseEN;
        }
        return pobjvcc_CourseEN;
    }
    exports.vcc_Course_GetObjByJSONStr = vcc_Course_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vcc_Course_GetCombineCondition(objvcc_Course_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseId, objvcc_Course_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_LikeCount) == true) {
            const strComparisonOp_LikeCount = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_LikeCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_LikeCount, objvcc_Course_Cond.likeCount, strComparisonOp_LikeCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseCode) == true) {
            const strComparisonOp_CourseCode = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseCode, objvcc_Course_Cond.courseCode, strComparisonOp_CourseCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseDescription) == true) {
            const strComparisonOp_CourseDescription = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseDescription];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseDescription, objvcc_Course_Cond.courseDescription, strComparisonOp_CourseDescription);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseName, objvcc_Course_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseTypeID) == true) {
            const strComparisonOp_CourseTypeID = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseTypeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseTypeID, objvcc_Course_Cond.courseTypeID, strComparisonOp_CourseTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseTypeName) == true) {
            const strComparisonOp_CourseTypeName = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CourseTypeName, objvcc_Course_Cond.courseTypeName, strComparisonOp_CourseTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CreateDate, objvcc_Course_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentTypeId) == true) {
            const strComparisonOp_ExcellentTypeId = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentTypeId, objvcc_Course_Cond.excellentTypeId, strComparisonOp_ExcellentTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentTypeName) == true) {
            const strComparisonOp_ExcellentTypeName = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentTypeName, objvcc_Course_Cond.excellentTypeName, strComparisonOp_ExcellentTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentYear) == true) {
            const strComparisonOp_ExcellentYear = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExcellentYear, objvcc_Course_Cond.excellentYear, strComparisonOp_ExcellentYear);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsBuildingCourse) == true) {
            if (objvcc_Course_Cond.isBuildingCourse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsBuildingCourse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsBuildingCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsDoubleLanguageCourse) == true) {
            if (objvcc_Course_Cond.isDoubleLanguageCourse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsDoubleLanguageCourse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsDoubleLanguageCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsOpen) == true) {
            if (objvcc_Course_Cond.isOpen == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsOpen);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsOpen);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsRecommendedCourse) == true) {
            if (objvcc_Course_Cond.isRecommendedCourse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsRecommendedCourse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsRecommendedCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsSelfPropelledCourse) == true) {
            if (objvcc_Course_Cond.isSelfPropelledCourse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsSelfPropelledCourse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_IsSelfPropelledCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OperationDate) == true) {
            const strComparisonOp_OperationDate = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OperationDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OperationDate, objvcc_Course_Cond.operationDate, strComparisonOp_OperationDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OrderNum, objvcc_Course_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OuterLink) == true) {
            const strComparisonOp_OuterLink = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OuterLink];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_OuterLink, objvcc_Course_Cond.outerLink, strComparisonOp_OuterLink);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ViewCount) == true) {
            const strComparisonOp_ViewCount = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ViewCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ViewCount, objvcc_Course_Cond.viewCount, strComparisonOp_ViewCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ThemeId) == true) {
            const strComparisonOp_ThemeId = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ThemeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ThemeId, objvcc_Course_Cond.themeId, strComparisonOp_ThemeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ThemeName) == true) {
            const strComparisonOp_ThemeName = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ThemeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ThemeName, objvcc_Course_Cond.themeName, strComparisonOp_ThemeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExampleImgPath) == true) {
            const strComparisonOp_ExampleImgPath = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExampleImgPath];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_ExampleImgPath, objvcc_Course_Cond.exampleImgPath, strComparisonOp_ExampleImgPath);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_id_XzMajor, objvcc_Course_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_MajorID) == true) {
            const strComparisonOp_MajorID = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_MajorID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_MajorID, objvcc_Course_Cond.majorID, strComparisonOp_MajorID);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_MajorName, objvcc_Course_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_id_XzCollege, objvcc_Course_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeID, objvcc_Course_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeName, objvcc_Course_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeNameA) == true) {
            const strComparisonOp_CollegeNameA = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_CollegeNameA, objvcc_Course_Cond.collegeNameA, strComparisonOp_CollegeNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseEN_js_1.clsvcc_CourseEN.con_Memo, objvcc_Course_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vcc_Course_GetCombineCondition = vcc_Course_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvcc_CourseENS:源对象
     * @param objvcc_CourseENT:目标对象
    */
    function vcc_Course_CopyObjTo(objvcc_CourseENS, objvcc_CourseENT) {
        objvcc_CourseENT.courseId = objvcc_CourseENS.courseId; //课程Id
        objvcc_CourseENT.likeCount = objvcc_CourseENS.likeCount; //LikeCount
        objvcc_CourseENT.courseCode = objvcc_CourseENS.courseCode; //课程代码
        objvcc_CourseENT.courseDescription = objvcc_CourseENS.courseDescription; //课程描述
        objvcc_CourseENT.courseName = objvcc_CourseENS.courseName; //课程名称
        objvcc_CourseENT.courseTypeID = objvcc_CourseENS.courseTypeID; //课程类型ID
        objvcc_CourseENT.courseTypeName = objvcc_CourseENS.courseTypeName; //课程类型名称
        objvcc_CourseENT.createDate = objvcc_CourseENS.createDate; //建立日期
        objvcc_CourseENT.excellentTypeId = objvcc_CourseENS.excellentTypeId; //精品课程类型Id
        objvcc_CourseENT.excellentTypeName = objvcc_CourseENS.excellentTypeName; //精品课程类型名称
        objvcc_CourseENT.excellentYear = objvcc_CourseENS.excellentYear; //课程年份
        objvcc_CourseENT.isBuildingCourse = objvcc_CourseENS.isBuildingCourse; //是否已建设课程
        objvcc_CourseENT.isDoubleLanguageCourse = objvcc_CourseENS.isDoubleLanguageCourse; //是否双语课程
        objvcc_CourseENT.isOpen = objvcc_CourseENS.isOpen; //是否公开
        objvcc_CourseENT.isRecommendedCourse = objvcc_CourseENS.isRecommendedCourse; //是否推荐课程
        objvcc_CourseENT.isSelfPropelledCourse = objvcc_CourseENS.isSelfPropelledCourse; //是否自荐课程
        objvcc_CourseENT.operationDate = objvcc_CourseENS.operationDate; //操作时间
        objvcc_CourseENT.orderNum = objvcc_CourseENS.orderNum; //序号
        objvcc_CourseENT.outerLink = objvcc_CourseENS.outerLink; //外链地址
        objvcc_CourseENT.viewCount = objvcc_CourseENS.viewCount; //浏览量
        objvcc_CourseENT.themeId = objvcc_CourseENS.themeId; //主题Id
        objvcc_CourseENT.themeName = objvcc_CourseENS.themeName; //主题名
        objvcc_CourseENT.exampleImgPath = objvcc_CourseENS.exampleImgPath; //示例图路径
        objvcc_CourseENT.id_XzMajor = objvcc_CourseENS.id_XzMajor; //专业流水号
        objvcc_CourseENT.majorID = objvcc_CourseENS.majorID; //专业ID
        objvcc_CourseENT.majorName = objvcc_CourseENS.majorName; //专业名称
        objvcc_CourseENT.id_XzCollege = objvcc_CourseENS.id_XzCollege; //学院流水号
        objvcc_CourseENT.collegeID = objvcc_CourseENS.collegeID; //学院ID
        objvcc_CourseENT.collegeName = objvcc_CourseENS.collegeName; //学院名称
        objvcc_CourseENT.collegeNameA = objvcc_CourseENS.collegeNameA; //学院名称简写
        objvcc_CourseENT.memo = objvcc_CourseENS.memo; //备注
    }
    exports.vcc_Course_CopyObjTo = vcc_Course_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvcc_CourseENS:源对象
     * @param objvcc_CourseENT:目标对象
    */
    function vcc_Course_GetObjFromJsonObj(objvcc_CourseENS) {
        const objvcc_CourseENT = new clsvcc_CourseEN_js_1.clsvcc_CourseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_CourseENT, objvcc_CourseENS);
        return objvcc_CourseENT;
    }
    exports.vcc_Course_GetObjFromJsonObj = vcc_Course_GetObjFromJsonObj;
});
