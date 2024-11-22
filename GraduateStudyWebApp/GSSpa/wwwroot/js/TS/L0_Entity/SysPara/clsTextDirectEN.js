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
    exports.clsTextDirectEN_Sim = exports.clsTextDirectEN = void 0;
    /**
    * 类名:clsTextDirectEN
    * 表名:TextDirect(01120031)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 23:49:32
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
    * 文本方向(TextDirect)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsTextDirectEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrTextDirectId = ""; //文本方向ID
            this.mstrTextDirectName = ""; //文本方向名
            this.mstrMemo = ""; //备注
        }
        /**
         * 文本方向ID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get TextDirectId() {
            return this.mstrTextDirectId;
        }
        /**
         * 文本方向ID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set TextDirectId(value) {
            if (value != undefined) {
                this.mstrTextDirectId = value;
                this.hmProperty["TextDirectId"] = true;
            }
        }
        /**
         * 文本方向名(说明:;字段类型:varchar;字段长度:40;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get TextDirectName() {
            return this.mstrTextDirectName;
        }
        /**
         * 文本方向名(说明:;字段类型:varchar;字段长度:40;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set TextDirectName(value) {
            if (value != undefined) {
                this.mstrTextDirectName = value;
                this.hmProperty["TextDirectName"] = true;
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
        * 常量:"TextDirectId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TextDirectId() { return "TextDirectId"; } //文本方向ID
        /**
        * 常量:"TextDirectName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TextDirectName() { return "TextDirectName"; } //文本方向名
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
    exports.clsTextDirectEN = clsTextDirectEN;
    clsTextDirectEN._CurrTabName = "TextDirect"; //当前表名,与该类相关的表名
    clsTextDirectEN._KeyFldName = "TextDirectId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsTextDirectEN.mintAttributeCount = 3;
    clsTextDirectEN.AttributeName = ["TextDirectId", "TextDirectName", "memo"];
    /**
    * 文本方向(TextDirect)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsTextDirectEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 文本方向ID(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.TextDirectId = "";
            /**
             * 文本方向名(说明:;字段类型:varchar;字段长度:40;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.TextDirectName = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsTextDirectEN_Sim = clsTextDirectEN_Sim;
});
