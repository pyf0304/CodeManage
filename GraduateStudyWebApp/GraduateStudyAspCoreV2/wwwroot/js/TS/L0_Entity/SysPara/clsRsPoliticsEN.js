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
    exports.clsRsPoliticsEN_Sim = exports.clsRsPoliticsEN = void 0;
    /**
    * 类名:clsRsPoliticsEN
    * 表名:RsPolitics(01120110)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 17:59:42
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
    * 政治面貌(RsPolitics)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsRsPoliticsEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrid_Politics = ""; //政治面貌流水号
            this.mstrPoliticsID = ""; //政治面貌ID
            this.mstrPoliticsName = ""; //政治面貌
            this.mstrPoliticsID_NGB = ""; //PoliticsID_NGB
            this.mstrPoliticsRecruitID = ""; //PoliticsRecruitID
            this.mstrModifyDate = ""; //修改日期
            this.mstrModifyUserID = ""; //修改人
        }
        /**
         * 政治面貌流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_Politics() {
            return this.mstrid_Politics;
        }
        /**
         * 政治面貌流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_Politics(value) {
            if (value != undefined) {
                this.mstrid_Politics = value;
                this.hmProperty["id_Politics"] = true;
            }
        }
        /**
         * 政治面貌ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get PoliticsID() {
            return this.mstrPoliticsID;
        }
        /**
         * 政治面貌ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set PoliticsID(value) {
            if (value != undefined) {
                this.mstrPoliticsID = value;
                this.hmProperty["PoliticsID"] = true;
            }
        }
        /**
         * 政治面貌(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get PoliticsName() {
            return this.mstrPoliticsName;
        }
        /**
         * 政治面貌(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set PoliticsName(value) {
            if (value != undefined) {
                this.mstrPoliticsName = value;
                this.hmProperty["PoliticsName"] = true;
            }
        }
        /**
         * PoliticsID_NGB(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get PoliticsID_NGB() {
            return this.mstrPoliticsID_NGB;
        }
        /**
         * PoliticsID_NGB(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set PoliticsID_NGB(value) {
            if (value != undefined) {
                this.mstrPoliticsID_NGB = value;
                this.hmProperty["PoliticsID_NGB"] = true;
            }
        }
        /**
         * PoliticsRecruitID(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get PoliticsRecruitID() {
            return this.mstrPoliticsRecruitID;
        }
        /**
         * PoliticsRecruitID(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set PoliticsRecruitID(value) {
            if (value != undefined) {
                this.mstrPoliticsRecruitID = value;
                this.hmProperty["PoliticsRecruitID"] = true;
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
        * 常量:"id_Politics"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Politics() { return "id_Politics"; } //政治面貌流水号
        /**
        * 常量:"PoliticsID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PoliticsID() { return "PoliticsID"; } //政治面貌ID
        /**
        * 常量:"PoliticsName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PoliticsName() { return "PoliticsName"; } //政治面貌
        /**
        * 常量:"PoliticsID_NGB"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PoliticsID_NGB() { return "PoliticsID_NGB"; } //PoliticsID_NGB
        /**
        * 常量:"PoliticsRecruitID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PoliticsRecruitID() { return "PoliticsRecruitID"; } //PoliticsRecruitID
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
    exports.clsRsPoliticsEN = clsRsPoliticsEN;
    clsRsPoliticsEN._CurrTabName = "RsPolitics"; //当前表名,与该类相关的表名
    clsRsPoliticsEN._KeyFldName = "id_Politics"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsRsPoliticsEN.mintAttributeCount = 7;
    clsRsPoliticsEN.AttributeName = ["id_Politics", "PoliticsID", "PoliticsName", "PoliticsID_NGB", "PoliticsRecruitID", "modifyDate", "modifyUserID"];
    /**
    * 政治面貌(RsPolitics)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsRsPoliticsEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 政治面貌流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_Politics = "";
            /**
             * 政治面貌ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.PoliticsID = "";
            /**
             * 政治面貌(说明:;字段类型:varchar;字段长度:30;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.PoliticsName = "";
            /**
             * PoliticsID_NGB(说明:;字段类型:varchar;字段长度:10;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.PoliticsID_NGB = "";
            /**
             * PoliticsRecruitID(说明:;字段类型:char;字段长度:2;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.PoliticsRecruitID = "";
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
    exports.clsRsPoliticsEN_Sim = clsRsPoliticsEN_Sim;
});
