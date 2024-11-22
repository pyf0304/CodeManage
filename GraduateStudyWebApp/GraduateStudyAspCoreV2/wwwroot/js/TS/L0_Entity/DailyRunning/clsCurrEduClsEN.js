(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTab.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsCurrEduClsEN = void 0;
    /**
    * 类名:clsCurrEduClsEN
    * 表名:CurrEduCls(01120123)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:45:09
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:日常运行(DailyRunning)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 当前教学班(CurrEduCls)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsCurrEduClsEN extends clsGeneralTab_js_1.clsGeneralTab {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            /**
             * 设置对象中私有属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPrivateVar)
            */
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrCurrEduClsId = ""; //教学班Id
            this.mstrEduClsName = ""; //教学班名
            this.mstrEduClsTypeId = ""; //教学班类型Id
            this.mstrCourseId = ""; //课程Id
            this.mstrTeachingSolutionId = ""; //教学方案Id
            this.mstrid_XzCollege = ""; //学院流水号
            this.mstrid_XzMajor = ""; //专业流水号
            this.mstrid_EduWay = ""; //教学方式流水号
            this.mstrid_ClassRoomType = ""; //教室类型流水号
            this.mintTotalLessonQty = 0; //总课时数
            this.mintMaxStuQty = 0; //最大学生数
            this.mintWeekQty = 0; //总周数
            this.mshtScheUnitPW = 0; //周排课次数
            this.mstrWeekStatusID = ""; //周状态编号(单,双,全周)
            this.mstrCustomerWeek = ""; //自定义上课周
            this.mshtLessonQtyPerWeek = 0; //周课时数
            this.mdblMark = 0; //获得学分
            this.mstrid_UniZone = ""; //校区流水号
            this.mstrid_GradeBase = ""; //年级流水号
            this.mbolIsEffective = false; //是否有效
            this.mbolIsForPaperReading = false; //是否参与论文阅读
            this.mstrSchoolYear = ""; //学年
            this.mstrSchoolTerm = ""; //学期
            this.mstrid_CourseType = ""; //课程类型流水号
            this.mbolIsDegree = false; //是否学位课
            this.mstrid_ScoreType = ""; //成绩类型流水号
            this.mstrGetScoreWayId = ""; //获得成绩方式Id
            this.mbolIsProportionalCtrl = false; //是否比例控制
            this.mstrid_ExamType = ""; //考试方式流水号
            this.mstrExamTime = ""; //考试时间
            this.mshtBeginWeek = 0; //开始周
            this.mstrModifyDate = ""; //修改日期
            this.mstrModifyUserID = ""; //修改人
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.id_CurrEduCls = ""; //教学班流水号
            this.currEduClsId = ""; //教学班Id
            this.eduClsName = ""; //教学班名
            this.eduClsTypeId = ""; //教学班类型Id
            this.courseId = ""; //课程Id
            this.teachingSolutionId = ""; //教学方案Id
            this.id_XzCollege = ""; //学院流水号
            this.id_XzMajor = ""; //专业流水号
            this.id_EduWay = ""; //教学方式流水号
            this.id_ClassRoomType = ""; //教室类型流水号
            this.totalLessonQty = 0; //总课时数
            this.maxStuQty = 0; //最大学生数
            this.weekQty = 0; //总周数
            this.scheUnitPW = 0; //周排课次数
            this.weekStatusID = ""; //周状态编号(单,双,全周)
            this.customerWeek = ""; //自定义上课周
            this.lessonQtyPerWeek = 0; //周课时数
            this.mark = 0; //获得学分
            this.id_UniZone = ""; //校区流水号
            this.id_GradeBase = ""; //年级流水号
            this.isEffective = false; //是否有效
            this.isForPaperReading = false; //是否参与论文阅读
            this.schoolYear = ""; //学年
            this.schoolTerm = ""; //学期
            this.id_CourseType = ""; //课程类型流水号
            this.isDegree = false; //是否学位课
            this.id_ScoreType = ""; //成绩类型流水号
            this.getScoreWayId = ""; //获得成绩方式Id
            this.isProportionalCtrl = false; //是否比例控制
            this.id_ExamType = ""; //考试方式流水号
            this.examTime = ""; //考试时间
            this.beginWeek = 0; //开始周
            this.modifyDate = ""; //修改日期
            this.modifyUserID = ""; //修改人
            this.memo = ""; //备注
        }
        /**
         * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_CurrEduCls(value) {
            if (value != undefined) {
                this.id_CurrEduCls = value;
                this.hmProperty["id_CurrEduCls"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教学班Id(说明:;字段类型:varchar;字段长度:15;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCurrEduClsId(value) {
            if (value != undefined) {
                this.currEduClsId = value;
                this.hmProperty["currEduClsId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教学班名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetEduClsName(value) {
            if (value != undefined) {
                this.eduClsName = value;
                this.hmProperty["eduClsName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教学班类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetEduClsTypeId(value) {
            if (value != undefined) {
                this.eduClsTypeId = value;
                this.hmProperty["eduClsTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseId(value) {
            if (value != undefined) {
                this.courseId = value;
                this.hmProperty["courseId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教学方案Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTeachingSolutionId(value) {
            if (value != undefined) {
                this.teachingSolutionId = value;
                this.hmProperty["teachingSolutionId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_XzCollege(value) {
            if (value != undefined) {
                this.id_XzCollege = value;
                this.hmProperty["id_XzCollege"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_XzMajor(value) {
            if (value != undefined) {
                this.id_XzMajor = value;
                this.hmProperty["id_XzMajor"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教学方式流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_EduWay(value) {
            if (value != undefined) {
                this.id_EduWay = value;
                this.hmProperty["id_EduWay"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教室类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_ClassRoomType(value) {
            if (value != undefined) {
                this.id_ClassRoomType = value;
                this.hmProperty["id_ClassRoomType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 总课时数(说明:;字段类型:int;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTotalLessonQty(value) {
            if (value != undefined) {
                this.totalLessonQty = value;
                this.hmProperty["totalLessonQty"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 最大学生数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMaxStuQty(value) {
            if (value != undefined) {
                this.maxStuQty = value;
                this.hmProperty["maxStuQty"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 总周数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetWeekQty(value) {
            if (value != undefined) {
                this.weekQty = value;
                this.hmProperty["weekQty"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 周排课次数(说明:;字段类型:smallint;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetScheUnitPW(value) {
            if (value != undefined) {
                this.scheUnitPW = value;
                this.hmProperty["scheUnitPW"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 周状态编号(单,双,全周)(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetWeekStatusID(value) {
            if (value != undefined) {
                this.weekStatusID = value;
                this.hmProperty["weekStatusID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 自定义上课周(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCustomerWeek(value) {
            if (value != undefined) {
                this.customerWeek = value;
                this.hmProperty["customerWeek"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 周课时数(说明:;字段类型:smallint;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLessonQtyPerWeek(value) {
            if (value != undefined) {
                this.lessonQtyPerWeek = value;
                this.hmProperty["lessonQtyPerWeek"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 获得学分(说明:;字段类型:decimal;字段长度:7;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMark(value) {
            if (value != undefined) {
                this.mark = value;
                this.hmProperty["mark"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_UniZone(value) {
            if (value != undefined) {
                this.id_UniZone = value;
                this.hmProperty["id_UniZone"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_GradeBase(value) {
            if (value != undefined) {
                this.id_GradeBase = value;
                this.hmProperty["id_GradeBase"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否有效(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsEffective(value) {
            if (value != undefined) {
                this.isEffective = value;
                this.hmProperty["isEffective"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否参与论文阅读(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsForPaperReading(value) {
            if (value != undefined) {
                this.isForPaperReading = value;
                this.hmProperty["isForPaperReading"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolYear(value) {
            if (value != undefined) {
                this.schoolYear = value;
                this.hmProperty["schoolYear"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolTerm(value) {
            if (value != undefined) {
                this.schoolTerm = value;
                this.hmProperty["schoolTerm"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_CourseType(value) {
            if (value != undefined) {
                this.id_CourseType = value;
                this.hmProperty["id_CourseType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否学位课(说明:;字段类型:bit;字段长度:1;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsDegree(value) {
            if (value != undefined) {
                this.isDegree = value;
                this.hmProperty["isDegree"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 成绩类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_ScoreType(value) {
            if (value != undefined) {
                this.id_ScoreType = value;
                this.hmProperty["id_ScoreType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 获得成绩方式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetGetScoreWayId(value) {
            if (value != undefined) {
                this.getScoreWayId = value;
                this.hmProperty["getScoreWayId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否比例控制(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsProportionalCtrl(value) {
            if (value != undefined) {
                this.isProportionalCtrl = value;
                this.hmProperty["isProportionalCtrl"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 考试方式流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_ExamType(value) {
            if (value != undefined) {
                this.id_ExamType = value;
                this.hmProperty["id_ExamType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 考试时间(说明:;字段类型:varchar;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetExamTime(value) {
            if (value != undefined) {
                this.examTime = value;
                this.hmProperty["examTime"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 开始周(说明:;字段类型:smallint;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetBeginWeek(value) {
            if (value != undefined) {
                this.beginWeek = value;
                this.hmProperty["beginWeek"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetModifyDate(value) {
            if (value != undefined) {
                this.modifyDate = value;
                this.hmProperty["modifyDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetModifyUserID(value) {
            if (value != undefined) {
                this.modifyUserID = value;
                this.hmProperty["modifyUserID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMemo(value) {
            if (value != undefined) {
                this.memo = value;
                this.hmProperty["memo"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsCurrEduClsEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsCurrEduClsEN.con_CurrEduClsId:
                    return this.currEduClsId;
                case clsCurrEduClsEN.con_EduClsName:
                    return this.eduClsName;
                case clsCurrEduClsEN.con_EduClsTypeId:
                    return this.eduClsTypeId;
                case clsCurrEduClsEN.con_CourseId:
                    return this.courseId;
                case clsCurrEduClsEN.con_TeachingSolutionId:
                    return this.teachingSolutionId;
                case clsCurrEduClsEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsCurrEduClsEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsCurrEduClsEN.con_id_EduWay:
                    return this.id_EduWay;
                case clsCurrEduClsEN.con_id_ClassRoomType:
                    return this.id_ClassRoomType;
                case clsCurrEduClsEN.con_TotalLessonQty:
                    return this.totalLessonQty;
                case clsCurrEduClsEN.con_MaxStuQty:
                    return this.maxStuQty;
                case clsCurrEduClsEN.con_WeekQty:
                    return this.weekQty;
                case clsCurrEduClsEN.con_ScheUnitPW:
                    return this.scheUnitPW;
                case clsCurrEduClsEN.con_WeekStatusID:
                    return this.weekStatusID;
                case clsCurrEduClsEN.con_CustomerWeek:
                    return this.customerWeek;
                case clsCurrEduClsEN.con_LessonQtyPerWeek:
                    return this.lessonQtyPerWeek;
                case clsCurrEduClsEN.con_Mark:
                    return this.mark;
                case clsCurrEduClsEN.con_id_UniZone:
                    return this.id_UniZone;
                case clsCurrEduClsEN.con_id_GradeBase:
                    return this.id_GradeBase;
                case clsCurrEduClsEN.con_IsEffective:
                    return this.isEffective;
                case clsCurrEduClsEN.con_IsForPaperReading:
                    return this.isForPaperReading;
                case clsCurrEduClsEN.con_SchoolYear:
                    return this.schoolYear;
                case clsCurrEduClsEN.con_SchoolTerm:
                    return this.schoolTerm;
                case clsCurrEduClsEN.con_id_CourseType:
                    return this.id_CourseType;
                case clsCurrEduClsEN.con_IsDegree:
                    return this.isDegree;
                case clsCurrEduClsEN.con_id_ScoreType:
                    return this.id_ScoreType;
                case clsCurrEduClsEN.con_GetScoreWayId:
                    return this.getScoreWayId;
                case clsCurrEduClsEN.con_IsProportionalCtrl:
                    return this.isProportionalCtrl;
                case clsCurrEduClsEN.con_id_ExamType:
                    return this.id_ExamType;
                case clsCurrEduClsEN.con_ExamTime:
                    return this.examTime;
                case clsCurrEduClsEN.con_BeginWeek:
                    return this.beginWeek;
                case clsCurrEduClsEN.con_ModifyDate:
                    return this.modifyDate;
                case clsCurrEduClsEN.con_ModifyUserID:
                    return this.modifyUserID;
                case clsCurrEduClsEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[CurrEduCls]中不存在！`;
                    console.error(strMsg);
                    return "";
            }
        }
        /**
         * 设置对象中某字段名的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetFldValue)
         * @param strFldName:字段名
         * @param strValue:字段值
         * @returns 字段值
        */
        SetFldValue(strFldName, strValue) {
            const strThisFuncName = "SetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsCurrEduClsEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsCurrEduClsEN.con_CurrEduClsId:
                    this.currEduClsId = strValue;
                    this.hmProperty["currEduClsId"] = true;
                    break;
                case clsCurrEduClsEN.con_EduClsName:
                    this.eduClsName = strValue;
                    this.hmProperty["eduClsName"] = true;
                    break;
                case clsCurrEduClsEN.con_EduClsTypeId:
                    this.eduClsTypeId = strValue;
                    this.hmProperty["eduClsTypeId"] = true;
                    break;
                case clsCurrEduClsEN.con_CourseId:
                    this.courseId = strValue;
                    this.hmProperty["courseId"] = true;
                    break;
                case clsCurrEduClsEN.con_TeachingSolutionId:
                    this.teachingSolutionId = strValue;
                    this.hmProperty["teachingSolutionId"] = true;
                    break;
                case clsCurrEduClsEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    this.hmProperty["id_XzCollege"] = true;
                    break;
                case clsCurrEduClsEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    this.hmProperty["id_XzMajor"] = true;
                    break;
                case clsCurrEduClsEN.con_id_EduWay:
                    this.id_EduWay = strValue;
                    this.hmProperty["id_EduWay"] = true;
                    break;
                case clsCurrEduClsEN.con_id_ClassRoomType:
                    this.id_ClassRoomType = strValue;
                    this.hmProperty["id_ClassRoomType"] = true;
                    break;
                case clsCurrEduClsEN.con_TotalLessonQty:
                    this.totalLessonQty = Number(strValue);
                    this.hmProperty["totalLessonQty"] = true;
                    break;
                case clsCurrEduClsEN.con_MaxStuQty:
                    this.maxStuQty = Number(strValue);
                    this.hmProperty["maxStuQty"] = true;
                    break;
                case clsCurrEduClsEN.con_WeekQty:
                    this.weekQty = Number(strValue);
                    this.hmProperty["weekQty"] = true;
                    break;
                case clsCurrEduClsEN.con_ScheUnitPW:
                    this.scheUnitPW = Number(strValue);
                    this.hmProperty["scheUnitPW"] = true;
                    break;
                case clsCurrEduClsEN.con_WeekStatusID:
                    this.weekStatusID = strValue;
                    this.hmProperty["weekStatusID"] = true;
                    break;
                case clsCurrEduClsEN.con_CustomerWeek:
                    this.customerWeek = strValue;
                    this.hmProperty["customerWeek"] = true;
                    break;
                case clsCurrEduClsEN.con_LessonQtyPerWeek:
                    this.lessonQtyPerWeek = Number(strValue);
                    this.hmProperty["lessonQtyPerWeek"] = true;
                    break;
                case clsCurrEduClsEN.con_Mark:
                    this.mark = Number(strValue);
                    this.hmProperty["mark"] = true;
                    break;
                case clsCurrEduClsEN.con_id_UniZone:
                    this.id_UniZone = strValue;
                    this.hmProperty["id_UniZone"] = true;
                    break;
                case clsCurrEduClsEN.con_id_GradeBase:
                    this.id_GradeBase = strValue;
                    this.hmProperty["id_GradeBase"] = true;
                    break;
                case clsCurrEduClsEN.con_IsEffective:
                    this.isEffective = Boolean(strValue);
                    this.hmProperty["isEffective"] = true;
                    break;
                case clsCurrEduClsEN.con_IsForPaperReading:
                    this.isForPaperReading = Boolean(strValue);
                    this.hmProperty["isForPaperReading"] = true;
                    break;
                case clsCurrEduClsEN.con_SchoolYear:
                    this.schoolYear = strValue;
                    this.hmProperty["schoolYear"] = true;
                    break;
                case clsCurrEduClsEN.con_SchoolTerm:
                    this.schoolTerm = strValue;
                    this.hmProperty["schoolTerm"] = true;
                    break;
                case clsCurrEduClsEN.con_id_CourseType:
                    this.id_CourseType = strValue;
                    this.hmProperty["id_CourseType"] = true;
                    break;
                case clsCurrEduClsEN.con_IsDegree:
                    this.isDegree = Boolean(strValue);
                    this.hmProperty["isDegree"] = true;
                    break;
                case clsCurrEduClsEN.con_id_ScoreType:
                    this.id_ScoreType = strValue;
                    this.hmProperty["id_ScoreType"] = true;
                    break;
                case clsCurrEduClsEN.con_GetScoreWayId:
                    this.getScoreWayId = strValue;
                    this.hmProperty["getScoreWayId"] = true;
                    break;
                case clsCurrEduClsEN.con_IsProportionalCtrl:
                    this.isProportionalCtrl = Boolean(strValue);
                    this.hmProperty["isProportionalCtrl"] = true;
                    break;
                case clsCurrEduClsEN.con_id_ExamType:
                    this.id_ExamType = strValue;
                    this.hmProperty["id_ExamType"] = true;
                    break;
                case clsCurrEduClsEN.con_ExamTime:
                    this.examTime = strValue;
                    this.hmProperty["examTime"] = true;
                    break;
                case clsCurrEduClsEN.con_BeginWeek:
                    this.beginWeek = Number(strValue);
                    this.hmProperty["beginWeek"] = true;
                    break;
                case clsCurrEduClsEN.con_ModifyDate:
                    this.modifyDate = strValue;
                    this.hmProperty["modifyDate"] = true;
                    break;
                case clsCurrEduClsEN.con_ModifyUserID:
                    this.modifyUserID = strValue;
                    this.hmProperty["modifyUserID"] = true;
                    break;
                case clsCurrEduClsEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[CurrEduCls]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"CurrEduClsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CurrEduClsId() { return "currEduClsId"; } //教学班Id
        /**
        * 常量:"EduClsName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsName() { return "eduClsName"; } //教学班名
        /**
        * 常量:"EduClsTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsTypeId() { return "eduClsTypeId"; } //教学班类型Id
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"TeachingSolutionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeachingSolutionId() { return "teachingSolutionId"; } //教学方案Id
        /**
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
        /**
        * 常量:"id_EduWay"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_EduWay() { return "id_EduWay"; } //教学方式流水号
        /**
        * 常量:"id_ClassRoomType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_ClassRoomType() { return "id_ClassRoomType"; } //教室类型流水号
        /**
        * 常量:"TotalLessonQty"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TotalLessonQty() { return "totalLessonQty"; } //总课时数
        /**
        * 常量:"MaxStuQty"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MaxStuQty() { return "maxStuQty"; } //最大学生数
        /**
        * 常量:"WeekQty"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_WeekQty() { return "weekQty"; } //总周数
        /**
        * 常量:"ScheUnitPW"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ScheUnitPW() { return "scheUnitPW"; } //周排课次数
        /**
        * 常量:"WeekStatusID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_WeekStatusID() { return "weekStatusID"; } //周状态编号(单,双,全周)
        /**
        * 常量:"CustomerWeek"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CustomerWeek() { return "customerWeek"; } //自定义上课周
        /**
        * 常量:"LessonQtyPerWeek"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LessonQtyPerWeek() { return "lessonQtyPerWeek"; } //周课时数
        /**
        * 常量:"Mark"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Mark() { return "mark"; } //获得学分
        /**
        * 常量:"id_UniZone"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_UniZone() { return "id_UniZone"; } //校区流水号
        /**
        * 常量:"id_GradeBase"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_GradeBase() { return "id_GradeBase"; } //年级流水号
        /**
        * 常量:"IsEffective"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsEffective() { return "isEffective"; } //是否有效
        /**
        * 常量:"IsForPaperReading"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsForPaperReading() { return "isForPaperReading"; } //是否参与论文阅读
        /**
        * 常量:"SchoolYear"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolYear() { return "schoolYear"; } //学年
        /**
        * 常量:"SchoolTerm"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolTerm() { return "schoolTerm"; } //学期
        /**
        * 常量:"id_CourseType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CourseType() { return "id_CourseType"; } //课程类型流水号
        /**
        * 常量:"IsDegree"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsDegree() { return "isDegree"; } //是否学位课
        /**
        * 常量:"id_ScoreType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_ScoreType() { return "id_ScoreType"; } //成绩类型流水号
        /**
        * 常量:"GetScoreWayId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GetScoreWayId() { return "getScoreWayId"; } //获得成绩方式Id
        /**
        * 常量:"IsProportionalCtrl"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsProportionalCtrl() { return "isProportionalCtrl"; } //是否比例控制
        /**
        * 常量:"id_ExamType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_ExamType() { return "id_ExamType"; } //考试方式流水号
        /**
        * 常量:"ExamTime"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExamTime() { return "examTime"; } //考试时间
        /**
        * 常量:"BeginWeek"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BeginWeek() { return "beginWeek"; } //开始周
        /**
        * 常量:"ModifyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyDate() { return "modifyDate"; } //修改日期
        /**
        * 常量:"ModifyUserID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyUserID() { return "modifyUserID"; } //修改人
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 设置条件字段值.
        * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetCondFldValue)
        * @param strFldName:字段名
        * @param strFldValue:字段值
        * @param strComparisonOp:比较操作条符
        * @returns 根据关键字获取的名称
        **/
        SetCondFldValue(strFldName, strFldValue, strComparisonOp) {
            const strThisFuncName = this.SetCondFldValue.name;
            this.SetFldValue(strFldName, strFldValue);
            if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false) {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            else {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
        }
    }
    exports.clsCurrEduClsEN = clsCurrEduClsEN;
    clsCurrEduClsEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsCurrEduClsEN.CacheModeId = "04"; //sessionStorage
    clsCurrEduClsEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsCurrEduClsEN.WhereFormat = ""; //条件格式串
    clsCurrEduClsEN._CurrTabName = "CurrEduCls"; //当前表名,与该类相关的表名
    clsCurrEduClsEN._KeyFldName = "id_CurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsCurrEduClsEN.mintAttributeCount = 35;
    clsCurrEduClsEN.AttributeName = ["id_CurrEduCls", "currEduClsId", "eduClsName", "eduClsTypeId", "courseId", "teachingSolutionId", "id_XzCollege", "id_XzMajor", "id_EduWay", "id_ClassRoomType", "totalLessonQty", "maxStuQty", "weekQty", "scheUnitPW", "weekStatusID", "customerWeek", "lessonQtyPerWeek", "mark", "id_UniZone", "id_GradeBase", "isEffective", "isForPaperReading", "schoolYear", "schoolTerm", "id_CourseType", "isDegree", "id_ScoreType", "getScoreWayId", "isProportionalCtrl", "id_ExamType", "examTime", "beginWeek", "modifyDate", "modifyUserID", "memo"];
});
