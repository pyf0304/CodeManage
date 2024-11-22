/**
* 类名:clsvcc_CourseExWApi
* 表名:vcc_CourseEx(01120213)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:27
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:课程管理(CourseManage)
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
        define(["require", "exports", "axios", "../../L0_Entity/CourseManage/clsvcc_CourseExEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vcc_CourseEx_GetObjFromJsonObj = exports.vcc_CourseEx_CopyObjTo = exports.vcc_CourseEx_GetCombineCondition = exports.vcc_CourseEx_GetObjByJSONStr = exports.vcc_CourseEx_GetObjLstByJSONObjLst = exports.vcc_CourseEx_GetObjLstByJSONStr = exports.vcc_CourseEx_GetJSONStrByObj = exports.vcc_CourseEx_GetWebApiUrl = exports.vcc_CourseEx_GetRecCountByCondAsync = exports.vcc_CourseEx_IsExistAsync = exports.vcc_CourseEx_IsExist = exports.vcc_CourseEx_IsExistRecordAsync = exports.vcc_CourseEx_GetObjLstByPagerAsync = exports.vcc_CourseEx_GetObjLstByRange = exports.vcc_CourseEx_GetObjLstByRangeAsync = exports.vcc_CourseEx_GetTopObjLstAsync = exports.vcc_CourseEx_GetObjLstByCourseIdLstAsync = exports.vcc_CourseEx_GetObjLstAsync = exports.vcc_CourseEx_GetFirstObjAsync = exports.vcc_CourseEx_GetFirstID = exports.vcc_CourseEx_GetFirstIDAsync = exports.vcc_CourseEx_FilterFunByKey = exports.vcc_CourseEx_SortFunByKey = exports.vcc_CourseEx_SortFun_Defa_2Fld = exports.vcc_CourseEx_SortFun_Defa = exports.vcc_CourseEx_GetObjByCourseIdAsync = exports.vcc_CourseEx_ConstructorName = exports.vcc_CourseEx_Controller = void 0;
    /**
     * v课程Ex(vcc_CourseEx)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvcc_CourseExEN_js_1 = require("../../L0_Entity/CourseManage/clsvcc_CourseExEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vcc_CourseEx_Controller = "vcc_CourseExApi";
    exports.vcc_CourseEx_ConstructorName = "vcc_CourseEx";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCourseId:关键字
    * @returns 对象
    **/
    async function vcc_CourseEx_GetObjByCourseIdAsync(strCourseId) {
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
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvcc_CourseEx = vcc_CourseEx_GetObjFromJsonObj(returnObj);
                return objvcc_CourseEx;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_GetObjByCourseIdAsync = vcc_CourseEx_GetObjByCourseIdAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseEx_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.courseId.localeCompare(b.courseId);
    }
    exports.vcc_CourseEx_SortFun_Defa = vcc_CourseEx_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseEx_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.likeCount == b.likeCount)
            return a.courseCode.localeCompare(b.courseCode);
        else
            return a.likeCount - b.likeCount;
    }
    exports.vcc_CourseEx_SortFun_Defa_2Fld = vcc_CourseEx_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseId:
                    return (a, b) => {
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_LikeCount:
                    return (a, b) => {
                        return a.likeCount - b.likeCount;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseCode:
                    return (a, b) => {
                        return a.courseCode.localeCompare(b.courseCode);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseDescription:
                    return (a, b) => {
                        return a.courseDescription.localeCompare(b.courseDescription);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseName:
                    return (a, b) => {
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseTypeID:
                    return (a, b) => {
                        return a.courseTypeID.localeCompare(b.courseTypeID);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseTypeName:
                    return (a, b) => {
                        return a.courseTypeName.localeCompare(b.courseTypeName);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CreateDate:
                    return (a, b) => {
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentTypeId:
                    return (a, b) => {
                        return a.excellentTypeId.localeCompare(b.excellentTypeId);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentTypeName:
                    return (a, b) => {
                        return a.excellentTypeName.localeCompare(b.excellentTypeName);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentYear:
                    return (a, b) => {
                        return a.excellentYear - b.excellentYear;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsBuildingCourse:
                    return (a, b) => {
                        if (a.isBuildingCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsDoubleLanguageCourse:
                    return (a, b) => {
                        if (a.isDoubleLanguageCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsOpen:
                    return (a, b) => {
                        if (a.isOpen == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsRecommendedCourse:
                    return (a, b) => {
                        if (a.isRecommendedCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsSelfPropelledCourse:
                    return (a, b) => {
                        if (a.isSelfPropelledCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OperationDate:
                    return (a, b) => {
                        return a.operationDate.localeCompare(b.operationDate);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OuterLink:
                    return (a, b) => {
                        return a.outerLink.localeCompare(b.outerLink);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ViewCount:
                    return (a, b) => {
                        return a.viewCount - b.viewCount;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ThemeId:
                    return (a, b) => {
                        return a.themeId.localeCompare(b.themeId);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ThemeName:
                    return (a, b) => {
                        return a.themeName.localeCompare(b.themeName);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExampleImgPath:
                    return (a, b) => {
                        return a.exampleImgPath.localeCompare(b.exampleImgPath);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_MajorID:
                    return (a, b) => {
                        return a.majorID.localeCompare(b.majorID);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeID:
                    return (a, b) => {
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeNameA:
                    return (a, b) => {
                        return a.collegeNameA.localeCompare(b.collegeNameA);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_QuestionNum:
                    return (a, b) => {
                        return a.questionNum - b.questionNum;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_KnowledgesNum:
                    return (a, b) => {
                        return a.knowledgesNum - b.knowledgesNum;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_TeacherNum:
                    return (a, b) => {
                        return a.teacherNum - b.teacherNum;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ChapterNum:
                    return (a, b) => {
                        return a.chapterNum - b.chapterNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseEx]中不存在！(in ${exports.vcc_CourseEx_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseId:
                    return (a, b) => {
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_LikeCount:
                    return (a, b) => {
                        return b.likeCount - a.likeCount;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseCode:
                    return (a, b) => {
                        return b.courseCode.localeCompare(a.courseCode);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseDescription:
                    return (a, b) => {
                        return b.courseDescription.localeCompare(a.courseDescription);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseName:
                    return (a, b) => {
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseTypeID:
                    return (a, b) => {
                        return b.courseTypeID.localeCompare(a.courseTypeID);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseTypeName:
                    return (a, b) => {
                        return b.courseTypeName.localeCompare(a.courseTypeName);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CreateDate:
                    return (a, b) => {
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentTypeId:
                    return (a, b) => {
                        return b.excellentTypeId.localeCompare(a.excellentTypeId);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentTypeName:
                    return (a, b) => {
                        return b.excellentTypeName.localeCompare(a.excellentTypeName);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentYear:
                    return (a, b) => {
                        return b.excellentYear - a.excellentYear;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsBuildingCourse:
                    return (a, b) => {
                        if (b.isBuildingCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsDoubleLanguageCourse:
                    return (a, b) => {
                        if (b.isDoubleLanguageCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsOpen:
                    return (a, b) => {
                        if (b.isOpen == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsRecommendedCourse:
                    return (a, b) => {
                        if (b.isRecommendedCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsSelfPropelledCourse:
                    return (a, b) => {
                        if (b.isSelfPropelledCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OperationDate:
                    return (a, b) => {
                        return b.operationDate.localeCompare(a.operationDate);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OuterLink:
                    return (a, b) => {
                        return b.outerLink.localeCompare(a.outerLink);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ViewCount:
                    return (a, b) => {
                        return b.viewCount - a.viewCount;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ThemeId:
                    return (a, b) => {
                        return b.themeId.localeCompare(a.themeId);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ThemeName:
                    return (a, b) => {
                        return b.themeName.localeCompare(a.themeName);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExampleImgPath:
                    return (a, b) => {
                        return b.exampleImgPath.localeCompare(a.exampleImgPath);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_MajorID:
                    return (a, b) => {
                        return b.majorID.localeCompare(a.majorID);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeID:
                    return (a, b) => {
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeNameA:
                    return (a, b) => {
                        return b.collegeNameA.localeCompare(a.collegeNameA);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_QuestionNum:
                    return (a, b) => {
                        return b.questionNum - a.questionNum;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_KnowledgesNum:
                    return (a, b) => {
                        return b.knowledgesNum - a.knowledgesNum;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_TeacherNum:
                    return (a, b) => {
                        return b.teacherNum - a.teacherNum;
                    };
                case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ChapterNum:
                    return (a, b) => {
                        return b.chapterNum - a.chapterNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseEx]中不存在！(in ${exports.vcc_CourseEx_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vcc_CourseEx_SortFunByKey = vcc_CourseEx_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vcc_CourseEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_LikeCount:
                return (obj) => {
                    return obj.likeCount === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseCode:
                return (obj) => {
                    return obj.courseCode === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseDescription:
                return (obj) => {
                    return obj.courseDescription === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseTypeID:
                return (obj) => {
                    return obj.courseTypeID === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseTypeName:
                return (obj) => {
                    return obj.courseTypeName === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentTypeId:
                return (obj) => {
                    return obj.excellentTypeId === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentTypeName:
                return (obj) => {
                    return obj.excellentTypeName === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentYear:
                return (obj) => {
                    return obj.excellentYear === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsBuildingCourse:
                return (obj) => {
                    return obj.isBuildingCourse === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsDoubleLanguageCourse:
                return (obj) => {
                    return obj.isDoubleLanguageCourse === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsOpen:
                return (obj) => {
                    return obj.isOpen === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsRecommendedCourse:
                return (obj) => {
                    return obj.isRecommendedCourse === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsSelfPropelledCourse:
                return (obj) => {
                    return obj.isSelfPropelledCourse === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OperationDate:
                return (obj) => {
                    return obj.operationDate === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OuterLink:
                return (obj) => {
                    return obj.outerLink === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ViewCount:
                return (obj) => {
                    return obj.viewCount === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ThemeId:
                return (obj) => {
                    return obj.themeId === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ThemeName:
                return (obj) => {
                    return obj.themeName === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExampleImgPath:
                return (obj) => {
                    return obj.exampleImgPath === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_MajorID:
                return (obj) => {
                    return obj.majorID === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeNameA:
                return (obj) => {
                    return obj.collegeNameA === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_QuestionNum:
                return (obj) => {
                    return obj.questionNum === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_KnowledgesNum:
                return (obj) => {
                    return obj.knowledgesNum === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_TeacherNum:
                return (obj) => {
                    return obj.teacherNum === value;
                };
            case clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ChapterNum:
                return (obj) => {
                    return obj.chapterNum === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseEx]中不存在！(in ${exports.vcc_CourseEx_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vcc_CourseEx_FilterFunByKey = vcc_CourseEx_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vcc_CourseEx_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_GetFirstIDAsync = vcc_CourseEx_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vcc_CourseEx_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_GetFirstID = vcc_CourseEx_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vcc_CourseEx_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvcc_CourseEx = vcc_CourseEx_GetObjFromJsonObj(returnObj);
                return objvcc_CourseEx;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_GetFirstObjAsync = vcc_CourseEx_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vcc_CourseEx_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseEx_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_GetObjLstAsync = vcc_CourseEx_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCourseId:关键字列表
    * @returns 对象列表
    **/
    async function vcc_CourseEx_GetObjLstByCourseIdLstAsync(arrCourseId) {
        const strThisFuncName = "GetObjLstByCourseIdLstAsync";
        const strAction = "GetObjLstByCourseIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseEx_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_GetObjLstByCourseIdLstAsync = vcc_CourseEx_GetObjLstByCourseIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vcc_CourseEx_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseEx_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_GetTopObjLstAsync = vcc_CourseEx_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_CourseEx_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseEx_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_GetObjLstByRangeAsync = vcc_CourseEx_GetObjLstByRangeAsync;
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
    async function vcc_CourseEx_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_GetObjLstByRange = vcc_CourseEx_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_CourseEx_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseEx_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_GetObjLstByPagerAsync = vcc_CourseEx_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vcc_CourseEx_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_IsExistRecordAsync = vcc_CourseEx_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCourseId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vcc_CourseEx_IsExist(strCourseId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_IsExist = vcc_CourseEx_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCourseId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vcc_CourseEx_IsExistAsync(strCourseId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_IsExistAsync = vcc_CourseEx_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vcc_CourseEx_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseEx_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseEx_GetRecCountByCondAsync = vcc_CourseEx_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vcc_CourseEx_GetWebApiUrl(strController, strAction) {
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
    exports.vcc_CourseEx_GetWebApiUrl = vcc_CourseEx_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_CourseEx_GetJSONStrByObj(pobjvcc_CourseExEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvcc_CourseExEN);
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
    exports.vcc_CourseEx_GetJSONStrByObj = vcc_CourseEx_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vcc_CourseEx_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvcc_CourseExObjLst = new Array();
        if (strJSON === "") {
            return arrvcc_CourseExObjLst;
        }
        try {
            arrvcc_CourseExObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvcc_CourseExObjLst;
        }
        return arrvcc_CourseExObjLst;
    }
    exports.vcc_CourseEx_GetObjLstByJSONStr = vcc_CourseEx_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvcc_CourseExObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vcc_CourseEx_GetObjLstByJSONObjLst(arrvcc_CourseExObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvcc_CourseExObjLst = new Array();
        for (const objInFor of arrvcc_CourseExObjLstS) {
            const obj1 = vcc_CourseEx_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvcc_CourseExObjLst.push(obj1);
        }
        return arrvcc_CourseExObjLst;
    }
    exports.vcc_CourseEx_GetObjLstByJSONObjLst = vcc_CourseEx_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_CourseEx_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvcc_CourseExEN = new clsvcc_CourseExEN_js_1.clsvcc_CourseExEN();
        if (strJSON === "") {
            return pobjvcc_CourseExEN;
        }
        try {
            pobjvcc_CourseExEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvcc_CourseExEN;
        }
        return pobjvcc_CourseExEN;
    }
    exports.vcc_CourseEx_GetObjByJSONStr = vcc_CourseEx_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vcc_CourseEx_GetCombineCondition(objvcc_CourseEx_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseId, objvcc_CourseEx_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_LikeCount) == true) {
            const strComparisonOp_LikeCount = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_LikeCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_LikeCount, objvcc_CourseEx_Cond.likeCount, strComparisonOp_LikeCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseCode) == true) {
            const strComparisonOp_CourseCode = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseCode, objvcc_CourseEx_Cond.courseCode, strComparisonOp_CourseCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseDescription) == true) {
            const strComparisonOp_CourseDescription = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseDescription];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseDescription, objvcc_CourseEx_Cond.courseDescription, strComparisonOp_CourseDescription);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseName, objvcc_CourseEx_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseTypeID) == true) {
            const strComparisonOp_CourseTypeID = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseTypeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseTypeID, objvcc_CourseEx_Cond.courseTypeID, strComparisonOp_CourseTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseTypeName) == true) {
            const strComparisonOp_CourseTypeName = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CourseTypeName, objvcc_CourseEx_Cond.courseTypeName, strComparisonOp_CourseTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CreateDate, objvcc_CourseEx_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentTypeId) == true) {
            const strComparisonOp_ExcellentTypeId = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentTypeId, objvcc_CourseEx_Cond.excellentTypeId, strComparisonOp_ExcellentTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentTypeName) == true) {
            const strComparisonOp_ExcellentTypeName = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentTypeName, objvcc_CourseEx_Cond.excellentTypeName, strComparisonOp_ExcellentTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentYear) == true) {
            const strComparisonOp_ExcellentYear = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExcellentYear, objvcc_CourseEx_Cond.excellentYear, strComparisonOp_ExcellentYear);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsBuildingCourse) == true) {
            if (objvcc_CourseEx_Cond.isBuildingCourse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsBuildingCourse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsBuildingCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsDoubleLanguageCourse) == true) {
            if (objvcc_CourseEx_Cond.isDoubleLanguageCourse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsDoubleLanguageCourse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsDoubleLanguageCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsOpen) == true) {
            if (objvcc_CourseEx_Cond.isOpen == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsOpen);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsOpen);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsRecommendedCourse) == true) {
            if (objvcc_CourseEx_Cond.isRecommendedCourse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsRecommendedCourse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsRecommendedCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsSelfPropelledCourse) == true) {
            if (objvcc_CourseEx_Cond.isSelfPropelledCourse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsSelfPropelledCourse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_IsSelfPropelledCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OperationDate) == true) {
            const strComparisonOp_OperationDate = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OperationDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OperationDate, objvcc_CourseEx_Cond.operationDate, strComparisonOp_OperationDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OrderNum, objvcc_CourseEx_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OuterLink) == true) {
            const strComparisonOp_OuterLink = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OuterLink];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_OuterLink, objvcc_CourseEx_Cond.outerLink, strComparisonOp_OuterLink);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ViewCount) == true) {
            const strComparisonOp_ViewCount = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ViewCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ViewCount, objvcc_CourseEx_Cond.viewCount, strComparisonOp_ViewCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ThemeId) == true) {
            const strComparisonOp_ThemeId = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ThemeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ThemeId, objvcc_CourseEx_Cond.themeId, strComparisonOp_ThemeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ThemeName) == true) {
            const strComparisonOp_ThemeName = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ThemeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ThemeName, objvcc_CourseEx_Cond.themeName, strComparisonOp_ThemeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExampleImgPath) == true) {
            const strComparisonOp_ExampleImgPath = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExampleImgPath];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ExampleImgPath, objvcc_CourseEx_Cond.exampleImgPath, strComparisonOp_ExampleImgPath);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_id_XzMajor, objvcc_CourseEx_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_MajorID) == true) {
            const strComparisonOp_MajorID = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_MajorID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_MajorID, objvcc_CourseEx_Cond.majorID, strComparisonOp_MajorID);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_MajorName, objvcc_CourseEx_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_id_XzCollege, objvcc_CourseEx_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeID, objvcc_CourseEx_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeName, objvcc_CourseEx_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeNameA) == true) {
            const strComparisonOp_CollegeNameA = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_CollegeNameA, objvcc_CourseEx_Cond.collegeNameA, strComparisonOp_CollegeNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_Memo, objvcc_CourseEx_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_QuestionNum) == true) {
            const strComparisonOp_QuestionNum = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_QuestionNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_QuestionNum, objvcc_CourseEx_Cond.questionNum, strComparisonOp_QuestionNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_KnowledgesNum) == true) {
            const strComparisonOp_KnowledgesNum = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_KnowledgesNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_KnowledgesNum, objvcc_CourseEx_Cond.knowledgesNum, strComparisonOp_KnowledgesNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_TeacherNum) == true) {
            const strComparisonOp_TeacherNum = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_TeacherNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_TeacherNum, objvcc_CourseEx_Cond.teacherNum, strComparisonOp_TeacherNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ChapterNum) == true) {
            const strComparisonOp_ChapterNum = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ChapterNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExEN_js_1.clsvcc_CourseExEN.con_ChapterNum, objvcc_CourseEx_Cond.chapterNum, strComparisonOp_ChapterNum);
        }
        return strWhereCond;
    }
    exports.vcc_CourseEx_GetCombineCondition = vcc_CourseEx_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvcc_CourseExENS:源对象
     * @param objvcc_CourseExENT:目标对象
    */
    function vcc_CourseEx_CopyObjTo(objvcc_CourseExENS, objvcc_CourseExENT) {
        objvcc_CourseExENT.courseId = objvcc_CourseExENS.courseId; //课程Id
        objvcc_CourseExENT.likeCount = objvcc_CourseExENS.likeCount; //LikeCount
        objvcc_CourseExENT.courseCode = objvcc_CourseExENS.courseCode; //课程代码
        objvcc_CourseExENT.courseDescription = objvcc_CourseExENS.courseDescription; //课程描述
        objvcc_CourseExENT.courseName = objvcc_CourseExENS.courseName; //课程名称
        objvcc_CourseExENT.courseTypeID = objvcc_CourseExENS.courseTypeID; //课程类型ID
        objvcc_CourseExENT.courseTypeName = objvcc_CourseExENS.courseTypeName; //课程类型名称
        objvcc_CourseExENT.createDate = objvcc_CourseExENS.createDate; //建立日期
        objvcc_CourseExENT.excellentTypeId = objvcc_CourseExENS.excellentTypeId; //精品课程类型Id
        objvcc_CourseExENT.excellentTypeName = objvcc_CourseExENS.excellentTypeName; //精品课程类型名称
        objvcc_CourseExENT.excellentYear = objvcc_CourseExENS.excellentYear; //课程年份
        objvcc_CourseExENT.isBuildingCourse = objvcc_CourseExENS.isBuildingCourse; //是否已建设课程
        objvcc_CourseExENT.isDoubleLanguageCourse = objvcc_CourseExENS.isDoubleLanguageCourse; //是否双语课程
        objvcc_CourseExENT.isOpen = objvcc_CourseExENS.isOpen; //是否公开
        objvcc_CourseExENT.isRecommendedCourse = objvcc_CourseExENS.isRecommendedCourse; //是否推荐课程
        objvcc_CourseExENT.isSelfPropelledCourse = objvcc_CourseExENS.isSelfPropelledCourse; //是否自荐课程
        objvcc_CourseExENT.operationDate = objvcc_CourseExENS.operationDate; //操作时间
        objvcc_CourseExENT.orderNum = objvcc_CourseExENS.orderNum; //序号
        objvcc_CourseExENT.outerLink = objvcc_CourseExENS.outerLink; //外链地址
        objvcc_CourseExENT.viewCount = objvcc_CourseExENS.viewCount; //浏览量
        objvcc_CourseExENT.themeId = objvcc_CourseExENS.themeId; //主题Id
        objvcc_CourseExENT.themeName = objvcc_CourseExENS.themeName; //主题名
        objvcc_CourseExENT.exampleImgPath = objvcc_CourseExENS.exampleImgPath; //示例图路径
        objvcc_CourseExENT.id_XzMajor = objvcc_CourseExENS.id_XzMajor; //专业流水号
        objvcc_CourseExENT.majorID = objvcc_CourseExENS.majorID; //专业ID
        objvcc_CourseExENT.majorName = objvcc_CourseExENS.majorName; //专业名称
        objvcc_CourseExENT.id_XzCollege = objvcc_CourseExENS.id_XzCollege; //学院流水号
        objvcc_CourseExENT.collegeID = objvcc_CourseExENS.collegeID; //学院ID
        objvcc_CourseExENT.collegeName = objvcc_CourseExENS.collegeName; //学院名称
        objvcc_CourseExENT.collegeNameA = objvcc_CourseExENS.collegeNameA; //学院名称简写
        objvcc_CourseExENT.memo = objvcc_CourseExENS.memo; //备注
        objvcc_CourseExENT.questionNum = objvcc_CourseExENS.questionNum; //题目数
        objvcc_CourseExENT.knowledgesNum = objvcc_CourseExENS.knowledgesNum; //知识点数
        objvcc_CourseExENT.teacherNum = objvcc_CourseExENS.teacherNum; //教师数
        objvcc_CourseExENT.chapterNum = objvcc_CourseExENS.chapterNum; //章节数
    }
    exports.vcc_CourseEx_CopyObjTo = vcc_CourseEx_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvcc_CourseExENS:源对象
     * @param objvcc_CourseExENT:目标对象
    */
    function vcc_CourseEx_GetObjFromJsonObj(objvcc_CourseExENS) {
        const objvcc_CourseExENT = new clsvcc_CourseExEN_js_1.clsvcc_CourseExEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_CourseExENT, objvcc_CourseExENS);
        return objvcc_CourseExENT;
    }
    exports.vcc_CourseEx_GetObjFromJsonObj = vcc_CourseEx_GetObjFromJsonObj;
});
