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
    exports.clsPaperHistoryLogEN_Sim = exports.clsPaperHistoryLogEN = void 0;
    /**
    * 类名:clsPaperHistoryLogEN
    * 表名:PaperHistoryLog(01120580)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:07:31
    * 生成者:pyf
    * 工程名称:问卷调查
    * 工程ID:0112
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培论文
    * 模块英文名:GraduateEduPaper
    * 框架-层名:实体层(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 论文历史记录(PaperHistoryLog)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsPaperHistoryLogEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mlngPaperHistoryLogId = 0; //PaperHistoryLogId
            this.mstrPaperId = ""; //论文Id
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrMeno = ""; //备注
        }
        /**
         * PaperHistoryLogId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get PaperHistoryLogId() {
            return this.mlngPaperHistoryLogId;
        }
        /**
         * PaperHistoryLogId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set PaperHistoryLogId(value) {
            if (value != undefined) {
                this.mlngPaperHistoryLogId = value;
                this.hmProperty["PaperHistoryLogId"] = true;
            }
        }
        /**
         * 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get paperId() {
            return this.mstrPaperId;
        }
        /**
         * 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set paperId(value) {
            if (value != undefined) {
                this.mstrPaperId = value;
                this.hmProperty["paperId"] = true;
            }
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get updUser() {
            return this.mstrUpdUser;
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set updUser(value) {
            if (value != undefined) {
                this.mstrUpdUser = value;
                this.hmProperty["updUser"] = true;
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
         * 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get meno() {
            return this.mstrMeno;
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set meno(value) {
            if (value != undefined) {
                this.mstrMeno = value;
                this.hmProperty["meno"] = true;
            }
        }
        /**
        * 常量:"PaperHistoryLogId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperHistoryLogId() { return "PaperHistoryLogId"; } //PaperHistoryLogId
        /**
        * 常量:"paperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"updUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"updDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"meno"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Meno() { return "meno"; } //备注
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
    exports.clsPaperHistoryLogEN = clsPaperHistoryLogEN;
    clsPaperHistoryLogEN._CurrTabName = "PaperHistoryLog"; //当前表名,与该类相关的表名
    clsPaperHistoryLogEN._KeyFldName = "PaperHistoryLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsPaperHistoryLogEN.mintAttributeCount = 5;
    clsPaperHistoryLogEN.AttributeName = ["PaperHistoryLogId", "paperId", "updUser", "updDate", "meno"];
    /**
    * 论文历史记录(PaperHistoryLog)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsPaperHistoryLogEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * PaperHistoryLogId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.PaperHistoryLogId = 0;
            /**
             * 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.paperId = "";
            /**
             * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.updUser = "";
            /**
             * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.updDate = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.meno = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsPaperHistoryLogEN_Sim = clsPaperHistoryLogEN_Sim;
});
