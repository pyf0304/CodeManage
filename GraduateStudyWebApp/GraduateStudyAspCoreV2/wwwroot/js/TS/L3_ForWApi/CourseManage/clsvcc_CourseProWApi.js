/**
* 类名:clsvcc_CourseProWApi
* 表名:vcc_CoursePro(01120213)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:46:48
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
        define(["require", "exports", "axios", "../../L0_Entity/CourseManage/clsvcc_CourseProEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vcc_CoursePro_GetObjFromJsonObj = exports.vcc_CoursePro_CopyObjTo = exports.vcc_CoursePro_GetCombineCondition = exports.vcc_CoursePro_GetObjByJSONStr = exports.vcc_CoursePro_GetObjLstByJSONObjLst = exports.vcc_CoursePro_GetObjLstByJSONStr = exports.vcc_CoursePro_GetJSONStrByObj = exports.vcc_CoursePro_GetWebApiUrl = exports.vcc_CoursePro_GetRecCountByCondAsync = exports.vcc_CoursePro_IsExistAsync = exports.vcc_CoursePro_IsExist = exports.vcc_CoursePro_IsExistRecordAsync = exports.vcc_CoursePro_GetObjLstByPagerAsync = exports.vcc_CoursePro_GetObjLstByRange = exports.vcc_CoursePro_GetObjLstByRangeAsync = exports.vcc_CoursePro_GetTopObjLstAsync = exports.vcc_CoursePro_GetObjLstByCourseIdLstAsync = exports.vcc_CoursePro_GetObjLstAsync = exports.vcc_CoursePro_GetFirstObjAsync = exports.vcc_CoursePro_GetFirstID = exports.vcc_CoursePro_GetFirstIDAsync = exports.vcc_CoursePro_FilterFunByKey = exports.vcc_CoursePro_SortFunByKey = exports.vcc_CoursePro_SortFun_Defa_2Fld = exports.vcc_CoursePro_SortFun_Defa = exports.vcc_CoursePro_GetObjByCourseIdAsync = exports.vcc_CoursePro_ConstructorName = exports.vcc_CoursePro_Controller = void 0;
    /**
     * v课程Pro(vcc_CoursePro)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvcc_CourseProEN_js_1 = require("../../L0_Entity/CourseManage/clsvcc_CourseProEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vcc_CoursePro_Controller = "vcc_CourseProApi";
    exports.vcc_CoursePro_ConstructorName = "vcc_CoursePro";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCourseId:关键字
    * @returns 对象
    **/
    async function vcc_CoursePro_GetObjByCourseIdAsync(strCourseId) {
        const strThisFuncName = "GetObjByCourseIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId]不能为空！(In clsvcc_CourseProWApi.GetObjByCourseIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsvcc_CourseProWApi.GetObjByCourseIdAsync)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCourseId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
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
                const objvcc_CoursePro = vcc_CoursePro_GetObjFromJsonObj(returnObj);
                return objvcc_CoursePro;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_GetObjByCourseIdAsync = vcc_CoursePro_GetObjByCourseIdAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CoursePro_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.courseId.localeCompare(b.courseId);
    }
    exports.vcc_CoursePro_SortFun_Defa = vcc_CoursePro_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CoursePro_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.likeCount == b.likeCount)
            return a.courseCode.localeCompare(b.courseCode);
        else
            return a.likeCount - b.likeCount;
    }
    exports.vcc_CoursePro_SortFun_Defa_2Fld = vcc_CoursePro_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CoursePro_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseId:
                    return (a, b) => {
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_LikeCount:
                    return (a, b) => {
                        return a.likeCount - b.likeCount;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseCode:
                    return (a, b) => {
                        if (a.courseCode == null)
                            return -1;
                        if (b.courseCode == null)
                            return 1;
                        return a.courseCode.localeCompare(b.courseCode);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseDescription:
                    return (a, b) => {
                        if (a.courseDescription == null)
                            return -1;
                        if (b.courseDescription == null)
                            return 1;
                        return a.courseDescription.localeCompare(b.courseDescription);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseName:
                    return (a, b) => {
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseTypeID:
                    return (a, b) => {
                        if (a.courseTypeID == null)
                            return -1;
                        if (b.courseTypeID == null)
                            return 1;
                        return a.courseTypeID.localeCompare(b.courseTypeID);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseTypeName:
                    return (a, b) => {
                        if (a.courseTypeName == null)
                            return -1;
                        if (b.courseTypeName == null)
                            return 1;
                        return a.courseTypeName.localeCompare(b.courseTypeName);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentTypeId:
                    return (a, b) => {
                        if (a.excellentTypeId == null)
                            return -1;
                        if (b.excellentTypeId == null)
                            return 1;
                        return a.excellentTypeId.localeCompare(b.excellentTypeId);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentTypeName:
                    return (a, b) => {
                        if (a.excellentTypeName == null)
                            return -1;
                        if (b.excellentTypeName == null)
                            return 1;
                        return a.excellentTypeName.localeCompare(b.excellentTypeName);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentYear:
                    return (a, b) => {
                        return a.excellentYear - b.excellentYear;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsBuildingCourse:
                    return (a, b) => {
                        if (a.isBuildingCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsDoubleLanguageCourse:
                    return (a, b) => {
                        if (a.isDoubleLanguageCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsOpen:
                    return (a, b) => {
                        if (a.isOpen == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsRecommendedCourse:
                    return (a, b) => {
                        if (a.isRecommendedCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsSelfPropelledCourse:
                    return (a, b) => {
                        if (a.isSelfPropelledCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OperationDate:
                    return (a, b) => {
                        if (a.operationDate == null)
                            return -1;
                        if (b.operationDate == null)
                            return 1;
                        return a.operationDate.localeCompare(b.operationDate);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OuterLink:
                    return (a, b) => {
                        if (a.outerLink == null)
                            return -1;
                        if (b.outerLink == null)
                            return 1;
                        return a.outerLink.localeCompare(b.outerLink);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ViewCount:
                    return (a, b) => {
                        return a.viewCount - b.viewCount;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ThemeId:
                    return (a, b) => {
                        if (a.themeId == null)
                            return -1;
                        if (b.themeId == null)
                            return 1;
                        return a.themeId.localeCompare(b.themeId);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ThemeName:
                    return (a, b) => {
                        if (a.themeName == null)
                            return -1;
                        if (b.themeName == null)
                            return 1;
                        return a.themeName.localeCompare(b.themeName);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExampleImgPath:
                    return (a, b) => {
                        if (a.exampleImgPath == null)
                            return -1;
                        if (b.exampleImgPath == null)
                            return 1;
                        return a.exampleImgPath.localeCompare(b.exampleImgPath);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_MajorID:
                    return (a, b) => {
                        if (a.majorID == null)
                            return -1;
                        if (b.majorID == null)
                            return 1;
                        return a.majorID.localeCompare(b.majorID);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_MajorName:
                    return (a, b) => {
                        if (a.majorName == null)
                            return -1;
                        if (b.majorName == null)
                            return 1;
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeID:
                    return (a, b) => {
                        if (a.collegeID == null)
                            return -1;
                        if (b.collegeID == null)
                            return 1;
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeName:
                    return (a, b) => {
                        if (a.collegeName == null)
                            return -1;
                        if (b.collegeName == null)
                            return 1;
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeNameA:
                    return (a, b) => {
                        if (a.collegeNameA == null)
                            return -1;
                        if (b.collegeNameA == null)
                            return 1;
                        return a.collegeNameA.localeCompare(b.collegeNameA);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_QuestionNum:
                    return (a, b) => {
                        return a.questionNum - b.questionNum;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_KnowledgesNum:
                    return (a, b) => {
                        return a.knowledgesNum - b.knowledgesNum;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_TeacherNum:
                    return (a, b) => {
                        return a.teacherNum - b.teacherNum;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ChapterNum:
                    return (a, b) => {
                        return a.chapterNum - b.chapterNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_CoursePro]中不存在！(in ${exports.vcc_CoursePro_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseId:
                    return (a, b) => {
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_LikeCount:
                    return (a, b) => {
                        return b.likeCount - a.likeCount;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseCode:
                    return (a, b) => {
                        if (b.courseCode == null)
                            return -1;
                        if (a.courseCode == null)
                            return 1;
                        return b.courseCode.localeCompare(a.courseCode);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseDescription:
                    return (a, b) => {
                        if (b.courseDescription == null)
                            return -1;
                        if (a.courseDescription == null)
                            return 1;
                        return b.courseDescription.localeCompare(a.courseDescription);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseName:
                    return (a, b) => {
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseTypeID:
                    return (a, b) => {
                        if (b.courseTypeID == null)
                            return -1;
                        if (a.courseTypeID == null)
                            return 1;
                        return b.courseTypeID.localeCompare(a.courseTypeID);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseTypeName:
                    return (a, b) => {
                        if (b.courseTypeName == null)
                            return -1;
                        if (a.courseTypeName == null)
                            return 1;
                        return b.courseTypeName.localeCompare(a.courseTypeName);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentTypeId:
                    return (a, b) => {
                        if (b.excellentTypeId == null)
                            return -1;
                        if (a.excellentTypeId == null)
                            return 1;
                        return b.excellentTypeId.localeCompare(a.excellentTypeId);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentTypeName:
                    return (a, b) => {
                        if (b.excellentTypeName == null)
                            return -1;
                        if (a.excellentTypeName == null)
                            return 1;
                        return b.excellentTypeName.localeCompare(a.excellentTypeName);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentYear:
                    return (a, b) => {
                        return b.excellentYear - a.excellentYear;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsBuildingCourse:
                    return (a, b) => {
                        if (b.isBuildingCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsDoubleLanguageCourse:
                    return (a, b) => {
                        if (b.isDoubleLanguageCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsOpen:
                    return (a, b) => {
                        if (b.isOpen == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsRecommendedCourse:
                    return (a, b) => {
                        if (b.isRecommendedCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsSelfPropelledCourse:
                    return (a, b) => {
                        if (b.isSelfPropelledCourse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OperationDate:
                    return (a, b) => {
                        if (b.operationDate == null)
                            return -1;
                        if (a.operationDate == null)
                            return 1;
                        return b.operationDate.localeCompare(a.operationDate);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OuterLink:
                    return (a, b) => {
                        if (b.outerLink == null)
                            return -1;
                        if (a.outerLink == null)
                            return 1;
                        return b.outerLink.localeCompare(a.outerLink);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ViewCount:
                    return (a, b) => {
                        return b.viewCount - a.viewCount;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ThemeId:
                    return (a, b) => {
                        if (b.themeId == null)
                            return -1;
                        if (a.themeId == null)
                            return 1;
                        return b.themeId.localeCompare(a.themeId);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ThemeName:
                    return (a, b) => {
                        if (b.themeName == null)
                            return -1;
                        if (a.themeName == null)
                            return 1;
                        return b.themeName.localeCompare(a.themeName);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExampleImgPath:
                    return (a, b) => {
                        if (b.exampleImgPath == null)
                            return -1;
                        if (a.exampleImgPath == null)
                            return 1;
                        return b.exampleImgPath.localeCompare(a.exampleImgPath);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_MajorID:
                    return (a, b) => {
                        if (b.majorID == null)
                            return -1;
                        if (a.majorID == null)
                            return 1;
                        return b.majorID.localeCompare(a.majorID);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_MajorName:
                    return (a, b) => {
                        if (b.majorName == null)
                            return -1;
                        if (a.majorName == null)
                            return 1;
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeID:
                    return (a, b) => {
                        if (b.collegeID == null)
                            return -1;
                        if (a.collegeID == null)
                            return 1;
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeName:
                    return (a, b) => {
                        if (b.collegeName == null)
                            return -1;
                        if (a.collegeName == null)
                            return 1;
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeNameA:
                    return (a, b) => {
                        if (b.collegeNameA == null)
                            return -1;
                        if (a.collegeNameA == null)
                            return 1;
                        return b.collegeNameA.localeCompare(a.collegeNameA);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_QuestionNum:
                    return (a, b) => {
                        return b.questionNum - a.questionNum;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_KnowledgesNum:
                    return (a, b) => {
                        return b.knowledgesNum - a.knowledgesNum;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_TeacherNum:
                    return (a, b) => {
                        return b.teacherNum - a.teacherNum;
                    };
                case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ChapterNum:
                    return (a, b) => {
                        return b.chapterNum - a.chapterNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_CoursePro]中不存在！(in ${exports.vcc_CoursePro_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vcc_CoursePro_SortFunByKey = vcc_CoursePro_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vcc_CoursePro_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_LikeCount:
                return (obj) => {
                    return obj.likeCount === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseCode:
                return (obj) => {
                    return obj.courseCode === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseDescription:
                return (obj) => {
                    return obj.courseDescription === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseTypeID:
                return (obj) => {
                    return obj.courseTypeID === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseTypeName:
                return (obj) => {
                    return obj.courseTypeName === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentTypeId:
                return (obj) => {
                    return obj.excellentTypeId === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentTypeName:
                return (obj) => {
                    return obj.excellentTypeName === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentYear:
                return (obj) => {
                    return obj.excellentYear === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsBuildingCourse:
                return (obj) => {
                    return obj.isBuildingCourse === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsDoubleLanguageCourse:
                return (obj) => {
                    return obj.isDoubleLanguageCourse === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsOpen:
                return (obj) => {
                    return obj.isOpen === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsRecommendedCourse:
                return (obj) => {
                    return obj.isRecommendedCourse === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsSelfPropelledCourse:
                return (obj) => {
                    return obj.isSelfPropelledCourse === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OperationDate:
                return (obj) => {
                    return obj.operationDate === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OuterLink:
                return (obj) => {
                    return obj.outerLink === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ViewCount:
                return (obj) => {
                    return obj.viewCount === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ThemeId:
                return (obj) => {
                    return obj.themeId === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ThemeName:
                return (obj) => {
                    return obj.themeName === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExampleImgPath:
                return (obj) => {
                    return obj.exampleImgPath === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_MajorID:
                return (obj) => {
                    return obj.majorID === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeNameA:
                return (obj) => {
                    return obj.collegeNameA === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_QuestionNum:
                return (obj) => {
                    return obj.questionNum === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_KnowledgesNum:
                return (obj) => {
                    return obj.knowledgesNum === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_TeacherNum:
                return (obj) => {
                    return obj.teacherNum === value;
                };
            case clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ChapterNum:
                return (obj) => {
                    return obj.chapterNum === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vcc_CoursePro]中不存在！(in ${exports.vcc_CoursePro_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vcc_CoursePro_FilterFunByKey = vcc_CoursePro_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vcc_CoursePro_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_GetFirstIDAsync = vcc_CoursePro_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vcc_CoursePro_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_GetFirstID = vcc_CoursePro_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vcc_CoursePro_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
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
                const objvcc_CoursePro = vcc_CoursePro_GetObjFromJsonObj(returnObj);
                return objvcc_CoursePro;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_GetFirstObjAsync = vcc_CoursePro_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vcc_CoursePro_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CoursePro_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_GetObjLstAsync = vcc_CoursePro_GetObjLstAsync;
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
    async function vcc_CoursePro_GetObjLstByCourseIdLstAsync(arrCourseId) {
        const strThisFuncName = "GetObjLstByCourseIdLstAsync";
        const strAction = "GetObjLstByCourseIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CoursePro_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_GetObjLstByCourseIdLstAsync = vcc_CoursePro_GetObjLstByCourseIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vcc_CoursePro_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CoursePro_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_GetTopObjLstAsync = vcc_CoursePro_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_CoursePro_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CoursePro_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_GetObjLstByRangeAsync = vcc_CoursePro_GetObjLstByRangeAsync;
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
    async function vcc_CoursePro_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_GetObjLstByRange = vcc_CoursePro_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_CoursePro_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CoursePro_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_GetObjLstByPagerAsync = vcc_CoursePro_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vcc_CoursePro_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_IsExistRecordAsync = vcc_CoursePro_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCourseId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vcc_CoursePro_IsExist(strCourseId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_IsExist = vcc_CoursePro_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCourseId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vcc_CoursePro_IsExistAsync(strCourseId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_IsExistAsync = vcc_CoursePro_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vcc_CoursePro_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CoursePro_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CoursePro_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CoursePro_GetRecCountByCondAsync = vcc_CoursePro_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vcc_CoursePro_GetWebApiUrl(strController, strAction) {
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
    exports.vcc_CoursePro_GetWebApiUrl = vcc_CoursePro_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_CoursePro_GetJSONStrByObj(pobjvcc_CourseProEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvcc_CourseProEN);
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
    exports.vcc_CoursePro_GetJSONStrByObj = vcc_CoursePro_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vcc_CoursePro_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvcc_CourseProObjLst = new Array();
        if (strJSON === "") {
            return arrvcc_CourseProObjLst;
        }
        try {
            arrvcc_CourseProObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvcc_CourseProObjLst;
        }
        return arrvcc_CourseProObjLst;
    }
    exports.vcc_CoursePro_GetObjLstByJSONStr = vcc_CoursePro_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvcc_CourseProObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vcc_CoursePro_GetObjLstByJSONObjLst(arrvcc_CourseProObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvcc_CourseProObjLst = new Array();
        for (const objInFor of arrvcc_CourseProObjLstS) {
            const obj1 = vcc_CoursePro_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvcc_CourseProObjLst.push(obj1);
        }
        return arrvcc_CourseProObjLst;
    }
    exports.vcc_CoursePro_GetObjLstByJSONObjLst = vcc_CoursePro_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_CoursePro_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvcc_CourseProEN = new clsvcc_CourseProEN_js_1.clsvcc_CourseProEN();
        if (strJSON === "") {
            return pobjvcc_CourseProEN;
        }
        try {
            pobjvcc_CourseProEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvcc_CourseProEN;
        }
        return pobjvcc_CourseProEN;
    }
    exports.vcc_CoursePro_GetObjByJSONStr = vcc_CoursePro_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vcc_CoursePro_GetCombineCondition(objvcc_CoursePro_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseId, objvcc_CoursePro_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_LikeCount) == true) {
            const strComparisonOp_LikeCount = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_LikeCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_LikeCount, objvcc_CoursePro_Cond.likeCount, strComparisonOp_LikeCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseCode) == true) {
            const strComparisonOp_CourseCode = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseCode, objvcc_CoursePro_Cond.courseCode, strComparisonOp_CourseCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseDescription) == true) {
            const strComparisonOp_CourseDescription = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseDescription];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseDescription, objvcc_CoursePro_Cond.courseDescription, strComparisonOp_CourseDescription);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseName, objvcc_CoursePro_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseTypeID) == true) {
            const strComparisonOp_CourseTypeID = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseTypeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseTypeID, objvcc_CoursePro_Cond.courseTypeID, strComparisonOp_CourseTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseTypeName) == true) {
            const strComparisonOp_CourseTypeName = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CourseTypeName, objvcc_CoursePro_Cond.courseTypeName, strComparisonOp_CourseTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CreateDate, objvcc_CoursePro_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentTypeId) == true) {
            const strComparisonOp_ExcellentTypeId = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentTypeId, objvcc_CoursePro_Cond.excellentTypeId, strComparisonOp_ExcellentTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentTypeName) == true) {
            const strComparisonOp_ExcellentTypeName = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentTypeName, objvcc_CoursePro_Cond.excellentTypeName, strComparisonOp_ExcellentTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentYear) == true) {
            const strComparisonOp_ExcellentYear = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExcellentYear, objvcc_CoursePro_Cond.excellentYear, strComparisonOp_ExcellentYear);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsBuildingCourse) == true) {
            if (objvcc_CoursePro_Cond.isBuildingCourse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsBuildingCourse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsBuildingCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsDoubleLanguageCourse) == true) {
            if (objvcc_CoursePro_Cond.isDoubleLanguageCourse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsDoubleLanguageCourse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsDoubleLanguageCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsOpen) == true) {
            if (objvcc_CoursePro_Cond.isOpen == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsOpen);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsOpen);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsRecommendedCourse) == true) {
            if (objvcc_CoursePro_Cond.isRecommendedCourse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsRecommendedCourse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsRecommendedCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsSelfPropelledCourse) == true) {
            if (objvcc_CoursePro_Cond.isSelfPropelledCourse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsSelfPropelledCourse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_IsSelfPropelledCourse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OperationDate) == true) {
            const strComparisonOp_OperationDate = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OperationDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OperationDate, objvcc_CoursePro_Cond.operationDate, strComparisonOp_OperationDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OrderNum, objvcc_CoursePro_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OuterLink) == true) {
            const strComparisonOp_OuterLink = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OuterLink];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_OuterLink, objvcc_CoursePro_Cond.outerLink, strComparisonOp_OuterLink);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ViewCount) == true) {
            const strComparisonOp_ViewCount = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ViewCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ViewCount, objvcc_CoursePro_Cond.viewCount, strComparisonOp_ViewCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ThemeId) == true) {
            const strComparisonOp_ThemeId = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ThemeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ThemeId, objvcc_CoursePro_Cond.themeId, strComparisonOp_ThemeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ThemeName) == true) {
            const strComparisonOp_ThemeName = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ThemeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ThemeName, objvcc_CoursePro_Cond.themeName, strComparisonOp_ThemeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExampleImgPath) == true) {
            const strComparisonOp_ExampleImgPath = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExampleImgPath];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ExampleImgPath, objvcc_CoursePro_Cond.exampleImgPath, strComparisonOp_ExampleImgPath);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_id_XzMajor, objvcc_CoursePro_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_MajorID) == true) {
            const strComparisonOp_MajorID = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_MajorID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_MajorID, objvcc_CoursePro_Cond.majorID, strComparisonOp_MajorID);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_MajorName, objvcc_CoursePro_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_id_XzCollege, objvcc_CoursePro_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeID, objvcc_CoursePro_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeName, objvcc_CoursePro_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeNameA) == true) {
            const strComparisonOp_CollegeNameA = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_CollegeNameA, objvcc_CoursePro_Cond.collegeNameA, strComparisonOp_CollegeNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_Memo, objvcc_CoursePro_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_QuestionNum) == true) {
            const strComparisonOp_QuestionNum = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_QuestionNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_QuestionNum, objvcc_CoursePro_Cond.questionNum, strComparisonOp_QuestionNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_KnowledgesNum) == true) {
            const strComparisonOp_KnowledgesNum = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_KnowledgesNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_KnowledgesNum, objvcc_CoursePro_Cond.knowledgesNum, strComparisonOp_KnowledgesNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_TeacherNum) == true) {
            const strComparisonOp_TeacherNum = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_TeacherNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_TeacherNum, objvcc_CoursePro_Cond.teacherNum, strComparisonOp_TeacherNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CoursePro_Cond.dicFldComparisonOp, clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ChapterNum) == true) {
            const strComparisonOp_ChapterNum = objvcc_CoursePro_Cond.dicFldComparisonOp[clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ChapterNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseProEN_js_1.clsvcc_CourseProEN.con_ChapterNum, objvcc_CoursePro_Cond.chapterNum, strComparisonOp_ChapterNum);
        }
        return strWhereCond;
    }
    exports.vcc_CoursePro_GetCombineCondition = vcc_CoursePro_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvcc_CourseProENS:源对象
     * @param objvcc_CourseProENT:目标对象
    */
    function vcc_CoursePro_CopyObjTo(objvcc_CourseProENS, objvcc_CourseProENT) {
        objvcc_CourseProENT.courseId = objvcc_CourseProENS.courseId; //课程Id
        objvcc_CourseProENT.likeCount = objvcc_CourseProENS.likeCount; //LikeCount
        objvcc_CourseProENT.courseCode = objvcc_CourseProENS.courseCode; //课程代码
        objvcc_CourseProENT.courseDescription = objvcc_CourseProENS.courseDescription; //课程描述
        objvcc_CourseProENT.courseName = objvcc_CourseProENS.courseName; //课程名称
        objvcc_CourseProENT.courseTypeID = objvcc_CourseProENS.courseTypeID; //课程类型ID
        objvcc_CourseProENT.courseTypeName = objvcc_CourseProENS.courseTypeName; //课程类型名称
        objvcc_CourseProENT.createDate = objvcc_CourseProENS.createDate; //建立日期
        objvcc_CourseProENT.excellentTypeId = objvcc_CourseProENS.excellentTypeId; //精品课程类型Id
        objvcc_CourseProENT.excellentTypeName = objvcc_CourseProENS.excellentTypeName; //精品课程类型名称
        objvcc_CourseProENT.excellentYear = objvcc_CourseProENS.excellentYear; //课程年份
        objvcc_CourseProENT.isBuildingCourse = objvcc_CourseProENS.isBuildingCourse; //是否已建设课程
        objvcc_CourseProENT.isDoubleLanguageCourse = objvcc_CourseProENS.isDoubleLanguageCourse; //是否双语课程
        objvcc_CourseProENT.isOpen = objvcc_CourseProENS.isOpen; //是否公开
        objvcc_CourseProENT.isRecommendedCourse = objvcc_CourseProENS.isRecommendedCourse; //是否推荐课程
        objvcc_CourseProENT.isSelfPropelledCourse = objvcc_CourseProENS.isSelfPropelledCourse; //是否自荐课程
        objvcc_CourseProENT.operationDate = objvcc_CourseProENS.operationDate; //操作时间
        objvcc_CourseProENT.orderNum = objvcc_CourseProENS.orderNum; //序号
        objvcc_CourseProENT.outerLink = objvcc_CourseProENS.outerLink; //外链地址
        objvcc_CourseProENT.viewCount = objvcc_CourseProENS.viewCount; //浏览量
        objvcc_CourseProENT.themeId = objvcc_CourseProENS.themeId; //主题Id
        objvcc_CourseProENT.themeName = objvcc_CourseProENS.themeName; //主题名
        objvcc_CourseProENT.exampleImgPath = objvcc_CourseProENS.exampleImgPath; //示例图路径
        objvcc_CourseProENT.id_XzMajor = objvcc_CourseProENS.id_XzMajor; //专业流水号
        objvcc_CourseProENT.majorID = objvcc_CourseProENS.majorID; //专业ID
        objvcc_CourseProENT.majorName = objvcc_CourseProENS.majorName; //专业名称
        objvcc_CourseProENT.id_XzCollege = objvcc_CourseProENS.id_XzCollege; //学院流水号
        objvcc_CourseProENT.collegeID = objvcc_CourseProENS.collegeID; //学院ID
        objvcc_CourseProENT.collegeName = objvcc_CourseProENS.collegeName; //学院名称
        objvcc_CourseProENT.collegeNameA = objvcc_CourseProENS.collegeNameA; //学院名称简写
        objvcc_CourseProENT.memo = objvcc_CourseProENS.memo; //备注
        objvcc_CourseProENT.questionNum = objvcc_CourseProENS.questionNum; //题目数
        objvcc_CourseProENT.knowledgesNum = objvcc_CourseProENS.knowledgesNum; //知识点数
        objvcc_CourseProENT.teacherNum = objvcc_CourseProENS.teacherNum; //教师数
        objvcc_CourseProENT.chapterNum = objvcc_CourseProENS.chapterNum; //章节数
    }
    exports.vcc_CoursePro_CopyObjTo = vcc_CoursePro_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvcc_CourseProENS:源对象
     * @param objvcc_CourseProENT:目标对象
    */
    function vcc_CoursePro_GetObjFromJsonObj(objvcc_CourseProENS) {
        const objvcc_CourseProENT = new clsvcc_CourseProEN_js_1.clsvcc_CourseProEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_CourseProENT, objvcc_CourseProENS);
        return objvcc_CourseProENT;
    }
    exports.vcc_CoursePro_GetObjFromJsonObj = vcc_CoursePro_GetObjFromJsonObj;
});
