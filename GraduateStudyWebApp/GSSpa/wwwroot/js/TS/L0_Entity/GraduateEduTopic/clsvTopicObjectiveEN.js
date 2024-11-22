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
    exports.clsvTopicObjectiveEN = void 0;
    /**
    * 类名:clsvTopicObjectiveEN
    * 表名:vTopicObjective(01120617)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:51
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
    * 客观表视图(vTopicObjective)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvTopicObjectiveEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.paperTitle = ""; //论文标题
            this.paperContent = ""; //主题内容
            this.author = ""; //作者
            this.keyword = ""; //关键字
            this.topicObjectiveId = ""; //客观Id
            this.objectiveName = ""; //客观名称
            this.objectiveContent = ""; //客观内容
            this.objectiveType = ""; //客观类型
            this.sourceId = ""; //来源Id
            this.conclusion = ""; //结论
            this.isSubmit = false; //是否提交
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.objectiveTypeName = ""; //ObjectiveTypeName
            this.citationCount = 0; //引用统计
            this.appraiseCount = 0; //评论数
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.id_CurrEduCls = ""; //教学班流水号
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.okCount = 0; //点赞统计
            this.versionCount = 0; //版本统计
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
            this.updUser = ""; //修改人
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
                case clsvTopicObjectiveEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvTopicObjectiveEN.con_PaperContent:
                    return this.paperContent;
                case clsvTopicObjectiveEN.con_Author:
                    return this.author;
                case clsvTopicObjectiveEN.con_Keyword:
                    return this.keyword;
                case clsvTopicObjectiveEN.con_TopicObjectiveId:
                    return this.topicObjectiveId;
                case clsvTopicObjectiveEN.con_ObjectiveName:
                    return this.objectiveName;
                case clsvTopicObjectiveEN.con_ObjectiveContent:
                    return this.objectiveContent;
                case clsvTopicObjectiveEN.con_ObjectiveType:
                    return this.objectiveType;
                case clsvTopicObjectiveEN.con_SourceId:
                    return this.sourceId;
                case clsvTopicObjectiveEN.con_Conclusion:
                    return this.conclusion;
                case clsvTopicObjectiveEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvTopicObjectiveEN.con_UpdDate:
                    return this.updDate;
                case clsvTopicObjectiveEN.con_Memo:
                    return this.memo;
                case clsvTopicObjectiveEN.con_ObjectiveTypeName:
                    return this.objectiveTypeName;
                case clsvTopicObjectiveEN.con_CitationCount:
                    return this.citationCount;
                case clsvTopicObjectiveEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvTopicObjectiveEN.con_score:
                    return this.score;
                case clsvTopicObjectiveEN.con_StuScore:
                    return this.stuScore;
                case clsvTopicObjectiveEN.con_TeaScore:
                    return this.teaScore;
                case clsvTopicObjectiveEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvTopicObjectiveEN.con_PdfContent:
                    return this.pdfContent;
                case clsvTopicObjectiveEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsvTopicObjectiveEN.con_OkCount:
                    return this.okCount;
                case clsvTopicObjectiveEN.con_VersionCount:
                    return this.versionCount;
                case clsvTopicObjectiveEN.con_CreateDate:
                    return this.createDate;
                case clsvTopicObjectiveEN.con_ShareId:
                    return this.shareId;
                case clsvTopicObjectiveEN.con_UpdUser:
                    return this.updUser;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vTopicObjective]中不存在！`;
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
                case clsvTopicObjectiveEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvTopicObjectiveEN.con_PaperContent:
                    this.paperContent = strValue;
                    break;
                case clsvTopicObjectiveEN.con_Author:
                    this.author = strValue;
                    break;
                case clsvTopicObjectiveEN.con_Keyword:
                    this.keyword = strValue;
                    break;
                case clsvTopicObjectiveEN.con_TopicObjectiveId:
                    this.topicObjectiveId = strValue;
                    break;
                case clsvTopicObjectiveEN.con_ObjectiveName:
                    this.objectiveName = strValue;
                    break;
                case clsvTopicObjectiveEN.con_ObjectiveContent:
                    this.objectiveContent = strValue;
                    break;
                case clsvTopicObjectiveEN.con_ObjectiveType:
                    this.objectiveType = strValue;
                    break;
                case clsvTopicObjectiveEN.con_SourceId:
                    this.sourceId = strValue;
                    break;
                case clsvTopicObjectiveEN.con_Conclusion:
                    this.conclusion = strValue;
                    break;
                case clsvTopicObjectiveEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvTopicObjectiveEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvTopicObjectiveEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvTopicObjectiveEN.con_ObjectiveTypeName:
                    this.objectiveTypeName = strValue;
                    break;
                case clsvTopicObjectiveEN.con_CitationCount:
                    this.citationCount = Number(strValue);
                    break;
                case clsvTopicObjectiveEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvTopicObjectiveEN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvTopicObjectiveEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvTopicObjectiveEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvTopicObjectiveEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvTopicObjectiveEN.con_PdfContent:
                    this.pdfContent = strValue;
                    break;
                case clsvTopicObjectiveEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    break;
                case clsvTopicObjectiveEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvTopicObjectiveEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvTopicObjectiveEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvTopicObjectiveEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvTopicObjectiveEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vTopicObjective]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
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
        * 常量:"Author"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Author() { return "author"; } //作者
        /**
        * 常量:"Keyword"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Keyword() { return "keyword"; } //关键字
        /**
        * 常量:"TopicObjectiveId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicObjectiveId() { return "topicObjectiveId"; } //客观Id
        /**
        * 常量:"ObjectiveName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveName() { return "objectiveName"; } //客观名称
        /**
        * 常量:"ObjectiveContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveContent() { return "objectiveContent"; } //客观内容
        /**
        * 常量:"ObjectiveType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveType() { return "objectiveType"; } //客观类型
        /**
        * 常量:"SourceId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SourceId() { return "sourceId"; } //来源Id
        /**
        * 常量:"Conclusion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Conclusion() { return "conclusion"; } //结论
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
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
        * 常量:"ObjectiveTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveTypeName() { return "objectiveTypeName"; } //ObjectiveTypeName
        /**
        * 常量:"CitationCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationCount() { return "citationCount"; } //引用统计
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
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
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
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
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
    exports.clsvTopicObjectiveEN = clsvTopicObjectiveEN;
    clsvTopicObjectiveEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvTopicObjectiveEN.CacheModeId = "04"; //sessionStorage
    clsvTopicObjectiveEN._CurrTabName = "vTopicObjective"; //当前表名,与该类相关的表名
    clsvTopicObjectiveEN._KeyFldName = "TopicObjectiveId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvTopicObjectiveEN.mintAttributeCount = 27;
    clsvTopicObjectiveEN.AttributeName = ["paperTitle", "paperContent", "author", "keyword", "topicObjectiveId", "objectiveName", "objectiveContent", "objectiveType", "sourceId", "conclusion", "isSubmit", "updDate", "memo", "objectiveTypeName", "citationCount", "appraiseCount", "score", "stuScore", "teaScore", "id_CurrEduCls", "pdfContent", "pdfPageNum", "okCount", "versionCount", "createDate", "shareId", "updUser"];
});
