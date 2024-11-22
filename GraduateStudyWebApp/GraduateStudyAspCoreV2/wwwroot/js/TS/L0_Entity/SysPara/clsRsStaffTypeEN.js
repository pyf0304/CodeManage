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
    exports.clsRsStaffTypeEN_Sim = exports.clsRsStaffTypeEN = void 0;
    /**
    * 类名:clsRsStaffTypeEN
    * 表名:RsStaffType(01120101)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 17:59:08
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
    * 职工类型(RsStaffType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsRsStaffTypeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrid_StaffType = ""; //职工类型流水号
            this.mstrStaffTypeID = ""; //职工类型ID
            this.mstrStaffTypeName = ""; //职工类型名称
            this.mstrModifyDate = ""; //修改日期
            this.mstrModifyUserID = ""; //修改人
        }
        /**
         * 职工类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_StaffType() {
            return this.mstrid_StaffType;
        }
        /**
         * 职工类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_StaffType(value) {
            if (value != undefined) {
                this.mstrid_StaffType = value;
                this.hmProperty["id_StaffType"] = true;
            }
        }
        /**
         * 职工类型ID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get StaffTypeID() {
            return this.mstrStaffTypeID;
        }
        /**
         * 职工类型ID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set StaffTypeID(value) {
            if (value != undefined) {
                this.mstrStaffTypeID = value;
                this.hmProperty["StaffTypeID"] = true;
            }
        }
        /**
         * 职工类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get StaffTypeName() {
            return this.mstrStaffTypeName;
        }
        /**
         * 职工类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set StaffTypeName(value) {
            if (value != undefined) {
                this.mstrStaffTypeName = value;
                this.hmProperty["StaffTypeName"] = true;
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
        * 常量:"id_StaffType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_StaffType() { return "id_StaffType"; } //职工类型流水号
        /**
        * 常量:"StaffTypeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StaffTypeID() { return "StaffTypeID"; } //职工类型ID
        /**
        * 常量:"StaffTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StaffTypeName() { return "StaffTypeName"; } //职工类型名称
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
    exports.clsRsStaffTypeEN = clsRsStaffTypeEN;
    clsRsStaffTypeEN._CurrTabName = "RsStaffType"; //当前表名,与该类相关的表名
    clsRsStaffTypeEN._KeyFldName = "id_StaffType"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsRsStaffTypeEN.mintAttributeCount = 5;
    clsRsStaffTypeEN.AttributeName = ["id_StaffType", "StaffTypeID", "StaffTypeName", "modifyDate", "modifyUserID"];
    /**
    * 职工类型(RsStaffType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsRsStaffTypeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 职工类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_StaffType = "";
            /**
             * 职工类型ID(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.StaffTypeID = "";
            /**
             * 职工类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.StaffTypeName = "";
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
    exports.clsRsStaffTypeEN_Sim = clsRsStaffTypeEN_Sim;
});
