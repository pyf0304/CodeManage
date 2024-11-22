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
    exports.clsRsAdminGradeEN_Sim = exports.clsRsAdminGradeEN = void 0;
    /**
    * 类名:clsRsAdminGradeEN
    * 表名:RsAdminGrade(01120111)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 17:59:46
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
    * 职务(RsAdminGrade)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsRsAdminGradeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrid_AdminGrade = ""; //行政职务流水号
            this.mstrAdminGradeID = ""; //行政职务代号
            this.mstrAdminGradeDesc = ""; //行政职务描述
            this.mstrModifyDate = ""; //修改日期
            this.mstrModifyUserID = ""; //修改人
        }
        /**
         * 行政职务流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_AdminGrade() {
            return this.mstrid_AdminGrade;
        }
        /**
         * 行政职务流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_AdminGrade(value) {
            if (value != undefined) {
                this.mstrid_AdminGrade = value;
                this.hmProperty["id_AdminGrade"] = true;
            }
        }
        /**
         * 行政职务代号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get AdminGradeID() {
            return this.mstrAdminGradeID;
        }
        /**
         * 行政职务代号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set AdminGradeID(value) {
            if (value != undefined) {
                this.mstrAdminGradeID = value;
                this.hmProperty["AdminGradeID"] = true;
            }
        }
        /**
         * 行政职务描述(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get AdminGradeDesc() {
            return this.mstrAdminGradeDesc;
        }
        /**
         * 行政职务描述(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set AdminGradeDesc(value) {
            if (value != undefined) {
                this.mstrAdminGradeDesc = value;
                this.hmProperty["AdminGradeDesc"] = true;
            }
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get modifyDate() {
            return this.mstrModifyDate;
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set modifyDate(value) {
            if (value != undefined) {
                this.mstrModifyDate = value;
                this.hmProperty["modifyDate"] = true;
            }
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get modifyUserID() {
            return this.mstrModifyUserID;
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set modifyUserID(value) {
            if (value != undefined) {
                this.mstrModifyUserID = value;
                this.hmProperty["modifyUserID"] = true;
            }
        }
        /**
        * 常量:"id_AdminGrade"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_AdminGrade() { return "id_AdminGrade"; } //行政职务流水号
        /**
        * 常量:"AdminGradeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AdminGradeID() { return "AdminGradeID"; } //行政职务代号
        /**
        * 常量:"AdminGradeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AdminGradeDesc() { return "AdminGradeDesc"; } //行政职务描述
        /**
        * 常量:"modifyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyDate() { return "modifyDate"; } //修改日期
        /**
        * 常量:"modifyUserID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyUserID() { return "modifyUserID"; } //修改人
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
    exports.clsRsAdminGradeEN = clsRsAdminGradeEN;
    clsRsAdminGradeEN._CurrTabName = "RsAdminGrade"; //当前表名,与该类相关的表名
    clsRsAdminGradeEN._KeyFldName = "id_AdminGrade"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsRsAdminGradeEN.mintAttributeCount = 5;
    clsRsAdminGradeEN.AttributeName = ["id_AdminGrade", "AdminGradeID", "AdminGradeDesc", "modifyDate", "modifyUserID"];
    /**
    * 职务(RsAdminGrade)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsRsAdminGradeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 行政职务流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_AdminGrade = "";
            /**
             * 行政职务代号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.AdminGradeID = "";
            /**
             * 行政职务描述(说明:;字段类型:varchar;字段长度:30;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.AdminGradeDesc = "";
            /**
             * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.modifyDate = "";
            /**
             * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.modifyUserID = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsRsAdminGradeEN_Sim = clsRsAdminGradeEN_Sim;
});
