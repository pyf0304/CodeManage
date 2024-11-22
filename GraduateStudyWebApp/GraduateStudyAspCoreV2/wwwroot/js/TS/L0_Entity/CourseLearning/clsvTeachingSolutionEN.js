(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTab2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvTeachingSolutionEN_Sim = exports.clsvTeachingSolutionEN = void 0;
    /**
    * 类名:clsvTeachingSolutionEN
    * 表名:vTeachingSolution(01120138)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:17:46
    * 生成者:pyf
    * 工程名称:问卷调查
    * 工程ID:0112
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:课程学习
    * 模块英文名:CourseLearning
    * 框架-层名:实体层(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * v教学方案(vTeachingSolution)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsvTeachingSolutionEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrTeachingSolutionId = ""; //教学方案Id
            this.mstrTeachingSolutionName = ""; //教学方案名称
            this.mstrCourseId = ""; //课程Id
            this.mstrCourseCode = ""; //课程代码
            this.mstrCourseDescription = ""; //课程描述
            this.mstrid_Teacher = ""; //教师流水号
            this.mstrTeacherID = ""; //教师工号
            this.mstrTeacherName = ""; //教师姓名
            this.mstrid_Sex = ""; //性别流水号
            this.mstrSexDesc = ""; //性别名称
            this.mstrcollegeName = ""; //学院名称
            this.mstrid_ProfGrade = ""; //专业职称流水号
            this.mstrProfenssionalGradeName = ""; //专业职称
            this.mstrCollegeID = ""; //学院ID
            this.mstrid_XzCollege = ""; //学院流水号
            this.mstrid_XzMajor = ""; //专业流水号
            this.mstrBriefIntroduction = ""; //简介
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
        }
        /**
         * 教学方案Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get TeachingSolutionId() {
            return this.mstrTeachingSolutionId;
        }
        /**
         * 教学方案Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set TeachingSolutionId(value) {
            if (value != undefined) {
                this.mstrTeachingSolutionId = value;
                this.hmProperty["TeachingSolutionId"] = true;
            }
        }
        /**
         * 教学方案名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get TeachingSolutionName() {
            return this.mstrTeachingSolutionName;
        }
        /**
         * 教学方案名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set TeachingSolutionName(value) {
            if (value != undefined) {
                this.mstrTeachingSolutionName = value;
                this.hmProperty["TeachingSolutionName"] = true;
            }
        }
        /**
         * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get courseId() {
            return this.mstrCourseId;
        }
        /**
         * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set courseId(value) {
            if (value != undefined) {
                this.mstrCourseId = value;
                this.hmProperty["courseId"] = true;
            }
        }
        /**
         * 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get courseCode() {
            return this.mstrCourseCode;
        }
        /**
         * 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set courseCode(value) {
            if (value != undefined) {
                this.mstrCourseCode = value;
                this.hmProperty["courseCode"] = true;
            }
        }
        /**
         * 课程描述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get courseDescription() {
            return this.mstrCourseDescription;
        }
        /**
         * 课程描述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set courseDescription(value) {
            if (value != undefined) {
                this.mstrCourseDescription = value;
                this.hmProperty["courseDescription"] = true;
            }
        }
        /**
         * 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_Teacher() {
            return this.mstrid_Teacher;
        }
        /**
         * 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_Teacher(value) {
            if (value != undefined) {
                this.mstrid_Teacher = value;
                this.hmProperty["id_Teacher"] = true;
            }
        }
        /**
         * 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get teacherID() {
            return this.mstrTeacherID;
        }
        /**
         * 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set teacherID(value) {
            if (value != undefined) {
                this.mstrTeacherID = value;
                this.hmProperty["teacherID"] = true;
            }
        }
        /**
         * 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get teacherName() {
            return this.mstrTeacherName;
        }
        /**
         * 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set teacherName(value) {
            if (value != undefined) {
                this.mstrTeacherName = value;
                this.hmProperty["teacherName"] = true;
            }
        }
        /**
         * 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_Sex() {
            return this.mstrid_Sex;
        }
        /**
         * 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_Sex(value) {
            if (value != undefined) {
                this.mstrid_Sex = value;
                this.hmProperty["id_Sex"] = true;
            }
        }
        /**
         * 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get SexDesc() {
            return this.mstrSexDesc;
        }
        /**
         * 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set SexDesc(value) {
            if (value != undefined) {
                this.mstrSexDesc = value;
                this.hmProperty["SexDesc"] = true;
            }
        }
        /**
         * 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get collegeName() {
            return this.mstrcollegeName;
        }
        /**
         * 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set collegeName(value) {
            if (value != undefined) {
                this.mstrcollegeName = value;
                this.hmProperty["collegeName"] = true;
            }
        }
        /**
         * 专业职称流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_ProfGrade() {
            return this.mstrid_ProfGrade;
        }
        /**
         * 专业职称流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_ProfGrade(value) {
            if (value != undefined) {
                this.mstrid_ProfGrade = value;
                this.hmProperty["id_ProfGrade"] = true;
            }
        }
        /**
         * 专业职称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get ProfenssionalGradeName() {
            return this.mstrProfenssionalGradeName;
        }
        /**
         * 专业职称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set ProfenssionalGradeName(value) {
            if (value != undefined) {
                this.mstrProfenssionalGradeName = value;
                this.hmProperty["ProfenssionalGradeName"] = true;
            }
        }
        /**
         * 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get CollegeID() {
            return this.mstrCollegeID;
        }
        /**
         * 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set CollegeID(value) {
            if (value != undefined) {
                this.mstrCollegeID = value;
                this.hmProperty["CollegeID"] = true;
            }
        }
        /**
         * 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_XzCollege() {
            return this.mstrid_XzCollege;
        }
        /**
         * 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_XzCollege(value) {
            if (value != undefined) {
                this.mstrid_XzCollege = value;
                this.hmProperty["id_XzCollege"] = true;
            }
        }
        /**
         * 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_XzMajor() {
            return this.mstrid_XzMajor;
        }
        /**
         * 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_XzMajor(value) {
            if (value != undefined) {
                this.mstrid_XzMajor = value;
                this.hmProperty["id_XzMajor"] = true;
            }
        }
        /**
         * 简介(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get BriefIntroduction() {
            return this.mstrBriefIntroduction;
        }
        /**
         * 简介(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set BriefIntroduction(value) {
            if (value != undefined) {
                this.mstrBriefIntroduction = value;
                this.hmProperty["BriefIntroduction"] = true;
            }
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get updDate() {
            return this.mstrUpdDate;
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set updDate(value) {
            if (value != undefined) {
                this.mstrUpdDate = value;
                this.hmProperty["updDate"] = true;
            }
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get updUser() {
            return this.mstrUpdUser;
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set updUser(value) {
            if (value != undefined) {
                this.mstrUpdUser = value;
                this.hmProperty["updUser"] = true;
            }
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get memo() {
            return this.mstrMemo;
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set memo(value) {
            if (value != undefined) {
                this.mstrMemo = value;
                this.hmProperty["memo"] = true;
            }
        }
        /**
        * 常量:"TeachingSolutionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeachingSolutionId() { return "TeachingSolutionId"; } //教学方案Id
        /**
        * 常量:"TeachingSolutionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeachingSolutionName() { return "TeachingSolutionName"; } //教学方案名称
        /**
        * 常量:"courseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"courseCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseCode() { return "courseCode"; } //课程代码
        /**
        * 常量:"courseDescription"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseDescription() { return "courseDescription"; } //课程描述
        /**
        * 常量:"id_Teacher"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Teacher() { return "id_Teacher"; } //教师流水号
        /**
        * 常量:"teacherID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeacherID() { return "teacherID"; } //教师工号
        /**
        * 常量:"teacherName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeacherName() { return "teacherName"; } //教师姓名
        /**
        * 常量:"id_Sex"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Sex() { return "id_Sex"; } //性别流水号
        /**
        * 常量:"SexDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SexDesc() { return "SexDesc"; } //性别名称
        /**
        * 常量:"collegeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName() { return "collegeName"; } //学院名称
        /**
        * 常量:"id_ProfGrade"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_ProfGrade() { return "id_ProfGrade"; } //专业职称流水号
        /**
        * 常量:"ProfenssionalGradeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProfenssionalGradeName() { return "ProfenssionalGradeName"; } //专业职称
        /**
        * 常量:"CollegeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeID() { return "CollegeID"; } //学院ID
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
        * 常量:"BriefIntroduction"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BriefIntroduction() { return "BriefIntroduction"; } //简介
        /**
        * 常量:"updDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"updUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        SetCondFldValue(strFldName, strFldValue, strComparisonOp) {
            this[strFldName] = strFldValue;
            if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false) {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            else {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
        }
    }
    exports.clsvTeachingSolutionEN = clsvTeachingSolutionEN;
    clsvTeachingSolutionEN._CurrTabName = "vTeachingSolution"; //当前表名,与该类相关的表名
    clsvTeachingSolutionEN._KeyFldName = "TeachingSolutionId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvTeachingSolutionEN.mintAttributeCount = 20;
    clsvTeachingSolutionEN.AttributeName = ["TeachingSolutionId", "TeachingSolutionName", "courseId", "courseCode", "courseDescription", "id_Teacher", "teacherID", "teacherName", "id_Sex", "SexDesc", "collegeName", "id_ProfGrade", "ProfenssionalGradeName", "CollegeID", "id_XzCollege", "id_XzMajor", "BriefIntroduction", "updDate", "updUser", "memo"];
    /**
    * v教学方案(vTeachingSolution)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsvTeachingSolutionEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 教学方案Id(说明:;字段类型:char;字段长度:8;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.TeachingSolutionId = "";
            /**
             * 教学方案名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.TeachingSolutionName = "";
            /**
             * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.courseId = "";
            /**
             * 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.courseCode = "";
            /**
             * 课程描述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.courseDescription = "";
            /**
             * 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_Teacher = "";
            /**
             * 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.teacherID = "";
            /**
             * 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.teacherName = "";
            /**
             * 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_Sex = "";
            /**
             * 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.SexDesc = "";
            /**
             * 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.collegeName = "";
            /**
             * 专业职称流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_ProfGrade = "";
            /**
             * 专业职称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.ProfenssionalGradeName = "";
            /**
             * 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.CollegeID = "";
            /**
             * 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_XzCollege = "";
            /**
             * 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_XzMajor = "";
            /**
             * 简介(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.BriefIntroduction = "";
            /**
             * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.updDate = "";
            /**
             * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.updUser = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsvTeachingSolutionEN_Sim = clsvTeachingSolutionEN_Sim;
});
