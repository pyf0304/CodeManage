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
    exports.clsgs_PaperVerEN = void 0;
    /**
    * 类名:clsgs_PaperVerEN
    * 表名:gs_PaperV(01120678)
    * 版本:2023.01.07.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/07 23:07:50
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
    * 论文历史版本表(gs_PaperV)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_PaperVerEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngPaperVId = 0; //PaperVId
            this.mstrPaperId = ""; //论文Id
            this.mstrPaperTitle = ""; //论文标题
            this.mstrPaperContent = ""; //主题内容
            this.mstrPeriodical = ""; //期刊
            this.mstrAuthor = ""; //作者
            this.mstrResearchQuestion = ""; //研究问题
            this.mstrKeyword = ""; //关键字
            this.mstrLiteratureSources = ""; //文献来源
            this.mstrLiteratureLink = ""; //文献链接
            this.mstrUploadfileUrl = ""; //文件地址
            this.mbolIsQuotethesis = false; //是否引用论文
            this.mbolIsSubmit = false; //是否提交
            this.mbolIsChecked = false; //是否检查
            this.mstrQuoteId = ""; //引用Id
            this.mstrChecker = ""; //审核人
            this.mstrLiteratureTypeId = ""; //作文类型Id
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrPaperTypeId = ""; //论文类型Id
            this.mstrPaperStatusId = ""; //论文状态Id
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.paperVId = 0; //PaperVId
            this.paperId = ""; //论文Id
            this.paperTitle = ""; //论文标题
            this.paperContent = ""; //主题内容
            this.periodical = ""; //期刊
            this.author = ""; //作者
            this.researchQuestion = ""; //研究问题
            this.keyword = ""; //关键字
            this.literatureSources = ""; //文献来源
            this.literatureLink = ""; //文献链接
            this.uploadfileUrl = ""; //文件地址
            this.isQuotethesis = false; //是否引用论文
            this.isSubmit = false; //是否提交
            this.isChecked = false; //是否检查
            this.quoteId = ""; //引用Id
            this.checker = ""; //审核人
            this.literatureTypeId = ""; //作文类型Id
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.id_CurrEduCls = ""; //教学班流水号
            this.paperTypeId = ""; //论文类型Id
            this.paperStatusId = ""; //论文状态Id
            this.memo = ""; //备注
        }
        /**
         * PaperVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperVId(value) {
            if (value != undefined) {
                this.paperVId = value;
                this.hmProperty["paperVId"] = true;
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
         * 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperTitle(value) {
            if (value != undefined) {
                this.paperTitle = value;
                this.hmProperty["paperTitle"] = true;
            }
        }
        /**
         * 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperContent(value) {
            if (value != undefined) {
                this.paperContent = value;
                this.hmProperty["paperContent"] = true;
            }
        }
        /**
         * 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPeriodical(value) {
            if (value != undefined) {
                this.periodical = value;
                this.hmProperty["periodical"] = true;
            }
        }
        /**
         * 作者(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAuthor(value) {
            if (value != undefined) {
                this.author = value;
                this.hmProperty["author"] = true;
            }
        }
        /**
         * 研究问题(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetResearchQuestion(value) {
            if (value != undefined) {
                this.researchQuestion = value;
                this.hmProperty["researchQuestion"] = true;
            }
        }
        /**
         * 关键字(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetKeyword(value) {
            if (value != undefined) {
                this.keyword = value;
                this.hmProperty["keyword"] = true;
            }
        }
        /**
         * 文献来源(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLiteratureSources(value) {
            if (value != undefined) {
                this.literatureSources = value;
                this.hmProperty["literatureSources"] = true;
            }
        }
        /**
         * 文献链接(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLiteratureLink(value) {
            if (value != undefined) {
                this.literatureLink = value;
                this.hmProperty["literatureLink"] = true;
            }
        }
        /**
         * 文件地址(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUploadfileUrl(value) {
            if (value != undefined) {
                this.uploadfileUrl = value;
                this.hmProperty["uploadfileUrl"] = true;
            }
        }
        /**
         * 是否引用论文(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsQuotethesis(value) {
            if (value != undefined) {
                this.isQuotethesis = value;
                this.hmProperty["isQuotethesis"] = true;
            }
        }
        /**
         * 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsSubmit(value) {
            if (value != undefined) {
                this.isSubmit = value;
                this.hmProperty["isSubmit"] = true;
            }
        }
        /**
         * 是否检查(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsChecked(value) {
            if (value != undefined) {
                this.isChecked = value;
                this.hmProperty["isChecked"] = true;
            }
        }
        /**
         * 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuoteId(value) {
            if (value != undefined) {
                this.quoteId = value;
                this.hmProperty["quoteId"] = true;
            }
        }
        /**
         * 审核人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetChecker(value) {
            if (value != undefined) {
                this.checker = value;
                this.hmProperty["checker"] = true;
            }
        }
        /**
         * 作文类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLiteratureTypeId(value) {
            if (value != undefined) {
                this.literatureTypeId = value;
                this.hmProperty["literatureTypeId"] = true;
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
         * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_CurrEduCls(value) {
            if (value != undefined) {
                this.id_CurrEduCls = value;
                this.hmProperty["id_CurrEduCls"] = true;
            }
        }
        /**
         * 论文类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperTypeId(value) {
            if (value != undefined) {
                this.paperTypeId = value;
                this.hmProperty["paperTypeId"] = true;
            }
        }
        /**
         * 论文状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperStatusId(value) {
            if (value != undefined) {
                this.paperStatusId = value;
                this.hmProperty["paperStatusId"] = true;
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
                case clsgs_PaperVerEN.con_PaperVId:
                    return this.paperVId;
                case clsgs_PaperVerEN.con_PaperId:
                    return this.paperId;
                case clsgs_PaperVerEN.con_PaperTitle:
                    return this.paperTitle;
                case clsgs_PaperVerEN.con_PaperContent:
                    return this.paperContent;
                case clsgs_PaperVerEN.con_Periodical:
                    return this.periodical;
                case clsgs_PaperVerEN.con_Author:
                    return this.author;
                case clsgs_PaperVerEN.con_ResearchQuestion:
                    return this.researchQuestion;
                case clsgs_PaperVerEN.con_Keyword:
                    return this.keyword;
                case clsgs_PaperVerEN.con_LiteratureSources:
                    return this.literatureSources;
                case clsgs_PaperVerEN.con_LiteratureLink:
                    return this.literatureLink;
                case clsgs_PaperVerEN.con_UploadfileUrl:
                    return this.uploadfileUrl;
                case clsgs_PaperVerEN.con_IsQuotethesis:
                    return this.isQuotethesis;
                case clsgs_PaperVerEN.con_IsSubmit:
                    return this.isSubmit;
                case clsgs_PaperVerEN.con_IsChecked:
                    return this.isChecked;
                case clsgs_PaperVerEN.con_QuoteId:
                    return this.quoteId;
                case clsgs_PaperVerEN.con_Checker:
                    return this.checker;
                case clsgs_PaperVerEN.con_LiteratureTypeId:
                    return this.literatureTypeId;
                case clsgs_PaperVerEN.con_UpdUser:
                    return this.updUser;
                case clsgs_PaperVerEN.con_UpdDate:
                    return this.updDate;
                case clsgs_PaperVerEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsgs_PaperVerEN.con_PaperTypeId:
                    return this.paperTypeId;
                case clsgs_PaperVerEN.con_PaperStatusId:
                    return this.paperStatusId;
                case clsgs_PaperVerEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperV]中不存在！`;
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
                case clsgs_PaperVerEN.con_PaperVId:
                    this.paperVId = Number(strValue);
                    this.hmProperty["paperVId"] = true;
                    break;
                case clsgs_PaperVerEN.con_PaperId:
                    this.paperId = strValue;
                    this.hmProperty["paperId"] = true;
                    break;
                case clsgs_PaperVerEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    this.hmProperty["paperTitle"] = true;
                    break;
                case clsgs_PaperVerEN.con_PaperContent:
                    this.paperContent = strValue;
                    this.hmProperty["paperContent"] = true;
                    break;
                case clsgs_PaperVerEN.con_Periodical:
                    this.periodical = strValue;
                    this.hmProperty["periodical"] = true;
                    break;
                case clsgs_PaperVerEN.con_Author:
                    this.author = strValue;
                    this.hmProperty["author"] = true;
                    break;
                case clsgs_PaperVerEN.con_ResearchQuestion:
                    this.researchQuestion = strValue;
                    this.hmProperty["researchQuestion"] = true;
                    break;
                case clsgs_PaperVerEN.con_Keyword:
                    this.keyword = strValue;
                    this.hmProperty["keyword"] = true;
                    break;
                case clsgs_PaperVerEN.con_LiteratureSources:
                    this.literatureSources = strValue;
                    this.hmProperty["literatureSources"] = true;
                    break;
                case clsgs_PaperVerEN.con_LiteratureLink:
                    this.literatureLink = strValue;
                    this.hmProperty["literatureLink"] = true;
                    break;
                case clsgs_PaperVerEN.con_UploadfileUrl:
                    this.uploadfileUrl = strValue;
                    this.hmProperty["uploadfileUrl"] = true;
                    break;
                case clsgs_PaperVerEN.con_IsQuotethesis:
                    this.isQuotethesis = Boolean(strValue);
                    this.hmProperty["isQuotethesis"] = true;
                    break;
                case clsgs_PaperVerEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsgs_PaperVerEN.con_IsChecked:
                    this.isChecked = Boolean(strValue);
                    this.hmProperty["isChecked"] = true;
                    break;
                case clsgs_PaperVerEN.con_QuoteId:
                    this.quoteId = strValue;
                    this.hmProperty["quoteId"] = true;
                    break;
                case clsgs_PaperVerEN.con_Checker:
                    this.checker = strValue;
                    this.hmProperty["checker"] = true;
                    break;
                case clsgs_PaperVerEN.con_LiteratureTypeId:
                    this.literatureTypeId = strValue;
                    this.hmProperty["literatureTypeId"] = true;
                    break;
                case clsgs_PaperVerEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_PaperVerEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_PaperVerEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsgs_PaperVerEN.con_PaperTypeId:
                    this.paperTypeId = strValue;
                    this.hmProperty["paperTypeId"] = true;
                    break;
                case clsgs_PaperVerEN.con_PaperStatusId:
                    this.paperStatusId = strValue;
                    this.hmProperty["paperStatusId"] = true;
                    break;
                case clsgs_PaperVerEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperV]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"PaperVId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperVId() { return "paperVId"; } //PaperVId
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /**
        * 常量:"PaperContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperContent() { return "paperContent"; } //主题内容
        /**
        * 常量:"Periodical"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Periodical() { return "periodical"; } //期刊
        /**
        * 常量:"Author"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Author() { return "author"; } //作者
        /**
        * 常量:"ResearchQuestion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResearchQuestion() { return "researchQuestion"; } //研究问题
        /**
        * 常量:"Keyword"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Keyword() { return "keyword"; } //关键字
        /**
        * 常量:"LiteratureSources"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureSources() { return "literatureSources"; } //文献来源
        /**
        * 常量:"LiteratureLink"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureLink() { return "literatureLink"; } //文献链接
        /**
        * 常量:"UploadfileUrl"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UploadfileUrl() { return "uploadfileUrl"; } //文件地址
        /**
        * 常量:"IsQuotethesis"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsQuotethesis() { return "isQuotethesis"; } //是否引用论文
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"IsChecked"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsChecked() { return "isChecked"; } //是否检查
        /**
        * 常量:"QuoteId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuoteId() { return "quoteId"; } //引用Id
        /**
        * 常量:"Checker"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Checker() { return "checker"; } //审核人
        /**
        * 常量:"LiteratureTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureTypeId() { return "literatureTypeId"; } //作文类型Id
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
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"PaperTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTypeId() { return "paperTypeId"; } //论文类型Id
        /**
        * 常量:"PaperStatusId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperStatusId() { return "paperStatusId"; } //论文状态Id
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
    exports.clsgs_PaperVerEN = clsgs_PaperVerEN;
    clsgs_PaperVerEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_PaperVerEN.CacheModeId = "05"; //未知
    clsgs_PaperVerEN._CurrTabName = "gs_PaperV"; //当前表名,与该类相关的表名
    clsgs_PaperVerEN._KeyFldName = "PaperVId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_PaperVerEN.mintAttributeCount = 23;
    clsgs_PaperVerEN.AttributeName = ["paperVId", "paperId", "paperTitle", "paperContent", "periodical", "author", "researchQuestion", "keyword", "literatureSources", "literatureLink", "uploadfileUrl", "isQuotethesis", "isSubmit", "isChecked", "quoteId", "checker", "literatureTypeId", "updUser", "updDate", "id_CurrEduCls", "paperTypeId", "paperStatusId", "memo"];
});
