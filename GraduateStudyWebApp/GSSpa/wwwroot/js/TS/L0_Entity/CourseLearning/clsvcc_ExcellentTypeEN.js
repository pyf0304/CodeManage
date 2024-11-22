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
    exports.clsvcc_ExcellentTypeEN_Sim = exports.clsvcc_ExcellentTypeEN = void 0;
    /**
    * 类名:clsvcc_ExcellentTypeEN
    * 表名:vcc_ExcellentType(01120063)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:17:42
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
    * v精品课程类型(vcc_ExcellentType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsvcc_ExcellentTypeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrExcellentTypeId = ""; //精品课程类型Id
            this.mstrExcellentTypeName = ""; //精品课程类型名称
            this.mstrid_School = ""; //学校流水号
            this.mstrSchoolId = ""; //学校编号
            this.mstrSchoolName = ""; //学校名称
            this.mbolIsUse = false; //是否使用
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrMemo = ""; //备注
        }
        /**
         * 精品课程类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get ExcellentTypeId() {
            return this.mstrExcellentTypeId;
        }
        /**
         * 精品课程类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set ExcellentTypeId(value) {
            if (value != undefined) {
                this.mstrExcellentTypeId = value;
                this.hmProperty["ExcellentTypeId"] = true;
            }
        }
        /**
         * 精品课程类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get ExcellentTypeName() {
            return this.mstrExcellentTypeName;
        }
        /**
         * 精品课程类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set ExcellentTypeName(value) {
            if (value != undefined) {
                this.mstrExcellentTypeName = value;
                this.hmProperty["ExcellentTypeName"] = true;
            }
        }
        /**
         * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_School() {
            return this.mstrid_School;
        }
        /**
         * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_School(value) {
            if (value != undefined) {
                this.mstrid_School = value;
                this.hmProperty["id_School"] = true;
            }
        }
        /**
         * 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get SchoolId() {
            return this.mstrSchoolId;
        }
        /**
         * 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set SchoolId(value) {
            if (value != undefined) {
                this.mstrSchoolId = value;
                this.hmProperty["SchoolId"] = true;
            }
        }
        /**
         * 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get SchoolName() {
            return this.mstrSchoolName;
        }
        /**
         * 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set SchoolName(value) {
            if (value != undefined) {
                this.mstrSchoolName = value;
                this.hmProperty["SchoolName"] = true;
            }
        }
        /**
         * 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get IsUse() {
            return this.mbolIsUse;
        }
        /**
         * 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set IsUse(value) {
            if (value != undefined) {
                this.mbolIsUse = value;
                this.hmProperty["IsUse"] = true;
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
         * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get updUserId() {
            return this.mstrUpdUserId;
        }
        /**
         * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set updUserId(value) {
            if (value != undefined) {
                this.mstrUpdUserId = value;
                this.hmProperty["updUserId"] = true;
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
        * 常量:"ExcellentTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExcellentTypeId() { return "ExcellentTypeId"; } //精品课程类型Id
        /**
        * 常量:"ExcellentTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExcellentTypeName() { return "ExcellentTypeName"; } //精品课程类型名称
        /**
        * 常量:"id_School"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_School() { return "id_School"; } //学校流水号
        /**
        * 常量:"SchoolId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolId() { return "SchoolId"; } //学校编号
        /**
        * 常量:"SchoolName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolName() { return "SchoolName"; } //学校名称
        /**
        * 常量:"IsUse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsUse() { return "IsUse"; } //是否使用
        /**
        * 常量:"updDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"updUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUserId() { return "updUserId"; } //修改用户Id
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
    exports.clsvcc_ExcellentTypeEN = clsvcc_ExcellentTypeEN;
    clsvcc_ExcellentTypeEN._CurrTabName = "vcc_ExcellentType"; //当前表名,与该类相关的表名
    clsvcc_ExcellentTypeEN._KeyFldName = "ExcellentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvcc_ExcellentTypeEN.mintAttributeCount = 9;
    clsvcc_ExcellentTypeEN.AttributeName = ["ExcellentTypeId", "ExcellentTypeName", "id_School", "SchoolId", "SchoolName", "IsUse", "updDate", "updUserId", "memo"];
    /**
    * v精品课程类型(vcc_ExcellentType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsvcc_ExcellentTypeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 精品课程类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.ExcellentTypeId = "";
            /**
             * 精品课程类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.ExcellentTypeName = "";
            /**
             * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_School = "";
            /**
             * 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.SchoolId = "";
            /**
             * 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.SchoolName = "";
            /**
             * 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.IsUse = false;
            /**
             * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.updDate = "";
            /**
             * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.updUserId = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsvcc_ExcellentTypeEN_Sim = clsvcc_ExcellentTypeEN_Sim;
});
