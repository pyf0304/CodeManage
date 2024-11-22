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
    exports.clsUserStateEN_Sim = exports.clsUserStateEN = void 0;
    /**
    * 类名:clsUserStateEN
    * 表名:UserState(01120035)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 17:59:00
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
    * 用户状态(UserState)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsUserStateEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrUserStateId = ""; //用户状态Id
            this.mstrUserStateName = ""; //用户状态名
            this.mstrMemo = ""; //备注
        }
        /**
         * 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get userStateId() {
            return this.mstrUserStateId;
        }
        /**
         * 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set userStateId(value) {
            if (value != undefined) {
                this.mstrUserStateId = value;
                this.hmProperty["userStateId"] = true;
            }
        }
        /**
         * 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get UserStateName() {
            return this.mstrUserStateName;
        }
        /**
         * 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set UserStateName(value) {
            if (value != undefined) {
                this.mstrUserStateName = value;
                this.hmProperty["UserStateName"] = true;
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
        * 常量:"userStateId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserStateId() { return "userStateId"; } //用户状态Id
        /**
        * 常量:"UserStateName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserStateName() { return "UserStateName"; } //用户状态名
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
    exports.clsUserStateEN = clsUserStateEN;
    clsUserStateEN._CurrTabName = "UserState"; //当前表名,与该类相关的表名
    clsUserStateEN._KeyFldName = "userStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsUserStateEN.mintAttributeCount = 3;
    clsUserStateEN.AttributeName = ["userStateId", "UserStateName", "memo"];
    /**
    * 用户状态(UserState)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsUserStateEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.userStateId = "";
            /**
             * 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.UserStateName = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsUserStateEN_Sim = clsUserStateEN_Sim;
});
