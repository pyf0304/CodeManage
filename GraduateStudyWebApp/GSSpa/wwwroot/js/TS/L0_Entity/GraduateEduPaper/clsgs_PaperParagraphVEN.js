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
    exports.clsgs_PaperParagraphVEN = void 0;
    /**
    * 类名:clsgs_PaperParagraphVEN
    * 表名:gs_PaperParagraphV(01120743)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:39
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
    * 论文段落版本(gs_PaperParagraphV)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_PaperParagraphVEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngParagraphVId = 0; //段落版本Id
            this.mstrParagraphId = ""; //段落Id
            this.mstrSectionId = ""; //节Id
            this.mstrParagraphTypeId = ""; //段落类型Id
            this.mstrParagraphContent = ""; //段落内容
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            this.mstrPaperId = ""; //论文Id
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.paragraphVId = 0; //段落版本Id
            this.paragraphId = ""; //段落Id
            this.sectionId = ""; //节Id
            this.paragraphTypeId = ""; //段落类型Id
            this.paragraphContent = ""; //段落内容
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.paperId = ""; //论文Id
        }
        /**
         * 段落版本Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParagraphVId(value) {
            if (value != undefined) {
                this.paragraphVId = value;
                this.hmProperty["paragraphVId"] = true;
            }
        }
        /**
         * 段落Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParagraphId(value) {
            if (value != undefined) {
                this.paragraphId = value;
                this.hmProperty["paragraphId"] = true;
            }
        }
        /**
         * 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSectionId(value) {
            if (value != undefined) {
                this.sectionId = value;
                this.hmProperty["sectionId"] = true;
            }
        }
        /**
         * 段落类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParagraphTypeId(value) {
            if (value != undefined) {
                this.paragraphTypeId = value;
                this.hmProperty["paragraphTypeId"] = true;
            }
        }
        /**
         * 段落内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParagraphContent(value) {
            if (value != undefined) {
                this.paragraphContent = value;
                this.hmProperty["paragraphContent"] = true;
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
         * 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperId(value) {
            if (value != undefined) {
                this.paperId = value;
                this.hmProperty["paperId"] = true;
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
                case clsgs_PaperParagraphVEN.con_ParagraphVId:
                    return this.paragraphVId;
                case clsgs_PaperParagraphVEN.con_ParagraphId:
                    return this.paragraphId;
                case clsgs_PaperParagraphVEN.con_SectionId:
                    return this.sectionId;
                case clsgs_PaperParagraphVEN.con_ParagraphTypeId:
                    return this.paragraphTypeId;
                case clsgs_PaperParagraphVEN.con_ParagraphContent:
                    return this.paragraphContent;
                case clsgs_PaperParagraphVEN.con_UpdDate:
                    return this.updDate;
                case clsgs_PaperParagraphVEN.con_UpdUser:
                    return this.updUser;
                case clsgs_PaperParagraphVEN.con_Memo:
                    return this.memo;
                case clsgs_PaperParagraphVEN.con_PaperId:
                    return this.paperId;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperParagraphV]中不存在！`;
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
                case clsgs_PaperParagraphVEN.con_ParagraphVId:
                    this.paragraphVId = Number(strValue);
                    this.hmProperty["paragraphVId"] = true;
                    break;
                case clsgs_PaperParagraphVEN.con_ParagraphId:
                    this.paragraphId = strValue;
                    this.hmProperty["paragraphId"] = true;
                    break;
                case clsgs_PaperParagraphVEN.con_SectionId:
                    this.sectionId = strValue;
                    this.hmProperty["sectionId"] = true;
                    break;
                case clsgs_PaperParagraphVEN.con_ParagraphTypeId:
                    this.paragraphTypeId = strValue;
                    this.hmProperty["paragraphTypeId"] = true;
                    break;
                case clsgs_PaperParagraphVEN.con_ParagraphContent:
                    this.paragraphContent = strValue;
                    this.hmProperty["paragraphContent"] = true;
                    break;
                case clsgs_PaperParagraphVEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_PaperParagraphVEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_PaperParagraphVEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_PaperParagraphVEN.con_PaperId:
                    this.paperId = strValue;
                    this.hmProperty["paperId"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperParagraphV]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ParagraphVId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParagraphVId() { return "paragraphVId"; } //段落版本Id
        /**
        * 常量:"ParagraphId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParagraphId() { return "paragraphId"; } //段落Id
        /**
        * 常量:"SectionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionId() { return "sectionId"; } //节Id
        /**
        * 常量:"ParagraphTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParagraphTypeId() { return "paragraphTypeId"; } //段落类型Id
        /**
        * 常量:"ParagraphContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParagraphContent() { return "paragraphContent"; } //段落内容
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
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
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
    exports.clsgs_PaperParagraphVEN = clsgs_PaperParagraphVEN;
    clsgs_PaperParagraphVEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_PaperParagraphVEN.CacheModeId = ""; //
    clsgs_PaperParagraphVEN._CurrTabName = "gs_PaperParagraphV"; //当前表名,与该类相关的表名
    clsgs_PaperParagraphVEN._KeyFldName = "ParagraphVId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_PaperParagraphVEN.mintAttributeCount = 9;
    clsgs_PaperParagraphVEN.AttributeName = ["paragraphVId", "paragraphId", "sectionId", "paragraphTypeId", "paragraphContent", "updDate", "updUser", "memo", "paperId"];
});
