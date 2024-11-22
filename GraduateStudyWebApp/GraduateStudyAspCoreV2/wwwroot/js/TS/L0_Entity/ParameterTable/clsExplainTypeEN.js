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
    exports.clsExplainTypeEN = void 0;
    /**
    * 类名:clsExplainTypeEN
    * 表名:ExplainType(01120548)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:50:41
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培参数(ParameterTable)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 说明类型(ExplainType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsExplainTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrExplainTypeId = ""; //说明类型Id
            this.mstrExplainTypeName = ""; //说明类型名
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.explainTypeId = ""; //说明类型Id
            this.explainTypeName = ""; //说明类型名
            this.updDate = ""; //修改日期
            this.updUserId = ""; //修改用户Id
            this.memo = ""; //备注
        }
        /**
         * 说明类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetExplainTypeId(value) {
            if (value != undefined) {
                this.explainTypeId = value;
                this.hmProperty["explainTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 说明类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetExplainTypeName(value) {
            if (value != undefined) {
                this.explainTypeName = value;
                this.hmProperty["explainTypeName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdDate(value) {
            if (value != undefined) {
                this.updDate = value;
                this.hmProperty["updDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdUserId(value) {
            if (value != undefined) {
                this.updUserId = value;
                this.hmProperty["updUserId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMemo(value) {
            if (value != undefined) {
                this.memo = value;
                this.hmProperty["memo"] = true;
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
                case clsExplainTypeEN.con_ExplainTypeId:
                    return this.explainTypeId;
                case clsExplainTypeEN.con_ExplainTypeName:
                    return this.explainTypeName;
                case clsExplainTypeEN.con_UpdDate:
                    return this.updDate;
                case clsExplainTypeEN.con_UpdUserId:
                    return this.updUserId;
                case clsExplainTypeEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[ExplainType]中不存在！`;
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
                case clsExplainTypeEN.con_ExplainTypeId:
                    this.explainTypeId = strValue;
                    this.hmProperty["explainTypeId"] = true;
                    break;
                case clsExplainTypeEN.con_ExplainTypeName:
                    this.explainTypeName = strValue;
                    this.hmProperty["explainTypeName"] = true;
                    break;
                case clsExplainTypeEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsExplainTypeEN.con_UpdUserId:
                    this.updUserId = strValue;
                    this.hmProperty["updUserId"] = true;
                    break;
                case clsExplainTypeEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[ExplainType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ExplainTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExplainTypeId() { return "explainTypeId"; } //说明类型Id
        /**
        * 常量:"ExplainTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExplainTypeName() { return "explainTypeName"; } //说明类型名
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"UpdUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUserId() { return "updUserId"; } //修改用户Id
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
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
    exports.clsExplainTypeEN = clsExplainTypeEN;
    clsExplainTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsExplainTypeEN.CacheModeId = "03"; //localStorage
    clsExplainTypeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsExplainTypeEN.WhereFormat = ""; //条件格式串
    clsExplainTypeEN._CurrTabName = "ExplainType"; //当前表名,与该类相关的表名
    clsExplainTypeEN._KeyFldName = "ExplainTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsExplainTypeEN.mintAttributeCount = 5;
    clsExplainTypeEN.AttributeName = ["explainTypeId", "explainTypeName", "updDate", "updUserId", "memo"];
});
