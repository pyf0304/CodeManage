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
    exports.clsStudyLevelEN_Sim = exports.clsStudyLevelEN = void 0;
    /**
    * 类名:clsStudyLevelEN
    * 表名:StudyLevel(01120212)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:00:12
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
    * 学段(StudyLevel)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsStudyLevelEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrid_StudyLevel = ""; //id_StudyLevel
            this.mstrStudyLevelName = ""; //学段名称
            this.mstrstudyLevelID = ""; //studyLevelID
            this.mintSequenceNumber = 0; //SequenceNumber
            this.mstrMemo = ""; //备注
        }
        /**
         * id_StudyLevel(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_StudyLevel() {
            return this.mstrid_StudyLevel;
        }
        /**
         * id_StudyLevel(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_StudyLevel(value) {
            if (value != undefined) {
                this.mstrid_StudyLevel = value;
                this.hmProperty["id_StudyLevel"] = true;
            }
        }
        /**
         * 学段名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get StudyLevelName() {
            return this.mstrStudyLevelName;
        }
        /**
         * 学段名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set StudyLevelName(value) {
            if (value != undefined) {
                this.mstrStudyLevelName = value;
                this.hmProperty["StudyLevelName"] = true;
            }
        }
        /**
         * studyLevelID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get studyLevelID() {
            return this.mstrstudyLevelID;
        }
        /**
         * studyLevelID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set studyLevelID(value) {
            if (value != undefined) {
                this.mstrstudyLevelID = value;
                this.hmProperty["studyLevelID"] = true;
            }
        }
        /**
         * SequenceNumber(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get SequenceNumber() {
            return this.mintSequenceNumber;
        }
        /**
         * SequenceNumber(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set SequenceNumber(value) {
            if (value != undefined) {
                this.mintSequenceNumber = value;
                this.hmProperty["SequenceNumber"] = true;
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
        * 常量:"id_StudyLevel"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_StudyLevel() { return "id_StudyLevel"; } //id_StudyLevel
        /**
        * 常量:"StudyLevelName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StudyLevelName() { return "StudyLevelName"; } //学段名称
        /**
        * 常量:"studyLevelID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_studyLevelID() { return "studyLevelID"; } //studyLevelID
        /**
        * 常量:"SequenceNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SequenceNumber() { return "SequenceNumber"; } //SequenceNumber
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
    exports.clsStudyLevelEN = clsStudyLevelEN;
    clsStudyLevelEN._CurrTabName = "StudyLevel"; //当前表名,与该类相关的表名
    clsStudyLevelEN._KeyFldName = "id_StudyLevel"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsStudyLevelEN.mintAttributeCount = 5;
    clsStudyLevelEN.AttributeName = ["id_StudyLevel", "StudyLevelName", "studyLevelID", "SequenceNumber", "memo"];
    /**
    * 学段(StudyLevel)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsStudyLevelEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * id_StudyLevel(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_StudyLevel = "";
            /**
             * 学段名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.StudyLevelName = "";
            /**
             * studyLevelID(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.studyLevelID = "";
            /**
             * SequenceNumber(说明:;字段类型:int;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.SequenceNumber = 0;
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsStudyLevelEN_Sim = clsStudyLevelEN_Sim;
});
