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
    exports.clsgs_ParagraphStateEN = void 0;
    /**
    * 类名:clsgs_ParagraphStateEN
    * 表名:gs_ParagraphState(01120745)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:51:06
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
    * 段落状态(gs_ParagraphState)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_ParagraphStateEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrParagraphStateId = ""; //段落状态Id
            this.mstrParagraphStateName = ""; //段落状态
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.paragraphStateId = ""; //段落状态Id
            this.paragraphStateName = ""; //段落状态
            this.memo = ""; //备注
        }
        /**
         * 段落状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParagraphStateId(value) {
            if (value != undefined) {
                this.paragraphStateId = value;
                this.hmProperty["paragraphStateId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 段落状态(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParagraphStateName(value) {
            if (value != undefined) {
                this.paragraphStateName = value;
                this.hmProperty["paragraphStateName"] = true;
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
                case clsgs_ParagraphStateEN.con_ParagraphStateId:
                    return this.paragraphStateId;
                case clsgs_ParagraphStateEN.con_ParagraphStateName:
                    return this.paragraphStateName;
                case clsgs_ParagraphStateEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_ParagraphState]中不存在！`;
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
                case clsgs_ParagraphStateEN.con_ParagraphStateId:
                    this.paragraphStateId = strValue;
                    this.hmProperty["paragraphStateId"] = true;
                    break;
                case clsgs_ParagraphStateEN.con_ParagraphStateName:
                    this.paragraphStateName = strValue;
                    this.hmProperty["paragraphStateName"] = true;
                    break;
                case clsgs_ParagraphStateEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_ParagraphState]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ParagraphStateId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParagraphStateId() { return "paragraphStateId"; } //段落状态Id
        /**
        * 常量:"ParagraphStateName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParagraphStateName() { return "paragraphStateName"; } //段落状态
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
    exports.clsgs_ParagraphStateEN = clsgs_ParagraphStateEN;
    clsgs_ParagraphStateEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_ParagraphStateEN.CacheModeId = "03"; //localStorage
    clsgs_ParagraphStateEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsgs_ParagraphStateEN.WhereFormat = ""; //条件格式串
    clsgs_ParagraphStateEN._CurrTabName = "gs_ParagraphState"; //当前表名,与该类相关的表名
    clsgs_ParagraphStateEN._KeyFldName = "ParagraphStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_ParagraphStateEN.mintAttributeCount = 3;
    clsgs_ParagraphStateEN.AttributeName = ["paragraphStateId", "paragraphStateName", "memo"];
});
