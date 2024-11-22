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
    exports.clsvViewpointEN = void 0;
    /**
    * 类名:clsvViewpointEN
    * 表名:vViewpoint(01120543)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:45
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * v观点表视图(vViewpoint)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvViewpointEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.viewpointId = ""; //观点Id
            this.viewpointName = ""; //观点名称
            this.viewpointContent = ""; //观点内容
            this.viewpointTypeId = ""; //观点类型Id
            this.viewpointTypeName = ""; //观点类型名
            this.reason = ""; //理由
            this.source = ""; //来源
            this.vpProposePeople = ""; //观点提出人
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.isSubmit = false; //是否提交
            this.appraiseCount = 0; //评论数
            this.score = 0.0; //评分
            this.okCount = 0; //点赞统计
            this.userTypeId = ""; //用户类型Id
            this.userTypeName = ""; //用户类型名称
            this.author = ""; //作者
            this.citationId = ""; //引用Id
            this.keyword = ""; //关键字
            this.paperTitle = ""; //论文标题
            this.periodical = ""; //期刊
            this.researchQuestion = ""; //研究问题
            this.uploadfileUrl = ""; //文件地址
            this.citationCount = 0; //引用统计
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.id_CurrEduCls = ""; //教学班流水号
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.versionCount = 0; //版本统计
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
            this.isRecommend = false; //是否推荐
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
                case clsvViewpointEN.con_ViewpointId:
                    return this.viewpointId;
                case clsvViewpointEN.con_ViewpointName:
                    return this.viewpointName;
                case clsvViewpointEN.con_ViewpointContent:
                    return this.viewpointContent;
                case clsvViewpointEN.con_ViewpointTypeId:
                    return this.viewpointTypeId;
                case clsvViewpointEN.con_ViewpointTypeName:
                    return this.viewpointTypeName;
                case clsvViewpointEN.con_Reason:
                    return this.reason;
                case clsvViewpointEN.con_Source:
                    return this.source;
                case clsvViewpointEN.con_VPProposePeople:
                    return this.vpProposePeople;
                case clsvViewpointEN.con_UpdDate:
                    return this.updDate;
                case clsvViewpointEN.con_UpdUser:
                    return this.updUser;
                case clsvViewpointEN.con_Memo:
                    return this.memo;
                case clsvViewpointEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvViewpointEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvViewpointEN.con_score:
                    return this.score;
                case clsvViewpointEN.con_OkCount:
                    return this.okCount;
                case clsvViewpointEN.con_UserTypeId:
                    return this.userTypeId;
                case clsvViewpointEN.con_UserTypeName:
                    return this.userTypeName;
                case clsvViewpointEN.con_Author:
                    return this.author;
                case clsvViewpointEN.con_CitationId:
                    return this.citationId;
                case clsvViewpointEN.con_Keyword:
                    return this.keyword;
                case clsvViewpointEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvViewpointEN.con_Periodical:
                    return this.periodical;
                case clsvViewpointEN.con_ResearchQuestion:
                    return this.researchQuestion;
                case clsvViewpointEN.con_UploadfileUrl:
                    return this.uploadfileUrl;
                case clsvViewpointEN.con_CitationCount:
                    return this.citationCount;
                case clsvViewpointEN.con_StuScore:
                    return this.stuScore;
                case clsvViewpointEN.con_TeaScore:
                    return this.teaScore;
                case clsvViewpointEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvViewpointEN.con_PdfContent:
                    return this.pdfContent;
                case clsvViewpointEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsvViewpointEN.con_VersionCount:
                    return this.versionCount;
                case clsvViewpointEN.con_CreateDate:
                    return this.createDate;
                case clsvViewpointEN.con_ShareId:
                    return this.shareId;
                case clsvViewpointEN.con_IsRecommend:
                    return this.isRecommend;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vViewpoint]中不存在！`;
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
                case clsvViewpointEN.con_ViewpointId:
                    this.viewpointId = strValue;
                    break;
                case clsvViewpointEN.con_ViewpointName:
                    this.viewpointName = strValue;
                    break;
                case clsvViewpointEN.con_ViewpointContent:
                    this.viewpointContent = strValue;
                    break;
                case clsvViewpointEN.con_ViewpointTypeId:
                    this.viewpointTypeId = strValue;
                    break;
                case clsvViewpointEN.con_ViewpointTypeName:
                    this.viewpointTypeName = strValue;
                    break;
                case clsvViewpointEN.con_Reason:
                    this.reason = strValue;
                    break;
                case clsvViewpointEN.con_Source:
                    this.source = strValue;
                    break;
                case clsvViewpointEN.con_VPProposePeople:
                    this.vpProposePeople = strValue;
                    break;
                case clsvViewpointEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvViewpointEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvViewpointEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvViewpointEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvViewpointEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvViewpointEN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvViewpointEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvViewpointEN.con_UserTypeId:
                    this.userTypeId = strValue;
                    break;
                case clsvViewpointEN.con_UserTypeName:
                    this.userTypeName = strValue;
                    break;
                case clsvViewpointEN.con_Author:
                    this.author = strValue;
                    break;
                case clsvViewpointEN.con_CitationId:
                    this.citationId = strValue;
                    break;
                case clsvViewpointEN.con_Keyword:
                    this.keyword = strValue;
                    break;
                case clsvViewpointEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvViewpointEN.con_Periodical:
                    this.periodical = strValue;
                    break;
                case clsvViewpointEN.con_ResearchQuestion:
                    this.researchQuestion = strValue;
                    break;
                case clsvViewpointEN.con_UploadfileUrl:
                    this.uploadfileUrl = strValue;
                    break;
                case clsvViewpointEN.con_CitationCount:
                    this.citationCount = Number(strValue);
                    break;
                case clsvViewpointEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvViewpointEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvViewpointEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvViewpointEN.con_PdfContent:
                    this.pdfContent = strValue;
                    break;
                case clsvViewpointEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    break;
                case clsvViewpointEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvViewpointEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvViewpointEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvViewpointEN.con_IsRecommend:
                    this.isRecommend = Boolean(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vViewpoint]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ViewpointId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointId() { return "viewpointId"; } //观点Id
        /**
        * 常量:"ViewpointName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointName() { return "viewpointName"; } //观点名称
        /**
        * 常量:"ViewpointContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointContent() { return "viewpointContent"; } //观点内容
        /**
        * 常量:"ViewpointTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointTypeId() { return "viewpointTypeId"; } //观点类型Id
        /**
        * 常量:"ViewpointTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointTypeName() { return "viewpointTypeName"; } //观点类型名
        /**
        * 常量:"Reason"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Reason() { return "reason"; } //理由
        /**
        * 常量:"Source"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Source() { return "source"; } //来源
        /**
        * 常量:"VPProposePeople"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VPProposePeople() { return "vpProposePeople"; } //观点提出人
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
        * 常量:"score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_score() { return "score"; } //评分
        /**
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
        /**
        * 常量:"UserTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserTypeId() { return "userTypeId"; } //用户类型Id
        /**
        * 常量:"UserTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserTypeName() { return "userTypeName"; } //用户类型名称
        /**
        * 常量:"Author"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Author() { return "author"; } //作者
        /**
        * 常量:"CitationId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationId() { return "citationId"; } //引用Id
        /**
        * 常量:"Keyword"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Keyword() { return "keyword"; } //关键字
        /**
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /**
        * 常量:"Periodical"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Periodical() { return "periodical"; } //期刊
        /**
        * 常量:"ResearchQuestion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResearchQuestion() { return "researchQuestion"; } //研究问题
        /**
        * 常量:"UploadfileUrl"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UploadfileUrl() { return "uploadfileUrl"; } //文件地址
        /**
        * 常量:"CitationCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationCount() { return "citationCount"; } //引用统计
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
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"PdfContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfContent() { return "pdfContent"; } //Pdf内容
        /**
        * 常量:"PdfPageNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfPageNum() { return "pdfPageNum"; } //Pdf页码
        /**
        * 常量:"VersionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VersionCount() { return "versionCount"; } //版本统计
        /**
        * 常量:"CreateDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CreateDate() { return "createDate"; } //建立日期
        /**
        * 常量:"ShareId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ShareId() { return "shareId"; } //分享Id
        /**
        * 常量:"IsRecommend"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRecommend() { return "isRecommend"; } //是否推荐
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
    exports.clsvViewpointEN = clsvViewpointEN;
    clsvViewpointEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvViewpointEN.CacheModeId = "04"; //sessionStorage
    clsvViewpointEN._CurrTabName = "vViewpoint"; //当前表名,与该类相关的表名
    clsvViewpointEN._KeyFldName = "ViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvViewpointEN.mintAttributeCount = 34;
    clsvViewpointEN.AttributeName = ["viewpointId", "viewpointName", "viewpointContent", "viewpointTypeId", "viewpointTypeName", "reason", "source", "vpProposePeople", "updDate", "updUser", "memo", "isSubmit", "appraiseCount", "score", "okCount", "userTypeId", "userTypeName", "author", "citationId", "keyword", "paperTitle", "periodical", "researchQuestion", "uploadfileUrl", "citationCount", "stuScore", "teaScore", "id_CurrEduCls", "pdfContent", "pdfPageNum", "versionCount", "createDate", "shareId", "isRecommend"];
});
