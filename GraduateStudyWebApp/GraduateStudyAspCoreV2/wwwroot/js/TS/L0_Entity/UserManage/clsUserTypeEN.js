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
    exports.clsUserTypeEN_Sim = exports.clsUserTypeEN = void 0;
    /**
    * 类名:clsUserTypeEN
    * 表名:UserType(01120309)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:00:35
    * 生成者:pyf
    * 工程名称:问卷调查
    * 工程ID:0112
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:用户管理
    * 模块英文名:UserManage
    * 框架-层名:实体层(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 用户类型(UserType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsUserTypeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrUserTypeId = ""; //用户类型Id
            this.mstrUserTypeName = ""; //用户类型名称
            this.mstrUserTypeName_Sim = ""; //用户类型名_Sim
            this.mstrMemo = ""; //备注
        }
        /**
         * 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get userTypeId() {
            return this.mstrUserTypeId;
        }
        /**
         * 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set userTypeId(value) {
            if (value != undefined) {
                this.mstrUserTypeId = value;
                this.hmProperty["userTypeId"] = true;
            }
        }
        /**
         * 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get userTypeName() {
            return this.mstrUserTypeName;
        }
        /**
         * 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set userTypeName(value) {
            if (value != undefined) {
                this.mstrUserTypeName = value;
                this.hmProperty["userTypeName"] = true;
            }
        }
        /**
         * 用户类型名_Sim(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get UserTypeName_Sim() {
            return this.mstrUserTypeName_Sim;
        }
        /**
         * 用户类型名_Sim(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set UserTypeName_Sim(value) {
            if (value != undefined) {
                this.mstrUserTypeName_Sim = value;
                this.hmProperty["UserTypeName_Sim"] = true;
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
        * 常量:"userTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserTypeId() { return "userTypeId"; } //用户类型Id
        /**
        * 常量:"userTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserTypeName() { return "userTypeName"; } //用户类型名称
        /**
        * 常量:"UserTypeName_Sim"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserTypeName_Sim() { return "UserTypeName_Sim"; } //用户类型名_Sim
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
    exports.clsUserTypeEN = clsUserTypeEN;
    clsUserTypeEN._CurrTabName = "UserType"; //当前表名,与该类相关的表名
    clsUserTypeEN._KeyFldName = "userTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsUserTypeEN.mintAttributeCount = 4;
    clsUserTypeEN.AttributeName = ["userTypeId", "userTypeName", "UserTypeName_Sim", "memo"];
    /**
    * 用户类型(UserType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsUserTypeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.userTypeId = "";
            /**
             * 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.userTypeName = "";
            /**
             * 用户类型名_Sim(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.UserTypeName_Sim = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsUserTypeEN_Sim = clsUserTypeEN_Sim;
});
