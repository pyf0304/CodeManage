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
    exports.clsRsDegreeEN_Sim = exports.clsRsDegreeEN = void 0;
    /**
    * 类名:clsRsDegreeEN
    * 表名:RsDegree(01120106)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 17:59:27
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
    * 学位(RsDegree)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsRsDegreeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrid_Degree = ""; //学位流水号
            this.mstrDegreeID = ""; //学位代号
            this.mstrDegreeName = ""; //学位名称
        }
        /**
         * 学位流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_Degree() {
            return this.mstrid_Degree;
        }
        /**
         * 学位流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_Degree(value) {
            if (value != undefined) {
                this.mstrid_Degree = value;
                this.hmProperty["id_Degree"] = true;
            }
        }
        /**
         * 学位代号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get DegreeID() {
            return this.mstrDegreeID;
        }
        /**
         * 学位代号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set DegreeID(value) {
            if (value != undefined) {
                this.mstrDegreeID = value;
                this.hmProperty["DegreeID"] = true;
            }
        }
        /**
         * 学位名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get DegreeName() {
            return this.mstrDegreeName;
        }
        /**
         * 学位名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set DegreeName(value) {
            if (value != undefined) {
                this.mstrDegreeName = value;
                this.hmProperty["DegreeName"] = true;
            }
        }
        /**
        * 常量:"id_Degree"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Degree() { return "id_Degree"; } //学位流水号
        /**
        * 常量:"DegreeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DegreeID() { return "DegreeID"; } //学位代号
        /**
        * 常量:"DegreeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DegreeName() { return "DegreeName"; } //学位名称
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
    exports.clsRsDegreeEN = clsRsDegreeEN;
    clsRsDegreeEN._CurrTabName = "RsDegree"; //当前表名,与该类相关的表名
    clsRsDegreeEN._KeyFldName = "id_Degree"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsRsDegreeEN.mintAttributeCount = 3;
    clsRsDegreeEN.AttributeName = ["id_Degree", "DegreeID", "DegreeName"];
    /**
    * 学位(RsDegree)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsRsDegreeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 学位流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_Degree = "";
            /**
             * 学位代号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.DegreeID = "";
            /**
             * 学位名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.DegreeName = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsRsDegreeEN_Sim = clsRsDegreeEN_Sim;
});
