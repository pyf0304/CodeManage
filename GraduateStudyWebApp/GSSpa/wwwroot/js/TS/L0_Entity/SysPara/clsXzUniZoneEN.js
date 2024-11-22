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
    exports.clsXzUniZoneEN_Sim = exports.clsXzUniZoneEN = void 0;
    /**
    * 类名:clsXzUniZoneEN
    * 表名:XzUniZone(01120095)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:00:01
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
    * 校区(XzUniZone)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsXzUniZoneEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrid_UniZone = ""; //校区流水号
            this.mstrUniZoneID = ""; //校区编号
            this.mstrUniZoneDesc = ""; //校区名称
            this.mstrUniZoneDescA = ""; //UniZoneDescA
            this.mstrid_School = ""; //学校流水号
            this.mstrid_Uni = ""; //id_Uni
            this.mstrModifyUserID = ""; //修改人
            this.mstrModifyDate = ""; //修改日期
            this.mstrMemo = ""; //备注
        }
        /**
         * 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_UniZone() {
            return this.mstrid_UniZone;
        }
        /**
         * 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_UniZone(value) {
            if (value != undefined) {
                this.mstrid_UniZone = value;
                this.hmProperty["id_UniZone"] = true;
            }
        }
        /**
         * 校区编号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get UniZoneID() {
            return this.mstrUniZoneID;
        }
        /**
         * 校区编号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set UniZoneID(value) {
            if (value != undefined) {
                this.mstrUniZoneID = value;
                this.hmProperty["UniZoneID"] = true;
            }
        }
        /**
         * 校区名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get UniZoneDesc() {
            return this.mstrUniZoneDesc;
        }
        /**
         * 校区名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set UniZoneDesc(value) {
            if (value != undefined) {
                this.mstrUniZoneDesc = value;
                this.hmProperty["UniZoneDesc"] = true;
            }
        }
        /**
         * UniZoneDescA(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get UniZoneDescA() {
            return this.mstrUniZoneDescA;
        }
        /**
         * UniZoneDescA(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set UniZoneDescA(value) {
            if (value != undefined) {
                this.mstrUniZoneDescA = value;
                this.hmProperty["UniZoneDescA"] = true;
            }
        }
        /**
         * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_School() {
            return this.mstrid_School;
        }
        /**
         * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_School(value) {
            if (value != undefined) {
                this.mstrid_School = value;
                this.hmProperty["id_School"] = true;
            }
        }
        /**
         * id_Uni(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_Uni() {
            return this.mstrid_Uni;
        }
        /**
         * id_Uni(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_Uni(value) {
            if (value != undefined) {
                this.mstrid_Uni = value;
                this.hmProperty["id_Uni"] = true;
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
        * 常量:"id_UniZone"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_UniZone() { return "id_UniZone"; } //校区流水号
        /**
        * 常量:"UniZoneID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UniZoneID() { return "UniZoneID"; } //校区编号
        /**
        * 常量:"UniZoneDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UniZoneDesc() { return "UniZoneDesc"; } //校区名称
        /**
        * 常量:"UniZoneDescA"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UniZoneDescA() { return "UniZoneDescA"; } //UniZoneDescA
        /**
        * 常量:"id_School"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_School() { return "id_School"; } //学校流水号
        /**
        * 常量:"id_Uni"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Uni() { return "id_Uni"; } //id_Uni
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
    exports.clsXzUniZoneEN = clsXzUniZoneEN;
    clsXzUniZoneEN._CurrTabName = "XzUniZone"; //当前表名,与该类相关的表名
    clsXzUniZoneEN._KeyFldName = "id_UniZone"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsXzUniZoneEN.mintAttributeCount = 9;
    clsXzUniZoneEN.AttributeName = ["id_UniZone", "UniZoneID", "UniZoneDesc", "UniZoneDescA", "id_School", "id_Uni", "modifyUserID", "modifyDate", "memo"];
    /**
    * 校区(XzUniZone)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsXzUniZoneEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_UniZone = "";
            /**
             * 校区编号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.UniZoneID = "";
            /**
             * 校区名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.UniZoneDesc = "";
            /**
             * UniZoneDescA(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.UniZoneDescA = "";
            /**
             * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_School = "";
            /**
             * id_Uni(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_Uni = "";
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
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsXzUniZoneEN_Sim = clsXzUniZoneEN_Sim;
});
