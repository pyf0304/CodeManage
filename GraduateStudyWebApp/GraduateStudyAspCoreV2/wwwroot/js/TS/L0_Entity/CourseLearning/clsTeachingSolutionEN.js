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
    exports.clsTeachingSolutionEN_Sim = exports.clsTeachingSolutionEN = void 0;
    /**
    * 类名:clsTeachingSolutionEN
    * 表名:TeachingSolution(01120137)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 23:55:42
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
    * 教学方案(TeachingSolution)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsTeachingSolutionEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
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
            this.mstrid_Teacher = ""; //教师流水号
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
        * 常量:"id_Teacher"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Teacher() { return "id_Teacher"; } //教师流水号
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
    exports.clsTeachingSolutionEN = clsTeachingSolutionEN;
    clsTeachingSolutionEN._CurrTabName = "TeachingSolution"; //当前表名,与该类相关的表名
    clsTeachingSolutionEN._KeyFldName = "TeachingSolutionId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsTeachingSolutionEN.mintAttributeCount = 8;
    clsTeachingSolutionEN.AttributeName = ["TeachingSolutionId", "TeachingSolutionName", "courseId", "id_Teacher", "BriefIntroduction", "updDate", "updUser", "memo"];
    /**
    * 教学方案(TeachingSolution)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsTeachingSolutionEN_Sim {
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
             * 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_Teacher = "";
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
    exports.clsTeachingSolutionEN_Sim = clsTeachingSolutionEN_Sim;
});
