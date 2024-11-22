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
    exports.clsvPaperSimEN = void 0;
    /**
    * 类名:clsvPaperSimEN
    * 表名:vPaperSim(01120597)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:34
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:其他(Other)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 论文简化视图(vPaperSim)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvPaperSimEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.paperId = ""; //论文Id
            this.paperTitle = ""; //论文标题
            this.paperContent = ""; //主题内容
            this.periodical = ""; //期刊
            this.author = ""; //作者
            this.researchQuestion = ""; //研究问题
            this.updDate = ""; //修改日期
            this.userName = ""; //用户名
            this.id_XzCollege = ""; //学院流水号
            this.collegeName = ""; //学院名称
            this.id_XzMajor = ""; //专业流水号
            this.majorName = ""; //专业名称
            this.keyword = ""; //关键字
            this.literatureSources = ""; //文献来源
            this.literatureLink = ""; //文献链接
            this.uploadfileUrl = ""; //文件地址
            this.isQuotethesis = false; //是否引用论文
            this.quoteId = ""; //引用Id
            this.checker = ""; //审核人
            this.isChecked = false; //是否检查
            this.literatureTypeId = ""; //作文类型Id
            this.browseNumber = 0; //浏览量
            this.literatureTypeName = ""; //作文类型名
            this.isSubmit = false; //是否提交
            this.appraiseCount = 0; //评论数
            this.attachmentCount = 0; //附件计数
            this.collectionCount = 0; //收藏数
            this.downloadCount = 0; //下载数
            this.memo = ""; //备注
            this.okCount = 0; //点赞统计
            this.pcount = 0; //读写数
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.paperQCount = 0; //论文答疑数
            this.subVCount = 0; //论文子观点数
            this.tagsCount = 0; //论文标注数
            this.teaQCount = 0; //教师提问数
            this.updUser = ""; //修改人
            this.isGSuser = false; //是否GS用户
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
                case clsvPaperSimEN.con_PaperId:
                    return this.paperId;
                case clsvPaperSimEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvPaperSimEN.con_PaperContent:
                    return this.paperContent;
                case clsvPaperSimEN.con_Periodical:
                    return this.periodical;
                case clsvPaperSimEN.con_Author:
                    return this.author;
                case clsvPaperSimEN.con_ResearchQuestion:
                    return this.researchQuestion;
                case clsvPaperSimEN.con_UpdDate:
                    return this.updDate;
                case clsvPaperSimEN.con_UserName:
                    return this.userName;
                case clsvPaperSimEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvPaperSimEN.con_CollegeName:
                    return this.collegeName;
                case clsvPaperSimEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvPaperSimEN.con_MajorName:
                    return this.majorName;
                case clsvPaperSimEN.con_Keyword:
                    return this.keyword;
                case clsvPaperSimEN.con_LiteratureSources:
                    return this.literatureSources;
                case clsvPaperSimEN.con_LiteratureLink:
                    return this.literatureLink;
                case clsvPaperSimEN.con_UploadfileUrl:
                    return this.uploadfileUrl;
                case clsvPaperSimEN.con_IsQuotethesis:
                    return this.isQuotethesis;
                case clsvPaperSimEN.con_QuoteId:
                    return this.quoteId;
                case clsvPaperSimEN.con_Checker:
                    return this.checker;
                case clsvPaperSimEN.con_IsChecked:
                    return this.isChecked;
                case clsvPaperSimEN.con_LiteratureTypeId:
                    return this.literatureTypeId;
                case clsvPaperSimEN.con_BrowseNumber:
                    return this.browseNumber;
                case clsvPaperSimEN.con_LiteratureTypeName:
                    return this.literatureTypeName;
                case clsvPaperSimEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvPaperSimEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvPaperSimEN.con_AttachmentCount:
                    return this.attachmentCount;
                case clsvPaperSimEN.con_CollectionCount:
                    return this.collectionCount;
                case clsvPaperSimEN.con_DownloadCount:
                    return this.downloadCount;
                case clsvPaperSimEN.con_Memo:
                    return this.memo;
                case clsvPaperSimEN.con_OkCount:
                    return this.okCount;
                case clsvPaperSimEN.con_Pcount:
                    return this.pcount;
                case clsvPaperSimEN.con_score:
                    return this.score;
                case clsvPaperSimEN.con_StuScore:
                    return this.stuScore;
                case clsvPaperSimEN.con_TeaScore:
                    return this.teaScore;
                case clsvPaperSimEN.con_PaperQCount:
                    return this.paperQCount;
                case clsvPaperSimEN.con_SubVCount:
                    return this.subVCount;
                case clsvPaperSimEN.con_TagsCount:
                    return this.tagsCount;
                case clsvPaperSimEN.con_TeaQCount:
                    return this.teaQCount;
                case clsvPaperSimEN.con_UpdUser:
                    return this.updUser;
                case clsvPaperSimEN.con_IsGSuser:
                    return this.isGSuser;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperSim]中不存在！`;
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
                case clsvPaperSimEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvPaperSimEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvPaperSimEN.con_PaperContent:
                    this.paperContent = strValue;
                    break;
                case clsvPaperSimEN.con_Periodical:
                    this.periodical = strValue;
                    break;
                case clsvPaperSimEN.con_Author:
                    this.author = strValue;
                    break;
                case clsvPaperSimEN.con_ResearchQuestion:
                    this.researchQuestion = strValue;
                    break;
                case clsvPaperSimEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvPaperSimEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvPaperSimEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvPaperSimEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvPaperSimEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvPaperSimEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvPaperSimEN.con_Keyword:
                    this.keyword = strValue;
                    break;
                case clsvPaperSimEN.con_LiteratureSources:
                    this.literatureSources = strValue;
                    break;
                case clsvPaperSimEN.con_LiteratureLink:
                    this.literatureLink = strValue;
                    break;
                case clsvPaperSimEN.con_UploadfileUrl:
                    this.uploadfileUrl = strValue;
                    break;
                case clsvPaperSimEN.con_IsQuotethesis:
                    this.isQuotethesis = Boolean(strValue);
                    break;
                case clsvPaperSimEN.con_QuoteId:
                    this.quoteId = strValue;
                    break;
                case clsvPaperSimEN.con_Checker:
                    this.checker = strValue;
                    break;
                case clsvPaperSimEN.con_IsChecked:
                    this.isChecked = Boolean(strValue);
                    break;
                case clsvPaperSimEN.con_LiteratureTypeId:
                    this.literatureTypeId = strValue;
                    break;
                case clsvPaperSimEN.con_BrowseNumber:
                    this.browseNumber = Number(strValue);
                    break;
                case clsvPaperSimEN.con_LiteratureTypeName:
                    this.literatureTypeName = strValue;
                    break;
                case clsvPaperSimEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvPaperSimEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvPaperSimEN.con_AttachmentCount:
                    this.attachmentCount = Number(strValue);
                    break;
                case clsvPaperSimEN.con_CollectionCount:
                    this.collectionCount = Number(strValue);
                    break;
                case clsvPaperSimEN.con_DownloadCount:
                    this.downloadCount = Number(strValue);
                    break;
                case clsvPaperSimEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvPaperSimEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvPaperSimEN.con_Pcount:
                    this.pcount = Number(strValue);
                    break;
                case clsvPaperSimEN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvPaperSimEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvPaperSimEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvPaperSimEN.con_PaperQCount:
                    this.paperQCount = Number(strValue);
                    break;
                case clsvPaperSimEN.con_SubVCount:
                    this.subVCount = Number(strValue);
                    break;
                case clsvPaperSimEN.con_TagsCount:
                    this.tagsCount = Number(strValue);
                    break;
                case clsvPaperSimEN.con_TeaQCount:
                    this.teaQCount = Number(strValue);
                    break;
                case clsvPaperSimEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvPaperSimEN.con_IsGSuser:
                    this.isGSuser = Boolean(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperSim]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
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
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"CollegeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName() { return "collegeName"; } //学院名称
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
        /**
        * 常量:"MajorName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorName() { return "majorName"; } //专业名称
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
        * 常量:"IsChecked"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsChecked() { return "isChecked"; } //是否检查
        /**
        * 常量:"LiteratureTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureTypeId() { return "literatureTypeId"; } //作文类型Id
        /**
        * 常量:"BrowseNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BrowseNumber() { return "browseNumber"; } //浏览量
        /**
        * 常量:"LiteratureTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureTypeName() { return "literatureTypeName"; } //作文类型名
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"AppraiseCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AppraiseCount() { return "appraiseCount"; } //评论数
        /**
        * 常量:"AttachmentCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AttachmentCount() { return "attachmentCount"; } //附件计数
        /**
        * 常量:"CollectionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollectionCount() { return "collectionCount"; } //收藏数
        /**
        * 常量:"DownloadCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DownloadCount() { return "downloadCount"; } //下载数
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
        /**
        * 常量:"Pcount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Pcount() { return "pcount"; } //读写数
        /**
        * 常量:"score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_score() { return "score"; } //评分
        /**
        * 常量:"StuScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuScore() { return "stuScore"; } //学生平均分
        /**
        * 常量:"TeaScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeaScore() { return "teaScore"; } //教师评分
        /**
        * 常量:"PaperQCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperQCount() { return "paperQCount"; } //论文答疑数
        /**
        * 常量:"SubVCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubVCount() { return "subVCount"; } //论文子观点数
        /**
        * 常量:"TagsCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TagsCount() { return "tagsCount"; } //论文标注数
        /**
        * 常量:"TeaQCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeaQCount() { return "teaQCount"; } //教师提问数
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"IsGSuser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsGSuser() { return "isGSuser"; } //是否GS用户
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
    exports.clsvPaperSimEN = clsvPaperSimEN;
    clsvPaperSimEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvPaperSimEN.CacheModeId = "04"; //sessionStorage
    clsvPaperSimEN._CurrTabName = "vPaperSim"; //当前表名,与该类相关的表名
    clsvPaperSimEN._KeyFldName = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvPaperSimEN.mintAttributeCount = 40;
    clsvPaperSimEN.AttributeName = ["paperId", "paperTitle", "paperContent", "periodical", "author", "researchQuestion", "updDate", "userName", "id_XzCollege", "collegeName", "id_XzMajor", "majorName", "keyword", "literatureSources", "literatureLink", "uploadfileUrl", "isQuotethesis", "quoteId", "checker", "isChecked", "literatureTypeId", "browseNumber", "literatureTypeName", "isSubmit", "appraiseCount", "attachmentCount", "collectionCount", "downloadCount", "memo", "okCount", "pcount", "score", "stuScore", "teaScore", "paperQCount", "subVCount", "tagsCount", "teaQCount", "updUser", "isGSuser"];
});
