/**
* 类名:clsvCurrEduClsWApi
* 表名:vCurrEduCls(01120126)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 02:45:31
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:游戏化教育平台(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:日常运行(DailyRunning)
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
        define(["require", "exports", "axios", "../../L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vCurrEduCls_GetObjFromJsonObj = exports.vCurrEduCls_CopyObjTo = exports.vCurrEduCls_GetCombineCondition = exports.vCurrEduCls_GetObjByJSONStr = exports.vCurrEduCls_GetObjLstByJSONObjLst = exports.vCurrEduCls_GetObjLstByJSONStr = exports.vCurrEduCls_GetJSONStrByObj = exports.vCurrEduCls_GetWebApiUrl = exports.vCurrEduCls_GetRecCountByCondAsync = exports.vCurrEduCls_IsExistAsync = exports.vCurrEduCls_IsExist = exports.vCurrEduCls_IsExistRecordAsync = exports.vCurrEduCls_GetObjLstByPagerAsync = exports.vCurrEduCls_GetObjLstByRange = exports.vCurrEduCls_GetObjLstByRangeAsync = exports.vCurrEduCls_GetTopObjLstAsync = exports.vCurrEduCls_GetObjLstByid_CurrEduClsLstAsync = exports.vCurrEduCls_GetObjLstAsync = exports.vCurrEduCls_GetFirstObjAsync = exports.vCurrEduCls_GetFirstID = exports.vCurrEduCls_GetFirstIDAsync = exports.vCurrEduCls_FilterFunByKey = exports.vCurrEduCls_SortFunByKey = exports.vCurrEduCls_SortFun_Defa_2Fld = exports.vCurrEduCls_SortFun_Defa = exports.vCurrEduCls_GetObjByid_CurrEduClsAsync = exports.vCurrEduCls_ConstructorName = exports.vCurrEduCls_Controller = void 0;
    /**
     * v当前教学班(vCurrEduCls)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvCurrEduClsEN_js_1 = require("../../L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vCurrEduCls_Controller = "vCurrEduClsApi";
    exports.vCurrEduCls_ConstructorName = "vCurrEduCls";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_CurrEduCls:关键字
    * @returns 对象
    **/
    async function vCurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls) {
        const strThisFuncName = "GetObjByid_CurrEduClsAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsvCurrEduClsWApi.GetObjByid_CurrEduClsAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsvCurrEduClsWApi.GetObjByid_CurrEduClsAsync)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_CurrEduCls";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_CurrEduCls": strid_CurrEduCls,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvCurrEduCls = vCurrEduCls_GetObjFromJsonObj(returnObj);
                return objvCurrEduCls;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetObjByid_CurrEduClsAsync = vCurrEduCls_GetObjByid_CurrEduClsAsync;
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
    function vCurrEduCls_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
    }
    exports.vCurrEduCls_SortFun_Defa = vCurrEduCls_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduCls_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.currEduClsId == b.currEduClsId)
            return a.eduClsName.localeCompare(b.eduClsName);
        else
            return a.currEduClsId.localeCompare(b.currEduClsId);
    }
    exports.vCurrEduCls_SortFun_Defa_2Fld = vCurrEduCls_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduCls_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId:
                    return (a, b) => {
                        return a.currEduClsId.localeCompare(b.currEduClsId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName:
                    return (a, b) => {
                        return a.eduClsName.localeCompare(b.eduClsName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeId:
                    return (a, b) => {
                        return a.eduClsTypeId.localeCompare(b.eduClsTypeId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeName:
                    return (a, b) => {
                        if (a.eduClsTypeName == null)
                            return -1;
                        if (b.eduClsTypeName == null)
                            return 1;
                        return a.eduClsTypeName.localeCompare(b.eduClsTypeName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseId:
                    return (a, b) => {
                        if (a.courseId == null)
                            return -1;
                        if (b.courseId == null)
                            return 1;
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseCode:
                    return (a, b) => {
                        if (a.courseCode == null)
                            return -1;
                        if (b.courseCode == null)
                            return 1;
                        return a.courseCode.localeCompare(b.courseCode);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseDescription:
                    return (a, b) => {
                        if (a.courseDescription == null)
                            return -1;
                        if (b.courseDescription == null)
                            return 1;
                        return a.courseDescription.localeCompare(b.courseDescription);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseName:
                    return (a, b) => {
                        if (a.courseName == null)
                            return -1;
                        if (b.courseName == null)
                            return 1;
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ViewCount:
                    return (a, b) => {
                        return a.viewCount - b.viewCount;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ExampleImgPath:
                    return (a, b) => {
                        if (a.exampleImgPath == null)
                            return -1;
                        if (b.exampleImgPath == null)
                            return 1;
                        return a.exampleImgPath.localeCompare(b.exampleImgPath);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionId:
                    return (a, b) => {
                        return a.teachingSolutionId.localeCompare(b.teachingSolutionId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionName:
                    return (a, b) => {
                        if (a.teachingSolutionName == null)
                            return -1;
                        if (b.teachingSolutionName == null)
                            return 1;
                        return a.teachingSolutionName.localeCompare(b.teachingSolutionName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_Teacher:
                    return (a, b) => {
                        if (a.id_Teacher == null)
                            return -1;
                        if (b.id_Teacher == null)
                            return 1;
                        return a.id_Teacher.localeCompare(b.id_Teacher);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherID:
                    return (a, b) => {
                        if (a.teacherID == null)
                            return -1;
                        if (b.teacherID == null)
                            return 1;
                        return a.teacherID.localeCompare(b.teacherID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherName:
                    return (a, b) => {
                        if (a.teacherName == null)
                            return -1;
                        if (b.teacherName == null)
                            return 1;
                        return a.teacherName.localeCompare(b.teacherName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeID:
                    return (a, b) => {
                        if (a.collegeID == null)
                            return -1;
                        if (b.collegeID == null)
                            return 1;
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeName:
                    return (a, b) => {
                        if (a.collegeName == null)
                            return -1;
                        if (b.collegeName == null)
                            return 1;
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ClgEnglishName:
                    return (a, b) => {
                        if (a.clgEnglishName == null)
                            return -1;
                        if (b.clgEnglishName == null)
                            return 1;
                        return a.clgEnglishName.localeCompare(b.clgEnglishName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_PhoneNumber:
                    return (a, b) => {
                        if (a.phoneNumber == null)
                            return -1;
                        if (b.phoneNumber == null)
                            return 1;
                        return a.phoneNumber.localeCompare(b.phoneNumber);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MajorName:
                    return (a, b) => {
                        if (a.majorName == null)
                            return -1;
                        if (b.majorName == null)
                            return 1;
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_EduWay:
                    return (a, b) => {
                        return a.id_EduWay.localeCompare(b.id_EduWay);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ClassRoomType:
                    return (a, b) => {
                        return a.id_ClassRoomType.localeCompare(b.id_ClassRoomType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TotalLessonQty:
                    return (a, b) => {
                        return a.totalLessonQty - b.totalLessonQty;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MaxStuQty:
                    return (a, b) => {
                        return a.maxStuQty - b.maxStuQty;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekQty:
                    return (a, b) => {
                        return a.weekQty - b.weekQty;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ScheUnitPW:
                    return (a, b) => {
                        return a.scheUnitPW - b.scheUnitPW;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekStatusID:
                    return (a, b) => {
                        if (a.weekStatusID == null)
                            return -1;
                        if (b.weekStatusID == null)
                            return 1;
                        return a.weekStatusID.localeCompare(b.weekStatusID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CustomerWeek:
                    return (a, b) => {
                        if (a.customerWeek == null)
                            return -1;
                        if (b.customerWeek == null)
                            return 1;
                        return a.customerWeek.localeCompare(b.customerWeek);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_LessonQtyPerWeek:
                    return (a, b) => {
                        return a.lessonQtyPerWeek - b.lessonQtyPerWeek;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Mark:
                    return (a, b) => {
                        return a.mark - b.mark;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_UniZone:
                    return (a, b) => {
                        if (a.id_UniZone == null)
                            return -1;
                        if (b.id_UniZone == null)
                            return 1;
                        return a.id_UniZone.localeCompare(b.id_UniZone);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_GradeBase:
                    return (a, b) => {
                        if (a.id_GradeBase == null)
                            return -1;
                        if (b.id_GradeBase == null)
                            return 1;
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseID:
                    return (a, b) => {
                        if (a.gradeBaseID == null)
                            return -1;
                        if (b.gradeBaseID == null)
                            return 1;
                        return a.gradeBaseID.localeCompare(b.gradeBaseID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseName:
                    return (a, b) => {
                        if (a.gradeBaseName == null)
                            return -1;
                        if (b.gradeBaseName == null)
                            return 1;
                        return a.gradeBaseName.localeCompare(b.gradeBaseName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseNameA:
                    return (a, b) => {
                        if (a.gradeBaseNameA == null)
                            return -1;
                        if (b.gradeBaseNameA == null)
                            return 1;
                        return a.gradeBaseNameA.localeCompare(b.gradeBaseNameA);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsEffective:
                    return (a, b) => {
                        if (a.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsForPaperReading:
                    return (a, b) => {
                        if (a.isForPaperReading == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolYear:
                    return (a, b) => {
                        if (a.schoolYear == null)
                            return -1;
                        if (b.schoolYear == null)
                            return 1;
                        return a.schoolYear.localeCompare(b.schoolYear);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolTerm:
                    return (a, b) => {
                        if (a.schoolTerm == null)
                            return -1;
                        if (b.schoolTerm == null)
                            return 1;
                        return a.schoolTerm.localeCompare(b.schoolTerm);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CourseType:
                    return (a, b) => {
                        return a.id_CourseType.localeCompare(b.id_CourseType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeID:
                    return (a, b) => {
                        if (a.courseTypeID == null)
                            return -1;
                        if (b.courseTypeID == null)
                            return 1;
                        return a.courseTypeID.localeCompare(b.courseTypeID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeName:
                    return (a, b) => {
                        if (a.courseTypeName == null)
                            return -1;
                        if (b.courseTypeName == null)
                            return 1;
                        return a.courseTypeName.localeCompare(b.courseTypeName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsDegree:
                    return (a, b) => {
                        if (a.isDegree == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ScoreType:
                    return (a, b) => {
                        if (a.id_ScoreType == null)
                            return -1;
                        if (b.id_ScoreType == null)
                            return 1;
                        return a.id_ScoreType.localeCompare(b.id_ScoreType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GetScoreWayId:
                    return (a, b) => {
                        if (a.getScoreWayId == null)
                            return -1;
                        if (b.getScoreWayId == null)
                            return 1;
                        return a.getScoreWayId.localeCompare(b.getScoreWayId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsProportionalCtrl:
                    return (a, b) => {
                        if (a.isProportionalCtrl == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ExamType:
                    return (a, b) => {
                        if (a.id_ExamType == null)
                            return -1;
                        if (b.id_ExamType == null)
                            return 1;
                        return a.id_ExamType.localeCompare(b.id_ExamType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_BeginWeek:
                    return (a, b) => {
                        return a.beginWeek - b.beginWeek;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyDate:
                    return (a, b) => {
                        if (a.modifyDate == null)
                            return -1;
                        if (b.modifyDate == null)
                            return 1;
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyUserID:
                    return (a, b) => {
                        if (a.modifyUserID == null)
                            return -1;
                        if (b.modifyUserID == null)
                            return 1;
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum_Valid:
                    return (a, b) => {
                        return a.currStuNum_Valid - b.currStuNum_Valid;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum:
                    return (a, b) => {
                        return a.currStuNum - b.currStuNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vCurrEduCls]中不存在！(in ${exports.vCurrEduCls_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId:
                    return (a, b) => {
                        return b.currEduClsId.localeCompare(a.currEduClsId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName:
                    return (a, b) => {
                        return b.eduClsName.localeCompare(a.eduClsName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeId:
                    return (a, b) => {
                        return b.eduClsTypeId.localeCompare(a.eduClsTypeId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeName:
                    return (a, b) => {
                        if (b.eduClsTypeName == null)
                            return -1;
                        if (a.eduClsTypeName == null)
                            return 1;
                        return b.eduClsTypeName.localeCompare(a.eduClsTypeName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseId:
                    return (a, b) => {
                        if (b.courseId == null)
                            return -1;
                        if (a.courseId == null)
                            return 1;
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseCode:
                    return (a, b) => {
                        if (b.courseCode == null)
                            return -1;
                        if (a.courseCode == null)
                            return 1;
                        return b.courseCode.localeCompare(a.courseCode);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseDescription:
                    return (a, b) => {
                        if (b.courseDescription == null)
                            return -1;
                        if (a.courseDescription == null)
                            return 1;
                        return b.courseDescription.localeCompare(a.courseDescription);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseName:
                    return (a, b) => {
                        if (b.courseName == null)
                            return -1;
                        if (a.courseName == null)
                            return 1;
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ViewCount:
                    return (a, b) => {
                        return b.viewCount - a.viewCount;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ExampleImgPath:
                    return (a, b) => {
                        if (b.exampleImgPath == null)
                            return -1;
                        if (a.exampleImgPath == null)
                            return 1;
                        return b.exampleImgPath.localeCompare(a.exampleImgPath);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionId:
                    return (a, b) => {
                        return b.teachingSolutionId.localeCompare(a.teachingSolutionId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionName:
                    return (a, b) => {
                        if (b.teachingSolutionName == null)
                            return -1;
                        if (a.teachingSolutionName == null)
                            return 1;
                        return b.teachingSolutionName.localeCompare(a.teachingSolutionName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_Teacher:
                    return (a, b) => {
                        if (b.id_Teacher == null)
                            return -1;
                        if (a.id_Teacher == null)
                            return 1;
                        return b.id_Teacher.localeCompare(a.id_Teacher);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherID:
                    return (a, b) => {
                        if (b.teacherID == null)
                            return -1;
                        if (a.teacherID == null)
                            return 1;
                        return b.teacherID.localeCompare(a.teacherID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherName:
                    return (a, b) => {
                        if (b.teacherName == null)
                            return -1;
                        if (a.teacherName == null)
                            return 1;
                        return b.teacherName.localeCompare(a.teacherName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeID:
                    return (a, b) => {
                        if (b.collegeID == null)
                            return -1;
                        if (a.collegeID == null)
                            return 1;
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeName:
                    return (a, b) => {
                        if (b.collegeName == null)
                            return -1;
                        if (a.collegeName == null)
                            return 1;
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ClgEnglishName:
                    return (a, b) => {
                        if (b.clgEnglishName == null)
                            return -1;
                        if (a.clgEnglishName == null)
                            return 1;
                        return b.clgEnglishName.localeCompare(a.clgEnglishName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_PhoneNumber:
                    return (a, b) => {
                        if (b.phoneNumber == null)
                            return -1;
                        if (a.phoneNumber == null)
                            return 1;
                        return b.phoneNumber.localeCompare(a.phoneNumber);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MajorName:
                    return (a, b) => {
                        if (b.majorName == null)
                            return -1;
                        if (a.majorName == null)
                            return 1;
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_EduWay:
                    return (a, b) => {
                        return b.id_EduWay.localeCompare(a.id_EduWay);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ClassRoomType:
                    return (a, b) => {
                        return b.id_ClassRoomType.localeCompare(a.id_ClassRoomType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TotalLessonQty:
                    return (a, b) => {
                        return b.totalLessonQty - a.totalLessonQty;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MaxStuQty:
                    return (a, b) => {
                        return b.maxStuQty - a.maxStuQty;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekQty:
                    return (a, b) => {
                        return b.weekQty - a.weekQty;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ScheUnitPW:
                    return (a, b) => {
                        return b.scheUnitPW - a.scheUnitPW;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekStatusID:
                    return (a, b) => {
                        if (b.weekStatusID == null)
                            return -1;
                        if (a.weekStatusID == null)
                            return 1;
                        return b.weekStatusID.localeCompare(a.weekStatusID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CustomerWeek:
                    return (a, b) => {
                        if (b.customerWeek == null)
                            return -1;
                        if (a.customerWeek == null)
                            return 1;
                        return b.customerWeek.localeCompare(a.customerWeek);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_LessonQtyPerWeek:
                    return (a, b) => {
                        return b.lessonQtyPerWeek - a.lessonQtyPerWeek;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Mark:
                    return (a, b) => {
                        return b.mark - a.mark;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_UniZone:
                    return (a, b) => {
                        if (b.id_UniZone == null)
                            return -1;
                        if (a.id_UniZone == null)
                            return 1;
                        return b.id_UniZone.localeCompare(a.id_UniZone);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_GradeBase:
                    return (a, b) => {
                        if (b.id_GradeBase == null)
                            return -1;
                        if (a.id_GradeBase == null)
                            return 1;
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseID:
                    return (a, b) => {
                        if (b.gradeBaseID == null)
                            return -1;
                        if (a.gradeBaseID == null)
                            return 1;
                        return b.gradeBaseID.localeCompare(a.gradeBaseID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseName:
                    return (a, b) => {
                        if (b.gradeBaseName == null)
                            return -1;
                        if (a.gradeBaseName == null)
                            return 1;
                        return b.gradeBaseName.localeCompare(a.gradeBaseName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseNameA:
                    return (a, b) => {
                        if (b.gradeBaseNameA == null)
                            return -1;
                        if (a.gradeBaseNameA == null)
                            return 1;
                        return b.gradeBaseNameA.localeCompare(a.gradeBaseNameA);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsEffective:
                    return (a, b) => {
                        if (b.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsForPaperReading:
                    return (a, b) => {
                        if (b.isForPaperReading == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolYear:
                    return (a, b) => {
                        if (b.schoolYear == null)
                            return -1;
                        if (a.schoolYear == null)
                            return 1;
                        return b.schoolYear.localeCompare(a.schoolYear);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolTerm:
                    return (a, b) => {
                        if (b.schoolTerm == null)
                            return -1;
                        if (a.schoolTerm == null)
                            return 1;
                        return b.schoolTerm.localeCompare(a.schoolTerm);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CourseType:
                    return (a, b) => {
                        return b.id_CourseType.localeCompare(a.id_CourseType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeID:
                    return (a, b) => {
                        if (b.courseTypeID == null)
                            return -1;
                        if (a.courseTypeID == null)
                            return 1;
                        return b.courseTypeID.localeCompare(a.courseTypeID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeName:
                    return (a, b) => {
                        if (b.courseTypeName == null)
                            return -1;
                        if (a.courseTypeName == null)
                            return 1;
                        return b.courseTypeName.localeCompare(a.courseTypeName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsDegree:
                    return (a, b) => {
                        if (b.isDegree == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ScoreType:
                    return (a, b) => {
                        if (b.id_ScoreType == null)
                            return -1;
                        if (a.id_ScoreType == null)
                            return 1;
                        return b.id_ScoreType.localeCompare(a.id_ScoreType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GetScoreWayId:
                    return (a, b) => {
                        if (b.getScoreWayId == null)
                            return -1;
                        if (a.getScoreWayId == null)
                            return 1;
                        return b.getScoreWayId.localeCompare(a.getScoreWayId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsProportionalCtrl:
                    return (a, b) => {
                        if (b.isProportionalCtrl == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ExamType:
                    return (a, b) => {
                        if (b.id_ExamType == null)
                            return -1;
                        if (a.id_ExamType == null)
                            return 1;
                        return b.id_ExamType.localeCompare(a.id_ExamType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_BeginWeek:
                    return (a, b) => {
                        return b.beginWeek - a.beginWeek;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyDate:
                    return (a, b) => {
                        if (b.modifyDate == null)
                            return -1;
                        if (a.modifyDate == null)
                            return 1;
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyUserID:
                    return (a, b) => {
                        if (b.modifyUserID == null)
                            return -1;
                        if (a.modifyUserID == null)
                            return 1;
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum_Valid:
                    return (a, b) => {
                        return b.currStuNum_Valid - a.currStuNum_Valid;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum:
                    return (a, b) => {
                        return b.currStuNum - a.currStuNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vCurrEduCls]中不存在！(in ${exports.vCurrEduCls_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vCurrEduCls_SortFunByKey = vCurrEduCls_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vCurrEduCls_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId:
                return (obj) => {
                    return obj.currEduClsId === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName:
                return (obj) => {
                    return obj.eduClsName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeId:
                return (obj) => {
                    return obj.eduClsTypeId === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeName:
                return (obj) => {
                    return obj.eduClsTypeName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseCode:
                return (obj) => {
                    return obj.courseCode === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseDescription:
                return (obj) => {
                    return obj.courseDescription === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ViewCount:
                return (obj) => {
                    return obj.viewCount === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ExampleImgPath:
                return (obj) => {
                    return obj.exampleImgPath === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionId:
                return (obj) => {
                    return obj.teachingSolutionId === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionName:
                return (obj) => {
                    return obj.teachingSolutionName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_Teacher:
                return (obj) => {
                    return obj.id_Teacher === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherID:
                return (obj) => {
                    return obj.teacherID === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherName:
                return (obj) => {
                    return obj.teacherName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ClgEnglishName:
                return (obj) => {
                    return obj.clgEnglishName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_PhoneNumber:
                return (obj) => {
                    return obj.phoneNumber === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_EduWay:
                return (obj) => {
                    return obj.id_EduWay === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ClassRoomType:
                return (obj) => {
                    return obj.id_ClassRoomType === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TotalLessonQty:
                return (obj) => {
                    return obj.totalLessonQty === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MaxStuQty:
                return (obj) => {
                    return obj.maxStuQty === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekQty:
                return (obj) => {
                    return obj.weekQty === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ScheUnitPW:
                return (obj) => {
                    return obj.scheUnitPW === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekStatusID:
                return (obj) => {
                    return obj.weekStatusID === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CustomerWeek:
                return (obj) => {
                    return obj.customerWeek === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_LessonQtyPerWeek:
                return (obj) => {
                    return obj.lessonQtyPerWeek === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Mark:
                return (obj) => {
                    return obj.mark === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_UniZone:
                return (obj) => {
                    return obj.id_UniZone === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseID:
                return (obj) => {
                    return obj.gradeBaseID === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseName:
                return (obj) => {
                    return obj.gradeBaseName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseNameA:
                return (obj) => {
                    return obj.gradeBaseNameA === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsEffective:
                return (obj) => {
                    return obj.isEffective === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsForPaperReading:
                return (obj) => {
                    return obj.isForPaperReading === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolYear:
                return (obj) => {
                    return obj.schoolYear === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolTerm:
                return (obj) => {
                    return obj.schoolTerm === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CourseType:
                return (obj) => {
                    return obj.id_CourseType === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeID:
                return (obj) => {
                    return obj.courseTypeID === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeName:
                return (obj) => {
                    return obj.courseTypeName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsDegree:
                return (obj) => {
                    return obj.isDegree === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ScoreType:
                return (obj) => {
                    return obj.id_ScoreType === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GetScoreWayId:
                return (obj) => {
                    return obj.getScoreWayId === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsProportionalCtrl:
                return (obj) => {
                    return obj.isProportionalCtrl === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ExamType:
                return (obj) => {
                    return obj.id_ExamType === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_BeginWeek:
                return (obj) => {
                    return obj.beginWeek === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum_Valid:
                return (obj) => {
                    return obj.currStuNum_Valid === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum:
                return (obj) => {
                    return obj.currStuNum === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vCurrEduCls]中不存在！(in ${exports.vCurrEduCls_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vCurrEduCls_FilterFunByKey = vCurrEduCls_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vCurrEduCls_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetFirstIDAsync = vCurrEduCls_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vCurrEduCls_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetFirstID = vCurrEduCls_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vCurrEduCls_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
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
                const objvCurrEduCls = vCurrEduCls_GetObjFromJsonObj(returnObj);
                return objvCurrEduCls;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetFirstObjAsync = vCurrEduCls_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vCurrEduCls_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetObjLstAsync = vCurrEduCls_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_CurrEduCls:关键字列表
    * @returns 对象列表
    **/
    async function vCurrEduCls_GetObjLstByid_CurrEduClsLstAsync(arrid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByid_CurrEduClsLstAsync";
        const strAction = "GetObjLstByid_CurrEduClsLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_CurrEduCls);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetObjLstByid_CurrEduClsLstAsync = vCurrEduCls_GetObjLstByid_CurrEduClsLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vCurrEduCls_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetTopObjLstAsync = vCurrEduCls_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vCurrEduCls_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetObjLstByRangeAsync = vCurrEduCls_GetObjLstByRangeAsync;
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
    async function vCurrEduCls_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetObjLstByRange = vCurrEduCls_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vCurrEduCls_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetObjLstByPagerAsync = vCurrEduCls_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vCurrEduCls_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_IsExistRecordAsync = vCurrEduCls_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_CurrEduCls:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vCurrEduCls_IsExist(strid_CurrEduCls, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_CurrEduCls": strid_CurrEduCls,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_IsExist = vCurrEduCls_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_CurrEduCls:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vCurrEduCls_IsExistAsync(strid_CurrEduCls) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_CurrEduCls": strid_CurrEduCls }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_IsExistAsync = vCurrEduCls_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vCurrEduCls_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetRecCountByCondAsync = vCurrEduCls_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vCurrEduCls_GetWebApiUrl(strController, strAction) {
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
    exports.vCurrEduCls_GetWebApiUrl = vCurrEduCls_GetWebApiUrl;
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
    function vCurrEduCls_GetJSONStrByObj(pobjvCurrEduClsEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvCurrEduClsEN);
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
    exports.vCurrEduCls_GetJSONStrByObj = vCurrEduCls_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vCurrEduCls_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvCurrEduClsObjLst = new Array();
        if (strJSON === "") {
            return arrvCurrEduClsObjLst;
        }
        try {
            arrvCurrEduClsObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvCurrEduClsObjLst;
        }
        return arrvCurrEduClsObjLst;
    }
    exports.vCurrEduCls_GetObjLstByJSONStr = vCurrEduCls_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvCurrEduClsObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vCurrEduCls_GetObjLstByJSONObjLst(arrvCurrEduClsObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvCurrEduClsObjLst = new Array();
        for (const objInFor of arrvCurrEduClsObjLstS) {
            const obj1 = vCurrEduCls_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvCurrEduClsObjLst.push(obj1);
        }
        return arrvCurrEduClsObjLst;
    }
    exports.vCurrEduCls_GetObjLstByJSONObjLst = vCurrEduCls_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vCurrEduCls_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvCurrEduClsEN = new clsvCurrEduClsEN_js_1.clsvCurrEduClsEN();
        if (strJSON === "") {
            return pobjvCurrEduClsEN;
        }
        try {
            pobjvCurrEduClsEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvCurrEduClsEN;
        }
        return pobjvCurrEduClsEN;
    }
    exports.vCurrEduCls_GetObjByJSONStr = vCurrEduCls_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vCurrEduCls_GetCombineCondition(objvCurrEduCls_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls, objvCurrEduCls_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId) == true) {
            const strComparisonOp_CurrEduClsId = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId, objvCurrEduCls_Cond.currEduClsId, strComparisonOp_CurrEduClsId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName) == true) {
            const strComparisonOp_EduClsName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName, objvCurrEduCls_Cond.eduClsName, strComparisonOp_EduClsName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeId) == true) {
            const strComparisonOp_EduClsTypeId = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeId, objvCurrEduCls_Cond.eduClsTypeId, strComparisonOp_EduClsTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeName) == true) {
            const strComparisonOp_EduClsTypeName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeName, objvCurrEduCls_Cond.eduClsTypeName, strComparisonOp_EduClsTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseId, objvCurrEduCls_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseCode) == true) {
            const strComparisonOp_CourseCode = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseCode, objvCurrEduCls_Cond.courseCode, strComparisonOp_CourseCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseDescription) == true) {
            const strComparisonOp_CourseDescription = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseDescription];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseDescription, objvCurrEduCls_Cond.courseDescription, strComparisonOp_CourseDescription);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseName, objvCurrEduCls_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ViewCount) == true) {
            const strComparisonOp_ViewCount = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ViewCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ViewCount, objvCurrEduCls_Cond.viewCount, strComparisonOp_ViewCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ExampleImgPath) == true) {
            const strComparisonOp_ExampleImgPath = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ExampleImgPath];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ExampleImgPath, objvCurrEduCls_Cond.exampleImgPath, strComparisonOp_ExampleImgPath);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionId) == true) {
            const strComparisonOp_TeachingSolutionId = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionId, objvCurrEduCls_Cond.teachingSolutionId, strComparisonOp_TeachingSolutionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionName) == true) {
            const strComparisonOp_TeachingSolutionName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionName, objvCurrEduCls_Cond.teachingSolutionName, strComparisonOp_TeachingSolutionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_Teacher) == true) {
            const strComparisonOp_id_Teacher = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_Teacher];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_Teacher, objvCurrEduCls_Cond.id_Teacher, strComparisonOp_id_Teacher);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherID) == true) {
            const strComparisonOp_TeacherID = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherID, objvCurrEduCls_Cond.teacherID, strComparisonOp_TeacherID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherName) == true) {
            const strComparisonOp_TeacherName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherName, objvCurrEduCls_Cond.teacherName, strComparisonOp_TeacherName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzCollege, objvCurrEduCls_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeID, objvCurrEduCls_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeName, objvCurrEduCls_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ClgEnglishName) == true) {
            const strComparisonOp_ClgEnglishName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ClgEnglishName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ClgEnglishName, objvCurrEduCls_Cond.clgEnglishName, strComparisonOp_ClgEnglishName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_PhoneNumber) == true) {
            const strComparisonOp_PhoneNumber = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_PhoneNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_PhoneNumber, objvCurrEduCls_Cond.phoneNumber, strComparisonOp_PhoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzMajor, objvCurrEduCls_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MajorName, objvCurrEduCls_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_EduWay) == true) {
            const strComparisonOp_id_EduWay = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_EduWay];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_EduWay, objvCurrEduCls_Cond.id_EduWay, strComparisonOp_id_EduWay);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ClassRoomType) == true) {
            const strComparisonOp_id_ClassRoomType = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ClassRoomType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ClassRoomType, objvCurrEduCls_Cond.id_ClassRoomType, strComparisonOp_id_ClassRoomType);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TotalLessonQty) == true) {
            const strComparisonOp_TotalLessonQty = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TotalLessonQty];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TotalLessonQty, objvCurrEduCls_Cond.totalLessonQty, strComparisonOp_TotalLessonQty);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MaxStuQty) == true) {
            const strComparisonOp_MaxStuQty = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MaxStuQty];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MaxStuQty, objvCurrEduCls_Cond.maxStuQty, strComparisonOp_MaxStuQty);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekQty) == true) {
            const strComparisonOp_WeekQty = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekQty];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekQty, objvCurrEduCls_Cond.weekQty, strComparisonOp_WeekQty);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekStatusID) == true) {
            const strComparisonOp_WeekStatusID = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekStatusID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekStatusID, objvCurrEduCls_Cond.weekStatusID, strComparisonOp_WeekStatusID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CustomerWeek) == true) {
            const strComparisonOp_CustomerWeek = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CustomerWeek];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CustomerWeek, objvCurrEduCls_Cond.customerWeek, strComparisonOp_CustomerWeek);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Mark) == true) {
            const strComparisonOp_Mark = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Mark];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Mark, objvCurrEduCls_Cond.mark, strComparisonOp_Mark);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_UniZone) == true) {
            const strComparisonOp_id_UniZone = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_UniZone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_UniZone, objvCurrEduCls_Cond.id_UniZone, strComparisonOp_id_UniZone);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_GradeBase, objvCurrEduCls_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseID) == true) {
            const strComparisonOp_GradeBaseID = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseID, objvCurrEduCls_Cond.gradeBaseID, strComparisonOp_GradeBaseID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseName) == true) {
            const strComparisonOp_GradeBaseName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseName, objvCurrEduCls_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseNameA) == true) {
            const strComparisonOp_GradeBaseNameA = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseNameA, objvCurrEduCls_Cond.gradeBaseNameA, strComparisonOp_GradeBaseNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsEffective) == true) {
            if (objvCurrEduCls_Cond.isEffective == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsEffective);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsEffective);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsForPaperReading) == true) {
            if (objvCurrEduCls_Cond.isForPaperReading == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsForPaperReading);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsForPaperReading);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolYear) == true) {
            const strComparisonOp_SchoolYear = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolYear, objvCurrEduCls_Cond.schoolYear, strComparisonOp_SchoolYear);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolTerm) == true) {
            const strComparisonOp_SchoolTerm = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolTerm];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolTerm, objvCurrEduCls_Cond.schoolTerm, strComparisonOp_SchoolTerm);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CourseType) == true) {
            const strComparisonOp_id_CourseType = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CourseType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CourseType, objvCurrEduCls_Cond.id_CourseType, strComparisonOp_id_CourseType);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeID) == true) {
            const strComparisonOp_CourseTypeID = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeID, objvCurrEduCls_Cond.courseTypeID, strComparisonOp_CourseTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeName) == true) {
            const strComparisonOp_CourseTypeName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeName, objvCurrEduCls_Cond.courseTypeName, strComparisonOp_CourseTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsDegree) == true) {
            if (objvCurrEduCls_Cond.isDegree == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsDegree);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsDegree);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ScoreType) == true) {
            const strComparisonOp_id_ScoreType = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ScoreType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ScoreType, objvCurrEduCls_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GetScoreWayId) == true) {
            const strComparisonOp_GetScoreWayId = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GetScoreWayId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GetScoreWayId, objvCurrEduCls_Cond.getScoreWayId, strComparisonOp_GetScoreWayId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsProportionalCtrl) == true) {
            if (objvCurrEduCls_Cond.isProportionalCtrl == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsProportionalCtrl);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsProportionalCtrl);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ExamType) == true) {
            const strComparisonOp_id_ExamType = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ExamType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ExamType, objvCurrEduCls_Cond.id_ExamType, strComparisonOp_id_ExamType);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyDate, objvCurrEduCls_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyUserID, objvCurrEduCls_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Memo, objvCurrEduCls_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum_Valid) == true) {
            const strComparisonOp_CurrStuNum_Valid = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum_Valid];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum_Valid, objvCurrEduCls_Cond.currStuNum_Valid, strComparisonOp_CurrStuNum_Valid);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum) == true) {
            const strComparisonOp_CurrStuNum = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum, objvCurrEduCls_Cond.currStuNum, strComparisonOp_CurrStuNum);
        }
        return strWhereCond;
    }
    exports.vCurrEduCls_GetCombineCondition = vCurrEduCls_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvCurrEduClsENS:源对象
     * @param objvCurrEduClsENT:目标对象
    */
    function vCurrEduCls_CopyObjTo(objvCurrEduClsENS, objvCurrEduClsENT) {
        objvCurrEduClsENT.id_CurrEduCls = objvCurrEduClsENS.id_CurrEduCls; //教学班流水号
        objvCurrEduClsENT.currEduClsId = objvCurrEduClsENS.currEduClsId; //教学班Id
        objvCurrEduClsENT.eduClsName = objvCurrEduClsENS.eduClsName; //教学班名
        objvCurrEduClsENT.eduClsTypeId = objvCurrEduClsENS.eduClsTypeId; //教学班类型Id
        objvCurrEduClsENT.eduClsTypeName = objvCurrEduClsENS.eduClsTypeName; //教学班类型名称
        objvCurrEduClsENT.courseId = objvCurrEduClsENS.courseId; //课程Id
        objvCurrEduClsENT.courseCode = objvCurrEduClsENS.courseCode; //课程代码
        objvCurrEduClsENT.courseDescription = objvCurrEduClsENS.courseDescription; //课程描述
        objvCurrEduClsENT.courseName = objvCurrEduClsENS.courseName; //课程名称
        objvCurrEduClsENT.viewCount = objvCurrEduClsENS.viewCount; //浏览量
        objvCurrEduClsENT.exampleImgPath = objvCurrEduClsENS.exampleImgPath; //示例图路径
        objvCurrEduClsENT.teachingSolutionId = objvCurrEduClsENS.teachingSolutionId; //教学方案Id
        objvCurrEduClsENT.teachingSolutionName = objvCurrEduClsENS.teachingSolutionName; //教学方案名称
        objvCurrEduClsENT.id_Teacher = objvCurrEduClsENS.id_Teacher; //教师流水号
        objvCurrEduClsENT.teacherID = objvCurrEduClsENS.teacherID; //教师工号
        objvCurrEduClsENT.teacherName = objvCurrEduClsENS.teacherName; //教师姓名
        objvCurrEduClsENT.id_XzCollege = objvCurrEduClsENS.id_XzCollege; //学院流水号
        objvCurrEduClsENT.collegeID = objvCurrEduClsENS.collegeID; //学院ID
        objvCurrEduClsENT.collegeName = objvCurrEduClsENS.collegeName; //学院名称
        objvCurrEduClsENT.clgEnglishName = objvCurrEduClsENS.clgEnglishName; //ClgEnglishName
        objvCurrEduClsENT.phoneNumber = objvCurrEduClsENS.phoneNumber; //PhoneNumber
        objvCurrEduClsENT.id_XzMajor = objvCurrEduClsENS.id_XzMajor; //专业流水号
        objvCurrEduClsENT.majorName = objvCurrEduClsENS.majorName; //专业名称
        objvCurrEduClsENT.id_EduWay = objvCurrEduClsENS.id_EduWay; //教学方式流水号
        objvCurrEduClsENT.id_ClassRoomType = objvCurrEduClsENS.id_ClassRoomType; //教室类型流水号
        objvCurrEduClsENT.totalLessonQty = objvCurrEduClsENS.totalLessonQty; //总课时数
        objvCurrEduClsENT.maxStuQty = objvCurrEduClsENS.maxStuQty; //最大学生数
        objvCurrEduClsENT.weekQty = objvCurrEduClsENS.weekQty; //总周数
        objvCurrEduClsENT.scheUnitPW = objvCurrEduClsENS.scheUnitPW; //周排课次数
        objvCurrEduClsENT.weekStatusID = objvCurrEduClsENS.weekStatusID; //周状态编号(单,双,全周)
        objvCurrEduClsENT.customerWeek = objvCurrEduClsENS.customerWeek; //自定义上课周
        objvCurrEduClsENT.lessonQtyPerWeek = objvCurrEduClsENS.lessonQtyPerWeek; //周课时数
        objvCurrEduClsENT.mark = objvCurrEduClsENS.mark; //获得学分
        objvCurrEduClsENT.id_UniZone = objvCurrEduClsENS.id_UniZone; //校区流水号
        objvCurrEduClsENT.id_GradeBase = objvCurrEduClsENS.id_GradeBase; //年级流水号
        objvCurrEduClsENT.gradeBaseID = objvCurrEduClsENS.gradeBaseID; //年级代号
        objvCurrEduClsENT.gradeBaseName = objvCurrEduClsENS.gradeBaseName; //年级名称
        objvCurrEduClsENT.gradeBaseNameA = objvCurrEduClsENS.gradeBaseNameA; //年级名称缩写
        objvCurrEduClsENT.isEffective = objvCurrEduClsENS.isEffective; //是否有效
        objvCurrEduClsENT.isForPaperReading = objvCurrEduClsENS.isForPaperReading; //是否参与论文阅读
        objvCurrEduClsENT.schoolYear = objvCurrEduClsENS.schoolYear; //学年
        objvCurrEduClsENT.schoolTerm = objvCurrEduClsENS.schoolTerm; //学期
        objvCurrEduClsENT.id_CourseType = objvCurrEduClsENS.id_CourseType; //课程类型流水号
        objvCurrEduClsENT.courseTypeID = objvCurrEduClsENS.courseTypeID; //课程类型ID
        objvCurrEduClsENT.courseTypeName = objvCurrEduClsENS.courseTypeName; //课程类型名称
        objvCurrEduClsENT.isDegree = objvCurrEduClsENS.isDegree; //是否学位课
        objvCurrEduClsENT.id_ScoreType = objvCurrEduClsENS.id_ScoreType; //成绩类型流水号
        objvCurrEduClsENT.getScoreWayId = objvCurrEduClsENS.getScoreWayId; //获得成绩方式Id
        objvCurrEduClsENT.isProportionalCtrl = objvCurrEduClsENS.isProportionalCtrl; //是否比例控制
        objvCurrEduClsENT.id_ExamType = objvCurrEduClsENS.id_ExamType; //考试方式流水号
        objvCurrEduClsENT.beginWeek = objvCurrEduClsENS.beginWeek; //开始周
        objvCurrEduClsENT.modifyDate = objvCurrEduClsENS.modifyDate; //修改日期
        objvCurrEduClsENT.modifyUserID = objvCurrEduClsENS.modifyUserID; //修改人
        objvCurrEduClsENT.memo = objvCurrEduClsENS.memo; //备注
        objvCurrEduClsENT.currStuNum_Valid = objvCurrEduClsENS.currStuNum_Valid; //CurrStuNum_Valid
        objvCurrEduClsENT.currStuNum = objvCurrEduClsENS.currStuNum; //当前学生数
    }
    exports.vCurrEduCls_CopyObjTo = vCurrEduCls_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvCurrEduClsENS:源对象
     * @param objvCurrEduClsENT:目标对象
    */
    function vCurrEduCls_GetObjFromJsonObj(objvCurrEduClsENS) {
        const objvCurrEduClsENT = new clsvCurrEduClsEN_js_1.clsvCurrEduClsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduClsENT, objvCurrEduClsENS);
        return objvCurrEduClsENT;
    }
    exports.vCurrEduCls_GetObjFromJsonObj = vCurrEduCls_GetObjFromJsonObj;
});
