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
    exports.clsUserKindEN_Sim = exports.clsUserKindEN = void 0;
    /**
    * 类名:clsUserKindEN
    * 表名:UserKind(01120328)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:00:20
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
    * 用户类别(UserKind)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsUserKindEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrUserKindId = ""; //用户类别Id
            this.mstrUserKindName = ""; //用户类别名
            this.mstrMemo = ""; //备注
        }
        /**
         * 用户类别Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get UserKindId() {
            return this.mstrUserKindId;
        }
        /**
         * 用户类别Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set UserKindId(value) {
            if (value != undefined) {
                this.mstrUserKindId = value;
                this.hmProperty["UserKindId"] = true;
            }
        }
        /**
         * 用户类别名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get UserKindName() {
            return this.mstrUserKindName;
        }
        /**
         * 用户类别名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set UserKindName(value) {
            if (value != undefined) {
                this.mstrUserKindName = value;
                this.hmProperty["UserKindName"] = true;
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
        * 常量:"UserKindId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserKindId() { return "UserKindId"; } //用户类别Id
        /**
        * 常量:"UserKindName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserKindName() { return "UserKindName"; } //用户类别名
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
    exports.clsUserKindEN = clsUserKindEN;
    clsUserKindEN._CurrTabName = "UserKind"; //当前表名,与该类相关的表名
    clsUserKindEN._KeyFldName = "UserKindId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsUserKindEN.mintAttributeCount = 3;
    clsUserKindEN.AttributeName = ["UserKindId", "UserKindName", "memo"];
    /**
    * 用户类别(UserKind)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsUserKindEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 用户类别Id(说明:;字段类型:char;字段长度:2;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.UserKindId = "";
            /**
             * 用户类别名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.UserKindName = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsUserKindEN_Sim = clsUserKindEN_Sim;
});
