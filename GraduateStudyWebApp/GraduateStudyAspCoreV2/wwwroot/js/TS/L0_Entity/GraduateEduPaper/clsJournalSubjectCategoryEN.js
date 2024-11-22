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
    exports.clsJournalSubjectCategoryEN = void 0;
    /**
    * 类名:clsJournalSubjectCategoryEN
    * 表名:JournalSubjectCategory(01120931)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:49:55
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培论文(GraduateEduPaper)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 期刊学科门类(JournalSubjectCategory)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsJournalSubjectCategoryEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrJournalSubjectCategoryId = ""; //期刊学科门类Id
            this.mstrJournalSubjectCategoryName = ""; //期刊学科门类名称
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.journalSubjectCategoryId = ""; //期刊学科门类Id
            this.journalSubjectCategoryName = ""; //期刊学科门类名称
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
        }
        /**
         * 期刊学科门类Id(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetJournalSubjectCategoryId(value) {
            if (value != undefined) {
                this.journalSubjectCategoryId = value;
                this.hmProperty["journalSubjectCategoryId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 期刊学科门类名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetJournalSubjectCategoryName(value) {
            if (value != undefined) {
                this.journalSubjectCategoryName = value;
                this.hmProperty["journalSubjectCategoryName"] = true;
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
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdUser(value) {
            if (value != undefined) {
                this.updUser = value;
                this.hmProperty["updUser"] = true;
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
                case clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId:
                    return this.journalSubjectCategoryId;
                case clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName:
                    return this.journalSubjectCategoryName;
                case clsJournalSubjectCategoryEN.con_UpdDate:
                    return this.updDate;
                case clsJournalSubjectCategoryEN.con_UpdUser:
                    return this.updUser;
                case clsJournalSubjectCategoryEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[JournalSubjectCategory]中不存在！`;
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
                case clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId:
                    this.journalSubjectCategoryId = strValue;
                    this.hmProperty["journalSubjectCategoryId"] = true;
                    break;
                case clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName:
                    this.journalSubjectCategoryName = strValue;
                    this.hmProperty["journalSubjectCategoryName"] = true;
                    break;
                case clsJournalSubjectCategoryEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsJournalSubjectCategoryEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsJournalSubjectCategoryEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[JournalSubjectCategory]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"JournalSubjectCategoryId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_JournalSubjectCategoryId() { return "journalSubjectCategoryId"; } //期刊学科门类Id
        /**
        * 常量:"JournalSubjectCategoryName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_JournalSubjectCategoryName() { return "journalSubjectCategoryName"; } //期刊学科门类名称
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
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
    exports.clsJournalSubjectCategoryEN = clsJournalSubjectCategoryEN;
    clsJournalSubjectCategoryEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsJournalSubjectCategoryEN.CacheModeId = "04"; //sessionStorage
    clsJournalSubjectCategoryEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsJournalSubjectCategoryEN.WhereFormat = ""; //条件格式串
    clsJournalSubjectCategoryEN._CurrTabName = "JournalSubjectCategory"; //当前表名,与该类相关的表名
    clsJournalSubjectCategoryEN._KeyFldName = "JournalSubjectCategoryId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsJournalSubjectCategoryEN.mintAttributeCount = 5;
    clsJournalSubjectCategoryEN.AttributeName = ["journalSubjectCategoryId", "journalSubjectCategoryName", "updDate", "updUser", "memo"];
});
