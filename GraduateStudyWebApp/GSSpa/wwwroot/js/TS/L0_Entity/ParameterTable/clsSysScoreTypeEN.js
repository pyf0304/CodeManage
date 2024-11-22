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
    exports.clsSysScoreTypeEN = void 0;
    /**
    * 类名:clsSysScoreTypeEN
    * 表名:SysScoreType(01120631)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 16:58:52
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
    * 评分类型表(SysScoreType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsSysScoreTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrScoreTypeId = ""; //分数类型Id
            this.mstrScoreTypeName = ""; //分数类型名称
            this.mstrOnlyId = ""; //OnlyId
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.scoreTypeId = ""; //分数类型Id
            this.scoreTypeName = ""; //分数类型名称
            this.onlyId = ""; //OnlyId
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
        }
        /**
         * 分数类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetScoreTypeId(value) {
            if (value != undefined) {
                this.scoreTypeId = value;
                this.hmProperty["scoreTypeId"] = true;
            }
        }
        /**
         * 分数类型名称(说明:;字段类型:varchar;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetScoreTypeName(value) {
            if (value != undefined) {
                this.scoreTypeName = value;
                this.hmProperty["scoreTypeName"] = true;
            }
        }
        /**
         * OnlyId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOnlyId(value) {
            if (value != undefined) {
                this.onlyId = value;
                this.hmProperty["onlyId"] = true;
            }
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdUser(value) {
            if (value != undefined) {
                this.updUser = value;
                this.hmProperty["updUser"] = true;
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
                case clsSysScoreTypeEN.con_ScoreTypeId:
                    return this.scoreTypeId;
                case clsSysScoreTypeEN.con_ScoreTypeName:
                    return this.scoreTypeName;
                case clsSysScoreTypeEN.con_OnlyId:
                    return this.onlyId;
                case clsSysScoreTypeEN.con_UpdUser:
                    return this.updUser;
                case clsSysScoreTypeEN.con_UpdDate:
                    return this.updDate;
                case clsSysScoreTypeEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SysScoreType]中不存在！`;
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
                case clsSysScoreTypeEN.con_ScoreTypeId:
                    this.scoreTypeId = strValue;
                    this.hmProperty["scoreTypeId"] = true;
                    break;
                case clsSysScoreTypeEN.con_ScoreTypeName:
                    this.scoreTypeName = strValue;
                    this.hmProperty["scoreTypeName"] = true;
                    break;
                case clsSysScoreTypeEN.con_OnlyId:
                    this.onlyId = strValue;
                    this.hmProperty["onlyId"] = true;
                    break;
                case clsSysScoreTypeEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsSysScoreTypeEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsSysScoreTypeEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[SysScoreType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ScoreTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ScoreTypeId() { return "scoreTypeId"; } //分数类型Id
        /**
        * 常量:"ScoreTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ScoreTypeName() { return "scoreTypeName"; } //分数类型名称
        /**
        * 常量:"OnlyId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OnlyId() { return "onlyId"; } //OnlyId
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
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
    exports.clsSysScoreTypeEN = clsSysScoreTypeEN;
    clsSysScoreTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsSysScoreTypeEN.CacheModeId = "03"; //localStorage
    clsSysScoreTypeEN._CurrTabName = "SysScoreType"; //当前表名,与该类相关的表名
    clsSysScoreTypeEN._KeyFldName = "ScoreTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsSysScoreTypeEN.mintAttributeCount = 6;
    clsSysScoreTypeEN.AttributeName = ["scoreTypeId", "scoreTypeName", "onlyId", "updUser", "updDate", "memo"];
});
