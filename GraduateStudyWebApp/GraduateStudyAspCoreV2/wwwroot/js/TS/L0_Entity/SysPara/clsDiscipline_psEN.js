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
    exports.clsDiscipline_psEN_Sim = exports.clsDiscipline_psEN = void 0;
    /**
    * 类名:clsDiscipline_psEN
    * 表名:Discipline_ps(01120100)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 17:59:04
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
    * 学科_ps(Discipline_ps)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsDiscipline_psEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrid_Discipline_Ps = ""; //学科流水号
            this.mstrDisciplineID = ""; //学科ID
            this.mstrDisciplineName = ""; //学科名称
            this.mintOrderNum = 0; //序号
            this.mbolIsVisible = false; //是否显示
            this.mstrid_School = ""; //学校流水号
            this.mstrMemo = ""; //备注
        }
        /**
         * 学科流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_Discipline_Ps() {
            return this.mstrid_Discipline_Ps;
        }
        /**
         * 学科流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_Discipline_Ps(value) {
            if (value != undefined) {
                this.mstrid_Discipline_Ps = value;
                this.hmProperty["id_Discipline_Ps"] = true;
            }
        }
        /**
         * 学科ID(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get DisciplineID() {
            return this.mstrDisciplineID;
        }
        /**
         * 学科ID(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set DisciplineID(value) {
            if (value != undefined) {
                this.mstrDisciplineID = value;
                this.hmProperty["DisciplineID"] = true;
            }
        }
        /**
         * 学科名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get DisciplineName() {
            return this.mstrDisciplineName;
        }
        /**
         * 学科名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set DisciplineName(value) {
            if (value != undefined) {
                this.mstrDisciplineName = value;
                this.hmProperty["DisciplineName"] = true;
            }
        }
        /**
         * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get orderNum() {
            return this.mintOrderNum;
        }
        /**
         * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set orderNum(value) {
            if (value != undefined) {
                this.mintOrderNum = value;
                this.hmProperty["orderNum"] = true;
            }
        }
        /**
         * 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get isVisible() {
            return this.mbolIsVisible;
        }
        /**
         * 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set isVisible(value) {
            if (value != undefined) {
                this.mbolIsVisible = value;
                this.hmProperty["isVisible"] = true;
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
        * 常量:"id_Discipline_Ps"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Discipline_Ps() { return "id_Discipline_Ps"; } //学科流水号
        /**
        * 常量:"DisciplineID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DisciplineID() { return "DisciplineID"; } //学科ID
        /**
        * 常量:"DisciplineName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DisciplineName() { return "DisciplineName"; } //学科名称
        /**
        * 常量:"orderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
        /**
        * 常量:"isVisible"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsVisible() { return "isVisible"; } //是否显示
        /**
        * 常量:"id_School"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_School() { return "id_School"; } //学校流水号
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
    exports.clsDiscipline_psEN = clsDiscipline_psEN;
    clsDiscipline_psEN._CurrTabName = "Discipline_ps"; //当前表名,与该类相关的表名
    clsDiscipline_psEN._KeyFldName = "id_Discipline_Ps"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsDiscipline_psEN.mintAttributeCount = 7;
    clsDiscipline_psEN.AttributeName = ["id_Discipline_Ps", "DisciplineID", "DisciplineName", "orderNum", "isVisible", "id_School", "memo"];
    /**
    * 学科_ps(Discipline_ps)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsDiscipline_psEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 学科流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_Discipline_Ps = "";
            /**
             * 学科ID(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.DisciplineID = "";
            /**
             * 学科名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.DisciplineName = "";
            /**
             * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.orderNum = 0;
            /**
             * 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.isVisible = false;
            /**
             * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_School = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsDiscipline_psEN_Sim = clsDiscipline_psEN_Sim;
});
