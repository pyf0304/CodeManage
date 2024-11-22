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
    exports.clsJournalSubjectEN = void 0;
    /**
    * 类名:clsJournalSubjectEN
    * 表名:JournalSubject(01120930)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:49:53
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
    * 期刊学科(JournalSubject)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsJournalSubjectEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrJournalSubjectId = ""; //期刊学科Id
            this.mstrJournalSubjectCode = ""; //期刊学科代码
            this.mstrJournalSubjectName = ""; //期刊学科名称
            this.mstrJournalSubjectCategoryId = ""; //期刊学科门类Id
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.journalSubjectId = ""; //期刊学科Id
            this.journalSubjectCode = ""; //期刊学科代码
            this.journalSubjectName = ""; //期刊学科名称
            this.journalSubjectCategoryId = ""; //期刊学科门类Id
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
        }
        /**
         * 期刊学科Id(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetJournalSubjectId(value) {
            if (value != undefined) {
                this.journalSubjectId = value;
                this.hmProperty["journalSubjectId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 期刊学科代码(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetJournalSubjectCode(value) {
            if (value != undefined) {
                this.journalSubjectCode = value;
                this.hmProperty["journalSubjectCode"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 期刊学科名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetJournalSubjectName(value) {
            if (value != undefined) {
                this.journalSubjectName = value;
                this.hmProperty["journalSubjectName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
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
                case clsJournalSubjectEN.con_JournalSubjectId:
                    return this.journalSubjectId;
                case clsJournalSubjectEN.con_JournalSubjectCode:
                    return this.journalSubjectCode;
                case clsJournalSubjectEN.con_JournalSubjectName:
                    return this.journalSubjectName;
                case clsJournalSubjectEN.con_JournalSubjectCategoryId:
                    return this.journalSubjectCategoryId;
                case clsJournalSubjectEN.con_UpdDate:
                    return this.updDate;
                case clsJournalSubjectEN.con_UpdUser:
                    return this.updUser;
                case clsJournalSubjectEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[JournalSubject]中不存在！`;
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
                case clsJournalSubjectEN.con_JournalSubjectId:
                    this.journalSubjectId = strValue;
                    this.hmProperty["journalSubjectId"] = true;
                    break;
                case clsJournalSubjectEN.con_JournalSubjectCode:
                    this.journalSubjectCode = strValue;
                    this.hmProperty["journalSubjectCode"] = true;
                    break;
                case clsJournalSubjectEN.con_JournalSubjectName:
                    this.journalSubjectName = strValue;
                    this.hmProperty["journalSubjectName"] = true;
                    break;
                case clsJournalSubjectEN.con_JournalSubjectCategoryId:
                    this.journalSubjectCategoryId = strValue;
                    this.hmProperty["journalSubjectCategoryId"] = true;
                    break;
                case clsJournalSubjectEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsJournalSubjectEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsJournalSubjectEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[JournalSubject]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"JournalSubjectId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_JournalSubjectId() { return "journalSubjectId"; } //期刊学科Id
        /**
        * 常量:"JournalSubjectCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_JournalSubjectCode() { return "journalSubjectCode"; } //期刊学科代码
        /**
        * 常量:"JournalSubjectName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_JournalSubjectName() { return "journalSubjectName"; } //期刊学科名称
        /**
        * 常量:"JournalSubjectCategoryId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_JournalSubjectCategoryId() { return "journalSubjectCategoryId"; } //期刊学科门类Id
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
    exports.clsJournalSubjectEN = clsJournalSubjectEN;
    clsJournalSubjectEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsJournalSubjectEN.CacheModeId = "04"; //sessionStorage
    clsJournalSubjectEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsJournalSubjectEN.WhereFormat = ""; //条件格式串
    clsJournalSubjectEN._CurrTabName = "JournalSubject"; //当前表名,与该类相关的表名
    clsJournalSubjectEN._KeyFldName = "JournalSubjectId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsJournalSubjectEN.mintAttributeCount = 7;
    clsJournalSubjectEN.AttributeName = ["journalSubjectId", "journalSubjectCode", "journalSubjectName", "journalSubjectCategoryId", "updDate", "updUser", "memo"];
});
