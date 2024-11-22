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
    exports.clsRsStuTypeEN_Sim = exports.clsRsStuTypeEN = void 0;
    /**
    * 类名:clsRsStuTypeEN
    * 表名:RsStuType(01120162)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:05:34
    * 生成者:pyf
    * 工程名称:问卷调查
    * 工程ID:0112
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:成长档案
    * 模块英文名:EPortfolio
    * 框架-层名:实体层(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 学生类别(RsStuType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsRsStuTypeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrid_StuType = ""; //学生类别流水号
            this.mstrStuTypeID = ""; //学生类别ID
            this.mstrStuTypeDesc = ""; //学生类别名称
            this.mstrModifyDate = ""; //修改日期
            this.mstrModifyUserID = ""; //修改人
            this.mstrSpecUniLenDesc = ""; //SpecUniLenDesc
            this.mstrMemo = ""; //备注
        }
        /**
         * 学生类别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_StuType() {
            return this.mstrid_StuType;
        }
        /**
         * 学生类别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_StuType(value) {
            if (value != undefined) {
                this.mstrid_StuType = value;
                this.hmProperty["id_StuType"] = true;
            }
        }
        /**
         * 学生类别ID(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get StuTypeID() {
            return this.mstrStuTypeID;
        }
        /**
         * 学生类别ID(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set StuTypeID(value) {
            if (value != undefined) {
                this.mstrStuTypeID = value;
                this.hmProperty["StuTypeID"] = true;
            }
        }
        /**
         * 学生类别名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get StuTypeDesc() {
            return this.mstrStuTypeDesc;
        }
        /**
         * 学生类别名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set StuTypeDesc(value) {
            if (value != undefined) {
                this.mstrStuTypeDesc = value;
                this.hmProperty["StuTypeDesc"] = true;
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
         * SpecUniLenDesc(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get SpecUniLenDesc() {
            return this.mstrSpecUniLenDesc;
        }
        /**
         * SpecUniLenDesc(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set SpecUniLenDesc(value) {
            if (value != undefined) {
                this.mstrSpecUniLenDesc = value;
                this.hmProperty["SpecUniLenDesc"] = true;
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
        * 常量:"id_StuType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_StuType() { return "id_StuType"; } //学生类别流水号
        /**
        * 常量:"StuTypeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuTypeID() { return "StuTypeID"; } //学生类别ID
        /**
        * 常量:"StuTypeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuTypeDesc() { return "StuTypeDesc"; } //学生类别名称
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
        /**
        * 常量:"SpecUniLenDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SpecUniLenDesc() { return "SpecUniLenDesc"; } //SpecUniLenDesc
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
    exports.clsRsStuTypeEN = clsRsStuTypeEN;
    clsRsStuTypeEN._CurrTabName = "RsStuType"; //当前表名,与该类相关的表名
    clsRsStuTypeEN._KeyFldName = "id_StuType"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsRsStuTypeEN.mintAttributeCount = 7;
    clsRsStuTypeEN.AttributeName = ["id_StuType", "StuTypeID", "StuTypeDesc", "modifyDate", "modifyUserID", "SpecUniLenDesc", "memo"];
    /**
    * 学生类别(RsStuType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsRsStuTypeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 学生类别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_StuType = "";
            /**
             * 学生类别ID(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.StuTypeID = "";
            /**
             * 学生类别名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.StuTypeDesc = "";
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
            /**
             * SpecUniLenDesc(说明:;字段类型:varchar;字段长度:50;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.SpecUniLenDesc = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsRsStuTypeEN_Sim = clsRsStuTypeEN_Sim;
});
