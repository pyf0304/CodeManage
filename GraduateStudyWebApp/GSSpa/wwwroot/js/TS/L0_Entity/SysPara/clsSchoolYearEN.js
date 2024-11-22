(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTab.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsSchoolYearEN = void 0;
    /**
    * 类名:clsSchoolYearEN
    * 表名:SchoolYear(01120134)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:45:52
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:系统参数(SysPara)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 学年(SchoolYear)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsSchoolYearEN extends clsGeneralTab_js_1.clsGeneralTab {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            /**
             * 设置对象中私有属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPrivateVar)
            */
            this.mstrSchoolYear = ""; //学年
            this.mstrSchoolYearName = ""; //学年名
            this.mbolIsCurrentSchoolYear = false; //是否当前学年
            this.mbolIsVisible = false; //是否显示
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.schoolYear = ""; //学年
            this.schoolYearName = ""; //学年名
            this.isCurrentSchoolYear = false; //是否当前学年
            this.isVisible = false; //是否显示
        }
        /**
         * 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolYear(value) {
            if (value != undefined) {
                this.schoolYear = value;
                this.hmProperty["schoolYear"] = true;
            }
        }
        /**
         * 学年名(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolYearName(value) {
            if (value != undefined) {
                this.schoolYearName = value;
                this.hmProperty["schoolYearName"] = true;
            }
        }
        /**
         * 是否当前学年(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsCurrentSchoolYear(value) {
            if (value != undefined) {
                this.isCurrentSchoolYear = value;
                this.hmProperty["isCurrentSchoolYear"] = true;
            }
        }
        /**
         * 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsVisible(value) {
            if (value != undefined) {
                this.isVisible = value;
                this.hmProperty["isVisible"] = true;
            }
        }
        /**
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsSchoolYearEN.con_SchoolYear:
                    return this.schoolYear;
                case clsSchoolYearEN.con_SchoolYearName:
                    return this.schoolYearName;
                case clsSchoolYearEN.con_IsCurrentSchoolYear:
                    return this.isCurrentSchoolYear;
                case clsSchoolYearEN.con_IsVisible:
                    return this.isVisible;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SchoolYear]中不存在！`;
                    console.error(strMsg);
                    return "";
            }
        }
        /**
         * 设置对象中某字段名的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetFldValue)
         * @param strFldName:字段名
         * @param strValue:字段值
         * @returns 字段值
        */
        SetFldValue(strFldName, strValue) {
            const strThisFuncName = "SetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsSchoolYearEN.con_SchoolYear:
                    this.schoolYear = strValue;
                    this.hmProperty["schoolYear"] = true;
                    break;
                case clsSchoolYearEN.con_SchoolYearName:
                    this.schoolYearName = strValue;
                    this.hmProperty["schoolYearName"] = true;
                    break;
                case clsSchoolYearEN.con_IsCurrentSchoolYear:
                    this.isCurrentSchoolYear = Boolean(strValue);
                    this.hmProperty["isCurrentSchoolYear"] = true;
                    break;
                case clsSchoolYearEN.con_IsVisible:
                    this.isVisible = Boolean(strValue);
                    this.hmProperty["isVisible"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SchoolYear]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"SchoolYear"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolYear() { return "schoolYear"; } //学年
        /**
        * 常量:"SchoolYearName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolYearName() { return "schoolYearName"; } //学年名
        /**
        * 常量:"IsCurrentSchoolYear"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsCurrentSchoolYear() { return "isCurrentSchoolYear"; } //是否当前学年
        /**
        * 常量:"IsVisible"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsVisible() { return "isVisible"; } //是否显示
        /**
        * 设置条件字段值.
        * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetCondFldValue)
        * @param strFldName:字段名
        * @param strFldValue:字段值
        * @param strComparisonOp:比较操作条符
        * @returns 根据关键字获取的名称
        **/
        SetCondFldValue(strFldName, strFldValue, strComparisonOp) {
            const strThisFuncName = this.SetCondFldValue.name;
            this.SetFldValue(strFldName, strFldValue);
            if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false) {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            else {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
        }
    }
    exports.clsSchoolYearEN = clsSchoolYearEN;
    clsSchoolYearEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsSchoolYearEN.CacheModeId = "03"; //localStorage
    clsSchoolYearEN._CurrTabName = "SchoolYear"; //当前表名,与该类相关的表名
    clsSchoolYearEN._KeyFldName = "SchoolYear"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsSchoolYearEN.mintAttributeCount = 4;
    clsSchoolYearEN.AttributeName = ["schoolYear", "schoolYearName", "isCurrentSchoolYear", "isVisible"];
});
