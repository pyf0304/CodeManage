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
    exports.clsSchoolTermEN = void 0;
    /**
    * 类名:clsSchoolTermEN
    * 表名:SchoolTerm(01120135)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:52:17
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
    * 学期(SchoolTerm)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsSchoolTermEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrSchoolTerm = ""; //学期
            this.mstrSchoolTermName = ""; //学期名
            this.mbolIsCurrentSchoolTerm = false; //学期
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.schoolTerm = ""; //学期
            this.schoolTermName = ""; //学期名
            this.isCurrentSchoolTerm = false; //学期
        }
        /**
         * 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolTerm(value) {
            if (value != undefined) {
                this.schoolTerm = value;
                this.hmProperty["schoolTerm"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学期名(说明:;字段类型:char;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolTermName(value) {
            if (value != undefined) {
                this.schoolTermName = value;
                this.hmProperty["schoolTermName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学期(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsCurrentSchoolTerm(value) {
            if (value != undefined) {
                this.isCurrentSchoolTerm = value;
                this.hmProperty["isCurrentSchoolTerm"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                case clsSchoolTermEN.con_SchoolTerm:
                    return this.schoolTerm;
                case clsSchoolTermEN.con_SchoolTermName:
                    return this.schoolTermName;
                case clsSchoolTermEN.con_IsCurrentSchoolTerm:
                    return this.isCurrentSchoolTerm;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SchoolTerm]中不存在！`;
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
                case clsSchoolTermEN.con_SchoolTerm:
                    this.schoolTerm = strValue;
                    this.hmProperty["schoolTerm"] = true;
                    break;
                case clsSchoolTermEN.con_SchoolTermName:
                    this.schoolTermName = strValue;
                    this.hmProperty["schoolTermName"] = true;
                    break;
                case clsSchoolTermEN.con_IsCurrentSchoolTerm:
                    this.isCurrentSchoolTerm = Boolean(strValue);
                    this.hmProperty["isCurrentSchoolTerm"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SchoolTerm]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"SchoolTerm"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolTerm() { return "schoolTerm"; } //学期
        /**
        * 常量:"SchoolTermName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolTermName() { return "schoolTermName"; } //学期名
        /**
        * 常量:"IsCurrentSchoolTerm"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsCurrentSchoolTerm() { return "isCurrentSchoolTerm"; } //学期
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
    exports.clsSchoolTermEN = clsSchoolTermEN;
    clsSchoolTermEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsSchoolTermEN.CacheModeId = "03"; //localStorage
    clsSchoolTermEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsSchoolTermEN.WhereFormat = ""; //条件格式串
    clsSchoolTermEN._CurrTabName = "SchoolTerm"; //当前表名,与该类相关的表名
    clsSchoolTermEN._KeyFldName = "SchoolTerm"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsSchoolTermEN.mintAttributeCount = 3;
    clsSchoolTermEN.AttributeName = ["schoolTerm", "schoolTermName", "isCurrentSchoolTerm"];
});
