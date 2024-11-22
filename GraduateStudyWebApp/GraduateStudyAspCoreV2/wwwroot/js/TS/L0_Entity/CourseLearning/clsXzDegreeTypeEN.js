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
    exports.clsXzDegreeTypeEN_Sim = exports.clsXzDegreeTypeEN = void 0;
    /**
    * 类名:clsXzDegreeTypeEN
    * 表名:XzDegreeType(01120067)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:01:08
    * 生成者:pyf
    * 工程名称:问卷调查
    * 工程ID:0112
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:课程学习
    * 模块英文名:CourseLearning
    * 框架-层名:实体层(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 行政学位类型(XzDegreeType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsXzDegreeTypeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrid_DegreeType = ""; //学位类型流水号
            this.mstrXwTypeID = ""; //学位类型ID
            this.mstrXwTypeDesc = ""; //学位类型名称
            this.mstrXwTypeDesc_EN = ""; //学位类型名称_EN
            this.mstrMemo = ""; //备注
        }
        /**
         * 学位类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_DegreeType() {
            return this.mstrid_DegreeType;
        }
        /**
         * 学位类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_DegreeType(value) {
            if (value != undefined) {
                this.mstrid_DegreeType = value;
                this.hmProperty["id_DegreeType"] = true;
            }
        }
        /**
         * 学位类型ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get XwTypeID() {
            return this.mstrXwTypeID;
        }
        /**
         * 学位类型ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set XwTypeID(value) {
            if (value != undefined) {
                this.mstrXwTypeID = value;
                this.hmProperty["XwTypeID"] = true;
            }
        }
        /**
         * 学位类型名称(说明:;字段类型:varchar;字段长度:60;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get XwTypeDesc() {
            return this.mstrXwTypeDesc;
        }
        /**
         * 学位类型名称(说明:;字段类型:varchar;字段长度:60;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set XwTypeDesc(value) {
            if (value != undefined) {
                this.mstrXwTypeDesc = value;
                this.hmProperty["XwTypeDesc"] = true;
            }
        }
        /**
         * 学位类型名称_EN(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get XwTypeDesc_EN() {
            return this.mstrXwTypeDesc_EN;
        }
        /**
         * 学位类型名称_EN(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set XwTypeDesc_EN(value) {
            if (value != undefined) {
                this.mstrXwTypeDesc_EN = value;
                this.hmProperty["XwTypeDesc_EN"] = true;
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
        * 常量:"id_DegreeType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_DegreeType() { return "id_DegreeType"; } //学位类型流水号
        /**
        * 常量:"XwTypeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_XwTypeID() { return "XwTypeID"; } //学位类型ID
        /**
        * 常量:"XwTypeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_XwTypeDesc() { return "XwTypeDesc"; } //学位类型名称
        /**
        * 常量:"XwTypeDesc_EN"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_XwTypeDesc_EN() { return "XwTypeDesc_EN"; } //学位类型名称_EN
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
    exports.clsXzDegreeTypeEN = clsXzDegreeTypeEN;
    clsXzDegreeTypeEN._CurrTabName = "XzDegreeType"; //当前表名,与该类相关的表名
    clsXzDegreeTypeEN._KeyFldName = "id_DegreeType"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsXzDegreeTypeEN.mintAttributeCount = 5;
    clsXzDegreeTypeEN.AttributeName = ["id_DegreeType", "XwTypeID", "XwTypeDesc", "XwTypeDesc_EN", "memo"];
    /**
    * 行政学位类型(XzDegreeType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsXzDegreeTypeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 学位类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_DegreeType = "";
            /**
             * 学位类型ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.XwTypeID = "";
            /**
             * 学位类型名称(说明:;字段类型:varchar;字段长度:60;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.XwTypeDesc = "";
            /**
             * 学位类型名称_EN(说明:;字段类型:varchar;字段长度:200;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.XwTypeDesc_EN = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsXzDegreeTypeEN_Sim = clsXzDegreeTypeEN_Sim;
});
