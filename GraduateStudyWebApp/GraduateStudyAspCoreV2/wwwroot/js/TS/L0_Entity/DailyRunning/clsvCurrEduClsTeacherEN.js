(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTabV.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvCurrEduClsTeacherEN = void 0;
    /**
    * 类名:clsvCurrEduClsTeacherEN
    * 表名:vCurrEduClsTeacher(01120128)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:46:43
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
    * v当前教学班教师(vCurrEduClsTeacher)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvCurrEduClsTeacherEN extends clsGeneralTabV_js_1.clsGeneralTabV {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.id_EduClsTeacher = 0; //教学班老师流水号
            this.id_CurrEduCls = ""; //教学班流水号
            this.currEduClsId = ""; //教学班Id
            this.eduClsName = ""; //教学班名
            this.eduClsTypeId = ""; //教学班类型Id
            this.eduClsTypeName = ""; //教学班类型名称
            this.courseId = ""; //课程Id
            this.courseCode = ""; //课程代码
            this.courseName = ""; //课程名称
            this.exampleImgPath = ""; //示例图路径
            this.teachingSolutionId = ""; //教学方案Id
            this.teachingSolutionName = ""; //教学方案名称
            this.id_XzCollege = ""; //学院流水号
            this.collegeID = ""; //学院ID
            this.id_EduWay = ""; //教学方式流水号
            this.totalLessonQty = 0; //总课时数
            this.maxStuQty = 0; //最大学生数
            this.weekQty = 0; //总周数
            this.scheUnitPW = 0; //周排课次数
            this.weekStatusID = ""; //周状态编号(单,双,全周)
            this.customerWeek = ""; //自定义上课周
            this.lessonQtyPerWeek = 0; //周课时数
            this.id_UniZone = ""; //校区流水号
            this.id_GradeBase = ""; //年级流水号
            this.gradeBaseID = ""; //年级代号
            this.gradeBaseName = ""; //年级名称
            this.isEffective = false; //是否有效
            this.id_CourseType = ""; //课程类型流水号
            this.courseTypeID = ""; //课程类型ID
            this.courseTypeName = ""; //课程类型名称
            this.isDegree = false; //是否学位课
            this.id_ScoreType = ""; //成绩类型流水号
            this.isProportionalCtrl = false; //是否比例控制
            this.id_ExamType = ""; //考试方式流水号
            this.beginWeek = 0; //开始周
            this.currStuNum_Valid = 0; //CurrStuNum_Valid
            this.currStuNum = 0; //当前学生数
            this.id_Teacher = ""; //教师流水号
            this.teacherID = ""; //教师工号
            this.teacherName = ""; //教师姓名
            this.id_ProfGrade = ""; //专业职称流水号
            this.profenssionalGradeName = ""; //专业职称
            this.degreeName = ""; //学位名称
            this.birthday = ""; //出生日期
            this.isGpUser = false; //是否Gp用户
            this.collegeName = ""; //学院名称
            this.id_Pk2EduClsTeacherType = ""; //教学班老师角色(主讲,辅导)流水号
            this.eduClsTeacherTypeID = ""; //教学班教学类型ID
            this.eduClsTeacherTypeDesc = ""; //教学班教师类型名
            this.schoolTerm = ""; //学期
            this.schoolYear = ""; //学年
            this.openBeginDate = ""; //开放开始日期
            this.openEndDate = ""; //开放结束日期
            this.orderNum = 0; //序号
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.collegeName4EduCls = ""; //学院名_教学班
            this.collegeName4Teacher = ""; //学院名_教师
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
                case clsvCurrEduClsTeacherEN.con_id_EduClsTeacher:
                    return this.id_EduClsTeacher;
                case clsvCurrEduClsTeacherEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvCurrEduClsTeacherEN.con_CurrEduClsId:
                    return this.currEduClsId;
                case clsvCurrEduClsTeacherEN.con_EduClsName:
                    return this.eduClsName;
                case clsvCurrEduClsTeacherEN.con_EduClsTypeId:
                    return this.eduClsTypeId;
                case clsvCurrEduClsTeacherEN.con_EduClsTypeName:
                    return this.eduClsTypeName;
                case clsvCurrEduClsTeacherEN.con_CourseId:
                    return this.courseId;
                case clsvCurrEduClsTeacherEN.con_CourseCode:
                    return this.courseCode;
                case clsvCurrEduClsTeacherEN.con_CourseName:
                    return this.courseName;
                case clsvCurrEduClsTeacherEN.con_ExampleImgPath:
                    return this.exampleImgPath;
                case clsvCurrEduClsTeacherEN.con_TeachingSolutionId:
                    return this.teachingSolutionId;
                case clsvCurrEduClsTeacherEN.con_TeachingSolutionName:
                    return this.teachingSolutionName;
                case clsvCurrEduClsTeacherEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvCurrEduClsTeacherEN.con_CollegeID:
                    return this.collegeID;
                case clsvCurrEduClsTeacherEN.con_id_EduWay:
                    return this.id_EduWay;
                case clsvCurrEduClsTeacherEN.con_TotalLessonQty:
                    return this.totalLessonQty;
                case clsvCurrEduClsTeacherEN.con_MaxStuQty:
                    return this.maxStuQty;
                case clsvCurrEduClsTeacherEN.con_WeekQty:
                    return this.weekQty;
                case clsvCurrEduClsTeacherEN.con_ScheUnitPW:
                    return this.scheUnitPW;
                case clsvCurrEduClsTeacherEN.con_WeekStatusID:
                    return this.weekStatusID;
                case clsvCurrEduClsTeacherEN.con_CustomerWeek:
                    return this.customerWeek;
                case clsvCurrEduClsTeacherEN.con_LessonQtyPerWeek:
                    return this.lessonQtyPerWeek;
                case clsvCurrEduClsTeacherEN.con_id_UniZone:
                    return this.id_UniZone;
                case clsvCurrEduClsTeacherEN.con_id_GradeBase:
                    return this.id_GradeBase;
                case clsvCurrEduClsTeacherEN.con_GradeBaseID:
                    return this.gradeBaseID;
                case clsvCurrEduClsTeacherEN.con_GradeBaseName:
                    return this.gradeBaseName;
                case clsvCurrEduClsTeacherEN.con_IsEffective:
                    return this.isEffective;
                case clsvCurrEduClsTeacherEN.con_id_CourseType:
                    return this.id_CourseType;
                case clsvCurrEduClsTeacherEN.con_CourseTypeID:
                    return this.courseTypeID;
                case clsvCurrEduClsTeacherEN.con_CourseTypeName:
                    return this.courseTypeName;
                case clsvCurrEduClsTeacherEN.con_IsDegree:
                    return this.isDegree;
                case clsvCurrEduClsTeacherEN.con_id_ScoreType:
                    return this.id_ScoreType;
                case clsvCurrEduClsTeacherEN.con_IsProportionalCtrl:
                    return this.isProportionalCtrl;
                case clsvCurrEduClsTeacherEN.con_id_ExamType:
                    return this.id_ExamType;
                case clsvCurrEduClsTeacherEN.con_BeginWeek:
                    return this.beginWeek;
                case clsvCurrEduClsTeacherEN.con_CurrStuNum_Valid:
                    return this.currStuNum_Valid;
                case clsvCurrEduClsTeacherEN.con_CurrStuNum:
                    return this.currStuNum;
                case clsvCurrEduClsTeacherEN.con_id_Teacher:
                    return this.id_Teacher;
                case clsvCurrEduClsTeacherEN.con_TeacherID:
                    return this.teacherID;
                case clsvCurrEduClsTeacherEN.con_TeacherName:
                    return this.teacherName;
                case clsvCurrEduClsTeacherEN.con_id_ProfGrade:
                    return this.id_ProfGrade;
                case clsvCurrEduClsTeacherEN.con_ProfenssionalGradeName:
                    return this.profenssionalGradeName;
                case clsvCurrEduClsTeacherEN.con_DegreeName:
                    return this.degreeName;
                case clsvCurrEduClsTeacherEN.con_Birthday:
                    return this.birthday;
                case clsvCurrEduClsTeacherEN.con_IsGpUser:
                    return this.isGpUser;
                case clsvCurrEduClsTeacherEN.con_CollegeName:
                    return this.collegeName;
                case clsvCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
                    return this.id_Pk2EduClsTeacherType;
                case clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeID:
                    return this.eduClsTeacherTypeID;
                case clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeDesc:
                    return this.eduClsTeacherTypeDesc;
                case clsvCurrEduClsTeacherEN.con_SchoolTerm:
                    return this.schoolTerm;
                case clsvCurrEduClsTeacherEN.con_SchoolYear:
                    return this.schoolYear;
                case clsvCurrEduClsTeacherEN.con_OpenBeginDate:
                    return this.openBeginDate;
                case clsvCurrEduClsTeacherEN.con_OpenEndDate:
                    return this.openEndDate;
                case clsvCurrEduClsTeacherEN.con_OrderNum:
                    return this.orderNum;
                case clsvCurrEduClsTeacherEN.con_UpdDate:
                    return this.updDate;
                case clsvCurrEduClsTeacherEN.con_UpdUser:
                    return this.updUser;
                case clsvCurrEduClsTeacherEN.con_Memo:
                    return this.memo;
                case clsvCurrEduClsTeacherEN.con_CollegeName4EduCls:
                    return this.collegeName4EduCls;
                case clsvCurrEduClsTeacherEN.con_CollegeName4Teacher:
                    return this.collegeName4Teacher;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vCurrEduClsTeacher]中不存在！`;
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
                case clsvCurrEduClsTeacherEN.con_id_EduClsTeacher:
                    this.id_EduClsTeacher = Number(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_CurrEduClsId:
                    this.currEduClsId = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_EduClsName:
                    this.eduClsName = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_EduClsTypeId:
                    this.eduClsTypeId = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_EduClsTypeName:
                    this.eduClsTypeName = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_CourseId:
                    this.courseId = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_CourseCode:
                    this.courseCode = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_CourseName:
                    this.courseName = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_ExampleImgPath:
                    this.exampleImgPath = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_TeachingSolutionId:
                    this.teachingSolutionId = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_TeachingSolutionName:
                    this.teachingSolutionName = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_CollegeID:
                    this.collegeID = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_id_EduWay:
                    this.id_EduWay = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_TotalLessonQty:
                    this.totalLessonQty = Number(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_MaxStuQty:
                    this.maxStuQty = Number(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_WeekQty:
                    this.weekQty = Number(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_ScheUnitPW:
                    this.scheUnitPW = Number(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_WeekStatusID:
                    this.weekStatusID = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_CustomerWeek:
                    this.customerWeek = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_LessonQtyPerWeek:
                    this.lessonQtyPerWeek = Number(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_id_UniZone:
                    this.id_UniZone = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_id_GradeBase:
                    this.id_GradeBase = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_GradeBaseID:
                    this.gradeBaseID = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_GradeBaseName:
                    this.gradeBaseName = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_IsEffective:
                    this.isEffective = Boolean(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_id_CourseType:
                    this.id_CourseType = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_CourseTypeID:
                    this.courseTypeID = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_CourseTypeName:
                    this.courseTypeName = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_IsDegree:
                    this.isDegree = Boolean(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_id_ScoreType:
                    this.id_ScoreType = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_IsProportionalCtrl:
                    this.isProportionalCtrl = Boolean(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_id_ExamType:
                    this.id_ExamType = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_BeginWeek:
                    this.beginWeek = Number(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_CurrStuNum_Valid:
                    this.currStuNum_Valid = Number(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_CurrStuNum:
                    this.currStuNum = Number(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_id_Teacher:
                    this.id_Teacher = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_TeacherID:
                    this.teacherID = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_TeacherName:
                    this.teacherName = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_id_ProfGrade:
                    this.id_ProfGrade = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_ProfenssionalGradeName:
                    this.profenssionalGradeName = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_DegreeName:
                    this.degreeName = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_Birthday:
                    this.birthday = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_IsGpUser:
                    this.isGpUser = Boolean(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
                    this.id_Pk2EduClsTeacherType = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeID:
                    this.eduClsTeacherTypeID = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeDesc:
                    this.eduClsTeacherTypeDesc = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_SchoolTerm:
                    this.schoolTerm = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_SchoolYear:
                    this.schoolYear = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_OpenBeginDate:
                    this.openBeginDate = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_OpenEndDate:
                    this.openEndDate = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    break;
                case clsvCurrEduClsTeacherEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_CollegeName4EduCls:
                    this.collegeName4EduCls = strValue;
                    break;
                case clsvCurrEduClsTeacherEN.con_CollegeName4Teacher:
                    this.collegeName4Teacher = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vCurrEduClsTeacher]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_EduClsTeacher"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_EduClsTeacher() { return "id_EduClsTeacher"; } //教学班老师流水号
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
        * 常量:"EduClsTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsTypeName() { return "eduClsTypeName"; } //教学班类型名称
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"CourseCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseCode() { return "courseCode"; } //课程代码
        /**
        * 常量:"CourseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseName() { return "courseName"; } //课程名称
        /**
        * 常量:"ExampleImgPath"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExampleImgPath() { return "exampleImgPath"; } //示例图路径
        /**
        * 常量:"TeachingSolutionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeachingSolutionId() { return "teachingSolutionId"; } //教学方案Id
        /**
        * 常量:"TeachingSolutionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeachingSolutionName() { return "teachingSolutionName"; } //教学方案名称
        /**
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"CollegeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeID() { return "collegeID"; } //学院ID
        /**
        * 常量:"id_EduWay"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_EduWay() { return "id_EduWay"; } //教学方式流水号
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
        * 常量:"GradeBaseID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GradeBaseID() { return "gradeBaseID"; } //年级代号
        /**
        * 常量:"GradeBaseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GradeBaseName() { return "gradeBaseName"; } //年级名称
        /**
        * 常量:"IsEffective"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsEffective() { return "isEffective"; } //是否有效
        /**
        * 常量:"id_CourseType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CourseType() { return "id_CourseType"; } //课程类型流水号
        /**
        * 常量:"CourseTypeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseTypeID() { return "courseTypeID"; } //课程类型ID
        /**
        * 常量:"CourseTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseTypeName() { return "courseTypeName"; } //课程类型名称
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
        * 常量:"BeginWeek"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BeginWeek() { return "beginWeek"; } //开始周
        /**
        * 常量:"CurrStuNum_Valid"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CurrStuNum_Valid() { return "currStuNum_Valid"; } //CurrStuNum_Valid
        /**
        * 常量:"CurrStuNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CurrStuNum() { return "currStuNum"; } //当前学生数
        /**
        * 常量:"id_Teacher"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Teacher() { return "id_Teacher"; } //教师流水号
        /**
        * 常量:"TeacherID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeacherID() { return "teacherID"; } //教师工号
        /**
        * 常量:"TeacherName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeacherName() { return "teacherName"; } //教师姓名
        /**
        * 常量:"id_ProfGrade"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_ProfGrade() { return "id_ProfGrade"; } //专业职称流水号
        /**
        * 常量:"ProfenssionalGradeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProfenssionalGradeName() { return "profenssionalGradeName"; } //专业职称
        /**
        * 常量:"DegreeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DegreeName() { return "degreeName"; } //学位名称
        /**
        * 常量:"Birthday"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Birthday() { return "birthday"; } //出生日期
        /**
        * 常量:"IsGpUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsGpUser() { return "isGpUser"; } //是否Gp用户
        /**
        * 常量:"CollegeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName() { return "collegeName"; } //学院名称
        /**
        * 常量:"id_Pk2EduClsTeacherType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Pk2EduClsTeacherType() { return "id_Pk2EduClsTeacherType"; } //教学班老师角色(主讲,辅导)流水号
        /**
        * 常量:"EduClsTeacherTypeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsTeacherTypeID() { return "eduClsTeacherTypeID"; } //教学班教学类型ID
        /**
        * 常量:"EduClsTeacherTypeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsTeacherTypeDesc() { return "eduClsTeacherTypeDesc"; } //教学班教师类型名
        /**
        * 常量:"SchoolTerm"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolTerm() { return "schoolTerm"; } //学期
        /**
        * 常量:"SchoolYear"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolYear() { return "schoolYear"; } //学年
        /**
        * 常量:"OpenBeginDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OpenBeginDate() { return "openBeginDate"; } //开放开始日期
        /**
        * 常量:"OpenEndDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OpenEndDate() { return "openEndDate"; } //开放结束日期
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"CollegeName4EduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName4EduCls() { return "collegeName4EduCls"; } //学院名_教学班
        /**
        * 常量:"CollegeName4Teacher"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName4Teacher() { return "collegeName4Teacher"; } //学院名_教师
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
    exports.clsvCurrEduClsTeacherEN = clsvCurrEduClsTeacherEN;
    clsvCurrEduClsTeacherEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvCurrEduClsTeacherEN.CacheModeId = "02"; //客户端缓存
    clsvCurrEduClsTeacherEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvCurrEduClsTeacherEN.WhereFormat = ""; //条件格式串
    clsvCurrEduClsTeacherEN._CurrTabName = "vCurrEduClsTeacher"; //当前表名,与该类相关的表名
    clsvCurrEduClsTeacherEN._KeyFldName = "id_EduClsTeacher"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvCurrEduClsTeacherEN.mintAttributeCount = 59;
    clsvCurrEduClsTeacherEN.AttributeName = ["id_EduClsTeacher", "id_CurrEduCls", "currEduClsId", "eduClsName", "eduClsTypeId", "eduClsTypeName", "courseId", "courseCode", "courseName", "exampleImgPath", "teachingSolutionId", "teachingSolutionName", "id_XzCollege", "collegeID", "id_EduWay", "totalLessonQty", "maxStuQty", "weekQty", "scheUnitPW", "weekStatusID", "customerWeek", "lessonQtyPerWeek", "id_UniZone", "id_GradeBase", "gradeBaseID", "gradeBaseName", "isEffective", "id_CourseType", "courseTypeID", "courseTypeName", "isDegree", "id_ScoreType", "isProportionalCtrl", "id_ExamType", "beginWeek", "currStuNum_Valid", "currStuNum", "id_Teacher", "teacherID", "teacherName", "id_ProfGrade", "profenssionalGradeName", "degreeName", "birthday", "isGpUser", "collegeName", "id_Pk2EduClsTeacherType", "eduClsTeacherTypeID", "eduClsTeacherTypeDesc", "schoolTerm", "schoolYear", "openBeginDate", "openEndDate", "orderNum", "updDate", "updUser", "memo", "collegeName4EduCls", "collegeName4Teacher"];
});
