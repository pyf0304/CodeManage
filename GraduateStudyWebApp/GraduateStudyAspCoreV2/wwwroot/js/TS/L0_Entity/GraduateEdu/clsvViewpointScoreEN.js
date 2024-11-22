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
    exports.clsvViewpointScoreEN_Sim = exports.clsvViewpointScoreEN = void 0;
    /**
    * 类名:clsvViewpointScoreEN
    * 表名:vViewpointScore(01120609)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:15:50
    * 生成者:pyf
    * 工程名称:问卷调查
    * 工程ID:0112
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研究生培养
    * 模块英文名:GraduateEdu
    * 框架-层名:实体层(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * vViewpointScore(vViewpointScore)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsvViewpointScoreEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mlngViewpointScoreId = 0; //评分Id
            this.mfltViewpointScore = 0.0; //评分
            this.mstrViewpointId = ""; //观点Id
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrMemo = ""; //备注
            this.mstrUserName = ""; //用户名
            this.mstrViewpointName = ""; //观点名称
            this.mstrViewpointContent = ""; //观点内容
            this.mstrReason = ""; //理由
        }
        /**
         * 评分Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get ViewpointScoreId() {
            return this.mlngViewpointScoreId;
        }
        /**
         * 评分Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set ViewpointScoreId(value) {
            if (value != undefined) {
                this.mlngViewpointScoreId = value;
                this.hmProperty["ViewpointScoreId"] = true;
            }
        }
        /**
         * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get viewpointScore() {
            return this.mfltViewpointScore;
        }
        /**
         * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set viewpointScore(value) {
            if (value != undefined) {
                this.mfltViewpointScore = value;
                this.hmProperty["viewpointScore"] = true;
            }
        }
        /**
         * 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get viewpointId() {
            return this.mstrViewpointId;
        }
        /**
         * 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set viewpointId(value) {
            if (value != undefined) {
                this.mstrViewpointId = value;
                this.hmProperty["viewpointId"] = true;
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
         * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get updUserId() {
            return this.mstrUpdUserId;
        }
        /**
         * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set updUserId(value) {
            if (value != undefined) {
                this.mstrUpdUserId = value;
                this.hmProperty["updUserId"] = true;
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
         * 用户名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get userName() {
            return this.mstrUserName;
        }
        /**
         * 用户名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set userName(value) {
            if (value != undefined) {
                this.mstrUserName = value;
                this.hmProperty["userName"] = true;
            }
        }
        /**
         * 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get viewpointName() {
            return this.mstrViewpointName;
        }
        /**
         * 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set viewpointName(value) {
            if (value != undefined) {
                this.mstrViewpointName = value;
                this.hmProperty["viewpointName"] = true;
            }
        }
        /**
         * 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get viewpointContent() {
            return this.mstrViewpointContent;
        }
        /**
         * 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set viewpointContent(value) {
            if (value != undefined) {
                this.mstrViewpointContent = value;
                this.hmProperty["viewpointContent"] = true;
            }
        }
        /**
         * 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get reason() {
            return this.mstrReason;
        }
        /**
         * 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set reason(value) {
            if (value != undefined) {
                this.mstrReason = value;
                this.hmProperty["reason"] = true;
            }
        }
        /**
        * 常量:"ViewpointScoreId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointScoreId() { return "ViewpointScoreId"; } //评分Id
        /**
        * 常量:"viewpointScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointScore() { return "viewpointScore"; } //评分
        /**
        * 常量:"viewpointId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointId() { return "viewpointId"; } //观点Id
        /**
        * 常量:"updDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"updUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUserId() { return "updUserId"; } //修改用户Id
        /**
        * 常量:"memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"userName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"viewpointName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointName() { return "viewpointName"; } //观点名称
        /**
        * 常量:"viewpointContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointContent() { return "viewpointContent"; } //观点内容
        /**
        * 常量:"reason"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Reason() { return "reason"; } //理由
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
    exports.clsvViewpointScoreEN = clsvViewpointScoreEN;
    clsvViewpointScoreEN._CurrTabName = "vViewpointScore"; //当前表名,与该类相关的表名
    clsvViewpointScoreEN._KeyFldName = "ViewpointScoreId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvViewpointScoreEN.mintAttributeCount = 10;
    clsvViewpointScoreEN.AttributeName = ["ViewpointScoreId", "viewpointScore", "viewpointId", "updDate", "updUserId", "memo", "userName", "viewpointName", "viewpointContent", "reason"];
    /**
    * vViewpointScore(vViewpointScore)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsvViewpointScoreEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 评分Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.ViewpointScoreId = 0;
            /**
             * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.viewpointScore = 0.0;
            /**
             * 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.viewpointId = "";
            /**
             * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.updDate = "";
            /**
             * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.updUserId = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            /**
             * 用户名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.userName = "";
            /**
             * 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.viewpointName = "";
            /**
             * 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.viewpointContent = "";
            /**
             * 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.reason = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsvViewpointScoreEN_Sim = clsvViewpointScoreEN_Sim;
});
