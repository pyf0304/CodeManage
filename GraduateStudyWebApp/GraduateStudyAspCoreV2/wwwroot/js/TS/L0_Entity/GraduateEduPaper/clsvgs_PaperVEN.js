(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTabV.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvgs_PaperVerEN = void 0;
    /**
    * 类名:clsvgs_PaperVerEN
    * 表名:vgs_PaperV(01120677)
    * 版本:2023.01.07.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/07 23:13:31
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
    * 论文历史版本视图(vgs_PaperV)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_PaperVerEN extends clsGeneralTabV_js_1.clsGeneralTabV {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
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
            this.literatureTypeName = ""; //作文类型名
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.id_CurrEduCls = ""; //教学班流水号
            this.paperTypeId = ""; //论文类型Id
            this.paperTypeName = ""; //论文类型名
            this.paperStatusId = ""; //论文状态Id
            this.paperStatusName = ""; //论文状态名
            this.memo = ""; //备注
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
                case clsvgs_PaperVerEN.con_PaperVId:
                    return this.paperVId;
                case clsvgs_PaperVerEN.con_PaperId:
                    return this.paperId;
                case clsvgs_PaperVerEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvgs_PaperVerEN.con_PaperContent:
                    return this.paperContent;
                case clsvgs_PaperVerEN.con_Periodical:
                    return this.periodical;
                case clsvgs_PaperVerEN.con_Author:
                    return this.author;
                case clsvgs_PaperVerEN.con_ResearchQuestion:
                    return this.researchQuestion;
                case clsvgs_PaperVerEN.con_Keyword:
                    return this.keyword;
                case clsvgs_PaperVerEN.con_LiteratureSources:
                    return this.literatureSources;
                case clsvgs_PaperVerEN.con_LiteratureLink:
                    return this.literatureLink;
                case clsvgs_PaperVerEN.con_UploadfileUrl:
                    return this.uploadfileUrl;
                case clsvgs_PaperVerEN.con_IsQuotethesis:
                    return this.isQuotethesis;
                case clsvgs_PaperVerEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvgs_PaperVerEN.con_IsChecked:
                    return this.isChecked;
                case clsvgs_PaperVerEN.con_QuoteId:
                    return this.quoteId;
                case clsvgs_PaperVerEN.con_Checker:
                    return this.checker;
                case clsvgs_PaperVerEN.con_LiteratureTypeId:
                    return this.literatureTypeId;
                case clsvgs_PaperVerEN.con_LiteratureTypeName:
                    return this.literatureTypeName;
                case clsvgs_PaperVerEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_PaperVerEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_PaperVerEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvgs_PaperVerEN.con_PaperTypeId:
                    return this.paperTypeId;
                case clsvgs_PaperVerEN.con_PaperTypeName:
                    return this.paperTypeName;
                case clsvgs_PaperVerEN.con_PaperStatusId:
                    return this.paperStatusId;
                case clsvgs_PaperVerEN.con_PaperStatusName:
                    return this.paperStatusName;
                case clsvgs_PaperVerEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_PaperV]中不存在！`;
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
                case clsvgs_PaperVerEN.con_PaperVId:
                    this.paperVId = Number(strValue);
                    break;
                case clsvgs_PaperVerEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvgs_PaperVerEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvgs_PaperVerEN.con_PaperContent:
                    this.paperContent = strValue;
                    break;
                case clsvgs_PaperVerEN.con_Periodical:
                    this.periodical = strValue;
                    break;
                case clsvgs_PaperVerEN.con_Author:
                    this.author = strValue;
                    break;
                case clsvgs_PaperVerEN.con_ResearchQuestion:
                    this.researchQuestion = strValue;
                    break;
                case clsvgs_PaperVerEN.con_Keyword:
                    this.keyword = strValue;
                    break;
                case clsvgs_PaperVerEN.con_LiteratureSources:
                    this.literatureSources = strValue;
                    break;
                case clsvgs_PaperVerEN.con_LiteratureLink:
                    this.literatureLink = strValue;
                    break;
                case clsvgs_PaperVerEN.con_UploadfileUrl:
                    this.uploadfileUrl = strValue;
                    break;
                case clsvgs_PaperVerEN.con_IsQuotethesis:
                    this.isQuotethesis = Boolean(strValue);
                    break;
                case clsvgs_PaperVerEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvgs_PaperVerEN.con_IsChecked:
                    this.isChecked = Boolean(strValue);
                    break;
                case clsvgs_PaperVerEN.con_QuoteId:
                    this.quoteId = strValue;
                    break;
                case clsvgs_PaperVerEN.con_Checker:
                    this.checker = strValue;
                    break;
                case clsvgs_PaperVerEN.con_LiteratureTypeId:
                    this.literatureTypeId = strValue;
                    break;
                case clsvgs_PaperVerEN.con_LiteratureTypeName:
                    this.literatureTypeName = strValue;
                    break;
                case clsvgs_PaperVerEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_PaperVerEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_PaperVerEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvgs_PaperVerEN.con_PaperTypeId:
                    this.paperTypeId = strValue;
                    break;
                case clsvgs_PaperVerEN.con_PaperTypeName:
                    this.paperTypeName = strValue;
                    break;
                case clsvgs_PaperVerEN.con_PaperStatusId:
                    this.paperStatusId = strValue;
                    break;
                case clsvgs_PaperVerEN.con_PaperStatusName:
                    this.paperStatusName = strValue;
                    break;
                case clsvgs_PaperVerEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_PaperV]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"LiteratureTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureTypeName() { return "literatureTypeName"; } //作文类型名
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
        * 常量:"PaperTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTypeName() { return "paperTypeName"; } //论文类型名
        /**
        * 常量:"PaperStatusId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperStatusId() { return "paperStatusId"; } //论文状态Id
        /**
        * 常量:"PaperStatusName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperStatusName() { return "paperStatusName"; } //论文状态名
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
    exports.clsvgs_PaperVerEN = clsvgs_PaperVerEN;
    clsvgs_PaperVerEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_PaperVerEN.CacheModeId = "05"; //未知
    clsvgs_PaperVerEN._CurrTabName = "vgs_PaperV"; //当前表名,与该类相关的表名
    clsvgs_PaperVerEN._KeyFldName = "PaperVId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_PaperVerEN.mintAttributeCount = 26;
    clsvgs_PaperVerEN.AttributeName = ["paperVId", "paperId", "paperTitle", "paperContent", "periodical", "author", "researchQuestion", "keyword", "literatureSources", "literatureLink", "uploadfileUrl", "isQuotethesis", "isSubmit", "isChecked", "quoteId", "checker", "literatureTypeId", "literatureTypeName", "updUser", "updDate", "id_CurrEduCls", "paperTypeId", "paperTypeName", "paperStatusId", "paperStatusName", "memo"];
});
