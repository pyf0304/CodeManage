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
    exports.clsSysVoteTypeEN = void 0;
    /**
    * 类名:clsSysVoteTypeEN
    * 表名:SysVoteType(01120638)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:23
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
    * 系统点赞类型(SysVoteType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsSysVoteTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrVoteTypeId = ""; //点赞类型Id
            this.mstrVoteTypeName = ""; //点赞类型名称
            this.mstrVoteTable = ""; //点赞表
            this.mstrVoteTableId = ""; //点赞表Id
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.voteTypeId = ""; //点赞类型Id
            this.voteTypeName = ""; //点赞类型名称
            this.voteTable = ""; //点赞表
            this.voteTableId = ""; //点赞表Id
            this.memo = ""; //备注
        }
        /**
         * 点赞类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetVoteTypeId(value) {
            if (value != undefined) {
                this.voteTypeId = value;
                this.hmProperty["voteTypeId"] = true;
            }
        }
        /**
         * 点赞类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetVoteTypeName(value) {
            if (value != undefined) {
                this.voteTypeName = value;
                this.hmProperty["voteTypeName"] = true;
            }
        }
        /**
         * 点赞表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetVoteTable(value) {
            if (value != undefined) {
                this.voteTable = value;
                this.hmProperty["voteTable"] = true;
            }
        }
        /**
         * 点赞表Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetVoteTableId(value) {
            if (value != undefined) {
                this.voteTableId = value;
                this.hmProperty["voteTableId"] = true;
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
                case clsSysVoteTypeEN.con_VoteTypeId:
                    return this.voteTypeId;
                case clsSysVoteTypeEN.con_VoteTypeName:
                    return this.voteTypeName;
                case clsSysVoteTypeEN.con_VoteTable:
                    return this.voteTable;
                case clsSysVoteTypeEN.con_VoteTableId:
                    return this.voteTableId;
                case clsSysVoteTypeEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SysVoteType]中不存在！`;
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
                case clsSysVoteTypeEN.con_VoteTypeId:
                    this.voteTypeId = strValue;
                    this.hmProperty["voteTypeId"] = true;
                    break;
                case clsSysVoteTypeEN.con_VoteTypeName:
                    this.voteTypeName = strValue;
                    this.hmProperty["voteTypeName"] = true;
                    break;
                case clsSysVoteTypeEN.con_VoteTable:
                    this.voteTable = strValue;
                    this.hmProperty["voteTable"] = true;
                    break;
                case clsSysVoteTypeEN.con_VoteTableId:
                    this.voteTableId = strValue;
                    this.hmProperty["voteTableId"] = true;
                    break;
                case clsSysVoteTypeEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[SysVoteType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"VoteTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteTypeId() { return "voteTypeId"; } //点赞类型Id
        /**
        * 常量:"VoteTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteTypeName() { return "voteTypeName"; } //点赞类型名称
        /**
        * 常量:"VoteTable"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteTable() { return "voteTable"; } //点赞表
        /**
        * 常量:"VoteTableId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteTableId() { return "voteTableId"; } //点赞表Id
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
    exports.clsSysVoteTypeEN = clsSysVoteTypeEN;
    clsSysVoteTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsSysVoteTypeEN.CacheModeId = "03"; //localStorage
    clsSysVoteTypeEN._CurrTabName = "SysVoteType"; //当前表名,与该类相关的表名
    clsSysVoteTypeEN._KeyFldName = "VoteTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsSysVoteTypeEN.mintAttributeCount = 5;
    clsSysVoteTypeEN.AttributeName = ["voteTypeId", "voteTypeName", "voteTable", "voteTableId", "memo"];
});
