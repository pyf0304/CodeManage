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
    exports.clsSysDefaValNameEN = void 0;
    /**
    * 类名:clsSysDefaValNameEN
    * 表名:SysDefaValName(01120936)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:52:23
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:日志管理(LogManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * SysDefaValName(SysDefaValName)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsSysDefaValNameEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrDefaValNameId = ""; //缺省值名称Id
            this.mstrDefaValName = ""; //缺省值名称
            this.mstrSysDefaValue = ""; //SysDefaValue
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.defaValNameId = ""; //缺省值名称Id
            this.defaValName = ""; //缺省值名称
            this.sysDefaValue = ""; //SysDefaValue
        }
        /**
         * 缺省值名称Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDefaValNameId(value) {
            if (value != undefined) {
                this.defaValNameId = value;
                this.hmProperty["defaValNameId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 缺省值名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDefaValName(value) {
            if (value != undefined) {
                this.defaValName = value;
                this.hmProperty["defaValName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * SysDefaValue(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSysDefaValue(value) {
            if (value != undefined) {
                this.sysDefaValue = value;
                this.hmProperty["sysDefaValue"] = true;
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
                case clsSysDefaValNameEN.con_DefaValNameId:
                    return this.defaValNameId;
                case clsSysDefaValNameEN.con_DefaValName:
                    return this.defaValName;
                case clsSysDefaValNameEN.con_SysDefaValue:
                    return this.sysDefaValue;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SysDefaValName]中不存在！`;
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
                case clsSysDefaValNameEN.con_DefaValNameId:
                    this.defaValNameId = strValue;
                    this.hmProperty["defaValNameId"] = true;
                    break;
                case clsSysDefaValNameEN.con_DefaValName:
                    this.defaValName = strValue;
                    this.hmProperty["defaValName"] = true;
                    break;
                case clsSysDefaValNameEN.con_SysDefaValue:
                    this.sysDefaValue = strValue;
                    this.hmProperty["sysDefaValue"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SysDefaValName]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"DefaValNameId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DefaValNameId() { return "defaValNameId"; } //缺省值名称Id
        /**
        * 常量:"DefaValName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DefaValName() { return "defaValName"; } //缺省值名称
        /**
        * 常量:"SysDefaValue"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SysDefaValue() { return "sysDefaValue"; } //SysDefaValue
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
    exports.clsSysDefaValNameEN = clsSysDefaValNameEN;
    clsSysDefaValNameEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsSysDefaValNameEN.CacheModeId = ""; //
    clsSysDefaValNameEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsSysDefaValNameEN.WhereFormat = ""; //条件格式串
    clsSysDefaValNameEN._CurrTabName = "SysDefaValName"; //当前表名,与该类相关的表名
    clsSysDefaValNameEN._KeyFldName = "DefaValNameId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsSysDefaValNameEN.mintAttributeCount = 3;
    clsSysDefaValNameEN.AttributeName = ["defaValNameId", "defaValName", "sysDefaValue"];
});
