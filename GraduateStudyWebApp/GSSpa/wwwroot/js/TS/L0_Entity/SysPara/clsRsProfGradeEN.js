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
    exports.clsRsProfGradeEN_Sim = exports.clsRsProfGradeEN = void 0;
    /**
    * 类名:clsRsProfGradeEN
    * 表名:RsProfGrade(01120104)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 17:59:20
    * 生成者:pyf
    * 工程名称:问卷调查
    * 工程ID:0112
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:系统参数
    * 模块英文名:SysPara
    * 框架-层名:实体层(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 专业职称(RsProfGrade)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsRsProfGradeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrid_ProfGrade = ""; //专业职称流水号
            this.mstrProfenssionalGradeID = ""; //专业职称ID
            this.mstrProfenssionalGradeName = ""; //专业职称
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
         * 专业职称ID(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get ProfenssionalGradeID() {
            return this.mstrProfenssionalGradeID;
        }
        /**
         * 专业职称ID(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set ProfenssionalGradeID(value) {
            if (value != undefined) {
                this.mstrProfenssionalGradeID = value;
                this.hmProperty["ProfenssionalGradeID"] = true;
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
        * 常量:"id_ProfGrade"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_ProfGrade() { return "id_ProfGrade"; } //专业职称流水号
        /**
        * 常量:"ProfenssionalGradeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProfenssionalGradeID() { return "ProfenssionalGradeID"; } //专业职称ID
        /**
        * 常量:"ProfenssionalGradeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProfenssionalGradeName() { return "ProfenssionalGradeName"; } //专业职称
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
    exports.clsRsProfGradeEN = clsRsProfGradeEN;
    clsRsProfGradeEN._CurrTabName = "RsProfGrade"; //当前表名,与该类相关的表名
    clsRsProfGradeEN._KeyFldName = "id_ProfGrade"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsRsProfGradeEN.mintAttributeCount = 3;
    clsRsProfGradeEN.AttributeName = ["id_ProfGrade", "ProfenssionalGradeID", "ProfenssionalGradeName"];
    /**
    * 专业职称(RsProfGrade)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsRsProfGradeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 专业职称流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_ProfGrade = "";
            /**
             * 专业职称ID(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.ProfenssionalGradeID = "";
            /**
             * 专业职称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.ProfenssionalGradeName = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsRsProfGradeEN_Sim = clsRsProfGradeEN_Sim;
});
