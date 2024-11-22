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
    exports.clsUserRolesEN_Sim = exports.clsUserRolesEN = void 0;
    /**
    * 类名:clsUserRolesEN
    * 表名:UserRoles(01120010)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 17:59:50
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
    * 角色(UserRoles)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsUserRolesEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrRoleId = ""; //角色Id
            this.mstrRoleName = ""; //角色名
            this.mstrQuestionnaireSetId = ""; //问卷集ID
            this.mstrPrjId = ""; //PrjId
            this.mstrMemo = ""; //备注
            this.mbolIsInUse = false; //IsInUse
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
        }
        /**
         * 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get roleId() {
            return this.mstrRoleId;
        }
        /**
         * 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set roleId(value) {
            if (value != undefined) {
                this.mstrRoleId = value;
                this.hmProperty["roleId"] = true;
            }
        }
        /**
         * 角色名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get roleName() {
            return this.mstrRoleName;
        }
        /**
         * 角色名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set roleName(value) {
            if (value != undefined) {
                this.mstrRoleName = value;
                this.hmProperty["roleName"] = true;
            }
        }
        /**
         * 问卷集ID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get QuestionnaireSetId() {
            return this.mstrQuestionnaireSetId;
        }
        /**
         * 问卷集ID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set QuestionnaireSetId(value) {
            if (value != undefined) {
                this.mstrQuestionnaireSetId = value;
                this.hmProperty["QuestionnaireSetId"] = true;
            }
        }
        /**
         * PrjId(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get PrjId() {
            return this.mstrPrjId;
        }
        /**
         * PrjId(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set PrjId(value) {
            if (value != undefined) {
                this.mstrPrjId = value;
                this.hmProperty["PrjId"] = true;
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
         * IsInUse(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get IsInUse() {
            return this.mbolIsInUse;
        }
        /**
         * IsInUse(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set IsInUse(value) {
            if (value != undefined) {
                this.mbolIsInUse = value;
                this.hmProperty["IsInUse"] = true;
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
        * 常量:"roleId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RoleId() { return "roleId"; } //角色Id
        /**
        * 常量:"roleName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RoleName() { return "roleName"; } //角色名
        /**
        * 常量:"QuestionnaireSetId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionnaireSetId() { return "QuestionnaireSetId"; } //问卷集ID
        /**
        * 常量:"PrjId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PrjId() { return "PrjId"; } //PrjId
        /**
        * 常量:"memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"IsInUse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsInUse() { return "IsInUse"; } //IsInUse
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
    exports.clsUserRolesEN = clsUserRolesEN;
    clsUserRolesEN._CurrTabName = "UserRoles"; //当前表名,与该类相关的表名
    clsUserRolesEN._KeyFldName = "roleId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsUserRolesEN.mintAttributeCount = 8;
    clsUserRolesEN.AttributeName = ["roleId", "roleName", "QuestionnaireSetId", "PrjId", "memo", "IsInUse", "updDate", "updUserId"];
    /**
    * 角色(UserRoles)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsUserRolesEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.roleId = "";
            /**
             * 角色名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.roleName = "";
            /**
             * 问卷集ID(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.QuestionnaireSetId = "";
            /**
             * PrjId(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.PrjId = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            /**
             * IsInUse(说明:;字段类型:bit;字段长度:1;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.IsInUse = false;
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
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsUserRolesEN_Sim = clsUserRolesEN_Sim;
});
