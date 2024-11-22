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
    exports.clscc_ThemesEN_Sim = exports.clscc_ThemesEN = void 0;
    /**
    * 类名:clscc_ThemesEN
    * 表名:cc_Themes(01120069)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:01:15
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
    * 课程主题(cc_Themes)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clscc_ThemesEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrThemeId = ""; //主题Id
            this.mstrThemeName = ""; //主题名
            this.mstrThemeDesc = ""; //主题描述
            this.mstrPageName = ""; //页面名称
            this.mstrExampleImgPath = ""; //示例图路径
            this.mintOrderNum = 0; //序号
            this.mbolIsUse = false; //是否使用
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrMemo = ""; //备注
        }
        /**
         * 主题Id(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get ThemeId() {
            return this.mstrThemeId;
        }
        /**
         * 主题Id(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set ThemeId(value) {
            if (value != undefined) {
                this.mstrThemeId = value;
                this.hmProperty["ThemeId"] = true;
            }
        }
        /**
         * 主题名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get ThemeName() {
            return this.mstrThemeName;
        }
        /**
         * 主题名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set ThemeName(value) {
            if (value != undefined) {
                this.mstrThemeName = value;
                this.hmProperty["ThemeName"] = true;
            }
        }
        /**
         * 主题描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get ThemeDesc() {
            return this.mstrThemeDesc;
        }
        /**
         * 主题描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set ThemeDesc(value) {
            if (value != undefined) {
                this.mstrThemeDesc = value;
                this.hmProperty["ThemeDesc"] = true;
            }
        }
        /**
         * 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get PageName() {
            return this.mstrPageName;
        }
        /**
         * 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set PageName(value) {
            if (value != undefined) {
                this.mstrPageName = value;
                this.hmProperty["PageName"] = true;
            }
        }
        /**
         * 示例图路径(说明:;字段类型:varchar;字段长度:300;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get ExampleImgPath() {
            return this.mstrExampleImgPath;
        }
        /**
         * 示例图路径(说明:;字段类型:varchar;字段长度:300;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set ExampleImgPath(value) {
            if (value != undefined) {
                this.mstrExampleImgPath = value;
                this.hmProperty["ExampleImgPath"] = true;
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
         * 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get IsUse() {
            return this.mbolIsUse;
        }
        /**
         * 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set IsUse(value) {
            if (value != undefined) {
                this.mbolIsUse = value;
                this.hmProperty["IsUse"] = true;
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
        * 常量:"ThemeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ThemeId() { return "ThemeId"; } //主题Id
        /**
        * 常量:"ThemeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ThemeName() { return "ThemeName"; } //主题名
        /**
        * 常量:"ThemeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ThemeDesc() { return "ThemeDesc"; } //主题描述
        /**
        * 常量:"PageName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PageName() { return "PageName"; } //页面名称
        /**
        * 常量:"ExampleImgPath"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExampleImgPath() { return "ExampleImgPath"; } //示例图路径
        /**
        * 常量:"orderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
        /**
        * 常量:"IsUse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsUse() { return "IsUse"; } //是否使用
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
    exports.clscc_ThemesEN = clscc_ThemesEN;
    clscc_ThemesEN._CurrTabName = "cc_Themes"; //当前表名,与该类相关的表名
    clscc_ThemesEN._KeyFldName = "ThemeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clscc_ThemesEN.mintAttributeCount = 10;
    clscc_ThemesEN.AttributeName = ["ThemeId", "ThemeName", "ThemeDesc", "PageName", "ExampleImgPath", "orderNum", "IsUse", "updDate", "updUserId", "memo"];
    /**
    * 课程主题(cc_Themes)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clscc_ThemesEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 主题Id(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.ThemeId = "";
            /**
             * 主题名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.ThemeName = "";
            /**
             * 主题描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.ThemeDesc = "";
            /**
             * 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.PageName = "";
            /**
             * 示例图路径(说明:;字段类型:varchar;字段长度:300;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.ExampleImgPath = "";
            /**
             * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.orderNum = 0;
            /**
             * 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.IsUse = false;
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
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clscc_ThemesEN_Sim = clscc_ThemesEN_Sim;
});
