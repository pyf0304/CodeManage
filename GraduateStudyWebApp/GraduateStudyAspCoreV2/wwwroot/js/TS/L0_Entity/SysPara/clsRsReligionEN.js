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
    exports.clsRsReligionEN_Sim = exports.clsRsReligionEN = void 0;
    /**
    * 类名:clsRsReligionEN
    * 表名:RsReligion(01120108)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 17:59:35
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
    * 宗教(RsReligion)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsRsReligionEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrModifyUserID = ""; //修改人
            this.mstrModifyDate = ""; //修改日期
            this.mstrid_Religion = ""; //id_Religion
            this.mstrReligionName = ""; //ReligionName
            this.mstrReligionID = ""; //ReligionID
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
         * id_Religion(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_Religion() {
            return this.mstrid_Religion;
        }
        /**
         * id_Religion(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_Religion(value) {
            if (value != undefined) {
                this.mstrid_Religion = value;
                this.hmProperty["id_Religion"] = true;
            }
        }
        /**
         * ReligionName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get ReligionName() {
            return this.mstrReligionName;
        }
        /**
         * ReligionName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set ReligionName(value) {
            if (value != undefined) {
                this.mstrReligionName = value;
                this.hmProperty["ReligionName"] = true;
            }
        }
        /**
         * ReligionID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get ReligionID() {
            return this.mstrReligionID;
        }
        /**
         * ReligionID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set ReligionID(value) {
            if (value != undefined) {
                this.mstrReligionID = value;
                this.hmProperty["ReligionID"] = true;
            }
        }
        /**
        * 常量:"modifyUserID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyUserID() { return "modifyUserID"; } //修改人
        /**
        * 常量:"modifyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyDate() { return "modifyDate"; } //修改日期
        /**
        * 常量:"id_Religion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Religion() { return "id_Religion"; } //id_Religion
        /**
        * 常量:"ReligionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReligionName() { return "ReligionName"; } //ReligionName
        /**
        * 常量:"ReligionID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReligionID() { return "ReligionID"; } //ReligionID
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
    exports.clsRsReligionEN = clsRsReligionEN;
    clsRsReligionEN._CurrTabName = "RsReligion"; //当前表名,与该类相关的表名
    clsRsReligionEN._KeyFldName = "id_Religion"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsRsReligionEN.mintAttributeCount = 5;
    clsRsReligionEN.AttributeName = ["modifyUserID", "modifyDate", "id_Religion", "ReligionName", "ReligionID"];
    /**
    * 宗教(RsReligion)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsRsReligionEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.modifyUserID = "";
            /**
             * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.modifyDate = "";
            /**
             * id_Religion(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_Religion = "";
            /**
             * ReligionName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.ReligionName = "";
            /**
             * ReligionID(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.ReligionID = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsRsReligionEN_Sim = clsRsReligionEN_Sim;
});
