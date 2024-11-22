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
    exports.clsWorkTypeEN_Sim = exports.clsWorkTypeEN = void 0;
    /**
    * 类名:clsWorkTypeEN
    * 表名:WorkType(01120196)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 23:49:27
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
    * 作业类型(WorkType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsWorkTypeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrWorkTypeId = ""; //作业类型Id
            this.mstrWorkTypeName = ""; //作业类型名称
            this.mstrMemo = ""; //备注
        }
        /**
         * 作业类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get WorkTypeId() {
            return this.mstrWorkTypeId;
        }
        /**
         * 作业类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set WorkTypeId(value) {
            if (value != undefined) {
                this.mstrWorkTypeId = value;
                this.hmProperty["WorkTypeId"] = true;
            }
        }
        /**
         * 作业类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get WorkTypeName() {
            return this.mstrWorkTypeName;
        }
        /**
         * 作业类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set WorkTypeName(value) {
            if (value != undefined) {
                this.mstrWorkTypeName = value;
                this.hmProperty["WorkTypeName"] = true;
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
        * 常量:"WorkTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_WorkTypeId() { return "WorkTypeId"; } //作业类型Id
        /**
        * 常量:"WorkTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_WorkTypeName() { return "WorkTypeName"; } //作业类型名称
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
    exports.clsWorkTypeEN = clsWorkTypeEN;
    clsWorkTypeEN._CurrTabName = "WorkType"; //当前表名,与该类相关的表名
    clsWorkTypeEN._KeyFldName = "WorkTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsWorkTypeEN.mintAttributeCount = 3;
    clsWorkTypeEN.AttributeName = ["WorkTypeId", "WorkTypeName", "memo"];
    /**
    * 作业类型(WorkType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsWorkTypeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 作业类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.WorkTypeId = "";
            /**
             * 作业类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.WorkTypeName = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsWorkTypeEN_Sim = clsWorkTypeEN_Sim;
});
